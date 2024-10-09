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
    public partial class ConditionalAccessTemplate : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user-friendly name of the template.</summary>
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
        /// <summary>The details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail? Details
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail Details
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The user-friendly name of the template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The scenarios property</summary>
        public global::Microsoft.Graph.Models.TemplateScenarios? Scenarios
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TemplateScenarios?>("scenarios"); }
            set { BackingStore?.Set("scenarios", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ConditionalAccessTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ConditionalAccessTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ConditionalAccessTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "details", n => { Details = n.GetObjectValue<global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail>(global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "scenarios", n => { Scenarios = n.GetEnumValue<global::Microsoft.Graph.Models.TemplateScenarios>(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ConditionalAccessPolicyDetail>("details", Details);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TemplateScenarios>("scenarios", Scenarios);
        }
    }
}
#pragma warning restore CS0618
