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
    /// The type Device Management Resource Access Profile Assignment.
    /// </summary>
    public partial class DeviceManagementResourceAccessProfileAssignment : Entity
    {
    
		///<summary>
		/// The DeviceManagementResourceAccessProfileAssignment constructor
		///</summary>
        public DeviceManagementResourceAccessProfileAssignment()
        {
            this.ODataType = "microsoft.graph.deviceManagementResourceAccessProfileAssignment";
        }
	
        /// <summary>
        /// Gets or sets intent.
        /// The assignment intent for the resource access profile. Possible values are: apply, remove.
        /// </summary>
        [JsonPropertyName("intent")]
        public DeviceManagementResourceAccessProfileIntent? Intent { get; set; }
    
        /// <summary>
        /// Gets or sets source id.
        /// The identifier of the source of the assignment.
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The assignment target for the resource access profile.
        /// </summary>
        [JsonPropertyName("target")]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
    }
}

