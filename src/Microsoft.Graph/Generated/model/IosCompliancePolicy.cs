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
    /// The type Ios Compliance Policy.
    /// </summary>
    public partial class IosCompliancePolicy : DeviceCompliancePolicy
    {
    
		///<summary>
		/// The IosCompliancePolicy constructor
		///</summary>
        public IosCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.iosCompliancePolicy";
        }
	
        /// <summary>
        /// Gets or sets advanced threat protection required security level.
        /// MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionRequiredSecurityLevel")]
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection .
        /// </summary>
        [JsonPropertyName("deviceThreatProtectionEnabled")]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonPropertyName("deviceThreatProtectionRequiredSecurityLevel")]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets managed email profile required.
        /// Indicates whether or not to require a managed email profile.
        /// </summary>
        [JsonPropertyName("managedEmailProfileRequired")]
        public bool? ManagedEmailProfileRequired { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum build version.
        /// Maximum IOS build version.
        /// </summary>
        [JsonPropertyName("osMaximumBuildVersion")]
        public string OsMaximumBuildVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum IOS version.
        /// </summary>
        [JsonPropertyName("osMaximumVersion")]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum build version.
        /// Minimum IOS build version.
        /// </summary>
        [JsonPropertyName("osMinimumBuildVersion")]
        public string OsMinimumBuildVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum IOS version.
        /// </summary>
        [JsonPropertyName("osMinimumVersion")]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets passcode block simple.
        /// Indicates whether or not to block simple passcodes.
        /// </summary>
        [JsonPropertyName("passcodeBlockSimple")]
        public bool? PasscodeBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets passcode expiration days.
        /// Number of days before the passcode expires. Valid values 1 to 65535
        /// </summary>
        [JsonPropertyName("passcodeExpirationDays")]
        public Int32? PasscodeExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonPropertyName("passcodeMinimumCharacterSetCount")]
        public Int32? PasscodeMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minimum length.
        /// Minimum length of passcode. Valid values 4 to 14
        /// </summary>
        [JsonPropertyName("passcodeMinimumLength")]
        public Int32? PasscodeMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minutes of inactivity before lock.
        /// Minutes of inactivity before a passcode is required.
        /// </summary>
        [JsonPropertyName("passcodeMinutesOfInactivityBeforeLock")]
        public Int32? PasscodeMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minutes of inactivity before screen timeout.
        /// Minutes of inactivity before the screen times out.
        /// </summary>
        [JsonPropertyName("passcodeMinutesOfInactivityBeforeScreenTimeout")]
        public Int32? PasscodeMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets passcode previous passcode block count.
        /// Number of previous passcodes to block. Valid values 1 to 24
        /// </summary>
        [JsonPropertyName("passcodePreviousPasscodeBlockCount")]
        public Int32? PasscodePreviousPasscodeBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets passcode required.
        /// Indicates whether or not to require a passcode.
        /// </summary>
        [JsonPropertyName("passcodeRequired")]
        public bool? PasscodeRequired { get; set; }
    
        /// <summary>
        /// Gets or sets passcode required type.
        /// The required passcode type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonPropertyName("passcodeRequiredType")]
        public RequiredPasswordType? PasscodeRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets restricted apps.
        /// Require the device to not have the specified apps installed. This collection can contain a maximum of 100 elements.
        /// </summary>
        [JsonPropertyName("restrictedApps")]
        public IEnumerable<AppListItem> RestrictedApps { get; set; }
    
        /// <summary>
        /// Gets or sets security block jailbroken devices.
        /// Devices must not be jailbroken or rooted.
        /// </summary>
        [JsonPropertyName("securityBlockJailbrokenDevices")]
        public bool? SecurityBlockJailbrokenDevices { get; set; }
    
    }
}

