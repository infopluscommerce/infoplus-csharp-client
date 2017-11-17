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
    public partial class GetOrderWarehouseFulfillmentDataInput :  IEquatable<GetOrderWarehouseFulfillmentDataInput>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderWarehouseFulfillmentDataInput" /> class.
        /// Initializes a new instance of the <see cref="GetOrderWarehouseFulfillmentDataInput" />class.
        /// </summary>

        public GetOrderWarehouseFulfillmentDataInput()
        {
            
        }
        
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public string OrderNo { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrderWarehouseFulfillmentDataInput {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            
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
            return this.Equals(obj as GetOrderWarehouseFulfillmentDataInput);
        }

        /// <summary>
        /// Returns true if GetOrderWarehouseFulfillmentDataInput instances are equal
        /// </summary>
        /// <param name="other">Instance of GetOrderWarehouseFulfillmentDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrderWarehouseFulfillmentDataInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
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
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                return hash;
            }
        }

    }
}
