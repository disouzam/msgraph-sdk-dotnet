// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CloudPC : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Microsoft Entra device ID for the Cloud PC, also known as the Azure Active Directory (Azure AD) device ID, that consists of 32 characters in a GUID format. Generated on a VM joined to Microsoft Entra ID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AadDeviceId
        {
            get { return BackingStore?.Get<string?>("aadDeviceId"); }
            set { BackingStore?.Set("aadDeviceId", value); }
        }
#nullable restore
#else
        public string AadDeviceId
        {
            get { return BackingStore?.Get<string>("aadDeviceId"); }
            set { BackingStore?.Set("aadDeviceId", value); }
        }
#endif
        /// <summary>The display name for the Cloud PC. Maximum length is 64 characters. Read-only. You can use the cloudPC: rename API to modify the Cloud PC name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The date and time when the grace period ends and reprovisioning or deprovisioning happen. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("gracePeriodEndDateTime"); }
            set { BackingStore?.Set("gracePeriodEndDateTime", value); }
        }
        /// <summary>The name of the operating system image used for the Cloud PC. Maximum length is 50 characters. Only letters (A-Z, a-z), numbers (0-9), and special characters (-,,.) are allowed for this property. The property value can&apos;t begin or end with an underscore. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageDisplayName
        {
            get { return BackingStore?.Get<string?>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
#nullable restore
#else
        public string ImageDisplayName
        {
            get { return BackingStore?.Get<string>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
#endif
        /// <summary>The last modified date and time of the Cloud PC. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The Intune enrolled device ID for the Cloud PC that consists of 32 characters in a GUID format. The managedDeviceId property of Windows 365 Business Cloud PCs is always null as Windows 365 Business Cloud PCs aren&apos;t Intune-enrolled automatically by Windows 365. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId
        {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId
        {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>The Intune enrolled device name for the Cloud PC. The managedDeviceName property of Windows 365 Business Cloud PCs is always null as Windows 365 Business Cloud PCs aren&apos;t Intune-enrolled automatically by Windows 365. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName
        {
            get { return BackingStore?.Get<string?>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#nullable restore
#else
        public string ManagedDeviceName
        {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
#endif
        /// <summary>The on-premises connection that applied during the provisioning of Cloud PCs. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesConnectionName
        {
            get { return BackingStore?.Get<string?>("onPremisesConnectionName"); }
            set { BackingStore?.Set("onPremisesConnectionName", value); }
        }
#nullable restore
#else
        public string OnPremisesConnectionName
        {
            get { return BackingStore?.Get<string>("onPremisesConnectionName"); }
            set { BackingStore?.Set("onPremisesConnectionName", value); }
        }
#endif
        /// <summary>The provisioning policy ID for the Cloud PC that consists of 32 characters in a GUID format. A policy defines the type of Cloud PC the user wants to create. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningPolicyId
        {
            get { return BackingStore?.Get<string?>("provisioningPolicyId"); }
            set { BackingStore?.Set("provisioningPolicyId", value); }
        }
#nullable restore
#else
        public string ProvisioningPolicyId
        {
            get { return BackingStore?.Get<string>("provisioningPolicyId"); }
            set { BackingStore?.Set("provisioningPolicyId", value); }
        }
#endif
        /// <summary>The provisioning policy that applied during the provisioning of Cloud PCs. Maximum length is 120 characters. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningPolicyName
        {
            get { return BackingStore?.Get<string?>("provisioningPolicyName"); }
            set { BackingStore?.Set("provisioningPolicyName", value); }
        }
#nullable restore
#else
        public string ProvisioningPolicyName
        {
            get { return BackingStore?.Get<string>("provisioningPolicyName"); }
            set { BackingStore?.Set("provisioningPolicyName", value); }
        }
#endif
        /// <summary>The type of licenses to be used when provisioning Cloud PCs using this policy. Possible values are: dedicated, shared, unknownFutureValue. The default value is dedicated.</summary>
        public global::Microsoft.Graph.Models.CloudPcProvisioningType? ProvisioningType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcProvisioningType?>("provisioningType"); }
            set { BackingStore?.Set("provisioningType", value); }
        }
        /// <summary>The service plan ID for the Cloud PC that consists of 32 characters in a GUID format. For more information about service plans, see Product names and service plan identifiers for licensing. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePlanId
        {
            get { return BackingStore?.Get<string?>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
#nullable restore
#else
        public string ServicePlanId
        {
            get { return BackingStore?.Get<string>("servicePlanId"); }
            set { BackingStore?.Set("servicePlanId", value); }
        }
#endif
        /// <summary>The service plan name for the customer-facing Cloud PC entity. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePlanName
        {
            get { return BackingStore?.Get<string?>("servicePlanName"); }
            set { BackingStore?.Set("servicePlanName", value); }
        }
#nullable restore
#else
        public string ServicePlanName
        {
            get { return BackingStore?.Get<string>("servicePlanName"); }
            set { BackingStore?.Set("servicePlanName", value); }
        }
#endif
        /// <summary>The user principal name (UPN) of the user assigned to the Cloud PC. Maximum length is 113 characters. For more information on username policies, see Password policies and account restrictions in Microsoft Entra ID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CloudPC"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CloudPC CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CloudPC();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "aadDeviceId", n => { AadDeviceId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "gracePeriodEndDateTime", n => { GracePeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "imageDisplayName", n => { ImageDisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                { "managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                { "onPremisesConnectionName", n => { OnPremisesConnectionName = n.GetStringValue(); } },
                { "provisioningPolicyId", n => { ProvisioningPolicyId = n.GetStringValue(); } },
                { "provisioningPolicyName", n => { ProvisioningPolicyName = n.GetStringValue(); } },
                { "provisioningType", n => { ProvisioningType = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcProvisioningType>(); } },
                { "servicePlanId", n => { ServicePlanId = n.GetStringValue(); } },
                { "servicePlanName", n => { ServicePlanName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aadDeviceId", AadDeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("gracePeriodEndDateTime", GracePeriodEndDateTime);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("onPremisesConnectionName", OnPremisesConnectionName);
            writer.WriteStringValue("provisioningPolicyId", ProvisioningPolicyId);
            writer.WriteStringValue("provisioningPolicyName", ProvisioningPolicyName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcProvisioningType>("provisioningType", ProvisioningType);
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteStringValue("servicePlanName", ServicePlanName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
#pragma warning restore CS0618
