using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Contact : OutlookItem, IParsable {
        /// <summary>The name of the contact&apos;s assistant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssistantName {
            get { return BackingStore?.Get<string?>("assistantName"); }
            set { BackingStore?.Set("assistantName", value); }
        }
#nullable restore
#else
        public string AssistantName {
            get { return BackingStore?.Get<string>("assistantName"); }
            set { BackingStore?.Set("assistantName", value); }
        }
#endif
        /// <summary>The contact&apos;s birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Birthday {
            get { return BackingStore?.Get<DateTimeOffset?>("birthday"); }
            set { BackingStore?.Set("birthday", value); }
        }
        /// <summary>The names of the contact&apos;s children.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Children {
            get { return BackingStore?.Get<List<string>?>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#nullable restore
#else
        public List<string> Children {
            get { return BackingStore?.Get<List<string>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#endif
        /// <summary>The name of the contact&apos;s company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>The contact&apos;s department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public string Department {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The contact&apos;s display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.</summary>
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
        /// <summary>The contact&apos;s email addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TypedEmailAddress>? EmailAddresses {
            get { return BackingStore?.Get<List<TypedEmailAddress>?>("emailAddresses"); }
            set { BackingStore?.Set("emailAddresses", value); }
        }
#nullable restore
#else
        public List<TypedEmailAddress> EmailAddresses {
            get { return BackingStore?.Get<List<TypedEmailAddress>>("emailAddresses"); }
            set { BackingStore?.Set("emailAddresses", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the contact. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>The name the contact is filed under.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileAs {
            get { return BackingStore?.Get<string?>("fileAs"); }
            set { BackingStore?.Set("fileAs", value); }
        }
#nullable restore
#else
        public string FileAs {
            get { return BackingStore?.Get<string>("fileAs"); }
            set { BackingStore?.Set("fileAs", value); }
        }
#endif
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FollowupFlag? Flag {
            get { return BackingStore?.Get<FollowupFlag?>("flag"); }
            set { BackingStore?.Set("flag", value); }
        }
#nullable restore
#else
        public FollowupFlag Flag {
            get { return BackingStore?.Get<FollowupFlag>("flag"); }
            set { BackingStore?.Set("flag", value); }
        }
#endif
        /// <summary>The contact&apos;s gender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gender {
            get { return BackingStore?.Get<string?>("gender"); }
            set { BackingStore?.Set("gender", value); }
        }
#nullable restore
#else
        public string Gender {
            get { return BackingStore?.Get<string>("gender"); }
            set { BackingStore?.Set("gender", value); }
        }
#endif
        /// <summary>The contact&apos;s generation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Generation {
            get { return BackingStore?.Get<string?>("generation"); }
            set { BackingStore?.Set("generation", value); }
        }
#nullable restore
#else
        public string Generation {
            get { return BackingStore?.Get<string>("generation"); }
            set { BackingStore?.Set("generation", value); }
        }
#endif
        /// <summary>The contact&apos;s given name.</summary>
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
        /// <summary>The imAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ImAddresses {
            get { return BackingStore?.Get<List<string>?>("imAddresses"); }
            set { BackingStore?.Set("imAddresses", value); }
        }
#nullable restore
#else
        public List<string> ImAddresses {
            get { return BackingStore?.Get<List<string>>("imAddresses"); }
            set { BackingStore?.Set("imAddresses", value); }
        }
#endif
        /// <summary>The initials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Initials {
            get { return BackingStore?.Get<string?>("initials"); }
            set { BackingStore?.Set("initials", value); }
        }
#nullable restore
#else
        public string Initials {
            get { return BackingStore?.Get<string>("initials"); }
            set { BackingStore?.Set("initials", value); }
        }
#endif
        /// <summary>The isFavorite property</summary>
        public bool? IsFavorite {
            get { return BackingStore?.Get<bool?>("isFavorite"); }
            set { BackingStore?.Set("isFavorite", value); }
        }
        /// <summary>The jobTitle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The manager property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manager {
            get { return BackingStore?.Get<string?>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#nullable restore
#else
        public string Manager {
            get { return BackingStore?.Get<string>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#endif
        /// <summary>The middleName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName {
            get { return BackingStore?.Get<string?>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
#nullable restore
#else
        public string MiddleName {
            get { return BackingStore?.Get<string>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
#endif
        /// <summary>The collection of multi-value extended properties defined for the contact. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The nickName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NickName {
            get { return BackingStore?.Get<string?>("nickName"); }
            set { BackingStore?.Set("nickName", value); }
        }
#nullable restore
#else
        public string NickName {
            get { return BackingStore?.Get<string>("nickName"); }
            set { BackingStore?.Set("nickName", value); }
        }
#endif
        /// <summary>The officeLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficeLocation {
            get { return BackingStore?.Get<string?>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#nullable restore
#else
        public string OfficeLocation {
            get { return BackingStore?.Get<string>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#endif
        /// <summary>The parentFolderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId {
            get { return BackingStore?.Get<string?>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#nullable restore
#else
        public string ParentFolderId {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#endif
        /// <summary>The personalNotes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalNotes {
            get { return BackingStore?.Get<string?>("personalNotes"); }
            set { BackingStore?.Set("personalNotes", value); }
        }
#nullable restore
#else
        public string PersonalNotes {
            get { return BackingStore?.Get<string>("personalNotes"); }
            set { BackingStore?.Set("personalNotes", value); }
        }
#endif
        /// <summary>The phones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Phone>? Phones {
            get { return BackingStore?.Get<List<Phone>?>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#nullable restore
#else
        public List<Phone> Phones {
            get { return BackingStore?.Get<List<Phone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#endif
        /// <summary>Optional contact picture. You can get or set a photo for a contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProfilePhoto? Photo {
            get { return BackingStore?.Get<ProfilePhoto?>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#nullable restore
#else
        public ProfilePhoto Photo {
            get { return BackingStore?.Get<ProfilePhoto>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#endif
        /// <summary>The postalAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PhysicalAddress>? PostalAddresses {
            get { return BackingStore?.Get<List<PhysicalAddress>?>("postalAddresses"); }
            set { BackingStore?.Set("postalAddresses", value); }
        }
#nullable restore
#else
        public List<PhysicalAddress> PostalAddresses {
            get { return BackingStore?.Get<List<PhysicalAddress>>("postalAddresses"); }
            set { BackingStore?.Set("postalAddresses", value); }
        }
#endif
        /// <summary>The profession property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Profession {
            get { return BackingStore?.Get<string?>("profession"); }
            set { BackingStore?.Set("profession", value); }
        }
#nullable restore
#else
        public string Profession {
            get { return BackingStore?.Get<string>("profession"); }
            set { BackingStore?.Set("profession", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the contact. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>The spouseName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpouseName {
            get { return BackingStore?.Get<string?>("spouseName"); }
            set { BackingStore?.Set("spouseName", value); }
        }
#nullable restore
#else
        public string SpouseName {
            get { return BackingStore?.Get<string>("spouseName"); }
            set { BackingStore?.Set("spouseName", value); }
        }
#endif
        /// <summary>The surname property</summary>
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
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>The websites property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Website>? Websites {
            get { return BackingStore?.Get<List<Website>?>("websites"); }
            set { BackingStore?.Set("websites", value); }
        }
#nullable restore
#else
        public List<Website> Websites {
            get { return BackingStore?.Get<List<Website>>("websites"); }
            set { BackingStore?.Set("websites", value); }
        }
#endif
        /// <summary>The weddingAnniversary property</summary>
        public Date? WeddingAnniversary {
            get { return BackingStore?.Get<Date?>("weddingAnniversary"); }
            set { BackingStore?.Set("weddingAnniversary", value); }
        }
        /// <summary>The yomiCompanyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiCompanyName {
            get { return BackingStore?.Get<string?>("yomiCompanyName"); }
            set { BackingStore?.Set("yomiCompanyName", value); }
        }
#nullable restore
#else
        public string YomiCompanyName {
            get { return BackingStore?.Get<string>("yomiCompanyName"); }
            set { BackingStore?.Set("yomiCompanyName", value); }
        }
#endif
        /// <summary>The yomiGivenName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiGivenName {
            get { return BackingStore?.Get<string?>("yomiGivenName"); }
            set { BackingStore?.Set("yomiGivenName", value); }
        }
#nullable restore
#else
        public string YomiGivenName {
            get { return BackingStore?.Get<string>("yomiGivenName"); }
            set { BackingStore?.Set("yomiGivenName", value); }
        }
#endif
        /// <summary>The yomiSurname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiSurname {
            get { return BackingStore?.Get<string?>("yomiSurname"); }
            set { BackingStore?.Set("yomiSurname", value); }
        }
#nullable restore
#else
        public string YomiSurname {
            get { return BackingStore?.Get<string>("yomiSurname"); }
            set { BackingStore?.Set("yomiSurname", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Contact and sets the default values.
        /// </summary>
        public Contact() : base() {
            OdataType = "#microsoft.graph.contact";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Contact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Contact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assistantName", n => { AssistantName = n.GetStringValue(); } },
                {"birthday", n => { Birthday = n.GetDateTimeOffsetValue(); } },
                {"children", n => { Children = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"emailAddresses", n => { EmailAddresses = n.GetCollectionOfObjectValues<TypedEmailAddress>(TypedEmailAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fileAs", n => { FileAs = n.GetStringValue(); } },
                {"flag", n => { Flag = n.GetObjectValue<FollowupFlag>(FollowupFlag.CreateFromDiscriminatorValue); } },
                {"gender", n => { Gender = n.GetStringValue(); } },
                {"generation", n => { Generation = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"imAddresses", n => { ImAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"initials", n => { Initials = n.GetStringValue(); } },
                {"isFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"manager", n => { Manager = n.GetStringValue(); } },
                {"middleName", n => { MiddleName = n.GetStringValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"nickName", n => { NickName = n.GetStringValue(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"personalNotes", n => { PersonalNotes = n.GetStringValue(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"postalAddresses", n => { PostalAddresses = n.GetCollectionOfObjectValues<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"profession", n => { Profession = n.GetStringValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"spouseName", n => { SpouseName = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"websites", n => { Websites = n.GetCollectionOfObjectValues<Website>(Website.CreateFromDiscriminatorValue)?.ToList(); } },
                {"weddingAnniversary", n => { WeddingAnniversary = n.GetDateValue(); } },
                {"yomiCompanyName", n => { YomiCompanyName = n.GetStringValue(); } },
                {"yomiGivenName", n => { YomiGivenName = n.GetStringValue(); } },
                {"yomiSurname", n => { YomiSurname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assistantName", AssistantName);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteCollectionOfPrimitiveValues<string>("children", Children);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<TypedEmailAddress>("emailAddresses", EmailAddresses);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("fileAs", FileAs);
            writer.WriteObjectValue<FollowupFlag>("flag", Flag);
            writer.WriteStringValue("gender", Gender);
            writer.WriteStringValue("generation", Generation);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteStringValue("initials", Initials);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("manager", Manager);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("nickName", NickName);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteStringValue("personalNotes", PersonalNotes);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<PhysicalAddress>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("spouseName", SpouseName);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfObjectValues<Website>("websites", Websites);
            writer.WriteDateValue("weddingAnniversary", WeddingAnniversary);
            writer.WriteStringValue("yomiCompanyName", YomiCompanyName);
            writer.WriteStringValue("yomiGivenName", YomiGivenName);
            writer.WriteStringValue("yomiSurname", YomiSurname);
        }
    }
}
