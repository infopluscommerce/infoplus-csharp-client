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
    public partial class OrderLineActivity :  IEquatable<OrderLineActivity>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineActivity" /> class.
        /// Initializes a new instance of the <see cref="OrderLineActivity" />class.
        /// </summary>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="ItemMajorGroupId">ItemMajorGroupId (required).</param>
        /// <param name="ItemSubGroupId">ItemSubGroupId (required).</param>
        /// <param name="ItemProductCodeId">ItemProductCodeId.</param>
        /// <param name="ItemAccountCodeId">ItemAccountCodeId (required).</param>
        /// <param name="ItemSummaryCodeId">ItemSummaryCodeId (required).</param>
        /// <param name="ItemLegacyLowStockContactId">ItemLegacyLowStockContactId (required).</param>
        /// <param name="AlternateUsage">AlternateUsage.</param>
        /// <param name="OrderStatusName">OrderStatusName.</param>
        /// <param name="CarrierId">CarrierId.</param>
        /// <param name="CarrierName">CarrierName.</param>
        /// <param name="MediaCode">MediaCode (required).</param>
        /// <param name="LegacyRestrictionType">LegacyRestrictionType (required).</param>
        /// <param name="ReqTypeName">ReqTypeName.</param>
        /// <param name="ServiceTypeId">ServiceTypeId.</param>
        /// <param name="ServiceTypeName">ServiceTypeName.</param>
        /// <param name="AlcoholOrderType">AlcoholOrderType.</param>
        /// <param name="DistributionChannel">DistributionChannel.</param>
        /// <param name="DistributionChannelName">DistributionChannelName.</param>
        /// <param name="PriorityCode">PriorityCode.</param>
        /// <param name="OrderDate">OrderDate (required).</param>
        /// <param name="CustomerOrderNo">CustomerOrderNo.</param>
        /// <param name="PriceLevel">PriceLevel.</param>
        /// <param name="OrderSourceId">OrderSourceId.</param>
        /// <param name="OrderSourceName">OrderSourceName.</param>
        /// <param name="IntegrationPartnerName">IntegrationPartnerName.</param>
        /// <param name="OrderLoadProgramName">OrderLoadProgramName.</param>
        /// <param name="ShipToAttention">ShipToAttention.</param>
        /// <param name="ShipToCompany">ShipToCompany.</param>
        /// <param name="ShipToStreet">ShipToStreet.</param>
        /// <param name="ShipToStreet2">ShipToStreet2.</param>
        /// <param name="ShipToStreet3">ShipToStreet3.</param>
        /// <param name="ShipToCity">ShipToCity.</param>
        /// <param name="ShipToState">ShipToState.</param>
        /// <param name="ShipToZip">ShipToZip.</param>
        /// <param name="ShipToCountry">ShipToCountry.</param>
        /// <param name="ShipToPhone">ShipToPhone.</param>
        /// <param name="ShipToEmail">ShipToEmail.</param>
        /// <param name="BillToAttention">BillToAttention.</param>
        /// <param name="BillToCompany">BillToCompany.</param>
        /// <param name="BillToStreet">BillToStreet.</param>
        /// <param name="BillToStreet2">BillToStreet2.</param>
        /// <param name="BillToStreet3">BillToStreet3.</param>
        /// <param name="BillToCity">BillToCity.</param>
        /// <param name="BillToState">BillToState.</param>
        /// <param name="BillToZip">BillToZip.</param>
        /// <param name="BillToCountry">BillToCountry.</param>
        /// <param name="BillToPhone">BillToPhone.</param>
        /// <param name="BillToEmail">BillToEmail.</param>
        /// <param name="HoldCode">HoldCode.</param>
        /// <param name="ShipCode">ShipCode.</param>
        /// <param name="OrderMessage">OrderMessage.</param>
        /// <param name="Division">Division.</param>
        /// <param name="CostCenter">CostCenter.</param>
        /// <param name="AuthorizedBy">AuthorizedBy.</param>
        /// <param name="BatchNo">BatchNo.</param>
        /// <param name="FirstShipDate">FirstShipDate.</param>
        /// <param name="LastShipDate">LastShipDate.</param>
        /// <param name="DeliverOnDate">DeliverOnDate.</param>
        /// <param name="CustomerPONo">CustomerPONo.</param>
        /// <param name="ShipVia">ShipVia.</param>
        /// <param name="NeedByDate">NeedByDate.</param>
        /// <param name="Total">Total.</param>
        /// <param name="Subtotal">Subtotal.</param>
        /// <param name="TaxOnFreight">TaxOnFreight.</param>
        /// <param name="Tax">Tax.</param>
        /// <param name="ShippingCharge">ShippingCharge.</param>
        /// <param name="TotalDiscount">TotalDiscount.</param>
        /// <param name="PackingSlipTemplateId">PackingSlipTemplateId.</param>
        /// <param name="GiftMessage">GiftMessage.</param>
        /// <param name="BranchSector">BranchSector.</param>
        /// <param name="BranchArea">BranchArea.</param>
        /// <param name="BranchCustomerType">BranchCustomerType.</param>
        /// <param name="BranchId">BranchId.</param>
        /// <param name="OrderCode">OrderCode.</param>
        /// <param name="LeadPackageId">LeadPackageId.</param>
        /// <param name="OrderConfirmationEmailTemplateId">OrderConfirmationEmailTemplateId.</param>
        /// <param name="ShipmentConfirmationEmailTemplateId">ShipmentConfirmationEmailTemplateId.</param>
        /// <param name="OrderInvoiceTemplateId">OrderInvoiceTemplateId.</param>
        /// <param name="PriceMode">PriceMode.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public OrderLineActivity(DateTime? CreateDate = null, DateTime? ModifyDate = null, int? LobId = null, int? ItemMajorGroupId = null, int? ItemSubGroupId = null, int? ItemProductCodeId = null, int? ItemAccountCodeId = null, int? ItemSummaryCodeId = null, int? ItemLegacyLowStockContactId = null, string AlternateUsage = null, string OrderStatusName = null, int? CarrierId = null, string CarrierName = null, string MediaCode = null, string LegacyRestrictionType = null, string ReqTypeName = null, string ServiceTypeId = null, string ServiceTypeName = null, string AlcoholOrderType = null, string DistributionChannel = null, string DistributionChannelName = null, int? PriorityCode = null, DateTime? OrderDate = null, string CustomerOrderNo = null, string PriceLevel = null, int? OrderSourceId = null, string OrderSourceName = null, string IntegrationPartnerName = null, string OrderLoadProgramName = null, string ShipToAttention = null, string ShipToCompany = null, string ShipToStreet = null, string ShipToStreet2 = null, string ShipToStreet3 = null, string ShipToCity = null, string ShipToState = null, string ShipToZip = null, string ShipToCountry = null, string ShipToPhone = null, string ShipToEmail = null, string BillToAttention = null, string BillToCompany = null, string BillToStreet = null, string BillToStreet2 = null, string BillToStreet3 = null, string BillToCity = null, string BillToState = null, string BillToZip = null, string BillToCountry = null, string BillToPhone = null, string BillToEmail = null, string HoldCode = null, string ShipCode = null, string OrderMessage = null, int? Division = null, string CostCenter = null, string AuthorizedBy = null, string BatchNo = null, DateTime? FirstShipDate = null, DateTime? LastShipDate = null, DateTime? DeliverOnDate = null, string CustomerPONo = null, string ShipVia = null, DateTime? NeedByDate = null, double? Total = null, double? Subtotal = null, double? TaxOnFreight = null, double? Tax = null, double? ShippingCharge = null, double? TotalDiscount = null, int? PackingSlipTemplateId = null, string GiftMessage = null, string BranchSector = null, string BranchArea = null, string BranchCustomerType = null, string BranchId = null, string OrderCode = null, string LeadPackageId = null, int? OrderConfirmationEmailTemplateId = null, int? ShipmentConfirmationEmailTemplateId = null, int? OrderInvoiceTemplateId = null, string PriceMode = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "ItemMajorGroupId" is required (not null)
            if (ItemMajorGroupId == null)
            {
                throw new InvalidDataException("ItemMajorGroupId is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.ItemMajorGroupId = ItemMajorGroupId;
            }
            // to ensure "ItemSubGroupId" is required (not null)
            if (ItemSubGroupId == null)
            {
                throw new InvalidDataException("ItemSubGroupId is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.ItemSubGroupId = ItemSubGroupId;
            }
            // to ensure "ItemAccountCodeId" is required (not null)
            if (ItemAccountCodeId == null)
            {
                throw new InvalidDataException("ItemAccountCodeId is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.ItemAccountCodeId = ItemAccountCodeId;
            }
            // to ensure "ItemSummaryCodeId" is required (not null)
            if (ItemSummaryCodeId == null)
            {
                throw new InvalidDataException("ItemSummaryCodeId is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.ItemSummaryCodeId = ItemSummaryCodeId;
            }
            // to ensure "ItemLegacyLowStockContactId" is required (not null)
            if (ItemLegacyLowStockContactId == null)
            {
                throw new InvalidDataException("ItemLegacyLowStockContactId is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.ItemLegacyLowStockContactId = ItemLegacyLowStockContactId;
            }
            // to ensure "MediaCode" is required (not null)
            if (MediaCode == null)
            {
                throw new InvalidDataException("MediaCode is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.MediaCode = MediaCode;
            }
            // to ensure "LegacyRestrictionType" is required (not null)
            if (LegacyRestrictionType == null)
            {
                throw new InvalidDataException("LegacyRestrictionType is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.LegacyRestrictionType = LegacyRestrictionType;
            }
            // to ensure "OrderDate" is required (not null)
            if (OrderDate == null)
            {
                throw new InvalidDataException("OrderDate is a required property for OrderLineActivity and cannot be null");
            }
            else
            {
                this.OrderDate = OrderDate;
            }
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.ItemProductCodeId = ItemProductCodeId;
            this.AlternateUsage = AlternateUsage;
            this.OrderStatusName = OrderStatusName;
            this.CarrierId = CarrierId;
            this.CarrierName = CarrierName;
            this.ReqTypeName = ReqTypeName;
            this.ServiceTypeId = ServiceTypeId;
            this.ServiceTypeName = ServiceTypeName;
            this.AlcoholOrderType = AlcoholOrderType;
            this.DistributionChannel = DistributionChannel;
            this.DistributionChannelName = DistributionChannelName;
            this.PriorityCode = PriorityCode;
            this.CustomerOrderNo = CustomerOrderNo;
            this.PriceLevel = PriceLevel;
            this.OrderSourceId = OrderSourceId;
            this.OrderSourceName = OrderSourceName;
            this.IntegrationPartnerName = IntegrationPartnerName;
            this.OrderLoadProgramName = OrderLoadProgramName;
            this.ShipToAttention = ShipToAttention;
            this.ShipToCompany = ShipToCompany;
            this.ShipToStreet = ShipToStreet;
            this.ShipToStreet2 = ShipToStreet2;
            this.ShipToStreet3 = ShipToStreet3;
            this.ShipToCity = ShipToCity;
            this.ShipToState = ShipToState;
            this.ShipToZip = ShipToZip;
            this.ShipToCountry = ShipToCountry;
            this.ShipToPhone = ShipToPhone;
            this.ShipToEmail = ShipToEmail;
            this.BillToAttention = BillToAttention;
            this.BillToCompany = BillToCompany;
            this.BillToStreet = BillToStreet;
            this.BillToStreet2 = BillToStreet2;
            this.BillToStreet3 = BillToStreet3;
            this.BillToCity = BillToCity;
            this.BillToState = BillToState;
            this.BillToZip = BillToZip;
            this.BillToCountry = BillToCountry;
            this.BillToPhone = BillToPhone;
            this.BillToEmail = BillToEmail;
            this.HoldCode = HoldCode;
            this.ShipCode = ShipCode;
            this.OrderMessage = OrderMessage;
            this.Division = Division;
            this.CostCenter = CostCenter;
            this.AuthorizedBy = AuthorizedBy;
            this.BatchNo = BatchNo;
            this.FirstShipDate = FirstShipDate;
            this.LastShipDate = LastShipDate;
            this.DeliverOnDate = DeliverOnDate;
            this.CustomerPONo = CustomerPONo;
            this.ShipVia = ShipVia;
            this.NeedByDate = NeedByDate;
            this.Total = Total;
            this.Subtotal = Subtotal;
            this.TaxOnFreight = TaxOnFreight;
            this.Tax = Tax;
            this.ShippingCharge = ShippingCharge;
            this.TotalDiscount = TotalDiscount;
            this.PackingSlipTemplateId = PackingSlipTemplateId;
            this.GiftMessage = GiftMessage;
            this.BranchSector = BranchSector;
            this.BranchArea = BranchArea;
            this.BranchCustomerType = BranchCustomerType;
            this.BranchId = BranchId;
            this.OrderCode = OrderCode;
            this.LeadPackageId = LeadPackageId;
            this.OrderConfirmationEmailTemplateId = OrderConfirmationEmailTemplateId;
            this.ShipmentConfirmationEmailTemplateId = ShipmentConfirmationEmailTemplateId;
            this.OrderInvoiceTemplateId = OrderInvoiceTemplateId;
            this.PriceMode = PriceMode;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
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
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
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
        /// Gets or Sets OrderCreateDate
        /// </summary>
        [DataMember(Name="orderCreateDate", EmitDefaultValue=false)]
        public DateTime? OrderCreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderModifyDate
        /// </summary>
        [DataMember(Name="orderModifyDate", EmitDefaultValue=false)]
        public DateTime? OrderModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets CrossDock
        /// </summary>
        [DataMember(Name="crossDock", EmitDefaultValue=false)]
        public int? CrossDock { get; private set; }
    
        /// <summary>
        /// Gets or Sets ProcessNoId
        /// </summary>
        [DataMember(Name="processNoId", EmitDefaultValue=false)]
        public int? ProcessNoId { get; private set; }
    
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
        /// Gets or Sets AdjustCode
        /// </summary>
        [DataMember(Name="adjustCode", EmitDefaultValue=false)]
        public int? AdjustCode { get; private set; }
    
        /// <summary>
        /// Gets or Sets ProcessFlag
        /// </summary>
        [DataMember(Name="processFlag", EmitDefaultValue=false)]
        public string ProcessFlag { get; private set; }
    
        /// <summary>
        /// Gets or Sets RevDate
        /// </summary>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets RestrictionRule
        /// </summary>
        [DataMember(Name="restrictionRule", EmitDefaultValue=false)]
        public int? RestrictionRule { get; private set; }
    
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
        /// Gets or Sets Per
        /// </summary>
        [DataMember(Name="per", EmitDefaultValue=false)]
        public string Per { get; private set; }
    
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
        /// Gets or Sets ItemMajorGroupId
        /// </summary>
        [DataMember(Name="itemMajorGroupId", EmitDefaultValue=false)]
        public int? ItemMajorGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterMajorGroupName
        /// </summary>
        [DataMember(Name="masterMajorGroupName", EmitDefaultValue=false)]
        public string MasterMajorGroupName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemSubGroupId
        /// </summary>
        [DataMember(Name="itemSubGroupId", EmitDefaultValue=false)]
        public int? ItemSubGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterSubGroupName
        /// </summary>
        [DataMember(Name="masterSubGroupName", EmitDefaultValue=false)]
        public string MasterSubGroupName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemProductCodeId
        /// </summary>
        [DataMember(Name="itemProductCodeId", EmitDefaultValue=false)]
        public int? ItemProductCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterProductionCodeName
        /// </summary>
        [DataMember(Name="masterProductionCodeName", EmitDefaultValue=false)]
        public string MasterProductionCodeName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemAccountCodeId
        /// </summary>
        [DataMember(Name="itemAccountCodeId", EmitDefaultValue=false)]
        public int? ItemAccountCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterAccountCodeName
        /// </summary>
        [DataMember(Name="masterAccountCodeName", EmitDefaultValue=false)]
        public string MasterAccountCodeName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemSummaryCodeId
        /// </summary>
        [DataMember(Name="itemSummaryCodeId", EmitDefaultValue=false)]
        public int? ItemSummaryCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterSummaryCodeName
        /// </summary>
        [DataMember(Name="masterSummaryCodeName", EmitDefaultValue=false)]
        public string MasterSummaryCodeName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemLegacyLowStockContactId
        /// </summary>
        [DataMember(Name="itemLegacyLowStockContactId", EmitDefaultValue=false)]
        public int? ItemLegacyLowStockContactId { get; set; }
    
        /// <summary>
        /// Gets or Sets LowStockContactName
        /// </summary>
        [DataMember(Name="lowStockContactName", EmitDefaultValue=false)]
        public string LowStockContactName { get; private set; }
    
        /// <summary>
        /// Gets or Sets Sector
        /// </summary>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; private set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; private set; }
    
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
        /// Gets or Sets NumberOfWraps
        /// </summary>
        [DataMember(Name="numberOfWraps", EmitDefaultValue=false)]
        public int? NumberOfWraps { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfCases
        /// </summary>
        [DataMember(Name="numberOfCases", EmitDefaultValue=false)]
        public int? NumberOfCases { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfTouches
        /// </summary>
        [DataMember(Name="numberOfTouches", EmitDefaultValue=false)]
        public int? NumberOfTouches { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholTypeId
        /// </summary>
        [DataMember(Name="alcoholTypeId", EmitDefaultValue=false)]
        public int? AlcoholTypeId { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholTypeName
        /// </summary>
        [DataMember(Name="alcoholTypeName", EmitDefaultValue=false)]
        public string AlcoholTypeName { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholContent
        /// </summary>
        [DataMember(Name="alcoholContent", EmitDefaultValue=false)]
        public double? AlcoholContent { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholContainerId
        /// </summary>
        [DataMember(Name="alcoholContainerId", EmitDefaultValue=false)]
        public int? AlcoholContainerId { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholContainerName
        /// </summary>
        [DataMember(Name="alcoholContainerName", EmitDefaultValue=false)]
        public string AlcoholContainerName { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholContainerVolume
        /// </summary>
        [DataMember(Name="alcoholContainerVolume", EmitDefaultValue=false)]
        public int? AlcoholContainerVolume { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholVintageYear
        /// </summary>
        [DataMember(Name="alcoholVintageYear", EmitDefaultValue=false)]
        public string AlcoholVintageYear { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholCountryId
        /// </summary>
        [DataMember(Name="alcoholCountryId", EmitDefaultValue=false)]
        public int? AlcoholCountryId { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholCountryName
        /// </summary>
        [DataMember(Name="alcoholCountryName", EmitDefaultValue=false)]
        public string AlcoholCountryName { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholState
        /// </summary>
        [DataMember(Name="alcoholState", EmitDefaultValue=false)]
        public string AlcoholState { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholRegion
        /// </summary>
        [DataMember(Name="alcoholRegion", EmitDefaultValue=false)]
        public string AlcoholRegion { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholBrand
        /// </summary>
        [DataMember(Name="alcoholBrand", EmitDefaultValue=false)]
        public string AlcoholBrand { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholUPCCode
        /// </summary>
        [DataMember(Name="alcoholUPCCode", EmitDefaultValue=false)]
        public string AlcoholUPCCode { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholNABCACode
        /// </summary>
        [DataMember(Name="alcoholNABCACode", EmitDefaultValue=false)]
        public string AlcoholNABCACode { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholUNIMERCCode
        /// </summary>
        [DataMember(Name="alcoholUNIMERCCode", EmitDefaultValue=false)]
        public string AlcoholUNIMERCCode { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlcoholSCCCode
        /// </summary>
        [DataMember(Name="alcoholSCCCode", EmitDefaultValue=false)]
        public string AlcoholSCCCode { get; private set; }
    
        /// <summary>
        /// Gets or Sets AlternateUsage
        /// </summary>
        [DataMember(Name="alternateUsage", EmitDefaultValue=false)]
        public string AlternateUsage { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupOrderId
        /// </summary>
        [DataMember(Name="groupOrderId", EmitDefaultValue=false)]
        public double? GroupOrderId { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name="orderStatus", EmitDefaultValue=false)]
        public string OrderStatus { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderStatusName
        /// </summary>
        [DataMember(Name="orderStatusName", EmitDefaultValue=false)]
        public string OrderStatusName { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name="carrierId", EmitDefaultValue=false)]
        public int? CarrierId { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierName
        /// </summary>
        [DataMember(Name="carrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }
    
        /// <summary>
        /// Gets or Sets MediaCode
        /// </summary>
        [DataMember(Name="mediaCode", EmitDefaultValue=false)]
        public string MediaCode { get; set; }
    
        /// <summary>
        /// Gets or Sets LegacyRestrictionType
        /// </summary>
        [DataMember(Name="legacyRestrictionType", EmitDefaultValue=false)]
        public string LegacyRestrictionType { get; set; }
    
        /// <summary>
        /// Gets or Sets ReqTypeName
        /// </summary>
        [DataMember(Name="reqTypeName", EmitDefaultValue=false)]
        public string ReqTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets ServiceTypeId
        /// </summary>
        [DataMember(Name="serviceTypeId", EmitDefaultValue=false)]
        public string ServiceTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets ServiceTypeName
        /// </summary>
        [DataMember(Name="serviceTypeName", EmitDefaultValue=false)]
        public string ServiceTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets AlcoholOrderType
        /// </summary>
        [DataMember(Name="alcoholOrderType", EmitDefaultValue=false)]
        public string AlcoholOrderType { get; set; }
    
        /// <summary>
        /// Gets or Sets DistributionChannel
        /// </summary>
        [DataMember(Name="distributionChannel", EmitDefaultValue=false)]
        public string DistributionChannel { get; set; }
    
        /// <summary>
        /// Gets or Sets DistributionChannelName
        /// </summary>
        [DataMember(Name="distributionChannelName", EmitDefaultValue=false)]
        public string DistributionChannelName { get; set; }
    
        /// <summary>
        /// Gets or Sets PriorityCode
        /// </summary>
        [DataMember(Name="priorityCode", EmitDefaultValue=false)]
        public int? PriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }
    
        /// <summary>
        /// Gets or Sets EnteredBy
        /// </summary>
        [DataMember(Name="enteredBy", EmitDefaultValue=false)]
        public string EnteredBy { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderReason
        /// </summary>
        [DataMember(Name="orderReason", EmitDefaultValue=false)]
        public int? OrderReason { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomerOrderNo
        /// </summary>
        [DataMember(Name="customerOrderNo", EmitDefaultValue=false)]
        public string CustomerOrderNo { get; set; }
    
        /// <summary>
        /// Gets or Sets PriceLevel
        /// </summary>
        [DataMember(Name="priceLevel", EmitDefaultValue=false)]
        public string PriceLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipBy
        /// </summary>
        [DataMember(Name="shipBy", EmitDefaultValue=false)]
        public DateTime? ShipBy { get; private set; }
    
        /// <summary>
        /// Gets or Sets StopBackOrders
        /// </summary>
        [DataMember(Name="stopBackOrders", EmitDefaultValue=false)]
        public string StopBackOrders { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceName
        /// </summary>
        [DataMember(Name="orderSourceName", EmitDefaultValue=false)]
        public string OrderSourceName { get; set; }
    
        /// <summary>
        /// Gets or Sets IntegrationPartnerId
        /// </summary>
        [DataMember(Name="integrationPartnerId", EmitDefaultValue=false)]
        public int? IntegrationPartnerId { get; private set; }
    
        /// <summary>
        /// Gets or Sets IntegrationPartnerName
        /// </summary>
        [DataMember(Name="integrationPartnerName", EmitDefaultValue=false)]
        public string IntegrationPartnerName { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderLoadProgramId
        /// </summary>
        [DataMember(Name="orderLoadProgramId", EmitDefaultValue=false)]
        public int? OrderLoadProgramId { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderLoadProgramName
        /// </summary>
        [DataMember(Name="orderLoadProgramName", EmitDefaultValue=false)]
        public string OrderLoadProgramName { get; set; }
    
        /// <summary>
        /// Gets or Sets OmsOrderNo
        /// </summary>
        [DataMember(Name="omsOrderNo", EmitDefaultValue=false)]
        public int? OmsOrderNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets OmsCustomerId
        /// </summary>
        [DataMember(Name="omsCustomerId", EmitDefaultValue=false)]
        public int? OmsCustomerId { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToAttention
        /// </summary>
        [DataMember(Name="shipToAttention", EmitDefaultValue=false)]
        public string ShipToAttention { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToCompany
        /// </summary>
        [DataMember(Name="shipToCompany", EmitDefaultValue=false)]
        public string ShipToCompany { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet
        /// </summary>
        [DataMember(Name="shipToStreet", EmitDefaultValue=false)]
        public string ShipToStreet { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet2
        /// </summary>
        [DataMember(Name="shipToStreet2", EmitDefaultValue=false)]
        public string ShipToStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet3
        /// </summary>
        [DataMember(Name="shipToStreet3", EmitDefaultValue=false)]
        public string ShipToStreet3 { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToCity
        /// </summary>
        [DataMember(Name="shipToCity", EmitDefaultValue=false)]
        public string ShipToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name="shipToState", EmitDefaultValue=false)]
        public string ShipToState { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToZip
        /// </summary>
        [DataMember(Name="shipToZip", EmitDefaultValue=false)]
        public string ShipToZip { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToCountry
        /// </summary>
        [DataMember(Name="shipToCountry", EmitDefaultValue=false)]
        public string ShipToCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToPhone
        /// </summary>
        [DataMember(Name="shipToPhone", EmitDefaultValue=false)]
        public string ShipToPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToEmail
        /// </summary>
        [DataMember(Name="shipToEmail", EmitDefaultValue=false)]
        public string ShipToEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToAttention
        /// </summary>
        [DataMember(Name="billToAttention", EmitDefaultValue=false)]
        public string BillToAttention { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCompany
        /// </summary>
        [DataMember(Name="billToCompany", EmitDefaultValue=false)]
        public string BillToCompany { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToStreet
        /// </summary>
        [DataMember(Name="billToStreet", EmitDefaultValue=false)]
        public string BillToStreet { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToStreet2
        /// </summary>
        [DataMember(Name="billToStreet2", EmitDefaultValue=false)]
        public string BillToStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToStreet3
        /// </summary>
        [DataMember(Name="billToStreet3", EmitDefaultValue=false)]
        public string BillToStreet3 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCity
        /// </summary>
        [DataMember(Name="billToCity", EmitDefaultValue=false)]
        public string BillToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToState
        /// </summary>
        [DataMember(Name="billToState", EmitDefaultValue=false)]
        public string BillToState { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToZip
        /// </summary>
        [DataMember(Name="billToZip", EmitDefaultValue=false)]
        public string BillToZip { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCountry
        /// </summary>
        [DataMember(Name="billToCountry", EmitDefaultValue=false)]
        public string BillToCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToPhone
        /// </summary>
        [DataMember(Name="billToPhone", EmitDefaultValue=false)]
        public string BillToPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToEmail
        /// </summary>
        [DataMember(Name="billToEmail", EmitDefaultValue=false)]
        public string BillToEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderShipDate
        /// </summary>
        [DataMember(Name="orderShipDate", EmitDefaultValue=false)]
        public DateTime? OrderShipDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="freight", EmitDefaultValue=false)]
        public double? Freight { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderWeightLbs
        /// </summary>
        [DataMember(Name="orderWeightLbs", EmitDefaultValue=false)]
        public double? OrderWeightLbs { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderEstimatedWeightLbs
        /// </summary>
        [DataMember(Name="orderEstimatedWeightLbs", EmitDefaultValue=false)]
        public double? OrderEstimatedWeightLbs { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfPallets
        /// </summary>
        [DataMember(Name="numberOfPallets", EmitDefaultValue=false)]
        public int? NumberOfPallets { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfLineItems
        /// </summary>
        [DataMember(Name="numberOfLineItems", EmitDefaultValue=false)]
        public int? NumberOfLineItems { get; private set; }
    
        /// <summary>
        /// Gets or Sets CompletionStatus
        /// </summary>
        [DataMember(Name="completionStatus", EmitDefaultValue=false)]
        public string CompletionStatus { get; private set; }
    
        /// <summary>
        /// Gets or Sets HoldCode
        /// </summary>
        [DataMember(Name="holdCode", EmitDefaultValue=false)]
        public string HoldCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipCode
        /// </summary>
        [DataMember(Name="shipCode", EmitDefaultValue=false)]
        public string ShipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderMessage
        /// </summary>
        [DataMember(Name="orderMessage", EmitDefaultValue=false)]
        public string OrderMessage { get; set; }
    
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public int? Division { get; set; }
    
        /// <summary>
        /// Gets or Sets CostCenter
        /// </summary>
        [DataMember(Name="costCenter", EmitDefaultValue=false)]
        public string CostCenter { get; set; }
    
        /// <summary>
        /// Gets or Sets AuthorizedBy
        /// </summary>
        [DataMember(Name="authorizedBy", EmitDefaultValue=false)]
        public string AuthorizedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets BatchNo
        /// </summary>
        [DataMember(Name="batchNo", EmitDefaultValue=false)]
        public string BatchNo { get; set; }
    
        /// <summary>
        /// Gets or Sets FirstShipDate
        /// </summary>
        [DataMember(Name="firstShipDate", EmitDefaultValue=false)]
        public DateTime? FirstShipDate { get; set; }
    
        /// <summary>
        /// Gets or Sets LastShipDate
        /// </summary>
        [DataMember(Name="lastShipDate", EmitDefaultValue=false)]
        public DateTime? LastShipDate { get; set; }
    
        /// <summary>
        /// Gets or Sets DeliverOnDate
        /// </summary>
        [DataMember(Name="deliverOnDate", EmitDefaultValue=false)]
        public DateTime? DeliverOnDate { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerPONo
        /// </summary>
        [DataMember(Name="customerPONo", EmitDefaultValue=false)]
        public string CustomerPONo { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipVia
        /// </summary>
        [DataMember(Name="shipVia", EmitDefaultValue=false)]
        public string ShipVia { get; set; }
    
        /// <summary>
        /// Gets or Sets NeedByDate
        /// </summary>
        [DataMember(Name="needByDate", EmitDefaultValue=false)]
        public DateTime? NeedByDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; set; }
    
        /// <summary>
        /// Gets or Sets BalanceDue
        /// </summary>
        [DataMember(Name="balanceDue", EmitDefaultValue=false)]
        public double? BalanceDue { get; private set; }
    
        /// <summary>
        /// Gets or Sets TotalPaid
        /// </summary>
        [DataMember(Name="totalPaid", EmitDefaultValue=false)]
        public double? TotalPaid { get; private set; }
    
        /// <summary>
        /// Gets or Sets AuthorizationAmount
        /// </summary>
        [DataMember(Name="authorizationAmount", EmitDefaultValue=false)]
        public double? AuthorizationAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; set; }
    
        /// <summary>
        /// Gets or Sets TaxOnFreight
        /// </summary>
        [DataMember(Name="taxOnFreight", EmitDefaultValue=false)]
        public double? TaxOnFreight { get; set; }
    
        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public double? Tax { get; set; }
    
        /// <summary>
        /// Gets or Sets DistributionCharges
        /// </summary>
        [DataMember(Name="distributionCharges", EmitDefaultValue=false)]
        public double? DistributionCharges { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShippingCharge
        /// </summary>
        [DataMember(Name="shippingCharge", EmitDefaultValue=false)]
        public double? ShippingCharge { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalDiscount
        /// </summary>
        [DataMember(Name="totalDiscount", EmitDefaultValue=false)]
        public double? TotalDiscount { get; set; }
    
        /// <summary>
        /// Gets or Sets ParcelAccountId
        /// </summary>
        [DataMember(Name="parcelAccountId", EmitDefaultValue=false)]
        public int? ParcelAccountId { get; private set; }
    
        /// <summary>
        /// Gets or Sets PackingSlipTemplateId
        /// </summary>
        [DataMember(Name="packingSlipTemplateId", EmitDefaultValue=false)]
        public int? PackingSlipTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets GiftMessage
        /// </summary>
        [DataMember(Name="giftMessage", EmitDefaultValue=false)]
        public string GiftMessage { get; set; }
    
        /// <summary>
        /// Gets or Sets BranchSector
        /// </summary>
        [DataMember(Name="branchSector", EmitDefaultValue=false)]
        public string BranchSector { get; set; }
    
        /// <summary>
        /// Gets or Sets BranchArea
        /// </summary>
        [DataMember(Name="branchArea", EmitDefaultValue=false)]
        public string BranchArea { get; set; }
    
        /// <summary>
        /// Gets or Sets BranchCustomerType
        /// </summary>
        [DataMember(Name="branchCustomerType", EmitDefaultValue=false)]
        public string BranchCustomerType { get; set; }
    
        /// <summary>
        /// Gets or Sets BranchId
        /// </summary>
        [DataMember(Name="branchId", EmitDefaultValue=false)]
        public string BranchId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderCode
        /// </summary>
        [DataMember(Name="orderCode", EmitDefaultValue=false)]
        public string OrderCode { get; set; }
    
        /// <summary>
        /// Gets or Sets LeadPackageId
        /// </summary>
        [DataMember(Name="leadPackageId", EmitDefaultValue=false)]
        public string LeadPackageId { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalQty
        /// </summary>
        [DataMember(Name="totalQty", EmitDefaultValue=false)]
        public int? TotalQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets EstimatedNumberOfPicks
        /// </summary>
        [DataMember(Name="estimatedNumberOfPicks", EmitDefaultValue=false)]
        public int? EstimatedNumberOfPicks { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderConfirmationEmailTemplateId
        /// </summary>
        [DataMember(Name="orderConfirmationEmailTemplateId", EmitDefaultValue=false)]
        public int? OrderConfirmationEmailTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipmentConfirmationEmailTemplateId
        /// </summary>
        [DataMember(Name="shipmentConfirmationEmailTemplateId", EmitDefaultValue=false)]
        public int? ShipmentConfirmationEmailTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderInvoiceTemplateId
        /// </summary>
        [DataMember(Name="orderInvoiceTemplateId", EmitDefaultValue=false)]
        public int? OrderInvoiceTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets PriceMode
        /// </summary>
        [DataMember(Name="priceMode", EmitDefaultValue=false)]
        public string PriceMode { get; set; }
    
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
            sb.Append("class OrderLineActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  OrderCreateDate: ").Append(OrderCreateDate).Append("\n");
            sb.Append("  OrderModifyDate: ").Append(OrderModifyDate).Append("\n");
            sb.Append("  CrossDock: ").Append(CrossDock).Append("\n");
            sb.Append("  ProcessNoId: ").Append(ProcessNoId).Append("\n");
            sb.Append("  OrderedQty: ").Append(OrderedQty).Append("\n");
            sb.Append("  AllowedQty: ").Append(AllowedQty).Append("\n");
            sb.Append("  ShippedQty: ").Append(ShippedQty).Append("\n");
            sb.Append("  BackorderQty: ").Append(BackorderQty).Append("\n");
            sb.Append("  AdjustCode: ").Append(AdjustCode).Append("\n");
            sb.Append("  ProcessFlag: ").Append(ProcessFlag).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  RestrictionRule: ").Append(RestrictionRule).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitSell: ").Append(UnitSell).Append("\n");
            sb.Append("  UnitDiscount: ").Append(UnitDiscount).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  ExtendedSell: ").Append(ExtendedSell).Append("\n");
            sb.Append("  ExtendedDiscount: ").Append(ExtendedDiscount).Append("\n");
            sb.Append("  NcExtendedSell: ").Append(NcExtendedSell).Append("\n");
            sb.Append("  Per: ").Append(Per).Append("\n");
            sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
            sb.Append("  DistributionCode: ").Append(DistributionCode).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
            sb.Append("  OrderSourceSKU: ").Append(OrderSourceSKU).Append("\n");
            sb.Append("  ItemMajorGroupId: ").Append(ItemMajorGroupId).Append("\n");
            sb.Append("  MasterMajorGroupName: ").Append(MasterMajorGroupName).Append("\n");
            sb.Append("  ItemSubGroupId: ").Append(ItemSubGroupId).Append("\n");
            sb.Append("  MasterSubGroupName: ").Append(MasterSubGroupName).Append("\n");
            sb.Append("  ItemProductCodeId: ").Append(ItemProductCodeId).Append("\n");
            sb.Append("  MasterProductionCodeName: ").Append(MasterProductionCodeName).Append("\n");
            sb.Append("  ItemAccountCodeId: ").Append(ItemAccountCodeId).Append("\n");
            sb.Append("  MasterAccountCodeName: ").Append(MasterAccountCodeName).Append("\n");
            sb.Append("  ItemSummaryCodeId: ").Append(ItemSummaryCodeId).Append("\n");
            sb.Append("  MasterSummaryCodeName: ").Append(MasterSummaryCodeName).Append("\n");
            sb.Append("  ItemLegacyLowStockContactId: ").Append(ItemLegacyLowStockContactId).Append("\n");
            sb.Append("  LowStockContactName: ").Append(LowStockContactName).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  ItemWeight: ").Append(ItemWeight).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  NumberOfWraps: ").Append(NumberOfWraps).Append("\n");
            sb.Append("  NumberOfCases: ").Append(NumberOfCases).Append("\n");
            sb.Append("  NumberOfTouches: ").Append(NumberOfTouches).Append("\n");
            sb.Append("  AlcoholTypeId: ").Append(AlcoholTypeId).Append("\n");
            sb.Append("  AlcoholTypeName: ").Append(AlcoholTypeName).Append("\n");
            sb.Append("  AlcoholContent: ").Append(AlcoholContent).Append("\n");
            sb.Append("  AlcoholContainerId: ").Append(AlcoholContainerId).Append("\n");
            sb.Append("  AlcoholContainerName: ").Append(AlcoholContainerName).Append("\n");
            sb.Append("  AlcoholContainerVolume: ").Append(AlcoholContainerVolume).Append("\n");
            sb.Append("  AlcoholVintageYear: ").Append(AlcoholVintageYear).Append("\n");
            sb.Append("  AlcoholCountryId: ").Append(AlcoholCountryId).Append("\n");
            sb.Append("  AlcoholCountryName: ").Append(AlcoholCountryName).Append("\n");
            sb.Append("  AlcoholState: ").Append(AlcoholState).Append("\n");
            sb.Append("  AlcoholRegion: ").Append(AlcoholRegion).Append("\n");
            sb.Append("  AlcoholBrand: ").Append(AlcoholBrand).Append("\n");
            sb.Append("  AlcoholUPCCode: ").Append(AlcoholUPCCode).Append("\n");
            sb.Append("  AlcoholNABCACode: ").Append(AlcoholNABCACode).Append("\n");
            sb.Append("  AlcoholUNIMERCCode: ").Append(AlcoholUNIMERCCode).Append("\n");
            sb.Append("  AlcoholSCCCode: ").Append(AlcoholSCCCode).Append("\n");
            sb.Append("  AlternateUsage: ").Append(AlternateUsage).Append("\n");
            sb.Append("  GroupOrderId: ").Append(GroupOrderId).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderStatusName: ").Append(OrderStatusName).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  MediaCode: ").Append(MediaCode).Append("\n");
            sb.Append("  LegacyRestrictionType: ").Append(LegacyRestrictionType).Append("\n");
            sb.Append("  ReqTypeName: ").Append(ReqTypeName).Append("\n");
            sb.Append("  ServiceTypeId: ").Append(ServiceTypeId).Append("\n");
            sb.Append("  ServiceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  AlcoholOrderType: ").Append(AlcoholOrderType).Append("\n");
            sb.Append("  DistributionChannel: ").Append(DistributionChannel).Append("\n");
            sb.Append("  DistributionChannelName: ").Append(DistributionChannelName).Append("\n");
            sb.Append("  PriorityCode: ").Append(PriorityCode).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  EnteredBy: ").Append(EnteredBy).Append("\n");
            sb.Append("  OrderReason: ").Append(OrderReason).Append("\n");
            sb.Append("  CustomerOrderNo: ").Append(CustomerOrderNo).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  ShipBy: ").Append(ShipBy).Append("\n");
            sb.Append("  StopBackOrders: ").Append(StopBackOrders).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  OrderSourceName: ").Append(OrderSourceName).Append("\n");
            sb.Append("  IntegrationPartnerId: ").Append(IntegrationPartnerId).Append("\n");
            sb.Append("  IntegrationPartnerName: ").Append(IntegrationPartnerName).Append("\n");
            sb.Append("  OrderLoadProgramId: ").Append(OrderLoadProgramId).Append("\n");
            sb.Append("  OrderLoadProgramName: ").Append(OrderLoadProgramName).Append("\n");
            sb.Append("  OmsOrderNo: ").Append(OmsOrderNo).Append("\n");
            sb.Append("  OmsCustomerId: ").Append(OmsCustomerId).Append("\n");
            sb.Append("  ShipToAttention: ").Append(ShipToAttention).Append("\n");
            sb.Append("  ShipToCompany: ").Append(ShipToCompany).Append("\n");
            sb.Append("  ShipToStreet: ").Append(ShipToStreet).Append("\n");
            sb.Append("  ShipToStreet2: ").Append(ShipToStreet2).Append("\n");
            sb.Append("  ShipToStreet3: ").Append(ShipToStreet3).Append("\n");
            sb.Append("  ShipToCity: ").Append(ShipToCity).Append("\n");
            sb.Append("  ShipToState: ").Append(ShipToState).Append("\n");
            sb.Append("  ShipToZip: ").Append(ShipToZip).Append("\n");
            sb.Append("  ShipToCountry: ").Append(ShipToCountry).Append("\n");
            sb.Append("  ShipToPhone: ").Append(ShipToPhone).Append("\n");
            sb.Append("  ShipToEmail: ").Append(ShipToEmail).Append("\n");
            sb.Append("  BillToAttention: ").Append(BillToAttention).Append("\n");
            sb.Append("  BillToCompany: ").Append(BillToCompany).Append("\n");
            sb.Append("  BillToStreet: ").Append(BillToStreet).Append("\n");
            sb.Append("  BillToStreet2: ").Append(BillToStreet2).Append("\n");
            sb.Append("  BillToStreet3: ").Append(BillToStreet3).Append("\n");
            sb.Append("  BillToCity: ").Append(BillToCity).Append("\n");
            sb.Append("  BillToState: ").Append(BillToState).Append("\n");
            sb.Append("  BillToZip: ").Append(BillToZip).Append("\n");
            sb.Append("  BillToCountry: ").Append(BillToCountry).Append("\n");
            sb.Append("  BillToPhone: ").Append(BillToPhone).Append("\n");
            sb.Append("  BillToEmail: ").Append(BillToEmail).Append("\n");
            sb.Append("  OrderShipDate: ").Append(OrderShipDate).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("  OrderWeightLbs: ").Append(OrderWeightLbs).Append("\n");
            sb.Append("  OrderEstimatedWeightLbs: ").Append(OrderEstimatedWeightLbs).Append("\n");
            sb.Append("  NumberOfPallets: ").Append(NumberOfPallets).Append("\n");
            sb.Append("  NumberOfLineItems: ").Append(NumberOfLineItems).Append("\n");
            sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
            sb.Append("  HoldCode: ").Append(HoldCode).Append("\n");
            sb.Append("  ShipCode: ").Append(ShipCode).Append("\n");
            sb.Append("  OrderMessage: ").Append(OrderMessage).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  CostCenter: ").Append(CostCenter).Append("\n");
            sb.Append("  AuthorizedBy: ").Append(AuthorizedBy).Append("\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  FirstShipDate: ").Append(FirstShipDate).Append("\n");
            sb.Append("  LastShipDate: ").Append(LastShipDate).Append("\n");
            sb.Append("  DeliverOnDate: ").Append(DeliverOnDate).Append("\n");
            sb.Append("  CustomerPONo: ").Append(CustomerPONo).Append("\n");
            sb.Append("  ShipVia: ").Append(ShipVia).Append("\n");
            sb.Append("  NeedByDate: ").Append(NeedByDate).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  BalanceDue: ").Append(BalanceDue).Append("\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
            sb.Append("  AuthorizationAmount: ").Append(AuthorizationAmount).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  TaxOnFreight: ").Append(TaxOnFreight).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  DistributionCharges: ").Append(DistributionCharges).Append("\n");
            sb.Append("  ShippingCharge: ").Append(ShippingCharge).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  ParcelAccountId: ").Append(ParcelAccountId).Append("\n");
            sb.Append("  PackingSlipTemplateId: ").Append(PackingSlipTemplateId).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  BranchSector: ").Append(BranchSector).Append("\n");
            sb.Append("  BranchArea: ").Append(BranchArea).Append("\n");
            sb.Append("  BranchCustomerType: ").Append(BranchCustomerType).Append("\n");
            sb.Append("  BranchId: ").Append(BranchId).Append("\n");
            sb.Append("  OrderCode: ").Append(OrderCode).Append("\n");
            sb.Append("  LeadPackageId: ").Append(LeadPackageId).Append("\n");
            sb.Append("  TotalQty: ").Append(TotalQty).Append("\n");
            sb.Append("  EstimatedNumberOfPicks: ").Append(EstimatedNumberOfPicks).Append("\n");
            sb.Append("  OrderConfirmationEmailTemplateId: ").Append(OrderConfirmationEmailTemplateId).Append("\n");
            sb.Append("  ShipmentConfirmationEmailTemplateId: ").Append(ShipmentConfirmationEmailTemplateId).Append("\n");
            sb.Append("  OrderInvoiceTemplateId: ").Append(OrderInvoiceTemplateId).Append("\n");
            sb.Append("  PriceMode: ").Append(PriceMode).Append("\n");
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
            return this.Equals(obj as OrderLineActivity);
        }

        /// <summary>
        /// Returns true if OrderLineActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLineActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineActivity other)
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
                    this.OrderCreateDate == other.OrderCreateDate ||
                    this.OrderCreateDate != null &&
                    this.OrderCreateDate.Equals(other.OrderCreateDate)
                ) && 
                (
                    this.OrderModifyDate == other.OrderModifyDate ||
                    this.OrderModifyDate != null &&
                    this.OrderModifyDate.Equals(other.OrderModifyDate)
                ) && 
                (
                    this.CrossDock == other.CrossDock ||
                    this.CrossDock != null &&
                    this.CrossDock.Equals(other.CrossDock)
                ) && 
                (
                    this.ProcessNoId == other.ProcessNoId ||
                    this.ProcessNoId != null &&
                    this.ProcessNoId.Equals(other.ProcessNoId)
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
                    this.AdjustCode == other.AdjustCode ||
                    this.AdjustCode != null &&
                    this.AdjustCode.Equals(other.AdjustCode)
                ) && 
                (
                    this.ProcessFlag == other.ProcessFlag ||
                    this.ProcessFlag != null &&
                    this.ProcessFlag.Equals(other.ProcessFlag)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
                (
                    this.RestrictionRule == other.RestrictionRule ||
                    this.RestrictionRule != null &&
                    this.RestrictionRule.Equals(other.RestrictionRule)
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
                    this.Per == other.Per ||
                    this.Per != null &&
                    this.Per.Equals(other.Per)
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
                    this.ItemMajorGroupId == other.ItemMajorGroupId ||
                    this.ItemMajorGroupId != null &&
                    this.ItemMajorGroupId.Equals(other.ItemMajorGroupId)
                ) && 
                (
                    this.MasterMajorGroupName == other.MasterMajorGroupName ||
                    this.MasterMajorGroupName != null &&
                    this.MasterMajorGroupName.Equals(other.MasterMajorGroupName)
                ) && 
                (
                    this.ItemSubGroupId == other.ItemSubGroupId ||
                    this.ItemSubGroupId != null &&
                    this.ItemSubGroupId.Equals(other.ItemSubGroupId)
                ) && 
                (
                    this.MasterSubGroupName == other.MasterSubGroupName ||
                    this.MasterSubGroupName != null &&
                    this.MasterSubGroupName.Equals(other.MasterSubGroupName)
                ) && 
                (
                    this.ItemProductCodeId == other.ItemProductCodeId ||
                    this.ItemProductCodeId != null &&
                    this.ItemProductCodeId.Equals(other.ItemProductCodeId)
                ) && 
                (
                    this.MasterProductionCodeName == other.MasterProductionCodeName ||
                    this.MasterProductionCodeName != null &&
                    this.MasterProductionCodeName.Equals(other.MasterProductionCodeName)
                ) && 
                (
                    this.ItemAccountCodeId == other.ItemAccountCodeId ||
                    this.ItemAccountCodeId != null &&
                    this.ItemAccountCodeId.Equals(other.ItemAccountCodeId)
                ) && 
                (
                    this.MasterAccountCodeName == other.MasterAccountCodeName ||
                    this.MasterAccountCodeName != null &&
                    this.MasterAccountCodeName.Equals(other.MasterAccountCodeName)
                ) && 
                (
                    this.ItemSummaryCodeId == other.ItemSummaryCodeId ||
                    this.ItemSummaryCodeId != null &&
                    this.ItemSummaryCodeId.Equals(other.ItemSummaryCodeId)
                ) && 
                (
                    this.MasterSummaryCodeName == other.MasterSummaryCodeName ||
                    this.MasterSummaryCodeName != null &&
                    this.MasterSummaryCodeName.Equals(other.MasterSummaryCodeName)
                ) && 
                (
                    this.ItemLegacyLowStockContactId == other.ItemLegacyLowStockContactId ||
                    this.ItemLegacyLowStockContactId != null &&
                    this.ItemLegacyLowStockContactId.Equals(other.ItemLegacyLowStockContactId)
                ) && 
                (
                    this.LowStockContactName == other.LowStockContactName ||
                    this.LowStockContactName != null &&
                    this.LowStockContactName.Equals(other.LowStockContactName)
                ) && 
                (
                    this.Sector == other.Sector ||
                    this.Sector != null &&
                    this.Sector.Equals(other.Sector)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
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
                    this.NumberOfWraps == other.NumberOfWraps ||
                    this.NumberOfWraps != null &&
                    this.NumberOfWraps.Equals(other.NumberOfWraps)
                ) && 
                (
                    this.NumberOfCases == other.NumberOfCases ||
                    this.NumberOfCases != null &&
                    this.NumberOfCases.Equals(other.NumberOfCases)
                ) && 
                (
                    this.NumberOfTouches == other.NumberOfTouches ||
                    this.NumberOfTouches != null &&
                    this.NumberOfTouches.Equals(other.NumberOfTouches)
                ) && 
                (
                    this.AlcoholTypeId == other.AlcoholTypeId ||
                    this.AlcoholTypeId != null &&
                    this.AlcoholTypeId.Equals(other.AlcoholTypeId)
                ) && 
                (
                    this.AlcoholTypeName == other.AlcoholTypeName ||
                    this.AlcoholTypeName != null &&
                    this.AlcoholTypeName.Equals(other.AlcoholTypeName)
                ) && 
                (
                    this.AlcoholContent == other.AlcoholContent ||
                    this.AlcoholContent != null &&
                    this.AlcoholContent.Equals(other.AlcoholContent)
                ) && 
                (
                    this.AlcoholContainerId == other.AlcoholContainerId ||
                    this.AlcoholContainerId != null &&
                    this.AlcoholContainerId.Equals(other.AlcoholContainerId)
                ) && 
                (
                    this.AlcoholContainerName == other.AlcoholContainerName ||
                    this.AlcoholContainerName != null &&
                    this.AlcoholContainerName.Equals(other.AlcoholContainerName)
                ) && 
                (
                    this.AlcoholContainerVolume == other.AlcoholContainerVolume ||
                    this.AlcoholContainerVolume != null &&
                    this.AlcoholContainerVolume.Equals(other.AlcoholContainerVolume)
                ) && 
                (
                    this.AlcoholVintageYear == other.AlcoholVintageYear ||
                    this.AlcoholVintageYear != null &&
                    this.AlcoholVintageYear.Equals(other.AlcoholVintageYear)
                ) && 
                (
                    this.AlcoholCountryId == other.AlcoholCountryId ||
                    this.AlcoholCountryId != null &&
                    this.AlcoholCountryId.Equals(other.AlcoholCountryId)
                ) && 
                (
                    this.AlcoholCountryName == other.AlcoholCountryName ||
                    this.AlcoholCountryName != null &&
                    this.AlcoholCountryName.Equals(other.AlcoholCountryName)
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
                    this.AlcoholNABCACode == other.AlcoholNABCACode ||
                    this.AlcoholNABCACode != null &&
                    this.AlcoholNABCACode.Equals(other.AlcoholNABCACode)
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
                    this.AlternateUsage == other.AlternateUsage ||
                    this.AlternateUsage != null &&
                    this.AlternateUsage.Equals(other.AlternateUsage)
                ) && 
                (
                    this.GroupOrderId == other.GroupOrderId ||
                    this.GroupOrderId != null &&
                    this.GroupOrderId.Equals(other.GroupOrderId)
                ) && 
                (
                    this.OrderStatus == other.OrderStatus ||
                    this.OrderStatus != null &&
                    this.OrderStatus.Equals(other.OrderStatus)
                ) && 
                (
                    this.OrderStatusName == other.OrderStatusName ||
                    this.OrderStatusName != null &&
                    this.OrderStatusName.Equals(other.OrderStatusName)
                ) && 
                (
                    this.CarrierId == other.CarrierId ||
                    this.CarrierId != null &&
                    this.CarrierId.Equals(other.CarrierId)
                ) && 
                (
                    this.CarrierName == other.CarrierName ||
                    this.CarrierName != null &&
                    this.CarrierName.Equals(other.CarrierName)
                ) && 
                (
                    this.MediaCode == other.MediaCode ||
                    this.MediaCode != null &&
                    this.MediaCode.Equals(other.MediaCode)
                ) && 
                (
                    this.LegacyRestrictionType == other.LegacyRestrictionType ||
                    this.LegacyRestrictionType != null &&
                    this.LegacyRestrictionType.Equals(other.LegacyRestrictionType)
                ) && 
                (
                    this.ReqTypeName == other.ReqTypeName ||
                    this.ReqTypeName != null &&
                    this.ReqTypeName.Equals(other.ReqTypeName)
                ) && 
                (
                    this.ServiceTypeId == other.ServiceTypeId ||
                    this.ServiceTypeId != null &&
                    this.ServiceTypeId.Equals(other.ServiceTypeId)
                ) && 
                (
                    this.ServiceTypeName == other.ServiceTypeName ||
                    this.ServiceTypeName != null &&
                    this.ServiceTypeName.Equals(other.ServiceTypeName)
                ) && 
                (
                    this.AlcoholOrderType == other.AlcoholOrderType ||
                    this.AlcoholOrderType != null &&
                    this.AlcoholOrderType.Equals(other.AlcoholOrderType)
                ) && 
                (
                    this.DistributionChannel == other.DistributionChannel ||
                    this.DistributionChannel != null &&
                    this.DistributionChannel.Equals(other.DistributionChannel)
                ) && 
                (
                    this.DistributionChannelName == other.DistributionChannelName ||
                    this.DistributionChannelName != null &&
                    this.DistributionChannelName.Equals(other.DistributionChannelName)
                ) && 
                (
                    this.PriorityCode == other.PriorityCode ||
                    this.PriorityCode != null &&
                    this.PriorityCode.Equals(other.PriorityCode)
                ) && 
                (
                    this.OrderDate == other.OrderDate ||
                    this.OrderDate != null &&
                    this.OrderDate.Equals(other.OrderDate)
                ) && 
                (
                    this.EnteredBy == other.EnteredBy ||
                    this.EnteredBy != null &&
                    this.EnteredBy.Equals(other.EnteredBy)
                ) && 
                (
                    this.OrderReason == other.OrderReason ||
                    this.OrderReason != null &&
                    this.OrderReason.Equals(other.OrderReason)
                ) && 
                (
                    this.CustomerOrderNo == other.CustomerOrderNo ||
                    this.CustomerOrderNo != null &&
                    this.CustomerOrderNo.Equals(other.CustomerOrderNo)
                ) && 
                (
                    this.PriceLevel == other.PriceLevel ||
                    this.PriceLevel != null &&
                    this.PriceLevel.Equals(other.PriceLevel)
                ) && 
                (
                    this.ShipBy == other.ShipBy ||
                    this.ShipBy != null &&
                    this.ShipBy.Equals(other.ShipBy)
                ) && 
                (
                    this.StopBackOrders == other.StopBackOrders ||
                    this.StopBackOrders != null &&
                    this.StopBackOrders.Equals(other.StopBackOrders)
                ) && 
                (
                    this.OrderSourceId == other.OrderSourceId ||
                    this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(other.OrderSourceId)
                ) && 
                (
                    this.OrderSourceName == other.OrderSourceName ||
                    this.OrderSourceName != null &&
                    this.OrderSourceName.Equals(other.OrderSourceName)
                ) && 
                (
                    this.IntegrationPartnerId == other.IntegrationPartnerId ||
                    this.IntegrationPartnerId != null &&
                    this.IntegrationPartnerId.Equals(other.IntegrationPartnerId)
                ) && 
                (
                    this.IntegrationPartnerName == other.IntegrationPartnerName ||
                    this.IntegrationPartnerName != null &&
                    this.IntegrationPartnerName.Equals(other.IntegrationPartnerName)
                ) && 
                (
                    this.OrderLoadProgramId == other.OrderLoadProgramId ||
                    this.OrderLoadProgramId != null &&
                    this.OrderLoadProgramId.Equals(other.OrderLoadProgramId)
                ) && 
                (
                    this.OrderLoadProgramName == other.OrderLoadProgramName ||
                    this.OrderLoadProgramName != null &&
                    this.OrderLoadProgramName.Equals(other.OrderLoadProgramName)
                ) && 
                (
                    this.OmsOrderNo == other.OmsOrderNo ||
                    this.OmsOrderNo != null &&
                    this.OmsOrderNo.Equals(other.OmsOrderNo)
                ) && 
                (
                    this.OmsCustomerId == other.OmsCustomerId ||
                    this.OmsCustomerId != null &&
                    this.OmsCustomerId.Equals(other.OmsCustomerId)
                ) && 
                (
                    this.ShipToAttention == other.ShipToAttention ||
                    this.ShipToAttention != null &&
                    this.ShipToAttention.Equals(other.ShipToAttention)
                ) && 
                (
                    this.ShipToCompany == other.ShipToCompany ||
                    this.ShipToCompany != null &&
                    this.ShipToCompany.Equals(other.ShipToCompany)
                ) && 
                (
                    this.ShipToStreet == other.ShipToStreet ||
                    this.ShipToStreet != null &&
                    this.ShipToStreet.Equals(other.ShipToStreet)
                ) && 
                (
                    this.ShipToStreet2 == other.ShipToStreet2 ||
                    this.ShipToStreet2 != null &&
                    this.ShipToStreet2.Equals(other.ShipToStreet2)
                ) && 
                (
                    this.ShipToStreet3 == other.ShipToStreet3 ||
                    this.ShipToStreet3 != null &&
                    this.ShipToStreet3.Equals(other.ShipToStreet3)
                ) && 
                (
                    this.ShipToCity == other.ShipToCity ||
                    this.ShipToCity != null &&
                    this.ShipToCity.Equals(other.ShipToCity)
                ) && 
                (
                    this.ShipToState == other.ShipToState ||
                    this.ShipToState != null &&
                    this.ShipToState.Equals(other.ShipToState)
                ) && 
                (
                    this.ShipToZip == other.ShipToZip ||
                    this.ShipToZip != null &&
                    this.ShipToZip.Equals(other.ShipToZip)
                ) && 
                (
                    this.ShipToCountry == other.ShipToCountry ||
                    this.ShipToCountry != null &&
                    this.ShipToCountry.Equals(other.ShipToCountry)
                ) && 
                (
                    this.ShipToPhone == other.ShipToPhone ||
                    this.ShipToPhone != null &&
                    this.ShipToPhone.Equals(other.ShipToPhone)
                ) && 
                (
                    this.ShipToEmail == other.ShipToEmail ||
                    this.ShipToEmail != null &&
                    this.ShipToEmail.Equals(other.ShipToEmail)
                ) && 
                (
                    this.BillToAttention == other.BillToAttention ||
                    this.BillToAttention != null &&
                    this.BillToAttention.Equals(other.BillToAttention)
                ) && 
                (
                    this.BillToCompany == other.BillToCompany ||
                    this.BillToCompany != null &&
                    this.BillToCompany.Equals(other.BillToCompany)
                ) && 
                (
                    this.BillToStreet == other.BillToStreet ||
                    this.BillToStreet != null &&
                    this.BillToStreet.Equals(other.BillToStreet)
                ) && 
                (
                    this.BillToStreet2 == other.BillToStreet2 ||
                    this.BillToStreet2 != null &&
                    this.BillToStreet2.Equals(other.BillToStreet2)
                ) && 
                (
                    this.BillToStreet3 == other.BillToStreet3 ||
                    this.BillToStreet3 != null &&
                    this.BillToStreet3.Equals(other.BillToStreet3)
                ) && 
                (
                    this.BillToCity == other.BillToCity ||
                    this.BillToCity != null &&
                    this.BillToCity.Equals(other.BillToCity)
                ) && 
                (
                    this.BillToState == other.BillToState ||
                    this.BillToState != null &&
                    this.BillToState.Equals(other.BillToState)
                ) && 
                (
                    this.BillToZip == other.BillToZip ||
                    this.BillToZip != null &&
                    this.BillToZip.Equals(other.BillToZip)
                ) && 
                (
                    this.BillToCountry == other.BillToCountry ||
                    this.BillToCountry != null &&
                    this.BillToCountry.Equals(other.BillToCountry)
                ) && 
                (
                    this.BillToPhone == other.BillToPhone ||
                    this.BillToPhone != null &&
                    this.BillToPhone.Equals(other.BillToPhone)
                ) && 
                (
                    this.BillToEmail == other.BillToEmail ||
                    this.BillToEmail != null &&
                    this.BillToEmail.Equals(other.BillToEmail)
                ) && 
                (
                    this.OrderShipDate == other.OrderShipDate ||
                    this.OrderShipDate != null &&
                    this.OrderShipDate.Equals(other.OrderShipDate)
                ) && 
                (
                    this.Freight == other.Freight ||
                    this.Freight != null &&
                    this.Freight.Equals(other.Freight)
                ) && 
                (
                    this.OrderWeightLbs == other.OrderWeightLbs ||
                    this.OrderWeightLbs != null &&
                    this.OrderWeightLbs.Equals(other.OrderWeightLbs)
                ) && 
                (
                    this.OrderEstimatedWeightLbs == other.OrderEstimatedWeightLbs ||
                    this.OrderEstimatedWeightLbs != null &&
                    this.OrderEstimatedWeightLbs.Equals(other.OrderEstimatedWeightLbs)
                ) && 
                (
                    this.NumberOfPallets == other.NumberOfPallets ||
                    this.NumberOfPallets != null &&
                    this.NumberOfPallets.Equals(other.NumberOfPallets)
                ) && 
                (
                    this.NumberOfLineItems == other.NumberOfLineItems ||
                    this.NumberOfLineItems != null &&
                    this.NumberOfLineItems.Equals(other.NumberOfLineItems)
                ) && 
                (
                    this.CompletionStatus == other.CompletionStatus ||
                    this.CompletionStatus != null &&
                    this.CompletionStatus.Equals(other.CompletionStatus)
                ) && 
                (
                    this.HoldCode == other.HoldCode ||
                    this.HoldCode != null &&
                    this.HoldCode.Equals(other.HoldCode)
                ) && 
                (
                    this.ShipCode == other.ShipCode ||
                    this.ShipCode != null &&
                    this.ShipCode.Equals(other.ShipCode)
                ) && 
                (
                    this.OrderMessage == other.OrderMessage ||
                    this.OrderMessage != null &&
                    this.OrderMessage.Equals(other.OrderMessage)
                ) && 
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) && 
                (
                    this.CostCenter == other.CostCenter ||
                    this.CostCenter != null &&
                    this.CostCenter.Equals(other.CostCenter)
                ) && 
                (
                    this.AuthorizedBy == other.AuthorizedBy ||
                    this.AuthorizedBy != null &&
                    this.AuthorizedBy.Equals(other.AuthorizedBy)
                ) && 
                (
                    this.BatchNo == other.BatchNo ||
                    this.BatchNo != null &&
                    this.BatchNo.Equals(other.BatchNo)
                ) && 
                (
                    this.FirstShipDate == other.FirstShipDate ||
                    this.FirstShipDate != null &&
                    this.FirstShipDate.Equals(other.FirstShipDate)
                ) && 
                (
                    this.LastShipDate == other.LastShipDate ||
                    this.LastShipDate != null &&
                    this.LastShipDate.Equals(other.LastShipDate)
                ) && 
                (
                    this.DeliverOnDate == other.DeliverOnDate ||
                    this.DeliverOnDate != null &&
                    this.DeliverOnDate.Equals(other.DeliverOnDate)
                ) && 
                (
                    this.CustomerPONo == other.CustomerPONo ||
                    this.CustomerPONo != null &&
                    this.CustomerPONo.Equals(other.CustomerPONo)
                ) && 
                (
                    this.ShipVia == other.ShipVia ||
                    this.ShipVia != null &&
                    this.ShipVia.Equals(other.ShipVia)
                ) && 
                (
                    this.NeedByDate == other.NeedByDate ||
                    this.NeedByDate != null &&
                    this.NeedByDate.Equals(other.NeedByDate)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.BalanceDue == other.BalanceDue ||
                    this.BalanceDue != null &&
                    this.BalanceDue.Equals(other.BalanceDue)
                ) && 
                (
                    this.TotalPaid == other.TotalPaid ||
                    this.TotalPaid != null &&
                    this.TotalPaid.Equals(other.TotalPaid)
                ) && 
                (
                    this.AuthorizationAmount == other.AuthorizationAmount ||
                    this.AuthorizationAmount != null &&
                    this.AuthorizationAmount.Equals(other.AuthorizationAmount)
                ) && 
                (
                    this.Subtotal == other.Subtotal ||
                    this.Subtotal != null &&
                    this.Subtotal.Equals(other.Subtotal)
                ) && 
                (
                    this.TaxOnFreight == other.TaxOnFreight ||
                    this.TaxOnFreight != null &&
                    this.TaxOnFreight.Equals(other.TaxOnFreight)
                ) && 
                (
                    this.Tax == other.Tax ||
                    this.Tax != null &&
                    this.Tax.Equals(other.Tax)
                ) && 
                (
                    this.DistributionCharges == other.DistributionCharges ||
                    this.DistributionCharges != null &&
                    this.DistributionCharges.Equals(other.DistributionCharges)
                ) && 
                (
                    this.ShippingCharge == other.ShippingCharge ||
                    this.ShippingCharge != null &&
                    this.ShippingCharge.Equals(other.ShippingCharge)
                ) && 
                (
                    this.TotalDiscount == other.TotalDiscount ||
                    this.TotalDiscount != null &&
                    this.TotalDiscount.Equals(other.TotalDiscount)
                ) && 
                (
                    this.ParcelAccountId == other.ParcelAccountId ||
                    this.ParcelAccountId != null &&
                    this.ParcelAccountId.Equals(other.ParcelAccountId)
                ) && 
                (
                    this.PackingSlipTemplateId == other.PackingSlipTemplateId ||
                    this.PackingSlipTemplateId != null &&
                    this.PackingSlipTemplateId.Equals(other.PackingSlipTemplateId)
                ) && 
                (
                    this.GiftMessage == other.GiftMessage ||
                    this.GiftMessage != null &&
                    this.GiftMessage.Equals(other.GiftMessage)
                ) && 
                (
                    this.BranchSector == other.BranchSector ||
                    this.BranchSector != null &&
                    this.BranchSector.Equals(other.BranchSector)
                ) && 
                (
                    this.BranchArea == other.BranchArea ||
                    this.BranchArea != null &&
                    this.BranchArea.Equals(other.BranchArea)
                ) && 
                (
                    this.BranchCustomerType == other.BranchCustomerType ||
                    this.BranchCustomerType != null &&
                    this.BranchCustomerType.Equals(other.BranchCustomerType)
                ) && 
                (
                    this.BranchId == other.BranchId ||
                    this.BranchId != null &&
                    this.BranchId.Equals(other.BranchId)
                ) && 
                (
                    this.OrderCode == other.OrderCode ||
                    this.OrderCode != null &&
                    this.OrderCode.Equals(other.OrderCode)
                ) && 
                (
                    this.LeadPackageId == other.LeadPackageId ||
                    this.LeadPackageId != null &&
                    this.LeadPackageId.Equals(other.LeadPackageId)
                ) && 
                (
                    this.TotalQty == other.TotalQty ||
                    this.TotalQty != null &&
                    this.TotalQty.Equals(other.TotalQty)
                ) && 
                (
                    this.EstimatedNumberOfPicks == other.EstimatedNumberOfPicks ||
                    this.EstimatedNumberOfPicks != null &&
                    this.EstimatedNumberOfPicks.Equals(other.EstimatedNumberOfPicks)
                ) && 
                (
                    this.OrderConfirmationEmailTemplateId == other.OrderConfirmationEmailTemplateId ||
                    this.OrderConfirmationEmailTemplateId != null &&
                    this.OrderConfirmationEmailTemplateId.Equals(other.OrderConfirmationEmailTemplateId)
                ) && 
                (
                    this.ShipmentConfirmationEmailTemplateId == other.ShipmentConfirmationEmailTemplateId ||
                    this.ShipmentConfirmationEmailTemplateId != null &&
                    this.ShipmentConfirmationEmailTemplateId.Equals(other.ShipmentConfirmationEmailTemplateId)
                ) && 
                (
                    this.OrderInvoiceTemplateId == other.OrderInvoiceTemplateId ||
                    this.OrderInvoiceTemplateId != null &&
                    this.OrderInvoiceTemplateId.Equals(other.OrderInvoiceTemplateId)
                ) && 
                (
                    this.PriceMode == other.PriceMode ||
                    this.PriceMode != null &&
                    this.PriceMode.Equals(other.PriceMode)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.PoNoId != null)
                    hash = hash * 59 + this.PoNoId.GetHashCode();
                
                if (this.OrderCreateDate != null)
                    hash = hash * 59 + this.OrderCreateDate.GetHashCode();
                
                if (this.OrderModifyDate != null)
                    hash = hash * 59 + this.OrderModifyDate.GetHashCode();
                
                if (this.CrossDock != null)
                    hash = hash * 59 + this.CrossDock.GetHashCode();
                
                if (this.ProcessNoId != null)
                    hash = hash * 59 + this.ProcessNoId.GetHashCode();
                
                if (this.OrderedQty != null)
                    hash = hash * 59 + this.OrderedQty.GetHashCode();
                
                if (this.AllowedQty != null)
                    hash = hash * 59 + this.AllowedQty.GetHashCode();
                
                if (this.ShippedQty != null)
                    hash = hash * 59 + this.ShippedQty.GetHashCode();
                
                if (this.BackorderQty != null)
                    hash = hash * 59 + this.BackorderQty.GetHashCode();
                
                if (this.AdjustCode != null)
                    hash = hash * 59 + this.AdjustCode.GetHashCode();
                
                if (this.ProcessFlag != null)
                    hash = hash * 59 + this.ProcessFlag.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
                if (this.RestrictionRule != null)
                    hash = hash * 59 + this.RestrictionRule.GetHashCode();
                
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
                
                if (this.Per != null)
                    hash = hash * 59 + this.Per.GetHashCode();
                
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
                
                if (this.ItemMajorGroupId != null)
                    hash = hash * 59 + this.ItemMajorGroupId.GetHashCode();
                
                if (this.MasterMajorGroupName != null)
                    hash = hash * 59 + this.MasterMajorGroupName.GetHashCode();
                
                if (this.ItemSubGroupId != null)
                    hash = hash * 59 + this.ItemSubGroupId.GetHashCode();
                
                if (this.MasterSubGroupName != null)
                    hash = hash * 59 + this.MasterSubGroupName.GetHashCode();
                
                if (this.ItemProductCodeId != null)
                    hash = hash * 59 + this.ItemProductCodeId.GetHashCode();
                
                if (this.MasterProductionCodeName != null)
                    hash = hash * 59 + this.MasterProductionCodeName.GetHashCode();
                
                if (this.ItemAccountCodeId != null)
                    hash = hash * 59 + this.ItemAccountCodeId.GetHashCode();
                
                if (this.MasterAccountCodeName != null)
                    hash = hash * 59 + this.MasterAccountCodeName.GetHashCode();
                
                if (this.ItemSummaryCodeId != null)
                    hash = hash * 59 + this.ItemSummaryCodeId.GetHashCode();
                
                if (this.MasterSummaryCodeName != null)
                    hash = hash * 59 + this.MasterSummaryCodeName.GetHashCode();
                
                if (this.ItemLegacyLowStockContactId != null)
                    hash = hash * 59 + this.ItemLegacyLowStockContactId.GetHashCode();
                
                if (this.LowStockContactName != null)
                    hash = hash * 59 + this.LowStockContactName.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.ItemWeight != null)
                    hash = hash * 59 + this.ItemWeight.GetHashCode();
                
                if (this.ProductionLot != null)
                    hash = hash * 59 + this.ProductionLot.GetHashCode();
                
                if (this.NumberOfWraps != null)
                    hash = hash * 59 + this.NumberOfWraps.GetHashCode();
                
                if (this.NumberOfCases != null)
                    hash = hash * 59 + this.NumberOfCases.GetHashCode();
                
                if (this.NumberOfTouches != null)
                    hash = hash * 59 + this.NumberOfTouches.GetHashCode();
                
                if (this.AlcoholTypeId != null)
                    hash = hash * 59 + this.AlcoholTypeId.GetHashCode();
                
                if (this.AlcoholTypeName != null)
                    hash = hash * 59 + this.AlcoholTypeName.GetHashCode();
                
                if (this.AlcoholContent != null)
                    hash = hash * 59 + this.AlcoholContent.GetHashCode();
                
                if (this.AlcoholContainerId != null)
                    hash = hash * 59 + this.AlcoholContainerId.GetHashCode();
                
                if (this.AlcoholContainerName != null)
                    hash = hash * 59 + this.AlcoholContainerName.GetHashCode();
                
                if (this.AlcoholContainerVolume != null)
                    hash = hash * 59 + this.AlcoholContainerVolume.GetHashCode();
                
                if (this.AlcoholVintageYear != null)
                    hash = hash * 59 + this.AlcoholVintageYear.GetHashCode();
                
                if (this.AlcoholCountryId != null)
                    hash = hash * 59 + this.AlcoholCountryId.GetHashCode();
                
                if (this.AlcoholCountryName != null)
                    hash = hash * 59 + this.AlcoholCountryName.GetHashCode();
                
                if (this.AlcoholState != null)
                    hash = hash * 59 + this.AlcoholState.GetHashCode();
                
                if (this.AlcoholRegion != null)
                    hash = hash * 59 + this.AlcoholRegion.GetHashCode();
                
                if (this.AlcoholBrand != null)
                    hash = hash * 59 + this.AlcoholBrand.GetHashCode();
                
                if (this.AlcoholUPCCode != null)
                    hash = hash * 59 + this.AlcoholUPCCode.GetHashCode();
                
                if (this.AlcoholNABCACode != null)
                    hash = hash * 59 + this.AlcoholNABCACode.GetHashCode();
                
                if (this.AlcoholUNIMERCCode != null)
                    hash = hash * 59 + this.AlcoholUNIMERCCode.GetHashCode();
                
                if (this.AlcoholSCCCode != null)
                    hash = hash * 59 + this.AlcoholSCCCode.GetHashCode();
                
                if (this.AlternateUsage != null)
                    hash = hash * 59 + this.AlternateUsage.GetHashCode();
                
                if (this.GroupOrderId != null)
                    hash = hash * 59 + this.GroupOrderId.GetHashCode();
                
                if (this.OrderStatus != null)
                    hash = hash * 59 + this.OrderStatus.GetHashCode();
                
                if (this.OrderStatusName != null)
                    hash = hash * 59 + this.OrderStatusName.GetHashCode();
                
                if (this.CarrierId != null)
                    hash = hash * 59 + this.CarrierId.GetHashCode();
                
                if (this.CarrierName != null)
                    hash = hash * 59 + this.CarrierName.GetHashCode();
                
                if (this.MediaCode != null)
                    hash = hash * 59 + this.MediaCode.GetHashCode();
                
                if (this.LegacyRestrictionType != null)
                    hash = hash * 59 + this.LegacyRestrictionType.GetHashCode();
                
                if (this.ReqTypeName != null)
                    hash = hash * 59 + this.ReqTypeName.GetHashCode();
                
                if (this.ServiceTypeId != null)
                    hash = hash * 59 + this.ServiceTypeId.GetHashCode();
                
                if (this.ServiceTypeName != null)
                    hash = hash * 59 + this.ServiceTypeName.GetHashCode();
                
                if (this.AlcoholOrderType != null)
                    hash = hash * 59 + this.AlcoholOrderType.GetHashCode();
                
                if (this.DistributionChannel != null)
                    hash = hash * 59 + this.DistributionChannel.GetHashCode();
                
                if (this.DistributionChannelName != null)
                    hash = hash * 59 + this.DistributionChannelName.GetHashCode();
                
                if (this.PriorityCode != null)
                    hash = hash * 59 + this.PriorityCode.GetHashCode();
                
                if (this.OrderDate != null)
                    hash = hash * 59 + this.OrderDate.GetHashCode();
                
                if (this.EnteredBy != null)
                    hash = hash * 59 + this.EnteredBy.GetHashCode();
                
                if (this.OrderReason != null)
                    hash = hash * 59 + this.OrderReason.GetHashCode();
                
                if (this.CustomerOrderNo != null)
                    hash = hash * 59 + this.CustomerOrderNo.GetHashCode();
                
                if (this.PriceLevel != null)
                    hash = hash * 59 + this.PriceLevel.GetHashCode();
                
                if (this.ShipBy != null)
                    hash = hash * 59 + this.ShipBy.GetHashCode();
                
                if (this.StopBackOrders != null)
                    hash = hash * 59 + this.StopBackOrders.GetHashCode();
                
                if (this.OrderSourceId != null)
                    hash = hash * 59 + this.OrderSourceId.GetHashCode();
                
                if (this.OrderSourceName != null)
                    hash = hash * 59 + this.OrderSourceName.GetHashCode();
                
                if (this.IntegrationPartnerId != null)
                    hash = hash * 59 + this.IntegrationPartnerId.GetHashCode();
                
                if (this.IntegrationPartnerName != null)
                    hash = hash * 59 + this.IntegrationPartnerName.GetHashCode();
                
                if (this.OrderLoadProgramId != null)
                    hash = hash * 59 + this.OrderLoadProgramId.GetHashCode();
                
                if (this.OrderLoadProgramName != null)
                    hash = hash * 59 + this.OrderLoadProgramName.GetHashCode();
                
                if (this.OmsOrderNo != null)
                    hash = hash * 59 + this.OmsOrderNo.GetHashCode();
                
                if (this.OmsCustomerId != null)
                    hash = hash * 59 + this.OmsCustomerId.GetHashCode();
                
                if (this.ShipToAttention != null)
                    hash = hash * 59 + this.ShipToAttention.GetHashCode();
                
                if (this.ShipToCompany != null)
                    hash = hash * 59 + this.ShipToCompany.GetHashCode();
                
                if (this.ShipToStreet != null)
                    hash = hash * 59 + this.ShipToStreet.GetHashCode();
                
                if (this.ShipToStreet2 != null)
                    hash = hash * 59 + this.ShipToStreet2.GetHashCode();
                
                if (this.ShipToStreet3 != null)
                    hash = hash * 59 + this.ShipToStreet3.GetHashCode();
                
                if (this.ShipToCity != null)
                    hash = hash * 59 + this.ShipToCity.GetHashCode();
                
                if (this.ShipToState != null)
                    hash = hash * 59 + this.ShipToState.GetHashCode();
                
                if (this.ShipToZip != null)
                    hash = hash * 59 + this.ShipToZip.GetHashCode();
                
                if (this.ShipToCountry != null)
                    hash = hash * 59 + this.ShipToCountry.GetHashCode();
                
                if (this.ShipToPhone != null)
                    hash = hash * 59 + this.ShipToPhone.GetHashCode();
                
                if (this.ShipToEmail != null)
                    hash = hash * 59 + this.ShipToEmail.GetHashCode();
                
                if (this.BillToAttention != null)
                    hash = hash * 59 + this.BillToAttention.GetHashCode();
                
                if (this.BillToCompany != null)
                    hash = hash * 59 + this.BillToCompany.GetHashCode();
                
                if (this.BillToStreet != null)
                    hash = hash * 59 + this.BillToStreet.GetHashCode();
                
                if (this.BillToStreet2 != null)
                    hash = hash * 59 + this.BillToStreet2.GetHashCode();
                
                if (this.BillToStreet3 != null)
                    hash = hash * 59 + this.BillToStreet3.GetHashCode();
                
                if (this.BillToCity != null)
                    hash = hash * 59 + this.BillToCity.GetHashCode();
                
                if (this.BillToState != null)
                    hash = hash * 59 + this.BillToState.GetHashCode();
                
                if (this.BillToZip != null)
                    hash = hash * 59 + this.BillToZip.GetHashCode();
                
                if (this.BillToCountry != null)
                    hash = hash * 59 + this.BillToCountry.GetHashCode();
                
                if (this.BillToPhone != null)
                    hash = hash * 59 + this.BillToPhone.GetHashCode();
                
                if (this.BillToEmail != null)
                    hash = hash * 59 + this.BillToEmail.GetHashCode();
                
                if (this.OrderShipDate != null)
                    hash = hash * 59 + this.OrderShipDate.GetHashCode();
                
                if (this.Freight != null)
                    hash = hash * 59 + this.Freight.GetHashCode();
                
                if (this.OrderWeightLbs != null)
                    hash = hash * 59 + this.OrderWeightLbs.GetHashCode();
                
                if (this.OrderEstimatedWeightLbs != null)
                    hash = hash * 59 + this.OrderEstimatedWeightLbs.GetHashCode();
                
                if (this.NumberOfPallets != null)
                    hash = hash * 59 + this.NumberOfPallets.GetHashCode();
                
                if (this.NumberOfLineItems != null)
                    hash = hash * 59 + this.NumberOfLineItems.GetHashCode();
                
                if (this.CompletionStatus != null)
                    hash = hash * 59 + this.CompletionStatus.GetHashCode();
                
                if (this.HoldCode != null)
                    hash = hash * 59 + this.HoldCode.GetHashCode();
                
                if (this.ShipCode != null)
                    hash = hash * 59 + this.ShipCode.GetHashCode();
                
                if (this.OrderMessage != null)
                    hash = hash * 59 + this.OrderMessage.GetHashCode();
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.CostCenter != null)
                    hash = hash * 59 + this.CostCenter.GetHashCode();
                
                if (this.AuthorizedBy != null)
                    hash = hash * 59 + this.AuthorizedBy.GetHashCode();
                
                if (this.BatchNo != null)
                    hash = hash * 59 + this.BatchNo.GetHashCode();
                
                if (this.FirstShipDate != null)
                    hash = hash * 59 + this.FirstShipDate.GetHashCode();
                
                if (this.LastShipDate != null)
                    hash = hash * 59 + this.LastShipDate.GetHashCode();
                
                if (this.DeliverOnDate != null)
                    hash = hash * 59 + this.DeliverOnDate.GetHashCode();
                
                if (this.CustomerPONo != null)
                    hash = hash * 59 + this.CustomerPONo.GetHashCode();
                
                if (this.ShipVia != null)
                    hash = hash * 59 + this.ShipVia.GetHashCode();
                
                if (this.NeedByDate != null)
                    hash = hash * 59 + this.NeedByDate.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.BalanceDue != null)
                    hash = hash * 59 + this.BalanceDue.GetHashCode();
                
                if (this.TotalPaid != null)
                    hash = hash * 59 + this.TotalPaid.GetHashCode();
                
                if (this.AuthorizationAmount != null)
                    hash = hash * 59 + this.AuthorizationAmount.GetHashCode();
                
                if (this.Subtotal != null)
                    hash = hash * 59 + this.Subtotal.GetHashCode();
                
                if (this.TaxOnFreight != null)
                    hash = hash * 59 + this.TaxOnFreight.GetHashCode();
                
                if (this.Tax != null)
                    hash = hash * 59 + this.Tax.GetHashCode();
                
                if (this.DistributionCharges != null)
                    hash = hash * 59 + this.DistributionCharges.GetHashCode();
                
                if (this.ShippingCharge != null)
                    hash = hash * 59 + this.ShippingCharge.GetHashCode();
                
                if (this.TotalDiscount != null)
                    hash = hash * 59 + this.TotalDiscount.GetHashCode();
                
                if (this.ParcelAccountId != null)
                    hash = hash * 59 + this.ParcelAccountId.GetHashCode();
                
                if (this.PackingSlipTemplateId != null)
                    hash = hash * 59 + this.PackingSlipTemplateId.GetHashCode();
                
                if (this.GiftMessage != null)
                    hash = hash * 59 + this.GiftMessage.GetHashCode();
                
                if (this.BranchSector != null)
                    hash = hash * 59 + this.BranchSector.GetHashCode();
                
                if (this.BranchArea != null)
                    hash = hash * 59 + this.BranchArea.GetHashCode();
                
                if (this.BranchCustomerType != null)
                    hash = hash * 59 + this.BranchCustomerType.GetHashCode();
                
                if (this.BranchId != null)
                    hash = hash * 59 + this.BranchId.GetHashCode();
                
                if (this.OrderCode != null)
                    hash = hash * 59 + this.OrderCode.GetHashCode();
                
                if (this.LeadPackageId != null)
                    hash = hash * 59 + this.LeadPackageId.GetHashCode();
                
                if (this.TotalQty != null)
                    hash = hash * 59 + this.TotalQty.GetHashCode();
                
                if (this.EstimatedNumberOfPicks != null)
                    hash = hash * 59 + this.EstimatedNumberOfPicks.GetHashCode();
                
                if (this.OrderConfirmationEmailTemplateId != null)
                    hash = hash * 59 + this.OrderConfirmationEmailTemplateId.GetHashCode();
                
                if (this.ShipmentConfirmationEmailTemplateId != null)
                    hash = hash * 59 + this.ShipmentConfirmationEmailTemplateId.GetHashCode();
                
                if (this.OrderInvoiceTemplateId != null)
                    hash = hash * 59 + this.OrderInvoiceTemplateId.GetHashCode();
                
                if (this.PriceMode != null)
                    hash = hash * 59 + this.PriceMode.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
