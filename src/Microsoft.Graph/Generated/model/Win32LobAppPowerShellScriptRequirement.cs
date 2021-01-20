// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Win32LobAppPowerShellScriptRequirement.
    /// </summary>
    public partial class Win32LobAppPowerShellScriptRequirement : Win32LobAppRequirement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppPowerShellScriptRequirement"/> class.
        /// </summary>
        public Win32LobAppPowerShellScriptRequirement()
        {
            this.ODataType = "microsoft.graph.win32LobAppPowerShellScriptRequirement";
        }

        /// <summary>
        /// Gets or sets detectionType.
        /// The detection type for script output. Possible values are: notConfigured, string, dateTime, integer, float, version, boolean.
        /// </summary>
        [JsonPropertyName("detectionType")]
        public Win32LobAppPowerShellScriptDetectionType? DetectionType { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The unique display name for this rule
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforceSignatureCheck.
        /// A value indicating whether signature check is enforced
        /// </summary>
        [JsonPropertyName("enforceSignatureCheck")]
        public bool? EnforceSignatureCheck { get; set; }
    
        /// <summary>
        /// Gets or sets runAs32Bit.
        /// A value indicating whether this script should run as 32-bit
        /// </summary>
        [JsonPropertyName("runAs32Bit")]
        public bool? RunAs32Bit { get; set; }
    
        /// <summary>
        /// Gets or sets runAsAccount.
        /// Indicates the type of execution context the script runs in. Possible values are: system, user.
        /// </summary>
        [JsonPropertyName("runAsAccount")]
        public RunAsAccountType? RunAsAccount { get; set; }
    
        /// <summary>
        /// Gets or sets scriptContent.
        /// The base64 encoded script content to detect Win32 Line of Business (LoB) app
        /// </summary>
        [JsonPropertyName("scriptContent")]
        public string ScriptContent { get; set; }
    
    }
}
