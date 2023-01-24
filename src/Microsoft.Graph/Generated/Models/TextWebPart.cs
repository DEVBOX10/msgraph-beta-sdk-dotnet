using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TextWebPart : WebPart, IParsable {
        /// <summary>The HTML string in text web part.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InnerHtml {
            get { return BackingStore?.Get<string?>("innerHtml"); }
            set { BackingStore?.Set("innerHtml", value); }
        }
#nullable restore
#else
        public string InnerHtml {
            get { return BackingStore?.Get<string>("innerHtml"); }
            set { BackingStore?.Set("innerHtml", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new TextWebPart and sets the default values.
        /// </summary>
        public TextWebPart() : base() {
            OdataType = "#microsoft.graph.textWebPart";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TextWebPart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TextWebPart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"innerHtml", n => { InnerHtml = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("innerHtml", InnerHtml);
        }
    }
}
