/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Name of the 3rd party provider, for example, Emailage.  For all possible values, see the &#x60;decision_provider_#_name&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName :  IEquatable<PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName" /> class.
        /// </summary>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="FieldValue">FieldValue.</param>
        public PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName(List<string> FieldName = default(List<string>), List<string> FieldValue = default(List<string>))
        {
            this.FieldName = FieldName;
            this.FieldValue = FieldValue;
        }
        
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public List<string> FieldName { get; set; }

        /// <summary>
        /// Gets or Sets FieldValue
        /// </summary>
        [DataMember(Name="fieldValue", EmitDefaultValue=false)]
        public List<string> FieldValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseRiskInformationProvidersProviderName other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.SequenceEqual(other.FieldName)
                ) && 
                (
                    this.FieldValue == other.FieldValue ||
                    this.FieldValue != null &&
                    this.FieldValue.SequenceEqual(other.FieldValue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.FieldValue != null)
                    hash = hash * 59 + this.FieldValue.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
