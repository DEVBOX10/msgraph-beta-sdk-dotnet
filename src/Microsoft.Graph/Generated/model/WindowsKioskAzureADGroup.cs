// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WindowsKioskAzureADGroup.
    /// </summary>
    public partial class WindowsKioskAzureADGroup : WindowsKioskUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsKioskAzureADGroup"/> class.
        /// </summary>
        public WindowsKioskAzureADGroup()
        {
            this.ODataType = "microsoft.graph.windowsKioskAzureADGroup";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The display name of the AzureAD group that will be locked to this kiosk configuration
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets groupId.
        /// The ID of the AzureAD group that will be locked to this kiosk configuration
        /// </summary>
        [JsonPropertyName("groupId")]
        public string GroupId { get; set; }
    
    }
}
