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
    /// The type Authentication Method Target.
    /// </summary>
    public partial class AuthenticationMethodTarget : Entity
    {
    
		///<summary>
		/// The AuthenticationMethodTarget constructor
		///</summary>
        public AuthenticationMethodTarget()
        {
            this.ODataType = "microsoft.graph.authenticationMethodTarget";
        }
	
        /// <summary>
        /// Gets or sets is registration required.
        /// Determines if the user is enforced to register the authentication method.
        /// </summary>
        [JsonPropertyName("isRegistrationRequired")]
        public bool? IsRegistrationRequired { get; set; }
    
        /// <summary>
        /// Gets or sets target type.
        /// Possible values are: user, group.
        /// </summary>
        [JsonPropertyName("targetType")]
        public AuthenticationMethodTargetType? TargetType { get; set; }
    
    }
}

