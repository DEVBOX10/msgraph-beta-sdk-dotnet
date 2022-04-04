using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserAccount : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The riskScore property</summary>
        public string RiskScore { get; set; }
        /// <summary>The service property</summary>
        public string Service { get; set; }
        /// <summary>The signinName property</summary>
        public string SigninName { get; set; }
        /// <summary>The status property</summary>
        public AccountStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new userAccount and sets the default values.
        /// </summary>
        public UserAccount() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as UserAccount).DisplayName = n.GetStringValue(); } },
                {"lastSeenDateTime", (o,n) => { (o as UserAccount).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", (o,n) => { (o as UserAccount).RiskScore = n.GetStringValue(); } },
                {"service", (o,n) => { (o as UserAccount).Service = n.GetStringValue(); } },
                {"signinName", (o,n) => { (o as UserAccount).SigninName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as UserAccount).Status = n.GetEnumValue<AccountStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteStringValue("service", Service);
            writer.WriteStringValue("signinName", SigninName);
            writer.WriteEnumValue<AccountStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
