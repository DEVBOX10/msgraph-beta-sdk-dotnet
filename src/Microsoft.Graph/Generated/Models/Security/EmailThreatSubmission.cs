// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EmailThreatSubmission : ThreatSubmission, IParsable {
        /// <summary>If the email is phishing simulation, this field won&apos;t be null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo? AttackSimulationInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo?>("attackSimulationInfo"); }
            set { BackingStore?.Set("attackSimulationInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo AttackSimulationInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo>("attackSimulationInfo"); }
            set { BackingStore?.Set("attackSimulationInfo", value); }
        }
#endif
        /// <summary>Specifies the internet message ID of the email being submitted. This information is present in the email header.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId {
            get { return BackingStore?.Get<string?>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#nullable restore
#else
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#endif
        /// <summary>The original category of the submission. The possible values are: notJunk, spam, phishing, malware and unkownFutureValue.</summary>
        public SubmissionCategory? OriginalCategory {
            get { return BackingStore?.Get<SubmissionCategory?>("originalCategory"); }
            set { BackingStore?.Set("originalCategory", value); }
        }
        /// <summary>Specifies the date and time stamp when the email was received.</summary>
        public DateTimeOffset? ReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>Specifies the email address (in smtp format) of the recipient who received the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientEmailAddress {
            get { return BackingStore?.Get<string?>("recipientEmailAddress"); }
            set { BackingStore?.Set("recipientEmailAddress", value); }
        }
#nullable restore
#else
        public string RecipientEmailAddress {
            get { return BackingStore?.Get<string>("recipientEmailAddress"); }
            set { BackingStore?.Set("recipientEmailAddress", value); }
        }
#endif
        /// <summary>Specifies the email address of the sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sender {
            get { return BackingStore?.Get<string?>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
#nullable restore
#else
        public string Sender {
            get { return BackingStore?.Get<string>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
#endif
        /// <summary>Specifies the IP address of the sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderIP {
            get { return BackingStore?.Get<string?>("senderIP"); }
            set { BackingStore?.Set("senderIP", value); }
        }
#nullable restore
#else
        public string SenderIP {
            get { return BackingStore?.Get<string>("senderIP"); }
            set { BackingStore?.Set("senderIP", value); }
        }
#endif
        /// <summary>Specifies the subject of the email.</summary>
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
        /// <summary>It&apos;s used to automatically add allows for the components such as URL, file, sender; which are deemed bad by Microsoft so that similar messages in the future can be allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction? TenantAllowOrBlockListAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction?>("tenantAllowOrBlockListAction"); }
            set { BackingStore?.Set("tenantAllowOrBlockListAction", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction TenantAllowOrBlockListAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction>("tenantAllowOrBlockListAction"); }
            set { BackingStore?.Set("tenantAllowOrBlockListAction", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new emailThreatSubmission and sets the default values.
        /// </summary>
        public EmailThreatSubmission() : base() {
            OdataType = "#microsoft.graph.security.emailThreatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.emailContentThreatSubmission" => new EmailContentThreatSubmission(),
                "#microsoft.graph.security.emailUrlThreatSubmission" => new EmailUrlThreatSubmission(),
                _ => new EmailThreatSubmission(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attackSimulationInfo", n => { AttackSimulationInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo>(Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo.CreateFromDiscriminatorValue); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"originalCategory", n => { OriginalCategory = n.GetEnumValue<SubmissionCategory>(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientEmailAddress", n => { RecipientEmailAddress = n.GetStringValue(); } },
                {"sender", n => { Sender = n.GetStringValue(); } },
                {"senderIP", n => { SenderIP = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"tenantAllowOrBlockListAction", n => { TenantAllowOrBlockListAction = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction>(Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.AttackSimulationInfo>("attackSimulationInfo", AttackSimulationInfo);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteEnumValue<SubmissionCategory>("originalCategory", OriginalCategory);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteStringValue("recipientEmailAddress", RecipientEmailAddress);
            writer.WriteStringValue("sender", Sender);
            writer.WriteStringValue("senderIP", SenderIP);
            writer.WriteStringValue("subject", Subject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.TenantAllowOrBlockListAction>("tenantAllowOrBlockListAction", TenantAllowOrBlockListAction);
        }
    }
}
