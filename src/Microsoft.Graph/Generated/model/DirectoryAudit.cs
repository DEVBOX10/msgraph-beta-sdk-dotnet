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
    /// The type Directory Audit.
    /// </summary>
    public partial class DirectoryAudit : Entity
    {
    
		///<summary>
		/// The DirectoryAudit constructor
		///</summary>
        public DirectoryAudit()
        {
            this.ODataType = "microsoft.graph.directoryAudit";
        }
	
        /// <summary>
        /// Gets or sets activity date time.
        /// Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("activityDateTime")]
        public DateTimeOffset? ActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets activity display name.
        /// Indicates the activity name or the operation name (E.g. 'Create User', 'Add member to group'). For a list of activities logged, refer to Azure Ad activity list.
        /// </summary>
        [JsonPropertyName("activityDisplayName")]
        public string ActivityDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets additional details.
        /// Indicates additional details on the activity.
        /// </summary>
        [JsonPropertyName("additionalDetails")]
        public IEnumerable<KeyValue> AdditionalDetails { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// Indicates which resource category that's targeted by the activity. (For example: User Management, Group Management etc..)
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.
        /// </summary>
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by.
        /// Indicates information about the user or app initiated the activity.
        /// </summary>
        [JsonPropertyName("initiatedBy")]
        public AuditActivityInitiator InitiatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets logged by service.
        /// Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.
        /// </summary>
        [JsonPropertyName("loggedByService")]
        public string LoggedByService { get; set; }
    
        /// <summary>
        /// Gets or sets operation type.
        /// </summary>
        [JsonPropertyName("operationType")]
        public string OperationType { get; set; }
    
        /// <summary>
        /// Gets or sets result.
        /// Indicates the result of the activity. Possible values are: success, failure, timeout, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("result")]
        public OperationResult? Result { get; set; }
    
        /// <summary>
        /// Gets or sets result reason.
        /// Indicates the reason for failure if the result is 'Failure' or 'timeout'.
        /// </summary>
        [JsonPropertyName("resultReason")]
        public string ResultReason { get; set; }
    
        /// <summary>
        /// Gets or sets target resources.
        /// Indicates information on which resource was changed due to the activity. Target Resource Type can be User, Device, Directory, App, Role, Group, Policy or Other.
        /// </summary>
        [JsonPropertyName("targetResources")]
        public IEnumerable<TargetResource> TargetResources { get; set; }
    
    }
}

