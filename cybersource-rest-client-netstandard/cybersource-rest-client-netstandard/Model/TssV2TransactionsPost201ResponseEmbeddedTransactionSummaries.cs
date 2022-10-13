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
    /// TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries" /> class.
        /// </summary>
        /// <param name="Id">An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. .</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. .</param>
        /// <param name="MerchantId">Your CyberSource merchant ID..</param>
        /// <param name="ApplicationInformation">ApplicationInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="FraudMarkingInformation">FraudMarkingInformation.</param>
        /// <param name="MerchantDefinedInformation">The object containing the custom data that the merchant defines. .</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="ProcessorInformation">ProcessorInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        /// <param name="RiskInformation">RiskInformation.</param>
        /// <param name="Links">Links.</param>
        public TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries(string Id = default(string), string SubmitTimeUtc = default(string), string MerchantId = default(string), TssV2TransactionsPost201ResponseEmbeddedApplicationInformation ApplicationInformation = default(TssV2TransactionsPost201ResponseEmbeddedApplicationInformation), TssV2TransactionsPost201ResponseEmbeddedBuyerInformation BuyerInformation = default(TssV2TransactionsPost201ResponseEmbeddedBuyerInformation), TssV2TransactionsPost201ResponseEmbeddedClientReferenceInformation ClientReferenceInformation = default(TssV2TransactionsPost201ResponseEmbeddedClientReferenceInformation), TssV2TransactionsPost201ResponseEmbeddedConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(TssV2TransactionsPost201ResponseEmbeddedConsumerAuthenticationInformation), Riskv1authenticationresultsDeviceInformation DeviceInformation = default(Riskv1authenticationresultsDeviceInformation), TssV2TransactionsGet200ResponseFraudMarkingInformation FraudMarkingInformation = default(TssV2TransactionsGet200ResponseFraudMarkingInformation), List<Ptsv2paymentsMerchantDefinedInformation> MerchantDefinedInformation = default(List<Ptsv2paymentsMerchantDefinedInformation>), TssV2TransactionsPost201ResponseEmbeddedMerchantInformation MerchantInformation = default(TssV2TransactionsPost201ResponseEmbeddedMerchantInformation), TssV2TransactionsPost201ResponseEmbeddedOrderInformation OrderInformation = default(TssV2TransactionsPost201ResponseEmbeddedOrderInformation), TssV2TransactionsPost201ResponseEmbeddedPaymentInformation PaymentInformation = default(TssV2TransactionsPost201ResponseEmbeddedPaymentInformation), TssV2TransactionsPost201ResponseEmbeddedProcessingInformation ProcessingInformation = default(TssV2TransactionsPost201ResponseEmbeddedProcessingInformation), TssV2TransactionsPost201ResponseEmbeddedProcessorInformation ProcessorInformation = default(TssV2TransactionsPost201ResponseEmbeddedProcessorInformation), TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation PointOfSaleInformation = default(TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation), TssV2TransactionsPost201ResponseEmbeddedRiskInformation RiskInformation = default(TssV2TransactionsPost201ResponseEmbeddedRiskInformation), TssV2TransactionsPost201ResponseEmbeddedLinks Links = default(TssV2TransactionsPost201ResponseEmbeddedLinks))
        {
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.MerchantId = MerchantId;
            this.ApplicationInformation = ApplicationInformation;
            this.BuyerInformation = BuyerInformation;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
            this.DeviceInformation = DeviceInformation;
            this.FraudMarkingInformation = FraudMarkingInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
            this.MerchantInformation = MerchantInformation;
            this.OrderInformation = OrderInformation;
            this.PaymentInformation = PaymentInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.ProcessorInformation = ProcessorInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
            this.RiskInformation = RiskInformation;
            this.Links = Links;
        }
        
        /// <summary>
        /// An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. 
        /// </summary>
        /// <value>An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. 
        /// </summary>
        /// <value>Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// Your CyberSource merchant ID.
        /// </summary>
        /// <value>Your CyberSource merchant ID.</value>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInformation
        /// </summary>
        [DataMember(Name="applicationInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedApplicationInformation ApplicationInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public Riskv1authenticationresultsDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets FraudMarkingInformation
        /// </summary>
        [DataMember(Name="fraudMarkingInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseFraudMarkingInformation FraudMarkingInformation { get; set; }

        /// <summary>
        /// The object containing the custom data that the merchant defines. 
        /// </summary>
        /// <value>The object containing the custom data that the merchant defines. </value>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<Ptsv2paymentsMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessorInformation
        /// </summary>
        [DataMember(Name="processorInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedProcessorInformation ProcessorInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  ApplicationInformation: ").Append(ApplicationInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  FraudMarkingInformation: ").Append(FraudMarkingInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  ProcessorInformation: ").Append(ProcessorInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedTransactionSummaries other)
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
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
                ) && 
                (
                    this.ApplicationInformation == other.ApplicationInformation ||
                    this.ApplicationInformation != null &&
                    this.ApplicationInformation.Equals(other.ApplicationInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.FraudMarkingInformation == other.FraudMarkingInformation ||
                    this.FraudMarkingInformation != null &&
                    this.FraudMarkingInformation.Equals(other.FraudMarkingInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.ProcessorInformation == other.ProcessorInformation ||
                    this.ProcessorInformation != null &&
                    this.ProcessorInformation.Equals(other.ProcessorInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
                ) && 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                if (this.ApplicationInformation != null)
                    hash = hash * 59 + this.ApplicationInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.FraudMarkingInformation != null)
                    hash = hash * 59 + this.FraudMarkingInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.ProcessorInformation != null)
                    hash = hash * 59 + this.ProcessorInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
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
