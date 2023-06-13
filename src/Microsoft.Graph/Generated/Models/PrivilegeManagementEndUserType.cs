using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of user account on Windows that was used to performed the elevation.</summary>
    public enum PrivilegeManagementEndUserType {
        /// <summary>Default. Unable to determine the login type of the user.</summary>
        [EnumMember(Value = "undetermined")]
        Undetermined,
        /// <summary>The user who performed the elevation logged in using an Azure Active Directory (Azure AD) account.</summary>
        [EnumMember(Value = "azureAd")]
        AzureAd,
        /// <summary>The user who performed the elevation logged in using Hybrid Azure AD joined account.</summary>
        [EnumMember(Value = "hybrid")]
        Hybrid,
        /// <summary>The user who performed the elevation logged in using a Windows local account.</summary>
        [EnumMember(Value = "local")]
        Local,
        /// <summary>Evolvable emuneration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
