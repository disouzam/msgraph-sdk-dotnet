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
    /// The type Unified Role Management Policy.
    /// </summary>
    public partial class UnifiedRoleManagementPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// Description for the policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name for the policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is organization default.
        /// This can only be set to true for a single tenant-wide policy which will apply to all scopes and roles. Set the scopeId to / and scopeType to Directory. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("isOrganizationDefault")]
        public bool? IsOrganizationDefault { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// The identity who last modified the role setting.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public Identity LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The time when the role setting was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets scope id.
        /// The identifier of the scope where the policy is created. Can be / for the tenant or a group ID. Required.
        /// </summary>
        [JsonPropertyName("scopeId")]
        public string ScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets scope type.
        /// The type of the scope where the policy is created. One of Directory, DirectoryRole. Required.
        /// </summary>
        [JsonPropertyName("scopeType")]
        public string ScopeType { get; set; }
    
        /// <summary>
        /// Gets or sets effective rules.
        /// The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules. For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval. Supports $expand.
        /// </summary>
        [JsonPropertyName("effectiveRules")]
        public IUnifiedRoleManagementPolicyEffectiveRulesCollectionPage EffectiveRules { get; set; }

        /// <summary>
        /// Gets or sets effectiveRulesNextLink.
        /// </summary>
        [JsonPropertyName("effectiveRules@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string EffectiveRulesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets rules.
        /// The collection of rules like approval rules and expiration rules. Supports $expand.
        /// </summary>
        [JsonPropertyName("rules")]
        public IUnifiedRoleManagementPolicyRulesCollectionPage Rules { get; set; }

        /// <summary>
        /// Gets or sets rulesNextLink.
        /// </summary>
        [JsonPropertyName("rules@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RulesNextLink { get; set; }
    
    }
}

