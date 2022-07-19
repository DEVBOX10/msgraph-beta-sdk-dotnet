using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class OfficeClientConfigurationAssignment : Entity, IParsable {
        /// <summary>The target assignment defined by the admin.</summary>
        public OfficeConfigurationAssignmentTarget Target {
            get { return BackingStore?.Get<OfficeConfigurationAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Instantiates a new officeClientConfigurationAssignment and sets the default values.
        /// </summary>
        public OfficeClientConfigurationAssignment() : base() {
            OdataType = "#microsoft.graph.officeClientConfigurationAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OfficeClientConfigurationAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeClientConfigurationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"target", n => { Target = n.GetObjectValue<OfficeConfigurationAssignmentTarget>(OfficeConfigurationAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OfficeConfigurationAssignmentTarget>("target", Target);
        }
    }
}
