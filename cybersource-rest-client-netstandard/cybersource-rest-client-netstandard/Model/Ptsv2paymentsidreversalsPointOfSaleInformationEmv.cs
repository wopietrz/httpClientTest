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
    /// Ptsv2paymentsidreversalsPointOfSaleInformationEmv
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidreversalsPointOfSaleInformationEmv :  IEquatable<Ptsv2paymentsidreversalsPointOfSaleInformationEmv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidreversalsPointOfSaleInformationEmv" /> class.
        /// </summary>
        /// <param name="Tags">EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com  **Note** Card present information about EMV applies only to credit card processing and PIN debit processing. All other card present information applies only to credit card processing. PIN debit processing is available only on FDC Nashville Global.  **Important** The following tags contain sensitive information and **must not** be included in this field:   - &#x60;56&#x60;: Track 1 equivalent data  - &#x60;57&#x60;: Track 2 equivalent data  - &#x60;5A&#x60;: Application PAN  - &#x60;5F20&#x60;: Cardholder name  - &#x60;5F24&#x60;: Application expiration date (This sensitivity has been relaxed for Credit Mutuel-CIC, American Express Direct, FDC Nashville Global, First Data Merchant Solutions, and SIX)  - &#x60;99&#x60;: Transaction PIN  - &#x60;9F0B&#x60;: Cardholder name (extended)  - &#x60;9F1F&#x60;: Track 1 discretionary data  - &#x60;9F20&#x60;: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  **Important** For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - &#x60;95&#x60;: Terminal verification results  - &#x60;9F10&#x60;: Issuer application data  - &#x60;9F26&#x60;: Application cryptogram   #### CyberSource through VisaNet - In Japan: 199 bytes - In other countries: String (252)  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International  #### JCN Gateway The following tags must be included: - &#x60;4F&#x60;: Application identifier - &#x60;84&#x60;: Dedicated file name  Data length: 199 bytes  #### All other processors: String (999)  #### Used by Authorization: Optional Authorization Reversal: Optional Credit: Optional PIN Debit processing (purchase, credit and reversal): Optional .</param>
        public Ptsv2paymentsidreversalsPointOfSaleInformationEmv(string Tags = default(string))
        {
            this.Tags = Tags;
        }
        
        /// <summary>
        /// EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com  **Note** Card present information about EMV applies only to credit card processing and PIN debit processing. All other card present information applies only to credit card processing. PIN debit processing is available only on FDC Nashville Global.  **Important** The following tags contain sensitive information and **must not** be included in this field:   - &#x60;56&#x60;: Track 1 equivalent data  - &#x60;57&#x60;: Track 2 equivalent data  - &#x60;5A&#x60;: Application PAN  - &#x60;5F20&#x60;: Cardholder name  - &#x60;5F24&#x60;: Application expiration date (This sensitivity has been relaxed for Credit Mutuel-CIC, American Express Direct, FDC Nashville Global, First Data Merchant Solutions, and SIX)  - &#x60;99&#x60;: Transaction PIN  - &#x60;9F0B&#x60;: Cardholder name (extended)  - &#x60;9F1F&#x60;: Track 1 discretionary data  - &#x60;9F20&#x60;: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  **Important** For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - &#x60;95&#x60;: Terminal verification results  - &#x60;9F10&#x60;: Issuer application data  - &#x60;9F26&#x60;: Application cryptogram   #### CyberSource through VisaNet - In Japan: 199 bytes - In other countries: String (252)  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International  #### JCN Gateway The following tags must be included: - &#x60;4F&#x60;: Application identifier - &#x60;84&#x60;: Dedicated file name  Data length: 199 bytes  #### All other processors: String (999)  #### Used by Authorization: Optional Authorization Reversal: Optional Credit: Optional PIN Debit processing (purchase, credit and reversal): Optional 
        /// </summary>
        /// <value>EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com  **Note** Card present information about EMV applies only to credit card processing and PIN debit processing. All other card present information applies only to credit card processing. PIN debit processing is available only on FDC Nashville Global.  **Important** The following tags contain sensitive information and **must not** be included in this field:   - &#x60;56&#x60;: Track 1 equivalent data  - &#x60;57&#x60;: Track 2 equivalent data  - &#x60;5A&#x60;: Application PAN  - &#x60;5F20&#x60;: Cardholder name  - &#x60;5F24&#x60;: Application expiration date (This sensitivity has been relaxed for Credit Mutuel-CIC, American Express Direct, FDC Nashville Global, First Data Merchant Solutions, and SIX)  - &#x60;99&#x60;: Transaction PIN  - &#x60;9F0B&#x60;: Cardholder name (extended)  - &#x60;9F1F&#x60;: Track 1 discretionary data  - &#x60;9F20&#x60;: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  **Important** For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - &#x60;95&#x60;: Terminal verification results  - &#x60;9F10&#x60;: Issuer application data  - &#x60;9F26&#x60;: Application cryptogram   #### CyberSource through VisaNet - In Japan: 199 bytes - In other countries: String (252)  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International  #### JCN Gateway The following tags must be included: - &#x60;4F&#x60;: Application identifier - &#x60;84&#x60;: Dedicated file name  Data length: 199 bytes  #### All other processors: String (999)  #### Used by Authorization: Optional Authorization Reversal: Optional Credit: Optional PIN Debit processing (purchase, credit and reversal): Optional </value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidreversalsPointOfSaleInformationEmv {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidreversalsPointOfSaleInformationEmv);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidreversalsPointOfSaleInformationEmv instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidreversalsPointOfSaleInformationEmv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidreversalsPointOfSaleInformationEmv other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
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
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
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