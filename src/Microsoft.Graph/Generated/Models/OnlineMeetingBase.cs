// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class OnlineMeetingBase : Entity, IParsable {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera {
            get { return BackingStore?.Get<bool?>("allowAttendeeToEnableCamera"); }
            set { BackingStore?.Set("allowAttendeeToEnableCamera", value); }
        }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic {
            get { return BackingStore?.Get<bool?>("allowAttendeeToEnableMic"); }
            set { BackingStore?.Set("allowAttendeeToEnableMic", value); }
        }
        /// <summary>Specifies who can be a presenter in a meeting.</summary>
        public OnlineMeetingPresenters? AllowedPresenters {
            get { return BackingStore?.Get<OnlineMeetingPresenters?>("allowedPresenters"); }
            set { BackingStore?.Set("allowedPresenters", value); }
        }
        /// <summary>Specifies the mode of the meeting chat.</summary>
        public MeetingChatMode? AllowMeetingChat {
            get { return BackingStore?.Get<MeetingChatMode?>("allowMeetingChat"); }
            set { BackingStore?.Set("allowMeetingChat", value); }
        }
        /// <summary>Specifies if participants are allowed to rename themselves in an instance of the meeting.</summary>
        public bool? AllowParticipantsToChangeName {
            get { return BackingStore?.Get<bool?>("allowParticipantsToChangeName"); }
            set { BackingStore?.Set("allowParticipantsToChangeName", value); }
        }
        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions {
            get { return BackingStore?.Get<bool?>("allowTeamworkReactions"); }
            set { BackingStore?.Set("allowTeamworkReactions", value); }
        }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingAttendanceReport>? AttendanceReports {
            get { return BackingStore?.Get<List<MeetingAttendanceReport>?>("attendanceReports"); }
            set { BackingStore?.Set("attendanceReports", value); }
        }
#nullable restore
#else
        public List<MeetingAttendanceReport> AttendanceReports {
            get { return BackingStore?.Get<List<MeetingAttendanceReport>>("attendanceReports"); }
            set { BackingStore?.Set("attendanceReports", value); }
        }
#endif
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AudioConferencing? AudioConferencing {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AudioConferencing?>("audioConferencing"); }
            set { BackingStore?.Set("audioConferencing", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AudioConferencing AudioConferencing {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AudioConferencing>("audioConferencing"); }
            set { BackingStore?.Set("audioConferencing", value); }
        }
#endif
        /// <summary>The chat information associated with this online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ChatInfo? ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo?>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ChatInfo ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#endif
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced {
            get { return BackingStore?.Get<bool?>("isEntryExitAnnounced"); }
            set { BackingStore?.Set("isEntryExitAnnounced", value); }
        }
        /// <summary>The join information in the language and locale variant specified in &apos;Accept-Language&apos; request HTTP header. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? JoinInformation {
            get { return BackingStore?.Get<ItemBody?>("joinInformation"); }
            set { BackingStore?.Set("joinInformation", value); }
        }
#nullable restore
#else
        public ItemBody JoinInformation {
            get { return BackingStore?.Get<ItemBody>("joinInformation"); }
            set { BackingStore?.Set("joinInformation", value); }
        }
#endif
        /// <summary>Specifies the joinMeetingId, the meeting passcode, and the requirement for the passcode. Once an onlineMeeting is created, the joinMeetingIdSettings can&apos;t be modified. To make any changes to this property, you must cancel this meeting and create a new one.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.JoinMeetingIdSettings? JoinMeetingIdSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.JoinMeetingIdSettings?>("joinMeetingIdSettings"); }
            set { BackingStore?.Set("joinMeetingIdSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.JoinMeetingIdSettings JoinMeetingIdSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.JoinMeetingIdSettings>("joinMeetingIdSettings"); }
            set { BackingStore?.Set("joinMeetingIdSettings", value); }
        }
#endif
        /// <summary>The join URL of the online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl {
            get { return BackingStore?.Get<string?>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#nullable restore
#else
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#endif
        /// <summary>Specifies which participants can bypass the meeting lobby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.LobbyBypassSettings? LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LobbyBypassSettings?>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.LobbyBypassSettings LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LobbyBypassSettings>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
#endif
        /// <summary>Indicates whether to record the meeting automatically.</summary>
        public bool? RecordAutomatically {
            get { return BackingStore?.Get<bool?>("recordAutomatically"); }
            set { BackingStore?.Set("recordAutomatically", value); }
        }
        /// <summary>The shareMeetingChatHistoryDefault property</summary>
        public MeetingChatHistoryDefaultMode? ShareMeetingChatHistoryDefault {
            get { return BackingStore?.Get<MeetingChatHistoryDefaultMode?>("shareMeetingChatHistoryDefault"); }
            set { BackingStore?.Set("shareMeetingChatHistoryDefault", value); }
        }
        /// <summary>The subject of the online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The video teleconferencing ID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoTeleconferenceId {
            get { return BackingStore?.Get<string?>("videoTeleconferenceId"); }
            set { BackingStore?.Set("videoTeleconferenceId", value); }
        }
#nullable restore
#else
        public string VideoTeleconferenceId {
            get { return BackingStore?.Get<string>("videoTeleconferenceId"); }
            set { BackingStore?.Set("videoTeleconferenceId", value); }
        }
#endif
        /// <summary>Specifies whether the client application should apply a watermark to a content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WatermarkProtectionValues? WatermarkProtection {
            get { return BackingStore?.Get<WatermarkProtectionValues?>("watermarkProtection"); }
            set { BackingStore?.Set("watermarkProtection", value); }
        }
#nullable restore
#else
        public WatermarkProtectionValues WatermarkProtection {
            get { return BackingStore?.Get<WatermarkProtectionValues>("watermarkProtection"); }
            set { BackingStore?.Set("watermarkProtection", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnlineMeetingBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.onlineMeeting" => new OnlineMeeting(),
                "#microsoft.graph.virtualEventSession" => new VirtualEventSession(),
                _ => new OnlineMeetingBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAttendeeToEnableCamera", n => { AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", n => { AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowMeetingChat", n => { AllowMeetingChat = n.GetEnumValue<MeetingChatMode>(); } },
                {"allowParticipantsToChangeName", n => { AllowParticipantsToChangeName = n.GetBoolValue(); } },
                {"allowTeamworkReactions", n => { AllowTeamworkReactions = n.GetBoolValue(); } },
                {"allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"attendanceReports", n => { AttendanceReports = n.GetCollectionOfObjectValues<MeetingAttendanceReport>(MeetingAttendanceReport.CreateFromDiscriminatorValue)?.ToList(); } },
                {"audioConferencing", n => { AudioConferencing = n.GetObjectValue<Microsoft.Graph.Models.AudioConferencing>(Microsoft.Graph.Models.AudioConferencing.CreateFromDiscriminatorValue); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Models.ChatInfo>(Microsoft.Graph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"isEntryExitAnnounced", n => { IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", n => { JoinInformation = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"joinMeetingIdSettings", n => { JoinMeetingIdSettings = n.GetObjectValue<Microsoft.Graph.Models.JoinMeetingIdSettings>(Microsoft.Graph.Models.JoinMeetingIdSettings.CreateFromDiscriminatorValue); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<Microsoft.Graph.Models.LobbyBypassSettings>(Microsoft.Graph.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
                {"recordAutomatically", n => { RecordAutomatically = n.GetBoolValue(); } },
                {"shareMeetingChatHistoryDefault", n => { ShareMeetingChatHistoryDefault = n.GetEnumValue<MeetingChatHistoryDefaultMode>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", n => { VideoTeleconferenceId = n.GetStringValue(); } },
                {"watermarkProtection", n => { WatermarkProtection = n.GetObjectValue<WatermarkProtectionValues>(WatermarkProtectionValues.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteEnumValue<MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowParticipantsToChangeName", AllowParticipantsToChangeName);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteCollectionOfObjectValues<MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteObjectValue<Microsoft.Graph.Models.AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<Microsoft.Graph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ItemBody>("joinInformation", JoinInformation);
            writer.WriteObjectValue<Microsoft.Graph.Models.JoinMeetingIdSettings>("joinMeetingIdSettings", JoinMeetingIdSettings);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<Microsoft.Graph.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteBoolValue("recordAutomatically", RecordAutomatically);
            writer.WriteEnumValue<MeetingChatHistoryDefaultMode>("shareMeetingChatHistoryDefault", ShareMeetingChatHistoryDefault);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
            writer.WriteObjectValue<WatermarkProtectionValues>("watermarkProtection", WatermarkProtection);
        }
    }
}
