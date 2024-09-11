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
    public partial class BrowserSharedCookie : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The comment for the shared cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment
        {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment
        {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The date and time when the shared cookie was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time when the shared cookie was deleted.</summary>
        public DateTimeOffset? DeletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The name of the cookie.</summary>
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
        /// <summary>The history of modifications applied to the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.BrowserSharedCookieHistory>? History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BrowserSharedCookieHistory>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.BrowserSharedCookieHistory> History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BrowserSharedCookieHistory>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>Controls whether a cookie is a host-only or domain cookie.</summary>
        public bool? HostOnly
        {
            get { return BackingStore?.Get<bool?>("hostOnly"); }
            set { BackingStore?.Set("hostOnly", value); }
        }
        /// <summary>The URL of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostOrDomain
        {
            get { return BackingStore?.Get<string?>("hostOrDomain"); }
            set { BackingStore?.Set("hostOrDomain", value); }
        }
#nullable restore
#else
        public string HostOrDomain
        {
            get { return BackingStore?.Get<string>("hostOrDomain"); }
            set { BackingStore?.Set("hostOrDomain", value); }
        }
#endif
        /// <summary>The user who last modified the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The date and time when the cookie was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The path of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path
        {
            get { return BackingStore?.Get<string?>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#nullable restore
#else
        public string Path
        {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#endif
        /// <summary>The sourceEnvironment property</summary>
        public global::Microsoft.Graph.Models.BrowserSharedCookieSourceEnvironment? SourceEnvironment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BrowserSharedCookieSourceEnvironment?>("sourceEnvironment"); }
            set { BackingStore?.Set("sourceEnvironment", value); }
        }
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Models.BrowserSharedCookieStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BrowserSharedCookieStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BrowserSharedCookie"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.BrowserSharedCookie CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.BrowserSharedCookie();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "comment", n => { Comment = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "history", n => { History = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.BrowserSharedCookieHistory>(global::Microsoft.Graph.Models.BrowserSharedCookieHistory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostOnly", n => { HostOnly = n.GetBoolValue(); } },
                { "hostOrDomain", n => { HostOrDomain = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "path", n => { Path = n.GetStringValue(); } },
                { "sourceEnvironment", n => { SourceEnvironment = n.GetEnumValue<global::Microsoft.Graph.Models.BrowserSharedCookieSourceEnvironment>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.BrowserSharedCookieStatus>(); } },
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
            writer.WriteStringValue("comment", Comment);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.BrowserSharedCookieHistory>("history", History);
            writer.WriteBoolValue("hostOnly", HostOnly);
            writer.WriteStringValue("hostOrDomain", HostOrDomain);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("path", Path);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BrowserSharedCookieSourceEnvironment>("sourceEnvironment", SourceEnvironment);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BrowserSharedCookieStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
