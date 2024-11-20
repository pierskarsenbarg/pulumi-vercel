// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vercel

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-vercel/sdk/go/vercel/internal"
)

func LookupTeamConfig(ctx *pulumi.Context, args *LookupTeamConfigArgs, opts ...pulumi.InvokeOption) (*LookupTeamConfigResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupTeamConfigResult
	err := ctx.Invoke("vercel:index/getTeamConfig:getTeamConfig", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTeamConfig.
type LookupTeamConfigArgs struct {
	Id string `pulumi:"id"`
}

// A collection of values returned by getTeamConfig.
type LookupTeamConfigResult struct {
	Description                        string                     `pulumi:"description"`
	EmailDomain                        string                     `pulumi:"emailDomain"`
	EnablePreviewFeedback              string                     `pulumi:"enablePreviewFeedback"`
	EnableProductionFeedback           string                     `pulumi:"enableProductionFeedback"`
	HideIpAddresses                    bool                       `pulumi:"hideIpAddresses"`
	HideIpAddressesInLogDrains         bool                       `pulumi:"hideIpAddressesInLogDrains"`
	Id                                 string                     `pulumi:"id"`
	InviteCode                         string                     `pulumi:"inviteCode"`
	Name                               string                     `pulumi:"name"`
	PreviewDeploymentSuffix            string                     `pulumi:"previewDeploymentSuffix"`
	RemoteCaching                      GetTeamConfigRemoteCaching `pulumi:"remoteCaching"`
	Saml                               GetTeamConfigSaml          `pulumi:"saml"`
	SensitiveEnvironmentVariablePolicy string                     `pulumi:"sensitiveEnvironmentVariablePolicy"`
	Slug                               string                     `pulumi:"slug"`
}

func LookupTeamConfigOutput(ctx *pulumi.Context, args LookupTeamConfigOutputArgs, opts ...pulumi.InvokeOption) LookupTeamConfigResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupTeamConfigResultOutput, error) {
			args := v.(LookupTeamConfigArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv LookupTeamConfigResult
			secret, err := ctx.InvokePackageRaw("vercel:index/getTeamConfig:getTeamConfig", args, &rv, "", opts...)
			if err != nil {
				return LookupTeamConfigResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(LookupTeamConfigResultOutput)
			if secret {
				return pulumi.ToSecret(output).(LookupTeamConfigResultOutput), nil
			}
			return output, nil
		}).(LookupTeamConfigResultOutput)
}

// A collection of arguments for invoking getTeamConfig.
type LookupTeamConfigOutputArgs struct {
	Id pulumi.StringInput `pulumi:"id"`
}

func (LookupTeamConfigOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTeamConfigArgs)(nil)).Elem()
}

// A collection of values returned by getTeamConfig.
type LookupTeamConfigResultOutput struct{ *pulumi.OutputState }

func (LookupTeamConfigResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTeamConfigResult)(nil)).Elem()
}

func (o LookupTeamConfigResultOutput) ToLookupTeamConfigResultOutput() LookupTeamConfigResultOutput {
	return o
}

func (o LookupTeamConfigResultOutput) ToLookupTeamConfigResultOutputWithContext(ctx context.Context) LookupTeamConfigResultOutput {
	return o
}

func (o LookupTeamConfigResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) EmailDomain() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.EmailDomain }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) EnablePreviewFeedback() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.EnablePreviewFeedback }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) EnableProductionFeedback() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.EnableProductionFeedback }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) HideIpAddresses() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) bool { return v.HideIpAddresses }).(pulumi.BoolOutput)
}

func (o LookupTeamConfigResultOutput) HideIpAddressesInLogDrains() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) bool { return v.HideIpAddressesInLogDrains }).(pulumi.BoolOutput)
}

func (o LookupTeamConfigResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) InviteCode() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.InviteCode }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) PreviewDeploymentSuffix() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.PreviewDeploymentSuffix }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) RemoteCaching() GetTeamConfigRemoteCachingOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) GetTeamConfigRemoteCaching { return v.RemoteCaching }).(GetTeamConfigRemoteCachingOutput)
}

func (o LookupTeamConfigResultOutput) Saml() GetTeamConfigSamlOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) GetTeamConfigSaml { return v.Saml }).(GetTeamConfigSamlOutput)
}

func (o LookupTeamConfigResultOutput) SensitiveEnvironmentVariablePolicy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.SensitiveEnvironmentVariablePolicy }).(pulumi.StringOutput)
}

func (o LookupTeamConfigResultOutput) Slug() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamConfigResult) string { return v.Slug }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupTeamConfigResultOutput{})
}