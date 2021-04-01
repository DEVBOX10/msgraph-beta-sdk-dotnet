# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.Synopsis
    Get the NuGet package version.

.Description
    Get the NuGet package version and write the package version to an environment
    variable named VERSION_STRING in the Azure DevOps release environment.
    VERSION_STRING is used to name a tag for setting a GitHub release. This
    script assumes that the NuGet package has been named with correct version number.

.Parameter packageDirPath
    Specifies the fully qualified path to the NuGet package directory.
#>

Param(
    [string]$packageDirPath
)

Write-Host "Get the NuGet package version and set it in the global variable: VERSION_STRING" -ForegroundColor Magenta

$nugetPackageName = (Get-ChildItem (Join-Path $packageDirPath *.nupkg) -Exclude *.symbols.nupkg).Name

Write-Host "Found NuGet package: $nugetPackageName" -ForegroundColor Magenta
$packageVersionRegex = "Microsoft\.Graph\.Beta\.([0-9]+\.[0-9]+\.[0-9]+-\w+)\.nupkg"

## Extracts the package version from nupkg file name.
if ($nugetPackageName -match $packageVersionRegex)
{
    $packageVersion = $Matches[1]
    Write-Host "##vso[task.setvariable variable=VERSION_STRING]$($packageVersion)";
    Write-Host "Updated the VERSION_STRING environment variable with the package version value '$packageVersion'." -ForegroundColor Green
}
else
{
    Write-Host "Regular expression used in extracting the package version is: $packageVersionRegex"
    Write-Error "We can't extract package version from the string"
}
