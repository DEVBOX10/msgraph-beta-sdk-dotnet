// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcOnPremisesConnectionHealthCheckErrorType {
        [EnumMember(Value = "dnsCheckFqdnNotFound")]
        DnsCheckFqdnNotFound,
        [EnumMember(Value = "dnsCheckNameWithInvalidCharacter")]
        DnsCheckNameWithInvalidCharacter,
        [EnumMember(Value = "dnsCheckUnknownError")]
        DnsCheckUnknownError,
        [EnumMember(Value = "adJoinCheckFqdnNotFound")]
        AdJoinCheckFqdnNotFound,
        [EnumMember(Value = "adJoinCheckIncorrectCredentials")]
        AdJoinCheckIncorrectCredentials,
        [EnumMember(Value = "adJoinCheckOrganizationalUnitNotFound")]
        AdJoinCheckOrganizationalUnitNotFound,
        [EnumMember(Value = "adJoinCheckOrganizationalUnitIncorrectFormat")]
        AdJoinCheckOrganizationalUnitIncorrectFormat,
        [EnumMember(Value = "adJoinCheckComputerObjectAlreadyExists")]
        AdJoinCheckComputerObjectAlreadyExists,
        [EnumMember(Value = "adJoinCheckAccessDenied")]
        AdJoinCheckAccessDenied,
        [EnumMember(Value = "adJoinCheckCredentialsExpired")]
        AdJoinCheckCredentialsExpired,
        [EnumMember(Value = "adJoinCheckAccountLockedOrDisabled")]
        AdJoinCheckAccountLockedOrDisabled,
        [EnumMember(Value = "adJoinCheckAccountQuotaExceeded")]
        AdJoinCheckAccountQuotaExceeded,
        [EnumMember(Value = "adJoinCheckServerNotOperational")]
        AdJoinCheckServerNotOperational,
        [EnumMember(Value = "adJoinCheckUnknownError")]
        AdJoinCheckUnknownError,
        [EnumMember(Value = "endpointConnectivityCheckCloudPcUrlNotAllowListed")]
        EndpointConnectivityCheckCloudPcUrlNotAllowListed,
        [EnumMember(Value = "endpointConnectivityCheckWVDUrlNotAllowListed")]
        EndpointConnectivityCheckWVDUrlNotAllowListed,
        [EnumMember(Value = "endpointConnectivityCheckIntuneUrlNotAllowListed")]
        EndpointConnectivityCheckIntuneUrlNotAllowListed,
        [EnumMember(Value = "endpointConnectivityCheckAzureADUrlNotAllowListed")]
        EndpointConnectivityCheckAzureADUrlNotAllowListed,
        [EnumMember(Value = "endpointConnectivityCheckLocaleUrlNotAllowListed")]
        EndpointConnectivityCheckLocaleUrlNotAllowListed,
        [EnumMember(Value = "endpointConnectivityCheckUnknownError")]
        EndpointConnectivityCheckUnknownError,
        [EnumMember(Value = "azureAdDeviceSyncCheckDeviceNotFound")]
        AzureAdDeviceSyncCheckDeviceNotFound,
        [EnumMember(Value = "azureAdDeviceSyncCheckLongSyncCircle")]
        AzureAdDeviceSyncCheckLongSyncCircle,
        [EnumMember(Value = "azureAdDeviceSyncCheckConnectDisabled")]
        AzureAdDeviceSyncCheckConnectDisabled,
        [EnumMember(Value = "azureAdDeviceSyncCheckDurationExceeded")]
        AzureAdDeviceSyncCheckDurationExceeded,
        [EnumMember(Value = "azureAdDeviceSyncCheckScpNotConfigured")]
        AzureAdDeviceSyncCheckScpNotConfigured,
        [EnumMember(Value = "azureAdDeviceSyncCheckTransientServiceError")]
        AzureAdDeviceSyncCheckTransientServiceError,
        [EnumMember(Value = "azureAdDeviceSyncCheckUnknownError")]
        AzureAdDeviceSyncCheckUnknownError,
        [EnumMember(Value = "resourceAvailabilityCheckNoSubnetIP")]
        ResourceAvailabilityCheckNoSubnetIP,
        [EnumMember(Value = "resourceAvailabilityCheckSubscriptionDisabled")]
        ResourceAvailabilityCheckSubscriptionDisabled,
        [EnumMember(Value = "resourceAvailabilityCheckAzurePolicyViolation")]
        ResourceAvailabilityCheckAzurePolicyViolation,
        [EnumMember(Value = "resourceAvailabilityCheckSubscriptionNotFound")]
        ResourceAvailabilityCheckSubscriptionNotFound,
        [EnumMember(Value = "resourceAvailabilityCheckSubscriptionTransferred")]
        ResourceAvailabilityCheckSubscriptionTransferred,
        [EnumMember(Value = "resourceAvailabilityCheckGeneralSubscriptionError")]
        ResourceAvailabilityCheckGeneralSubscriptionError,
        [EnumMember(Value = "resourceAvailabilityCheckUnsupportedVNetRegion")]
        ResourceAvailabilityCheckUnsupportedVNetRegion,
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupInvalid")]
        ResourceAvailabilityCheckResourceGroupInvalid,
        [EnumMember(Value = "resourceAvailabilityCheckVNetInvalid")]
        ResourceAvailabilityCheckVNetInvalid,
        [EnumMember(Value = "resourceAvailabilityCheckSubnetInvalid")]
        ResourceAvailabilityCheckSubnetInvalid,
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupBeingDeleted")]
        ResourceAvailabilityCheckResourceGroupBeingDeleted,
        [EnumMember(Value = "resourceAvailabilityCheckVNetBeingMoved")]
        ResourceAvailabilityCheckVNetBeingMoved,
        [EnumMember(Value = "resourceAvailabilityCheckSubnetDelegationFailed")]
        ResourceAvailabilityCheckSubnetDelegationFailed,
        [EnumMember(Value = "resourceAvailabilityCheckSubnetWithExternalResources")]
        ResourceAvailabilityCheckSubnetWithExternalResources,
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupLockedForReadonly")]
        ResourceAvailabilityCheckResourceGroupLockedForReadonly,
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupLockedForDelete")]
        ResourceAvailabilityCheckResourceGroupLockedForDelete,
        [EnumMember(Value = "resourceAvailabilityCheckNoIntuneReaderRoleError")]
        ResourceAvailabilityCheckNoIntuneReaderRoleError,
        [EnumMember(Value = "resourceAvailabilityCheckIntuneDefaultWindowsRestrictionViolation")]
        ResourceAvailabilityCheckIntuneDefaultWindowsRestrictionViolation,
        [EnumMember(Value = "resourceAvailabilityCheckIntuneCustomWindowsRestrictionViolation")]
        ResourceAvailabilityCheckIntuneCustomWindowsRestrictionViolation,
        [EnumMember(Value = "resourceAvailabilityCheckTransientServiceError")]
        ResourceAvailabilityCheckTransientServiceError,
        [EnumMember(Value = "resourceAvailabilityCheckUnknownError")]
        ResourceAvailabilityCheckUnknownError,
        [EnumMember(Value = "permissionCheckNoSubscriptionReaderRole")]
        PermissionCheckNoSubscriptionReaderRole,
        [EnumMember(Value = "permissionCheckNoResourceGroupOwnerRole")]
        PermissionCheckNoResourceGroupOwnerRole,
        [EnumMember(Value = "permissionCheckNoVNetContributorRole")]
        PermissionCheckNoVNetContributorRole,
        [EnumMember(Value = "permissionCheckNoResourceGroupNetworkContributorRole")]
        PermissionCheckNoResourceGroupNetworkContributorRole,
        [EnumMember(Value = "permissionCheckNoWindows365NetworkUserRole")]
        PermissionCheckNoWindows365NetworkUserRole,
        [EnumMember(Value = "permissionCheckNoWindows365NetworkInterfaceContributorRole")]
        PermissionCheckNoWindows365NetworkInterfaceContributorRole,
        [EnumMember(Value = "permissionCheckTransientServiceError")]
        PermissionCheckTransientServiceError,
        [EnumMember(Value = "permissionCheckUnknownError")]
        PermissionCheckUnknownError,
        [EnumMember(Value = "udpConnectivityCheckStunUrlNotAllowListed")]
        UdpConnectivityCheckStunUrlNotAllowListed,
        [EnumMember(Value = "udpConnectivityCheckTurnUrlNotAllowListed")]
        UdpConnectivityCheckTurnUrlNotAllowListed,
        [EnumMember(Value = "udpConnectivityCheckUrlsNotAllowListed")]
        UdpConnectivityCheckUrlsNotAllowListed,
        [EnumMember(Value = "udpConnectivityCheckUnknownError")]
        UdpConnectivityCheckUnknownError,
        [EnumMember(Value = "internalServerErrorDeploymentCanceled")]
        InternalServerErrorDeploymentCanceled,
        [EnumMember(Value = "internalServerErrorAllocateResourceFailed")]
        InternalServerErrorAllocateResourceFailed,
        [EnumMember(Value = "internalServerErrorVMDeploymentTimeout")]
        InternalServerErrorVMDeploymentTimeout,
        [EnumMember(Value = "internalServerErrorUnableToRunDscScript")]
        InternalServerErrorUnableToRunDscScript,
        [EnumMember(Value = "ssoCheckKerberosConfigurationError")]
        SsoCheckKerberosConfigurationError,
        [EnumMember(Value = "internalServerUnknownError")]
        InternalServerUnknownError,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
