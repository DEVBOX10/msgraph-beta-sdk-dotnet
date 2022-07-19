using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365ActiveUserCounts : Entity, IParsable {
        /// <summary>The number of active users in Exchange. Any user who can read and send email is considered an active user.</summary>
        public long? Exchange {
            get { return BackingStore?.Get<long?>("exchange"); }
            set { BackingStore?.Set("exchange", value); }
        }
        /// <summary>The number of active users in Microsoft 365. This number includes all the active users in Exchange, OneDrive, SharePoint, Skype For Business, Yammer, and Microsoft Teams. You can find the definition of active user for each product in the respective property description.</summary>
        public long? Office365 {
            get { return BackingStore?.Get<long?>("office365"); }
            set { BackingStore?.Set("office365", value); }
        }
        /// <summary>The number of active users in OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public long? OneDrive {
            get { return BackingStore?.Get<long?>("oneDrive"); }
            set { BackingStore?.Set("oneDrive", value); }
        }
        /// <summary>The date on which a number of users were active.</summary>
        public Date? ReportDate {
            get { return BackingStore?.Get<Date?>("reportDate"); }
            set { BackingStore?.Set("reportDate", value); }
        }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod {
            get { return BackingStore?.Get<string>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate {
            get { return BackingStore?.Get<Date?>("reportRefreshDate"); }
            set { BackingStore?.Set("reportRefreshDate", value); }
        }
        /// <summary>The number of active users in SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public long? SharePoint {
            get { return BackingStore?.Get<long?>("sharePoint"); }
            set { BackingStore?.Set("sharePoint", value); }
        }
        /// <summary>The number of active users in Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public long? SkypeForBusiness {
            get { return BackingStore?.Get<long?>("skypeForBusiness"); }
            set { BackingStore?.Set("skypeForBusiness", value); }
        }
        /// <summary>The number of active users in Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public long? Teams {
            get { return BackingStore?.Get<long?>("teams"); }
            set { BackingStore?.Set("teams", value); }
        }
        /// <summary>The number of active users in Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public long? Yammer {
            get { return BackingStore?.Get<long?>("yammer"); }
            set { BackingStore?.Set("yammer", value); }
        }
        /// <summary>
        /// Instantiates a new Office365ActiveUserCounts and sets the default values.
        /// </summary>
        public Office365ActiveUserCounts() : base() {
            OdataType = "#microsoft.graph.office365ActiveUserCounts";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365ActiveUserCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365ActiveUserCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exchange", n => { Exchange = n.GetLongValue(); } },
                {"office365", n => { Office365 = n.GetLongValue(); } },
                {"oneDrive", n => { OneDrive = n.GetLongValue(); } },
                {"reportDate", n => { ReportDate = n.GetDateValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"sharePoint", n => { SharePoint = n.GetLongValue(); } },
                {"skypeForBusiness", n => { SkypeForBusiness = n.GetLongValue(); } },
                {"teams", n => { Teams = n.GetLongValue(); } },
                {"yammer", n => { Yammer = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchange", Exchange);
            writer.WriteLongValue("office365", Office365);
            writer.WriteLongValue("oneDrive", OneDrive);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePoint", SharePoint);
            writer.WriteLongValue("skypeForBusiness", SkypeForBusiness);
            writer.WriteLongValue("teams", Teams);
            writer.WriteLongValue("yammer", Yammer);
        }
    }
}
