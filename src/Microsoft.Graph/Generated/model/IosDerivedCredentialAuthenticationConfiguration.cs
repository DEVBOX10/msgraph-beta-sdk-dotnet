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
    /// The type Ios Derived Credential Authentication Configuration.
    /// </summary>
    public partial class IosDerivedCredentialAuthenticationConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The IosDerivedCredentialAuthenticationConfiguration constructor
		///</summary>
        public IosDerivedCredentialAuthenticationConfiguration()
        {
            this.ODataType = "microsoft.graph.iosDerivedCredentialAuthenticationConfiguration";
        }
	
        /// <summary>
        /// Gets or sets derived credential settings.
        /// Tenant level settings for the Derived Credentials to be used for authentication.
        /// </summary>
        [JsonPropertyName("derivedCredentialSettings")]
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings { get; set; }
    
    }
}

