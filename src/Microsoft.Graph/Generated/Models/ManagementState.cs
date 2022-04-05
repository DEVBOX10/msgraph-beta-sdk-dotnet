namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum ManagementState {
        Managed,
        RetirePending,
        RetireFailed,
        WipePending,
        WipeFailed,
        Unhealthy,
        DeletePending,
        RetireIssued,
        WipeIssued,
        WipeCanceled,
        RetireCanceled,
        Discovered,
    }
}
