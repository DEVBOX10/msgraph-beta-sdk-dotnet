using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.SetScheduledRetireState {
    /// <summary>
    /// Provides operations to call the setScheduledRetireState method.
    /// </summary>
    public class SetScheduledRetireStatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The managedDeviceIds property</summary>
        public List<string> ManagedDeviceIds {
            get { return BackingStore?.Get<List<string>>("managedDeviceIds"); }
            set { BackingStore?.Set("managedDeviceIds", value); }
        }
        /// <summary>The scopedToAllDevices property</summary>
        public bool? ScopedToAllDevices {
            get { return BackingStore?.Get<bool?>("scopedToAllDevices"); }
            set { BackingStore?.Set("scopedToAllDevices", value); }
        }
        /// <summary>Cancel or confirm scheduled retire </summary>
        public ScheduledRetireState? State {
            get { return BackingStore?.Get<ScheduledRetireState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new setScheduledRetireStatePostRequestBody and sets the default values.
        /// </summary>
        public SetScheduledRetireStatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SetScheduledRetireStatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetScheduledRetireStatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"managedDeviceIds", n => { ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"scopedToAllDevices", n => { ScopedToAllDevices = n.GetBoolValue(); } },
                {"state", n => { State = n.GetEnumValue<ScheduledRetireState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("managedDeviceIds", ManagedDeviceIds);
            writer.WriteBoolValue("scopedToAllDevices", ScopedToAllDevices);
            writer.WriteEnumValue<ScheduledRetireState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
