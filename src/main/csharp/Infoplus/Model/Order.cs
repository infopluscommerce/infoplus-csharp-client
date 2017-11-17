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
    public partial class Order :  IEquatable<Order>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// Initializes a new instance of the <see cref="Order" />class.
        /// </summary>
        /// <param name="CustomerOrderNo">CustomerOrderNo.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="OrderDate">OrderDate (required).</param>
        /// <param name="CustomerNo">CustomerNo.</param>
        /// <param name="UseOrderNoRoot">UseOrderNoRoot.</param>
        /// <param name="FirstShipDate">FirstShipDate.</param>
        /// <param name="LastShipDate">LastShipDate.</param>
        /// <param name="DeliverOnDate">DeliverOnDate.</param>
        /// <param name="NeedByDate">NeedByDate.</param>
        /// <param name="CarrierId">CarrierId.</param>
        /// <param name="ServiceTypeId">ServiceTypeId.</param>
        /// <param name="ShipVia">ShipVia.</param>
        /// <param name="MediaCode">MediaCode (required).</param>
        /// <param name="LegacyRestrictionType">LegacyRestrictionType (required).</param>
        /// <param name="AlcoholOrderType">AlcoholOrderType.</param>
        /// <param name="AlternateUsage">AlternateUsage.</param>
        /// <param name="AuthorizedBy">AuthorizedBy.</param>
        /// <param name="BatchNo">BatchNo.</param>
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
        /// <param name="CostCenter">CostCenter.</param>
        /// <param name="CustomerPONo">CustomerPONo.</param>
        /// <param name="DistributionChannel">DistributionChannel.</param>
        /// <param name="Division">Division.</param>
        /// <param name="GiftMessage">GiftMessage.</param>
        /// <param name="HoldCode">HoldCode.</param>
        /// <param name="OrderMessage">OrderMessage.</param>
        /// <param name="OrderSourceId">OrderSourceId.</param>
        /// <param name="PackingSlipTemplateId">PackingSlipTemplateId.</param>
        /// <param name="OrderConfirmationEmailTemplateId">OrderConfirmationEmailTemplateId.</param>
        /// <param name="ShipmentConfirmationEmailTemplateId">ShipmentConfirmationEmailTemplateId.</param>
        /// <param name="PriceLevel">PriceLevel.</param>
        /// <param name="PriorityCode">PriorityCode.</param>
        /// <param name="ShipCode">ShipCode.</param>
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
        /// <param name="LineItems">LineItems (required).</param>
        /// <param name="ExtraOrderData">ExtraOrderData.</param>
        /// <param name="ExtraLineItemData">ExtraLineItemData.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Order(string CustomerOrderNo = null, int? LobId = null, int? WarehouseId = null, DateTime? OrderDate = null, string CustomerNo = null, int? UseOrderNoRoot = null, DateTime? FirstShipDate = null, DateTime? LastShipDate = null, DateTime? DeliverOnDate = null, DateTime? NeedByDate = null, int? CarrierId = null, string ServiceTypeId = null, string ShipVia = null, string MediaCode = null, string LegacyRestrictionType = null, string AlcoholOrderType = null, string AlternateUsage = null, string AuthorizedBy = null, string BatchNo = null, string BillToAttention = null, string BillToCompany = null, string BillToStreet = null, string BillToStreet2 = null, string BillToStreet3 = null, string BillToCity = null, string BillToState = null, string BillToZip = null, string BillToCountry = null, string BillToPhone = null, string BillToEmail = null, string CostCenter = null, string CustomerPONo = null, string DistributionChannel = null, int? Division = null, string GiftMessage = null, string HoldCode = null, string OrderMessage = null, int? OrderSourceId = null, int? PackingSlipTemplateId = null, int? OrderConfirmationEmailTemplateId = null, int? ShipmentConfirmationEmailTemplateId = null, string PriceLevel = null, int? PriorityCode = null, string ShipCode = null, string ShipToAttention = null, string ShipToCompany = null, string ShipToStreet = null, string ShipToStreet2 = null, string ShipToStreet3 = null, string ShipToCity = null, string ShipToState = null, string ShipToZip = null, string ShipToCountry = null, string ShipToPhone = null, string ShipToEmail = null, List<OrderLine> LineItems = null, List<OrderExtraOrderData> ExtraOrderData = null, List<OrderExtraLineItemData> ExtraLineItemData = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Order and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Order and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "OrderDate" is required (not null)
            if (OrderDate == null)
            {
                throw new InvalidDataException("OrderDate is a required property for Order and cannot be null");
            }
            else
            {
                this.OrderDate = OrderDate;
            }
            // to ensure "MediaCode" is required (not null)
            if (MediaCode == null)
            {
                throw new InvalidDataException("MediaCode is a required property for Order and cannot be null");
            }
            else
            {
                this.MediaCode = MediaCode;
            }
            // to ensure "LegacyRestrictionType" is required (not null)
            if (LegacyRestrictionType == null)
            {
                throw new InvalidDataException("LegacyRestrictionType is a required property for Order and cannot be null");
            }
            else
            {
                this.LegacyRestrictionType = LegacyRestrictionType;
            }
            // to ensure "LineItems" is required (not null)
            if (LineItems == null)
            {
                throw new InvalidDataException("LineItems is a required property for Order and cannot be null");
            }
            else
            {
                this.LineItems = LineItems;
            }
            this.CustomerOrderNo = CustomerOrderNo;
            this.CustomerNo = CustomerNo;
            this.UseOrderNoRoot = UseOrderNoRoot;
            this.FirstShipDate = FirstShipDate;
            this.LastShipDate = LastShipDate;
            this.DeliverOnDate = DeliverOnDate;
            this.NeedByDate = NeedByDate;
            this.CarrierId = CarrierId;
            this.ServiceTypeId = ServiceTypeId;
            this.ShipVia = ShipVia;
            this.AlcoholOrderType = AlcoholOrderType;
            this.AlternateUsage = AlternateUsage;
            this.AuthorizedBy = AuthorizedBy;
            this.BatchNo = BatchNo;
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
            this.CostCenter = CostCenter;
            this.CustomerPONo = CustomerPONo;
            this.DistributionChannel = DistributionChannel;
            this.Division = Division;
            this.GiftMessage = GiftMessage;
            this.HoldCode = HoldCode;
            this.OrderMessage = OrderMessage;
            this.OrderSourceId = OrderSourceId;
            this.PackingSlipTemplateId = PackingSlipTemplateId;
            this.OrderConfirmationEmailTemplateId = OrderConfirmationEmailTemplateId;
            this.ShipmentConfirmationEmailTemplateId = ShipmentConfirmationEmailTemplateId;
            this.PriceLevel = PriceLevel;
            this.PriorityCode = PriorityCode;
            this.ShipCode = ShipCode;
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
            this.ExtraOrderData = ExtraOrderData;
            this.ExtraLineItemData = ExtraLineItemData;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomerOrderNo
        /// </summary>
        [DataMember(Name="customerOrderNo", EmitDefaultValue=false)]
        public string CustomerOrderNo { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerNo
        /// </summary>
        [DataMember(Name="customerNo", EmitDefaultValue=false)]
        public string CustomerNo { get; set; }
    
        /// <summary>
        /// Gets or Sets UseOrderNoRoot
        /// </summary>
        [DataMember(Name="useOrderNoRoot", EmitDefaultValue=false)]
        public int? UseOrderNoRoot { get; set; }
    
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
        /// Gets or Sets NeedByDate
        /// </summary>
        [DataMember(Name="needByDate", EmitDefaultValue=false)]
        public DateTime? NeedByDate { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name="carrierId", EmitDefaultValue=false)]
        public int? CarrierId { get; set; }
    
        /// <summary>
        /// Gets or Sets ServiceTypeId
        /// </summary>
        [DataMember(Name="serviceTypeId", EmitDefaultValue=false)]
        public string ServiceTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipVia
        /// </summary>
        [DataMember(Name="shipVia", EmitDefaultValue=false)]
        public string ShipVia { get; set; }
    
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
        /// Gets or Sets AlcoholOrderType
        /// </summary>
        [DataMember(Name="alcoholOrderType", EmitDefaultValue=false)]
        public string AlcoholOrderType { get; set; }
    
        /// <summary>
        /// Gets or Sets AlternateUsage
        /// </summary>
        [DataMember(Name="alternateUsage", EmitDefaultValue=false)]
        public string AlternateUsage { get; set; }
    
        /// <summary>
        /// Gets or Sets AuthorizationAmount
        /// </summary>
        [DataMember(Name="authorizationAmount", EmitDefaultValue=false)]
        public double? AuthorizationAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets AuthorizedBy
        /// </summary>
        [DataMember(Name="authorizedBy", EmitDefaultValue=false)]
        public string AuthorizedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets BalanceDue
        /// </summary>
        [DataMember(Name="balanceDue", EmitDefaultValue=false)]
        public double? BalanceDue { get; private set; }
    
        /// <summary>
        /// Gets or Sets BatchNo
        /// </summary>
        [DataMember(Name="batchNo", EmitDefaultValue=false)]
        public string BatchNo { get; set; }
    
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
        /// Gets or Sets NumberOfCartons
        /// </summary>
        [DataMember(Name="numberOfCartons", EmitDefaultValue=false)]
        public int? NumberOfCartons { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfPallets
        /// </summary>
        [DataMember(Name="numberOfPallets", EmitDefaultValue=false)]
        public int? NumberOfPallets { get; private set; }
    
        /// <summary>
        /// Gets or Sets CompletionStatus
        /// </summary>
        [DataMember(Name="completionStatus", EmitDefaultValue=false)]
        public string CompletionStatus { get; private set; }
    
        /// <summary>
        /// Gets or Sets ParcelAccountId
        /// </summary>
        [DataMember(Name="parcelAccountId", EmitDefaultValue=false)]
        public int? ParcelAccountId { get; private set; }
    
        /// <summary>
        /// Gets or Sets CostCenter
        /// </summary>
        [DataMember(Name="costCenter", EmitDefaultValue=false)]
        public string CostCenter { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomerPONo
        /// </summary>
        [DataMember(Name="customerPONo", EmitDefaultValue=false)]
        public string CustomerPONo { get; set; }
    
        /// <summary>
        /// Gets or Sets DistributionChannel
        /// </summary>
        [DataMember(Name="distributionChannel", EmitDefaultValue=false)]
        public string DistributionChannel { get; set; }
    
        /// <summary>
        /// Gets or Sets DistributionCharges
        /// </summary>
        [DataMember(Name="distributionCharges", EmitDefaultValue=false)]
        public double? DistributionCharges { get; private set; }
    
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public int? Division { get; set; }
    
        /// <summary>
        /// Gets or Sets EnteredBy
        /// </summary>
        [DataMember(Name="enteredBy", EmitDefaultValue=false)]
        public string EnteredBy { get; private set; }
    
        /// <summary>
        /// Gets or Sets EstimatedWeightLbs
        /// </summary>
        [DataMember(Name="estimatedWeightLbs", EmitDefaultValue=false)]
        public double? EstimatedWeightLbs { get; private set; }
    
        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="freight", EmitDefaultValue=false)]
        public double? Freight { get; private set; }
    
        /// <summary>
        /// Gets or Sets GiftMessage
        /// </summary>
        [DataMember(Name="giftMessage", EmitDefaultValue=false)]
        public string GiftMessage { get; set; }
    
        /// <summary>
        /// Gets or Sets GroupOrderId
        /// </summary>
        [DataMember(Name="groupOrderId", EmitDefaultValue=false)]
        public double? GroupOrderId { get; private set; }
    
        /// <summary>
        /// Gets or Sets HoldCode
        /// </summary>
        [DataMember(Name="holdCode", EmitDefaultValue=false)]
        public string HoldCode { get; set; }
    
        /// <summary>
        /// Gets or Sets IntegrationPartnerId
        /// </summary>
        [DataMember(Name="integrationPartnerId", EmitDefaultValue=false)]
        public int? IntegrationPartnerId { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfLineItems
        /// </summary>
        [DataMember(Name="numberOfLineItems", EmitDefaultValue=false)]
        public int? NumberOfLineItems { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
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
        /// Gets or Sets OrderLoadProgramId
        /// </summary>
        [DataMember(Name="orderLoadProgramId", EmitDefaultValue=false)]
        public int? OrderLoadProgramId { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderMessage
        /// </summary>
        [DataMember(Name="orderMessage", EmitDefaultValue=false)]
        public string OrderMessage { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderReason
        /// </summary>
        [DataMember(Name="orderReason", EmitDefaultValue=false)]
        public int? OrderReason { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }
    
        /// <summary>
        /// Gets or Sets PackingSlipTemplateId
        /// </summary>
        [DataMember(Name="packingSlipTemplateId", EmitDefaultValue=false)]
        public int? PackingSlipTemplateId { get; set; }
    
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
        /// Gets or Sets PriceLevel
        /// </summary>
        [DataMember(Name="priceLevel", EmitDefaultValue=false)]
        public string PriceLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets PriorityCode
        /// </summary>
        [DataMember(Name="priorityCode", EmitDefaultValue=false)]
        public int? PriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets FulfillmentProcessId
        /// </summary>
        [DataMember(Name="fulfillmentProcessId", EmitDefaultValue=false)]
        public int? FulfillmentProcessId { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipBy
        /// </summary>
        [DataMember(Name="shipBy", EmitDefaultValue=false)]
        public DateTime? ShipBy { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipCode
        /// </summary>
        [DataMember(Name="shipCode", EmitDefaultValue=false)]
        public string ShipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; private set; }
    
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
        /// Gets or Sets ShippingCharge
        /// </summary>
        [DataMember(Name="shippingCharge", EmitDefaultValue=false)]
        public double? ShippingCharge { get; private set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets StopBackOrders
        /// </summary>
        [DataMember(Name="stopBackOrders", EmitDefaultValue=false)]
        public string StopBackOrders { get; private set; }
    
        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; private set; }
    
        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public double? Tax { get; private set; }
    
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; private set; }
    
        /// <summary>
        /// Gets or Sets TotalPaid
        /// </summary>
        [DataMember(Name="totalPaid", EmitDefaultValue=false)]
        public double? TotalPaid { get; private set; }
    
        /// <summary>
        /// Gets or Sets TotalQty
        /// </summary>
        [DataMember(Name="totalQty", EmitDefaultValue=false)]
        public int? TotalQty { get; private set; }
    
        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public double? WeightLbs { get; private set; }
    
        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<OrderLine> LineItems { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtraOrderData
        /// </summary>
        [DataMember(Name="extraOrderData", EmitDefaultValue=false)]
        public List<OrderExtraOrderData> ExtraOrderData { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtraLineItemData
        /// </summary>
        [DataMember(Name="extraLineItemData", EmitDefaultValue=false)]
        public List<OrderExtraLineItemData> ExtraLineItemData { get; set; }
    
        /// <summary>
        /// Gets or Sets ExternalShippingSystemId
        /// </summary>
        [DataMember(Name="externalShippingSystemId", EmitDefaultValue=false)]
        public int? ExternalShippingSystemId { get; private set; }
    
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
            sb.Append("class Order {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  CustomerOrderNo: ").Append(CustomerOrderNo).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  CustomerNo: ").Append(CustomerNo).Append("\n");
            sb.Append("  UseOrderNoRoot: ").Append(UseOrderNoRoot).Append("\n");
            sb.Append("  FirstShipDate: ").Append(FirstShipDate).Append("\n");
            sb.Append("  LastShipDate: ").Append(LastShipDate).Append("\n");
            sb.Append("  DeliverOnDate: ").Append(DeliverOnDate).Append("\n");
            sb.Append("  NeedByDate: ").Append(NeedByDate).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  ServiceTypeId: ").Append(ServiceTypeId).Append("\n");
            sb.Append("  ShipVia: ").Append(ShipVia).Append("\n");
            sb.Append("  MediaCode: ").Append(MediaCode).Append("\n");
            sb.Append("  LegacyRestrictionType: ").Append(LegacyRestrictionType).Append("\n");
            sb.Append("  AlcoholOrderType: ").Append(AlcoholOrderType).Append("\n");
            sb.Append("  AlternateUsage: ").Append(AlternateUsage).Append("\n");
            sb.Append("  AuthorizationAmount: ").Append(AuthorizationAmount).Append("\n");
            sb.Append("  AuthorizedBy: ").Append(AuthorizedBy).Append("\n");
            sb.Append("  BalanceDue: ").Append(BalanceDue).Append("\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
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
            sb.Append("  NumberOfCartons: ").Append(NumberOfCartons).Append("\n");
            sb.Append("  NumberOfPallets: ").Append(NumberOfPallets).Append("\n");
            sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
            sb.Append("  ParcelAccountId: ").Append(ParcelAccountId).Append("\n");
            sb.Append("  CostCenter: ").Append(CostCenter).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CustomerPONo: ").Append(CustomerPONo).Append("\n");
            sb.Append("  DistributionChannel: ").Append(DistributionChannel).Append("\n");
            sb.Append("  DistributionCharges: ").Append(DistributionCharges).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  EnteredBy: ").Append(EnteredBy).Append("\n");
            sb.Append("  EstimatedWeightLbs: ").Append(EstimatedWeightLbs).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  GroupOrderId: ").Append(GroupOrderId).Append("\n");
            sb.Append("  HoldCode: ").Append(HoldCode).Append("\n");
            sb.Append("  IntegrationPartnerId: ").Append(IntegrationPartnerId).Append("\n");
            sb.Append("  NumberOfLineItems: ").Append(NumberOfLineItems).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  OmsOrderNo: ").Append(OmsOrderNo).Append("\n");
            sb.Append("  OmsCustomerId: ").Append(OmsCustomerId).Append("\n");
            sb.Append("  OrderLoadProgramId: ").Append(OrderLoadProgramId).Append("\n");
            sb.Append("  OrderMessage: ").Append(OrderMessage).Append("\n");
            sb.Append("  OrderReason: ").Append(OrderReason).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  PackingSlipTemplateId: ").Append(PackingSlipTemplateId).Append("\n");
            sb.Append("  OrderConfirmationEmailTemplateId: ").Append(OrderConfirmationEmailTemplateId).Append("\n");
            sb.Append("  ShipmentConfirmationEmailTemplateId: ").Append(ShipmentConfirmationEmailTemplateId).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  PriorityCode: ").Append(PriorityCode).Append("\n");
            sb.Append("  FulfillmentProcessId: ").Append(FulfillmentProcessId).Append("\n");
            sb.Append("  ShipBy: ").Append(ShipBy).Append("\n");
            sb.Append("  ShipCode: ").Append(ShipCode).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
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
            sb.Append("  ShippingCharge: ").Append(ShippingCharge).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StopBackOrders: ").Append(StopBackOrders).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
            sb.Append("  TotalQty: ").Append(TotalQty).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ExtraOrderData: ").Append(ExtraOrderData).Append("\n");
            sb.Append("  ExtraLineItemData: ").Append(ExtraLineItemData).Append("\n");
            sb.Append("  ExternalShippingSystemId: ").Append(ExternalShippingSystemId).Append("\n");
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.CustomerOrderNo == other.CustomerOrderNo ||
                    this.CustomerOrderNo != null &&
                    this.CustomerOrderNo.Equals(other.CustomerOrderNo)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
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
                    this.CustomerNo == other.CustomerNo ||
                    this.CustomerNo != null &&
                    this.CustomerNo.Equals(other.CustomerNo)
                ) && 
                (
                    this.UseOrderNoRoot == other.UseOrderNoRoot ||
                    this.UseOrderNoRoot != null &&
                    this.UseOrderNoRoot.Equals(other.UseOrderNoRoot)
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
                    this.NeedByDate == other.NeedByDate ||
                    this.NeedByDate != null &&
                    this.NeedByDate.Equals(other.NeedByDate)
                ) && 
                (
                    this.CarrierId == other.CarrierId ||
                    this.CarrierId != null &&
                    this.CarrierId.Equals(other.CarrierId)
                ) && 
                (
                    this.ServiceTypeId == other.ServiceTypeId ||
                    this.ServiceTypeId != null &&
                    this.ServiceTypeId.Equals(other.ServiceTypeId)
                ) && 
                (
                    this.ShipVia == other.ShipVia ||
                    this.ShipVia != null &&
                    this.ShipVia.Equals(other.ShipVia)
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
                    this.AlcoholOrderType == other.AlcoholOrderType ||
                    this.AlcoholOrderType != null &&
                    this.AlcoholOrderType.Equals(other.AlcoholOrderType)
                ) && 
                (
                    this.AlternateUsage == other.AlternateUsage ||
                    this.AlternateUsage != null &&
                    this.AlternateUsage.Equals(other.AlternateUsage)
                ) && 
                (
                    this.AuthorizationAmount == other.AuthorizationAmount ||
                    this.AuthorizationAmount != null &&
                    this.AuthorizationAmount.Equals(other.AuthorizationAmount)
                ) && 
                (
                    this.AuthorizedBy == other.AuthorizedBy ||
                    this.AuthorizedBy != null &&
                    this.AuthorizedBy.Equals(other.AuthorizedBy)
                ) && 
                (
                    this.BalanceDue == other.BalanceDue ||
                    this.BalanceDue != null &&
                    this.BalanceDue.Equals(other.BalanceDue)
                ) && 
                (
                    this.BatchNo == other.BatchNo ||
                    this.BatchNo != null &&
                    this.BatchNo.Equals(other.BatchNo)
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
                    this.NumberOfCartons == other.NumberOfCartons ||
                    this.NumberOfCartons != null &&
                    this.NumberOfCartons.Equals(other.NumberOfCartons)
                ) && 
                (
                    this.NumberOfPallets == other.NumberOfPallets ||
                    this.NumberOfPallets != null &&
                    this.NumberOfPallets.Equals(other.NumberOfPallets)
                ) && 
                (
                    this.CompletionStatus == other.CompletionStatus ||
                    this.CompletionStatus != null &&
                    this.CompletionStatus.Equals(other.CompletionStatus)
                ) && 
                (
                    this.ParcelAccountId == other.ParcelAccountId ||
                    this.ParcelAccountId != null &&
                    this.ParcelAccountId.Equals(other.ParcelAccountId)
                ) && 
                (
                    this.CostCenter == other.CostCenter ||
                    this.CostCenter != null &&
                    this.CostCenter.Equals(other.CostCenter)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.CustomerPONo == other.CustomerPONo ||
                    this.CustomerPONo != null &&
                    this.CustomerPONo.Equals(other.CustomerPONo)
                ) && 
                (
                    this.DistributionChannel == other.DistributionChannel ||
                    this.DistributionChannel != null &&
                    this.DistributionChannel.Equals(other.DistributionChannel)
                ) && 
                (
                    this.DistributionCharges == other.DistributionCharges ||
                    this.DistributionCharges != null &&
                    this.DistributionCharges.Equals(other.DistributionCharges)
                ) && 
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) && 
                (
                    this.EnteredBy == other.EnteredBy ||
                    this.EnteredBy != null &&
                    this.EnteredBy.Equals(other.EnteredBy)
                ) && 
                (
                    this.EstimatedWeightLbs == other.EstimatedWeightLbs ||
                    this.EstimatedWeightLbs != null &&
                    this.EstimatedWeightLbs.Equals(other.EstimatedWeightLbs)
                ) && 
                (
                    this.Freight == other.Freight ||
                    this.Freight != null &&
                    this.Freight.Equals(other.Freight)
                ) && 
                (
                    this.GiftMessage == other.GiftMessage ||
                    this.GiftMessage != null &&
                    this.GiftMessage.Equals(other.GiftMessage)
                ) && 
                (
                    this.GroupOrderId == other.GroupOrderId ||
                    this.GroupOrderId != null &&
                    this.GroupOrderId.Equals(other.GroupOrderId)
                ) && 
                (
                    this.HoldCode == other.HoldCode ||
                    this.HoldCode != null &&
                    this.HoldCode.Equals(other.HoldCode)
                ) && 
                (
                    this.IntegrationPartnerId == other.IntegrationPartnerId ||
                    this.IntegrationPartnerId != null &&
                    this.IntegrationPartnerId.Equals(other.IntegrationPartnerId)
                ) && 
                (
                    this.NumberOfLineItems == other.NumberOfLineItems ||
                    this.NumberOfLineItems != null &&
                    this.NumberOfLineItems.Equals(other.NumberOfLineItems)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
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
                    this.OrderLoadProgramId == other.OrderLoadProgramId ||
                    this.OrderLoadProgramId != null &&
                    this.OrderLoadProgramId.Equals(other.OrderLoadProgramId)
                ) && 
                (
                    this.OrderMessage == other.OrderMessage ||
                    this.OrderMessage != null &&
                    this.OrderMessage.Equals(other.OrderMessage)
                ) && 
                (
                    this.OrderReason == other.OrderReason ||
                    this.OrderReason != null &&
                    this.OrderReason.Equals(other.OrderReason)
                ) && 
                (
                    this.OrderSourceId == other.OrderSourceId ||
                    this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(other.OrderSourceId)
                ) && 
                (
                    this.PackingSlipTemplateId == other.PackingSlipTemplateId ||
                    this.PackingSlipTemplateId != null &&
                    this.PackingSlipTemplateId.Equals(other.PackingSlipTemplateId)
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
                    this.PriceLevel == other.PriceLevel ||
                    this.PriceLevel != null &&
                    this.PriceLevel.Equals(other.PriceLevel)
                ) && 
                (
                    this.PriorityCode == other.PriorityCode ||
                    this.PriorityCode != null &&
                    this.PriorityCode.Equals(other.PriorityCode)
                ) && 
                (
                    this.FulfillmentProcessId == other.FulfillmentProcessId ||
                    this.FulfillmentProcessId != null &&
                    this.FulfillmentProcessId.Equals(other.FulfillmentProcessId)
                ) && 
                (
                    this.ShipBy == other.ShipBy ||
                    this.ShipBy != null &&
                    this.ShipBy.Equals(other.ShipBy)
                ) && 
                (
                    this.ShipCode == other.ShipCode ||
                    this.ShipCode != null &&
                    this.ShipCode.Equals(other.ShipCode)
                ) && 
                (
                    this.ShipDate == other.ShipDate ||
                    this.ShipDate != null &&
                    this.ShipDate.Equals(other.ShipDate)
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
                    this.ShippingCharge == other.ShippingCharge ||
                    this.ShippingCharge != null &&
                    this.ShippingCharge.Equals(other.ShippingCharge)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StopBackOrders == other.StopBackOrders ||
                    this.StopBackOrders != null &&
                    this.StopBackOrders.Equals(other.StopBackOrders)
                ) && 
                (
                    this.Subtotal == other.Subtotal ||
                    this.Subtotal != null &&
                    this.Subtotal.Equals(other.Subtotal)
                ) && 
                (
                    this.Tax == other.Tax ||
                    this.Tax != null &&
                    this.Tax.Equals(other.Tax)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.TotalPaid == other.TotalPaid ||
                    this.TotalPaid != null &&
                    this.TotalPaid.Equals(other.TotalPaid)
                ) && 
                (
                    this.TotalQty == other.TotalQty ||
                    this.TotalQty != null &&
                    this.TotalQty.Equals(other.TotalQty)
                ) && 
                (
                    this.WeightLbs == other.WeightLbs ||
                    this.WeightLbs != null &&
                    this.WeightLbs.Equals(other.WeightLbs)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.ExtraOrderData == other.ExtraOrderData ||
                    this.ExtraOrderData != null &&
                    this.ExtraOrderData.SequenceEqual(other.ExtraOrderData)
                ) && 
                (
                    this.ExtraLineItemData == other.ExtraLineItemData ||
                    this.ExtraLineItemData != null &&
                    this.ExtraLineItemData.SequenceEqual(other.ExtraLineItemData)
                ) && 
                (
                    this.ExternalShippingSystemId == other.ExternalShippingSystemId ||
                    this.ExternalShippingSystemId != null &&
                    this.ExternalShippingSystemId.Equals(other.ExternalShippingSystemId)
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
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.CustomerOrderNo != null)
                    hash = hash * 59 + this.CustomerOrderNo.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.OrderDate != null)
                    hash = hash * 59 + this.OrderDate.GetHashCode();
                
                if (this.CustomerNo != null)
                    hash = hash * 59 + this.CustomerNo.GetHashCode();
                
                if (this.UseOrderNoRoot != null)
                    hash = hash * 59 + this.UseOrderNoRoot.GetHashCode();
                
                if (this.FirstShipDate != null)
                    hash = hash * 59 + this.FirstShipDate.GetHashCode();
                
                if (this.LastShipDate != null)
                    hash = hash * 59 + this.LastShipDate.GetHashCode();
                
                if (this.DeliverOnDate != null)
                    hash = hash * 59 + this.DeliverOnDate.GetHashCode();
                
                if (this.NeedByDate != null)
                    hash = hash * 59 + this.NeedByDate.GetHashCode();
                
                if (this.CarrierId != null)
                    hash = hash * 59 + this.CarrierId.GetHashCode();
                
                if (this.ServiceTypeId != null)
                    hash = hash * 59 + this.ServiceTypeId.GetHashCode();
                
                if (this.ShipVia != null)
                    hash = hash * 59 + this.ShipVia.GetHashCode();
                
                if (this.MediaCode != null)
                    hash = hash * 59 + this.MediaCode.GetHashCode();
                
                if (this.LegacyRestrictionType != null)
                    hash = hash * 59 + this.LegacyRestrictionType.GetHashCode();
                
                if (this.AlcoholOrderType != null)
                    hash = hash * 59 + this.AlcoholOrderType.GetHashCode();
                
                if (this.AlternateUsage != null)
                    hash = hash * 59 + this.AlternateUsage.GetHashCode();
                
                if (this.AuthorizationAmount != null)
                    hash = hash * 59 + this.AuthorizationAmount.GetHashCode();
                
                if (this.AuthorizedBy != null)
                    hash = hash * 59 + this.AuthorizedBy.GetHashCode();
                
                if (this.BalanceDue != null)
                    hash = hash * 59 + this.BalanceDue.GetHashCode();
                
                if (this.BatchNo != null)
                    hash = hash * 59 + this.BatchNo.GetHashCode();
                
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
                
                if (this.NumberOfCartons != null)
                    hash = hash * 59 + this.NumberOfCartons.GetHashCode();
                
                if (this.NumberOfPallets != null)
                    hash = hash * 59 + this.NumberOfPallets.GetHashCode();
                
                if (this.CompletionStatus != null)
                    hash = hash * 59 + this.CompletionStatus.GetHashCode();
                
                if (this.ParcelAccountId != null)
                    hash = hash * 59 + this.ParcelAccountId.GetHashCode();
                
                if (this.CostCenter != null)
                    hash = hash * 59 + this.CostCenter.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.CustomerPONo != null)
                    hash = hash * 59 + this.CustomerPONo.GetHashCode();
                
                if (this.DistributionChannel != null)
                    hash = hash * 59 + this.DistributionChannel.GetHashCode();
                
                if (this.DistributionCharges != null)
                    hash = hash * 59 + this.DistributionCharges.GetHashCode();
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.EnteredBy != null)
                    hash = hash * 59 + this.EnteredBy.GetHashCode();
                
                if (this.EstimatedWeightLbs != null)
                    hash = hash * 59 + this.EstimatedWeightLbs.GetHashCode();
                
                if (this.Freight != null)
                    hash = hash * 59 + this.Freight.GetHashCode();
                
                if (this.GiftMessage != null)
                    hash = hash * 59 + this.GiftMessage.GetHashCode();
                
                if (this.GroupOrderId != null)
                    hash = hash * 59 + this.GroupOrderId.GetHashCode();
                
                if (this.HoldCode != null)
                    hash = hash * 59 + this.HoldCode.GetHashCode();
                
                if (this.IntegrationPartnerId != null)
                    hash = hash * 59 + this.IntegrationPartnerId.GetHashCode();
                
                if (this.NumberOfLineItems != null)
                    hash = hash * 59 + this.NumberOfLineItems.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.OmsOrderNo != null)
                    hash = hash * 59 + this.OmsOrderNo.GetHashCode();
                
                if (this.OmsCustomerId != null)
                    hash = hash * 59 + this.OmsCustomerId.GetHashCode();
                
                if (this.OrderLoadProgramId != null)
                    hash = hash * 59 + this.OrderLoadProgramId.GetHashCode();
                
                if (this.OrderMessage != null)
                    hash = hash * 59 + this.OrderMessage.GetHashCode();
                
                if (this.OrderReason != null)
                    hash = hash * 59 + this.OrderReason.GetHashCode();
                
                if (this.OrderSourceId != null)
                    hash = hash * 59 + this.OrderSourceId.GetHashCode();
                
                if (this.PackingSlipTemplateId != null)
                    hash = hash * 59 + this.PackingSlipTemplateId.GetHashCode();
                
                if (this.OrderConfirmationEmailTemplateId != null)
                    hash = hash * 59 + this.OrderConfirmationEmailTemplateId.GetHashCode();
                
                if (this.ShipmentConfirmationEmailTemplateId != null)
                    hash = hash * 59 + this.ShipmentConfirmationEmailTemplateId.GetHashCode();
                
                if (this.PriceLevel != null)
                    hash = hash * 59 + this.PriceLevel.GetHashCode();
                
                if (this.PriorityCode != null)
                    hash = hash * 59 + this.PriorityCode.GetHashCode();
                
                if (this.FulfillmentProcessId != null)
                    hash = hash * 59 + this.FulfillmentProcessId.GetHashCode();
                
                if (this.ShipBy != null)
                    hash = hash * 59 + this.ShipBy.GetHashCode();
                
                if (this.ShipCode != null)
                    hash = hash * 59 + this.ShipCode.GetHashCode();
                
                if (this.ShipDate != null)
                    hash = hash * 59 + this.ShipDate.GetHashCode();
                
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
                
                if (this.ShippingCharge != null)
                    hash = hash * 59 + this.ShippingCharge.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StopBackOrders != null)
                    hash = hash * 59 + this.StopBackOrders.GetHashCode();
                
                if (this.Subtotal != null)
                    hash = hash * 59 + this.Subtotal.GetHashCode();
                
                if (this.Tax != null)
                    hash = hash * 59 + this.Tax.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.TotalPaid != null)
                    hash = hash * 59 + this.TotalPaid.GetHashCode();
                
                if (this.TotalQty != null)
                    hash = hash * 59 + this.TotalQty.GetHashCode();
                
                if (this.WeightLbs != null)
                    hash = hash * 59 + this.WeightLbs.GetHashCode();
                
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                
                if (this.ExtraOrderData != null)
                    hash = hash * 59 + this.ExtraOrderData.GetHashCode();
                
                if (this.ExtraLineItemData != null)
                    hash = hash * 59 + this.ExtraLineItemData.GetHashCode();
                
                if (this.ExternalShippingSystemId != null)
                    hash = hash * 59 + this.ExternalShippingSystemId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
