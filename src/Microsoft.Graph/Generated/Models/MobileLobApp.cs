using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileLobApp : MobileApp, IParsable {
        /// <summary>The internal committed content version.</summary>
        public string CommittedContentVersion {
            get { return BackingStore?.Get<string>("committedContentVersion"); }
            set { BackingStore?.Set("committedContentVersion", value); }
        }
        /// <summary>The list of content versions for this app.</summary>
        public List<MobileAppContent> ContentVersions {
            get { return BackingStore?.Get<List<MobileAppContent>>("contentVersions"); }
            set { BackingStore?.Set("contentVersions", value); }
        }
        /// <summary>The name of the main Lob application file.</summary>
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
        /// <summary>The total size, including all uploaded files.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>
        /// Instantiates a new MobileLobApp and sets the default values.
        /// </summary>
        public MobileLobApp() : base() {
            OdataType = "#microsoft.graph.mobileLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileLobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidLobApp" => new AndroidLobApp(),
                "#microsoft.graph.iosLobApp" => new IosLobApp(),
                "#microsoft.graph.macOSDmgApp" => new MacOSDmgApp(),
                "#microsoft.graph.macOSLobApp" => new MacOSLobApp(),
                "#microsoft.graph.win32LobApp" => new Win32LobApp(),
                "#microsoft.graph.windowsAppX" => new WindowsAppX(),
                "#microsoft.graph.windowsMobileMSI" => new WindowsMobileMSI(),
                "#microsoft.graph.windowsPhone81AppX" => new WindowsPhone81AppX(),
                "#microsoft.graph.windowsPhone81AppXBundle" => new WindowsPhone81AppXBundle(),
                "#microsoft.graph.windowsPhoneXAP" => new WindowsPhoneXAP(),
                "#microsoft.graph.windowsUniversalAppX" => new WindowsUniversalAppX(),
                _ => new MobileLobApp(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"committedContentVersion", n => { CommittedContentVersion = n.GetStringValue(); } },
                {"contentVersions", n => { ContentVersions = n.GetCollectionOfObjectValues<MobileAppContent>(MobileAppContent.CreateFromDiscriminatorValue).ToList(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("committedContentVersion", CommittedContentVersion);
            writer.WriteCollectionOfObjectValues<MobileAppContent>("contentVersions", ContentVersions);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteLongValue("size", Size);
        }
    }
}
