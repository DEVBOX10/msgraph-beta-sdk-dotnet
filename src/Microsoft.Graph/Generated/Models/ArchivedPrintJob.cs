using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ArchivedPrintJob : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>True if the job was acquired by a printer; false otherwise. Read-only.</summary>
        public bool? AcquiredByPrinter {
            get { return BackingStore?.Get<bool?>("acquiredByPrinter"); }
            set { BackingStore?.Set("acquiredByPrinter", value); }
        }
        /// <summary>The dateTimeOffset when the job was acquired by the printer, if any. Read-only.</summary>
        public DateTimeOffset? AcquiredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("acquiredDateTime"); }
            set { BackingStore?.Set("acquiredDateTime", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of black and white pages that were printed. Read-only.</summary>
        public int? BlackAndWhitePageCount {
            get { return BackingStore?.Get<int?>("blackAndWhitePageCount"); }
            set { BackingStore?.Set("blackAndWhitePageCount", value); }
        }
        /// <summary>The number of color pages that were printed. Read-only.</summary>
        public int? ColorPageCount {
            get { return BackingStore?.Get<int?>("colorPageCount"); }
            set { BackingStore?.Set("colorPageCount", value); }
        }
        /// <summary>The dateTimeOffset when the job was completed, canceled or aborted. Read-only.</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>The number of copies that were printed. Read-only.</summary>
        public int? CopiesPrinted {
            get { return BackingStore?.Get<int?>("copiesPrinted"); }
            set { BackingStore?.Set("copiesPrinted", value); }
        }
        /// <summary>The user who created the print job. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? CreatedBy {
            get { return BackingStore?.Get<UserIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public UserIdentity CreatedBy {
            get { return BackingStore?.Get<UserIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The dateTimeOffset when the job was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The number of duplex (double-sided) pages that were printed. Read-only.</summary>
        public int? DuplexPageCount {
            get { return BackingStore?.Get<int?>("duplexPageCount"); }
            set { BackingStore?.Set("duplexPageCount", value); }
        }
        /// <summary>The archived print job&apos;s GUID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
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
        /// <summary>The total number of pages that were printed. Read-only.</summary>
        public int? PageCount {
            get { return BackingStore?.Get<int?>("pageCount"); }
            set { BackingStore?.Set("pageCount", value); }
        }
        /// <summary>The printer ID that the job was queued for. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterId {
            get { return BackingStore?.Get<string?>("printerId"); }
            set { BackingStore?.Set("printerId", value); }
        }
#nullable restore
#else
        public string PrinterId {
            get { return BackingStore?.Get<string>("printerId"); }
            set { BackingStore?.Set("printerId", value); }
        }
#endif
        /// <summary>The processingState property</summary>
        public PrintJobProcessingState? ProcessingState {
            get { return BackingStore?.Get<PrintJobProcessingState?>("processingState"); }
            set { BackingStore?.Set("processingState", value); }
        }
        /// <summary>The number of simplex (single-sided) pages that were printed. Read-only.</summary>
        public int? SimplexPageCount {
            get { return BackingStore?.Get<int?>("simplexPageCount"); }
            set { BackingStore?.Set("simplexPageCount", value); }
        }
        /// <summary>
        /// Instantiates a new archivedPrintJob and sets the default values.
        /// </summary>
        public ArchivedPrintJob() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ArchivedPrintJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ArchivedPrintJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acquiredByPrinter", n => { AcquiredByPrinter = n.GetBoolValue(); } },
                {"acquiredDateTime", n => { AcquiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"blackAndWhitePageCount", n => { BlackAndWhitePageCount = n.GetIntValue(); } },
                {"colorPageCount", n => { ColorPageCount = n.GetIntValue(); } },
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"copiesPrinted", n => { CopiesPrinted = n.GetIntValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"duplexPageCount", n => { DuplexPageCount = n.GetIntValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"pageCount", n => { PageCount = n.GetIntValue(); } },
                {"printerId", n => { PrinterId = n.GetStringValue(); } },
                {"processingState", n => { ProcessingState = n.GetEnumValue<PrintJobProcessingState>(); } },
                {"simplexPageCount", n => { SimplexPageCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acquiredByPrinter", AcquiredByPrinter);
            writer.WriteDateTimeOffsetValue("acquiredDateTime", AcquiredDateTime);
            writer.WriteIntValue("blackAndWhitePageCount", BlackAndWhitePageCount);
            writer.WriteIntValue("colorPageCount", ColorPageCount);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteIntValue("copiesPrinted", CopiesPrinted);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("duplexPageCount", DuplexPageCount);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("pageCount", PageCount);
            writer.WriteStringValue("printerId", PrinterId);
            writer.WriteEnumValue<PrintJobProcessingState>("processingState", ProcessingState);
            writer.WriteIntValue("simplexPageCount", SimplexPageCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
