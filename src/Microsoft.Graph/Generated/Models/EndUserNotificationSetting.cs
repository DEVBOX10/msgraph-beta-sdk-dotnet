// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EndUserNotificationSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Notification preference. Possible values are: unknown, microsoft, custom, unknownFutureValue.</summary>
        public EndUserNotificationPreference? NotificationPreference {
            get { return BackingStore?.Get<EndUserNotificationPreference?>("notificationPreference"); }
            set { BackingStore?.Set("notificationPreference", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Positive reinforcement detail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PositiveReinforcementNotification? PositiveReinforcement {
            get { return BackingStore?.Get<PositiveReinforcementNotification?>("positiveReinforcement"); }
            set { BackingStore?.Set("positiveReinforcement", value); }
        }
#nullable restore
#else
        public PositiveReinforcementNotification PositiveReinforcement {
            get { return BackingStore?.Get<PositiveReinforcementNotification>("positiveReinforcement"); }
            set { BackingStore?.Set("positiveReinforcement", value); }
        }
#endif
        /// <summary>End user notification type. Possible values are: unknown, noTraining, trainingSelected, noNotification, unknownFutureValue.</summary>
        public EndUserNotificationSettingType? SettingType {
            get { return BackingStore?.Get<EndUserNotificationSettingType?>("settingType"); }
            set { BackingStore?.Set("settingType", value); }
        }
        /// <summary>
        /// Instantiates a new endUserNotificationSetting and sets the default values.
        /// </summary>
        public EndUserNotificationSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EndUserNotificationSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.noTrainingNotificationSetting" => new NoTrainingNotificationSetting(),
                "#microsoft.graph.trainingNotificationSetting" => new TrainingNotificationSetting(),
                _ => new EndUserNotificationSetting(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"notificationPreference", n => { NotificationPreference = n.GetEnumValue<EndUserNotificationPreference>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"positiveReinforcement", n => { PositiveReinforcement = n.GetObjectValue<PositiveReinforcementNotification>(PositiveReinforcementNotification.CreateFromDiscriminatorValue); } },
                {"settingType", n => { SettingType = n.GetEnumValue<EndUserNotificationSettingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EndUserNotificationPreference>("notificationPreference", NotificationPreference);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PositiveReinforcementNotification>("positiveReinforcement", PositiveReinforcement);
            writer.WriteEnumValue<EndUserNotificationSettingType>("settingType", SettingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
