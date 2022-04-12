using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Base type for assignment targets.</summary>
    public class DeviceAndAppManagementAssignmentTarget : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Id of the filter for the target assignment.</summary>
        public string DeviceAndAppManagementAssignmentFilterId { get; set; }
        /// <summary>The type of filter of the target assignment i.e. Exclude or Include. Possible values are: none, include, exclude.</summary>
        public Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType? DeviceAndAppManagementAssignmentFilterType { get; set; }
        /// <summary>
        /// Instantiates a new deviceAndAppManagementAssignmentTarget and sets the default values.
        /// </summary>
        public DeviceAndAppManagementAssignmentTarget() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceAndAppManagementAssignmentTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAndAppManagementAssignmentTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceAndAppManagementAssignmentFilterId", n => { DeviceAndAppManagementAssignmentFilterId = n.GetStringValue(); } },
                {"deviceAndAppManagementAssignmentFilterType", n => { DeviceAndAppManagementAssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceAndAppManagementAssignmentFilterId", DeviceAndAppManagementAssignmentFilterId);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentFilterType>("deviceAndAppManagementAssignmentFilterType", DeviceAndAppManagementAssignmentFilterType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
