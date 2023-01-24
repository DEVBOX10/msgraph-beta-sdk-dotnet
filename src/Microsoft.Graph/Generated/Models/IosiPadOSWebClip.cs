using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosiPadOSWebClip : MobileApp, IParsable {
        /// <summary>The web app URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUrl {
            get { return BackingStore?.Get<string?>("appUrl"); }
            set { BackingStore?.Set("appUrl", value); }
        }
#nullable restore
#else
        public string AppUrl {
            get { return BackingStore?.Get<string>("appUrl"); }
            set { BackingStore?.Set("appUrl", value); }
        }
#endif
        /// <summary>Whether or not to use managed browser. When true, the app will be required to be opened in an Intune-protected browser. When false, the app will not be required to be opened in an Intune-protected browser.</summary>
        public bool? UseManagedBrowser {
            get { return BackingStore?.Get<bool?>("useManagedBrowser"); }
            set { BackingStore?.Set("useManagedBrowser", value); }
        }
        /// <summary>
        /// Instantiates a new IosiPadOSWebClip and sets the default values.
        /// </summary>
        public IosiPadOSWebClip() : base() {
            OdataType = "#microsoft.graph.iosiPadOSWebClip";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosiPadOSWebClip CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosiPadOSWebClip();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appUrl", n => { AppUrl = n.GetStringValue(); } },
                {"useManagedBrowser", n => { UseManagedBrowser = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appUrl", AppUrl);
            writer.WriteBoolValue("useManagedBrowser", UseManagedBrowser);
        }
    }
}
