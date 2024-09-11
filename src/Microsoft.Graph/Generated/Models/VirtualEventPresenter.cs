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
    public partial class VirtualEventPresenter : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Email address of the presenter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>Identity information of the presenter. The supported identities are: communicationsGuestIdentity and communicationsUserIdentity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>Other details about the presenter. This property returns null when the virtual event type is virtualEventTownhall.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.VirtualEventPresenterDetails? PresenterDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VirtualEventPresenterDetails?>("presenterDetails"); }
            set { BackingStore?.Set("presenterDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.VirtualEventPresenterDetails PresenterDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VirtualEventPresenterDetails>("presenterDetails"); }
            set { BackingStore?.Set("presenterDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.VirtualEventPresenter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.VirtualEventPresenter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.VirtualEventPresenter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "email", n => { Email = n.GetStringValue(); } },
                { "identity", n => { Identity = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "presenterDetails", n => { PresenterDetails = n.GetObjectValue<global::Microsoft.Graph.Models.VirtualEventPresenterDetails>(global::Microsoft.Graph.Models.VirtualEventPresenterDetails.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("identity", Identity);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.VirtualEventPresenterDetails>("presenterDetails", PresenterDetails);
        }
    }
}
#pragma warning restore CS0618
