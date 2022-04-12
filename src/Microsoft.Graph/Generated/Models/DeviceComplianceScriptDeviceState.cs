using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptDeviceState : Entity, IParsable {
        /// <summary>Detection state from the lastest device compliance script execution. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.</summary>
        public RunState? DetectionState { get; set; }
        /// <summary>The next timestamp of when the device compliance script is expected to execute</summary>
        public DateTimeOffset? ExpectedStateUpdateDateTime { get; set; }
        /// <summary>The last timestamp of when the device compliance script executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
        /// <summary>The last time that Intune Managment Extension synced with Intune</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>The managed device on which the device compliance script executed</summary>
        public Microsoft.Graph.Beta.Models.ManagedDevice ManagedDevice { get; set; }
        /// <summary>Error from the detection script</summary>
        public string ScriptError { get; set; }
        /// <summary>Output of the detection script</summary>
        public string ScriptOutput { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceScriptDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionState", n => { DetectionState = n.GetEnumValue<RunState>(); } },
                {"expectedStateUpdateDateTime", n => { ExpectedStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDevice", n => { ManagedDevice = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>(Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue); } },
                {"scriptError", n => { ScriptError = n.GetStringValue(); } },
                {"scriptOutput", n => { ScriptOutput = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<RunState>("detectionState", DetectionState);
            writer.WriteDateTimeOffsetValue("expectedStateUpdateDateTime", ExpectedStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice", ManagedDevice);
            writer.WriteStringValue("scriptError", ScriptError);
            writer.WriteStringValue("scriptOutput", ScriptOutput);
        }
    }
}
