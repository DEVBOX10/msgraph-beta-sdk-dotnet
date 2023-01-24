using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Intune will provide customer the ability to run their Powershell Health scripts (remediation + detection) on the enrolled windows 10 Azure Active Directory joined devices.
    /// </summary>
    public class DeviceHealthScript : Entity, IParsable {
        /// <summary>The list of group assignments for the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptAssignment>? Assignments {
            get { return BackingStore?.Get<List<DeviceHealthScriptAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<DeviceHealthScriptAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceHealthScriptAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The timestamp of when the device health script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the device health script</summary>
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
        /// <summary>The entire content of the detection powershell script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? DetectionScriptContent {
            get { return BackingStore?.Get<byte[]?>("detectionScriptContent"); }
            set { BackingStore?.Set("detectionScriptContent", value); }
        }
#nullable restore
#else
        public byte[] DetectionScriptContent {
            get { return BackingStore?.Get<byte[]>("detectionScriptContent"); }
            set { BackingStore?.Set("detectionScriptContent", value); }
        }
#endif
        /// <summary>List of ComplexType DetectionScriptParameters objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptParameter>? DetectionScriptParameters {
            get { return BackingStore?.Get<List<DeviceHealthScriptParameter>?>("detectionScriptParameters"); }
            set { BackingStore?.Set("detectionScriptParameters", value); }
        }
#nullable restore
#else
        public List<DeviceHealthScriptParameter> DetectionScriptParameters {
            get { return BackingStore?.Get<List<DeviceHealthScriptParameter>>("detectionScriptParameters"); }
            set { BackingStore?.Set("detectionScriptParameters", value); }
        }
#endif
        /// <summary>List of run states for the device health script across all devices</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptDeviceState>? DeviceRunStates {
            get { return BackingStore?.Get<List<DeviceHealthScriptDeviceState>?>("deviceRunStates"); }
            set { BackingStore?.Set("deviceRunStates", value); }
        }
#nullable restore
#else
        public List<DeviceHealthScriptDeviceState> DeviceRunStates {
            get { return BackingStore?.Get<List<DeviceHealthScriptDeviceState>>("deviceRunStates"); }
            set { BackingStore?.Set("deviceRunStates", value); }
        }
#endif
        /// <summary>Name of the device health script</summary>
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
        /// <summary>Indicate whether the script signature needs be checked</summary>
        public bool? EnforceSignatureCheck {
            get { return BackingStore?.Get<bool?>("enforceSignatureCheck"); }
            set { BackingStore?.Set("enforceSignatureCheck", value); }
        }
        /// <summary>Highest available version for a Microsoft Proprietary script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HighestAvailableVersion {
            get { return BackingStore?.Get<string?>("highestAvailableVersion"); }
            set { BackingStore?.Set("highestAvailableVersion", value); }
        }
#nullable restore
#else
        public string HighestAvailableVersion {
            get { return BackingStore?.Get<string>("highestAvailableVersion"); }
            set { BackingStore?.Set("highestAvailableVersion", value); }
        }
#endif
        /// <summary>Determines if this is Microsoft Proprietary Script. Proprietary scripts are read-only</summary>
        public bool? IsGlobalScript {
            get { return BackingStore?.Get<bool?>("isGlobalScript"); }
            set { BackingStore?.Set("isGlobalScript", value); }
        }
        /// <summary>The timestamp of when the device health script was modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Name of the device health script publisher</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>The entire content of the remediation powershell script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? RemediationScriptContent {
            get { return BackingStore?.Get<byte[]?>("remediationScriptContent"); }
            set { BackingStore?.Set("remediationScriptContent", value); }
        }
#nullable restore
#else
        public byte[] RemediationScriptContent {
            get { return BackingStore?.Get<byte[]>("remediationScriptContent"); }
            set { BackingStore?.Set("remediationScriptContent", value); }
        }
#endif
        /// <summary>List of ComplexType RemediationScriptParameters objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthScriptParameter>? RemediationScriptParameters {
            get { return BackingStore?.Get<List<DeviceHealthScriptParameter>?>("remediationScriptParameters"); }
            set { BackingStore?.Set("remediationScriptParameters", value); }
        }
#nullable restore
#else
        public List<DeviceHealthScriptParameter> RemediationScriptParameters {
            get { return BackingStore?.Get<List<DeviceHealthScriptParameter>>("remediationScriptParameters"); }
            set { BackingStore?.Set("remediationScriptParameters", value); }
        }
#endif
        /// <summary>List of Scope Tag IDs for the device health script</summary>
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
        /// <summary>Indicate whether PowerShell script(s) should run as 32-bit</summary>
        public bool? RunAs32Bit {
            get { return BackingStore?.Get<bool?>("runAs32Bit"); }
            set { BackingStore?.Set("runAs32Bit", value); }
        }
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public RunAsAccountType? RunAsAccount {
            get { return BackingStore?.Get<RunAsAccountType?>("runAsAccount"); }
            set { BackingStore?.Set("runAsAccount", value); }
        }
        /// <summary>High level run summary for device health script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceHealthScriptRunSummary? RunSummary {
            get { return BackingStore?.Get<DeviceHealthScriptRunSummary?>("runSummary"); }
            set { BackingStore?.Set("runSummary", value); }
        }
#nullable restore
#else
        public DeviceHealthScriptRunSummary RunSummary {
            get { return BackingStore?.Get<DeviceHealthScriptRunSummary>("runSummary"); }
            set { BackingStore?.Set("runSummary", value); }
        }
#endif
        /// <summary>Version of the device health script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceHealthScriptAssignment>(DeviceHealthScriptAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionScriptContent", n => { DetectionScriptContent = n.GetByteArrayValue(); } },
                {"detectionScriptParameters", n => { DetectionScriptParameters = n.GetCollectionOfObjectValues<DeviceHealthScriptParameter>(DeviceHealthScriptParameter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceHealthScriptDeviceState>(DeviceHealthScriptDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                {"highestAvailableVersion", n => { HighestAvailableVersion = n.GetStringValue(); } },
                {"isGlobalScript", n => { IsGlobalScript = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"remediationScriptContent", n => { RemediationScriptContent = n.GetByteArrayValue(); } },
                {"remediationScriptParameters", n => { RemediationScriptParameters = n.GetCollectionOfObjectValues<DeviceHealthScriptParameter>(DeviceHealthScriptParameter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                {"runSummary", n => { RunSummary = n.GetObjectValue<DeviceHealthScriptRunSummary>(DeviceHealthScriptRunSummary.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptAssignment>("assignments", Assignments);
            writer.WriteStringValue("description", Description);
            writer.WriteByteArrayValue("detectionScriptContent", DetectionScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptParameter>("detectionScriptParameters", DetectionScriptParameters);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteStringValue("highestAvailableVersion", HighestAvailableVersion);
            writer.WriteBoolValue("isGlobalScript", IsGlobalScript);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteByteArrayValue("remediationScriptContent", RemediationScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptParameter>("remediationScriptParameters", RemediationScriptParameters);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceHealthScriptRunSummary>("runSummary", RunSummary);
            writer.WriteStringValue("version", Version);
        }
    }
}
