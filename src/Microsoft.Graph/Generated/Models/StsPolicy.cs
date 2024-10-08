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
    public partial class StsPolicy : global::Microsoft.Graph.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appliesTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DirectoryObject>? AppliesTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryObject>?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DirectoryObject> AppliesTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryObject>>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
#endif
        /// <summary>A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Definition
        {
            get { return BackingStore?.Get<List<string>?>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
#nullable restore
#else
        public List<string> Definition
        {
            get { return BackingStore?.Get<List<string>>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
#endif
        /// <summary>If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.</summary>
        public bool? IsOrganizationDefault
        {
            get { return BackingStore?.Get<bool?>("isOrganizationDefault"); }
            set { BackingStore?.Set("isOrganizationDefault", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.StsPolicy"/> and sets the default values.
        /// </summary>
        public StsPolicy() : base()
        {
            OdataType = "#microsoft.graph.stsPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.StsPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.StsPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.activityBasedTimeoutPolicy" => new global::Microsoft.Graph.Models.ActivityBasedTimeoutPolicy(),
                "#microsoft.graph.claimsMappingPolicy" => new global::Microsoft.Graph.Models.ClaimsMappingPolicy(),
                "#microsoft.graph.homeRealmDiscoveryPolicy" => new global::Microsoft.Graph.Models.HomeRealmDiscoveryPolicy(),
                "#microsoft.graph.tokenIssuancePolicy" => new global::Microsoft.Graph.Models.TokenIssuancePolicy(),
                "#microsoft.graph.tokenLifetimePolicy" => new global::Microsoft.Graph.Models.TokenLifetimePolicy(),
                _ => new global::Microsoft.Graph.Models.StsPolicy(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appliesTo", n => { AppliesTo = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "definition", n => { Definition = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isOrganizationDefault", n => { IsOrganizationDefault = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteCollectionOfPrimitiveValues<string>("definition", Definition);
            writer.WriteBoolValue("isOrganizationDefault", IsOrganizationDefault);
        }
    }
}
#pragma warning restore CS0618
