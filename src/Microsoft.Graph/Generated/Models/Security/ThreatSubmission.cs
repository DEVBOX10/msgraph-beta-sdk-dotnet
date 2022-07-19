using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ThreatSubmission : Entity, IParsable {
        /// <summary>Specifies the admin review property which constitutes of who reviewed the user submission, when and what was it identified as.</summary>
        public SubmissionAdminReview AdminReview {
            get { return BackingStore?.Get<SubmissionAdminReview>("adminReview"); }
            set { BackingStore?.Set("adminReview", value); }
        }
        /// <summary>The category property</summary>
        public SubmissionCategory? Category {
            get { return BackingStore?.Get<SubmissionCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>Specifies the source of the submission. The possible values are: microsoft,  other and unkownFutureValue.</summary>
        public SubmissionClientSource? ClientSource {
            get { return BackingStore?.Get<SubmissionClientSource?>("clientSource"); }
            set { BackingStore?.Set("clientSource", value); }
        }
        /// <summary>Specifies the type of content being submitted. The possible values are: email, url, file, app and unkownFutureValue.</summary>
        public SubmissionContentType? ContentType {
            get { return BackingStore?.Get<SubmissionContentType?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
        /// <summary>Specifies who submitted the email as a threat. Supports $filter = createdBy/email eq &apos;value&apos;.</summary>
        public SubmissionUserIdentity CreatedBy {
            get { return BackingStore?.Get<SubmissionUserIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>Specifies when the threat submission was created. Supports $filter = createdDateTime ge 2022-01-01T00:00:00Z and createdDateTime lt 2022-01-02T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Specifies the result of the analysis performed by Microsoft.</summary>
        public SubmissionResult Result {
            get { return BackingStore?.Get<SubmissionResult>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>Specifies the role of the submitter. Supports $filter = source eq &apos;value&apos;. The possible values are: administrator,  user and unkownFutureValue.</summary>
        public SubmissionSource? Source {
            get { return BackingStore?.Get<SubmissionSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>Indicates whether the threat submission has been analyzed by Microsoft. Supports $filter = status eq &apos;value&apos;. The possible values are: notStarted, running, succeeded, failed, skipped and unkownFutureValue.</summary>
        public LongRunningOperationStatus? Status {
            get { return BackingStore?.Get<LongRunningOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Indicates the tenant id of the submitter. Not required when created using a POST operation. It is extracted from the token of the post API call.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>
        /// Instantiates a new threatSubmission and sets the default values.
        /// </summary>
        public ThreatSubmission() : base() {
            OdataType = "#microsoft.graph.security.threatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.emailContentThreatSubmission" => new EmailContentThreatSubmission(),
                "#microsoft.graph.security.emailThreatSubmission" => new EmailThreatSubmission(),
                "#microsoft.graph.security.emailUrlThreatSubmission" => new EmailUrlThreatSubmission(),
                "#microsoft.graph.security.fileContentThreatSubmission" => new FileContentThreatSubmission(),
                "#microsoft.graph.security.fileThreatSubmission" => new FileThreatSubmission(),
                "#microsoft.graph.security.fileUrlThreatSubmission" => new FileUrlThreatSubmission(),
                "#microsoft.graph.security.urlThreatSubmission" => new UrlThreatSubmission(),
                _ => new ThreatSubmission(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"adminReview", n => { AdminReview = n.GetObjectValue<SubmissionAdminReview>(SubmissionAdminReview.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetEnumValue<SubmissionCategory>(); } },
                {"clientSource", n => { ClientSource = n.GetEnumValue<SubmissionClientSource>(); } },
                {"contentType", n => { ContentType = n.GetEnumValue<SubmissionContentType>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<SubmissionUserIdentity>(SubmissionUserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"result", n => { Result = n.GetObjectValue<SubmissionResult>(SubmissionResult.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetEnumValue<SubmissionSource>(); } },
                {"status", n => { Status = n.GetEnumValue<LongRunningOperationStatus>(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SubmissionAdminReview>("adminReview", AdminReview);
            writer.WriteEnumValue<SubmissionCategory>("category", Category);
            writer.WriteEnumValue<SubmissionClientSource>("clientSource", ClientSource);
            writer.WriteEnumValue<SubmissionContentType>("contentType", ContentType);
            writer.WriteObjectValue<SubmissionUserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<SubmissionResult>("result", Result);
            writer.WriteEnumValue<SubmissionSource>("source", Source);
            writer.WriteEnumValue<LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
