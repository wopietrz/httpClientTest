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
    /// PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice :  IEquatable<PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice" /> class.
        /// </summary>
        /// <param name="Code">Reason the recurring payment transaction was declined. For some processors, this field is used only for Mastercard. For other processors, this field is used for Visa and Mastercard. And for other processors, this field is not implemented.  Possible values:   - &#x60;00&#x60;: Response not provided.  - &#x60;01&#x60;: New account information is available. Obtain the new information.  - &#x60;02&#x60;: Try again later.  - &#x60;03&#x60;: Do not try again. Obtain another type of payment from the customer.  - &#x60;04&#x60;: Problem with a token or a partial shipment indicator.  - &#x60;21&#x60;: Recurring payment cancellation service.  - &#x60;99&#x60;: An unknown value was returned from the processor.  For processor-specific information, see the &#x60;auth_merchant_advice_code&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="CodeRaw">Raw merchant advice code sent directly from the processor. This field is used only for Mastercard.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file1: - Record: CP01 TCR7 - Position: 96-99 - Field: Response Data-Merchant Advice Code   For processor-specific information, see the &#x60;auth_merchant_advice_code_raw&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="NameMatch">#### Visa Platform Connect The field contains will contain the Account Name Request Result for zero amount Authorization request. Valid values are:  00 &#x3D; Name Match Performed 01 &#x3D; Name Match not Performed 02 &#x3D; Name Match not supported .</param>
        public PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice(string Code = default(string), string CodeRaw = default(string), string NameMatch = default(string))
        {
            this.Code = Code;
            this.CodeRaw = CodeRaw;
            this.NameMatch = NameMatch;
        }
        
        /// <summary>
        /// Reason the recurring payment transaction was declined. For some processors, this field is used only for Mastercard. For other processors, this field is used for Visa and Mastercard. And for other processors, this field is not implemented.  Possible values:   - &#x60;00&#x60;: Response not provided.  - &#x60;01&#x60;: New account information is available. Obtain the new information.  - &#x60;02&#x60;: Try again later.  - &#x60;03&#x60;: Do not try again. Obtain another type of payment from the customer.  - &#x60;04&#x60;: Problem with a token or a partial shipment indicator.  - &#x60;21&#x60;: Recurring payment cancellation service.  - &#x60;99&#x60;: An unknown value was returned from the processor.  For processor-specific information, see the &#x60;auth_merchant_advice_code&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Reason the recurring payment transaction was declined. For some processors, this field is used only for Mastercard. For other processors, this field is used for Visa and Mastercard. And for other processors, this field is not implemented.  Possible values:   - &#x60;00&#x60;: Response not provided.  - &#x60;01&#x60;: New account information is available. Obtain the new information.  - &#x60;02&#x60;: Try again later.  - &#x60;03&#x60;: Do not try again. Obtain another type of payment from the customer.  - &#x60;04&#x60;: Problem with a token or a partial shipment indicator.  - &#x60;21&#x60;: Recurring payment cancellation service.  - &#x60;99&#x60;: An unknown value was returned from the processor.  For processor-specific information, see the &#x60;auth_merchant_advice_code&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Raw merchant advice code sent directly from the processor. This field is used only for Mastercard.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file1: - Record: CP01 TCR7 - Position: 96-99 - Field: Response Data-Merchant Advice Code   For processor-specific information, see the &#x60;auth_merchant_advice_code_raw&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Raw merchant advice code sent directly from the processor. This field is used only for Mastercard.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file1: - Record: CP01 TCR7 - Position: 96-99 - Field: Response Data-Merchant Advice Code   For processor-specific information, see the &#x60;auth_merchant_advice_code_raw&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="codeRaw", EmitDefaultValue=false)]
        public string CodeRaw { get; set; }

        /// <summary>
        /// #### Visa Platform Connect The field contains will contain the Account Name Request Result for zero amount Authorization request. Valid values are:  00 &#x3D; Name Match Performed 01 &#x3D; Name Match not Performed 02 &#x3D; Name Match not supported 
        /// </summary>
        /// <value>#### Visa Platform Connect The field contains will contain the Account Name Request Result for zero amount Authorization request. Valid values are:  00 &#x3D; Name Match Performed 01 &#x3D; Name Match not Performed 02 &#x3D; Name Match not supported </value>
        [DataMember(Name="nameMatch", EmitDefaultValue=false)]
        public string NameMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CodeRaw: ").Append(CodeRaw).Append("\n");
            sb.Append("  NameMatch: ").Append(NameMatch).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseProcessorInformationMerchantAdvice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CodeRaw == other.CodeRaw ||
                    this.CodeRaw != null &&
                    this.CodeRaw.Equals(other.CodeRaw)
                ) && 
                (
                    this.NameMatch == other.NameMatch ||
                    this.NameMatch != null &&
                    this.NameMatch.Equals(other.NameMatch)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CodeRaw != null)
                    hash = hash * 59 + this.CodeRaw.GetHashCode();
                if (this.NameMatch != null)
                    hash = hash * 59 + this.NameMatch.GetHashCode();
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