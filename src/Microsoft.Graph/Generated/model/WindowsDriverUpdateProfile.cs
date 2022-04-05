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
    /// The type Windows Driver Update Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsDriverUpdateProfile>))]
    public partial class WindowsDriverUpdateProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets approval type.
        /// Driver update profile approval type. For example, manual or automatic approval. Possible values are: manual, automatic.
        /// </summary>
        [JsonPropertyName("approvalType")]
        public DriverUpdateProfileApprovalType? ApprovalType { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date time that the profile was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment deferral in days.
        /// Deployment deferral settings in days, only applicable when ApprovalType is set to automatic approval.
        /// </summary>
        [JsonPropertyName("deploymentDeferralInDays")]
        public Int32? DeploymentDeferralInDays { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the profile which is specified by the user.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets device reporting.
        /// Number of devices reporting for this profile
        /// </summary>
        [JsonPropertyName("deviceReporting")]
        public Int32? DeviceReporting { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the profile.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets inventory sync status.
        /// Driver inventory sync status for this profile.
        /// </summary>
        [JsonPropertyName("inventorySyncStatus")]
        public WindowsDriverUpdateProfileInventorySyncStatus InventorySyncStatus { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date time that the profile was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets new updates.
        /// Number of new driver updates available for this profile.
        /// </summary>
        [JsonPropertyName("newUpdates")]
        public Int32? NewUpdates { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Driver Update entity.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments of the profile.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IWindowsDriverUpdateProfileAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets driver inventories.
        /// Driver inventories for this profile.
        /// </summary>
        [JsonPropertyName("driverInventories")]
        public IWindowsDriverUpdateProfileDriverInventoriesCollectionPage DriverInventories { get; set; }

        /// <summary>
        /// Gets or sets driverInventoriesNextLink.
        /// </summary>
        [JsonPropertyName("driverInventories@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DriverInventoriesNextLink { get; set; }
    
    }
}

