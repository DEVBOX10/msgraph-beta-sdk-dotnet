using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SymantecCodeSigningCertificate : Entity, IParsable {
        /// <summary>The Windows Symantec Code-Signing Certificate in the raw data format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The Cert Expiration Date.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The Issuer value for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer {
            get { return BackingStore?.Get<string?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#nullable restore
#else
        public string Issuer {
            get { return BackingStore?.Get<string>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#endif
        /// <summary>The Issuer Name for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerName {
            get { return BackingStore?.Get<string?>("issuerName"); }
            set { BackingStore?.Set("issuerName", value); }
        }
#nullable restore
#else
        public string IssuerName {
            get { return BackingStore?.Get<string>("issuerName"); }
            set { BackingStore?.Set("issuerName", value); }
        }
#endif
        /// <summary>The Password required for .pfx file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password {
            get { return BackingStore?.Get<string?>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#nullable restore
#else
        public string Password {
            get { return BackingStore?.Get<string>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#endif
        /// <summary>The status property</summary>
        public CertificateStatus? Status {
            get { return BackingStore?.Get<CertificateStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The Subject value for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The Subject Name for the cert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectName {
            get { return BackingStore?.Get<string?>("subjectName"); }
            set { BackingStore?.Set("subjectName", value); }
        }
#nullable restore
#else
        public string SubjectName {
            get { return BackingStore?.Get<string>("subjectName"); }
            set { BackingStore?.Set("subjectName", value); }
        }
#endif
        /// <summary>The Type of the CodeSigning Cert as Symantec Cert.</summary>
        public DateTimeOffset? UploadDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("uploadDateTime"); }
            set { BackingStore?.Set("uploadDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SymantecCodeSigningCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SymantecCodeSigningCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"issuerName", n => { IssuerName = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CertificateStatus>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"subjectName", n => { SubjectName = n.GetStringValue(); } },
                {"uploadDateTime", n => { UploadDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("issuerName", IssuerName);
            writer.WriteStringValue("password", Password);
            writer.WriteEnumValue<CertificateStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteDateTimeOffsetValue("uploadDateTime", UploadDateTime);
        }
    }
}
