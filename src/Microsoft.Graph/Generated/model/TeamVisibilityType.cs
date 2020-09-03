// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum TeamVisibilityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TeamVisibilityType
    {
    
        /// <summary>
        /// Private
        /// </summary>
        Private = 0,
	
        /// <summary>
        /// Public
        /// </summary>
        Public = 1,
	
        /// <summary>
        /// Hidden Membership
        /// </summary>
        HiddenMembership = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}