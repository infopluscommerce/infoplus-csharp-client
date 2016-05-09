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
    public partial class Zone :  IEquatable<Zone>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Zone" /> class.
        /// Initializes a new instance of the <see cref="Zone" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Address">Address.</param>
        /// <param name="IsClimateControlled">IsClimateControlled (default to false).</param>
        /// <param name="IsFoodGrade">IsFoodGrade (default to false).</param>
        /// <param name="IsSecure">IsSecure (default to false).</param>
        /// <param name="IsFrozen">IsFrozen (default to false).</param>
        /// <param name="IsRefrigerated">IsRefrigerated (default to false).</param>

        public Zone(int? WarehouseId = null, string Name = null, string Address = null, bool? IsClimateControlled = null, bool? IsFoodGrade = null, bool? IsSecure = null, bool? IsFrozen = null, bool? IsRefrigerated = null, )
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Zone and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Zone and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Address = Address;
            // use default value if no "IsClimateControlled" provided
            if (IsClimateControlled == null)
            {
                this.IsClimateControlled = false;
            }
            else
            {
                this.IsClimateControlled = IsClimateControlled;
            }
            // use default value if no "IsFoodGrade" provided
            if (IsFoodGrade == null)
            {
                this.IsFoodGrade = false;
            }
            else
            {
                this.IsFoodGrade = IsFoodGrade;
            }
            // use default value if no "IsSecure" provided
            if (IsSecure == null)
            {
                this.IsSecure = false;
            }
            else
            {
                this.IsSecure = IsSecure;
            }
            // use default value if no "IsFrozen" provided
            if (IsFrozen == null)
            {
                this.IsFrozen = false;
            }
            else
            {
                this.IsFrozen = IsFrozen;
            }
            // use default value if no "IsRefrigerated" provided
            if (IsRefrigerated == null)
            {
                this.IsRefrigerated = false;
            }
            else
            {
                this.IsRefrigerated = IsRefrigerated;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets IsClimateControlled
        /// </summary>
        [DataMember(Name="isClimateControlled", EmitDefaultValue=false)]
        public bool? IsClimateControlled { get; set; }
    
        /// <summary>
        /// Gets or Sets IsFoodGrade
        /// </summary>
        [DataMember(Name="isFoodGrade", EmitDefaultValue=false)]
        public bool? IsFoodGrade { get; set; }
    
        /// <summary>
        /// Gets or Sets IsSecure
        /// </summary>
        [DataMember(Name="isSecure", EmitDefaultValue=false)]
        public bool? IsSecure { get; set; }
    
        /// <summary>
        /// Gets or Sets IsFrozen
        /// </summary>
        [DataMember(Name="isFrozen", EmitDefaultValue=false)]
        public bool? IsFrozen { get; set; }
    
        /// <summary>
        /// Gets or Sets IsRefrigerated
        /// </summary>
        [DataMember(Name="isRefrigerated", EmitDefaultValue=false)]
        public bool? IsRefrigerated { get; set; }
    
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
            sb.Append("class Zone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  IsClimateControlled: ").Append(IsClimateControlled).Append("\n");
            sb.Append("  IsFoodGrade: ").Append(IsFoodGrade).Append("\n");
            sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
            sb.Append("  IsFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  IsRefrigerated: ").Append(IsRefrigerated).Append("\n");
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
            return this.Equals(obj as Zone);
        }

        /// <summary>
        /// Returns true if Zone instances are equal
        /// </summary>
        /// <param name="other">Instance of Zone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Zone other)
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
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.IsClimateControlled == other.IsClimateControlled ||
                    this.IsClimateControlled != null &&
                    this.IsClimateControlled.Equals(other.IsClimateControlled)
                ) && 
                (
                    this.IsFoodGrade == other.IsFoodGrade ||
                    this.IsFoodGrade != null &&
                    this.IsFoodGrade.Equals(other.IsFoodGrade)
                ) && 
                (
                    this.IsSecure == other.IsSecure ||
                    this.IsSecure != null &&
                    this.IsSecure.Equals(other.IsSecure)
                ) && 
                (
                    this.IsFrozen == other.IsFrozen ||
                    this.IsFrozen != null &&
                    this.IsFrozen.Equals(other.IsFrozen)
                ) && 
                (
                    this.IsRefrigerated == other.IsRefrigerated ||
                    this.IsRefrigerated != null &&
                    this.IsRefrigerated.Equals(other.IsRefrigerated)
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
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.IsClimateControlled != null)
                    hash = hash * 59 + this.IsClimateControlled.GetHashCode();
                
                if (this.IsFoodGrade != null)
                    hash = hash * 59 + this.IsFoodGrade.GetHashCode();
                
                if (this.IsSecure != null)
                    hash = hash * 59 + this.IsSecure.GetHashCode();
                
                if (this.IsFrozen != null)
                    hash = hash * 59 + this.IsFrozen.GetHashCode();
                
                if (this.IsRefrigerated != null)
                    hash = hash * 59 + this.IsRefrigerated.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
