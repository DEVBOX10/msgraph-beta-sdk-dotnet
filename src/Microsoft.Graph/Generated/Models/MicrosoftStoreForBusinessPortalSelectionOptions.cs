// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Portal to which admin syncs available Microsoft Store for Business apps. This is available in the Intune Admin Console.</summary>
    [Flags]
    public enum MicrosoftStoreForBusinessPortalSelectionOptions {
        /// <summary>This option is not available for the account</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Intune Company Portal only.</summary>
        [EnumMember(Value = "companyPortal")]
        CompanyPortal = 2,
        /// <summary>MSFB Private store only.</summary>
        [EnumMember(Value = "privateStore")]
        PrivateStore = 4,
    }
}
