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
    public partial class OrderSourceReservation :  IEquatable<OrderSourceReservation>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSourceReservation" /> class.
        /// Initializes a new instance of the <see cref="OrderSourceReservation" />class.
        /// </summary>
        /// <param name="OrderSourceId">OrderSourceId (required).</param>
        /// <param name="ReservedQuantity">ReservedQuantity (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>

        public OrderSourceReservation(int? OrderSourceId = null, int? ReservedQuantity = null, Dictionary<string, Object> CustomFields = null, string Sku = null)
        {
            // to ensure "OrderSourceId" is required (not null)
            if (OrderSourceId == null)
            {
                throw new InvalidDataException("OrderSourceId is a required property for OrderSourceReservation and cannot be null");
            }
            else
            {
                this.OrderSourceId = OrderSourceId;
            }
            // to ensure "ReservedQuantity" is required (not null)
            if (ReservedQuantity == null)
            {
                throw new InvalidDataException("ReservedQuantity is a required property for OrderSourceReservation and cannot be null");
            }
            else
            {
                this.ReservedQuantity = ReservedQuantity;
            }
            this.CustomFields = CustomFields;
            this.Sku = Sku;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ReservedQuantity
        /// </summary>
        [DataMember(Name="reservedQuantity", EmitDefaultValue=false)]
        public int? ReservedQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderSourceReservation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ReservedQuantity: ").Append(ReservedQuantity).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            
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
            return this.Equals(obj as OrderSourceReservation);
        }

        /// <summary>
        /// Returns true if OrderSourceReservation instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderSourceReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderSourceReservation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OrderSourceId == other.OrderSourceId ||
                    this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(other.OrderSourceId)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.ReservedQuantity == other.ReservedQuantity ||
                    this.ReservedQuantity != null &&
                    this.ReservedQuantity.Equals(other.ReservedQuantity)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.OrderSourceId != null)
                    hash = hash * 59 + this.OrderSourceId.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.ReservedQuantity != null)
                    hash = hash * 59 + this.ReservedQuantity.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                return hash;
            }
        }

    }
}
