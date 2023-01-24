using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResource : Entity, IParsable {
        /// <summary>Contains the environment information for the resource. This can be set using either the @odata.bind annotation or the environment&apos;s originId.Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment? AccessPackageResourceEnvironment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment?>("accessPackageResourceEnvironment"); }
            set { BackingStore?.Set("accessPackageResourceEnvironment", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment AccessPackageResourceEnvironment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>("accessPackageResourceEnvironment"); }
            set { BackingStore?.Set("accessPackageResourceEnvironment", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceRole>? AccessPackageResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>?>("accessPackageResourceRoles"); }
            set { BackingStore?.Set("accessPackageResourceRoles", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceRole> AccessPackageResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>>("accessPackageResourceRoles"); }
            set { BackingStore?.Set("accessPackageResourceRoles", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceScope>? AccessPackageResourceScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>?>("accessPackageResourceScopes"); }
            set { BackingStore?.Set("accessPackageResourceScopes", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceScope> AccessPackageResourceScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>>("accessPackageResourceScopes"); }
            set { BackingStore?.Set("accessPackageResourceScopes", value); }
        }
#endif
        /// <summary>The name of the user or application that first added this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddedBy {
            get { return BackingStore?.Get<string?>("addedBy"); }
            set { BackingStore?.Set("addedBy", value); }
        }
#nullable restore
#else
        public string AddedBy {
            get { return BackingStore?.Get<string>("addedBy"); }
            set { BackingStore?.Set("addedBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? AddedOn {
            get { return BackingStore?.Get<DateTimeOffset?>("addedOn"); }
            set { BackingStore?.Set("addedOn", value); }
        }
        /// <summary>Contains information about the attributes to be collected from the requestor and sent to the resource application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceAttribute>? Attributes {
            get { return BackingStore?.Get<List<AccessPackageResourceAttribute>?>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceAttribute> Attributes {
            get { return BackingStore?.Get<List<AccessPackageResourceAttribute>>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#endif
        /// <summary>A description for the resource.</summary>
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
        /// <summary>The display name of the resource, such as the application name, group name or site name.</summary>
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
        /// <summary>True if the resource is not yet available for assignment. Read-only.</summary>
        public bool? IsPendingOnboarding {
            get { return BackingStore?.Get<bool?>("isPendingOnboarding"); }
            set { BackingStore?.Set("isPendingOnboarding", value); }
        }
        /// <summary>The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginId {
            get { return BackingStore?.Get<string?>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
#nullable restore
#else
        public string OriginId {
            get { return BackingStore?.Get<string>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
#endif
        /// <summary>The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginSystem {
            get { return BackingStore?.Get<string?>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
#nullable restore
#else
        public string OriginSystem {
            get { return BackingStore?.Get<string>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
#endif
        /// <summary>The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType {
            get { return BackingStore?.Get<string?>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#nullable restore
#else
        public string ResourceType {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#endif
        /// <summary>A unique resource locator for the resource, such as the URL for signing a user into an application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResourceEnvironment", n => { AccessPackageResourceEnvironment = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>(Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceRoles", n => { AccessPackageResourceRoles = n.GetCollectionOfObjectValues<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageResourceScopes", n => { AccessPackageResourceScopes = n.GetCollectionOfObjectValues<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"addedBy", n => { AddedBy = n.GetStringValue(); } },
                {"addedOn", n => { AddedOn = n.GetDateTimeOffsetValue(); } },
                {"attributes", n => { Attributes = n.GetCollectionOfObjectValues<AccessPackageResourceAttribute>(AccessPackageResourceAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isPendingOnboarding", n => { IsPendingOnboarding = n.GetBoolValue(); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
                {"resourceType", n => { ResourceType = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResourceEnvironment>("accessPackageResourceEnvironment", AccessPackageResourceEnvironment);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRole>("accessPackageResourceRoles", AccessPackageResourceRoles);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceScope>("accessPackageResourceScopes", AccessPackageResourceScopes);
            writer.WriteStringValue("addedBy", AddedBy);
            writer.WriteDateTimeOffsetValue("addedOn", AddedOn);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceAttribute>("attributes", Attributes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isPendingOnboarding", IsPendingOnboarding);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteStringValue("url", Url);
        }
    }
}
