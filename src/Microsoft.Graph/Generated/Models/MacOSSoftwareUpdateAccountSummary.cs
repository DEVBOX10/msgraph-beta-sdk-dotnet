using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSSoftwareUpdateAccountSummary : Entity, IParsable {
        /// <summary>Summary of the updates by category.</summary>
        public List<MacOSSoftwareUpdateCategorySummary> CategorySummaries { get; set; }
        /// <summary>The device ID.</summary>
        public string DeviceId { get; set; }
        /// <summary>The device name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The name of the report</summary>
        public string DisplayName { get; set; }
        /// <summary>Number of failed updates on the device.</summary>
        public int? FailedUpdateCount { get; set; }
        /// <summary>Last date time the report for this device was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The OS version.</summary>
        public string OsVersion { get; set; }
        /// <summary>Number of successful updates on the device.</summary>
        public int? SuccessfulUpdateCount { get; set; }
        /// <summary>Number of total updates on the device.</summary>
        public int? TotalUpdateCount { get; set; }
        /// <summary>The user ID.</summary>
        public string UserId { get; set; }
        /// <summary>The user principal name</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSSoftwareUpdateAccountSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateAccountSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categorySummaries", n => { CategorySummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateCategorySummary>(MacOSSoftwareUpdateCategorySummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"failedUpdateCount", n => { FailedUpdateCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"successfulUpdateCount", n => { SuccessfulUpdateCount = n.GetIntValue(); } },
                {"totalUpdateCount", n => { TotalUpdateCount = n.GetIntValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MacOSSoftwareUpdateCategorySummary>("categorySummaries", CategorySummaries);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("failedUpdateCount", FailedUpdateCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteIntValue("successfulUpdateCount", SuccessfulUpdateCount);
            writer.WriteIntValue("totalUpdateCount", TotalUpdateCount);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
