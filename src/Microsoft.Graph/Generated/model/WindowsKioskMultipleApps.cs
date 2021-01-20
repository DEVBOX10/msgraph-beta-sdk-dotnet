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
    /// The type WindowsKioskMultipleApps.
    /// </summary>
    public partial class WindowsKioskMultipleApps : WindowsKioskAppConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsKioskMultipleApps"/> class.
        /// </summary>
        public WindowsKioskMultipleApps()
        {
            this.ODataType = "microsoft.graph.windowsKioskMultipleApps";
        }

        /// <summary>
        /// Gets or sets allowAccessToDownloadsFolder.
        /// This setting allows access to Downloads folder in file explorer.
        /// </summary>
        [JsonPropertyName("allowAccessToDownloadsFolder")]
        public bool? AllowAccessToDownloadsFolder { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// These are the only Windows Store Apps that will be available to launch from the Start menu. This collection can contain a maximum of 128 elements.
        /// </summary>
        [JsonPropertyName("apps")]
        public IEnumerable<WindowsKioskAppBase> Apps { get; set; }
    
        /// <summary>
        /// Gets or sets disallowDesktopApps.
        /// This setting indicates that desktop apps are allowed. Default to true.
        /// </summary>
        [JsonPropertyName("disallowDesktopApps")]
        public bool? DisallowDesktopApps { get; set; }
    
        /// <summary>
        /// Gets or sets showTaskBar.
        /// This setting allows the admin to specify whether the Task Bar is shown or not.
        /// </summary>
        [JsonPropertyName("showTaskBar")]
        public bool? ShowTaskBar { get; set; }
    
        /// <summary>
        /// Gets or sets startMenuLayoutXml.
        /// Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.
        /// </summary>
        [JsonPropertyName("startMenuLayoutXml")]
        public byte[] StartMenuLayoutXml { get; set; }
    
    }
}
