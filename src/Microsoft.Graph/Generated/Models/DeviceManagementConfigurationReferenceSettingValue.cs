using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationReferenceSettingValue : DeviceManagementConfigurationStringSettingValue, IParsable {
        /// <summary>A note that admin can use to put some contextual information</summary>
        public string Note {
            get { return BackingStore?.Get<string>("note"); }
            set { BackingStore?.Set("note", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationReferenceSettingValue and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationReferenceSettingValue() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationReferenceSettingValue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationReferenceSettingValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationReferenceSettingValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"note", n => { Note = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("note", Note);
        }
    }
}
