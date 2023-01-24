using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AddContentFooterAction : InformationProtectionAction, IParsable {
        /// <summary>The alignment property</summary>
        public ContentAlignment? Alignment {
            get { return BackingStore?.Get<ContentAlignment?>("alignment"); }
            set { BackingStore?.Set("alignment", value); }
        }
        /// <summary>Color of the font to use for the footer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontColor {
            get { return BackingStore?.Get<string?>("fontColor"); }
            set { BackingStore?.Set("fontColor", value); }
        }
#nullable restore
#else
        public string FontColor {
            get { return BackingStore?.Get<string>("fontColor"); }
            set { BackingStore?.Set("fontColor", value); }
        }
#endif
        /// <summary>Name of the font to use for the footer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontName {
            get { return BackingStore?.Get<string?>("fontName"); }
            set { BackingStore?.Set("fontName", value); }
        }
#nullable restore
#else
        public string FontName {
            get { return BackingStore?.Get<string>("fontName"); }
            set { BackingStore?.Set("fontName", value); }
        }
#endif
        /// <summary>Font size to use for the footer.</summary>
        public int? FontSize {
            get { return BackingStore?.Get<int?>("fontSize"); }
            set { BackingStore?.Set("fontSize", value); }
        }
        /// <summary>The margin of the header from the bottom of the document.</summary>
        public int? Margin {
            get { return BackingStore?.Get<int?>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
        /// <summary>The contents of the footer itself.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text {
            get { return BackingStore?.Get<string?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public string Text {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>The name of the UI element where the footer should be placed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UiElementName {
            get { return BackingStore?.Get<string?>("uiElementName"); }
            set { BackingStore?.Set("uiElementName", value); }
        }
#nullable restore
#else
        public string UiElementName {
            get { return BackingStore?.Get<string>("uiElementName"); }
            set { BackingStore?.Set("uiElementName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AddContentFooterAction and sets the default values.
        /// </summary>
        public AddContentFooterAction() : base() {
            OdataType = "#microsoft.graph.security.addContentFooterAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AddContentFooterAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddContentFooterAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alignment", n => { Alignment = n.GetEnumValue<ContentAlignment>(); } },
                {"fontColor", n => { FontColor = n.GetStringValue(); } },
                {"fontName", n => { FontName = n.GetStringValue(); } },
                {"fontSize", n => { FontSize = n.GetIntValue(); } },
                {"margin", n => { Margin = n.GetIntValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"uiElementName", n => { UiElementName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ContentAlignment>("alignment", Alignment);
            writer.WriteStringValue("fontColor", FontColor);
            writer.WriteStringValue("fontName", FontName);
            writer.WriteIntValue("fontSize", FontSize);
            writer.WriteIntValue("margin", Margin);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("uiElementName", UiElementName);
        }
    }
}
