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
    public partial class ParticipantLeftNotification : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The call property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Call? Call
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Call?>("call"); }
            set { BackingStore?.Set("call", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Call Call
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Call>("call"); }
            set { BackingStore?.Set("call", value); }
        }
#endif
        /// <summary>ID of the participant under the policy who has left the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParticipantId
        {
            get { return BackingStore?.Get<string?>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
#nullable restore
#else
        public string ParticipantId
        {
            get { return BackingStore?.Get<string>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ParticipantLeftNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ParticipantLeftNotification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ParticipantLeftNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "call", n => { Call = n.GetObjectValue<global::Microsoft.Graph.Models.Call>(global::Microsoft.Graph.Models.Call.CreateFromDiscriminatorValue); } },
                { "participantId", n => { ParticipantId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Call>("call", Call);
            writer.WriteStringValue("participantId", ParticipantId);
        }
    }
}
#pragma warning restore CS0618
