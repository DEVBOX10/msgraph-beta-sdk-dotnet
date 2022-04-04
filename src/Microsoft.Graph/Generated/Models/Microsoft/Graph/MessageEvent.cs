using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MessageEvent : Entity, IParsable {
        /// <summary>The dateTime property</summary>
        public DateTimeOffset? DateTime { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The eventType property</summary>
        public MessageEventType? EventType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MessageEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"dateTime", (o,n) => { (o as MessageEvent).DateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as MessageEvent).Description = n.GetStringValue(); } },
                {"eventType", (o,n) => { (o as MessageEvent).EventType = n.GetEnumValue<MessageEventType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<MessageEventType>("eventType", EventType);
        }
    }
}
