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
    public partial class X509CertificateCombinationConfiguration : global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A list of allowed subject key identifier values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedIssuerSkis
        {
            get { return BackingStore?.Get<List<string>?>("allowedIssuerSkis"); }
            set { BackingStore?.Set("allowedIssuerSkis", value); }
        }
#nullable restore
#else
        public List<string> AllowedIssuerSkis
        {
            get { return BackingStore?.Get<List<string>>("allowedIssuerSkis"); }
            set { BackingStore?.Set("allowedIssuerSkis", value); }
        }
#endif
        /// <summary>A list of allowed policy OIDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedPolicyOIDs
        {
            get { return BackingStore?.Get<List<string>?>("allowedPolicyOIDs"); }
            set { BackingStore?.Set("allowedPolicyOIDs", value); }
        }
#nullable restore
#else
        public List<string> AllowedPolicyOIDs
        {
            get { return BackingStore?.Get<List<string>>("allowedPolicyOIDs"); }
            set { BackingStore?.Set("allowedPolicyOIDs", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.X509CertificateCombinationConfiguration"/> and sets the default values.
        /// </summary>
        public X509CertificateCombinationConfiguration() : base()
        {
            OdataType = "#microsoft.graph.x509CertificateCombinationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.X509CertificateCombinationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.X509CertificateCombinationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.X509CertificateCombinationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedIssuerSkis", n => { AllowedIssuerSkis = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "allowedPolicyOIDs", n => { AllowedPolicyOIDs = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("allowedIssuerSkis", AllowedIssuerSkis);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedPolicyOIDs", AllowedPolicyOIDs);
        }
    }
}
#pragma warning restore CS0618
