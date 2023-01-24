using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents a custom attribute script for macOS.
    /// </summary>
    public class DeviceCustomAttributeShellScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptAssignment>? Assignments {
            get { return BackingStore?.Get<List<DeviceManagementScriptAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<DeviceManagementScriptAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceManagementScriptAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The date and time the device management script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The name of the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomAttributeName {
            get { return BackingStore?.Get<string?>("customAttributeName"); }
            set { BackingStore?.Set("customAttributeName", value); }
        }
#nullable restore
#else
        public string CustomAttributeName {
            get { return BackingStore?.Get<string>("customAttributeName"); }
            set { BackingStore?.Set("customAttributeName", value); }
        }
#endif
        /// <summary>Represents the expected type for a macOS custom attribute script value.</summary>
        public DeviceCustomAttributeValueType? CustomAttributeType {
            get { return BackingStore?.Get<DeviceCustomAttributeValueType?>("customAttributeType"); }
            set { BackingStore?.Set("customAttributeType", value); }
        }
        /// <summary>Optional description for the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>List of run states for this script across all devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptDeviceState>? DeviceRunStates {
            get { return BackingStore?.Get<List<DeviceManagementScriptDeviceState>?>("deviceRunStates"); }
            set { BackingStore?.Set("deviceRunStates", value); }
        }
#nullable restore
#else
        public List<DeviceManagementScriptDeviceState> DeviceRunStates {
            get { return BackingStore?.Get<List<DeviceManagementScriptDeviceState>>("deviceRunStates"); }
            set { BackingStore?.Set("deviceRunStates", value); }
        }
#endif
        /// <summary>Name of the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Script file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>The list of group assignments for the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptGroupAssignment>? GroupAssignments {
            get { return BackingStore?.Get<List<DeviceManagementScriptGroupAssignment>?>("groupAssignments"); }
            set { BackingStore?.Set("groupAssignments", value); }
        }
#nullable restore
#else
        public List<DeviceManagementScriptGroupAssignment> GroupAssignments {
            get { return BackingStore?.Get<List<DeviceManagementScriptGroupAssignment>>("groupAssignments"); }
            set { BackingStore?.Set("groupAssignments", value); }
        }
#endif
        /// <summary>The date and time the device management script was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tag IDs for this PowerShellScript instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public RunAsAccountType? RunAsAccount {
            get { return BackingStore?.Get<RunAsAccountType?>("runAsAccount"); }
            set { BackingStore?.Set("runAsAccount", value); }
        }
        /// <summary>Run summary for device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementScriptRunSummary? RunSummary {
            get { return BackingStore?.Get<DeviceManagementScriptRunSummary?>("runSummary"); }
            set { BackingStore?.Set("runSummary", value); }
        }
#nullable restore
#else
        public DeviceManagementScriptRunSummary RunSummary {
            get { return BackingStore?.Get<DeviceManagementScriptRunSummary>("runSummary"); }
            set { BackingStore?.Set("runSummary", value); }
        }
#endif
        /// <summary>The script content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ScriptContent {
            get { return BackingStore?.Get<byte[]?>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#nullable restore
#else
        public byte[] ScriptContent {
            get { return BackingStore?.Get<byte[]>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#endif
        /// <summary>List of run states for this script across all users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptUserState>? UserRunStates {
            get { return BackingStore?.Get<List<DeviceManagementScriptUserState>?>("userRunStates"); }
            set { BackingStore?.Set("userRunStates", value); }
        }
#nullable restore
#else
        public List<DeviceManagementScriptUserState> UserRunStates {
            get { return BackingStore?.Get<List<DeviceManagementScriptUserState>>("userRunStates"); }
            set { BackingStore?.Set("userRunStates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceCustomAttributeShellScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCustomAttributeShellScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>(DeviceManagementScriptAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customAttributeName", n => { CustomAttributeName = n.GetStringValue(); } },
                {"customAttributeType", n => { CustomAttributeType = n.GetEnumValue<DeviceCustomAttributeValueType>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>(DeviceManagementScriptDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>(DeviceManagementScriptGroupAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", n => { RunSummary = n.GetObjectValue<DeviceManagementScriptRunSummary>(DeviceManagementScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"scriptContent", n => { ScriptContent = n.GetByteArrayValue(); } },
                {"userRunStates", n => { UserRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptUserState>(DeviceManagementScriptUserState.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptAssignment>("assignments", Assignments);
            writer.WriteStringValue("customAttributeName", CustomAttributeName);
            writer.WriteEnumValue<DeviceCustomAttributeValueType>("customAttributeType", CustomAttributeType);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceManagementScriptRunSummary>("runSummary", RunSummary);
            writer.WriteByteArrayValue("scriptContent", ScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptUserState>("userRunStates", UserRunStates);
        }
    }
}
