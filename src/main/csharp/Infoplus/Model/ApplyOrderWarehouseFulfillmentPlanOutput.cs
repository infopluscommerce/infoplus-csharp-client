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
    public partial class ApplyOrderWarehouseFulfillmentPlanOutput :  IEquatable<ApplyOrderWarehouseFulfillmentPlanOutput>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyOrderWarehouseFulfillmentPlanOutput" /> class.
        /// Initializes a new instance of the <see cref="ApplyOrderWarehouseFulfillmentPlanOutput" />class.
        /// </summary>
        /// <param name="OrderList">OrderList.</param>

        public ApplyOrderWarehouseFulfillmentPlanOutput(List<Order> OrderList = null)
        {
            this.OrderList = OrderList;
            
        }
        
    
        /// <summary>
        /// Gets or Sets OrderList
        /// </summary>
        [DataMember(Name="orderList", EmitDefaultValue=false)]
        public List<Order> OrderList { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyOrderWarehouseFulfillmentPlanOutput {\n");
            sb.Append("  OrderList: ").Append(OrderList).Append("\n");
            
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
            return this.Equals(obj as ApplyOrderWarehouseFulfillmentPlanOutput);
        }

        /// <summary>
        /// Returns true if ApplyOrderWarehouseFulfillmentPlanOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplyOrderWarehouseFulfillmentPlanOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyOrderWarehouseFulfillmentPlanOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderList == other.OrderList ||
                    this.OrderList != null &&
                    this.OrderList.SequenceEqual(other.OrderList)
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
                
                if (this.OrderList != null)
                    hash = hash * 59 + this.OrderList.GetHashCode();
                
                return hash;
            }
        }

    }
}
