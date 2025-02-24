// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EducationClass : Entity, IParsable {
        /// <summary>All categories associated with this class. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationCategory>? AssignmentCategories {
            get { return BackingStore?.Get<List<EducationCategory>?>("assignmentCategories"); }
            set { BackingStore?.Set("assignmentCategories", value); }
        }
#nullable restore
#else
        public List<EducationCategory> AssignmentCategories {
            get { return BackingStore?.Get<List<EducationCategory>>("assignmentCategories"); }
            set { BackingStore?.Set("assignmentCategories", value); }
        }
#endif
        /// <summary>Specifies class-level defaults respected by new assignments created in the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationAssignmentDefaults? AssignmentDefaults {
            get { return BackingStore?.Get<EducationAssignmentDefaults?>("assignmentDefaults"); }
            set { BackingStore?.Set("assignmentDefaults", value); }
        }
#nullable restore
#else
        public EducationAssignmentDefaults AssignmentDefaults {
            get { return BackingStore?.Get<EducationAssignmentDefaults>("assignmentDefaults"); }
            set { BackingStore?.Set("assignmentDefaults", value); }
        }
#endif
        /// <summary>All assignments associated with this class. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationAssignment>? Assignments {
            get { return BackingStore?.Get<List<EducationAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<EducationAssignment> Assignments {
            get { return BackingStore?.Get<List<EducationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Specifies class-level assignments settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationAssignmentSettings? AssignmentSettings {
            get { return BackingStore?.Get<EducationAssignmentSettings?>("assignmentSettings"); }
            set { BackingStore?.Set("assignmentSettings", value); }
        }
#nullable restore
#else
        public EducationAssignmentSettings AssignmentSettings {
            get { return BackingStore?.Get<EducationAssignmentSettings>("assignmentSettings"); }
            set { BackingStore?.Set("assignmentSettings", value); }
        }
#endif
        /// <summary>Class code used by the school to identify the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClassCode {
            get { return BackingStore?.Get<string?>("classCode"); }
            set { BackingStore?.Set("classCode", value); }
        }
#nullable restore
#else
        public string ClassCode {
            get { return BackingStore?.Get<string>("classCode"); }
            set { BackingStore?.Set("classCode", value); }
        }
#endif
        /// <summary>Course information for the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationCourse? Course {
            get { return BackingStore?.Get<EducationCourse?>("course"); }
            set { BackingStore?.Set("course", value); }
        }
#nullable restore
#else
        public EducationCourse Course {
            get { return BackingStore?.Get<EducationCourse>("course"); }
            set { BackingStore?.Set("course", value); }
        }
#endif
        /// <summary>Entity who created the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Description of the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of the class.</summary>
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
        /// <summary>ID of the class from the syncing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>Name of the class in the syncing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalName {
            get { return BackingStore?.Get<string?>("externalName"); }
            set { BackingStore?.Set("externalName", value); }
        }
#nullable restore
#else
        public string ExternalName {
            get { return BackingStore?.Get<string>("externalName"); }
            set { BackingStore?.Set("externalName", value); }
        }
#endif
        /// <summary>The type of external source this resource was generated from (automatically determined from externalSourceDetail). Possible values are: sis, lms, or manual.</summary>
        public EducationExternalSource? ExternalSource {
            get { return BackingStore?.Get<EducationExternalSource?>("externalSource"); }
            set { BackingStore?.Set("externalSource", value); }
        }
        /// <summary>The name of the external source this resources was generated from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalSourceDetail {
            get { return BackingStore?.Get<string?>("externalSourceDetail"); }
            set { BackingStore?.Set("externalSourceDetail", value); }
        }
#nullable restore
#else
        public string ExternalSourceDetail {
            get { return BackingStore?.Get<string>("externalSourceDetail"); }
            set { BackingStore?.Set("externalSourceDetail", value); }
        }
#endif
        /// <summary>Grade level of the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Grade {
            get { return BackingStore?.Get<string?>("grade"); }
            set { BackingStore?.Set("grade", value); }
        }
#nullable restore
#else
        public string Grade {
            get { return BackingStore?.Get<string>("grade"); }
            set { BackingStore?.Set("grade", value); }
        }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Group? Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Mail name for sending email to all members, if this is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailNickname {
            get { return BackingStore?.Get<string?>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#nullable restore
#else
        public string MailNickname {
            get { return BackingStore?.Get<string>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#endif
        /// <summary>All users in the class. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationUser>? Members {
            get { return BackingStore?.Get<List<EducationUser>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<EducationUser> Members {
            get { return BackingStore?.Get<List<EducationUser>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>All modules in the class. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationModule>? Modules {
            get { return BackingStore?.Get<List<EducationModule>?>("modules"); }
            set { BackingStore?.Set("modules", value); }
        }
#nullable restore
#else
        public List<EducationModule> Modules {
            get { return BackingStore?.Get<List<EducationModule>>("modules"); }
            set { BackingStore?.Set("modules", value); }
        }
#endif
        /// <summary>All schools that this class is associated with. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationSchool>? Schools {
            get { return BackingStore?.Get<List<EducationSchool>?>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#nullable restore
#else
        public List<EducationSchool> Schools {
            get { return BackingStore?.Get<List<EducationSchool>>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#endif
        /// <summary>All teachers in the class. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationUser>? Teachers {
            get { return BackingStore?.Get<List<EducationUser>?>("teachers"); }
            set { BackingStore?.Set("teachers", value); }
        }
#nullable restore
#else
        public List<EducationUser> Teachers {
            get { return BackingStore?.Get<List<EducationUser>>("teachers"); }
            set { BackingStore?.Set("teachers", value); }
        }
#endif
        /// <summary>Term for the class.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationTerm? Term {
            get { return BackingStore?.Get<EducationTerm?>("term"); }
            set { BackingStore?.Set("term", value); }
        }
#nullable restore
#else
        public EducationTerm Term {
            get { return BackingStore?.Get<EducationTerm>("term"); }
            set { BackingStore?.Set("term", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationClass CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationClass();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentCategories", n => { AssignmentCategories = n.GetCollectionOfObjectValues<EducationCategory>(EducationCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentDefaults", n => { AssignmentDefaults = n.GetObjectValue<EducationAssignmentDefaults>(EducationAssignmentDefaults.CreateFromDiscriminatorValue); } },
                {"assignmentSettings", n => { AssignmentSettings = n.GetObjectValue<EducationAssignmentSettings>(EducationAssignmentSettings.CreateFromDiscriminatorValue); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EducationAssignment>(EducationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classCode", n => { ClassCode = n.GetStringValue(); } },
                {"course", n => { Course = n.GetObjectValue<EducationCourse>(EducationCourse.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"externalName", n => { ExternalName = n.GetStringValue(); } },
                {"externalSource", n => { ExternalSource = n.GetEnumValue<EducationExternalSource>(); } },
                {"externalSourceDetail", n => { ExternalSourceDetail = n.GetStringValue(); } },
                {"grade", n => { Grade = n.GetStringValue(); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"modules", n => { Modules = n.GetCollectionOfObjectValues<EducationModule>(EducationModule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schools", n => { Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue)?.ToList(); } },
                {"teachers", n => { Teachers = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"term", n => { Term = n.GetObjectValue<EducationTerm>(EducationTerm.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationCategory>("assignmentCategories", AssignmentCategories);
            writer.WriteObjectValue<EducationAssignmentDefaults>("assignmentDefaults", AssignmentDefaults);
            writer.WriteCollectionOfObjectValues<EducationAssignment>("assignments", Assignments);
            writer.WriteObjectValue<EducationAssignmentSettings>("assignmentSettings", AssignmentSettings);
            writer.WriteStringValue("classCode", ClassCode);
            writer.WriteObjectValue<EducationCourse>("course", Course);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalName", ExternalName);
            writer.WriteEnumValue<EducationExternalSource>("externalSource", ExternalSource);
            writer.WriteStringValue("externalSourceDetail", ExternalSourceDetail);
            writer.WriteStringValue("grade", Grade);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<EducationUser>("members", Members);
            writer.WriteCollectionOfObjectValues<EducationModule>("modules", Modules);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<EducationUser>("teachers", Teachers);
            writer.WriteObjectValue<EducationTerm>("term", Term);
        }
    }
}
