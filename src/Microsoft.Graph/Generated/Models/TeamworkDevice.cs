using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDevice : Entity, IParsable {
        /// <summary>The activity properties that change based on the device usage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDeviceActivity? Activity {
            get { return BackingStore?.Get<TeamworkDeviceActivity?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public TeamworkDeviceActivity Activity {
            get { return BackingStore?.Get<TeamworkDeviceActivity>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The activity state of the device. The possible values are: unknown, busy, idle, unavailable, unknownFutureValue.</summary>
        public TeamworkDeviceActivityState? ActivityState {
            get { return BackingStore?.Get<TeamworkDeviceActivityState?>("activityState"); }
            set { BackingStore?.Set("activityState", value); }
        }
        /// <summary>The company asset tag assigned by the admin on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyAssetTag {
            get { return BackingStore?.Get<string?>("companyAssetTag"); }
            set { BackingStore?.Set("companyAssetTag", value); }
        }
#nullable restore
#else
        public string CompanyAssetTag {
            get { return BackingStore?.Get<string>("companyAssetTag"); }
            set { BackingStore?.Set("companyAssetTag", value); }
        }
#endif
        /// <summary>The configuration properties of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDeviceConfiguration? Configuration {
            get { return BackingStore?.Get<TeamworkDeviceConfiguration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public TeamworkDeviceConfiguration Configuration {
            get { return BackingStore?.Get<TeamworkDeviceConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>Identity of the user who enrolled the device to the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device was enrolled to the tenant.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The signed-in user on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkUserIdentity? CurrentUser {
            get { return BackingStore?.Get<TeamworkUserIdentity?>("currentUser"); }
            set { BackingStore?.Set("currentUser", value); }
        }
#nullable restore
#else
        public TeamworkUserIdentity CurrentUser {
            get { return BackingStore?.Get<TeamworkUserIdentity>("currentUser"); }
            set { BackingStore?.Set("currentUser", value); }
        }
#endif
        /// <summary>The deviceType property</summary>
        public TeamworkDeviceType? DeviceType {
            get { return BackingStore?.Get<TeamworkDeviceType?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>The hardwareDetail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkHardwareDetail? HardwareDetail {
            get { return BackingStore?.Get<TeamworkHardwareDetail?>("hardwareDetail"); }
            set { BackingStore?.Set("hardwareDetail", value); }
        }
#nullable restore
#else
        public TeamworkHardwareDetail HardwareDetail {
            get { return BackingStore?.Get<TeamworkHardwareDetail>("hardwareDetail"); }
            set { BackingStore?.Set("hardwareDetail", value); }
        }
#endif
        /// <summary>The health properties of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDeviceHealth? Health {
            get { return BackingStore?.Get<TeamworkDeviceHealth?>("health"); }
            set { BackingStore?.Set("health", value); }
        }
#nullable restore
#else
        public TeamworkDeviceHealth Health {
            get { return BackingStore?.Get<TeamworkDeviceHealth>("health"); }
            set { BackingStore?.Set("health", value); }
        }
#endif
        /// <summary>The health status of the device. The possible values are: unknown, offline, critical, nonUrgent, healthy, unknownFutureValue.</summary>
        public TeamworkDeviceHealthStatus? HealthStatus {
            get { return BackingStore?.Get<TeamworkDeviceHealthStatus?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>Identity of the user who last modified the device details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The notes added by the admin to the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The async operations on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkDeviceOperation>? Operations {
            get { return BackingStore?.Get<List<TeamworkDeviceOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<TeamworkDeviceOperation> Operations {
            get { return BackingStore?.Get<List<TeamworkDeviceOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamworkDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetObjectValue<TeamworkDeviceActivity>(TeamworkDeviceActivity.CreateFromDiscriminatorValue); } },
                {"activityState", n => { ActivityState = n.GetEnumValue<TeamworkDeviceActivityState>(); } },
                {"companyAssetTag", n => { CompanyAssetTag = n.GetStringValue(); } },
                {"configuration", n => { Configuration = n.GetObjectValue<TeamworkDeviceConfiguration>(TeamworkDeviceConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"currentUser", n => { CurrentUser = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<TeamworkDeviceType>(); } },
                {"hardwareDetail", n => { HardwareDetail = n.GetObjectValue<TeamworkHardwareDetail>(TeamworkHardwareDetail.CreateFromDiscriminatorValue); } },
                {"health", n => { Health = n.GetObjectValue<TeamworkDeviceHealth>(TeamworkDeviceHealth.CreateFromDiscriminatorValue); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<TeamworkDeviceHealthStatus>(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<TeamworkDeviceOperation>(TeamworkDeviceOperation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkDeviceActivity>("activity", Activity);
            writer.WriteEnumValue<TeamworkDeviceActivityState>("activityState", ActivityState);
            writer.WriteStringValue("companyAssetTag", CompanyAssetTag);
            writer.WriteObjectValue<TeamworkDeviceConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<TeamworkUserIdentity>("currentUser", CurrentUser);
            writer.WriteEnumValue<TeamworkDeviceType>("deviceType", DeviceType);
            writer.WriteObjectValue<TeamworkHardwareDetail>("hardwareDetail", HardwareDetail);
            writer.WriteObjectValue<TeamworkDeviceHealth>("health", Health);
            writer.WriteEnumValue<TeamworkDeviceHealthStatus>("healthStatus", HealthStatus);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("notes", Notes);
            writer.WriteCollectionOfObjectValues<TeamworkDeviceOperation>("operations", Operations);
        }
    }
}
