using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrinterCapabilities : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
        public List<int?> BottomMargins { get; set; }
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation { get; set; }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
        public List<PrintColorMode?> ColorModes { get; set; }
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
        public List<string> ContentTypes { get; set; }
        /// <summary>The range of copies per job supported by the printer.</summary>
        public IntegerRange CopiesPerJob { get; set; }
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
        public List<int?> Dpis { get; set; }
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
        public List<PrintDuplexMode?> DuplexModes { get; set; }
        /// <summary>The feedDirections property</summary>
        public List<PrinterFeedDirection?> FeedDirections { get; set; }
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
        public List<PrinterFeedOrientation?> FeedOrientations { get; set; }
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
        public List<PrintFinishing?> Finishings { get; set; }
        /// <summary>Supported input bins for the printer.</summary>
        public List<string> InputBins { get; set; }
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported { get; set; }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported { get; set; }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
        public List<int?> LeftMargins { get; set; }
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
        public List<string> MediaColors { get; set; }
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
        public List<string> MediaSizes { get; set; }
        /// <summary>The media types supported by the printer.</summary>
        public List<string> MediaTypes { get; set; }
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
        public List<PrintMultipageLayout?> MultipageLayouts { get; set; }
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
        public List<PrintOrientation?> Orientations { get; set; }
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
        public List<string> OutputBins { get; set; }
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
        public List<int?> PagesPerSheet { get; set; }
        /// <summary>The print qualities supported by the printer.</summary>
        public List<PrintQuality?> Qualities { get; set; }
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
        public List<int?> RightMargins { get; set; }
        /// <summary>Supported print scalings.</summary>
        public List<PrintScaling?> Scalings { get; set; }
        /// <summary>The supportedColorConfigurations property</summary>
        public List<PrintColorConfiguration?> SupportedColorConfigurations { get; set; }
        /// <summary>The supportedCopiesPerJob property</summary>
        public IntegerRange SupportedCopiesPerJob { get; set; }
        /// <summary>The supportedDocumentMimeTypes property</summary>
        public List<string> SupportedDocumentMimeTypes { get; set; }
        /// <summary>The supportedDuplexConfigurations property</summary>
        public List<PrintDuplexConfiguration?> SupportedDuplexConfigurations { get; set; }
        /// <summary>The supportedFinishings property</summary>
        public List<PrintFinishing?> SupportedFinishings { get; set; }
        /// <summary>The supportedMediaColors property</summary>
        public List<string> SupportedMediaColors { get; set; }
        /// <summary>The supportedMediaSizes property</summary>
        public List<string> SupportedMediaSizes { get; set; }
        /// <summary>The supportedMediaTypes property</summary>
        public List<PrintMediaType?> SupportedMediaTypes { get; set; }
        /// <summary>The supportedOrientations property</summary>
        public List<PrintOrientation?> SupportedOrientations { get; set; }
        /// <summary>The supportedOutputBins property</summary>
        public List<string> SupportedOutputBins { get; set; }
        /// <summary>The supportedPagesPerSheet property</summary>
        public IntegerRange SupportedPagesPerSheet { get; set; }
        /// <summary>The supportedPresentationDirections property</summary>
        public List<PrintPresentationDirection?> SupportedPresentationDirections { get; set; }
        /// <summary>The supportedPrintQualities property</summary>
        public List<PrintQuality?> SupportedPrintQualities { get; set; }
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage { get; set; }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
        public List<int?> TopMargins { get; set; }
        /// <summary>
        /// Instantiates a new printerCapabilities and sets the default values.
        /// </summary>
        public PrinterCapabilities() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bottomMargins", (o,n) => { (o as PrinterCapabilities).BottomMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"collation", (o,n) => { (o as PrinterCapabilities).Collation = n.GetBoolValue(); } },
                {"colorModes", (o,n) => { (o as PrinterCapabilities).ColorModes = n.GetCollectionOfEnumValues<PrintColorMode>().ToList(); } },
                {"contentTypes", (o,n) => { (o as PrinterCapabilities).ContentTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copiesPerJob", (o,n) => { (o as PrinterCapabilities).CopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"dpis", (o,n) => { (o as PrinterCapabilities).Dpis = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"duplexModes", (o,n) => { (o as PrinterCapabilities).DuplexModes = n.GetCollectionOfEnumValues<PrintDuplexMode>().ToList(); } },
                {"feedDirections", (o,n) => { (o as PrinterCapabilities).FeedDirections = n.GetCollectionOfEnumValues<PrinterFeedDirection>().ToList(); } },
                {"feedOrientations", (o,n) => { (o as PrinterCapabilities).FeedOrientations = n.GetCollectionOfEnumValues<PrinterFeedOrientation>().ToList(); } },
                {"finishings", (o,n) => { (o as PrinterCapabilities).Finishings = n.GetCollectionOfEnumValues<PrintFinishing>().ToList(); } },
                {"inputBins", (o,n) => { (o as PrinterCapabilities).InputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isColorPrintingSupported", (o,n) => { (o as PrinterCapabilities).IsColorPrintingSupported = n.GetBoolValue(); } },
                {"isPageRangeSupported", (o,n) => { (o as PrinterCapabilities).IsPageRangeSupported = n.GetBoolValue(); } },
                {"leftMargins", (o,n) => { (o as PrinterCapabilities).LeftMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"mediaColors", (o,n) => { (o as PrinterCapabilities).MediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaSizes", (o,n) => { (o as PrinterCapabilities).MediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaTypes", (o,n) => { (o as PrinterCapabilities).MediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"multipageLayouts", (o,n) => { (o as PrinterCapabilities).MultipageLayouts = n.GetCollectionOfEnumValues<PrintMultipageLayout>().ToList(); } },
                {"orientations", (o,n) => { (o as PrinterCapabilities).Orientations = n.GetCollectionOfEnumValues<PrintOrientation>().ToList(); } },
                {"outputBins", (o,n) => { (o as PrinterCapabilities).OutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"pagesPerSheet", (o,n) => { (o as PrinterCapabilities).PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"qualities", (o,n) => { (o as PrinterCapabilities).Qualities = n.GetCollectionOfEnumValues<PrintQuality>().ToList(); } },
                {"rightMargins", (o,n) => { (o as PrinterCapabilities).RightMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"scalings", (o,n) => { (o as PrinterCapabilities).Scalings = n.GetCollectionOfEnumValues<PrintScaling>().ToList(); } },
                {"supportedColorConfigurations", (o,n) => { (o as PrinterCapabilities).SupportedColorConfigurations = n.GetCollectionOfEnumValues<PrintColorConfiguration>().ToList(); } },
                {"supportedCopiesPerJob", (o,n) => { (o as PrinterCapabilities).SupportedCopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"supportedDocumentMimeTypes", (o,n) => { (o as PrinterCapabilities).SupportedDocumentMimeTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedDuplexConfigurations", (o,n) => { (o as PrinterCapabilities).SupportedDuplexConfigurations = n.GetCollectionOfEnumValues<PrintDuplexConfiguration>().ToList(); } },
                {"supportedFinishings", (o,n) => { (o as PrinterCapabilities).SupportedFinishings = n.GetCollectionOfEnumValues<PrintFinishing>().ToList(); } },
                {"supportedMediaColors", (o,n) => { (o as PrinterCapabilities).SupportedMediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaSizes", (o,n) => { (o as PrinterCapabilities).SupportedMediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedMediaTypes", (o,n) => { (o as PrinterCapabilities).SupportedMediaTypes = n.GetCollectionOfEnumValues<PrintMediaType>().ToList(); } },
                {"supportedOrientations", (o,n) => { (o as PrinterCapabilities).SupportedOrientations = n.GetCollectionOfEnumValues<PrintOrientation>().ToList(); } },
                {"supportedOutputBins", (o,n) => { (o as PrinterCapabilities).SupportedOutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedPagesPerSheet", (o,n) => { (o as PrinterCapabilities).SupportedPagesPerSheet = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"supportedPresentationDirections", (o,n) => { (o as PrinterCapabilities).SupportedPresentationDirections = n.GetCollectionOfEnumValues<PrintPresentationDirection>().ToList(); } },
                {"supportedPrintQualities", (o,n) => { (o as PrinterCapabilities).SupportedPrintQualities = n.GetCollectionOfEnumValues<PrintQuality>().ToList(); } },
                {"supportsFitPdfToPage", (o,n) => { (o as PrinterCapabilities).SupportsFitPdfToPage = n.GetBoolValue(); } },
                {"topMargins", (o,n) => { (o as PrinterCapabilities).TopMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfEnumValues<PrintColorMode>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfEnumValues<PrintDuplexMode>("duplexModes", DuplexModes);
            writer.WriteCollectionOfEnumValues<PrinterFeedDirection>("feedDirections", FeedDirections);
            writer.WriteCollectionOfEnumValues<PrinterFeedOrientation>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfEnumValues<PrintFinishing>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfEnumValues<PrintMultipageLayout>("multipageLayouts", MultipageLayouts);
            writer.WriteCollectionOfEnumValues<PrintOrientation>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfEnumValues<PrintQuality>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfEnumValues<PrintScaling>("scalings", Scalings);
            writer.WriteCollectionOfEnumValues<PrintColorConfiguration>("supportedColorConfigurations", SupportedColorConfigurations);
            writer.WriteObjectValue<IntegerRange>("supportedCopiesPerJob", SupportedCopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDocumentMimeTypes", SupportedDocumentMimeTypes);
            writer.WriteCollectionOfEnumValues<PrintDuplexConfiguration>("supportedDuplexConfigurations", SupportedDuplexConfigurations);
            writer.WriteCollectionOfEnumValues<PrintFinishing>("supportedFinishings", SupportedFinishings);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaColors", SupportedMediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedMediaSizes", SupportedMediaSizes);
            writer.WriteCollectionOfEnumValues<PrintMediaType>("supportedMediaTypes", SupportedMediaTypes);
            writer.WriteCollectionOfEnumValues<PrintOrientation>("supportedOrientations", SupportedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedOutputBins", SupportedOutputBins);
            writer.WriteObjectValue<IntegerRange>("supportedPagesPerSheet", SupportedPagesPerSheet);
            writer.WriteCollectionOfEnumValues<PrintPresentationDirection>("supportedPresentationDirections", SupportedPresentationDirections);
            writer.WriteCollectionOfEnumValues<PrintQuality>("supportedPrintQualities", SupportedPrintQualities);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
