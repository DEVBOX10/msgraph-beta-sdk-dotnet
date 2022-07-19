using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserRegistrationFeatureSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Total number of users accounts, excluding those that are blocked</summary>
        public long? TotalUserCount {
            get { return BackingStore?.Get<long?>("totalUserCount"); }
            set { BackingStore?.Set("totalUserCount", value); }
        }
        /// <summary>Number of users registered or capable for Multi-Factor Authentication, Self-Service Password Reset and Passwordless Authentication.</summary>
        public List<UserRegistrationFeatureCount> UserRegistrationFeatureCounts {
            get { return BackingStore?.Get<List<UserRegistrationFeatureCount>>("userRegistrationFeatureCounts"); }
            set { BackingStore?.Set("userRegistrationFeatureCounts", value); }
        }
        /// <summary>User role type. Possible values are: all, privilegedAdmin, admin, user.</summary>
        public IncludedUserRoles? UserRoles {
            get { return BackingStore?.Get<IncludedUserRoles?>("userRoles"); }
            set { BackingStore?.Set("userRoles", value); }
        }
        /// <summary>User type. Possible values are: all, member, guest.</summary>
        public IncludedUserTypes? UserTypes {
            get { return BackingStore?.Get<IncludedUserTypes?>("userTypes"); }
            set { BackingStore?.Set("userTypes", value); }
        }
        /// <summary>
        /// Instantiates a new UserRegistrationFeatureSummary and sets the default values.
        /// </summary>
        public UserRegistrationFeatureSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.userRegistrationFeatureSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserRegistrationFeatureSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationFeatureSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationFeatureCounts", n => { UserRegistrationFeatureCounts = n.GetCollectionOfObjectValues<UserRegistrationFeatureCount>(UserRegistrationFeatureCount.CreateFromDiscriminatorValue).ToList(); } },
                {"userRoles", n => { UserRoles = n.GetEnumValue<IncludedUserRoles>(); } },
                {"userTypes", n => { UserTypes = n.GetEnumValue<IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationFeatureCount>("userRegistrationFeatureCounts", UserRegistrationFeatureCounts);
            writer.WriteEnumValue<IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
