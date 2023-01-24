using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerFieldRules : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default rules that apply if no override matches to the current data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefaultRules {
            get { return BackingStore?.Get<List<string>?>("defaultRules"); }
            set { BackingStore?.Set("defaultRules", value); }
        }
#nullable restore
#else
        public List<string> DefaultRules {
            get { return BackingStore?.Get<List<string>>("defaultRules"); }
            set { BackingStore?.Set("defaultRules", value); }
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
        /// <summary>Overrides that specify different rules for specific data associated with the field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PlannerRuleOverride>? Overrides {
            get { return BackingStore?.Get<List<PlannerRuleOverride>?>("overrides"); }
            set { BackingStore?.Set("overrides", value); }
        }
#nullable restore
#else
        public List<PlannerRuleOverride> Overrides {
            get { return BackingStore?.Get<List<PlannerRuleOverride>>("overrides"); }
            set { BackingStore?.Set("overrides", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new plannerFieldRules and sets the default values.
        /// </summary>
        public PlannerFieldRules() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerFieldRules CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerFieldRules();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultRules", n => { DefaultRules = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"overrides", n => { Overrides = n.GetCollectionOfObjectValues<PlannerRuleOverride>(PlannerRuleOverride.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("defaultRules", DefaultRules);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<PlannerRuleOverride>("overrides", Overrides);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
