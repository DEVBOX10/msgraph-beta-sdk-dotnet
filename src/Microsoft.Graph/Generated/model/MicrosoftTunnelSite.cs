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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Microsoft Tunnel Site.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MicrosoftTunnelSite : Entity
    {
    
		///<summary>
		/// The MicrosoftTunnelSite constructor
		///</summary>
        public MicrosoftTunnelSite()
        {
            this.ODataType = "microsoft.graph.microsoftTunnelSite";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// The MicrosoftTunnelSite's description
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The MicrosoftTunnelSite's display name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets public address.
        /// The MicrosoftTunnelSite's public domain name or IP address
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publicAddress", Required = Newtonsoft.Json.Required.Default)]
        public string PublicAddress { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade automatically.
        /// The site's automatic upgrade setting. True for automatic upgrades, false for manual control
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upgradeAutomatically", Required = Newtonsoft.Json.Required.Default)]
        public bool? UpgradeAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade available.
        /// True if an upgrade is available
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upgradeAvailable", Required = Newtonsoft.Json.Required.Default)]
        public bool? UpgradeAvailable { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade window end time.
        /// The site's upgrade window end time of day
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upgradeWindowEndTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay UpgradeWindowEndTime { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade window start time.
        /// The site's upgrade window start time of day
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upgradeWindowStartTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay UpgradeWindowStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade window utc offset in minutes.
        /// The site's timezone represented as a minute offset from UTC
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upgradeWindowUtcOffsetInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UpgradeWindowUtcOffsetInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft tunnel configuration.
        /// The MicrosoftTunnelConfiguration that has been applied to this MicrosoftTunnelSite
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftTunnelConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public MicrosoftTunnelConfiguration MicrosoftTunnelConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft tunnel servers.
        /// A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftTunnelServers", Required = Newtonsoft.Json.Required.Default)]
        public IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionPage MicrosoftTunnelServers { get; set; }
    
    }
}

