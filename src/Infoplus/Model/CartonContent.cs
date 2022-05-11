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
    /// CartonContent
    /// </summary>
    [DataContract]
    public partial class CartonContent :  IEquatable<CartonContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CartonContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonContent" /> class.
        /// </summary>
        /// <param name="GroupOrderId">GroupOrderId.</param>
        /// <param name="OrderNo">OrderNo (required).</param>
        /// <param name="CartonId">CartonId (required).</param>
        /// <param name="LineItemId">LineItemId (required).</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="QuantityScanned">QuantityScanned.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="ToteId">ToteId.</param>
        /// <param name="PickerId">PickerId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public CartonContent(decimal? GroupOrderId = default(decimal?), decimal? OrderNo = default(decimal?), int? CartonId = default(int?), int? LineItemId = default(int?), string Sku = default(string), string Location = default(string), int? Quantity = default(int?), int? QuantityScanned = default(int?), DateTime? Completed = default(DateTime?), string ToteId = default(string), string PickerId = default(string), string Status = default(string), int? LobId = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
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
            // to ensure "CartonId" is required (not null)
            if (CartonId == null)
            {
                throw new InvalidDataException("CartonId is a required property for CartonContent and cannot be null");
            }
            else
            {
                this.CartonId = CartonId;
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
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for CartonContent and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            this.GroupOrderId = GroupOrderId;
            this.Sku = Sku;
            this.Location = Location;
            this.QuantityScanned = QuantityScanned;
            this.Completed = Completed;
            this.ToteId = ToteId;
            this.PickerId = PickerId;
            this.Status = Status;
            this.CustomFields = CustomFields;
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
        public decimal? GroupOrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public decimal? OrderNo { get; set; }

        /// <summary>
        /// Gets or Sets CartonNo
        /// </summary>
        [DataMember(Name="cartonNo", EmitDefaultValue=false)]
        public int? CartonNo { get; private set; }

        /// <summary>
        /// Gets or Sets CartonId
        /// </summary>
        [DataMember(Name="cartonId", EmitDefaultValue=false)]
        public int? CartonId { get; set; }

        /// <summary>
        /// Gets or Sets LineItemId
        /// </summary>
        [DataMember(Name="lineItemId", EmitDefaultValue=false)]
        public int? LineItemId { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

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
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

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
            sb.Append("class CartonContent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupOrderId: ").Append(GroupOrderId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  CartonNo: ").Append(CartonNo).Append("\n");
            sb.Append("  CartonId: ").Append(CartonId).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityScanned: ").Append(QuantityScanned).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  ToteId: ").Append(ToteId).Append("\n");
            sb.Append("  PickerId: ").Append(PickerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
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
            return this.Equals(input as CartonContent);
        }

        /// <summary>
        /// Returns true if CartonContent instances are equal
        /// </summary>
        /// <param name="input">Instance of CartonContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartonContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GroupOrderId == input.GroupOrderId ||
                    (this.GroupOrderId != null &&
                    this.GroupOrderId.Equals(input.GroupOrderId))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.CartonNo == input.CartonNo ||
                    (this.CartonNo != null &&
                    this.CartonNo.Equals(input.CartonNo))
                ) && 
                (
                    this.CartonId == input.CartonId ||
                    (this.CartonId != null &&
                    this.CartonId.Equals(input.CartonId))
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.QuantityScanned == input.QuantityScanned ||
                    (this.QuantityScanned != null &&
                    this.QuantityScanned.Equals(input.QuantityScanned))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.ToteId == input.ToteId ||
                    (this.ToteId != null &&
                    this.ToteId.Equals(input.ToteId))
                ) && 
                (
                    this.PickerId == input.PickerId ||
                    (this.PickerId != null &&
                    this.PickerId.Equals(input.PickerId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GroupOrderId != null)
                    hashCode = hashCode * 59 + this.GroupOrderId.GetHashCode();
                if (this.OrderNo != null)
                    hashCode = hashCode * 59 + this.OrderNo.GetHashCode();
                if (this.CartonNo != null)
                    hashCode = hashCode * 59 + this.CartonNo.GetHashCode();
                if (this.CartonId != null)
                    hashCode = hashCode * 59 + this.CartonId.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.QuantityScanned != null)
                    hashCode = hashCode * 59 + this.QuantityScanned.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.ToteId != null)
                    hashCode = hashCode * 59 + this.ToteId.GetHashCode();
                if (this.PickerId != null)
                    hashCode = hashCode * 59 + this.PickerId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
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
