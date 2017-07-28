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
    public partial class CartonActivity :  IEquatable<CartonActivity>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonActivity" /> class.
        /// Initializes a new instance of the <see cref="CartonActivity" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="CartonNo">CartonNo.</param>
        /// <param name="NumberOfCartons">NumberOfCartons.</param>
        /// <param name="Shipped">Shipped (default to false).</param>
        /// <param name="CarrierServiceId">CarrierServiceId.</param>
        /// <param name="Dim1In">Dim1In.</param>
        /// <param name="Dim2In">Dim2In.</param>
        /// <param name="Dim3In">Dim3In.</param>
        /// <param name="EstimatedZone">EstimatedZone.</param>
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
        /// <param name="ShippingSystemName">ShippingSystemName.</param>
        /// <param name="OrderInvoiceTemplateId">OrderInvoiceTemplateId.</param>
        /// <param name="PriceMode">PriceMode.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public CartonActivity(int? LobId = null, int? WarehouseId = null, int? CartonNo = null, int? NumberOfCartons = null, bool? Shipped = null, int? CarrierServiceId = null, double? Dim1In = null, double? Dim2In = null, double? Dim3In = null, string EstimatedZone = null, string AlternateUsage = null, string OrderStatusName = null, int? CarrierId = null, string CarrierName = null, string MediaCode = null, string LegacyRestrictionType = null, string ReqTypeName = null, string ServiceTypeId = null, string ServiceTypeName = null, string AlcoholOrderType = null, string DistributionChannel = null, string DistributionChannelName = null, int? PriorityCode = null, DateTime? OrderDate = null, string CustomerOrderNo = null, string PriceLevel = null, int? OrderSourceId = null, string OrderSourceName = null, string IntegrationPartnerName = null, string OrderLoadProgramName = null, string ShipToAttention = null, string ShipToCompany = null, string ShipToStreet = null, string ShipToStreet2 = null, string ShipToStreet3 = null, string ShipToCity = null, string ShipToState = null, string ShipToZip = null, string ShipToCountry = null, string ShipToPhone = null, string ShipToEmail = null, string BillToAttention = null, string BillToCompany = null, string BillToStreet = null, string BillToStreet2 = null, string BillToStreet3 = null, string BillToCity = null, string BillToState = null, string BillToZip = null, string BillToCountry = null, string BillToPhone = null, string BillToEmail = null, string HoldCode = null, string ShipCode = null, string OrderMessage = null, int? Division = null, string CostCenter = null, string AuthorizedBy = null, string BatchNo = null, DateTime? FirstShipDate = null, DateTime? LastShipDate = null, DateTime? DeliverOnDate = null, string CustomerPONo = null, string ShipVia = null, DateTime? NeedByDate = null, double? Total = null, double? Subtotal = null, double? TaxOnFreight = null, double? Tax = null, double? ShippingCharge = null, double? TotalDiscount = null, int? PackingSlipTemplateId = null, string GiftMessage = null, string BranchSector = null, string BranchArea = null, string BranchCustomerType = null, string BranchId = null, string OrderCode = null, string LeadPackageId = null, int? OrderConfirmationEmailTemplateId = null, int? ShipmentConfirmationEmailTemplateId = null, string ShippingSystemName = null, int? OrderInvoiceTemplateId = null, string PriceMode = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for CartonActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for CartonActivity and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "MediaCode" is required (not null)
            if (MediaCode == null)
            {
                throw new InvalidDataException("MediaCode is a required property for CartonActivity and cannot be null");
            }
            else
            {
                this.MediaCode = MediaCode;
            }
            // to ensure "LegacyRestrictionType" is required (not null)
            if (LegacyRestrictionType == null)
            {
                throw new InvalidDataException("LegacyRestrictionType is a required property for CartonActivity and cannot be null");
            }
            else
            {
                this.LegacyRestrictionType = LegacyRestrictionType;
            }
            // to ensure "OrderDate" is required (not null)
            if (OrderDate == null)
            {
                throw new InvalidDataException("OrderDate is a required property for CartonActivity and cannot be null");
            }
            else
            {
                this.OrderDate = OrderDate;
            }
            this.CartonNo = CartonNo;
            this.NumberOfCartons = NumberOfCartons;
            // use default value if no "Shipped" provided
            if (Shipped == null)
            {
                this.Shipped = false;
            }
            else
            {
                this.Shipped = Shipped;
            }
            this.CarrierServiceId = CarrierServiceId;
            this.Dim1In = Dim1In;
            this.Dim2In = Dim2In;
            this.Dim3In = Dim3In;
            this.EstimatedZone = EstimatedZone;
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
            this.ShippingSystemName = ShippingSystemName;
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
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets DeliveredDate
        /// </summary>
        [DataMember(Name="deliveredDate", EmitDefaultValue=false)]
        public DateTime? DeliveredDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets TrackingNo
        /// </summary>
        [DataMember(Name="trackingNo", EmitDefaultValue=false)]
        public string TrackingNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseName
        /// </summary>
        [DataMember(Name="warehouseName", EmitDefaultValue=false)]
        public string WarehouseName { get; private set; }
    
        /// <summary>
        /// Gets or Sets CartonNo
        /// </summary>
        [DataMember(Name="cartonNo", EmitDefaultValue=false)]
        public int? CartonNo { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfCartons
        /// </summary>
        [DataMember(Name="numberOfCartons", EmitDefaultValue=false)]
        public int? NumberOfCartons { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets Shipped
        /// </summary>
        [DataMember(Name="shipped", EmitDefaultValue=false)]
        public bool? Shipped { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierServiceId
        /// </summary>
        [DataMember(Name="carrierServiceId", EmitDefaultValue=false)]
        public int? CarrierServiceId { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim1In
        /// </summary>
        [DataMember(Name="dim1In", EmitDefaultValue=false)]
        public double? Dim1In { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim2In
        /// </summary>
        [DataMember(Name="dim2In", EmitDefaultValue=false)]
        public double? Dim2In { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim3In
        /// </summary>
        [DataMember(Name="dim3In", EmitDefaultValue=false)]
        public double? Dim3In { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedZone
        /// </summary>
        [DataMember(Name="estimatedZone", EmitDefaultValue=false)]
        public string EstimatedZone { get; set; }
    
        /// <summary>
        /// Gets or Sets ParcelAccountNo
        /// </summary>
        [DataMember(Name="parcelAccountNo", EmitDefaultValue=false)]
        public string ParcelAccountNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyParcelAccountNo
        /// </summary>
        [DataMember(Name="thirdPartyParcelAccountNo", EmitDefaultValue=false)]
        public string ThirdPartyParcelAccountNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets ManifestId
        /// </summary>
        [DataMember(Name="manifestId", EmitDefaultValue=false)]
        public int? ManifestId { get; private set; }
    
        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        [DataMember(Name="residential", EmitDefaultValue=false)]
        public bool? Residential { get; private set; }
    
        /// <summary>
        /// Gets or Sets BillingOption
        /// </summary>
        [DataMember(Name="billingOption", EmitDefaultValue=false)]
        public string BillingOption { get; private set; }
    
        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public double? WeightLbs { get; private set; }
    
        /// <summary>
        /// Gets or Sets DimWeight
        /// </summary>
        [DataMember(Name="dimWeight", EmitDefaultValue=false)]
        public double? DimWeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets LicensePlateNumber
        /// </summary>
        [DataMember(Name="licensePlateNumber", EmitDefaultValue=false)]
        public string LicensePlateNumber { get; private set; }
    
        /// <summary>
        /// Gets or Sets ChargedFreightAmount
        /// </summary>
        [DataMember(Name="chargedFreightAmount", EmitDefaultValue=false)]
        public double? ChargedFreightAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets PublishedFreightAmount
        /// </summary>
        [DataMember(Name="publishedFreightAmount", EmitDefaultValue=false)]
        public double? PublishedFreightAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets RetailFreightAmount
        /// </summary>
        [DataMember(Name="retailFreightAmount", EmitDefaultValue=false)]
        public double? RetailFreightAmount { get; private set; }
    
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
        /// Gets or Sets FulfillmentProcessId
        /// </summary>
        [DataMember(Name="fulfillmentProcessId", EmitDefaultValue=false)]
        public int? FulfillmentProcessId { get; private set; }
    
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
        /// Gets or Sets OrderCreateDate
        /// </summary>
        [DataMember(Name="orderCreateDate", EmitDefaultValue=false)]
        public DateTime? OrderCreateDate { get; private set; }
    
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
        /// Gets or Sets ExternalShippingSystemId
        /// </summary>
        [DataMember(Name="externalShippingSystemId", EmitDefaultValue=false)]
        public int? ExternalShippingSystemId { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShippingSystemName
        /// </summary>
        [DataMember(Name="shippingSystemName", EmitDefaultValue=false)]
        public string ShippingSystemName { get; set; }
    
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
            sb.Append("class CartonActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  DeliveredDate: ").Append(DeliveredDate).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
            sb.Append("  CartonNo: ").Append(CartonNo).Append("\n");
            sb.Append("  NumberOfCartons: ").Append(NumberOfCartons).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Shipped: ").Append(Shipped).Append("\n");
            sb.Append("  CarrierServiceId: ").Append(CarrierServiceId).Append("\n");
            sb.Append("  Dim1In: ").Append(Dim1In).Append("\n");
            sb.Append("  Dim2In: ").Append(Dim2In).Append("\n");
            sb.Append("  Dim3In: ").Append(Dim3In).Append("\n");
            sb.Append("  EstimatedZone: ").Append(EstimatedZone).Append("\n");
            sb.Append("  ParcelAccountNo: ").Append(ParcelAccountNo).Append("\n");
            sb.Append("  ThirdPartyParcelAccountNo: ").Append(ThirdPartyParcelAccountNo).Append("\n");
            sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  BillingOption: ").Append(BillingOption).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
            sb.Append("  DimWeight: ").Append(DimWeight).Append("\n");
            sb.Append("  LicensePlateNumber: ").Append(LicensePlateNumber).Append("\n");
            sb.Append("  ChargedFreightAmount: ").Append(ChargedFreightAmount).Append("\n");
            sb.Append("  PublishedFreightAmount: ").Append(PublishedFreightAmount).Append("\n");
            sb.Append("  RetailFreightAmount: ").Append(RetailFreightAmount).Append("\n");
            sb.Append("  AlternateUsage: ").Append(AlternateUsage).Append("\n");
            sb.Append("  GroupOrderId: ").Append(GroupOrderId).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderStatusName: ").Append(OrderStatusName).Append("\n");
            sb.Append("  FulfillmentProcessId: ").Append(FulfillmentProcessId).Append("\n");
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
            sb.Append("  OrderCreateDate: ").Append(OrderCreateDate).Append("\n");
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
            sb.Append("  ExternalShippingSystemId: ").Append(ExternalShippingSystemId).Append("\n");
            sb.Append("  ShippingSystemName: ").Append(ShippingSystemName).Append("\n");
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
            return this.Equals(obj as CartonActivity);
        }

        /// <summary>
        /// Returns true if CartonActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of CartonActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartonActivity other)
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
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.ShipDate == other.ShipDate ||
                    this.ShipDate != null &&
                    this.ShipDate.Equals(other.ShipDate)
                ) && 
                (
                    this.DeliveredDate == other.DeliveredDate ||
                    this.DeliveredDate != null &&
                    this.DeliveredDate.Equals(other.DeliveredDate)
                ) && 
                (
                    this.TrackingNo == other.TrackingNo ||
                    this.TrackingNo != null &&
                    this.TrackingNo.Equals(other.TrackingNo)
                ) && 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.WarehouseName == other.WarehouseName ||
                    this.WarehouseName != null &&
                    this.WarehouseName.Equals(other.WarehouseName)
                ) && 
                (
                    this.CartonNo == other.CartonNo ||
                    this.CartonNo != null &&
                    this.CartonNo.Equals(other.CartonNo)
                ) && 
                (
                    this.NumberOfCartons == other.NumberOfCartons ||
                    this.NumberOfCartons != null &&
                    this.NumberOfCartons.Equals(other.NumberOfCartons)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Shipped == other.Shipped ||
                    this.Shipped != null &&
                    this.Shipped.Equals(other.Shipped)
                ) && 
                (
                    this.CarrierServiceId == other.CarrierServiceId ||
                    this.CarrierServiceId != null &&
                    this.CarrierServiceId.Equals(other.CarrierServiceId)
                ) && 
                (
                    this.Dim1In == other.Dim1In ||
                    this.Dim1In != null &&
                    this.Dim1In.Equals(other.Dim1In)
                ) && 
                (
                    this.Dim2In == other.Dim2In ||
                    this.Dim2In != null &&
                    this.Dim2In.Equals(other.Dim2In)
                ) && 
                (
                    this.Dim3In == other.Dim3In ||
                    this.Dim3In != null &&
                    this.Dim3In.Equals(other.Dim3In)
                ) && 
                (
                    this.EstimatedZone == other.EstimatedZone ||
                    this.EstimatedZone != null &&
                    this.EstimatedZone.Equals(other.EstimatedZone)
                ) && 
                (
                    this.ParcelAccountNo == other.ParcelAccountNo ||
                    this.ParcelAccountNo != null &&
                    this.ParcelAccountNo.Equals(other.ParcelAccountNo)
                ) && 
                (
                    this.ThirdPartyParcelAccountNo == other.ThirdPartyParcelAccountNo ||
                    this.ThirdPartyParcelAccountNo != null &&
                    this.ThirdPartyParcelAccountNo.Equals(other.ThirdPartyParcelAccountNo)
                ) && 
                (
                    this.ManifestId == other.ManifestId ||
                    this.ManifestId != null &&
                    this.ManifestId.Equals(other.ManifestId)
                ) && 
                (
                    this.Residential == other.Residential ||
                    this.Residential != null &&
                    this.Residential.Equals(other.Residential)
                ) && 
                (
                    this.BillingOption == other.BillingOption ||
                    this.BillingOption != null &&
                    this.BillingOption.Equals(other.BillingOption)
                ) && 
                (
                    this.WeightLbs == other.WeightLbs ||
                    this.WeightLbs != null &&
                    this.WeightLbs.Equals(other.WeightLbs)
                ) && 
                (
                    this.DimWeight == other.DimWeight ||
                    this.DimWeight != null &&
                    this.DimWeight.Equals(other.DimWeight)
                ) && 
                (
                    this.LicensePlateNumber == other.LicensePlateNumber ||
                    this.LicensePlateNumber != null &&
                    this.LicensePlateNumber.Equals(other.LicensePlateNumber)
                ) && 
                (
                    this.ChargedFreightAmount == other.ChargedFreightAmount ||
                    this.ChargedFreightAmount != null &&
                    this.ChargedFreightAmount.Equals(other.ChargedFreightAmount)
                ) && 
                (
                    this.PublishedFreightAmount == other.PublishedFreightAmount ||
                    this.PublishedFreightAmount != null &&
                    this.PublishedFreightAmount.Equals(other.PublishedFreightAmount)
                ) && 
                (
                    this.RetailFreightAmount == other.RetailFreightAmount ||
                    this.RetailFreightAmount != null &&
                    this.RetailFreightAmount.Equals(other.RetailFreightAmount)
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
                    this.FulfillmentProcessId == other.FulfillmentProcessId ||
                    this.FulfillmentProcessId != null &&
                    this.FulfillmentProcessId.Equals(other.FulfillmentProcessId)
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
                    this.OrderCreateDate == other.OrderCreateDate ||
                    this.OrderCreateDate != null &&
                    this.OrderCreateDate.Equals(other.OrderCreateDate)
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
                    this.ExternalShippingSystemId == other.ExternalShippingSystemId ||
                    this.ExternalShippingSystemId != null &&
                    this.ExternalShippingSystemId.Equals(other.ExternalShippingSystemId)
                ) && 
                (
                    this.ShippingSystemName == other.ShippingSystemName ||
                    this.ShippingSystemName != null &&
                    this.ShippingSystemName.Equals(other.ShippingSystemName)
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
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.ShipDate != null)
                    hash = hash * 59 + this.ShipDate.GetHashCode();
                
                if (this.DeliveredDate != null)
                    hash = hash * 59 + this.DeliveredDate.GetHashCode();
                
                if (this.TrackingNo != null)
                    hash = hash * 59 + this.TrackingNo.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.WarehouseName != null)
                    hash = hash * 59 + this.WarehouseName.GetHashCode();
                
                if (this.CartonNo != null)
                    hash = hash * 59 + this.CartonNo.GetHashCode();
                
                if (this.NumberOfCartons != null)
                    hash = hash * 59 + this.NumberOfCartons.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Shipped != null)
                    hash = hash * 59 + this.Shipped.GetHashCode();
                
                if (this.CarrierServiceId != null)
                    hash = hash * 59 + this.CarrierServiceId.GetHashCode();
                
                if (this.Dim1In != null)
                    hash = hash * 59 + this.Dim1In.GetHashCode();
                
                if (this.Dim2In != null)
                    hash = hash * 59 + this.Dim2In.GetHashCode();
                
                if (this.Dim3In != null)
                    hash = hash * 59 + this.Dim3In.GetHashCode();
                
                if (this.EstimatedZone != null)
                    hash = hash * 59 + this.EstimatedZone.GetHashCode();
                
                if (this.ParcelAccountNo != null)
                    hash = hash * 59 + this.ParcelAccountNo.GetHashCode();
                
                if (this.ThirdPartyParcelAccountNo != null)
                    hash = hash * 59 + this.ThirdPartyParcelAccountNo.GetHashCode();
                
                if (this.ManifestId != null)
                    hash = hash * 59 + this.ManifestId.GetHashCode();
                
                if (this.Residential != null)
                    hash = hash * 59 + this.Residential.GetHashCode();
                
                if (this.BillingOption != null)
                    hash = hash * 59 + this.BillingOption.GetHashCode();
                
                if (this.WeightLbs != null)
                    hash = hash * 59 + this.WeightLbs.GetHashCode();
                
                if (this.DimWeight != null)
                    hash = hash * 59 + this.DimWeight.GetHashCode();
                
                if (this.LicensePlateNumber != null)
                    hash = hash * 59 + this.LicensePlateNumber.GetHashCode();
                
                if (this.ChargedFreightAmount != null)
                    hash = hash * 59 + this.ChargedFreightAmount.GetHashCode();
                
                if (this.PublishedFreightAmount != null)
                    hash = hash * 59 + this.PublishedFreightAmount.GetHashCode();
                
                if (this.RetailFreightAmount != null)
                    hash = hash * 59 + this.RetailFreightAmount.GetHashCode();
                
                if (this.AlternateUsage != null)
                    hash = hash * 59 + this.AlternateUsage.GetHashCode();
                
                if (this.GroupOrderId != null)
                    hash = hash * 59 + this.GroupOrderId.GetHashCode();
                
                if (this.OrderStatus != null)
                    hash = hash * 59 + this.OrderStatus.GetHashCode();
                
                if (this.OrderStatusName != null)
                    hash = hash * 59 + this.OrderStatusName.GetHashCode();
                
                if (this.FulfillmentProcessId != null)
                    hash = hash * 59 + this.FulfillmentProcessId.GetHashCode();
                
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
                
                if (this.OrderCreateDate != null)
                    hash = hash * 59 + this.OrderCreateDate.GetHashCode();
                
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
                
                if (this.ExternalShippingSystemId != null)
                    hash = hash * 59 + this.ExternalShippingSystemId.GetHashCode();
                
                if (this.ShippingSystemName != null)
                    hash = hash * 59 + this.ShippingSystemName.GetHashCode();
                
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
