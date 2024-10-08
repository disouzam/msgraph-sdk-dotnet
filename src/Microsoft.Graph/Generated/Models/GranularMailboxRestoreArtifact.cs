// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class GranularMailboxRestoreArtifact : global::Microsoft.Graph.Models.MailboxRestoreArtifact, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>.</summary>
        public int? ArtifactCount
        {
            get { return BackingStore?.Get<int?>("artifactCount"); }
            set { BackingStore?.Set("artifactCount", value); }
        }
        /// <summary>.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SearchResponseId
        {
            get { return BackingStore?.Get<string?>("searchResponseId"); }
            set { BackingStore?.Set("searchResponseId", value); }
        }
#nullable restore
#else
        public string SearchResponseId
        {
            get { return BackingStore?.Get<string>("searchResponseId"); }
            set { BackingStore?.Set("searchResponseId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.GranularMailboxRestoreArtifact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.GranularMailboxRestoreArtifact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.GranularMailboxRestoreArtifact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "artifactCount", n => { ArtifactCount = n.GetIntValue(); } },
                { "searchResponseId", n => { SearchResponseId = n.GetStringValue(); } },
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
            writer.WriteIntValue("artifactCount", ArtifactCount);
            writer.WriteStringValue("searchResponseId", SearchResponseId);
        }
    }
}
#pragma warning restore CS0618
