using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerExternalTaskSource : PlannerTaskCreation, IParsable {
        /// <summary>Nullable. An identifier for the scenario associated with this external source. This should be in reverse DNS format. For example, Contoso company owned application for customer support would have a value like &apos;com.constoso.customerSupport&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextScenarioId {
            get { return BackingStore?.Get<string?>("contextScenarioId"); }
            set { BackingStore?.Set("contextScenarioId", value); }
        }
#nullable restore
#else
        public string ContextScenarioId {
            get { return BackingStore?.Get<string>("contextScenarioId"); }
            set { BackingStore?.Set("contextScenarioId", value); }
        }
#endif
        /// <summary>Specifies how an application should display the link to the associated plannerExternalTaskSource. The possible values are: none, default.</summary>
        public PlannerExternalTaskSourceDisplayType? DisplayLinkType {
            get { return BackingStore?.Get<PlannerExternalTaskSourceDisplayType?>("displayLinkType"); }
            set { BackingStore?.Set("displayLinkType", value); }
        }
        /// <summary>The segments of the name of the external experience. Segments represent a hierarchical structure that allows other apps to display the relationship.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisplayNameSegments {
            get { return BackingStore?.Get<List<string>?>("displayNameSegments"); }
            set { BackingStore?.Set("displayNameSegments", value); }
        }
#nullable restore
#else
        public List<string> DisplayNameSegments {
            get { return BackingStore?.Get<List<string>>("displayNameSegments"); }
            set { BackingStore?.Set("displayNameSegments", value); }
        }
#endif
        /// <summary>Nullable. The id of the external entity&apos;s containing entity or context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalContextId {
            get { return BackingStore?.Get<string?>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
#nullable restore
#else
        public string ExternalContextId {
            get { return BackingStore?.Get<string>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
#endif
        /// <summary>Nullable. The id of the entity that an external service associates with a task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalObjectId {
            get { return BackingStore?.Get<string?>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
#nullable restore
#else
        public string ExternalObjectId {
            get { return BackingStore?.Get<string>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
#endif
        /// <summary>Nullable. The external Item Version for the object specified by the externalObjectId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalObjectVersion {
            get { return BackingStore?.Get<string?>("externalObjectVersion"); }
            set { BackingStore?.Set("externalObjectVersion", value); }
        }
#nullable restore
#else
        public string ExternalObjectVersion {
            get { return BackingStore?.Get<string>("externalObjectVersion"); }
            set { BackingStore?.Set("externalObjectVersion", value); }
        }
#endif
        /// <summary>Nullable. URL of the user experience represented by the associated plannerExternalTaskSource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new PlannerExternalTaskSource and sets the default values.
        /// </summary>
        public PlannerExternalTaskSource() : base() {
            OdataType = "#microsoft.graph.plannerExternalTaskSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerExternalTaskSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerExternalTaskSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contextScenarioId", n => { ContextScenarioId = n.GetStringValue(); } },
                {"displayLinkType", n => { DisplayLinkType = n.GetEnumValue<PlannerExternalTaskSourceDisplayType>(); } },
                {"displayNameSegments", n => { DisplayNameSegments = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"externalContextId", n => { ExternalContextId = n.GetStringValue(); } },
                {"externalObjectId", n => { ExternalObjectId = n.GetStringValue(); } },
                {"externalObjectVersion", n => { ExternalObjectVersion = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contextScenarioId", ContextScenarioId);
            writer.WriteEnumValue<PlannerExternalTaskSourceDisplayType>("displayLinkType", DisplayLinkType);
            writer.WriteCollectionOfPrimitiveValues<string>("displayNameSegments", DisplayNameSegments);
            writer.WriteStringValue("externalContextId", ExternalContextId);
            writer.WriteStringValue("externalObjectId", ExternalObjectId);
            writer.WriteStringValue("externalObjectVersion", ExternalObjectVersion);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
