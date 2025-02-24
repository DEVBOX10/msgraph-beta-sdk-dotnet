// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskPropertyRule : PlannerPropertyRule, IParsable {
        /// <summary>Rules and restrictions for applied categories. This value does not currently support overrides. Accepted values for the default rule and individual overrides are allow, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? AppliedCategories {
            get { return BackingStore?.Get<PlannerFieldRules?>("appliedCategories"); }
            set { BackingStore?.Set("appliedCategories", value); }
        }
#nullable restore
#else
        public PlannerFieldRules AppliedCategories {
            get { return BackingStore?.Get<PlannerFieldRules>("appliedCategories"); }
            set { BackingStore?.Set("appliedCategories", value); }
        }
#endif
        /// <summary>Rules and restrictions for assignments. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are allow, add, addSelf, addOther, remove, removeSelf, removeOther, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? Assignments {
            get { return BackingStore?.Get<PlannerFieldRules?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public PlannerFieldRules Assignments {
            get { return BackingStore?.Get<PlannerFieldRules>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Rules and restrictions for checklist. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are allow, add, remove, update, check, reorder, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? CheckLists {
            get { return BackingStore?.Get<PlannerFieldRules?>("checkLists"); }
            set { BackingStore?.Set("checkLists", value); }
        }
#nullable restore
#else
        public PlannerFieldRules CheckLists {
            get { return BackingStore?.Get<PlannerFieldRules>("checkLists"); }
            set { BackingStore?.Set("checkLists", value); }
        }
#endif
        /// <summary>Rules and restrictions for completion requirements of the task. Accepted values are allow, add, remove, edit, and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CompletionRequirements {
            get { return BackingStore?.Get<List<string>?>("completionRequirements"); }
            set { BackingStore?.Set("completionRequirements", value); }
        }
#nullable restore
#else
        public List<string> CompletionRequirements {
            get { return BackingStore?.Get<List<string>>("completionRequirements"); }
            set { BackingStore?.Set("completionRequirements", value); }
        }
#endif
        /// <summary>Rules and restrictions for deleting the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Delete {
            get { return BackingStore?.Get<List<string>?>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
#nullable restore
#else
        public List<string> Delete {
            get { return BackingStore?.Get<List<string>>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the due date of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DueDate {
            get { return BackingStore?.Get<List<string>?>("dueDate"); }
            set { BackingStore?.Set("dueDate", value); }
        }
#nullable restore
#else
        public List<string> DueDate {
            get { return BackingStore?.Get<List<string>>("dueDate"); }
            set { BackingStore?.Set("dueDate", value); }
        }
#endif
        /// <summary>Rules and restrictions for moving the task between buckets or plans. Accepted values are allow, moveBetweenPlans, moveBetweenBuckets, and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Move {
            get { return BackingStore?.Get<List<string>?>("move"); }
            set { BackingStore?.Set("move", value); }
        }
#nullable restore
#else
        public List<string> Move {
            get { return BackingStore?.Get<List<string>>("move"); }
            set { BackingStore?.Set("move", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the notes of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Notes {
            get { return BackingStore?.Get<List<string>?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public List<string> Notes {
            get { return BackingStore?.Get<List<string>>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the order of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Order {
            get { return BackingStore?.Get<List<string>?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#nullable restore
#else
        public List<string> Order {
            get { return BackingStore?.Get<List<string>>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the completion percentage of the task. Accepted values are allow, setToComplete, overrideRequirements, setToNotStarted, setToInProgress, and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PercentComplete {
            get { return BackingStore?.Get<List<string>?>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
#nullable restore
#else
        public List<string> PercentComplete {
            get { return BackingStore?.Get<List<string>>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the preview type of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PreviewType {
            get { return BackingStore?.Get<List<string>?>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
#nullable restore
#else
        public List<string> PreviewType {
            get { return BackingStore?.Get<List<string>>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the priority of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Priority {
            get { return BackingStore?.Get<List<string>?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
#nullable restore
#else
        public List<string> Priority {
            get { return BackingStore?.Get<List<string>>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
#endif
        /// <summary>Rules and restrictions for references. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are allow, add, remove, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? References {
            get { return BackingStore?.Get<PlannerFieldRules?>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#nullable restore
#else
        public PlannerFieldRules References {
            get { return BackingStore?.Get<PlannerFieldRules>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the start date of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StartDate {
            get { return BackingStore?.Get<List<string>?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#nullable restore
#else
        public List<string> StartDate {
            get { return BackingStore?.Get<List<string>>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#endif
        /// <summary>Rules and restrictions for changing the title of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Title {
            get { return BackingStore?.Get<List<string>?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public List<string> Title {
            get { return BackingStore?.Get<List<string>>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new plannerTaskPropertyRule and sets the default values.
        /// </summary>
        public PlannerTaskPropertyRule() : base() {
            OdataType = "#microsoft.graph.plannerTaskPropertyRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTaskPropertyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskPropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliedCategories", n => { AppliedCategories = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"assignments", n => { Assignments = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"checkLists", n => { CheckLists = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"completionRequirements", n => { CompletionRequirements = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"delete", n => { Delete = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"dueDate", n => { DueDate = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"move", n => { Move = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notes", n => { Notes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"order", n => { Order = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"percentComplete", n => { PercentComplete = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"previewType", n => { PreviewType = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"priority", n => { Priority = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"references", n => { References = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                {"startDate", n => { StartDate = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"title", n => { Title = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerFieldRules>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<PlannerFieldRules>("assignments", Assignments);
            writer.WriteObjectValue<PlannerFieldRules>("checkLists", CheckLists);
            writer.WriteCollectionOfPrimitiveValues<string>("completionRequirements", CompletionRequirements);
            writer.WriteCollectionOfPrimitiveValues<string>("delete", Delete);
            writer.WriteCollectionOfPrimitiveValues<string>("dueDate", DueDate);
            writer.WriteCollectionOfPrimitiveValues<string>("move", Move);
            writer.WriteCollectionOfPrimitiveValues<string>("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("order", Order);
            writer.WriteCollectionOfPrimitiveValues<string>("percentComplete", PercentComplete);
            writer.WriteCollectionOfPrimitiveValues<string>("previewType", PreviewType);
            writer.WriteCollectionOfPrimitiveValues<string>("priority", Priority);
            writer.WriteObjectValue<PlannerFieldRules>("references", References);
            writer.WriteCollectionOfPrimitiveValues<string>("startDate", StartDate);
            writer.WriteCollectionOfPrimitiveValues<string>("title", Title);
        }
    }
}
