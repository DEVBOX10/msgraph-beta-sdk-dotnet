using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IpSecurityProfile : Entity, IParsable {
        /// <summary>The activityGroupNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ActivityGroupNames {
            get { return BackingStore?.Get<List<string>?>("activityGroupNames"); }
            set { BackingStore?.Set("activityGroupNames", value); }
        }
#nullable restore
#else
        public List<string> ActivityGroupNames {
            get { return BackingStore?.Get<List<string>>("activityGroupNames"); }
            set { BackingStore?.Set("activityGroupNames", value); }
        }
#endif
        /// <summary>The address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address {
            get { return BackingStore?.Get<string?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public string Address {
            get { return BackingStore?.Get<string>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>The azureSubscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureSubscriptionId {
            get { return BackingStore?.Get<string?>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#nullable restore
#else
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#endif
        /// <summary>The azureTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>The countHits property</summary>
        public int? CountHits {
            get { return BackingStore?.Get<int?>("countHits"); }
            set { BackingStore?.Set("countHits", value); }
        }
        /// <summary>The countHosts property</summary>
        public int? CountHosts {
            get { return BackingStore?.Get<int?>("countHosts"); }
            set { BackingStore?.Set("countHosts", value); }
        }
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The ipCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpCategory>? IpCategories {
            get { return BackingStore?.Get<List<IpCategory>?>("ipCategories"); }
            set { BackingStore?.Set("ipCategories", value); }
        }
#nullable restore
#else
        public List<IpCategory> IpCategories {
            get { return BackingStore?.Get<List<IpCategory>>("ipCategories"); }
            set { BackingStore?.Set("ipCategories", value); }
        }
#endif
        /// <summary>The ipReferenceData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IpReferenceData>? IpReferenceData {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IpReferenceData>?>("ipReferenceData"); }
            set { BackingStore?.Set("ipReferenceData", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IpReferenceData> IpReferenceData {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IpReferenceData>>("ipReferenceData"); }
            set { BackingStore?.Set("ipReferenceData", value); }
        }
#endif
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The riskScore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore {
            get { return BackingStore?.Get<string?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#nullable restore
#else
        public string RiskScore {
            get { return BackingStore?.Get<string>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The vendorInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityVendorInformation? VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public SecurityVendorInformation VendorInformation {
            get { return BackingStore?.Get<SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"address", n => { Address = n.GetStringValue(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"countHits", n => { CountHits = n.GetIntValue(); } },
                {"countHosts", n => { CountHosts = n.GetIntValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"ipCategories", n => { IpCategories = n.GetCollectionOfObjectValues<IpCategory>(IpCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ipReferenceData", n => { IpReferenceData = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IpReferenceData>(Microsoft.Graph.Beta.Models.IpReferenceData.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteIntValue("countHits", CountHits);
            writer.WriteIntValue("countHosts", CountHosts);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteCollectionOfObjectValues<IpCategory>("ipCategories", IpCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IpReferenceData>("ipReferenceData", IpReferenceData);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
