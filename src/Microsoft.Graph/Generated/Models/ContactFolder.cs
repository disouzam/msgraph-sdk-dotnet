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
    public partial class ContactFolder : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of child folders in the folder. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ContactFolder>? ChildFolders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ContactFolder>?>("childFolders"); }
            set { BackingStore?.Set("childFolders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ContactFolder> ChildFolders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ContactFolder>>("childFolders"); }
            set { BackingStore?.Set("childFolders", value); }
        }
#endif
        /// <summary>The contacts in the folder. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Contact>? Contacts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Contact>?>("contacts"); }
            set { BackingStore?.Set("contacts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Contact> Contacts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Contact>>("contacts"); }
            set { BackingStore?.Set("contacts", value); }
        }
#endif
        /// <summary>The folder&apos;s display name.</summary>
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
        /// <summary>The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The ID of the folder&apos;s parent folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId
        {
            get { return BackingStore?.Get<string?>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#nullable restore
#else
        public string ParentFolderId
        {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ContactFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ContactFolder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ContactFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childFolders", n => { ChildFolders = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ContactFolder>(global::Microsoft.Graph.Models.ContactFolder.CreateFromDiscriminatorValue)?.AsList(); } },
                { "contacts", n => { Contacts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Contact>(global::Microsoft.Graph.Models.Contact.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>(global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>(global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ContactFolder>("childFolders", ChildFolders);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Contact>("contacts", Contacts);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
#pragma warning restore CS0618
