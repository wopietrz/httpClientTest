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
    /// Riskv1authenticationresultsConsumerAuthenticationInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationresultsConsumerAuthenticationInformation :  IEquatable<Riskv1authenticationresultsConsumerAuthenticationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationresultsConsumerAuthenticationInformation" /> class.
        /// </summary>
        /// <param name="AuthenticationTransactionId">Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages.For Rupay,this is passed only in Re-Send OTP usecase. **Note**: Required for Standard integration, Rupay Seamless server to server integration for enroll service. Required for Hybrid integration for validate service. .</param>
        /// <param name="AuthenticationTransactionContext">Authentication transaction context is used as a unique identifier to link enroll and validate call. .</param>
        /// <param name="OtpToken">OTP entered by the card holder. .</param>
        /// <param name="AuthenticationType">Indicates the type of authentication that will be used to challenge the card holder.  Possible Values:  01 - Static  02 - Dynamic  03 - OOB (Out of Band)  04 - Decoupled  20 - OTP hosted at merchant end. (Rupay S2S flow) **NOTE**:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time. .</param>
        /// <param name="EffectiveAuthenticationType">This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows; CH - Challenge FR - Frictionless FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer). .</param>
        /// <param name="ResponseAccessToken">JWT returned by the 3D Secure provider when the authentication is complete. Required for Hybrid integration if you use the Cybersource-generated access token. Note: Max. length of this field is 2048 characters. .</param>
        /// <param name="SignedParesStatusReason">Provides additional information as to why the PAResStatus has a specific value. .</param>
        /// <param name="SignedPares">Payer authentication result (PARes) message returned by the card-issuing bank. If you need to show proof of enrollment checking, you may need to decrypt and parse the string for the information required by the payment card company. For more information, see \&quot;Storing Payer Authentication Data,\&quot; page 160. Important The value is in base64. You must remove all carriage returns and line feeds before adding the PARes to the request. .</param>
        /// <param name="WhiteListStatus">Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.  Possible Values:  Y - 3DS Requestor is whitelisted by cardholder  N - 3DS Requestor is not whitelisted by cardholder .</param>
        public Riskv1authenticationresultsConsumerAuthenticationInformation(string AuthenticationTransactionId = default(string), string AuthenticationTransactionContext = default(string), string OtpToken = default(string), string AuthenticationType = default(string), string EffectiveAuthenticationType = default(string), string ResponseAccessToken = default(string), string SignedParesStatusReason = default(string), string SignedPares = default(string), string WhiteListStatus = default(string))
        {
            this.AuthenticationTransactionId = AuthenticationTransactionId;
            this.AuthenticationTransactionContext = AuthenticationTransactionContext;
            this.OtpToken = OtpToken;
            this.AuthenticationType = AuthenticationType;
            this.EffectiveAuthenticationType = EffectiveAuthenticationType;
            this.ResponseAccessToken = ResponseAccessToken;
            this.SignedParesStatusReason = SignedParesStatusReason;
            this.SignedPares = SignedPares;
            this.WhiteListStatus = WhiteListStatus;
        }
        
        /// <summary>
        /// Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages.For Rupay,this is passed only in Re-Send OTP usecase. **Note**: Required for Standard integration, Rupay Seamless server to server integration for enroll service. Required for Hybrid integration for validate service. 
        /// </summary>
        /// <value>Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages.For Rupay,this is passed only in Re-Send OTP usecase. **Note**: Required for Standard integration, Rupay Seamless server to server integration for enroll service. Required for Hybrid integration for validate service. </value>
        [DataMember(Name="authenticationTransactionId", EmitDefaultValue=false)]
        public string AuthenticationTransactionId { get; set; }

        /// <summary>
        /// Authentication transaction context is used as a unique identifier to link enroll and validate call. 
        /// </summary>
        /// <value>Authentication transaction context is used as a unique identifier to link enroll and validate call. </value>
        [DataMember(Name="authenticationTransactionContext", EmitDefaultValue=false)]
        public string AuthenticationTransactionContext { get; set; }

        /// <summary>
        /// OTP entered by the card holder. 
        /// </summary>
        /// <value>OTP entered by the card holder. </value>
        [DataMember(Name="otpToken", EmitDefaultValue=false)]
        public string OtpToken { get; set; }

        /// <summary>
        /// Indicates the type of authentication that will be used to challenge the card holder.  Possible Values:  01 - Static  02 - Dynamic  03 - OOB (Out of Band)  04 - Decoupled  20 - OTP hosted at merchant end. (Rupay S2S flow) **NOTE**:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time. 
        /// </summary>
        /// <value>Indicates the type of authentication that will be used to challenge the card holder.  Possible Values:  01 - Static  02 - Dynamic  03 - OOB (Out of Band)  04 - Decoupled  20 - OTP hosted at merchant end. (Rupay S2S flow) **NOTE**:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time. </value>
        [DataMember(Name="authenticationType", EmitDefaultValue=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows; CH - Challenge FR - Frictionless FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer). 
        /// </summary>
        /// <value>This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows; CH - Challenge FR - Frictionless FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer). </value>
        [DataMember(Name="effectiveAuthenticationType", EmitDefaultValue=false)]
        public string EffectiveAuthenticationType { get; set; }

        /// <summary>
        /// JWT returned by the 3D Secure provider when the authentication is complete. Required for Hybrid integration if you use the Cybersource-generated access token. Note: Max. length of this field is 2048 characters. 
        /// </summary>
        /// <value>JWT returned by the 3D Secure provider when the authentication is complete. Required for Hybrid integration if you use the Cybersource-generated access token. Note: Max. length of this field is 2048 characters. </value>
        [DataMember(Name="responseAccessToken", EmitDefaultValue=false)]
        public string ResponseAccessToken { get; set; }

        /// <summary>
        /// Provides additional information as to why the PAResStatus has a specific value. 
        /// </summary>
        /// <value>Provides additional information as to why the PAResStatus has a specific value. </value>
        [DataMember(Name="signedParesStatusReason", EmitDefaultValue=false)]
        public string SignedParesStatusReason { get; set; }

        /// <summary>
        /// Payer authentication result (PARes) message returned by the card-issuing bank. If you need to show proof of enrollment checking, you may need to decrypt and parse the string for the information required by the payment card company. For more information, see \&quot;Storing Payer Authentication Data,\&quot; page 160. Important The value is in base64. You must remove all carriage returns and line feeds before adding the PARes to the request. 
        /// </summary>
        /// <value>Payer authentication result (PARes) message returned by the card-issuing bank. If you need to show proof of enrollment checking, you may need to decrypt and parse the string for the information required by the payment card company. For more information, see \&quot;Storing Payer Authentication Data,\&quot; page 160. Important The value is in base64. You must remove all carriage returns and line feeds before adding the PARes to the request. </value>
        [DataMember(Name="signedPares", EmitDefaultValue=false)]
        public string SignedPares { get; set; }

        /// <summary>
        /// Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.  Possible Values:  Y - 3DS Requestor is whitelisted by cardholder  N - 3DS Requestor is not whitelisted by cardholder 
        /// </summary>
        /// <value>Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.  Possible Values:  Y - 3DS Requestor is whitelisted by cardholder  N - 3DS Requestor is not whitelisted by cardholder </value>
        [DataMember(Name="whiteListStatus", EmitDefaultValue=false)]
        public string WhiteListStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationresultsConsumerAuthenticationInformation {\n");
            sb.Append("  AuthenticationTransactionId: ").Append(AuthenticationTransactionId).Append("\n");
            sb.Append("  AuthenticationTransactionContext: ").Append(AuthenticationTransactionContext).Append("\n");
            sb.Append("  OtpToken: ").Append(OtpToken).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  EffectiveAuthenticationType: ").Append(EffectiveAuthenticationType).Append("\n");
            sb.Append("  ResponseAccessToken: ").Append(ResponseAccessToken).Append("\n");
            sb.Append("  SignedParesStatusReason: ").Append(SignedParesStatusReason).Append("\n");
            sb.Append("  SignedPares: ").Append(SignedPares).Append("\n");
            sb.Append("  WhiteListStatus: ").Append(WhiteListStatus).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationresultsConsumerAuthenticationInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationresultsConsumerAuthenticationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationresultsConsumerAuthenticationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationresultsConsumerAuthenticationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationTransactionId == other.AuthenticationTransactionId ||
                    this.AuthenticationTransactionId != null &&
                    this.AuthenticationTransactionId.Equals(other.AuthenticationTransactionId)
                ) && 
                (
                    this.AuthenticationTransactionContext == other.AuthenticationTransactionContext ||
                    this.AuthenticationTransactionContext != null &&
                    this.AuthenticationTransactionContext.Equals(other.AuthenticationTransactionContext)
                ) && 
                (
                    this.OtpToken == other.OtpToken ||
                    this.OtpToken != null &&
                    this.OtpToken.Equals(other.OtpToken)
                ) && 
                (
                    this.AuthenticationType == other.AuthenticationType ||
                    this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(other.AuthenticationType)
                ) && 
                (
                    this.EffectiveAuthenticationType == other.EffectiveAuthenticationType ||
                    this.EffectiveAuthenticationType != null &&
                    this.EffectiveAuthenticationType.Equals(other.EffectiveAuthenticationType)
                ) && 
                (
                    this.ResponseAccessToken == other.ResponseAccessToken ||
                    this.ResponseAccessToken != null &&
                    this.ResponseAccessToken.Equals(other.ResponseAccessToken)
                ) && 
                (
                    this.SignedParesStatusReason == other.SignedParesStatusReason ||
                    this.SignedParesStatusReason != null &&
                    this.SignedParesStatusReason.Equals(other.SignedParesStatusReason)
                ) && 
                (
                    this.SignedPares == other.SignedPares ||
                    this.SignedPares != null &&
                    this.SignedPares.Equals(other.SignedPares)
                ) && 
                (
                    this.WhiteListStatus == other.WhiteListStatus ||
                    this.WhiteListStatus != null &&
                    this.WhiteListStatus.Equals(other.WhiteListStatus)
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
                if (this.AuthenticationTransactionId != null)
                    hash = hash * 59 + this.AuthenticationTransactionId.GetHashCode();
                if (this.AuthenticationTransactionContext != null)
                    hash = hash * 59 + this.AuthenticationTransactionContext.GetHashCode();
                if (this.OtpToken != null)
                    hash = hash * 59 + this.OtpToken.GetHashCode();
                if (this.AuthenticationType != null)
                    hash = hash * 59 + this.AuthenticationType.GetHashCode();
                if (this.EffectiveAuthenticationType != null)
                    hash = hash * 59 + this.EffectiveAuthenticationType.GetHashCode();
                if (this.ResponseAccessToken != null)
                    hash = hash * 59 + this.ResponseAccessToken.GetHashCode();
                if (this.SignedParesStatusReason != null)
                    hash = hash * 59 + this.SignedParesStatusReason.GetHashCode();
                if (this.SignedPares != null)
                    hash = hash * 59 + this.SignedPares.GetHashCode();
                if (this.WhiteListStatus != null)
                    hash = hash * 59 + this.WhiteListStatus.GetHashCode();
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