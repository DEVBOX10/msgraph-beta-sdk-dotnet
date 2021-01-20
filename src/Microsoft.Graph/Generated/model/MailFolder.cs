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
    /// The type Mail Folder.
    /// </summary>
    public partial class MailFolder : Entity
    {
    
		///<summary>
		/// The MailFolder constructor
		///</summary>
        public MailFolder()
        {
            this.ODataType = "microsoft.graph.mailFolder";
        }
	
        /// <summary>
        /// Gets or sets child folder count.
        /// The number of immediate child mailFolders in the current mailFolder.
        /// </summary>
        [JsonPropertyName("childFolderCount")]
        public Int32? ChildFolderCount { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The mailFolder's display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is hidden.
        /// Indicates whether the mailFolder is hidden. This property can be set only when creating the folder. Find more information in Hidden mail folders.
        /// </summary>
        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The unique identifier for the mailFolder's parent mailFolder.
        /// </summary>
        [JsonPropertyName("parentFolderId")]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets total item count.
        /// The number of items in the mailFolder.
        /// </summary>
        [JsonPropertyName("totalItemCount")]
        public Int32? TotalItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets unread item count.
        /// The number of items in the mailFolder marked as unread.
        /// </summary>
        [JsonPropertyName("unreadItemCount")]
        public Int32? UnreadItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets well known name.
        /// The well-known folder name for the folder. The possible values are listed above. This property is only set for default folders created by Outlook. For other folders, this property is null.
        /// </summary>
        [JsonPropertyName("wellKnownName")]
        public string WellKnownName { get; set; }
    
        /// <summary>
        /// Gets or sets child folders.
        /// The collection of child folders in the mailFolder.
        /// </summary>
        [JsonPropertyName("childFolders")]
        public IMailFolderChildFoldersCollectionPage ChildFolders { get; set; }
    
        /// <summary>
        /// Gets or sets message rules.
        /// The collection of rules that apply to the user's Inbox folder.
        /// </summary>
        [JsonPropertyName("messageRules")]
        public IMailFolderMessageRulesCollectionPage MessageRules { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// The collection of messages in the mailFolder.
        /// </summary>
        [JsonPropertyName("messages")]
        public IMailFolderMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IMailFolderMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IMailFolderSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets user configurations.
        /// </summary>
        [JsonPropertyName("userConfigurations")]
        public IMailFolderUserConfigurationsCollectionPage UserConfigurations { get; set; }
    
    }
}

