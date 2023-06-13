using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SignInPreferences : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether the credential preferences of the system are enabled.</summary>
        public bool? IsSystemPreferredAuthenticationMethodEnabled {
            get { return BackingStore?.Get<bool?>("isSystemPreferredAuthenticationMethodEnabled"); }
            set { BackingStore?.Set("isSystemPreferredAuthenticationMethodEnabled", value); }
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
        /// <summary>The default second-factor method used by the user when signing in. If a user is enabled for system-preferred authentication, then this value is ignored except for a few scenarios where a user is authenticating via NPS extension or ADFS adapter. Possible values are push, oath, voiceMobile, voiceAlternateMobile, voiceOffice, sms, and unknownFutureValue</summary>
        public UserDefaultAuthenticationMethodType? UserPreferredMethodForSecondaryAuthentication {
            get { return BackingStore?.Get<UserDefaultAuthenticationMethodType?>("userPreferredMethodForSecondaryAuthentication"); }
            set { BackingStore?.Set("userPreferredMethodForSecondaryAuthentication", value); }
        }
        /// <summary>
        /// Instantiates a new signInPreferences and sets the default values.
        /// </summary>
        public SignInPreferences() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SignInPreferences CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignInPreferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isSystemPreferredAuthenticationMethodEnabled", n => { IsSystemPreferredAuthenticationMethodEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userPreferredMethodForSecondaryAuthentication", n => { UserPreferredMethodForSecondaryAuthentication = n.GetEnumValue<UserDefaultAuthenticationMethodType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isSystemPreferredAuthenticationMethodEnabled", IsSystemPreferredAuthenticationMethodEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<UserDefaultAuthenticationMethodType>("userPreferredMethodForSecondaryAuthentication", UserPreferredMethodForSecondaryAuthentication);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
