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
    public partial class OnUserCreateStartExternalUsersSelfServiceSignUp : global::Microsoft.Graph.Models.OnUserCreateStartHandler, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The type of user to create. Maps to userType property of user object. The possible values are: member, guest, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.UserType? UserTypeToCreate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserType?>("userTypeToCreate"); }
            set { BackingStore?.Set("userTypeToCreate", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.OnUserCreateStartExternalUsersSelfServiceSignUp"/> and sets the default values.
        /// </summary>
        public OnUserCreateStartExternalUsersSelfServiceSignUp() : base()
        {
            OdataType = "#microsoft.graph.onUserCreateStartExternalUsersSelfServiceSignUp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OnUserCreateStartExternalUsersSelfServiceSignUp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OnUserCreateStartExternalUsersSelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OnUserCreateStartExternalUsersSelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "userTypeToCreate", n => { UserTypeToCreate = n.GetEnumValue<global::Microsoft.Graph.Models.UserType>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.UserType>("userTypeToCreate", UserTypeToCreate);
        }
    }
}
#pragma warning restore CS0618
