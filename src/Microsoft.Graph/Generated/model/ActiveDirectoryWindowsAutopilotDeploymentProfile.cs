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
    /// The type Active Directory Windows Autopilot Deployment Profile.
    /// </summary>
    public partial class ActiveDirectoryWindowsAutopilotDeploymentProfile : WindowsAutopilotDeploymentProfile
    {
    
		///<summary>
		/// The ActiveDirectoryWindowsAutopilotDeploymentProfile constructor
		///</summary>
        public ActiveDirectoryWindowsAutopilotDeploymentProfile()
        {
            this.ODataType = "microsoft.graph.activeDirectoryWindowsAutopilotDeploymentProfile";
        }
	
        /// <summary>
        /// Gets or sets hybrid azure adjoin skip connectivity check.
        /// The Autopilot Hybrid Azure AD join flow will continue even if it does not establish domain controller connectivity during OOBE.
        /// </summary>
        [JsonPropertyName("hybridAzureADJoinSkipConnectivityCheck")]
        public bool? HybridAzureADJoinSkipConnectivityCheck { get; set; }
    
        /// <summary>
        /// Gets or sets domain join configuration.
        /// Configuration to join Active Directory domain
        /// </summary>
        [JsonPropertyName("domainJoinConfiguration")]
        public WindowsDomainJoinConfiguration DomainJoinConfiguration { get; set; }
    
    }
}

