using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcConnectivityResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The failedHealthCheckItems property</summary>
        public List<CloudPcHealthCheckItem> FailedHealthCheckItems {
            get { return BackingStore?.Get<List<CloudPcHealthCheckItem>>("failedHealthCheckItems"); }
            set { BackingStore?.Set("failedHealthCheckItems", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The status property</summary>
        public CloudPcConnectivityStatus? Status {
            get { return BackingStore?.Get<CloudPcConnectivityStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The updatedDateTime property</summary>
        public DateTimeOffset? UpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("updatedDateTime"); }
            set { BackingStore?.Set("updatedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcConnectivityResult and sets the default values.
        /// </summary>
        public CloudPcConnectivityResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.cloudPcConnectivityResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcConnectivityResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcConnectivityResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedHealthCheckItems", n => { FailedHealthCheckItems = n.GetCollectionOfObjectValues<CloudPcHealthCheckItem>(CloudPcHealthCheckItem.CreateFromDiscriminatorValue).ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcConnectivityStatus>(); } },
                {"updatedDateTime", n => { UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CloudPcHealthCheckItem>("failedHealthCheckItems", FailedHealthCheckItems);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<CloudPcConnectivityStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
