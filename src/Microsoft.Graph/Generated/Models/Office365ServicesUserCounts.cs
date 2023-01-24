using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365ServicesUserCounts : Entity, IParsable {
        /// <summary>The number of active users on Exchange. Any user who can read and send email is considered an active user.</summary>
        public long? ExchangeActive {
            get { return BackingStore?.Get<long?>("exchangeActive"); }
            set { BackingStore?.Set("exchangeActive", value); }
        }
        /// <summary>The number of inactive users on Exchange.</summary>
        public long? ExchangeInactive {
            get { return BackingStore?.Get<long?>("exchangeInactive"); }
            set { BackingStore?.Set("exchangeInactive", value); }
        }
        /// <summary>The number of active users on Microsoft 365.</summary>
        public long? Office365Active {
            get { return BackingStore?.Get<long?>("office365Active"); }
            set { BackingStore?.Set("office365Active", value); }
        }
        /// <summary>The number of inactive users on Microsoft 365.</summary>
        public long? Office365Inactive {
            get { return BackingStore?.Get<long?>("office365Inactive"); }
            set { BackingStore?.Set("office365Inactive", value); }
        }
        /// <summary>The number of active users on OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public long? OneDriveActive {
            get { return BackingStore?.Get<long?>("oneDriveActive"); }
            set { BackingStore?.Set("oneDriveActive", value); }
        }
        /// <summary>The number of inactive users on OneDrive.</summary>
        public long? OneDriveInactive {
            get { return BackingStore?.Get<long?>("oneDriveInactive"); }
            set { BackingStore?.Set("oneDriveInactive", value); }
        }
        /// <summary>The number of days the report covers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportPeriod {
            get { return BackingStore?.Get<string?>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#nullable restore
#else
        public string ReportPeriod {
            get { return BackingStore?.Get<string>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#endif
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate {
            get { return BackingStore?.Get<Date?>("reportRefreshDate"); }
            set { BackingStore?.Set("reportRefreshDate", value); }
        }
        /// <summary>The number of active users on SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public long? SharePointActive {
            get { return BackingStore?.Get<long?>("sharePointActive"); }
            set { BackingStore?.Set("sharePointActive", value); }
        }
        /// <summary>The number of inactive users on SharePoint.</summary>
        public long? SharePointInactive {
            get { return BackingStore?.Get<long?>("sharePointInactive"); }
            set { BackingStore?.Set("sharePointInactive", value); }
        }
        /// <summary>The number of active users on Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public long? SkypeForBusinessActive {
            get { return BackingStore?.Get<long?>("skypeForBusinessActive"); }
            set { BackingStore?.Set("skypeForBusinessActive", value); }
        }
        /// <summary>The number of inactive users on Skype For Business.</summary>
        public long? SkypeForBusinessInactive {
            get { return BackingStore?.Get<long?>("skypeForBusinessInactive"); }
            set { BackingStore?.Set("skypeForBusinessInactive", value); }
        }
        /// <summary>The number of active users on Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public long? TeamsActive {
            get { return BackingStore?.Get<long?>("teamsActive"); }
            set { BackingStore?.Set("teamsActive", value); }
        }
        /// <summary>The number of inactive users on Microsoft Teams.</summary>
        public long? TeamsInactive {
            get { return BackingStore?.Get<long?>("teamsInactive"); }
            set { BackingStore?.Set("teamsInactive", value); }
        }
        /// <summary>The number of active users on Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public long? YammerActive {
            get { return BackingStore?.Get<long?>("yammerActive"); }
            set { BackingStore?.Set("yammerActive", value); }
        }
        /// <summary>The number of inactive users on Yammer.</summary>
        public long? YammerInactive {
            get { return BackingStore?.Get<long?>("yammerInactive"); }
            set { BackingStore?.Set("yammerInactive", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Office365ServicesUserCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365ServicesUserCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exchangeActive", n => { ExchangeActive = n.GetLongValue(); } },
                {"exchangeInactive", n => { ExchangeInactive = n.GetLongValue(); } },
                {"office365Active", n => { Office365Active = n.GetLongValue(); } },
                {"office365Inactive", n => { Office365Inactive = n.GetLongValue(); } },
                {"oneDriveActive", n => { OneDriveActive = n.GetLongValue(); } },
                {"oneDriveInactive", n => { OneDriveInactive = n.GetLongValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointActive", n => { SharePointActive = n.GetLongValue(); } },
                {"sharePointInactive", n => { SharePointInactive = n.GetLongValue(); } },
                {"skypeForBusinessActive", n => { SkypeForBusinessActive = n.GetLongValue(); } },
                {"skypeForBusinessInactive", n => { SkypeForBusinessInactive = n.GetLongValue(); } },
                {"teamsActive", n => { TeamsActive = n.GetLongValue(); } },
                {"teamsInactive", n => { TeamsInactive = n.GetLongValue(); } },
                {"yammerActive", n => { YammerActive = n.GetLongValue(); } },
                {"yammerInactive", n => { YammerInactive = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchangeActive", ExchangeActive);
            writer.WriteLongValue("exchangeInactive", ExchangeInactive);
            writer.WriteLongValue("office365Active", Office365Active);
            writer.WriteLongValue("office365Inactive", Office365Inactive);
            writer.WriteLongValue("oneDriveActive", OneDriveActive);
            writer.WriteLongValue("oneDriveInactive", OneDriveInactive);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePointActive", SharePointActive);
            writer.WriteLongValue("sharePointInactive", SharePointInactive);
            writer.WriteLongValue("skypeForBusinessActive", SkypeForBusinessActive);
            writer.WriteLongValue("skypeForBusinessInactive", SkypeForBusinessInactive);
            writer.WriteLongValue("teamsActive", TeamsActive);
            writer.WriteLongValue("teamsInactive", TeamsInactive);
            writer.WriteLongValue("yammerActive", YammerActive);
            writer.WriteLongValue("yammerInactive", YammerInactive);
        }
    }
}
