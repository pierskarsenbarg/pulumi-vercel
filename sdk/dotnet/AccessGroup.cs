// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Vercel
{
    [VercelResourceType("vercel:index/accessGroup:AccessGroup")]
    public partial class AccessGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Access Group
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the team the Access Group should exist under. Required when configuring a team resource if a default team has
        /// not been set in the provider.
        /// </summary>
        [Output("teamId")]
        public Output<string> TeamId { get; private set; } = null!;


        /// <summary>
        /// Create a AccessGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccessGroup(string name, AccessGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("vercel:index/accessGroup:AccessGroup", name, args ?? new AccessGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccessGroup(string name, Input<string> id, AccessGroupState? state = null, CustomResourceOptions? options = null)
            : base("vercel:index/accessGroup:AccessGroup", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AccessGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccessGroup Get(string name, Input<string> id, AccessGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new AccessGroup(name, id, state, options);
        }
    }

    public sealed class AccessGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Access Group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the team the Access Group should exist under. Required when configuring a team resource if a default team has
        /// not been set in the provider.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        public AccessGroupArgs()
        {
        }
        public static new AccessGroupArgs Empty => new AccessGroupArgs();
    }

    public sealed class AccessGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Access Group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the team the Access Group should exist under. Required when configuring a team resource if a default team has
        /// not been set in the provider.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        public AccessGroupState()
        {
        }
        public static new AccessGroupState Empty => new AccessGroupState();
    }
}