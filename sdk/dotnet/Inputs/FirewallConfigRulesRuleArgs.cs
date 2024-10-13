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

    public sealed class FirewallConfigRulesRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Actions to take when the condition groups match a request
        /// </summary>
        [Input("action", required: true)]
        public Input<Inputs.FirewallConfigRulesRuleActionArgs> Action { get; set; } = null!;

        /// <summary>
        /// Rule is active or disabled
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("conditionGroups", required: true)]
        private InputList<Inputs.FirewallConfigRulesRuleConditionGroupArgs>? _conditionGroups;

        /// <summary>
        /// Sets of conditions that may match a request
        /// </summary>
        public InputList<Inputs.FirewallConfigRulesRuleConditionGroupArgs> ConditionGroups
        {
            get => _conditionGroups ?? (_conditionGroups = new InputList<Inputs.FirewallConfigRulesRuleConditionGroupArgs>());
            set => _conditionGroups = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name to identify the rule
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public FirewallConfigRulesRuleArgs()
        {
        }
        public static new FirewallConfigRulesRuleArgs Empty => new FirewallConfigRulesRuleArgs();
    }
}