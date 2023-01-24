using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TranslationPreferences : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Translation override behavior for languages, if any.Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TranslationLanguageOverride>? LanguageOverrides {
            get { return BackingStore?.Get<List<TranslationLanguageOverride>?>("languageOverrides"); }
            set { BackingStore?.Set("languageOverrides", value); }
        }
#nullable restore
#else
        public List<TranslationLanguageOverride> LanguageOverrides {
            get { return BackingStore?.Get<List<TranslationLanguageOverride>>("languageOverrides"); }
            set { BackingStore?.Set("languageOverrides", value); }
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
        /// <summary>The user&apos;s preferred translation behavior.Returned by default. Not nullable.</summary>
        public Microsoft.Graph.Beta.Models.TranslationBehavior? TranslationBehavior {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TranslationBehavior?>("translationBehavior"); }
            set { BackingStore?.Set("translationBehavior", value); }
        }
        /// <summary>The list of languages the user does not need translated. This is computed from the authoringLanguages collection in regionalAndLanguageSettings, and the languageOverrides collection in translationPreferences. The list specifies neutral culture values that include the language code without any country or region association. For example, it would specify &apos;fr&apos; for the neutral French culture, but not &apos;fr-FR&apos; for the French culture in France. Returned by default. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UntranslatedLanguages {
            get { return BackingStore?.Get<List<string>?>("untranslatedLanguages"); }
            set { BackingStore?.Set("untranslatedLanguages", value); }
        }
#nullable restore
#else
        public List<string> UntranslatedLanguages {
            get { return BackingStore?.Get<List<string>>("untranslatedLanguages"); }
            set { BackingStore?.Set("untranslatedLanguages", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new translationPreferences and sets the default values.
        /// </summary>
        public TranslationPreferences() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TranslationPreferences CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslationPreferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"languageOverrides", n => { LanguageOverrides = n.GetCollectionOfObjectValues<TranslationLanguageOverride>(TranslationLanguageOverride.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"translationBehavior", n => { TranslationBehavior = n.GetEnumValue<TranslationBehavior>(); } },
                {"untranslatedLanguages", n => { UntranslatedLanguages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TranslationLanguageOverride>("languageOverrides", LanguageOverrides);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TranslationBehavior>("translationBehavior", TranslationBehavior);
            writer.WriteCollectionOfPrimitiveValues<string>("untranslatedLanguages", UntranslatedLanguages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
