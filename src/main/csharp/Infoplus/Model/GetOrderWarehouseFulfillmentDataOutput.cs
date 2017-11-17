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
    public partial class GetOrderWarehouseFulfillmentDataOutput :  IEquatable<GetOrderWarehouseFulfillmentDataOutput>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderWarehouseFulfillmentDataOutput" /> class.
        /// Initializes a new instance of the <see cref="GetOrderWarehouseFulfillmentDataOutput" />class.
        /// </summary>
        /// <param name="RawData">RawData (required).</param>
        /// <param name="PlanList">PlanList (required).</param>

        public GetOrderWarehouseFulfillmentDataOutput(Dictionary<string, OrderWarehouseFulfillmentRawData> RawData = null, List<OrderWarehouseFulfillmentPlan> PlanList = null)
        {
            // to ensure "RawData" is required (not null)
            if (RawData == null)
            {
                throw new InvalidDataException("RawData is a required property for GetOrderWarehouseFulfillmentDataOutput and cannot be null");
            }
            else
            {
                this.RawData = RawData;
            }
            // to ensure "PlanList" is required (not null)
            if (PlanList == null)
            {
                throw new InvalidDataException("PlanList is a required property for GetOrderWarehouseFulfillmentDataOutput and cannot be null");
            }
            else
            {
                this.PlanList = PlanList;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets RawData
        /// </summary>
        [DataMember(Name="rawData", EmitDefaultValue=false)]
        public Dictionary<string, OrderWarehouseFulfillmentRawData> RawData { get; set; }
    
        /// <summary>
        /// Gets or Sets PlanList
        /// </summary>
        [DataMember(Name="planList", EmitDefaultValue=false)]
        public List<OrderWarehouseFulfillmentPlan> PlanList { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrderWarehouseFulfillmentDataOutput {\n");
            sb.Append("  RawData: ").Append(RawData).Append("\n");
            sb.Append("  PlanList: ").Append(PlanList).Append("\n");
            
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
            return this.Equals(obj as GetOrderWarehouseFulfillmentDataOutput);
        }

        /// <summary>
        /// Returns true if GetOrderWarehouseFulfillmentDataOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of GetOrderWarehouseFulfillmentDataOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrderWarehouseFulfillmentDataOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RawData == other.RawData ||
                    this.RawData != null &&
                    this.RawData.SequenceEqual(other.RawData)
                ) && 
                (
                    this.PlanList == other.PlanList ||
                    this.PlanList != null &&
                    this.PlanList.SequenceEqual(other.PlanList)
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
                
                if (this.RawData != null)
                    hash = hash * 59 + this.RawData.GetHashCode();
                
                if (this.PlanList != null)
                    hash = hash * 59 + this.PlanList.GetHashCode();
                
                return hash;
            }
        }

    }
}
