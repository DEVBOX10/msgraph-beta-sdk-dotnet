using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.MicrosoftGraphOverrideComplianceState {
    public class OverrideComplianceStatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Administrator configured device compliance state Enum</summary>
        public AdministratorConfiguredDeviceComplianceState? ComplianceState {
            get { return BackingStore?.Get<AdministratorConfiguredDeviceComplianceState?>("complianceState"); }
            set { BackingStore?.Set("complianceState", value); }
        }
        /// <summary>The remediationUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationUrl {
            get { return BackingStore?.Get<string?>("remediationUrl"); }
            set { BackingStore?.Set("remediationUrl", value); }
        }
#nullable restore
#else
        public string RemediationUrl {
            get { return BackingStore?.Get<string>("remediationUrl"); }
            set { BackingStore?.Set("remediationUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new overrideComplianceStatePostRequestBody and sets the default values.
        /// </summary>
        public OverrideComplianceStatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OverrideComplianceStatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OverrideComplianceStatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"complianceState", n => { ComplianceState = n.GetEnumValue<AdministratorConfiguredDeviceComplianceState>(); } },
                {"remediationUrl", n => { RemediationUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdministratorConfiguredDeviceComplianceState>("complianceState", ComplianceState);
            writer.WriteStringValue("remediationUrl", RemediationUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
