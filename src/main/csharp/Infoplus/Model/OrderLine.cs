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
    public partial class OrderLine :  IEquatable<OrderLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine" /> class.
        /// Initializes a new instance of the <see cref="OrderLine" />class.
        /// </summary>
        /// <param name="OrderAssemblyInstructions">OrderAssemblyInstructions.</param>
        /// <param name="ItemAccountCodeId">ItemAccountCodeId (required).</param>
        /// <param name="ItemLegacyLowStockContactId">ItemLegacyLowStockContactId (required).</param>
        /// <param name="ItemMajorGroupId">ItemMajorGroupId (required).</param>
        /// <param name="ItemSubGroupId">ItemSubGroupId (required).</param>
        /// <param name="ItemProductCodeId">ItemProductCodeId.</param>
        /// <param name="ItemSummaryCodeId">ItemSummaryCodeId (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public OrderLine(string OrderAssemblyInstructions = null, int? ItemAccountCodeId = null, int? ItemLegacyLowStockContactId = null, int? ItemMajorGroupId = null, int? ItemSubGroupId = null, int? ItemProductCodeId = null, int? ItemSummaryCodeId = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "ItemAccountCodeId" is required (not null)
            if (ItemAccountCodeId == null)
            {
                throw new InvalidDataException("ItemAccountCodeId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemAccountCodeId = ItemAccountCodeId;
            }
            // to ensure "ItemLegacyLowStockContactId" is required (not null)
            if (ItemLegacyLowStockContactId == null)
            {
                throw new InvalidDataException("ItemLegacyLowStockContactId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemLegacyLowStockContactId = ItemLegacyLowStockContactId;
            }
            // to ensure "ItemMajorGroupId" is required (not null)
            if (ItemMajorGroupId == null)
            {
                throw new InvalidDataException("ItemMajorGroupId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemMajorGroupId = ItemMajorGroupId;
            }
            // to ensure "ItemSubGroupId" is required (not null)
            if (ItemSubGroupId == null)
            {
                throw new InvalidDataException("ItemSubGroupId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemSubGroupId = ItemSubGroupId;
            }
            // to ensure "ItemSummaryCodeId" is required (not null)
            if (ItemSummaryCodeId == null)
            {
                throw new InvalidDataException("ItemSummaryCodeId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemSummaryCodeId = ItemSummaryCodeId;
            }
            this.OrderAssemblyInstructions = OrderAssemblyInstructions;
            this.ItemProductCodeId = ItemProductCodeId;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; private set; }
    
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
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderedQty
        /// </summary>
        [DataMember(Name="orderedQty", EmitDefaultValue=false)]
        public int? OrderedQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets AllowedQty
        /// </summary>
        [DataMember(Name="allowedQty", EmitDefaultValue=false)]
        public int? AllowedQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShippedQty
        /// </summary>
        [DataMember(Name="shippedQty", EmitDefaultValue=false)]
        public int? ShippedQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets BackorderQty
        /// </summary>
        [DataMember(Name="backorderQty", EmitDefaultValue=false)]
        public int? BackorderQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets RevDate
        /// </summary>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ChargeCode
        /// </summary>
        [DataMember(Name="chargeCode", EmitDefaultValue=false)]
        public string ChargeCode { get; private set; }
    
        /// <summary>
        /// Gets or Sets DistributionCode
        /// </summary>
        [DataMember(Name="distributionCode", EmitDefaultValue=false)]
        public string DistributionCode { get; private set; }
    
        /// <summary>
        /// Gets or Sets Upc
        /// </summary>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; private set; }
    
        /// <summary>
        /// Gets or Sets VendorSKU
        /// </summary>
        [DataMember(Name="vendorSKU", EmitDefaultValue=false)]
        public string VendorSKU { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceSKU
        /// </summary>
        [DataMember(Name="orderSourceSKU", EmitDefaultValue=false)]
        public string OrderSourceSKU { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="unitCost", EmitDefaultValue=false)]
        public double? UnitCost { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnitSell
        /// </summary>
        [DataMember(Name="unitSell", EmitDefaultValue=false)]
        public double? UnitSell { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnitDiscount
        /// </summary>
        [DataMember(Name="unitDiscount", EmitDefaultValue=false)]
        public double? UnitDiscount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="extendedCost", EmitDefaultValue=false)]
        public double? ExtendedCost { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtendedSell
        /// </summary>
        [DataMember(Name="extendedSell", EmitDefaultValue=false)]
        public double? ExtendedSell { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtendedDiscount
        /// </summary>
        [DataMember(Name="extendedDiscount", EmitDefaultValue=false)]
        public double? ExtendedDiscount { get; private set; }
    
        /// <summary>
        /// Gets or Sets NcExtendedSell
        /// </summary>
        [DataMember(Name="ncExtendedSell", EmitDefaultValue=false)]
        public double? NcExtendedSell { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemWeight
        /// </summary>
        [DataMember(Name="itemWeight", EmitDefaultValue=false)]
        public double? ItemWeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets ProductionLot
        /// </summary>
        [DataMember(Name="productionLot", EmitDefaultValue=false)]
        public string ProductionLot { get; private set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; private set; }
    
        /// <summary>
        /// Gets or Sets Sector
        /// </summary>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderAssemblyInstructions
        /// </summary>
        [DataMember(Name="orderAssemblyInstructions", EmitDefaultValue=false)]
        public string OrderAssemblyInstructions { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemAccountCodeId
        /// </summary>
        [DataMember(Name="itemAccountCodeId", EmitDefaultValue=false)]
        public int? ItemAccountCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemLegacyLowStockContactId
        /// </summary>
        [DataMember(Name="itemLegacyLowStockContactId", EmitDefaultValue=false)]
        public int? ItemLegacyLowStockContactId { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemMajorGroupId
        /// </summary>
        [DataMember(Name="itemMajorGroupId", EmitDefaultValue=false)]
        public int? ItemMajorGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSubGroupId
        /// </summary>
        [DataMember(Name="itemSubGroupId", EmitDefaultValue=false)]
        public int? ItemSubGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemProductCodeId
        /// </summary>
        [DataMember(Name="itemProductCodeId", EmitDefaultValue=false)]
        public int? ItemProductCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSummaryCodeId
        /// </summary>
        [DataMember(Name="itemSummaryCodeId", EmitDefaultValue=false)]
        public int? ItemSummaryCodeId { get; set; }
    
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
            sb.Append("class OrderLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  OrderedQty: ").Append(OrderedQty).Append("\n");
            sb.Append("  AllowedQty: ").Append(AllowedQty).Append("\n");
            sb.Append("  ShippedQty: ").Append(ShippedQty).Append("\n");
            sb.Append("  BackorderQty: ").Append(BackorderQty).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
            sb.Append("  DistributionCode: ").Append(DistributionCode).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
            sb.Append("  OrderSourceSKU: ").Append(OrderSourceSKU).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitSell: ").Append(UnitSell).Append("\n");
            sb.Append("  UnitDiscount: ").Append(UnitDiscount).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  ExtendedSell: ").Append(ExtendedSell).Append("\n");
            sb.Append("  ExtendedDiscount: ").Append(ExtendedDiscount).Append("\n");
            sb.Append("  NcExtendedSell: ").Append(NcExtendedSell).Append("\n");
            sb.Append("  ItemWeight: ").Append(ItemWeight).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  OrderAssemblyInstructions: ").Append(OrderAssemblyInstructions).Append("\n");
            sb.Append("  ItemAccountCodeId: ").Append(ItemAccountCodeId).Append("\n");
            sb.Append("  ItemLegacyLowStockContactId: ").Append(ItemLegacyLowStockContactId).Append("\n");
            sb.Append("  ItemMajorGroupId: ").Append(ItemMajorGroupId).Append("\n");
            sb.Append("  ItemSubGroupId: ").Append(ItemSubGroupId).Append("\n");
            sb.Append("  ItemProductCodeId: ").Append(ItemProductCodeId).Append("\n");
            sb.Append("  ItemSummaryCodeId: ").Append(ItemSummaryCodeId).Append("\n");
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
            return this.Equals(obj as OrderLine);
        }

        /// <summary>
        /// Returns true if OrderLine instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLine other)
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
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.PoNoId == other.PoNoId ||
                    this.PoNoId != null &&
                    this.PoNoId.Equals(other.PoNoId)
                ) && 
                (
                    this.OrderedQty == other.OrderedQty ||
                    this.OrderedQty != null &&
                    this.OrderedQty.Equals(other.OrderedQty)
                ) && 
                (
                    this.AllowedQty == other.AllowedQty ||
                    this.AllowedQty != null &&
                    this.AllowedQty.Equals(other.AllowedQty)
                ) && 
                (
                    this.ShippedQty == other.ShippedQty ||
                    this.ShippedQty != null &&
                    this.ShippedQty.Equals(other.ShippedQty)
                ) && 
                (
                    this.BackorderQty == other.BackorderQty ||
                    this.BackorderQty != null &&
                    this.BackorderQty.Equals(other.BackorderQty)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
                (
                    this.ChargeCode == other.ChargeCode ||
                    this.ChargeCode != null &&
                    this.ChargeCode.Equals(other.ChargeCode)
                ) && 
                (
                    this.DistributionCode == other.DistributionCode ||
                    this.DistributionCode != null &&
                    this.DistributionCode.Equals(other.DistributionCode)
                ) && 
                (
                    this.Upc == other.Upc ||
                    this.Upc != null &&
                    this.Upc.Equals(other.Upc)
                ) && 
                (
                    this.VendorSKU == other.VendorSKU ||
                    this.VendorSKU != null &&
                    this.VendorSKU.Equals(other.VendorSKU)
                ) && 
                (
                    this.OrderSourceSKU == other.OrderSourceSKU ||
                    this.OrderSourceSKU != null &&
                    this.OrderSourceSKU.Equals(other.OrderSourceSKU)
                ) && 
                (
                    this.UnitCost == other.UnitCost ||
                    this.UnitCost != null &&
                    this.UnitCost.Equals(other.UnitCost)
                ) && 
                (
                    this.UnitSell == other.UnitSell ||
                    this.UnitSell != null &&
                    this.UnitSell.Equals(other.UnitSell)
                ) && 
                (
                    this.UnitDiscount == other.UnitDiscount ||
                    this.UnitDiscount != null &&
                    this.UnitDiscount.Equals(other.UnitDiscount)
                ) && 
                (
                    this.ExtendedCost == other.ExtendedCost ||
                    this.ExtendedCost != null &&
                    this.ExtendedCost.Equals(other.ExtendedCost)
                ) && 
                (
                    this.ExtendedSell == other.ExtendedSell ||
                    this.ExtendedSell != null &&
                    this.ExtendedSell.Equals(other.ExtendedSell)
                ) && 
                (
                    this.ExtendedDiscount == other.ExtendedDiscount ||
                    this.ExtendedDiscount != null &&
                    this.ExtendedDiscount.Equals(other.ExtendedDiscount)
                ) && 
                (
                    this.NcExtendedSell == other.NcExtendedSell ||
                    this.NcExtendedSell != null &&
                    this.NcExtendedSell.Equals(other.NcExtendedSell)
                ) && 
                (
                    this.ItemWeight == other.ItemWeight ||
                    this.ItemWeight != null &&
                    this.ItemWeight.Equals(other.ItemWeight)
                ) && 
                (
                    this.ProductionLot == other.ProductionLot ||
                    this.ProductionLot != null &&
                    this.ProductionLot.Equals(other.ProductionLot)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.Sector == other.Sector ||
                    this.Sector != null &&
                    this.Sector.Equals(other.Sector)
                ) && 
                (
                    this.OrderAssemblyInstructions == other.OrderAssemblyInstructions ||
                    this.OrderAssemblyInstructions != null &&
                    this.OrderAssemblyInstructions.Equals(other.OrderAssemblyInstructions)
                ) && 
                (
                    this.ItemAccountCodeId == other.ItemAccountCodeId ||
                    this.ItemAccountCodeId != null &&
                    this.ItemAccountCodeId.Equals(other.ItemAccountCodeId)
                ) && 
                (
                    this.ItemLegacyLowStockContactId == other.ItemLegacyLowStockContactId ||
                    this.ItemLegacyLowStockContactId != null &&
                    this.ItemLegacyLowStockContactId.Equals(other.ItemLegacyLowStockContactId)
                ) && 
                (
                    this.ItemMajorGroupId == other.ItemMajorGroupId ||
                    this.ItemMajorGroupId != null &&
                    this.ItemMajorGroupId.Equals(other.ItemMajorGroupId)
                ) && 
                (
                    this.ItemSubGroupId == other.ItemSubGroupId ||
                    this.ItemSubGroupId != null &&
                    this.ItemSubGroupId.Equals(other.ItemSubGroupId)
                ) && 
                (
                    this.ItemProductCodeId == other.ItemProductCodeId ||
                    this.ItemProductCodeId != null &&
                    this.ItemProductCodeId.Equals(other.ItemProductCodeId)
                ) && 
                (
                    this.ItemSummaryCodeId == other.ItemSummaryCodeId ||
                    this.ItemSummaryCodeId != null &&
                    this.ItemSummaryCodeId.Equals(other.ItemSummaryCodeId)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.PoNoId != null)
                    hash = hash * 59 + this.PoNoId.GetHashCode();
                
                if (this.OrderedQty != null)
                    hash = hash * 59 + this.OrderedQty.GetHashCode();
                
                if (this.AllowedQty != null)
                    hash = hash * 59 + this.AllowedQty.GetHashCode();
                
                if (this.ShippedQty != null)
                    hash = hash * 59 + this.ShippedQty.GetHashCode();
                
                if (this.BackorderQty != null)
                    hash = hash * 59 + this.BackorderQty.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
                if (this.ChargeCode != null)
                    hash = hash * 59 + this.ChargeCode.GetHashCode();
                
                if (this.DistributionCode != null)
                    hash = hash * 59 + this.DistributionCode.GetHashCode();
                
                if (this.Upc != null)
                    hash = hash * 59 + this.Upc.GetHashCode();
                
                if (this.VendorSKU != null)
                    hash = hash * 59 + this.VendorSKU.GetHashCode();
                
                if (this.OrderSourceSKU != null)
                    hash = hash * 59 + this.OrderSourceSKU.GetHashCode();
                
                if (this.UnitCost != null)
                    hash = hash * 59 + this.UnitCost.GetHashCode();
                
                if (this.UnitSell != null)
                    hash = hash * 59 + this.UnitSell.GetHashCode();
                
                if (this.UnitDiscount != null)
                    hash = hash * 59 + this.UnitDiscount.GetHashCode();
                
                if (this.ExtendedCost != null)
                    hash = hash * 59 + this.ExtendedCost.GetHashCode();
                
                if (this.ExtendedSell != null)
                    hash = hash * 59 + this.ExtendedSell.GetHashCode();
                
                if (this.ExtendedDiscount != null)
                    hash = hash * 59 + this.ExtendedDiscount.GetHashCode();
                
                if (this.NcExtendedSell != null)
                    hash = hash * 59 + this.NcExtendedSell.GetHashCode();
                
                if (this.ItemWeight != null)
                    hash = hash * 59 + this.ItemWeight.GetHashCode();
                
                if (this.ProductionLot != null)
                    hash = hash * 59 + this.ProductionLot.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.OrderAssemblyInstructions != null)
                    hash = hash * 59 + this.OrderAssemblyInstructions.GetHashCode();
                
                if (this.ItemAccountCodeId != null)
                    hash = hash * 59 + this.ItemAccountCodeId.GetHashCode();
                
                if (this.ItemLegacyLowStockContactId != null)
                    hash = hash * 59 + this.ItemLegacyLowStockContactId.GetHashCode();
                
                if (this.ItemMajorGroupId != null)
                    hash = hash * 59 + this.ItemMajorGroupId.GetHashCode();
                
                if (this.ItemSubGroupId != null)
                    hash = hash * 59 + this.ItemSubGroupId.GetHashCode();
                
                if (this.ItemProductCodeId != null)
                    hash = hash * 59 + this.ItemProductCodeId.GetHashCode();
                
                if (this.ItemSummaryCodeId != null)
                    hash = hash * 59 + this.ItemSummaryCodeId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
