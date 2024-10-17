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
    public partial class EdiscoveryReviewTag : global::Microsoft.Graph.Models.Security.Tag, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether a single or multiple child tags can be associated with a document. Possible values are: One, Many.  This value controls whether the UX presents the tags as checkboxes or a radio button group.</summary>
        public global::Microsoft.Graph.Models.Security.ChildSelectability? ChildSelectability
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ChildSelectability?>("childSelectability"); }
            set { BackingStore?.Set("childSelectability", value); }
        }
        /// <summary>Returns the tags that are a child of a tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>? ChildTags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>?>("childTags"); }
            set { BackingStore?.Set("childTags", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag> ChildTags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>>("childTags"); }
            set { BackingStore?.Set("childTags", value); }
        }
#endif
        /// <summary>Returns the parent tag of the specified tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag? Parent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag?>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag Parent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag"/> and sets the default values.
        /// </summary>
        public EdiscoveryReviewTag() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoveryReviewTag";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childSelectability", n => { ChildSelectability = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ChildSelectability>(); } },
                { "childTags", n => { ChildTags = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>(global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parent", n => { Parent = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>(global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ChildSelectability>("childSelectability", ChildSelectability);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>("childTags", ChildTags);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryReviewTag>("parent", Parent);
        }
    }
}
#pragma warning restore CS0618
