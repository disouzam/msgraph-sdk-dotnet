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
    public partial class AccessReviewScheduleDefinition : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines the list of additional users or group members to be notified of the access review progress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem>? AdditionalNotificationRecipients
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem>?>("additionalNotificationRecipients"); }
            set { BackingStore?.Set("additionalNotificationRecipients", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem> AdditionalNotificationRecipients
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem>>("additionalNotificationRecipients"); }
            set { BackingStore?.Set("additionalNotificationRecipients", value); }
        }
#endif
        /// <summary>User who created this review. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UserIdentity? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UserIdentity CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Timestamp when the access review series was created. Supports $select. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description provided by review creators to provide more context of the review to admins. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DescriptionForAdmins
        {
            get { return BackingStore?.Get<string?>("descriptionForAdmins"); }
            set { BackingStore?.Set("descriptionForAdmins", value); }
        }
#nullable restore
#else
        public string DescriptionForAdmins
        {
            get { return BackingStore?.Get<string>("descriptionForAdmins"); }
            set { BackingStore?.Set("descriptionForAdmins", value); }
        }
#endif
        /// <summary>Description provided  by review creators to provide more context of the review to reviewers. Reviewers see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DescriptionForReviewers
        {
            get { return BackingStore?.Get<string?>("descriptionForReviewers"); }
            set { BackingStore?.Set("descriptionForReviewers", value); }
        }
#nullable restore
#else
        public string DescriptionForReviewers
        {
            get { return BackingStore?.Get<string>("descriptionForReviewers"); }
            set { BackingStore?.Set("descriptionForReviewers", value); }
        }
#endif
        /// <summary>Name of the access review series. Supports $select and $orderby. Required on create.</summary>
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
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers are notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner doesn&apos;t exist, or manager is specified as reviewer but a user&apos;s manager doesn&apos;t exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select. NOTE: The value of this property will be ignored if fallback reviewers are assigned through the stageSettings property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>? FallbackReviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>?>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope> FallbackReviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#endif
        /// <summary>This property is required when scoping a review to guest users&apos; access across all Microsoft 365 groups and determines which Microsoft 365 groups are reviewed. Each group becomes a unique accessReviewInstance of the access review series.  For supported scopes, see accessReviewScope. Supports $select. For examples of options for configuring instanceEnumerationScope, see Configure the scope of your access review definition using the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessReviewScope? InstanceEnumerationScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScope?>("instanceEnumerationScope"); }
            set { BackingStore?.Set("instanceEnumerationScope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessReviewScope InstanceEnumerationScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScope>("instanceEnumerationScope"); }
            set { BackingStore?.Set("instanceEnumerationScope", value); }
        }
#endif
        /// <summary>If the accessReviewScheduleDefinition is a recurring access review, instances represent each recurrence. A review that doesn&apos;t recur will have exactly one instance. Instances also represent each unique resource under review in the accessReviewScheduleDefinition. If a review has multiple resources and multiple instances, each resource has a unique instance for each recurrence.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewInstance>? Instances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewInstance>?>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewInstance> Instances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewInstance>>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#endif
        /// <summary>Timestamp when the access review series was last modified. Supports $select. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will be ignored if reviewers are assigned through the stageSettings property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>? Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>?>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope> Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#endif
        /// <summary>Defines the entities whose access is reviewed. For supported scopes, see accessReviewScope. Required on create. Supports $select and $filter (contains only). For examples of options for configuring scope, see Configure the scope of your access review definition using the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessReviewScope? Scope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessReviewScope Scope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScope>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The settings for an access review series, see type definition below. Supports $select. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessReviewScheduleSettings? Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScheduleSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessReviewScheduleSettings Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScheduleSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Required only for a multi-stage access review to define the stages and their settings. You can break down each review instance into up to three sequential stages, where each stage can have a different set of reviewers, fallback reviewers, and settings. Stages are created sequentially based on the dependsOn property. Optional.  When this property is defined, its settings are used instead of the corresponding settings in the accessReviewScheduleDefinition object and its settings, reviewers, and fallbackReviewers properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewStageSettings>? StageSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewStageSettings>?>("stageSettings"); }
            set { BackingStore?.Set("stageSettings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewStageSettings> StageSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewStageSettings>>("stageSettings"); }
            set { BackingStore?.Set("stageSettings", value); }
        }
#endif
        /// <summary>This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessReviewScheduleDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AccessReviewScheduleDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessReviewScheduleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalNotificationRecipients", n => { AdditionalNotificationRecipients = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem>(global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Models.UserIdentity>(global::Microsoft.Graph.Models.UserIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "descriptionForAdmins", n => { DescriptionForAdmins = n.GetStringValue(); } },
                { "descriptionForReviewers", n => { DescriptionForReviewers = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fallbackReviewers", n => { FallbackReviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>(global::Microsoft.Graph.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "instanceEnumerationScope", n => { InstanceEnumerationScope = n.GetObjectValue<global::Microsoft.Graph.Models.AccessReviewScope>(global::Microsoft.Graph.Models.AccessReviewScope.CreateFromDiscriminatorValue); } },
                { "instances", n => { Instances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewInstance>(global::Microsoft.Graph.Models.AccessReviewInstance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>(global::Microsoft.Graph.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "scope", n => { Scope = n.GetObjectValue<global::Microsoft.Graph.Models.AccessReviewScope>(global::Microsoft.Graph.Models.AccessReviewScope.CreateFromDiscriminatorValue); } },
                { "settings", n => { Settings = n.GetObjectValue<global::Microsoft.Graph.Models.AccessReviewScheduleSettings>(global::Microsoft.Graph.Models.AccessReviewScheduleSettings.CreateFromDiscriminatorValue); } },
                { "stageSettings", n => { StageSettings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewStageSettings>(global::Microsoft.Graph.Models.AccessReviewStageSettings.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewNotificationRecipientItem>("additionalNotificationRecipients", AdditionalNotificationRecipients);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("descriptionForAdmins", DescriptionForAdmins);
            writer.WriteStringValue("descriptionForReviewers", DescriptionForReviewers);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessReviewScope>("instanceEnumerationScope", InstanceEnumerationScope);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewInstance>("instances", Instances);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessReviewScope>("scope", Scope);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessReviewScheduleSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewStageSettings>("stageSettings", StageSettings);
            writer.WriteStringValue("status", Status);
        }
    }
}
#pragma warning restore CS0618
