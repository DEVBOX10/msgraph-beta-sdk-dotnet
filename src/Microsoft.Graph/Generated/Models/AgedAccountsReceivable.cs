using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AgedAccountsReceivable : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The agedAsOfDate property</summary>
        public Date? AgedAsOfDate {
            get { return BackingStore?.Get<Date?>("agedAsOfDate"); }
            set { BackingStore?.Set("agedAsOfDate", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The balanceDue property</summary>
        public decimal? BalanceDue {
            get { return BackingStore?.Get<decimal?>("balanceDue"); }
            set { BackingStore?.Set("balanceDue", value); }
        }
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>The currentAmount property</summary>
        public decimal? CurrentAmount {
            get { return BackingStore?.Get<decimal?>("currentAmount"); }
            set { BackingStore?.Set("currentAmount", value); }
        }
        /// <summary>The customerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId {
            get { return BackingStore?.Get<string?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
#nullable restore
#else
        public string CustomerId {
            get { return BackingStore?.Get<string>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
#endif
        /// <summary>The customerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber {
            get { return BackingStore?.Get<string?>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#nullable restore
#else
        public string CustomerNumber {
            get { return BackingStore?.Get<string>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
#endif
        /// <summary>The id property</summary>
        public Guid? Id {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
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
        /// <summary>The period1Amount property</summary>
        public decimal? Period1Amount {
            get { return BackingStore?.Get<decimal?>("period1Amount"); }
            set { BackingStore?.Set("period1Amount", value); }
        }
        /// <summary>The period2Amount property</summary>
        public decimal? Period2Amount {
            get { return BackingStore?.Get<decimal?>("period2Amount"); }
            set { BackingStore?.Set("period2Amount", value); }
        }
        /// <summary>The period3Amount property</summary>
        public decimal? Period3Amount {
            get { return BackingStore?.Get<decimal?>("period3Amount"); }
            set { BackingStore?.Set("period3Amount", value); }
        }
        /// <summary>The periodLengthFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PeriodLengthFilter {
            get { return BackingStore?.Get<string?>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
#nullable restore
#else
        public string PeriodLengthFilter {
            get { return BackingStore?.Get<string>("periodLengthFilter"); }
            set { BackingStore?.Set("periodLengthFilter", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new agedAccountsReceivable and sets the default values.
        /// </summary>
        public AgedAccountsReceivable() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AgedAccountsReceivable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgedAccountsReceivable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"agedAsOfDate", n => { AgedAsOfDate = n.GetDateValue(); } },
                {"balanceDue", n => { BalanceDue = n.GetDecimalValue(); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currentAmount", n => { CurrentAmount = n.GetDecimalValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"period1Amount", n => { Period1Amount = n.GetDecimalValue(); } },
                {"period2Amount", n => { Period2Amount = n.GetDecimalValue(); } },
                {"period3Amount", n => { Period3Amount = n.GetDecimalValue(); } },
                {"periodLengthFilter", n => { PeriodLengthFilter = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("agedAsOfDate", AgedAsOfDate);
            writer.WriteDecimalValue("balanceDue", BalanceDue);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDecimalValue("currentAmount", CurrentAmount);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDecimalValue("period1Amount", Period1Amount);
            writer.WriteDecimalValue("period2Amount", Period2Amount);
            writer.WriteDecimalValue("period3Amount", Period3Amount);
            writer.WriteStringValue("periodLengthFilter", PeriodLengthFilter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
