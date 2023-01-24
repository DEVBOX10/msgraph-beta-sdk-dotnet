using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskConfiguration : Entity, IParsable {
        /// <summary>Policy configuration for tasks created for the businessScenario when they are being changed outside of the scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskPolicy? EditPolicy {
            get { return BackingStore?.Get<PlannerTaskPolicy?>("editPolicy"); }
            set { BackingStore?.Set("editPolicy", value); }
        }
#nullable restore
#else
        public PlannerTaskPolicy EditPolicy {
            get { return BackingStore?.Get<PlannerTaskPolicy>("editPolicy"); }
            set { BackingStore?.Set("editPolicy", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTaskConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"editPolicy", n => { EditPolicy = n.GetObjectValue<PlannerTaskPolicy>(PlannerTaskPolicy.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerTaskPolicy>("editPolicy", EditPolicy);
        }
    }
}
