using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ArchivedPrintJob : IAdditionalDataHolder, IParsable {
        /// <summary>True if the job was acquired by a printer; false otherwise. Read-only.</summary>
        public bool? AcquiredByPrinter { get; set; }
        /// <summary>The dateTimeOffset when the job was acquired by the printer, if any. Read-only.</summary>
        public DateTimeOffset? AcquiredDateTime { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of black and white pages that were printed. Read-only.</summary>
        public int? BlackAndWhitePageCount { get; set; }
        /// <summary>The number of color pages that were printed. Read-only.</summary>
        public int? ColorPageCount { get; set; }
        /// <summary>The dateTimeOffset when the job was completed, canceled or aborted. Read-only.</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>The number of copies that were printed. Read-only.</summary>
        public int? CopiesPrinted { get; set; }
        /// <summary>The user who created the print job. Read-only.</summary>
        public UserIdentity CreatedBy { get; set; }
        /// <summary>The dateTimeOffset when the job was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The number of duplex (double-sided) pages that were printed. Read-only.</summary>
        public int? DuplexPageCount { get; set; }
        /// <summary>The archived print job&apos;s GUID. Read-only.</summary>
        public string Id { get; set; }
        /// <summary>The total number of pages that were printed. Read-only.</summary>
        public int? PageCount { get; set; }
        /// <summary>The printer ID that the job was queued for. Read-only.</summary>
        public string PrinterId { get; set; }
        /// <summary>The print job&apos;s final processing state. Read-only.</summary>
        public PrintJobProcessingState? ProcessingState { get; set; }
        /// <summary>The number of simplex (single-sided) pages that were printed. Read-only.</summary>
        public int? SimplexPageCount { get; set; }
        /// <summary>
        /// Instantiates a new archivedPrintJob and sets the default values.
        /// </summary>
        public ArchivedPrintJob() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"pageCount", n => { PageCount = n.GetIntValue(); } },
                {"printerId", n => { PrinterId = n.GetStringValue(); } },
                {"processingState", n => { ProcessingState = n.GetEnumValue<PrintJobProcessingState>(); } },
                {"simplexPageCount", n => { SimplexPageCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
            writer.WriteIntValue("pageCount", PageCount);
            writer.WriteStringValue("printerId", PrinterId);
            writer.WriteEnumValue<PrintJobProcessingState>("processingState", ProcessingState);
            writer.WriteIntValue("simplexPageCount", SimplexPageCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
