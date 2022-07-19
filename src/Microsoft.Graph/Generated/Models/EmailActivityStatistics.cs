using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EmailActivityStatistics : ActivityStatistics, IParsable {
        /// <summary>Total hours spent on email outside of working hours, which is based on the user&apos;s Outlook calendar setting for work hours. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? AfterHours {
            get { return BackingStore?.Get<TimeSpan?>("afterHours"); }
            set { BackingStore?.Set("afterHours", value); }
        }
        /// <summary>Total hours spent reading email. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? ReadEmail {
            get { return BackingStore?.Get<TimeSpan?>("readEmail"); }
            set { BackingStore?.Set("readEmail", value); }
        }
        /// <summary>Total hours spent writing and sending email. The value is represented in ISO 8601 format for durations.</summary>
        public TimeSpan? SentEmail {
            get { return BackingStore?.Get<TimeSpan?>("sentEmail"); }
            set { BackingStore?.Set("sentEmail", value); }
        }
        /// <summary>
        /// Instantiates a new EmailActivityStatistics and sets the default values.
        /// </summary>
        public EmailActivityStatistics() : base() {
            OdataType = "#microsoft.graph.emailActivityStatistics";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EmailActivityStatistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailActivityStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"afterHours", n => { AfterHours = n.GetTimeSpanValue(); } },
                {"readEmail", n => { ReadEmail = n.GetTimeSpanValue(); } },
                {"sentEmail", n => { SentEmail = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("afterHours", AfterHours);
            writer.WriteTimeSpanValue("readEmail", ReadEmail);
            writer.WriteTimeSpanValue("sentEmail", SentEmail);
        }
    }
}
