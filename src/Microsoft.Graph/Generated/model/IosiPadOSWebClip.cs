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
    /// The type Iosi Pad OSWeb Clip.
    /// </summary>
    public partial class IosiPadOSWebClip : MobileApp
    {
    
        ///<summary>
        /// The IosiPadOSWebClip constructor
        ///</summary>
        public IosiPadOSWebClip()
        {
            this.ODataType = "microsoft.graph.iosiPadOSWebClip";
        }

        /// <summary>
        /// Gets or sets app url.
        /// Indicates iOS/iPadOS web clip app URL. Example: 'https://www.contoso.com'
        /// </summary>
        [JsonPropertyName("appUrl")]
        public string AppUrl { get; set; }
    
        /// <summary>
        /// Gets or sets use managed browser.
        /// Whether or not to use managed browser. When TRUE, the app will be required to be opened in Microsoft Edge. When FALSE, the app will not be required to be opened in Microsoft Edge. By default, this property is set to FALSE.
        /// </summary>
        [JsonPropertyName("useManagedBrowser")]
        public bool? UseManagedBrowser { get; set; }
    
    }
}

