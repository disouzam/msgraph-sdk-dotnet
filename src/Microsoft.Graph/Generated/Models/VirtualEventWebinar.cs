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
    public partial class VirtualEventWebinar : global::Microsoft.Graph.Models.VirtualEvent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>To whom the webinar is visible. Possible values are: everyone, organization, and unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.MeetingAudience? Audience
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MeetingAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
        /// <summary>Identity information of coorganizers of the webinar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CommunicationsUserIdentity>? CoOrganizers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CommunicationsUserIdentity>?>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CommunicationsUserIdentity> CoOrganizers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CommunicationsUserIdentity>>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#endif
        /// <summary>Registration configuration of the webinar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration? RegistrationConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration?>("registrationConfiguration"); }
            set { BackingStore?.Set("registrationConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration RegistrationConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration>("registrationConfiguration"); }
            set { BackingStore?.Set("registrationConfiguration", value); }
        }
#endif
        /// <summary>Registration records of the webinar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.VirtualEventRegistration>? Registrations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.VirtualEventRegistration>?>("registrations"); }
            set { BackingStore?.Set("registrations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.VirtualEventRegistration> Registrations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.VirtualEventRegistration>>("registrations"); }
            set { BackingStore?.Set("registrations", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.VirtualEventWebinar"/> and sets the default values.
        /// </summary>
        public VirtualEventWebinar() : base()
        {
            OdataType = "#microsoft.graph.virtualEventWebinar";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.VirtualEventWebinar"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.VirtualEventWebinar CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.VirtualEventWebinar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetEnumValue<global::Microsoft.Graph.Models.MeetingAudience>(); } },
                { "coOrganizers", n => { CoOrganizers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CommunicationsUserIdentity>(global::Microsoft.Graph.Models.CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "registrationConfiguration", n => { RegistrationConfiguration = n.GetObjectValue<global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration>(global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration.CreateFromDiscriminatorValue); } },
                { "registrations", n => { Registrations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.VirtualEventRegistration>(global::Microsoft.Graph.Models.VirtualEventRegistration.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.MeetingAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CommunicationsUserIdentity>("coOrganizers", CoOrganizers);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration>("registrationConfiguration", RegistrationConfiguration);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.VirtualEventRegistration>("registrations", Registrations);
        }
    }
}
#pragma warning restore CS0618
