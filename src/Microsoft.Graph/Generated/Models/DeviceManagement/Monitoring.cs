using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class Monitoring : Entity, IParsable {
        /// <summary>The collection of records of alert events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertRecord>? AlertRecords {
            get { return BackingStore?.Get<List<AlertRecord>?>("alertRecords"); }
            set { BackingStore?.Set("alertRecords", value); }
        }
#nullable restore
#else
        public List<AlertRecord> AlertRecords {
            get { return BackingStore?.Get<List<AlertRecord>>("alertRecords"); }
            set { BackingStore?.Set("alertRecords", value); }
        }
#endif
        /// <summary>The collection of alert rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertRule>? AlertRules {
            get { return BackingStore?.Get<List<AlertRule>?>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
#nullable restore
#else
        public List<AlertRule> AlertRules {
            get { return BackingStore?.Get<List<AlertRule>>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Monitoring CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Monitoring();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertRecords", n => { AlertRecords = n.GetCollectionOfObjectValues<AlertRecord>(AlertRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alertRules", n => { AlertRules = n.GetCollectionOfObjectValues<AlertRule>(AlertRule.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AlertRecord>("alertRecords", AlertRecords);
            writer.WriteCollectionOfObjectValues<AlertRule>("alertRules", AlertRules);
        }
    }
}
