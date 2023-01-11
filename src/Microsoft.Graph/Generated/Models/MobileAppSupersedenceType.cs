namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the supersedence type associated with a relationship between two mobile apps.</summary>
    public enum MobileAppSupersedenceType {
        /// <summary>Indicates that the child app should be updated by the internal logic of the parent app.</summary>
        Update,
        /// <summary>Indicates that the child app should be uninstalled before installing the parent app.</summary>
        Replace,
    }
}
