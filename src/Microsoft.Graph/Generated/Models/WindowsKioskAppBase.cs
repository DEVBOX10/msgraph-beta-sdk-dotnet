using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The base class for a type of apps</summary>
    public class WindowsKioskAppBase : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The type of Windows kiosk app.</summary>
        public WindowsKioskAppType? AppType {
            get { return BackingStore?.Get<WindowsKioskAppType?>("appType"); }
            set { BackingStore?.Set("appType", value); }
        }
        /// <summary>Allow the app to be auto-launched in multi-app kiosk mode</summary>
        public bool? AutoLaunch {
            get { return BackingStore?.Get<bool?>("autoLaunch"); }
            set { BackingStore?.Set("autoLaunch", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the friendly name of an app</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The tile size of Windows app in the start layout.</summary>
        public WindowsAppStartLayoutTileSize? StartLayoutTileSize {
            get { return BackingStore?.Get<WindowsAppStartLayoutTileSize?>("startLayoutTileSize"); }
            set { BackingStore?.Set("startLayoutTileSize", value); }
        }
        /// <summary>
        /// Instantiates a new windowsKioskAppBase and sets the default values.
        /// </summary>
        public WindowsKioskAppBase() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.windowsKioskAppBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsKioskAppBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsKioskDesktopApp" => new WindowsKioskDesktopApp(),
                "#microsoft.graph.windowsKioskUWPApp" => new WindowsKioskUWPApp(),
                "#microsoft.graph.windowsKioskWin32App" => new WindowsKioskWin32App(),
                _ => new WindowsKioskAppBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appType", n => { AppType = n.GetEnumValue<WindowsKioskAppType>(); } },
                {"autoLaunch", n => { AutoLaunch = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startLayoutTileSize", n => { StartLayoutTileSize = n.GetEnumValue<WindowsAppStartLayoutTileSize>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WindowsKioskAppType>("appType", AppType);
            writer.WriteBoolValue("autoLaunch", AutoLaunch);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<WindowsAppStartLayoutTileSize>("startLayoutTileSize", StartLayoutTileSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
