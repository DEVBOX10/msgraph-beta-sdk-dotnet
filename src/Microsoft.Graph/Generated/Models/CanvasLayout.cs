// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CanvasLayout : Entity, IParsable {
        /// <summary>Collection of horizontal sections on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HorizontalSection>? HorizontalSections {
            get { return BackingStore?.Get<List<HorizontalSection>?>("horizontalSections"); }
            set { BackingStore?.Set("horizontalSections", value); }
        }
#nullable restore
#else
        public List<HorizontalSection> HorizontalSections {
            get { return BackingStore?.Get<List<HorizontalSection>>("horizontalSections"); }
            set { BackingStore?.Set("horizontalSections", value); }
        }
#endif
        /// <summary>Vertical section on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.VerticalSection? VerticalSection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VerticalSection?>("verticalSection"); }
            set { BackingStore?.Set("verticalSection", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.VerticalSection VerticalSection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VerticalSection>("verticalSection"); }
            set { BackingStore?.Set("verticalSection", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CanvasLayout CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CanvasLayout();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"horizontalSections", n => { HorizontalSections = n.GetCollectionOfObjectValues<HorizontalSection>(HorizontalSection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"verticalSection", n => { VerticalSection = n.GetObjectValue<Microsoft.Graph.Beta.Models.VerticalSection>(Microsoft.Graph.Beta.Models.VerticalSection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<HorizontalSection>("horizontalSections", HorizontalSections);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.VerticalSection>("verticalSection", VerticalSection);
        }
    }
}
