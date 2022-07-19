using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcForensicStorageAccount : Entity, IParsable {
        /// <summary>The ID of the storage account.</summary>
        public string StorageAccountId {
            get { return BackingStore?.Get<string>("storageAccountId"); }
            set { BackingStore?.Set("storageAccountId", value); }
        }
        /// <summary>The name of the storage account.</summary>
        public string StorageAccountName {
            get { return BackingStore?.Get<string>("storageAccountName"); }
            set { BackingStore?.Set("storageAccountName", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcForensicStorageAccount and sets the default values.
        /// </summary>
        public CloudPcForensicStorageAccount() : base() {
            OdataType = "#microsoft.graph.cloudPcForensicStorageAccount";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcForensicStorageAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcForensicStorageAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"storageAccountId", n => { StorageAccountId = n.GetStringValue(); } },
                {"storageAccountName", n => { StorageAccountName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("storageAccountId", StorageAccountId);
            writer.WriteStringValue("storageAccountName", StorageAccountName);
        }
    }
}
