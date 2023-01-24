using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Request for assignment filter evaluation for devices.
    /// </summary>
    public class AssignmentFilterEvaluateRequest : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Order the devices should be sorted in. Default is ascending on device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderBy {
            get { return BackingStore?.Get<List<string>?>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
#nullable restore
#else
        public List<string> OrderBy {
            get { return BackingStore?.Get<List<string>>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
#endif
        /// <summary>Supported platform types.</summary>
        public DevicePlatformType? Platform {
            get { return BackingStore?.Get<DevicePlatformType?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>Rule definition of the Assignment Filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rule {
            get { return BackingStore?.Get<string?>("rule"); }
            set { BackingStore?.Set("rule", value); }
        }
#nullable restore
#else
        public string Rule {
            get { return BackingStore?.Get<string>("rule"); }
            set { BackingStore?.Set("rule", value); }
        }
#endif
        /// <summary>Search keyword applied to scope found devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Search {
            get { return BackingStore?.Get<string?>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#nullable restore
#else
        public string Search {
            get { return BackingStore?.Get<string>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#endif
        /// <summary>Number of records to skip. Default value is 0</summary>
        public int? Skip {
            get { return BackingStore?.Get<int?>("skip"); }
            set { BackingStore?.Set("skip", value); }
        }
        /// <summary>Limit of records per request. Default value is 100, if provided less than 0 or greater than 100</summary>
        public int? Top {
            get { return BackingStore?.Get<int?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
        /// <summary>
        /// Instantiates a new assignmentFilterEvaluateRequest and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluateRequest() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignmentFilterEvaluateRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterEvaluateRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"platform", n => { Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"rule", n => { Rule = n.GetStringValue(); } },
                {"search", n => { Search = n.GetStringValue(); } },
                {"skip", n => { Skip = n.GetIntValue(); } },
                {"top", n => { Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteStringValue("rule", Rule);
            writer.WriteStringValue("search", Search);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
