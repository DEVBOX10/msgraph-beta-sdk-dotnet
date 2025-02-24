// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determines which clients a content cache will serve.</summary>
    public enum MacOSContentCachingClientPolicy {
        /// <summary>Defaults to clients in local network.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Content caches will provide content to devices only in their immediate local network.</summary>
        [EnumMember(Value = "clientsInLocalNetwork")]
        ClientsInLocalNetwork,
        /// <summary>Content caches will provide content to devices that share the same public IP address.</summary>
        [EnumMember(Value = "clientsWithSamePublicIpAddress")]
        ClientsWithSamePublicIpAddress,
        /// <summary>Content caches will provide content to devices in contentCachingClientListenRanges.</summary>
        [EnumMember(Value = "clientsInCustomLocalNetworks")]
        ClientsInCustomLocalNetworks,
        /// <summary>Content caches will provide content to devices in contentCachingClientListenRanges, contentCachingPeerListenRanges, and contentCachingParents.</summary>
        [EnumMember(Value = "clientsInCustomLocalNetworksWithFallback")]
        ClientsInCustomLocalNetworksWithFallback,
    }
}
