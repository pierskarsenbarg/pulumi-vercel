// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * An Edge Config Schema provides an existing Edge Config with a JSON schema. Use schema protection to prevent unexpected updates that may cause bugs or downtime.
 *
 * ## Import
 *
 * If importing into a personal account, or with a team configured on
 *
 * the provider, simply use the edge config id.
 *
 * - edge_config_id can be found by navigating to the Edge Config in the Vercel UI. It should begin with `ecfg_`.
 *
 * ```sh
 * $ pulumi import vercel:index/edgeConfigSchema:EdgeConfigSchema example ecfg_xxxxxxxxxxxxxxxxxxxxxxxxxxxx
 * ```
 *
 * Alternatively, you can import via the team_id and edge_config_id.
 *
 * - team_id can be found in the team `settings` tab in the Vercel UI.
 *
 * - edge_config_id can be found by navigating to the Edge Config in the Vercel UI. It should begin with `ecfg_`.
 *
 * ```sh
 * $ pulumi import vercel:index/edgeConfigSchema:EdgeConfigSchema example team_xxxxxxxxxxxxxxxxxxxxxxxx/ecfg_xxxxxxxxxxxxxxxxxxxxxxxxxxxx
 * ```
 */
export class EdgeConfigSchema extends pulumi.CustomResource {
    /**
     * Get an existing EdgeConfigSchema resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EdgeConfigSchemaState, opts?: pulumi.CustomResourceOptions): EdgeConfigSchema {
        return new EdgeConfigSchema(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'vercel:index/edgeConfigSchema:EdgeConfigSchema';

    /**
     * Returns true if the given object is an instance of EdgeConfigSchema.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EdgeConfigSchema {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EdgeConfigSchema.__pulumiType;
    }

    /**
     * A JSON schema that will be used to validate data in the Edge Config.
     */
    public readonly definition!: pulumi.Output<string>;
    /**
     * The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
     */
    public readonly teamId!: pulumi.Output<string>;

    /**
     * Create a EdgeConfigSchema resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EdgeConfigSchemaArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EdgeConfigSchemaArgs | EdgeConfigSchemaState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as EdgeConfigSchemaState | undefined;
            resourceInputs["definition"] = state ? state.definition : undefined;
            resourceInputs["teamId"] = state ? state.teamId : undefined;
        } else {
            const args = argsOrState as EdgeConfigSchemaArgs | undefined;
            if ((!args || args.definition === undefined) && !opts.urn) {
                throw new Error("Missing required property 'definition'");
            }
            resourceInputs["definition"] = args ? args.definition : undefined;
            resourceInputs["teamId"] = args ? args.teamId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(EdgeConfigSchema.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EdgeConfigSchema resources.
 */
export interface EdgeConfigSchemaState {
    /**
     * A JSON schema that will be used to validate data in the Edge Config.
     */
    definition?: pulumi.Input<string>;
    /**
     * The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
     */
    teamId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a EdgeConfigSchema resource.
 */
export interface EdgeConfigSchemaArgs {
    /**
     * A JSON schema that will be used to validate data in the Edge Config.
     */
    definition: pulumi.Input<string>;
    /**
     * The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
     */
    teamId?: pulumi.Input<string>;
}