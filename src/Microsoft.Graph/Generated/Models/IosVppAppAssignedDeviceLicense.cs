using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosVppAppAssignedDeviceLicense : IosVppAppAssignedLicense, IParsable {
        /// <summary>The device name.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>The managed device ID.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>
        /// Instantiates a new IosVppAppAssignedDeviceLicense and sets the default values.
        /// </summary>
        public IosVppAppAssignedDeviceLicense() : base() {
            OdataType = "#microsoft.graph.iosVppAppAssignedDeviceLicense";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosVppAppAssignedDeviceLicense CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppAppAssignedDeviceLicense();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
        }
    }
}
