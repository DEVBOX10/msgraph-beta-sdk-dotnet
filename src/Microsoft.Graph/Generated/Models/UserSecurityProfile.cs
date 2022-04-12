using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserSecurityProfile : Entity, IParsable {
        /// <summary>The accounts property</summary>
        public List<UserAccount> Accounts { get; set; }
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary>The azureTenantId property</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The riskScore property</summary>
        public string RiskScore { get; set; }
        /// <summary>The tags property</summary>
        public List<string> Tags { get; set; }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accounts", n => { Accounts = n.GetCollectionOfObjectValues<UserAccount>(UserAccount.CreateFromDiscriminatorValue).ToList(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserAccount>("accounts", Accounts);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
