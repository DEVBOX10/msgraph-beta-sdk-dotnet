using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Account : Entity, IParsable {
        /// <summary>The blocked property</summary>
        public bool? Blocked { get; set; }
        /// <summary>The category property</summary>
        public string Category { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The subCategory property</summary>
        public string SubCategory { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Account CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Account();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"blocked", (o,n) => { (o as Account).Blocked = n.GetBoolValue(); } },
                {"category", (o,n) => { (o as Account).Category = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Account).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Account).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as Account).Number = n.GetStringValue(); } },
                {"subCategory", (o,n) => { (o as Account).SubCategory = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("blocked", Blocked);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("subCategory", SubCategory);
        }
    }
}
