using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// OMA Settings definition.
    /// </summary>
    public class OmaSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Indicates whether the value field is encrypted. This property is read-only.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>("isEncrypted"); }
            set { BackingStore?.Set("isEncrypted", value); }
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
        /// <summary>OMA.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OmaUri {
            get { return BackingStore?.Get<string?>("omaUri"); }
            set { BackingStore?.Set("omaUri", value); }
        }
#nullable restore
#else
        public string OmaUri {
            get { return BackingStore?.Get<string>("omaUri"); }
            set { BackingStore?.Set("omaUri", value); }
        }
#endif
        /// <summary>ReferenceId for looking up secret for decryption. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretReferenceValueId {
            get { return BackingStore?.Get<string?>("secretReferenceValueId"); }
            set { BackingStore?.Set("secretReferenceValueId", value); }
        }
#nullable restore
#else
        public string SecretReferenceValueId {
            get { return BackingStore?.Get<string>("secretReferenceValueId"); }
            set { BackingStore?.Set("secretReferenceValueId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new omaSetting and sets the default values.
        /// </summary>
        public OmaSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OmaSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.omaSettingBase64" => new OmaSettingBase64(),
                "#microsoft.graph.omaSettingBoolean" => new OmaSettingBoolean(),
                "#microsoft.graph.omaSettingDateTime" => new OmaSettingDateTime(),
                "#microsoft.graph.omaSettingFloatingPoint" => new OmaSettingFloatingPoint(),
                "#microsoft.graph.omaSettingInteger" => new OmaSettingInteger(),
                "#microsoft.graph.omaSettingString" => new OmaSettingString(),
                "#microsoft.graph.omaSettingStringXml" => new OmaSettingStringXml(),
                _ => new OmaSetting(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"omaUri", n => { OmaUri = n.GetStringValue(); } },
                {"secretReferenceValueId", n => { SecretReferenceValueId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("omaUri", OmaUri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
