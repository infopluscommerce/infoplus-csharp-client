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
        /// <param name="AccountCode">AccountCode (required).</param>
        /// <param name="LowStockContact">LowStockContact (required).</param>
        /// <param name="MajorGroup">MajorGroup (required).</param>
        /// <param name="SubGroup">SubGroup (required).</param>
        /// <param name="ProductionCode">ProductionCode.</param>
        /// <param name="SummaryCode">SummaryCode (required).</param>

        public OrderLine(string AccountCode = null, string LowStockContact = null, string MajorGroup = null, string SubGroup = null, string ProductionCode = null, string SummaryCode = null)
        {
            // to ensure "AccountCode" is required (not null)
            if (AccountCode == null)
            {
                throw new InvalidDataException("AccountCode is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.AccountCode = AccountCode;
            }
            // to ensure "LowStockContact" is required (not null)
            if (LowStockContact == null)
            {
                throw new InvalidDataException("LowStockContact is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.LowStockContact = LowStockContact;
            }
            // to ensure "MajorGroup" is required (not null)
            if (MajorGroup == null)
            {
                throw new InvalidDataException("MajorGroup is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.MajorGroup = MajorGroup;
            }
            // to ensure "SubGroup" is required (not null)
            if (SubGroup == null)
            {
                throw new InvalidDataException("SubGroup is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.SubGroup = SubGroup;
            }
            // to ensure "SummaryCode" is required (not null)
            if (SummaryCode == null)
            {
                throw new InvalidDataException("SummaryCode is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.SummaryCode = SummaryCode;
            }
            this.ProductionCode = ProductionCode;
            
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
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }
    
        /// <summary>
        /// Gets or Sets LowStockContact
        /// </summary>
        [DataMember(Name="lowStockContact", EmitDefaultValue=false)]
        public string LowStockContact { get; set; }
    
        /// <summary>
        /// Gets or Sets MajorGroup
        /// </summary>
        [DataMember(Name="majorGroup", EmitDefaultValue=false)]
        public string MajorGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets SubGroup
        /// </summary>
        [DataMember(Name="subGroup", EmitDefaultValue=false)]
        public string SubGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductionCode
        /// </summary>
        [DataMember(Name="productionCode", EmitDefaultValue=false)]
        public string ProductionCode { get; set; }
    
        /// <summary>
        /// Gets or Sets SummaryCode
        /// </summary>
        [DataMember(Name="summaryCode", EmitDefaultValue=false)]
        public string SummaryCode { get; set; }
    
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
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  ExtendedSell: ").Append(ExtendedSell).Append("\n");
            sb.Append("  NcExtendedSell: ").Append(NcExtendedSell).Append("\n");
            sb.Append("  ItemWeight: ").Append(ItemWeight).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  LowStockContact: ").Append(LowStockContact).Append("\n");
            sb.Append("  MajorGroup: ").Append(MajorGroup).Append("\n");
            sb.Append("  SubGroup: ").Append(SubGroup).Append("\n");
            sb.Append("  ProductionCode: ").Append(ProductionCode).Append("\n");
            sb.Append("  SummaryCode: ").Append(SummaryCode).Append("\n");
            
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
                    this.AccountCode == other.AccountCode ||
                    this.AccountCode != null &&
                    this.AccountCode.Equals(other.AccountCode)
                ) && 
                (
                    this.LowStockContact == other.LowStockContact ||
                    this.LowStockContact != null &&
                    this.LowStockContact.Equals(other.LowStockContact)
                ) && 
                (
                    this.MajorGroup == other.MajorGroup ||
                    this.MajorGroup != null &&
                    this.MajorGroup.Equals(other.MajorGroup)
                ) && 
                (
                    this.SubGroup == other.SubGroup ||
                    this.SubGroup != null &&
                    this.SubGroup.Equals(other.SubGroup)
                ) && 
                (
                    this.ProductionCode == other.ProductionCode ||
                    this.ProductionCode != null &&
                    this.ProductionCode.Equals(other.ProductionCode)
                ) && 
                (
                    this.SummaryCode == other.SummaryCode ||
                    this.SummaryCode != null &&
                    this.SummaryCode.Equals(other.SummaryCode)
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
                
                if (this.ExtendedCost != null)
                    hash = hash * 59 + this.ExtendedCost.GetHashCode();
                
                if (this.ExtendedSell != null)
                    hash = hash * 59 + this.ExtendedSell.GetHashCode();
                
                if (this.NcExtendedSell != null)
                    hash = hash * 59 + this.NcExtendedSell.GetHashCode();
                
                if (this.ItemWeight != null)
                    hash = hash * 59 + this.ItemWeight.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.AccountCode != null)
                    hash = hash * 59 + this.AccountCode.GetHashCode();
                
                if (this.LowStockContact != null)
                    hash = hash * 59 + this.LowStockContact.GetHashCode();
                
                if (this.MajorGroup != null)
                    hash = hash * 59 + this.MajorGroup.GetHashCode();
                
                if (this.SubGroup != null)
                    hash = hash * 59 + this.SubGroup.GetHashCode();
                
                if (this.ProductionCode != null)
                    hash = hash * 59 + this.ProductionCode.GetHashCode();
                
                if (this.SummaryCode != null)
                    hash = hash * 59 + this.SummaryCode.GetHashCode();
                
                return hash;
            }
        }

    }
}
