using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RequestorSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Indicates whether new requests are accepted on this policy.</summary>
        public bool? AcceptRequests {
            get { return BackingStore?.Get<bool?>("acceptRequests"); }
            set { BackingStore?.Set("acceptRequests", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSet>? AllowedRequestors {
            get { return BackingStore?.Get<List<UserSet>?>("allowedRequestors"); }
            set { BackingStore?.Set("allowedRequestors", value); }
        }
#nullable restore
#else
        public List<UserSet> AllowedRequestors {
            get { return BackingStore?.Get<List<UserSet>>("allowedRequestors"); }
            set { BackingStore?.Set("allowedRequestors", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Who can request. One of NoSubjects, SpecificDirectorySubjects, SpecificConnectedOrganizationSubjects, AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects or AllExternalSubjects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType {
            get { return BackingStore?.Get<string?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#nullable restore
#else
        public string ScopeType {
            get { return BackingStore?.Get<string>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new requestorSettings and sets the default values.
        /// </summary>
        public RequestorSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RequestorSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequestorSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptRequests", n => { AcceptRequests = n.GetBoolValue(); } },
                {"allowedRequestors", n => { AllowedRequestors = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scopeType", n => { ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acceptRequests", AcceptRequests);
            writer.WriteCollectionOfObjectValues<UserSet>("allowedRequestors", AllowedRequestors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("scopeType", ScopeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
