using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSimpleSettingInstance : DeviceManagementConfigurationSettingInstance, IParsable {
        /// <summary>The simpleSettingValue property</summary>
        public DeviceManagementConfigurationSimpleSettingValue SimpleSettingValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSimpleSettingValue>("simpleSettingValue"); }
            set { BackingStore?.Set("simpleSettingValue", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationSimpleSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingInstance() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSimpleSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSimpleSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"simpleSettingValue", n => { SimpleSettingValue = n.GetObjectValue<DeviceManagementConfigurationSimpleSettingValue>(DeviceManagementConfigurationSimpleSettingValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationSimpleSettingValue>("simpleSettingValue", SimpleSettingValue);
        }
    }
}
