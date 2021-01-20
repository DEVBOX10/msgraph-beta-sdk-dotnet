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
    /// The type Privileged Role Assignment.
    /// </summary>
    public partial class PrivilegedRoleAssignment : Entity
    {
    
		///<summary>
		/// The PrivilegedRoleAssignment constructor
		///</summary>
        public PrivilegedRoleAssignment()
        {
            this.ODataType = "microsoft.graph.privilegedRoleAssignment";
        }
	
        /// <summary>
        /// Gets or sets expiration date time.
        /// The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is elevated.
        /// true if the role assignment is activated. false if the role assignment is deactivated.
        /// </summary>
        [JsonPropertyName("isElevated")]
        public bool? IsElevated { get; set; }
    
        /// <summary>
        /// Gets or sets result message.
        /// Result message set by the service.
        /// </summary>
        [JsonPropertyName("resultMessage")]
        public string ResultMessage { get; set; }
    
        /// <summary>
        /// Gets or sets role id.
        /// Role identifier. In GUID string format.
        /// </summary>
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// User identifier. In GUID string format.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets role info.
        /// Read-only. Nullable. The associated role information.
        /// </summary>
        [JsonPropertyName("roleInfo")]
        public PrivilegedRole RoleInfo { get; set; }
    
    }
}

