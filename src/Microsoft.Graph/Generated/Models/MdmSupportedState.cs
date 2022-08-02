namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum MdmSupportedState {
        /// <summary>Mdm support status of the setting is not known.</summary>
        Unknown,
        /// <summary>Setting is supported.</summary>
        Supported,
        /// <summary>Setting is unsupported.</summary>
        Unsupported,
        /// <summary>Setting is depcrecated.</summary>
        Deprecated,
    }
}
