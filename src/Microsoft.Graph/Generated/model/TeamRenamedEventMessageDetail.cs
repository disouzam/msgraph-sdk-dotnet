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
    /// The type TeamRenamedEventMessageDetail.
    /// </summary>
    public partial class TeamRenamedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRenamedEventMessageDetail"/> class.
        /// </summary>
        public TeamRenamedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.teamRenamedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets initiator.
        /// Initiator of the event.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
        /// <summary>
        /// Gets or sets teamDisplayName.
        /// The updated name of the team.
        /// </summary>
        [JsonPropertyName("teamDisplayName")]
        public string TeamDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets teamId.
        /// Unique identifier of the team.
        /// </summary>
        [JsonPropertyName("teamId")]
        public string TeamId { get; set; }
    
    }
}