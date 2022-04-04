using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.App.Calls.Item.RecordResponse {
    /// <summary>Provides operations to call the recordResponse method.</summary>
    public class RecordResponseRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bargeInAllowed property</summary>
        public bool? BargeInAllowed { get; set; }
        /// <summary>The clientContext property</summary>
        public string ClientContext { get; set; }
        /// <summary>The initialSilenceTimeoutInSeconds property</summary>
        public int? InitialSilenceTimeoutInSeconds { get; set; }
        /// <summary>The maxRecordDurationInSeconds property</summary>
        public int? MaxRecordDurationInSeconds { get; set; }
        /// <summary>The maxSilenceTimeoutInSeconds property</summary>
        public int? MaxSilenceTimeoutInSeconds { get; set; }
        /// <summary>The playBeep property</summary>
        public bool? PlayBeep { get; set; }
        /// <summary>The prompts property</summary>
        public List<Prompt> Prompts { get; set; }
        /// <summary>The stopTones property</summary>
        public List<string> StopTones { get; set; }
        /// <summary>The streamWhileRecording property</summary>
        public bool? StreamWhileRecording { get; set; }
        /// <summary>
        /// Instantiates a new recordResponseRequestBody and sets the default values.
        /// </summary>
        public RecordResponseRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RecordResponseRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordResponseRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bargeInAllowed", (o,n) => { (o as RecordResponseRequestBody).BargeInAllowed = n.GetBoolValue(); } },
                {"clientContext", (o,n) => { (o as RecordResponseRequestBody).ClientContext = n.GetStringValue(); } },
                {"initialSilenceTimeoutInSeconds", (o,n) => { (o as RecordResponseRequestBody).InitialSilenceTimeoutInSeconds = n.GetIntValue(); } },
                {"maxRecordDurationInSeconds", (o,n) => { (o as RecordResponseRequestBody).MaxRecordDurationInSeconds = n.GetIntValue(); } },
                {"maxSilenceTimeoutInSeconds", (o,n) => { (o as RecordResponseRequestBody).MaxSilenceTimeoutInSeconds = n.GetIntValue(); } },
                {"playBeep", (o,n) => { (o as RecordResponseRequestBody).PlayBeep = n.GetBoolValue(); } },
                {"prompts", (o,n) => { (o as RecordResponseRequestBody).Prompts = n.GetCollectionOfObjectValues<Prompt>(Prompt.CreateFromDiscriminatorValue).ToList(); } },
                {"stopTones", (o,n) => { (o as RecordResponseRequestBody).StopTones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"streamWhileRecording", (o,n) => { (o as RecordResponseRequestBody).StreamWhileRecording = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("bargeInAllowed", BargeInAllowed);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteIntValue("initialSilenceTimeoutInSeconds", InitialSilenceTimeoutInSeconds);
            writer.WriteIntValue("maxRecordDurationInSeconds", MaxRecordDurationInSeconds);
            writer.WriteIntValue("maxSilenceTimeoutInSeconds", MaxSilenceTimeoutInSeconds);
            writer.WriteBoolValue("playBeep", PlayBeep);
            writer.WriteCollectionOfObjectValues<Prompt>("prompts", Prompts);
            writer.WriteCollectionOfPrimitiveValues<string>("stopTones", StopTones);
            writer.WriteBoolValue("streamWhileRecording", StreamWhileRecording);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
