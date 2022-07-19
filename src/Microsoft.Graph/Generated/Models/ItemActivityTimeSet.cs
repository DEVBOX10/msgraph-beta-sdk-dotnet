using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemActivityTimeSet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The lastRecordedDateTime property</summary>
        public DateTimeOffset? LastRecordedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRecordedDateTime"); }
            set { BackingStore?.Set("lastRecordedDateTime", value); }
        }
        /// <summary>When the activity was observed to take place.</summary>
        public DateTimeOffset? ObservedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("observedDateTime"); }
            set { BackingStore?.Set("observedDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>When the observation was recorded on the service.</summary>
        public DateTimeOffset? RecordedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("recordedDateTime"); }
            set { BackingStore?.Set("recordedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new itemActivityTimeSet and sets the default values.
        /// </summary>
        public ItemActivityTimeSet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.itemActivityTimeSet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ItemActivityTimeSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityTimeSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lastRecordedDateTime", n => { LastRecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"observedDateTime", n => { ObservedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recordedDateTime", n => { RecordedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastRecordedDateTime", LastRecordedDateTime);
            writer.WriteDateTimeOffsetValue("observedDateTime", ObservedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("recordedDateTime", RecordedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
