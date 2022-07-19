using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OpenIdConnectIdentityProvider : IdentityProviderBase, IParsable {
        /// <summary>After the OIDC provider sends an ID token back to Azure AD, Azure AD needs to be able to map the claims from the received token to the claims that Azure AD recognizes and uses. This complex type captures that mapping. Required.</summary>
        public Microsoft.Graph.Beta.Models.ClaimsMapping ClaimsMapping {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClaimsMapping>("claimsMapping"); }
            set { BackingStore?.Set("claimsMapping", value); }
        }
        /// <summary>The client identifier for the application obtained when registering the application with the identity provider. Required.</summary>
        public string ClientId {
            get { return BackingStore?.Get<string>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
        /// <summary>The client secret for the application obtained when registering the application with the identity provider. The clientSecret has a dependency on responseType. When responseType is code, a secret is required for the auth code exchange.When responseType is id_token the secret is not required because there is no code exchange. The id_token is returned directly from the authorization response. This is write-only. A read operation returns ****.</summary>
        public string ClientSecret {
            get { return BackingStore?.Get<string>("clientSecret"); }
            set { BackingStore?.Set("clientSecret", value); }
        }
        /// <summary>The domain hint can be used to skip directly to the sign-in page of the specified identity provider, instead of having the user make a selection among the list of available identity providers.</summary>
        public string DomainHint {
            get { return BackingStore?.Get<string>("domainHint"); }
            set { BackingStore?.Set("domainHint", value); }
        }
        /// <summary>The URL for the metadata document of the OpenID Connect identity provider. Every OpenID Connect identity provider describes a metadata document that contains most of the information required to perform sign-in. This includes information such as the URLs to use and the location of the service&apos;s public signing keys. The OpenID Connect metadata document is always located at an endpoint that ends in .well-known/openid-configuration. Provide the metadata URL for the OpenID Connect identity provider you add. Read-only. Required.</summary>
        public string MetadataUrl {
            get { return BackingStore?.Get<string>("metadataUrl"); }
            set { BackingStore?.Set("metadataUrl", value); }
        }
        /// <summary>The responseMode property</summary>
        public OpenIdConnectResponseMode? ResponseMode {
            get { return BackingStore?.Get<OpenIdConnectResponseMode?>("responseMode"); }
            set { BackingStore?.Set("responseMode", value); }
        }
        /// <summary>The responseType property</summary>
        public OpenIdConnectResponseTypes? ResponseType {
            get { return BackingStore?.Get<OpenIdConnectResponseTypes?>("responseType"); }
            set { BackingStore?.Set("responseType", value); }
        }
        /// <summary>Scope defines the information and permissions you are looking to gather from your custom identity provider. OpenID Connect requests must contain the openid scope value in order to receive the ID token from the identity provider. Without the ID token, users are not able to sign in to Azure AD B2C using the custom identity provider. Other scopes can be appended, separated by a space. For more details about the scope limitations see RFC6749 Section 3.3. Required.</summary>
        public string Scope {
            get { return BackingStore?.Get<string>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>
        /// Instantiates a new OpenIdConnectIdentityProvider and sets the default values.
        /// </summary>
        public OpenIdConnectIdentityProvider() : base() {
            OdataType = "#microsoft.graph.openIdConnectIdentityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OpenIdConnectIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OpenIdConnectIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"claimsMapping", n => { ClaimsMapping = n.GetObjectValue<Microsoft.Graph.Beta.Models.ClaimsMapping>(Microsoft.Graph.Beta.Models.ClaimsMapping.CreateFromDiscriminatorValue); } },
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"clientSecret", n => { ClientSecret = n.GetStringValue(); } },
                {"domainHint", n => { DomainHint = n.GetStringValue(); } },
                {"metadataUrl", n => { MetadataUrl = n.GetStringValue(); } },
                {"responseMode", n => { ResponseMode = n.GetEnumValue<OpenIdConnectResponseMode>(); } },
                {"responseType", n => { ResponseType = n.GetEnumValue<OpenIdConnectResponseTypes>(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ClaimsMapping>("claimsMapping", ClaimsMapping);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("domainHint", DomainHint);
            writer.WriteStringValue("metadataUrl", MetadataUrl);
            writer.WriteEnumValue<OpenIdConnectResponseMode>("responseMode", ResponseMode);
            writer.WriteEnumValue<OpenIdConnectResponseTypes>("responseType", ResponseType);
            writer.WriteStringValue("scope", Scope);
        }
    }
}
