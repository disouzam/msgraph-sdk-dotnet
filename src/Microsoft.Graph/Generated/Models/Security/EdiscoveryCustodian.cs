// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EdiscoveryCustodian : global::Microsoft.Graph.Models.Security.DataSourceContainer, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time the custodian acknowledged a hold notification.</summary>
        public DateTimeOffset? AcknowledgedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("acknowledgedDateTime"); }
            set { BackingStore?.Set("acknowledgedDateTime", value); }
        }
        /// <summary>Email address of the custodian.</summary>
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
        /// <summary>Operation entity that represents the latest indexing for the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation? LastIndexOperation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation?>("lastIndexOperation"); }
            set { BackingStore?.Set("lastIndexOperation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation LastIndexOperation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation>("lastIndexOperation"); }
            set { BackingStore?.Set("lastIndexOperation", value); }
        }
#endif
        /// <summary>Data source entity for SharePoint sites associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.SiteSource>? SiteSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.SiteSource>?>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.SiteSource> SiteSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.SiteSource>>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#endif
        /// <summary>Data source entity for groups associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.UnifiedGroupSource>? UnifiedGroupSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.UnifiedGroupSource>?>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.UnifiedGroupSource> UnifiedGroupSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.UnifiedGroupSource>>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#endif
        /// <summary>Data source entity for a the custodian. This is the container for a custodian&apos;s mailbox and OneDrive for Business site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.UserSource>? UserSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.UserSource>?>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.UserSource> UserSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.UserSource>>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryCustodian"/> and sets the default values.
        /// </summary>
        public EdiscoveryCustodian() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoveryCustodian";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryCustodian"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.EdiscoveryCustodian CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.EdiscoveryCustodian();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acknowledgedDateTime", n => { AcknowledgedDateTime = n.GetDateTimeOffsetValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "lastIndexOperation", n => { LastIndexOperation = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation>(global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation.CreateFromDiscriminatorValue); } },
                { "siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.SiteSource>(global::Microsoft.Graph.Models.Security.SiteSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.UnifiedGroupSource>(global::Microsoft.Graph.Models.Security.UnifiedGroupSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userSources", n => { UserSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.UserSource>(global::Microsoft.Graph.Models.Security.UserSource.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteDateTimeOffsetValue("acknowledgedDateTime", AcknowledgedDateTime);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryIndexOperation>("lastIndexOperation", LastIndexOperation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.UserSource>("userSources", UserSources);
        }
    }
}
#pragma warning restore CS0618
