using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class ContentApplicabilitySettings : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>Offer if the update is recommended by a vendor in the list, otherwise withhold the offer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OfferWhileRecommendedBy {
            get { return BackingStore?.Get<List<string>?>("offerWhileRecommendedBy"); }
            set { BackingStore?.Set("offerWhileRecommendedBy", value); }
        }
#nullable restore
#else
        public List<string> OfferWhileRecommendedBy {
            get { return BackingStore?.Get<List<string>>("offerWhileRecommendedBy"); }
            set { BackingStore?.Set("offerWhileRecommendedBy", value); }
        }
#endif
        /// <summary>Settings for governing safeguard holds on offering content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SafeguardSettings? Safeguard {
            get { return BackingStore?.Get<SafeguardSettings?>("safeguard"); }
            set { BackingStore?.Set("safeguard", value); }
        }
#nullable restore
#else
        public SafeguardSettings Safeguard {
            get { return BackingStore?.Get<SafeguardSettings>("safeguard"); }
            set { BackingStore?.Set("safeguard", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new contentApplicabilitySettings and sets the default values.
        /// </summary>
        public ContentApplicabilitySettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ContentApplicabilitySettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentApplicabilitySettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"offerWhileRecommendedBy", n => { OfferWhileRecommendedBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"safeguard", n => { Safeguard = n.GetObjectValue<SafeguardSettings>(SafeguardSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("offerWhileRecommendedBy", OfferWhileRecommendedBy);
            writer.WriteObjectValue<SafeguardSettings>("safeguard", Safeguard);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
