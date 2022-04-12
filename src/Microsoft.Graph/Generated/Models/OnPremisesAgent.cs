using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesAgent : Entity, IParsable {
        /// <summary>List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.</summary>
        public List<OnPremisesAgentGroup> AgentGroups { get; set; }
        /// <summary>The external IP address as detected by the service for the agent machine. Read-only</summary>
        public string ExternalIp { get; set; }
        /// <summary>The name of the machine that the aggent is running on. Read-only</summary>
        public string MachineName { get; set; }
        /// <summary>Possible values are: active, inactive.</summary>
        public AgentStatus? Status { get; set; }
        /// <summary>The supportedPublishingTypes property</summary>
        public List<OnPremisesPublishingType?> SupportedPublishingTypes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnPremisesAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentGroups", n => { AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>(OnPremisesAgentGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"externalIp", n => { ExternalIp = n.GetStringValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AgentStatus>(); } },
                {"supportedPublishingTypes", n => { SupportedPublishingTypes = n.GetCollectionOfEnumValues<OnPremisesPublishingType>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnPremisesAgentGroup>("agentGroups", AgentGroups);
            writer.WriteStringValue("externalIp", ExternalIp);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteEnumValue<AgentStatus>("status", Status);
            writer.WriteCollectionOfEnumValues<OnPremisesPublishingType>("supportedPublishingTypes", SupportedPublishingTypes);
        }
    }
}
