using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResourceAttribute : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Information about how to set the attribute, currently a accessPackageUserDirectoryAttributeStore object type.</summary>
        public AccessPackageResourceAttributeDestination AttributeDestination {
            get { return BackingStore?.Get<AccessPackageResourceAttributeDestination>("attributeDestination"); }
            set { BackingStore?.Set("attributeDestination", value); }
        }
        /// <summary>The name of the attribute in the end system. If the destination is accessPackageUserDirectoryAttributeStore, then a user property such as jobTitle or a directory schema extension for the user object type, such as extension_2b676109c7c74ae2b41549205f1947ed_personalTitle.</summary>
        public string AttributeName {
            get { return BackingStore?.Get<string>("attributeName"); }
            set { BackingStore?.Set("attributeName", value); }
        }
        /// <summary>Information about how to populate the attribute value when an accessPackageAssignmentRequest is being fulfilled, currently a accessPackageResourceAttributeQuestion object type.</summary>
        public AccessPackageResourceAttributeSource AttributeSource {
            get { return BackingStore?.Get<AccessPackageResourceAttributeSource>("attributeSource"); }
            set { BackingStore?.Set("attributeSource", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Unique identifier for the attribute on the access package resource. Read-only.</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>Specifies whether or not an existing attribute value can be edited by the requester.</summary>
        public bool? IsEditable {
            get { return BackingStore?.Get<bool?>("isEditable"); }
            set { BackingStore?.Set("isEditable", value); }
        }
        /// <summary>Specifies whether the attribute will remain in the end system after an assignment ends.</summary>
        public bool? IsPersistedOnAssignmentRemoval {
            get { return BackingStore?.Get<bool?>("isPersistedOnAssignmentRemoval"); }
            set { BackingStore?.Set("isPersistedOnAssignmentRemoval", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageResourceAttribute and sets the default values.
        /// </summary>
        public AccessPackageResourceAttribute() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.accessPackageResourceAttribute";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageResourceAttribute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceAttribute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attributeDestination", n => { AttributeDestination = n.GetObjectValue<AccessPackageResourceAttributeDestination>(AccessPackageResourceAttributeDestination.CreateFromDiscriminatorValue); } },
                {"attributeName", n => { AttributeName = n.GetStringValue(); } },
                {"attributeSource", n => { AttributeSource = n.GetObjectValue<AccessPackageResourceAttributeSource>(AccessPackageResourceAttributeSource.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isEditable", n => { IsEditable = n.GetBoolValue(); } },
                {"isPersistedOnAssignmentRemoval", n => { IsPersistedOnAssignmentRemoval = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AccessPackageResourceAttributeDestination>("attributeDestination", AttributeDestination);
            writer.WriteStringValue("attributeName", AttributeName);
            writer.WriteObjectValue<AccessPackageResourceAttributeSource>("attributeSource", AttributeSource);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEditable", IsEditable);
            writer.WriteBoolValue("isPersistedOnAssignmentRemoval", IsPersistedOnAssignmentRemoval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
