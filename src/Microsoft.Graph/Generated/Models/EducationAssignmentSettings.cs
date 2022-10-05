using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EducationAssignmentSettings : Entity, IParsable {
        /// <summary>Indicates whether turn-in celebration animation will be shown. A value of true indicates that the animation will not be shown. Default value is false.</summary>
        public bool? SubmissionAnimationDisabled {
            get { return BackingStore?.Get<bool?>("submissionAnimationDisabled"); }
            set { BackingStore?.Set("submissionAnimationDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new educationAssignmentSettings and sets the default values.
        /// </summary>
        public EducationAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.educationAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"submissionAnimationDisabled", n => { SubmissionAnimationDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("submissionAnimationDisabled", SubmissionAnimationDisabled);
        }
    }
}
