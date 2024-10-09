// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class MembershipOutlierInsight : global::Microsoft.Graph.Models.GovernanceInsight, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Navigation link to the container directory object. For example, to a group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DirectoryObject? Container
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject?>("container"); }
            set { BackingStore?.Set("container", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DirectoryObject Container
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject>("container"); }
            set { BackingStore?.Set("container", value); }
        }
#endif
        /// <summary>Indicates the identifier of the container, for example, a group ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerId
        {
            get { return BackingStore?.Get<string?>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
#nullable restore
#else
        public string ContainerId
        {
            get { return BackingStore?.Get<string>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
#endif
        /// <summary>Navigation link to a member object who modified the record. For example, to a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.User? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.User LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Navigation link to a member object. For example, to a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DirectoryObject? Member
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject?>("member"); }
            set { BackingStore?.Set("member", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DirectoryObject Member
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject>("member"); }
            set { BackingStore?.Set("member", value); }
        }
#endif
        /// <summary>Indicates the identifier of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberId
        {
            get { return BackingStore?.Get<string?>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
#nullable restore
#else
        public string MemberId
        {
            get { return BackingStore?.Get<string>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
#endif
        /// <summary>The outlierContainerType property</summary>
        public global::Microsoft.Graph.Models.OutlierContainerType? OutlierContainerType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OutlierContainerType?>("outlierContainerType"); }
            set { BackingStore?.Set("outlierContainerType", value); }
        }
        /// <summary>The outlierMemberType property</summary>
        public global::Microsoft.Graph.Models.OutlierMemberType? OutlierMemberType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OutlierMemberType?>("outlierMemberType"); }
            set { BackingStore?.Set("outlierMemberType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.MembershipOutlierInsight"/> and sets the default values.
        /// </summary>
        public MembershipOutlierInsight() : base()
        {
            OdataType = "#microsoft.graph.membershipOutlierInsight";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.MembershipOutlierInsight"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.MembershipOutlierInsight CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.MembershipOutlierInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "container", n => { Container = n.GetObjectValue<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "containerId", n => { ContainerId = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.User>(global::Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "member", n => { Member = n.GetObjectValue<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "memberId", n => { MemberId = n.GetStringValue(); } },
                { "outlierContainerType", n => { OutlierContainerType = n.GetEnumValue<global::Microsoft.Graph.Models.OutlierContainerType>(); } },
                { "outlierMemberType", n => { OutlierMemberType = n.GetEnumValue<global::Microsoft.Graph.Models.OutlierMemberType>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DirectoryObject>("container", Container);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.User>("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DirectoryObject>("member", Member);
            writer.WriteStringValue("memberId", MemberId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.OutlierContainerType>("outlierContainerType", OutlierContainerType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.OutlierMemberType>("outlierMemberType", OutlierMemberType);
        }
    }
}
#pragma warning restore CS0618
