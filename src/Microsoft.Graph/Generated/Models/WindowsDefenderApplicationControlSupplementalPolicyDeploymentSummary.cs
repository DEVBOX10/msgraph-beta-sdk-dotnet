using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.</summary>
        public int? DeployedDeviceCount {
            get { return BackingStore?.Get<int?>("deployedDeviceCount"); }
            set { BackingStore?.Set("deployedDeviceCount", value); }
        }
        /// <summary>Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.</summary>
        public int? FailedDeviceCount {
            get { return BackingStore?.Get<int?>("failedDeviceCount"); }
            set { BackingStore?.Set("failedDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new windowsDefenderApplicationControlSupplementalPolicyDeploymentSummary and sets the default values.
        /// </summary>
        public WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary() : base() {
            OdataType = "#microsoft.graph.windowsDefenderApplicationControlSupplementalPolicyDeploymentSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deployedDeviceCount", n => { DeployedDeviceCount = n.GetIntValue(); } },
                {"failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deployedDeviceCount", DeployedDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
        }
    }
}
