using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class FeatureUsageDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The featureName property</summary>
        public string FeatureName { get; set; }
        /// <summary>The lastConfiguredDateTime property</summary>
        public DateTimeOffset? LastConfiguredDateTime { get; set; }
        /// <summary>The lastUsedDateTime property</summary>
        public DateTimeOffset? LastUsedDateTime { get; set; }
        /// <summary>The licenseAssigned property</summary>
        public AzureADLicenseType? LicenseAssigned { get; set; }
        /// <summary>The licenseRequired property</summary>
        public AzureADLicenseType? LicenseRequired { get; set; }
        /// <summary>
        /// Instantiates a new featureUsageDetail and sets the default values.
        /// </summary>
        public FeatureUsageDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FeatureUsageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FeatureUsageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"featureName", (o,n) => { (o as FeatureUsageDetail).FeatureName = n.GetStringValue(); } },
                {"lastConfiguredDateTime", (o,n) => { (o as FeatureUsageDetail).LastConfiguredDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUsedDateTime", (o,n) => { (o as FeatureUsageDetail).LastUsedDateTime = n.GetDateTimeOffsetValue(); } },
                {"licenseAssigned", (o,n) => { (o as FeatureUsageDetail).LicenseAssigned = n.GetEnumValue<AzureADLicenseType>(); } },
                {"licenseRequired", (o,n) => { (o as FeatureUsageDetail).LicenseRequired = n.GetEnumValue<AzureADLicenseType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("featureName", FeatureName);
            writer.WriteDateTimeOffsetValue("lastConfiguredDateTime", LastConfiguredDateTime);
            writer.WriteDateTimeOffsetValue("lastUsedDateTime", LastUsedDateTime);
            writer.WriteEnumValue<AzureADLicenseType>("licenseAssigned", LicenseAssigned);
            writer.WriteEnumValue<AzureADLicenseType>("licenseRequired", LicenseRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
