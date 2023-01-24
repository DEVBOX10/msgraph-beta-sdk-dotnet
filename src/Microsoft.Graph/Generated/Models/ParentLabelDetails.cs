using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ParentLabelDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The color that the user interface should display for the label, if configured.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color {
            get { return BackingStore?.Get<string?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#nullable restore
#else
        public string Color {
            get { return BackingStore?.Get<string>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#endif
        /// <summary>The admin-defined description for the label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The label ID is a globally unique identifier (GUID).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>The plaintext name of the label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The parent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ParentLabelDetails? Parent {
            get { return BackingStore?.Get<ParentLabelDetails?>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
#nullable restore
#else
        public ParentLabelDetails Parent {
            get { return BackingStore?.Get<ParentLabelDetails>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
#endif
        /// <summary>The sensitivity value of the label, where lower is less sensitive.</summary>
        public int? Sensitivity {
            get { return BackingStore?.Get<int?>("sensitivity"); }
            set { BackingStore?.Set("sensitivity", value); }
        }
        /// <summary>The tooltip that should be displayed for the label in a user interface.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tooltip {
            get { return BackingStore?.Get<string?>("tooltip"); }
            set { BackingStore?.Set("tooltip", value); }
        }
#nullable restore
#else
        public string Tooltip {
            get { return BackingStore?.Get<string>("tooltip"); }
            set { BackingStore?.Set("tooltip", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new parentLabelDetails and sets the default values.
        /// </summary>
        public ParentLabelDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ParentLabelDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.labelDetails" => new LabelDetails(),
                _ => new ParentLabelDetails(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"color", n => { Color = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<ParentLabelDetails>(ParentLabelDetails.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetIntValue(); } },
                {"tooltip", n => { Tooltip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ParentLabelDetails>("parent", Parent);
            writer.WriteIntValue("sensitivity", Sensitivity);
            writer.WriteStringValue("tooltip", Tooltip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
