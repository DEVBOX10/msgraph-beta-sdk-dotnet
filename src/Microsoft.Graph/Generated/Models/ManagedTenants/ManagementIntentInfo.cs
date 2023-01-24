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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementIntentDisplayName {
            get { return BackingStore?.Get<string?>("managementIntentDisplayName"); }
            set { BackingStore?.Set("managementIntentDisplayName", value); }
        }
#nullable restore
#else
        public string ManagementIntentDisplayName {
            get { return BackingStore?.Get<string>("managementIntentDisplayName"); }
            set { BackingStore?.Set("managementIntentDisplayName", value); }
        }
#endif
        /// <summary>The identifier for the management intent. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementIntentId {
            get { return BackingStore?.Get<string?>("managementIntentId"); }
            set { BackingStore?.Set("managementIntentId", value); }
        }
#nullable restore
#else
        public string ManagementIntentId {
            get { return BackingStore?.Get<string>("managementIntentId"); }
            set { BackingStore?.Set("managementIntentId", value); }
        }
#endif
        /// <summary>The collection of management template information associated with the management intent. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateDetailedInfo>? ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplateDetailedInfo>?>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateDetailedInfo> ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplateDetailedInfo>>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new managementIntentInfo and sets the default values.
        /// </summary>
        public ManagementIntentInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplateDetailedInfo>(ManagementTemplateDetailedInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
