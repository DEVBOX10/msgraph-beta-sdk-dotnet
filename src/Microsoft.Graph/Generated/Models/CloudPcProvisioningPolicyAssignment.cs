// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcProvisioningPolicyAssignment : Entity, IParsable {
        /// <summary>The assignment targeted users for the provisioning policy. This list of users is computed based on assignments, licenses, group memberships, and policies. This property is read-only. Supports$expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<User>? AssignedUsers {
            get { return BackingStore?.Get<List<User>?>("assignedUsers"); }
            set { BackingStore?.Set("assignedUsers", value); }
        }
#nullable restore
#else
        public List<User> AssignedUsers {
            get { return BackingStore?.Get<List<User>>("assignedUsers"); }
            set { BackingStore?.Set("assignedUsers", value); }
        }
#endif
        /// <summary>The assignment target for the provisioning policy. Currently, the only target supported for this policy is a user group. For details, see cloudPcManagementGroupAssignmentTarget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcManagementAssignmentTarget? Target {
            get { return BackingStore?.Get<CloudPcManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public CloudPcManagementAssignmentTarget Target {
            get { return BackingStore?.Get<CloudPcManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcProvisioningPolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcProvisioningPolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedUsers", n => { AssignedUsers = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue)?.ToList(); } },
                {"target", n => { Target = n.GetObjectValue<CloudPcManagementAssignmentTarget>(CloudPcManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<User>("assignedUsers", AssignedUsers);
            writer.WriteObjectValue<CloudPcManagementAssignmentTarget>("target", Target);
        }
    }
}
