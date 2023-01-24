using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Connector : Entity, IParsable {
        /// <summary>The external IP address as detected by the the connector server. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalIp {
            get { return BackingStore?.Get<string?>("externalIp"); }
            set { BackingStore?.Set("externalIp", value); }
        }
#nullable restore
#else
        public string ExternalIp {
            get { return BackingStore?.Get<string>("externalIp"); }
            set { BackingStore?.Set("externalIp", value); }
        }
#endif
        /// <summary>The machine name the connector is installed and running on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MachineName {
            get { return BackingStore?.Get<string?>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#nullable restore
#else
        public string MachineName {
            get { return BackingStore?.Get<string>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#endif
        /// <summary>The connectorGroup that the connector is a member of. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConnectorGroup>? MemberOf {
            get { return BackingStore?.Get<List<ConnectorGroup>?>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#nullable restore
#else
        public List<ConnectorGroup> MemberOf {
            get { return BackingStore?.Get<List<ConnectorGroup>>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#endif
        /// <summary>The status property</summary>
        public ConnectorStatus? Status {
            get { return BackingStore?.Get<ConnectorStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Connector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Connector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"externalIp", n => { ExternalIp = n.GetStringValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<ConnectorGroup>(ConnectorGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<ConnectorStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("externalIp", ExternalIp);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteCollectionOfObjectValues<ConnectorGroup>("memberOf", MemberOf);
            writer.WriteEnumValue<ConnectorStatus>("status", Status);
        }
    }
}
