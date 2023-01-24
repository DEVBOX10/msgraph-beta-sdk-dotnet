using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// ManagedDevices that are scheduled for retire
    /// </summary>
    public class RetireScheduledManagedDevice : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The complianceState property</summary>
        public ComplianceStatus? ComplianceState {
            get { return BackingStore?.Get<ComplianceStatus?>("complianceState"); }
            set { BackingStore?.Set("complianceState", value); }
        }
        /// <summary>Device Compliance PolicyId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceCompliancePolicyId {
            get { return BackingStore?.Get<string?>("deviceCompliancePolicyId"); }
            set { BackingStore?.Set("deviceCompliancePolicyId", value); }
        }
#nullable restore
#else
        public string DeviceCompliancePolicyId {
            get { return BackingStore?.Get<string>("deviceCompliancePolicyId"); }
            set { BackingStore?.Set("deviceCompliancePolicyId", value); }
        }
#endif
        /// <summary>Device Compliance Policy Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceCompliancePolicyName {
            get { return BackingStore?.Get<string?>("deviceCompliancePolicyName"); }
            set { BackingStore?.Set("deviceCompliancePolicyName", value); }
        }
#nullable restore
#else
        public string DeviceCompliancePolicyName {
            get { return BackingStore?.Get<string>("deviceCompliancePolicyName"); }
            set { BackingStore?.Set("deviceCompliancePolicyName", value); }
        }
#endif
        /// <summary>Device type.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>Key of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>Managed DeviceId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>Managed Device Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName {
            get { return BackingStore?.Get<string?>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#nullable restore
#else
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#endif
        /// <summary>Management agent type.</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>("managementAgent"); }
            set { BackingStore?.Set("managementAgent", value); }
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
        /// <summary>Owner type of device.</summary>
        public ManagedDeviceOwnerType? OwnerType {
            get { return BackingStore?.Get<ManagedDeviceOwnerType?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
        /// <summary>Managed Device Retire After DateTime</summary>
        public DateTimeOffset? RetireAfterDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("retireAfterDateTime"); }
            set { BackingStore?.Set("retireAfterDateTime", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new retireScheduledManagedDevice and sets the default values.
        /// </summary>
        public RetireScheduledManagedDevice() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RetireScheduledManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetireScheduledManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceStatus>(); } },
                {"deviceCompliancePolicyId", n => { DeviceCompliancePolicyId = n.GetStringValue(); } },
                {"deviceCompliancePolicyName", n => { DeviceCompliancePolicyName = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"retireAfterDateTime", n => { RetireAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ComplianceStatus>("complianceState", ComplianceState);
            writer.WriteStringValue("deviceCompliancePolicyId", DeviceCompliancePolicyId);
            writer.WriteStringValue("deviceCompliancePolicyName", DeviceCompliancePolicyName);
            writer.WriteEnumValue<DeviceType>("deviceType", DeviceType);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("ownerType", OwnerType);
            writer.WriteDateTimeOffsetValue("retireAfterDateTime", RetireAfterDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
