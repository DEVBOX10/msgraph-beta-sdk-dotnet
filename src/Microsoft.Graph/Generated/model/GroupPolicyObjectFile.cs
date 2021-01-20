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
    /// The type Group Policy Object File.
    /// </summary>
    public partial class GroupPolicyObjectFile : Entity
    {
    
		///<summary>
		/// The GroupPolicyObjectFile constructor
		///</summary>
        public GroupPolicyObjectFile()
        {
            this.ODataType = "microsoft.graph.groupPolicyObjectFile";
        }
	
        /// <summary>
        /// Gets or sets content.
        /// The Group Policy Object file content.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time at which the GroupPolicy was first uploaded.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets group policy object id.
        /// The Group Policy Object GUID from GPO Xml content
        /// </summary>
        [JsonPropertyName("groupPolicyObjectId")]
        public Guid? GroupPolicyObjectId { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time at which the GroupPolicyObjectFile was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets ou distinguished name.
        /// The distinguished name of the OU.
        /// </summary>
        [JsonPropertyName("ouDistinguishedName")]
        public string OuDistinguishedName { get; set; }
    
    }
}

