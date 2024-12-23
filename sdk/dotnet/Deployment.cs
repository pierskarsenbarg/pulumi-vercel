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
    [VercelResourceType("vercel:index/deployment:Deployment")]
    public partial class Deployment : global::Pulumi.CustomResource
    {
        [Output("deleteOnDestroy")]
        public Output<bool?> DeleteOnDestroy { get; private set; } = null!;

        /// <summary>
        /// A list of all the domains (default domains, staging domains and production domains) that were assigned upon deployment
        /// creation.
        /// </summary>
        [Output("domains")]
        public Output<ImmutableArray<string>> Domains { get; private set; } = null!;

        /// <summary>
        /// A map of environment variable names to values. These are specific to a Deployment, and can also be configured on the
        /// `vercel.Project` resource.
        /// </summary>
        [Output("environment")]
        public Output<ImmutableDictionary<string, string>?> Environment { get; private set; } = null!;

        /// <summary>
        /// A map of files to be uploaded for the deployment. This should be provided by a `vercel.getProjectDirectory` or
        /// `vercel.getFile` data source. Required if `git_source` is not set.
        /// </summary>
        [Output("files")]
        public Output<ImmutableDictionary<string, string>?> Files { get; private set; } = null!;

        /// <summary>
        /// If specified then the `path_prefix` will be stripped from the start of file paths as they are uploaded to Vercel. If
        /// this is omitted, then any leading `../`s will be stripped.
        /// </summary>
        [Output("pathPrefix")]
        public Output<string?> PathPrefix { get; private set; } = null!;

        /// <summary>
        /// true if the deployment is a production deployment, meaning production aliases will be assigned.
        /// </summary>
        [Output("production")]
        public Output<bool> Production { get; private set; } = null!;

        /// <summary>
        /// The project ID to add the deployment to.
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// Project settings that will be applied to the deployment.
        /// </summary>
        [Output("projectSettings")]
        public Output<Outputs.DeploymentProjectSettings?> ProjectSettings { get; private set; } = null!;

        /// <summary>
        /// The branch or commit hash that should be deployed. Note this will only work if the project is configured to use a Git
        /// repository. Required if `files` is not set.
        /// </summary>
        [Output("ref")]
        public Output<string?> Ref { get; private set; } = null!;

        /// <summary>
        /// The team ID to add the deployment to. Required when configuring a team resource if a default team has not been set in
        /// the provider.
        /// </summary>
        [Output("teamId")]
        public Output<string> TeamId { get; private set; } = null!;

        /// <summary>
        /// A unique URL that is automatically generated for a deployment.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a Deployment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Deployment(string name, DeploymentArgs args, CustomResourceOptions? options = null)
            : base("vercel:index/deployment:Deployment", name, args ?? new DeploymentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Deployment(string name, Input<string> id, DeploymentState? state = null, CustomResourceOptions? options = null)
            : base("vercel:index/deployment:Deployment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Deployment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Deployment Get(string name, Input<string> id, DeploymentState? state = null, CustomResourceOptions? options = null)
        {
            return new Deployment(name, id, state, options);
        }
    }

    public sealed class DeploymentArgs : global::Pulumi.ResourceArgs
    {
        [Input("deleteOnDestroy")]
        public Input<bool>? DeleteOnDestroy { get; set; }

        [Input("environment")]
        private InputMap<string>? _environment;

        /// <summary>
        /// A map of environment variable names to values. These are specific to a Deployment, and can also be configured on the
        /// `vercel.Project` resource.
        /// </summary>
        public InputMap<string> Environment
        {
            get => _environment ?? (_environment = new InputMap<string>());
            set => _environment = value;
        }

        [Input("files")]
        private InputMap<string>? _files;

        /// <summary>
        /// A map of files to be uploaded for the deployment. This should be provided by a `vercel.getProjectDirectory` or
        /// `vercel.getFile` data source. Required if `git_source` is not set.
        /// </summary>
        public InputMap<string> Files
        {
            get => _files ?? (_files = new InputMap<string>());
            set => _files = value;
        }

        /// <summary>
        /// If specified then the `path_prefix` will be stripped from the start of file paths as they are uploaded to Vercel. If
        /// this is omitted, then any leading `../`s will be stripped.
        /// </summary>
        [Input("pathPrefix")]
        public Input<string>? PathPrefix { get; set; }

        /// <summary>
        /// true if the deployment is a production deployment, meaning production aliases will be assigned.
        /// </summary>
        [Input("production")]
        public Input<bool>? Production { get; set; }

        /// <summary>
        /// The project ID to add the deployment to.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// Project settings that will be applied to the deployment.
        /// </summary>
        [Input("projectSettings")]
        public Input<Inputs.DeploymentProjectSettingsArgs>? ProjectSettings { get; set; }

        /// <summary>
        /// The branch or commit hash that should be deployed. Note this will only work if the project is configured to use a Git
        /// repository. Required if `files` is not set.
        /// </summary>
        [Input("ref")]
        public Input<string>? Ref { get; set; }

        /// <summary>
        /// The team ID to add the deployment to. Required when configuring a team resource if a default team has not been set in
        /// the provider.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        public DeploymentArgs()
        {
        }
        public static new DeploymentArgs Empty => new DeploymentArgs();
    }

    public sealed class DeploymentState : global::Pulumi.ResourceArgs
    {
        [Input("deleteOnDestroy")]
        public Input<bool>? DeleteOnDestroy { get; set; }

        [Input("domains")]
        private InputList<string>? _domains;

        /// <summary>
        /// A list of all the domains (default domains, staging domains and production domains) that were assigned upon deployment
        /// creation.
        /// </summary>
        public InputList<string> Domains
        {
            get => _domains ?? (_domains = new InputList<string>());
            set => _domains = value;
        }

        [Input("environment")]
        private InputMap<string>? _environment;

        /// <summary>
        /// A map of environment variable names to values. These are specific to a Deployment, and can also be configured on the
        /// `vercel.Project` resource.
        /// </summary>
        public InputMap<string> Environment
        {
            get => _environment ?? (_environment = new InputMap<string>());
            set => _environment = value;
        }

        [Input("files")]
        private InputMap<string>? _files;

        /// <summary>
        /// A map of files to be uploaded for the deployment. This should be provided by a `vercel.getProjectDirectory` or
        /// `vercel.getFile` data source. Required if `git_source` is not set.
        /// </summary>
        public InputMap<string> Files
        {
            get => _files ?? (_files = new InputMap<string>());
            set => _files = value;
        }

        /// <summary>
        /// If specified then the `path_prefix` will be stripped from the start of file paths as they are uploaded to Vercel. If
        /// this is omitted, then any leading `../`s will be stripped.
        /// </summary>
        [Input("pathPrefix")]
        public Input<string>? PathPrefix { get; set; }

        /// <summary>
        /// true if the deployment is a production deployment, meaning production aliases will be assigned.
        /// </summary>
        [Input("production")]
        public Input<bool>? Production { get; set; }

        /// <summary>
        /// The project ID to add the deployment to.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// Project settings that will be applied to the deployment.
        /// </summary>
        [Input("projectSettings")]
        public Input<Inputs.DeploymentProjectSettingsGetArgs>? ProjectSettings { get; set; }

        /// <summary>
        /// The branch or commit hash that should be deployed. Note this will only work if the project is configured to use a Git
        /// repository. Required if `files` is not set.
        /// </summary>
        [Input("ref")]
        public Input<string>? Ref { get; set; }

        /// <summary>
        /// The team ID to add the deployment to. Required when configuring a team resource if a default team has not been set in
        /// the provider.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        /// <summary>
        /// A unique URL that is automatically generated for a deployment.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public DeploymentState()
        {
        }
        public static new DeploymentState Empty => new DeploymentState();
    }
}
