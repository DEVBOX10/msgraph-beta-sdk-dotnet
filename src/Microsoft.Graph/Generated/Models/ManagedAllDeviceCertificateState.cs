using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagedAllDeviceCertificateState : Entity, IParsable {
        /// <summary>Certificate expiry date</summary>
        public DateTimeOffset? CertificateExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certificateExpirationDateTime"); }
            set { BackingStore?.Set("certificateExpirationDateTime", value); }
        }
        /// <summary>Enhanced Key Usage</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateExtendedKeyUsages {
            get { return BackingStore?.Get<string?>("certificateExtendedKeyUsages"); }
            set { BackingStore?.Set("certificateExtendedKeyUsages", value); }
        }
#nullable restore
#else
        public string CertificateExtendedKeyUsages {
            get { return BackingStore?.Get<string>("certificateExtendedKeyUsages"); }
            set { BackingStore?.Set("certificateExtendedKeyUsages", value); }
        }
#endif
        /// <summary>Issuance date</summary>
        public DateTimeOffset? CertificateIssuanceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certificateIssuanceDateTime"); }
            set { BackingStore?.Set("certificateIssuanceDateTime", value); }
        }
        /// <summary>Issuer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateIssuerName {
            get { return BackingStore?.Get<string?>("certificateIssuerName"); }
            set { BackingStore?.Set("certificateIssuerName", value); }
        }
#nullable restore
#else
        public string CertificateIssuerName {
            get { return BackingStore?.Get<string>("certificateIssuerName"); }
            set { BackingStore?.Set("certificateIssuerName", value); }
        }
#endif
        /// <summary>Key Usage</summary>
        public int? CertificateKeyUsages {
            get { return BackingStore?.Get<int?>("certificateKeyUsages"); }
            set { BackingStore?.Set("certificateKeyUsages", value); }
        }
        /// <summary>Certificate Revocation Status.</summary>
        public CertificateRevocationStatus? CertificateRevokeStatus {
            get { return BackingStore?.Get<CertificateRevocationStatus?>("certificateRevokeStatus"); }
            set { BackingStore?.Set("certificateRevokeStatus", value); }
        }
        /// <summary>The time the revoke status was last changed</summary>
        public DateTimeOffset? CertificateRevokeStatusLastChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certificateRevokeStatusLastChangeDateTime"); }
            set { BackingStore?.Set("certificateRevokeStatusLastChangeDateTime", value); }
        }
        /// <summary>Serial number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateSerialNumber {
            get { return BackingStore?.Get<string?>("certificateSerialNumber"); }
            set { BackingStore?.Set("certificateSerialNumber", value); }
        }
#nullable restore
#else
        public string CertificateSerialNumber {
            get { return BackingStore?.Get<string>("certificateSerialNumber"); }
            set { BackingStore?.Set("certificateSerialNumber", value); }
        }
#endif
        /// <summary>Certificate subject name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateSubjectName {
            get { return BackingStore?.Get<string?>("certificateSubjectName"); }
            set { BackingStore?.Set("certificateSubjectName", value); }
        }
#nullable restore
#else
        public string CertificateSubjectName {
            get { return BackingStore?.Get<string>("certificateSubjectName"); }
            set { BackingStore?.Set("certificateSubjectName", value); }
        }
#endif
        /// <summary>Thumbprint</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateThumbprint {
            get { return BackingStore?.Get<string?>("certificateThumbprint"); }
            set { BackingStore?.Set("certificateThumbprint", value); }
        }
#nullable restore
#else
        public string CertificateThumbprint {
            get { return BackingStore?.Get<string>("certificateThumbprint"); }
            set { BackingStore?.Set("certificateThumbprint", value); }
        }
#endif
        /// <summary>Device display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceDisplayName {
            get { return BackingStore?.Get<string?>("managedDeviceDisplayName"); }
            set { BackingStore?.Set("managedDeviceDisplayName", value); }
        }
#nullable restore
#else
        public string ManagedDeviceDisplayName {
            get { return BackingStore?.Get<string>("managedDeviceDisplayName"); }
            set { BackingStore?.Set("managedDeviceDisplayName", value); }
        }
#endif
        /// <summary>User principal name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAllDeviceCertificateState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAllDeviceCertificateState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateExpirationDateTime", n => { CertificateExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateExtendedKeyUsages", n => { CertificateExtendedKeyUsages = n.GetStringValue(); } },
                {"certificateIssuanceDateTime", n => { CertificateIssuanceDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateIssuerName", n => { CertificateIssuerName = n.GetStringValue(); } },
                {"certificateKeyUsages", n => { CertificateKeyUsages = n.GetIntValue(); } },
                {"certificateRevokeStatus", n => { CertificateRevokeStatus = n.GetEnumValue<CertificateRevocationStatus>(); } },
                {"certificateRevokeStatusLastChangeDateTime", n => { CertificateRevokeStatusLastChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateSerialNumber", n => { CertificateSerialNumber = n.GetStringValue(); } },
                {"certificateSubjectName", n => { CertificateSubjectName = n.GetStringValue(); } },
                {"certificateThumbprint", n => { CertificateThumbprint = n.GetStringValue(); } },
                {"managedDeviceDisplayName", n => { ManagedDeviceDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("certificateExpirationDateTime", CertificateExpirationDateTime);
            writer.WriteStringValue("certificateExtendedKeyUsages", CertificateExtendedKeyUsages);
            writer.WriteDateTimeOffsetValue("certificateIssuanceDateTime", CertificateIssuanceDateTime);
            writer.WriteStringValue("certificateIssuerName", CertificateIssuerName);
            writer.WriteIntValue("certificateKeyUsages", CertificateKeyUsages);
            writer.WriteEnumValue<CertificateRevocationStatus>("certificateRevokeStatus", CertificateRevokeStatus);
            writer.WriteDateTimeOffsetValue("certificateRevokeStatusLastChangeDateTime", CertificateRevokeStatusLastChangeDateTime);
            writer.WriteStringValue("certificateSerialNumber", CertificateSerialNumber);
            writer.WriteStringValue("certificateSubjectName", CertificateSubjectName);
            writer.WriteStringValue("certificateThumbprint", CertificateThumbprint);
            writer.WriteStringValue("managedDeviceDisplayName", ManagedDeviceDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
