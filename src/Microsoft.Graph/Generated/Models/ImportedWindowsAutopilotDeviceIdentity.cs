using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Imported windows autopilot devices.
    /// </summary>
    public class ImportedWindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>UPN of the user the device will be assigned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedUserPrincipalName {
            get { return BackingStore?.Get<string?>("assignedUserPrincipalName"); }
            set { BackingStore?.Set("assignedUserPrincipalName", value); }
        }
#nullable restore
#else
        public string AssignedUserPrincipalName {
            get { return BackingStore?.Get<string>("assignedUserPrincipalName"); }
            set { BackingStore?.Set("assignedUserPrincipalName", value); }
        }
#endif
        /// <summary>Group Tag of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupTag {
            get { return BackingStore?.Get<string?>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
#nullable restore
#else
        public string GroupTag {
            get { return BackingStore?.Get<string>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
#endif
        /// <summary>Hardware Blob of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? HardwareIdentifier {
            get { return BackingStore?.Get<byte[]?>("hardwareIdentifier"); }
            set { BackingStore?.Set("hardwareIdentifier", value); }
        }
#nullable restore
#else
        public byte[] HardwareIdentifier {
            get { return BackingStore?.Get<byte[]>("hardwareIdentifier"); }
            set { BackingStore?.Set("hardwareIdentifier", value); }
        }
#endif
        /// <summary>The Import Id of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImportId {
            get { return BackingStore?.Get<string?>("importId"); }
            set { BackingStore?.Set("importId", value); }
        }
#nullable restore
#else
        public string ImportId {
            get { return BackingStore?.Get<string>("importId"); }
            set { BackingStore?.Set("importId", value); }
        }
#endif
        /// <summary>Product Key of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey {
            get { return BackingStore?.Get<string?>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#nullable restore
#else
        public string ProductKey {
            get { return BackingStore?.Get<string>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#endif
        /// <summary>Serial number of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>Current state of the imported device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ImportedWindowsAutopilotDeviceIdentityState? State {
            get { return BackingStore?.Get<ImportedWindowsAutopilotDeviceIdentityState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public ImportedWindowsAutopilotDeviceIdentityState State {
            get { return BackingStore?.Get<ImportedWindowsAutopilotDeviceIdentityState>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImportedWindowsAutopilotDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedWindowsAutopilotDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedUserPrincipalName", n => { AssignedUserPrincipalName = n.GetStringValue(); } },
                {"groupTag", n => { GroupTag = n.GetStringValue(); } },
                {"hardwareIdentifier", n => { HardwareIdentifier = n.GetByteArrayValue(); } },
                {"importId", n => { ImportId = n.GetStringValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"state", n => { State = n.GetObjectValue<ImportedWindowsAutopilotDeviceIdentityState>(ImportedWindowsAutopilotDeviceIdentityState.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignedUserPrincipalName", AssignedUserPrincipalName);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteByteArrayValue("hardwareIdentifier", HardwareIdentifier);
            writer.WriteStringValue("importId", ImportId);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteObjectValue<ImportedWindowsAutopilotDeviceIdentityState>("state", State);
        }
    }
}
