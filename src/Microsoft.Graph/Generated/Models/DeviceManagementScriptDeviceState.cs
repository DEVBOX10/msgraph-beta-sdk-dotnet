using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties for device run state of the device management script.
    /// </summary>
    public class DeviceManagementScriptDeviceState : Entity, IParsable {
        /// <summary>Error code corresponding to erroneous execution of the device management script.</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Error description corresponding to erroneous execution of the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorDescription {
            get { return BackingStore?.Get<string?>("errorDescription"); }
            set { BackingStore?.Set("errorDescription", value); }
        }
#nullable restore
#else
        public string ErrorDescription {
            get { return BackingStore?.Get<string>("errorDescription"); }
            set { BackingStore?.Set("errorDescription", value); }
        }
#endif
        /// <summary>Latest time the device management script executes.</summary>
        public DateTimeOffset? LastStateUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStateUpdateDateTime"); }
            set { BackingStore?.Set("lastStateUpdateDateTime", value); }
        }
        /// <summary>The managed devices that executes the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ManagedDevice? ManagedDevice {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDevice?>("managedDevice"); }
            set { BackingStore?.Set("managedDevice", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ManagedDevice ManagedDevice {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice"); }
            set { BackingStore?.Set("managedDevice", value); }
        }
#endif
        /// <summary>Details of execution output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultMessage {
            get { return BackingStore?.Get<string?>("resultMessage"); }
            set { BackingStore?.Set("resultMessage", value); }
        }
#nullable restore
#else
        public string ResultMessage {
            get { return BackingStore?.Get<string>("resultMessage"); }
            set { BackingStore?.Set("resultMessage", value); }
        }
#endif
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public Microsoft.Graph.Beta.Models.RunState? RunState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RunState?>("runState"); }
            set { BackingStore?.Set("runState", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementScriptDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementScriptDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"errorDescription", n => { ErrorDescription = n.GetStringValue(); } },
                {"lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDevice", n => { ManagedDevice = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>(Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue); } },
                {"resultMessage", n => { ResultMessage = n.GetStringValue(); } },
                {"runState", n => { RunState = n.GetEnumValue<RunState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice", ManagedDevice);
            writer.WriteStringValue("resultMessage", ResultMessage);
            writer.WriteEnumValue<RunState>("runState", RunState);
        }
    }
}
