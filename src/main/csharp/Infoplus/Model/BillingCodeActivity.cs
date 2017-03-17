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
    public partial class BillingCodeActivity :  IEquatable<BillingCodeActivity>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeActivity" /> class.
        /// Initializes a new instance of the <see cref="BillingCodeActivity" />class.
        /// </summary>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="Email">Email.</param>
        /// <param name="BillingCodeTypeId">BillingCodeTypeId (required).</param>
        /// <param name="BillingCodeTypeName">BillingCodeTypeName.</param>
        /// <param name="Note">Note.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public BillingCodeActivity(int? Quantity = null, int? LobId = null, int? UserId = null, string Email = null, int? BillingCodeTypeId = null, string BillingCodeTypeName = null, string Note = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "BillingCodeTypeId" is required (not null)
            if (BillingCodeTypeId == null)
            {
                throw new InvalidDataException("BillingCodeTypeId is a required property for BillingCodeActivity and cannot be null");
            }
            else
            {
                this.BillingCodeTypeId = BillingCodeTypeId;
            }
            this.Email = Email;
            this.BillingCodeTypeName = BillingCodeTypeName;
            this.Note = Note;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets ImportedId
        /// </summary>
        [DataMember(Name="importedId", EmitDefaultValue=false)]
        public int? ImportedId { get; private set; }
    
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
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; private set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingCodeTypeId
        /// </summary>
        [DataMember(Name="billingCodeTypeId", EmitDefaultValue=false)]
        public int? BillingCodeTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingCodeTypeName
        /// </summary>
        [DataMember(Name="billingCodeTypeName", EmitDefaultValue=false)]
        public string BillingCodeTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingCodeActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImportedId: ").Append(ImportedId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BillingCodeTypeId: ").Append(BillingCodeTypeId).Append("\n");
            sb.Append("  BillingCodeTypeName: ").Append(BillingCodeTypeName).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            
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
            return this.Equals(obj as BillingCodeActivity);
        }

        /// <summary>
        /// Returns true if BillingCodeActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingCodeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingCodeActivity other)
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
                    this.ImportedId == other.ImportedId ||
                    this.ImportedId != null &&
                    this.ImportedId.Equals(other.ImportedId)
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
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.BillingCodeTypeId == other.BillingCodeTypeId ||
                    this.BillingCodeTypeId != null &&
                    this.BillingCodeTypeId.Equals(other.BillingCodeTypeId)
                ) && 
                (
                    this.BillingCodeTypeName == other.BillingCodeTypeName ||
                    this.BillingCodeTypeName != null &&
                    this.BillingCodeTypeName.Equals(other.BillingCodeTypeName)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                
                if (this.ImportedId != null)
                    hash = hash * 59 + this.ImportedId.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.BillingCodeTypeId != null)
                    hash = hash * 59 + this.BillingCodeTypeId.GetHashCode();
                
                if (this.BillingCodeTypeName != null)
                    hash = hash * 59 + this.BillingCodeTypeName.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
