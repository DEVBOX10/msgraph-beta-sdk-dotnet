using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemFacet : Entity, IParsable {
        /// <summary>The audiences that are able to see the values contained within the associated entity. Possible values are: me, family, contacts, groupMembers, organization, federatedOrganizations, everyone, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.AllowedAudiences? AllowedAudiences { get; set; }
        /// <summary>The createdBy property</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Contains inference detail if the entity is inferred by the creating or modifying application.</summary>
        public InferenceData Inference { get; set; }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>The lastModifiedBy property</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Where the values within an entity originated if synced from another service.</summary>
        public PersonDataSources Source { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemFacet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemFacet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAudiences", n => { AllowedAudiences = n.GetEnumValue<AllowedAudiences>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inference", n => { Inference = n.GetObjectValue<InferenceData>(InferenceData.CreateFromDiscriminatorValue); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"source", n => { Source = n.GetObjectValue<PersonDataSources>(PersonDataSources.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AllowedAudiences>("allowedAudiences", AllowedAudiences);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<InferenceData>("inference", Inference);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<PersonDataSources>("source", Source);
        }
    }
}
