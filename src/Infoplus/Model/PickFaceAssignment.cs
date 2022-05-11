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
    /// PickFaceAssignment
    /// </summary>
    [DataContract]
    public partial class PickFaceAssignment :  IEquatable<PickFaceAssignment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PickFaceAssignment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PickFaceAssignment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PickFaceAssignment" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="LocationId">LocationId (required).</param>
        /// <param name="ReplenishmentPoint">ReplenishmentPoint (required).</param>
        /// <param name="MaxQuantity">MaxQuantity (required).</param>
        /// <param name="Active">Active (required) (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>
        public PickFaceAssignment(int? WarehouseId = default(int?), int? LocationId = default(int?), int? ReplenishmentPoint = default(int?), int? MaxQuantity = default(int?), bool? Active = false, Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>), string Sku = default(string))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for PickFaceAssignment and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for PickFaceAssignment and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "ReplenishmentPoint" is required (not null)
            if (ReplenishmentPoint == null)
            {
                throw new InvalidDataException("ReplenishmentPoint is a required property for PickFaceAssignment and cannot be null");
            }
            else
            {
                this.ReplenishmentPoint = ReplenishmentPoint;
            }
            // to ensure "MaxQuantity" is required (not null)
            if (MaxQuantity == null)
            {
                throw new InvalidDataException("MaxQuantity is a required property for PickFaceAssignment and cannot be null");
            }
            else
            {
                this.MaxQuantity = MaxQuantity;
            }
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for PickFaceAssignment and cannot be null");
            }
            else
            {
                this.Active = Active;
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
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or Sets ReplenishmentPoint
        /// </summary>
        [DataMember(Name="replenishmentPoint", EmitDefaultValue=false)]
        public int? ReplenishmentPoint { get; set; }

        /// <summary>
        /// Gets or Sets MaxQuantity
        /// </summary>
        [DataMember(Name="maxQuantity", EmitDefaultValue=false)]
        public int? MaxQuantity { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

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
            sb.Append("class PickFaceAssignment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ReplenishmentPoint: ").Append(ReplenishmentPoint).Append("\n");
            sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PickFaceAssignment);
        }

        /// <summary>
        /// Returns true if PickFaceAssignment instances are equal
        /// </summary>
        /// <param name="input">Instance of PickFaceAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PickFaceAssignment input)
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
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.ReplenishmentPoint == input.ReplenishmentPoint ||
                    (this.ReplenishmentPoint != null &&
                    this.ReplenishmentPoint.Equals(input.ReplenishmentPoint))
                ) && 
                (
                    this.MaxQuantity == input.MaxQuantity ||
                    (this.MaxQuantity != null &&
                    this.MaxQuantity.Equals(input.MaxQuantity))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.ReplenishmentPoint != null)
                    hashCode = hashCode * 59 + this.ReplenishmentPoint.GetHashCode();
                if (this.MaxQuantity != null)
                    hashCode = hashCode * 59 + this.MaxQuantity.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
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
