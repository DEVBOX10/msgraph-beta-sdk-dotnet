using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.DeviceCustomAttributeShellScripts.Item.Assign {
    /// <summary>Provides operations to call the assign method.</summary>
    public class AssignRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceManagementScriptAssignments property</summary>
        public List<DeviceManagementScriptAssignment> DeviceManagementScriptAssignments { get; set; }
        /// <summary>The deviceManagementScriptGroupAssignments property</summary>
        public List<DeviceManagementScriptGroupAssignment> DeviceManagementScriptGroupAssignments { get; set; }
        /// <summary>
        /// Instantiates a new assignRequestBody and sets the default values.
        /// </summary>
        public AssignRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceManagementScriptAssignments", (o,n) => { (o as AssignRequestBody).DeviceManagementScriptAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>(DeviceManagementScriptAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceManagementScriptGroupAssignments", (o,n) => { (o as AssignRequestBody).DeviceManagementScriptGroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>(DeviceManagementScriptGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptAssignment>("deviceManagementScriptAssignments", DeviceManagementScriptAssignments);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>("deviceManagementScriptGroupAssignments", DeviceManagementScriptGroupAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
