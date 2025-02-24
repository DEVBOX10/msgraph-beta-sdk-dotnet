// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class SslCertificateEntity : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>A physical address of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PhysicalAddress? Address {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PhysicalAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PhysicalAddress Address {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PhysicalAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Alternate names for this entity that are part of the certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlternateNames {
            get { return BackingStore?.Get<List<string>?>("alternateNames"); }
            set { BackingStore?.Set("alternateNames", value); }
        }
#nullable restore
#else
        public List<string> AlternateNames {
            get { return BackingStore?.Get<List<string>>("alternateNames"); }
            set { BackingStore?.Set("alternateNames", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A common name for this entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommonName {
            get { return BackingStore?.Get<string?>("commonName"); }
            set { BackingStore?.Set("commonName", value); }
        }
#nullable restore
#else
        public string CommonName {
            get { return BackingStore?.Get<string>("commonName"); }
            set { BackingStore?.Set("commonName", value); }
        }
#endif
        /// <summary>An email for this entity.</summary>
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
        /// <summary>If the entity is a person, this is the person&apos;s given name (first name).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName {
            get { return BackingStore?.Get<string?>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#nullable restore
#else
        public string GivenName {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
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
        /// <summary>If the entity is an organization, this is the name of the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName {
            get { return BackingStore?.Get<string?>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#nullable restore
#else
        public string OrganizationName {
            get { return BackingStore?.Get<string>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#endif
        /// <summary>If the entity is an organization, this communicates if a unit in the organization is named on the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationUnitName {
            get { return BackingStore?.Get<string?>("organizationUnitName"); }
            set { BackingStore?.Set("organizationUnitName", value); }
        }
#nullable restore
#else
        public string OrganizationUnitName {
            get { return BackingStore?.Get<string>("organizationUnitName"); }
            set { BackingStore?.Set("organizationUnitName", value); }
        }
#endif
        /// <summary>A serial number assigned to the entity; usually only available if the entity is the issuer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>If the entity is a person, this is the person&apos;s surname (last name).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname {
            get { return BackingStore?.Get<string?>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#nullable restore
#else
        public string Surname {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new sslCertificateEntity and sets the default values.
        /// </summary>
        public SslCertificateEntity() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SslCertificateEntity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SslCertificateEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<Microsoft.Graph.Beta.Models.PhysicalAddress>(Microsoft.Graph.Beta.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"alternateNames", n => { AlternateNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"commonName", n => { CommonName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"organizationUnitName", n => { OrganizationUnitName = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PhysicalAddress>("address", Address);
            writer.WriteCollectionOfPrimitiveValues<string>("alternateNames", AlternateNames);
            writer.WriteStringValue("commonName", CommonName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteStringValue("organizationUnitName", OrganizationUnitName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("surname", Surname);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
