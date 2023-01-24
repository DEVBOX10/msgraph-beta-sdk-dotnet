using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationError : Entity, IParsable {
        /// <summary>Represents the sync entity (school, section, student, teacher).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EntryType {
            get { return BackingStore?.Get<string?>("entryType"); }
            set { BackingStore?.Set("entryType", value); }
        }
#nullable restore
#else
        public string EntryType {
            get { return BackingStore?.Get<string>("entryType"); }
            set { BackingStore?.Set("entryType", value); }
        }
#endif
        /// <summary>Represents the error code for this error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode {
            get { return BackingStore?.Get<string?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#nullable restore
#else
        public string ErrorCode {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#endif
        /// <summary>Contains a description of the error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage {
            get { return BackingStore?.Get<string?>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#nullable restore
#else
        public string ErrorMessage {
            get { return BackingStore?.Get<string>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#endif
        /// <summary>The unique identifier for the entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoiningValue {
            get { return BackingStore?.Get<string?>("joiningValue"); }
            set { BackingStore?.Set("joiningValue", value); }
        }
#nullable restore
#else
        public string JoiningValue {
            get { return BackingStore?.Get<string>("joiningValue"); }
            set { BackingStore?.Set("joiningValue", value); }
        }
#endif
        /// <summary>The time of occurrence of this error.</summary>
        public DateTimeOffset? RecordedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("recordedDateTime"); }
            set { BackingStore?.Set("recordedDateTime", value); }
        }
        /// <summary>The identifier of this error entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportableIdentifier {
            get { return BackingStore?.Get<string?>("reportableIdentifier"); }
            set { BackingStore?.Set("reportableIdentifier", value); }
        }
#nullable restore
#else
        public string ReportableIdentifier {
            get { return BackingStore?.Get<string>("reportableIdentifier"); }
            set { BackingStore?.Set("reportableIdentifier", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationSynchronizationError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"entryType", n => { EntryType = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"joiningValue", n => { JoiningValue = n.GetStringValue(); } },
                {"recordedDateTime", n => { RecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reportableIdentifier", n => { ReportableIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("entryType", EntryType);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteStringValue("joiningValue", JoiningValue);
            writer.WriteDateTimeOffsetValue("recordedDateTime", RecordedDateTime);
            writer.WriteStringValue("reportableIdentifier", ReportableIdentifier);
        }
    }
}
