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
    public static class GetAccessGroupProject
    {
        public static Task<GetAccessGroupProjectResult> InvokeAsync(GetAccessGroupProjectArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAccessGroupProjectResult>("vercel:index/getAccessGroupProject:getAccessGroupProject", args ?? new GetAccessGroupProjectArgs(), options.WithDefaults());

        public static Output<GetAccessGroupProjectResult> Invoke(GetAccessGroupProjectInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAccessGroupProjectResult>("vercel:index/getAccessGroupProject:getAccessGroupProject", args ?? new GetAccessGroupProjectInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAccessGroupProjectArgs : global::Pulumi.InvokeArgs
    {
        [Input("accessGroupId", required: true)]
        public string AccessGroupId { get; set; } = null!;

        [Input("projectId", required: true)]
        public string ProjectId { get; set; } = null!;

        [Input("teamId")]
        public string? TeamId { get; set; }

        public GetAccessGroupProjectArgs()
        {
        }
        public static new GetAccessGroupProjectArgs Empty => new GetAccessGroupProjectArgs();
    }

    public sealed class GetAccessGroupProjectInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("accessGroupId", required: true)]
        public Input<string> AccessGroupId { get; set; } = null!;

        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        public GetAccessGroupProjectInvokeArgs()
        {
        }
        public static new GetAccessGroupProjectInvokeArgs Empty => new GetAccessGroupProjectInvokeArgs();
    }


    [OutputType]
    public sealed class GetAccessGroupProjectResult
    {
        public readonly string AccessGroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string ProjectId;
        public readonly string Role;
        public readonly string TeamId;

        [OutputConstructor]
        private GetAccessGroupProjectResult(
            string accessGroupId,

            string id,

            string projectId,

            string role,

            string teamId)
        {
            AccessGroupId = accessGroupId;
            Id = id;
            ProjectId = projectId;
            Role = role;
            TeamId = teamId;
        }
    }
}