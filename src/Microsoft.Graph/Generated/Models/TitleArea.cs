using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TitleArea : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Alternative text on the title area.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternativeText {
            get { return BackingStore?.Get<string?>("alternativeText"); }
            set { BackingStore?.Set("alternativeText", value); }
        }
#nullable restore
#else
        public string AlternativeText {
            get { return BackingStore?.Get<string>("alternativeText"); }
            set { BackingStore?.Set("alternativeText", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether the title area has a gradient effect enabled.</summary>
        public bool? EnableGradientEffect {
            get { return BackingStore?.Get<bool?>("enableGradientEffect"); }
            set { BackingStore?.Set("enableGradientEffect", value); }
        }
        /// <summary>URL of the image in the title area.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageWebUrl {
            get { return BackingStore?.Get<string?>("imageWebUrl"); }
            set { BackingStore?.Set("imageWebUrl", value); }
        }
#nullable restore
#else
        public string ImageWebUrl {
            get { return BackingStore?.Get<string>("imageWebUrl"); }
            set { BackingStore?.Set("imageWebUrl", value); }
        }
#endif
        /// <summary>Enumeration value that indicates the layout of the title area. The possible values are: imageAndTitle, plain, colorBlock, overlap, unknownFutureValue.</summary>
        public TitleAreaLayoutType? Layout {
            get { return BackingStore?.Get<TitleAreaLayoutType?>("layout"); }
            set { BackingStore?.Set("layout", value); }
        }
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
        /// <summary>Contains collections of data that can be processed by server side services like search index and link fixup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ServerProcessedContent? ServerProcessedContent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServerProcessedContent?>("serverProcessedContent"); }
            set { BackingStore?.Set("serverProcessedContent", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ServerProcessedContent ServerProcessedContent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServerProcessedContent>("serverProcessedContent"); }
            set { BackingStore?.Set("serverProcessedContent", value); }
        }
#endif
        /// <summary>Indicates whether the author should be shown in title area.</summary>
        public bool? ShowAuthor {
            get { return BackingStore?.Get<bool?>("showAuthor"); }
            set { BackingStore?.Set("showAuthor", value); }
        }
        /// <summary>Indicates whether the published date should be shown in title area.</summary>
        public bool? ShowPublishedDate {
            get { return BackingStore?.Get<bool?>("showPublishedDate"); }
            set { BackingStore?.Set("showPublishedDate", value); }
        }
        /// <summary>Indicates whether the text block above title should be shown in title area.</summary>
        public bool? ShowTextBlockAboveTitle {
            get { return BackingStore?.Get<bool?>("showTextBlockAboveTitle"); }
            set { BackingStore?.Set("showTextBlockAboveTitle", value); }
        }
        /// <summary>The text above title line.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TextAboveTitle {
            get { return BackingStore?.Get<string?>("textAboveTitle"); }
            set { BackingStore?.Set("textAboveTitle", value); }
        }
#nullable restore
#else
        public string TextAboveTitle {
            get { return BackingStore?.Get<string>("textAboveTitle"); }
            set { BackingStore?.Set("textAboveTitle", value); }
        }
#endif
        /// <summary>Enumeration value that indicates the text alignment of the title area. The possible values are: left, center, unknownFutureValue.</summary>
        public TitleAreaTextAlignmentType? TextAlignment {
            get { return BackingStore?.Get<TitleAreaTextAlignmentType?>("textAlignment"); }
            set { BackingStore?.Set("textAlignment", value); }
        }
        /// <summary>
        /// Instantiates a new titleArea and sets the default values.
        /// </summary>
        public TitleArea() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TitleArea CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TitleArea();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alternativeText", n => { AlternativeText = n.GetStringValue(); } },
                {"enableGradientEffect", n => { EnableGradientEffect = n.GetBoolValue(); } },
                {"imageWebUrl", n => { ImageWebUrl = n.GetStringValue(); } },
                {"layout", n => { Layout = n.GetEnumValue<TitleAreaLayoutType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"serverProcessedContent", n => { ServerProcessedContent = n.GetObjectValue<Microsoft.Graph.Beta.Models.ServerProcessedContent>(Microsoft.Graph.Beta.Models.ServerProcessedContent.CreateFromDiscriminatorValue); } },
                {"showAuthor", n => { ShowAuthor = n.GetBoolValue(); } },
                {"showPublishedDate", n => { ShowPublishedDate = n.GetBoolValue(); } },
                {"showTextBlockAboveTitle", n => { ShowTextBlockAboveTitle = n.GetBoolValue(); } },
                {"textAboveTitle", n => { TextAboveTitle = n.GetStringValue(); } },
                {"textAlignment", n => { TextAlignment = n.GetEnumValue<TitleAreaTextAlignmentType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alternativeText", AlternativeText);
            writer.WriteBoolValue("enableGradientEffect", EnableGradientEffect);
            writer.WriteStringValue("imageWebUrl", ImageWebUrl);
            writer.WriteEnumValue<TitleAreaLayoutType>("layout", Layout);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ServerProcessedContent>("serverProcessedContent", ServerProcessedContent);
            writer.WriteBoolValue("showAuthor", ShowAuthor);
            writer.WriteBoolValue("showPublishedDate", ShowPublishedDate);
            writer.WriteBoolValue("showTextBlockAboveTitle", ShowTextBlockAboveTitle);
            writer.WriteStringValue("textAboveTitle", TextAboveTitle);
            writer.WriteEnumValue<TitleAreaTextAlignmentType>("textAlignment", TextAlignment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
