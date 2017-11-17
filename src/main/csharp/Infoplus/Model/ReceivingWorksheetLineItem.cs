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
    public partial class ReceivingWorksheetLineItem :  IEquatable<ReceivingWorksheetLineItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingWorksheetLineItem" /> class.
        /// Initializes a new instance of the <see cref="ReceivingWorksheetLineItem" />class.
        /// </summary>
        /// <param name="ReceivingQty">ReceivingQty (required).</param>
        /// <param name="UnitCode">UnitCode (required).</param>
        /// <param name="WrapCode">WrapCode (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap.</param>
        /// <param name="UnitsPerCase">UnitsPerCase.</param>
        /// <param name="CasesPerPallet">CasesPerPallet.</param>
        /// <param name="WeightPerWrap">WeightPerWrap (required).</param>
        /// <param name="WeightPerCase">WeightPerCase.</param>
        /// <param name="ProductionLot">ProductionLot.</param>
        /// <param name="RevisionDate">RevisionDate.</param>
        /// <param name="Origin">Origin.</param>
        /// <param name="CartonLength">CartonLength.</param>
        /// <param name="CartonWidth">CartonWidth.</param>
        /// <param name="CartonHeight">CartonHeight.</param>
        /// <param name="PutAwayPlans">PutAwayPlans.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ReceivingWorksheetLineItem(int? ReceivingQty = null, string UnitCode = null, string WrapCode = null, int? UnitsPerWrap = null, int? UnitsPerCase = null, int? CasesPerPallet = null, double? WeightPerWrap = null, double? WeightPerCase = null, string ProductionLot = null, string RevisionDate = null, string Origin = null, double? CartonLength = null, double? CartonWidth = null, double? CartonHeight = null, List<ReceivingWorksheetPutAwayPlan> PutAwayPlans = null, int? Quantity = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "ReceivingQty" is required (not null)
            if (ReceivingQty == null)
            {
                throw new InvalidDataException("ReceivingQty is a required property for ReceivingWorksheetLineItem and cannot be null");
            }
            else
            {
                this.ReceivingQty = ReceivingQty;
            }
            // to ensure "UnitCode" is required (not null)
            if (UnitCode == null)
            {
                throw new InvalidDataException("UnitCode is a required property for ReceivingWorksheetLineItem and cannot be null");
            }
            else
            {
                this.UnitCode = UnitCode;
            }
            // to ensure "WrapCode" is required (not null)
            if (WrapCode == null)
            {
                throw new InvalidDataException("WrapCode is a required property for ReceivingWorksheetLineItem and cannot be null");
            }
            else
            {
                this.WrapCode = WrapCode;
            }
            // to ensure "WeightPerWrap" is required (not null)
            if (WeightPerWrap == null)
            {
                throw new InvalidDataException("WeightPerWrap is a required property for ReceivingWorksheetLineItem and cannot be null");
            }
            else
            {
                this.WeightPerWrap = WeightPerWrap;
            }
            this.UnitsPerWrap = UnitsPerWrap;
            this.UnitsPerCase = UnitsPerCase;
            this.CasesPerPallet = CasesPerPallet;
            this.WeightPerCase = WeightPerCase;
            this.ProductionLot = ProductionLot;
            this.RevisionDate = RevisionDate;
            this.Origin = Origin;
            this.CartonLength = CartonLength;
            this.CartonWidth = CartonWidth;
            this.CartonHeight = CartonHeight;
            this.PutAwayPlans = PutAwayPlans;
            this.Quantity = Quantity;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }
    
        /// <summary>
        /// Gets or Sets FullDescription
        /// </summary>
        [DataMember(Name="fullDescription", EmitDefaultValue=false)]
        public string FullDescription { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderedQty
        /// </summary>
        [DataMember(Name="orderedQty", EmitDefaultValue=false)]
        public int? OrderedQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets PrevReceivedQty
        /// </summary>
        [DataMember(Name="prevReceivedQty", EmitDefaultValue=false)]
        public int? PrevReceivedQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnreceivedQty
        /// </summary>
        [DataMember(Name="unreceivedQty", EmitDefaultValue=false)]
        public int? UnreceivedQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets ReceivingQty
        /// </summary>
        [DataMember(Name="receivingQty", EmitDefaultValue=false)]
        public int? ReceivingQty { get; set; }
    
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
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightPerCase
        /// </summary>
        [DataMember(Name="weightPerCase", EmitDefaultValue=false)]
        public double? WeightPerCase { get; set; }
    
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
        /// Gets or Sets PutAwayPlans
        /// </summary>
        [DataMember(Name="putAwayPlans", EmitDefaultValue=false)]
        public List<ReceivingWorksheetPutAwayPlan> PutAwayPlans { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
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
            sb.Append("class ReceivingWorksheetLineItem {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  FullDescription: ").Append(FullDescription).Append("\n");
            sb.Append("  OrderedQty: ").Append(OrderedQty).Append("\n");
            sb.Append("  PrevReceivedQty: ").Append(PrevReceivedQty).Append("\n");
            sb.Append("  UnreceivedQty: ").Append(UnreceivedQty).Append("\n");
            sb.Append("  ReceivingQty: ").Append(ReceivingQty).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  UnitsPerCase: ").Append(UnitsPerCase).Append("\n");
            sb.Append("  CasesPerPallet: ").Append(CasesPerPallet).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  WeightPerCase: ").Append(WeightPerCase).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  RevisionDate: ").Append(RevisionDate).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  CartonLength: ").Append(CartonLength).Append("\n");
            sb.Append("  CartonWidth: ").Append(CartonWidth).Append("\n");
            sb.Append("  CartonHeight: ").Append(CartonHeight).Append("\n");
            sb.Append("  PutAwayPlans: ").Append(PutAwayPlans).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReceivingWorksheetLineItem);
        }

        /// <summary>
        /// Returns true if ReceivingWorksheetLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ReceivingWorksheetLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivingWorksheetLineItem other)
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
                    this.FullDescription == other.FullDescription ||
                    this.FullDescription != null &&
                    this.FullDescription.Equals(other.FullDescription)
                ) && 
                (
                    this.OrderedQty == other.OrderedQty ||
                    this.OrderedQty != null &&
                    this.OrderedQty.Equals(other.OrderedQty)
                ) && 
                (
                    this.PrevReceivedQty == other.PrevReceivedQty ||
                    this.PrevReceivedQty != null &&
                    this.PrevReceivedQty.Equals(other.PrevReceivedQty)
                ) && 
                (
                    this.UnreceivedQty == other.UnreceivedQty ||
                    this.UnreceivedQty != null &&
                    this.UnreceivedQty.Equals(other.UnreceivedQty)
                ) && 
                (
                    this.ReceivingQty == other.ReceivingQty ||
                    this.ReceivingQty != null &&
                    this.ReceivingQty.Equals(other.ReceivingQty)
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
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.WeightPerCase == other.WeightPerCase ||
                    this.WeightPerCase != null &&
                    this.WeightPerCase.Equals(other.WeightPerCase)
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
                    this.PutAwayPlans == other.PutAwayPlans ||
                    this.PutAwayPlans != null &&
                    this.PutAwayPlans.SequenceEqual(other.PutAwayPlans)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                
                if (this.FullDescription != null)
                    hash = hash * 59 + this.FullDescription.GetHashCode();
                
                if (this.OrderedQty != null)
                    hash = hash * 59 + this.OrderedQty.GetHashCode();
                
                if (this.PrevReceivedQty != null)
                    hash = hash * 59 + this.PrevReceivedQty.GetHashCode();
                
                if (this.UnreceivedQty != null)
                    hash = hash * 59 + this.UnreceivedQty.GetHashCode();
                
                if (this.ReceivingQty != null)
                    hash = hash * 59 + this.ReceivingQty.GetHashCode();
                
                if (this.UnitCode != null)
                    hash = hash * 59 + this.UnitCode.GetHashCode();
                
                if (this.WrapCode != null)
                    hash = hash * 59 + this.WrapCode.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.UnitsPerCase != null)
                    hash = hash * 59 + this.UnitsPerCase.GetHashCode();
                
                if (this.CasesPerPallet != null)
                    hash = hash * 59 + this.CasesPerPallet.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.WeightPerCase != null)
                    hash = hash * 59 + this.WeightPerCase.GetHashCode();
                
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
                
                if (this.PutAwayPlans != null)
                    hash = hash * 59 + this.PutAwayPlans.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
