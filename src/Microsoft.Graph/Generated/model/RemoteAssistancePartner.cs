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
    /// The type Remote Assistance Partner.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RemoteAssistancePartner : Entity
    {
    
		///<summary>
		/// The RemoteAssistancePartner constructor
		///</summary>
        public RemoteAssistancePartner()
        {
            this.ODataType = "microsoft.graph.remoteAssistancePartner";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the partner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last connection date time.
        /// Timestamp of the last request sent to Intune by the TEM partner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastConnectionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastConnectionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboarding request expiry date time.
        /// When the OnboardingStatus is Onboarding, This is the date time when the onboarding request expires.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onboardingRequestExpiryDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnboardingRequestExpiryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboarding status.
        /// A friendly description of the current TeamViewer connector status. Possible values are: notOnboarded, onboarding, onboarded.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onboardingStatus", Required = Newtonsoft.Json.Required.Default)]
        public RemoteAssistanceOnboardingStatus? OnboardingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets onboarding url.
        /// URL of the partner's onboarding portal, where an administrator can configure their Remote Assistance service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onboardingUrl", Required = Newtonsoft.Json.Required.Default)]
        public string OnboardingUrl { get; set; }
    
    }
}

