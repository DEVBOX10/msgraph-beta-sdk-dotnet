using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>SharedPC Account Manager Policy. Only applies when the account manager is enabled.</summary>
    public class SharedPCAccountManagerPolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Possible values for when accounts are deleted on a shared PC.</summary>
        public SharedPCAccountDeletionPolicyType? AccountDeletionPolicy {
            get { return BackingStore?.Get<SharedPCAccountDeletionPolicyType?>("accountDeletionPolicy"); }
            set { BackingStore?.Set("accountDeletionPolicy", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Sets the percentage of available disk space a PC should have before it stops deleting cached shared PC accounts. Only applies when AccountDeletionPolicy is DiskSpaceThreshold or DiskSpaceThresholdOrInactiveThreshold. Valid values 0 to 100</summary>
        public int? CacheAccountsAboveDiskFreePercentage {
            get { return BackingStore?.Get<int?>("cacheAccountsAboveDiskFreePercentage"); }
            set { BackingStore?.Set("cacheAccountsAboveDiskFreePercentage", value); }
        }
        /// <summary>Specifies when the accounts will start being deleted when they have not been logged on during the specified period, given as number of days. Only applies when AccountDeletionPolicy is DiskSpaceThreshold or DiskSpaceThresholdOrInactiveThreshold.</summary>
        public int? InactiveThresholdDays {
            get { return BackingStore?.Get<int?>("inactiveThresholdDays"); }
            set { BackingStore?.Set("inactiveThresholdDays", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Sets the percentage of disk space remaining on a PC before cached accounts will be deleted to free disk space. Accounts that have been inactive the longest will be deleted first. Only applies when AccountDeletionPolicy is DiskSpaceThresholdOrInactiveThreshold. Valid values 0 to 100</summary>
        public int? RemoveAccountsBelowDiskFreePercentage {
            get { return BackingStore?.Get<int?>("removeAccountsBelowDiskFreePercentage"); }
            set { BackingStore?.Set("removeAccountsBelowDiskFreePercentage", value); }
        }
        /// <summary>
        /// Instantiates a new sharedPCAccountManagerPolicy and sets the default values.
        /// </summary>
        public SharedPCAccountManagerPolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.sharedPCAccountManagerPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharedPCAccountManagerPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedPCAccountManagerPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountDeletionPolicy", n => { AccountDeletionPolicy = n.GetEnumValue<SharedPCAccountDeletionPolicyType>(); } },
                {"cacheAccountsAboveDiskFreePercentage", n => { CacheAccountsAboveDiskFreePercentage = n.GetIntValue(); } },
                {"inactiveThresholdDays", n => { InactiveThresholdDays = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"removeAccountsBelowDiskFreePercentage", n => { RemoveAccountsBelowDiskFreePercentage = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SharedPCAccountDeletionPolicyType>("accountDeletionPolicy", AccountDeletionPolicy);
            writer.WriteIntValue("cacheAccountsAboveDiskFreePercentage", CacheAccountsAboveDiskFreePercentage);
            writer.WriteIntValue("inactiveThresholdDays", InactiveThresholdDays);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("removeAccountsBelowDiskFreePercentage", RemoveAccountsBelowDiskFreePercentage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
