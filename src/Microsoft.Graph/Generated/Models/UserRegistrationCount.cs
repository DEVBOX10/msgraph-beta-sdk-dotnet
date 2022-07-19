using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserRegistrationCount : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>Provides the registration count for your tenant.</summary>
        public long? RegistrationCount {
            get { return BackingStore?.Get<long?>("registrationCount"); }
            set { BackingStore?.Set("registrationCount", value); }
        }
        /// <summary>The registrationStatus property</summary>
        public RegistrationStatusType? RegistrationStatus {
            get { return BackingStore?.Get<RegistrationStatusType?>("registrationStatus"); }
            set { BackingStore?.Set("registrationStatus", value); }
        }
        /// <summary>
        /// Instantiates a new userRegistrationCount and sets the default values.
        /// </summary>
        public UserRegistrationCount() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.userRegistrationCount";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserRegistrationCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"registrationCount", n => { RegistrationCount = n.GetLongValue(); } },
                {"registrationStatus", n => { RegistrationStatus = n.GetEnumValue<RegistrationStatusType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("registrationCount", RegistrationCount);
            writer.WriteEnumValue<RegistrationStatusType>("registrationStatus", RegistrationStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
