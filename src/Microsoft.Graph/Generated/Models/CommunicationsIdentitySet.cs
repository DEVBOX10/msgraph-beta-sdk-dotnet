using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CommunicationsIdentitySet : IdentitySet, IParsable {
        /// <summary>The application instance associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? ApplicationInstance {
            get { return BackingStore?.Get<Identity?>("applicationInstance"); }
            set { BackingStore?.Set("applicationInstance", value); }
        }
#nullable restore
#else
        public Identity ApplicationInstance {
            get { return BackingStore?.Get<Identity>("applicationInstance"); }
            set { BackingStore?.Set("applicationInstance", value); }
        }
#endif
        /// <summary>An identity the participant would like to present itself as to the other participants in the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? AssertedIdentity {
            get { return BackingStore?.Get<Identity?>("assertedIdentity"); }
            set { BackingStore?.Set("assertedIdentity", value); }
        }
#nullable restore
#else
        public Identity AssertedIdentity {
            get { return BackingStore?.Get<Identity>("assertedIdentity"); }
            set { BackingStore?.Set("assertedIdentity", value); }
        }
#endif
        /// <summary>The Azure Communication Services user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? AzureCommunicationServicesUser {
            get { return BackingStore?.Get<Identity?>("azureCommunicationServicesUser"); }
            set { BackingStore?.Set("azureCommunicationServicesUser", value); }
        }
#nullable restore
#else
        public Identity AzureCommunicationServicesUser {
            get { return BackingStore?.Get<Identity>("azureCommunicationServicesUser"); }
            set { BackingStore?.Set("azureCommunicationServicesUser", value); }
        }
#endif
        /// <summary>The encrypted user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Encrypted {
            get { return BackingStore?.Get<Identity?>("encrypted"); }
            set { BackingStore?.Set("encrypted", value); }
        }
#nullable restore
#else
        public Identity Encrypted {
            get { return BackingStore?.Get<Identity>("encrypted"); }
            set { BackingStore?.Set("encrypted", value); }
        }
#endif
        /// <summary>Type of endpoint the participant is using. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone and unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.EndpointType? EndpointType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EndpointType?>("endpointType"); }
            set { BackingStore?.Set("endpointType", value); }
        }
        /// <summary>The guest user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Guest {
            get { return BackingStore?.Get<Identity?>("guest"); }
            set { BackingStore?.Set("guest", value); }
        }
#nullable restore
#else
        public Identity Guest {
            get { return BackingStore?.Get<Identity>("guest"); }
            set { BackingStore?.Set("guest", value); }
        }
#endif
        /// <summary>The Skype for Business On-Premises user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? OnPremises {
            get { return BackingStore?.Get<Identity?>("onPremises"); }
            set { BackingStore?.Set("onPremises", value); }
        }
#nullable restore
#else
        public Identity OnPremises {
            get { return BackingStore?.Get<Identity>("onPremises"); }
            set { BackingStore?.Set("onPremises", value); }
        }
#endif
        /// <summary>Inherited from identitySet. The phone user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Phone {
            get { return BackingStore?.Get<Identity?>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#nullable restore
#else
        public Identity Phone {
            get { return BackingStore?.Get<Identity>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CommunicationsIdentitySet and sets the default values.
        /// </summary>
        public CommunicationsIdentitySet() : base() {
            OdataType = "#microsoft.graph.communicationsIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CommunicationsIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommunicationsIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationInstance", n => { ApplicationInstance = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"assertedIdentity", n => { AssertedIdentity = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"azureCommunicationServicesUser", n => { AzureCommunicationServicesUser = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"encrypted", n => { Encrypted = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"guest", n => { Guest = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"onPremises", n => { OnPremises = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"phone", n => { Phone = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("applicationInstance", ApplicationInstance);
            writer.WriteObjectValue<Identity>("assertedIdentity", AssertedIdentity);
            writer.WriteObjectValue<Identity>("azureCommunicationServicesUser", AzureCommunicationServicesUser);
            writer.WriteObjectValue<Identity>("encrypted", Encrypted);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<Identity>("guest", Guest);
            writer.WriteObjectValue<Identity>("onPremises", OnPremises);
            writer.WriteObjectValue<Identity>("phone", Phone);
        }
    }
}
