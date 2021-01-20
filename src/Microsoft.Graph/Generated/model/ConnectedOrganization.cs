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
    /// The type Connected Organization.
    /// </summary>
    public partial class ConnectedOrganization : Entity
    {
    
		///<summary>
		/// The ConnectedOrganization constructor
		///</summary>
        public ConnectedOrganization()
        {
            this.ODataType = "microsoft.graph.connectedOrganization";
        }
	
        /// <summary>
        /// Gets or sets created by.
        /// UPN of the user who created this resource. Read-only.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the connected organization.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the connected organization.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets identity sources.
        /// </summary>
        [JsonPropertyName("identitySources")]
        public IEnumerable<IdentitySource> IdentitySources { get; set; }
    
        /// <summary>
        /// Gets or sets modified by.
        /// UPN of the user who last modified this resource. Read-only.
        /// </summary>
        [JsonPropertyName("modifiedBy")]
        public string ModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of a connected organization defines whether assignment policies with requestor scope type AllConfiguredConnectedOrganizationSubjects are applicable or not. Possible values are: configured, proposed.
        /// </summary>
        [JsonPropertyName("state")]
        public ConnectedOrganizationState? State { get; set; }
    
        /// <summary>
        /// Gets or sets external sponsors.
        /// Nullable.
        /// </summary>
        [JsonPropertyName("externalSponsors")]
        public IConnectedOrganizationExternalSponsorsCollectionPage ExternalSponsors { get; set; }
    
        /// <summary>
        /// Gets or sets internal sponsors.
        /// Nullable.
        /// </summary>
        [JsonPropertyName("internalSponsors")]
        public IConnectedOrganizationInternalSponsorsCollectionPage InternalSponsors { get; set; }
    
    }
}

