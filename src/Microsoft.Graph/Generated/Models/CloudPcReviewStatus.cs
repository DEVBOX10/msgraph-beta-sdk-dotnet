using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcReviewStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The azureStorageAccountId property</summary>
        public string AzureStorageAccountId { get; set; }
        /// <summary>The azureStorageAccountName property</summary>
        public string AzureStorageAccountName { get; set; }
        /// <summary>The inReview property</summary>
        public bool? InReview { get; set; }
        /// <summary>The restorePointDateTime property</summary>
        public DateTimeOffset? RestorePointDateTime { get; set; }
        /// <summary>The reviewStartDateTime property</summary>
        public DateTimeOffset? ReviewStartDateTime { get; set; }
        /// <summary>The subscriptionId property</summary>
        public string SubscriptionId { get; set; }
        /// <summary>The subscriptionName property</summary>
        public string SubscriptionName { get; set; }
        /// <summary>The userAccessLevel property</summary>
        public CloudPcUserAccessLevel? UserAccessLevel { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcReviewStatus and sets the default values.
        /// </summary>
        public CloudPcReviewStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcReviewStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcReviewStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"azureStorageAccountId", n => { AzureStorageAccountId = n.GetStringValue(); } },
                {"azureStorageAccountName", n => { AzureStorageAccountName = n.GetStringValue(); } },
                {"inReview", n => { InReview = n.GetBoolValue(); } },
                {"restorePointDateTime", n => { RestorePointDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewStartDateTime", n => { ReviewStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"subscriptionName", n => { SubscriptionName = n.GetStringValue(); } },
                {"userAccessLevel", n => { UserAccessLevel = n.GetEnumValue<CloudPcUserAccessLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("azureStorageAccountId", AzureStorageAccountId);
            writer.WriteStringValue("azureStorageAccountName", AzureStorageAccountName);
            writer.WriteBoolValue("inReview", InReview);
            writer.WriteDateTimeOffsetValue("restorePointDateTime", RestorePointDateTime);
            writer.WriteDateTimeOffsetValue("reviewStartDateTime", ReviewStartDateTime);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("subscriptionName", SubscriptionName);
            writer.WriteEnumValue<CloudPcUserAccessLevel>("userAccessLevel", UserAccessLevel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
