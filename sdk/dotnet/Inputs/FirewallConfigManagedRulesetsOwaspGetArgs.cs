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

    public sealed class FirewallConfigManagedRulesetsOwaspGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Generic Attack Detection
        /// </summary>
        [Input("gen")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspGenGetArgs>? Gen { get; set; }

        /// <summary>
        /// Java Attack Detection
        /// </summary>
        [Input("java")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspJavaGetArgs>? Java { get; set; }

        /// <summary>
        /// Local File Inclusion Rules
        /// </summary>
        [Input("lfi")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspLfiGetArgs>? Lfi { get; set; }

        /// <summary>
        /// Multipart Rules
        /// </summary>
        [Input("ma")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspMaGetArgs>? Ma { get; set; }

        /// <summary>
        /// PHP Attack Detection
        /// </summary>
        [Input("php")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspPhpGetArgs>? Php { get; set; }

        /// <summary>
        /// Remote Code Execution Rules
        /// </summary>
        [Input("rce")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspRceGetArgs>? Rce { get; set; }

        /// <summary>
        /// Remote File Inclusion Rules
        /// </summary>
        [Input("rfi")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspRfiGetArgs>? Rfi { get; set; }

        /// <summary>
        /// Scanner Detection Rules
        /// </summary>
        [Input("sd")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspSdGetArgs>? Sd { get; set; }

        /// <summary>
        /// SQL Injection Rules
        /// </summary>
        [Input("sqli")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspSqliGetArgs>? Sqli { get; set; }

        /// <summary>
        /// Cross Site Scripting Rules
        /// </summary>
        [Input("xss")]
        public Input<Inputs.FirewallConfigManagedRulesetsOwaspXssGetArgs>? Xss { get; set; }

        public FirewallConfigManagedRulesetsOwaspGetArgs()
        {
        }
        public static new FirewallConfigManagedRulesetsOwaspGetArgs Empty => new FirewallConfigManagedRulesetsOwaspGetArgs();
    }
}