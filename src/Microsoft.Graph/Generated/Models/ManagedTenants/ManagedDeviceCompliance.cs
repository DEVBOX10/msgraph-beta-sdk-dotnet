using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedDeviceCompliance : Entity, IParsable {
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComplianceStatus {
            get { return BackingStore?.Get<string?>("complianceStatus"); }
            set { BackingStore?.Set("complianceStatus", value); }
        }
#nullable restore
#else
        public string ComplianceStatus {
            get { return BackingStore?.Get<string>("complianceStatus"); }
            set { BackingStore?.Set("complianceStatus", value); }
        }
#endif
        /// <summary>Platform of the device. This property is read-only. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.  Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType {
            get { return BackingStore?.Get<string?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#nullable restore
#else
        public string DeviceType {
            get { return BackingStore?.Get<string>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#endif
        /// <summary>The date and time when the grace period will expire. Optional. Read-only.</summary>
        public DateTimeOffset? InGracePeriodUntilDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("inGracePeriodUntilDateTime"); }
            set { BackingStore?.Set("inGracePeriodUntilDateTime", value); }
        }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The date and time that the device last completed a successful sync with Microsoft Endpoint Manager. Optional. Read-only.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The identifier for the managed device in Microsoft Endpoint Manager. Optional. Read-only.</summary>
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
        /// <summary>The display name for the managed device. Optional. Read-only.</summary>
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
        /// <summary>The manufacture for the device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The model for the device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>The description of the operating system for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDescription {
            get { return BackingStore?.Get<string?>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#nullable restore
#else
        public string OsDescription {
            get { return BackingStore?.Get<string>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#endif
        /// <summary>The version of the operating system for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>The type of owner for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerType {
            get { return BackingStore?.Get<string?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
#nullable restore
#else
        public string OwnerType {
            get { return BackingStore?.Get<string>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
#endif
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedDeviceCompliance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceCompliance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"complianceStatus", n => { ComplianceStatus = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetStringValue(); } },
                {"inGracePeriodUntilDateTime", n => { InGracePeriodUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetStringValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("complianceStatus", ComplianceStatus);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteDateTimeOffsetValue("inGracePeriodUntilDateTime", InGracePeriodUntilDateTime);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("ownerType", OwnerType);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
