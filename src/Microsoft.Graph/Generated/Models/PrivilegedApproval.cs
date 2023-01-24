using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedApproval : Entity, IParsable {
        /// <summary>The approvalDuration property</summary>
        public TimeSpan? ApprovalDuration {
            get { return BackingStore?.Get<TimeSpan?>("approvalDuration"); }
            set { BackingStore?.Set("approvalDuration", value); }
        }
        /// <summary>Possible values are: pending, approved, denied, aborted, canceled.</summary>
        public Microsoft.Graph.Beta.Models.ApprovalState? ApprovalState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApprovalState?>("approvalState"); }
            set { BackingStore?.Set("approvalState", value); }
        }
        /// <summary>The approvalType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApprovalType {
            get { return BackingStore?.Get<string?>("approvalType"); }
            set { BackingStore?.Set("approvalType", value); }
        }
#nullable restore
#else
        public string ApprovalType {
            get { return BackingStore?.Get<string>("approvalType"); }
            set { BackingStore?.Set("approvalType", value); }
        }
#endif
        /// <summary>The approverReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApproverReason {
            get { return BackingStore?.Get<string?>("approverReason"); }
            set { BackingStore?.Set("approverReason", value); }
        }
#nullable restore
#else
        public string ApproverReason {
            get { return BackingStore?.Get<string>("approverReason"); }
            set { BackingStore?.Set("approverReason", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Read-only. The role assignment request for this approval object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedRoleAssignmentRequest? Request {
            get { return BackingStore?.Get<PrivilegedRoleAssignmentRequest?>("request"); }
            set { BackingStore?.Set("request", value); }
        }
#nullable restore
#else
        public PrivilegedRoleAssignmentRequest Request {
            get { return BackingStore?.Get<PrivilegedRoleAssignmentRequest>("request"); }
            set { BackingStore?.Set("request", value); }
        }
#endif
        /// <summary>The requestorReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestorReason {
            get { return BackingStore?.Get<string?>("requestorReason"); }
            set { BackingStore?.Set("requestorReason", value); }
        }
#nullable restore
#else
        public string RequestorReason {
            get { return BackingStore?.Get<string>("requestorReason"); }
            set { BackingStore?.Set("requestorReason", value); }
        }
#endif
        /// <summary>The roleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId {
            get { return BackingStore?.Get<string?>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#nullable restore
#else
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#endif
        /// <summary>The roleInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedRole? RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole?>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
#nullable restore
#else
        public PrivilegedRole RoleInfo {
            get { return BackingStore?.Get<PrivilegedRole>("roleInfo"); }
            set { BackingStore?.Set("roleInfo", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedApproval CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedApproval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"approvalDuration", n => { ApprovalDuration = n.GetTimeSpanValue(); } },
                {"approvalState", n => { ApprovalState = n.GetEnumValue<ApprovalState>(); } },
                {"approvalType", n => { ApprovalType = n.GetStringValue(); } },
                {"approverReason", n => { ApproverReason = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"request", n => { Request = n.GetObjectValue<PrivilegedRoleAssignmentRequest>(PrivilegedRoleAssignmentRequest.CreateFromDiscriminatorValue); } },
                {"requestorReason", n => { RequestorReason = n.GetStringValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleInfo", n => { RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("approvalDuration", ApprovalDuration);
            writer.WriteEnumValue<ApprovalState>("approvalState", ApprovalState);
            writer.WriteStringValue("approvalType", ApprovalType);
            writer.WriteStringValue("approverReason", ApproverReason);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<PrivilegedRoleAssignmentRequest>("request", Request);
            writer.WriteStringValue("requestorReason", RequestorReason);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<PrivilegedRole>("roleInfo", RoleInfo);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
