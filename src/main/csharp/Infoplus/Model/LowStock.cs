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
    public partial class LowStock :  IEquatable<LowStock>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LowStock" /> class.
        /// Initializes a new instance of the <see cref="LowStock" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="Sku">Sku.</param>

        public LowStock(int? WarehouseId = null, string Sku = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for LowStock and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            this.Sku = Sku;
            
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
        /// Gets or Sets LowLevelDate
        /// </summary>
        [DataMember(Name="lowLevelDate", EmitDefaultValue=false)]
        public DateTime? LowLevelDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets LowStockMessage
        /// </summary>
        [DataMember(Name="lowStockMessage", EmitDefaultValue=false)]
        public string LowStockMessage { get; private set; }
    
        /// <summary>
        /// Gets or Sets PrintFlag
        /// </summary>
        [DataMember(Name="printFlag", EmitDefaultValue=false)]
        public string PrintFlag { get; private set; }
    
        /// <summary>
        /// Gets or Sets IsDelayed
        /// </summary>
        [DataMember(Name="isDelayed", EmitDefaultValue=false)]
        public bool? IsDelayed { get; private set; }
    
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
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LowStock {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LowLevelDate: ").Append(LowLevelDate).Append("\n");
            sb.Append("  LowStockMessage: ").Append(LowStockMessage).Append("\n");
            sb.Append("  PrintFlag: ").Append(PrintFlag).Append("\n");
            sb.Append("  IsDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            
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
            return this.Equals(obj as LowStock);
        }

        /// <summary>
        /// Returns true if LowStock instances are equal
        /// </summary>
        /// <param name="other">Instance of LowStock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LowStock other)
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
                    this.LowLevelDate == other.LowLevelDate ||
                    this.LowLevelDate != null &&
                    this.LowLevelDate.Equals(other.LowLevelDate)
                ) && 
                (
                    this.LowStockMessage == other.LowStockMessage ||
                    this.LowStockMessage != null &&
                    this.LowStockMessage.Equals(other.LowStockMessage)
                ) && 
                (
                    this.PrintFlag == other.PrintFlag ||
                    this.PrintFlag != null &&
                    this.PrintFlag.Equals(other.PrintFlag)
                ) && 
                (
                    this.IsDelayed == other.IsDelayed ||
                    this.IsDelayed != null &&
                    this.IsDelayed.Equals(other.IsDelayed)
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
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                
                if (this.LowLevelDate != null)
                    hash = hash * 59 + this.LowLevelDate.GetHashCode();
                
                if (this.LowStockMessage != null)
                    hash = hash * 59 + this.LowStockMessage.GetHashCode();
                
                if (this.PrintFlag != null)
                    hash = hash * 59 + this.PrintFlag.GetHashCode();
                
                if (this.IsDelayed != null)
                    hash = hash * 59 + this.IsDelayed.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                return hash;
            }
        }

    }
}
