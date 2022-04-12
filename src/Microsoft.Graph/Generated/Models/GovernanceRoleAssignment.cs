using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GovernanceRoleAssignment : Entity, IParsable {
        /// <summary>The state of the assignment. The value can be Eligible for eligible assignment or Active if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.</summary>
        public string AssignmentState { get; set; }
        /// <summary>For a non-permanent role assignment, this is the time when the role assignment will be expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The external ID the resource that is used to identify the role assignment in the provider.</summary>
        public string ExternalId { get; set; }
        /// <summary>Read-only. If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.</summary>
        public GovernanceRoleAssignment LinkedEligibleRoleAssignment { get; set; }
        /// <summary>If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.</summary>
        public string LinkedEligibleRoleAssignmentId { get; set; }
        /// <summary>The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment is not inherited, but comes from the membership of a group assignment), or User (if the role assignment is neither inherited nor from a group assignment).</summary>
        public string MemberType { get; set; }
        /// <summary>Read-only. The resource associated with the role assignment.</summary>
        public GovernanceResource Resource { get; set; }
        /// <summary>Required. The ID of the resource which the role assignment is associated with.</summary>
        public string ResourceId { get; set; }
        /// <summary>Read-only. The role definition associated with the role assignment.</summary>
        public GovernanceRoleDefinition RoleDefinition { get; set; }
        /// <summary>Required. The ID of the role definition which the role assignment is associated with.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The status property</summary>
        public string Status { get; set; }
        /// <summary>Read-only. The subject associated with the role assignment.</summary>
        public GovernanceSubject Subject { get; set; }
        /// <summary>Required. The ID of the subject which the role assignment is associated with.</summary>
        public string SubjectId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernanceRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"linkedEligibleRoleAssignment", n => { LinkedEligibleRoleAssignment = n.GetObjectValue<GovernanceRoleAssignment>(GovernanceRoleAssignment.CreateFromDiscriminatorValue); } },
                {"linkedEligibleRoleAssignmentId", n => { LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                {"memberType", n => { MemberType = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetObjectValue<GovernanceSubject>(GovernanceSubject.CreateFromDiscriminatorValue); } },
                {"subjectId", n => { SubjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<GovernanceRoleAssignment>("linkedEligibleRoleAssignment", LinkedEligibleRoleAssignment);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
        }
    }
}
