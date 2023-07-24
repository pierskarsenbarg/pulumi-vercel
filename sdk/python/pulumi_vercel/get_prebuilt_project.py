# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetPrebuiltProjectResult',
    'AwaitableGetPrebuiltProjectResult',
    'get_prebuilt_project',
    'get_prebuilt_project_output',
]

@pulumi.output_type
class GetPrebuiltProjectResult:
    """
    A collection of values returned by getPrebuiltProject.
    """
    def __init__(__self__, id=None, output=None, path=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if output and not isinstance(output, dict):
            raise TypeError("Expected argument 'output' to be a dict")
        pulumi.set(__self__, "output", output)
        if path and not isinstance(path, str):
            raise TypeError("Expected argument 'path' to be a str")
        pulumi.set(__self__, "path", path)

    @property
    @pulumi.getter
    def id(self) -> str:
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def output(self) -> Mapping[str, str]:
        return pulumi.get(self, "output")

    @property
    @pulumi.getter
    def path(self) -> str:
        return pulumi.get(self, "path")


class AwaitableGetPrebuiltProjectResult(GetPrebuiltProjectResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPrebuiltProjectResult(
            id=self.id,
            output=self.output,
            path=self.path)


def get_prebuilt_project(path: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPrebuiltProjectResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['path'] = path
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('vercel:index/getPrebuiltProject:getPrebuiltProject', __args__, opts=opts, typ=GetPrebuiltProjectResult).value

    return AwaitableGetPrebuiltProjectResult(
        id=pulumi.get(__ret__, 'id'),
        output=pulumi.get(__ret__, 'output'),
        path=pulumi.get(__ret__, 'path'))


@_utilities.lift_output_func(get_prebuilt_project)
def get_prebuilt_project_output(path: Optional[pulumi.Input[str]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPrebuiltProjectResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...