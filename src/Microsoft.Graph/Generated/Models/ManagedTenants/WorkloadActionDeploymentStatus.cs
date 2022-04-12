using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class WorkloadActionDeploymentStatus : IAdditionalDataHolder, IParsable {
        /// <summary>The unique identifier for the workload action. Required. Read-only.</summary>
        public string ActionId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier of any policy that was created by applying the workload action. Optional. Read-only.</summary>
        public string DeployedPolicyId { get; set; }
        /// <summary>The detailed information for exceptions that occur when deploying the workload action. Optional. Required.</summary>
        public Microsoft.Graph.Beta.Models.GenericError Error { get; set; }
        /// <summary>The excludeGroups property</summary>
        public List<string> ExcludeGroups { get; set; }
        /// <summary>The includeAllUsers property</summary>
        public bool? IncludeAllUsers { get; set; }
        /// <summary>The includeGroups property</summary>
        public List<string> IncludeGroups { get; set; }
        /// <summary>The date and time the workload action was last deployed. Optional.</summary>
        public DateTimeOffset? LastDeploymentDateTime { get; set; }
        /// <summary>The status of the workload action deployment. Possible values are: toAddress, completed, error, timeOut, inProgress, unknownFutureValue. Required. Read-only.</summary>
        public WorkloadActionStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new workloadActionDeploymentStatus and sets the default values.
        /// </summary>
        public WorkloadActionDeploymentStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WorkloadActionDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkloadActionDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionId", n => { ActionId = n.GetStringValue(); } },
                {"deployedPolicyId", n => { DeployedPolicyId = n.GetStringValue(); } },
                {"error", n => { Error = n.GetObjectValue<Microsoft.Graph.Beta.Models.GenericError>(Microsoft.Graph.Beta.Models.GenericError.CreateFromDiscriminatorValue); } },
                {"excludeGroups", n => { ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeAllUsers", n => { IncludeAllUsers = n.GetBoolValue(); } },
                {"includeGroups", n => { IncludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"lastDeploymentDateTime", n => { LastDeploymentDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<WorkloadActionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionId", ActionId);
            writer.WriteStringValue("deployedPolicyId", DeployedPolicyId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GenericError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteBoolValue("includeAllUsers", IncludeAllUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteDateTimeOffsetValue("lastDeploymentDateTime", LastDeploymentDateTime);
            writer.WriteEnumValue<WorkloadActionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
