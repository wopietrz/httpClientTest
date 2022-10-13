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
    /// RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress
    /// </summary>
    [DataContract]
    public partial class RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress :  IEquatable<RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress" /> class.
        /// </summary>
        /// <param name="Address1">Address1.</param>
        /// <param name="Address2">Second line of the standardized address..</param>
        /// <param name="Address3">Third line of the standardized address..</param>
        /// <param name="Address4">Fourth line of the standardized address..</param>
        /// <param name="Locality">Standardized city name..</param>
        /// <param name="County">U.S. county if available..</param>
        /// <param name="Country">Standardized country name..</param>
        /// <param name="Csz">Standardized city, state or province, and ZIP +4 code or postal code line..</param>
        /// <param name="IsoCountry">Standardized two-character ISO country code..</param>
        /// <param name="AdministrativeArea">U.S.P.S. standardized state or province abbreviation..</param>
        /// <param name="PostalCode">Standardized U.S. ZIP + 4 postal code..</param>
        public RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 Address1 = default(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1), string Address2 = default(string), string Address3 = default(string), string Address4 = default(string), string Locality = default(string), string County = default(string), string Country = default(string), string Csz = default(string), string IsoCountry = default(string), string AdministrativeArea = default(string), string PostalCode = default(string))
        {
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Address3 = Address3;
            this.Address4 = Address4;
            this.Locality = Locality;
            this.County = County;
            this.Country = Country;
            this.Csz = Csz;
            this.IsoCountry = IsoCountry;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 Address1 { get; set; }

        /// <summary>
        /// Second line of the standardized address.
        /// </summary>
        /// <value>Second line of the standardized address.</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Third line of the standardized address.
        /// </summary>
        /// <value>Third line of the standardized address.</value>
        [DataMember(Name="address3", EmitDefaultValue=false)]
        public string Address3 { get; set; }

        /// <summary>
        /// Fourth line of the standardized address.
        /// </summary>
        /// <value>Fourth line of the standardized address.</value>
        [DataMember(Name="address4", EmitDefaultValue=false)]
        public string Address4 { get; set; }

        /// <summary>
        /// Standardized city name.
        /// </summary>
        /// <value>Standardized city name.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// U.S. county if available.
        /// </summary>
        /// <value>U.S. county if available.</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Standardized country name.
        /// </summary>
        /// <value>Standardized country name.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Standardized city, state or province, and ZIP +4 code or postal code line.
        /// </summary>
        /// <value>Standardized city, state or province, and ZIP +4 code or postal code line.</value>
        [DataMember(Name="csz", EmitDefaultValue=false)]
        public string Csz { get; set; }

        /// <summary>
        /// Standardized two-character ISO country code.
        /// </summary>
        /// <value>Standardized two-character ISO country code.</value>
        [DataMember(Name="isoCountry", EmitDefaultValue=false)]
        public string IsoCountry { get; set; }

        /// <summary>
        /// U.S.P.S. standardized state or province abbreviation.
        /// </summary>
        /// <value>U.S.P.S. standardized state or province abbreviation.</value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Standardized U.S. ZIP + 4 postal code.
        /// </summary>
        /// <value>Standardized U.S. ZIP + 4 postal code.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  Address4: ").Append(Address4).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Csz: ").Append(Csz).Append("\n");
            sb.Append("  IsoCountry: ").Append(IsoCountry).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(obj as RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress);
        }

        /// <summary>
        /// Returns true if RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.Address3 == other.Address3 ||
                    this.Address3 != null &&
                    this.Address3.Equals(other.Address3)
                ) && 
                (
                    this.Address4 == other.Address4 ||
                    this.Address4 != null &&
                    this.Address4.Equals(other.Address4)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Csz == other.Csz ||
                    this.Csz != null &&
                    this.Csz.Equals(other.Csz)
                ) && 
                (
                    this.IsoCountry == other.IsoCountry ||
                    this.IsoCountry != null &&
                    this.IsoCountry.Equals(other.IsoCountry)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
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
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.Address3 != null)
                    hash = hash * 59 + this.Address3.GetHashCode();
                if (this.Address4 != null)
                    hash = hash * 59 + this.Address4.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Csz != null)
                    hash = hash * 59 + this.Csz.GetHashCode();
                if (this.IsoCountry != null)
                    hash = hash * 59 + this.IsoCountry.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
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
