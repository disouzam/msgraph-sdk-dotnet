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
    /// Represents a booked appointment of a service by a customer in a business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class BookingAppointment : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation
        {
            get { return BackingStore?.Get<string?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public string AdditionalInformation
        {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>The URL of the meeting to join anonymously.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnonymousJoinWebUrl
        {
            get { return BackingStore?.Get<string?>("anonymousJoinWebUrl"); }
            set { BackingStore?.Set("anonymousJoinWebUrl", value); }
        }
#nullable restore
#else
        public string AnonymousJoinWebUrl
        {
            get { return BackingStore?.Get<string>("anonymousJoinWebUrl"); }
            set { BackingStore?.Set("anonymousJoinWebUrl", value); }
        }
#endif
        /// <summary>The custom label that can be stamped on this appointment by users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppointmentLabel
        {
            get { return BackingStore?.Get<string?>("appointmentLabel"); }
            set { BackingStore?.Set("appointmentLabel", value); }
        }
#nullable restore
#else
        public string AppointmentLabel
        {
            get { return BackingStore?.Get<string>("appointmentLabel"); }
            set { BackingStore?.Set("appointmentLabel", value); }
        }
#endif
        /// <summary>The date, time, and time zone when the appointment was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The SMTP address of the bookingCustomer who books the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerEmailAddress
        {
            get { return BackingStore?.Get<string?>("customerEmailAddress"); }
            set { BackingStore?.Set("customerEmailAddress", value); }
        }
#nullable restore
#else
        public string CustomerEmailAddress
        {
            get { return BackingStore?.Get<string>("customerEmailAddress"); }
            set { BackingStore?.Set("customerEmailAddress", value); }
        }
#endif
        /// <summary>The customer&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName
        {
            get { return BackingStore?.Get<string?>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#nullable restore
#else
        public string CustomerName
        {
            get { return BackingStore?.Get<string>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#endif
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when you read this bookingAppointment by its ID. You can set this property only when you initially create an appointment with a new customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNotes
        {
            get { return BackingStore?.Get<string?>("customerNotes"); }
            set { BackingStore?.Set("customerNotes", value); }
        }
#nullable restore
#else
        public string CustomerNotes
        {
            get { return BackingStore?.Get<string>("customerNotes"); }
            set { BackingStore?.Set("customerNotes", value); }
        }
#endif
        /// <summary>The customer&apos;s phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerPhone
        {
            get { return BackingStore?.Get<string?>("customerPhone"); }
            set { BackingStore?.Set("customerPhone", value); }
        }
#nullable restore
#else
        public string CustomerPhone
        {
            get { return BackingStore?.Get<string>("customerPhone"); }
            set { BackingStore?.Set("customerPhone", value); }
        }
#endif
        /// <summary>A collection of customer properties for an appointment. An appointment contains a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.BookingCustomerInformationBase>? Customers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BookingCustomerInformationBase>?>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.BookingCustomerInformationBase> Customers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BookingCustomerInformationBase>>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerTimeZone
        {
            get { return BackingStore?.Get<string?>("customerTimeZone"); }
            set { BackingStore?.Set("customerTimeZone", value); }
        }
#nullable restore
#else
        public string CustomerTimeZone
        {
            get { return BackingStore?.Get<string>("customerTimeZone"); }
            set { BackingStore?.Set("customerTimeZone", value); }
        }
#endif
        /// <summary>The length of the appointment, denoted in ISO8601 format.</summary>
        public TimeSpan? Duration
        {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>The endDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? EndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone EndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#endif
        /// <summary>The current number of customers in the appointment.</summary>
        public int? FilledAttendeesCount
        {
            get { return BackingStore?.Get<int?>("filledAttendeesCount"); }
            set { BackingStore?.Set("filledAttendeesCount", value); }
        }
        /// <summary>Indicates that the customer can manage bookings created by the staff. The default value is false.</summary>
        public bool? IsCustomerAllowedToManageBooking
        {
            get { return BackingStore?.Get<bool?>("isCustomerAllowedToManageBooking"); }
            set { BackingStore?.Set("isCustomerAllowedToManageBooking", value); }
        }
        /// <summary>Indicates that the appointment is held online. The default value is false.</summary>
        public bool? IsLocationOnline
        {
            get { return BackingStore?.Get<bool?>("isLocationOnline"); }
            set { BackingStore?.Set("isLocationOnline", value); }
        }
        /// <summary>The URL of the online meeting for the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl
        {
            get { return BackingStore?.Get<string?>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#nullable restore
#else
        public string JoinWebUrl
        {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#endif
        /// <summary>The date, time, and time zone when the booking business was last updated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount
        {
            get { return BackingStore?.Get<int?>("maximumAttendeesCount"); }
            set { BackingStore?.Set("maximumAttendeesCount", value); }
        }
        /// <summary>If true indicates that the bookingCustomer for this appointment doesn&apos;t wish to receive a confirmation for this appointment.</summary>
        public bool? OptOutOfCustomerEmail
        {
            get { return BackingStore?.Get<bool?>("optOutOfCustomerEmail"); }
            set { BackingStore?.Set("optOutOfCustomerEmail", value); }
        }
        /// <summary>The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PostBuffer
        {
            get { return BackingStore?.Get<TimeSpan?>("postBuffer"); }
            set { BackingStore?.Set("postBuffer", value); }
        }
        /// <summary>The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PreBuffer
        {
            get { return BackingStore?.Get<TimeSpan?>("preBuffer"); }
            set { BackingStore?.Set("preBuffer", value); }
        }
        /// <summary>The regular price for an appointment for the specified bookingService.</summary>
        public double? Price
        {
            get { return BackingStore?.Get<double?>("price"); }
            set { BackingStore?.Set("price", value); }
        }
        /// <summary>Represents the type of pricing of a booking service.</summary>
        public global::Microsoft.Graph.Models.BookingPriceType? PriceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BookingPriceType?>("priceType"); }
            set { BackingStore?.Set("priceType", value); }
        }
        /// <summary>The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.BookingReminder>? Reminders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BookingReminder>?>("reminders"); }
            set { BackingStore?.Set("reminders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.BookingReminder> Reminders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BookingReminder>>("reminders"); }
            set { BackingStore?.Set("reminders", value); }
        }
#endif
        /// <summary>Another tracking ID for the appointment, if the appointment was created directly by the customer on the scheduling page, as opposed to by a staff member on behalf of the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelfServiceAppointmentId
        {
            get { return BackingStore?.Get<string?>("selfServiceAppointmentId"); }
            set { BackingStore?.Set("selfServiceAppointmentId", value); }
        }
#nullable restore
#else
        public string SelfServiceAppointmentId
        {
            get { return BackingStore?.Get<string>("selfServiceAppointmentId"); }
            set { BackingStore?.Set("selfServiceAppointmentId", value); }
        }
#endif
        /// <summary>The ID of the bookingService associated with this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId
        {
            get { return BackingStore?.Get<string?>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
#nullable restore
#else
        public string ServiceId
        {
            get { return BackingStore?.Get<string>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
#endif
        /// <summary>The location where the service is delivered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Location? ServiceLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Location?>("serviceLocation"); }
            set { BackingStore?.Set("serviceLocation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Location ServiceLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Location>("serviceLocation"); }
            set { BackingStore?.Set("serviceLocation", value); }
        }
#endif
        /// <summary>The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it&apos;s computed from the service associated with the appointment by the serviceId property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName
        {
            get { return BackingStore?.Get<string?>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#nullable restore
#else
        public string ServiceName
        {
            get { return BackingStore?.Get<string>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#endif
        /// <summary>Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceNotes
        {
            get { return BackingStore?.Get<string?>("serviceNotes"); }
            set { BackingStore?.Set("serviceNotes", value); }
        }
#nullable restore
#else
        public string ServiceNotes
        {
            get { return BackingStore?.Get<string>("serviceNotes"); }
            set { BackingStore?.Set("serviceNotes", value); }
        }
#endif
        /// <summary>If true, indicates SMS notifications will be sent to the customers for the appointment. Default value is false.</summary>
        public bool? SmsNotificationsEnabled
        {
            get { return BackingStore?.Get<bool?>("smsNotificationsEnabled"); }
            set { BackingStore?.Set("smsNotificationsEnabled", value); }
        }
        /// <summary>The ID of each bookingStaffMember who is scheduled in this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StaffMemberIds
        {
            get { return BackingStore?.Get<List<string>?>("staffMemberIds"); }
            set { BackingStore?.Set("staffMemberIds", value); }
        }
#nullable restore
#else
        public List<string> StaffMemberIds
        {
            get { return BackingStore?.Get<List<string>>("staffMemberIds"); }
            set { BackingStore?.Set("staffMemberIds", value); }
        }
#endif
        /// <summary>The startDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BookingAppointment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.BookingAppointment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.BookingAppointment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                { "anonymousJoinWebUrl", n => { AnonymousJoinWebUrl = n.GetStringValue(); } },
                { "appointmentLabel", n => { AppointmentLabel = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customerEmailAddress", n => { CustomerEmailAddress = n.GetStringValue(); } },
                { "customerName", n => { CustomerName = n.GetStringValue(); } },
                { "customerNotes", n => { CustomerNotes = n.GetStringValue(); } },
                { "customerPhone", n => { CustomerPhone = n.GetStringValue(); } },
                { "customerTimeZone", n => { CustomerTimeZone = n.GetStringValue(); } },
                { "customers", n => { Customers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.BookingCustomerInformationBase>(global::Microsoft.Graph.Models.BookingCustomerInformationBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "duration", n => { Duration = n.GetTimeSpanValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "filledAttendeesCount", n => { FilledAttendeesCount = n.GetIntValue(); } },
                { "isCustomerAllowedToManageBooking", n => { IsCustomerAllowedToManageBooking = n.GetBoolValue(); } },
                { "isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                { "joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                { "optOutOfCustomerEmail", n => { OptOutOfCustomerEmail = n.GetBoolValue(); } },
                { "postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                { "preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                { "price", n => { Price = n.GetDoubleValue(); } },
                { "priceType", n => { PriceType = n.GetEnumValue<global::Microsoft.Graph.Models.BookingPriceType>(); } },
                { "reminders", n => { Reminders = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.BookingReminder>(global::Microsoft.Graph.Models.BookingReminder.CreateFromDiscriminatorValue)?.AsList(); } },
                { "selfServiceAppointmentId", n => { SelfServiceAppointmentId = n.GetStringValue(); } },
                { "serviceId", n => { ServiceId = n.GetStringValue(); } },
                { "serviceLocation", n => { ServiceLocation = n.GetObjectValue<global::Microsoft.Graph.Models.Location>(global::Microsoft.Graph.Models.Location.CreateFromDiscriminatorValue); } },
                { "serviceName", n => { ServiceName = n.GetStringValue(); } },
                { "serviceNotes", n => { ServiceNotes = n.GetStringValue(); } },
                { "smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                { "staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "startDateTime", n => { StartDateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("anonymousJoinWebUrl", AnonymousJoinWebUrl);
            writer.WriteStringValue("appointmentLabel", AppointmentLabel);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customerEmailAddress", CustomerEmailAddress);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNotes", CustomerNotes);
            writer.WriteStringValue("customerPhone", CustomerPhone);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.BookingCustomerInformationBase>("customers", Customers);
            writer.WriteStringValue("customerTimeZone", CustomerTimeZone);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteBoolValue("isCustomerAllowedToManageBooking", IsCustomerAllowedToManageBooking);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteBoolValue("optOutOfCustomerEmail", OptOutOfCustomerEmail);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteDoubleValue("price", Price);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BookingPriceType>("priceType", PriceType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.BookingReminder>("reminders", Reminders);
            writer.WriteStringValue("selfServiceAppointmentId", SelfServiceAppointmentId);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Location>("serviceLocation", ServiceLocation);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteStringValue("serviceNotes", ServiceNotes);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("startDateTime", StartDateTime);
        }
    }
}
#pragma warning restore CS0618
