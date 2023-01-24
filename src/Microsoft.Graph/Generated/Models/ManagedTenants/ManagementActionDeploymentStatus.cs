using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementActionDeploymentStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identifier for the management action. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementActionId {
            get { return BackingStore?.Get<string?>("managementActionId"); }
            set { BackingStore?.Set("managementActionId", value); }
        }
#nullable restore
#else
        public string ManagementActionId {
            get { return BackingStore?.Get<string>("managementActionId"); }
            set { BackingStore?.Set("managementActionId", value); }
        }
#endif
        /// <summary>The management template identifier that was used to generate the management action. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateId {
            get { return BackingStore?.Get<string?>("managementTemplateId"); }
            set { BackingStore?.Set("managementTemplateId", value); }
        }
#nullable restore
#else
        public string ManagementTemplateId {
            get { return BackingStore?.Get<string>("managementTemplateId"); }
            set { BackingStore?.Set("managementTemplateId", value); }
        }
#endif
        /// <summary>The managementTemplateVersion property</summary>
        public int? ManagementTemplateVersion {
            get { return BackingStore?.Get<int?>("managementTemplateVersion"); }
            set { BackingStore?.Set("managementTemplateVersion", value); }
        }
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
        /// <summary>The status property</summary>
        public ManagementActionStatus? Status {
            get { return BackingStore?.Get<ManagementActionStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The collection of workload action deployment statues for the given management action. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkloadActionDeploymentStatus>? WorkloadActionDeploymentStatuses {
            get { return BackingStore?.Get<List<WorkloadActionDeploymentStatus>?>("workloadActionDeploymentStatuses"); }
            set { BackingStore?.Set("workloadActionDeploymentStatuses", value); }
        }
#nullable restore
#else
        public List<WorkloadActionDeploymentStatus> WorkloadActionDeploymentStatuses {
            get { return BackingStore?.Get<List<WorkloadActionDeploymentStatus>>("workloadActionDeploymentStatuses"); }
            set { BackingStore?.Set("workloadActionDeploymentStatuses", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new managementActionDeploymentStatus and sets the default values.
        /// </summary>
        public ManagementActionDeploymentStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ManagementActionDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementActionDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"managementActionId", n => { ManagementActionId = n.GetStringValue(); } },
                {"managementTemplateId", n => { ManagementTemplateId = n.GetStringValue(); } },
                {"managementTemplateVersion", n => { ManagementTemplateVersion = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ManagementActionStatus>(); } },
                {"workloadActionDeploymentStatuses", n => { WorkloadActionDeploymentStatuses = n.GetCollectionOfObjectValues<WorkloadActionDeploymentStatus>(WorkloadActionDeploymentStatus.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementActionId", ManagementActionId);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteIntValue("managementTemplateVersion", ManagementTemplateVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ManagementActionStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<WorkloadActionDeploymentStatus>("workloadActionDeploymentStatuses", WorkloadActionDeploymentStatuses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
