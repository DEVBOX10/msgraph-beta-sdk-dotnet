namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum RemoteAssistanceOnboardingStatus {
        /// <summary>The status reported when there is no active TeamViewer connector configured or active</summary>
        NotOnboarded,
        /// <summary>The status reported when the system has initiated a TeamViewer connection, but the service has not yet completed the confirmation of a connector</summary>
        Onboarding,
        /// <summary>The status reported when the system has successfully exchanged account information with TeamViewer and can now initiate remote assistance sessions with clients</summary>
        Onboarded,
    }
}
