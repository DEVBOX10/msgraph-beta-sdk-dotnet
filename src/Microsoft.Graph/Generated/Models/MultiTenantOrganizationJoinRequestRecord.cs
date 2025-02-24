// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MultiTenantOrganizationJoinRequestRecord : Entity, IParsable {
        /// <summary>Tenant ID of the Microsoft Entra tenant that added a tenant to the multi-tenant organization. To reset a failed join request, set addedByTenantId to 00000000-0000-0000-0000-000000000000. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddedByTenantId {
            get { return BackingStore?.Get<string?>("addedByTenantId"); }
            set { BackingStore?.Set("addedByTenantId", value); }
        }
#nullable restore
#else
        public string AddedByTenantId {
            get { return BackingStore?.Get<string>("addedByTenantId"); }
            set { BackingStore?.Set("addedByTenantId", value); }
        }
#endif
        /// <summary>State of the tenant in the multi-tenant organization. The possible values are: pending, active, removed, unknownFutureValue. Tenants in the pending state must join the multi-tenant organization to participate in the multi-tenant organization. Tenants in the active state can participate in the multi-tenant organization. Tenants in the removed state are in the process of being removed from the multi-tenant organization. Read-only.</summary>
        public MultiTenantOrganizationMemberState? MemberState {
            get { return BackingStore?.Get<MultiTenantOrganizationMemberState?>("memberState"); }
            set { BackingStore?.Set("memberState", value); }
        }
        /// <summary>Role of the tenant in the multi-tenant organization. The possible values are: owner, member (default), unknownFutureValue. Tenants with the owner role can manage the multi-tenant organization. There can be multiple tenants with the owner role in a multi-tenant organization. Tenants with the member role can participate in a multi-tenant organization.</summary>
        public MultiTenantOrganizationMemberRole? Role {
            get { return BackingStore?.Get<MultiTenantOrganizationMemberRole?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>Details of the processing status for a tenant joining a multi-tenant organization. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MultiTenantOrganizationJoinRequestTransitionDetails? TransitionDetails {
            get { return BackingStore?.Get<MultiTenantOrganizationJoinRequestTransitionDetails?>("transitionDetails"); }
            set { BackingStore?.Set("transitionDetails", value); }
        }
#nullable restore
#else
        public MultiTenantOrganizationJoinRequestTransitionDetails TransitionDetails {
            get { return BackingStore?.Get<MultiTenantOrganizationJoinRequestTransitionDetails>("transitionDetails"); }
            set { BackingStore?.Set("transitionDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MultiTenantOrganizationJoinRequestRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MultiTenantOrganizationJoinRequestRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addedByTenantId", n => { AddedByTenantId = n.GetStringValue(); } },
                {"memberState", n => { MemberState = n.GetEnumValue<MultiTenantOrganizationMemberState>(); } },
                {"role", n => { Role = n.GetEnumValue<MultiTenantOrganizationMemberRole>(); } },
                {"transitionDetails", n => { TransitionDetails = n.GetObjectValue<MultiTenantOrganizationJoinRequestTransitionDetails>(MultiTenantOrganizationJoinRequestTransitionDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("addedByTenantId", AddedByTenantId);
            writer.WriteEnumValue<MultiTenantOrganizationMemberState>("memberState", MemberState);
            writer.WriteEnumValue<MultiTenantOrganizationMemberRole>("role", Role);
            writer.WriteObjectValue<MultiTenantOrganizationJoinRequestTransitionDetails>("transitionDetails", TransitionDetails);
        }
    }
}
