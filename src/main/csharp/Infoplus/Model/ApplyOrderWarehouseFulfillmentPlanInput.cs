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
    public partial class ApplyOrderWarehouseFulfillmentPlanInput :  IEquatable<ApplyOrderWarehouseFulfillmentPlanInput>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyOrderWarehouseFulfillmentPlanInput" /> class.
        /// Initializes a new instance of the <see cref="ApplyOrderWarehouseFulfillmentPlanInput" />class.
        /// </summary>
        /// <param name="Plan">Plan (required).</param>

        public ApplyOrderWarehouseFulfillmentPlanInput(OrderWarehouseFulfillmentPlan Plan = null)
        {
            // to ensure "Plan" is required (not null)
            if (Plan == null)
            {
                throw new InvalidDataException("Plan is a required property for ApplyOrderWarehouseFulfillmentPlanInput and cannot be null");
            }
            else
            {
                this.Plan = Plan;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public string OrderNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public OrderWarehouseFulfillmentPlan Plan { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyOrderWarehouseFulfillmentPlanInput {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            
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
            return this.Equals(obj as ApplyOrderWarehouseFulfillmentPlanInput);
        }

        /// <summary>
        /// Returns true if ApplyOrderWarehouseFulfillmentPlanInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplyOrderWarehouseFulfillmentPlanInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyOrderWarehouseFulfillmentPlanInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
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
                
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                
                return hash;
            }
        }

    }
}
