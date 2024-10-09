// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.ExternalConnectors
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ExternalItem : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>An array of access control entries. Each entry specifies the access granted to a user or group. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ExternalConnectors.Acl>? Acl
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ExternalConnectors.Acl>?>("acl"); }
            set { BackingStore?.Set("acl", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ExternalConnectors.Acl> Acl
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ExternalConnectors.Acl>>("acl"); }
            set { BackingStore?.Set("acl", value); }
        }
#endif
        /// <summary>Returns a list of activities performed on the item. Write-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity>? Activities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity> Activities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>A plain-text  representation of the contents of the item. The text in this property is full-text indexed. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent? Content
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent Content
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>A property bag with the properties of the item. The properties MUST conform to the schema defined for the externalConnection. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ExternalConnectors.Properties? Properties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExternalConnectors.Properties?>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ExternalConnectors.Properties Properties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExternalConnectors.Properties>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ExternalConnectors.ExternalItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ExternalConnectors.ExternalItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ExternalConnectors.ExternalItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acl", n => { Acl = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ExternalConnectors.Acl>(global::Microsoft.Graph.Models.ExternalConnectors.Acl.CreateFromDiscriminatorValue)?.AsList(); } },
                { "activities", n => { Activities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity>(global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "content", n => { Content = n.GetObjectValue<global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent>(global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent.CreateFromDiscriminatorValue); } },
                { "properties", n => { Properties = n.GetObjectValue<global::Microsoft.Graph.Models.ExternalConnectors.Properties>(global::Microsoft.Graph.Models.ExternalConnectors.Properties.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ExternalConnectors.Acl>("acl", Acl);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ExternalConnectors.ExternalActivity>("activities", Activities);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ExternalConnectors.ExternalItemContent>("content", Content);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ExternalConnectors.Properties>("properties", Properties);
        }
    }
}
#pragma warning restore CS0618
