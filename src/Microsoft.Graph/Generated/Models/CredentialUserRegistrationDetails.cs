using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CredentialUserRegistrationDetails : Entity, IParsable {
        /// <summary>Represents the authentication method that the user has registered. Possible values are: email, mobilePhone, officePhone,  securityQuestion (only used for self-service password reset), appNotification,  appCode, alternateMobilePhone (supported only in registration),  fido,  appPassword,  unknownFutureValue.</summary>
        public List<RegistrationAuthMethod?> AuthMethods { get; set; }
        /// <summary>Indicates whether the user is ready to perform self-service password reset or MFA.</summary>
        public bool? IsCapable { get; set; }
        /// <summary>Indicates whether the user enabled to perform self-service password reset.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Indicates whether the user is registered for MFA.</summary>
        public bool? IsMfaRegistered { get; set; }
        /// <summary>Indicates whether the user has registered any authentication methods for self-service password reset.</summary>
        public bool? IsRegistered { get; set; }
        /// <summary>Provides the user name of the corresponding user.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Provides the user principal name of the corresponding user.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CredentialUserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authMethods", n => { AuthMethods = n.GetCollectionOfEnumValues<RegistrationAuthMethod>().ToList(); } },
                {"isCapable", n => { IsCapable = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isRegistered", n => { IsRegistered = n.GetBoolValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<RegistrationAuthMethod>("authMethods", AuthMethods);
            writer.WriteBoolValue("isCapable", IsCapable);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isRegistered", IsRegistered);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
