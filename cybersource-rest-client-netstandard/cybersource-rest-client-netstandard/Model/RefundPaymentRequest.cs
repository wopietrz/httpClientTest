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
    /// RefundPaymentRequest
    /// </summary>
    [DataContract]
    public partial class RefundPaymentRequest :  IEquatable<RefundPaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPaymentRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="AggregatorInformation">AggregatorInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        /// <param name="MerchantDefinedInformation">The object containing the custom data that the merchant defines. .</param>
        /// <param name="TravelInformation">TravelInformation.</param>
        /// <param name="PromotionInformation">PromotionInformation.</param>
        public RefundPaymentRequest(Ptsv2paymentsClientReferenceInformation ClientReferenceInformation = default(Ptsv2paymentsClientReferenceInformation), Ptsv2paymentsidrefundsProcessingInformation ProcessingInformation = default(Ptsv2paymentsidrefundsProcessingInformation), Ptsv2paymentsidrefundsPaymentInformation PaymentInformation = default(Ptsv2paymentsidrefundsPaymentInformation), Ptsv2paymentsidrefundsOrderInformation OrderInformation = default(Ptsv2paymentsidrefundsOrderInformation), Ptsv2paymentsidcapturesBuyerInformation BuyerInformation = default(Ptsv2paymentsidcapturesBuyerInformation), Ptsv2paymentsidcapturesDeviceInformation DeviceInformation = default(Ptsv2paymentsidcapturesDeviceInformation), Ptsv2paymentsidrefundsMerchantInformation MerchantInformation = default(Ptsv2paymentsidrefundsMerchantInformation), Ptsv2paymentsidcapturesAggregatorInformation AggregatorInformation = default(Ptsv2paymentsidcapturesAggregatorInformation), Ptsv2paymentsidrefundsPointOfSaleInformation PointOfSaleInformation = default(Ptsv2paymentsidrefundsPointOfSaleInformation), List<Ptsv2paymentsMerchantDefinedInformation> MerchantDefinedInformation = default(List<Ptsv2paymentsMerchantDefinedInformation>), Ptsv2paymentsTravelInformation TravelInformation = default(Ptsv2paymentsTravelInformation), Ptsv2paymentsPromotionInformation PromotionInformation = default(Ptsv2paymentsPromotionInformation))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.PaymentInformation = PaymentInformation;
            this.OrderInformation = OrderInformation;
            this.BuyerInformation = BuyerInformation;
            this.DeviceInformation = DeviceInformation;
            this.MerchantInformation = MerchantInformation;
            this.AggregatorInformation = AggregatorInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
            this.TravelInformation = TravelInformation;
            this.PromotionInformation = PromotionInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets AggregatorInformation
        /// </summary>
        [DataMember(Name="aggregatorInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesAggregatorInformation AggregatorInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsPointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// The object containing the custom data that the merchant defines. 
        /// </summary>
        /// <value>The object containing the custom data that the merchant defines. </value>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<Ptsv2paymentsMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Gets or Sets TravelInformation
        /// </summary>
        [DataMember(Name="travelInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsTravelInformation TravelInformation { get; set; }

        /// <summary>
        /// Gets or Sets PromotionInformation
        /// </summary>
        [DataMember(Name="promotionInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsPromotionInformation PromotionInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundPaymentRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  AggregatorInformation: ").Append(AggregatorInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
            sb.Append("  TravelInformation: ").Append(TravelInformation).Append("\n");
            sb.Append("  PromotionInformation: ").Append(PromotionInformation).Append("\n");
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
            return this.Equals(obj as RefundPaymentRequest);
        }

        /// <summary>
        /// Returns true if RefundPaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RefundPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundPaymentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.AggregatorInformation == other.AggregatorInformation ||
                    this.AggregatorInformation != null &&
                    this.AggregatorInformation.Equals(other.AggregatorInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
                ) && 
                (
                    this.TravelInformation == other.TravelInformation ||
                    this.TravelInformation != null &&
                    this.TravelInformation.Equals(other.TravelInformation)
                ) && 
                (
                    this.PromotionInformation == other.PromotionInformation ||
                    this.PromotionInformation != null &&
                    this.PromotionInformation.Equals(other.PromotionInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.AggregatorInformation != null)
                    hash = hash * 59 + this.AggregatorInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
                if (this.TravelInformation != null)
                    hash = hash * 59 + this.TravelInformation.GetHashCode();
                if (this.PromotionInformation != null)
                    hash = hash * 59 + this.PromotionInformation.GetHashCode();
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
