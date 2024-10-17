// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Agreement : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Information about acceptances of this agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AgreementAcceptance>? Acceptances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AgreementAcceptance>?>("acceptances"); }
            set { BackingStore?.Set("acceptances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AgreementAcceptance> Acceptances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AgreementAcceptance>>("acceptances"); }
            set { BackingStore?.Set("acceptances", value); }
        }
#endif
        /// <summary>Display name of the agreement. The display name is used for internal tracking of the agreement but isn&apos;t shown to end users who view the agreement. Supports $filter (eq).</summary>
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
        /// <summary>Default PDF linked to this agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AgreementFile? File
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AgreementFile?>("file"); }
            set { BackingStore?.Set("file", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AgreementFile File
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AgreementFile>("file"); }
            set { BackingStore?.Set("file", value); }
        }
#endif
        /// <summary>PDFs linked to this agreement. This property is in the process of being deprecated. Use the  file property instead. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AgreementFileLocalization>? Files
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AgreementFileLocalization>?>("files"); }
            set { BackingStore?.Set("files", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AgreementFileLocalization> Files
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AgreementFileLocalization>>("files"); }
            set { BackingStore?.Set("files", value); }
        }
#endif
        /// <summary>Indicates whether end users are required to accept this agreement on every device that they access it from. The end user is required to register their device in Microsoft Entra ID, if they haven&apos;t already done so. Supports $filter (eq).</summary>
        public bool? IsPerDeviceAcceptanceRequired
        {
            get { return BackingStore?.Get<bool?>("isPerDeviceAcceptanceRequired"); }
            set { BackingStore?.Set("isPerDeviceAcceptanceRequired", value); }
        }
        /// <summary>Indicates whether the user has to expand the agreement before accepting. Supports $filter (eq).</summary>
        public bool? IsViewingBeforeAcceptanceRequired
        {
            get { return BackingStore?.Get<bool?>("isViewingBeforeAcceptanceRequired"); }
            set { BackingStore?.Set("isViewingBeforeAcceptanceRequired", value); }
        }
        /// <summary>Expiration schedule and frequency of agreement for all users. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermsExpiration? TermsExpiration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermsExpiration?>("termsExpiration"); }
            set { BackingStore?.Set("termsExpiration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermsExpiration TermsExpiration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermsExpiration>("termsExpiration"); }
            set { BackingStore?.Set("termsExpiration", value); }
        }
#endif
        /// <summary>The duration after which the user must reaccept the terms of use. The value is represented in ISO 8601 format for durations. Supports $filter (eq).</summary>
        public TimeSpan? UserReacceptRequiredFrequency
        {
            get { return BackingStore?.Get<TimeSpan?>("userReacceptRequiredFrequency"); }
            set { BackingStore?.Set("userReacceptRequiredFrequency", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Agreement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Agreement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Agreement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acceptances", n => { Acceptances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AgreementAcceptance>(global::Microsoft.Graph.Models.AgreementAcceptance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "file", n => { File = n.GetObjectValue<global::Microsoft.Graph.Models.AgreementFile>(global::Microsoft.Graph.Models.AgreementFile.CreateFromDiscriminatorValue); } },
                { "files", n => { Files = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AgreementFileLocalization>(global::Microsoft.Graph.Models.AgreementFileLocalization.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isPerDeviceAcceptanceRequired", n => { IsPerDeviceAcceptanceRequired = n.GetBoolValue(); } },
                { "isViewingBeforeAcceptanceRequired", n => { IsViewingBeforeAcceptanceRequired = n.GetBoolValue(); } },
                { "termsExpiration", n => { TermsExpiration = n.GetObjectValue<global::Microsoft.Graph.Models.TermsExpiration>(global::Microsoft.Graph.Models.TermsExpiration.CreateFromDiscriminatorValue); } },
                { "userReacceptRequiredFrequency", n => { UserReacceptRequiredFrequency = n.GetTimeSpanValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AgreementAcceptance>("acceptances", Acceptances);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AgreementFile>("file", File);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AgreementFileLocalization>("files", Files);
            writer.WriteBoolValue("isPerDeviceAcceptanceRequired", IsPerDeviceAcceptanceRequired);
            writer.WriteBoolValue("isViewingBeforeAcceptanceRequired", IsViewingBeforeAcceptanceRequired);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermsExpiration>("termsExpiration", TermsExpiration);
            writer.WriteTimeSpanValue("userReacceptRequiredFrequency", UserReacceptRequiredFrequency);
        }
    }
}
#pragma warning restore CS0618
