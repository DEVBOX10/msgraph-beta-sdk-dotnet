using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftTunnelSite : Entity, IParsable {
        /// <summary>The site&apos;s description (optional)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name for the site. This property is required when a site is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The site&apos;s Internal Network Access Probe URL</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalNetworkProbeUrl {
            get { return BackingStore?.Get<string?>("internalNetworkProbeUrl"); }
            set { BackingStore?.Set("internalNetworkProbeUrl", value); }
        }
#nullable restore
#else
        public string InternalNetworkProbeUrl {
            get { return BackingStore?.Get<string>("internalNetworkProbeUrl"); }
            set { BackingStore?.Set("internalNetworkProbeUrl", value); }
        }
#endif
        /// <summary>The MicrosoftTunnelConfiguration that has been applied to this MicrosoftTunnelSite</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration? MicrosoftTunnelConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration?>("microsoftTunnelConfiguration"); }
            set { BackingStore?.Set("microsoftTunnelConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration MicrosoftTunnelConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>("microsoftTunnelConfiguration"); }
            set { BackingStore?.Set("microsoftTunnelConfiguration", value); }
        }
#endif
        /// <summary>A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MicrosoftTunnelServer>? MicrosoftTunnelServers {
            get { return BackingStore?.Get<List<MicrosoftTunnelServer>?>("microsoftTunnelServers"); }
            set { BackingStore?.Set("microsoftTunnelServers", value); }
        }
#nullable restore
#else
        public List<MicrosoftTunnelServer> MicrosoftTunnelServers {
            get { return BackingStore?.Get<List<MicrosoftTunnelServer>>("microsoftTunnelServers"); }
            set { BackingStore?.Set("microsoftTunnelServers", value); }
        }
#endif
        /// <summary>The site&apos;s public domain name or IP address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicAddress {
            get { return BackingStore?.Get<string?>("publicAddress"); }
            set { BackingStore?.Set("publicAddress", value); }
        }
#nullable restore
#else
        public string PublicAddress {
            get { return BackingStore?.Get<string>("publicAddress"); }
            set { BackingStore?.Set("publicAddress", value); }
        }
#endif
        /// <summary>List of Scope Tags for this Entity instance</summary>
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
        /// <summary>The site&apos;s automatic upgrade setting. True for automatic upgrades, false for manual control</summary>
        public bool? UpgradeAutomatically {
            get { return BackingStore?.Get<bool?>("upgradeAutomatically"); }
            set { BackingStore?.Set("upgradeAutomatically", value); }
        }
        /// <summary>The site provides the state of when an upgrade is available</summary>
        public bool? UpgradeAvailable {
            get { return BackingStore?.Get<bool?>("upgradeAvailable"); }
            set { BackingStore?.Set("upgradeAvailable", value); }
        }
        /// <summary>The site&apos;s upgrade window end time of day</summary>
        public Time? UpgradeWindowEndTime {
            get { return BackingStore?.Get<Time?>("upgradeWindowEndTime"); }
            set { BackingStore?.Set("upgradeWindowEndTime", value); }
        }
        /// <summary>The site&apos;s upgrade window start time of day</summary>
        public Time? UpgradeWindowStartTime {
            get { return BackingStore?.Get<Time?>("upgradeWindowStartTime"); }
            set { BackingStore?.Set("upgradeWindowStartTime", value); }
        }
        /// <summary>The site&apos;s timezone represented as a minute offset from UTC</summary>
        public int? UpgradeWindowUtcOffsetInMinutes {
            get { return BackingStore?.Get<int?>("upgradeWindowUtcOffsetInMinutes"); }
            set { BackingStore?.Set("upgradeWindowUtcOffsetInMinutes", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftTunnelSite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"internalNetworkProbeUrl", n => { InternalNetworkProbeUrl = n.GetStringValue(); } },
                {"microsoftTunnelConfiguration", n => { MicrosoftTunnelConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>(Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelServers", n => { MicrosoftTunnelServers = n.GetCollectionOfObjectValues<MicrosoftTunnelServer>(MicrosoftTunnelServer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"publicAddress", n => { PublicAddress = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"upgradeAutomatically", n => { UpgradeAutomatically = n.GetBoolValue(); } },
                {"upgradeAvailable", n => { UpgradeAvailable = n.GetBoolValue(); } },
                {"upgradeWindowEndTime", n => { UpgradeWindowEndTime = n.GetTimeValue(); } },
                {"upgradeWindowStartTime", n => { UpgradeWindowStartTime = n.GetTimeValue(); } },
                {"upgradeWindowUtcOffsetInMinutes", n => { UpgradeWindowUtcOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("internalNetworkProbeUrl", InternalNetworkProbeUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelConfiguration>("microsoftTunnelConfiguration", MicrosoftTunnelConfiguration);
            writer.WriteCollectionOfObjectValues<MicrosoftTunnelServer>("microsoftTunnelServers", MicrosoftTunnelServers);
            writer.WriteStringValue("publicAddress", PublicAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("upgradeAutomatically", UpgradeAutomatically);
            writer.WriteBoolValue("upgradeAvailable", UpgradeAvailable);
            writer.WriteTimeValue("upgradeWindowEndTime", UpgradeWindowEndTime);
            writer.WriteTimeValue("upgradeWindowStartTime", UpgradeWindowStartTime);
            writer.WriteIntValue("upgradeWindowUtcOffsetInMinutes", UpgradeWindowUtcOffsetInMinutes);
        }
    }
}
