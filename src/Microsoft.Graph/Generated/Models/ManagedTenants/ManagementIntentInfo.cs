using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementIntentInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name for the management intent. Optional. Read-only.</summary>
        public string ManagementIntentDisplayName {
            get { return BackingStore?.Get<string>("managementIntentDisplayName"); }
            set { BackingStore?.Set("managementIntentDisplayName", value); }
        }
        /// <summary>The identifier for the management intent. Required. Read-only.</summary>
        public string ManagementIntentId {
            get { return BackingStore?.Get<string>("managementIntentId"); }
            set { BackingStore?.Set("managementIntentId", value); }
        }
        /// <summary>The collection of management template information associated with the management intent. Optional. Read-only.</summary>
        public List<ManagementTemplateDetailedInfo> ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplateDetailedInfo>>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new managementIntentInfo and sets the default values.
        /// </summary>
        public ManagementIntentInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedTenants.managementIntentInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagementIntentInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementIntentInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"managementIntentDisplayName", n => { ManagementIntentDisplayName = n.GetStringValue(); } },
                {"managementIntentId", n => { ManagementIntentId = n.GetStringValue(); } },
                {"managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplateDetailedInfo>(ManagementTemplateDetailedInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementIntentDisplayName", ManagementIntentDisplayName);
            writer.WriteStringValue("managementIntentId", ManagementIntentId);
            writer.WriteCollectionOfObjectValues<ManagementTemplateDetailedInfo>("managementTemplates", ManagementTemplates);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
