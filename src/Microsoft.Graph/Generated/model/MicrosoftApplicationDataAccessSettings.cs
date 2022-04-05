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
    /// The type Microsoft Application Data Access Settings.
    /// </summary>
    public partial class MicrosoftApplicationDataAccessSettings : Entity
    {
    
        /// <summary>
        /// Gets or sets disabled for group.
        /// The ID of an Azure Active Directory (Azure AD) security group for which the members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge.  This is only applicable if isEnabledForAllMicrosoftApplications is set to true.
        /// </summary>
        [JsonPropertyName("disabledForGroup")]
        public string DisabledForGroup { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled for all microsoft applications.
        /// When set to true, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (for example, Excel, Outlook) or non-Microsoft 365 app (for example, Edge). The default is true.  It is possible to disable this access for a subset of users in an Azure AD security group, by specifying the group in the disabledForGroup property.  When set to false, all users can access authorized Microsoft 365 data only in a Microsoft 365 app.
        /// </summary>
        [JsonPropertyName("isEnabledForAllMicrosoftApplications")]
        public bool? IsEnabledForAllMicrosoftApplications { get; set; }
    
    }
}

