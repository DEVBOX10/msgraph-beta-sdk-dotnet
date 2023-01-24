using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity that represents a single Microsoft Tunnel server
    /// </summary>
    public class MicrosoftTunnelServer : Entity, IParsable {
        /// <summary>The digest of the current agent image running on this server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgentImageDigest {
            get { return BackingStore?.Get<string?>("agentImageDigest"); }
            set { BackingStore?.Set("agentImageDigest", value); }
        }
#nullable restore
#else
        public string AgentImageDigest {
            get { return BackingStore?.Get<string>("agentImageDigest"); }
            set { BackingStore?.Set("agentImageDigest", value); }
        }
#endif
        /// <summary>The display name for the server. This property is required when a server is created and cannot be cleared during updates.</summary>
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
        /// <summary>Indicates when the server last checked in</summary>
        public DateTimeOffset? LastCheckinDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckinDateTime"); }
            set { BackingStore?.Set("lastCheckinDateTime", value); }
        }
        /// <summary>The digest of the current server image running on this server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerImageDigest {
            get { return BackingStore?.Get<string?>("serverImageDigest"); }
            set { BackingStore?.Set("serverImageDigest", value); }
        }
#nullable restore
#else
        public string ServerImageDigest {
            get { return BackingStore?.Get<string>("serverImageDigest"); }
            set { BackingStore?.Set("serverImageDigest", value); }
        }
#endif
        /// <summary>Enum of possible MicrosoftTunnelServer health status types</summary>
        public MicrosoftTunnelServerHealthStatus? TunnelServerHealthStatus {
            get { return BackingStore?.Get<MicrosoftTunnelServerHealthStatus?>("tunnelServerHealthStatus"); }
            set { BackingStore?.Set("tunnelServerHealthStatus", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftTunnelServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTunnelServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentImageDigest", n => { AgentImageDigest = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastCheckinDateTime", n => { LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"serverImageDigest", n => { ServerImageDigest = n.GetStringValue(); } },
                {"tunnelServerHealthStatus", n => { TunnelServerHealthStatus = n.GetEnumValue<MicrosoftTunnelServerHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("agentImageDigest", AgentImageDigest);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastCheckinDateTime", LastCheckinDateTime);
            writer.WriteStringValue("serverImageDigest", ServerImageDigest);
            writer.WriteEnumValue<MicrosoftTunnelServerHealthStatus>("tunnelServerHealthStatus", TunnelServerHealthStatus);
        }
    }
}
