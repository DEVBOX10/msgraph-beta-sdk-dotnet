using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties for Excluded Office365 Apps.
    /// </summary>
    public class ExcludedApps : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The value for if MS Office Access should be excluded or not.</summary>
        public bool? Access {
            get { return BackingStore?.Get<bool?>("access"); }
            set { BackingStore?.Set("access", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The value for if Microsoft Search as default should be excluded or not.</summary>
        public bool? Bing {
            get { return BackingStore?.Get<bool?>("bing"); }
            set { BackingStore?.Set("bing", value); }
        }
        /// <summary>The value for if MS Office Excel should be excluded or not.</summary>
        public bool? Excel {
            get { return BackingStore?.Get<bool?>("excel"); }
            set { BackingStore?.Set("excel", value); }
        }
        /// <summary>The value for if MS Office OneDrive for Business - Groove should be excluded or not.</summary>
        public bool? Groove {
            get { return BackingStore?.Get<bool?>("groove"); }
            set { BackingStore?.Set("groove", value); }
        }
        /// <summary>The value for if MS Office InfoPath should be excluded or not.</summary>
        public bool? InfoPath {
            get { return BackingStore?.Get<bool?>("infoPath"); }
            set { BackingStore?.Set("infoPath", value); }
        }
        /// <summary>The value for if MS Office Skype for Business - Lync should be excluded or not.</summary>
        public bool? Lync {
            get { return BackingStore?.Get<bool?>("lync"); }
            set { BackingStore?.Set("lync", value); }
        }
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
        /// <summary>The value for if MS Office OneDrive should be excluded or not.</summary>
        public bool? OneDrive {
            get { return BackingStore?.Get<bool?>("oneDrive"); }
            set { BackingStore?.Set("oneDrive", value); }
        }
        /// <summary>The value for if MS Office OneNote should be excluded or not.</summary>
        public bool? OneNote {
            get { return BackingStore?.Get<bool?>("oneNote"); }
            set { BackingStore?.Set("oneNote", value); }
        }
        /// <summary>The value for if MS Office Outlook should be excluded or not.</summary>
        public bool? Outlook {
            get { return BackingStore?.Get<bool?>("outlook"); }
            set { BackingStore?.Set("outlook", value); }
        }
        /// <summary>The value for if MS Office PowerPoint should be excluded or not.</summary>
        public bool? PowerPoint {
            get { return BackingStore?.Get<bool?>("powerPoint"); }
            set { BackingStore?.Set("powerPoint", value); }
        }
        /// <summary>The value for if MS Office Publisher should be excluded or not.</summary>
        public bool? Publisher {
            get { return BackingStore?.Get<bool?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
        /// <summary>The value for if MS Office SharePointDesigner should be excluded or not.</summary>
        public bool? SharePointDesigner {
            get { return BackingStore?.Get<bool?>("sharePointDesigner"); }
            set { BackingStore?.Set("sharePointDesigner", value); }
        }
        /// <summary>The value for if MS Office Teams should be excluded or not.</summary>
        public bool? Teams {
            get { return BackingStore?.Get<bool?>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
        /// <summary>The value for if MS Office Visio should be excluded or not.</summary>
        public bool? Visio {
            get { return BackingStore?.Get<bool?>("visio"); }
            set { BackingStore?.Set("visio", value); }
        }
        /// <summary>The value for if MS Office Word should be excluded or not.</summary>
        public bool? Word {
            get { return BackingStore?.Get<bool?>("word"); }
            set { BackingStore?.Set("word", value); }
        }
        /// <summary>
        /// Instantiates a new excludedApps and sets the default values.
        /// </summary>
        public ExcludedApps() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExcludedApps CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExcludedApps();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"access", n => { Access = n.GetBoolValue(); } },
                {"bing", n => { Bing = n.GetBoolValue(); } },
                {"excel", n => { Excel = n.GetBoolValue(); } },
                {"groove", n => { Groove = n.GetBoolValue(); } },
                {"infoPath", n => { InfoPath = n.GetBoolValue(); } },
                {"lync", n => { Lync = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"oneDrive", n => { OneDrive = n.GetBoolValue(); } },
                {"oneNote", n => { OneNote = n.GetBoolValue(); } },
                {"outlook", n => { Outlook = n.GetBoolValue(); } },
                {"powerPoint", n => { PowerPoint = n.GetBoolValue(); } },
                {"publisher", n => { Publisher = n.GetBoolValue(); } },
                {"sharePointDesigner", n => { SharePointDesigner = n.GetBoolValue(); } },
                {"teams", n => { Teams = n.GetBoolValue(); } },
                {"visio", n => { Visio = n.GetBoolValue(); } },
                {"word", n => { Word = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("access", Access);
            writer.WriteBoolValue("bing", Bing);
            writer.WriteBoolValue("excel", Excel);
            writer.WriteBoolValue("groove", Groove);
            writer.WriteBoolValue("infoPath", InfoPath);
            writer.WriteBoolValue("lync", Lync);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("oneDrive", OneDrive);
            writer.WriteBoolValue("oneNote", OneNote);
            writer.WriteBoolValue("outlook", Outlook);
            writer.WriteBoolValue("powerPoint", PowerPoint);
            writer.WriteBoolValue("publisher", Publisher);
            writer.WriteBoolValue("sharePointDesigner", SharePointDesigner);
            writer.WriteBoolValue("teams", Teams);
            writer.WriteBoolValue("visio", Visio);
            writer.WriteBoolValue("word", Word);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
