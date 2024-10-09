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
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the iosCustomConfiguration resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class IosCustomConfiguration : global::Microsoft.Graph.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Payload
        {
            get { return BackingStore?.Get<byte[]?>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#nullable restore
#else
        public byte[] Payload
        {
            get { return BackingStore?.Get<byte[]>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#endif
        /// <summary>Payload file name (.mobileconfig</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadFileName
        {
            get { return BackingStore?.Get<string?>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#nullable restore
#else
        public string PayloadFileName
        {
            get { return BackingStore?.Get<string>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#endif
        /// <summary>Name that is displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadName
        {
            get { return BackingStore?.Get<string?>("payloadName"); }
            set { BackingStore?.Set("payloadName", value); }
        }
#nullable restore
#else
        public string PayloadName
        {
            get { return BackingStore?.Get<string>("payloadName"); }
            set { BackingStore?.Set("payloadName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IosCustomConfiguration"/> and sets the default values.
        /// </summary>
        public IosCustomConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosCustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IosCustomConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IosCustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IosCustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "payload", n => { Payload = n.GetByteArrayValue(); } },
                { "payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                { "payloadName", n => { PayloadName = n.GetStringValue(); } },
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
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteStringValue("payloadName", PayloadName);
        }
    }
}
#pragma warning restore CS0618
