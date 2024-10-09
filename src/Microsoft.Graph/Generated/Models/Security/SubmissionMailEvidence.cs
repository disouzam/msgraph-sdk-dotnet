// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class SubmissionMailEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The networkMessageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId
        {
            get { return BackingStore?.Get<string?>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#nullable restore
#else
        public string NetworkMessageId
        {
            get { return BackingStore?.Get<string>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#endif
        /// <summary>The recipient property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Recipient
        {
            get { return BackingStore?.Get<string?>("recipient"); }
            set { BackingStore?.Set("recipient", value); }
        }
#nullable restore
#else
        public string Recipient
        {
            get { return BackingStore?.Get<string>("recipient"); }
            set { BackingStore?.Set("recipient", value); }
        }
#endif
        /// <summary>The reportType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportType
        {
            get { return BackingStore?.Get<string?>("reportType"); }
            set { BackingStore?.Set("reportType", value); }
        }
#nullable restore
#else
        public string ReportType
        {
            get { return BackingStore?.Get<string>("reportType"); }
            set { BackingStore?.Set("reportType", value); }
        }
#endif
        /// <summary>The sender property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sender
        {
            get { return BackingStore?.Get<string?>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
#nullable restore
#else
        public string Sender
        {
            get { return BackingStore?.Get<string>("sender"); }
            set { BackingStore?.Set("sender", value); }
        }
#endif
        /// <summary>The senderIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderIp
        {
            get { return BackingStore?.Get<string?>("senderIp"); }
            set { BackingStore?.Set("senderIp", value); }
        }
#nullable restore
#else
        public string SenderIp
        {
            get { return BackingStore?.Get<string>("senderIp"); }
            set { BackingStore?.Set("senderIp", value); }
        }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject
        {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject
        {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The submissionDateTime property</summary>
        public DateTimeOffset? SubmissionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("submissionDateTime"); }
            set { BackingStore?.Set("submissionDateTime", value); }
        }
        /// <summary>The submissionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubmissionId
        {
            get { return BackingStore?.Get<string?>("submissionId"); }
            set { BackingStore?.Set("submissionId", value); }
        }
#nullable restore
#else
        public string SubmissionId
        {
            get { return BackingStore?.Get<string>("submissionId"); }
            set { BackingStore?.Set("submissionId", value); }
        }
#endif
        /// <summary>The submitter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Submitter
        {
            get { return BackingStore?.Get<string?>("submitter"); }
            set { BackingStore?.Set("submitter", value); }
        }
#nullable restore
#else
        public string Submitter
        {
            get { return BackingStore?.Get<string>("submitter"); }
            set { BackingStore?.Set("submitter", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.SubmissionMailEvidence"/> and sets the default values.
        /// </summary>
        public SubmissionMailEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.submissionMailEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.SubmissionMailEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.SubmissionMailEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.SubmissionMailEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                { "recipient", n => { Recipient = n.GetStringValue(); } },
                { "reportType", n => { ReportType = n.GetStringValue(); } },
                { "sender", n => { Sender = n.GetStringValue(); } },
                { "senderIp", n => { SenderIp = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "submissionDateTime", n => { SubmissionDateTime = n.GetDateTimeOffsetValue(); } },
                { "submissionId", n => { SubmissionId = n.GetStringValue(); } },
                { "submitter", n => { Submitter = n.GetStringValue(); } },
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
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteStringValue("recipient", Recipient);
            writer.WriteStringValue("reportType", ReportType);
            writer.WriteStringValue("sender", Sender);
            writer.WriteStringValue("senderIp", SenderIp);
            writer.WriteStringValue("subject", Subject);
            writer.WriteDateTimeOffsetValue("submissionDateTime", SubmissionDateTime);
            writer.WriteStringValue("submissionId", SubmissionId);
            writer.WriteStringValue("submitter", Submitter);
        }
    }
}
#pragma warning restore CS0618
