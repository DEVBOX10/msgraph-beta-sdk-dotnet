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
    /// The type Windows Defender Advanced Threat Protection Configuration.
    /// </summary>
    public partial class WindowsDefenderAdvancedThreatProtectionConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The WindowsDefenderAdvancedThreatProtectionConfiguration constructor
		///</summary>
        public WindowsDefenderAdvancedThreatProtectionConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration";
        }
	
        /// <summary>
        /// Gets or sets advanced threat protection auto populate onboarding blob.
        /// Auto populate onboarding blob programmatically from Advanced Threat protection service
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionAutoPopulateOnboardingBlob")]
        public bool? AdvancedThreatProtectionAutoPopulateOnboardingBlob { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection offboarding blob.
        /// Windows Defender AdvancedThreatProtection Offboarding Blob.
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionOffboardingBlob")]
        public string AdvancedThreatProtectionOffboardingBlob { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection offboarding filename.
        /// Name of the file from which AdvancedThreatProtectionOffboardingBlob was obtained.
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionOffboardingFilename")]
        public string AdvancedThreatProtectionOffboardingFilename { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection onboarding blob.
        /// Windows Defender AdvancedThreatProtection Onboarding Blob.
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionOnboardingBlob")]
        public string AdvancedThreatProtectionOnboardingBlob { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection onboarding filename.
        /// Name of the file from which AdvancedThreatProtectionOnboardingBlob was obtained.
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionOnboardingFilename")]
        public string AdvancedThreatProtectionOnboardingFilename { get; set; }
    
        /// <summary>
        /// Gets or sets allow sample sharing.
        /// Windows Defender AdvancedThreatProtection 'Allow Sample Sharing' Rule
        /// </summary>
        [JsonPropertyName("allowSampleSharing")]
        public bool? AllowSampleSharing { get; set; }
    
        /// <summary>
        /// Gets or sets enable expedited telemetry reporting.
        /// Expedite Windows Defender Advanced Threat Protection telemetry reporting frequency.
        /// </summary>
        [JsonPropertyName("enableExpeditedTelemetryReporting")]
        public bool? EnableExpeditedTelemetryReporting { get; set; }
    
    }
}

