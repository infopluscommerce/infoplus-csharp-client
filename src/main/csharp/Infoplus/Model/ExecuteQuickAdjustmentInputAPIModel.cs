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
    public partial class ExecuteQuickAdjustmentInputAPIModel :  IEquatable<ExecuteQuickAdjustmentInputAPIModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteQuickAdjustmentInputAPIModel" /> class.
        /// Initializes a new instance of the <see cref="ExecuteQuickAdjustmentInputAPIModel" />class.
        /// </summary>
        /// <param name="IdList">IdList.</param>

        public ExecuteQuickAdjustmentInputAPIModel(List<int?> IdList = null)
        {
            this.IdList = IdList;
            
        }
        
    
        /// <summary>
        /// Gets or Sets IdList
        /// </summary>
        [DataMember(Name="idList", EmitDefaultValue=false)]
        public List<int?> IdList { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteQuickAdjustmentInputAPIModel {\n");
            sb.Append("  IdList: ").Append(IdList).Append("\n");
            
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
            return this.Equals(obj as ExecuteQuickAdjustmentInputAPIModel);
        }

        /// <summary>
        /// Returns true if ExecuteQuickAdjustmentInputAPIModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ExecuteQuickAdjustmentInputAPIModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteQuickAdjustmentInputAPIModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdList == other.IdList ||
                    this.IdList != null &&
                    this.IdList.SequenceEqual(other.IdList)
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
                
                if (this.IdList != null)
                    hash = hash * 59 + this.IdList.GetHashCode();
                
                return hash;
            }
        }

    }
}
