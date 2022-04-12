using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CustomCalloutExtension : Entity, IParsable {
        /// <summary>Configuration for securing the API call to the logic app. For example, using OAuth client credentials flow.</summary>
        public CustomExtensionAuthenticationConfiguration AuthenticationConfiguration { get; set; }
        /// <summary>HTTP connection settings that define how long Azure AD can wait for a connection to a logic app, how many times you can retry a timed-out connection and the exception scenarios when retries are allowed.</summary>
        public CustomExtensionClientConfiguration ClientConfiguration { get; set; }
        /// <summary>Description for the customCalloutExtension object.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the customCalloutExtension object.</summary>
        public string DisplayName { get; set; }
        /// <summary>The type and details for configuring the endpoint to call the logic app&apos;s workflow.</summary>
        public CustomExtensionEndpointConfiguration EndpointConfiguration { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomCalloutExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomCalloutExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationConfiguration", n => { AuthenticationConfiguration = n.GetObjectValue<CustomExtensionAuthenticationConfiguration>(CustomExtensionAuthenticationConfiguration.CreateFromDiscriminatorValue); } },
                {"clientConfiguration", n => { ClientConfiguration = n.GetObjectValue<CustomExtensionClientConfiguration>(CustomExtensionClientConfiguration.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endpointConfiguration", n => { EndpointConfiguration = n.GetObjectValue<CustomExtensionEndpointConfiguration>(CustomExtensionEndpointConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomExtensionAuthenticationConfiguration>("authenticationConfiguration", AuthenticationConfiguration);
            writer.WriteObjectValue<CustomExtensionClientConfiguration>("clientConfiguration", ClientConfiguration);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<CustomExtensionEndpointConfiguration>("endpointConfiguration", EndpointConfiguration);
        }
    }
}
