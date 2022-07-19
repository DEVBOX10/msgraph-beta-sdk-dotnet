using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PaymentTerm : Entity, IParsable {
        /// <summary>The calculateDiscountOnCreditMemos property</summary>
        public bool? CalculateDiscountOnCreditMemos {
            get { return BackingStore?.Get<bool?>("calculateDiscountOnCreditMemos"); }
            set { BackingStore?.Set("calculateDiscountOnCreditMemos", value); }
        }
        /// <summary>The code property</summary>
        public string Code {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
        /// <summary>The discountDateCalculation property</summary>
        public string DiscountDateCalculation {
            get { return BackingStore?.Get<string>("discountDateCalculation"); }
            set { BackingStore?.Set("discountDateCalculation", value); }
        }
        /// <summary>The discountPercent property</summary>
        public decimal? DiscountPercent {
            get { return BackingStore?.Get<decimal?>("discountPercent"); }
            set { BackingStore?.Set("discountPercent", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The dueDateCalculation property</summary>
        public string DueDateCalculation {
            get { return BackingStore?.Get<string>("dueDateCalculation"); }
            set { BackingStore?.Set("dueDateCalculation", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new paymentTerm and sets the default values.
        /// </summary>
        public PaymentTerm() : base() {
            OdataType = "#microsoft.graph.paymentTerm";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PaymentTerm CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PaymentTerm();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"calculateDiscountOnCreditMemos", n => { CalculateDiscountOnCreditMemos = n.GetBoolValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"discountDateCalculation", n => { DiscountDateCalculation = n.GetStringValue(); } },
                {"discountPercent", n => { DiscountPercent = n.GetDecimalValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dueDateCalculation", n => { DueDateCalculation = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("calculateDiscountOnCreditMemos", CalculateDiscountOnCreditMemos);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("discountDateCalculation", DiscountDateCalculation);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("dueDateCalculation", DueDateCalculation);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
