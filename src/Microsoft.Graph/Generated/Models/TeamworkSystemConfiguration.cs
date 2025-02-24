// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkSystemConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date and time configurations for a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDateTimeConfiguration? DateTimeConfiguration {
            get { return BackingStore?.Get<TeamworkDateTimeConfiguration?>("dateTimeConfiguration"); }
            set { BackingStore?.Set("dateTimeConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkDateTimeConfiguration DateTimeConfiguration {
            get { return BackingStore?.Get<TeamworkDateTimeConfiguration>("dateTimeConfiguration"); }
            set { BackingStore?.Set("dateTimeConfiguration", value); }
        }
#endif
        /// <summary>The default password for the device. Write-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultPassword {
            get { return BackingStore?.Get<string?>("defaultPassword"); }
            set { BackingStore?.Set("defaultPassword", value); }
        }
#nullable restore
#else
        public string DefaultPassword {
            get { return BackingStore?.Get<string>("defaultPassword"); }
            set { BackingStore?.Set("defaultPassword", value); }
        }
#endif
        /// <summary>The device lock timeout in seconds.</summary>
        public TimeSpan? DeviceLockTimeout {
            get { return BackingStore?.Get<TimeSpan?>("deviceLockTimeout"); }
            set { BackingStore?.Set("deviceLockTimeout", value); }
        }
        /// <summary>True if the device lock is enabled.</summary>
        public bool? IsDeviceLockEnabled {
            get { return BackingStore?.Get<bool?>("isDeviceLockEnabled"); }
            set { BackingStore?.Set("isDeviceLockEnabled", value); }
        }
        /// <summary>True if logging is enabled.</summary>
        public bool? IsLoggingEnabled {
            get { return BackingStore?.Get<bool?>("isLoggingEnabled"); }
            set { BackingStore?.Set("isLoggingEnabled", value); }
        }
        /// <summary>True if power saving is enabled.</summary>
        public bool? IsPowerSavingEnabled {
            get { return BackingStore?.Get<bool?>("isPowerSavingEnabled"); }
            set { BackingStore?.Set("isPowerSavingEnabled", value); }
        }
        /// <summary>True if screen capture is enabled.</summary>
        public bool? IsScreenCaptureEnabled {
            get { return BackingStore?.Get<bool?>("isScreenCaptureEnabled"); }
            set { BackingStore?.Set("isScreenCaptureEnabled", value); }
        }
        /// <summary>True if silent mode is enabled.</summary>
        public bool? IsSilentModeEnabled {
            get { return BackingStore?.Get<bool?>("isSilentModeEnabled"); }
            set { BackingStore?.Set("isSilentModeEnabled", value); }
        }
        /// <summary>The language option for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>The pin that unlocks the device. Write-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockPin {
            get { return BackingStore?.Get<string?>("lockPin"); }
            set { BackingStore?.Set("lockPin", value); }
        }
#nullable restore
#else
        public string LockPin {
            get { return BackingStore?.Get<string>("lockPin"); }
            set { BackingStore?.Set("lockPin", value); }
        }
#endif
        /// <summary>The logging level for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoggingLevel {
            get { return BackingStore?.Get<string?>("loggingLevel"); }
            set { BackingStore?.Set("loggingLevel", value); }
        }
#nullable restore
#else
        public string LoggingLevel {
            get { return BackingStore?.Get<string>("loggingLevel"); }
            set { BackingStore?.Set("loggingLevel", value); }
        }
#endif
        /// <summary>The network configuration for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkNetworkConfiguration? NetworkConfiguration {
            get { return BackingStore?.Get<TeamworkNetworkConfiguration?>("networkConfiguration"); }
            set { BackingStore?.Set("networkConfiguration", value); }
        }
#nullable restore
#else
        public TeamworkNetworkConfiguration NetworkConfiguration {
            get { return BackingStore?.Get<TeamworkNetworkConfiguration>("networkConfiguration"); }
            set { BackingStore?.Set("networkConfiguration", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new teamworkSystemConfiguration and sets the default values.
        /// </summary>
        public TeamworkSystemConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkSystemConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSystemConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dateTimeConfiguration", n => { DateTimeConfiguration = n.GetObjectValue<TeamworkDateTimeConfiguration>(TeamworkDateTimeConfiguration.CreateFromDiscriminatorValue); } },
                {"defaultPassword", n => { DefaultPassword = n.GetStringValue(); } },
                {"deviceLockTimeout", n => { DeviceLockTimeout = n.GetTimeSpanValue(); } },
                {"isDeviceLockEnabled", n => { IsDeviceLockEnabled = n.GetBoolValue(); } },
                {"isLoggingEnabled", n => { IsLoggingEnabled = n.GetBoolValue(); } },
                {"isPowerSavingEnabled", n => { IsPowerSavingEnabled = n.GetBoolValue(); } },
                {"isScreenCaptureEnabled", n => { IsScreenCaptureEnabled = n.GetBoolValue(); } },
                {"isSilentModeEnabled", n => { IsSilentModeEnabled = n.GetBoolValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"lockPin", n => { LockPin = n.GetStringValue(); } },
                {"loggingLevel", n => { LoggingLevel = n.GetStringValue(); } },
                {"networkConfiguration", n => { NetworkConfiguration = n.GetObjectValue<TeamworkNetworkConfiguration>(TeamworkNetworkConfiguration.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkDateTimeConfiguration>("dateTimeConfiguration", DateTimeConfiguration);
            writer.WriteStringValue("defaultPassword", DefaultPassword);
            writer.WriteTimeSpanValue("deviceLockTimeout", DeviceLockTimeout);
            writer.WriteBoolValue("isDeviceLockEnabled", IsDeviceLockEnabled);
            writer.WriteBoolValue("isLoggingEnabled", IsLoggingEnabled);
            writer.WriteBoolValue("isPowerSavingEnabled", IsPowerSavingEnabled);
            writer.WriteBoolValue("isScreenCaptureEnabled", IsScreenCaptureEnabled);
            writer.WriteBoolValue("isSilentModeEnabled", IsSilentModeEnabled);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("lockPin", LockPin);
            writer.WriteStringValue("loggingLevel", LoggingLevel);
            writer.WriteObjectValue<TeamworkNetworkConfiguration>("networkConfiguration", NetworkConfiguration);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
