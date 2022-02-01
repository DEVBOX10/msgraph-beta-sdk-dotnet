// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Managed Device.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ManagedDevice>))]
    public partial class ManagedDevice : Entity
    {
    
        /// <summary>
        /// Gets or sets cloud pc remote action results.
        /// </summary>
        [JsonPropertyName("cloudPcRemoteActionResults")]
        public IEnumerable<CloudPcRemoteActionResult> CloudPcRemoteActionResults { get; set; }
    
        /// <summary>
        /// Gets or sets aad registered.
        /// Whether the device is Azure Active Directory registered. This property is read-only.
        /// </summary>
        [JsonPropertyName("aadRegistered")]
        public bool? AadRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets activation lock bypass code.
        /// Code that allows the Activation Lock on a device to be bypassed. This property is read-only.
        /// </summary>
        [JsonPropertyName("activationLockBypassCode")]
        public string ActivationLockBypassCode { get; set; }
    
        /// <summary>
        /// Gets or sets android security patch level.
        /// Android security patch level. This property is read-only.
        /// </summary>
        [JsonPropertyName("androidSecurityPatchLevel")]
        public string AndroidSecurityPatchLevel { get; set; }
    
        /// <summary>
        /// Gets or sets autopilot enrolled.
        /// Reports if the managed device is enrolled via auto-pilot. This property is read-only.
        /// </summary>
        [JsonPropertyName("autopilotEnrolled")]
        public bool? AutopilotEnrolled { get; set; }
    
        /// <summary>
        /// Gets or sets azure active directory device id.
        /// The unique identifier for the Azure Active Directory device. Read only. This property is read-only.
        /// </summary>
        [JsonPropertyName("azureActiveDirectoryDeviceId")]
        public string AzureActiveDirectoryDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure addevice id.
        /// The unique identifier for the Azure Active Directory device. Read only. This property is read-only.
        /// </summary>
        [JsonPropertyName("azureADDeviceId")]
        public string AzureADDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure adregistered.
        /// Whether the device is Azure Active Directory registered. This property is read-only.
        /// </summary>
        [JsonPropertyName("azureADRegistered")]
        public bool? AzureADRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets chassis type.
        /// Chassis type of the device. This property is read-only. Possible values are: unknown, desktop, laptop, worksWorkstation, enterpriseServer, phone, tablet, mobileOther, mobileUnknown.
        /// </summary>
        [JsonPropertyName("chassisType")]
        public ChassisType? ChassisType { get; set; }
    
        /// <summary>
        /// Gets or sets chrome osdevice info.
        /// List of properties of the ChromeOS Device.
        /// </summary>
        [JsonPropertyName("chromeOSDeviceInfo")]
        public IEnumerable<ChromeOSDeviceProperty> ChromeOSDeviceInfo { get; set; }
    
        /// <summary>
        /// Gets or sets compliance grace period expiration date time.
        /// The DateTime when device compliance grace period expires. This property is read-only.
        /// </summary>
        [JsonPropertyName("complianceGracePeriodExpirationDateTime")]
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets compliance state.
        /// Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager.
        /// </summary>
        [JsonPropertyName("complianceState")]
        public ComplianceState? ComplianceState { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager client enabled features.
        /// ConfigrMgr client enabled features. This property is read-only.
        /// </summary>
        [JsonPropertyName("configurationManagerClientEnabledFeatures")]
        public ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager client health state.
        /// Configuration manager client health state, valid only for devices managed by MDM/ConfigMgr Agent
        /// </summary>
        [JsonPropertyName("configurationManagerClientHealthState")]
        public ConfigurationManagerClientHealthState ConfigurationManagerClientHealthState { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager client information.
        /// Configuration manager client information, valid only for devices managed, duel-managed or tri-managed by ConfigMgr Agent
        /// </summary>
        [JsonPropertyName("configurationManagerClientInformation")]
        public ConfigurationManagerClientInformation ConfigurationManagerClientInformation { get; set; }
    
        /// <summary>
        /// Gets or sets device action results.
        /// List of ComplexType deviceActionResult objects. This property is read-only.
        /// </summary>
        [JsonPropertyName("deviceActionResults")]
        public IEnumerable<DeviceActionResult> DeviceActionResults { get; set; }
    
        /// <summary>
        /// Gets or sets device category display name.
        /// Device category display name. This property is read-only.
        /// </summary>
        [JsonPropertyName("deviceCategoryDisplayName")]
        public string DeviceCategoryDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device enrollment type.
        /// Enrollment type of the device. This property is read-only. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount, azureAdJoinUsingAzureVmExtension, androidEnterpriseDedicatedDevice, androidEnterpriseFullyManaged, androidEnterpriseCorporateWorkProfile.
        /// </summary>
        [JsonPropertyName("deviceEnrollmentType")]
        public DeviceEnrollmentType? DeviceEnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets device health attestation state.
        /// The device health attestation state. This property is read-only.
        /// </summary>
        [JsonPropertyName("deviceHealthAttestationState")]
        public DeviceHealthAttestationState DeviceHealthAttestationState { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Name of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device registration state.
        /// Device registration state. This property is read-only. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.
        /// </summary>
        [JsonPropertyName("deviceRegistrationState")]
        public DeviceRegistrationState? DeviceRegistrationState { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// Platform of the device. This property is read-only. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.
        /// </summary>
        [JsonPropertyName("deviceType")]
        public DeviceType? DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets eas activated.
        /// Whether the device is Exchange ActiveSync activated. This property is read-only.
        /// </summary>
        [JsonPropertyName("easActivated")]
        public bool? EasActivated { get; set; }
    
        /// <summary>
        /// Gets or sets eas activation date time.
        /// Exchange ActivationSync activation time of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("easActivationDateTime")]
        public DateTimeOffset? EasActivationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets eas device id.
        /// Exchange ActiveSync Id of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("easDeviceId")]
        public string EasDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// Email(s) for the user associated with the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets enrolled date time.
        /// Enrollment time of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("enrolledDateTime")]
        public DateTimeOffset? EnrolledDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment profile name.
        /// Name of the enrollment profile assigned to the device. Default value is empty string, indicating no enrollment profile was assgined. This property is read-only.
        /// </summary>
        [JsonPropertyName("enrollmentProfileName")]
        public string EnrollmentProfileName { get; set; }
    
        /// <summary>
        /// Gets or sets ethernet mac address.
        /// Ethernet MAC. This property is read-only.
        /// </summary>
        [JsonPropertyName("ethernetMacAddress")]
        public string EthernetMacAddress { get; set; }
    
        /// <summary>
        /// Gets or sets exchange access state.
        /// The Access State of the device in Exchange. This property is read-only. Possible values are: none, unknown, allowed, blocked, quarantined.
        /// </summary>
        [JsonPropertyName("exchangeAccessState")]
        public DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }
    
        /// <summary>
        /// Gets or sets exchange access state reason.
        /// The reason for the device's access state in Exchange. This property is read-only. Possible values are: none, unknown, exchangeGlobalRule, exchangeIndividualRule, exchangeDeviceRule, exchangeUpgrade, exchangeMailboxPolicy, other, compliant, notCompliant, notEnrolled, unknownLocation, mfaRequired, azureADBlockDueToAccessPolicy, compromisedPassword, deviceNotKnownWithManagedApp.
        /// </summary>
        [JsonPropertyName("exchangeAccessStateReason")]
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }
    
        /// <summary>
        /// Gets or sets exchange last successful sync date time.
        /// Last time the device contacted Exchange. This property is read-only.
        /// </summary>
        [JsonPropertyName("exchangeLastSuccessfulSyncDateTime")]
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets free storage space in bytes.
        /// Free Storage in Bytes. This property is read-only.
        /// </summary>
        [JsonPropertyName("freeStorageSpaceInBytes")]
        public Int64? FreeStorageSpaceInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets hardware information.
        /// The hardward details for the device.  Includes information such as storage space, manufacturer, serial number, etc. This property is read-only.
        /// </summary>
        [JsonPropertyName("hardwareInformation")]
        public HardwareInformation HardwareInformation { get; set; }
    
        /// <summary>
        /// Gets or sets iccid.
        /// Integrated Circuit Card Identifier, it is A SIM card's unique identification number. This property is read-only.
        /// </summary>
        [JsonPropertyName("iccid")]
        public string Iccid { get; set; }
    
        /// <summary>
        /// Gets or sets imei.
        /// IMEI. This property is read-only.
        /// </summary>
        [JsonPropertyName("imei")]
        public string Imei { get; set; }
    
        /// <summary>
        /// Gets or sets is encrypted.
        /// Device encryption status. This property is read-only.
        /// </summary>
        [JsonPropertyName("isEncrypted")]
        public bool? IsEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets is supervised.
        /// Device supervised status. This property is read-only.
        /// </summary>
        [JsonPropertyName("isSupervised")]
        public bool? IsSupervised { get; set; }
    
        /// <summary>
        /// Gets or sets jail broken.
        /// whether the device is jail broken or rooted. This property is read-only.
        /// </summary>
        [JsonPropertyName("jailBroken")]
        public string JailBroken { get; set; }
    
        /// <summary>
        /// Gets or sets join type.
        /// Device join type. Possible values are: unknown, azureADJoined, azureADRegistered, hybridAzureADJoined.
        /// </summary>
        [JsonPropertyName("joinType")]
        public JoinType? JoinType { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The date and time that the device last completed a successful sync with Intune. This property is read-only.
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lost mode state.
        /// Indicates if Lost mode is enabled or disabled. This property is read-only. Possible values are: disabled, enabled.
        /// </summary>
        [JsonPropertyName("lostModeState")]
        public LostModeState? LostModeState { get; set; }
    
        /// <summary>
        /// Gets or sets managed device name.
        /// Automatically generated name to identify a device. Can be overwritten to a user friendly name.
        /// </summary>
        [JsonPropertyName("managedDeviceName")]
        public string ManagedDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets managed device owner type.
        /// Ownership of the device. Can be 'company' or 'personal'. Possible values are: unknown, company, personal.
        /// </summary>
        [JsonPropertyName("managedDeviceOwnerType")]
        public ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets management agent.
        /// Management channel of the device. Intune, EAS, etc. This property is read-only. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, msSense, intuneAosp.
        /// </summary>
        [JsonPropertyName("managementAgent")]
        public ManagementAgentType? ManagementAgent { get; set; }
    
        /// <summary>
        /// Gets or sets management certificate expiration date.
        /// Reports device management certificate expiration date. This property is read-only.
        /// </summary>
        [JsonPropertyName("managementCertificateExpirationDate")]
        public DateTimeOffset? ManagementCertificateExpirationDate { get; set; }
    
        /// <summary>
        /// Gets or sets management features.
        /// Device management features. Possible values are: none, microsoftManagedDesktop.
        /// </summary>
        [JsonPropertyName("managementFeatures")]
        public ManagedDeviceManagementFeatures? ManagementFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets management state.
        /// Management state of the device. This property is read-only. Possible values are: managed, retirePending, retireFailed, wipePending, wipeFailed, unhealthy, deletePending, retireIssued, wipeIssued, wipeCanceled, retireCanceled, discovered.
        /// </summary>
        [JsonPropertyName("managementState")]
        public ManagementState? ManagementState { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Manufacturer of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets meid.
        /// MEID. This property is read-only.
        /// </summary>
        [JsonPropertyName("meid")]
        public string Meid { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Notes on the device created by IT Admin
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// Operating system of the device. Windows, iOS, etc. This property is read-only.
        /// </summary>
        [JsonPropertyName("operatingSystem")]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Operating system version of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets owner type.
        /// Ownership of the device. Can be 'company' or 'personal'. Possible values are: unknown, company, personal.
        /// </summary>
        [JsonPropertyName("ownerType")]
        public OwnerType? OwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets partner reported threat state.
        /// Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only. This property is read-only. Possible values are: unknown, activated, deactivated, secured, lowSeverity, mediumSeverity, highSeverity, unresponsive, compromised, misconfigured.
        /// </summary>
        [JsonPropertyName("partnerReportedThreatState")]
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// Phone number of the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets physical memory in bytes.
        /// Total Memory in Bytes. This property is read-only.
        /// </summary>
        [JsonPropertyName("physicalMemoryInBytes")]
        public Int64? PhysicalMemoryInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets prefer mdm over group policy applied date time.
        /// Reports the DateTime the preferMdmOverGroupPolicy setting was set.  When set, the Intune MDM settings will override Group Policy settings if there is a conflict. Read Only. This property is read-only.
        /// </summary>
        [JsonPropertyName("preferMdmOverGroupPolicyAppliedDateTime")]
        public DateTimeOffset? PreferMdmOverGroupPolicyAppliedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets processor architecture.
        /// Processor architecture. This property is read-only. Possible values are: unknown, x86, x64, arm, arM64.
        /// </summary>
        [JsonPropertyName("processorArchitecture")]
        public ManagedDeviceArchitecture? ProcessorArchitecture { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance session error details.
        /// An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.
        /// </summary>
        [JsonPropertyName("remoteAssistanceSessionErrorDetails")]
        public string RemoteAssistanceSessionErrorDetails { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance session url.
        /// Url that allows a Remote Assistance session to be established with the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("remoteAssistanceSessionUrl")]
        public string RemoteAssistanceSessionUrl { get; set; }
    
        /// <summary>
        /// Gets or sets require user enrollment approval.
        /// Reports if the managed iOS device is user approval enrollment. This property is read-only.
        /// </summary>
        [JsonPropertyName("requireUserEnrollmentApproval")]
        public bool? RequireUserEnrollmentApproval { get; set; }
    
        /// <summary>
        /// Gets or sets retire after date time.
        /// Indicates the time after when a device will be auto retired because of scheduled action. This property is read-only.
        /// </summary>
        [JsonPropertyName("retireAfterDateTime")]
        public DateTimeOffset? RetireAfterDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tag IDs for this Device instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// SerialNumber. This property is read-only.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets sku family.
        /// Device sku family
        /// </summary>
        [JsonPropertyName("skuFamily")]
        public string SkuFamily { get; set; }
    
        /// <summary>
        /// Gets or sets sku number.
        /// Device sku number, see also: GetProductInfo function. Valid values 0 to 2147483647. This property is read-only.
        /// </summary>
        [JsonPropertyName("skuNumber")]
        public Int32? SkuNumber { get; set; }
    
        /// <summary>
        /// Gets or sets specification version.
        /// Specification version. This property is read-only.
        /// </summary>
        [JsonPropertyName("specificationVersion")]
        public string SpecificationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets subscriber carrier.
        /// Subscriber Carrier. This property is read-only.
        /// </summary>
        [JsonPropertyName("subscriberCarrier")]
        public string SubscriberCarrier { get; set; }
    
        /// <summary>
        /// Gets or sets total storage space in bytes.
        /// Total Storage in Bytes. This property is read-only.
        /// </summary>
        [JsonPropertyName("totalStorageSpaceInBytes")]
        public Int64? TotalStorageSpaceInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets udid.
        /// Unique Device Identifier for iOS and macOS devices. This property is read-only.
        /// </summary>
        [JsonPropertyName("udid")]
        public string Udid { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// User display name. This property is read-only.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Unique Identifier for the user associated with the device. This property is read-only.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// Device user principal name. This property is read-only.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets users logged on.
        /// Indicates the last logged on users of a device. This property is read-only.
        /// </summary>
        [JsonPropertyName("usersLoggedOn")]
        public IEnumerable<LoggedOnUser> UsersLoggedOn { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi mac address.
        /// Wi-Fi MAC. This property is read-only.
        /// </summary>
        [JsonPropertyName("wiFiMacAddress")]
        public string WiFiMacAddress { get; set; }
    
        /// <summary>
        /// Gets or sets windows active malware count.
        /// Count of active malware for this windows device. This property is read-only.
        /// </summary>
        [JsonPropertyName("windowsActiveMalwareCount")]
        public Int32? WindowsActiveMalwareCount { get; set; }
    
        /// <summary>
        /// Gets or sets windows remediated malware count.
        /// Count of remediated malware for this windows device. This property is read-only.
        /// </summary>
        [JsonPropertyName("windowsRemediatedMalwareCount")]
        public Int32? WindowsRemediatedMalwareCount { get; set; }
    
        /// <summary>
        /// Gets or sets assignment filter evaluation status details.
        /// Managed device mobile app configuration states for this device.
        /// </summary>
        [JsonPropertyName("assignmentFilterEvaluationStatusDetails")]
        public IManagedDeviceAssignmentFilterEvaluationStatusDetailsCollectionPage AssignmentFilterEvaluationStatusDetails { get; set; }

        /// <summary>
        /// Gets or sets assignmentFilterEvaluationStatusDetailsNextLink.
        /// </summary>
        [JsonPropertyName("assignmentFilterEvaluationStatusDetails@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentFilterEvaluationStatusDetailsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy states.
        /// Device compliance policy states for this device.
        /// </summary>
        [JsonPropertyName("deviceCompliancePolicyStates")]
        public IManagedDeviceDeviceCompliancePolicyStatesCollectionPage DeviceCompliancePolicyStates { get; set; }

        /// <summary>
        /// Gets or sets deviceCompliancePolicyStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceCompliancePolicyStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceCompliancePolicyStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration states.
        /// Device configuration states for this device.
        /// </summary>
        [JsonPropertyName("deviceConfigurationStates")]
        public IManagedDeviceDeviceConfigurationStatesCollectionPage DeviceConfigurationStates { get; set; }

        /// <summary>
        /// Gets or sets deviceConfigurationStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceConfigurationStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceConfigurationStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets managed device mobile app configuration states.
        /// Managed device mobile app configuration states for this device.
        /// </summary>
        [JsonPropertyName("managedDeviceMobileAppConfigurationStates")]
        public IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionPage ManagedDeviceMobileAppConfigurationStates { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceMobileAppConfigurationStatesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceMobileAppConfigurationStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedDeviceMobileAppConfigurationStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets security baseline states.
        /// Security baseline states for this device.
        /// </summary>
        [JsonPropertyName("securityBaselineStates")]
        public IManagedDeviceSecurityBaselineStatesCollectionPage SecurityBaselineStates { get; set; }

        /// <summary>
        /// Gets or sets securityBaselineStatesNextLink.
        /// </summary>
        [JsonPropertyName("securityBaselineStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SecurityBaselineStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets detected apps.
        /// All applications currently installed on the device
        /// </summary>
        [JsonPropertyName("detectedApps")]
        public IManagedDeviceDetectedAppsCollectionWithReferencesPage DetectedApps { get; set; }

        /// <summary>
        /// Gets or sets detectedAppsNextLink.
        /// </summary>
        [JsonPropertyName("detectedApps@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DetectedAppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device category.
        /// Device category
        /// </summary>
        [JsonPropertyName("deviceCategory")]
        public DeviceCategory DeviceCategory { get; set; }
    
        /// <summary>
        /// Gets or sets log collection requests.
        /// List of log collection requests
        /// </summary>
        [JsonPropertyName("logCollectionRequests")]
        public IManagedDeviceLogCollectionRequestsCollectionPage LogCollectionRequests { get; set; }

        /// <summary>
        /// Gets or sets logCollectionRequestsNextLink.
        /// </summary>
        [JsonPropertyName("logCollectionRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string LogCollectionRequestsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// The primary users associated with the managed device.
        /// </summary>
        [JsonPropertyName("users")]
        public IManagedDeviceUsersCollectionWithReferencesPage Users { get; set; }

        /// <summary>
        /// Gets or sets usersNextLink.
        /// </summary>
        [JsonPropertyName("users@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UsersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows protection state.
        /// The device protection status. This property is read-only.
        /// </summary>
        [JsonPropertyName("windowsProtectionState")]
        public WindowsProtectionState WindowsProtectionState { get; set; }
    
    }
}

