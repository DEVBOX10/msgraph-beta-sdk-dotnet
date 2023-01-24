using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewRecurrenceSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The duration in days for recurrence.</summary>
        public int? DurationInDays {
            get { return BackingStore?.Get<int?>("durationInDays"); }
            set { BackingStore?.Set("durationInDays", value); }
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
        /// <summary>The count of recurrences, if the value of recurrenceEndType is occurrences, or 0 otherwise.</summary>
        public int? RecurrenceCount {
            get { return BackingStore?.Get<int?>("recurrenceCount"); }
            set { BackingStore?.Set("recurrenceCount", value); }
        }
        /// <summary>How the recurrence ends. Possible values: never, endBy, occurrences, or recurrenceCount. If it is never, then there is no explicit end of the recurrence series. If it is endBy, then the recurrence ends at a certain date. If it is occurrences, then the series ends after recurrenceCount instances of the review have completed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecurrenceEndType {
            get { return BackingStore?.Get<string?>("recurrenceEndType"); }
            set { BackingStore?.Set("recurrenceEndType", value); }
        }
#nullable restore
#else
        public string RecurrenceEndType {
            get { return BackingStore?.Get<string>("recurrenceEndType"); }
            set { BackingStore?.Set("recurrenceEndType", value); }
        }
#endif
        /// <summary>The recurrence interval. Possible vaules: onetime, weekly, monthly, quarterly, halfyearly or annual.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecurrenceType {
            get { return BackingStore?.Get<string?>("recurrenceType"); }
            set { BackingStore?.Set("recurrenceType", value); }
        }
#nullable restore
#else
        public string RecurrenceType {
            get { return BackingStore?.Get<string>("recurrenceType"); }
            set { BackingStore?.Set("recurrenceType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new accessReviewRecurrenceSettings and sets the default values.
        /// </summary>
        public AccessReviewRecurrenceSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessReviewRecurrenceSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewRecurrenceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recurrenceCount", n => { RecurrenceCount = n.GetIntValue(); } },
                {"recurrenceEndType", n => { RecurrenceEndType = n.GetStringValue(); } },
                {"recurrenceType", n => { RecurrenceType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("recurrenceCount", RecurrenceCount);
            writer.WriteStringValue("recurrenceEndType", RecurrenceEndType);
            writer.WriteStringValue("recurrenceType", RecurrenceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
