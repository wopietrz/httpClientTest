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
    /// TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions :  IEquatable<TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions" /> class.
        /// </summary>
        /// <param name="PaymentMethod">This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment) .</param>
        /// <param name="TerminalId">Unique Japan Credit Card Association (JCCA) terminal identifier.  The difference between this field and the &#x60;pointOfSaleInformation.terminalID&#x60; field is that you can define &#x60;pointOfSaleInformation.terminalID&#x60;, but &#x60;processingInformation.japanPaymentOptions.terminalId&#x60; is defined by the JCCA and is used only in Japan.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. .</param>
        /// <param name="BusinessName">Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. .</param>
        /// <param name="BusinessNameKatakana">Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. .</param>
        public TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions(string PaymentMethod = default(string), string TerminalId = default(string), string BusinessName = default(string), string BusinessNameKatakana = default(string))
        {
            this.PaymentMethod = PaymentMethod;
            this.TerminalId = TerminalId;
            this.BusinessName = BusinessName;
            this.BusinessNameKatakana = BusinessNameKatakana;
        }
        
        /// <summary>
        /// This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment) 
        /// </summary>
        /// <value>This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment) </value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Unique Japan Credit Card Association (JCCA) terminal identifier.  The difference between this field and the &#x60;pointOfSaleInformation.terminalID&#x60; field is that you can define &#x60;pointOfSaleInformation.terminalID&#x60;, but &#x60;processingInformation.japanPaymentOptions.terminalId&#x60; is defined by the JCCA and is used only in Japan.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. 
        /// </summary>
        /// <value>Unique Japan Credit Card Association (JCCA) terminal identifier.  The difference between this field and the &#x60;pointOfSaleInformation.terminalID&#x60; field is that you can define &#x60;pointOfSaleInformation.terminalID&#x60;, but &#x60;processingInformation.japanPaymentOptions.terminalId&#x60; is defined by the JCCA and is used only in Japan.  This field is supported only on CyberSource through VisaNet and JCN Gateway.  Optional field. </value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. </value>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet. </value>
        [DataMember(Name="businessNameKatakana", EmitDefaultValue=false)]
        public string BusinessNameKatakana { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessNameKatakana: ").Append(BusinessNameKatakana).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseProcessingInformationJapanPaymentOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.TerminalId == other.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(other.TerminalId)
                ) && 
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) && 
                (
                    this.BusinessNameKatakana == other.BusinessNameKatakana ||
                    this.BusinessNameKatakana != null &&
                    this.BusinessNameKatakana.Equals(other.BusinessNameKatakana)
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
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.TerminalId != null)
                    hash = hash * 59 + this.TerminalId.GetHashCode();
                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();
                if (this.BusinessNameKatakana != null)
                    hash = hash * 59 + this.BusinessNameKatakana.GetHashCode();
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
