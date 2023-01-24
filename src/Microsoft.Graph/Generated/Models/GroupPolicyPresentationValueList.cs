using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationValueList : GroupPolicyPresentationValue, IParsable {
        /// <summary>A list of pairs for the associated presentation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? Values {
            get { return BackingStore?.Get<List<KeyValuePair>?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> Values {
            get { return BackingStore?.Get<List<KeyValuePair>>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyPresentationValueList CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationValueList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"values", n => { Values = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("values", Values);
        }
    }
}
