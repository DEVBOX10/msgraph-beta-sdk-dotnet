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
    /// The type Windows Microsoft Edge App.
    /// </summary>
    public partial class WindowsMicrosoftEdgeApp : MobileApp
    {
    
		///<summary>
		/// The WindowsMicrosoftEdgeApp constructor
		///</summary>
        public WindowsMicrosoftEdgeApp()
        {
            this.ODataType = "microsoft.graph.windowsMicrosoftEdgeApp";
        }
	
        /// <summary>
        /// Gets or sets channel.
        /// The channel to install on target devices. Possible values are: dev, beta, stable.
        /// </summary>
        [JsonPropertyName("channel")]
        public MicrosoftEdgeChannel? Channel { get; set; }
    
        /// <summary>
        /// Gets or sets display language locale.
        /// The language locale to use when the Edge app displays text to the user.
        /// </summary>
        [JsonPropertyName("displayLanguageLocale")]
        public string DisplayLanguageLocale { get; set; }
    
    }
}

