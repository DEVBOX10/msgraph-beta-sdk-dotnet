using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Company : Entity, IParsable {
        /// <summary>The accounts property</summary>
        public List<Account> Accounts { get; set; }
        /// <summary>The agedAccountsPayable property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsPayable> AgedAccountsPayable { get; set; }
        /// <summary>The agedAccountsReceivable property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsReceivable> AgedAccountsReceivable { get; set; }
        /// <summary>The businessProfileId property</summary>
        public string BusinessProfileId { get; set; }
        /// <summary>The companyInformation property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.CompanyInformation> CompanyInformation { get; set; }
        /// <summary>The countriesRegions property</summary>
        public List<CountryRegion> CountriesRegions { get; set; }
        /// <summary>The currencies property</summary>
        public List<Currency> Currencies { get; set; }
        /// <summary>The customerPaymentJournals property</summary>
        public List<CustomerPaymentJournal> CustomerPaymentJournals { get; set; }
        /// <summary>The customerPayments property</summary>
        public List<CustomerPayment> CustomerPayments { get; set; }
        /// <summary>The customers property</summary>
        public List<Customer> Customers { get; set; }
        /// <summary>The dimensions property</summary>
        public List<Dimension> Dimensions { get; set; }
        /// <summary>The dimensionValues property</summary>
        public List<DimensionValue> DimensionValues { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The employees property</summary>
        public List<Employee> Employees { get; set; }
        /// <summary>The generalLedgerEntries property</summary>
        public List<GeneralLedgerEntry> GeneralLedgerEntries { get; set; }
        /// <summary>The itemCategories property</summary>
        public List<ItemCategory> ItemCategories { get; set; }
        /// <summary>The items property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item> Items { get; set; }
        /// <summary>The journalLines property</summary>
        public List<JournalLine> JournalLines { get; set; }
        /// <summary>The journals property</summary>
        public List<Journal> Journals { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The paymentMethods property</summary>
        public List<PaymentMethod> PaymentMethods { get; set; }
        /// <summary>The paymentTerms property</summary>
        public List<PaymentTerm> PaymentTerms { get; set; }
        /// <summary>The picture property</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture> Picture { get; set; }
        /// <summary>The purchaseInvoiceLines property</summary>
        public List<PurchaseInvoiceLine> PurchaseInvoiceLines { get; set; }
        /// <summary>The purchaseInvoices property</summary>
        public List<PurchaseInvoice> PurchaseInvoices { get; set; }
        /// <summary>The salesCreditMemoLines property</summary>
        public List<SalesCreditMemoLine> SalesCreditMemoLines { get; set; }
        /// <summary>The salesCreditMemos property</summary>
        public List<SalesCreditMemo> SalesCreditMemos { get; set; }
        /// <summary>The salesInvoiceLines property</summary>
        public List<SalesInvoiceLine> SalesInvoiceLines { get; set; }
        /// <summary>The salesInvoices property</summary>
        public List<SalesInvoice> SalesInvoices { get; set; }
        /// <summary>The salesOrderLines property</summary>
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        /// <summary>The salesOrders property</summary>
        public List<SalesOrder> SalesOrders { get; set; }
        /// <summary>The salesQuoteLines property</summary>
        public List<SalesQuoteLine> SalesQuoteLines { get; set; }
        /// <summary>The salesQuotes property</summary>
        public List<SalesQuote> SalesQuotes { get; set; }
        /// <summary>The shipmentMethods property</summary>
        public List<ShipmentMethod> ShipmentMethods { get; set; }
        /// <summary>The systemVersion property</summary>
        public string SystemVersion { get; set; }
        /// <summary>The taxAreas property</summary>
        public List<TaxArea> TaxAreas { get; set; }
        /// <summary>The taxGroups property</summary>
        public List<TaxGroup> TaxGroups { get; set; }
        /// <summary>The unitsOfMeasure property</summary>
        public List<UnitOfMeasure> UnitsOfMeasure { get; set; }
        /// <summary>The vendors property</summary>
        public List<Vendor> Vendors { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Company CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Company();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accounts", (o,n) => { (o as Company).Accounts = n.GetCollectionOfObjectValues<Account>(Account.CreateFromDiscriminatorValue).ToList(); } },
                {"agedAccountsPayable", (o,n) => { (o as Company).AgedAccountsPayable = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsPayable>(MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsPayable.CreateFromDiscriminatorValue).ToList(); } },
                {"agedAccountsReceivable", (o,n) => { (o as Company).AgedAccountsReceivable = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsReceivable>(MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsReceivable.CreateFromDiscriminatorValue).ToList(); } },
                {"businessProfileId", (o,n) => { (o as Company).BusinessProfileId = n.GetStringValue(); } },
                {"companyInformation", (o,n) => { (o as Company).CompanyInformation = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.CompanyInformation>(MicrosoftGraphSdk.Models.Microsoft.Graph.CompanyInformation.CreateFromDiscriminatorValue).ToList(); } },
                {"countriesRegions", (o,n) => { (o as Company).CountriesRegions = n.GetCollectionOfObjectValues<CountryRegion>(CountryRegion.CreateFromDiscriminatorValue).ToList(); } },
                {"currencies", (o,n) => { (o as Company).Currencies = n.GetCollectionOfObjectValues<Currency>(Currency.CreateFromDiscriminatorValue).ToList(); } },
                {"customerPaymentJournals", (o,n) => { (o as Company).CustomerPaymentJournals = n.GetCollectionOfObjectValues<CustomerPaymentJournal>(CustomerPaymentJournal.CreateFromDiscriminatorValue).ToList(); } },
                {"customerPayments", (o,n) => { (o as Company).CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>(CustomerPayment.CreateFromDiscriminatorValue).ToList(); } },
                {"customers", (o,n) => { (o as Company).Customers = n.GetCollectionOfObjectValues<Customer>(Customer.CreateFromDiscriminatorValue).ToList(); } },
                {"dimensions", (o,n) => { (o as Company).Dimensions = n.GetCollectionOfObjectValues<Dimension>(Dimension.CreateFromDiscriminatorValue).ToList(); } },
                {"dimensionValues", (o,n) => { (o as Company).DimensionValues = n.GetCollectionOfObjectValues<DimensionValue>(DimensionValue.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as Company).DisplayName = n.GetStringValue(); } },
                {"employees", (o,n) => { (o as Company).Employees = n.GetCollectionOfObjectValues<Employee>(Employee.CreateFromDiscriminatorValue).ToList(); } },
                {"generalLedgerEntries", (o,n) => { (o as Company).GeneralLedgerEntries = n.GetCollectionOfObjectValues<GeneralLedgerEntry>(GeneralLedgerEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"itemCategories", (o,n) => { (o as Company).ItemCategories = n.GetCollectionOfObjectValues<ItemCategory>(ItemCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"items", (o,n) => { (o as Company).Items = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>(MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item.CreateFromDiscriminatorValue).ToList(); } },
                {"journalLines", (o,n) => { (o as Company).JournalLines = n.GetCollectionOfObjectValues<JournalLine>(JournalLine.CreateFromDiscriminatorValue).ToList(); } },
                {"journals", (o,n) => { (o as Company).Journals = n.GetCollectionOfObjectValues<Journal>(Journal.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as Company).Name = n.GetStringValue(); } },
                {"paymentMethods", (o,n) => { (o as Company).PaymentMethods = n.GetCollectionOfObjectValues<PaymentMethod>(PaymentMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"paymentTerms", (o,n) => { (o as Company).PaymentTerms = n.GetCollectionOfObjectValues<PaymentTerm>(PaymentTerm.CreateFromDiscriminatorValue).ToList(); } },
                {"picture", (o,n) => { (o as Company).Picture = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture>(MicrosoftGraphSdk.Models.Microsoft.Graph.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"purchaseInvoiceLines", (o,n) => { (o as Company).PurchaseInvoiceLines = n.GetCollectionOfObjectValues<PurchaseInvoiceLine>(PurchaseInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"purchaseInvoices", (o,n) => { (o as Company).PurchaseInvoices = n.GetCollectionOfObjectValues<PurchaseInvoice>(PurchaseInvoice.CreateFromDiscriminatorValue).ToList(); } },
                {"salesCreditMemoLines", (o,n) => { (o as Company).SalesCreditMemoLines = n.GetCollectionOfObjectValues<SalesCreditMemoLine>(SalesCreditMemoLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesCreditMemos", (o,n) => { (o as Company).SalesCreditMemos = n.GetCollectionOfObjectValues<SalesCreditMemo>(SalesCreditMemo.CreateFromDiscriminatorValue).ToList(); } },
                {"salesInvoiceLines", (o,n) => { (o as Company).SalesInvoiceLines = n.GetCollectionOfObjectValues<SalesInvoiceLine>(SalesInvoiceLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesInvoices", (o,n) => { (o as Company).SalesInvoices = n.GetCollectionOfObjectValues<SalesInvoice>(SalesInvoice.CreateFromDiscriminatorValue).ToList(); } },
                {"salesOrderLines", (o,n) => { (o as Company).SalesOrderLines = n.GetCollectionOfObjectValues<SalesOrderLine>(SalesOrderLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesOrders", (o,n) => { (o as Company).SalesOrders = n.GetCollectionOfObjectValues<SalesOrder>(SalesOrder.CreateFromDiscriminatorValue).ToList(); } },
                {"salesQuoteLines", (o,n) => { (o as Company).SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>(SalesQuoteLine.CreateFromDiscriminatorValue).ToList(); } },
                {"salesQuotes", (o,n) => { (o as Company).SalesQuotes = n.GetCollectionOfObjectValues<SalesQuote>(SalesQuote.CreateFromDiscriminatorValue).ToList(); } },
                {"shipmentMethods", (o,n) => { (o as Company).ShipmentMethods = n.GetCollectionOfObjectValues<ShipmentMethod>(ShipmentMethod.CreateFromDiscriminatorValue).ToList(); } },
                {"systemVersion", (o,n) => { (o as Company).SystemVersion = n.GetStringValue(); } },
                {"taxAreas", (o,n) => { (o as Company).TaxAreas = n.GetCollectionOfObjectValues<TaxArea>(TaxArea.CreateFromDiscriminatorValue).ToList(); } },
                {"taxGroups", (o,n) => { (o as Company).TaxGroups = n.GetCollectionOfObjectValues<TaxGroup>(TaxGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"unitsOfMeasure", (o,n) => { (o as Company).UnitsOfMeasure = n.GetCollectionOfObjectValues<UnitOfMeasure>(UnitOfMeasure.CreateFromDiscriminatorValue).ToList(); } },
                {"vendors", (o,n) => { (o as Company).Vendors = n.GetCollectionOfObjectValues<Vendor>(Vendor.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Account>("accounts", Accounts);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsPayable>("agedAccountsPayable", AgedAccountsPayable);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.AgedAccountsReceivable>("agedAccountsReceivable", AgedAccountsReceivable);
            writer.WriteStringValue("businessProfileId", BusinessProfileId);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.CompanyInformation>("companyInformation", CompanyInformation);
            writer.WriteCollectionOfObjectValues<CountryRegion>("countriesRegions", CountriesRegions);
            writer.WriteCollectionOfObjectValues<Currency>("currencies", Currencies);
            writer.WriteCollectionOfObjectValues<CustomerPaymentJournal>("customerPaymentJournals", CustomerPaymentJournals);
            writer.WriteCollectionOfObjectValues<CustomerPayment>("customerPayments", CustomerPayments);
            writer.WriteCollectionOfObjectValues<Customer>("customers", Customers);
            writer.WriteCollectionOfObjectValues<Dimension>("dimensions", Dimensions);
            writer.WriteCollectionOfObjectValues<DimensionValue>("dimensionValues", DimensionValues);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Employee>("employees", Employees);
            writer.WriteCollectionOfObjectValues<GeneralLedgerEntry>("generalLedgerEntries", GeneralLedgerEntries);
            writer.WriteCollectionOfObjectValues<ItemCategory>("itemCategories", ItemCategories);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Item.Item>("items", Items);
            writer.WriteCollectionOfObjectValues<JournalLine>("journalLines", JournalLines);
            writer.WriteCollectionOfObjectValues<Journal>("journals", Journals);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<PaymentMethod>("paymentMethods", PaymentMethods);
            writer.WriteCollectionOfObjectValues<PaymentTerm>("paymentTerms", PaymentTerms);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture>("picture", Picture);
            writer.WriteCollectionOfObjectValues<PurchaseInvoiceLine>("purchaseInvoiceLines", PurchaseInvoiceLines);
            writer.WriteCollectionOfObjectValues<PurchaseInvoice>("purchaseInvoices", PurchaseInvoices);
            writer.WriteCollectionOfObjectValues<SalesCreditMemoLine>("salesCreditMemoLines", SalesCreditMemoLines);
            writer.WriteCollectionOfObjectValues<SalesCreditMemo>("salesCreditMemos", SalesCreditMemos);
            writer.WriteCollectionOfObjectValues<SalesInvoiceLine>("salesInvoiceLines", SalesInvoiceLines);
            writer.WriteCollectionOfObjectValues<SalesInvoice>("salesInvoices", SalesInvoices);
            writer.WriteCollectionOfObjectValues<SalesOrderLine>("salesOrderLines", SalesOrderLines);
            writer.WriteCollectionOfObjectValues<SalesOrder>("salesOrders", SalesOrders);
            writer.WriteCollectionOfObjectValues<SalesQuoteLine>("salesQuoteLines", SalesQuoteLines);
            writer.WriteCollectionOfObjectValues<SalesQuote>("salesQuotes", SalesQuotes);
            writer.WriteCollectionOfObjectValues<ShipmentMethod>("shipmentMethods", ShipmentMethods);
            writer.WriteStringValue("systemVersion", SystemVersion);
            writer.WriteCollectionOfObjectValues<TaxArea>("taxAreas", TaxAreas);
            writer.WriteCollectionOfObjectValues<TaxGroup>("taxGroups", TaxGroups);
            writer.WriteCollectionOfObjectValues<UnitOfMeasure>("unitsOfMeasure", UnitsOfMeasure);
            writer.WriteCollectionOfObjectValues<Vendor>("vendors", Vendors);
        }
    }
}
