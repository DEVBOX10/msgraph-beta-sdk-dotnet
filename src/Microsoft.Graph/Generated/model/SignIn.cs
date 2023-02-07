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
    /// The type Sign In.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SignIn>))]
    public partial class SignIn : Entity
    {
    
        /// <summary>
        /// Gets or sets app display name.
        /// The application name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The application identifier in Azure Active Directory. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets applied conditional access policies.
        /// A list of conditional access policies that are triggered by the corresponding sign-in activity.
        /// </summary>
        [JsonPropertyName("appliedConditionalAccessPolicies")]
        public IEnumerable<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets applied event listeners.
        /// Detailed information about the listeners, such as Azure Logic Apps and Azure Functions, that were triggered by the corresponding events in the sign-in event.
        /// </summary>
        [JsonPropertyName("appliedEventListeners")]
        public IEnumerable<AppliedAuthenticationEventListener> AppliedEventListeners { get; set; }
    
        /// <summary>
        /// Gets or sets authentication app device details.
        /// Provides details about the app and device used during an Azure AD authentication step.
        /// </summary>
        [JsonPropertyName("authenticationAppDeviceDetails")]
        public AuthenticationAppDeviceDetails AuthenticationAppDeviceDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication app policy evaluation details.
        /// Provides details of the Azure AD policies applied to a user and client authentication app during an authentication step.
        /// </summary>
        [JsonPropertyName("authenticationAppPolicyEvaluationDetails")]
        public IEnumerable<AuthenticationAppPolicyDetails> AuthenticationAppPolicyEvaluationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication context class references.
        /// Contains a collection of values that represent the conditional access authentication contexts applied to the sign-in.
        /// </summary>
        [JsonPropertyName("authenticationContextClassReferences")]
        public IEnumerable<AuthenticationContext> AuthenticationContextClassReferences { get; set; }
    
        /// <summary>
        /// Gets or sets authentication details.
        /// The result of the authentication attempt and additional details on the authentication method.
        /// </summary>
        [JsonPropertyName("authenticationDetails")]
        public IEnumerable<AuthenticationDetail> AuthenticationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication methods used.
        /// The authentication methods used. Possible values: SMS, Authenticator App, App Verification code, Password, FIDO, PTA, or PHS.
        /// </summary>
        [JsonPropertyName("authenticationMethodsUsed")]
        public IEnumerable<string> AuthenticationMethodsUsed { get; set; }
    
        /// <summary>
        /// Gets or sets authentication processing details.
        /// Additional authentication processing details, such as the agent name in case of PTA/PHS or Server/farm name in case of federated authentication.
        /// </summary>
        [JsonPropertyName("authenticationProcessingDetails")]
        public IEnumerable<KeyValue> AuthenticationProcessingDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication protocol.
        /// Lists the protocol type or grant type used in the authentication. The possible values are: none, oAuth2, ropc, wsFederation, saml20, deviceCode, unknownFutureValue. For authentications that use protocols other than the possible values listed, the protocol type is listed as none.
        /// </summary>
        [JsonPropertyName("authenticationProtocol")]
        public ProtocolType? AuthenticationProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement.
        /// This holds the highest level of authentication needed through all the sign-in steps, for sign-in to succeed. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("authenticationRequirement")]
        public string AuthenticationRequirement { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement policies.
        /// Sources of authentication requirement, such as conditional access, per-user MFA, identity protection, and security defaults.
        /// </summary>
        [JsonPropertyName("authenticationRequirementPolicies")]
        public IEnumerable<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets autonomous system number.
        /// The Autonomous System Number (ASN) of the network used by the actor.
        /// </summary>
        [JsonPropertyName("autonomousSystemNumber")]
        public Int32? AutonomousSystemNumber { get; set; }
    
        /// <summary>
        /// Gets or sets azure resource id.
        /// Contains a fully qualified Azure Resource Manager ID of an Azure resource accessed during the sign-in.
        /// </summary>
        [JsonPropertyName("azureResourceId")]
        public string AzureResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets client app used.
        /// The legacy client used for sign-in activity. For example: Browser, Exchange ActiveSync, Modern clients, IMAP, MAPI, SMTP, or POP. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("clientAppUsed")]
        public string ClientAppUsed { get; set; }
    
        /// <summary>
        /// Gets or sets client credential type.
        /// Describes the credential type that a user client or service principal provided to Azure AD to authenticate itself. You may wish to review clientCredentialType to track and eliminate less secure credential types or to watch for clients and service principals using anomalous credential types. The possible values are: none, clientSecret, clientAssertion, federatedIdentityCredential, managedIdentity, certificate, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("clientCredentialType")]
        public ClientCredentialType? ClientCredentialType { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access status.
        /// The status of the conditional access policy triggered. Possible values: success, failure, notApplied, or unknownFutureValue. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("conditionalAccessStatus")]
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// The identifier that's sent from the client when sign-in is initiated. This is used for troubleshooting the corresponding sign-in activity when calling for support. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the sign-in was initiated. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets cross tenant access type.
        /// Describes the type of cross-tenant access used by the actor to access the resource. Possible values are: none, b2bCollaboration, b2bDirectConnect, microsoftSupport, serviceProvider, unknownFutureValue. If the sign in did not cross tenant boundaries, the value is none.
        /// </summary>
        [JsonPropertyName("crossTenantAccessType")]
        public SignInAccessType? CrossTenantAccessType { get; set; }
    
        /// <summary>
        /// Gets or sets device detail.
        /// The device information from where the sign-in occurred. Includes information such as deviceId, OS, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSystem properties.
        /// </summary>
        [JsonPropertyName("deviceDetail")]
        public DeviceDetail DeviceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets federated credential id.
        /// Contains the identifier of an application's federated identity credential, if a federated identity credential was used to sign in.
        /// </summary>
        [JsonPropertyName("federatedCredentialId")]
        public string FederatedCredentialId { get; set; }
    
        /// <summary>
        /// Gets or sets flagged for review.
        /// During a failed sign in, a user may click a button in the Azure portal to mark the failed event for tenant admins. If a user clicked the button to flag the failed sign in, this value is true.
        /// </summary>
        [JsonPropertyName("flaggedForReview")]
        public bool? FlaggedForReview { get; set; }
    
        /// <summary>
        /// Gets or sets home tenant id.
        /// The tenant identifier of the user initiating the sign in. Not applicable in Managed Identity or service principal sign ins.
        /// </summary>
        [JsonPropertyName("homeTenantId")]
        public string HomeTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets home tenant name.
        /// For user sign ins, the identifier of the tenant that the user is a member of. Only populated in cases where the home tenant has provided affirmative consent to Azure AD to show the tenant content.
        /// </summary>
        [JsonPropertyName("homeTenantName")]
        public string HomeTenantName { get; set; }
    
        /// <summary>
        /// Gets or sets incoming token type.
        /// Indicates the token types that were presented to Azure AD to authenticate the actor in the sign in. The possible values are: none, primaryRefreshToken, saml11, saml20, unknownFutureValue, remoteDesktopToken.  NOTE Azure AD may have also used token types not listed in this Enum type to authenticate the actor. Do not infer the lack of a token if it is not one of the types listed. Also, please note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: remoteDesktopToken.
        /// </summary>
        [JsonPropertyName("incomingTokenType")]
        public IncomingTokenType? IncomingTokenType { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// The IP address of the client from where the sign-in occurred. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets ip address from resource provider.
        /// The IP address a user used to reach a resource provider, used to determine Conditional Access compliance for some policies. For example, when a user interacts with Exchange Online, the IP address Exchange receives from the user may be recorded here. This value is often null.
        /// </summary>
        [JsonPropertyName("ipAddressFromResourceProvider")]
        public string IpAddressFromResourceProvider { get; set; }
    
        /// <summary>
        /// Gets or sets is interactive.
        /// Indicates whether a user sign in is interactive. In interactive sign in, the user provides an authentication factor to Azure AD. These factors include passwords, responses to MFA challenges, biometric factors, or QR codes that a user provides to Azure AD or an associated app. In non-interactive sign in, the user doesn't provide an authentication factor. Instead, the client app uses a token or code to authenticate or access a resource on behalf of a user. Non-interactive sign ins are commonly used for a client to sign in on a user's behalf in a process transparent to the user.
        /// </summary>
        [JsonPropertyName("isInteractive")]
        public bool? IsInteractive { get; set; }
    
        /// <summary>
        /// Gets or sets is tenant restricted.
        /// Shows whether the sign in event was subject to an Azure AD tenant restriction policy.
        /// </summary>
        [JsonPropertyName("isTenantRestricted")]
        public bool? IsTenantRestricted { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The city, state, and 2 letter country code from where the sign-in occurred. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.
        /// </summary>
        [JsonPropertyName("location")]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets mfa detail.
        /// </summary>
        [JsonPropertyName("mfaDetail")]
        public MfaDetail MfaDetail { get; set; }
    
        /// <summary>
        /// Gets or sets network location details.
        /// The network location details including the type of network used and its names.
        /// </summary>
        [JsonPropertyName("networkLocationDetails")]
        public IEnumerable<NetworkLocationDetail> NetworkLocationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets original request id.
        /// The request identifier of the first request in the authentication sequence. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("originalRequestId")]
        public string OriginalRequestId { get; set; }
    
        /// <summary>
        /// Gets or sets private link details.
        /// Contains information about the Azure AD Private Link policy that is associated with the sign in event.
        /// </summary>
        [JsonPropertyName("privateLinkDetails")]
        public PrivateLinkDetails PrivateLinkDetails { get; set; }
    
        /// <summary>
        /// Gets or sets processing time in milliseconds.
        /// The request processing time in milliseconds in AD STS.
        /// </summary>
        [JsonPropertyName("processingTimeInMilliseconds")]
        public Int32? ProcessingTimeInMilliseconds { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// The name of the resource that the user signed in to. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("resourceDisplayName")]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// The identifier of the resource that the user signed in to. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets resource service principal id.
        /// The identifier of the service principal representing the target resource in the sign-in event.
        /// </summary>
        [JsonPropertyName("resourceServicePrincipalId")]
        public string ResourceServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets resource tenant id.
        /// The tenant identifier of the resource referenced in the sign in.
        /// </summary>
        [JsonPropertyName("resourceTenantId")]
        public string ResourceTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// The reason behind a specific state of a risky user, sign-in, or a risk event. Possible values: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, or unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonPropertyName("riskDetail")]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types_v2.
        /// The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("riskEventTypes_v2")]
        public IEnumerable<string> RiskEventTypes_v2 { get; set; }
    
        /// <summary>
        /// Gets or sets risk level aggregated.
        /// The aggregated risk level. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonPropertyName("riskLevelAggregated")]
        public RiskLevel? RiskLevelAggregated { get; set; }
    
        /// <summary>
        /// Gets or sets risk level during sign in.
        /// The risk level during sign-in. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonPropertyName("riskLevelDuringSignIn")]
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// The risk state of a risky user, sign-in, or a risk event. Possible values: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, or unknownFutureValue. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("riskState")]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets service principal credential key id.
        /// The unique identifier of the key credential used by the service principal to authenticate.
        /// </summary>
        [JsonPropertyName("servicePrincipalCredentialKeyId")]
        public string ServicePrincipalCredentialKeyId { get; set; }
    
        /// <summary>
        /// Gets or sets service principal credential thumbprint.
        /// The certificate thumbprint of the certificate used by the service principal to authenticate.
        /// </summary>
        [JsonPropertyName("servicePrincipalCredentialThumbprint")]
        public string ServicePrincipalCredentialThumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets service principal id.
        /// The application identifier used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("servicePrincipalId")]
        public string ServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets service principal name.
        /// The application name used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("servicePrincipalName")]
        public string ServicePrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets session lifetime policies.
        /// Any conditional access session management policies that were applied during the sign-in event.
        /// </summary>
        [JsonPropertyName("sessionLifetimePolicies")]
        public IEnumerable<SessionLifetimePolicy> SessionLifetimePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets sign in event types.
        /// Indicates the category of sign in that the event represents. For user sign ins, the category can be interactiveUser or nonInteractiveUser and corresponds to the value for the isInteractive property on the signin resource. For managed identity sign ins, the category is managedIdentity. For service principal sign ins, the category is servicePrincipal. Possible values are: interactiveUser, nonInteractiveUser, servicePrincipal, managedIdentity, unknownFutureValue. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("signInEventTypes")]
        public IEnumerable<string> SignInEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets sign in identifier.
        /// The identification that the user provided to sign in. It may be the userPrincipalName but it's also populated when a user signs in using other identifiers.
        /// </summary>
        [JsonPropertyName("signInIdentifier")]
        public string SignInIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets sign in identifier type.
        /// The type of sign in identifier. Possible values are: userPrincipalName, phoneNumber, proxyAddress, qrCode, onPremisesUserPrincipalName, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("signInIdentifierType")]
        public SignInIdentifierType? SignInIdentifierType { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.
        /// </summary>
        [JsonPropertyName("status")]
        public SignInStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer name.
        /// The name of the identity provider. For example, sts.microsoft.com. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("tokenIssuerName")]
        public string TokenIssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer type.
        /// The type of identity provider. The possible values are: AzureAD, ADFederationServices, UnknownFutureValue, AzureADBackupAuth, ADFederationServicesMFAAdapter, NPSExtension. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: AzureADBackupAuth , ADFederationServicesMFAAdapter , NPSExtension.
        /// </summary>
        [JsonPropertyName("tokenIssuerType")]
        public TokenIssuerType? TokenIssuerType { get; set; }
    
        /// <summary>
        /// Gets or sets unique token identifier.
        /// A unique base64 encoded request identifier used to track tokens issued by Azure AD as they are redeemed at resource providers.
        /// </summary>
        [JsonPropertyName("uniqueTokenIdentifier")]
        public string UniqueTokenIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets user agent.
        /// The user agent information related to sign-in. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// The display name of the user. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The identifier of the user. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The UPN of the user. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// Identifies whether the user is a member or guest in the tenant. Possible values are: member, guest, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("userType")]
        public SignInUserType? UserType { get; set; }
    
    }
}

