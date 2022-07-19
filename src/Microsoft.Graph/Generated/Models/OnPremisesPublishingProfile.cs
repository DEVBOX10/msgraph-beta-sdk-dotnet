using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesPublishingProfile : Entity, IParsable {
        /// <summary>List of existing onPremisesAgentGroup objects. Read-only. Nullable.</summary>
        public List<OnPremisesAgentGroup> AgentGroups {
            get { return BackingStore?.Get<List<OnPremisesAgentGroup>>("agentGroups"); }
            set { BackingStore?.Set("agentGroups", value); }
        }
        /// <summary>List of existing onPremisesAgent objects. Read-only. Nullable.</summary>
        public List<OnPremisesAgent> Agents {
            get { return BackingStore?.Get<List<OnPremisesAgent>>("agents"); }
            set { BackingStore?.Set("agents", value); }
        }
        /// <summary>List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.</summary>
        public List<ConnectorGroup> ConnectorGroups {
            get { return BackingStore?.Get<List<ConnectorGroup>>("connectorGroups"); }
            set { BackingStore?.Set("connectorGroups", value); }
        }
        /// <summary>List of existing connector objects for applications published through Application Proxy. Read-only. Nullable.</summary>
        public List<Connector> Connectors {
            get { return BackingStore?.Get<List<Connector>>("connectors"); }
            set { BackingStore?.Set("connectors", value); }
        }
        /// <summary>Represents a hybridAgentUpdaterConfiguration object.</summary>
        public Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration HybridAgentUpdaterConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration>("hybridAgentUpdaterConfiguration"); }
            set { BackingStore?.Set("hybridAgentUpdaterConfiguration", value); }
        }
        /// <summary>Represents if Azure AD Application Proxy is enabled for the tenant.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>List of existing publishedResource objects. Read-only. Nullable.</summary>
        public List<PublishedResource> PublishedResources {
            get { return BackingStore?.Get<List<PublishedResource>>("publishedResources"); }
            set { BackingStore?.Set("publishedResources", value); }
        }
        /// <summary>
        /// Instantiates a new OnPremisesPublishingProfile and sets the default values.
        /// </summary>
        public OnPremisesPublishingProfile() : base() {
            OdataType = "#microsoft.graph.onPremisesPublishingProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnPremisesPublishingProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesPublishingProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentGroups", n => { AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>(OnPremisesAgentGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"agents", n => { Agents = n.GetCollectionOfObjectValues<OnPremisesAgent>(OnPremisesAgent.CreateFromDiscriminatorValue).ToList(); } },
                {"connectorGroups", n => { ConnectorGroups = n.GetCollectionOfObjectValues<ConnectorGroup>(ConnectorGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<Connector>(Connector.CreateFromDiscriminatorValue).ToList(); } },
                {"hybridAgentUpdaterConfiguration", n => { HybridAgentUpdaterConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration>(Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration.CreateFromDiscriminatorValue); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"publishedResources", n => { PublishedResources = n.GetCollectionOfObjectValues<PublishedResource>(PublishedResource.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<OnPremisesAgent>("agents", Agents);
            writer.WriteCollectionOfObjectValues<ConnectorGroup>("connectorGroups", ConnectorGroups);
            writer.WriteCollectionOfObjectValues<Connector>("connectors", Connectors);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration>("hybridAgentUpdaterConfiguration", HybridAgentUpdaterConfiguration);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<PublishedResource>("publishedResources", PublishedResources);
        }
    }
}
