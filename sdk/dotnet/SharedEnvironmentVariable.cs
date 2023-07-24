// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Vercel
{
    [VercelResourceType("vercel:index/sharedEnvironmentVariable:SharedEnvironmentVariable")]
    public partial class SharedEnvironmentVariable : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Environment Variable.
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// The ID of the Vercel project.
        /// </summary>
        [Output("projectIds")]
        public Output<ImmutableArray<string>> ProjectIds { get; private set; } = null!;

        /// <summary>
        /// The environments that the Environment Variable should be present on. Valid targets are either `production`, `preview`,
        /// or `development`.
        /// </summary>
        [Output("targets")]
        public Output<ImmutableArray<string>> Targets { get; private set; } = null!;

        /// <summary>
        /// The ID of the Vercel team. Shared environment variables require a team.
        /// </summary>
        [Output("teamId")]
        public Output<string> TeamId { get; private set; } = null!;

        /// <summary>
        /// The value of the Environment Variable.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a SharedEnvironmentVariable resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SharedEnvironmentVariable(string name, SharedEnvironmentVariableArgs args, CustomResourceOptions? options = null)
            : base("vercel:index/sharedEnvironmentVariable:SharedEnvironmentVariable", name, args ?? new SharedEnvironmentVariableArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SharedEnvironmentVariable(string name, Input<string> id, SharedEnvironmentVariableState? state = null, CustomResourceOptions? options = null)
            : base("vercel:index/sharedEnvironmentVariable:SharedEnvironmentVariable", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "value",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SharedEnvironmentVariable resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SharedEnvironmentVariable Get(string name, Input<string> id, SharedEnvironmentVariableState? state = null, CustomResourceOptions? options = null)
        {
            return new SharedEnvironmentVariable(name, id, state, options);
        }
    }

    public sealed class SharedEnvironmentVariableArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Environment Variable.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("projectIds", required: true)]
        private InputList<string>? _projectIds;

        /// <summary>
        /// The ID of the Vercel project.
        /// </summary>
        public InputList<string> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new InputList<string>());
            set => _projectIds = value;
        }

        [Input("targets", required: true)]
        private InputList<string>? _targets;

        /// <summary>
        /// The environments that the Environment Variable should be present on. Valid targets are either `production`, `preview`,
        /// or `development`.
        /// </summary>
        public InputList<string> Targets
        {
            get => _targets ?? (_targets = new InputList<string>());
            set => _targets = value;
        }

        /// <summary>
        /// The ID of the Vercel team. Shared environment variables require a team.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        [Input("value", required: true)]
        private Input<string>? _value;

        /// <summary>
        /// The value of the Environment Variable.
        /// </summary>
        public Input<string>? Value
        {
            get => _value;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _value = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public SharedEnvironmentVariableArgs()
        {
        }
        public static new SharedEnvironmentVariableArgs Empty => new SharedEnvironmentVariableArgs();
    }

    public sealed class SharedEnvironmentVariableState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Environment Variable.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("projectIds")]
        private InputList<string>? _projectIds;

        /// <summary>
        /// The ID of the Vercel project.
        /// </summary>
        public InputList<string> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new InputList<string>());
            set => _projectIds = value;
        }

        [Input("targets")]
        private InputList<string>? _targets;

        /// <summary>
        /// The environments that the Environment Variable should be present on. Valid targets are either `production`, `preview`,
        /// or `development`.
        /// </summary>
        public InputList<string> Targets
        {
            get => _targets ?? (_targets = new InputList<string>());
            set => _targets = value;
        }

        /// <summary>
        /// The ID of the Vercel team. Shared environment variables require a team.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        [Input("value")]
        private Input<string>? _value;

        /// <summary>
        /// The value of the Environment Variable.
        /// </summary>
        public Input<string>? Value
        {
            get => _value;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _value = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public SharedEnvironmentVariableState()
        {
        }
        public static new SharedEnvironmentVariableState Empty => new SharedEnvironmentVariableState();
    }
}