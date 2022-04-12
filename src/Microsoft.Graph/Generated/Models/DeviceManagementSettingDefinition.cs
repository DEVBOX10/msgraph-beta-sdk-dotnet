using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingDefinition : Entity, IParsable {
        /// <summary>Collection of constraints for the setting value</summary>
        public List<DeviceManagementConstraint> Constraints { get; set; }
        /// <summary>Collection of dependencies on other settings</summary>
        public List<DeviceManagementSettingDependency> Dependencies { get; set; }
        /// <summary>The setting&apos;s description</summary>
        public string Description { get; set; }
        /// <summary>The setting&apos;s display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Url to setting documentation</summary>
        public string DocumentationUrl { get; set; }
        /// <summary>subtitle of the setting header for more details about the category/section</summary>
        public string HeaderSubtitle { get; set; }
        /// <summary>title of the setting header represents a category/section of a setting/settings</summary>
        public string HeaderTitle { get; set; }
        /// <summary>If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting</summary>
        public bool? IsTopLevel { get; set; }
        /// <summary>Keywords associated with the setting</summary>
        public List<string> Keywords { get; set; }
        /// <summary>Placeholder text as an example of valid input</summary>
        public string PlaceholderText { get; set; }
        /// <summary>The data type of the value. Possible values are: integer, boolean, string, complex, collection, abstractComplex.</summary>
        public DeviceManangementIntentValueType? ValueType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"constraints", n => { Constraints = n.GetCollectionOfObjectValues<DeviceManagementConstraint>(DeviceManagementConstraint.CreateFromDiscriminatorValue).ToList(); } },
                {"dependencies", n => { Dependencies = n.GetCollectionOfObjectValues<DeviceManagementSettingDependency>(DeviceManagementSettingDependency.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"documentationUrl", n => { DocumentationUrl = n.GetStringValue(); } },
                {"headerSubtitle", n => { HeaderSubtitle = n.GetStringValue(); } },
                {"headerTitle", n => { HeaderTitle = n.GetStringValue(); } },
                {"isTopLevel", n => { IsTopLevel = n.GetBoolValue(); } },
                {"keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"placeholderText", n => { PlaceholderText = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetEnumValue<DeviceManangementIntentValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConstraint>("constraints", Constraints);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingDependency>("dependencies", Dependencies);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("documentationUrl", DocumentationUrl);
            writer.WriteStringValue("headerSubtitle", HeaderSubtitle);
            writer.WriteStringValue("headerTitle", HeaderTitle);
            writer.WriteBoolValue("isTopLevel", IsTopLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteStringValue("placeholderText", PlaceholderText);
            writer.WriteEnumValue<DeviceManangementIntentValueType>("valueType", ValueType);
        }
    }
}
