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
    public partial class AuthenticationStrengthPolicy : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of authentication method modes that are required be used to satify this authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AuthenticationMethodModes?>? AllowedCombinations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationMethodModes?>?>("allowedCombinations"); }
            set { BackingStore?.Set("allowedCombinations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AuthenticationMethodModes?> AllowedCombinations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationMethodModes?>>("allowedCombinations"); }
            set { BackingStore?.Set("allowedCombinations", value); }
        }
#endif
        /// <summary>Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration>? CombinationConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration>?>("combinationConfigurations"); }
            set { BackingStore?.Set("combinationConfigurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration> CombinationConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration>>("combinationConfigurations"); }
            set { BackingStore?.Set("combinationConfigurations", value); }
        }
#endif
        /// <summary>The datetime when this policy was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The human-readable description of this policy.</summary>
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
        /// <summary>The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).</summary>
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
        /// <summary>The datetime when this policy was last modified.</summary>
        public DateTimeOffset? ModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The policyType property</summary>
        public global::Microsoft.Graph.Models.AuthenticationStrengthPolicyType? PolicyType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationStrengthPolicyType?>("policyType"); }
            set { BackingStore?.Set("policyType", value); }
        }
        /// <summary>The requirementsSatisfied property</summary>
        public global::Microsoft.Graph.Models.AuthenticationStrengthRequirements? RequirementsSatisfied
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationStrengthRequirements?>("requirementsSatisfied"); }
            set { BackingStore?.Set("requirementsSatisfied", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuthenticationStrengthPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuthenticationStrengthPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AuthenticationStrengthPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedCombinations", n => { AllowedCombinations = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.AuthenticationMethodModes>()?.AsList(); } },
                { "combinationConfigurations", n => { CombinationConfigurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration>(global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "policyType", n => { PolicyType = n.GetEnumValue<global::Microsoft.Graph.Models.AuthenticationStrengthPolicyType>(); } },
                { "requirementsSatisfied", n => { RequirementsSatisfied = n.GetEnumValue<global::Microsoft.Graph.Models.AuthenticationStrengthRequirements>(); } },
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
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.AuthenticationMethodModes>("allowedCombinations", AllowedCombinations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration>("combinationConfigurations", CombinationConfigurations);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AuthenticationStrengthPolicyType>("policyType", PolicyType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AuthenticationStrengthRequirements>("requirementsSatisfied", RequirementsSatisfied);
        }
    }
}
#pragma warning restore CS0618
