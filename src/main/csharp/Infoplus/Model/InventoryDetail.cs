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
    public partial class InventoryDetail :  IEquatable<InventoryDetail>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetail" /> class.
        /// Initializes a new instance of the <see cref="InventoryDetail" />class.
        /// </summary>
        /// <param name="WarehouseLocationId">WarehouseLocationId (required).</param>
        /// <param name="Sku">Sku.</param>

        public InventoryDetail(int? WarehouseLocationId = null, string Sku = null)
        {
            // to ensure "WarehouseLocationId" is required (not null)
            if (WarehouseLocationId == null)
            {
                throw new InvalidDataException("WarehouseLocationId is a required property for InventoryDetail and cannot be null");
            }
            else
            {
                this.WarehouseLocationId = WarehouseLocationId;
            }
            this.Sku = Sku;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationId
        /// </summary>
        [DataMember(Name="warehouseLocationId", EmitDefaultValue=false)]
        public int? WarehouseLocationId { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets DistributionDate
        /// </summary>
        [DataMember(Name="distributionDate", EmitDefaultValue=false)]
        public DateTime? DistributionDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerCase
        /// </summary>
        [DataMember(Name="unitsPerCase", EmitDefaultValue=false)]
        public int? UnitsPerCase { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerWrap
        /// </summary>
        [DataMember(Name="unitsPerWrap", EmitDefaultValue=false)]
        public int? UnitsPerWrap { get; private set; }
    
        /// <summary>
        /// Gets or Sets RevisionDate
        /// </summary>
        [DataMember(Name="revisionDate", EmitDefaultValue=false)]
        public string RevisionDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ProductionLot
        /// </summary>
        [DataMember(Name="productionLot", EmitDefaultValue=false)]
        public string ProductionLot { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }
    
        /// <summary>
        /// Gets or Sets PoNo
        /// </summary>
        [DataMember(Name="poNo", EmitDefaultValue=false)]
        public string PoNo { get; private set; }
    
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
            sb.Append("class InventoryDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseLocationId: ").Append(WarehouseLocationId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  DistributionDate: ").Append(DistributionDate).Append("\n");
            sb.Append("  UnitsPerCase: ").Append(UnitsPerCase).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  RevisionDate: ").Append(RevisionDate).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  PoNo: ").Append(PoNo).Append("\n");
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
            return this.Equals(obj as InventoryDetail);
        }

        /// <summary>
        /// Returns true if InventoryDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryDetail other)
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
                    this.WarehouseLocationId == other.WarehouseLocationId ||
                    this.WarehouseLocationId != null &&
                    this.WarehouseLocationId.Equals(other.WarehouseLocationId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.DistributionDate == other.DistributionDate ||
                    this.DistributionDate != null &&
                    this.DistributionDate.Equals(other.DistributionDate)
                ) && 
                (
                    this.UnitsPerCase == other.UnitsPerCase ||
                    this.UnitsPerCase != null &&
                    this.UnitsPerCase.Equals(other.UnitsPerCase)
                ) && 
                (
                    this.UnitsPerWrap == other.UnitsPerWrap ||
                    this.UnitsPerWrap != null &&
                    this.UnitsPerWrap.Equals(other.UnitsPerWrap)
                ) && 
                (
                    this.RevisionDate == other.RevisionDate ||
                    this.RevisionDate != null &&
                    this.RevisionDate.Equals(other.RevisionDate)
                ) && 
                (
                    this.ProductionLot == other.ProductionLot ||
                    this.ProductionLot != null &&
                    this.ProductionLot.Equals(other.ProductionLot)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.PoNo == other.PoNo ||
                    this.PoNo != null &&
                    this.PoNo.Equals(other.PoNo)
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
                
                if (this.WarehouseLocationId != null)
                    hash = hash * 59 + this.WarehouseLocationId.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.DistributionDate != null)
                    hash = hash * 59 + this.DistributionDate.GetHashCode();
                
                if (this.UnitsPerCase != null)
                    hash = hash * 59 + this.UnitsPerCase.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.RevisionDate != null)
                    hash = hash * 59 + this.RevisionDate.GetHashCode();
                
                if (this.ProductionLot != null)
                    hash = hash * 59 + this.ProductionLot.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.PoNo != null)
                    hash = hash * 59 + this.PoNo.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                return hash;
            }
        }

    }
}
