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
    /// ReportingV3ChargebackDetailsGet200ResponseChargebackDetails
    /// </summary>
    [DataContract]
    public partial class ReportingV3ChargebackDetailsGet200ResponseChargebackDetails :  IEquatable<ReportingV3ChargebackDetailsGet200ResponseChargebackDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ChargebackDetailsGet200ResponseChargebackDetails" /> class.
        /// </summary>
        /// <param name="ProcessorMerchantId">Processor Merchant Id.</param>
        /// <param name="MerchantName">Merchant Name.</param>
        /// <param name="TransactionReferenceNumber">Transaction Reference Number.</param>
        /// <param name="MerchantReferenceNumber">Merchant Reference Number.</param>
        /// <param name="NatureOfDispute">Nature of Dispute.</param>
        /// <param name="AlertType">Chargeback Alert Type.</param>
        /// <param name="Amount">Chargeback Amount.</param>
        /// <param name="Sign">Chargeback Sign.</param>
        /// <param name="Action">Chargeback Action.</param>
        /// <param name="CardType">Card Type.</param>
        /// <param name="OriginalSettlementTime">Original Settlement Date.</param>
        /// <param name="TrackingNumber">Tracking Number.</param>
        /// <param name="CurrencyCode">Valid ISO 4217 ALPHA-3 currency code.</param>
        /// <param name="RequestId">Request Id.</param>
        /// <param name="ResponseDueTime">Response Due Date.</param>
        /// <param name="Time">Chargeback Date.</param>
        /// <param name="ActionDescription">Chargeback Action Description.</param>
        /// <param name="CustomerId">Customer Id.</param>
        /// <param name="ReasonCode">Chargeback Reason Code.</param>
        /// <param name="RepresentmentCPTime">Representment CP Date.</param>
        /// <param name="Applications">ICS Request Applications.</param>
        /// <param name="EventRequestedTime">Event Request Date.</param>
        /// <param name="PreDisputeFlag">Pre Dispute Flag.</param>
        public ReportingV3ChargebackDetailsGet200ResponseChargebackDetails(string ProcessorMerchantId = default(string), string MerchantName = default(string), string TransactionReferenceNumber = default(string), string MerchantReferenceNumber = default(string), string NatureOfDispute = default(string), string AlertType = default(string), string Amount = default(string), string Sign = default(string), string Action = default(string), string CardType = default(string), DateTime? OriginalSettlementTime = default(DateTime?), string TrackingNumber = default(string), string CurrencyCode = default(string), string RequestId = default(string), DateTime? ResponseDueTime = default(DateTime?), DateTime? Time = default(DateTime?), string ActionDescription = default(string), string CustomerId = default(string), string ReasonCode = default(string), DateTime? RepresentmentCPTime = default(DateTime?), string Applications = default(string), DateTime? EventRequestedTime = default(DateTime?), string PreDisputeFlag = default(string))
        {
            this.ProcessorMerchantId = ProcessorMerchantId;
            this.MerchantName = MerchantName;
            this.TransactionReferenceNumber = TransactionReferenceNumber;
            this.MerchantReferenceNumber = MerchantReferenceNumber;
            this.NatureOfDispute = NatureOfDispute;
            this.AlertType = AlertType;
            this.Amount = Amount;
            this.Sign = Sign;
            this.Action = Action;
            this.CardType = CardType;
            this.OriginalSettlementTime = OriginalSettlementTime;
            this.TrackingNumber = TrackingNumber;
            this.CurrencyCode = CurrencyCode;
            this.RequestId = RequestId;
            this.ResponseDueTime = ResponseDueTime;
            this.Time = Time;
            this.ActionDescription = ActionDescription;
            this.CustomerId = CustomerId;
            this.ReasonCode = ReasonCode;
            this.RepresentmentCPTime = RepresentmentCPTime;
            this.Applications = Applications;
            this.EventRequestedTime = EventRequestedTime;
            this.PreDisputeFlag = PreDisputeFlag;
        }
        
        /// <summary>
        /// Processor Merchant Id
        /// </summary>
        /// <value>Processor Merchant Id</value>
        [DataMember(Name="processorMerchantId", EmitDefaultValue=false)]
        public string ProcessorMerchantId { get; set; }

        /// <summary>
        /// Merchant Name
        /// </summary>
        /// <value>Merchant Name</value>
        [DataMember(Name="merchantName", EmitDefaultValue=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Transaction Reference Number
        /// </summary>
        /// <value>Transaction Reference Number</value>
        [DataMember(Name="transactionReferenceNumber", EmitDefaultValue=false)]
        public string TransactionReferenceNumber { get; set; }

        /// <summary>
        /// Merchant Reference Number
        /// </summary>
        /// <value>Merchant Reference Number</value>
        [DataMember(Name="merchantReferenceNumber", EmitDefaultValue=false)]
        public string MerchantReferenceNumber { get; set; }

        /// <summary>
        /// Nature of Dispute
        /// </summary>
        /// <value>Nature of Dispute</value>
        [DataMember(Name="natureOfDispute", EmitDefaultValue=false)]
        public string NatureOfDispute { get; set; }

        /// <summary>
        /// Chargeback Alert Type
        /// </summary>
        /// <value>Chargeback Alert Type</value>
        [DataMember(Name="alertType", EmitDefaultValue=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// Chargeback Amount
        /// </summary>
        /// <value>Chargeback Amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Chargeback Sign
        /// </summary>
        /// <value>Chargeback Sign</value>
        [DataMember(Name="sign", EmitDefaultValue=false)]
        public string Sign { get; set; }

        /// <summary>
        /// Chargeback Action
        /// </summary>
        /// <value>Chargeback Action</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Card Type
        /// </summary>
        /// <value>Card Type</value>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public string CardType { get; set; }

        /// <summary>
        /// Original Settlement Date
        /// </summary>
        /// <value>Original Settlement Date</value>
        [DataMember(Name="originalSettlementTime", EmitDefaultValue=false)]
        public DateTime? OriginalSettlementTime { get; set; }

        /// <summary>
        /// Tracking Number
        /// </summary>
        /// <value>Tracking Number</value>
        [DataMember(Name="trackingNumber", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Valid ISO 4217 ALPHA-3 currency code
        /// </summary>
        /// <value>Valid ISO 4217 ALPHA-3 currency code</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Request Id
        /// </summary>
        /// <value>Request Id</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Response Due Date
        /// </summary>
        /// <value>Response Due Date</value>
        [DataMember(Name="responseDueTime", EmitDefaultValue=false)]
        public DateTime? ResponseDueTime { get; set; }

        /// <summary>
        /// Chargeback Date
        /// </summary>
        /// <value>Chargeback Date</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Chargeback Action Description
        /// </summary>
        /// <value>Chargeback Action Description</value>
        [DataMember(Name="actionDescription", EmitDefaultValue=false)]
        public string ActionDescription { get; set; }

        /// <summary>
        /// Customer Id
        /// </summary>
        /// <value>Customer Id</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Chargeback Reason Code
        /// </summary>
        /// <value>Chargeback Reason Code</value>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Representment CP Date
        /// </summary>
        /// <value>Representment CP Date</value>
        [DataMember(Name="representmentCPTime", EmitDefaultValue=false)]
        public DateTime? RepresentmentCPTime { get; set; }

        /// <summary>
        /// ICS Request Applications
        /// </summary>
        /// <value>ICS Request Applications</value>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public string Applications { get; set; }

        /// <summary>
        /// Event Request Date
        /// </summary>
        /// <value>Event Request Date</value>
        [DataMember(Name="eventRequestedTime", EmitDefaultValue=false)]
        public DateTime? EventRequestedTime { get; set; }

        /// <summary>
        /// Pre Dispute Flag
        /// </summary>
        /// <value>Pre Dispute Flag</value>
        [DataMember(Name="preDisputeFlag", EmitDefaultValue=false)]
        public string PreDisputeFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ChargebackDetailsGet200ResponseChargebackDetails {\n");
            sb.Append("  ProcessorMerchantId: ").Append(ProcessorMerchantId).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  TransactionReferenceNumber: ").Append(TransactionReferenceNumber).Append("\n");
            sb.Append("  MerchantReferenceNumber: ").Append(MerchantReferenceNumber).Append("\n");
            sb.Append("  NatureOfDispute: ").Append(NatureOfDispute).Append("\n");
            sb.Append("  AlertType: ").Append(AlertType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Sign: ").Append(Sign).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  OriginalSettlementTime: ").Append(OriginalSettlementTime).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ResponseDueTime: ").Append(ResponseDueTime).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  ActionDescription: ").Append(ActionDescription).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  RepresentmentCPTime: ").Append(RepresentmentCPTime).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  EventRequestedTime: ").Append(EventRequestedTime).Append("\n");
            sb.Append("  PreDisputeFlag: ").Append(PreDisputeFlag).Append("\n");
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
            return this.Equals(obj as ReportingV3ChargebackDetailsGet200ResponseChargebackDetails);
        }

        /// <summary>
        /// Returns true if ReportingV3ChargebackDetailsGet200ResponseChargebackDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ChargebackDetailsGet200ResponseChargebackDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ChargebackDetailsGet200ResponseChargebackDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProcessorMerchantId == other.ProcessorMerchantId ||
                    this.ProcessorMerchantId != null &&
                    this.ProcessorMerchantId.Equals(other.ProcessorMerchantId)
                ) && 
                (
                    this.MerchantName == other.MerchantName ||
                    this.MerchantName != null &&
                    this.MerchantName.Equals(other.MerchantName)
                ) && 
                (
                    this.TransactionReferenceNumber == other.TransactionReferenceNumber ||
                    this.TransactionReferenceNumber != null &&
                    this.TransactionReferenceNumber.Equals(other.TransactionReferenceNumber)
                ) && 
                (
                    this.MerchantReferenceNumber == other.MerchantReferenceNumber ||
                    this.MerchantReferenceNumber != null &&
                    this.MerchantReferenceNumber.Equals(other.MerchantReferenceNumber)
                ) && 
                (
                    this.NatureOfDispute == other.NatureOfDispute ||
                    this.NatureOfDispute != null &&
                    this.NatureOfDispute.Equals(other.NatureOfDispute)
                ) && 
                (
                    this.AlertType == other.AlertType ||
                    this.AlertType != null &&
                    this.AlertType.Equals(other.AlertType)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Sign == other.Sign ||
                    this.Sign != null &&
                    this.Sign.Equals(other.Sign)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
                ) && 
                (
                    this.OriginalSettlementTime == other.OriginalSettlementTime ||
                    this.OriginalSettlementTime != null &&
                    this.OriginalSettlementTime.Equals(other.OriginalSettlementTime)
                ) && 
                (
                    this.TrackingNumber == other.TrackingNumber ||
                    this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.ResponseDueTime == other.ResponseDueTime ||
                    this.ResponseDueTime != null &&
                    this.ResponseDueTime.Equals(other.ResponseDueTime)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.ActionDescription == other.ActionDescription ||
                    this.ActionDescription != null &&
                    this.ActionDescription.Equals(other.ActionDescription)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.ReasonCode == other.ReasonCode ||
                    this.ReasonCode != null &&
                    this.ReasonCode.Equals(other.ReasonCode)
                ) && 
                (
                    this.RepresentmentCPTime == other.RepresentmentCPTime ||
                    this.RepresentmentCPTime != null &&
                    this.RepresentmentCPTime.Equals(other.RepresentmentCPTime)
                ) && 
                (
                    this.Applications == other.Applications ||
                    this.Applications != null &&
                    this.Applications.Equals(other.Applications)
                ) && 
                (
                    this.EventRequestedTime == other.EventRequestedTime ||
                    this.EventRequestedTime != null &&
                    this.EventRequestedTime.Equals(other.EventRequestedTime)
                ) && 
                (
                    this.PreDisputeFlag == other.PreDisputeFlag ||
                    this.PreDisputeFlag != null &&
                    this.PreDisputeFlag.Equals(other.PreDisputeFlag)
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
                if (this.ProcessorMerchantId != null)
                    hash = hash * 59 + this.ProcessorMerchantId.GetHashCode();
                if (this.MerchantName != null)
                    hash = hash * 59 + this.MerchantName.GetHashCode();
                if (this.TransactionReferenceNumber != null)
                    hash = hash * 59 + this.TransactionReferenceNumber.GetHashCode();
                if (this.MerchantReferenceNumber != null)
                    hash = hash * 59 + this.MerchantReferenceNumber.GetHashCode();
                if (this.NatureOfDispute != null)
                    hash = hash * 59 + this.NatureOfDispute.GetHashCode();
                if (this.AlertType != null)
                    hash = hash * 59 + this.AlertType.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Sign != null)
                    hash = hash * 59 + this.Sign.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                if (this.OriginalSettlementTime != null)
                    hash = hash * 59 + this.OriginalSettlementTime.GetHashCode();
                if (this.TrackingNumber != null)
                    hash = hash * 59 + this.TrackingNumber.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.ResponseDueTime != null)
                    hash = hash * 59 + this.ResponseDueTime.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.ActionDescription != null)
                    hash = hash * 59 + this.ActionDescription.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.ReasonCode != null)
                    hash = hash * 59 + this.ReasonCode.GetHashCode();
                if (this.RepresentmentCPTime != null)
                    hash = hash * 59 + this.RepresentmentCPTime.GetHashCode();
                if (this.Applications != null)
                    hash = hash * 59 + this.Applications.GetHashCode();
                if (this.EventRequestedTime != null)
                    hash = hash * 59 + this.EventRequestedTime.GetHashCode();
                if (this.PreDisputeFlag != null)
                    hash = hash * 59 + this.PreDisputeFlag.GetHashCode();
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
