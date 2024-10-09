// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.CallRecords
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class Session : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Endpoint that answered the session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CallRecords.Endpoint? Callee
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallRecords.Endpoint?>("callee"); }
            set { BackingStore?.Set("callee", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CallRecords.Endpoint Callee
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallRecords.Endpoint>("callee"); }
            set { BackingStore?.Set("callee", value); }
        }
#endif
        /// <summary>Endpoint that initiated the session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CallRecords.Endpoint? Caller
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallRecords.Endpoint?>("caller"); }
            set { BackingStore?.Set("caller", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CallRecords.Endpoint Caller
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallRecords.Endpoint>("caller"); }
            set { BackingStore?.Set("caller", value); }
        }
#endif
        /// <summary>UTC time when the last user left the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Failure information associated with the session if the session failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CallRecords.FailureInfo? FailureInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallRecords.FailureInfo?>("failureInfo"); }
            set { BackingStore?.Set("failureInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CallRecords.FailureInfo FailureInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallRecords.FailureInfo>("failureInfo"); }
            set { BackingStore?.Set("failureInfo", value); }
        }
#endif
        /// <summary>Specifies whether the session is a test.</summary>
        public bool? IsTest
        {
            get { return BackingStore?.Get<bool?>("isTest"); }
            set { BackingStore?.Set("isTest", value); }
        }
        /// <summary>List of modalities present in the session. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CallRecords.Modality?>? Modalities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CallRecords.Modality?>?>("modalities"); }
            set { BackingStore?.Set("modalities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CallRecords.Modality?> Modalities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CallRecords.Modality?>>("modalities"); }
            set { BackingStore?.Set("modalities", value); }
        }
#endif
        /// <summary>The list of segments involved in the session. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CallRecords.Segment>? Segments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CallRecords.Segment>?>("segments"); }
            set { BackingStore?.Set("segments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CallRecords.Segment> Segments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CallRecords.Segment>>("segments"); }
            set { BackingStore?.Set("segments", value); }
        }
#endif
        /// <summary>UTC time when the first user joined the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CallRecords.Session"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CallRecords.Session CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CallRecords.Session();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callee", n => { Callee = n.GetObjectValue<global::Microsoft.Graph.Models.CallRecords.Endpoint>(global::Microsoft.Graph.Models.CallRecords.Endpoint.CreateFromDiscriminatorValue); } },
                { "caller", n => { Caller = n.GetObjectValue<global::Microsoft.Graph.Models.CallRecords.Endpoint>(global::Microsoft.Graph.Models.CallRecords.Endpoint.CreateFromDiscriminatorValue); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "failureInfo", n => { FailureInfo = n.GetObjectValue<global::Microsoft.Graph.Models.CallRecords.FailureInfo>(global::Microsoft.Graph.Models.CallRecords.FailureInfo.CreateFromDiscriminatorValue); } },
                { "isTest", n => { IsTest = n.GetBoolValue(); } },
                { "modalities", n => { Modalities = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.CallRecords.Modality>()?.AsList(); } },
                { "segments", n => { Segments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CallRecords.Segment>(global::Microsoft.Graph.Models.CallRecords.Segment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CallRecords.Endpoint>("callee", Callee);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CallRecords.Endpoint>("caller", Caller);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CallRecords.FailureInfo>("failureInfo", FailureInfo);
            writer.WriteBoolValue("isTest", IsTest);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.CallRecords.Modality>("modalities", Modalities);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CallRecords.Segment>("segments", Segments);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
#pragma warning restore CS0618
