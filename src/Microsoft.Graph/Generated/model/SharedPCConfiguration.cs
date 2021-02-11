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
    /// The type Shared PCConfiguration.
    /// </summary>
    public partial class SharedPCConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The SharedPCConfiguration constructor
		///</summary>
        public SharedPCConfiguration()
        {
            this.ODataType = "microsoft.graph.sharedPCConfiguration";
        }
	
        /// <summary>
        /// Gets or sets account manager policy.
        /// Specifies how accounts are managed on a shared PC. Only applies when disableAccountManager is false.
        /// </summary>
        [JsonPropertyName("accountManagerPolicy")]
        public SharedPCAccountManagerPolicy AccountManagerPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets allowed accounts.
        /// Indicates which type of accounts are allowed to use on a shared PC. Possible values are: notConfigured, guest, domain.
        /// </summary>
        [JsonPropertyName("allowedAccounts")]
        public SharedPCAllowedAccountType? AllowedAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets allow local storage.
        /// Specifies whether local storage is allowed on a shared PC.
        /// </summary>
        [JsonPropertyName("allowLocalStorage")]
        public bool? AllowLocalStorage { get; set; }
    
        /// <summary>
        /// Gets or sets disable account manager.
        /// Disables the account manager for shared PC mode.
        /// </summary>
        [JsonPropertyName("disableAccountManager")]
        public bool? DisableAccountManager { get; set; }
    
        /// <summary>
        /// Gets or sets disable edu policies.
        /// Specifies whether the default shared PC education environment policies should be disabled. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true.
        /// </summary>
        [JsonPropertyName("disableEduPolicies")]
        public bool? DisableEduPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets disable power policies.
        /// Specifies whether the default shared PC power policies should be disabled.
        /// </summary>
        [JsonPropertyName("disablePowerPolicies")]
        public bool? DisablePowerPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets disable sign in on resume.
        /// Disables the requirement to sign in whenever the device wakes up from sleep mode.
        /// </summary>
        [JsonPropertyName("disableSignInOnResume")]
        public bool? DisableSignInOnResume { get; set; }
    
        /// <summary>
        /// Gets or sets enabled.
        /// Enables shared PC mode and applies the shared pc policies.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or sets idle time before sleep in seconds.
        /// Specifies the time in seconds that a device must sit idle before the PC goes to sleep. Setting this value to 0 prevents the sleep timeout from occurring.
        /// </summary>
        [JsonPropertyName("idleTimeBeforeSleepInSeconds")]
        public Int32? IdleTimeBeforeSleepInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk app display name.
        /// Specifies the display text for the account shown on the sign-in screen which launches the app specified by SetKioskAppUserModelId. Only applies when KioskAppUserModelId is set.
        /// </summary>
        [JsonPropertyName("kioskAppDisplayName")]
        public string KioskAppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk app user model id.
        /// Specifies the application user model ID of the app to use with assigned access.
        /// </summary>
        [JsonPropertyName("kioskAppUserModelId")]
        public string KioskAppUserModelId { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance start time.
        /// Specifies the daily start time of maintenance hour.
        /// </summary>
        [JsonPropertyName("maintenanceStartTime")]
        public TimeOfDay MaintenanceStartTime { get; set; }
    
    }
}

