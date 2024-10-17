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
    public partial class CertificateBasedAuthConfiguration : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of certificate authorities which creates a trusted certificate chain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CertificateAuthority>? CertificateAuthorities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CertificateAuthority>?>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CertificateAuthority> CertificateAuthorities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CertificateAuthority>>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CertificateBasedAuthConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CertificateBasedAuthConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CertificateBasedAuthConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateAuthorities", n => { CertificateAuthorities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CertificateAuthority>(global::Microsoft.Graph.Models.CertificateAuthority.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CertificateAuthority>("certificateAuthorities", CertificateAuthorities);
        }
    }
}
#pragma warning restore CS0618
