// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementTemplateCollectionTenantSummary : Entity, IParsable {
        /// <summary>The completeStepsCount property</summary>
        public int? CompleteStepsCount {
            get { return BackingStore?.Get<int?>("completeStepsCount"); }
            set { BackingStore?.Set("completeStepsCount", value); }
        }
        /// <summary>The completeUsersCount property</summary>
        public int? CompleteUsersCount {
            get { return BackingStore?.Get<int?>("completeUsersCount"); }
            set { BackingStore?.Set("completeUsersCount", value); }
        }
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
#else
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The dismissedStepsCount property</summary>
        public int? DismissedStepsCount {
            get { return BackingStore?.Get<int?>("dismissedStepsCount"); }
            set { BackingStore?.Set("dismissedStepsCount", value); }
        }
        /// <summary>The excludedUsersCount property</summary>
        public int? ExcludedUsersCount {
            get { return BackingStore?.Get<int?>("excludedUsersCount"); }
            set { BackingStore?.Set("excludedUsersCount", value); }
        }
        /// <summary>The excludedUsersDistinctCount property</summary>
        public int? ExcludedUsersDistinctCount {
            get { return BackingStore?.Get<int?>("excludedUsersDistinctCount"); }
            set { BackingStore?.Set("excludedUsersDistinctCount", value); }
        }
        /// <summary>The incompleteStepsCount property</summary>
        public int? IncompleteStepsCount {
            get { return BackingStore?.Get<int?>("incompleteStepsCount"); }
            set { BackingStore?.Set("incompleteStepsCount", value); }
        }
        /// <summary>The incompleteUsersCount property</summary>
        public int? IncompleteUsersCount {
            get { return BackingStore?.Get<int?>("incompleteUsersCount"); }
            set { BackingStore?.Set("incompleteUsersCount", value); }
        }
        /// <summary>The ineligibleStepsCount property</summary>
        public int? IneligibleStepsCount {
            get { return BackingStore?.Get<int?>("ineligibleStepsCount"); }
            set { BackingStore?.Set("ineligibleStepsCount", value); }
        }
        /// <summary>The isComplete property</summary>
        public bool? IsComplete {
            get { return BackingStore?.Get<bool?>("isComplete"); }
            set { BackingStore?.Set("isComplete", value); }
        }
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
#else
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The managementTemplateCollectionDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateCollectionDisplayName {
            get { return BackingStore?.Get<string?>("managementTemplateCollectionDisplayName"); }
            set { BackingStore?.Set("managementTemplateCollectionDisplayName", value); }
        }
#nullable restore
#else
        public string ManagementTemplateCollectionDisplayName {
            get { return BackingStore?.Get<string>("managementTemplateCollectionDisplayName"); }
            set { BackingStore?.Set("managementTemplateCollectionDisplayName", value); }
        }
#endif
        /// <summary>The managementTemplateCollectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateCollectionId {
            get { return BackingStore?.Get<string?>("managementTemplateCollectionId"); }
            set { BackingStore?.Set("managementTemplateCollectionId", value); }
        }
#nullable restore
#else
        public string ManagementTemplateCollectionId {
            get { return BackingStore?.Get<string>("managementTemplateCollectionId"); }
            set { BackingStore?.Set("managementTemplateCollectionId", value); }
        }
#endif
        /// <summary>The regressedStepsCount property</summary>
        public int? RegressedStepsCount {
            get { return BackingStore?.Get<int?>("regressedStepsCount"); }
            set { BackingStore?.Set("regressedStepsCount", value); }
        }
        /// <summary>The regressedUsersCount property</summary>
        public int? RegressedUsersCount {
            get { return BackingStore?.Get<int?>("regressedUsersCount"); }
            set { BackingStore?.Set("regressedUsersCount", value); }
        }
        /// <summary>The tenantId property</summary>
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
        /// <summary>The unlicensedUsersCount property</summary>
        public int? UnlicensedUsersCount {
            get { return BackingStore?.Get<int?>("unlicensedUsersCount"); }
            set { BackingStore?.Set("unlicensedUsersCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateCollectionTenantSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateCollectionTenantSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completeStepsCount", n => { CompleteStepsCount = n.GetIntValue(); } },
                {"completeUsersCount", n => { CompleteUsersCount = n.GetIntValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dismissedStepsCount", n => { DismissedStepsCount = n.GetIntValue(); } },
                {"excludedUsersCount", n => { ExcludedUsersCount = n.GetIntValue(); } },
                {"excludedUsersDistinctCount", n => { ExcludedUsersDistinctCount = n.GetIntValue(); } },
                {"incompleteStepsCount", n => { IncompleteStepsCount = n.GetIntValue(); } },
                {"incompleteUsersCount", n => { IncompleteUsersCount = n.GetIntValue(); } },
                {"ineligibleStepsCount", n => { IneligibleStepsCount = n.GetIntValue(); } },
                {"isComplete", n => { IsComplete = n.GetBoolValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollectionDisplayName", n => { ManagementTemplateCollectionDisplayName = n.GetStringValue(); } },
                {"managementTemplateCollectionId", n => { ManagementTemplateCollectionId = n.GetStringValue(); } },
                {"regressedStepsCount", n => { RegressedStepsCount = n.GetIntValue(); } },
                {"regressedUsersCount", n => { RegressedUsersCount = n.GetIntValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"unlicensedUsersCount", n => { UnlicensedUsersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("completeStepsCount", CompleteStepsCount);
            writer.WriteIntValue("completeUsersCount", CompleteUsersCount);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("dismissedStepsCount", DismissedStepsCount);
            writer.WriteIntValue("excludedUsersCount", ExcludedUsersCount);
            writer.WriteIntValue("excludedUsersDistinctCount", ExcludedUsersDistinctCount);
            writer.WriteIntValue("incompleteStepsCount", IncompleteStepsCount);
            writer.WriteIntValue("incompleteUsersCount", IncompleteUsersCount);
            writer.WriteIntValue("ineligibleStepsCount", IneligibleStepsCount);
            writer.WriteBoolValue("isComplete", IsComplete);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("managementTemplateCollectionDisplayName", ManagementTemplateCollectionDisplayName);
            writer.WriteStringValue("managementTemplateCollectionId", ManagementTemplateCollectionId);
            writer.WriteIntValue("regressedStepsCount", RegressedStepsCount);
            writer.WriteIntValue("regressedUsersCount", RegressedUsersCount);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("unlicensedUsersCount", UnlicensedUsersCount);
        }
    }
}
