using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ImportedAppleDeviceIdentity : Entity, IParsable {
        /// <summary>Created Date Time of the device</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the device</summary>
        public string Description { get; set; }
        /// <summary>Apple device discovery source. Possible values are: unknown, adminImport, deviceEnrollmentProgram.</summary>
        public Microsoft.Graph.Beta.Models.DiscoverySource? DiscoverySource { get; set; }
        /// <summary>The state of the device in Intune. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState { get; set; }
        /// <summary>Indicates if the device is deleted from Apple Business Manager</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837</summary>
        public bool? IsSupervised { get; set; }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime { get; set; }
        /// <summary>The platform of the Device. Possible values are: unknown, ios, android, windows, windowsMobile, macOS.</summary>
        public Microsoft.Graph.Beta.Models.Platform? Platform { get; set; }
        /// <summary>The time enrollment profile was assigned to the device</summary>
        public DateTimeOffset? RequestedEnrollmentProfileAssignmentDateTime { get; set; }
        /// <summary>Enrollment profile Id admin intends to apply to the device during next enrollment</summary>
        public string RequestedEnrollmentProfileId { get; set; }
        /// <summary>Device serial number</summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ImportedAppleDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedAppleDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoverySource", n => { DiscoverySource = n.GetEnumValue<DiscoverySource>(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<Platform>(); } },
                {"requestedEnrollmentProfileAssignmentDateTime", n => { RequestedEnrollmentProfileAssignmentDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestedEnrollmentProfileId", n => { RequestedEnrollmentProfileId = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DiscoverySource>("discoverySource", DiscoverySource);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteBoolValue("isSupervised", IsSupervised);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteEnumValue<Platform>("platform", Platform);
            writer.WriteDateTimeOffsetValue("requestedEnrollmentProfileAssignmentDateTime", RequestedEnrollmentProfileAssignmentDateTime);
            writer.WriteStringValue("requestedEnrollmentProfileId", RequestedEnrollmentProfileId);
            writer.WriteStringValue("serialNumber", SerialNumber);
        }
    }
}
