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
    public partial class WorkforceIntegration : global::Microsoft.Graph.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>API version for the call back URL. Start with 1.</summary>
        public int? ApiVersion
        {
            get { return BackingStore?.Get<int?>("apiVersion"); }
            set { BackingStore?.Set("apiVersion", value); }
        }
        /// <summary>Name of the workforce integration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The workforce integration encryption resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkforceIntegrationEncryption? Encryption
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkforceIntegrationEncryption?>("encryption"); }
            set { BackingStore?.Set("encryption", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkforceIntegrationEncryption Encryption
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkforceIntegrationEncryption>("encryption"); }
            set { BackingStore?.Set("encryption", value); }
        }
#endif
        /// <summary>Indicates whether this workforce integration is currently active and available.</summary>
        public bool? IsActive
        {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>The Shifts entities supported for synchronous change notifications. Shifts will make a call back to the url provided on client changes on those entities added here. By default, no entities are supported for change notifications. Possible values are: none, shift, swapRequest, userShiftPreferences, openshift, openShiftRequest, offerShiftRequest, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.WorkforceIntegrationSupportedEntities? SupportedEntities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkforceIntegrationSupportedEntities?>("supportedEntities"); }
            set { BackingStore?.Set("supportedEntities", value); }
        }
        /// <summary>Workforce Integration URL for callbacks from the Shifts service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url
        {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url
        {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.WorkforceIntegration"/> and sets the default values.
        /// </summary>
        public WorkforceIntegration() : base()
        {
            OdataType = "#microsoft.graph.workforceIntegration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkforceIntegration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkforceIntegration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkforceIntegration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "apiVersion", n => { ApiVersion = n.GetIntValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "encryption", n => { Encryption = n.GetObjectValue<global::Microsoft.Graph.Models.WorkforceIntegrationEncryption>(global::Microsoft.Graph.Models.WorkforceIntegrationEncryption.CreateFromDiscriminatorValue); } },
                { "isActive", n => { IsActive = n.GetBoolValue(); } },
                { "supportedEntities", n => { SupportedEntities = n.GetEnumValue<global::Microsoft.Graph.Models.WorkforceIntegrationSupportedEntities>(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteIntValue("apiVersion", ApiVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkforceIntegrationEncryption>("encryption", Encryption);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WorkforceIntegrationSupportedEntities>("supportedEntities", SupportedEntities);
            writer.WriteStringValue("url", Url);
        }
    }
}
#pragma warning restore CS0618
