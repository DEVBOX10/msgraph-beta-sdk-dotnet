// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedAccessGroup : Entity, IParsable {
        /// <summary>The assignmentApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Approval>? AssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>?>("assignmentApprovals"); }
            set { BackingStore?.Set("assignmentApprovals", value); }
        }
#nullable restore
#else
        public List<Approval> AssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>("assignmentApprovals"); }
            set { BackingStore?.Set("assignmentApprovals", value); }
        }
#endif
        /// <summary>The instances of assignment schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegedAccessGroupAssignmentScheduleInstance>? AssignmentScheduleInstances {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentScheduleInstance>?>("assignmentScheduleInstances"); }
            set { BackingStore?.Set("assignmentScheduleInstances", value); }
        }
#nullable restore
#else
        public List<PrivilegedAccessGroupAssignmentScheduleInstance> AssignmentScheduleInstances {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentScheduleInstance>>("assignmentScheduleInstances"); }
            set { BackingStore?.Set("assignmentScheduleInstances", value); }
        }
#endif
        /// <summary>The schedule requests for operations to create, update, delete, extend, and renew an assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegedAccessGroupAssignmentScheduleRequest>? AssignmentScheduleRequests {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentScheduleRequest>?>("assignmentScheduleRequests"); }
            set { BackingStore?.Set("assignmentScheduleRequests", value); }
        }
#nullable restore
#else
        public List<PrivilegedAccessGroupAssignmentScheduleRequest> AssignmentScheduleRequests {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentScheduleRequest>>("assignmentScheduleRequests"); }
            set { BackingStore?.Set("assignmentScheduleRequests", value); }
        }
#endif
        /// <summary>The assignment schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegedAccessGroupAssignmentSchedule>? AssignmentSchedules {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentSchedule>?>("assignmentSchedules"); }
            set { BackingStore?.Set("assignmentSchedules", value); }
        }
#nullable restore
#else
        public List<PrivilegedAccessGroupAssignmentSchedule> AssignmentSchedules {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentSchedule>>("assignmentSchedules"); }
            set { BackingStore?.Set("assignmentSchedules", value); }
        }
#endif
        /// <summary>The instances of eligibility schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegedAccessGroupEligibilityScheduleInstance>? EligibilityScheduleInstances {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilityScheduleInstance>?>("eligibilityScheduleInstances"); }
            set { BackingStore?.Set("eligibilityScheduleInstances", value); }
        }
#nullable restore
#else
        public List<PrivilegedAccessGroupEligibilityScheduleInstance> EligibilityScheduleInstances {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilityScheduleInstance>>("eligibilityScheduleInstances"); }
            set { BackingStore?.Set("eligibilityScheduleInstances", value); }
        }
#endif
        /// <summary>The schedule requests for operations to create, update, delete, extend, and renew an eligibility.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegedAccessGroupEligibilityScheduleRequest>? EligibilityScheduleRequests {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilityScheduleRequest>?>("eligibilityScheduleRequests"); }
            set { BackingStore?.Set("eligibilityScheduleRequests", value); }
        }
#nullable restore
#else
        public List<PrivilegedAccessGroupEligibilityScheduleRequest> EligibilityScheduleRequests {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilityScheduleRequest>>("eligibilityScheduleRequests"); }
            set { BackingStore?.Set("eligibilityScheduleRequests", value); }
        }
#endif
        /// <summary>The eligibility schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrivilegedAccessGroupEligibilitySchedule>? EligibilitySchedules {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilitySchedule>?>("eligibilitySchedules"); }
            set { BackingStore?.Set("eligibilitySchedules", value); }
        }
#nullable restore
#else
        public List<PrivilegedAccessGroupEligibilitySchedule> EligibilitySchedules {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilitySchedule>>("eligibilitySchedules"); }
            set { BackingStore?.Set("eligibilitySchedules", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentApprovals", n => { AssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentScheduleInstances", n => { AssignmentScheduleInstances = n.GetCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleInstance>(PrivilegedAccessGroupAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentScheduleRequests", n => { AssignmentScheduleRequests = n.GetCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleRequest>(PrivilegedAccessGroupAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentSchedules", n => { AssignmentSchedules = n.GetCollectionOfObjectValues<PrivilegedAccessGroupAssignmentSchedule>(PrivilegedAccessGroupAssignmentSchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eligibilityScheduleInstances", n => { EligibilityScheduleInstances = n.GetCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleInstance>(PrivilegedAccessGroupEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eligibilityScheduleRequests", n => { EligibilityScheduleRequests = n.GetCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleRequest>(PrivilegedAccessGroupEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eligibilitySchedules", n => { EligibilitySchedules = n.GetCollectionOfObjectValues<PrivilegedAccessGroupEligibilitySchedule>(PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Approval>("assignmentApprovals", AssignmentApprovals);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleInstance>("assignmentScheduleInstances", AssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleRequest>("assignmentScheduleRequests", AssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupAssignmentSchedule>("assignmentSchedules", AssignmentSchedules);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleInstance>("eligibilityScheduleInstances", EligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleRequest>("eligibilityScheduleRequests", EligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupEligibilitySchedule>("eligibilitySchedules", EligibilitySchedules);
        }
    }
}
