using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ServicePrincipalCreationConditionSet : Entity, IParsable {
        /// <summary>The applicationIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationIds {
            get { return BackingStore?.Get<List<string>?>("applicationIds"); }
            set { BackingStore?.Set("applicationIds", value); }
        }
#nullable restore
#else
        public List<string> ApplicationIds {
            get { return BackingStore?.Get<List<string>>("applicationIds"); }
            set { BackingStore?.Set("applicationIds", value); }
        }
#endif
        /// <summary>The applicationPublisherIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationPublisherIds {
            get { return BackingStore?.Get<List<string>?>("applicationPublisherIds"); }
            set { BackingStore?.Set("applicationPublisherIds", value); }
        }
#nullable restore
#else
        public List<string> ApplicationPublisherIds {
            get { return BackingStore?.Get<List<string>>("applicationPublisherIds"); }
            set { BackingStore?.Set("applicationPublisherIds", value); }
        }
#endif
        /// <summary>The applicationsFromVerifiedPublisherOnly property</summary>
        public bool? ApplicationsFromVerifiedPublisherOnly {
            get { return BackingStore?.Get<bool?>("applicationsFromVerifiedPublisherOnly"); }
            set { BackingStore?.Set("applicationsFromVerifiedPublisherOnly", value); }
        }
        /// <summary>The applicationTenantIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationTenantIds {
            get { return BackingStore?.Get<List<string>?>("applicationTenantIds"); }
            set { BackingStore?.Set("applicationTenantIds", value); }
        }
#nullable restore
#else
        public List<string> ApplicationTenantIds {
            get { return BackingStore?.Get<List<string>>("applicationTenantIds"); }
            set { BackingStore?.Set("applicationTenantIds", value); }
        }
#endif
        /// <summary>The certifiedApplicationsOnly property</summary>
        public bool? CertifiedApplicationsOnly {
            get { return BackingStore?.Get<bool?>("certifiedApplicationsOnly"); }
            set { BackingStore?.Set("certifiedApplicationsOnly", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServicePrincipalCreationConditionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalCreationConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationIds", n => { ApplicationIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"applicationPublisherIds", n => { ApplicationPublisherIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"applicationsFromVerifiedPublisherOnly", n => { ApplicationsFromVerifiedPublisherOnly = n.GetBoolValue(); } },
                {"applicationTenantIds", n => { ApplicationTenantIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"certifiedApplicationsOnly", n => { CertifiedApplicationsOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationIds", ApplicationIds);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationPublisherIds", ApplicationPublisherIds);
            writer.WriteBoolValue("applicationsFromVerifiedPublisherOnly", ApplicationsFromVerifiedPublisherOnly);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationTenantIds", ApplicationTenantIds);
            writer.WriteBoolValue("certifiedApplicationsOnly", CertifiedApplicationsOnly);
        }
    }
}
