using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewReviewerScope : AccessReviewScope, IParsable {
        /// <summary>The query specifying who will be the reviewer.</summary>
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
        /// <summary>In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueryRoot {
            get { return BackingStore?.Get<string?>("queryRoot"); }
            set { BackingStore?.Set("queryRoot", value); }
        }
#nullable restore
#else
        public string QueryRoot {
            get { return BackingStore?.Get<string>("queryRoot"); }
            set { BackingStore?.Set("queryRoot", value); }
        }
#endif
        /// <summary>The type of query. Examples include MicrosoftGraph and ARM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueryType {
            get { return BackingStore?.Get<string?>("queryType"); }
            set { BackingStore?.Set("queryType", value); }
        }
#nullable restore
#else
        public string QueryType {
            get { return BackingStore?.Get<string>("queryType"); }
            set { BackingStore?.Set("queryType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AccessReviewReviewerScope and sets the default values.
        /// </summary>
        public AccessReviewReviewerScope() : base() {
            OdataType = "#microsoft.graph.accessReviewReviewerScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewReviewerScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewReviewerScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"query", n => { Query = n.GetStringValue(); } },
                {"queryRoot", n => { QueryRoot = n.GetStringValue(); } },
                {"queryType", n => { QueryType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("query", Query);
            writer.WriteStringValue("queryRoot", QueryRoot);
            writer.WriteStringValue("queryType", QueryType);
        }
    }
}
