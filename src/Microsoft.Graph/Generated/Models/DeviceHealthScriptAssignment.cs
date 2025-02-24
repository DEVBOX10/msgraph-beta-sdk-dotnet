// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties used to assign a device management script to a group.
    /// </summary>
    public class DeviceHealthScriptAssignment : Entity, IParsable {
        /// <summary>Determine whether we want to run detection script only or run both detection script and remediation script</summary>
        public bool? RunRemediationScript {
            get { return BackingStore?.Get<bool?>("runRemediationScript"); }
            set { BackingStore?.Set("runRemediationScript", value); }
        }
        /// <summary>Script run schedule for the target group</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceHealthScriptRunSchedule? RunSchedule {
            get { return BackingStore?.Get<DeviceHealthScriptRunSchedule?>("runSchedule"); }
            set { BackingStore?.Set("runSchedule", value); }
        }
#nullable restore
#else
        public DeviceHealthScriptRunSchedule RunSchedule {
            get { return BackingStore?.Get<DeviceHealthScriptRunSchedule>("runSchedule"); }
            set { BackingStore?.Set("runSchedule", value); }
        }
#endif
        /// <summary>The Azure Active Directory group we are targeting the script to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceAndAppManagementAssignmentTarget? Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public DeviceAndAppManagementAssignmentTarget Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScriptAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"runRemediationScript", n => { RunRemediationScript = n.GetBoolValue(); } },
                {"runSchedule", n => { RunSchedule = n.GetObjectValue<DeviceHealthScriptRunSchedule>(DeviceHealthScriptRunSchedule.CreateFromDiscriminatorValue); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("runRemediationScript", RunRemediationScript);
            writer.WriteObjectValue<DeviceHealthScriptRunSchedule>("runSchedule", RunSchedule);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
