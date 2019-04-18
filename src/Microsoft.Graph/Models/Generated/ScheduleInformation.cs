// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ScheduleInformation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ScheduleInformation
    {

        /// <summary>
        /// Gets or sets scheduleId.
        /// An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduleId", Required = Newtonsoft.Json.Required.Default)]
        public string ScheduleId { get; set; }
    
        /// <summary>
        /// Gets or sets scheduleItems.
        /// Contains the items that describe the availability of the user or resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduleItems", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ScheduleItem> ScheduleItems { get; set; }
    
        /// <summary>
        /// Gets or sets availabilityView.
        /// Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free, 1= tentative, 2= busy, 3= out of office, 4= working elsewhere.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "availabilityView", Required = Newtonsoft.Json.Required.Default)]
        public string AvailabilityView { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// Error information from attempting to get the availability of the user, distribution list, or resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "error", Required = Newtonsoft.Json.Required.Default)]
        public FreeBusyError Error { get; set; }
    
        /// <summary>
        /// Gets or sets workingHours.
        /// The days of the week and hours in a specific time zone that the user works. These are set as part of the user's mailboxSettings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "workingHours", Required = Newtonsoft.Json.Required.Default)]
        public WorkingHours WorkingHours { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
