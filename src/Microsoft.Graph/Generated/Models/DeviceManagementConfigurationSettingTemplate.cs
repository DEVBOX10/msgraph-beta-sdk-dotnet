using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingTemplate : Entity, IParsable {
        /// <summary>List of related Setting Definitions</summary>
        public List<DeviceManagementConfigurationSettingDefinition> SettingDefinitions { get; set; }
        /// <summary>Setting Instance Template</summary>
        public DeviceManagementConfigurationSettingInstanceTemplate SettingInstanceTemplate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSettingTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>(DeviceManagementConfigurationSettingDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"settingInstanceTemplate", n => { SettingInstanceTemplate = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplate>(DeviceManagementConfigurationSettingInstanceTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDefinition>("settingDefinitions", SettingDefinitions);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstanceTemplate>("settingInstanceTemplate", SettingInstanceTemplate);
        }
    }
}
