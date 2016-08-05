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
    public partial class FulfillmentProcess :  IEquatable<FulfillmentProcess>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentProcess" /> class.
        /// Initializes a new instance of the <see cref="FulfillmentProcess" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="FulfillmentPlanId">FulfillmentPlanId (required).</param>
        /// <param name="PickScanSchemeId">PickScanSchemeId (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="OrderSmartFilterId">OrderSmartFilterId.</param>
        /// <param name="LocationSmartFilterId">LocationSmartFilterId.</param>
        /// <param name="CompletedPicks">CompletedPicks.</param>
        /// <param name="TotalPicks">TotalPicks.</param>
        /// <param name="ShippedCasebreaks">ShippedCasebreaks.</param>
        /// <param name="TotalCasebreaksToShip">TotalCasebreaksToShip.</param>
        /// <param name="ShippedOrders">ShippedOrders.</param>
        /// <param name="TotalOrdersToShip">TotalOrdersToShip.</param>
        /// <param name="CompletedToDo">CompletedToDo.</param>
        /// <param name="TotalToDo">TotalToDo.</param>
        /// <param name="CreatePickWork">CreatePickWork (default to false).</param>
        /// <param name="PickingRule">PickingRule.</param>
        /// <param name="LayoutRule">LayoutRule.</param>
        /// <param name="PickSortRule">PickSortRule.</param>
        /// <param name="FirstPickPosition">FirstPickPosition.</param>
        /// <param name="PickListFormat">PickListFormat.</param>
        /// <param name="PickListLayout">PickListLayout.</param>
        /// <param name="PickListGroup">PickListGroup.</param>
        /// <param name="PickListSort">PickListSort.</param>
        /// <param name="PickSummaryFormat">PickSummaryFormat.</param>
        /// <param name="PickSummaryLayout">PickSummaryLayout.</param>
        /// <param name="PickSummarySort">PickSummarySort.</param>
        /// <param name="CreatePickSummary">CreatePickSummary (default to false).</param>
        /// <param name="CreatePickList">CreatePickList (default to false).</param>
        /// <param name="PreGenerateParcelLabels">PreGenerateParcelLabels (default to false).</param>
        /// <param name="ShipDate">ShipDate.</param>
        /// <param name="AutoShipCasebreakCartons">AutoShipCasebreakCartons (default to false).</param>
        /// <param name="CartonizeOrders">CartonizeOrders (default to false).</param>
        /// <param name="CreatePackingSlip">CreatePackingSlip (default to false).</param>
        /// <param name="OverridePackingSlipTemplateId">OverridePackingSlipTemplateId.</param>
        /// <param name="CreateOrderAssemblyGuide">CreateOrderAssemblyGuide (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public FulfillmentProcess(int? WarehouseId = null, int? FulfillmentPlanId = null, int? PickScanSchemeId = null, string Status = null, int? OrderSmartFilterId = null, int? LocationSmartFilterId = null, int? CompletedPicks = null, int? TotalPicks = null, int? ShippedCasebreaks = null, int? TotalCasebreaksToShip = null, int? ShippedOrders = null, int? TotalOrdersToShip = null, int? CompletedToDo = null, int? TotalToDo = null, bool? CreatePickWork = null, string PickingRule = null, string LayoutRule = null, string PickSortRule = null, int? FirstPickPosition = null, string PickListFormat = null, string PickListLayout = null, string PickListGroup = null, string PickListSort = null, string PickSummaryFormat = null, string PickSummaryLayout = null, string PickSummarySort = null, bool? CreatePickSummary = null, bool? CreatePickList = null, bool? PreGenerateParcelLabels = null, DateTime? ShipDate = null, bool? AutoShipCasebreakCartons = null, bool? CartonizeOrders = null, bool? CreatePackingSlip = null, int? OverridePackingSlipTemplateId = null, bool? CreateOrderAssemblyGuide = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for FulfillmentProcess and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "FulfillmentPlanId" is required (not null)
            if (FulfillmentPlanId == null)
            {
                throw new InvalidDataException("FulfillmentPlanId is a required property for FulfillmentProcess and cannot be null");
            }
            else
            {
                this.FulfillmentPlanId = FulfillmentPlanId;
            }
            // to ensure "PickScanSchemeId" is required (not null)
            if (PickScanSchemeId == null)
            {
                throw new InvalidDataException("PickScanSchemeId is a required property for FulfillmentProcess and cannot be null");
            }
            else
            {
                this.PickScanSchemeId = PickScanSchemeId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for FulfillmentProcess and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.OrderSmartFilterId = OrderSmartFilterId;
            this.LocationSmartFilterId = LocationSmartFilterId;
            this.CompletedPicks = CompletedPicks;
            this.TotalPicks = TotalPicks;
            this.ShippedCasebreaks = ShippedCasebreaks;
            this.TotalCasebreaksToShip = TotalCasebreaksToShip;
            this.ShippedOrders = ShippedOrders;
            this.TotalOrdersToShip = TotalOrdersToShip;
            this.CompletedToDo = CompletedToDo;
            this.TotalToDo = TotalToDo;
            // use default value if no "CreatePickWork" provided
            if (CreatePickWork == null)
            {
                this.CreatePickWork = false;
            }
            else
            {
                this.CreatePickWork = CreatePickWork;
            }
            this.PickingRule = PickingRule;
            this.LayoutRule = LayoutRule;
            this.PickSortRule = PickSortRule;
            this.FirstPickPosition = FirstPickPosition;
            this.PickListFormat = PickListFormat;
            this.PickListLayout = PickListLayout;
            this.PickListGroup = PickListGroup;
            this.PickListSort = PickListSort;
            this.PickSummaryFormat = PickSummaryFormat;
            this.PickSummaryLayout = PickSummaryLayout;
            this.PickSummarySort = PickSummarySort;
            // use default value if no "CreatePickSummary" provided
            if (CreatePickSummary == null)
            {
                this.CreatePickSummary = false;
            }
            else
            {
                this.CreatePickSummary = CreatePickSummary;
            }
            // use default value if no "CreatePickList" provided
            if (CreatePickList == null)
            {
                this.CreatePickList = false;
            }
            else
            {
                this.CreatePickList = CreatePickList;
            }
            // use default value if no "PreGenerateParcelLabels" provided
            if (PreGenerateParcelLabels == null)
            {
                this.PreGenerateParcelLabels = false;
            }
            else
            {
                this.PreGenerateParcelLabels = PreGenerateParcelLabels;
            }
            this.ShipDate = ShipDate;
            // use default value if no "AutoShipCasebreakCartons" provided
            if (AutoShipCasebreakCartons == null)
            {
                this.AutoShipCasebreakCartons = false;
            }
            else
            {
                this.AutoShipCasebreakCartons = AutoShipCasebreakCartons;
            }
            // use default value if no "CartonizeOrders" provided
            if (CartonizeOrders == null)
            {
                this.CartonizeOrders = false;
            }
            else
            {
                this.CartonizeOrders = CartonizeOrders;
            }
            // use default value if no "CreatePackingSlip" provided
            if (CreatePackingSlip == null)
            {
                this.CreatePackingSlip = false;
            }
            else
            {
                this.CreatePackingSlip = CreatePackingSlip;
            }
            this.OverridePackingSlipTemplateId = OverridePackingSlipTemplateId;
            // use default value if no "CreateOrderAssemblyGuide" provided
            if (CreateOrderAssemblyGuide == null)
            {
                this.CreateOrderAssemblyGuide = false;
            }
            else
            {
                this.CreateOrderAssemblyGuide = CreateOrderAssemblyGuide;
            }
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
        /// Gets or Sets ProcessNo
        /// </summary>
        [DataMember(Name="processNo", EmitDefaultValue=false)]
        public int? ProcessNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets FulfillmentPlanId
        /// </summary>
        [DataMember(Name="fulfillmentPlanId", EmitDefaultValue=false)]
        public int? FulfillmentPlanId { get; set; }
    
        /// <summary>
        /// Gets or Sets PickScanSchemeId
        /// </summary>
        [DataMember(Name="pickScanSchemeId", EmitDefaultValue=false)]
        public int? PickScanSchemeId { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderSmartFilterId
        /// </summary>
        [DataMember(Name="orderSmartFilterId", EmitDefaultValue=false)]
        public int? OrderSmartFilterId { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationSmartFilterId
        /// </summary>
        [DataMember(Name="locationSmartFilterId", EmitDefaultValue=false)]
        public int? LocationSmartFilterId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderLimit
        /// </summary>
        [DataMember(Name="orderLimit", EmitDefaultValue=false)]
        public int? OrderLimit { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfOrders
        /// </summary>
        [DataMember(Name="numberOfOrders", EmitDefaultValue=false)]
        public int? NumberOfOrders { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfLines
        /// </summary>
        [DataMember(Name="numberOfLines", EmitDefaultValue=false)]
        public int? NumberOfLines { get; private set; }
    
        /// <summary>
        /// Gets or Sets NumberOfSKUs
        /// </summary>
        [DataMember(Name="numberOfSKUs", EmitDefaultValue=false)]
        public int? NumberOfSKUs { get; private set; }
    
        /// <summary>
        /// Gets or Sets CompletedPicks
        /// </summary>
        [DataMember(Name="completedPicks", EmitDefaultValue=false)]
        public int? CompletedPicks { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalPicks
        /// </summary>
        [DataMember(Name="totalPicks", EmitDefaultValue=false)]
        public int? TotalPicks { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippedCasebreaks
        /// </summary>
        [DataMember(Name="shippedCasebreaks", EmitDefaultValue=false)]
        public int? ShippedCasebreaks { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalCasebreaksToShip
        /// </summary>
        [DataMember(Name="totalCasebreaksToShip", EmitDefaultValue=false)]
        public int? TotalCasebreaksToShip { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippedOrders
        /// </summary>
        [DataMember(Name="shippedOrders", EmitDefaultValue=false)]
        public int? ShippedOrders { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalOrdersToShip
        /// </summary>
        [DataMember(Name="totalOrdersToShip", EmitDefaultValue=false)]
        public int? TotalOrdersToShip { get; set; }
    
        /// <summary>
        /// Gets or Sets CompletedToDo
        /// </summary>
        [DataMember(Name="completedToDo", EmitDefaultValue=false)]
        public int? CompletedToDo { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalToDo
        /// </summary>
        [DataMember(Name="totalToDo", EmitDefaultValue=false)]
        public int? TotalToDo { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatePickWork
        /// </summary>
        [DataMember(Name="createPickWork", EmitDefaultValue=false)]
        public bool? CreatePickWork { get; set; }
    
        /// <summary>
        /// Gets or Sets PickingRule
        /// </summary>
        [DataMember(Name="pickingRule", EmitDefaultValue=false)]
        public string PickingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets LayoutRule
        /// </summary>
        [DataMember(Name="layoutRule", EmitDefaultValue=false)]
        public string LayoutRule { get; set; }
    
        /// <summary>
        /// Gets or Sets PickSortRule
        /// </summary>
        [DataMember(Name="pickSortRule", EmitDefaultValue=false)]
        public string PickSortRule { get; set; }
    
        /// <summary>
        /// Gets or Sets FirstPickPosition
        /// </summary>
        [DataMember(Name="firstPickPosition", EmitDefaultValue=false)]
        public int? FirstPickPosition { get; set; }
    
        /// <summary>
        /// Gets or Sets PickListFormat
        /// </summary>
        [DataMember(Name="pickListFormat", EmitDefaultValue=false)]
        public string PickListFormat { get; set; }
    
        /// <summary>
        /// Gets or Sets PickListLayout
        /// </summary>
        [DataMember(Name="pickListLayout", EmitDefaultValue=false)]
        public string PickListLayout { get; set; }
    
        /// <summary>
        /// Gets or Sets PickListGroup
        /// </summary>
        [DataMember(Name="pickListGroup", EmitDefaultValue=false)]
        public string PickListGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets PickListSort
        /// </summary>
        [DataMember(Name="pickListSort", EmitDefaultValue=false)]
        public string PickListSort { get; set; }
    
        /// <summary>
        /// Gets or Sets PickSummaryFormat
        /// </summary>
        [DataMember(Name="pickSummaryFormat", EmitDefaultValue=false)]
        public string PickSummaryFormat { get; set; }
    
        /// <summary>
        /// Gets or Sets PickSummaryLayout
        /// </summary>
        [DataMember(Name="pickSummaryLayout", EmitDefaultValue=false)]
        public string PickSummaryLayout { get; set; }
    
        /// <summary>
        /// Gets or Sets PickSummarySort
        /// </summary>
        [DataMember(Name="pickSummarySort", EmitDefaultValue=false)]
        public string PickSummarySort { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatePickSummary
        /// </summary>
        [DataMember(Name="createPickSummary", EmitDefaultValue=false)]
        public bool? CreatePickSummary { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatePickList
        /// </summary>
        [DataMember(Name="createPickList", EmitDefaultValue=false)]
        public bool? CreatePickList { get; set; }
    
        /// <summary>
        /// Gets or Sets PreGenerateParcelLabels
        /// </summary>
        [DataMember(Name="preGenerateParcelLabels", EmitDefaultValue=false)]
        public bool? PreGenerateParcelLabels { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; set; }
    
        /// <summary>
        /// Gets or Sets AutoShipCasebreakCartons
        /// </summary>
        [DataMember(Name="autoShipCasebreakCartons", EmitDefaultValue=false)]
        public bool? AutoShipCasebreakCartons { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonizeOrders
        /// </summary>
        [DataMember(Name="cartonizeOrders", EmitDefaultValue=false)]
        public bool? CartonizeOrders { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatePackingSlip
        /// </summary>
        [DataMember(Name="createPackingSlip", EmitDefaultValue=false)]
        public bool? CreatePackingSlip { get; set; }
    
        /// <summary>
        /// Gets or Sets OverridePackingSlipTemplateId
        /// </summary>
        [DataMember(Name="overridePackingSlipTemplateId", EmitDefaultValue=false)]
        public int? OverridePackingSlipTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateOrderAssemblyGuide
        /// </summary>
        [DataMember(Name="createOrderAssemblyGuide", EmitDefaultValue=false)]
        public bool? CreateOrderAssemblyGuide { get; set; }
    
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
            sb.Append("class FulfillmentProcess {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ProcessNo: ").Append(ProcessNo).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  FulfillmentPlanId: ").Append(FulfillmentPlanId).Append("\n");
            sb.Append("  PickScanSchemeId: ").Append(PickScanSchemeId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OrderSmartFilterId: ").Append(OrderSmartFilterId).Append("\n");
            sb.Append("  LocationSmartFilterId: ").Append(LocationSmartFilterId).Append("\n");
            sb.Append("  OrderLimit: ").Append(OrderLimit).Append("\n");
            sb.Append("  NumberOfOrders: ").Append(NumberOfOrders).Append("\n");
            sb.Append("  NumberOfLines: ").Append(NumberOfLines).Append("\n");
            sb.Append("  NumberOfSKUs: ").Append(NumberOfSKUs).Append("\n");
            sb.Append("  CompletedPicks: ").Append(CompletedPicks).Append("\n");
            sb.Append("  TotalPicks: ").Append(TotalPicks).Append("\n");
            sb.Append("  ShippedCasebreaks: ").Append(ShippedCasebreaks).Append("\n");
            sb.Append("  TotalCasebreaksToShip: ").Append(TotalCasebreaksToShip).Append("\n");
            sb.Append("  ShippedOrders: ").Append(ShippedOrders).Append("\n");
            sb.Append("  TotalOrdersToShip: ").Append(TotalOrdersToShip).Append("\n");
            sb.Append("  CompletedToDo: ").Append(CompletedToDo).Append("\n");
            sb.Append("  TotalToDo: ").Append(TotalToDo).Append("\n");
            sb.Append("  CreatePickWork: ").Append(CreatePickWork).Append("\n");
            sb.Append("  PickingRule: ").Append(PickingRule).Append("\n");
            sb.Append("  LayoutRule: ").Append(LayoutRule).Append("\n");
            sb.Append("  PickSortRule: ").Append(PickSortRule).Append("\n");
            sb.Append("  FirstPickPosition: ").Append(FirstPickPosition).Append("\n");
            sb.Append("  PickListFormat: ").Append(PickListFormat).Append("\n");
            sb.Append("  PickListLayout: ").Append(PickListLayout).Append("\n");
            sb.Append("  PickListGroup: ").Append(PickListGroup).Append("\n");
            sb.Append("  PickListSort: ").Append(PickListSort).Append("\n");
            sb.Append("  PickSummaryFormat: ").Append(PickSummaryFormat).Append("\n");
            sb.Append("  PickSummaryLayout: ").Append(PickSummaryLayout).Append("\n");
            sb.Append("  PickSummarySort: ").Append(PickSummarySort).Append("\n");
            sb.Append("  CreatePickSummary: ").Append(CreatePickSummary).Append("\n");
            sb.Append("  CreatePickList: ").Append(CreatePickList).Append("\n");
            sb.Append("  PreGenerateParcelLabels: ").Append(PreGenerateParcelLabels).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  AutoShipCasebreakCartons: ").Append(AutoShipCasebreakCartons).Append("\n");
            sb.Append("  CartonizeOrders: ").Append(CartonizeOrders).Append("\n");
            sb.Append("  CreatePackingSlip: ").Append(CreatePackingSlip).Append("\n");
            sb.Append("  OverridePackingSlipTemplateId: ").Append(OverridePackingSlipTemplateId).Append("\n");
            sb.Append("  CreateOrderAssemblyGuide: ").Append(CreateOrderAssemblyGuide).Append("\n");
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
            return this.Equals(obj as FulfillmentProcess);
        }

        /// <summary>
        /// Returns true if FulfillmentProcess instances are equal
        /// </summary>
        /// <param name="other">Instance of FulfillmentProcess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentProcess other)
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
                    this.ProcessNo == other.ProcessNo ||
                    this.ProcessNo != null &&
                    this.ProcessNo.Equals(other.ProcessNo)
                ) && 
                (
                    this.WorkBatchId == other.WorkBatchId ||
                    this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(other.WorkBatchId)
                ) && 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.FulfillmentPlanId == other.FulfillmentPlanId ||
                    this.FulfillmentPlanId != null &&
                    this.FulfillmentPlanId.Equals(other.FulfillmentPlanId)
                ) && 
                (
                    this.PickScanSchemeId == other.PickScanSchemeId ||
                    this.PickScanSchemeId != null &&
                    this.PickScanSchemeId.Equals(other.PickScanSchemeId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.OrderSmartFilterId == other.OrderSmartFilterId ||
                    this.OrderSmartFilterId != null &&
                    this.OrderSmartFilterId.Equals(other.OrderSmartFilterId)
                ) && 
                (
                    this.LocationSmartFilterId == other.LocationSmartFilterId ||
                    this.LocationSmartFilterId != null &&
                    this.LocationSmartFilterId.Equals(other.LocationSmartFilterId)
                ) && 
                (
                    this.OrderLimit == other.OrderLimit ||
                    this.OrderLimit != null &&
                    this.OrderLimit.Equals(other.OrderLimit)
                ) && 
                (
                    this.NumberOfOrders == other.NumberOfOrders ||
                    this.NumberOfOrders != null &&
                    this.NumberOfOrders.Equals(other.NumberOfOrders)
                ) && 
                (
                    this.NumberOfLines == other.NumberOfLines ||
                    this.NumberOfLines != null &&
                    this.NumberOfLines.Equals(other.NumberOfLines)
                ) && 
                (
                    this.NumberOfSKUs == other.NumberOfSKUs ||
                    this.NumberOfSKUs != null &&
                    this.NumberOfSKUs.Equals(other.NumberOfSKUs)
                ) && 
                (
                    this.CompletedPicks == other.CompletedPicks ||
                    this.CompletedPicks != null &&
                    this.CompletedPicks.Equals(other.CompletedPicks)
                ) && 
                (
                    this.TotalPicks == other.TotalPicks ||
                    this.TotalPicks != null &&
                    this.TotalPicks.Equals(other.TotalPicks)
                ) && 
                (
                    this.ShippedCasebreaks == other.ShippedCasebreaks ||
                    this.ShippedCasebreaks != null &&
                    this.ShippedCasebreaks.Equals(other.ShippedCasebreaks)
                ) && 
                (
                    this.TotalCasebreaksToShip == other.TotalCasebreaksToShip ||
                    this.TotalCasebreaksToShip != null &&
                    this.TotalCasebreaksToShip.Equals(other.TotalCasebreaksToShip)
                ) && 
                (
                    this.ShippedOrders == other.ShippedOrders ||
                    this.ShippedOrders != null &&
                    this.ShippedOrders.Equals(other.ShippedOrders)
                ) && 
                (
                    this.TotalOrdersToShip == other.TotalOrdersToShip ||
                    this.TotalOrdersToShip != null &&
                    this.TotalOrdersToShip.Equals(other.TotalOrdersToShip)
                ) && 
                (
                    this.CompletedToDo == other.CompletedToDo ||
                    this.CompletedToDo != null &&
                    this.CompletedToDo.Equals(other.CompletedToDo)
                ) && 
                (
                    this.TotalToDo == other.TotalToDo ||
                    this.TotalToDo != null &&
                    this.TotalToDo.Equals(other.TotalToDo)
                ) && 
                (
                    this.CreatePickWork == other.CreatePickWork ||
                    this.CreatePickWork != null &&
                    this.CreatePickWork.Equals(other.CreatePickWork)
                ) && 
                (
                    this.PickingRule == other.PickingRule ||
                    this.PickingRule != null &&
                    this.PickingRule.Equals(other.PickingRule)
                ) && 
                (
                    this.LayoutRule == other.LayoutRule ||
                    this.LayoutRule != null &&
                    this.LayoutRule.Equals(other.LayoutRule)
                ) && 
                (
                    this.PickSortRule == other.PickSortRule ||
                    this.PickSortRule != null &&
                    this.PickSortRule.Equals(other.PickSortRule)
                ) && 
                (
                    this.FirstPickPosition == other.FirstPickPosition ||
                    this.FirstPickPosition != null &&
                    this.FirstPickPosition.Equals(other.FirstPickPosition)
                ) && 
                (
                    this.PickListFormat == other.PickListFormat ||
                    this.PickListFormat != null &&
                    this.PickListFormat.Equals(other.PickListFormat)
                ) && 
                (
                    this.PickListLayout == other.PickListLayout ||
                    this.PickListLayout != null &&
                    this.PickListLayout.Equals(other.PickListLayout)
                ) && 
                (
                    this.PickListGroup == other.PickListGroup ||
                    this.PickListGroup != null &&
                    this.PickListGroup.Equals(other.PickListGroup)
                ) && 
                (
                    this.PickListSort == other.PickListSort ||
                    this.PickListSort != null &&
                    this.PickListSort.Equals(other.PickListSort)
                ) && 
                (
                    this.PickSummaryFormat == other.PickSummaryFormat ||
                    this.PickSummaryFormat != null &&
                    this.PickSummaryFormat.Equals(other.PickSummaryFormat)
                ) && 
                (
                    this.PickSummaryLayout == other.PickSummaryLayout ||
                    this.PickSummaryLayout != null &&
                    this.PickSummaryLayout.Equals(other.PickSummaryLayout)
                ) && 
                (
                    this.PickSummarySort == other.PickSummarySort ||
                    this.PickSummarySort != null &&
                    this.PickSummarySort.Equals(other.PickSummarySort)
                ) && 
                (
                    this.CreatePickSummary == other.CreatePickSummary ||
                    this.CreatePickSummary != null &&
                    this.CreatePickSummary.Equals(other.CreatePickSummary)
                ) && 
                (
                    this.CreatePickList == other.CreatePickList ||
                    this.CreatePickList != null &&
                    this.CreatePickList.Equals(other.CreatePickList)
                ) && 
                (
                    this.PreGenerateParcelLabels == other.PreGenerateParcelLabels ||
                    this.PreGenerateParcelLabels != null &&
                    this.PreGenerateParcelLabels.Equals(other.PreGenerateParcelLabels)
                ) && 
                (
                    this.ShipDate == other.ShipDate ||
                    this.ShipDate != null &&
                    this.ShipDate.Equals(other.ShipDate)
                ) && 
                (
                    this.AutoShipCasebreakCartons == other.AutoShipCasebreakCartons ||
                    this.AutoShipCasebreakCartons != null &&
                    this.AutoShipCasebreakCartons.Equals(other.AutoShipCasebreakCartons)
                ) && 
                (
                    this.CartonizeOrders == other.CartonizeOrders ||
                    this.CartonizeOrders != null &&
                    this.CartonizeOrders.Equals(other.CartonizeOrders)
                ) && 
                (
                    this.CreatePackingSlip == other.CreatePackingSlip ||
                    this.CreatePackingSlip != null &&
                    this.CreatePackingSlip.Equals(other.CreatePackingSlip)
                ) && 
                (
                    this.OverridePackingSlipTemplateId == other.OverridePackingSlipTemplateId ||
                    this.OverridePackingSlipTemplateId != null &&
                    this.OverridePackingSlipTemplateId.Equals(other.OverridePackingSlipTemplateId)
                ) && 
                (
                    this.CreateOrderAssemblyGuide == other.CreateOrderAssemblyGuide ||
                    this.CreateOrderAssemblyGuide != null &&
                    this.CreateOrderAssemblyGuide.Equals(other.CreateOrderAssemblyGuide)
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
                
                if (this.ProcessNo != null)
                    hash = hash * 59 + this.ProcessNo.GetHashCode();
                
                if (this.WorkBatchId != null)
                    hash = hash * 59 + this.WorkBatchId.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.FulfillmentPlanId != null)
                    hash = hash * 59 + this.FulfillmentPlanId.GetHashCode();
                
                if (this.PickScanSchemeId != null)
                    hash = hash * 59 + this.PickScanSchemeId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.OrderSmartFilterId != null)
                    hash = hash * 59 + this.OrderSmartFilterId.GetHashCode();
                
                if (this.LocationSmartFilterId != null)
                    hash = hash * 59 + this.LocationSmartFilterId.GetHashCode();
                
                if (this.OrderLimit != null)
                    hash = hash * 59 + this.OrderLimit.GetHashCode();
                
                if (this.NumberOfOrders != null)
                    hash = hash * 59 + this.NumberOfOrders.GetHashCode();
                
                if (this.NumberOfLines != null)
                    hash = hash * 59 + this.NumberOfLines.GetHashCode();
                
                if (this.NumberOfSKUs != null)
                    hash = hash * 59 + this.NumberOfSKUs.GetHashCode();
                
                if (this.CompletedPicks != null)
                    hash = hash * 59 + this.CompletedPicks.GetHashCode();
                
                if (this.TotalPicks != null)
                    hash = hash * 59 + this.TotalPicks.GetHashCode();
                
                if (this.ShippedCasebreaks != null)
                    hash = hash * 59 + this.ShippedCasebreaks.GetHashCode();
                
                if (this.TotalCasebreaksToShip != null)
                    hash = hash * 59 + this.TotalCasebreaksToShip.GetHashCode();
                
                if (this.ShippedOrders != null)
                    hash = hash * 59 + this.ShippedOrders.GetHashCode();
                
                if (this.TotalOrdersToShip != null)
                    hash = hash * 59 + this.TotalOrdersToShip.GetHashCode();
                
                if (this.CompletedToDo != null)
                    hash = hash * 59 + this.CompletedToDo.GetHashCode();
                
                if (this.TotalToDo != null)
                    hash = hash * 59 + this.TotalToDo.GetHashCode();
                
                if (this.CreatePickWork != null)
                    hash = hash * 59 + this.CreatePickWork.GetHashCode();
                
                if (this.PickingRule != null)
                    hash = hash * 59 + this.PickingRule.GetHashCode();
                
                if (this.LayoutRule != null)
                    hash = hash * 59 + this.LayoutRule.GetHashCode();
                
                if (this.PickSortRule != null)
                    hash = hash * 59 + this.PickSortRule.GetHashCode();
                
                if (this.FirstPickPosition != null)
                    hash = hash * 59 + this.FirstPickPosition.GetHashCode();
                
                if (this.PickListFormat != null)
                    hash = hash * 59 + this.PickListFormat.GetHashCode();
                
                if (this.PickListLayout != null)
                    hash = hash * 59 + this.PickListLayout.GetHashCode();
                
                if (this.PickListGroup != null)
                    hash = hash * 59 + this.PickListGroup.GetHashCode();
                
                if (this.PickListSort != null)
                    hash = hash * 59 + this.PickListSort.GetHashCode();
                
                if (this.PickSummaryFormat != null)
                    hash = hash * 59 + this.PickSummaryFormat.GetHashCode();
                
                if (this.PickSummaryLayout != null)
                    hash = hash * 59 + this.PickSummaryLayout.GetHashCode();
                
                if (this.PickSummarySort != null)
                    hash = hash * 59 + this.PickSummarySort.GetHashCode();
                
                if (this.CreatePickSummary != null)
                    hash = hash * 59 + this.CreatePickSummary.GetHashCode();
                
                if (this.CreatePickList != null)
                    hash = hash * 59 + this.CreatePickList.GetHashCode();
                
                if (this.PreGenerateParcelLabels != null)
                    hash = hash * 59 + this.PreGenerateParcelLabels.GetHashCode();
                
                if (this.ShipDate != null)
                    hash = hash * 59 + this.ShipDate.GetHashCode();
                
                if (this.AutoShipCasebreakCartons != null)
                    hash = hash * 59 + this.AutoShipCasebreakCartons.GetHashCode();
                
                if (this.CartonizeOrders != null)
                    hash = hash * 59 + this.CartonizeOrders.GetHashCode();
                
                if (this.CreatePackingSlip != null)
                    hash = hash * 59 + this.CreatePackingSlip.GetHashCode();
                
                if (this.OverridePackingSlipTemplateId != null)
                    hash = hash * 59 + this.OverridePackingSlipTemplateId.GetHashCode();
                
                if (this.CreateOrderAssemblyGuide != null)
                    hash = hash * 59 + this.CreateOrderAssemblyGuide.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
