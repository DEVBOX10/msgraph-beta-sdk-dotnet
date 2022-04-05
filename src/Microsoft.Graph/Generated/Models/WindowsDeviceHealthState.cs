namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum WindowsDeviceHealthState {
        Clean,
        FullScanPending,
        RebootPending,
        ManualStepsPending,
        OfflineScanPending,
        Critical,
    }
}
