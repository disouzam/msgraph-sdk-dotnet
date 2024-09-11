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
    public partial class AuthenticationMethod : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuthenticationMethod"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.emailAuthenticationMethod" => new global::Microsoft.Graph.Models.EmailAuthenticationMethod(),
                "#microsoft.graph.fido2AuthenticationMethod" => new global::Microsoft.Graph.Models.Fido2AuthenticationMethod(),
                "#microsoft.graph.microsoftAuthenticatorAuthenticationMethod" => new global::Microsoft.Graph.Models.MicrosoftAuthenticatorAuthenticationMethod(),
                "#microsoft.graph.passwordAuthenticationMethod" => new global::Microsoft.Graph.Models.PasswordAuthenticationMethod(),
                "#microsoft.graph.phoneAuthenticationMethod" => new global::Microsoft.Graph.Models.PhoneAuthenticationMethod(),
                "#microsoft.graph.softwareOathAuthenticationMethod" => new global::Microsoft.Graph.Models.SoftwareOathAuthenticationMethod(),
                "#microsoft.graph.temporaryAccessPassAuthenticationMethod" => new global::Microsoft.Graph.Models.TemporaryAccessPassAuthenticationMethod(),
                "#microsoft.graph.windowsHelloForBusinessAuthenticationMethod" => new global::Microsoft.Graph.Models.WindowsHelloForBusinessAuthenticationMethod(),
                _ => new global::Microsoft.Graph.Models.AuthenticationMethod(),
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
        }
    }
}
#pragma warning restore CS0618
