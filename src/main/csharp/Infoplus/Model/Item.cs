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
    public partial class Item :  IEquatable<Item>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// Initializes a new instance of the <see cref="Item" />class.
        /// </summary>
        /// <param name="AccountCodeId">AccountCodeId.</param>
        /// <param name="LowStockContactId">LowStockContactId.</param>
        /// <param name="LegacyLowLevelContactId">LegacyLowLevelContactId.</param>
        /// <param name="LowStockCodeId">LowStockCodeId.</param>
        /// <param name="MajorGroupId">MajorGroupId (required).</param>
        /// <param name="SubGroupId">SubGroupId (required).</param>
        /// <param name="ProductCodeId">ProductCodeId.</param>
        /// <param name="SummaryCodeId">SummaryCodeId.</param>
        /// <param name="BuyerId">BuyerId.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="VendorSKU">VendorSKU.</param>
        /// <param name="Upc">Upc.</param>
        /// <param name="ItemDescription">ItemDescription (required).</param>
        /// <param name="PackingSlipDescription">PackingSlipDescription.</param>
        /// <param name="AbsoluteMax">AbsoluteMax.</param>
        /// <param name="AdditionalDescription">AdditionalDescription.</param>
        /// <param name="Backorder">Backorder (required).</param>
        /// <param name="ChargeCode">ChargeCode (required).</param>
        /// <param name="CommodityCode">CommodityCode.</param>
        /// <param name="CompCode">CompCode.</param>
        /// <param name="CriticalAmount">CriticalAmount (required).</param>
        /// <param name="OverallFixedReorderPoint">OverallFixedReorderPoint.</param>
        /// <param name="OverallLeadTime">OverallLeadTime.</param>
        /// <param name="SellPrice">SellPrice.</param>
        /// <param name="PricingPer">PricingPer.</param>
        /// <param name="LotControlFlag">LotControlFlag.</param>
        /// <param name="MaxCycle">MaxCycle (required).</param>
        /// <param name="MaxInterim">MaxInterim (required).</param>
        /// <param name="NumericSortOrder">NumericSortOrder.</param>
        /// <param name="OutsideVendor">OutsideVendor.</param>
        /// <param name="PickNo">PickNo.</param>
        /// <param name="PodOrderSuffix">PodOrderSuffix.</param>
        /// <param name="PodRevDate">PodRevDate.</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="SeasonalItem">SeasonalItem (required).</param>
        /// <param name="RequiresProductionLot">RequiresProductionLot.</param>
        /// <param name="Sector">Sector.</param>
        /// <param name="Secure">Secure (required).</param>
        /// <param name="SerialCode">SerialCode (required).</param>
        /// <param name="UnitCode">UnitCode (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap (required).</param>
        /// <param name="WeightPerWrap">WeightPerWrap.</param>
        /// <param name="WrapCode">WrapCode (required).</param>
        /// <param name="ExtrinsicText1">ExtrinsicText1.</param>
        /// <param name="ExtrinsicText2">ExtrinsicText2.</param>
        /// <param name="ExtrinsicText3">ExtrinsicText3.</param>
        /// <param name="ExtrinsicNumber1">ExtrinsicNumber1.</param>
        /// <param name="ExtrinsicNumber2">ExtrinsicNumber2.</param>
        /// <param name="ExtrinsicDecimal1">ExtrinsicDecimal1.</param>
        /// <param name="ExtrinsicDecimal2">ExtrinsicDecimal2.</param>
        /// <param name="CasebreakEnabled">CasebreakEnabled.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="VendorPrice">VendorPrice.</param>
        /// <param name="VendorPer">VendorPer.</param>
        /// <param name="BehaviorType">BehaviorType.</param>
        /// <param name="ForwardLotMixingRule">ForwardLotMixingRule (required).</param>
        /// <param name="StorageLotMixingRule">StorageLotMixingRule (required).</param>
        /// <param name="ForwardItemMixingRule">ForwardItemMixingRule (required).</param>
        /// <param name="StorageItemMixingRule">StorageItemMixingRule (required).</param>
        /// <param name="AllocationRule">AllocationRule (required).</param>
        /// <param name="BarcodeField">BarcodeField.</param>
        /// <param name="WarehouseDisplayField">WarehouseDisplayField.</param>
        /// <param name="ProductIdTagSchemeId">ProductIdTagSchemeId.</param>
        /// <param name="Hazmat">Hazmat (required).</param>
        /// <param name="IsAlcohol">IsAlcohol (default to false).</param>
        /// <param name="AlcoholType">AlcoholType.</param>
        /// <param name="AlcoholContent">AlcoholContent.</param>
        /// <param name="AlcoholContainer">AlcoholContainer.</param>
        /// <param name="AlcoholVintageYear">AlcoholVintageYear.</param>
        /// <param name="AlcoholCountry">AlcoholCountry.</param>
        /// <param name="AlcoholState">AlcoholState.</param>
        /// <param name="AlcoholRegion">AlcoholRegion.</param>
        /// <param name="AlcoholBrand">AlcoholBrand.</param>
        /// <param name="AlcoholUPCCode">AlcoholUPCCode.</param>
        /// <param name="AlcoholNAMBCACode">AlcoholNAMBCACode.</param>
        /// <param name="AlcoholUNIMERCCode">AlcoholUNIMERCCode.</param>
        /// <param name="AlcoholSCCCode">AlcoholSCCCode.</param>
        /// <param name="Length">Length.</param>
        /// <param name="Width">Width.</param>
        /// <param name="Height">Height.</param>
        /// <param name="TopUp">TopUp (default to false).</param>
        /// <param name="ShipSolo">ShipSolo (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Item(int? AccountCodeId = null, int? LowStockContactId = null, int? LegacyLowLevelContactId = null, int? LowStockCodeId = null, int? MajorGroupId = null, int? SubGroupId = null, int? ProductCodeId = null, int? SummaryCodeId = null, int? BuyerId = null, int? LobId = null, string Sku = null, string VendorSKU = null, string Upc = null, string ItemDescription = null, string PackingSlipDescription = null, string AbsoluteMax = null, string AdditionalDescription = null, string Backorder = null, string ChargeCode = null, string CommodityCode = null, int? CompCode = null, int? CriticalAmount = null, int? OverallFixedReorderPoint = null, int? OverallLeadTime = null, double? SellPrice = null, string PricingPer = null, string LotControlFlag = null, int? MaxCycle = null, int? MaxInterim = null, int? NumericSortOrder = null, int? OutsideVendor = null, string PickNo = null, int? PodOrderSuffix = null, string PodRevDate = null, string Status = null, string SeasonalItem = null, string RequiresProductionLot = null, string Sector = null, string Secure = null, string SerialCode = null, string UnitCode = null, int? UnitsPerWrap = null, double? WeightPerWrap = null, string WrapCode = null, string ExtrinsicText1 = null, string ExtrinsicText2 = null, string ExtrinsicText3 = null, int? ExtrinsicNumber1 = null, int? ExtrinsicNumber2 = null, double? ExtrinsicDecimal1 = null, double? ExtrinsicDecimal2 = null, string CasebreakEnabled = null, int? VendorId = null, double? VendorPrice = null, string VendorPer = null, string BehaviorType = null, string ForwardLotMixingRule = null, string StorageLotMixingRule = null, string ForwardItemMixingRule = null, string StorageItemMixingRule = null, string AllocationRule = null, string BarcodeField = null, string WarehouseDisplayField = null, int? ProductIdTagSchemeId = null, string Hazmat = null, bool? IsAlcohol = null, string AlcoholType = null, double? AlcoholContent = null, string AlcoholContainer = null, string AlcoholVintageYear = null, string AlcoholCountry = null, string AlcoholState = null, string AlcoholRegion = null, string AlcoholBrand = null, string AlcoholUPCCode = null, string AlcoholNAMBCACode = null, string AlcoholUNIMERCCode = null, string AlcoholSCCCode = null, double? Length = null, double? Width = null, double? Height = null, bool? TopUp = null, bool? ShipSolo = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "MajorGroupId" is required (not null)
            if (MajorGroupId == null)
            {
                throw new InvalidDataException("MajorGroupId is a required property for Item and cannot be null");
            }
            else
            {
                this.MajorGroupId = MajorGroupId;
            }
            // to ensure "SubGroupId" is required (not null)
            if (SubGroupId == null)
            {
                throw new InvalidDataException("SubGroupId is a required property for Item and cannot be null");
            }
            else
            {
                this.SubGroupId = SubGroupId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Item and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for Item and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "ItemDescription" is required (not null)
            if (ItemDescription == null)
            {
                throw new InvalidDataException("ItemDescription is a required property for Item and cannot be null");
            }
            else
            {
                this.ItemDescription = ItemDescription;
            }
            // to ensure "Backorder" is required (not null)
            if (Backorder == null)
            {
                throw new InvalidDataException("Backorder is a required property for Item and cannot be null");
            }
            else
            {
                this.Backorder = Backorder;
            }
            // to ensure "ChargeCode" is required (not null)
            if (ChargeCode == null)
            {
                throw new InvalidDataException("ChargeCode is a required property for Item and cannot be null");
            }
            else
            {
                this.ChargeCode = ChargeCode;
            }
            // to ensure "CriticalAmount" is required (not null)
            if (CriticalAmount == null)
            {
                throw new InvalidDataException("CriticalAmount is a required property for Item and cannot be null");
            }
            else
            {
                this.CriticalAmount = CriticalAmount;
            }
            // to ensure "MaxCycle" is required (not null)
            if (MaxCycle == null)
            {
                throw new InvalidDataException("MaxCycle is a required property for Item and cannot be null");
            }
            else
            {
                this.MaxCycle = MaxCycle;
            }
            // to ensure "MaxInterim" is required (not null)
            if (MaxInterim == null)
            {
                throw new InvalidDataException("MaxInterim is a required property for Item and cannot be null");
            }
            else
            {
                this.MaxInterim = MaxInterim;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Item and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "SeasonalItem" is required (not null)
            if (SeasonalItem == null)
            {
                throw new InvalidDataException("SeasonalItem is a required property for Item and cannot be null");
            }
            else
            {
                this.SeasonalItem = SeasonalItem;
            }
            // to ensure "Secure" is required (not null)
            if (Secure == null)
            {
                throw new InvalidDataException("Secure is a required property for Item and cannot be null");
            }
            else
            {
                this.Secure = Secure;
            }
            // to ensure "SerialCode" is required (not null)
            if (SerialCode == null)
            {
                throw new InvalidDataException("SerialCode is a required property for Item and cannot be null");
            }
            else
            {
                this.SerialCode = SerialCode;
            }
            // to ensure "UnitCode" is required (not null)
            if (UnitCode == null)
            {
                throw new InvalidDataException("UnitCode is a required property for Item and cannot be null");
            }
            else
            {
                this.UnitCode = UnitCode;
            }
            // to ensure "UnitsPerWrap" is required (not null)
            if (UnitsPerWrap == null)
            {
                throw new InvalidDataException("UnitsPerWrap is a required property for Item and cannot be null");
            }
            else
            {
                this.UnitsPerWrap = UnitsPerWrap;
            }
            // to ensure "WrapCode" is required (not null)
            if (WrapCode == null)
            {
                throw new InvalidDataException("WrapCode is a required property for Item and cannot be null");
            }
            else
            {
                this.WrapCode = WrapCode;
            }
            // to ensure "ForwardLotMixingRule" is required (not null)
            if (ForwardLotMixingRule == null)
            {
                throw new InvalidDataException("ForwardLotMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.ForwardLotMixingRule = ForwardLotMixingRule;
            }
            // to ensure "StorageLotMixingRule" is required (not null)
            if (StorageLotMixingRule == null)
            {
                throw new InvalidDataException("StorageLotMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.StorageLotMixingRule = StorageLotMixingRule;
            }
            // to ensure "ForwardItemMixingRule" is required (not null)
            if (ForwardItemMixingRule == null)
            {
                throw new InvalidDataException("ForwardItemMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.ForwardItemMixingRule = ForwardItemMixingRule;
            }
            // to ensure "StorageItemMixingRule" is required (not null)
            if (StorageItemMixingRule == null)
            {
                throw new InvalidDataException("StorageItemMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.StorageItemMixingRule = StorageItemMixingRule;
            }
            // to ensure "AllocationRule" is required (not null)
            if (AllocationRule == null)
            {
                throw new InvalidDataException("AllocationRule is a required property for Item and cannot be null");
            }
            else
            {
                this.AllocationRule = AllocationRule;
            }
            // to ensure "Hazmat" is required (not null)
            if (Hazmat == null)
            {
                throw new InvalidDataException("Hazmat is a required property for Item and cannot be null");
            }
            else
            {
                this.Hazmat = Hazmat;
            }
            this.AccountCodeId = AccountCodeId;
            this.LowStockContactId = LowStockContactId;
            this.LegacyLowLevelContactId = LegacyLowLevelContactId;
            this.LowStockCodeId = LowStockCodeId;
            this.ProductCodeId = ProductCodeId;
            this.SummaryCodeId = SummaryCodeId;
            this.BuyerId = BuyerId;
            this.VendorSKU = VendorSKU;
            this.Upc = Upc;
            this.PackingSlipDescription = PackingSlipDescription;
            this.AbsoluteMax = AbsoluteMax;
            this.AdditionalDescription = AdditionalDescription;
            this.CommodityCode = CommodityCode;
            this.CompCode = CompCode;
            this.OverallFixedReorderPoint = OverallFixedReorderPoint;
            this.OverallLeadTime = OverallLeadTime;
            this.SellPrice = SellPrice;
            this.PricingPer = PricingPer;
            this.LotControlFlag = LotControlFlag;
            this.NumericSortOrder = NumericSortOrder;
            this.OutsideVendor = OutsideVendor;
            this.PickNo = PickNo;
            this.PodOrderSuffix = PodOrderSuffix;
            this.PodRevDate = PodRevDate;
            this.RequiresProductionLot = RequiresProductionLot;
            this.Sector = Sector;
            this.WeightPerWrap = WeightPerWrap;
            this.ExtrinsicText1 = ExtrinsicText1;
            this.ExtrinsicText2 = ExtrinsicText2;
            this.ExtrinsicText3 = ExtrinsicText3;
            this.ExtrinsicNumber1 = ExtrinsicNumber1;
            this.ExtrinsicNumber2 = ExtrinsicNumber2;
            this.ExtrinsicDecimal1 = ExtrinsicDecimal1;
            this.ExtrinsicDecimal2 = ExtrinsicDecimal2;
            this.CasebreakEnabled = CasebreakEnabled;
            this.VendorId = VendorId;
            this.VendorPrice = VendorPrice;
            this.VendorPer = VendorPer;
            this.BehaviorType = BehaviorType;
            this.BarcodeField = BarcodeField;
            this.WarehouseDisplayField = WarehouseDisplayField;
            this.ProductIdTagSchemeId = ProductIdTagSchemeId;
            // use default value if no "IsAlcohol" provided
            if (IsAlcohol == null)
            {
                this.IsAlcohol = false;
            }
            else
            {
                this.IsAlcohol = IsAlcohol;
            }
            this.AlcoholType = AlcoholType;
            this.AlcoholContent = AlcoholContent;
            this.AlcoholContainer = AlcoholContainer;
            this.AlcoholVintageYear = AlcoholVintageYear;
            this.AlcoholCountry = AlcoholCountry;
            this.AlcoholState = AlcoholState;
            this.AlcoholRegion = AlcoholRegion;
            this.AlcoholBrand = AlcoholBrand;
            this.AlcoholUPCCode = AlcoholUPCCode;
            this.AlcoholNAMBCACode = AlcoholNAMBCACode;
            this.AlcoholUNIMERCCode = AlcoholUNIMERCCode;
            this.AlcoholSCCCode = AlcoholSCCCode;
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
            // use default value if no "TopUp" provided
            if (TopUp == null)
            {
                this.TopUp = false;
            }
            else
            {
                this.TopUp = TopUp;
            }
            // use default value if no "ShipSolo" provided
            if (ShipSolo == null)
            {
                this.ShipSolo = false;
            }
            else
            {
                this.ShipSolo = ShipSolo;
            }
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets AccountCodeId
        /// </summary>
        [DataMember(Name="accountCodeId", EmitDefaultValue=false)]
        public int? AccountCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets LowStockContactId
        /// </summary>
        [DataMember(Name="lowStockContactId", EmitDefaultValue=false)]
        public int? LowStockContactId { get; set; }
    
        /// <summary>
        /// Gets or Sets LegacyLowLevelContactId
        /// </summary>
        [DataMember(Name="legacyLowLevelContactId", EmitDefaultValue=false)]
        public int? LegacyLowLevelContactId { get; set; }
    
        /// <summary>
        /// Gets or Sets LowStockCodeId
        /// </summary>
        [DataMember(Name="lowStockCodeId", EmitDefaultValue=false)]
        public int? LowStockCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets MajorGroupId
        /// </summary>
        [DataMember(Name="majorGroupId", EmitDefaultValue=false)]
        public int? MajorGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets SubGroupId
        /// </summary>
        [DataMember(Name="subGroupId", EmitDefaultValue=false)]
        public int? SubGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductCodeId
        /// </summary>
        [DataMember(Name="productCodeId", EmitDefaultValue=false)]
        public int? ProductCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets SummaryCodeId
        /// </summary>
        [DataMember(Name="summaryCodeId", EmitDefaultValue=false)]
        public int? SummaryCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets BuyerId
        /// </summary>
        [DataMember(Name="buyerId", EmitDefaultValue=false)]
        public int? BuyerId { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorSKU
        /// </summary>
        [DataMember(Name="vendorSKU", EmitDefaultValue=false)]
        public string VendorSKU { get; set; }
    
        /// <summary>
        /// Gets or Sets Upc
        /// </summary>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="itemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets PackingSlipDescription
        /// </summary>
        [DataMember(Name="packingSlipDescription", EmitDefaultValue=false)]
        public string PackingSlipDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets AbsoluteMax
        /// </summary>
        [DataMember(Name="absoluteMax", EmitDefaultValue=false)]
        public string AbsoluteMax { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalDescription
        /// </summary>
        [DataMember(Name="additionalDescription", EmitDefaultValue=false)]
        public string AdditionalDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets Backorder
        /// </summary>
        [DataMember(Name="backorder", EmitDefaultValue=false)]
        public string Backorder { get; set; }
    
        /// <summary>
        /// Gets or Sets ChargeCode
        /// </summary>
        [DataMember(Name="chargeCode", EmitDefaultValue=false)]
        public string ChargeCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CommodityCode
        /// </summary>
        [DataMember(Name="commodityCode", EmitDefaultValue=false)]
        public string CommodityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CompCode
        /// </summary>
        [DataMember(Name="compCode", EmitDefaultValue=false)]
        public int? CompCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets CriticalAmount
        /// </summary>
        [DataMember(Name="criticalAmount", EmitDefaultValue=false)]
        public int? CriticalAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets OverallFixedReorderPoint
        /// </summary>
        [DataMember(Name="overallFixedReorderPoint", EmitDefaultValue=false)]
        public int? OverallFixedReorderPoint { get; set; }
    
        /// <summary>
        /// Gets or Sets OverallLeadTime
        /// </summary>
        [DataMember(Name="overallLeadTime", EmitDefaultValue=false)]
        public int? OverallLeadTime { get; set; }
    
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
        /// Gets or Sets LotControlFlag
        /// </summary>
        [DataMember(Name="lotControlFlag", EmitDefaultValue=false)]
        public string LotControlFlag { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxCycle
        /// </summary>
        [DataMember(Name="maxCycle", EmitDefaultValue=false)]
        public int? MaxCycle { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxInterim
        /// </summary>
        [DataMember(Name="maxInterim", EmitDefaultValue=false)]
        public int? MaxInterim { get; set; }
    
        /// <summary>
        /// Gets or Sets NumericSortOrder
        /// </summary>
        [DataMember(Name="numericSortOrder", EmitDefaultValue=false)]
        public int? NumericSortOrder { get; set; }
    
        /// <summary>
        /// Gets or Sets OutsideVendor
        /// </summary>
        [DataMember(Name="outsideVendor", EmitDefaultValue=false)]
        public int? OutsideVendor { get; set; }
    
        /// <summary>
        /// Gets or Sets PickNo
        /// </summary>
        [DataMember(Name="pickNo", EmitDefaultValue=false)]
        public string PickNo { get; set; }
    
        /// <summary>
        /// Gets or Sets PodOrderSuffix
        /// </summary>
        [DataMember(Name="podOrderSuffix", EmitDefaultValue=false)]
        public int? PodOrderSuffix { get; set; }
    
        /// <summary>
        /// Gets or Sets PodRevDate
        /// </summary>
        [DataMember(Name="podRevDate", EmitDefaultValue=false)]
        public string PodRevDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets SeasonalItem
        /// </summary>
        [DataMember(Name="seasonalItem", EmitDefaultValue=false)]
        public string SeasonalItem { get; set; }
    
        /// <summary>
        /// Gets or Sets RequiresProductionLot
        /// </summary>
        [DataMember(Name="requiresProductionLot", EmitDefaultValue=false)]
        public string RequiresProductionLot { get; set; }
    
        /// <summary>
        /// Gets or Sets Sector
        /// </summary>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; set; }
    
        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public string Secure { get; set; }
    
        /// <summary>
        /// Gets or Sets SerialCode
        /// </summary>
        [DataMember(Name="serialCode", EmitDefaultValue=false)]
        public string SerialCode { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitCode
        /// </summary>
        [DataMember(Name="unitCode", EmitDefaultValue=false)]
        public string UnitCode { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerWrap
        /// </summary>
        [DataMember(Name="unitsPerWrap", EmitDefaultValue=false)]
        public int? UnitsPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets VoidDate
        /// </summary>
        [DataMember(Name="voidDate", EmitDefaultValue=false)]
        public DateTime? VoidDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets WrapCode
        /// </summary>
        [DataMember(Name="wrapCode", EmitDefaultValue=false)]
        public string WrapCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText1
        /// </summary>
        [DataMember(Name="extrinsicText1", EmitDefaultValue=false)]
        public string ExtrinsicText1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText2
        /// </summary>
        [DataMember(Name="extrinsicText2", EmitDefaultValue=false)]
        public string ExtrinsicText2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText3
        /// </summary>
        [DataMember(Name="extrinsicText3", EmitDefaultValue=false)]
        public string ExtrinsicText3 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicNumber1
        /// </summary>
        [DataMember(Name="extrinsicNumber1", EmitDefaultValue=false)]
        public int? ExtrinsicNumber1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicNumber2
        /// </summary>
        [DataMember(Name="extrinsicNumber2", EmitDefaultValue=false)]
        public int? ExtrinsicNumber2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicDecimal1
        /// </summary>
        [DataMember(Name="extrinsicDecimal1", EmitDefaultValue=false)]
        public double? ExtrinsicDecimal1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicDecimal2
        /// </summary>
        [DataMember(Name="extrinsicDecimal2", EmitDefaultValue=false)]
        public double? ExtrinsicDecimal2 { get; set; }
    
        /// <summary>
        /// Gets or Sets CasebreakEnabled
        /// </summary>
        [DataMember(Name="casebreakEnabled", EmitDefaultValue=false)]
        public string CasebreakEnabled { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorPrice
        /// </summary>
        [DataMember(Name="vendorPrice", EmitDefaultValue=false)]
        public double? VendorPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorPer
        /// </summary>
        [DataMember(Name="vendorPer", EmitDefaultValue=false)]
        public string VendorPer { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets BehaviorType
        /// </summary>
        [DataMember(Name="behaviorType", EmitDefaultValue=false)]
        public string BehaviorType { get; set; }
    
        /// <summary>
        /// Gets or Sets ForwardLotMixingRule
        /// </summary>
        [DataMember(Name="forwardLotMixingRule", EmitDefaultValue=false)]
        public string ForwardLotMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageLotMixingRule
        /// </summary>
        [DataMember(Name="storageLotMixingRule", EmitDefaultValue=false)]
        public string StorageLotMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets ForwardItemMixingRule
        /// </summary>
        [DataMember(Name="forwardItemMixingRule", EmitDefaultValue=false)]
        public string ForwardItemMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageItemMixingRule
        /// </summary>
        [DataMember(Name="storageItemMixingRule", EmitDefaultValue=false)]
        public string StorageItemMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets AllocationRule
        /// </summary>
        [DataMember(Name="allocationRule", EmitDefaultValue=false)]
        public string AllocationRule { get; set; }
    
        /// <summary>
        /// Gets or Sets BarcodeField
        /// </summary>
        [DataMember(Name="barcodeField", EmitDefaultValue=false)]
        public string BarcodeField { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseDisplayField
        /// </summary>
        [DataMember(Name="warehouseDisplayField", EmitDefaultValue=false)]
        public string WarehouseDisplayField { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductIdTagSchemeId
        /// </summary>
        [DataMember(Name="productIdTagSchemeId", EmitDefaultValue=false)]
        public int? ProductIdTagSchemeId { get; set; }
    
        /// <summary>
        /// Gets or Sets Hazmat
        /// </summary>
        [DataMember(Name="hazmat", EmitDefaultValue=false)]
        public string Hazmat { get; set; }
    
        /// <summary>
        /// Gets or Sets IsAlcohol
        /// </summary>
        [DataMember(Name="isAlcohol", EmitDefaultValue=false)]
        public bool? IsAlcohol { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholType
        /// </summary>
        [DataMember(Name="alcoholType", EmitDefaultValue=false)]
        public string AlcoholType { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholContent
        /// </summary>
        [DataMember(Name="alcoholContent", EmitDefaultValue=false)]
        public double? AlcoholContent { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholContainer
        /// </summary>
        [DataMember(Name="alcoholContainer", EmitDefaultValue=false)]
        public string AlcoholContainer { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholVintageYear
        /// </summary>
        [DataMember(Name="alcoholVintageYear", EmitDefaultValue=false)]
        public string AlcoholVintageYear { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholCountry
        /// </summary>
        [DataMember(Name="alcoholCountry", EmitDefaultValue=false)]
        public string AlcoholCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholState
        /// </summary>
        [DataMember(Name="alcoholState", EmitDefaultValue=false)]
        public string AlcoholState { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholRegion
        /// </summary>
        [DataMember(Name="alcoholRegion", EmitDefaultValue=false)]
        public string AlcoholRegion { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholBrand
        /// </summary>
        [DataMember(Name="alcoholBrand", EmitDefaultValue=false)]
        public string AlcoholBrand { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholUPCCode
        /// </summary>
        [DataMember(Name="alcoholUPCCode", EmitDefaultValue=false)]
        public string AlcoholUPCCode { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholNAMBCACode
        /// </summary>
        [DataMember(Name="alcoholNAMBCACode", EmitDefaultValue=false)]
        public string AlcoholNAMBCACode { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholUNIMERCCode
        /// </summary>
        [DataMember(Name="alcoholUNIMERCCode", EmitDefaultValue=false)]
        public string AlcoholUNIMERCCode { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholSCCCode
        /// </summary>
        [DataMember(Name="alcoholSCCCode", EmitDefaultValue=false)]
        public string AlcoholSCCCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public double? Length { get; set; }
    
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }
    
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }
    
        /// <summary>
        /// Gets or Sets TopUp
        /// </summary>
        [DataMember(Name="topUp", EmitDefaultValue=false)]
        public bool? TopUp { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipSolo
        /// </summary>
        [DataMember(Name="shipSolo", EmitDefaultValue=false)]
        public bool? ShipSolo { get; set; }
    
        /// <summary>
        /// Gets or Sets InventoryUpdateTimestamp
        /// </summary>
        [DataMember(Name="inventoryUpdateTimestamp", EmitDefaultValue=false)]
        public DateTime? InventoryUpdateTimestamp { get; private set; }
    
        /// <summary>
        /// Gets or Sets AvailableQuantity
        /// </summary>
        [DataMember(Name="availableQuantity", EmitDefaultValue=false)]
        public int? AvailableQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets DamagedQuantity
        /// </summary>
        [DataMember(Name="damagedQuantity", EmitDefaultValue=false)]
        public int? DamagedQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets InFulfillmentProcessQuantity
        /// </summary>
        [DataMember(Name="inFulfillmentProcessQuantity", EmitDefaultValue=false)]
        public int? InFulfillmentProcessQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets OnHandQuantity
        /// </summary>
        [DataMember(Name="onHandQuantity", EmitDefaultValue=false)]
        public int? OnHandQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets OpenOrderQuantity
        /// </summary>
        [DataMember(Name="openOrderQuantity", EmitDefaultValue=false)]
        public int? OpenOrderQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets OpenPOQuantity
        /// </summary>
        [DataMember(Name="openPOQuantity", EmitDefaultValue=false)]
        public int? OpenPOQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderableQuantity
        /// </summary>
        [DataMember(Name="orderableQuantity", EmitDefaultValue=false)]
        public int? OrderableQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnallocatableQuantity
        /// </summary>
        [DataMember(Name="unallocatableQuantity", EmitDefaultValue=false)]
        public int? UnallocatableQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets UnavailableQuantity
        /// </summary>
        [DataMember(Name="unavailableQuantity", EmitDefaultValue=false)]
        public int? UnavailableQuantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets OverallDaysOnHand
        /// </summary>
        [DataMember(Name="overallDaysOnHand", EmitDefaultValue=false)]
        public int? OverallDaysOnHand { get; private set; }
    
        /// <summary>
        /// Gets or Sets OverallStockStatus
        /// </summary>
        [DataMember(Name="overallStockStatus", EmitDefaultValue=false)]
        public string OverallStockStatus { get; private set; }
    
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
            sb.Append("class Item {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountCodeId: ").Append(AccountCodeId).Append("\n");
            sb.Append("  LowStockContactId: ").Append(LowStockContactId).Append("\n");
            sb.Append("  LegacyLowLevelContactId: ").Append(LegacyLowLevelContactId).Append("\n");
            sb.Append("  LowStockCodeId: ").Append(LowStockCodeId).Append("\n");
            sb.Append("  MajorGroupId: ").Append(MajorGroupId).Append("\n");
            sb.Append("  SubGroupId: ").Append(SubGroupId).Append("\n");
            sb.Append("  ProductCodeId: ").Append(ProductCodeId).Append("\n");
            sb.Append("  SummaryCodeId: ").Append(SummaryCodeId).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  PackingSlipDescription: ").Append(PackingSlipDescription).Append("\n");
            sb.Append("  AbsoluteMax: ").Append(AbsoluteMax).Append("\n");
            sb.Append("  AdditionalDescription: ").Append(AdditionalDescription).Append("\n");
            sb.Append("  Backorder: ").Append(Backorder).Append("\n");
            sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  CompCode: ").Append(CompCode).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CriticalAmount: ").Append(CriticalAmount).Append("\n");
            sb.Append("  OverallFixedReorderPoint: ").Append(OverallFixedReorderPoint).Append("\n");
            sb.Append("  OverallLeadTime: ").Append(OverallLeadTime).Append("\n");
            sb.Append("  SellPrice: ").Append(SellPrice).Append("\n");
            sb.Append("  PricingPer: ").Append(PricingPer).Append("\n");
            sb.Append("  LotControlFlag: ").Append(LotControlFlag).Append("\n");
            sb.Append("  MaxCycle: ").Append(MaxCycle).Append("\n");
            sb.Append("  MaxInterim: ").Append(MaxInterim).Append("\n");
            sb.Append("  NumericSortOrder: ").Append(NumericSortOrder).Append("\n");
            sb.Append("  OutsideVendor: ").Append(OutsideVendor).Append("\n");
            sb.Append("  PickNo: ").Append(PickNo).Append("\n");
            sb.Append("  PodOrderSuffix: ").Append(PodOrderSuffix).Append("\n");
            sb.Append("  PodRevDate: ").Append(PodRevDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SeasonalItem: ").Append(SeasonalItem).Append("\n");
            sb.Append("  RequiresProductionLot: ").Append(RequiresProductionLot).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  SerialCode: ").Append(SerialCode).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  VoidDate: ").Append(VoidDate).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  ExtrinsicText1: ").Append(ExtrinsicText1).Append("\n");
            sb.Append("  ExtrinsicText2: ").Append(ExtrinsicText2).Append("\n");
            sb.Append("  ExtrinsicText3: ").Append(ExtrinsicText3).Append("\n");
            sb.Append("  ExtrinsicNumber1: ").Append(ExtrinsicNumber1).Append("\n");
            sb.Append("  ExtrinsicNumber2: ").Append(ExtrinsicNumber2).Append("\n");
            sb.Append("  ExtrinsicDecimal1: ").Append(ExtrinsicDecimal1).Append("\n");
            sb.Append("  ExtrinsicDecimal2: ").Append(ExtrinsicDecimal2).Append("\n");
            sb.Append("  CasebreakEnabled: ").Append(CasebreakEnabled).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  VendorPrice: ").Append(VendorPrice).Append("\n");
            sb.Append("  VendorPer: ").Append(VendorPer).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  BehaviorType: ").Append(BehaviorType).Append("\n");
            sb.Append("  ForwardLotMixingRule: ").Append(ForwardLotMixingRule).Append("\n");
            sb.Append("  StorageLotMixingRule: ").Append(StorageLotMixingRule).Append("\n");
            sb.Append("  ForwardItemMixingRule: ").Append(ForwardItemMixingRule).Append("\n");
            sb.Append("  StorageItemMixingRule: ").Append(StorageItemMixingRule).Append("\n");
            sb.Append("  AllocationRule: ").Append(AllocationRule).Append("\n");
            sb.Append("  BarcodeField: ").Append(BarcodeField).Append("\n");
            sb.Append("  WarehouseDisplayField: ").Append(WarehouseDisplayField).Append("\n");
            sb.Append("  ProductIdTagSchemeId: ").Append(ProductIdTagSchemeId).Append("\n");
            sb.Append("  Hazmat: ").Append(Hazmat).Append("\n");
            sb.Append("  IsAlcohol: ").Append(IsAlcohol).Append("\n");
            sb.Append("  AlcoholType: ").Append(AlcoholType).Append("\n");
            sb.Append("  AlcoholContent: ").Append(AlcoholContent).Append("\n");
            sb.Append("  AlcoholContainer: ").Append(AlcoholContainer).Append("\n");
            sb.Append("  AlcoholVintageYear: ").Append(AlcoholVintageYear).Append("\n");
            sb.Append("  AlcoholCountry: ").Append(AlcoholCountry).Append("\n");
            sb.Append("  AlcoholState: ").Append(AlcoholState).Append("\n");
            sb.Append("  AlcoholRegion: ").Append(AlcoholRegion).Append("\n");
            sb.Append("  AlcoholBrand: ").Append(AlcoholBrand).Append("\n");
            sb.Append("  AlcoholUPCCode: ").Append(AlcoholUPCCode).Append("\n");
            sb.Append("  AlcoholNAMBCACode: ").Append(AlcoholNAMBCACode).Append("\n");
            sb.Append("  AlcoholUNIMERCCode: ").Append(AlcoholUNIMERCCode).Append("\n");
            sb.Append("  AlcoholSCCCode: ").Append(AlcoholSCCCode).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  TopUp: ").Append(TopUp).Append("\n");
            sb.Append("  ShipSolo: ").Append(ShipSolo).Append("\n");
            sb.Append("  InventoryUpdateTimestamp: ").Append(InventoryUpdateTimestamp).Append("\n");
            sb.Append("  AvailableQuantity: ").Append(AvailableQuantity).Append("\n");
            sb.Append("  DamagedQuantity: ").Append(DamagedQuantity).Append("\n");
            sb.Append("  InFulfillmentProcessQuantity: ").Append(InFulfillmentProcessQuantity).Append("\n");
            sb.Append("  OnHandQuantity: ").Append(OnHandQuantity).Append("\n");
            sb.Append("  OpenOrderQuantity: ").Append(OpenOrderQuantity).Append("\n");
            sb.Append("  OpenPOQuantity: ").Append(OpenPOQuantity).Append("\n");
            sb.Append("  OrderableQuantity: ").Append(OrderableQuantity).Append("\n");
            sb.Append("  UnallocatableQuantity: ").Append(UnallocatableQuantity).Append("\n");
            sb.Append("  UnavailableQuantity: ").Append(UnavailableQuantity).Append("\n");
            sb.Append("  OverallDaysOnHand: ").Append(OverallDaysOnHand).Append("\n");
            sb.Append("  OverallStockStatus: ").Append(OverallStockStatus).Append("\n");
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
            return this.Equals(obj as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="other">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item other)
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
                    this.AccountCodeId == other.AccountCodeId ||
                    this.AccountCodeId != null &&
                    this.AccountCodeId.Equals(other.AccountCodeId)
                ) && 
                (
                    this.LowStockContactId == other.LowStockContactId ||
                    this.LowStockContactId != null &&
                    this.LowStockContactId.Equals(other.LowStockContactId)
                ) && 
                (
                    this.LegacyLowLevelContactId == other.LegacyLowLevelContactId ||
                    this.LegacyLowLevelContactId != null &&
                    this.LegacyLowLevelContactId.Equals(other.LegacyLowLevelContactId)
                ) && 
                (
                    this.LowStockCodeId == other.LowStockCodeId ||
                    this.LowStockCodeId != null &&
                    this.LowStockCodeId.Equals(other.LowStockCodeId)
                ) && 
                (
                    this.MajorGroupId == other.MajorGroupId ||
                    this.MajorGroupId != null &&
                    this.MajorGroupId.Equals(other.MajorGroupId)
                ) && 
                (
                    this.SubGroupId == other.SubGroupId ||
                    this.SubGroupId != null &&
                    this.SubGroupId.Equals(other.SubGroupId)
                ) && 
                (
                    this.ProductCodeId == other.ProductCodeId ||
                    this.ProductCodeId != null &&
                    this.ProductCodeId.Equals(other.ProductCodeId)
                ) && 
                (
                    this.SummaryCodeId == other.SummaryCodeId ||
                    this.SummaryCodeId != null &&
                    this.SummaryCodeId.Equals(other.SummaryCodeId)
                ) && 
                (
                    this.BuyerId == other.BuyerId ||
                    this.BuyerId != null &&
                    this.BuyerId.Equals(other.BuyerId)
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
                    this.VendorSKU == other.VendorSKU ||
                    this.VendorSKU != null &&
                    this.VendorSKU.Equals(other.VendorSKU)
                ) && 
                (
                    this.Upc == other.Upc ||
                    this.Upc != null &&
                    this.Upc.Equals(other.Upc)
                ) && 
                (
                    this.ItemDescription == other.ItemDescription ||
                    this.ItemDescription != null &&
                    this.ItemDescription.Equals(other.ItemDescription)
                ) && 
                (
                    this.PackingSlipDescription == other.PackingSlipDescription ||
                    this.PackingSlipDescription != null &&
                    this.PackingSlipDescription.Equals(other.PackingSlipDescription)
                ) && 
                (
                    this.AbsoluteMax == other.AbsoluteMax ||
                    this.AbsoluteMax != null &&
                    this.AbsoluteMax.Equals(other.AbsoluteMax)
                ) && 
                (
                    this.AdditionalDescription == other.AdditionalDescription ||
                    this.AdditionalDescription != null &&
                    this.AdditionalDescription.Equals(other.AdditionalDescription)
                ) && 
                (
                    this.Backorder == other.Backorder ||
                    this.Backorder != null &&
                    this.Backorder.Equals(other.Backorder)
                ) && 
                (
                    this.ChargeCode == other.ChargeCode ||
                    this.ChargeCode != null &&
                    this.ChargeCode.Equals(other.ChargeCode)
                ) && 
                (
                    this.CommodityCode == other.CommodityCode ||
                    this.CommodityCode != null &&
                    this.CommodityCode.Equals(other.CommodityCode)
                ) && 
                (
                    this.CompCode == other.CompCode ||
                    this.CompCode != null &&
                    this.CompCode.Equals(other.CompCode)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.CriticalAmount == other.CriticalAmount ||
                    this.CriticalAmount != null &&
                    this.CriticalAmount.Equals(other.CriticalAmount)
                ) && 
                (
                    this.OverallFixedReorderPoint == other.OverallFixedReorderPoint ||
                    this.OverallFixedReorderPoint != null &&
                    this.OverallFixedReorderPoint.Equals(other.OverallFixedReorderPoint)
                ) && 
                (
                    this.OverallLeadTime == other.OverallLeadTime ||
                    this.OverallLeadTime != null &&
                    this.OverallLeadTime.Equals(other.OverallLeadTime)
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
                    this.LotControlFlag == other.LotControlFlag ||
                    this.LotControlFlag != null &&
                    this.LotControlFlag.Equals(other.LotControlFlag)
                ) && 
                (
                    this.MaxCycle == other.MaxCycle ||
                    this.MaxCycle != null &&
                    this.MaxCycle.Equals(other.MaxCycle)
                ) && 
                (
                    this.MaxInterim == other.MaxInterim ||
                    this.MaxInterim != null &&
                    this.MaxInterim.Equals(other.MaxInterim)
                ) && 
                (
                    this.NumericSortOrder == other.NumericSortOrder ||
                    this.NumericSortOrder != null &&
                    this.NumericSortOrder.Equals(other.NumericSortOrder)
                ) && 
                (
                    this.OutsideVendor == other.OutsideVendor ||
                    this.OutsideVendor != null &&
                    this.OutsideVendor.Equals(other.OutsideVendor)
                ) && 
                (
                    this.PickNo == other.PickNo ||
                    this.PickNo != null &&
                    this.PickNo.Equals(other.PickNo)
                ) && 
                (
                    this.PodOrderSuffix == other.PodOrderSuffix ||
                    this.PodOrderSuffix != null &&
                    this.PodOrderSuffix.Equals(other.PodOrderSuffix)
                ) && 
                (
                    this.PodRevDate == other.PodRevDate ||
                    this.PodRevDate != null &&
                    this.PodRevDate.Equals(other.PodRevDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SeasonalItem == other.SeasonalItem ||
                    this.SeasonalItem != null &&
                    this.SeasonalItem.Equals(other.SeasonalItem)
                ) && 
                (
                    this.RequiresProductionLot == other.RequiresProductionLot ||
                    this.RequiresProductionLot != null &&
                    this.RequiresProductionLot.Equals(other.RequiresProductionLot)
                ) && 
                (
                    this.Sector == other.Sector ||
                    this.Sector != null &&
                    this.Sector.Equals(other.Sector)
                ) && 
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
                ) && 
                (
                    this.SerialCode == other.SerialCode ||
                    this.SerialCode != null &&
                    this.SerialCode.Equals(other.SerialCode)
                ) && 
                (
                    this.UnitCode == other.UnitCode ||
                    this.UnitCode != null &&
                    this.UnitCode.Equals(other.UnitCode)
                ) && 
                (
                    this.UnitsPerWrap == other.UnitsPerWrap ||
                    this.UnitsPerWrap != null &&
                    this.UnitsPerWrap.Equals(other.UnitsPerWrap)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.VoidDate == other.VoidDate ||
                    this.VoidDate != null &&
                    this.VoidDate.Equals(other.VoidDate)
                ) && 
                (
                    this.WrapCode == other.WrapCode ||
                    this.WrapCode != null &&
                    this.WrapCode.Equals(other.WrapCode)
                ) && 
                (
                    this.ExtrinsicText1 == other.ExtrinsicText1 ||
                    this.ExtrinsicText1 != null &&
                    this.ExtrinsicText1.Equals(other.ExtrinsicText1)
                ) && 
                (
                    this.ExtrinsicText2 == other.ExtrinsicText2 ||
                    this.ExtrinsicText2 != null &&
                    this.ExtrinsicText2.Equals(other.ExtrinsicText2)
                ) && 
                (
                    this.ExtrinsicText3 == other.ExtrinsicText3 ||
                    this.ExtrinsicText3 != null &&
                    this.ExtrinsicText3.Equals(other.ExtrinsicText3)
                ) && 
                (
                    this.ExtrinsicNumber1 == other.ExtrinsicNumber1 ||
                    this.ExtrinsicNumber1 != null &&
                    this.ExtrinsicNumber1.Equals(other.ExtrinsicNumber1)
                ) && 
                (
                    this.ExtrinsicNumber2 == other.ExtrinsicNumber2 ||
                    this.ExtrinsicNumber2 != null &&
                    this.ExtrinsicNumber2.Equals(other.ExtrinsicNumber2)
                ) && 
                (
                    this.ExtrinsicDecimal1 == other.ExtrinsicDecimal1 ||
                    this.ExtrinsicDecimal1 != null &&
                    this.ExtrinsicDecimal1.Equals(other.ExtrinsicDecimal1)
                ) && 
                (
                    this.ExtrinsicDecimal2 == other.ExtrinsicDecimal2 ||
                    this.ExtrinsicDecimal2 != null &&
                    this.ExtrinsicDecimal2.Equals(other.ExtrinsicDecimal2)
                ) && 
                (
                    this.CasebreakEnabled == other.CasebreakEnabled ||
                    this.CasebreakEnabled != null &&
                    this.CasebreakEnabled.Equals(other.CasebreakEnabled)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.VendorPrice == other.VendorPrice ||
                    this.VendorPrice != null &&
                    this.VendorPrice.Equals(other.VendorPrice)
                ) && 
                (
                    this.VendorPer == other.VendorPer ||
                    this.VendorPer != null &&
                    this.VendorPer.Equals(other.VendorPer)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.BehaviorType == other.BehaviorType ||
                    this.BehaviorType != null &&
                    this.BehaviorType.Equals(other.BehaviorType)
                ) && 
                (
                    this.ForwardLotMixingRule == other.ForwardLotMixingRule ||
                    this.ForwardLotMixingRule != null &&
                    this.ForwardLotMixingRule.Equals(other.ForwardLotMixingRule)
                ) && 
                (
                    this.StorageLotMixingRule == other.StorageLotMixingRule ||
                    this.StorageLotMixingRule != null &&
                    this.StorageLotMixingRule.Equals(other.StorageLotMixingRule)
                ) && 
                (
                    this.ForwardItemMixingRule == other.ForwardItemMixingRule ||
                    this.ForwardItemMixingRule != null &&
                    this.ForwardItemMixingRule.Equals(other.ForwardItemMixingRule)
                ) && 
                (
                    this.StorageItemMixingRule == other.StorageItemMixingRule ||
                    this.StorageItemMixingRule != null &&
                    this.StorageItemMixingRule.Equals(other.StorageItemMixingRule)
                ) && 
                (
                    this.AllocationRule == other.AllocationRule ||
                    this.AllocationRule != null &&
                    this.AllocationRule.Equals(other.AllocationRule)
                ) && 
                (
                    this.BarcodeField == other.BarcodeField ||
                    this.BarcodeField != null &&
                    this.BarcodeField.Equals(other.BarcodeField)
                ) && 
                (
                    this.WarehouseDisplayField == other.WarehouseDisplayField ||
                    this.WarehouseDisplayField != null &&
                    this.WarehouseDisplayField.Equals(other.WarehouseDisplayField)
                ) && 
                (
                    this.ProductIdTagSchemeId == other.ProductIdTagSchemeId ||
                    this.ProductIdTagSchemeId != null &&
                    this.ProductIdTagSchemeId.Equals(other.ProductIdTagSchemeId)
                ) && 
                (
                    this.Hazmat == other.Hazmat ||
                    this.Hazmat != null &&
                    this.Hazmat.Equals(other.Hazmat)
                ) && 
                (
                    this.IsAlcohol == other.IsAlcohol ||
                    this.IsAlcohol != null &&
                    this.IsAlcohol.Equals(other.IsAlcohol)
                ) && 
                (
                    this.AlcoholType == other.AlcoholType ||
                    this.AlcoholType != null &&
                    this.AlcoholType.Equals(other.AlcoholType)
                ) && 
                (
                    this.AlcoholContent == other.AlcoholContent ||
                    this.AlcoholContent != null &&
                    this.AlcoholContent.Equals(other.AlcoholContent)
                ) && 
                (
                    this.AlcoholContainer == other.AlcoholContainer ||
                    this.AlcoholContainer != null &&
                    this.AlcoholContainer.Equals(other.AlcoholContainer)
                ) && 
                (
                    this.AlcoholVintageYear == other.AlcoholVintageYear ||
                    this.AlcoholVintageYear != null &&
                    this.AlcoholVintageYear.Equals(other.AlcoholVintageYear)
                ) && 
                (
                    this.AlcoholCountry == other.AlcoholCountry ||
                    this.AlcoholCountry != null &&
                    this.AlcoholCountry.Equals(other.AlcoholCountry)
                ) && 
                (
                    this.AlcoholState == other.AlcoholState ||
                    this.AlcoholState != null &&
                    this.AlcoholState.Equals(other.AlcoholState)
                ) && 
                (
                    this.AlcoholRegion == other.AlcoholRegion ||
                    this.AlcoholRegion != null &&
                    this.AlcoholRegion.Equals(other.AlcoholRegion)
                ) && 
                (
                    this.AlcoholBrand == other.AlcoholBrand ||
                    this.AlcoholBrand != null &&
                    this.AlcoholBrand.Equals(other.AlcoholBrand)
                ) && 
                (
                    this.AlcoholUPCCode == other.AlcoholUPCCode ||
                    this.AlcoholUPCCode != null &&
                    this.AlcoholUPCCode.Equals(other.AlcoholUPCCode)
                ) && 
                (
                    this.AlcoholNAMBCACode == other.AlcoholNAMBCACode ||
                    this.AlcoholNAMBCACode != null &&
                    this.AlcoholNAMBCACode.Equals(other.AlcoholNAMBCACode)
                ) && 
                (
                    this.AlcoholUNIMERCCode == other.AlcoholUNIMERCCode ||
                    this.AlcoholUNIMERCCode != null &&
                    this.AlcoholUNIMERCCode.Equals(other.AlcoholUNIMERCCode)
                ) && 
                (
                    this.AlcoholSCCCode == other.AlcoholSCCCode ||
                    this.AlcoholSCCCode != null &&
                    this.AlcoholSCCCode.Equals(other.AlcoholSCCCode)
                ) && 
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.TopUp == other.TopUp ||
                    this.TopUp != null &&
                    this.TopUp.Equals(other.TopUp)
                ) && 
                (
                    this.ShipSolo == other.ShipSolo ||
                    this.ShipSolo != null &&
                    this.ShipSolo.Equals(other.ShipSolo)
                ) && 
                (
                    this.InventoryUpdateTimestamp == other.InventoryUpdateTimestamp ||
                    this.InventoryUpdateTimestamp != null &&
                    this.InventoryUpdateTimestamp.Equals(other.InventoryUpdateTimestamp)
                ) && 
                (
                    this.AvailableQuantity == other.AvailableQuantity ||
                    this.AvailableQuantity != null &&
                    this.AvailableQuantity.Equals(other.AvailableQuantity)
                ) && 
                (
                    this.DamagedQuantity == other.DamagedQuantity ||
                    this.DamagedQuantity != null &&
                    this.DamagedQuantity.Equals(other.DamagedQuantity)
                ) && 
                (
                    this.InFulfillmentProcessQuantity == other.InFulfillmentProcessQuantity ||
                    this.InFulfillmentProcessQuantity != null &&
                    this.InFulfillmentProcessQuantity.Equals(other.InFulfillmentProcessQuantity)
                ) && 
                (
                    this.OnHandQuantity == other.OnHandQuantity ||
                    this.OnHandQuantity != null &&
                    this.OnHandQuantity.Equals(other.OnHandQuantity)
                ) && 
                (
                    this.OpenOrderQuantity == other.OpenOrderQuantity ||
                    this.OpenOrderQuantity != null &&
                    this.OpenOrderQuantity.Equals(other.OpenOrderQuantity)
                ) && 
                (
                    this.OpenPOQuantity == other.OpenPOQuantity ||
                    this.OpenPOQuantity != null &&
                    this.OpenPOQuantity.Equals(other.OpenPOQuantity)
                ) && 
                (
                    this.OrderableQuantity == other.OrderableQuantity ||
                    this.OrderableQuantity != null &&
                    this.OrderableQuantity.Equals(other.OrderableQuantity)
                ) && 
                (
                    this.UnallocatableQuantity == other.UnallocatableQuantity ||
                    this.UnallocatableQuantity != null &&
                    this.UnallocatableQuantity.Equals(other.UnallocatableQuantity)
                ) && 
                (
                    this.UnavailableQuantity == other.UnavailableQuantity ||
                    this.UnavailableQuantity != null &&
                    this.UnavailableQuantity.Equals(other.UnavailableQuantity)
                ) && 
                (
                    this.OverallDaysOnHand == other.OverallDaysOnHand ||
                    this.OverallDaysOnHand != null &&
                    this.OverallDaysOnHand.Equals(other.OverallDaysOnHand)
                ) && 
                (
                    this.OverallStockStatus == other.OverallStockStatus ||
                    this.OverallStockStatus != null &&
                    this.OverallStockStatus.Equals(other.OverallStockStatus)
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
                
                if (this.AccountCodeId != null)
                    hash = hash * 59 + this.AccountCodeId.GetHashCode();
                
                if (this.LowStockContactId != null)
                    hash = hash * 59 + this.LowStockContactId.GetHashCode();
                
                if (this.LegacyLowLevelContactId != null)
                    hash = hash * 59 + this.LegacyLowLevelContactId.GetHashCode();
                
                if (this.LowStockCodeId != null)
                    hash = hash * 59 + this.LowStockCodeId.GetHashCode();
                
                if (this.MajorGroupId != null)
                    hash = hash * 59 + this.MajorGroupId.GetHashCode();
                
                if (this.SubGroupId != null)
                    hash = hash * 59 + this.SubGroupId.GetHashCode();
                
                if (this.ProductCodeId != null)
                    hash = hash * 59 + this.ProductCodeId.GetHashCode();
                
                if (this.SummaryCodeId != null)
                    hash = hash * 59 + this.SummaryCodeId.GetHashCode();
                
                if (this.BuyerId != null)
                    hash = hash * 59 + this.BuyerId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.VendorSKU != null)
                    hash = hash * 59 + this.VendorSKU.GetHashCode();
                
                if (this.Upc != null)
                    hash = hash * 59 + this.Upc.GetHashCode();
                
                if (this.ItemDescription != null)
                    hash = hash * 59 + this.ItemDescription.GetHashCode();
                
                if (this.PackingSlipDescription != null)
                    hash = hash * 59 + this.PackingSlipDescription.GetHashCode();
                
                if (this.AbsoluteMax != null)
                    hash = hash * 59 + this.AbsoluteMax.GetHashCode();
                
                if (this.AdditionalDescription != null)
                    hash = hash * 59 + this.AdditionalDescription.GetHashCode();
                
                if (this.Backorder != null)
                    hash = hash * 59 + this.Backorder.GetHashCode();
                
                if (this.ChargeCode != null)
                    hash = hash * 59 + this.ChargeCode.GetHashCode();
                
                if (this.CommodityCode != null)
                    hash = hash * 59 + this.CommodityCode.GetHashCode();
                
                if (this.CompCode != null)
                    hash = hash * 59 + this.CompCode.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.CriticalAmount != null)
                    hash = hash * 59 + this.CriticalAmount.GetHashCode();
                
                if (this.OverallFixedReorderPoint != null)
                    hash = hash * 59 + this.OverallFixedReorderPoint.GetHashCode();
                
                if (this.OverallLeadTime != null)
                    hash = hash * 59 + this.OverallLeadTime.GetHashCode();
                
                if (this.SellPrice != null)
                    hash = hash * 59 + this.SellPrice.GetHashCode();
                
                if (this.PricingPer != null)
                    hash = hash * 59 + this.PricingPer.GetHashCode();
                
                if (this.LotControlFlag != null)
                    hash = hash * 59 + this.LotControlFlag.GetHashCode();
                
                if (this.MaxCycle != null)
                    hash = hash * 59 + this.MaxCycle.GetHashCode();
                
                if (this.MaxInterim != null)
                    hash = hash * 59 + this.MaxInterim.GetHashCode();
                
                if (this.NumericSortOrder != null)
                    hash = hash * 59 + this.NumericSortOrder.GetHashCode();
                
                if (this.OutsideVendor != null)
                    hash = hash * 59 + this.OutsideVendor.GetHashCode();
                
                if (this.PickNo != null)
                    hash = hash * 59 + this.PickNo.GetHashCode();
                
                if (this.PodOrderSuffix != null)
                    hash = hash * 59 + this.PodOrderSuffix.GetHashCode();
                
                if (this.PodRevDate != null)
                    hash = hash * 59 + this.PodRevDate.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.SeasonalItem != null)
                    hash = hash * 59 + this.SeasonalItem.GetHashCode();
                
                if (this.RequiresProductionLot != null)
                    hash = hash * 59 + this.RequiresProductionLot.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                if (this.SerialCode != null)
                    hash = hash * 59 + this.SerialCode.GetHashCode();
                
                if (this.UnitCode != null)
                    hash = hash * 59 + this.UnitCode.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.VoidDate != null)
                    hash = hash * 59 + this.VoidDate.GetHashCode();
                
                if (this.WrapCode != null)
                    hash = hash * 59 + this.WrapCode.GetHashCode();
                
                if (this.ExtrinsicText1 != null)
                    hash = hash * 59 + this.ExtrinsicText1.GetHashCode();
                
                if (this.ExtrinsicText2 != null)
                    hash = hash * 59 + this.ExtrinsicText2.GetHashCode();
                
                if (this.ExtrinsicText3 != null)
                    hash = hash * 59 + this.ExtrinsicText3.GetHashCode();
                
                if (this.ExtrinsicNumber1 != null)
                    hash = hash * 59 + this.ExtrinsicNumber1.GetHashCode();
                
                if (this.ExtrinsicNumber2 != null)
                    hash = hash * 59 + this.ExtrinsicNumber2.GetHashCode();
                
                if (this.ExtrinsicDecimal1 != null)
                    hash = hash * 59 + this.ExtrinsicDecimal1.GetHashCode();
                
                if (this.ExtrinsicDecimal2 != null)
                    hash = hash * 59 + this.ExtrinsicDecimal2.GetHashCode();
                
                if (this.CasebreakEnabled != null)
                    hash = hash * 59 + this.CasebreakEnabled.GetHashCode();
                
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                
                if (this.VendorPrice != null)
                    hash = hash * 59 + this.VendorPrice.GetHashCode();
                
                if (this.VendorPer != null)
                    hash = hash * 59 + this.VendorPer.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.BehaviorType != null)
                    hash = hash * 59 + this.BehaviorType.GetHashCode();
                
                if (this.ForwardLotMixingRule != null)
                    hash = hash * 59 + this.ForwardLotMixingRule.GetHashCode();
                
                if (this.StorageLotMixingRule != null)
                    hash = hash * 59 + this.StorageLotMixingRule.GetHashCode();
                
                if (this.ForwardItemMixingRule != null)
                    hash = hash * 59 + this.ForwardItemMixingRule.GetHashCode();
                
                if (this.StorageItemMixingRule != null)
                    hash = hash * 59 + this.StorageItemMixingRule.GetHashCode();
                
                if (this.AllocationRule != null)
                    hash = hash * 59 + this.AllocationRule.GetHashCode();
                
                if (this.BarcodeField != null)
                    hash = hash * 59 + this.BarcodeField.GetHashCode();
                
                if (this.WarehouseDisplayField != null)
                    hash = hash * 59 + this.WarehouseDisplayField.GetHashCode();
                
                if (this.ProductIdTagSchemeId != null)
                    hash = hash * 59 + this.ProductIdTagSchemeId.GetHashCode();
                
                if (this.Hazmat != null)
                    hash = hash * 59 + this.Hazmat.GetHashCode();
                
                if (this.IsAlcohol != null)
                    hash = hash * 59 + this.IsAlcohol.GetHashCode();
                
                if (this.AlcoholType != null)
                    hash = hash * 59 + this.AlcoholType.GetHashCode();
                
                if (this.AlcoholContent != null)
                    hash = hash * 59 + this.AlcoholContent.GetHashCode();
                
                if (this.AlcoholContainer != null)
                    hash = hash * 59 + this.AlcoholContainer.GetHashCode();
                
                if (this.AlcoholVintageYear != null)
                    hash = hash * 59 + this.AlcoholVintageYear.GetHashCode();
                
                if (this.AlcoholCountry != null)
                    hash = hash * 59 + this.AlcoholCountry.GetHashCode();
                
                if (this.AlcoholState != null)
                    hash = hash * 59 + this.AlcoholState.GetHashCode();
                
                if (this.AlcoholRegion != null)
                    hash = hash * 59 + this.AlcoholRegion.GetHashCode();
                
                if (this.AlcoholBrand != null)
                    hash = hash * 59 + this.AlcoholBrand.GetHashCode();
                
                if (this.AlcoholUPCCode != null)
                    hash = hash * 59 + this.AlcoholUPCCode.GetHashCode();
                
                if (this.AlcoholNAMBCACode != null)
                    hash = hash * 59 + this.AlcoholNAMBCACode.GetHashCode();
                
                if (this.AlcoholUNIMERCCode != null)
                    hash = hash * 59 + this.AlcoholUNIMERCCode.GetHashCode();
                
                if (this.AlcoholSCCCode != null)
                    hash = hash * 59 + this.AlcoholSCCCode.GetHashCode();
                
                if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();
                
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                
                if (this.TopUp != null)
                    hash = hash * 59 + this.TopUp.GetHashCode();
                
                if (this.ShipSolo != null)
                    hash = hash * 59 + this.ShipSolo.GetHashCode();
                
                if (this.InventoryUpdateTimestamp != null)
                    hash = hash * 59 + this.InventoryUpdateTimestamp.GetHashCode();
                
                if (this.AvailableQuantity != null)
                    hash = hash * 59 + this.AvailableQuantity.GetHashCode();
                
                if (this.DamagedQuantity != null)
                    hash = hash * 59 + this.DamagedQuantity.GetHashCode();
                
                if (this.InFulfillmentProcessQuantity != null)
                    hash = hash * 59 + this.InFulfillmentProcessQuantity.GetHashCode();
                
                if (this.OnHandQuantity != null)
                    hash = hash * 59 + this.OnHandQuantity.GetHashCode();
                
                if (this.OpenOrderQuantity != null)
                    hash = hash * 59 + this.OpenOrderQuantity.GetHashCode();
                
                if (this.OpenPOQuantity != null)
                    hash = hash * 59 + this.OpenPOQuantity.GetHashCode();
                
                if (this.OrderableQuantity != null)
                    hash = hash * 59 + this.OrderableQuantity.GetHashCode();
                
                if (this.UnallocatableQuantity != null)
                    hash = hash * 59 + this.UnallocatableQuantity.GetHashCode();
                
                if (this.UnavailableQuantity != null)
                    hash = hash * 59 + this.UnavailableQuantity.GetHashCode();
                
                if (this.OverallDaysOnHand != null)
                    hash = hash * 59 + this.OverallDaysOnHand.GetHashCode();
                
                if (this.OverallStockStatus != null)
                    hash = hash * 59 + this.OverallStockStatus.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
