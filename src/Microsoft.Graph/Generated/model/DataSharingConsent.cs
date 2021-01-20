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
    /// The type Data Sharing Consent.
    /// </summary>
    public partial class DataSharingConsent : Entity
    {
    
		///<summary>
		/// The DataSharingConsent constructor
		///</summary>
        public DataSharingConsent()
        {
            this.ODataType = "microsoft.graph.dataSharingConsent";
        }
	
        /// <summary>
        /// Gets or sets grant date time.
        /// The time consent was granted for this account
        /// </summary>
        [JsonPropertyName("grantDateTime")]
        public DateTimeOffset? GrantDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets granted.
        /// The granted state for the data sharing consent
        /// </summary>
        [JsonPropertyName("granted")]
        public bool? Granted { get; set; }
    
        /// <summary>
        /// Gets or sets granted by upn.
        /// The Upn of the user that granted consent for this account
        /// </summary>
        [JsonPropertyName("grantedByUpn")]
        public string GrantedByUpn { get; set; }
    
        /// <summary>
        /// Gets or sets granted by user id.
        /// The UserId of the user that granted consent for this account
        /// </summary>
        [JsonPropertyName("grantedByUserId")]
        public string GrantedByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets service display name.
        /// The display name of the service work flow
        /// </summary>
        [JsonPropertyName("serviceDisplayName")]
        public string ServiceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets terms url.
        /// The TermsUrl for the data sharing consent
        /// </summary>
        [JsonPropertyName("termsUrl")]
        public string TermsUrl { get; set; }
    
    }
}

