using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A ConfigManager policy summary.</summary>
    public class ConfigManagerPolicySummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of devices evaluated to be compliant by the policy.</summary>
        public int? CompliantDeviceCount {
            get { return BackingStore?.Get<int?>("compliantDeviceCount"); }
            set { BackingStore?.Set("compliantDeviceCount", value); }
        }
        /// <summary>The number of devices that have have been remediated by the policy.</summary>
        public int? EnforcedDeviceCount {
            get { return BackingStore?.Get<int?>("enforcedDeviceCount"); }
            set { BackingStore?.Set("enforcedDeviceCount", value); }
        }
        /// <summary>The number of devices that failed to be evaluated by the policy.</summary>
        public int? FailedDeviceCount {
            get { return BackingStore?.Get<int?>("failedDeviceCount"); }
            set { BackingStore?.Set("failedDeviceCount", value); }
        }
        /// <summary>The number of devices evaluated to be noncompliant by the policy.</summary>
        public int? NonCompliantDeviceCount {
            get { return BackingStore?.Get<int?>("nonCompliantDeviceCount"); }
            set { BackingStore?.Set("nonCompliantDeviceCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The number of devices that have acknowledged the policy but are pending evaluation.</summary>
        public int? PendingDeviceCount {
            get { return BackingStore?.Get<int?>("pendingDeviceCount"); }
            set { BackingStore?.Set("pendingDeviceCount", value); }
        }
        /// <summary>The number of devices targeted by the policy.</summary>
        public int? TargetedDeviceCount {
            get { return BackingStore?.Get<int?>("targetedDeviceCount"); }
            set { BackingStore?.Set("targetedDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new configManagerPolicySummary and sets the default values.
        /// </summary>
        public ConfigManagerPolicySummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.configManagerPolicySummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConfigManagerPolicySummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigManagerPolicySummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"enforcedDeviceCount", n => { EnforcedDeviceCount = n.GetIntValue(); } },
                {"failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"pendingDeviceCount", n => { PendingDeviceCount = n.GetIntValue(); } },
                {"targetedDeviceCount", n => { TargetedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("enforcedDeviceCount", EnforcedDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("pendingDeviceCount", PendingDeviceCount);
            writer.WriteIntValue("targetedDeviceCount", TargetedDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
