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
    public partial class FulfillmentPlan :  IEquatable<FulfillmentPlan>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPlan" /> class.
        /// Initializes a new instance of the <see cref="FulfillmentPlan" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="OrderSmartFilterId">OrderSmartFilterId (required).</param>
        /// <param name="LocationSmartFilterId">LocationSmartFilterId.</param>
        /// <param name="MaxOrders">MaxOrders.</param>
        /// <param name="BatchSize">BatchSize.</param>
        /// <param name="Version">Version.</param>
        /// <param name="CreatePickWork">CreatePickWork (required) (default to false).</param>
        /// <param name="PickingRule">PickingRule.</param>
        /// <param name="LayoutRule">LayoutRule.</param>
        /// <param name="PickSortRule">PickSortRule.</param>
        /// <param name="CreatePickList">CreatePickList (default to false).</param>
        /// <param name="PickListFormat">PickListFormat.</param>
        /// <param name="PickListLayout">PickListLayout.</param>
        /// <param name="PickListGroup">PickListGroup.</param>
        /// <param name="PickListSort">PickListSort.</param>
        /// <param name="CreatePickSummary">CreatePickSummary (default to false).</param>
        /// <param name="PickSummaryFormat">PickSummaryFormat.</param>
        /// <param name="PickSummaryLayout">PickSummaryLayout.</param>
        /// <param name="PickSummarySort">PickSummarySort.</param>
        /// <param name="PickScanSchemeId">PickScanSchemeId (required).</param>
        /// <param name="CartonizeOrders">CartonizeOrders (required) (default to false).</param>
        /// <param name="AutoShipCasebreakCartons">AutoShipCasebreakCartons (default to false).</param>
        /// <param name="PreGenerateParcelLabels">PreGenerateParcelLabels (default to false).</param>
        /// <param name="CreatePackingSlip">CreatePackingSlip (required).</param>
        /// <param name="OverridePackingSlipTemplateId">OverridePackingSlipTemplateId.</param>
        /// <param name="CreateOrderAssemblyGuide">CreateOrderAssemblyGuide (default to false).</param>
        /// <param name="CreateOrderInvoice">CreateOrderInvoice (required).</param>
        /// <param name="OverrideOrderInvoiceTemplateId">OverrideOrderInvoiceTemplateId.</param>
        /// <param name="SendToExternalShippingSystem">SendToExternalShippingSystem (required) (default to false).</param>
        /// <param name="ExternalShippingSystemId">ExternalShippingSystemId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public FulfillmentPlan(string Name = null, string Description = null, int? WarehouseId = null, int? OrderSmartFilterId = null, int? LocationSmartFilterId = null, int? MaxOrders = null, int? BatchSize = null, string Version = null, bool? CreatePickWork = null, string PickingRule = null, string LayoutRule = null, string PickSortRule = null, bool? CreatePickList = null, string PickListFormat = null, string PickListLayout = null, string PickListGroup = null, string PickListSort = null, bool? CreatePickSummary = null, string PickSummaryFormat = null, string PickSummaryLayout = null, string PickSummarySort = null, int? PickScanSchemeId = null, bool? CartonizeOrders = null, bool? AutoShipCasebreakCartons = null, bool? PreGenerateParcelLabels = null, string CreatePackingSlip = null, int? OverridePackingSlipTemplateId = null, bool? CreateOrderAssemblyGuide = null, string CreateOrderInvoice = null, int? OverrideOrderInvoiceTemplateId = null, bool? SendToExternalShippingSystem = null, int? ExternalShippingSystemId = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "OrderSmartFilterId" is required (not null)
            if (OrderSmartFilterId == null)
            {
                throw new InvalidDataException("OrderSmartFilterId is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.OrderSmartFilterId = OrderSmartFilterId;
            }
            // to ensure "CreatePickWork" is required (not null)
            if (CreatePickWork == null)
            {
                throw new InvalidDataException("CreatePickWork is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.CreatePickWork = CreatePickWork;
            }
            // to ensure "PickScanSchemeId" is required (not null)
            if (PickScanSchemeId == null)
            {
                throw new InvalidDataException("PickScanSchemeId is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.PickScanSchemeId = PickScanSchemeId;
            }
            // to ensure "CartonizeOrders" is required (not null)
            if (CartonizeOrders == null)
            {
                throw new InvalidDataException("CartonizeOrders is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.CartonizeOrders = CartonizeOrders;
            }
            // to ensure "CreatePackingSlip" is required (not null)
            if (CreatePackingSlip == null)
            {
                throw new InvalidDataException("CreatePackingSlip is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.CreatePackingSlip = CreatePackingSlip;
            }
            // to ensure "CreateOrderInvoice" is required (not null)
            if (CreateOrderInvoice == null)
            {
                throw new InvalidDataException("CreateOrderInvoice is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.CreateOrderInvoice = CreateOrderInvoice;
            }
            // to ensure "SendToExternalShippingSystem" is required (not null)
            if (SendToExternalShippingSystem == null)
            {
                throw new InvalidDataException("SendToExternalShippingSystem is a required property for FulfillmentPlan and cannot be null");
            }
            else
            {
                this.SendToExternalShippingSystem = SendToExternalShippingSystem;
            }
            this.Description = Description;
            this.LocationSmartFilterId = LocationSmartFilterId;
            this.MaxOrders = MaxOrders;
            this.BatchSize = BatchSize;
            this.Version = Version;
            this.PickingRule = PickingRule;
            this.LayoutRule = LayoutRule;
            this.PickSortRule = PickSortRule;
            // use default value if no "CreatePickList" provided
            if (CreatePickList == null)
            {
                this.CreatePickList = false;
            }
            else
            {
                this.CreatePickList = CreatePickList;
            }
            this.PickListFormat = PickListFormat;
            this.PickListLayout = PickListLayout;
            this.PickListGroup = PickListGroup;
            this.PickListSort = PickListSort;
            // use default value if no "CreatePickSummary" provided
            if (CreatePickSummary == null)
            {
                this.CreatePickSummary = false;
            }
            else
            {
                this.CreatePickSummary = CreatePickSummary;
            }
            this.PickSummaryFormat = PickSummaryFormat;
            this.PickSummaryLayout = PickSummaryLayout;
            this.PickSummarySort = PickSummarySort;
            // use default value if no "AutoShipCasebreakCartons" provided
            if (AutoShipCasebreakCartons == null)
            {
                this.AutoShipCasebreakCartons = false;
            }
            else
            {
                this.AutoShipCasebreakCartons = AutoShipCasebreakCartons;
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
            this.OverrideOrderInvoiceTemplateId = OverrideOrderInvoiceTemplateId;
            this.ExternalShippingSystemId = ExternalShippingSystemId;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets LastRunTime
        /// </summary>
        [DataMember(Name="lastRunTime", EmitDefaultValue=false)]
        public DateTime? LastRunTime { get; private set; }
    
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
        /// Gets or Sets MaxOrders
        /// </summary>
        [DataMember(Name="maxOrders", EmitDefaultValue=false)]
        public int? MaxOrders { get; set; }
    
        /// <summary>
        /// Gets or Sets BatchSize
        /// </summary>
        [DataMember(Name="batchSize", EmitDefaultValue=false)]
        public int? BatchSize { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
    
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
        /// Gets or Sets CreatePickList
        /// </summary>
        [DataMember(Name="createPickList", EmitDefaultValue=false)]
        public bool? CreatePickList { get; set; }
    
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
        /// Gets or Sets CreatePickSummary
        /// </summary>
        [DataMember(Name="createPickSummary", EmitDefaultValue=false)]
        public bool? CreatePickSummary { get; set; }
    
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
        /// Gets or Sets PickScanSchemeId
        /// </summary>
        [DataMember(Name="pickScanSchemeId", EmitDefaultValue=false)]
        public int? PickScanSchemeId { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonizeOrders
        /// </summary>
        [DataMember(Name="cartonizeOrders", EmitDefaultValue=false)]
        public bool? CartonizeOrders { get; set; }
    
        /// <summary>
        /// Gets or Sets AutoShipCasebreakCartons
        /// </summary>
        [DataMember(Name="autoShipCasebreakCartons", EmitDefaultValue=false)]
        public bool? AutoShipCasebreakCartons { get; set; }
    
        /// <summary>
        /// Gets or Sets PreGenerateParcelLabels
        /// </summary>
        [DataMember(Name="preGenerateParcelLabels", EmitDefaultValue=false)]
        public bool? PreGenerateParcelLabels { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatePackingSlip
        /// </summary>
        [DataMember(Name="createPackingSlip", EmitDefaultValue=false)]
        public string CreatePackingSlip { get; set; }
    
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
        /// Gets or Sets CreateOrderInvoice
        /// </summary>
        [DataMember(Name="createOrderInvoice", EmitDefaultValue=false)]
        public string CreateOrderInvoice { get; set; }
    
        /// <summary>
        /// Gets or Sets OverrideOrderInvoiceTemplateId
        /// </summary>
        [DataMember(Name="overrideOrderInvoiceTemplateId", EmitDefaultValue=false)]
        public int? OverrideOrderInvoiceTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets SendToExternalShippingSystem
        /// </summary>
        [DataMember(Name="sendToExternalShippingSystem", EmitDefaultValue=false)]
        public bool? SendToExternalShippingSystem { get; set; }
    
        /// <summary>
        /// Gets or Sets ExternalShippingSystemId
        /// </summary>
        [DataMember(Name="externalShippingSystemId", EmitDefaultValue=false)]
        public int? ExternalShippingSystemId { get; set; }
    
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
            sb.Append("class FulfillmentPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LastRunTime: ").Append(LastRunTime).Append("\n");
            sb.Append("  OrderSmartFilterId: ").Append(OrderSmartFilterId).Append("\n");
            sb.Append("  LocationSmartFilterId: ").Append(LocationSmartFilterId).Append("\n");
            sb.Append("  MaxOrders: ").Append(MaxOrders).Append("\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatePickWork: ").Append(CreatePickWork).Append("\n");
            sb.Append("  PickingRule: ").Append(PickingRule).Append("\n");
            sb.Append("  LayoutRule: ").Append(LayoutRule).Append("\n");
            sb.Append("  PickSortRule: ").Append(PickSortRule).Append("\n");
            sb.Append("  CreatePickList: ").Append(CreatePickList).Append("\n");
            sb.Append("  PickListFormat: ").Append(PickListFormat).Append("\n");
            sb.Append("  PickListLayout: ").Append(PickListLayout).Append("\n");
            sb.Append("  PickListGroup: ").Append(PickListGroup).Append("\n");
            sb.Append("  PickListSort: ").Append(PickListSort).Append("\n");
            sb.Append("  CreatePickSummary: ").Append(CreatePickSummary).Append("\n");
            sb.Append("  PickSummaryFormat: ").Append(PickSummaryFormat).Append("\n");
            sb.Append("  PickSummaryLayout: ").Append(PickSummaryLayout).Append("\n");
            sb.Append("  PickSummarySort: ").Append(PickSummarySort).Append("\n");
            sb.Append("  PickScanSchemeId: ").Append(PickScanSchemeId).Append("\n");
            sb.Append("  CartonizeOrders: ").Append(CartonizeOrders).Append("\n");
            sb.Append("  AutoShipCasebreakCartons: ").Append(AutoShipCasebreakCartons).Append("\n");
            sb.Append("  PreGenerateParcelLabels: ").Append(PreGenerateParcelLabels).Append("\n");
            sb.Append("  CreatePackingSlip: ").Append(CreatePackingSlip).Append("\n");
            sb.Append("  OverridePackingSlipTemplateId: ").Append(OverridePackingSlipTemplateId).Append("\n");
            sb.Append("  CreateOrderAssemblyGuide: ").Append(CreateOrderAssemblyGuide).Append("\n");
            sb.Append("  CreateOrderInvoice: ").Append(CreateOrderInvoice).Append("\n");
            sb.Append("  OverrideOrderInvoiceTemplateId: ").Append(OverrideOrderInvoiceTemplateId).Append("\n");
            sb.Append("  SendToExternalShippingSystem: ").Append(SendToExternalShippingSystem).Append("\n");
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
            return this.Equals(obj as FulfillmentPlan);
        }

        /// <summary>
        /// Returns true if FulfillmentPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of FulfillmentPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentPlan other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.LastRunTime == other.LastRunTime ||
                    this.LastRunTime != null &&
                    this.LastRunTime.Equals(other.LastRunTime)
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
                    this.MaxOrders == other.MaxOrders ||
                    this.MaxOrders != null &&
                    this.MaxOrders.Equals(other.MaxOrders)
                ) && 
                (
                    this.BatchSize == other.BatchSize ||
                    this.BatchSize != null &&
                    this.BatchSize.Equals(other.BatchSize)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                    this.CreatePickList == other.CreatePickList ||
                    this.CreatePickList != null &&
                    this.CreatePickList.Equals(other.CreatePickList)
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
                    this.CreatePickSummary == other.CreatePickSummary ||
                    this.CreatePickSummary != null &&
                    this.CreatePickSummary.Equals(other.CreatePickSummary)
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
                    this.PickScanSchemeId == other.PickScanSchemeId ||
                    this.PickScanSchemeId != null &&
                    this.PickScanSchemeId.Equals(other.PickScanSchemeId)
                ) && 
                (
                    this.CartonizeOrders == other.CartonizeOrders ||
                    this.CartonizeOrders != null &&
                    this.CartonizeOrders.Equals(other.CartonizeOrders)
                ) && 
                (
                    this.AutoShipCasebreakCartons == other.AutoShipCasebreakCartons ||
                    this.AutoShipCasebreakCartons != null &&
                    this.AutoShipCasebreakCartons.Equals(other.AutoShipCasebreakCartons)
                ) && 
                (
                    this.PreGenerateParcelLabels == other.PreGenerateParcelLabels ||
                    this.PreGenerateParcelLabels != null &&
                    this.PreGenerateParcelLabels.Equals(other.PreGenerateParcelLabels)
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
                    this.CreateOrderInvoice == other.CreateOrderInvoice ||
                    this.CreateOrderInvoice != null &&
                    this.CreateOrderInvoice.Equals(other.CreateOrderInvoice)
                ) && 
                (
                    this.OverrideOrderInvoiceTemplateId == other.OverrideOrderInvoiceTemplateId ||
                    this.OverrideOrderInvoiceTemplateId != null &&
                    this.OverrideOrderInvoiceTemplateId.Equals(other.OverrideOrderInvoiceTemplateId)
                ) && 
                (
                    this.SendToExternalShippingSystem == other.SendToExternalShippingSystem ||
                    this.SendToExternalShippingSystem != null &&
                    this.SendToExternalShippingSystem.Equals(other.SendToExternalShippingSystem)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.LastRunTime != null)
                    hash = hash * 59 + this.LastRunTime.GetHashCode();
                
                if (this.OrderSmartFilterId != null)
                    hash = hash * 59 + this.OrderSmartFilterId.GetHashCode();
                
                if (this.LocationSmartFilterId != null)
                    hash = hash * 59 + this.LocationSmartFilterId.GetHashCode();
                
                if (this.MaxOrders != null)
                    hash = hash * 59 + this.MaxOrders.GetHashCode();
                
                if (this.BatchSize != null)
                    hash = hash * 59 + this.BatchSize.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.CreatePickWork != null)
                    hash = hash * 59 + this.CreatePickWork.GetHashCode();
                
                if (this.PickingRule != null)
                    hash = hash * 59 + this.PickingRule.GetHashCode();
                
                if (this.LayoutRule != null)
                    hash = hash * 59 + this.LayoutRule.GetHashCode();
                
                if (this.PickSortRule != null)
                    hash = hash * 59 + this.PickSortRule.GetHashCode();
                
                if (this.CreatePickList != null)
                    hash = hash * 59 + this.CreatePickList.GetHashCode();
                
                if (this.PickListFormat != null)
                    hash = hash * 59 + this.PickListFormat.GetHashCode();
                
                if (this.PickListLayout != null)
                    hash = hash * 59 + this.PickListLayout.GetHashCode();
                
                if (this.PickListGroup != null)
                    hash = hash * 59 + this.PickListGroup.GetHashCode();
                
                if (this.PickListSort != null)
                    hash = hash * 59 + this.PickListSort.GetHashCode();
                
                if (this.CreatePickSummary != null)
                    hash = hash * 59 + this.CreatePickSummary.GetHashCode();
                
                if (this.PickSummaryFormat != null)
                    hash = hash * 59 + this.PickSummaryFormat.GetHashCode();
                
                if (this.PickSummaryLayout != null)
                    hash = hash * 59 + this.PickSummaryLayout.GetHashCode();
                
                if (this.PickSummarySort != null)
                    hash = hash * 59 + this.PickSummarySort.GetHashCode();
                
                if (this.PickScanSchemeId != null)
                    hash = hash * 59 + this.PickScanSchemeId.GetHashCode();
                
                if (this.CartonizeOrders != null)
                    hash = hash * 59 + this.CartonizeOrders.GetHashCode();
                
                if (this.AutoShipCasebreakCartons != null)
                    hash = hash * 59 + this.AutoShipCasebreakCartons.GetHashCode();
                
                if (this.PreGenerateParcelLabels != null)
                    hash = hash * 59 + this.PreGenerateParcelLabels.GetHashCode();
                
                if (this.CreatePackingSlip != null)
                    hash = hash * 59 + this.CreatePackingSlip.GetHashCode();
                
                if (this.OverridePackingSlipTemplateId != null)
                    hash = hash * 59 + this.OverridePackingSlipTemplateId.GetHashCode();
                
                if (this.CreateOrderAssemblyGuide != null)
                    hash = hash * 59 + this.CreateOrderAssemblyGuide.GetHashCode();
                
                if (this.CreateOrderInvoice != null)
                    hash = hash * 59 + this.CreateOrderInvoice.GetHashCode();
                
                if (this.OverrideOrderInvoiceTemplateId != null)
                    hash = hash * 59 + this.OverrideOrderInvoiceTemplateId.GetHashCode();
                
                if (this.SendToExternalShippingSystem != null)
                    hash = hash * 59 + this.SendToExternalShippingSystem.GetHashCode();
                
                if (this.ExternalShippingSystemId != null)
                    hash = hash * 59 + this.ExternalShippingSystemId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
