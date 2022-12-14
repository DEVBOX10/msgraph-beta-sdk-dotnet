using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TenantRelationshipAccessPolicyBase : PolicyBase, IParsable {
        /// <summary>The definition property</summary>
        public List<string> Definition {
            get { return BackingStore?.Get<List<string>>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
        /// <summary>
        /// Instantiates a new TenantRelationshipAccessPolicyBase and sets the default values.
        /// </summary>
        public TenantRelationshipAccessPolicyBase() : base() {
            OdataType = "#microsoft.graph.tenantRelationshipAccessPolicyBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantRelationshipAccessPolicyBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.crossTenantAccessPolicy" => new CrossTenantAccessPolicy(),
                _ => new TenantRelationshipAccessPolicyBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definition", n => { Definition = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("definition", Definition);
        }
    }
}
