using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AllowedDataLocation : Entity, IParsable {
        /// <summary>The appId property</summary>
        public string AppId { get; set; }
        /// <summary>The domain property</summary>
        public string Domain { get; set; }
        /// <summary>The isDefault property</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The location property</summary>
        public string Location { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AllowedDataLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AllowedDataLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"domain", n => { Domain = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("domain", Domain);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("location", Location);
        }
    }
}
