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
    /// The type Teams Async Operation.
    /// </summary>
    public partial class TeamsAsyncOperation : Entity
    {
    
		///<summary>
		/// The TeamsAsyncOperation constructor
		///</summary>
        public TeamsAsyncOperation()
        {
            this.ODataType = "microsoft.graph.teamsAsyncOperation";
        }
	
        /// <summary>
        /// Gets or sets attempts count.
        /// Number of times the operation was attempted before being marked successful or failed.
        /// </summary>
        [JsonPropertyName("attemptsCount")]
        public Int32? AttemptsCount { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Time when the operation was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// Any error that causes the async operation to fail.
        /// </summary>
        [JsonPropertyName("error")]
        public OperationError Error { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// Time when the async operation was last updated.
        /// </summary>
        [JsonPropertyName("lastActionDateTime")]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets operation type.
        /// Denotes which type of operation is being described.
        /// </summary>
        [JsonPropertyName("operationType")]
        public TeamsAsyncOperationType? OperationType { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Operation status.
        /// </summary>
        [JsonPropertyName("status")]
        public TeamsAsyncOperationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets target resource id.
        /// The ID of the object that's created or modified as result of this async operation, typically a team.
        /// </summary>
        [JsonPropertyName("targetResourceId")]
        public string TargetResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets target resource location.
        /// The location of the object that's created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.
        /// </summary>
        [JsonPropertyName("targetResourceLocation")]
        public string TargetResourceLocation { get; set; }
    
    }
}

