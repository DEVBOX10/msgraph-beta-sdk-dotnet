using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPcLaunchInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cloudPcId property</summary>
        public string CloudPcId { get; set; }
        /// <summary>The cloudPcLaunchUrl property</summary>
        public string CloudPcLaunchUrl { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcLaunchInfo and sets the default values.
        /// </summary>
        public CloudPcLaunchInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcLaunchInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcLaunchInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cloudPcId", (o,n) => { (o as CloudPcLaunchInfo).CloudPcId = n.GetStringValue(); } },
                {"cloudPcLaunchUrl", (o,n) => { (o as CloudPcLaunchInfo).CloudPcLaunchUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteStringValue("cloudPcLaunchUrl", CloudPcLaunchUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
