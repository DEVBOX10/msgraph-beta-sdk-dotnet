using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SalesInvoice : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The billingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? BillingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType?>("billingPostalAddress"); }
            set { BackingStore?.Set("billingPostalAddress", value); }
        }
#nullable restore
#else
        public PostalAddressType BillingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>("billingPostalAddress"); }
            set { BackingStore?.Set("billingPostalAddress", value); }
        }
#endif
        /// <summary>The billToCustomerId property</summary>
        public Guid? BillToCustomerId {
            get { return BackingStore?.Get<Guid?>("billToCustomerId"); }
            set { BackingStore?.Set("billToCustomerId", value); }
        }
        /// <summary>The billToCustomerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillToCustomerNumber {
            get { return BackingStore?.Get<string?>("billToCustomerNumber"); }
            set { BackingStore?.Set("billToCustomerNumber", value); }
        }
#nullable restore
#else
        public string BillToCustomerNumber {
            get { return BackingStore?.Get<string>("billToCustomerNumber"); }
            set { BackingStore?.Set("billToCustomerNumber", value); }
        }
#endif
        /// <summary>The billToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillToName {
            get { return BackingStore?.Get<string?>("billToName"); }
            set { BackingStore?.Set("billToName", value); }
        }
#nullable restore
#else
        public string BillToName {
            get { return BackingStore?.Get<string>("billToName"); }
            set { BackingStore?.Set("billToName", value); }
        }
#endif
        /// <summary>The currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Currency? Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Currency Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
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
        /// <summary>The currencyId property</summary>
        public Guid? CurrencyId {
            get { return BackingStore?.Get<Guid?>("currencyId"); }
            set { BackingStore?.Set("currencyId", value); }
        }
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Customer? Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer?>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Customer Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#endif
        /// <summary>The customerId property</summary>
        public Guid? CustomerId {
            get { return BackingStore?.Get<Guid?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
        /// <summary>The customerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName {
            get { return BackingStore?.Get<string?>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#nullable restore
#else
        public string CustomerName {
            get { return BackingStore?.Get<string>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
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
        /// <summary>The customerPurchaseOrderReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerPurchaseOrderReference {
            get { return BackingStore?.Get<string?>("customerPurchaseOrderReference"); }
            set { BackingStore?.Set("customerPurchaseOrderReference", value); }
        }
#nullable restore
#else
        public string CustomerPurchaseOrderReference {
            get { return BackingStore?.Get<string>("customerPurchaseOrderReference"); }
            set { BackingStore?.Set("customerPurchaseOrderReference", value); }
        }
#endif
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>("discountAmount"); }
            set { BackingStore?.Set("discountAmount", value); }
        }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax {
            get { return BackingStore?.Get<bool?>("discountAppliedBeforeTax"); }
            set { BackingStore?.Set("discountAppliedBeforeTax", value); }
        }
        /// <summary>The dueDate property</summary>
        public Date? DueDate {
            get { return BackingStore?.Get<Date?>("dueDate"); }
            set { BackingStore?.Set("dueDate", value); }
        }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The externalDocumentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalDocumentNumber {
            get { return BackingStore?.Get<string?>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
#nullable restore
#else
        public string ExternalDocumentNumber {
            get { return BackingStore?.Get<string>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
#endif
        /// <summary>The id property</summary>
        public Guid? Id {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The invoiceDate property</summary>
        public Date? InvoiceDate {
            get { return BackingStore?.Get<Date?>("invoiceDate"); }
            set { BackingStore?.Set("invoiceDate", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number {
            get { return BackingStore?.Get<string?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
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
        /// <summary>The orderId property</summary>
        public Guid? OrderId {
            get { return BackingStore?.Get<Guid?>("orderId"); }
            set { BackingStore?.Set("orderId", value); }
        }
        /// <summary>The orderNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderNumber {
            get { return BackingStore?.Get<string?>("orderNumber"); }
            set { BackingStore?.Set("orderNumber", value); }
        }
#nullable restore
#else
        public string OrderNumber {
            get { return BackingStore?.Get<string>("orderNumber"); }
            set { BackingStore?.Set("orderNumber", value); }
        }
#endif
        /// <summary>The paymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PaymentTerm? PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm?>("paymentTerm"); }
            set { BackingStore?.Set("paymentTerm", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm"); }
            set { BackingStore?.Set("paymentTerm", value); }
        }
#endif
        /// <summary>The paymentTermsId property</summary>
        public Guid? PaymentTermsId {
            get { return BackingStore?.Get<Guid?>("paymentTermsId"); }
            set { BackingStore?.Set("paymentTermsId", value); }
        }
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>The pricesIncludeTax property</summary>
        public bool? PricesIncludeTax {
            get { return BackingStore?.Get<bool?>("pricesIncludeTax"); }
            set { BackingStore?.Set("pricesIncludeTax", value); }
        }
        /// <summary>The salesInvoiceLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SalesInvoiceLine>? SalesInvoiceLines {
            get { return BackingStore?.Get<List<SalesInvoiceLine>?>("salesInvoiceLines"); }
            set { BackingStore?.Set("salesInvoiceLines", value); }
        }
#nullable restore
#else
        public List<SalesInvoiceLine> SalesInvoiceLines {
            get { return BackingStore?.Get<List<SalesInvoiceLine>>("salesInvoiceLines"); }
            set { BackingStore?.Set("salesInvoiceLines", value); }
        }
#endif
        /// <summary>The salesperson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Salesperson {
            get { return BackingStore?.Get<string?>("salesperson"); }
            set { BackingStore?.Set("salesperson", value); }
        }
#nullable restore
#else
        public string Salesperson {
            get { return BackingStore?.Get<string>("salesperson"); }
            set { BackingStore?.Set("salesperson", value); }
        }
#endif
        /// <summary>The sellingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? SellingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType?>("sellingPostalAddress"); }
            set { BackingStore?.Set("sellingPostalAddress", value); }
        }
#nullable restore
#else
        public PostalAddressType SellingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>("sellingPostalAddress"); }
            set { BackingStore?.Set("sellingPostalAddress", value); }
        }
#endif
        /// <summary>The shipmentMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ShipmentMethod? ShipmentMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ShipmentMethod?>("shipmentMethod"); }
            set { BackingStore?.Set("shipmentMethod", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ShipmentMethod ShipmentMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ShipmentMethod>("shipmentMethod"); }
            set { BackingStore?.Set("shipmentMethod", value); }
        }
#endif
        /// <summary>The shipmentMethodId property</summary>
        public Guid? ShipmentMethodId {
            get { return BackingStore?.Get<Guid?>("shipmentMethodId"); }
            set { BackingStore?.Set("shipmentMethodId", value); }
        }
        /// <summary>The shippingPostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? ShippingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType?>("shippingPostalAddress"); }
            set { BackingStore?.Set("shippingPostalAddress", value); }
        }
#nullable restore
#else
        public PostalAddressType ShippingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>("shippingPostalAddress"); }
            set { BackingStore?.Set("shippingPostalAddress", value); }
        }
#endif
        /// <summary>The shipToContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipToContact {
            get { return BackingStore?.Get<string?>("shipToContact"); }
            set { BackingStore?.Set("shipToContact", value); }
        }
#nullable restore
#else
        public string ShipToContact {
            get { return BackingStore?.Get<string>("shipToContact"); }
            set { BackingStore?.Set("shipToContact", value); }
        }
#endif
        /// <summary>The shipToName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShipToName {
            get { return BackingStore?.Get<string?>("shipToName"); }
            set { BackingStore?.Set("shipToName", value); }
        }
#nullable restore
#else
        public string ShipToName {
            get { return BackingStore?.Get<string>("shipToName"); }
            set { BackingStore?.Set("shipToName", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The totalAmountExcludingTax property</summary>
        public decimal? TotalAmountExcludingTax {
            get { return BackingStore?.Get<decimal?>("totalAmountExcludingTax"); }
            set { BackingStore?.Set("totalAmountExcludingTax", value); }
        }
        /// <summary>The totalAmountIncludingTax property</summary>
        public decimal? TotalAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>("totalAmountIncludingTax"); }
            set { BackingStore?.Set("totalAmountIncludingTax", value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>("totalTaxAmount"); }
            set { BackingStore?.Set("totalTaxAmount", value); }
        }
        /// <summary>
        /// Instantiates a new salesInvoice and sets the default values.
        /// </summary>
        public SalesInvoice() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SalesInvoice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesInvoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"billingPostalAddress", n => { BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", n => { BillToCustomerId = n.GetGuidValue(); } },
                {"billToCustomerNumber", n => { BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", n => { BillToName = n.GetStringValue(); } },
                {"currency", n => { Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetGuidValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetGuidValue(); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"customerPurchaseOrderReference", n => { CustomerPurchaseOrderReference = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"dueDate", n => { DueDate = n.GetDateValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"invoiceDate", n => { InvoiceDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"orderId", n => { OrderId = n.GetGuidValue(); } },
                {"orderNumber", n => { OrderNumber = n.GetStringValue(); } },
                {"paymentTerm", n => { PaymentTerm = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>(Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", n => { PaymentTermsId = n.GetGuidValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"pricesIncludeTax", n => { PricesIncludeTax = n.GetBoolValue(); } },
                {"salesInvoiceLines", n => { SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>(SalesInvoiceLine.CreateFromDiscriminatorValue)?.ToList(); } },
                {"salesperson", n => { Salesperson = n.GetStringValue(); } },
                {"sellingPostalAddress", n => { SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipmentMethod", n => { ShipmentMethod = n.GetObjectValue<Microsoft.Graph.Beta.Models.ShipmentMethod>(Microsoft.Graph.Beta.Models.ShipmentMethod.CreateFromDiscriminatorValue); } },
                {"shipmentMethodId", n => { ShipmentMethodId = n.GetGuidValue(); } },
                {"shippingPostalAddress", n => { ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipToContact", n => { ShipToContact = n.GetStringValue(); } },
                {"shipToName", n => { ShipToName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", n => { TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", n => { TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PostalAddressType>("billingPostalAddress", BillingPostalAddress);
            writer.WriteGuidValue("billToCustomerId", BillToCustomerId);
            writer.WriteStringValue("billToCustomerNumber", BillToCustomerNumber);
            writer.WriteStringValue("billToName", BillToName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteGuidValue("currencyId", CurrencyId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Customer>("customer", Customer);
            writer.WriteGuidValue("customerId", CustomerId);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteStringValue("customerPurchaseOrderReference", CustomerPurchaseOrderReference);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateValue("invoiceDate", InvoiceDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteGuidValue("orderId", OrderId);
            writer.WriteStringValue("orderNumber", OrderNumber);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteGuidValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteBoolValue("pricesIncludeTax", PricesIncludeTax);
            writer.WriteCollectionOfObjectValues<SalesInvoiceLine>("salesInvoiceLines", SalesInvoiceLines);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ShipmentMethod>("shipmentMethod", ShipmentMethod);
            writer.WriteGuidValue("shipmentMethodId", ShipmentMethodId);
            writer.WriteObjectValue<PostalAddressType>("shippingPostalAddress", ShippingPostalAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
