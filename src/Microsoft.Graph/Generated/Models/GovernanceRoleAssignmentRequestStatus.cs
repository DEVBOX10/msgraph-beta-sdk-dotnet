using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GovernanceRoleAssignmentRequestStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The status of the role assignment request. The value can be InProgress or Closed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The details of the status of the role assignment request. It represents the evaluation results of different rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? StatusDetails {
            get { return BackingStore?.Get<List<KeyValue>?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#nullable restore
#else
        public List<KeyValue> StatusDetails {
            get { return BackingStore?.Get<List<KeyValue>>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#endif
        /// <summary>The sub status of the role assignment request. The values can be Accepted, PendingEvaluation, Granted, Denied, PendingProvisioning, Provisioned, PendingRevocation, Revoked, Canceled, Failed, PendingApprovalProvisioning, PendingApproval, FailedAsResourceIsLocked, PendingAdminDecision, AdminApproved, AdminDenied, TimedOut, and ProvisioningStarted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubStatus {
            get { return BackingStore?.Get<string?>("subStatus"); }
            set { BackingStore?.Set("subStatus", value); }
        }
#nullable restore
#else
        public string SubStatus {
            get { return BackingStore?.Get<string>("subStatus"); }
            set { BackingStore?.Set("subStatus", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new governanceRoleAssignmentRequestStatus and sets the default values.
        /// </summary>
        public GovernanceRoleAssignmentRequestStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GovernanceRoleAssignmentRequestStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleAssignmentRequestStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"statusDetails", n => { StatusDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subStatus", n => { SubStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfObjectValues<KeyValue>("statusDetails", StatusDetails);
            writer.WriteStringValue("subStatus", SubStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
