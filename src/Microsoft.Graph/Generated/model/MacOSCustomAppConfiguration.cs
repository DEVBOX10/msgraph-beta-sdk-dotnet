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
    /// The type Mac OSCustom App Configuration.
    /// </summary>
    public partial class MacOSCustomAppConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The MacOSCustomAppConfiguration constructor
		///</summary>
        public MacOSCustomAppConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSCustomAppConfiguration";
        }
	
        /// <summary>
        /// Gets or sets bundle id.
        /// Bundle id for targeting.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets configuration xml.
        /// Configuration xml. (UTF8 encoded byte array)
        /// </summary>
        [JsonPropertyName("configurationXml")]
        public byte[] ConfigurationXml { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// Configuration file name (.plist
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
    }
}

