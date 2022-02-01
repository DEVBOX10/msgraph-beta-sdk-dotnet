// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type TeamworkSystemConfiguration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamworkSystemConfiguration>))]
    public partial class TeamworkSystemConfiguration
    {

        /// <summary>
        /// Gets or sets dateTimeConfiguration.
        /// The date and time configurations for a device.
        /// </summary>
        [JsonPropertyName("dateTimeConfiguration")]
        public TeamworkDateTimeConfiguration DateTimeConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets defaultPassword.
        /// The default password for the device. Write-Only.
        /// </summary>
        [JsonPropertyName("defaultPassword")]
        public string DefaultPassword { get; set; }
    
        /// <summary>
        /// Gets or sets deviceLockTimeout.
        /// The device lock timeout in seconds.
        /// </summary>
        [JsonPropertyName("deviceLockTimeout")]
        public Duration DeviceLockTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets isDeviceLockEnabled.
        /// True if the device lock is enabled.
        /// </summary>
        [JsonPropertyName("isDeviceLockEnabled")]
        public bool? IsDeviceLockEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isLoggingEnabled.
        /// True if logging is enabled.
        /// </summary>
        [JsonPropertyName("isLoggingEnabled")]
        public bool? IsLoggingEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isPowerSavingEnabled.
        /// True if power saving is enabled.
        /// </summary>
        [JsonPropertyName("isPowerSavingEnabled")]
        public bool? IsPowerSavingEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isScreenCaptureEnabled.
        /// True if screen capture is enabled.
        /// </summary>
        [JsonPropertyName("isScreenCaptureEnabled")]
        public bool? IsScreenCaptureEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isSilentModeEnabled.
        /// True if silent mode is enabled.
        /// </summary>
        [JsonPropertyName("isSilentModeEnabled")]
        public bool? IsSilentModeEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// The language option for the device.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or sets lockPin.
        /// The pin that unlocks the device. Write-Only.
        /// </summary>
        [JsonPropertyName("lockPin")]
        public string LockPin { get; set; }
    
        /// <summary>
        /// Gets or sets loggingLevel.
        /// The logging level for the device.
        /// </summary>
        [JsonPropertyName("loggingLevel")]
        public string LoggingLevel { get; set; }
    
        /// <summary>
        /// Gets or sets networkConfiguration.
        /// The network configuration for the device.
        /// </summary>
        [JsonPropertyName("networkConfiguration")]
        public TeamworkNetworkConfiguration NetworkConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
