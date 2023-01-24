using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerVpnConfiguration : VpnConfiguration, IParsable {
        /// <summary>Whether or not to enable always-on VPN connection.</summary>
        public bool? AlwaysOn {
            get { return BackingStore?.Get<bool?>("alwaysOn"); }
            set { BackingStore?.Set("alwaysOn", value); }
        }
        /// <summary>If always-on VPN connection is enabled, whether or not to lock network traffic when that VPN is disconnected.</summary>
        public bool? AlwaysOnLockdown {
            get { return BackingStore?.Get<bool?>("alwaysOnLockdown"); }
            set { BackingStore?.Set("alwaysOnLockdown", value); }
        }
        /// <summary>Android VPN connection type.</summary>
        public AndroidVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<AndroidVpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Custom data to define key/value pairs specific to a VPN provider. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? CustomData {
            get { return BackingStore?.Get<List<KeyValue>?>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#nullable restore
#else
        public List<KeyValue> CustomData {
            get { return BackingStore?.Get<List<KeyValue>>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#endif
        /// <summary>Custom data to define key/value pairs specific to a VPN provider. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>?>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#endif
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings?>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#nullable restore
#else
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<AndroidDeviceOwnerCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public AndroidDeviceOwnerCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidDeviceOwnerCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Microsoft Tunnel site ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string?>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#nullable restore
#else
        public string MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#endif
        /// <summary>Proxy server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VpnProxyServer? ProxyServer {
            get { return BackingStore?.Get<VpnProxyServer?>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#nullable restore
#else
        public VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<VpnProxyServer>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#endif
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? TargetedMobileApps {
            get { return BackingStore?.Get<List<AppListItem>?>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
#nullable restore
#else
        public List<AppListItem> TargetedMobileApps {
            get { return BackingStore?.Get<List<AppListItem>>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
#endif
        /// <summary>Targeted App package IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TargetedPackageIds {
            get { return BackingStore?.Get<List<string>?>("targetedPackageIds"); }
            set { BackingStore?.Set("targetedPackageIds", value); }
        }
#nullable restore
#else
        public List<string> TargetedPackageIds {
            get { return BackingStore?.Get<List<string>>("targetedPackageIds"); }
            set { BackingStore?.Set("targetedPackageIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AndroidDeviceOwnerVpnConfiguration and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerVpnConfiguration() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alwaysOn", n => { AlwaysOn = n.GetBoolValue(); } },
                {"alwaysOnLockdown", n => { AlwaysOnLockdown = n.GetBoolValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AndroidVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidDeviceOwnerCertificateProfileBase>(AndroidDeviceOwnerCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<VpnProxyServer>(VpnProxyServer.CreateFromDiscriminatorValue); } },
                {"targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedPackageIds", n => { TargetedPackageIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("alwaysOn", AlwaysOn);
            writer.WriteBoolValue("alwaysOnLockdown", AlwaysOnLockdown);
            writer.WriteEnumValue<AndroidVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteObjectValue<AndroidDeviceOwnerCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteObjectValue<VpnProxyServer>("proxyServer", ProxyServer);
            writer.WriteCollectionOfObjectValues<AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedPackageIds", TargetedPackageIds);
        }
    }
}
