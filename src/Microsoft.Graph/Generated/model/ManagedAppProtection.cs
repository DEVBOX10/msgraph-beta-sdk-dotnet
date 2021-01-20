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
    /// The type Managed App Protection.
    /// </summary>
    public partial class ManagedAppProtection : ManagedAppPolicy
    {
    
		///<summary>
		/// The internal ManagedAppProtection constructor
		///</summary>
        protected internal ManagedAppProtection()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets allowed data ingestion locations.
        /// Data storage locations where a user may store managed data.
        /// </summary>
        [JsonPropertyName("allowedDataIngestionLocations")]
        public IEnumerable<ManagedAppDataIngestionLocation> AllowedDataIngestionLocations { get; set; }
    
        /// <summary>
        /// Gets or sets allowed data storage locations.
        /// Data storage locations where a user may store managed data.
        /// </summary>
        [JsonPropertyName("allowedDataStorageLocations")]
        public IEnumerable<ManagedAppDataStorageLocation> AllowedDataStorageLocations { get; set; }
    
        /// <summary>
        /// Gets or sets allowed inbound data transfer sources.
        /// Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.
        /// </summary>
        [JsonPropertyName("allowedInboundDataTransferSources")]
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }
    
        /// <summary>
        /// Gets or sets allowed outbound clipboard sharing exception length.
        /// Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
        /// </summary>
        [JsonPropertyName("allowedOutboundClipboardSharingExceptionLength")]
        public Int32? AllowedOutboundClipboardSharingExceptionLength { get; set; }
    
        /// <summary>
        /// Gets or sets allowed outbound clipboard sharing level.
        /// The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.
        /// </summary>
        [JsonPropertyName("allowedOutboundClipboardSharingLevel")]
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }
    
        /// <summary>
        /// Gets or sets allowed outbound data transfer destinations.
        /// Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.
        /// </summary>
        [JsonPropertyName("allowedOutboundDataTransferDestinations")]
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }
    
        /// <summary>
        /// Gets or sets app action if device compliance required.
        /// Defines a managed app behavior, either block or wipe, when the device is either rooted or jailbroken, if DeviceComplianceRequired is set to true. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonPropertyName("appActionIfDeviceComplianceRequired")]
        public ManagedAppRemediationAction? AppActionIfDeviceComplianceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets app action if maximum pin retries exceeded.
        /// Defines a managed app behavior, either block or wipe, based on maximum number of incorrect pin retry attempts. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonPropertyName("appActionIfMaximumPinRetriesExceeded")]
        public ManagedAppRemediationAction? AppActionIfMaximumPinRetriesExceeded { get; set; }
    
        /// <summary>
        /// Gets or sets app action if unable to authenticate user.
        /// If set, it will specify what action to take in the case where the user is unable to checkin because their authentication token is invalid. This happens when the user is deleted or disabled in AAD. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonPropertyName("appActionIfUnableToAuthenticateUser")]
        public ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser { get; set; }
    
        /// <summary>
        /// Gets or sets block data ingestion into organization documents.
        /// Indicates whether a user can bring data into org documents.
        /// </summary>
        [JsonPropertyName("blockDataIngestionIntoOrganizationDocuments")]
        public bool? BlockDataIngestionIntoOrganizationDocuments { get; set; }
    
        /// <summary>
        /// Gets or sets contact sync blocked.
        /// Indicates whether contacts can be synced to the user's device.
        /// </summary>
        [JsonPropertyName("contactSyncBlocked")]
        public bool? ContactSyncBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets data backup blocked.
        /// Indicates whether the backup of a managed app's data is blocked.
        /// </summary>
        [JsonPropertyName("dataBackupBlocked")]
        public bool? DataBackupBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance required.
        /// Indicates whether device compliance is required.
        /// </summary>
        [JsonPropertyName("deviceComplianceRequired")]
        public bool? DeviceComplianceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets dialer restriction level.
        /// The classes of dialer apps that are allowed to click-to-open a phone number. Possible values are: allApps, managedApps, customApp, blocked.
        /// </summary>
        [JsonPropertyName("dialerRestrictionLevel")]
        public ManagedAppPhoneNumberRedirectLevel? DialerRestrictionLevel { get; set; }
    
        /// <summary>
        /// Gets or sets disable app pin if device pin is set.
        /// Indicates whether use of the app pin is required if the device pin is set.
        /// </summary>
        [JsonPropertyName("disableAppPinIfDevicePinIsSet")]
        public bool? DisableAppPinIfDevicePinIsSet { get; set; }
    
        /// <summary>
        /// Gets or sets fingerprint blocked.
        /// Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonPropertyName("fingerprintBlocked")]
        public bool? FingerprintBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets managed browser.
        /// Indicates in which managed browser(s) that internet links should be opened. When this property is configured, ManagedBrowserToOpenLinksRequired should be true. Possible values are: notConfigured, microsoftEdge.
        /// </summary>
        [JsonPropertyName("managedBrowser")]
        public ManagedBrowserType? ManagedBrowser { get; set; }
    
        /// <summary>
        /// Gets or sets managed browser to open links required.
        /// Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
        /// </summary>
        [JsonPropertyName("managedBrowserToOpenLinksRequired")]
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }
    
        /// <summary>
        /// Gets or sets maximum allowed device threat level.
        /// Maximum allowed device threat level, as reported by the MTD app. Possible values are: notConfigured, secured, low, medium, high.
        /// </summary>
        [JsonPropertyName("maximumAllowedDeviceThreatLevel")]
        public ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel { get; set; }
    
        /// <summary>
        /// Gets or sets maximum pin retries.
        /// Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
        /// </summary>
        [JsonPropertyName("maximumPinRetries")]
        public Int32? MaximumPinRetries { get; set; }
    
        /// <summary>
        /// Gets or sets minimum pin length.
        /// Minimum pin length required for an app-level pin if PinRequired is set to True
        /// </summary>
        [JsonPropertyName("minimumPinLength")]
        public Int32? MinimumPinLength { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required app version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonPropertyName("minimumRequiredAppVersion")]
        public string MinimumRequiredAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required os version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonPropertyName("minimumRequiredOsVersion")]
        public string MinimumRequiredOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning app version.
        /// Versions less than the specified version will result in warning message on the managed app.
        /// </summary>
        [JsonPropertyName("minimumWarningAppVersion")]
        public string MinimumWarningAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning os version.
        /// Versions less than the specified version will result in warning message on the managed app from accessing company data.
        /// </summary>
        [JsonPropertyName("minimumWarningOsVersion")]
        public string MinimumWarningOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe app version.
        /// Versions less than or equal to the specified version will wipe the managed app and the associated company data.
        /// </summary>
        [JsonPropertyName("minimumWipeAppVersion")]
        public string MinimumWipeAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe os version.
        /// Versions less than or equal to the specified version will wipe the managed app and the associated company data.
        /// </summary>
        [JsonPropertyName("minimumWipeOsVersion")]
        public string MinimumWipeOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets mobile threat defense remediation action.
        /// Determines what action to take if the mobile threat defense threat threshold isn't met. Warn isn't a supported value for this property. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonPropertyName("mobileThreatDefenseRemediationAction")]
        public ManagedAppRemediationAction? MobileThreatDefenseRemediationAction { get; set; }
    
        /// <summary>
        /// Gets or sets notification restriction.
        /// Specify app notification restriction. Possible values are: allow, blockOrganizationalData, block.
        /// </summary>
        [JsonPropertyName("notificationRestriction")]
        public ManagedAppNotificationRestriction? NotificationRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets organizational credentials required.
        /// Indicates whether organizational credentials are required for app use.
        /// </summary>
        [JsonPropertyName("organizationalCredentialsRequired")]
        public bool? OrganizationalCredentialsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets period before pin reset.
        /// TimePeriod before the all-level pin must be reset if PinRequired is set to True.
        /// </summary>
        [JsonPropertyName("periodBeforePinReset")]
        public Duration PeriodBeforePinReset { get; set; }
    
        /// <summary>
        /// Gets or sets period offline before access check.
        /// The period after which access is checked when the device is not connected to the internet.
        /// </summary>
        [JsonPropertyName("periodOfflineBeforeAccessCheck")]
        public Duration PeriodOfflineBeforeAccessCheck { get; set; }
    
        /// <summary>
        /// Gets or sets period offline before wipe is enforced.
        /// The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
        /// </summary>
        [JsonPropertyName("periodOfflineBeforeWipeIsEnforced")]
        public Duration PeriodOfflineBeforeWipeIsEnforced { get; set; }
    
        /// <summary>
        /// Gets or sets period online before access check.
        /// The period after which access is checked when the device is connected to the internet.
        /// </summary>
        [JsonPropertyName("periodOnlineBeforeAccessCheck")]
        public Duration PeriodOnlineBeforeAccessCheck { get; set; }
    
        /// <summary>
        /// Gets or sets pin character set.
        /// Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.
        /// </summary>
        [JsonPropertyName("pinCharacterSet")]
        public ManagedAppPinCharacterSet? PinCharacterSet { get; set; }
    
        /// <summary>
        /// Gets or sets pin required.
        /// Indicates whether an app-level pin is required.
        /// </summary>
        [JsonPropertyName("pinRequired")]
        public bool? PinRequired { get; set; }
    
        /// <summary>
        /// Gets or sets pin required instead of biometric timeout.
        /// Timeout in minutes for an app pin instead of non biometrics passcode
        /// </summary>
        [JsonPropertyName("pinRequiredInsteadOfBiometricTimeout")]
        public Duration PinRequiredInsteadOfBiometricTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets previous pin block count.
        /// Requires a pin to be unique from the number specified in this property.
        /// </summary>
        [JsonPropertyName("previousPinBlockCount")]
        public Int32? PreviousPinBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets print blocked.
        /// Indicates whether printing is allowed from managed apps.
        /// </summary>
        [JsonPropertyName("printBlocked")]
        public bool? PrintBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets save as blocked.
        /// Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
        /// </summary>
        [JsonPropertyName("saveAsBlocked")]
        public bool? SaveAsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets simple pin blocked.
        /// Indicates whether simplePin is blocked.
        /// </summary>
        [JsonPropertyName("simplePinBlocked")]
        public bool? SimplePinBlocked { get; set; }
    
    }
}

