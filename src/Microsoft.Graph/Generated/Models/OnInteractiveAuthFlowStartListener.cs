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
    public partial class OnInteractiveAuthFlowStartListener : global::Microsoft.Graph.Models.AuthenticationEventListener, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Required. Configuration for what to invoke if the event resolves to this listener. This lets us define potential handler configurations per-event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler? Handler
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler?>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler Handler
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartListener"/> and sets the default values.
        /// </summary>
        public OnInteractiveAuthFlowStartListener() : base()
        {
            OdataType = "#microsoft.graph.onInteractiveAuthFlowStartListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartListener"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartListener CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "handler", n => { Handler = n.GetObjectValue<global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler>(global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler>("handler", Handler);
        }
    }
}
#pragma warning restore CS0618
