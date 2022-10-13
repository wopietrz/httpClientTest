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
    /// PtsV2PaymentsPost201ResponsePaymentInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInformation :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInformation" /> class.
        /// </summary>
        /// <param name="Card">Card.</param>
        /// <param name="TokenizedCard">TokenizedCard.</param>
        /// <param name="AccountFeatures">AccountFeatures.</param>
        /// <param name="Bank">Bank.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="PaymentInstrument">PaymentInstrument.</param>
        /// <param name="InstrumentIdentifier">InstrumentIdentifier.</param>
        /// <param name="ShippingAddress">ShippingAddress.</param>
        /// <param name="Scheme">Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  For all possible values, see the &#x60;score_card_scheme&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Bin">Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  For all possible values, see the &#x60;score_cc_bin&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="AccountType">Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  For all possible values, see the &#x60;score_card_account_type&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Issuer">Name of the bank or entity that issued the card account.  For all possible values, see the &#x60;score_card_issuer&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="BinCountry">Country (two-digit country code) associated with the BIN of the customer’s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  For all possible values, see the &#x60;bin_country&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        public PtsV2PaymentsPost201ResponsePaymentInformation(PtsV2PaymentsPost201ResponsePaymentAccountInformationCard Card = default(PtsV2PaymentsPost201ResponsePaymentAccountInformationCard), PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard TokenizedCard = default(PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard), PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures AccountFeatures = default(PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures), PtsV2PaymentsPost201ResponsePaymentInformationBank Bank = default(PtsV2PaymentsPost201ResponsePaymentInformationBank), Ptsv2paymentsPaymentInformationCustomer Customer = default(Ptsv2paymentsPaymentInformationCustomer), Ptsv2paymentsPaymentInformationPaymentInstrument PaymentInstrument = default(Ptsv2paymentsPaymentInformationPaymentInstrument), PtsV2PaymentsPost201ResponsePaymentInformationInstrumentIdentifier InstrumentIdentifier = default(PtsV2PaymentsPost201ResponsePaymentInformationInstrumentIdentifier), Ptsv2paymentsPaymentInformationShippingAddress ShippingAddress = default(Ptsv2paymentsPaymentInformationShippingAddress), string Scheme = default(string), string Bin = default(string), string AccountType = default(string), string Issuer = default(string), string BinCountry = default(string))
        {
            this.Card = Card;
            this.TokenizedCard = TokenizedCard;
            this.AccountFeatures = AccountFeatures;
            this.Bank = Bank;
            this.Customer = Customer;
            this.PaymentInstrument = PaymentInstrument;
            this.InstrumentIdentifier = InstrumentIdentifier;
            this.ShippingAddress = ShippingAddress;
            this.Scheme = Scheme;
            this.Bin = Bin;
            this.AccountType = AccountType;
            this.Issuer = Issuer;
            this.BinCountry = BinCountry;
        }
        
        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentAccountInformationCard Card { get; set; }

        /// <summary>
        /// Gets or Sets TokenizedCard
        /// </summary>
        [DataMember(Name="tokenizedCard", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard TokenizedCard { get; set; }

        /// <summary>
        /// Gets or Sets AccountFeatures
        /// </summary>
        [DataMember(Name="accountFeatures", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures AccountFeatures { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationBank Bank { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstrument
        /// </summary>
        [DataMember(Name="paymentInstrument", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationPaymentInstrument PaymentInstrument { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentIdentifier
        /// </summary>
        [DataMember(Name="instrumentIdentifier", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationInstrumentIdentifier InstrumentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  For all possible values, see the &#x60;score_card_scheme&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  For all possible values, see the &#x60;score_card_scheme&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  For all possible values, see the &#x60;score_cc_bin&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  For all possible values, see the &#x60;score_cc_bin&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="bin", EmitDefaultValue=false)]
        public string Bin { get; set; }

        /// <summary>
        /// Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  For all possible values, see the &#x60;score_card_account_type&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  For all possible values, see the &#x60;score_card_account_type&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Name of the bank or entity that issued the card account.  For all possible values, see the &#x60;score_card_issuer&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Name of the bank or entity that issued the card account.  For all possible values, see the &#x60;score_card_issuer&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Country (two-digit country code) associated with the BIN of the customer’s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  For all possible values, see the &#x60;bin_country&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Country (two-digit country code) associated with the BIN of the customer’s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  For all possible values, see the &#x60;bin_country&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="binCountry", EmitDefaultValue=false)]
        public string BinCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInformation {\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  TokenizedCard: ").Append(TokenizedCard).Append("\n");
            sb.Append("  AccountFeatures: ").Append(AccountFeatures).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  PaymentInstrument: ").Append(PaymentInstrument).Append("\n");
            sb.Append("  InstrumentIdentifier: ").Append(InstrumentIdentifier).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  BinCountry: ").Append(BinCountry).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.TokenizedCard == other.TokenizedCard ||
                    this.TokenizedCard != null &&
                    this.TokenizedCard.Equals(other.TokenizedCard)
                ) && 
                (
                    this.AccountFeatures == other.AccountFeatures ||
                    this.AccountFeatures != null &&
                    this.AccountFeatures.Equals(other.AccountFeatures)
                ) && 
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.PaymentInstrument == other.PaymentInstrument ||
                    this.PaymentInstrument != null &&
                    this.PaymentInstrument.Equals(other.PaymentInstrument)
                ) && 
                (
                    this.InstrumentIdentifier == other.InstrumentIdentifier ||
                    this.InstrumentIdentifier != null &&
                    this.InstrumentIdentifier.Equals(other.InstrumentIdentifier)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.Scheme == other.Scheme ||
                    this.Scheme != null &&
                    this.Scheme.Equals(other.Scheme)
                ) && 
                (
                    this.Bin == other.Bin ||
                    this.Bin != null &&
                    this.Bin.Equals(other.Bin)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.BinCountry == other.BinCountry ||
                    this.BinCountry != null &&
                    this.BinCountry.Equals(other.BinCountry)
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
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.TokenizedCard != null)
                    hash = hash * 59 + this.TokenizedCard.GetHashCode();
                if (this.AccountFeatures != null)
                    hash = hash * 59 + this.AccountFeatures.GetHashCode();
                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.PaymentInstrument != null)
                    hash = hash * 59 + this.PaymentInstrument.GetHashCode();
                if (this.InstrumentIdentifier != null)
                    hash = hash * 59 + this.InstrumentIdentifier.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.Scheme != null)
                    hash = hash * 59 + this.Scheme.GetHashCode();
                if (this.Bin != null)
                    hash = hash * 59 + this.Bin.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.Issuer != null)
                    hash = hash * 59 + this.Issuer.GetHashCode();
                if (this.BinCountry != null)
                    hash = hash * 59 + this.BinCountry.GetHashCode();
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
