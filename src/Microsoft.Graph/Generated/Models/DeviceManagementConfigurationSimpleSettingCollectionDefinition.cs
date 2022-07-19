using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSimpleSettingCollectionDefinition : DeviceManagementConfigurationSimpleSettingDefinition, IParsable {
        /// <summary>Maximum number of simple settings in the collection. Valid values 1 to 100</summary>
        public int? MaximumCount {
            get { return BackingStore?.Get<int?>("maximumCount"); }
            set { BackingStore?.Set("maximumCount", value); }
        }
        /// <summary>Minimum number of simple settings in the collection. Valid values 1 to 100</summary>
        public int? MinimumCount {
            get { return BackingStore?.Get<int?>("minimumCount"); }
            set { BackingStore?.Set("minimumCount", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationSimpleSettingCollectionDefinition and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingCollectionDefinition() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSimpleSettingCollectionDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSimpleSettingCollectionDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumCount", n => { MaximumCount = n.GetIntValue(); } },
                {"minimumCount", n => { MinimumCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumCount", MaximumCount);
            writer.WriteIntValue("minimumCount", MinimumCount);
        }
    }
}
