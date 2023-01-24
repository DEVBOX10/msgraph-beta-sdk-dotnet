using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class MailClusterEvidence : AlertEvidence, IParsable {
        /// <summary>The clustering logic of the emails inside the cluster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterBy {
            get { return BackingStore?.Get<string?>("clusterBy"); }
            set { BackingStore?.Set("clusterBy", value); }
        }
#nullable restore
#else
        public string ClusterBy {
            get { return BackingStore?.Get<string>("clusterBy"); }
            set { BackingStore?.Set("clusterBy", value); }
        }
#endif
        /// <summary>The value utilized to cluster the similar emails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterByValue {
            get { return BackingStore?.Get<string?>("clusterByValue"); }
            set { BackingStore?.Set("clusterByValue", value); }
        }
#nullable restore
#else
        public string ClusterByValue {
            get { return BackingStore?.Get<string>("clusterByValue"); }
            set { BackingStore?.Set("clusterByValue", value); }
        }
#endif
        /// <summary>Count of emails in the email cluster.</summary>
        public long? EmailCount {
            get { return BackingStore?.Get<long?>("emailCount"); }
            set { BackingStore?.Set("emailCount", value); }
        }
        /// <summary>Unique identifiers for the emails in the cluster, generated by Microsoft 365.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NetworkMessageIds {
            get { return BackingStore?.Get<List<string>?>("networkMessageIds"); }
            set { BackingStore?.Set("networkMessageIds", value); }
        }
#nullable restore
#else
        public List<string> NetworkMessageIds {
            get { return BackingStore?.Get<List<string>>("networkMessageIds"); }
            set { BackingStore?.Set("networkMessageIds", value); }
        }
#endif
        /// <summary>The query used to identify the email cluster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Query {
            get { return BackingStore?.Get<string?>("query"); }
            set { BackingStore?.Set("query", value); }
        }
#nullable restore
#else
        public string Query {
            get { return BackingStore?.Get<string>("query"); }
            set { BackingStore?.Set("query", value); }
        }
#endif
        /// <summary>Uniform resource name (URN) of the automated investigation where the cluster was identified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn {
            get { return BackingStore?.Get<string?>("urn"); }
            set { BackingStore?.Set("urn", value); }
        }
#nullable restore
#else
        public string Urn {
            get { return BackingStore?.Get<string>("urn"); }
            set { BackingStore?.Set("urn", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MailClusterEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailClusterEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clusterBy", n => { ClusterBy = n.GetStringValue(); } },
                {"clusterByValue", n => { ClusterByValue = n.GetStringValue(); } },
                {"emailCount", n => { EmailCount = n.GetLongValue(); } },
                {"networkMessageIds", n => { NetworkMessageIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"query", n => { Query = n.GetStringValue(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clusterBy", ClusterBy);
            writer.WriteStringValue("clusterByValue", ClusterByValue);
            writer.WriteLongValue("emailCount", EmailCount);
            writer.WriteCollectionOfPrimitiveValues<string>("networkMessageIds", NetworkMessageIds);
            writer.WriteStringValue("query", Query);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
