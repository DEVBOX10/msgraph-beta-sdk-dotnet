using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkSoftwareUpdateStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The available software version to update.</summary>
        public string AvailableVersion {
            get { return BackingStore?.Get<string>("availableVersion"); }
            set { BackingStore?.Set("availableVersion", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The current software version.</summary>
        public string CurrentVersion {
            get { return BackingStore?.Get<string>("currentVersion"); }
            set { BackingStore?.Set("currentVersion", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The update status of the software. The possible values are: unknown, latest, updateAvailable, unknownFutureValue.</summary>
        public TeamworkSoftwareFreshness? SoftwareFreshness {
            get { return BackingStore?.Get<TeamworkSoftwareFreshness?>("softwareFreshness"); }
            set { BackingStore?.Set("softwareFreshness", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkSoftwareUpdateStatus and sets the default values.
        /// </summary>
        public TeamworkSoftwareUpdateStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkSoftwareUpdateStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkSoftwareUpdateStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSoftwareUpdateStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availableVersion", n => { AvailableVersion = n.GetStringValue(); } },
                {"currentVersion", n => { CurrentVersion = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"softwareFreshness", n => { SoftwareFreshness = n.GetEnumValue<TeamworkSoftwareFreshness>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availableVersion", AvailableVersion);
            writer.WriteStringValue("currentVersion", CurrentVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TeamworkSoftwareFreshness>("softwareFreshness", SoftwareFreshness);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
