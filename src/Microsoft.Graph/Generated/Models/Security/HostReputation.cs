// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class HostReputation : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The classification property</summary>
        public global::Microsoft.Graph.Models.Security.HostReputationClassification? Classification
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.HostReputationClassification?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
        /// <summary>A collection of rules that have been used to calculate the classification and score.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostReputationRule>? Rules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostReputationRule>?>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostReputationRule> Rules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostReputationRule>>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
#endif
        /// <summary>The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.</summary>
        public int? Score
        {
            get { return BackingStore?.Get<int?>("score"); }
            set { BackingStore?.Set("score", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.HostReputation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.HostReputation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.HostReputation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classification", n => { Classification = n.GetEnumValue<global::Microsoft.Graph.Models.Security.HostReputationClassification>(); } },
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostReputationRule>(global::Microsoft.Graph.Models.Security.HostReputationRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "score", n => { Score = n.GetIntValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.HostReputationClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostReputationRule>("rules", Rules);
            writer.WriteIntValue("score", Score);
        }
    }
}
#pragma warning restore CS0618
