// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp : global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartHandler, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Optional. Specifies whether the authentication flow includes an option to sign up (create account) and sign in. Default value is false meaning only sign in is enabled.</summary>
        public bool? IsSignUpAllowed
        {
            get { return BackingStore?.Get<bool?>("isSignUpAllowed"); }
            set { BackingStore?.Set("isSignUpAllowed", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp"/> and sets the default values.
        /// </summary>
        public OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp() : base()
        {
            OdataType = "#microsoft.graph.onInteractiveAuthFlowStartExternalUsersSelfServiceSignUp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OnInteractiveAuthFlowStartExternalUsersSelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isSignUpAllowed", n => { IsSignUpAllowed = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("isSignUpAllowed", IsSignUpAllowed);
        }
    }
}
#pragma warning restore CS0618
