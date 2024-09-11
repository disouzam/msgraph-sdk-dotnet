// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class HealthIssue : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The additionalInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdditionalInformation
        {
            get { return BackingStore?.Get<List<string>?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public List<string> AdditionalInformation
        {
            get { return BackingStore?.Get<List<string>>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
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
        /// <summary>The domainNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DomainNames
        {
            get { return BackingStore?.Get<List<string>?>("domainNames"); }
            set { BackingStore?.Set("domainNames", value); }
        }
#nullable restore
#else
        public List<string> DomainNames
        {
            get { return BackingStore?.Get<List<string>>("domainNames"); }
            set { BackingStore?.Set("domainNames", value); }
        }
#endif
        /// <summary>The healthIssueType property</summary>
        public global::Microsoft.Graph.Models.Security.HealthIssueType? HealthIssueType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.HealthIssueType?>("healthIssueType"); }
            set { BackingStore?.Set("healthIssueType", value); }
        }
        /// <summary>The issueTypeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueTypeId
        {
            get { return BackingStore?.Get<string?>("issueTypeId"); }
            set { BackingStore?.Set("issueTypeId", value); }
        }
#nullable restore
#else
        public string IssueTypeId
        {
            get { return BackingStore?.Get<string>("issueTypeId"); }
            set { BackingStore?.Set("issueTypeId", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The recommendations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Recommendations
        {
            get { return BackingStore?.Get<List<string>?>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#nullable restore
#else
        public List<string> Recommendations
        {
            get { return BackingStore?.Get<List<string>>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#endif
        /// <summary>The recommendedActionCommands property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecommendedActionCommands
        {
            get { return BackingStore?.Get<List<string>?>("recommendedActionCommands"); }
            set { BackingStore?.Set("recommendedActionCommands", value); }
        }
#nullable restore
#else
        public List<string> RecommendedActionCommands
        {
            get { return BackingStore?.Get<List<string>>("recommendedActionCommands"); }
            set { BackingStore?.Set("recommendedActionCommands", value); }
        }
#endif
        /// <summary>The sensorDNSNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SensorDNSNames
        {
            get { return BackingStore?.Get<List<string>?>("sensorDNSNames"); }
            set { BackingStore?.Set("sensorDNSNames", value); }
        }
#nullable restore
#else
        public List<string> SensorDNSNames
        {
            get { return BackingStore?.Get<List<string>>("sensorDNSNames"); }
            set { BackingStore?.Set("sensorDNSNames", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public global::Microsoft.Graph.Models.Security.HealthIssueSeverity? Severity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.HealthIssueSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Models.Security.HealthIssueStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.HealthIssueStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.HealthIssue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.HealthIssue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.HealthIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "domainNames", n => { DomainNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "healthIssueType", n => { HealthIssueType = n.GetEnumValue<global::Microsoft.Graph.Models.Security.HealthIssueType>(); } },
                { "issueTypeId", n => { IssueTypeId = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "recommendations", n => { Recommendations = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "recommendedActionCommands", n => { RecommendedActionCommands = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "sensorDNSNames", n => { SensorDNSNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::Microsoft.Graph.Models.Security.HealthIssueSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.Security.HealthIssueStatus>(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("additionalInformation", AdditionalInformation);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("domainNames", DomainNames);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.HealthIssueType>("healthIssueType", HealthIssueType);
            writer.WriteStringValue("issueTypeId", IssueTypeId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendations", Recommendations);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendedActionCommands", RecommendedActionCommands);
            writer.WriteCollectionOfPrimitiveValues<string>("sensorDNSNames", SensorDNSNames);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.HealthIssueSeverity>("severity", Severity);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.HealthIssueStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
