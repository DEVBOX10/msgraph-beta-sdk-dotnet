// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// License summary of a given app in a token.
    /// </summary>
    public class VppTokenLicenseSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId {
            get { return BackingStore?.Get<string?>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#nullable restore
#else
        public string AppleId {
            get { return BackingStore?.Get<string>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#endif
        /// <summary>The number of VPP licenses available.</summary>
        public int? AvailableLicenseCount {
            get { return BackingStore?.Get<int?>("availableLicenseCount"); }
            set { BackingStore?.Set("availableLicenseCount", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The organization associated with the Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName {
            get { return BackingStore?.Get<string?>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#nullable restore
#else
        public string OrganizationName {
            get { return BackingStore?.Get<string>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#endif
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>Identifier of the VPP token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenId {
            get { return BackingStore?.Get<string?>("vppTokenId"); }
            set { BackingStore?.Set("vppTokenId", value); }
        }
#nullable restore
#else
        public string VppTokenId {
            get { return BackingStore?.Get<string>("vppTokenId"); }
            set { BackingStore?.Set("vppTokenId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new vppTokenLicenseSummary and sets the default values.
        /// </summary>
        public VppTokenLicenseSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VppTokenLicenseSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppTokenLicenseSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"availableLicenseCount", n => { AvailableLicenseCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteIntValue("availableLicenseCount", AvailableLicenseCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppTokenId", VppTokenId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
