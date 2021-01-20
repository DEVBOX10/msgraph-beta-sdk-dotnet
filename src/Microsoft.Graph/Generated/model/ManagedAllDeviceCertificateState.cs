// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Managed All Device Certificate State.
    /// </summary>
    public partial class ManagedAllDeviceCertificateState : Entity
    {
    
		///<summary>
		/// The ManagedAllDeviceCertificateState constructor
		///</summary>
        public ManagedAllDeviceCertificateState()
        {
            this.ODataType = "microsoft.graph.managedAllDeviceCertificateState";
        }
	
        /// <summary>
        /// Gets or sets certificate expiration date time.
        /// Certificate expiry date
        /// </summary>
        [JsonPropertyName("certificateExpirationDateTime")]
        public DateTimeOffset? CertificateExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets certificate extended key usages.
        /// Enhanced Key Usage
        /// </summary>
        [JsonPropertyName("certificateExtendedKeyUsages")]
        public string CertificateExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets certificate issuance date time.
        /// Issuance date
        /// </summary>
        [JsonPropertyName("certificateIssuanceDateTime")]
        public DateTimeOffset? CertificateIssuanceDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets certificate issuer name.
        /// Issuer
        /// </summary>
        [JsonPropertyName("certificateIssuerName")]
        public string CertificateIssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets certificate key usages.
        /// Key Usage
        /// </summary>
        [JsonPropertyName("certificateKeyUsages")]
        public Int32? CertificateKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets certificate revoke status.
        /// Revoke status. Possible values are: none, pending, issued, failed, revoked.
        /// </summary>
        [JsonPropertyName("certificateRevokeStatus")]
        public CertificateRevocationStatus? CertificateRevokeStatus { get; set; }
    
        /// <summary>
        /// Gets or sets certificate revoke status last change date time.
        /// The time the revoke status was last changed
        /// </summary>
        [JsonPropertyName("certificateRevokeStatusLastChangeDateTime")]
        public DateTimeOffset? CertificateRevokeStatusLastChangeDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets certificate serial number.
        /// Serial number
        /// </summary>
        [JsonPropertyName("certificateSerialNumber")]
        public string CertificateSerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets certificate subject name.
        /// Certificate subject name
        /// </summary>
        [JsonPropertyName("certificateSubjectName")]
        public string CertificateSubjectName { get; set; }
    
        /// <summary>
        /// Gets or sets certificate thumbprint.
        /// Thumbprint
        /// </summary>
        [JsonPropertyName("certificateThumbprint")]
        public string CertificateThumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets managed device display name.
        /// Device display name
        /// </summary>
        [JsonPropertyName("managedDeviceDisplayName")]
        public string ManagedDeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

