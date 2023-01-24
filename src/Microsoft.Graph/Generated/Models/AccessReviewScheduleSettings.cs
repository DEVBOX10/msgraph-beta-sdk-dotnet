using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewScheduleSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewApplyAction>? ApplyActions {
            get { return BackingStore?.Get<List<AccessReviewApplyAction>?>("applyActions"); }
            set { BackingStore?.Set("applyActions", value); }
        }
#nullable restore
#else
        public List<AccessReviewApplyAction> ApplyActions {
            get { return BackingStore?.Get<List<AccessReviewApplyAction>>("applyActions"); }
            set { BackingStore?.Set("applyActions", value); }
        }
#endif
        /// <summary>Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.</summary>
        public bool? AutoApplyDecisionsEnabled {
            get { return BackingStore?.Get<bool?>("autoApplyDecisionsEnabled"); }
            set { BackingStore?.Set("autoApplyDecisionsEnabled", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether decisions on previous access review stages are available for reviewers on an accessReviewInstance with multiple subsequent stages. If not provided, the default is disabled (false).</summary>
        public bool? DecisionHistoriesForReviewersEnabled {
            get { return BackingStore?.Get<bool?>("decisionHistoriesForReviewersEnabled"); }
            set { BackingStore?.Set("decisionHistoriesForReviewersEnabled", value); }
        }
        /// <summary>Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDecision {
            get { return BackingStore?.Get<string?>("defaultDecision"); }
            set { BackingStore?.Set("defaultDecision", value); }
        }
#nullable restore
#else
        public string DefaultDecision {
            get { return BackingStore?.Get<string>("defaultDecision"); }
            set { BackingStore?.Set("defaultDecision", value); }
        }
#endif
        /// <summary>Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.</summary>
        public bool? DefaultDecisionEnabled {
            get { return BackingStore?.Get<bool?>("defaultDecisionEnabled"); }
            set { BackingStore?.Set("defaultDecisionEnabled", value); }
        }
        /// <summary>Duration of each recurrence of review (accessReviewInstance) in number of days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its durationInDays setting will be used instead of the value of this property.</summary>
        public int? InstanceDurationInDays {
            get { return BackingStore?.Get<int?>("instanceDurationInDays"); }
            set { BackingStore?.Set("instanceDurationInDays", value); }
        }
        /// <summary>Indicates whether reviewers are required to provide justification with their decision. Default value is false.</summary>
        public bool? JustificationRequiredOnApproval {
            get { return BackingStore?.Get<bool?>("justificationRequiredOnApproval"); }
            set { BackingStore?.Set("justificationRequiredOnApproval", value); }
        }
        /// <summary>Indicates whether emails are enabled or disabled. Default value is false.</summary>
        public bool? MailNotificationsEnabled {
            get { return BackingStore?.Get<bool?>("mailNotificationsEnabled"); }
            set { BackingStore?.Set("mailNotificationsEnabled", value); }
        }
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
        /// <summary>Optional. Describes the types of insights that aid reviewers to make access review decisions. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationInsightSettings setting will be used instead of the value of this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewRecommendationInsightSetting>? RecommendationInsightSettings {
            get { return BackingStore?.Get<List<AccessReviewRecommendationInsightSetting>?>("recommendationInsightSettings"); }
            set { BackingStore?.Set("recommendationInsightSettings", value); }
        }
#nullable restore
#else
        public List<AccessReviewRecommendationInsightSetting> RecommendationInsightSettings {
            get { return BackingStore?.Get<List<AccessReviewRecommendationInsightSetting>>("recommendationInsightSettings"); }
            set { BackingStore?.Set("recommendationInsightSettings", value); }
        }
#endif
        /// <summary>Optional field. Indicates the period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look-back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationLookBackDuration setting will be used instead of the value of this property.</summary>
        public TimeSpan? RecommendationLookBackDuration {
            get { return BackingStore?.Get<TimeSpan?>("recommendationLookBackDuration"); }
            set { BackingStore?.Set("recommendationLookBackDuration", value); }
        }
        /// <summary>Indicates whether decision recommendations are enabled or disabled. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationsEnabled setting will be used instead of the value of this property.</summary>
        public bool? RecommendationsEnabled {
            get { return BackingStore?.Get<bool?>("recommendationsEnabled"); }
            set { BackingStore?.Set("recommendationsEnabled", value); }
        }
        /// <summary>Detailed settings for recurrence using the standard Outlook recurrence object. Note: Only dayOfMonth, interval, and type (weekly, absoluteMonthly) properties are supported. Use the property startDate on recurrenceRange to determine the day the review starts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PatternedRecurrence? Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence?>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#nullable restore
#else
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#endif
        /// <summary>Indicates whether reminders are enabled or disabled. Default value is false.</summary>
        public bool? ReminderNotificationsEnabled {
            get { return BackingStore?.Get<bool?>("reminderNotificationsEnabled"); }
            set { BackingStore?.Set("reminderNotificationsEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new accessReviewScheduleSettings and sets the default values.
        /// </summary>
        public AccessReviewScheduleSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessReviewScheduleSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewScheduleSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applyActions", n => { ApplyActions = n.GetCollectionOfObjectValues<AccessReviewApplyAction>(AccessReviewApplyAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"autoApplyDecisionsEnabled", n => { AutoApplyDecisionsEnabled = n.GetBoolValue(); } },
                {"decisionHistoriesForReviewersEnabled", n => { DecisionHistoriesForReviewersEnabled = n.GetBoolValue(); } },
                {"defaultDecision", n => { DefaultDecision = n.GetStringValue(); } },
                {"defaultDecisionEnabled", n => { DefaultDecisionEnabled = n.GetBoolValue(); } },
                {"instanceDurationInDays", n => { InstanceDurationInDays = n.GetIntValue(); } },
                {"justificationRequiredOnApproval", n => { JustificationRequiredOnApproval = n.GetBoolValue(); } },
                {"mailNotificationsEnabled", n => { MailNotificationsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recommendationInsightSettings", n => { RecommendationInsightSettings = n.GetCollectionOfObjectValues<AccessReviewRecommendationInsightSetting>(AccessReviewRecommendationInsightSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recommendationLookBackDuration", n => { RecommendationLookBackDuration = n.GetTimeSpanValue(); } },
                {"recommendationsEnabled", n => { RecommendationsEnabled = n.GetBoolValue(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderNotificationsEnabled", n => { ReminderNotificationsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AccessReviewApplyAction>("applyActions", ApplyActions);
            writer.WriteBoolValue("autoApplyDecisionsEnabled", AutoApplyDecisionsEnabled);
            writer.WriteBoolValue("decisionHistoriesForReviewersEnabled", DecisionHistoriesForReviewersEnabled);
            writer.WriteStringValue("defaultDecision", DefaultDecision);
            writer.WriteBoolValue("defaultDecisionEnabled", DefaultDecisionEnabled);
            writer.WriteIntValue("instanceDurationInDays", InstanceDurationInDays);
            writer.WriteBoolValue("justificationRequiredOnApproval", JustificationRequiredOnApproval);
            writer.WriteBoolValue("mailNotificationsEnabled", MailNotificationsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<AccessReviewRecommendationInsightSetting>("recommendationInsightSettings", RecommendationInsightSettings);
            writer.WriteTimeSpanValue("recommendationLookBackDuration", RecommendationLookBackDuration);
            writer.WriteBoolValue("recommendationsEnabled", RecommendationsEnabled);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteBoolValue("reminderNotificationsEnabled", ReminderNotificationsEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
