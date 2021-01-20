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
    /// The type Android Oma Cp Configuration.
    /// </summary>
    public partial class AndroidOmaCpConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The AndroidOmaCpConfiguration constructor
		///</summary>
        public AndroidOmaCpConfiguration()
        {
            this.ODataType = "microsoft.graph.androidOmaCpConfiguration";
        }
	
        /// <summary>
        /// Gets or sets configuration xml.
        /// Configuration XML that will be applied to the device. When it is read, it only provides a placeholder string since the original data is encrypted and stored.
        /// </summary>
        [JsonPropertyName("configurationXml")]
        public byte[] ConfigurationXml { get; set; }
    
    }
}

