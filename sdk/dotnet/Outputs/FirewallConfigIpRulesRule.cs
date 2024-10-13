// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Vercel.Outputs
{

    [OutputType]
    public sealed class FirewallConfigIpRulesRule
    {
        public readonly string Action;
        /// <summary>
        /// Hosts to apply these rules to
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// IP or CIDR to block
        /// </summary>
        public readonly string Ip;
        public readonly string? Notes;

        [OutputConstructor]
        private FirewallConfigIpRulesRule(
            string action,

            string hostname,

            string? id,

            string ip,

            string? notes)
        {
            Action = action;
            Hostname = hostname;
            Id = id;
            Ip = ip;
            Notes = notes;
        }
    }
}