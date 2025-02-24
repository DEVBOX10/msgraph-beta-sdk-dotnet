// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewDecision : Entity, IParsable {
        /// <summary>The feature- generated recommendation shown to the reviewer, one of Approve, Deny or NotAvailable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessRecommendation {
            get { return BackingStore?.Get<string?>("accessRecommendation"); }
            set { BackingStore?.Set("accessRecommendation", value); }
        }
#nullable restore
#else
        public string AccessRecommendation {
            get { return BackingStore?.Get<string>("accessRecommendation"); }
            set { BackingStore?.Set("accessRecommendation", value); }
        }
#endif
        /// <summary>The feature-generated ID of the access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessReviewId {
            get { return BackingStore?.Get<string?>("accessReviewId"); }
            set { BackingStore?.Set("accessReviewId", value); }
        }
#nullable restore
#else
        public string AccessReviewId {
            get { return BackingStore?.Get<string>("accessReviewId"); }
            set { BackingStore?.Set("accessReviewId", value); }
        }
#endif
        /// <summary>When the review completes, if the results were manually applied, the user identity of the user who applied the decision. If the review was autoapplied, the userPrincipalName is empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? AppliedBy {
            get { return BackingStore?.Get<UserIdentity?>("appliedBy"); }
            set { BackingStore?.Set("appliedBy", value); }
        }
#nullable restore
#else
        public UserIdentity AppliedBy {
            get { return BackingStore?.Get<UserIdentity>("appliedBy"); }
            set { BackingStore?.Set("appliedBy", value); }
        }
#endif
        /// <summary>The date and time when the review decision was applied.</summary>
        public DateTimeOffset? AppliedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("appliedDateTime"); }
            set { BackingStore?.Set("appliedDateTime", value); }
        }
        /// <summary>The outcome of applying the decision, one of NotApplied, Success, Failed, NotFound or NotSupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplyResult {
            get { return BackingStore?.Get<string?>("applyResult"); }
            set { BackingStore?.Set("applyResult", value); }
        }
#nullable restore
#else
        public string ApplyResult {
            get { return BackingStore?.Get<string>("applyResult"); }
            set { BackingStore?.Set("applyResult", value); }
        }
#endif
        /// <summary>The reviewer&apos;s business justification, if supplied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>The identity of the reviewer. If the recommendation was used as the review, the userPrincipalName is empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? ReviewedBy {
            get { return BackingStore?.Get<UserIdentity?>("reviewedBy"); }
            set { BackingStore?.Set("reviewedBy", value); }
        }
#nullable restore
#else
        public UserIdentity ReviewedBy {
            get { return BackingStore?.Get<UserIdentity>("reviewedBy"); }
            set { BackingStore?.Set("reviewedBy", value); }
        }
#endif
        /// <summary>The reviewedDateTime property</summary>
        public DateTimeOffset? ReviewedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewedDateTime"); }
            set { BackingStore?.Set("reviewedDateTime", value); }
        }
        /// <summary>The result of the review, one of NotReviewed, Deny, DontKnow or Approve.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewResult {
            get { return BackingStore?.Get<string?>("reviewResult"); }
            set { BackingStore?.Set("reviewResult", value); }
        }
#nullable restore
#else
        public string ReviewResult {
            get { return BackingStore?.Get<string>("reviewResult"); }
            set { BackingStore?.Set("reviewResult", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewDecision CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewDecision();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessRecommendation", n => { AccessRecommendation = n.GetStringValue(); } },
                {"accessReviewId", n => { AccessReviewId = n.GetStringValue(); } },
                {"appliedBy", n => { AppliedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"appliedDateTime", n => { AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyResult", n => { ApplyResult = n.GetStringValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"reviewResult", n => { ReviewResult = n.GetStringValue(); } },
                {"reviewedBy", n => { ReviewedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", n => { ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accessRecommendation", AccessRecommendation);
            writer.WriteStringValue("accessReviewId", AccessReviewId);
            writer.WriteObjectValue<UserIdentity>("appliedBy", AppliedBy);
            writer.WriteDateTimeOffsetValue("appliedDateTime", AppliedDateTime);
            writer.WriteStringValue("applyResult", ApplyResult);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<UserIdentity>("reviewedBy", ReviewedBy);
            writer.WriteDateTimeOffsetValue("reviewedDateTime", ReviewedDateTime);
            writer.WriteStringValue("reviewResult", ReviewResult);
        }
    }
}
