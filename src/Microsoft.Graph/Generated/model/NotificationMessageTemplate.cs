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
    /// The type Notification Message Template.
    /// </summary>
    public partial class NotificationMessageTemplate : Entity
    {
    
		///<summary>
		/// The NotificationMessageTemplate constructor
		///</summary>
        public NotificationMessageTemplate()
        {
            this.ODataType = "microsoft.graph.notificationMessageTemplate";
        }
	
        /// <summary>
        /// Gets or sets branding options.
        /// The Message Template Branding Options. Branding is defined in the Intune Admin Console. Possible values are: none, includeCompanyLogo, includeCompanyName, includeContactInformation, includeCompanyPortalLink.
        /// </summary>
        [JsonPropertyName("brandingOptions")]
        public NotificationTemplateBrandingOptions? BrandingOptions { get; set; }
    
        /// <summary>
        /// Gets or sets default locale.
        /// The default locale to fallback onto when the requested locale is not available.
        /// </summary>
        [JsonPropertyName("defaultLocale")]
        public string DefaultLocale { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name for the Notification Message Template.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets localized notification messages.
        /// The list of localized messages for this Notification Message Template.
        /// </summary>
        [JsonPropertyName("localizedNotificationMessages")]
        public INotificationMessageTemplateLocalizedNotificationMessagesCollectionPage LocalizedNotificationMessages { get; set; }
    
    }
}

