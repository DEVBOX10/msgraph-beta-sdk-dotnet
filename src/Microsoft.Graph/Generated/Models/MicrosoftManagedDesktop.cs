using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftManagedDesktop : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>The name of the Microsoft Managed Desktop profile that the Windows 365 Cloud PC is associated with.</summary>
        public string Profile {
            get { return BackingStore?.Get<string>("profile"); }
            set { BackingStore?.Set("profile", value); }
        }
        /// <summary>Indicates whether the provisioning policy enables Microsoft Managed Desktop. It indicates the type of plan under which the device is managed if the provisioning policy is enabled. Possible values are: notManaged, premiumManaged, standardManaged, starterManaged, unknownFutureValue.</summary>
        public MicrosoftManagedDesktopType? Type {
            get { return BackingStore?.Get<MicrosoftManagedDesktopType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftManagedDesktop and sets the default values.
        /// </summary>
        public MicrosoftManagedDesktop() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.microsoftManagedDesktop";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MicrosoftManagedDesktop CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftManagedDesktop();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"profile", n => { Profile = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<MicrosoftManagedDesktopType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("profile", Profile);
            writer.WriteEnumValue<MicrosoftManagedDesktopType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
