using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphNominal {
    public class NominalPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The effectRate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? EffectRate {
            get { return BackingStore?.Get<Json?>("effectRate"); }
            set { BackingStore?.Set("effectRate", value); }
        }
#nullable restore
#else
        public Json EffectRate {
            get { return BackingStore?.Get<Json>("effectRate"); }
            set { BackingStore?.Set("effectRate", value); }
        }
#endif
        /// <summary>The npery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Npery {
            get { return BackingStore?.Get<Json?>("npery"); }
            set { BackingStore?.Set("npery", value); }
        }
#nullable restore
#else
        public Json Npery {
            get { return BackingStore?.Get<Json>("npery"); }
            set { BackingStore?.Set("npery", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new nominalPostRequestBody and sets the default values.
        /// </summary>
        public NominalPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NominalPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NominalPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"effectRate", n => { EffectRate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"npery", n => { Npery = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("effectRate", EffectRate);
            writer.WriteObjectValue<Json>("npery", Npery);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
