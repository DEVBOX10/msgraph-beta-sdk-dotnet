// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRbacResourceAction : Entity, IParsable {
        /// <summary>HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionVerb {
            get { return BackingStore?.Get<string?>("actionVerb"); }
            set { BackingStore?.Set("actionVerb", value); }
        }
#nullable restore
#else
        public string ActionVerb {
            get { return BackingStore?.Get<string>("actionVerb"); }
            set { BackingStore?.Set("actionVerb", value); }
        }
#endif
        /// <summary>The authenticationContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationContextClassReference? AuthenticationContext {
            get { return BackingStore?.Get<AuthenticationContextClassReference?>("authenticationContext"); }
            set { BackingStore?.Set("authenticationContext", value); }
        }
#nullable restore
#else
        public AuthenticationContextClassReference AuthenticationContext {
            get { return BackingStore?.Get<AuthenticationContextClassReference>("authenticationContext"); }
            set { BackingStore?.Set("authenticationContext", value); }
        }
#endif
        /// <summary>The authenticationContextId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationContextId {
            get { return BackingStore?.Get<string?>("authenticationContextId"); }
            set { BackingStore?.Set("authenticationContextId", value); }
        }
#nullable restore
#else
        public string AuthenticationContextId {
            get { return BackingStore?.Get<string>("authenticationContextId"); }
            set { BackingStore?.Set("authenticationContextId", value); }
        }
#endif
        /// <summary>Description for the action. Supports $filter (eq).</summary>
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
        /// <summary>The isAuthenticationContextSettable property</summary>
        public bool? IsAuthenticationContextSettable {
            get { return BackingStore?.Get<bool?>("isAuthenticationContextSettable"); }
            set { BackingStore?.Set("isAuthenticationContextSettable", value); }
        }
        /// <summary>Flag indicating if the action is a sensitive resource action. Applies only for actions in the microsoft.directory resource namespace. Read-only. Supports $filter (eq).</summary>
        public bool? IsPrivileged {
            get { return BackingStore?.Get<bool?>("isPrivileged"); }
            set { BackingStore?.Set("isPrivileged", value); }
        }
        /// <summary>Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The resourceScope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRbacResourceScope? ResourceScope {
            get { return BackingStore?.Get<UnifiedRbacResourceScope?>("resourceScope"); }
            set { BackingStore?.Set("resourceScope", value); }
        }
#nullable restore
#else
        public UnifiedRbacResourceScope ResourceScope {
            get { return BackingStore?.Get<UnifiedRbacResourceScope>("resourceScope"); }
            set { BackingStore?.Set("resourceScope", value); }
        }
#endif
        /// <summary>Not implemented.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceScopeId {
            get { return BackingStore?.Get<string?>("resourceScopeId"); }
            set { BackingStore?.Set("resourceScopeId", value); }
        }
#nullable restore
#else
        public string ResourceScopeId {
            get { return BackingStore?.Get<string>("resourceScopeId"); }
            set { BackingStore?.Set("resourceScopeId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRbacResourceAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRbacResourceAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionVerb", n => { ActionVerb = n.GetStringValue(); } },
                {"authenticationContext", n => { AuthenticationContext = n.GetObjectValue<AuthenticationContextClassReference>(AuthenticationContextClassReference.CreateFromDiscriminatorValue); } },
                {"authenticationContextId", n => { AuthenticationContextId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isAuthenticationContextSettable", n => { IsAuthenticationContextSettable = n.GetBoolValue(); } },
                {"isPrivileged", n => { IsPrivileged = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"resourceScope", n => { ResourceScope = n.GetObjectValue<UnifiedRbacResourceScope>(UnifiedRbacResourceScope.CreateFromDiscriminatorValue); } },
                {"resourceScopeId", n => { ResourceScopeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionVerb", ActionVerb);
            writer.WriteObjectValue<AuthenticationContextClassReference>("authenticationContext", AuthenticationContext);
            writer.WriteStringValue("authenticationContextId", AuthenticationContextId);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isAuthenticationContextSettable", IsAuthenticationContextSettable);
            writer.WriteBoolValue("isPrivileged", IsPrivileged);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<UnifiedRbacResourceScope>("resourceScope", ResourceScope);
            writer.WriteStringValue("resourceScopeId", ResourceScopeId);
        }
    }
}
