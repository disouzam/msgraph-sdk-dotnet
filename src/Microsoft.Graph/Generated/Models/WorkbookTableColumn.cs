// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class WorkbookTableColumn : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The filter applied to the column. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookFilter? Filter
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookFilter?>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookFilter Filter
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookFilter>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
#endif
        /// <summary>The index of the column within the columns collection of the table. Zero-indexed. Read-only.</summary>
        public int? Index
        {
            get { return BackingStore?.Get<int?>("index"); }
            set { BackingStore?.Set("index", value); }
        }
        /// <summary>The name of the table column.</summary>
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
        /// <summary>TRepresents the raw values of the specified range. The data returned could be of type string, number, or a Boolean. Cell that contain an error will return the error string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Values
        {
            get { return BackingStore?.Get<UntypedNode?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public UntypedNode Values
        {
            get { return BackingStore?.Get<UntypedNode>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookTableColumn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkbookTableColumn CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkbookTableColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "filter", n => { Filter = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookFilter>(global::Microsoft.Graph.Models.WorkbookFilter.CreateFromDiscriminatorValue); } },
                { "index", n => { Index = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "values", n => { Values = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookFilter>("filter", Filter);
            writer.WriteIntValue("index", Index);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<UntypedNode>("values", Values);
        }
    }
}
#pragma warning restore CS0618
