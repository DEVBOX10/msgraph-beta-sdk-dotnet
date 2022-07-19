using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Initiator : Identity, IParsable {
        /// <summary>Type of initiator. Possible values are: user, application, system, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.InitiatorType? InitiatorType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InitiatorType?>("initiatorType"); }
            set { BackingStore?.Set("initiatorType", value); }
        }
        /// <summary>
        /// Instantiates a new Initiator and sets the default values.
        /// </summary>
        public Initiator() : base() {
            OdataType = "#microsoft.graph.initiator";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Initiator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Initiator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiatorType", n => { InitiatorType = n.GetEnumValue<InitiatorType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InitiatorType>("initiatorType", InitiatorType);
        }
    }
}
