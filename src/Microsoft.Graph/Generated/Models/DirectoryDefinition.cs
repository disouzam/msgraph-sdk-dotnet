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
    public partial class DirectoryDefinition : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The discoverabilities property</summary>
        public global::Microsoft.Graph.Models.DirectoryDefinitionDiscoverabilities? Discoverabilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryDefinitionDiscoverabilities?>("discoverabilities"); }
            set { BackingStore?.Set("discoverabilities", value); }
        }
        /// <summary>Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DiscoveryDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("discoveryDateTime"); }
            set { BackingStore?.Set("discoveryDateTime", value); }
        }
        /// <summary>Name of the directory. Must be unique within the synchronization schema. Not nullable.</summary>
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
        /// <summary>Collection of objects supported by the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ObjectDefinition>? Objects
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ObjectDefinition>?>("objects"); }
            set { BackingStore?.Set("objects", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ObjectDefinition> Objects
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ObjectDefinition>>("objects"); }
            set { BackingStore?.Set("objects", value); }
        }
#endif
        /// <summary>Whether this object is read-only.</summary>
        public bool? ReadOnly
        {
            get { return BackingStore?.Get<bool?>("readOnly"); }
            set { BackingStore?.Set("readOnly", value); }
        }
        /// <summary>Read only value that indicates version discovered. null if discovery hasn&apos;t yet occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DirectoryDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DirectoryDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DirectoryDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "discoverabilities", n => { Discoverabilities = n.GetEnumValue<global::Microsoft.Graph.Models.DirectoryDefinitionDiscoverabilities>(); } },
                { "discoveryDateTime", n => { DiscoveryDateTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "objects", n => { Objects = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ObjectDefinition>(global::Microsoft.Graph.Models.ObjectDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.DirectoryDefinitionDiscoverabilities>("discoverabilities", Discoverabilities);
            writer.WriteDateTimeOffsetValue("discoveryDateTime", DiscoveryDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ObjectDefinition>("objects", Objects);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
