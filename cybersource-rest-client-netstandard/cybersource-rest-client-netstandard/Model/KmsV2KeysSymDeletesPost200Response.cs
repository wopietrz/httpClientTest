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
    /// KmsV2KeysSymDeletesPost200Response
    /// </summary>
    [DataContract]
    public partial class KmsV2KeysSymDeletesPost200Response :  IEquatable<KmsV2KeysSymDeletesPost200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmsV2KeysSymDeletesPost200Response" /> class.
        /// </summary>
        /// <param name="SubmitTimeUtc">Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. .</param>
        /// <param name="Status">The status of the submitted transaction.  Possible values:  - ACCEPTED .</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="KeyInformation">KeyInformation.</param>
        public KmsV2KeysSymDeletesPost200Response(string SubmitTimeUtc = default(string), string Status = default(string), Kmsv2keyssymClientReferenceInformation ClientReferenceInformation = default(Kmsv2keyssymClientReferenceInformation), List<KmsV2KeysSymDeletesPost200ResponseKeyInformation> KeyInformation = default(List<KmsV2KeysSymDeletesPost200ResponseKeyInformation>))
        {
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.KeyInformation = KeyInformation;
        }
        
        /// <summary>
        /// Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. 
        /// </summary>
        /// <value>Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// The status of the submitted transaction.  Possible values:  - ACCEPTED 
        /// </summary>
        /// <value>The status of the submitted transaction.  Possible values:  - ACCEPTED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Kmsv2keyssymClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets KeyInformation
        /// </summary>
        [DataMember(Name="keyInformation", EmitDefaultValue=false)]
        public List<KmsV2KeysSymDeletesPost200ResponseKeyInformation> KeyInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsV2KeysSymDeletesPost200Response {\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  KeyInformation: ").Append(KeyInformation).Append("\n");
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
            return this.Equals(obj as KmsV2KeysSymDeletesPost200Response);
        }

        /// <summary>
        /// Returns true if KmsV2KeysSymDeletesPost200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of KmsV2KeysSymDeletesPost200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmsV2KeysSymDeletesPost200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.KeyInformation == other.KeyInformation ||
                    this.KeyInformation != null &&
                    this.KeyInformation.SequenceEqual(other.KeyInformation)
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
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.KeyInformation != null)
                    hash = hash * 59 + this.KeyInformation.GetHashCode();
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
