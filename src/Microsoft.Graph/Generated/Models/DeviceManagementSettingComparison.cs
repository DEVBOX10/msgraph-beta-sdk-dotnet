using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity representing setting comparison result</summary>
    public class DeviceManagementSettingComparison : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Setting comparison result. Possible values are: unknown, equal, notEqual, added, removed.</summary>
        public DeviceManagementComparisonResult? ComparisonResult { get; set; }
        /// <summary>JSON representation of current intent (or) template setting&apos;s value</summary>
        public string CurrentValueJson { get; set; }
        /// <summary>The ID of the setting definition for this instance</summary>
        public string DefinitionId { get; set; }
        /// <summary>The setting&apos;s display name</summary>
        public string DisplayName { get; set; }
        /// <summary>The setting ID</summary>
        public string Id { get; set; }
        /// <summary>JSON representation of new template setting&apos;s value</summary>
        public string NewValueJson { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementSettingComparison and sets the default values.
        /// </summary>
        public DeviceManagementSettingComparison() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementSettingComparison CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingComparison();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comparisonResult", n => { ComparisonResult = n.GetEnumValue<DeviceManagementComparisonResult>(); } },
                {"currentValueJson", n => { CurrentValueJson = n.GetStringValue(); } },
                {"definitionId", n => { DefinitionId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"newValueJson", n => { NewValueJson = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DeviceManagementComparisonResult>("comparisonResult", ComparisonResult);
            writer.WriteStringValue("currentValueJson", CurrentValueJson);
            writer.WriteStringValue("definitionId", DefinitionId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("newValueJson", NewValueJson);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
