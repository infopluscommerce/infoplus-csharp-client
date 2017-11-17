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
    public partial class OrderWarehouseFulfillmentPlan :  IEquatable<OrderWarehouseFulfillmentPlan>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentPlan" /> class.
        /// Initializes a new instance of the <see cref="OrderWarehouseFulfillmentPlan" />class.
        /// </summary>
        /// <param name="Score">Score.</param>
        /// <param name="PlanDetailList">PlanDetailList (required).</param>

        public OrderWarehouseFulfillmentPlan(int? Score = null, List<OrderWarehouseFulfillmentPlanDetail> PlanDetailList = null)
        {
            // to ensure "PlanDetailList" is required (not null)
            if (PlanDetailList == null)
            {
                throw new InvalidDataException("PlanDetailList is a required property for OrderWarehouseFulfillmentPlan and cannot be null");
            }
            else
            {
                this.PlanDetailList = PlanDetailList;
            }
            this.Score = Score;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int? Score { get; set; }
    
        /// <summary>
        /// Gets or Sets PlanDetailList
        /// </summary>
        [DataMember(Name="planDetailList", EmitDefaultValue=false)]
        public List<OrderWarehouseFulfillmentPlanDetail> PlanDetailList { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderWarehouseFulfillmentPlan {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  PlanDetailList: ").Append(PlanDetailList).Append("\n");
            
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
            return this.Equals(obj as OrderWarehouseFulfillmentPlan);
        }

        /// <summary>
        /// Returns true if OrderWarehouseFulfillmentPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderWarehouseFulfillmentPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderWarehouseFulfillmentPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.PlanDetailList == other.PlanDetailList ||
                    this.PlanDetailList != null &&
                    this.PlanDetailList.SequenceEqual(other.PlanDetailList)
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
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                if (this.PlanDetailList != null)
                    hash = hash * 59 + this.PlanDetailList.GetHashCode();
                
                return hash;
            }
        }

    }
}
