using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NotifyUserAction : DlpActionInfo, IParsable {
        /// <summary>The actionLastModifiedDateTime property</summary>
        public DateTimeOffset? ActionLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("actionLastModifiedDateTime"); }
            set { BackingStore?.Set("actionLastModifiedDateTime", value); }
        }
        /// <summary>The emailText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailText {
            get { return BackingStore?.Get<string?>("emailText"); }
            set { BackingStore?.Set("emailText", value); }
        }
#nullable restore
#else
        public string EmailText {
            get { return BackingStore?.Get<string>("emailText"); }
            set { BackingStore?.Set("emailText", value); }
        }
#endif
        /// <summary>The policyTip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyTip {
            get { return BackingStore?.Get<string?>("policyTip"); }
            set { BackingStore?.Set("policyTip", value); }
        }
#nullable restore
#else
        public string PolicyTip {
            get { return BackingStore?.Get<string>("policyTip"); }
            set { BackingStore?.Set("policyTip", value); }
        }
#endif
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Recipients {
            get { return BackingStore?.Get<List<string>?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#nullable restore
#else
        public List<string> Recipients {
            get { return BackingStore?.Get<List<string>>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NotifyUserAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NotifyUserAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionLastModifiedDateTime", n => { ActionLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"emailText", n => { EmailText = n.GetStringValue(); } },
                {"policyTip", n => { PolicyTip = n.GetStringValue(); } },
                {"recipients", n => { Recipients = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("actionLastModifiedDateTime", ActionLastModifiedDateTime);
            writer.WriteStringValue("emailText", EmailText);
            writer.WriteStringValue("policyTip", PolicyTip);
            writer.WriteCollectionOfPrimitiveValues<string>("recipients", Recipients);
        }
    }
}
