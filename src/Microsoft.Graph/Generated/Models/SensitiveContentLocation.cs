using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitiveContentLocation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The confidence property</summary>
        public int? Confidence {
            get { return BackingStore?.Get<int?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>The evidences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SensitiveContentEvidence>? Evidences {
            get { return BackingStore?.Get<List<SensitiveContentEvidence>?>("evidences"); }
            set { BackingStore?.Set("evidences", value); }
        }
#nullable restore
#else
        public List<SensitiveContentEvidence> Evidences {
            get { return BackingStore?.Get<List<SensitiveContentEvidence>>("evidences"); }
            set { BackingStore?.Set("evidences", value); }
        }
#endif
        /// <summary>The idMatch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdMatch {
            get { return BackingStore?.Get<string?>("idMatch"); }
            set { BackingStore?.Set("idMatch", value); }
        }
#nullable restore
#else
        public string IdMatch {
            get { return BackingStore?.Get<string>("idMatch"); }
            set { BackingStore?.Set("idMatch", value); }
        }
#endif
        /// <summary>The length property</summary>
        public int? Length {
            get { return BackingStore?.Get<int?>("length"); }
            set { BackingStore?.Set("length", value); }
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
        /// <summary>The offset property</summary>
        public int? Offset {
            get { return BackingStore?.Get<int?>("offset"); }
            set { BackingStore?.Set("offset", value); }
        }
        /// <summary>
        /// Instantiates a new sensitiveContentLocation and sets the default values.
        /// </summary>
        public SensitiveContentLocation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SensitiveContentLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveContentLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"evidences", n => { Evidences = n.GetCollectionOfObjectValues<SensitiveContentEvidence>(SensitiveContentEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"idMatch", n => { IdMatch = n.GetStringValue(); } },
                {"length", n => { Length = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"offset", n => { Offset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<SensitiveContentEvidence>("evidences", Evidences);
            writer.WriteStringValue("idMatch", IdMatch);
            writer.WriteIntValue("length", Length);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("offset", Offset);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
