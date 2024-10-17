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
    public partial class DomainDnsMxRecord : global::Microsoft.Graph.Models.DomainDnsRecord, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Value used when configuring the answer/destination/value of the MX record at the DNS host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailExchange
        {
            get { return BackingStore?.Get<string?>("mailExchange"); }
            set { BackingStore?.Set("mailExchange", value); }
        }
#nullable restore
#else
        public string MailExchange
        {
            get { return BackingStore?.Get<string>("mailExchange"); }
            set { BackingStore?.Set("mailExchange", value); }
        }
#endif
        /// <summary>Value used when configuring the Preference/Priority property of the MX record at the DNS host.</summary>
        public int? Preference
        {
            get { return BackingStore?.Get<int?>("preference"); }
            set { BackingStore?.Set("preference", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DomainDnsMxRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DomainDnsMxRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DomainDnsMxRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "mailExchange", n => { MailExchange = n.GetStringValue(); } },
                { "preference", n => { Preference = n.GetIntValue(); } },
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
            writer.WriteStringValue("mailExchange", MailExchange);
            writer.WriteIntValue("preference", Preference);
        }
    }
}
#pragma warning restore CS0618
