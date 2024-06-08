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
    'GetDeploymentResult',
    'AwaitableGetDeploymentResult',
    'get_deployment',
    'get_deployment_output',
]

@pulumi.output_type
class GetDeploymentResult:
    """
    A collection of values returned by getDeployment.
    """
    def __init__(__self__, domains=None, id=None, production=None, project_id=None, ref=None, team_id=None, url=None):
        if domains and not isinstance(domains, list):
            raise TypeError("Expected argument 'domains' to be a list")
        pulumi.set(__self__, "domains", domains)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if production and not isinstance(production, bool):
            raise TypeError("Expected argument 'production' to be a bool")
        pulumi.set(__self__, "production", production)
        if project_id and not isinstance(project_id, str):
            raise TypeError("Expected argument 'project_id' to be a str")
        pulumi.set(__self__, "project_id", project_id)
        if ref and not isinstance(ref, str):
            raise TypeError("Expected argument 'ref' to be a str")
        pulumi.set(__self__, "ref", ref)
        if team_id and not isinstance(team_id, str):
            raise TypeError("Expected argument 'team_id' to be a str")
        pulumi.set(__self__, "team_id", team_id)
        if url and not isinstance(url, str):
            raise TypeError("Expected argument 'url' to be a str")
        pulumi.set(__self__, "url", url)

    @property
    @pulumi.getter
    def domains(self) -> Sequence[str]:
        """
        A list of all the domains (default domains, staging domains and production domains) that were assigned upon deployment creation.
        """
        return pulumi.get(self, "domains")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID or URL of the Deployment to read.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def production(self) -> bool:
        """
        true if the deployment is a production deployment, meaning production aliases will be assigned.
        """
        return pulumi.get(self, "production")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> str:
        """
        The project ID to add the deployment to.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter
    def ref(self) -> str:
        """
        The branch or commit hash that has been deployed. Note this will only work if the project is configured to use a Git repository.
        """
        return pulumi.get(self, "ref")

    @property
    @pulumi.getter(name="teamId")
    def team_id(self) -> str:
        """
        The Team ID to the Deployment belong to. Required when reading a team resource if a default team has not been set in the provider.
        """
        return pulumi.get(self, "team_id")

    @property
    @pulumi.getter
    def url(self) -> str:
        """
        A unique URL that is automatically generated for a deployment.
        """
        return pulumi.get(self, "url")


class AwaitableGetDeploymentResult(GetDeploymentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDeploymentResult(
            domains=self.domains,
            id=self.id,
            production=self.production,
            project_id=self.project_id,
            ref=self.ref,
            team_id=self.team_id,
            url=self.url)


def get_deployment(id: Optional[str] = None,
                   team_id: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDeploymentResult:
    """
    Provides information about an existing Deployment.

    A Deployment is the result of building your Project and making it available through a live URL.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_vercel as vercel

    example = vercel.get_deployment(id="https://my-vercel-project.vercel.app")
    ```


    :param str id: The ID or URL of the Deployment to read.
    :param str team_id: The Team ID to the Deployment belong to. Required when reading a team resource if a default team has not been set in the provider.
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['teamId'] = team_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('vercel:index/getDeployment:getDeployment', __args__, opts=opts, typ=GetDeploymentResult).value

    return AwaitableGetDeploymentResult(
        domains=pulumi.get(__ret__, 'domains'),
        id=pulumi.get(__ret__, 'id'),
        production=pulumi.get(__ret__, 'production'),
        project_id=pulumi.get(__ret__, 'project_id'),
        ref=pulumi.get(__ret__, 'ref'),
        team_id=pulumi.get(__ret__, 'team_id'),
        url=pulumi.get(__ret__, 'url'))


@_utilities.lift_output_func(get_deployment)
def get_deployment_output(id: Optional[pulumi.Input[str]] = None,
                          team_id: Optional[pulumi.Input[Optional[str]]] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDeploymentResult]:
    """
    Provides information about an existing Deployment.

    A Deployment is the result of building your Project and making it available through a live URL.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_vercel as vercel

    example = vercel.get_deployment(id="https://my-vercel-project.vercel.app")
    ```


    :param str id: The ID or URL of the Deployment to read.
    :param str team_id: The Team ID to the Deployment belong to. Required when reading a team resource if a default team has not been set in the provider.
    """
    ...