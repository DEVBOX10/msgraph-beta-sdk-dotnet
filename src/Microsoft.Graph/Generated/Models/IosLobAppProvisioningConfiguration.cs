using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>This topic provides descriptions of the declared methods, properties and relationships exposed by the iOS Lob App Provisioning Configuration resource.</summary>
    public class IosLobAppProvisioningConfiguration : Entity, IParsable {
        /// <summary>The associated group assignments for IosLobAppProvisioningConfiguration.</summary>
        public List<IosLobAppProvisioningConfigurationAssignment> Assignments {
            get { return BackingStore?.Get<List<IosLobAppProvisioningConfigurationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The list of device installation states for this mobile app configuration.</summary>
        public List<ManagedDeviceMobileAppConfigurationDeviceStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationDeviceStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Optional profile expiration date and time.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The associated group assignments.</summary>
        public List<MobileAppProvisioningConfigGroupAssignment> GroupAssignments {
            get { return BackingStore?.Get<List<MobileAppProvisioningConfigGroupAssignment>>("groupAssignments"); }
            set { BackingStore?.Set("groupAssignments", value); }
        }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
        public byte[] Payload {
            get { return BackingStore?.Get<byte[]>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
        /// <summary>Payload file name (.mobileprovision</summary>
        public string PayloadFileName {
            get { return BackingStore?.Get<string>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
        /// <summary>List of Scope Tags for this iOS LOB app provisioning configuration entity.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The list of user installation states for this mobile app configuration.</summary>
        public List<ManagedDeviceMobileAppConfigurationUserStatus> UserStatuses {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationUserStatus>>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
        /// <summary>Version of the device configuration.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new iosLobAppProvisioningConfiguration and sets the default values.
        /// </summary>
        public IosLobAppProvisioningConfiguration() : base() {
            OdataType = "#microsoft.graph.iosLobAppProvisioningConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosLobAppProvisioningConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosLobAppProvisioningConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>(IosLobAppProvisioningConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>(ManagedDeviceMobileAppConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>(MobileAppProvisioningConfigGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payload", n => { Payload = n.GetByteArrayValue(); } },
                {"payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>(ManagedDeviceMobileAppConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteIntValue("version", Version);
        }
    }
}
