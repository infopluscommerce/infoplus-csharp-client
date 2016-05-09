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
    public partial class ParcelAccount :  IEquatable<ParcelAccount>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelAccount" /> class.
        /// Initializes a new instance of the <see cref="ParcelAccount" />class.
        /// </summary>
        /// <param name="Carrier">Carrier (required).</param>
        /// <param name="AccountNo">AccountNo (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="ManifestPartnerId">ManifestPartnerId (required).</param>

        public ParcelAccount(string Carrier = null, string AccountNo = null, string Name = null, string ManifestPartnerId = null)
        {
            // to ensure "Carrier" is required (not null)
            if (Carrier == null)
            {
                throw new InvalidDataException("Carrier is a required property for ParcelAccount and cannot be null");
            }
            else
            {
                this.Carrier = Carrier;
            }
            // to ensure "AccountNo" is required (not null)
            if (AccountNo == null)
            {
                throw new InvalidDataException("AccountNo is a required property for ParcelAccount and cannot be null");
            }
            else
            {
                this.AccountNo = AccountNo;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ParcelAccount and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ManifestPartnerId" is required (not null)
            if (ManifestPartnerId == null)
            {
                throw new InvalidDataException("ManifestPartnerId is a required property for ParcelAccount and cannot be null");
            }
            else
            {
                this.ManifestPartnerId = ManifestPartnerId;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
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
        /// Gets or Sets Client
        /// </summary>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public int? Client { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ManifestPartnerId
        /// </summary>
        [DataMember(Name="manifestPartnerId", EmitDefaultValue=false)]
        public string ManifestPartnerId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManifestPartnerId: ").Append(ManifestPartnerId).Append("\n");
            
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
            return this.Equals(obj as ParcelAccount);
        }

        /// <summary>
        /// Returns true if ParcelAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelAccount other)
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
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
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
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ManifestPartnerId == other.ManifestPartnerId ||
                    this.ManifestPartnerId != null &&
                    this.ManifestPartnerId.Equals(other.ManifestPartnerId)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.AccountNo != null)
                    hash = hash * 59 + this.AccountNo.GetHashCode();
                
                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ManifestPartnerId != null)
                    hash = hash * 59 + this.ManifestPartnerId.GetHashCode();
                
                return hash;
            }
        }

    }
}
