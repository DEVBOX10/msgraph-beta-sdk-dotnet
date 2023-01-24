using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PayloadTypes : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The notification content of a raw user notification that will be delivered to and consumed by the app client on all supported platforms (Windows, iOS, Android or WebPush) receiving this notification. At least one of Payload.RawContent or Payload.VisualContent needs to be valid for a POST Notification request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawContent {
            get { return BackingStore?.Get<string?>("rawContent"); }
            set { BackingStore?.Set("rawContent", value); }
        }
#nullable restore
#else
        public string RawContent {
            get { return BackingStore?.Get<string>("rawContent"); }
            set { BackingStore?.Set("rawContent", value); }
        }
#endif
        /// <summary>The visual content of a visual user notification, which will be consumed by the notification platform on each supported platform (Windows, iOS and Android only) and rendered for the user. At least one of Payload.RawContent or Payload.VisualContent needs to be valid for a POST Notification request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VisualProperties? VisualContent {
            get { return BackingStore?.Get<VisualProperties?>("visualContent"); }
            set { BackingStore?.Set("visualContent", value); }
        }
#nullable restore
#else
        public VisualProperties VisualContent {
            get { return BackingStore?.Get<VisualProperties>("visualContent"); }
            set { BackingStore?.Set("visualContent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new payloadTypes and sets the default values.
        /// </summary>
        public PayloadTypes() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayloadTypes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayloadTypes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rawContent", n => { RawContent = n.GetStringValue(); } },
                {"visualContent", n => { VisualContent = n.GetObjectValue<VisualProperties>(VisualProperties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("rawContent", RawContent);
            writer.WriteObjectValue<VisualProperties>("visualContent", VisualContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
