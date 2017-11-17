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
    public partial class OrderWarehouseFulfillmentRawData :  IEquatable<OrderWarehouseFulfillmentRawData>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentRawData" /> class.
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentRawData" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId.</param>
        /// <param name="CanFulfill">CanFulfill (default to false).</param>
        /// <param name="SkuMap">SkuMap.</param>

        public OrderWarehouseFulfillmentRawData(int? WarehouseId = null, bool? CanFulfill = null, Dictionary<string, OrderWarehouseFulfillmentRawSkuData> SkuMap = null)
        {
            this.WarehouseId = WarehouseId;
            // use default value if no "CanFulfill" provided
            if (CanFulfill == null)
            {
                this.CanFulfill = false;
            }
            else
            {
                this.CanFulfill = CanFulfill;
            }
            this.SkuMap = SkuMap;
            
        }
        
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets CanFulfill
        /// </summary>
        [DataMember(Name="canFulfill", EmitDefaultValue=false)]
        public bool? CanFulfill { get; set; }
    
        /// <summary>
        /// Gets or Sets SkuMap
        /// </summary>
        [DataMember(Name="skuMap", EmitDefaultValue=false)]
        public Dictionary<string, OrderWarehouseFulfillmentRawSkuData> SkuMap { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderWarehouseFulfillmentRawData {\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  CanFulfill: ").Append(CanFulfill).Append("\n");
            sb.Append("  SkuMap: ").Append(SkuMap).Append("\n");
            
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
            return this.Equals(obj as OrderWarehouseFulfillmentRawData);
        }

        /// <summary>
        /// Returns true if OrderWarehouseFulfillmentRawData instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderWarehouseFulfillmentRawData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderWarehouseFulfillmentRawData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.CanFulfill == other.CanFulfill ||
                    this.CanFulfill != null &&
                    this.CanFulfill.Equals(other.CanFulfill)
                ) && 
                (
                    this.SkuMap == other.SkuMap ||
                    this.SkuMap != null &&
                    this.SkuMap.SequenceEqual(other.SkuMap)
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
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.CanFulfill != null)
                    hash = hash * 59 + this.CanFulfill.GetHashCode();
                
                if (this.SkuMap != null)
                    hash = hash * 59 + this.SkuMap.GetHashCode();
                
                return hash;
            }
        }

    }
}
