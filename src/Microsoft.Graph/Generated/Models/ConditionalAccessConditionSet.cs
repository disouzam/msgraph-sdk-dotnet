// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class ConditionalAccessConditionSet : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Applications and user actions included in and excluded from the policy. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessApplications? Applications
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessApplications?>("applications"); }
            set { BackingStore?.Set("applications", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessApplications Applications
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessApplications>("applications"); }
            set { BackingStore?.Set("applications", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Client applications (service principals and workload identities) included in and excluded from the policy. Either users or clientApplications is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessClientApplications? ClientApplications
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessClientApplications?>("clientApplications"); }
            set { BackingStore?.Set("clientApplications", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessClientApplications ClientApplications
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessClientApplications>("clientApplications"); }
            set { BackingStore?.Set("clientApplications", value); }
        }
#endif
        /// <summary>Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.  The easUnsupported enumeration member will be deprecated in favor of exchangeActiveSync which includes EAS supported and unsupported platforms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ConditionalAccessClientApp?>? ClientAppTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessClientApp?>?>("clientAppTypes"); }
            set { BackingStore?.Set("clientAppTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ConditionalAccessClientApp?> ClientAppTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessClientApp?>>("clientAppTypes"); }
            set { BackingStore?.Set("clientAppTypes", value); }
        }
#endif
        /// <summary>Devices in the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessDevices? Devices
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessDevices?>("devices"); }
            set { BackingStore?.Set("devices", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessDevices Devices
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessDevices>("devices"); }
            set { BackingStore?.Set("devices", value); }
        }
#endif
        /// <summary>Insider risk levels included in the policy. The possible values are: minor, moderate, elevated, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.ConditionalAccessInsiderRiskLevels? InsiderRiskLevels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessInsiderRiskLevels?>("insiderRiskLevels"); }
            set { BackingStore?.Set("insiderRiskLevels", value); }
        }
        /// <summary>Locations included in and excluded from the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessLocations? Locations
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessLocations?>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessLocations Locations
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessLocations>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Platforms included in and excluded from the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessPlatforms? Platforms
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessPlatforms?>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessPlatforms Platforms
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessPlatforms>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
#endif
        /// <summary>Service principal risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RiskLevel?>? ServicePrincipalRiskLevels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskLevel?>?>("servicePrincipalRiskLevels"); }
            set { BackingStore?.Set("servicePrincipalRiskLevels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RiskLevel?> ServicePrincipalRiskLevels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskLevel?>>("servicePrincipalRiskLevels"); }
            set { BackingStore?.Set("servicePrincipalRiskLevels", value); }
        }
#endif
        /// <summary>Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RiskLevel?>? SignInRiskLevels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskLevel?>?>("signInRiskLevels"); }
            set { BackingStore?.Set("signInRiskLevels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RiskLevel?> SignInRiskLevels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskLevel?>>("signInRiskLevels"); }
            set { BackingStore?.Set("signInRiskLevels", value); }
        }
#endif
        /// <summary>User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RiskLevel?>? UserRiskLevels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskLevel?>?>("userRiskLevels"); }
            set { BackingStore?.Set("userRiskLevels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RiskLevel?> UserRiskLevels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskLevel?>>("userRiskLevels"); }
            set { BackingStore?.Set("userRiskLevels", value); }
        }
#endif
        /// <summary>Users, groups, and roles included in and excluded from the policy. Either users or clientApplications is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessUsers? Users
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessUsers?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessUsers Users
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessUsers>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ConditionalAccessConditionSet"/> and sets the default values.
        /// </summary>
        public ConditionalAccessConditionSet()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ConditionalAccessConditionSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ConditionalAccessConditionSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ConditionalAccessConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applications", n => { Applications = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessApplications>(global::Microsoft.Graph.Models.ConditionalAccessApplications.CreateFromDiscriminatorValue); } },
                { "clientAppTypes", n => { ClientAppTypes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.ConditionalAccessClientApp>()?.AsList(); } },
                { "clientApplications", n => { ClientApplications = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessClientApplications>(global::Microsoft.Graph.Models.ConditionalAccessClientApplications.CreateFromDiscriminatorValue); } },
                { "devices", n => { Devices = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessDevices>(global::Microsoft.Graph.Models.ConditionalAccessDevices.CreateFromDiscriminatorValue); } },
                { "insiderRiskLevels", n => { InsiderRiskLevels = n.GetEnumValue<global::Microsoft.Graph.Models.ConditionalAccessInsiderRiskLevels>(); } },
                { "locations", n => { Locations = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessLocations>(global::Microsoft.Graph.Models.ConditionalAccessLocations.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "platforms", n => { Platforms = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessPlatforms>(global::Microsoft.Graph.Models.ConditionalAccessPlatforms.CreateFromDiscriminatorValue); } },
                { "servicePrincipalRiskLevels", n => { ServicePrincipalRiskLevels = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.RiskLevel>()?.AsList(); } },
                { "signInRiskLevels", n => { SignInRiskLevels = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.RiskLevel>()?.AsList(); } },
                { "userRiskLevels", n => { UserRiskLevels = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.RiskLevel>()?.AsList(); } },
                { "users", n => { Users = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessUsers>(global::Microsoft.Graph.Models.ConditionalAccessUsers.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessApplications>("applications", Applications);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessClientApplications>("clientApplications", ClientApplications);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.ConditionalAccessClientApp>("clientAppTypes", ClientAppTypes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessDevices>("devices", Devices);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ConditionalAccessInsiderRiskLevels>("insiderRiskLevels", InsiderRiskLevels);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessLocations>("locations", Locations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.RiskLevel>("servicePrincipalRiskLevels", ServicePrincipalRiskLevels);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.RiskLevel>("signInRiskLevels", SignInRiskLevels);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.RiskLevel>("userRiskLevels", UserRiskLevels);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessUsers>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
