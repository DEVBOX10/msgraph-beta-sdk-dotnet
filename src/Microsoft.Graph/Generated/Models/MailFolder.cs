using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class MailFolder : Entity, IParsable {
        /// <summary>The number of immediate child mailFolders in the current mailFolder.</summary>
        public int? ChildFolderCount {
            get { return BackingStore?.Get<int?>("childFolderCount"); }
            set { BackingStore?.Set("childFolderCount", value); }
        }
        /// <summary>The collection of child folders in the mailFolder.</summary>
        public List<MailFolder> ChildFolders {
            get { return BackingStore?.Get<List<MailFolder>>("childFolders"); }
            set { BackingStore?.Set("childFolders", value); }
        }
        /// <summary>The mailFolder&apos;s display name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Indicates whether the mailFolder is hidden. This property can be set only when creating the folder. Find more information in Hidden mail folders.</summary>
        public bool? IsHidden {
            get { return BackingStore?.Get<bool?>("isHidden"); }
            set { BackingStore?.Set("isHidden", value); }
        }
        /// <summary>The collection of rules that apply to the user&apos;s Inbox folder.</summary>
        public List<MessageRule> MessageRules {
            get { return BackingStore?.Get<List<MessageRule>>("messageRules"); }
            set { BackingStore?.Set("messageRules", value); }
        }
        /// <summary>The collection of messages in the mailFolder.</summary>
        public List<Message> Messages {
            get { return BackingStore?.Get<List<Message>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
        /// <summary>The unique identifier for the mailFolder&apos;s parent mailFolder.</summary>
        public string ParentFolderId {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
        /// <summary>The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
        /// <summary>The number of items in the mailFolder.</summary>
        public int? TotalItemCount {
            get { return BackingStore?.Get<int?>("totalItemCount"); }
            set { BackingStore?.Set("totalItemCount", value); }
        }
        /// <summary>The number of items in the mailFolder marked as unread.</summary>
        public int? UnreadItemCount {
            get { return BackingStore?.Get<int?>("unreadItemCount"); }
            set { BackingStore?.Set("unreadItemCount", value); }
        }
        /// <summary>The userConfigurations property</summary>
        public List<UserConfiguration> UserConfigurations {
            get { return BackingStore?.Get<List<UserConfiguration>>("userConfigurations"); }
            set { BackingStore?.Set("userConfigurations", value); }
        }
        /// <summary>The well-known folder name for the folder. The possible values are listed above. This property is only set for default folders created by Outlook. For other folders, this property is null.</summary>
        public string WellKnownName {
            get { return BackingStore?.Get<string>("wellKnownName"); }
            set { BackingStore?.Set("wellKnownName", value); }
        }
        /// <summary>
        /// Instantiates a new mailFolder and sets the default values.
        /// </summary>
        public MailFolder() : base() {
            OdataType = "#microsoft.graph.mailFolder";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MailFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.mailSearchFolder" => new MailSearchFolder(),
                _ => new MailFolder(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childFolderCount", n => { ChildFolderCount = n.GetIntValue(); } },
                {"childFolders", n => { ChildFolders = n.GetCollectionOfObjectValues<MailFolder>(MailFolder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isHidden", n => { IsHidden = n.GetBoolValue(); } },
                {"messageRules", n => { MessageRules = n.GetCollectionOfObjectValues<MessageRule>(MessageRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<Message>(Message.CreateFromDiscriminatorValue)?.ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalItemCount", n => { TotalItemCount = n.GetIntValue(); } },
                {"unreadItemCount", n => { UnreadItemCount = n.GetIntValue(); } },
                {"userConfigurations", n => { UserConfigurations = n.GetCollectionOfObjectValues<UserConfiguration>(UserConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wellKnownName", n => { WellKnownName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("childFolderCount", ChildFolderCount);
            writer.WriteCollectionOfObjectValues<MailFolder>("childFolders", ChildFolders);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteCollectionOfObjectValues<MessageRule>("messageRules", MessageRules);
            writer.WriteCollectionOfObjectValues<Message>("messages", Messages);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteIntValue("totalItemCount", TotalItemCount);
            writer.WriteIntValue("unreadItemCount", UnreadItemCount);
            writer.WriteCollectionOfObjectValues<UserConfiguration>("userConfigurations", UserConfigurations);
            writer.WriteStringValue("wellKnownName", WellKnownName);
        }
    }
}
