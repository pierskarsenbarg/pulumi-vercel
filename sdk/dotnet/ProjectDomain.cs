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
    /// <summary>
    /// Provides a Project Domain resource.
    /// 
    /// A Project Domain is used to associate a domain name with a `vercel.Project`.
    /// 
    /// By default, Project Domains will be automatically applied to any `production` deployments.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Vercel = Pulumiverse.Vercel;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var exampleProject = new Vercel.Project("exampleProject");
    /// 
    ///     // A simple domain that will be automatically
    ///     // applied to each production deployment
    ///     var exampleProjectDomain = new Vercel.ProjectDomain("exampleProjectDomain", new()
    ///     {
    ///         ProjectId = exampleProject.Id,
    ///         Domain = "i-love.vercel.app",
    ///     });
    /// 
    ///     // A redirect of a domain name to a second domain name.
    ///     // The status_code can optionally be controlled.
    ///     var exampleRedirect = new Vercel.ProjectDomain("exampleRedirect", new()
    ///     {
    ///         ProjectId = exampleProject.Id,
    ///         Domain = "i-also-love.vercel.app",
    ///         Redirect = exampleProjectDomain.Domain,
    ///         RedirectStatusCode = 307,
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// If importing into a personal account, or with a team configured on the provider, simply use the project ID and domain. - project_id can be found in the project `settings` tab in the Vercel UI.
    /// 
    /// ```sh
    ///  $ pulumi import vercel:index/projectDomain:ProjectDomain example prj_xxxxxxxxxxxxxxxxxxxxxxxxxxxx/example.com
    /// ```
    /// 
    ///  Alternatively, you can import via the team_id, project_id and domain name. - team_id can be found in the team `settings` tab in the Vercel UI. - project_id can be found in the project `settings` tab in the Vercel UI.
    /// 
    /// ```sh
    ///  $ pulumi import vercel:index/projectDomain:ProjectDomain example team_xxxxxxxxxxxxxxxxxxxxxxxx/prj_xxxxxxxxxxxxxxxxxxxxxxxxxxxx/example.com
    /// ```
    /// </summary>
    [VercelResourceType("vercel:index/projectDomain:ProjectDomain")]
    public partial class ProjectDomain : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The domain name to associate with the project.
        /// </summary>
        [Output("domain")]
        public Output<string> Domain { get; private set; } = null!;

        /// <summary>
        /// Git branch to link to the project domain. Deployments from this git branch will be assigned the domain name.
        /// </summary>
        [Output("gitBranch")]
        public Output<string?> GitBranch { get; private set; } = null!;

        /// <summary>
        /// The project ID to add the deployment to.
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// The domain name that serves as a target destination for redirects.
        /// </summary>
        [Output("redirect")]
        public Output<string?> Redirect { get; private set; } = null!;

        /// <summary>
        /// The HTTP status code to use when serving as a redirect.
        /// </summary>
        [Output("redirectStatusCode")]
        public Output<int?> RedirectStatusCode { get; private set; } = null!;

        /// <summary>
        /// The ID of the team the project exists under. Required when configuring a team resource if a default team has not been set in the provider.
        /// </summary>
        [Output("teamId")]
        public Output<string> TeamId { get; private set; } = null!;


        /// <summary>
        /// Create a ProjectDomain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProjectDomain(string name, ProjectDomainArgs args, CustomResourceOptions? options = null)
            : base("vercel:index/projectDomain:ProjectDomain", name, args ?? new ProjectDomainArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProjectDomain(string name, Input<string> id, ProjectDomainState? state = null, CustomResourceOptions? options = null)
            : base("vercel:index/projectDomain:ProjectDomain", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ProjectDomain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProjectDomain Get(string name, Input<string> id, ProjectDomainState? state = null, CustomResourceOptions? options = null)
        {
            return new ProjectDomain(name, id, state, options);
        }
    }

    public sealed class ProjectDomainArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The domain name to associate with the project.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// Git branch to link to the project domain. Deployments from this git branch will be assigned the domain name.
        /// </summary>
        [Input("gitBranch")]
        public Input<string>? GitBranch { get; set; }

        /// <summary>
        /// The project ID to add the deployment to.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// The domain name that serves as a target destination for redirects.
        /// </summary>
        [Input("redirect")]
        public Input<string>? Redirect { get; set; }

        /// <summary>
        /// The HTTP status code to use when serving as a redirect.
        /// </summary>
        [Input("redirectStatusCode")]
        public Input<int>? RedirectStatusCode { get; set; }

        /// <summary>
        /// The ID of the team the project exists under. Required when configuring a team resource if a default team has not been set in the provider.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        public ProjectDomainArgs()
        {
        }
        public static new ProjectDomainArgs Empty => new ProjectDomainArgs();
    }

    public sealed class ProjectDomainState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The domain name to associate with the project.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// Git branch to link to the project domain. Deployments from this git branch will be assigned the domain name.
        /// </summary>
        [Input("gitBranch")]
        public Input<string>? GitBranch { get; set; }

        /// <summary>
        /// The project ID to add the deployment to.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// The domain name that serves as a target destination for redirects.
        /// </summary>
        [Input("redirect")]
        public Input<string>? Redirect { get; set; }

        /// <summary>
        /// The HTTP status code to use when serving as a redirect.
        /// </summary>
        [Input("redirectStatusCode")]
        public Input<int>? RedirectStatusCode { get; set; }

        /// <summary>
        /// The ID of the team the project exists under. Required when configuring a team resource if a default team has not been set in the provider.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        public ProjectDomainState()
        {
        }
        public static new ProjectDomainState Empty => new ProjectDomainState();
    }
}
