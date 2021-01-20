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
    /// The type Windows Defender Application Control Supplemental Policy Deployment Status.
    /// </summary>
    public partial class WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus : Entity
    {
    
		///<summary>
		/// The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus constructor
		///</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus()
        {
            this.ODataType = "microsoft.graph.windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus";
        }
	
        /// <summary>
        /// Gets or sets deployment status.
        /// The deployment state of the policy. Possible values are: unknown, success, tokenError, notAuthorizedByToken, policyNotFound.
        /// </summary>
        [JsonPropertyName("deploymentStatus")]
        public WindowsDefenderApplicationControlSupplementalPolicyStatuses? DeploymentStatus { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Device ID.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Last sync date time.
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets os description.
        /// Windows OS Version Description.
        /// </summary>
        [JsonPropertyName("osDescription")]
        public string OsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Windows OS Version.
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets policy version.
        /// Human readable version of the WindowsDefenderApplicationControl supplemental policy.
        /// </summary>
        [JsonPropertyName("policyVersion")]
        public string PolicyVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// The name of the user of this device.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets policy.
        /// The navigation link to the WindowsDefenderApplicationControl supplemental policy.
        /// </summary>
        [JsonPropertyName("policy")]
        public WindowsDefenderApplicationControlSupplementalPolicy Policy { get; set; }
    
    }
}

