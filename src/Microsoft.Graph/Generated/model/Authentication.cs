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
    /// The type Authentication.
    /// </summary>
    public partial class Authentication : Entity
    {
    
		///<summary>
		/// The Authentication constructor
		///</summary>
        public Authentication()
        {
            this.ODataType = "microsoft.graph.authentication";
        }
	
        /// <summary>
        /// Gets or sets fido2methods.
        /// </summary>
        [JsonPropertyName("fido2Methods")]
        public IAuthenticationFido2MethodsCollectionPage Fido2Methods { get; set; }
    
        /// <summary>
        /// Gets or sets methods.
        /// </summary>
        [JsonPropertyName("methods")]
        public IAuthenticationMethodsCollectionPage Methods { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft authenticator methods.
        /// </summary>
        [JsonPropertyName("microsoftAuthenticatorMethods")]
        public IAuthenticationMicrosoftAuthenticatorMethodsCollectionPage MicrosoftAuthenticatorMethods { get; set; }
    
        /// <summary>
        /// Gets or sets windows hello for business methods.
        /// </summary>
        [JsonPropertyName("windowsHelloForBusinessMethods")]
        public IAuthenticationWindowsHelloForBusinessMethodsCollectionPage WindowsHelloForBusinessMethods { get; set; }
    
    }
}

