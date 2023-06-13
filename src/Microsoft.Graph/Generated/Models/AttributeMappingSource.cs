using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AttributeMappingSource : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Equivalent expression representation of this attributeMappingSource object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expression {
            get { return BackingStore?.Get<string?>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
#nullable restore
#else
        public string Expression {
            get { return BackingStore?.Get<string>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
#endif
        /// <summary>Name parameter of the mapping source. Depending on the type property value, this can be the name of the function, the name of the source attribute, or a constant value to be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
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
        /// <summary>If this object represents a function, lists function parameters. Parameters consist of attributeMappingSource objects themselves, allowing for complex expressions. If type is not Function, this property will be null/empty array.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StringKeyAttributeMappingSourceValuePair>? Parameters {
            get { return BackingStore?.Get<List<StringKeyAttributeMappingSourceValuePair>?>("parameters"); }
            set { BackingStore?.Set("parameters", value); }
        }
#nullable restore
#else
        public List<StringKeyAttributeMappingSourceValuePair> Parameters {
            get { return BackingStore?.Get<List<StringKeyAttributeMappingSourceValuePair>>("parameters"); }
            set { BackingStore?.Set("parameters", value); }
        }
#endif
        /// <summary>The type property</summary>
        public AttributeMappingSourceType? Type {
            get { return BackingStore?.Get<AttributeMappingSourceType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new attributeMappingSource and sets the default values.
        /// </summary>
        public AttributeMappingSource() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttributeMappingSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeMappingSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expression", n => { Expression = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parameters", n => { Parameters = n.GetCollectionOfObjectValues<StringKeyAttributeMappingSourceValuePair>(StringKeyAttributeMappingSourceValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"type", n => { Type = n.GetEnumValue<AttributeMappingSourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<StringKeyAttributeMappingSourceValuePair>("parameters", Parameters);
            writer.WriteEnumValue<AttributeMappingSourceType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
