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
    /// The type Privileged Role Settings.
    /// </summary>
    public partial class PrivilegedRoleSettings : Entity
    {
    
		///<summary>
		/// The PrivilegedRoleSettings constructor
		///</summary>
        public PrivilegedRoleSettings()
        {
            this.ODataType = "microsoft.graph.privilegedRoleSettings";
        }
	
        /// <summary>
        /// Gets or sets approval on elevation.
        /// true if the approval is required when activate the role. false if the approval is not required when activate the role.
        /// </summary>
        [JsonPropertyName("approvalOnElevation")]
        public bool? ApprovalOnElevation { get; set; }
    
        /// <summary>
        /// Gets or sets approver ids.
        /// List of Approval ids, if approval is required for activation.
        /// </summary>
        [JsonPropertyName("approverIds")]
        public IEnumerable<string> ApproverIds { get; set; }
    
        /// <summary>
        /// Gets or sets elevation duration.
        /// The duration when the role is activated.
        /// </summary>
        [JsonPropertyName("elevationDuration")]
        public Duration ElevationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets is mfa on elevation configurable.
        /// true if mfaOnElevation is configurable. false if mfaOnElevation is not configurable.
        /// </summary>
        [JsonPropertyName("isMfaOnElevationConfigurable")]
        public bool? IsMfaOnElevationConfigurable { get; set; }
    
        /// <summary>
        /// Gets or sets last global admin.
        /// Internal used only.
        /// </summary>
        [JsonPropertyName("lastGlobalAdmin")]
        public bool? LastGlobalAdmin { get; set; }
    
        /// <summary>
        /// Gets or sets max elavation duration.
        /// Maximal duration for the activated role.
        /// </summary>
        [JsonPropertyName("maxElavationDuration")]
        public Duration MaxElavationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets mfa on elevation.
        /// true if MFA is required to activate the role. false if MFA is not required to activate the role.
        /// </summary>
        [JsonPropertyName("mfaOnElevation")]
        public bool? MfaOnElevation { get; set; }
    
        /// <summary>
        /// Gets or sets min elevation duration.
        /// Minimal duration for the activated role.
        /// </summary>
        [JsonPropertyName("minElevationDuration")]
        public Duration MinElevationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets notification to user on elevation.
        /// true if send notification to the end user when the role is activated. false if do not send notification when the role is activated.
        /// </summary>
        [JsonPropertyName("notificationToUserOnElevation")]
        public bool? NotificationToUserOnElevation { get; set; }
    
        /// <summary>
        /// Gets or sets ticketing info on elevation.
        /// true if the ticketing information is required when activate the role. false if the ticketing information is not required when activate the role.
        /// </summary>
        [JsonPropertyName("ticketingInfoOnElevation")]
        public bool? TicketingInfoOnElevation { get; set; }
    
    }
}

