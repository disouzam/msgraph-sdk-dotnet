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
    public partial class CalendarSharingMessage : global::Microsoft.Graph.Models.Message, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The canAccept property</summary>
        public bool? CanAccept
        {
            get { return BackingStore?.Get<bool?>("canAccept"); }
            set { BackingStore?.Set("canAccept", value); }
        }
        /// <summary>The sharingMessageAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CalendarSharingMessageAction? SharingMessageAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalendarSharingMessageAction?>("sharingMessageAction"); }
            set { BackingStore?.Set("sharingMessageAction", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CalendarSharingMessageAction SharingMessageAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalendarSharingMessageAction>("sharingMessageAction"); }
            set { BackingStore?.Set("sharingMessageAction", value); }
        }
#endif
        /// <summary>The sharingMessageActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CalendarSharingMessageAction>? SharingMessageActions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CalendarSharingMessageAction>?>("sharingMessageActions"); }
            set { BackingStore?.Set("sharingMessageActions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CalendarSharingMessageAction> SharingMessageActions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CalendarSharingMessageAction>>("sharingMessageActions"); }
            set { BackingStore?.Set("sharingMessageActions", value); }
        }
#endif
        /// <summary>The suggestedCalendarName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestedCalendarName
        {
            get { return BackingStore?.Get<string?>("suggestedCalendarName"); }
            set { BackingStore?.Set("suggestedCalendarName", value); }
        }
#nullable restore
#else
        public string SuggestedCalendarName
        {
            get { return BackingStore?.Get<string>("suggestedCalendarName"); }
            set { BackingStore?.Set("suggestedCalendarName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.CalendarSharingMessage"/> and sets the default values.
        /// </summary>
        public CalendarSharingMessage() : base()
        {
            OdataType = "#microsoft.graph.calendarSharingMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CalendarSharingMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CalendarSharingMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CalendarSharingMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "canAccept", n => { CanAccept = n.GetBoolValue(); } },
                { "sharingMessageAction", n => { SharingMessageAction = n.GetObjectValue<global::Microsoft.Graph.Models.CalendarSharingMessageAction>(global::Microsoft.Graph.Models.CalendarSharingMessageAction.CreateFromDiscriminatorValue); } },
                { "sharingMessageActions", n => { SharingMessageActions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CalendarSharingMessageAction>(global::Microsoft.Graph.Models.CalendarSharingMessageAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "suggestedCalendarName", n => { SuggestedCalendarName = n.GetStringValue(); } },
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
            writer.WriteBoolValue("canAccept", CanAccept);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CalendarSharingMessageAction>("sharingMessageAction", SharingMessageAction);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CalendarSharingMessageAction>("sharingMessageActions", SharingMessageActions);
            writer.WriteStringValue("suggestedCalendarName", SuggestedCalendarName);
        }
    }
}
#pragma warning restore CS0618
