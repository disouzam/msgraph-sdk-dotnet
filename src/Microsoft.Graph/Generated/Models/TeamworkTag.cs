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
    public partial class TeamworkTag : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The description of the tag as it appears to the user in Microsoft Teams. A teamworkTag can&apos;t have more than 200 teamworkTagMembers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The name of the tag as it appears to the user in Microsoft Teams.</summary>
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
        /// <summary>The number of users assigned to the tag.</summary>
        public int? MemberCount
        {
            get { return BackingStore?.Get<int?>("memberCount"); }
            set { BackingStore?.Set("memberCount", value); }
        }
        /// <summary>Users assigned to the tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamworkTagMember>? Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamworkTagMember>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamworkTagMember> Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamworkTagMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The type of the tag. Default is standard.</summary>
        public global::Microsoft.Graph.Models.TeamworkTagType? TagType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkTagType?>("tagType"); }
            set { BackingStore?.Set("tagType", value); }
        }
        /// <summary>ID of the team in which the tag is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamId
        {
            get { return BackingStore?.Get<string?>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#nullable restore
#else
        public string TeamId
        {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamworkTag"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TeamworkTag CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TeamworkTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "memberCount", n => { MemberCount = n.GetIntValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamworkTagMember>(global::Microsoft.Graph.Models.TeamworkTagMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tagType", n => { TagType = n.GetEnumValue<global::Microsoft.Graph.Models.TeamworkTagType>(); } },
                { "teamId", n => { TeamId = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("memberCount", MemberCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamworkTagMember>("members", Members);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TeamworkTagType>("tagType", TagType);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
#pragma warning restore CS0618
