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
    public partial class OrderWarehouseFulfillmentPlanDetail :  IEquatable<OrderWarehouseFulfillmentPlanDetail>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentPlanDetail" /> class.
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentPlanDetail" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId.</param>
        /// <param name="CarrierCode">CarrierCode.</param>
        /// <param name="LineItemList">LineItemList.</param>

        public OrderWarehouseFulfillmentPlanDetail(int? WarehouseId = null, int? CarrierCode = null, List<string> LineItemList = null)
        {
            this.WarehouseId = WarehouseId;
            this.CarrierCode = CarrierCode;
            this.LineItemList = LineItemList;
            
        }
        
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierCode
        /// </summary>
        [DataMember(Name="carrierCode", EmitDefaultValue=false)]
        public int? CarrierCode { get; set; }
    
        /// <summary>
        /// Gets or Sets LineItemList
        /// </summary>
        [DataMember(Name="lineItemList", EmitDefaultValue=false)]
        public List<string> LineItemList { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderWarehouseFulfillmentPlanDetail {\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  LineItemList: ").Append(LineItemList).Append("\n");
            
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
            return this.Equals(obj as OrderWarehouseFulfillmentPlanDetail);
        }

        /// <summary>
        /// Returns true if OrderWarehouseFulfillmentPlanDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderWarehouseFulfillmentPlanDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderWarehouseFulfillmentPlanDetail other)
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
                    this.CarrierCode == other.CarrierCode ||
                    this.CarrierCode != null &&
                    this.CarrierCode.Equals(other.CarrierCode)
                ) && 
                (
                    this.LineItemList == other.LineItemList ||
                    this.LineItemList != null &&
                    this.LineItemList.SequenceEqual(other.LineItemList)
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
                
                if (this.CarrierCode != null)
                    hash = hash * 59 + this.CarrierCode.GetHashCode();
                
                if (this.LineItemList != null)
                    hash = hash * 59 + this.LineItemList.GetHashCode();
                
                return hash;
            }
        }

    }
}
