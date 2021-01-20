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
    /// The type Domain Dns Cname Record.
    /// </summary>
    public partial class DomainDnsCnameRecord : DomainDnsRecord
    {
    
		///<summary>
		/// The DomainDnsCnameRecord constructor
		///</summary>
        public DomainDnsCnameRecord()
        {
            this.ODataType = "microsoft.graph.domainDnsCnameRecord";
        }
	
        /// <summary>
        /// Gets or sets canonical name.
        /// The canonical name of the CNAME record. Used to configure the CNAME record at the DNS host.
        /// </summary>
        [JsonPropertyName("canonicalName")]
        public string CanonicalName { get; set; }
    
    }
}

