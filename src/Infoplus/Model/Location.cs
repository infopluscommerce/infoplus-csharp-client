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
    /// Location
    /// </summary>
    [DataContract]
    public partial class Location :  IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Location() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="BuildingId">BuildingId.</param>
        /// <param name="ZoneId">ZoneId.</param>
        /// <param name="AisleId">AisleId.</param>
        /// <param name="BillingTypeId">BillingTypeId (required).</param>
        /// <param name="BehaviorType">BehaviorType (required).</param>
        /// <param name="FootprintId">FootprintId (required).</param>
        /// <param name="AddressSchemeId">AddressSchemeId.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Bay">Bay.</param>
        /// <param name="Number">Number.</param>
        /// <param name="Online">Online (required) (default to false).</param>
        /// <param name="PriorityCode">PriorityCode.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="AllowItemMixing">AllowItemMixing (required) (default to false).</param>
        /// <param name="ContentMixingRule">ContentMixingRule.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Location(int? WarehouseId = default(int?), int? BuildingId = default(int?), int? ZoneId = default(int?), int? AisleId = default(int?), int? BillingTypeId = default(int?), string BehaviorType = default(string), int? FootprintId = default(int?), int? AddressSchemeId = default(int?), string Address = default(string), int? Level = default(int?), int? Bay = default(int?), int? Number = default(int?), bool? Online = false, int? PriorityCode = default(int?), int? Cost = default(int?), bool? AllowItemMixing = false, string ContentMixingRule = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Location and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "BillingTypeId" is required (not null)
            if (BillingTypeId == null)
            {
                throw new InvalidDataException("BillingTypeId is a required property for Location and cannot be null");
            }
            else
            {
                this.BillingTypeId = BillingTypeId;
            }
            // to ensure "BehaviorType" is required (not null)
            if (BehaviorType == null)
            {
                throw new InvalidDataException("BehaviorType is a required property for Location and cannot be null");
            }
            else
            {
                this.BehaviorType = BehaviorType;
            }
            // to ensure "FootprintId" is required (not null)
            if (FootprintId == null)
            {
                throw new InvalidDataException("FootprintId is a required property for Location and cannot be null");
            }
            else
            {
                this.FootprintId = FootprintId;
            }
            // to ensure "Online" is required (not null)
            if (Online == null)
            {
                throw new InvalidDataException("Online is a required property for Location and cannot be null");
            }
            else
            {
                this.Online = Online;
            }
            // to ensure "AllowItemMixing" is required (not null)
            if (AllowItemMixing == null)
            {
                throw new InvalidDataException("AllowItemMixing is a required property for Location and cannot be null");
            }
            else
            {
                this.AllowItemMixing = AllowItemMixing;
            }
            this.BuildingId = BuildingId;
            this.ZoneId = ZoneId;
            this.AisleId = AisleId;
            this.AddressSchemeId = AddressSchemeId;
            this.Address = Address;
            this.Level = Level;
            this.Bay = Bay;
            this.Number = Number;
            this.PriorityCode = PriorityCode;
            this.Cost = Cost;
            this.ContentMixingRule = ContentMixingRule;
            this.CustomFields = CustomFields;
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
        /// Gets or Sets BuildingId
        /// </summary>
        [DataMember(Name="buildingId", EmitDefaultValue=false)]
        public int? BuildingId { get; set; }

        /// <summary>
        /// Gets or Sets ZoneId
        /// </summary>
        [DataMember(Name="zoneId", EmitDefaultValue=false)]
        public int? ZoneId { get; set; }

        /// <summary>
        /// Gets or Sets AisleId
        /// </summary>
        [DataMember(Name="aisleId", EmitDefaultValue=false)]
        public int? AisleId { get; set; }

        /// <summary>
        /// Gets or Sets BillingTypeId
        /// </summary>
        [DataMember(Name="billingTypeId", EmitDefaultValue=false)]
        public int? BillingTypeId { get; set; }

        /// <summary>
        /// Gets or Sets BehaviorType
        /// </summary>
        [DataMember(Name="behaviorType", EmitDefaultValue=false)]
        public string BehaviorType { get; set; }

        /// <summary>
        /// Gets or Sets FootprintId
        /// </summary>
        [DataMember(Name="footprintId", EmitDefaultValue=false)]
        public int? FootprintId { get; set; }

        /// <summary>
        /// Gets or Sets AddressSchemeId
        /// </summary>
        [DataMember(Name="addressSchemeId", EmitDefaultValue=false)]
        public int? AddressSchemeId { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public int? Origin { get; private set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public int? Level { get; set; }

        /// <summary>
        /// Gets or Sets Bay
        /// </summary>
        [DataMember(Name="bay", EmitDefaultValue=false)]
        public int? Bay { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or Sets Online
        /// </summary>
        [DataMember(Name="online", EmitDefaultValue=false)]
        public bool? Online { get; set; }

        /// <summary>
        /// Gets or Sets PriorityCode
        /// </summary>
        [DataMember(Name="priorityCode", EmitDefaultValue=false)]
        public int? PriorityCode { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public int? Cost { get; set; }

        /// <summary>
        /// Gets or Sets AllowItemMixing
        /// </summary>
        [DataMember(Name="allowItemMixing", EmitDefaultValue=false)]
        public bool? AllowItemMixing { get; set; }

        /// <summary>
        /// Gets or Sets ContentMixingRule
        /// </summary>
        [DataMember(Name="contentMixingRule", EmitDefaultValue=false)]
        public string ContentMixingRule { get; set; }

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
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; private set; }

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
            sb.Append("class Location {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  BuildingId: ").Append(BuildingId).Append("\n");
            sb.Append("  ZoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  AisleId: ").Append(AisleId).Append("\n");
            sb.Append("  BillingTypeId: ").Append(BillingTypeId).Append("\n");
            sb.Append("  BehaviorType: ").Append(BehaviorType).Append("\n");
            sb.Append("  FootprintId: ").Append(FootprintId).Append("\n");
            sb.Append("  AddressSchemeId: ").Append(AddressSchemeId).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Bay: ").Append(Bay).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  PriorityCode: ").Append(PriorityCode).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  AllowItemMixing: ").Append(AllowItemMixing).Append("\n");
            sb.Append("  ContentMixingRule: ").Append(ContentMixingRule).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
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
                    this.BuildingId == input.BuildingId ||
                    (this.BuildingId != null &&
                    this.BuildingId.Equals(input.BuildingId))
                ) && 
                (
                    this.ZoneId == input.ZoneId ||
                    (this.ZoneId != null &&
                    this.ZoneId.Equals(input.ZoneId))
                ) && 
                (
                    this.AisleId == input.AisleId ||
                    (this.AisleId != null &&
                    this.AisleId.Equals(input.AisleId))
                ) && 
                (
                    this.BillingTypeId == input.BillingTypeId ||
                    (this.BillingTypeId != null &&
                    this.BillingTypeId.Equals(input.BillingTypeId))
                ) && 
                (
                    this.BehaviorType == input.BehaviorType ||
                    (this.BehaviorType != null &&
                    this.BehaviorType.Equals(input.BehaviorType))
                ) && 
                (
                    this.FootprintId == input.FootprintId ||
                    (this.FootprintId != null &&
                    this.FootprintId.Equals(input.FootprintId))
                ) && 
                (
                    this.AddressSchemeId == input.AddressSchemeId ||
                    (this.AddressSchemeId != null &&
                    this.AddressSchemeId.Equals(input.AddressSchemeId))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Bay == input.Bay ||
                    (this.Bay != null &&
                    this.Bay.Equals(input.Bay))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
                ) && 
                (
                    this.PriorityCode == input.PriorityCode ||
                    (this.PriorityCode != null &&
                    this.PriorityCode.Equals(input.PriorityCode))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.AllowItemMixing == input.AllowItemMixing ||
                    (this.AllowItemMixing != null &&
                    this.AllowItemMixing.Equals(input.AllowItemMixing))
                ) && 
                (
                    this.ContentMixingRule == input.ContentMixingRule ||
                    (this.ContentMixingRule != null &&
                    this.ContentMixingRule.Equals(input.ContentMixingRule))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.BuildingId != null)
                    hashCode = hashCode * 59 + this.BuildingId.GetHashCode();
                if (this.ZoneId != null)
                    hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.AisleId != null)
                    hashCode = hashCode * 59 + this.AisleId.GetHashCode();
                if (this.BillingTypeId != null)
                    hashCode = hashCode * 59 + this.BillingTypeId.GetHashCode();
                if (this.BehaviorType != null)
                    hashCode = hashCode * 59 + this.BehaviorType.GetHashCode();
                if (this.FootprintId != null)
                    hashCode = hashCode * 59 + this.FootprintId.GetHashCode();
                if (this.AddressSchemeId != null)
                    hashCode = hashCode * 59 + this.AddressSchemeId.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Bay != null)
                    hashCode = hashCode * 59 + this.Bay.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.PriorityCode != null)
                    hashCode = hashCode * 59 + this.PriorityCode.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.AllowItemMixing != null)
                    hashCode = hashCode * 59 + this.AllowItemMixing.GetHashCode();
                if (this.ContentMixingRule != null)
                    hashCode = hashCode * 59 + this.ContentMixingRule.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
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
