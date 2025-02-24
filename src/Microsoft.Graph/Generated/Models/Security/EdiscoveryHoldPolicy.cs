// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryHoldPolicy : PolicyBase, IParsable {
        /// <summary>KQL query that specifies content to be held in the specified locations. To learn more, see Keyword queries and search conditions for Content Search and eDiscovery.  To hold all content in the specified locations, leave contentQuery blank.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentQuery {
            get { return BackingStore?.Get<string?>("contentQuery"); }
            set { BackingStore?.Set("contentQuery", value); }
        }
#nullable restore
#else
        public string ContentQuery {
            get { return BackingStore?.Get<string>("contentQuery"); }
            set { BackingStore?.Set("contentQuery", value); }
        }
#endif
        /// <summary>Lists any errors that happened while placing the hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Errors {
            get { return BackingStore?.Get<List<string>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<string> Errors {
            get { return BackingStore?.Get<List<string>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>Indicates whether the hold is enabled and actively holding content.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Data sources that represent SharePoint sites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SiteSource>? SiteSources {
            get { return BackingStore?.Get<List<SiteSource>?>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#nullable restore
#else
        public List<SiteSource> SiteSources {
            get { return BackingStore?.Get<List<SiteSource>>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#endif
        /// <summary>Data sources that represent Exchange mailboxes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSource>? UserSources {
            get { return BackingStore?.Get<List<UserSource>?>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#nullable restore
#else
        public List<UserSource> UserSources {
            get { return BackingStore?.Get<List<UserSource>>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ediscoveryHoldPolicy and sets the default values.
        /// </summary>
        public EdiscoveryHoldPolicy() : base() {
            OdataType = "#microsoft.graph.security.ediscoveryHoldPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryHoldPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryHoldPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentQuery", n => { ContentQuery = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<SiteSource>(SiteSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userSources", n => { UserSources = n.GetCollectionOfObjectValues<UserSource>(UserSource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteCollectionOfPrimitiveValues<string>("errors", Errors);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
