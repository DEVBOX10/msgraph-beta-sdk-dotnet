using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SiteSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The language tag for the language used on this site.</summary>
        public string LanguageTag { get; set; }
        /// <summary>Indicates the time offset for the time zone of the site from Coordinated Universal Time (UTC).</summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// Instantiates a new siteSettings and sets the default values.
        /// </summary>
        public SiteSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SiteSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SiteSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"languageTag", (o,n) => { (o as SiteSettings).LanguageTag = n.GetStringValue(); } },
                {"timeZone", (o,n) => { (o as SiteSettings).TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
