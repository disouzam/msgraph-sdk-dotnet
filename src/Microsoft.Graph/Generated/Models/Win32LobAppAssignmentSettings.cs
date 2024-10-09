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
    /// Contains properties used to assign an Win32 LOB mobile app to a group.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class Win32LobAppAssignmentSettings : global::Microsoft.Graph.Models.MobileAppAssignmentSettings, IParsable
    {
        /// <summary>Contains value for delivery optimization priority.</summary>
        public global::Microsoft.Graph.Models.Win32LobAppDeliveryOptimizationPriority? DeliveryOptimizationPriority
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppDeliveryOptimizationPriority?>("deliveryOptimizationPriority"); }
            set { BackingStore?.Set("deliveryOptimizationPriority", value); }
        }
        /// <summary>The install time settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.MobileAppInstallTimeSettings? InstallTimeSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MobileAppInstallTimeSettings?>("installTimeSettings"); }
            set { BackingStore?.Set("installTimeSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.MobileAppInstallTimeSettings InstallTimeSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MobileAppInstallTimeSettings>("installTimeSettings"); }
            set { BackingStore?.Set("installTimeSettings", value); }
        }
#endif
        /// <summary>Contains value for notification status.</summary>
        public global::Microsoft.Graph.Models.Win32LobAppNotification? Notifications
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppNotification?>("notifications"); }
            set { BackingStore?.Set("notifications", value); }
        }
        /// <summary>The reboot settings to apply for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Win32LobAppRestartSettings? RestartSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppRestartSettings?>("restartSettings"); }
            set { BackingStore?.Set("restartSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Win32LobAppRestartSettings RestartSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppRestartSettings>("restartSettings"); }
            set { BackingStore?.Set("restartSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Win32LobAppAssignmentSettings"/> and sets the default values.
        /// </summary>
        public Win32LobAppAssignmentSettings() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Win32LobAppAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Win32LobAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Win32LobAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deliveryOptimizationPriority", n => { DeliveryOptimizationPriority = n.GetEnumValue<global::Microsoft.Graph.Models.Win32LobAppDeliveryOptimizationPriority>(); } },
                { "installTimeSettings", n => { InstallTimeSettings = n.GetObjectValue<global::Microsoft.Graph.Models.MobileAppInstallTimeSettings>(global::Microsoft.Graph.Models.MobileAppInstallTimeSettings.CreateFromDiscriminatorValue); } },
                { "notifications", n => { Notifications = n.GetEnumValue<global::Microsoft.Graph.Models.Win32LobAppNotification>(); } },
                { "restartSettings", n => { RestartSettings = n.GetObjectValue<global::Microsoft.Graph.Models.Win32LobAppRestartSettings>(global::Microsoft.Graph.Models.Win32LobAppRestartSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Win32LobAppDeliveryOptimizationPriority>("deliveryOptimizationPriority", DeliveryOptimizationPriority);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.MobileAppInstallTimeSettings>("installTimeSettings", InstallTimeSettings);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Win32LobAppNotification>("notifications", Notifications);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Win32LobAppRestartSettings>("restartSettings", RestartSettings);
        }
    }
}
#pragma warning restore CS0618
