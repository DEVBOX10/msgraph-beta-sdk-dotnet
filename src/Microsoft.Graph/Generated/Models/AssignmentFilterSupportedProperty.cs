using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents the information about the property which is supported in crafting the rule of AssignmentFilter.
    /// </summary>
    public class AssignmentFilterSupportedProperty : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The data type of the property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataType {
            get { return BackingStore?.Get<string?>("dataType"); }
            set { BackingStore?.Set("dataType", value); }
        }
#nullable restore
#else
        public string DataType {
            get { return BackingStore?.Get<string>("dataType"); }
            set { BackingStore?.Set("dataType", value); }
        }
#endif
        /// <summary>Indicates whether the property is a collection type or not.</summary>
        public bool? IsCollection {
            get { return BackingStore?.Get<bool?>("isCollection"); }
            set { BackingStore?.Set("isCollection", value); }
        }
        /// <summary>Name of the property.</summary>
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
        /// <summary>Regex string to do validation on the property value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PropertyRegexConstraint {
            get { return BackingStore?.Get<string?>("propertyRegexConstraint"); }
            set { BackingStore?.Set("propertyRegexConstraint", value); }
        }
#nullable restore
#else
        public string PropertyRegexConstraint {
            get { return BackingStore?.Get<string>("propertyRegexConstraint"); }
            set { BackingStore?.Set("propertyRegexConstraint", value); }
        }
#endif
        /// <summary>List of all supported operators on this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignmentFilterOperator?>? SupportedOperators {
            get { return BackingStore?.Get<List<AssignmentFilterOperator?>?>("supportedOperators"); }
            set { BackingStore?.Set("supportedOperators", value); }
        }
#nullable restore
#else
        public List<AssignmentFilterOperator?> SupportedOperators {
            get { return BackingStore?.Get<List<AssignmentFilterOperator?>>("supportedOperators"); }
            set { BackingStore?.Set("supportedOperators", value); }
        }
#endif
        /// <summary>List of all supported values for this property, empty if everything is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedValues {
            get { return BackingStore?.Get<List<string>?>("supportedValues"); }
            set { BackingStore?.Set("supportedValues", value); }
        }
#nullable restore
#else
        public List<string> SupportedValues {
            get { return BackingStore?.Get<List<string>>("supportedValues"); }
            set { BackingStore?.Set("supportedValues", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new assignmentFilterSupportedProperty and sets the default values.
        /// </summary>
        public AssignmentFilterSupportedProperty() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignmentFilterSupportedProperty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterSupportedProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataType", n => { DataType = n.GetStringValue(); } },
                {"isCollection", n => { IsCollection = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propertyRegexConstraint", n => { PropertyRegexConstraint = n.GetStringValue(); } },
                {"supportedOperators", n => { SupportedOperators = n.GetCollectionOfEnumValues<AssignmentFilterOperator>()?.ToList(); } },
                {"supportedValues", n => { SupportedValues = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dataType", DataType);
            writer.WriteBoolValue("isCollection", IsCollection);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("propertyRegexConstraint", PropertyRegexConstraint);
            writer.WriteCollectionOfEnumValues<AssignmentFilterOperator>("supportedOperators", SupportedOperators);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedValues", SupportedValues);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
