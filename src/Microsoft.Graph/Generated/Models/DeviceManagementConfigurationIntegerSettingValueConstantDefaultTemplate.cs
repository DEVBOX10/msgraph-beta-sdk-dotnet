using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate : DeviceManagementConfigurationIntegerSettingValueDefaultTemplate, IParsable {
        /// <summary>Default Constant Value. Valid values -2147483648 to 2147483647</summary>
        public int? ConstantValue {
            get { return BackingStore?.Get<int?>("constantValue"); }
            set { BackingStore?.Set("constantValue", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"constantValue", n => { ConstantValue = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("constantValue", ConstantValue);
        }
    }
}
