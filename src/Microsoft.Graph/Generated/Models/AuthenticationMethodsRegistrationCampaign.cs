using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationMethodsRegistrationCampaign : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Users and groups of users that are excluded from being prompted to set up the authentication method.</summary>
        public List<ExcludeTarget> ExcludeTargets {
            get { return BackingStore?.Get<List<ExcludeTarget>>("excludeTargets"); }
            set { BackingStore?.Set("excludeTargets", value); }
        }
        /// <summary>Users and groups of users that are prompted to set up the authentication method.</summary>
        public List<AuthenticationMethodsRegistrationCampaignIncludeTarget> IncludeTargets {
            get { return BackingStore?.Get<List<AuthenticationMethodsRegistrationCampaignIncludeTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Specifies the number of days that the user sees a prompt again if they select &apos;Not now&apos; and snoozes the prompt. Minimum 0 days. Maximum: 14 days. If the value is &apos;0&apos; – The user is prompted during every MFA attempt.</summary>
        public int? SnoozeDurationInDays {
            get { return BackingStore?.Get<int?>("snoozeDurationInDays"); }
            set { BackingStore?.Set("snoozeDurationInDays", value); }
        }
        /// <summary>The state property</summary>
        public AdvancedConfigState? State {
            get { return BackingStore?.Get<AdvancedConfigState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new authenticationMethodsRegistrationCampaign and sets the default values.
        /// </summary>
        public AuthenticationMethodsRegistrationCampaign() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.authenticationMethodsRegistrationCampaign";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuthenticationMethodsRegistrationCampaign CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodsRegistrationCampaign();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeTargets", n => { ExcludeTargets = n.GetCollectionOfObjectValues<ExcludeTarget>(ExcludeTarget.CreateFromDiscriminatorValue).ToList(); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodsRegistrationCampaignIncludeTarget>(AuthenticationMethodsRegistrationCampaignIncludeTarget.CreateFromDiscriminatorValue).ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"snoozeDurationInDays", n => { SnoozeDurationInDays = n.GetIntValue(); } },
                {"state", n => { State = n.GetEnumValue<AdvancedConfigState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ExcludeTarget>("excludeTargets", ExcludeTargets);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodsRegistrationCampaignIncludeTarget>("includeTargets", IncludeTargets);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("snoozeDurationInDays", SnoozeDurationInDays);
            writer.WriteEnumValue<AdvancedConfigState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
