using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementCompliancePolicy : Entity, IParsable {
        /// <summary>Policy assignments</summary>
        public List<DeviceManagementConfigurationPolicyAssignment> Assignments { get; set; }
        /// <summary>Policy creation date and time. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Policy creation source</summary>
        public string CreationSource { get; set; }
        /// <summary>Policy description</summary>
        public string Description { get; set; }
        /// <summary>Policy assignment status. This property is read-only.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>Policy last modification date and time. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Policy name</summary>
        public string Name { get; set; }
        /// <summary>Platforms for this policy. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The list of scheduled action for this rule</summary>
        public List<DeviceManagementComplianceScheduledActionForRule> ScheduledActionsForRule { get; set; }
        /// <summary>Number of settings. This property is read-only.</summary>
        public int? SettingCount { get; set; }
        /// <summary>Policy settings</summary>
        public List<DeviceManagementConfigurationSetting> Settings { get; set; }
        /// <summary>Technologies for this policy. Possible values are: none, mdm, windows10XManagement, configManager, appleRemoteManagement, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>(DeviceManagementConfigurationPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationSource", n => { CreationSource = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"platforms", n => { Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scheduledActionsForRule", n => { ScheduledActionsForRule = n.GetCollectionOfObjectValues<DeviceManagementComplianceScheduledActionForRule>(DeviceManagementComplianceScheduledActionForRule.CreateFromDiscriminatorValue).ToList(); } },
                {"settingCount", n => { SettingCount = n.GetIntValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSetting>(DeviceManagementConfigurationSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationPolicyAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("creationSource", CreationSource);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<DeviceManagementComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSetting>("settings", Settings);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
        }
    }
}
