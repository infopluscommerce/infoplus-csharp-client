/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
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
    /// JobOutput
    /// </summary>
    [DataContract]
    public partial class JobOutput :  IEquatable<JobOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobOutput" /> class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public JobOutput(string Sku = default(string), int? Quantity = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for JobOutput and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for JobOutput and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobOutput {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(input as JobOutput);
        }

        /// <summary>
        /// Returns true if JobOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of JobOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
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
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
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
