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
    /// The type Privileged Approval.
    /// </summary>
    public partial class PrivilegedApproval : Entity
    {
    
		///<summary>
		/// The PrivilegedApproval constructor
		///</summary>
        public PrivilegedApproval()
        {
            this.ODataType = "microsoft.graph.privilegedApproval";
        }
	
        /// <summary>
        /// Gets or sets approval duration.
        /// </summary>
        [JsonPropertyName("approvalDuration")]
        public Duration ApprovalDuration { get; set; }
    
        /// <summary>
        /// Gets or sets approval state.
        /// Possible values are: pending, approved, denied, aborted, canceled.
        /// </summary>
        [JsonPropertyName("approvalState")]
        public ApprovalState? ApprovalState { get; set; }
    
        /// <summary>
        /// Gets or sets approval type.
        /// </summary>
        [JsonPropertyName("approvalType")]
        public string ApprovalType { get; set; }
    
        /// <summary>
        /// Gets or sets approver reason.
        /// </summary>
        [JsonPropertyName("approverReason")]
        public string ApproverReason { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets requestor reason.
        /// </summary>
        [JsonPropertyName("requestorReason")]
        public string RequestorReason { get; set; }
    
        /// <summary>
        /// Gets or sets role id.
        /// </summary>
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets request.
        /// Read-only. The role assignment request for this approval object
        /// </summary>
        [JsonPropertyName("request")]
        public PrivilegedRoleAssignmentRequest Request { get; set; }
    
        /// <summary>
        /// Gets or sets role info.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("roleInfo")]
        public PrivilegedRole RoleInfo { get; set; }
    
    }
}

