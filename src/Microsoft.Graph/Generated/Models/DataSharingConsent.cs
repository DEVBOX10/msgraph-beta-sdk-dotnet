using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Data sharing consent information.
    /// </summary>
    public class DataSharingConsent : Entity, IParsable {
        /// <summary>The time consent was granted for this account</summary>
        public DateTimeOffset? GrantDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("grantDateTime"); }
            set { BackingStore?.Set("grantDateTime", value); }
        }
        /// <summary>The granted state for the data sharing consent</summary>
        public bool? Granted {
            get { return BackingStore?.Get<bool?>("granted"); }
            set { BackingStore?.Set("granted", value); }
        }
        /// <summary>The Upn of the user that granted consent for this account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GrantedByUpn {
            get { return BackingStore?.Get<string?>("grantedByUpn"); }
            set { BackingStore?.Set("grantedByUpn", value); }
        }
#nullable restore
#else
        public string GrantedByUpn {
            get { return BackingStore?.Get<string>("grantedByUpn"); }
            set { BackingStore?.Set("grantedByUpn", value); }
        }
#endif
        /// <summary>The UserId of the user that granted consent for this account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GrantedByUserId {
            get { return BackingStore?.Get<string?>("grantedByUserId"); }
            set { BackingStore?.Set("grantedByUserId", value); }
        }
#nullable restore
#else
        public string GrantedByUserId {
            get { return BackingStore?.Get<string>("grantedByUserId"); }
            set { BackingStore?.Set("grantedByUserId", value); }
        }
#endif
        /// <summary>The display name of the service work flow</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceDisplayName {
            get { return BackingStore?.Get<string?>("serviceDisplayName"); }
            set { BackingStore?.Set("serviceDisplayName", value); }
        }
#nullable restore
#else
        public string ServiceDisplayName {
            get { return BackingStore?.Get<string>("serviceDisplayName"); }
            set { BackingStore?.Set("serviceDisplayName", value); }
        }
#endif
        /// <summary>The TermsUrl for the data sharing consent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TermsUrl {
            get { return BackingStore?.Get<string?>("termsUrl"); }
            set { BackingStore?.Set("termsUrl", value); }
        }
#nullable restore
#else
        public string TermsUrl {
            get { return BackingStore?.Get<string>("termsUrl"); }
            set { BackingStore?.Set("termsUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DataSharingConsent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataSharingConsent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"grantDateTime", n => { GrantDateTime = n.GetDateTimeOffsetValue(); } },
                {"granted", n => { Granted = n.GetBoolValue(); } },
                {"grantedByUpn", n => { GrantedByUpn = n.GetStringValue(); } },
                {"grantedByUserId", n => { GrantedByUserId = n.GetStringValue(); } },
                {"serviceDisplayName", n => { ServiceDisplayName = n.GetStringValue(); } },
                {"termsUrl", n => { TermsUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("grantDateTime", GrantDateTime);
            writer.WriteBoolValue("granted", Granted);
            writer.WriteStringValue("grantedByUpn", GrantedByUpn);
            writer.WriteStringValue("grantedByUserId", GrantedByUserId);
            writer.WriteStringValue("serviceDisplayName", ServiceDisplayName);
            writer.WriteStringValue("termsUrl", TermsUrl);
        }
    }
}
