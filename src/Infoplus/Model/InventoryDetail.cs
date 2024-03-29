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
    /// InventoryDetail
    /// </summary>
    [DataContract]
    public partial class InventoryDetail :  IEquatable<InventoryDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InventoryDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryDetail" /> class.
        /// </summary>
        /// <param name="WarehouseLocationId">WarehouseLocationId (required).</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public InventoryDetail(int? WarehouseLocationId = default(int?), DateTime? CreateDate = default(DateTime?), DateTime? ModifyDate = default(DateTime?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "WarehouseLocationId" is required (not null)
            if (WarehouseLocationId == null)
            {
                throw new InvalidDataException("WarehouseLocationId is a required property for InventoryDetail and cannot be null");
            }
            else
            {
                this.WarehouseLocationId = WarehouseLocationId;
            }
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets WarehouseLocationId
        /// </summary>
        [DataMember(Name="warehouseLocationId", EmitDefaultValue=false)]
        public int? WarehouseLocationId { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; private set; }

        /// <summary>
        /// Gets or Sets OutstandingPickQuantity
        /// </summary>
        [DataMember(Name="outstandingPickQuantity", EmitDefaultValue=false)]
        public int? OutstandingPickQuantity { get; private set; }

        /// <summary>
        /// Gets or Sets DistributionDate
        /// </summary>
        [DataMember(Name="distributionDate", EmitDefaultValue=false)]
        public DateTime? DistributionDate { get; private set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; private set; }

        /// <summary>
        /// Gets or Sets QuantityPerInnerPack
        /// </summary>
        [DataMember(Name="quantityPerInnerPack", EmitDefaultValue=false)]
        public int? QuantityPerInnerPack { get; private set; }

        /// <summary>
        /// Gets or Sets QuantityPerCase
        /// </summary>
        [DataMember(Name="quantityPerCase", EmitDefaultValue=false)]
        public int? QuantityPerCase { get; private set; }

        /// <summary>
        /// Gets or Sets QuantityPerPallet
        /// </summary>
        [DataMember(Name="quantityPerPallet", EmitDefaultValue=false)]
        public int? QuantityPerPallet { get; private set; }

        /// <summary>
        /// Gets or Sets EstimatedInnerPacks
        /// </summary>
        [DataMember(Name="estimatedInnerPacks", EmitDefaultValue=false)]
        public int? EstimatedInnerPacks { get; private set; }

        /// <summary>
        /// Gets or Sets EstimatedCases
        /// </summary>
        [DataMember(Name="estimatedCases", EmitDefaultValue=false)]
        public int? EstimatedCases { get; private set; }

        /// <summary>
        /// Gets or Sets EstimatedPallets
        /// </summary>
        [DataMember(Name="estimatedPallets", EmitDefaultValue=false)]
        public int? EstimatedPallets { get; private set; }

        /// <summary>
        /// Gets or Sets UnitsPerWrap
        /// </summary>
        [DataMember(Name="unitsPerWrap", EmitDefaultValue=false)]
        public int? UnitsPerWrap { get; private set; }

        /// <summary>
        /// Gets or Sets RevisionDate
        /// </summary>
        [DataMember(Name="revisionDate", EmitDefaultValue=false)]
        public string RevisionDate { get; private set; }

        /// <summary>
        /// Gets or Sets ProductionLot
        /// </summary>
        [DataMember(Name="productionLot", EmitDefaultValue=false)]
        public string ProductionLot { get; private set; }

        /// <summary>
        /// Gets or Sets OldestReceiptDate
        /// </summary>
        [DataMember(Name="oldestReceiptDate", EmitDefaultValue=false)]
        public DateTime? OldestReceiptDate { get; private set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Gets or Sets PoNo
        /// </summary>
        [DataMember(Name="poNo", EmitDefaultValue=false)]
        public string PoNo { get; private set; }

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
            sb.Append("class InventoryDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseLocationId: ").Append(WarehouseLocationId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  OutstandingPickQuantity: ").Append(OutstandingPickQuantity).Append("\n");
            sb.Append("  DistributionDate: ").Append(DistributionDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  QuantityPerInnerPack: ").Append(QuantityPerInnerPack).Append("\n");
            sb.Append("  QuantityPerCase: ").Append(QuantityPerCase).Append("\n");
            sb.Append("  QuantityPerPallet: ").Append(QuantityPerPallet).Append("\n");
            sb.Append("  EstimatedInnerPacks: ").Append(EstimatedInnerPacks).Append("\n");
            sb.Append("  EstimatedCases: ").Append(EstimatedCases).Append("\n");
            sb.Append("  EstimatedPallets: ").Append(EstimatedPallets).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  RevisionDate: ").Append(RevisionDate).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  OldestReceiptDate: ").Append(OldestReceiptDate).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  PoNo: ").Append(PoNo).Append("\n");
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
            return this.Equals(input as InventoryDetail);
        }

        /// <summary>
        /// Returns true if InventoryDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryDetail input)
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
                    this.WarehouseLocationId == input.WarehouseLocationId ||
                    (this.WarehouseLocationId != null &&
                    this.WarehouseLocationId.Equals(input.WarehouseLocationId))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
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
                    this.OutstandingPickQuantity == input.OutstandingPickQuantity ||
                    (this.OutstandingPickQuantity != null &&
                    this.OutstandingPickQuantity.Equals(input.OutstandingPickQuantity))
                ) && 
                (
                    this.DistributionDate == input.DistributionDate ||
                    (this.DistributionDate != null &&
                    this.DistributionDate.Equals(input.DistributionDate))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.QuantityPerInnerPack == input.QuantityPerInnerPack ||
                    (this.QuantityPerInnerPack != null &&
                    this.QuantityPerInnerPack.Equals(input.QuantityPerInnerPack))
                ) && 
                (
                    this.QuantityPerCase == input.QuantityPerCase ||
                    (this.QuantityPerCase != null &&
                    this.QuantityPerCase.Equals(input.QuantityPerCase))
                ) && 
                (
                    this.QuantityPerPallet == input.QuantityPerPallet ||
                    (this.QuantityPerPallet != null &&
                    this.QuantityPerPallet.Equals(input.QuantityPerPallet))
                ) && 
                (
                    this.EstimatedInnerPacks == input.EstimatedInnerPacks ||
                    (this.EstimatedInnerPacks != null &&
                    this.EstimatedInnerPacks.Equals(input.EstimatedInnerPacks))
                ) && 
                (
                    this.EstimatedCases == input.EstimatedCases ||
                    (this.EstimatedCases != null &&
                    this.EstimatedCases.Equals(input.EstimatedCases))
                ) && 
                (
                    this.EstimatedPallets == input.EstimatedPallets ||
                    (this.EstimatedPallets != null &&
                    this.EstimatedPallets.Equals(input.EstimatedPallets))
                ) && 
                (
                    this.UnitsPerWrap == input.UnitsPerWrap ||
                    (this.UnitsPerWrap != null &&
                    this.UnitsPerWrap.Equals(input.UnitsPerWrap))
                ) && 
                (
                    this.RevisionDate == input.RevisionDate ||
                    (this.RevisionDate != null &&
                    this.RevisionDate.Equals(input.RevisionDate))
                ) && 
                (
                    this.ProductionLot == input.ProductionLot ||
                    (this.ProductionLot != null &&
                    this.ProductionLot.Equals(input.ProductionLot))
                ) && 
                (
                    this.OldestReceiptDate == input.OldestReceiptDate ||
                    (this.OldestReceiptDate != null &&
                    this.OldestReceiptDate.Equals(input.OldestReceiptDate))
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
                    this.PoNo == input.PoNo ||
                    (this.PoNo != null &&
                    this.PoNo.Equals(input.PoNo))
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
                if (this.WarehouseLocationId != null)
                    hashCode = hashCode * 59 + this.WarehouseLocationId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.OutstandingPickQuantity != null)
                    hashCode = hashCode * 59 + this.OutstandingPickQuantity.GetHashCode();
                if (this.DistributionDate != null)
                    hashCode = hashCode * 59 + this.DistributionDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.QuantityPerInnerPack != null)
                    hashCode = hashCode * 59 + this.QuantityPerInnerPack.GetHashCode();
                if (this.QuantityPerCase != null)
                    hashCode = hashCode * 59 + this.QuantityPerCase.GetHashCode();
                if (this.QuantityPerPallet != null)
                    hashCode = hashCode * 59 + this.QuantityPerPallet.GetHashCode();
                if (this.EstimatedInnerPacks != null)
                    hashCode = hashCode * 59 + this.EstimatedInnerPacks.GetHashCode();
                if (this.EstimatedCases != null)
                    hashCode = hashCode * 59 + this.EstimatedCases.GetHashCode();
                if (this.EstimatedPallets != null)
                    hashCode = hashCode * 59 + this.EstimatedPallets.GetHashCode();
                if (this.UnitsPerWrap != null)
                    hashCode = hashCode * 59 + this.UnitsPerWrap.GetHashCode();
                if (this.RevisionDate != null)
                    hashCode = hashCode * 59 + this.RevisionDate.GetHashCode();
                if (this.ProductionLot != null)
                    hashCode = hashCode * 59 + this.ProductionLot.GetHashCode();
                if (this.OldestReceiptDate != null)
                    hashCode = hashCode * 59 + this.OldestReceiptDate.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.PoNo != null)
                    hashCode = hashCode * 59 + this.PoNo.GetHashCode();
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
