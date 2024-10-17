// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.CallRecords
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ParticipantBase : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identity of the call participant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CommunicationsIdentitySet? Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CommunicationsIdentitySet?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CommunicationsIdentitySet Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CommunicationsIdentitySet>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CallRecords.ParticipantBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CallRecords.ParticipantBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.callRecords.organizer" => new global::Microsoft.Graph.Models.CallRecords.Organizer(),
                "#microsoft.graph.callRecords.participant" => new global::Microsoft.Graph.Models.CallRecords.Participant(),
                _ => new global::Microsoft.Graph.Models.CallRecords.ParticipantBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "identity", n => { Identity = n.GetObjectValue<global::Microsoft.Graph.Models.CommunicationsIdentitySet>(global::Microsoft.Graph.Models.CommunicationsIdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CommunicationsIdentitySet>("identity", Identity);
        }
    }
}
#pragma warning restore CS0618
