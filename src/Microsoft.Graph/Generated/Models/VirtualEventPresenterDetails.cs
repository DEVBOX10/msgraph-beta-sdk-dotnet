// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventPresenterDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Bio of the presenter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Bio {
            get { return BackingStore?.Get<ItemBody?>("bio"); }
            set { BackingStore?.Set("bio", value); }
        }
#nullable restore
#else
        public ItemBody Bio {
            get { return BackingStore?.Get<ItemBody>("bio"); }
            set { BackingStore?.Set("bio", value); }
        }
#endif
        /// <summary>The presenter&apos;s company name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company {
            get { return BackingStore?.Get<string?>("company"); }
            set { BackingStore?.Set("company", value); }
        }
#nullable restore
#else
        public string Company {
            get { return BackingStore?.Get<string>("company"); }
            set { BackingStore?.Set("company", value); }
        }
#endif
        /// <summary>The presenter&apos;s job title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The presenter&apos;s LinkedIn profile URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedInProfileWebUrl {
            get { return BackingStore?.Get<string?>("linkedInProfileWebUrl"); }
            set { BackingStore?.Set("linkedInProfileWebUrl", value); }
        }
#nullable restore
#else
        public string LinkedInProfileWebUrl {
            get { return BackingStore?.Get<string>("linkedInProfileWebUrl"); }
            set { BackingStore?.Set("linkedInProfileWebUrl", value); }
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
        /// <summary>The presenter&apos;s personal website URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalSiteWebUrl {
            get { return BackingStore?.Get<string?>("personalSiteWebUrl"); }
            set { BackingStore?.Set("personalSiteWebUrl", value); }
        }
#nullable restore
#else
        public string PersonalSiteWebUrl {
            get { return BackingStore?.Get<string>("personalSiteWebUrl"); }
            set { BackingStore?.Set("personalSiteWebUrl", value); }
        }
#endif
        /// <summary>The presenter&apos;s Twitter profile URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwitterProfileWebUrl {
            get { return BackingStore?.Get<string?>("twitterProfileWebUrl"); }
            set { BackingStore?.Set("twitterProfileWebUrl", value); }
        }
#nullable restore
#else
        public string TwitterProfileWebUrl {
            get { return BackingStore?.Get<string>("twitterProfileWebUrl"); }
            set { BackingStore?.Set("twitterProfileWebUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new virtualEventPresenterDetails and sets the default values.
        /// </summary>
        public VirtualEventPresenterDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VirtualEventPresenterDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventPresenterDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bio", n => { Bio = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"company", n => { Company = n.GetStringValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"linkedInProfileWebUrl", n => { LinkedInProfileWebUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"personalSiteWebUrl", n => { PersonalSiteWebUrl = n.GetStringValue(); } },
                {"twitterProfileWebUrl", n => { TwitterProfileWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ItemBody>("bio", Bio);
            writer.WriteStringValue("company", Company);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("linkedInProfileWebUrl", LinkedInProfileWebUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("personalSiteWebUrl", PersonalSiteWebUrl);
            writer.WriteStringValue("twitterProfileWebUrl", TwitterProfileWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
