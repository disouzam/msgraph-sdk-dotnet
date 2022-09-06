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
    /// The type StaffAvailabilityItem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<StaffAvailabilityItem>))]
    public partial class StaffAvailabilityItem
    {

        /// <summary>
        /// Gets or sets availabilityItems.
        /// Each item in this collection indicates a slot and the status of the staff member.
        /// </summary>
        [JsonPropertyName("availabilityItems")]
        public IEnumerable<AvailabilityItem> AvailabilityItems { get; set; }
    
        /// <summary>
        /// Gets or sets staffId.
        /// The ID of the staff member.
        /// </summary>
        [JsonPropertyName("staffId")]
        public string StaffId { get; set; }
    
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