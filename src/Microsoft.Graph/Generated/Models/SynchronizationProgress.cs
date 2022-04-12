using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationProgress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The numerator of a progress ratio; the number of units of changes already processed.</summary>
        public long? CompletedUnits { get; set; }
        /// <summary>The time of a progress observation as an offset in minutes from UTC.</summary>
        public DateTimeOffset? ProgressObservationDateTime { get; set; }
        /// <summary>The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.</summary>
        public long? TotalUnits { get; set; }
        /// <summary>An optional description of the units.</summary>
        public string Units { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationProgress and sets the default values.
        /// </summary>
        public SynchronizationProgress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationProgress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationProgress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedUnits", n => { CompletedUnits = n.GetLongValue(); } },
                {"progressObservationDateTime", n => { ProgressObservationDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalUnits", n => { TotalUnits = n.GetLongValue(); } },
                {"units", n => { Units = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("completedUnits", CompletedUnits);
            writer.WriteDateTimeOffsetValue("progressObservationDateTime", ProgressObservationDateTime);
            writer.WriteLongValue("totalUnits", TotalUnits);
            writer.WriteStringValue("units", Units);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
