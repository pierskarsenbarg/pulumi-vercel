// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vercel

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-vercel/sdk/go/vercel/internal"
)

// An Edge Config Schema provides an existing Edge Config with a JSON schema. Use schema protection to prevent unexpected updates that may cause bugs or downtime.
//
// ## Import
//
// # If importing into a personal account, or with a team configured on
//
// the provider, simply use the edge config id.
//
// - edge_config_id can be found by navigating to the Edge Config in the Vercel UI. It should begin with `ecfg_`.
//
// ```sh
// $ pulumi import vercel:index/edgeConfigSchema:EdgeConfigSchema example ecfg_xxxxxxxxxxxxxxxxxxxxxxxxxxxx
// ```
//
// Alternatively, you can import via the team_id and edge_config_id.
//
// - team_id can be found in the team `settings` tab in the Vercel UI.
//
// - edge_config_id can be found by navigating to the Edge Config in the Vercel UI. It should begin with `ecfg_`.
//
// ```sh
// $ pulumi import vercel:index/edgeConfigSchema:EdgeConfigSchema example team_xxxxxxxxxxxxxxxxxxxxxxxx/ecfg_xxxxxxxxxxxxxxxxxxxxxxxxxxxx
// ```
type EdgeConfigSchema struct {
	pulumi.CustomResourceState

	// A JSON schema that will be used to validate data in the Edge Config.
	Definition pulumi.StringOutput `pulumi:"definition"`
	// The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
	TeamId pulumi.StringOutput `pulumi:"teamId"`
}

// NewEdgeConfigSchema registers a new resource with the given unique name, arguments, and options.
func NewEdgeConfigSchema(ctx *pulumi.Context,
	name string, args *EdgeConfigSchemaArgs, opts ...pulumi.ResourceOption) (*EdgeConfigSchema, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Definition == nil {
		return nil, errors.New("invalid value for required argument 'Definition'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource EdgeConfigSchema
	err := ctx.RegisterResource("vercel:index/edgeConfigSchema:EdgeConfigSchema", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEdgeConfigSchema gets an existing EdgeConfigSchema resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEdgeConfigSchema(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EdgeConfigSchemaState, opts ...pulumi.ResourceOption) (*EdgeConfigSchema, error) {
	var resource EdgeConfigSchema
	err := ctx.ReadResource("vercel:index/edgeConfigSchema:EdgeConfigSchema", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EdgeConfigSchema resources.
type edgeConfigSchemaState struct {
	// A JSON schema that will be used to validate data in the Edge Config.
	Definition *string `pulumi:"definition"`
	// The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
	TeamId *string `pulumi:"teamId"`
}

type EdgeConfigSchemaState struct {
	// A JSON schema that will be used to validate data in the Edge Config.
	Definition pulumi.StringPtrInput
	// The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
	TeamId pulumi.StringPtrInput
}

func (EdgeConfigSchemaState) ElementType() reflect.Type {
	return reflect.TypeOf((*edgeConfigSchemaState)(nil)).Elem()
}

type edgeConfigSchemaArgs struct {
	// A JSON schema that will be used to validate data in the Edge Config.
	Definition string `pulumi:"definition"`
	// The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
	TeamId *string `pulumi:"teamId"`
}

// The set of arguments for constructing a EdgeConfigSchema resource.
type EdgeConfigSchemaArgs struct {
	// A JSON schema that will be used to validate data in the Edge Config.
	Definition pulumi.StringInput
	// The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
	TeamId pulumi.StringPtrInput
}

func (EdgeConfigSchemaArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*edgeConfigSchemaArgs)(nil)).Elem()
}

type EdgeConfigSchemaInput interface {
	pulumi.Input

	ToEdgeConfigSchemaOutput() EdgeConfigSchemaOutput
	ToEdgeConfigSchemaOutputWithContext(ctx context.Context) EdgeConfigSchemaOutput
}

func (*EdgeConfigSchema) ElementType() reflect.Type {
	return reflect.TypeOf((**EdgeConfigSchema)(nil)).Elem()
}

func (i *EdgeConfigSchema) ToEdgeConfigSchemaOutput() EdgeConfigSchemaOutput {
	return i.ToEdgeConfigSchemaOutputWithContext(context.Background())
}

func (i *EdgeConfigSchema) ToEdgeConfigSchemaOutputWithContext(ctx context.Context) EdgeConfigSchemaOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EdgeConfigSchemaOutput)
}

// EdgeConfigSchemaArrayInput is an input type that accepts EdgeConfigSchemaArray and EdgeConfigSchemaArrayOutput values.
// You can construct a concrete instance of `EdgeConfigSchemaArrayInput` via:
//
//	EdgeConfigSchemaArray{ EdgeConfigSchemaArgs{...} }
type EdgeConfigSchemaArrayInput interface {
	pulumi.Input

	ToEdgeConfigSchemaArrayOutput() EdgeConfigSchemaArrayOutput
	ToEdgeConfigSchemaArrayOutputWithContext(context.Context) EdgeConfigSchemaArrayOutput
}

type EdgeConfigSchemaArray []EdgeConfigSchemaInput

func (EdgeConfigSchemaArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EdgeConfigSchema)(nil)).Elem()
}

func (i EdgeConfigSchemaArray) ToEdgeConfigSchemaArrayOutput() EdgeConfigSchemaArrayOutput {
	return i.ToEdgeConfigSchemaArrayOutputWithContext(context.Background())
}

func (i EdgeConfigSchemaArray) ToEdgeConfigSchemaArrayOutputWithContext(ctx context.Context) EdgeConfigSchemaArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EdgeConfigSchemaArrayOutput)
}

// EdgeConfigSchemaMapInput is an input type that accepts EdgeConfigSchemaMap and EdgeConfigSchemaMapOutput values.
// You can construct a concrete instance of `EdgeConfigSchemaMapInput` via:
//
//	EdgeConfigSchemaMap{ "key": EdgeConfigSchemaArgs{...} }
type EdgeConfigSchemaMapInput interface {
	pulumi.Input

	ToEdgeConfigSchemaMapOutput() EdgeConfigSchemaMapOutput
	ToEdgeConfigSchemaMapOutputWithContext(context.Context) EdgeConfigSchemaMapOutput
}

type EdgeConfigSchemaMap map[string]EdgeConfigSchemaInput

func (EdgeConfigSchemaMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EdgeConfigSchema)(nil)).Elem()
}

func (i EdgeConfigSchemaMap) ToEdgeConfigSchemaMapOutput() EdgeConfigSchemaMapOutput {
	return i.ToEdgeConfigSchemaMapOutputWithContext(context.Background())
}

func (i EdgeConfigSchemaMap) ToEdgeConfigSchemaMapOutputWithContext(ctx context.Context) EdgeConfigSchemaMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EdgeConfigSchemaMapOutput)
}

type EdgeConfigSchemaOutput struct{ *pulumi.OutputState }

func (EdgeConfigSchemaOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EdgeConfigSchema)(nil)).Elem()
}

func (o EdgeConfigSchemaOutput) ToEdgeConfigSchemaOutput() EdgeConfigSchemaOutput {
	return o
}

func (o EdgeConfigSchemaOutput) ToEdgeConfigSchemaOutputWithContext(ctx context.Context) EdgeConfigSchemaOutput {
	return o
}

// A JSON schema that will be used to validate data in the Edge Config.
func (o EdgeConfigSchemaOutput) Definition() pulumi.StringOutput {
	return o.ApplyT(func(v *EdgeConfigSchema) pulumi.StringOutput { return v.Definition }).(pulumi.StringOutput)
}

// The ID of the team the Edge Config should exist under. Required when configuring a team resource if a default team has not been set in the provider.
func (o EdgeConfigSchemaOutput) TeamId() pulumi.StringOutput {
	return o.ApplyT(func(v *EdgeConfigSchema) pulumi.StringOutput { return v.TeamId }).(pulumi.StringOutput)
}

type EdgeConfigSchemaArrayOutput struct{ *pulumi.OutputState }

func (EdgeConfigSchemaArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EdgeConfigSchema)(nil)).Elem()
}

func (o EdgeConfigSchemaArrayOutput) ToEdgeConfigSchemaArrayOutput() EdgeConfigSchemaArrayOutput {
	return o
}

func (o EdgeConfigSchemaArrayOutput) ToEdgeConfigSchemaArrayOutputWithContext(ctx context.Context) EdgeConfigSchemaArrayOutput {
	return o
}

func (o EdgeConfigSchemaArrayOutput) Index(i pulumi.IntInput) EdgeConfigSchemaOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *EdgeConfigSchema {
		return vs[0].([]*EdgeConfigSchema)[vs[1].(int)]
	}).(EdgeConfigSchemaOutput)
}

type EdgeConfigSchemaMapOutput struct{ *pulumi.OutputState }

func (EdgeConfigSchemaMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EdgeConfigSchema)(nil)).Elem()
}

func (o EdgeConfigSchemaMapOutput) ToEdgeConfigSchemaMapOutput() EdgeConfigSchemaMapOutput {
	return o
}

func (o EdgeConfigSchemaMapOutput) ToEdgeConfigSchemaMapOutputWithContext(ctx context.Context) EdgeConfigSchemaMapOutput {
	return o
}

func (o EdgeConfigSchemaMapOutput) MapIndex(k pulumi.StringInput) EdgeConfigSchemaOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *EdgeConfigSchema {
		return vs[0].(map[string]*EdgeConfigSchema)[vs[1].(string)]
	}).(EdgeConfigSchemaOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EdgeConfigSchemaInput)(nil)).Elem(), &EdgeConfigSchema{})
	pulumi.RegisterInputType(reflect.TypeOf((*EdgeConfigSchemaArrayInput)(nil)).Elem(), EdgeConfigSchemaArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EdgeConfigSchemaMapInput)(nil)).Elem(), EdgeConfigSchemaMap{})
	pulumi.RegisterOutputType(EdgeConfigSchemaOutput{})
	pulumi.RegisterOutputType(EdgeConfigSchemaArrayOutput{})
	pulumi.RegisterOutputType(EdgeConfigSchemaMapOutput{})
}