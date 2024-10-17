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
    /// Contains properties, inherited properties and actions for iOS mobile app configurations.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosMobileAppConfiguration : global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration, IParsable
    {
        /// <summary>mdm app configuration Base64 binary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? EncodedSettingXml
        {
            get { return BackingStore?.Get<byte[]?>("encodedSettingXml"); }
            set { BackingStore?.Set("encodedSettingXml", value); }
        }
#nullable restore
#else
        public byte[] EncodedSettingXml
        {
            get { return BackingStore?.Get<byte[]>("encodedSettingXml"); }
            set { BackingStore?.Set("encodedSettingXml", value); }
        }
#endif
        /// <summary>app configuration setting items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AppConfigurationSettingItem>? Settings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AppConfigurationSettingItem>?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AppConfigurationSettingItem> Settings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AppConfigurationSettingItem>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IosMobileAppConfiguration"/> and sets the default values.
        /// </summary>
        public IosMobileAppConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosMobileAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IosMobileAppConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IosMobileAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IosMobileAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "encodedSettingXml", n => { EncodedSettingXml = n.GetByteArrayValue(); } },
                { "settings", n => { Settings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AppConfigurationSettingItem>(global::Microsoft.Graph.Models.AppConfigurationSettingItem.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteByteArrayValue("encodedSettingXml", EncodedSettingXml);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AppConfigurationSettingItem>("settings", Settings);
        }
    }
}
#pragma warning restore CS0618
