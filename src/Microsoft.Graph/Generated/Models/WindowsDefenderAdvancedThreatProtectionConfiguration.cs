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
    /// Windows Defender AdvancedThreatProtection Configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class WindowsDefenderAdvancedThreatProtectionConfiguration : global::Microsoft.Graph.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Windows Defender AdvancedThreatProtection &apos;Allow Sample Sharing&apos; Rule</summary>
        public bool? AllowSampleSharing
        {
            get { return BackingStore?.Get<bool?>("allowSampleSharing"); }
            set { BackingStore?.Set("allowSampleSharing", value); }
        }
        /// <summary>Expedite Windows Defender Advanced Threat Protection telemetry reporting frequency.</summary>
        public bool? EnableExpeditedTelemetryReporting
        {
            get { return BackingStore?.Get<bool?>("enableExpeditedTelemetryReporting"); }
            set { BackingStore?.Set("enableExpeditedTelemetryReporting", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.WindowsDefenderAdvancedThreatProtectionConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsDefenderAdvancedThreatProtectionConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WindowsDefenderAdvancedThreatProtectionConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WindowsDefenderAdvancedThreatProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WindowsDefenderAdvancedThreatProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowSampleSharing", n => { AllowSampleSharing = n.GetBoolValue(); } },
                { "enableExpeditedTelemetryReporting", n => { EnableExpeditedTelemetryReporting = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("allowSampleSharing", AllowSampleSharing);
            writer.WriteBoolValue("enableExpeditedTelemetryReporting", EnableExpeditedTelemetryReporting);
        }
    }
}
#pragma warning restore CS0618
