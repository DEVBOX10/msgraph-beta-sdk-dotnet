using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class InformationProtectionPolicySetting : Entity, IParsable {
        /// <summary>The defaultLabelId property</summary>
        public string DefaultLabelId { get; set; }
        /// <summary>The isDowngradeJustificationRequired property</summary>
        public bool? IsDowngradeJustificationRequired { get; set; }
        /// <summary>The isMandatory property</summary>
        public bool? IsMandatory { get; set; }
        /// <summary>The moreInfoUrl property</summary>
        public string MoreInfoUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InformationProtectionPolicySetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtectionPolicySetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultLabelId", n => { DefaultLabelId = n.GetStringValue(); } },
                {"isDowngradeJustificationRequired", n => { IsDowngradeJustificationRequired = n.GetBoolValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
                {"moreInfoUrl", n => { MoreInfoUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultLabelId", DefaultLabelId);
            writer.WriteBoolValue("isDowngradeJustificationRequired", IsDowngradeJustificationRequired);
            writer.WriteBoolValue("isMandatory", IsMandatory);
            writer.WriteStringValue("moreInfoUrl", MoreInfoUrl);
        }
    }
}
