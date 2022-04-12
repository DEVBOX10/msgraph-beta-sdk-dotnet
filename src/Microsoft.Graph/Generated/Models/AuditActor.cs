using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the properties for Audit Actor.</summary>
    public class AuditActor : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the Application.</summary>
        public string ApplicationDisplayName { get; set; }
        /// <summary>AAD Application Id.</summary>
        public string ApplicationId { get; set; }
        /// <summary>IPAddress.</summary>
        public string IpAddress { get; set; }
        /// <summary>Remote Tenant Id</summary>
        public string RemoteTenantId { get; set; }
        /// <summary>Remote User Id</summary>
        public string RemoteUserId { get; set; }
        /// <summary>Service Principal Name (SPN).</summary>
        public string ServicePrincipalName { get; set; }
        /// <summary>Actor Type.</summary>
        public string Type { get; set; }
        /// <summary>User Id.</summary>
        public string UserId { get; set; }
        /// <summary>List of user permissions when the audit was performed.</summary>
        public List<string> UserPermissions { get; set; }
        /// <summary>User Principal Name (UPN).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>List of user scope tags when the audit was performed.</summary>
        public List<RoleScopeTagInfo> UserRoleScopeTags { get; set; }
        /// <summary>
        /// Instantiates a new auditActor and sets the default values.
        /// </summary>
        public AuditActor() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuditActor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationDisplayName", n => { ApplicationDisplayName = n.GetStringValue(); } },
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"remoteTenantId", n => { RemoteTenantId = n.GetStringValue(); } },
                {"remoteUserId", n => { RemoteUserId = n.GetStringValue(); } },
                {"servicePrincipalName", n => { ServicePrincipalName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPermissions", n => { UserPermissions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userRoleScopeTags", n => { UserRoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTagInfo>(RoleScopeTagInfo.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationDisplayName", ApplicationDisplayName);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("remoteTenantId", RemoteTenantId);
            writer.WriteStringValue("remoteUserId", RemoteUserId);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userId", UserId);
            writer.WriteCollectionOfPrimitiveValues<string>("userPermissions", UserPermissions);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<RoleScopeTagInfo>("userRoleScopeTags", UserRoleScopeTags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
