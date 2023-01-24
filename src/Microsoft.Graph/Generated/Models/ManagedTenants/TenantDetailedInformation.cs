using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class TenantDetailedInformation : Entity, IParsable {
        /// <summary>The city where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City {
            get { return BackingStore?.Get<string?>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#nullable restore
#else
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#endif
        /// <summary>The code for the country where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode {
            get { return BackingStore?.Get<string?>("countryCode"); }
            set { BackingStore?.Set("countryCode", value); }
        }
#nullable restore
#else
        public string CountryCode {
            get { return BackingStore?.Get<string>("countryCode"); }
            set { BackingStore?.Set("countryCode", value); }
        }
#endif
        /// <summary>The name for the country where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryName {
            get { return BackingStore?.Get<string?>("countryName"); }
            set { BackingStore?.Set("countryName", value); }
        }
#nullable restore
#else
        public string CountryName {
            get { return BackingStore?.Get<string>("countryName"); }
            set { BackingStore?.Set("countryName", value); }
        }
#endif
        /// <summary>The default domain name for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDomainName {
            get { return BackingStore?.Get<string?>("defaultDomainName"); }
            set { BackingStore?.Set("defaultDomainName", value); }
        }
#nullable restore
#else
        public string DefaultDomainName {
            get { return BackingStore?.Get<string>("defaultDomainName"); }
            set { BackingStore?.Set("defaultDomainName", value); }
        }
#endif
        /// <summary>The display name for the managed tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The business industry associated with the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndustryName {
            get { return BackingStore?.Get<string?>("industryName"); }
            set { BackingStore?.Set("industryName", value); }
        }
#nullable restore
#else
        public string IndustryName {
            get { return BackingStore?.Get<string>("industryName"); }
            set { BackingStore?.Set("industryName", value); }
        }
#endif
        /// <summary>The region where the managed tenant is located. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>The business segment associated with the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SegmentName {
            get { return BackingStore?.Get<string?>("segmentName"); }
            set { BackingStore?.Set("segmentName", value); }
        }
#nullable restore
#else
        public string SegmentName {
            get { return BackingStore?.Get<string>("segmentName"); }
            set { BackingStore?.Set("segmentName", value); }
        }
#endif
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The vertical associated with the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerticalName {
            get { return BackingStore?.Get<string?>("verticalName"); }
            set { BackingStore?.Set("verticalName", value); }
        }
#nullable restore
#else
        public string VerticalName {
            get { return BackingStore?.Get<string>("verticalName"); }
            set { BackingStore?.Set("verticalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantDetailedInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantDetailedInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"city", n => { City = n.GetStringValue(); } },
                {"countryCode", n => { CountryCode = n.GetStringValue(); } },
                {"countryName", n => { CountryName = n.GetStringValue(); } },
                {"defaultDomainName", n => { DefaultDomainName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"industryName", n => { IndustryName = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
                {"segmentName", n => { SegmentName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"verticalName", n => { VerticalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteStringValue("countryName", CountryName);
            writer.WriteStringValue("defaultDomainName", DefaultDomainName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("industryName", IndustryName);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("segmentName", SegmentName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("verticalName", VerticalName);
        }
    }
}
