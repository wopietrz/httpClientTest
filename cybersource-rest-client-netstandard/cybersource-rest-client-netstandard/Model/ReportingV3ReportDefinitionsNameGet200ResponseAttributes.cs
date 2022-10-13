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
    /// ReportingV3ReportDefinitionsNameGet200ResponseAttributes
    /// </summary>
    [DataContract]
    public partial class ReportingV3ReportDefinitionsNameGet200ResponseAttributes :  IEquatable<ReportingV3ReportDefinitionsNameGet200ResponseAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ReportDefinitionsNameGet200ResponseAttributes" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="FilterType">Attribute Filter Type..</param>
        /// <param name="_Default">_Default.</param>
        /// <param name="Required">Required.</param>
        /// <param name="SupportedType">Valid values for the filter..</param>
        public ReportingV3ReportDefinitionsNameGet200ResponseAttributes(string Id = default(string), string Name = default(string), string Description = default(string), string FilterType = default(string), bool? _Default = default(bool?), bool? Required = default(bool?), string SupportedType = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.FilterType = FilterType;
            this._Default = _Default;
            this.Required = Required;
            this.SupportedType = SupportedType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Attribute Filter Type.
        /// </summary>
        /// <value>Attribute Filter Type.</value>
        [DataMember(Name="filterType", EmitDefaultValue=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Valid values for the filter.
        /// </summary>
        /// <value>Valid values for the filter.</value>
        [DataMember(Name="supportedType", EmitDefaultValue=false)]
        public string SupportedType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ReportDefinitionsNameGet200ResponseAttributes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  SupportedType: ").Append(SupportedType).Append("\n");
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
            return this.Equals(obj as ReportingV3ReportDefinitionsNameGet200ResponseAttributes);
        }

        /// <summary>
        /// Returns true if ReportingV3ReportDefinitionsNameGet200ResponseAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ReportDefinitionsNameGet200ResponseAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ReportDefinitionsNameGet200ResponseAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.FilterType == other.FilterType ||
                    this.FilterType != null &&
                    this.FilterType.Equals(other.FilterType)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.SupportedType == other.SupportedType ||
                    this.SupportedType != null &&
                    this.SupportedType.Equals(other.SupportedType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.FilterType != null)
                    hash = hash * 59 + this.FilterType.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.SupportedType != null)
                    hash = hash * 59 + this.SupportedType.GetHashCode();
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
