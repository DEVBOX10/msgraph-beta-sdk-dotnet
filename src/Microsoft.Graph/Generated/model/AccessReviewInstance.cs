// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Access Review Instance.
    /// </summary>
    public partial class AccessReviewInstance : Entity
    {
    
        /// <summary>
        /// Gets or sets end date time.
        /// DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets fallback reviewers.
        /// This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
        /// </summary>
        [JsonPropertyName("fallbackReviewers")]
        public IEnumerable<AccessReviewReviewerScope> FallbackReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets reviewers.
        /// This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
        /// </summary>
        [JsonPropertyName("reviewers")]
        public IEnumerable<AccessReviewReviewerScope> Reviewers { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Created based on scope and instanceEnumerationScope at the accessReviewScheduleDefinition level. Defines the scope of users reviewed in a group. Supports $select and $filter (contains only). Read-only.
        /// </summary>
        [JsonPropertyName("scope")]
        public AccessReviewScope Scope { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets contacted reviewers.
        /// Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
        /// </summary>
        [JsonPropertyName("contactedReviewers")]
        public IAccessReviewInstanceContactedReviewersCollectionPage ContactedReviewers { get; set; }

        /// <summary>
        /// Gets or sets contactedReviewersNextLink.
        /// </summary>
        [JsonPropertyName("contactedReviewers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ContactedReviewersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets decisions.
        /// Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
        /// </summary>
        [JsonPropertyName("decisions")]
        public IAccessReviewInstanceDecisionsCollectionPage Decisions { get; set; }

        /// <summary>
        /// Gets or sets decisionsNextLink.
        /// </summary>
        [JsonPropertyName("decisions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DecisionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets definition.
        /// There is exactly one accessReviewScheduleDefinition associated with each instance. It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.
        /// </summary>
        [JsonPropertyName("definition")]
        public AccessReviewScheduleDefinition Definition { get; set; }
    
    }
}

