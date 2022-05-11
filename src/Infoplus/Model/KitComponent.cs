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
    /// KitComponent
    /// </summary>
    [DataContract]
    public partial class KitComponent :  IEquatable<KitComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KitComponent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KitComponent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KitComponent" /> class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="Instructions">Instructions.</param>
        /// <param name="AdditionalServices">AdditionalServices.</param>
        /// <param name="Critical">Critical.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public KitComponent(string Sku = default(string), int? Quantity = default(int?), string Instructions = default(string), string AdditionalServices = default(string), string Critical = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for KitComponent and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for KitComponent and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.Instructions = Instructions;
            this.AdditionalServices = AdditionalServices;
            this.Critical = Critical;
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
        /// Gets or Sets Instructions
        /// </summary>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalServices
        /// </summary>
        [DataMember(Name="additionalServices", EmitDefaultValue=false)]
        public string AdditionalServices { get; set; }

        /// <summary>
        /// Gets or Sets Critical
        /// </summary>
        [DataMember(Name="critical", EmitDefaultValue=false)]
        public string Critical { get; set; }

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
            sb.Append("class KitComponent {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  AdditionalServices: ").Append(AdditionalServices).Append("\n");
            sb.Append("  Critical: ").Append(Critical).Append("\n");
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
            return this.Equals(input as KitComponent);
        }

        /// <summary>
        /// Returns true if KitComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of KitComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KitComponent input)
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
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
                ) && 
                (
                    this.AdditionalServices == input.AdditionalServices ||
                    (this.AdditionalServices != null &&
                    this.AdditionalServices.Equals(input.AdditionalServices))
                ) && 
                (
                    this.Critical == input.Critical ||
                    (this.Critical != null &&
                    this.Critical.Equals(input.Critical))
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
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.AdditionalServices != null)
                    hashCode = hashCode * 59 + this.AdditionalServices.GetHashCode();
                if (this.Critical != null)
                    hashCode = hashCode * 59 + this.Critical.GetHashCode();
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
