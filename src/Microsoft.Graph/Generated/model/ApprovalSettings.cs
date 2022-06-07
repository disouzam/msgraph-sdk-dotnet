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
    /// The type ApprovalSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ApprovalSettings>))]
    public partial class ApprovalSettings
    {

        /// <summary>
        /// Gets or sets approvalMode.
        /// One of SingleStage, Serial, Parallel, NoApproval (default). NoApproval is used when isApprovalRequired is false.
        /// </summary>
        [JsonPropertyName("approvalMode")]
        public string ApprovalMode { get; set; }
    
        /// <summary>
        /// Gets or sets approvalStages.
        /// If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.
        /// </summary>
        [JsonPropertyName("approvalStages")]
        public IEnumerable<UnifiedApprovalStage> ApprovalStages { get; set; }
    
        /// <summary>
        /// Gets or sets isApprovalRequired.
        /// Indicates whether approval is required for requests in this policy.
        /// </summary>
        [JsonPropertyName("isApprovalRequired")]
        public bool? IsApprovalRequired { get; set; }
    
        /// <summary>
        /// Gets or sets isApprovalRequiredForExtension.
        /// Indicates whether approval is required for a user to extend their assignment.
        /// </summary>
        [JsonPropertyName("isApprovalRequiredForExtension")]
        public bool? IsApprovalRequiredForExtension { get; set; }
    
        /// <summary>
        /// Gets or sets isRequestorJustificationRequired.
        /// Indicates whether the requestor is required to supply a justification in their request.
        /// </summary>
        [JsonPropertyName("isRequestorJustificationRequired")]
        public bool? IsRequestorJustificationRequired { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
