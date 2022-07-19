using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SharedAppleDeviceUser : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data quota</summary>
        public long? DataQuota {
            get { return BackingStore?.Get<long?>("dataQuota"); }
            set { BackingStore?.Set("dataQuota", value); }
        }
        /// <summary>Data to sync</summary>
        public bool? DataToSync {
            get { return BackingStore?.Get<bool?>("dataToSync"); }
            set { BackingStore?.Set("dataToSync", value); }
        }
        /// <summary>Data quota</summary>
        public long? DataUsed {
            get { return BackingStore?.Get<long?>("dataUsed"); }
            set { BackingStore?.Set("dataUsed", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>User name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new sharedAppleDeviceUser and sets the default values.
        /// </summary>
        public SharedAppleDeviceUser() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.sharedAppleDeviceUser";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharedAppleDeviceUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedAppleDeviceUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataQuota", n => { DataQuota = n.GetLongValue(); } },
                {"dataToSync", n => { DataToSync = n.GetBoolValue(); } },
                {"dataUsed", n => { DataUsed = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("dataQuota", DataQuota);
            writer.WriteBoolValue("dataToSync", DataToSync);
            writer.WriteLongValue("dataUsed", DataUsed);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
