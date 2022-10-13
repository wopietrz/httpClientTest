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
    /// Ptsv2payoutsProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2payoutsProcessingInformation :  IEquatable<Ptsv2payoutsProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2payoutsProcessingInformation" /> class.
        /// </summary>
        /// <param name="BusinessApplicationId">Payouts transaction type.  Applicable Processors: FDC Compass, Paymentech, CtV  Possible values:  **Credit Card Bill Payment**   - **CP**: credit card bill payment  **Funds Disbursement**   - **FD**: funds disbursement  - **GD**: government disbursement  - **MD**: merchant disbursement  **Money Transfer**   - **AA**: account to account. Sender and receiver are same person.  - **PP**: person to person. Sender and receiver are different.  **Prepaid Load**   - **TU**: top up .</param>
        /// <param name="NetworkRoutingOrder">This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer’s preference.  If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer’s routing priorities.   For details, see the &#x60;network_order&#x60; field description in [BIN Lookup Service Using the SCMP API.](http://apps.cybersource.com/library/documentation/BIN_Lookup/BIN_Lookup_SCMP_API/html/) .</param>
        /// <param name="CommerceIndicator">Type of transaction.  Value for an OCT transaction: - &#x60;internet&#x60;  For details, see the &#x60;e_commerce_indicator&#x60; field description in [Payouts Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/payouts_SCMP/html/) .</param>
        /// <param name="ReconciliationId">Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). .</param>
        /// <param name="PayoutsOptions">PayoutsOptions.</param>
        /// <param name="TransactionReason">Transaction reason code. .</param>
        /// <param name="PurposeOfPayment">This will send purpose of funds code for original credit transactions (OCTs). .</param>
        /// <param name="FundingOptions">FundingOptions.</param>
        public Ptsv2payoutsProcessingInformation(string BusinessApplicationId = default(string), string NetworkRoutingOrder = default(string), string CommerceIndicator = default(string), string ReconciliationId = default(string), Ptsv2payoutsProcessingInformationPayoutsOptions PayoutsOptions = default(Ptsv2payoutsProcessingInformationPayoutsOptions), string TransactionReason = default(string), string PurposeOfPayment = default(string), Ptsv2payoutsProcessingInformationFundingOptions FundingOptions = default(Ptsv2payoutsProcessingInformationFundingOptions))
        {
            this.BusinessApplicationId = BusinessApplicationId;
            this.NetworkRoutingOrder = NetworkRoutingOrder;
            this.CommerceIndicator = CommerceIndicator;
            this.ReconciliationId = ReconciliationId;
            this.PayoutsOptions = PayoutsOptions;
            this.TransactionReason = TransactionReason;
            this.PurposeOfPayment = PurposeOfPayment;
            this.FundingOptions = FundingOptions;
        }
        
        /// <summary>
        /// Payouts transaction type.  Applicable Processors: FDC Compass, Paymentech, CtV  Possible values:  **Credit Card Bill Payment**   - **CP**: credit card bill payment  **Funds Disbursement**   - **FD**: funds disbursement  - **GD**: government disbursement  - **MD**: merchant disbursement  **Money Transfer**   - **AA**: account to account. Sender and receiver are same person.  - **PP**: person to person. Sender and receiver are different.  **Prepaid Load**   - **TU**: top up 
        /// </summary>
        /// <value>Payouts transaction type.  Applicable Processors: FDC Compass, Paymentech, CtV  Possible values:  **Credit Card Bill Payment**   - **CP**: credit card bill payment  **Funds Disbursement**   - **FD**: funds disbursement  - **GD**: government disbursement  - **MD**: merchant disbursement  **Money Transfer**   - **AA**: account to account. Sender and receiver are same person.  - **PP**: person to person. Sender and receiver are different.  **Prepaid Load**   - **TU**: top up </value>
        [DataMember(Name="businessApplicationId", EmitDefaultValue=false)]
        public string BusinessApplicationId { get; set; }

        /// <summary>
        /// This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer’s preference.  If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer’s routing priorities.   For details, see the &#x60;network_order&#x60; field description in [BIN Lookup Service Using the SCMP API.](http://apps.cybersource.com/library/documentation/BIN_Lookup/BIN_Lookup_SCMP_API/html/) 
        /// </summary>
        /// <value>This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer’s preference.  If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer’s routing priorities.   For details, see the &#x60;network_order&#x60; field description in [BIN Lookup Service Using the SCMP API.](http://apps.cybersource.com/library/documentation/BIN_Lookup/BIN_Lookup_SCMP_API/html/) </value>
        [DataMember(Name="networkRoutingOrder", EmitDefaultValue=false)]
        public string NetworkRoutingOrder { get; set; }

        /// <summary>
        /// Type of transaction.  Value for an OCT transaction: - &#x60;internet&#x60;  For details, see the &#x60;e_commerce_indicator&#x60; field description in [Payouts Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/payouts_SCMP/html/) 
        /// </summary>
        /// <value>Type of transaction.  Value for an OCT transaction: - &#x60;internet&#x60;  For details, see the &#x60;e_commerce_indicator&#x60; field description in [Payouts Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/payouts_SCMP/html/) </value>
        [DataMember(Name="commerceIndicator", EmitDefaultValue=false)]
        public string CommerceIndicator { get; set; }

        /// <summary>
        /// Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). 
        /// </summary>
        /// <value>Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Gets or Sets PayoutsOptions
        /// </summary>
        [DataMember(Name="payoutsOptions", EmitDefaultValue=false)]
        public Ptsv2payoutsProcessingInformationPayoutsOptions PayoutsOptions { get; set; }

        /// <summary>
        /// Transaction reason code. 
        /// </summary>
        /// <value>Transaction reason code. </value>
        [DataMember(Name="transactionReason", EmitDefaultValue=false)]
        public string TransactionReason { get; set; }

        /// <summary>
        /// This will send purpose of funds code for original credit transactions (OCTs). 
        /// </summary>
        /// <value>This will send purpose of funds code for original credit transactions (OCTs). </value>
        [DataMember(Name="purposeOfPayment", EmitDefaultValue=false)]
        public string PurposeOfPayment { get; set; }

        /// <summary>
        /// Gets or Sets FundingOptions
        /// </summary>
        [DataMember(Name="fundingOptions", EmitDefaultValue=false)]
        public Ptsv2payoutsProcessingInformationFundingOptions FundingOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2payoutsProcessingInformation {\n");
            sb.Append("  BusinessApplicationId: ").Append(BusinessApplicationId).Append("\n");
            sb.Append("  NetworkRoutingOrder: ").Append(NetworkRoutingOrder).Append("\n");
            sb.Append("  CommerceIndicator: ").Append(CommerceIndicator).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  PayoutsOptions: ").Append(PayoutsOptions).Append("\n");
            sb.Append("  TransactionReason: ").Append(TransactionReason).Append("\n");
            sb.Append("  PurposeOfPayment: ").Append(PurposeOfPayment).Append("\n");
            sb.Append("  FundingOptions: ").Append(FundingOptions).Append("\n");
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
            return this.Equals(obj as Ptsv2payoutsProcessingInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2payoutsProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2payoutsProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2payoutsProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BusinessApplicationId == other.BusinessApplicationId ||
                    this.BusinessApplicationId != null &&
                    this.BusinessApplicationId.Equals(other.BusinessApplicationId)
                ) && 
                (
                    this.NetworkRoutingOrder == other.NetworkRoutingOrder ||
                    this.NetworkRoutingOrder != null &&
                    this.NetworkRoutingOrder.Equals(other.NetworkRoutingOrder)
                ) && 
                (
                    this.CommerceIndicator == other.CommerceIndicator ||
                    this.CommerceIndicator != null &&
                    this.CommerceIndicator.Equals(other.CommerceIndicator)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.PayoutsOptions == other.PayoutsOptions ||
                    this.PayoutsOptions != null &&
                    this.PayoutsOptions.Equals(other.PayoutsOptions)
                ) && 
                (
                    this.TransactionReason == other.TransactionReason ||
                    this.TransactionReason != null &&
                    this.TransactionReason.Equals(other.TransactionReason)
                ) && 
                (
                    this.PurposeOfPayment == other.PurposeOfPayment ||
                    this.PurposeOfPayment != null &&
                    this.PurposeOfPayment.Equals(other.PurposeOfPayment)
                ) && 
                (
                    this.FundingOptions == other.FundingOptions ||
                    this.FundingOptions != null &&
                    this.FundingOptions.Equals(other.FundingOptions)
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
                if (this.BusinessApplicationId != null)
                    hash = hash * 59 + this.BusinessApplicationId.GetHashCode();
                if (this.NetworkRoutingOrder != null)
                    hash = hash * 59 + this.NetworkRoutingOrder.GetHashCode();
                if (this.CommerceIndicator != null)
                    hash = hash * 59 + this.CommerceIndicator.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.PayoutsOptions != null)
                    hash = hash * 59 + this.PayoutsOptions.GetHashCode();
                if (this.TransactionReason != null)
                    hash = hash * 59 + this.TransactionReason.GetHashCode();
                if (this.PurposeOfPayment != null)
                    hash = hash * 59 + this.PurposeOfPayment.GetHashCode();
                if (this.FundingOptions != null)
                    hash = hash * 59 + this.FundingOptions.GetHashCode();
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