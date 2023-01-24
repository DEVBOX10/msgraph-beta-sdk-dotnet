using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MessageTrace : Entity, IParsable {
        /// <summary>The destinationIPAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationIPAddress {
            get { return BackingStore?.Get<string?>("destinationIPAddress"); }
            set { BackingStore?.Set("destinationIPAddress", value); }
        }
#nullable restore
#else
        public string DestinationIPAddress {
            get { return BackingStore?.Get<string>("destinationIPAddress"); }
            set { BackingStore?.Set("destinationIPAddress", value); }
        }
#endif
        /// <summary>The messageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageId {
            get { return BackingStore?.Get<string?>("messageId"); }
            set { BackingStore?.Set("messageId", value); }
        }
#nullable restore
#else
        public string MessageId {
            get { return BackingStore?.Get<string>("messageId"); }
            set { BackingStore?.Set("messageId", value); }
        }
#endif
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MessageRecipient>? Recipients {
            get { return BackingStore?.Get<List<MessageRecipient>?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#nullable restore
#else
        public List<MessageRecipient> Recipients {
            get { return BackingStore?.Get<List<MessageRecipient>>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#endif
        /// <summary>The senderEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderEmail {
            get { return BackingStore?.Get<string?>("senderEmail"); }
            set { BackingStore?.Set("senderEmail", value); }
        }
#nullable restore
#else
        public string SenderEmail {
            get { return BackingStore?.Get<string>("senderEmail"); }
            set { BackingStore?.Set("senderEmail", value); }
        }
#endif
        /// <summary>The size property</summary>
        public int? Size {
            get { return BackingStore?.Get<int?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The sourceIPAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceIPAddress {
            get { return BackingStore?.Get<string?>("sourceIPAddress"); }
            set { BackingStore?.Set("sourceIPAddress", value); }
        }
#nullable restore
#else
        public string SourceIPAddress {
            get { return BackingStore?.Get<string>("sourceIPAddress"); }
            set { BackingStore?.Set("sourceIPAddress", value); }
        }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MessageTrace CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageTrace();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"destinationIPAddress", n => { DestinationIPAddress = n.GetStringValue(); } },
                {"messageId", n => { MessageId = n.GetStringValue(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipients", n => { Recipients = n.GetCollectionOfObjectValues<MessageRecipient>(MessageRecipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"senderEmail", n => { SenderEmail = n.GetStringValue(); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"sourceIPAddress", n => { SourceIPAddress = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("destinationIPAddress", DestinationIPAddress);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<MessageRecipient>("recipients", Recipients);
            writer.WriteStringValue("senderEmail", SenderEmail);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("sourceIPAddress", SourceIPAddress);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
