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
    /// The type Windows Kiosk Configuration.
    /// </summary>
    public partial class WindowsKioskConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The WindowsKioskConfiguration constructor
		///</summary>
        public WindowsKioskConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsKioskConfiguration";
        }
	
        /// <summary>
        /// Gets or sets edge kiosk enable public browsing.
        /// Enable public browsing kiosk mode for the Microsoft Edge browser. The Default is false.
        /// </summary>
        [JsonPropertyName("edgeKioskEnablePublicBrowsing")]
        public bool? EdgeKioskEnablePublicBrowsing { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser blocked url exceptions.
        /// Specify URLs that the kiosk browser is allowed to navigate to
        /// </summary>
        [JsonPropertyName("kioskBrowserBlockedUrlExceptions")]
        public IEnumerable<string> KioskBrowserBlockedUrlExceptions { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser blocked urls.
        /// Specify URLs that the kiosk browsers should not navigate to
        /// </summary>
        [JsonPropertyName("kioskBrowserBlockedURLs")]
        public IEnumerable<string> KioskBrowserBlockedURLs { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser default url.
        /// Specify the default URL the browser should navigate to on launch.
        /// </summary>
        [JsonPropertyName("kioskBrowserDefaultUrl")]
        public string KioskBrowserDefaultUrl { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser enable end session button.
        /// Enable the kiosk browser's end session button. By default, the end session button is disabled.
        /// </summary>
        [JsonPropertyName("kioskBrowserEnableEndSessionButton")]
        public bool? KioskBrowserEnableEndSessionButton { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser enable home button.
        /// Enable the kiosk browser's home button. By default, the home button is disabled.
        /// </summary>
        [JsonPropertyName("kioskBrowserEnableHomeButton")]
        public bool? KioskBrowserEnableHomeButton { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser enable navigation buttons.
        /// Enable the kiosk browser's navigation buttons(forward/back). By default, the navigation buttons are disabled.
        /// </summary>
        [JsonPropertyName("kioskBrowserEnableNavigationButtons")]
        public bool? KioskBrowserEnableNavigationButtons { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser restart on idle time in minutes.
        /// Specify the number of minutes the session is idle until the kiosk browser restarts in a fresh state.  Valid values are 1-1440. Valid values 1 to 1440
        /// </summary>
        [JsonPropertyName("kioskBrowserRestartOnIdleTimeInMinutes")]
        public Int32? KioskBrowserRestartOnIdleTimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk profiles.
        /// This policy setting allows to define a list of Kiosk profiles for a Kiosk configuration. This collection can contain a maximum of 3 elements.
        /// </summary>
        [JsonPropertyName("kioskProfiles")]
        public IEnumerable<WindowsKioskProfile> KioskProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets windows kiosk force update schedule.
        /// force update schedule for Kiosk devices.
        /// </summary>
        [JsonPropertyName("windowsKioskForceUpdateSchedule")]
        public WindowsKioskForceUpdateSchedule WindowsKioskForceUpdateSchedule { get; set; }
    
    }
}

