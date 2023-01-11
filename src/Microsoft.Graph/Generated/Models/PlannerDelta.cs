using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerDelta : Entity, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerDelta CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.businessScenarioTask" => new BusinessScenarioTask(),
                "#microsoft.graph.plannerAssignedToTaskBoardTaskFormat" => new PlannerAssignedToTaskBoardTaskFormat(),
                "#microsoft.graph.plannerBucket" => new PlannerBucket(),
                "#microsoft.graph.plannerBucketTaskBoardTaskFormat" => new PlannerBucketTaskBoardTaskFormat(),
                "#microsoft.graph.plannerPlan" => new PlannerPlan(),
                "#microsoft.graph.plannerPlanDetails" => new PlannerPlanDetails(),
                "#microsoft.graph.plannerProgressTaskBoardTaskFormat" => new PlannerProgressTaskBoardTaskFormat(),
                "#microsoft.graph.plannerTask" => new PlannerTask(),
                "#microsoft.graph.plannerTaskDetails" => new PlannerTaskDetails(),
                "#microsoft.graph.plannerUser" => new PlannerUser(),
                _ => new PlannerDelta(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
