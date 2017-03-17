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
    public partial class Substitution :  IEquatable<Substitution>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Substitution" /> class.
        /// Initializes a new instance of the <see cref="Substitution" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="OrderSKUId">OrderSKUId (required).</param>
        /// <param name="SubstituteSKUId">SubstituteSKUId (required).</param>
        /// <param name="Period">Period (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="SubstitutionQuantity">SubstitutionQuantity (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Substitution(int? LobId = null, DateTime? CreateDate = null, DateTime? ModifyDate = null, int? OrderSKUId = null, int? SubstituteSKUId = null, string Period = null, string Type = null, double? SubstitutionQuantity = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Substitution and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "OrderSKUId" is required (not null)
            if (OrderSKUId == null)
            {
                throw new InvalidDataException("OrderSKUId is a required property for Substitution and cannot be null");
            }
            else
            {
                this.OrderSKUId = OrderSKUId;
            }
            // to ensure "SubstituteSKUId" is required (not null)
            if (SubstituteSKUId == null)
            {
                throw new InvalidDataException("SubstituteSKUId is a required property for Substitution and cannot be null");
            }
            else
            {
                this.SubstituteSKUId = SubstituteSKUId;
            }
            // to ensure "Period" is required (not null)
            if (Period == null)
            {
                throw new InvalidDataException("Period is a required property for Substitution and cannot be null");
            }
            else
            {
                this.Period = Period;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Substitution and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "SubstitutionQuantity" is required (not null)
            if (SubstitutionQuantity == null)
            {
                throw new InvalidDataException("SubstitutionQuantity is a required property for Substitution and cannot be null");
            }
            else
            {
                this.SubstitutionQuantity = SubstitutionQuantity;
            }
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderSKUId
        /// </summary>
        [DataMember(Name="orderSKUId", EmitDefaultValue=false)]
        public int? OrderSKUId { get; set; }
    
        /// <summary>
        /// Gets or Sets SubstituteSKUId
        /// </summary>
        [DataMember(Name="substituteSKUId", EmitDefaultValue=false)]
        public int? SubstituteSKUId { get; set; }
    
        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets SubstitutionQuantity
        /// </summary>
        [DataMember(Name="substitutionQuantity", EmitDefaultValue=false)]
        public double? SubstitutionQuantity { get; set; }
    
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
            sb.Append("class Substitution {\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderSKUId: ").Append(OrderSKUId).Append("\n");
            sb.Append("  SubstituteSKUId: ").Append(SubstituteSKUId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubstitutionQuantity: ").Append(SubstitutionQuantity).Append("\n");
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
            return this.Equals(obj as Substitution);
        }

        /// <summary>
        /// Returns true if Substitution instances are equal
        /// </summary>
        /// <param name="other">Instance of Substitution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Substitution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OrderSKUId == other.OrderSKUId ||
                    this.OrderSKUId != null &&
                    this.OrderSKUId.Equals(other.OrderSKUId)
                ) && 
                (
                    this.SubstituteSKUId == other.SubstituteSKUId ||
                    this.SubstituteSKUId != null &&
                    this.SubstituteSKUId.Equals(other.SubstituteSKUId)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SubstitutionQuantity == other.SubstitutionQuantity ||
                    this.SubstitutionQuantity != null &&
                    this.SubstitutionQuantity.Equals(other.SubstitutionQuantity)
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
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.OrderSKUId != null)
                    hash = hash * 59 + this.OrderSKUId.GetHashCode();
                
                if (this.SubstituteSKUId != null)
                    hash = hash * 59 + this.SubstituteSKUId.GetHashCode();
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SubstitutionQuantity != null)
                    hash = hash * 59 + this.SubstitutionQuantity.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
