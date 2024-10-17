// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Configuration used to deliver a set of custom settings as-is to apps for users to whom the configuration is scoped
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedAppConfiguration : global::Microsoft.Graph.Models.ManagedAppPolicy, IParsable
    {
        /// <summary>A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.KeyValuePair>? CustomSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValuePair>?>("customSettings"); }
            set { BackingStore?.Set("customSettings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.KeyValuePair> CustomSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValuePair>>("customSettings"); }
            set { BackingStore?.Set("customSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ManagedAppConfiguration"/> and sets the default values.
        /// </summary>
        public ManagedAppConfiguration() : base()
        {
            OdataType = "#microsoft.graph.managedAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedAppConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ManagedAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.targetedManagedAppConfiguration" => new global::Microsoft.Graph.Models.TargetedManagedAppConfiguration(),
                _ => new global::Microsoft.Graph.Models.ManagedAppConfiguration(),
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
                { "customSettings", n => { CustomSettings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValuePair>(global::Microsoft.Graph.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValuePair>("customSettings", CustomSettings);
        }
    }
}
#pragma warning restore CS0618
