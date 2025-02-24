// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Finding : Entity, IParsable {
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Finding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.awsExternalSystemAccessFinding" => new AwsExternalSystemAccessFinding(),
                "#microsoft.graph.awsExternalSystemAccessRoleFinding" => new AwsExternalSystemAccessRoleFinding(),
                "#microsoft.graph.awsIdentityAccessManagementKeyAgeFinding" => new AwsIdentityAccessManagementKeyAgeFinding(),
                "#microsoft.graph.awsIdentityAccessManagementKeyUsageFinding" => new AwsIdentityAccessManagementKeyUsageFinding(),
                "#microsoft.graph.awsSecretInformationAccessFinding" => new AwsSecretInformationAccessFinding(),
                "#microsoft.graph.awsSecurityToolAdministrationFinding" => new AwsSecurityToolAdministrationFinding(),
                "#microsoft.graph.encryptedAwsStorageBucketFinding" => new EncryptedAwsStorageBucketFinding(),
                "#microsoft.graph.encryptedAzureStorageAccountFinding" => new EncryptedAzureStorageAccountFinding(),
                "#microsoft.graph.encryptedGcpStorageBucketFinding" => new EncryptedGcpStorageBucketFinding(),
                "#microsoft.graph.externallyAccessibleAwsStorageBucketFinding" => new ExternallyAccessibleAwsStorageBucketFinding(),
                "#microsoft.graph.externallyAccessibleAzureBlobContainerFinding" => new ExternallyAccessibleAzureBlobContainerFinding(),
                "#microsoft.graph.externallyAccessibleGcpStorageBucketFinding" => new ExternallyAccessibleGcpStorageBucketFinding(),
                "#microsoft.graph.identityFinding" => new IdentityFinding(),
                "#microsoft.graph.inactiveAwsResourceFinding" => new InactiveAwsResourceFinding(),
                "#microsoft.graph.inactiveAwsRoleFinding" => new InactiveAwsRoleFinding(),
                "#microsoft.graph.inactiveAzureServicePrincipalFinding" => new InactiveAzureServicePrincipalFinding(),
                "#microsoft.graph.inactiveGcpServiceAccountFinding" => new InactiveGcpServiceAccountFinding(),
                "#microsoft.graph.inactiveGroupFinding" => new InactiveGroupFinding(),
                "#microsoft.graph.inactiveServerlessFunctionFinding" => new InactiveServerlessFunctionFinding(),
                "#microsoft.graph.inactiveUserFinding" => new InactiveUserFinding(),
                "#microsoft.graph.openAwsSecurityGroupFinding" => new OpenAwsSecurityGroupFinding(),
                "#microsoft.graph.openNetworkAzureSecurityGroupFinding" => new OpenNetworkAzureSecurityGroupFinding(),
                "#microsoft.graph.overprovisionedAwsResourceFinding" => new OverprovisionedAwsResourceFinding(),
                "#microsoft.graph.overprovisionedAwsRoleFinding" => new OverprovisionedAwsRoleFinding(),
                "#microsoft.graph.overprovisionedAzureServicePrincipalFinding" => new OverprovisionedAzureServicePrincipalFinding(),
                "#microsoft.graph.overprovisionedGcpServiceAccountFinding" => new OverprovisionedGcpServiceAccountFinding(),
                "#microsoft.graph.overprovisionedServerlessFunctionFinding" => new OverprovisionedServerlessFunctionFinding(),
                "#microsoft.graph.overprovisionedUserFinding" => new OverprovisionedUserFinding(),
                "#microsoft.graph.privilegeEscalationAwsResourceFinding" => new PrivilegeEscalationAwsResourceFinding(),
                "#microsoft.graph.privilegeEscalationAwsRoleFinding" => new PrivilegeEscalationAwsRoleFinding(),
                "#microsoft.graph.privilegeEscalationFinding" => new PrivilegeEscalationFinding(),
                "#microsoft.graph.privilegeEscalationGcpServiceAccountFinding" => new PrivilegeEscalationGcpServiceAccountFinding(),
                "#microsoft.graph.privilegeEscalationUserFinding" => new PrivilegeEscalationUserFinding(),
                "#microsoft.graph.secretInformationAccessAwsResourceFinding" => new SecretInformationAccessAwsResourceFinding(),
                "#microsoft.graph.secretInformationAccessAwsRoleFinding" => new SecretInformationAccessAwsRoleFinding(),
                "#microsoft.graph.secretInformationAccessAwsServerlessFunctionFinding" => new SecretInformationAccessAwsServerlessFunctionFinding(),
                "#microsoft.graph.secretInformationAccessAwsUserFinding" => new SecretInformationAccessAwsUserFinding(),
                "#microsoft.graph.securityToolAwsResourceAdministratorFinding" => new SecurityToolAwsResourceAdministratorFinding(),
                "#microsoft.graph.securityToolAwsRoleAdministratorFinding" => new SecurityToolAwsRoleAdministratorFinding(),
                "#microsoft.graph.securityToolAwsServerlessFunctionAdministratorFinding" => new SecurityToolAwsServerlessFunctionAdministratorFinding(),
                "#microsoft.graph.securityToolAwsUserAdministratorFinding" => new SecurityToolAwsUserAdministratorFinding(),
                "#microsoft.graph.superAwsResourceFinding" => new SuperAwsResourceFinding(),
                "#microsoft.graph.superAwsRoleFinding" => new SuperAwsRoleFinding(),
                "#microsoft.graph.superAzureServicePrincipalFinding" => new SuperAzureServicePrincipalFinding(),
                "#microsoft.graph.superGcpServiceAccountFinding" => new SuperGcpServiceAccountFinding(),
                "#microsoft.graph.superServerlessFunctionFinding" => new SuperServerlessFunctionFinding(),
                "#microsoft.graph.superUserFinding" => new SuperUserFinding(),
                "#microsoft.graph.unenforcedMfaAwsUserFinding" => new UnenforcedMfaAwsUserFinding(),
                "#microsoft.graph.virtualMachineWithAwsStorageBucketAccessFinding" => new VirtualMachineWithAwsStorageBucketAccessFinding(),
                _ => new Finding(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
        }
    }
}
