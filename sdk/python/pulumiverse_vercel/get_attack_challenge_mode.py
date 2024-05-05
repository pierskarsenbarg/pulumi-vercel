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
    'GetAttackChallengeModeResult',
    'AwaitableGetAttackChallengeModeResult',
    'get_attack_challenge_mode',
    'get_attack_challenge_mode_output',
]

@pulumi.output_type
class GetAttackChallengeModeResult:
    """
    A collection of values returned by getAttackChallengeMode.
    """
    def __init__(__self__, enabled=None, id=None, project_id=None, team_id=None):
        if enabled and not isinstance(enabled, bool):
            raise TypeError("Expected argument 'enabled' to be a bool")
        pulumi.set(__self__, "enabled", enabled)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if project_id and not isinstance(project_id, str):
            raise TypeError("Expected argument 'project_id' to be a str")
        pulumi.set(__self__, "project_id", project_id)
        if team_id and not isinstance(team_id, str):
            raise TypeError("Expected argument 'team_id' to be a str")
        pulumi.set(__self__, "team_id", team_id)

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        """
        Whether Attack Challenge Mode is enabled or not.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The resource identifier.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> str:
        """
        The ID of the Project to adjust the CPU for.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter(name="teamId")
    def team_id(self) -> str:
        """
        The ID of the team the Project exists under. Required when configuring a team resource if a default team has not been set in the provider.
        """
        return pulumi.get(self, "team_id")


class AwaitableGetAttackChallengeModeResult(GetAttackChallengeModeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAttackChallengeModeResult(
            enabled=self.enabled,
            id=self.id,
            project_id=self.project_id,
            team_id=self.team_id)


def get_attack_challenge_mode(project_id: Optional[str] = None,
                              team_id: Optional[str] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAttackChallengeModeResult:
    """
    Provides an Attack Challenge Mode resource.

    Attack Challenge Mode prevent malicious traffic by showing a verification challenge for every visitor.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_vercel as vercel

    example = vercel.get_attack_challenge_mode(project_id=vercel_project["example"]["id"])
    ```


    :param str project_id: The ID of the Project to adjust the CPU for.
    :param str team_id: The ID of the team the Project exists under. Required when configuring a team resource if a default team has not been set in the provider.
    """
    __args__ = dict()
    __args__['projectId'] = project_id
    __args__['teamId'] = team_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('vercel:index/getAttackChallengeMode:getAttackChallengeMode', __args__, opts=opts, typ=GetAttackChallengeModeResult).value

    return AwaitableGetAttackChallengeModeResult(
        enabled=pulumi.get(__ret__, 'enabled'),
        id=pulumi.get(__ret__, 'id'),
        project_id=pulumi.get(__ret__, 'project_id'),
        team_id=pulumi.get(__ret__, 'team_id'))


@_utilities.lift_output_func(get_attack_challenge_mode)
def get_attack_challenge_mode_output(project_id: Optional[pulumi.Input[str]] = None,
                                     team_id: Optional[pulumi.Input[Optional[str]]] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAttackChallengeModeResult]:
    """
    Provides an Attack Challenge Mode resource.

    Attack Challenge Mode prevent malicious traffic by showing a verification challenge for every visitor.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_vercel as vercel

    example = vercel.get_attack_challenge_mode(project_id=vercel_project["example"]["id"])
    ```


    :param str project_id: The ID of the Project to adjust the CPU for.
    :param str team_id: The ID of the team the Project exists under. Required when configuring a team resource if a default team has not been set in the provider.
    """
    ...
