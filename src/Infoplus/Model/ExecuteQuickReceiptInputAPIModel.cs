/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v3.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Infoplus.Client.SwaggerDateConverter;

namespace Infoplus.Model
{
    /// <summary>
    /// ExecuteQuickReceiptInputAPIModel
    /// </summary>
    [DataContract]
    public partial class ExecuteQuickReceiptInputAPIModel :  IEquatable<ExecuteQuickReceiptInputAPIModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteQuickReceiptInputAPIModel" /> class.
        /// </summary>
        /// <param name="IdList">IdList.</param>
        public ExecuteQuickReceiptInputAPIModel(List<int?> IdList = default(List<int?>))
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
            sb.Append("class ExecuteQuickReceiptInputAPIModel {\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteQuickReceiptInputAPIModel);
        }

        /// <summary>
        /// Returns true if ExecuteQuickReceiptInputAPIModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteQuickReceiptInputAPIModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteQuickReceiptInputAPIModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdList == input.IdList ||
                    this.IdList != null &&
                    this.IdList.SequenceEqual(input.IdList)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IdList != null)
                    hashCode = hashCode * 59 + this.IdList.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
