using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ThirdPartyParcelAccount :  IEquatable<ThirdPartyParcelAccount>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParcelAccount" /> class.
        /// Initializes a new instance of the <see cref="ThirdPartyParcelAccount" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Carrier">Carrier (required).</param>
        /// <param name="AccountNo">AccountNo (required).</param>
        /// <param name="AccountName">AccountName (required).</param>
        /// <param name="BillingCompany">BillingCompany (required).</param>
        /// <param name="Attention">Attention.</param>
        /// <param name="Street1">Street1 (required).</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Street3">Street3.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State (required).</param>
        /// <param name="Country">Country.</param>
        /// <param name="ZipCode">ZipCode (required).</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Active">Active (required).</param>

        public ThirdPartyParcelAccount(int? LobId = null, string Carrier = null, string AccountNo = null, string AccountName = null, string BillingCompany = null, string Attention = null, string Street1 = null, string Street2 = null, string Street3 = null, string City = null, string State = null, string Country = null, string ZipCode = null, string Phone = null, string Active = null, )
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Carrier" is required (not null)
            if (Carrier == null)
            {
                throw new InvalidDataException("Carrier is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.Carrier = Carrier;
            }
            // to ensure "AccountNo" is required (not null)
            if (AccountNo == null)
            {
                throw new InvalidDataException("AccountNo is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.AccountNo = AccountNo;
            }
            // to ensure "AccountName" is required (not null)
            if (AccountName == null)
            {
                throw new InvalidDataException("AccountName is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.AccountName = AccountName;
            }
            // to ensure "BillingCompany" is required (not null)
            if (BillingCompany == null)
            {
                throw new InvalidDataException("BillingCompany is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.BillingCompany = BillingCompany;
            }
            // to ensure "Street1" is required (not null)
            if (Street1 == null)
            {
                throw new InvalidDataException("Street1 is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.Street1 = Street1;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "ZipCode" is required (not null)
            if (ZipCode == null)
            {
                throw new InvalidDataException("ZipCode is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.ZipCode = ZipCode;
            }
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for ThirdPartyParcelAccount and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
            this.Attention = Attention;
            this.Street2 = Street2;
            this.Street3 = Street3;
            this.Country = Country;
            this.Phone = Phone;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=false)]
        public string AccountNo { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingCompany
        /// </summary>
        [DataMember(Name="billingCompany", EmitDefaultValue=false)]
        public string BillingCompany { get; set; }
    
        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="attention", EmitDefaultValue=false)]
        public string Attention { get; set; }
    
        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        [DataMember(Name="street1", EmitDefaultValue=false)]
        public string Street1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Street3
        /// </summary>
        [DataMember(Name="street3", EmitDefaultValue=false)]
        public string Street3 { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public string Active { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyParcelAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  BillingCompany: ").Append(BillingCompany).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Street3: ").Append(Street3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            
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
            return this.Equals(obj as ThirdPartyParcelAccount);
        }

        /// <summary>
        /// Returns true if ThirdPartyParcelAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of ThirdPartyParcelAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThirdPartyParcelAccount other)
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
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.AccountNo == other.AccountNo ||
                    this.AccountNo != null &&
                    this.AccountNo.Equals(other.AccountNo)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.BillingCompany == other.BillingCompany ||
                    this.BillingCompany != null &&
                    this.BillingCompany.Equals(other.BillingCompany)
                ) && 
                (
                    this.Attention == other.Attention ||
                    this.Attention != null &&
                    this.Attention.Equals(other.Attention)
                ) && 
                (
                    this.Street1 == other.Street1 ||
                    this.Street1 != null &&
                    this.Street1.Equals(other.Street1)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.Street3 == other.Street3 ||
                    this.Street3 != null &&
                    this.Street3.Equals(other.Street3)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
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
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.AccountNo != null)
                    hash = hash * 59 + this.AccountNo.GetHashCode();
                
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                
                if (this.BillingCompany != null)
                    hash = hash * 59 + this.BillingCompany.GetHashCode();
                
                if (this.Attention != null)
                    hash = hash * 59 + this.Attention.GetHashCode();
                
                if (this.Street1 != null)
                    hash = hash * 59 + this.Street1.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.Street3 != null)
                    hash = hash * 59 + this.Street3.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
