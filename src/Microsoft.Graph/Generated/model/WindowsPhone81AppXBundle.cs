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
    /// The type Windows Phone81App XBundle.
    /// </summary>
    public partial class WindowsPhone81AppXBundle : WindowsPhone81AppX
    {
    
		///<summary>
		/// The WindowsPhone81AppXBundle constructor
		///</summary>
        public WindowsPhone81AppXBundle()
        {
            this.ODataType = "microsoft.graph.windowsPhone81AppXBundle";
        }
	
        /// <summary>
        /// Gets or sets app xpackage information list.
        /// The list of AppX Package Information.
        /// </summary>
        [JsonPropertyName("appXPackageInformationList")]
        public IEnumerable<WindowsPackageInformation> AppXPackageInformationList { get; set; }
    
    }
}

