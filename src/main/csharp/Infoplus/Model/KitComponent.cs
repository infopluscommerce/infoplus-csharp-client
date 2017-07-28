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
    public partial class KitComponent :  IEquatable<KitComponent>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KitComponent" /> class.
        /// Initializes a new instance of the <see cref="KitComponent" />class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="Instructions">Instructions.</param>
        /// <param name="AdditionalServices">AdditionalServices.</param>
        /// <param name="Critical">Critical (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public KitComponent(string Sku = null, int? Quantity = null, string Instructions = null, string AdditionalServices = null, string Critical = null, Dictionary<string, Object> CustomFields = null)
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
            // to ensure "Critical" is required (not null)
            if (Critical == null)
            {
                throw new InvalidDataException("Critical is a required property for KitComponent and cannot be null");
            }
            else
            {
                this.Critical = Critical;
            }
            this.Instructions = Instructions;
            this.AdditionalServices = AdditionalServices;
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as KitComponent);
        }

        /// <summary>
        /// Returns true if KitComponent instances are equal
        /// </summary>
        /// <param name="other">Instance of KitComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KitComponent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Instructions == other.Instructions ||
                    this.Instructions != null &&
                    this.Instructions.Equals(other.Instructions)
                ) && 
                (
                    this.AdditionalServices == other.AdditionalServices ||
                    this.AdditionalServices != null &&
                    this.AdditionalServices.Equals(other.AdditionalServices)
                ) && 
                (
                    this.Critical == other.Critical ||
                    this.Critical != null &&
                    this.Critical.Equals(other.Critical)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.Instructions != null)
                    hash = hash * 59 + this.Instructions.GetHashCode();
                
                if (this.AdditionalServices != null)
                    hash = hash * 59 + this.AdditionalServices.GetHashCode();
                
                if (this.Critical != null)
                    hash = hash * 59 + this.Critical.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
