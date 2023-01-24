using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationProgress : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The numerator of a progress ratio; the number of units of changes already processed.</summary>
        public long? CompletedUnits {
            get { return BackingStore?.Get<long?>("completedUnits"); }
            set { BackingStore?.Set("completedUnits", value); }
        }
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
        /// <summary>The time of a progress observation as an offset in minutes from UTC.</summary>
        public DateTimeOffset? ProgressObservationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("progressObservationDateTime"); }
            set { BackingStore?.Set("progressObservationDateTime", value); }
        }
        /// <summary>The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.</summary>
        public long? TotalUnits {
            get { return BackingStore?.Get<long?>("totalUnits"); }
            set { BackingStore?.Set("totalUnits", value); }
        }
        /// <summary>An optional description of the units.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Units {
            get { return BackingStore?.Get<string?>("units"); }
            set { BackingStore?.Set("units", value); }
        }
#nullable restore
#else
        public string Units {
            get { return BackingStore?.Get<string>("units"); }
            set { BackingStore?.Set("units", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new synchronizationProgress and sets the default values.
        /// </summary>
        public SynchronizationProgress() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"progressObservationDateTime", n => { ProgressObservationDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalUnits", n => { TotalUnits = n.GetLongValue(); } },
                {"units", n => { Units = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("completedUnits", CompletedUnits);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("progressObservationDateTime", ProgressObservationDateTime);
            writer.WriteLongValue("totalUnits", TotalUnits);
            writer.WriteStringValue("units", Units);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
