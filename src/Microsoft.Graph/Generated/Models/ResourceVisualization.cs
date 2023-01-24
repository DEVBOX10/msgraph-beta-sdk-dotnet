using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ResourceVisualization : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerDisplayName {
            get { return BackingStore?.Get<string?>("containerDisplayName"); }
            set { BackingStore?.Set("containerDisplayName", value); }
        }
#nullable restore
#else
        public string ContainerDisplayName {
            get { return BackingStore?.Get<string>("containerDisplayName"); }
            set { BackingStore?.Set("containerDisplayName", value); }
        }
#endif
        /// <summary>Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerType {
            get { return BackingStore?.Get<string?>("containerType"); }
            set { BackingStore?.Set("containerType", value); }
        }
#nullable restore
#else
        public string ContainerType {
            get { return BackingStore?.Get<string>("containerType"); }
            set { BackingStore?.Set("containerType", value); }
        }
#endif
        /// <summary>A path leading to the folder in which the item is stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerWebUrl {
            get { return BackingStore?.Get<string?>("containerWebUrl"); }
            set { BackingStore?.Set("containerWebUrl", value); }
        }
#nullable restore
#else
        public string ContainerWebUrl {
            get { return BackingStore?.Get<string>("containerWebUrl"); }
            set { BackingStore?.Set("containerWebUrl", value); }
        }
#endif
        /// <summary>The item&apos;s media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType {
            get { return BackingStore?.Get<string?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#nullable restore
#else
        public string MediaType {
            get { return BackingStore?.Get<string>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
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
        /// <summary>A URL leading to the preview image for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviewImageUrl {
            get { return BackingStore?.Get<string?>("previewImageUrl"); }
            set { BackingStore?.Set("previewImageUrl", value); }
        }
#nullable restore
#else
        public string PreviewImageUrl {
            get { return BackingStore?.Get<string>("previewImageUrl"); }
            set { BackingStore?.Set("previewImageUrl", value); }
        }
#endif
        /// <summary>A preview text for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviewText {
            get { return BackingStore?.Get<string?>("previewText"); }
            set { BackingStore?.Set("previewText", value); }
        }
#nullable restore
#else
        public string PreviewText {
            get { return BackingStore?.Get<string>("previewText"); }
            set { BackingStore?.Set("previewText", value); }
        }
#endif
        /// <summary>The item&apos;s title text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>The item&apos;s media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new resourceVisualization and sets the default values.
        /// </summary>
        public ResourceVisualization() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ResourceVisualization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResourceVisualization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"containerDisplayName", n => { ContainerDisplayName = n.GetStringValue(); } },
                {"containerType", n => { ContainerType = n.GetStringValue(); } },
                {"containerWebUrl", n => { ContainerWebUrl = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"previewImageUrl", n => { PreviewImageUrl = n.GetStringValue(); } },
                {"previewText", n => { PreviewText = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("containerDisplayName", ContainerDisplayName);
            writer.WriteStringValue("containerType", ContainerType);
            writer.WriteStringValue("containerWebUrl", ContainerWebUrl);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("previewImageUrl", PreviewImageUrl);
            writer.WriteStringValue("previewText", PreviewText);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
