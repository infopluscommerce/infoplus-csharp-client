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
    public partial class ItemReceipt :  IEquatable<ItemReceipt>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReceipt" /> class.
        /// Initializes a new instance of the <see cref="ItemReceipt" />class.
        /// </summary>
        /// <param name="LegacyPoNo">LegacyPoNo.</param>
        /// <param name="OrderDate">OrderDate.</param>
        /// <param name="FullDescription">FullDescription.</param>
        /// <param name="FactCost">FactCost.</param>
        /// <param name="MlCost">MlCost.</param>
        /// <param name="OrderQuantity">OrderQuantity (required).</param>
        /// <param name="RequestedDeliveryDate">RequestedDeliveryDate (required).</param>
        /// <param name="UnitCode">UnitCode (required).</param>
        /// <param name="WrapCode">WrapCode (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap (required).</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="SellPrice">SellPrice.</param>
        /// <param name="PricingPer">PricingPer.</param>
        /// <param name="MaxFreight">MaxFreight.</param>
        /// <param name="ChargeFreight">ChargeFreight (required).</param>
        /// <param name="MaxOther">MaxOther.</param>
        /// <param name="DistDate">DistDate (required).</param>
        /// <param name="VoidDate">VoidDate.</param>
        /// <param name="FreezeAction">FreezeAction.</param>
        /// <param name="RevDate">RevDate.</param>
        /// <param name="ArtBack">ArtBack.</param>
        /// <param name="Origin">Origin.</param>
        /// <param name="Sample">Sample.</param>
        /// <param name="SampleTo">SampleTo.</param>
        /// <param name="MaxOvers">MaxOvers (required).</param>
        /// <param name="MaxUnders">MaxUnders (required).</param>
        /// <param name="ReceivedSfp">ReceivedSfp.</param>
        /// <param name="BudgetCode">BudgetCode.</param>
        /// <param name="AccountingCode">AccountingCode.</param>
        /// <param name="TaxExempt">TaxExempt.</param>
        /// <param name="Capitalize">Capitalize.</param>
        /// <param name="Accrual">Accrual.</param>
        /// <param name="OddQuantity">OddQuantity.</param>
        /// <param name="FreightCost">FreightCost.</param>
        /// <param name="ReceivedDate">ReceivedDate.</param>
        /// <param name="ReceivedQuantity">ReceivedQuantity.</param>
        /// <param name="FromProd">FromProd.</param>
        /// <param name="SfpComplete">SfpComplete.</param>
        /// <param name="EndQuantity">EndQuantity.</param>
        /// <param name="EndVal">EndVal.</param>
        /// <param name="EndFact">EndFact.</param>
        /// <param name="InterimQuantity">InterimQuantity.</param>
        /// <param name="InterimVal">InterimVal.</param>
        /// <param name="InterimFact">InterimFact.</param>
        /// <param name="LastAct">LastAct.</param>
        /// <param name="WeightPerWrap">WeightPerWrap.</param>
        /// <param name="Norcs">Norcs.</param>
        /// <param name="VendorId">VendorId (required).</param>
        /// <param name="BsVendor">BsVendor.</param>
        /// <param name="MlVendor">MlVendor.</param>
        /// <param name="ReceiptNo">ReceiptNo.</param>
        /// <param name="PaidFull">PaidFull.</param>
        /// <param name="EnteredBy">EnteredBy.</param>
        /// <param name="ReceivedBy">ReceivedBy.</param>
        /// <param name="LineNo">LineNo.</param>
        /// <param name="ProdLot">ProdLot.</param>
        /// <param name="ProductIdTag">ProductIdTag.</param>
        /// <param name="UnitsPerCase">UnitsPerCase.</param>
        /// <param name="CaseWeight">CaseWeight.</param>
        /// <param name="Height">Height.</param>
        /// <param name="Width">Width.</param>
        /// <param name="Length">Length.</param>
        /// <param name="DockDate">DockDate.</param>
        /// <param name="Impressions">Impressions.</param>
        /// <param name="AsnLine">AsnLine.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ItemReceipt(string LegacyPoNo = null, DateTime? OrderDate = null, string FullDescription = null, double? FactCost = null, double? MlCost = null, int? OrderQuantity = null, DateTime? RequestedDeliveryDate = null, string UnitCode = null, string WrapCode = null, int? UnitsPerWrap = null, double? Cost = null, double? SellPrice = null, string PricingPer = null, double? MaxFreight = null, string ChargeFreight = null, double? MaxOther = null, DateTime? DistDate = null, DateTime? VoidDate = null, string FreezeAction = null, string RevDate = null, string ArtBack = null, string Origin = null, int? Sample = null, string SampleTo = null, int? MaxOvers = null, int? MaxUnders = null, int? ReceivedSfp = null, string BudgetCode = null, string AccountingCode = null, string TaxExempt = null, string Capitalize = null, string Accrual = null, int? OddQuantity = null, double? FreightCost = null, DateTime? ReceivedDate = null, int? ReceivedQuantity = null, int? FromProd = null, string SfpComplete = null, int? EndQuantity = null, double? EndVal = null, double? EndFact = null, int? InterimQuantity = null, double? InterimVal = null, double? InterimFact = null, DateTime? LastAct = null, double? WeightPerWrap = null, string Norcs = null, int? VendorId = null, int? BsVendor = null, int? MlVendor = null, int? ReceiptNo = null, string PaidFull = null, string EnteredBy = null, string ReceivedBy = null, int? LineNo = null, string ProdLot = null, string ProductIdTag = null, int? UnitsPerCase = null, double? CaseWeight = null, double? Height = null, double? Width = null, double? Length = null, DateTime? DockDate = null, int? Impressions = null, int? AsnLine = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "OrderQuantity" is required (not null)
            if (OrderQuantity == null)
            {
                throw new InvalidDataException("OrderQuantity is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.OrderQuantity = OrderQuantity;
            }
            // to ensure "RequestedDeliveryDate" is required (not null)
            if (RequestedDeliveryDate == null)
            {
                throw new InvalidDataException("RequestedDeliveryDate is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.RequestedDeliveryDate = RequestedDeliveryDate;
            }
            // to ensure "UnitCode" is required (not null)
            if (UnitCode == null)
            {
                throw new InvalidDataException("UnitCode is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.UnitCode = UnitCode;
            }
            // to ensure "WrapCode" is required (not null)
            if (WrapCode == null)
            {
                throw new InvalidDataException("WrapCode is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.WrapCode = WrapCode;
            }
            // to ensure "UnitsPerWrap" is required (not null)
            if (UnitsPerWrap == null)
            {
                throw new InvalidDataException("UnitsPerWrap is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.UnitsPerWrap = UnitsPerWrap;
            }
            // to ensure "ChargeFreight" is required (not null)
            if (ChargeFreight == null)
            {
                throw new InvalidDataException("ChargeFreight is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.ChargeFreight = ChargeFreight;
            }
            // to ensure "DistDate" is required (not null)
            if (DistDate == null)
            {
                throw new InvalidDataException("DistDate is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.DistDate = DistDate;
            }
            // to ensure "MaxOvers" is required (not null)
            if (MaxOvers == null)
            {
                throw new InvalidDataException("MaxOvers is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.MaxOvers = MaxOvers;
            }
            // to ensure "MaxUnders" is required (not null)
            if (MaxUnders == null)
            {
                throw new InvalidDataException("MaxUnders is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.MaxUnders = MaxUnders;
            }
            // to ensure "VendorId" is required (not null)
            if (VendorId == null)
            {
                throw new InvalidDataException("VendorId is a required property for ItemReceipt and cannot be null");
            }
            else
            {
                this.VendorId = VendorId;
            }
            this.LegacyPoNo = LegacyPoNo;
            this.OrderDate = OrderDate;
            this.FullDescription = FullDescription;
            this.FactCost = FactCost;
            this.MlCost = MlCost;
            this.Cost = Cost;
            this.SellPrice = SellPrice;
            this.PricingPer = PricingPer;
            this.MaxFreight = MaxFreight;
            this.MaxOther = MaxOther;
            this.VoidDate = VoidDate;
            this.FreezeAction = FreezeAction;
            this.RevDate = RevDate;
            this.ArtBack = ArtBack;
            this.Origin = Origin;
            this.Sample = Sample;
            this.SampleTo = SampleTo;
            this.ReceivedSfp = ReceivedSfp;
            this.BudgetCode = BudgetCode;
            this.AccountingCode = AccountingCode;
            this.TaxExempt = TaxExempt;
            this.Capitalize = Capitalize;
            this.Accrual = Accrual;
            this.OddQuantity = OddQuantity;
            this.FreightCost = FreightCost;
            this.ReceivedDate = ReceivedDate;
            this.ReceivedQuantity = ReceivedQuantity;
            this.FromProd = FromProd;
            this.SfpComplete = SfpComplete;
            this.EndQuantity = EndQuantity;
            this.EndVal = EndVal;
            this.EndFact = EndFact;
            this.InterimQuantity = InterimQuantity;
            this.InterimVal = InterimVal;
            this.InterimFact = InterimFact;
            this.LastAct = LastAct;
            this.WeightPerWrap = WeightPerWrap;
            this.Norcs = Norcs;
            this.BsVendor = BsVendor;
            this.MlVendor = MlVendor;
            this.ReceiptNo = ReceiptNo;
            this.PaidFull = PaidFull;
            this.EnteredBy = EnteredBy;
            this.ReceivedBy = ReceivedBy;
            this.LineNo = LineNo;
            this.ProdLot = ProdLot;
            this.ProductIdTag = ProductIdTag;
            this.UnitsPerCase = UnitsPerCase;
            this.CaseWeight = CaseWeight;
            this.Height = Height;
            this.Width = Width;
            this.Length = Length;
            this.DockDate = DockDate;
            this.Impressions = Impressions;
            this.AsnLine = AsnLine;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }
    
        /// <summary>
        /// Gets or Sets LegacyPoNo
        /// </summary>
        [DataMember(Name="legacyPoNo", EmitDefaultValue=false)]
        public string LegacyPoNo { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }
    
        /// <summary>
        /// Gets or Sets FullDescription
        /// </summary>
        [DataMember(Name="fullDescription", EmitDefaultValue=false)]
        public string FullDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets FactCost
        /// </summary>
        [DataMember(Name="factCost", EmitDefaultValue=false)]
        public double? FactCost { get; set; }
    
        /// <summary>
        /// Gets or Sets MlCost
        /// </summary>
        [DataMember(Name="mlCost", EmitDefaultValue=false)]
        public double? MlCost { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderQuantity
        /// </summary>
        [DataMember(Name="orderQuantity", EmitDefaultValue=false)]
        public int? OrderQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets RequestedDeliveryDate
        /// </summary>
        [DataMember(Name="requestedDeliveryDate", EmitDefaultValue=false)]
        public DateTime? RequestedDeliveryDate { get; set; }
    
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
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }
    
        /// <summary>
        /// Gets or Sets SellPrice
        /// </summary>
        [DataMember(Name="sellPrice", EmitDefaultValue=false)]
        public double? SellPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets PricingPer
        /// </summary>
        [DataMember(Name="pricingPer", EmitDefaultValue=false)]
        public string PricingPer { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxFreight
        /// </summary>
        [DataMember(Name="maxFreight", EmitDefaultValue=false)]
        public double? MaxFreight { get; set; }
    
        /// <summary>
        /// Gets or Sets ChargeFreight
        /// </summary>
        [DataMember(Name="chargeFreight", EmitDefaultValue=false)]
        public string ChargeFreight { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxOther
        /// </summary>
        [DataMember(Name="maxOther", EmitDefaultValue=false)]
        public double? MaxOther { get; set; }
    
        /// <summary>
        /// Gets or Sets DistDate
        /// </summary>
        [DataMember(Name="distDate", EmitDefaultValue=false)]
        public DateTime? DistDate { get; set; }
    
        /// <summary>
        /// Gets or Sets VoidDate
        /// </summary>
        [DataMember(Name="voidDate", EmitDefaultValue=false)]
        public DateTime? VoidDate { get; set; }
    
        /// <summary>
        /// Gets or Sets FreezeAction
        /// </summary>
        [DataMember(Name="freezeAction", EmitDefaultValue=false)]
        public string FreezeAction { get; set; }
    
        /// <summary>
        /// Gets or Sets RevDate
        /// </summary>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ArtBack
        /// </summary>
        [DataMember(Name="artBack", EmitDefaultValue=false)]
        public string ArtBack { get; set; }
    
        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }
    
        /// <summary>
        /// Gets or Sets Sample
        /// </summary>
        [DataMember(Name="sample", EmitDefaultValue=false)]
        public int? Sample { get; set; }
    
        /// <summary>
        /// Gets or Sets SampleTo
        /// </summary>
        [DataMember(Name="sampleTo", EmitDefaultValue=false)]
        public string SampleTo { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxOvers
        /// </summary>
        [DataMember(Name="maxOvers", EmitDefaultValue=false)]
        public int? MaxOvers { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxUnders
        /// </summary>
        [DataMember(Name="maxUnders", EmitDefaultValue=false)]
        public int? MaxUnders { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceivedSfp
        /// </summary>
        [DataMember(Name="receivedSfp", EmitDefaultValue=false)]
        public int? ReceivedSfp { get; set; }
    
        /// <summary>
        /// Gets or Sets BudgetCode
        /// </summary>
        [DataMember(Name="budgetCode", EmitDefaultValue=false)]
        public string BudgetCode { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountingCode
        /// </summary>
        [DataMember(Name="accountingCode", EmitDefaultValue=false)]
        public string AccountingCode { get; set; }
    
        /// <summary>
        /// Gets or Sets TaxExempt
        /// </summary>
        [DataMember(Name="taxExempt", EmitDefaultValue=false)]
        public string TaxExempt { get; set; }
    
        /// <summary>
        /// Gets or Sets Capitalize
        /// </summary>
        [DataMember(Name="capitalize", EmitDefaultValue=false)]
        public string Capitalize { get; set; }
    
        /// <summary>
        /// Gets or Sets Accrual
        /// </summary>
        [DataMember(Name="accrual", EmitDefaultValue=false)]
        public string Accrual { get; set; }
    
        /// <summary>
        /// Gets or Sets OddQuantity
        /// </summary>
        [DataMember(Name="oddQuantity", EmitDefaultValue=false)]
        public int? OddQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets FreightCost
        /// </summary>
        [DataMember(Name="freightCost", EmitDefaultValue=false)]
        public double? FreightCost { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceivedDate
        /// </summary>
        [DataMember(Name="receivedDate", EmitDefaultValue=false)]
        public DateTime? ReceivedDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceivedQuantity
        /// </summary>
        [DataMember(Name="receivedQuantity", EmitDefaultValue=false)]
        public int? ReceivedQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets FromProd
        /// </summary>
        [DataMember(Name="fromProd", EmitDefaultValue=false)]
        public int? FromProd { get; set; }
    
        /// <summary>
        /// Gets or Sets SfpComplete
        /// </summary>
        [DataMember(Name="sfpComplete", EmitDefaultValue=false)]
        public string SfpComplete { get; set; }
    
        /// <summary>
        /// Gets or Sets EndQuantity
        /// </summary>
        [DataMember(Name="endQuantity", EmitDefaultValue=false)]
        public int? EndQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets EndVal
        /// </summary>
        [DataMember(Name="endVal", EmitDefaultValue=false)]
        public double? EndVal { get; set; }
    
        /// <summary>
        /// Gets or Sets EndFact
        /// </summary>
        [DataMember(Name="endFact", EmitDefaultValue=false)]
        public double? EndFact { get; set; }
    
        /// <summary>
        /// Gets or Sets InterimQuantity
        /// </summary>
        [DataMember(Name="interimQuantity", EmitDefaultValue=false)]
        public int? InterimQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets InterimVal
        /// </summary>
        [DataMember(Name="interimVal", EmitDefaultValue=false)]
        public double? InterimVal { get; set; }
    
        /// <summary>
        /// Gets or Sets InterimFact
        /// </summary>
        [DataMember(Name="interimFact", EmitDefaultValue=false)]
        public double? InterimFact { get; set; }
    
        /// <summary>
        /// Gets or Sets LastAct
        /// </summary>
        [DataMember(Name="lastAct", EmitDefaultValue=false)]
        public DateTime? LastAct { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets Norcs
        /// </summary>
        [DataMember(Name="norcs", EmitDefaultValue=false)]
        public string Norcs { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
    
        /// <summary>
        /// Gets or Sets BsVendor
        /// </summary>
        [DataMember(Name="bsVendor", EmitDefaultValue=false)]
        public int? BsVendor { get; set; }
    
        /// <summary>
        /// Gets or Sets MlVendor
        /// </summary>
        [DataMember(Name="mlVendor", EmitDefaultValue=false)]
        public int? MlVendor { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptNo
        /// </summary>
        [DataMember(Name="receiptNo", EmitDefaultValue=false)]
        public int? ReceiptNo { get; set; }
    
        /// <summary>
        /// Gets or Sets PaidFull
        /// </summary>
        [DataMember(Name="paidFull", EmitDefaultValue=false)]
        public string PaidFull { get; set; }
    
        /// <summary>
        /// Gets or Sets EnteredBy
        /// </summary>
        [DataMember(Name="enteredBy", EmitDefaultValue=false)]
        public string EnteredBy { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceivedBy
        /// </summary>
        [DataMember(Name="receivedBy", EmitDefaultValue=false)]
        public string ReceivedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets LineNo
        /// </summary>
        [DataMember(Name="lineNo", EmitDefaultValue=false)]
        public int? LineNo { get; set; }
    
        /// <summary>
        /// Gets or Sets ProdLot
        /// </summary>
        [DataMember(Name="prodLot", EmitDefaultValue=false)]
        public string ProdLot { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductIdTag
        /// </summary>
        [DataMember(Name="productIdTag", EmitDefaultValue=false)]
        public string ProductIdTag { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerCase
        /// </summary>
        [DataMember(Name="unitsPerCase", EmitDefaultValue=false)]
        public int? UnitsPerCase { get; set; }
    
        /// <summary>
        /// Gets or Sets CaseWeight
        /// </summary>
        [DataMember(Name="caseWeight", EmitDefaultValue=false)]
        public double? CaseWeight { get; set; }
    
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }
    
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }
    
        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public double? Length { get; set; }
    
        /// <summary>
        /// Gets or Sets DockDate
        /// </summary>
        [DataMember(Name="dockDate", EmitDefaultValue=false)]
        public DateTime? DockDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets Impressions
        /// </summary>
        [DataMember(Name="impressions", EmitDefaultValue=false)]
        public int? Impressions { get; set; }
    
        /// <summary>
        /// Gets or Sets AsnLine
        /// </summary>
        [DataMember(Name="asnLine", EmitDefaultValue=false)]
        public int? AsnLine { get; set; }
    
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
            sb.Append("class ItemReceipt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  LegacyPoNo: ").Append(LegacyPoNo).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  FullDescription: ").Append(FullDescription).Append("\n");
            sb.Append("  FactCost: ").Append(FactCost).Append("\n");
            sb.Append("  MlCost: ").Append(MlCost).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  OrderQuantity: ").Append(OrderQuantity).Append("\n");
            sb.Append("  RequestedDeliveryDate: ").Append(RequestedDeliveryDate).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  SellPrice: ").Append(SellPrice).Append("\n");
            sb.Append("  PricingPer: ").Append(PricingPer).Append("\n");
            sb.Append("  MaxFreight: ").Append(MaxFreight).Append("\n");
            sb.Append("  ChargeFreight: ").Append(ChargeFreight).Append("\n");
            sb.Append("  MaxOther: ").Append(MaxOther).Append("\n");
            sb.Append("  DistDate: ").Append(DistDate).Append("\n");
            sb.Append("  VoidDate: ").Append(VoidDate).Append("\n");
            sb.Append("  FreezeAction: ").Append(FreezeAction).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  ArtBack: ").Append(ArtBack).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Sample: ").Append(Sample).Append("\n");
            sb.Append("  SampleTo: ").Append(SampleTo).Append("\n");
            sb.Append("  MaxOvers: ").Append(MaxOvers).Append("\n");
            sb.Append("  MaxUnders: ").Append(MaxUnders).Append("\n");
            sb.Append("  ReceivedSfp: ").Append(ReceivedSfp).Append("\n");
            sb.Append("  BudgetCode: ").Append(BudgetCode).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  TaxExempt: ").Append(TaxExempt).Append("\n");
            sb.Append("  Capitalize: ").Append(Capitalize).Append("\n");
            sb.Append("  Accrual: ").Append(Accrual).Append("\n");
            sb.Append("  OddQuantity: ").Append(OddQuantity).Append("\n");
            sb.Append("  FreightCost: ").Append(FreightCost).Append("\n");
            sb.Append("  ReceivedDate: ").Append(ReceivedDate).Append("\n");
            sb.Append("  ReceivedQuantity: ").Append(ReceivedQuantity).Append("\n");
            sb.Append("  FromProd: ").Append(FromProd).Append("\n");
            sb.Append("  SfpComplete: ").Append(SfpComplete).Append("\n");
            sb.Append("  EndQuantity: ").Append(EndQuantity).Append("\n");
            sb.Append("  EndVal: ").Append(EndVal).Append("\n");
            sb.Append("  EndFact: ").Append(EndFact).Append("\n");
            sb.Append("  InterimQuantity: ").Append(InterimQuantity).Append("\n");
            sb.Append("  InterimVal: ").Append(InterimVal).Append("\n");
            sb.Append("  InterimFact: ").Append(InterimFact).Append("\n");
            sb.Append("  LastAct: ").Append(LastAct).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  Norcs: ").Append(Norcs).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  BsVendor: ").Append(BsVendor).Append("\n");
            sb.Append("  MlVendor: ").Append(MlVendor).Append("\n");
            sb.Append("  ReceiptNo: ").Append(ReceiptNo).Append("\n");
            sb.Append("  PaidFull: ").Append(PaidFull).Append("\n");
            sb.Append("  EnteredBy: ").Append(EnteredBy).Append("\n");
            sb.Append("  ReceivedBy: ").Append(ReceivedBy).Append("\n");
            sb.Append("  LineNo: ").Append(LineNo).Append("\n");
            sb.Append("  ProdLot: ").Append(ProdLot).Append("\n");
            sb.Append("  ProductIdTag: ").Append(ProductIdTag).Append("\n");
            sb.Append("  UnitsPerCase: ").Append(UnitsPerCase).Append("\n");
            sb.Append("  CaseWeight: ").Append(CaseWeight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  DockDate: ").Append(DockDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Impressions: ").Append(Impressions).Append("\n");
            sb.Append("  AsnLine: ").Append(AsnLine).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
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
            return this.Equals(obj as ItemReceipt);
        }

        /// <summary>
        /// Returns true if ItemReceipt instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemReceipt other)
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
                    this.PoNoId == other.PoNoId ||
                    this.PoNoId != null &&
                    this.PoNoId.Equals(other.PoNoId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.LegacyPoNo == other.LegacyPoNo ||
                    this.LegacyPoNo != null &&
                    this.LegacyPoNo.Equals(other.LegacyPoNo)
                ) && 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.OrderDate == other.OrderDate ||
                    this.OrderDate != null &&
                    this.OrderDate.Equals(other.OrderDate)
                ) && 
                (
                    this.FullDescription == other.FullDescription ||
                    this.FullDescription != null &&
                    this.FullDescription.Equals(other.FullDescription)
                ) && 
                (
                    this.FactCost == other.FactCost ||
                    this.FactCost != null &&
                    this.FactCost.Equals(other.FactCost)
                ) && 
                (
                    this.MlCost == other.MlCost ||
                    this.MlCost != null &&
                    this.MlCost.Equals(other.MlCost)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.OrderQuantity == other.OrderQuantity ||
                    this.OrderQuantity != null &&
                    this.OrderQuantity.Equals(other.OrderQuantity)
                ) && 
                (
                    this.RequestedDeliveryDate == other.RequestedDeliveryDate ||
                    this.RequestedDeliveryDate != null &&
                    this.RequestedDeliveryDate.Equals(other.RequestedDeliveryDate)
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
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.SellPrice == other.SellPrice ||
                    this.SellPrice != null &&
                    this.SellPrice.Equals(other.SellPrice)
                ) && 
                (
                    this.PricingPer == other.PricingPer ||
                    this.PricingPer != null &&
                    this.PricingPer.Equals(other.PricingPer)
                ) && 
                (
                    this.MaxFreight == other.MaxFreight ||
                    this.MaxFreight != null &&
                    this.MaxFreight.Equals(other.MaxFreight)
                ) && 
                (
                    this.ChargeFreight == other.ChargeFreight ||
                    this.ChargeFreight != null &&
                    this.ChargeFreight.Equals(other.ChargeFreight)
                ) && 
                (
                    this.MaxOther == other.MaxOther ||
                    this.MaxOther != null &&
                    this.MaxOther.Equals(other.MaxOther)
                ) && 
                (
                    this.DistDate == other.DistDate ||
                    this.DistDate != null &&
                    this.DistDate.Equals(other.DistDate)
                ) && 
                (
                    this.VoidDate == other.VoidDate ||
                    this.VoidDate != null &&
                    this.VoidDate.Equals(other.VoidDate)
                ) && 
                (
                    this.FreezeAction == other.FreezeAction ||
                    this.FreezeAction != null &&
                    this.FreezeAction.Equals(other.FreezeAction)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
                (
                    this.ArtBack == other.ArtBack ||
                    this.ArtBack != null &&
                    this.ArtBack.Equals(other.ArtBack)
                ) && 
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) && 
                (
                    this.Sample == other.Sample ||
                    this.Sample != null &&
                    this.Sample.Equals(other.Sample)
                ) && 
                (
                    this.SampleTo == other.SampleTo ||
                    this.SampleTo != null &&
                    this.SampleTo.Equals(other.SampleTo)
                ) && 
                (
                    this.MaxOvers == other.MaxOvers ||
                    this.MaxOvers != null &&
                    this.MaxOvers.Equals(other.MaxOvers)
                ) && 
                (
                    this.MaxUnders == other.MaxUnders ||
                    this.MaxUnders != null &&
                    this.MaxUnders.Equals(other.MaxUnders)
                ) && 
                (
                    this.ReceivedSfp == other.ReceivedSfp ||
                    this.ReceivedSfp != null &&
                    this.ReceivedSfp.Equals(other.ReceivedSfp)
                ) && 
                (
                    this.BudgetCode == other.BudgetCode ||
                    this.BudgetCode != null &&
                    this.BudgetCode.Equals(other.BudgetCode)
                ) && 
                (
                    this.AccountingCode == other.AccountingCode ||
                    this.AccountingCode != null &&
                    this.AccountingCode.Equals(other.AccountingCode)
                ) && 
                (
                    this.TaxExempt == other.TaxExempt ||
                    this.TaxExempt != null &&
                    this.TaxExempt.Equals(other.TaxExempt)
                ) && 
                (
                    this.Capitalize == other.Capitalize ||
                    this.Capitalize != null &&
                    this.Capitalize.Equals(other.Capitalize)
                ) && 
                (
                    this.Accrual == other.Accrual ||
                    this.Accrual != null &&
                    this.Accrual.Equals(other.Accrual)
                ) && 
                (
                    this.OddQuantity == other.OddQuantity ||
                    this.OddQuantity != null &&
                    this.OddQuantity.Equals(other.OddQuantity)
                ) && 
                (
                    this.FreightCost == other.FreightCost ||
                    this.FreightCost != null &&
                    this.FreightCost.Equals(other.FreightCost)
                ) && 
                (
                    this.ReceivedDate == other.ReceivedDate ||
                    this.ReceivedDate != null &&
                    this.ReceivedDate.Equals(other.ReceivedDate)
                ) && 
                (
                    this.ReceivedQuantity == other.ReceivedQuantity ||
                    this.ReceivedQuantity != null &&
                    this.ReceivedQuantity.Equals(other.ReceivedQuantity)
                ) && 
                (
                    this.FromProd == other.FromProd ||
                    this.FromProd != null &&
                    this.FromProd.Equals(other.FromProd)
                ) && 
                (
                    this.SfpComplete == other.SfpComplete ||
                    this.SfpComplete != null &&
                    this.SfpComplete.Equals(other.SfpComplete)
                ) && 
                (
                    this.EndQuantity == other.EndQuantity ||
                    this.EndQuantity != null &&
                    this.EndQuantity.Equals(other.EndQuantity)
                ) && 
                (
                    this.EndVal == other.EndVal ||
                    this.EndVal != null &&
                    this.EndVal.Equals(other.EndVal)
                ) && 
                (
                    this.EndFact == other.EndFact ||
                    this.EndFact != null &&
                    this.EndFact.Equals(other.EndFact)
                ) && 
                (
                    this.InterimQuantity == other.InterimQuantity ||
                    this.InterimQuantity != null &&
                    this.InterimQuantity.Equals(other.InterimQuantity)
                ) && 
                (
                    this.InterimVal == other.InterimVal ||
                    this.InterimVal != null &&
                    this.InterimVal.Equals(other.InterimVal)
                ) && 
                (
                    this.InterimFact == other.InterimFact ||
                    this.InterimFact != null &&
                    this.InterimFact.Equals(other.InterimFact)
                ) && 
                (
                    this.LastAct == other.LastAct ||
                    this.LastAct != null &&
                    this.LastAct.Equals(other.LastAct)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.Norcs == other.Norcs ||
                    this.Norcs != null &&
                    this.Norcs.Equals(other.Norcs)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.BsVendor == other.BsVendor ||
                    this.BsVendor != null &&
                    this.BsVendor.Equals(other.BsVendor)
                ) && 
                (
                    this.MlVendor == other.MlVendor ||
                    this.MlVendor != null &&
                    this.MlVendor.Equals(other.MlVendor)
                ) && 
                (
                    this.ReceiptNo == other.ReceiptNo ||
                    this.ReceiptNo != null &&
                    this.ReceiptNo.Equals(other.ReceiptNo)
                ) && 
                (
                    this.PaidFull == other.PaidFull ||
                    this.PaidFull != null &&
                    this.PaidFull.Equals(other.PaidFull)
                ) && 
                (
                    this.EnteredBy == other.EnteredBy ||
                    this.EnteredBy != null &&
                    this.EnteredBy.Equals(other.EnteredBy)
                ) && 
                (
                    this.ReceivedBy == other.ReceivedBy ||
                    this.ReceivedBy != null &&
                    this.ReceivedBy.Equals(other.ReceivedBy)
                ) && 
                (
                    this.LineNo == other.LineNo ||
                    this.LineNo != null &&
                    this.LineNo.Equals(other.LineNo)
                ) && 
                (
                    this.ProdLot == other.ProdLot ||
                    this.ProdLot != null &&
                    this.ProdLot.Equals(other.ProdLot)
                ) && 
                (
                    this.ProductIdTag == other.ProductIdTag ||
                    this.ProductIdTag != null &&
                    this.ProductIdTag.Equals(other.ProductIdTag)
                ) && 
                (
                    this.UnitsPerCase == other.UnitsPerCase ||
                    this.UnitsPerCase != null &&
                    this.UnitsPerCase.Equals(other.UnitsPerCase)
                ) && 
                (
                    this.CaseWeight == other.CaseWeight ||
                    this.CaseWeight != null &&
                    this.CaseWeight.Equals(other.CaseWeight)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
                ) && 
                (
                    this.DockDate == other.DockDate ||
                    this.DockDate != null &&
                    this.DockDate.Equals(other.DockDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.Impressions == other.Impressions ||
                    this.Impressions != null &&
                    this.Impressions.Equals(other.Impressions)
                ) && 
                (
                    this.AsnLine == other.AsnLine ||
                    this.AsnLine != null &&
                    this.AsnLine.Equals(other.AsnLine)
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
                
                if (this.PoNoId != null)
                    hash = hash * 59 + this.PoNoId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.LegacyPoNo != null)
                    hash = hash * 59 + this.LegacyPoNo.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.OrderDate != null)
                    hash = hash * 59 + this.OrderDate.GetHashCode();
                
                if (this.FullDescription != null)
                    hash = hash * 59 + this.FullDescription.GetHashCode();
                
                if (this.FactCost != null)
                    hash = hash * 59 + this.FactCost.GetHashCode();
                
                if (this.MlCost != null)
                    hash = hash * 59 + this.MlCost.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.OrderQuantity != null)
                    hash = hash * 59 + this.OrderQuantity.GetHashCode();
                
                if (this.RequestedDeliveryDate != null)
                    hash = hash * 59 + this.RequestedDeliveryDate.GetHashCode();
                
                if (this.UnitCode != null)
                    hash = hash * 59 + this.UnitCode.GetHashCode();
                
                if (this.WrapCode != null)
                    hash = hash * 59 + this.WrapCode.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                
                if (this.SellPrice != null)
                    hash = hash * 59 + this.SellPrice.GetHashCode();
                
                if (this.PricingPer != null)
                    hash = hash * 59 + this.PricingPer.GetHashCode();
                
                if (this.MaxFreight != null)
                    hash = hash * 59 + this.MaxFreight.GetHashCode();
                
                if (this.ChargeFreight != null)
                    hash = hash * 59 + this.ChargeFreight.GetHashCode();
                
                if (this.MaxOther != null)
                    hash = hash * 59 + this.MaxOther.GetHashCode();
                
                if (this.DistDate != null)
                    hash = hash * 59 + this.DistDate.GetHashCode();
                
                if (this.VoidDate != null)
                    hash = hash * 59 + this.VoidDate.GetHashCode();
                
                if (this.FreezeAction != null)
                    hash = hash * 59 + this.FreezeAction.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
                if (this.ArtBack != null)
                    hash = hash * 59 + this.ArtBack.GetHashCode();
                
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                
                if (this.Sample != null)
                    hash = hash * 59 + this.Sample.GetHashCode();
                
                if (this.SampleTo != null)
                    hash = hash * 59 + this.SampleTo.GetHashCode();
                
                if (this.MaxOvers != null)
                    hash = hash * 59 + this.MaxOvers.GetHashCode();
                
                if (this.MaxUnders != null)
                    hash = hash * 59 + this.MaxUnders.GetHashCode();
                
                if (this.ReceivedSfp != null)
                    hash = hash * 59 + this.ReceivedSfp.GetHashCode();
                
                if (this.BudgetCode != null)
                    hash = hash * 59 + this.BudgetCode.GetHashCode();
                
                if (this.AccountingCode != null)
                    hash = hash * 59 + this.AccountingCode.GetHashCode();
                
                if (this.TaxExempt != null)
                    hash = hash * 59 + this.TaxExempt.GetHashCode();
                
                if (this.Capitalize != null)
                    hash = hash * 59 + this.Capitalize.GetHashCode();
                
                if (this.Accrual != null)
                    hash = hash * 59 + this.Accrual.GetHashCode();
                
                if (this.OddQuantity != null)
                    hash = hash * 59 + this.OddQuantity.GetHashCode();
                
                if (this.FreightCost != null)
                    hash = hash * 59 + this.FreightCost.GetHashCode();
                
                if (this.ReceivedDate != null)
                    hash = hash * 59 + this.ReceivedDate.GetHashCode();
                
                if (this.ReceivedQuantity != null)
                    hash = hash * 59 + this.ReceivedQuantity.GetHashCode();
                
                if (this.FromProd != null)
                    hash = hash * 59 + this.FromProd.GetHashCode();
                
                if (this.SfpComplete != null)
                    hash = hash * 59 + this.SfpComplete.GetHashCode();
                
                if (this.EndQuantity != null)
                    hash = hash * 59 + this.EndQuantity.GetHashCode();
                
                if (this.EndVal != null)
                    hash = hash * 59 + this.EndVal.GetHashCode();
                
                if (this.EndFact != null)
                    hash = hash * 59 + this.EndFact.GetHashCode();
                
                if (this.InterimQuantity != null)
                    hash = hash * 59 + this.InterimQuantity.GetHashCode();
                
                if (this.InterimVal != null)
                    hash = hash * 59 + this.InterimVal.GetHashCode();
                
                if (this.InterimFact != null)
                    hash = hash * 59 + this.InterimFact.GetHashCode();
                
                if (this.LastAct != null)
                    hash = hash * 59 + this.LastAct.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.Norcs != null)
                    hash = hash * 59 + this.Norcs.GetHashCode();
                
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                
                if (this.BsVendor != null)
                    hash = hash * 59 + this.BsVendor.GetHashCode();
                
                if (this.MlVendor != null)
                    hash = hash * 59 + this.MlVendor.GetHashCode();
                
                if (this.ReceiptNo != null)
                    hash = hash * 59 + this.ReceiptNo.GetHashCode();
                
                if (this.PaidFull != null)
                    hash = hash * 59 + this.PaidFull.GetHashCode();
                
                if (this.EnteredBy != null)
                    hash = hash * 59 + this.EnteredBy.GetHashCode();
                
                if (this.ReceivedBy != null)
                    hash = hash * 59 + this.ReceivedBy.GetHashCode();
                
                if (this.LineNo != null)
                    hash = hash * 59 + this.LineNo.GetHashCode();
                
                if (this.ProdLot != null)
                    hash = hash * 59 + this.ProdLot.GetHashCode();
                
                if (this.ProductIdTag != null)
                    hash = hash * 59 + this.ProductIdTag.GetHashCode();
                
                if (this.UnitsPerCase != null)
                    hash = hash * 59 + this.UnitsPerCase.GetHashCode();
                
                if (this.CaseWeight != null)
                    hash = hash * 59 + this.CaseWeight.GetHashCode();
                
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                
                if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();
                
                if (this.DockDate != null)
                    hash = hash * 59 + this.DockDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Impressions != null)
                    hash = hash * 59 + this.Impressions.GetHashCode();
                
                if (this.AsnLine != null)
                    hash = hash * 59 + this.AsnLine.GetHashCode();
                
                if (this.Upc != null)
                    hash = hash * 59 + this.Upc.GetHashCode();
                
                if (this.VendorSKU != null)
                    hash = hash * 59 + this.VendorSKU.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
