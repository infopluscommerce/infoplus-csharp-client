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
    public partial class CartonContent :  IEquatable<CartonContent>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonContent" /> class.
        /// Initializes a new instance of the <see cref="CartonContent" />class.
        /// </summary>
        /// <param name="GroupOrderId">GroupOrderId.</param>
        /// <param name="OrderNo">OrderNo (required).</param>
        /// <param name="CartonNoId">CartonNoId (required).</param>
        /// <param name="LineItemId">LineItemId (required).</param>
        /// <param name="Location">Location.</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="QuantityScanned">QuantityScanned.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="ToteId">ToteId.</param>
        /// <param name="PickerId">PickerId.</param>
        /// <param name="Status">Status.</param>

        public CartonContent(double? GroupOrderId = null, double? OrderNo = null, int? CartonNoId = null, int? LineItemId = null, string Location = null, int? Quantity = null, int? QuantityScanned = null, DateTime? Completed = null, string ToteId = null, string PickerId = null, string Status = null)
        {
            // to ensure "OrderNo" is required (not null)
            if (OrderNo == null)
            {
                throw new InvalidDataException("OrderNo is a required property for CartonContent and cannot be null");
            }
            else
            {
                this.OrderNo = OrderNo;
            }
            // to ensure "CartonNoId" is required (not null)
            if (CartonNoId == null)
            {
                throw new InvalidDataException("CartonNoId is a required property for CartonContent and cannot be null");
            }
            else
            {
                this.CartonNoId = CartonNoId;
            }
            // to ensure "LineItemId" is required (not null)
            if (LineItemId == null)
            {
                throw new InvalidDataException("LineItemId is a required property for CartonContent and cannot be null");
            }
            else
            {
                this.LineItemId = LineItemId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for CartonContent and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.GroupOrderId = GroupOrderId;
            this.Location = Location;
            this.QuantityScanned = QuantityScanned;
            this.Completed = Completed;
            this.ToteId = ToteId;
            this.PickerId = PickerId;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets GroupOrderId
        /// </summary>
        [DataMember(Name="groupOrderId", EmitDefaultValue=false)]
        public double? GroupOrderId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonNoId
        /// </summary>
        [DataMember(Name="cartonNoId", EmitDefaultValue=false)]
        public int? CartonNoId { get; set; }
    
        /// <summary>
        /// Gets or Sets LineItemId
        /// </summary>
        [DataMember(Name="lineItemId", EmitDefaultValue=false)]
        public int? LineItemId { get; set; }
    
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets QuantityScanned
        /// </summary>
        [DataMember(Name="quantityScanned", EmitDefaultValue=false)]
        public int? QuantityScanned { get; set; }
    
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public DateTime? Completed { get; set; }
    
        /// <summary>
        /// Gets or Sets ToteId
        /// </summary>
        [DataMember(Name="toteId", EmitDefaultValue=false)]
        public string ToteId { get; set; }
    
        /// <summary>
        /// Gets or Sets PickerId
        /// </summary>
        [DataMember(Name="pickerId", EmitDefaultValue=false)]
        public string PickerId { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartonContent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupOrderId: ").Append(GroupOrderId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  CartonNoId: ").Append(CartonNoId).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityScanned: ").Append(QuantityScanned).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  ToteId: ").Append(ToteId).Append("\n");
            sb.Append("  PickerId: ").Append(PickerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as CartonContent);
        }

        /// <summary>
        /// Returns true if CartonContent instances are equal
        /// </summary>
        /// <param name="other">Instance of CartonContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartonContent other)
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
                    this.GroupOrderId == other.GroupOrderId ||
                    this.GroupOrderId != null &&
                    this.GroupOrderId.Equals(other.GroupOrderId)
                ) && 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.CartonNoId == other.CartonNoId ||
                    this.CartonNoId != null &&
                    this.CartonNoId.Equals(other.CartonNoId)
                ) && 
                (
                    this.LineItemId == other.LineItemId ||
                    this.LineItemId != null &&
                    this.LineItemId.Equals(other.LineItemId)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.QuantityScanned == other.QuantityScanned ||
                    this.QuantityScanned != null &&
                    this.QuantityScanned.Equals(other.QuantityScanned)
                ) && 
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
                ) && 
                (
                    this.ToteId == other.ToteId ||
                    this.ToteId != null &&
                    this.ToteId.Equals(other.ToteId)
                ) && 
                (
                    this.PickerId == other.PickerId ||
                    this.PickerId != null &&
                    this.PickerId.Equals(other.PickerId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.GroupOrderId != null)
                    hash = hash * 59 + this.GroupOrderId.GetHashCode();
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.CartonNoId != null)
                    hash = hash * 59 + this.CartonNoId.GetHashCode();
                
                if (this.LineItemId != null)
                    hash = hash * 59 + this.LineItemId.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.QuantityScanned != null)
                    hash = hash * 59 + this.QuantityScanned.GetHashCode();
                
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                
                if (this.ToteId != null)
                    hash = hash * 59 + this.ToteId.GetHashCode();
                
                if (this.PickerId != null)
                    hash = hash * 59 + this.PickerId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
