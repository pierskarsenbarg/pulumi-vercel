// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Vercel.Inputs
{

    public sealed class FirewallConfigManagedRulesetsOwaspJavaArgs : global::Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("active")]
        public Input<bool>? Active { get; set; }

        public FirewallConfigManagedRulesetsOwaspJavaArgs()
        {
        }
        public static new FirewallConfigManagedRulesetsOwaspJavaArgs Empty => new FirewallConfigManagedRulesetsOwaspJavaArgs();
    }
}