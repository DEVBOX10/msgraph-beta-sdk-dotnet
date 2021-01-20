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
    /// The type Credential User Registration Count.
    /// </summary>
    public partial class CredentialUserRegistrationCount : Entity
    {
    
		///<summary>
		/// The CredentialUserRegistrationCount constructor
		///</summary>
        public CredentialUserRegistrationCount()
        {
            this.ODataType = "microsoft.graph.credentialUserRegistrationCount";
        }
	
        /// <summary>
        /// Gets or sets total user count.
        /// Provides the total user count in the tenant.
        /// </summary>
        [JsonPropertyName("totalUserCount")]
        public Int64? TotalUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets user registration counts.
        /// A collection of registration count and status information for users in your tenant.
        /// </summary>
        [JsonPropertyName("userRegistrationCounts")]
        public IEnumerable<UserRegistrationCount> UserRegistrationCounts { get; set; }
    
    }
}

