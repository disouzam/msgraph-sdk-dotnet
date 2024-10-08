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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ChatMessagePolicyViolation : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The action taken by the DLP provider on the message with sensitive content. Supported values are: NoneNotifySender -- Inform the sender of the violation but allow readers to read the message.BlockAccess -- Block readers from reading the message.BlockAccessExternal -- Block users outside the organization from reading the message, while allowing users within the organization to read the message.</summary>
        public global::Microsoft.Graph.Models.ChatMessagePolicyViolationDlpActionTypes? DlpAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessagePolicyViolationDlpActionTypes?>("dlpAction"); }
            set { BackingStore?.Set("dlpAction", value); }
        }
        /// <summary>Justification text provided by the sender of the message when overriding a policy violation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JustificationText
        {
            get { return BackingStore?.Get<string?>("justificationText"); }
            set { BackingStore?.Set("justificationText", value); }
        }
#nullable restore
#else
        public string JustificationText
        {
            get { return BackingStore?.Get<string>("justificationText"); }
            set { BackingStore?.Set("justificationText", value); }
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
        /// <summary>Information to display to the message sender about why the message was flagged as a violation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip? PolicyTip
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip?>("policyTip"); }
            set { BackingStore?.Set("policyTip", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip PolicyTip
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip>("policyTip"); }
            set { BackingStore?.Set("policyTip", value); }
        }
#endif
        /// <summary>Indicates the action taken by the user on a message blocked by the DLP provider. Supported values are: NoneOverrideReportFalsePositiveWhen the DLP provider is updating the message for blocking sensitive content, userAction isn&apos;t required.</summary>
        public global::Microsoft.Graph.Models.ChatMessagePolicyViolationUserActionTypes? UserAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessagePolicyViolationUserActionTypes?>("userAction"); }
            set { BackingStore?.Set("userAction", value); }
        }
        /// <summary>Indicates what actions the sender may take in response to the policy violation. Supported values are: NoneAllowFalsePositiveOverride -- Allows the sender to declare the policyViolation to be an error in the DLP app and its rules, and allow readers to see the message again if the dlpAction hides it.AllowOverrideWithoutJustification -- Allows the sender to override the DLP violation and allow readers to see the message again if the dlpAction hides it, without needing to provide an explanation for doing so. AllowOverrideWithJustification -- Allows the sender to override the DLP violation and allow readers to see the message again if the dlpAction hides it, after providing an explanation for doing so.AllowOverrideWithoutJustification and AllowOverrideWithJustification are mutually exclusive.</summary>
        public global::Microsoft.Graph.Models.ChatMessagePolicyViolationVerdictDetailsTypes? VerdictDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessagePolicyViolationVerdictDetailsTypes?>("verdictDetails"); }
            set { BackingStore?.Set("verdictDetails", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ChatMessagePolicyViolation"/> and sets the default values.
        /// </summary>
        public ChatMessagePolicyViolation()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ChatMessagePolicyViolation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ChatMessagePolicyViolation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ChatMessagePolicyViolation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dlpAction", n => { DlpAction = n.GetEnumValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationDlpActionTypes>(); } },
                { "justificationText", n => { JustificationText = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "policyTip", n => { PolicyTip = n.GetObjectValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip>(global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip.CreateFromDiscriminatorValue); } },
                { "userAction", n => { UserAction = n.GetEnumValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationUserActionTypes>(); } },
                { "verdictDetails", n => { VerdictDetails = n.GetEnumValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationVerdictDetailsTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationDlpActionTypes>("dlpAction", DlpAction);
            writer.WriteStringValue("justificationText", JustificationText);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationPolicyTip>("policyTip", PolicyTip);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationUserActionTypes>("userAction", UserAction);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ChatMessagePolicyViolationVerdictDetailsTypes>("verdictDetails", VerdictDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
