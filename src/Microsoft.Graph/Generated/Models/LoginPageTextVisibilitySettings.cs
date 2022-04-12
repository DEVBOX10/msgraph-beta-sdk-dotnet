using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class LoginPageTextVisibilitySettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hideAccountResetCredentials property</summary>
        public bool? HideAccountResetCredentials { get; set; }
        /// <summary>Option to hide the self-service password reset (SSPR) &apos;Can&apos;t access your account?&apos; hyperlink on the sign-in form.</summary>
        public bool? HideCannotAccessYourAccount { get; set; }
        /// <summary>Option to hide the self-service password reset (SSPR) &apos;Forgot my password&apos; hyperlink on the sign-in form.</summary>
        public bool? HideForgotMyPassword { get; set; }
        /// <summary>Option to hide the &apos;Privacy &amp; Cookies&apos; hyperlink in the footer.</summary>
        public bool? HidePrivacyAndCookies { get; set; }
        /// <summary>Option to hide the self-service password reset (SSPR) &apos;reset it now&apos; hyperlink on the sign-in form.</summary>
        public bool? HideResetItNow { get; set; }
        /// <summary>Option to hide the &apos;Terms of Use&apos; hyperlink in the footer.</summary>
        public bool? HideTermsOfUse { get; set; }
        /// <summary>
        /// Instantiates a new loginPageTextVisibilitySettings and sets the default values.
        /// </summary>
        public LoginPageTextVisibilitySettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LoginPageTextVisibilitySettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LoginPageTextVisibilitySettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hideAccountResetCredentials", n => { HideAccountResetCredentials = n.GetBoolValue(); } },
                {"hideCannotAccessYourAccount", n => { HideCannotAccessYourAccount = n.GetBoolValue(); } },
                {"hideForgotMyPassword", n => { HideForgotMyPassword = n.GetBoolValue(); } },
                {"hidePrivacyAndCookies", n => { HidePrivacyAndCookies = n.GetBoolValue(); } },
                {"hideResetItNow", n => { HideResetItNow = n.GetBoolValue(); } },
                {"hideTermsOfUse", n => { HideTermsOfUse = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hideAccountResetCredentials", HideAccountResetCredentials);
            writer.WriteBoolValue("hideCannotAccessYourAccount", HideCannotAccessYourAccount);
            writer.WriteBoolValue("hideForgotMyPassword", HideForgotMyPassword);
            writer.WriteBoolValue("hidePrivacyAndCookies", HidePrivacyAndCookies);
            writer.WriteBoolValue("hideResetItNow", HideResetItNow);
            writer.WriteBoolValue("hideTermsOfUse", HideTermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
