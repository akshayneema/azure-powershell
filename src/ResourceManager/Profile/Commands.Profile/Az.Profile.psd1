#
# Module manifest for module 'PSGet_AzureRM.Profile'
#
# Generated by: Microsoft Corporation
#
# Generated on: 4/3/2017
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '17a2feff-488b-47f9-8729-e2cec094624c'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = '[PowerShell .Net Core] Microsoft Azure PowerShell - Profile credential management cmdlets for Azure Resource Manager'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = ''

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = '.\Microsoft.Azure.PowerShell.Authentication.Abstractions.dll', 
    '.\Microsoft.Azure.PowerShell.Authentication.dll', 
    '.\Microsoft.Azure.PowerShell.Authentication.ResourceManager.dll', 
    '.\Microsoft.Azure.PowerShell.Authorization.dll', 
    '.\Microsoft.Azure.PowerShell.Compute.dll', 
    '.\Microsoft.Azure.PowerShell.Graph.Rbac.dll', 
    '.\Microsoft.Azure.PowerShell.Network.dll', 
    '.\Microsoft.Azure.PowerShell.ResourceManager.dll', 
    '.\Microsoft.Azure.PowerShell.Common.dll', 
    '.\Microsoft.Azure.PowerShell.Storage.dll', 
    '.\Microsoft.Azure.PowerShell.Storage.Management.dll', 
    '.\Microsoft.Azure.PowerShell.KeyVault.dll', 
    '.\Microsoft.Azure.PowerShell.Websites.dll', 
    '.\Hyak.Common.dll', '.\Microsoft.ApplicationInsights.dll', 
    '.\Microsoft.Azure.Common.dll', 
    '.\Microsoft.IdentityModel.Clients.ActiveDirectory.dll', 
    '.\Microsoft.IdentityModel.Clients.ActiveDirectory.Platform.dll', 
    '.\Microsoft.IdentityModel.Tokens.dll', 
    '.\Microsoft.Rest.ClientRuntime.dll', 
    '.\Microsoft.Rest.ClientRuntime.Azure.dll', 
    '.\Microsoft.Rest.ClientRuntime.Azure.Authentication.dll', 
    '.\Microsoft.WindowsAzure.Storage.dll', 
    '.\Newtonsoft.Json.dll', 
    '.\Microsoft.Azure.PowerShell.Aks.dll', 
    '.\Microsoft.Azure.PowerShell.Strategies.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
TypesToProcess = '.\Microsoft.Azure.Commands.Profile.types.ps1xml'

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = '.\Microsoft.Azure.Commands.Profile.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('.\Microsoft.Azure.Commands.Profile.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Disable-AzDataCollection', 'Disable-AzContextAutosave', 
    'Enable-AzDataCollection', 'Enable-AzContextAutosave', 
    'Remove-AzEnvironment', 'Get-AzEnvironment', 
    'Set-AzEnvironment', 'Add-AzEnvironment', 
    'Get-AzSubscription', 'Connect-AzAccount', 
    'Get-AzContext', 'Set-AzContext', 'Import-AzContext', 
    'Save-AzContext', 'Get-AzTenant', 'Send-Feedback', 
    'Resolve-AzError', 'Select-AzContext', 
    'Rename-AzContext', 'Remove-AzContext', 
    'Clear-AzContext', 'Disconnect-AzAccount', 
    'Get-AzContextAutosaveSetting', 'Set-AzDefault', 
    'Get-AzDefault', 'Clear-AzDefault'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Add-AzureRmAccount', 'Login-AzAccount', 'Login-AzureRmAccount', 
    'Remove-AzureRmAccount', 'Logout-AzAccount', 'Logout-AzureRmAccount', 
    'Select-AzureRmSubscription', 'Resolve-Error', 'Save-AzureRmProfile'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure', 'ResourceManager', 'ARM', 'Profile', 'Authentication', 
            'Environment', 'Subscription'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Resolve-AzureRmError
  * New cmdlet to show details of errors and exceptions thrown by cmdlets, including server request/response data
* Send-Feedback
  * Enabled sending feedback without logging in
* Get-AzureRmSubscription
  * Fix bug in retrieving CSP subscriptions
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

