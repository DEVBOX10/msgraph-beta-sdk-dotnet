using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The number of devices remediated by a device health script on a given date with the last modified time.</summary>
    public class DeviceHealthScriptRemediationHistory : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of devices remediated by the device health script on the given date.</summary>
        public List<DeviceHealthScriptRemediationHistoryData> HistoryData { get; set; }
        /// <summary>The date on which the results history is calculated for the healthscript.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new deviceHealthScriptRemediationHistory and sets the default values.
        /// </summary>
        public DeviceHealthScriptRemediationHistory() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceHealthScriptRemediationHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptRemediationHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"historyData", n => { HistoryData = n.GetCollectionOfObjectValues<DeviceHealthScriptRemediationHistoryData>(DeviceHealthScriptRemediationHistoryData.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceHealthScriptRemediationHistoryData>("historyData", HistoryData);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
