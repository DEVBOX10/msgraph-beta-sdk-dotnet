using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class InformationProtectionLabel : Entity, IParsable {
        /// <summary>The color that the UI should display for the label, if configured.</summary>
        public string Color {
            get { return BackingStore?.Get<string>("color"); }
            set { BackingStore?.Set("color", value); }
        }
        /// <summary>The admin-defined description for the label.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>The plaintext name of the label.</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The parent label associated with a child label. Null if label has no parent.</summary>
        public ParentLabelDetails Parent {
            get { return BackingStore?.Get<ParentLabelDetails>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
        /// <summary>The sensitivity value of the label, where lower is less sensitive.</summary>
        public int? Sensitivity {
            get { return BackingStore?.Get<int?>("sensitivity"); }
            set { BackingStore?.Set("sensitivity", value); }
        }
        /// <summary>The tooltip that should be displayed for the label in a UI.</summary>
        public string Tooltip {
            get { return BackingStore?.Get<string>("tooltip"); }
            set { BackingStore?.Set("tooltip", value); }
        }
        /// <summary>
        /// Instantiates a new informationProtectionLabel and sets the default values.
        /// </summary>
        public InformationProtectionLabel() : base() {
            OdataType = "#microsoft.graph.informationProtectionLabel";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InformationProtectionLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtectionLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"color", n => { Color = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<ParentLabelDetails>(ParentLabelDetails.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetIntValue(); } },
                {"tooltip", n => { Tooltip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ParentLabelDetails>("parent", Parent);
            writer.WriteIntValue("sensitivity", Sensitivity);
            writer.WriteStringValue("tooltip", Tooltip);
        }
    }
}
