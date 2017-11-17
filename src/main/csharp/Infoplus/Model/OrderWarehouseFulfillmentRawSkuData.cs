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
    public partial class OrderWarehouseFulfillmentRawSkuData :  IEquatable<OrderWarehouseFulfillmentRawSkuData>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentRawSkuData" /> class.
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentRawSkuData" />class.
        /// </summary>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="CanFulfill">CanFulfill (default to false).</param>

        public OrderWarehouseFulfillmentRawSkuData(int? Quantity = null, bool? CanFulfill = null)
        {
            this.Quantity = Quantity;
            // use default value if no "CanFulfill" provided
            if (CanFulfill == null)
            {
                this.CanFulfill = false;
            }
            else
            {
                this.CanFulfill = CanFulfill;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets CanFulfill
        /// </summary>
        [DataMember(Name="canFulfill", EmitDefaultValue=false)]
        public bool? CanFulfill { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderWarehouseFulfillmentRawSkuData {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CanFulfill: ").Append(CanFulfill).Append("\n");
            
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
            return this.Equals(obj as OrderWarehouseFulfillmentRawSkuData);
        }

        /// <summary>
        /// Returns true if OrderWarehouseFulfillmentRawSkuData instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderWarehouseFulfillmentRawSkuData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderWarehouseFulfillmentRawSkuData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.CanFulfill == other.CanFulfill ||
                    this.CanFulfill != null &&
                    this.CanFulfill.Equals(other.CanFulfill)
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
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.CanFulfill != null)
                    hash = hash * 59 + this.CanFulfill.GetHashCode();
                
                return hash;
            }
        }

    }
}
