// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SimulationNotification : BaseEndUserNotification, IParsable {
        /// <summary>Target user type. Possible values are: unknown, clicked, compromised, allUsers, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.TargettedUserType? TargettedUserType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TargettedUserType?>("targettedUserType"); }
            set { BackingStore?.Set("targettedUserType", value); }
        }
        /// <summary>
        /// Instantiates a new simulationNotification and sets the default values.
        /// </summary>
        public SimulationNotification() : base() {
            OdataType = "#microsoft.graph.simulationNotification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SimulationNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targettedUserType", n => { TargettedUserType = n.GetEnumValue<TargettedUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TargettedUserType>("targettedUserType", TargettedUserType);
        }
    }
}
