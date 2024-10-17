// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IdentityGovernance : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessReviews property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessReviewSet? AccessReviews
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewSet?>("accessReviews"); }
            set { BackingStore?.Set("accessReviews", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessReviewSet AccessReviews
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewSet>("accessReviews"); }
            set { BackingStore?.Set("accessReviews", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The appConsent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AppConsentApprovalRoute? AppConsent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppConsentApprovalRoute?>("appConsent"); }
            set { BackingStore?.Set("appConsent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AppConsentApprovalRoute AppConsent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppConsentApprovalRoute>("appConsent"); }
            set { BackingStore?.Set("appConsent", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The entitlementManagement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EntitlementManagement? EntitlementManagement
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EntitlementManagement?>("entitlementManagement"); }
            set { BackingStore?.Set("entitlementManagement", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EntitlementManagement EntitlementManagement
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EntitlementManagement>("entitlementManagement"); }
            set { BackingStore?.Set("entitlementManagement", value); }
        }
#endif
        /// <summary>The lifecycleWorkflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer? LifecycleWorkflows
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer?>("lifecycleWorkflows"); }
            set { BackingStore?.Set("lifecycleWorkflows", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer LifecycleWorkflows
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer>("lifecycleWorkflows"); }
            set { BackingStore?.Set("lifecycleWorkflows", value); }
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
        /// <summary>The privilegedAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PrivilegedAccessRoot? PrivilegedAccess
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrivilegedAccessRoot?>("privilegedAccess"); }
            set { BackingStore?.Set("privilegedAccess", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PrivilegedAccessRoot PrivilegedAccess
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrivilegedAccessRoot>("privilegedAccess"); }
            set { BackingStore?.Set("privilegedAccess", value); }
        }
#endif
        /// <summary>The termsOfUse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermsOfUseContainer? TermsOfUse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermsOfUseContainer?>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermsOfUseContainer TermsOfUse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermsOfUseContainer>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance"/> and sets the default values.
        /// </summary>
        public IdentityGovernance()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessReviews", n => { AccessReviews = n.GetObjectValue<global::Microsoft.Graph.Models.AccessReviewSet>(global::Microsoft.Graph.Models.AccessReviewSet.CreateFromDiscriminatorValue); } },
                { "appConsent", n => { AppConsent = n.GetObjectValue<global::Microsoft.Graph.Models.AppConsentApprovalRoute>(global::Microsoft.Graph.Models.AppConsentApprovalRoute.CreateFromDiscriminatorValue); } },
                { "entitlementManagement", n => { EntitlementManagement = n.GetObjectValue<global::Microsoft.Graph.Models.EntitlementManagement>(global::Microsoft.Graph.Models.EntitlementManagement.CreateFromDiscriminatorValue); } },
                { "lifecycleWorkflows", n => { LifecycleWorkflows = n.GetObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer>(global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privilegedAccess", n => { PrivilegedAccess = n.GetObjectValue<global::Microsoft.Graph.Models.PrivilegedAccessRoot>(global::Microsoft.Graph.Models.PrivilegedAccessRoot.CreateFromDiscriminatorValue); } },
                { "termsOfUse", n => { TermsOfUse = n.GetObjectValue<global::Microsoft.Graph.Models.TermsOfUseContainer>(global::Microsoft.Graph.Models.TermsOfUseContainer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessReviewSet>("accessReviews", AccessReviews);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AppConsentApprovalRoute>("appConsent", AppConsent);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EntitlementManagement>("entitlementManagement", EntitlementManagement);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer>("lifecycleWorkflows", LifecycleWorkflows);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PrivilegedAccessRoot>("privilegedAccess", PrivilegedAccess);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermsOfUseContainer>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
