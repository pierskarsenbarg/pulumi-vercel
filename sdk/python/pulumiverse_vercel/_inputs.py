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
    'DeploymentProjectSettingsArgs',
    'DnsRecordSrvArgs',
    'ProjectEnvironmentArgs',
    'ProjectGitRepositoryArgs',
    'ProjectPasswordProtectionArgs',
    'ProjectVercelAuthenticationArgs',
    'GetProjectPasswordProtectionArgs',
]

@pulumi.input_type
class DeploymentProjectSettingsArgs:
    def __init__(__self__, *,
                 build_command: Optional[pulumi.Input[str]] = None,
                 framework: Optional[pulumi.Input[str]] = None,
                 install_command: Optional[pulumi.Input[str]] = None,
                 output_directory: Optional[pulumi.Input[str]] = None,
                 root_directory: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] build_command: The build command for this deployment. If omitted, this value will be taken from the project or automatically detected.
        :param pulumi.Input[str] framework: The framework that is being used for this deployment. If omitted, no framework is selected.
        :param pulumi.Input[str] install_command: The install command for this deployment. If omitted, this value will be taken from the project or automatically detected.
        :param pulumi.Input[str] output_directory: The output directory of the deployment. If omitted, this value will be taken from the project or automatically detected.
        :param pulumi.Input[str] root_directory: The name of a directory or relative path to the source code of your project. When null is used it will default to the project root.
        """
        if build_command is not None:
            pulumi.set(__self__, "build_command", build_command)
        if framework is not None:
            pulumi.set(__self__, "framework", framework)
        if install_command is not None:
            pulumi.set(__self__, "install_command", install_command)
        if output_directory is not None:
            pulumi.set(__self__, "output_directory", output_directory)
        if root_directory is not None:
            pulumi.set(__self__, "root_directory", root_directory)

    @property
    @pulumi.getter(name="buildCommand")
    def build_command(self) -> Optional[pulumi.Input[str]]:
        """
        The build command for this deployment. If omitted, this value will be taken from the project or automatically detected.
        """
        return pulumi.get(self, "build_command")

    @build_command.setter
    def build_command(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "build_command", value)

    @property
    @pulumi.getter
    def framework(self) -> Optional[pulumi.Input[str]]:
        """
        The framework that is being used for this deployment. If omitted, no framework is selected.
        """
        return pulumi.get(self, "framework")

    @framework.setter
    def framework(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "framework", value)

    @property
    @pulumi.getter(name="installCommand")
    def install_command(self) -> Optional[pulumi.Input[str]]:
        """
        The install command for this deployment. If omitted, this value will be taken from the project or automatically detected.
        """
        return pulumi.get(self, "install_command")

    @install_command.setter
    def install_command(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "install_command", value)

    @property
    @pulumi.getter(name="outputDirectory")
    def output_directory(self) -> Optional[pulumi.Input[str]]:
        """
        The output directory of the deployment. If omitted, this value will be taken from the project or automatically detected.
        """
        return pulumi.get(self, "output_directory")

    @output_directory.setter
    def output_directory(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "output_directory", value)

    @property
    @pulumi.getter(name="rootDirectory")
    def root_directory(self) -> Optional[pulumi.Input[str]]:
        """
        The name of a directory or relative path to the source code of your project. When null is used it will default to the project root.
        """
        return pulumi.get(self, "root_directory")

    @root_directory.setter
    def root_directory(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "root_directory", value)


@pulumi.input_type
class DnsRecordSrvArgs:
    def __init__(__self__, *,
                 port: pulumi.Input[int],
                 priority: pulumi.Input[int],
                 target: pulumi.Input[str],
                 weight: pulumi.Input[int]):
        """
        :param pulumi.Input[int] port: The TCP or UDP port on which the service is to be found.
        :param pulumi.Input[int] priority: The priority of the target host, lower value means more preferred.
        :param pulumi.Input[str] target: The canonical hostname of the machine providing the service, ending in a dot.
        :param pulumi.Input[int] weight: A relative weight for records with the same priority, higher value means higher chance of getting picked.
        """
        pulumi.set(__self__, "port", port)
        pulumi.set(__self__, "priority", priority)
        pulumi.set(__self__, "target", target)
        pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter
    def port(self) -> pulumi.Input[int]:
        """
        The TCP or UDP port on which the service is to be found.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: pulumi.Input[int]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def priority(self) -> pulumi.Input[int]:
        """
        The priority of the target host, lower value means more preferred.
        """
        return pulumi.get(self, "priority")

    @priority.setter
    def priority(self, value: pulumi.Input[int]):
        pulumi.set(self, "priority", value)

    @property
    @pulumi.getter
    def target(self) -> pulumi.Input[str]:
        """
        The canonical hostname of the machine providing the service, ending in a dot.
        """
        return pulumi.get(self, "target")

    @target.setter
    def target(self, value: pulumi.Input[str]):
        pulumi.set(self, "target", value)

    @property
    @pulumi.getter
    def weight(self) -> pulumi.Input[int]:
        """
        A relative weight for records with the same priority, higher value means higher chance of getting picked.
        """
        return pulumi.get(self, "weight")

    @weight.setter
    def weight(self, value: pulumi.Input[int]):
        pulumi.set(self, "weight", value)


@pulumi.input_type
class ProjectEnvironmentArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 targets: pulumi.Input[Sequence[pulumi.Input[str]]],
                 value: pulumi.Input[str],
                 git_branch: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] key: The name of the Environment Variable.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] targets: The environments that the Environment Variable should be present on. Valid targets are either `production`, `preview`, or `development`.
        :param pulumi.Input[str] value: The value of the Environment Variable.
        :param pulumi.Input[str] git_branch: The git branch of the Environment Variable.
        :param pulumi.Input[str] id: The ID of the Environment Variable.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "targets", targets)
        pulumi.set(__self__, "value", value)
        if git_branch is not None:
            pulumi.set(__self__, "git_branch", git_branch)
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The name of the Environment Variable.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def targets(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        The environments that the Environment Variable should be present on. Valid targets are either `production`, `preview`, or `development`.
        """
        return pulumi.get(self, "targets")

    @targets.setter
    def targets(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "targets", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value of the Environment Variable.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter(name="gitBranch")
    def git_branch(self) -> Optional[pulumi.Input[str]]:
        """
        The git branch of the Environment Variable.
        """
        return pulumi.get(self, "git_branch")

    @git_branch.setter
    def git_branch(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "git_branch", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Environment Variable.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)


@pulumi.input_type
class ProjectGitRepositoryArgs:
    def __init__(__self__, *,
                 repo: pulumi.Input[str],
                 type: pulumi.Input[str],
                 production_branch: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] repo: The name of the git repository. For example: `vercel/next.js`.
        :param pulumi.Input[str] type: The git provider of the repository. Must be either `github`, `gitlab`, or `bitbucket`.
        :param pulumi.Input[str] production_branch: By default, every commit pushed to the main branch will trigger a Production Deployment instead of the usual Preview Deployment. You can switch to a different branch here.
        """
        pulumi.set(__self__, "repo", repo)
        pulumi.set(__self__, "type", type)
        if production_branch is not None:
            pulumi.set(__self__, "production_branch", production_branch)

    @property
    @pulumi.getter
    def repo(self) -> pulumi.Input[str]:
        """
        The name of the git repository. For example: `vercel/next.js`.
        """
        return pulumi.get(self, "repo")

    @repo.setter
    def repo(self, value: pulumi.Input[str]):
        pulumi.set(self, "repo", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The git provider of the repository. Must be either `github`, `gitlab`, or `bitbucket`.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="productionBranch")
    def production_branch(self) -> Optional[pulumi.Input[str]]:
        """
        By default, every commit pushed to the main branch will trigger a Production Deployment instead of the usual Preview Deployment. You can switch to a different branch here.
        """
        return pulumi.get(self, "production_branch")

    @production_branch.setter
    def production_branch(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "production_branch", value)


@pulumi.input_type
class ProjectPasswordProtectionArgs:
    def __init__(__self__, *,
                 password: pulumi.Input[str],
                 protect_production: Optional[pulumi.Input[bool]] = None):
        """
        :param pulumi.Input[str] password: The password that visitors must enter to gain access to your Preview Deployments. Drift detection is not possible for this field.
        :param pulumi.Input[bool] protect_production: If true, production deployments will also be protected
        """
        pulumi.set(__self__, "password", password)
        if protect_production is not None:
            pulumi.set(__self__, "protect_production", protect_production)

    @property
    @pulumi.getter
    def password(self) -> pulumi.Input[str]:
        """
        The password that visitors must enter to gain access to your Preview Deployments. Drift detection is not possible for this field.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: pulumi.Input[str]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter(name="protectProduction")
    def protect_production(self) -> Optional[pulumi.Input[bool]]:
        """
        If true, production deployments will also be protected
        """
        return pulumi.get(self, "protect_production")

    @protect_production.setter
    def protect_production(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "protect_production", value)


@pulumi.input_type
class ProjectVercelAuthenticationArgs:
    def __init__(__self__, *,
                 protect_production: Optional[pulumi.Input[bool]] = None):
        """
        :param pulumi.Input[bool] protect_production: If true, production deployments will also be protected
        """
        if protect_production is not None:
            pulumi.set(__self__, "protect_production", protect_production)

    @property
    @pulumi.getter(name="protectProduction")
    def protect_production(self) -> Optional[pulumi.Input[bool]]:
        """
        If true, production deployments will also be protected
        """
        return pulumi.get(self, "protect_production")

    @protect_production.setter
    def protect_production(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "protect_production", value)


@pulumi.input_type
class GetProjectPasswordProtectionArgs:
    def __init__(__self__, *,
                 protect_production: bool):
        """
        :param bool protect_production: If true, production deployments will also be protected
        """
        pulumi.set(__self__, "protect_production", protect_production)

    @property
    @pulumi.getter(name="protectProduction")
    def protect_production(self) -> bool:
        """
        If true, production deployments will also be protected
        """
        return pulumi.get(self, "protect_production")

    @protect_production.setter
    def protect_production(self, value: bool):
        pulumi.set(self, "protect_production", value)

