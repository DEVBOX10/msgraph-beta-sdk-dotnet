using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceAppManagementTask : Entity, IParsable {
        /// <summary>The name or email of the admin this task is assigned to.</summary>
        public string AssignedTo { get; set; }
        /// <summary>The category. Possible values are: unknown, advancedThreatProtection.</summary>
        public DeviceAppManagementTaskCategory? Category { get; set; }
        /// <summary>The created date.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The email address of the creator.</summary>
        public string Creator { get; set; }
        /// <summary>Notes from the creator.</summary>
        public string CreatorNotes { get; set; }
        /// <summary>The description.</summary>
        public string Description { get; set; }
        /// <summary>The name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The due date.</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>The priority. Possible values are: none, high, low.</summary>
        public DeviceAppManagementTaskPriority? Priority { get; set; }
        /// <summary>The status. Possible values are: unknown, pending, active, completed, rejected.</summary>
        public DeviceAppManagementTaskStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceAppManagementTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagementTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"category", n => { Category = n.GetEnumValue<DeviceAppManagementTaskCategory>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creator", n => { Creator = n.GetStringValue(); } },
                {"creatorNotes", n => { CreatorNotes = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", n => { Priority = n.GetEnumValue<DeviceAppManagementTaskPriority>(); } },
                {"status", n => { Status = n.GetEnumValue<DeviceAppManagementTaskStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteEnumValue<DeviceAppManagementTaskCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("creator", Creator);
            writer.WriteStringValue("creatorNotes", CreatorNotes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteEnumValue<DeviceAppManagementTaskPriority>("priority", Priority);
            writer.WriteEnumValue<DeviceAppManagementTaskStatus>("status", Status);
        }
    }
}
