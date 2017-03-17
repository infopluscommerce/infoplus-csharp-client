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
    public partial class QuickReceipt :  IEquatable<QuickReceipt>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickReceipt" /> class.
        /// Initializes a new instance of the <see cref="QuickReceipt" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="LocationId">LocationId (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="UnitCode">UnitCode (required).</param>
        /// <param name="WrapCode">WrapCode (required).</param>
        /// <param name="WeightPerWrap">WeightPerWrap (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap (required).</param>
        /// <param name="UnitsPerCase">UnitsPerCase.</param>
        /// <param name="CasesPerPallet">CasesPerPallet.</param>
        /// <param name="CaseWeight">CaseWeight.</param>
        /// <param name="ProductionLot">ProductionLot.</param>
        /// <param name="RevisionDate">RevisionDate.</param>
        /// <param name="Origin">Origin.</param>
        /// <param name="CartonLength">CartonLength.</param>
        /// <param name="CartonWidth">CartonWidth.</param>
        /// <param name="CartonHeight">CartonHeight.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="Sell">Sell.</param>
        /// <param name="PricingPer">PricingPer.</param>
        /// <param name="DockDate">DockDate.</param>
        /// <param name="ProductIdTag">ProductIdTag.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>

        public QuickReceipt(int? WarehouseId = null, int? LobId = null, int? LocationId = null, int? Quantity = null, int? VendorId = null, string Carrier = null, string UnitCode = null, string WrapCode = null, double? WeightPerWrap = null, int? UnitsPerWrap = null, int? UnitsPerCase = null, int? CasesPerPallet = null, double? CaseWeight = null, string ProductionLot = null, string RevisionDate = null, string Origin = null, double? CartonLength = null, double? CartonWidth = null, double? CartonHeight = null, double? Cost = null, double? Sell = null, string PricingPer = null, DateTime? DockDate = null, string ProductIdTag = null, Dictionary<string, Object> CustomFields = null, string Sku = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "UnitCode" is required (not null)
            if (UnitCode == null)
            {
                throw new InvalidDataException("UnitCode is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.UnitCode = UnitCode;
            }
            // to ensure "WrapCode" is required (not null)
            if (WrapCode == null)
            {
                throw new InvalidDataException("WrapCode is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.WrapCode = WrapCode;
            }
            // to ensure "WeightPerWrap" is required (not null)
            if (WeightPerWrap == null)
            {
                throw new InvalidDataException("WeightPerWrap is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.WeightPerWrap = WeightPerWrap;
            }
            // to ensure "UnitsPerWrap" is required (not null)
            if (UnitsPerWrap == null)
            {
                throw new InvalidDataException("UnitsPerWrap is a required property for QuickReceipt and cannot be null");
            }
            else
            {
                this.UnitsPerWrap = UnitsPerWrap;
            }
            this.VendorId = VendorId;
            this.Carrier = Carrier;
            this.UnitsPerCase = UnitsPerCase;
            this.CasesPerPallet = CasesPerPallet;
            this.CaseWeight = CaseWeight;
            this.ProductionLot = ProductionLot;
            this.RevisionDate = RevisionDate;
            this.Origin = Origin;
            this.CartonLength = CartonLength;
            this.CartonWidth = CartonWidth;
            this.CartonHeight = CartonHeight;
            this.Cost = Cost;
            this.Sell = Sell;
            this.PricingPer = PricingPer;
            this.DockDate = DockDate;
            this.ProductIdTag = ProductIdTag;
            this.CustomFields = CustomFields;
            this.Sku = Sku;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int? CreatedBy { get; private set; }
    
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
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
    
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnitCode
        /// </summary>
        [DataMember(Name="unitCode", EmitDefaultValue=false)]
        public string UnitCode { get; set; }
    
        /// <summary>
        /// Gets or Sets WrapCode
        /// </summary>
        [DataMember(Name="wrapCode", EmitDefaultValue=false)]
        public string WrapCode { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerWrap
        /// </summary>
        [DataMember(Name="unitsPerWrap", EmitDefaultValue=false)]
        public int? UnitsPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerCase
        /// </summary>
        [DataMember(Name="unitsPerCase", EmitDefaultValue=false)]
        public int? UnitsPerCase { get; set; }
    
        /// <summary>
        /// Gets or Sets CasesPerPallet
        /// </summary>
        [DataMember(Name="casesPerPallet", EmitDefaultValue=false)]
        public int? CasesPerPallet { get; set; }
    
        /// <summary>
        /// Gets or Sets CaseWeight
        /// </summary>
        [DataMember(Name="caseWeight", EmitDefaultValue=false)]
        public double? CaseWeight { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductionLot
        /// </summary>
        [DataMember(Name="productionLot", EmitDefaultValue=false)]
        public string ProductionLot { get; set; }
    
        /// <summary>
        /// Gets or Sets RevisionDate
        /// </summary>
        [DataMember(Name="revisionDate", EmitDefaultValue=false)]
        public string RevisionDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonLength
        /// </summary>
        [DataMember(Name="cartonLength", EmitDefaultValue=false)]
        public double? CartonLength { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonWidth
        /// </summary>
        [DataMember(Name="cartonWidth", EmitDefaultValue=false)]
        public double? CartonWidth { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonHeight
        /// </summary>
        [DataMember(Name="cartonHeight", EmitDefaultValue=false)]
        public double? CartonHeight { get; set; }
    
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }
    
        /// <summary>
        /// Gets or Sets Sell
        /// </summary>
        [DataMember(Name="sell", EmitDefaultValue=false)]
        public double? Sell { get; set; }
    
        /// <summary>
        /// Gets or Sets PricingPer
        /// </summary>
        [DataMember(Name="pricingPer", EmitDefaultValue=false)]
        public string PricingPer { get; set; }
    
        /// <summary>
        /// Gets or Sets GeneratedItemReceiptId
        /// </summary>
        [DataMember(Name="generatedItemReceiptId", EmitDefaultValue=false)]
        public int? GeneratedItemReceiptId { get; private set; }
    
        /// <summary>
        /// Gets or Sets GeneratedASNId
        /// </summary>
        [DataMember(Name="generatedASNId", EmitDefaultValue=false)]
        public int? GeneratedASNId { get; private set; }
    
        /// <summary>
        /// Gets or Sets DockDate
        /// </summary>
        [DataMember(Name="dockDate", EmitDefaultValue=false)]
        public DateTime? DockDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductIdTag
        /// </summary>
        [DataMember(Name="productIdTag", EmitDefaultValue=false)]
        public string ProductIdTag { get; set; }
    
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
            sb.Append("class QuickReceipt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  UnitsPerCase: ").Append(UnitsPerCase).Append("\n");
            sb.Append("  CasesPerPallet: ").Append(CasesPerPallet).Append("\n");
            sb.Append("  CaseWeight: ").Append(CaseWeight).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  RevisionDate: ").Append(RevisionDate).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  CartonLength: ").Append(CartonLength).Append("\n");
            sb.Append("  CartonWidth: ").Append(CartonWidth).Append("\n");
            sb.Append("  CartonHeight: ").Append(CartonHeight).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Sell: ").Append(Sell).Append("\n");
            sb.Append("  PricingPer: ").Append(PricingPer).Append("\n");
            sb.Append("  GeneratedItemReceiptId: ").Append(GeneratedItemReceiptId).Append("\n");
            sb.Append("  GeneratedASNId: ").Append(GeneratedASNId).Append("\n");
            sb.Append("  DockDate: ").Append(DockDate).Append("\n");
            sb.Append("  ProductIdTag: ").Append(ProductIdTag).Append("\n");
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
            return this.Equals(obj as QuickReceipt);
        }

        /// <summary>
        /// Returns true if QuickReceipt instances are equal
        /// </summary>
        /// <param name="other">Instance of QuickReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickReceipt other)
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
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
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
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UnitCode == other.UnitCode ||
                    this.UnitCode != null &&
                    this.UnitCode.Equals(other.UnitCode)
                ) && 
                (
                    this.WrapCode == other.WrapCode ||
                    this.WrapCode != null &&
                    this.WrapCode.Equals(other.WrapCode)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.UnitsPerWrap == other.UnitsPerWrap ||
                    this.UnitsPerWrap != null &&
                    this.UnitsPerWrap.Equals(other.UnitsPerWrap)
                ) && 
                (
                    this.UnitsPerCase == other.UnitsPerCase ||
                    this.UnitsPerCase != null &&
                    this.UnitsPerCase.Equals(other.UnitsPerCase)
                ) && 
                (
                    this.CasesPerPallet == other.CasesPerPallet ||
                    this.CasesPerPallet != null &&
                    this.CasesPerPallet.Equals(other.CasesPerPallet)
                ) && 
                (
                    this.CaseWeight == other.CaseWeight ||
                    this.CaseWeight != null &&
                    this.CaseWeight.Equals(other.CaseWeight)
                ) && 
                (
                    this.ProductionLot == other.ProductionLot ||
                    this.ProductionLot != null &&
                    this.ProductionLot.Equals(other.ProductionLot)
                ) && 
                (
                    this.RevisionDate == other.RevisionDate ||
                    this.RevisionDate != null &&
                    this.RevisionDate.Equals(other.RevisionDate)
                ) && 
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) && 
                (
                    this.CartonLength == other.CartonLength ||
                    this.CartonLength != null &&
                    this.CartonLength.Equals(other.CartonLength)
                ) && 
                (
                    this.CartonWidth == other.CartonWidth ||
                    this.CartonWidth != null &&
                    this.CartonWidth.Equals(other.CartonWidth)
                ) && 
                (
                    this.CartonHeight == other.CartonHeight ||
                    this.CartonHeight != null &&
                    this.CartonHeight.Equals(other.CartonHeight)
                ) && 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.Sell == other.Sell ||
                    this.Sell != null &&
                    this.Sell.Equals(other.Sell)
                ) && 
                (
                    this.PricingPer == other.PricingPer ||
                    this.PricingPer != null &&
                    this.PricingPer.Equals(other.PricingPer)
                ) && 
                (
                    this.GeneratedItemReceiptId == other.GeneratedItemReceiptId ||
                    this.GeneratedItemReceiptId != null &&
                    this.GeneratedItemReceiptId.Equals(other.GeneratedItemReceiptId)
                ) && 
                (
                    this.GeneratedASNId == other.GeneratedASNId ||
                    this.GeneratedASNId != null &&
                    this.GeneratedASNId.Equals(other.GeneratedASNId)
                ) && 
                (
                    this.DockDate == other.DockDate ||
                    this.DockDate != null &&
                    this.DockDate.Equals(other.DockDate)
                ) && 
                (
                    this.ProductIdTag == other.ProductIdTag ||
                    this.ProductIdTag != null &&
                    this.ProductIdTag.Equals(other.ProductIdTag)
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
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.UnitCode != null)
                    hash = hash * 59 + this.UnitCode.GetHashCode();
                
                if (this.WrapCode != null)
                    hash = hash * 59 + this.WrapCode.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.UnitsPerCase != null)
                    hash = hash * 59 + this.UnitsPerCase.GetHashCode();
                
                if (this.CasesPerPallet != null)
                    hash = hash * 59 + this.CasesPerPallet.GetHashCode();
                
                if (this.CaseWeight != null)
                    hash = hash * 59 + this.CaseWeight.GetHashCode();
                
                if (this.ProductionLot != null)
                    hash = hash * 59 + this.ProductionLot.GetHashCode();
                
                if (this.RevisionDate != null)
                    hash = hash * 59 + this.RevisionDate.GetHashCode();
                
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                
                if (this.CartonLength != null)
                    hash = hash * 59 + this.CartonLength.GetHashCode();
                
                if (this.CartonWidth != null)
                    hash = hash * 59 + this.CartonWidth.GetHashCode();
                
                if (this.CartonHeight != null)
                    hash = hash * 59 + this.CartonHeight.GetHashCode();
                
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                
                if (this.Sell != null)
                    hash = hash * 59 + this.Sell.GetHashCode();
                
                if (this.PricingPer != null)
                    hash = hash * 59 + this.PricingPer.GetHashCode();
                
                if (this.GeneratedItemReceiptId != null)
                    hash = hash * 59 + this.GeneratedItemReceiptId.GetHashCode();
                
                if (this.GeneratedASNId != null)
                    hash = hash * 59 + this.GeneratedASNId.GetHashCode();
                
                if (this.DockDate != null)
                    hash = hash * 59 + this.DockDate.GetHashCode();
                
                if (this.ProductIdTag != null)
                    hash = hash * 59 + this.ProductIdTag.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                return hash;
            }
        }

    }
}
