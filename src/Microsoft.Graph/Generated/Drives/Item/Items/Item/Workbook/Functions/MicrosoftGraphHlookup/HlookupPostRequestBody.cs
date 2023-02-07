using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphHlookup {
    public class HlookupPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The lookupValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LookupValue {
            get { return BackingStore?.Get<Json?>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#nullable restore
#else
        public Json LookupValue {
            get { return BackingStore?.Get<Json>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#endif
        /// <summary>The rangeLookup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? RangeLookup {
            get { return BackingStore?.Get<Json?>("rangeLookup"); }
            set { BackingStore?.Set("rangeLookup", value); }
        }
#nullable restore
#else
        public Json RangeLookup {
            get { return BackingStore?.Get<Json>("rangeLookup"); }
            set { BackingStore?.Set("rangeLookup", value); }
        }
#endif
        /// <summary>The rowIndexNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? RowIndexNum {
            get { return BackingStore?.Get<Json?>("rowIndexNum"); }
            set { BackingStore?.Set("rowIndexNum", value); }
        }
#nullable restore
#else
        public Json RowIndexNum {
            get { return BackingStore?.Get<Json>("rowIndexNum"); }
            set { BackingStore?.Set("rowIndexNum", value); }
        }
#endif
        /// <summary>The tableArray property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? TableArray {
            get { return BackingStore?.Get<Json?>("tableArray"); }
            set { BackingStore?.Set("tableArray", value); }
        }
#nullable restore
#else
        public Json TableArray {
            get { return BackingStore?.Get<Json>("tableArray"); }
            set { BackingStore?.Set("tableArray", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new hlookupPostRequestBody and sets the default values.
        /// </summary>
        public HlookupPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HlookupPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HlookupPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lookupValue", n => { LookupValue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rangeLookup", n => { RangeLookup = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rowIndexNum", n => { RowIndexNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"tableArray", n => { TableArray = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("rangeLookup", RangeLookup);
            writer.WriteObjectValue<Json>("rowIndexNum", RowIndexNum);
            writer.WriteObjectValue<Json>("tableArray", TableArray);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
