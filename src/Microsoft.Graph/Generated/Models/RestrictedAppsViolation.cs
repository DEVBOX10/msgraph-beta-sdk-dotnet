using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Violation of restricted apps configuration profile per device per user
    /// </summary>
    public class RestrictedAppsViolation : Entity, IParsable {
        /// <summary>Device configuration profile unique identifier, must be Guid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceConfigurationId {
            get { return BackingStore?.Get<string?>("deviceConfigurationId"); }
            set { BackingStore?.Set("deviceConfigurationId", value); }
        }
#nullable restore
#else
        public string DeviceConfigurationId {
            get { return BackingStore?.Get<string>("deviceConfigurationId"); }
            set { BackingStore?.Set("deviceConfigurationId", value); }
        }
#endif
        /// <summary>Device configuration profile name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceConfigurationName {
            get { return BackingStore?.Get<string?>("deviceConfigurationName"); }
            set { BackingStore?.Set("deviceConfigurationName", value); }
        }
#nullable restore
#else
        public string DeviceConfigurationName {
            get { return BackingStore?.Get<string>("deviceConfigurationName"); }
            set { BackingStore?.Set("deviceConfigurationName", value); }
        }
#endif
        /// <summary>Device name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>Managed device unique identifier, must be Guid</summary>
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
        /// <summary>Supported platform types for policies.</summary>
        public PolicyPlatformType? PlatformType {
            get { return BackingStore?.Get<PolicyPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>List of violated restricted apps</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceReportedApp>? RestrictedApps {
            get { return BackingStore?.Get<List<ManagedDeviceReportedApp>?>("restrictedApps"); }
            set { BackingStore?.Set("restrictedApps", value); }
        }
#nullable restore
#else
        public List<ManagedDeviceReportedApp> RestrictedApps {
            get { return BackingStore?.Get<List<ManagedDeviceReportedApp>>("restrictedApps"); }
            set { BackingStore?.Set("restrictedApps", value); }
        }
#endif
        /// <summary>Restricted apps state</summary>
        public Microsoft.Graph.Beta.Models.RestrictedAppsState? RestrictedAppsState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RestrictedAppsState?>("restrictedAppsState"); }
            set { BackingStore?.Set("restrictedAppsState", value); }
        }
        /// <summary>User unique identifier, must be Guid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>User name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName {
            get { return BackingStore?.Get<string?>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#nullable restore
#else
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RestrictedAppsViolation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RestrictedAppsViolation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceConfigurationId", n => { DeviceConfigurationId = n.GetStringValue(); } },
                {"deviceConfigurationName", n => { DeviceConfigurationName = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"restrictedApps", n => { RestrictedApps = n.GetCollectionOfObjectValues<ManagedDeviceReportedApp>(ManagedDeviceReportedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"restrictedAppsState", n => { RestrictedAppsState = n.GetEnumValue<RestrictedAppsState>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceConfigurationId", DeviceConfigurationId);
            writer.WriteStringValue("deviceConfigurationName", DeviceConfigurationName);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteCollectionOfObjectValues<ManagedDeviceReportedApp>("restrictedApps", RestrictedApps);
            writer.WriteEnumValue<RestrictedAppsState>("restrictedAppsState", RestrictedAppsState);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
