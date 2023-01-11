namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionResultDetail {
        None,
        UnderInvestigation,
        SimulatedThreat,
        AllowedBySecOps,
        AllowedByThirdPartyFilters,
        MessageNotFound,
        UrlFileShouldNotBeBlocked,
        UrlFileShouldBeBlocked,
        UrlFileCannotMakeDecision,
        DomainImpersonation,
        UserImpersonation,
        BrandImpersonation,
        OutboundShouldNotBeBlocked,
        OutboundShouldBeBlocked,
        OutboundBulk,
        OutboundCannotMakeDecision,
        OutboundNotRescanned,
        ZeroHourAutoPurgeAllowed,
        ZeroHourAutoPurgeBlocked,
        ZeroHourAutoPurgeQuarantineReleased,
        OnPremisesSkip,
        AllowedByTenantAllowBlockList,
        BlockedByTenantAllowBlockList,
        AllowedUrlByTenantAllowBlockList,
        AllowedFileByTenantAllowBlockList,
        AllowedSenderByTenantAllowBlockList,
        AllowedRecipientByTenantAllowBlockList,
        BlockedUrlByTenantAllowBlockList,
        BlockedFileByTenantAllowBlockList,
        BlockedSenderByTenantAllowBlockList,
        BlockedRecipientByTenantAllowBlockList,
        AllowedByConnection,
        BlockedByConnection,
        AllowedByExchangeTransportRule,
        BlockedByExchangeTransportRule,
        QuarantineReleased,
        QuarantineReleasedThenBlocked,
        JunkMailRuleDisabled,
        AllowedByUserSetting,
        BlockedByUserSetting,
        AllowedByTenant,
        BlockedByTenant,
        InvalidFalsePositive,
        InvalidFalseNegative,
        SpoofBlocked,
        GoodReclassifiedAsBad,
        GoodReclassifiedAsBulk,
        GoodReclassifiedAsGood,
        GoodReclassifiedAsCannotMakeDecision,
        BadReclassifiedAsGood,
        BadReclassifiedAsBulk,
        BadReclassifiedAsBad,
        BadReclassifiedAsCannotMakeDecision,
        UnknownFutureValue,
    }
}
