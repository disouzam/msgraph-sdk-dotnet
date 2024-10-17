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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IdentityProtectionRoot : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Risk detection in Microsoft Entra ID Protection and the associated information about the detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RiskDetection>? RiskDetections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskDetection>?>("riskDetections"); }
            set { BackingStore?.Set("riskDetections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RiskDetection> RiskDetections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskDetection>>("riskDetections"); }
            set { BackingStore?.Set("riskDetections", value); }
        }
#endif
        /// <summary>Microsoft Entra service principals that are at risk.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RiskyServicePrincipal>? RiskyServicePrincipals
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskyServicePrincipal>?>("riskyServicePrincipals"); }
            set { BackingStore?.Set("riskyServicePrincipals", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RiskyServicePrincipal> RiskyServicePrincipals
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskyServicePrincipal>>("riskyServicePrincipals"); }
            set { BackingStore?.Set("riskyServicePrincipals", value); }
        }
#endif
        /// <summary>Users that are flagged as at-risk by Microsoft Entra ID Protection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RiskyUser>? RiskyUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskyUser>?>("riskyUsers"); }
            set { BackingStore?.Set("riskyUsers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RiskyUser> RiskyUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RiskyUser>>("riskyUsers"); }
            set { BackingStore?.Set("riskyUsers", value); }
        }
#endif
        /// <summary>Represents information about detected at-risk service principals in a Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ServicePrincipalRiskDetection>? ServicePrincipalRiskDetections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ServicePrincipalRiskDetection>?>("servicePrincipalRiskDetections"); }
            set { BackingStore?.Set("servicePrincipalRiskDetections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ServicePrincipalRiskDetection> ServicePrincipalRiskDetections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ServicePrincipalRiskDetection>>("servicePrincipalRiskDetections"); }
            set { BackingStore?.Set("servicePrincipalRiskDetections", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityProtectionRoot"/> and sets the default values.
        /// </summary>
        public IdentityProtectionRoot()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityProtectionRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.IdentityProtectionRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityProtectionRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "riskDetections", n => { RiskDetections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RiskDetection>(global::Microsoft.Graph.Models.RiskDetection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "riskyServicePrincipals", n => { RiskyServicePrincipals = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RiskyServicePrincipal>(global::Microsoft.Graph.Models.RiskyServicePrincipal.CreateFromDiscriminatorValue)?.AsList(); } },
                { "riskyUsers", n => { RiskyUsers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RiskyUser>(global::Microsoft.Graph.Models.RiskyUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "servicePrincipalRiskDetections", n => { ServicePrincipalRiskDetections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ServicePrincipalRiskDetection>(global::Microsoft.Graph.Models.ServicePrincipalRiskDetection.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RiskDetection>("riskDetections", RiskDetections);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RiskyServicePrincipal>("riskyServicePrincipals", RiskyServicePrincipals);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RiskyUser>("riskyUsers", RiskyUsers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ServicePrincipalRiskDetection>("servicePrincipalRiskDetections", ServicePrincipalRiskDetections);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
