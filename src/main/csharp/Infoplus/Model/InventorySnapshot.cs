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
    public partial class InventorySnapshot :  IEquatable<InventorySnapshot>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySnapshot" /> class.
        /// Initializes a new instance of the <see cref="InventorySnapshot" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="IsMixedReceipts">IsMixedReceipts (default to false).</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="Address">Address.</param>
        /// <param name="WarehouseId">WarehouseId.</param>
        /// <param name="WarehouseName">WarehouseName.</param>
        /// <param name="WarehouseZoneId">WarehouseZoneId.</param>
        /// <param name="WarehouseZoneName">WarehouseZoneName.</param>
        /// <param name="WarehouseZoneAddress">WarehouseZoneAddress.</param>
        /// <param name="WarehouseBuildingId">WarehouseBuildingId.</param>
        /// <param name="WarehouseBuildingName">WarehouseBuildingName.</param>
        /// <param name="WarehouseAisleId">WarehouseAisleId.</param>
        /// <param name="WarehouseAisleAddress">WarehouseAisleAddress.</param>
        /// <param name="WarehouseLocationOriginId">WarehouseLocationOriginId.</param>
        /// <param name="WarehouseLocationOriginName">WarehouseLocationOriginName.</param>
        /// <param name="WarehouseLocationBillingTypeId">WarehouseLocationBillingTypeId.</param>
        /// <param name="WarehouseLocationBillingTypeName">WarehouseLocationBillingTypeName.</param>
        /// <param name="WarehouseLocationBehaviorTypeId">WarehouseLocationBehaviorTypeId.</param>
        /// <param name="WarehouseLocationBehaviorTypeName">WarehouseLocationBehaviorTypeName.</param>
        /// <param name="WarehouseLocationFootprintId">WarehouseLocationFootprintId.</param>
        /// <param name="WarehouseLocationFootprintName">WarehouseLocationFootprintName.</param>
        /// <param name="WarehouseLocationFootprintWidth">WarehouseLocationFootprintWidth.</param>
        /// <param name="WarehouseLocationFootprintHeight">WarehouseLocationFootprintHeight.</param>
        /// <param name="WarehouseLocationFootprintDepth">WarehouseLocationFootprintDepth.</param>
        /// <param name="WarehouseLocationLevel">WarehouseLocationLevel.</param>
        /// <param name="WarehouseLocationBay">WarehouseLocationBay.</param>
        /// <param name="WarehouseLocationNumber">WarehouseLocationNumber.</param>
        /// <param name="WarehouseLocationOnline">WarehouseLocationOnline (default to false).</param>
        /// <param name="WarehouseLocationPriorityCode">WarehouseLocationPriorityCode.</param>
        /// <param name="WarehouseLocationAllowItemMixing">WarehouseLocationAllowItemMixing (default to false).</param>
        /// <param name="WarehouseLocationCost">WarehouseLocationCost.</param>
        /// <param name="ControlNo">ControlNo.</param>
        /// <param name="ItemVendorSku">ItemVendorSku.</param>
        /// <param name="ItemUpc">ItemUpc.</param>
        /// <param name="ItemMajorGroup">ItemMajorGroup.</param>
        /// <param name="ItemMajorGroupName">ItemMajorGroupName.</param>
        /// <param name="ItemSubGroup">ItemSubGroup.</param>
        /// <param name="ItemSubGroupName">ItemSubGroupName.</param>
        /// <param name="ItemProductCode">ItemProductCode.</param>
        /// <param name="ItemProductCodeName">ItemProductCodeName.</param>
        /// <param name="ItemAccountCode">ItemAccountCode.</param>
        /// <param name="ItemAccountCodeName">ItemAccountCodeName.</param>
        /// <param name="ItemSummaryCode">ItemSummaryCode.</param>
        /// <param name="ItemSummaryCodeName">ItemSummaryCodeName.</param>
        /// <param name="ItemSector">ItemSector.</param>
        /// <param name="PoNo">PoNo.</param>
        /// <param name="ReceiptDistributionDate">ReceiptDistributionDate.</param>
        /// <param name="ReceiptUnitsPerWrap">ReceiptUnitsPerWrap.</param>
        /// <param name="ReceiptUnitsPerCase">ReceiptUnitsPerCase.</param>
        /// <param name="ReceiptRevisionDate">ReceiptRevisionDate.</param>
        /// <param name="ReceiptProductionLot">ReceiptProductionLot.</param>
        /// <param name="ReceiptReceiveDate">ReceiptReceiveDate.</param>
        /// <param name="ReceiptStatus">ReceiptStatus.</param>
        /// <param name="ReceiptStatusName">ReceiptStatusName.</param>
        /// <param name="ReceiptUnitCode">ReceiptUnitCode.</param>
        /// <param name="ReceiptUnitCodeText">ReceiptUnitCodeText.</param>
        /// <param name="ReceiptWrapCode">ReceiptWrapCode.</param>
        /// <param name="ReceiptWrapCodeText">ReceiptWrapCodeText.</param>
        /// <param name="ReceiptCaseWeight">ReceiptCaseWeight.</param>
        /// <param name="ReceiptProductIdTag">ReceiptProductIdTag.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public InventorySnapshot(int? LobId = null, bool? IsMixedReceipts = null, int? Quantity = null, string Address = null, int? WarehouseId = null, string WarehouseName = null, int? WarehouseZoneId = null, string WarehouseZoneName = null, string WarehouseZoneAddress = null, int? WarehouseBuildingId = null, string WarehouseBuildingName = null, int? WarehouseAisleId = null, string WarehouseAisleAddress = null, int? WarehouseLocationOriginId = null, string WarehouseLocationOriginName = null, int? WarehouseLocationBillingTypeId = null, string WarehouseLocationBillingTypeName = null, int? WarehouseLocationBehaviorTypeId = null, string WarehouseLocationBehaviorTypeName = null, int? WarehouseLocationFootprintId = null, string WarehouseLocationFootprintName = null, int? WarehouseLocationFootprintWidth = null, int? WarehouseLocationFootprintHeight = null, int? WarehouseLocationFootprintDepth = null, int? WarehouseLocationLevel = null, int? WarehouseLocationBay = null, int? WarehouseLocationNumber = null, bool? WarehouseLocationOnline = null, int? WarehouseLocationPriorityCode = null, bool? WarehouseLocationAllowItemMixing = null, int? WarehouseLocationCost = null, string ControlNo = null, string ItemVendorSku = null, string ItemUpc = null, int? ItemMajorGroup = null, string ItemMajorGroupName = null, int? ItemSubGroup = null, string ItemSubGroupName = null, int? ItemProductCode = null, string ItemProductCodeName = null, string ItemAccountCode = null, string ItemAccountCodeName = null, int? ItemSummaryCode = null, string ItemSummaryCodeName = null, string ItemSector = null, string PoNo = null, DateTime? ReceiptDistributionDate = null, int? ReceiptUnitsPerWrap = null, int? ReceiptUnitsPerCase = null, string ReceiptRevisionDate = null, string ReceiptProductionLot = null, DateTime? ReceiptReceiveDate = null, string ReceiptStatus = null, string ReceiptStatusName = null, int? ReceiptUnitCode = null, string ReceiptUnitCodeText = null, int? ReceiptWrapCode = null, string ReceiptWrapCodeText = null, double? ReceiptCaseWeight = null, string ReceiptProductIdTag = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for InventorySnapshot and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // use default value if no "IsMixedReceipts" provided
            if (IsMixedReceipts == null)
            {
                this.IsMixedReceipts = false;
            }
            else
            {
                this.IsMixedReceipts = IsMixedReceipts;
            }
            this.Quantity = Quantity;
            this.Address = Address;
            this.WarehouseId = WarehouseId;
            this.WarehouseName = WarehouseName;
            this.WarehouseZoneId = WarehouseZoneId;
            this.WarehouseZoneName = WarehouseZoneName;
            this.WarehouseZoneAddress = WarehouseZoneAddress;
            this.WarehouseBuildingId = WarehouseBuildingId;
            this.WarehouseBuildingName = WarehouseBuildingName;
            this.WarehouseAisleId = WarehouseAisleId;
            this.WarehouseAisleAddress = WarehouseAisleAddress;
            this.WarehouseLocationOriginId = WarehouseLocationOriginId;
            this.WarehouseLocationOriginName = WarehouseLocationOriginName;
            this.WarehouseLocationBillingTypeId = WarehouseLocationBillingTypeId;
            this.WarehouseLocationBillingTypeName = WarehouseLocationBillingTypeName;
            this.WarehouseLocationBehaviorTypeId = WarehouseLocationBehaviorTypeId;
            this.WarehouseLocationBehaviorTypeName = WarehouseLocationBehaviorTypeName;
            this.WarehouseLocationFootprintId = WarehouseLocationFootprintId;
            this.WarehouseLocationFootprintName = WarehouseLocationFootprintName;
            this.WarehouseLocationFootprintWidth = WarehouseLocationFootprintWidth;
            this.WarehouseLocationFootprintHeight = WarehouseLocationFootprintHeight;
            this.WarehouseLocationFootprintDepth = WarehouseLocationFootprintDepth;
            this.WarehouseLocationLevel = WarehouseLocationLevel;
            this.WarehouseLocationBay = WarehouseLocationBay;
            this.WarehouseLocationNumber = WarehouseLocationNumber;
            // use default value if no "WarehouseLocationOnline" provided
            if (WarehouseLocationOnline == null)
            {
                this.WarehouseLocationOnline = false;
            }
            else
            {
                this.WarehouseLocationOnline = WarehouseLocationOnline;
            }
            this.WarehouseLocationPriorityCode = WarehouseLocationPriorityCode;
            // use default value if no "WarehouseLocationAllowItemMixing" provided
            if (WarehouseLocationAllowItemMixing == null)
            {
                this.WarehouseLocationAllowItemMixing = false;
            }
            else
            {
                this.WarehouseLocationAllowItemMixing = WarehouseLocationAllowItemMixing;
            }
            this.WarehouseLocationCost = WarehouseLocationCost;
            this.ControlNo = ControlNo;
            this.ItemVendorSku = ItemVendorSku;
            this.ItemUpc = ItemUpc;
            this.ItemMajorGroup = ItemMajorGroup;
            this.ItemMajorGroupName = ItemMajorGroupName;
            this.ItemSubGroup = ItemSubGroup;
            this.ItemSubGroupName = ItemSubGroupName;
            this.ItemProductCode = ItemProductCode;
            this.ItemProductCodeName = ItemProductCodeName;
            this.ItemAccountCode = ItemAccountCode;
            this.ItemAccountCodeName = ItemAccountCodeName;
            this.ItemSummaryCode = ItemSummaryCode;
            this.ItemSummaryCodeName = ItemSummaryCodeName;
            this.ItemSector = ItemSector;
            this.PoNo = PoNo;
            this.ReceiptDistributionDate = ReceiptDistributionDate;
            this.ReceiptUnitsPerWrap = ReceiptUnitsPerWrap;
            this.ReceiptUnitsPerCase = ReceiptUnitsPerCase;
            this.ReceiptRevisionDate = ReceiptRevisionDate;
            this.ReceiptProductionLot = ReceiptProductionLot;
            this.ReceiptReceiveDate = ReceiptReceiveDate;
            this.ReceiptStatus = ReceiptStatus;
            this.ReceiptStatusName = ReceiptStatusName;
            this.ReceiptUnitCode = ReceiptUnitCode;
            this.ReceiptUnitCodeText = ReceiptUnitCodeText;
            this.ReceiptWrapCode = ReceiptWrapCode;
            this.ReceiptWrapCodeText = ReceiptWrapCodeText;
            this.ReceiptCaseWeight = ReceiptCaseWeight;
            this.ReceiptProductIdTag = ReceiptProductIdTag;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationId
        /// </summary>
        [DataMember(Name="warehouseLocationId", EmitDefaultValue=false)]
        public int? WarehouseLocationId { get; private set; }
    
        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public int? ItemId { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets SnapshotDate
        /// </summary>
        [DataMember(Name="snapshotDate", EmitDefaultValue=false)]
        public DateTime? SnapshotDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets IsMixedReceipts
        /// </summary>
        [DataMember(Name="isMixedReceipts", EmitDefaultValue=false)]
        public bool? IsMixedReceipts { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseName
        /// </summary>
        [DataMember(Name="warehouseName", EmitDefaultValue=false)]
        public string WarehouseName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseZoneId
        /// </summary>
        [DataMember(Name="warehouseZoneId", EmitDefaultValue=false)]
        public int? WarehouseZoneId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseZoneName
        /// </summary>
        [DataMember(Name="warehouseZoneName", EmitDefaultValue=false)]
        public string WarehouseZoneName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseZoneAddress
        /// </summary>
        [DataMember(Name="warehouseZoneAddress", EmitDefaultValue=false)]
        public string WarehouseZoneAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseBuildingId
        /// </summary>
        [DataMember(Name="warehouseBuildingId", EmitDefaultValue=false)]
        public int? WarehouseBuildingId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseBuildingName
        /// </summary>
        [DataMember(Name="warehouseBuildingName", EmitDefaultValue=false)]
        public string WarehouseBuildingName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseAisleId
        /// </summary>
        [DataMember(Name="warehouseAisleId", EmitDefaultValue=false)]
        public int? WarehouseAisleId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseAisleAddress
        /// </summary>
        [DataMember(Name="warehouseAisleAddress", EmitDefaultValue=false)]
        public string WarehouseAisleAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationOriginId
        /// </summary>
        [DataMember(Name="warehouseLocationOriginId", EmitDefaultValue=false)]
        public int? WarehouseLocationOriginId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationOriginName
        /// </summary>
        [DataMember(Name="warehouseLocationOriginName", EmitDefaultValue=false)]
        public string WarehouseLocationOriginName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationBillingTypeId
        /// </summary>
        [DataMember(Name="warehouseLocationBillingTypeId", EmitDefaultValue=false)]
        public int? WarehouseLocationBillingTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationBillingTypeName
        /// </summary>
        [DataMember(Name="warehouseLocationBillingTypeName", EmitDefaultValue=false)]
        public string WarehouseLocationBillingTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationBehaviorTypeId
        /// </summary>
        [DataMember(Name="warehouseLocationBehaviorTypeId", EmitDefaultValue=false)]
        public int? WarehouseLocationBehaviorTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationBehaviorTypeName
        /// </summary>
        [DataMember(Name="warehouseLocationBehaviorTypeName", EmitDefaultValue=false)]
        public string WarehouseLocationBehaviorTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationFootprintId
        /// </summary>
        [DataMember(Name="warehouseLocationFootprintId", EmitDefaultValue=false)]
        public int? WarehouseLocationFootprintId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationFootprintName
        /// </summary>
        [DataMember(Name="warehouseLocationFootprintName", EmitDefaultValue=false)]
        public string WarehouseLocationFootprintName { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationFootprintWidth
        /// </summary>
        [DataMember(Name="warehouseLocationFootprintWidth", EmitDefaultValue=false)]
        public int? WarehouseLocationFootprintWidth { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationFootprintHeight
        /// </summary>
        [DataMember(Name="warehouseLocationFootprintHeight", EmitDefaultValue=false)]
        public int? WarehouseLocationFootprintHeight { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationFootprintDepth
        /// </summary>
        [DataMember(Name="warehouseLocationFootprintDepth", EmitDefaultValue=false)]
        public int? WarehouseLocationFootprintDepth { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationLevel
        /// </summary>
        [DataMember(Name="warehouseLocationLevel", EmitDefaultValue=false)]
        public int? WarehouseLocationLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationBay
        /// </summary>
        [DataMember(Name="warehouseLocationBay", EmitDefaultValue=false)]
        public int? WarehouseLocationBay { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationNumber
        /// </summary>
        [DataMember(Name="warehouseLocationNumber", EmitDefaultValue=false)]
        public int? WarehouseLocationNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationOnline
        /// </summary>
        [DataMember(Name="warehouseLocationOnline", EmitDefaultValue=false)]
        public bool? WarehouseLocationOnline { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationPriorityCode
        /// </summary>
        [DataMember(Name="warehouseLocationPriorityCode", EmitDefaultValue=false)]
        public int? WarehouseLocationPriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationAllowItemMixing
        /// </summary>
        [DataMember(Name="warehouseLocationAllowItemMixing", EmitDefaultValue=false)]
        public bool? WarehouseLocationAllowItemMixing { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseLocationCost
        /// </summary>
        [DataMember(Name="warehouseLocationCost", EmitDefaultValue=false)]
        public int? WarehouseLocationCost { get; set; }
    
        /// <summary>
        /// Gets or Sets ControlNo
        /// </summary>
        [DataMember(Name="controlNo", EmitDefaultValue=false)]
        public string ControlNo { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemVendorSku
        /// </summary>
        [DataMember(Name="itemVendorSku", EmitDefaultValue=false)]
        public string ItemVendorSku { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemUpc
        /// </summary>
        [DataMember(Name="itemUpc", EmitDefaultValue=false)]
        public string ItemUpc { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemMajorGroup
        /// </summary>
        [DataMember(Name="itemMajorGroup", EmitDefaultValue=false)]
        public int? ItemMajorGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemMajorGroupName
        /// </summary>
        [DataMember(Name="itemMajorGroupName", EmitDefaultValue=false)]
        public string ItemMajorGroupName { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSubGroup
        /// </summary>
        [DataMember(Name="itemSubGroup", EmitDefaultValue=false)]
        public int? ItemSubGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSubGroupName
        /// </summary>
        [DataMember(Name="itemSubGroupName", EmitDefaultValue=false)]
        public string ItemSubGroupName { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemProductCode
        /// </summary>
        [DataMember(Name="itemProductCode", EmitDefaultValue=false)]
        public int? ItemProductCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemProductCodeName
        /// </summary>
        [DataMember(Name="itemProductCodeName", EmitDefaultValue=false)]
        public string ItemProductCodeName { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemAccountCode
        /// </summary>
        [DataMember(Name="itemAccountCode", EmitDefaultValue=false)]
        public string ItemAccountCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemAccountCodeName
        /// </summary>
        [DataMember(Name="itemAccountCodeName", EmitDefaultValue=false)]
        public string ItemAccountCodeName { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSummaryCode
        /// </summary>
        [DataMember(Name="itemSummaryCode", EmitDefaultValue=false)]
        public int? ItemSummaryCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSummaryCodeName
        /// </summary>
        [DataMember(Name="itemSummaryCodeName", EmitDefaultValue=false)]
        public string ItemSummaryCodeName { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemSector
        /// </summary>
        [DataMember(Name="itemSector", EmitDefaultValue=false)]
        public string ItemSector { get; set; }
    
        /// <summary>
        /// Gets or Sets PoNo
        /// </summary>
        [DataMember(Name="poNo", EmitDefaultValue=false)]
        public string PoNo { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptDistributionDate
        /// </summary>
        [DataMember(Name="receiptDistributionDate", EmitDefaultValue=false)]
        public DateTime? ReceiptDistributionDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptUnitsPerWrap
        /// </summary>
        [DataMember(Name="receiptUnitsPerWrap", EmitDefaultValue=false)]
        public int? ReceiptUnitsPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptUnitsPerCase
        /// </summary>
        [DataMember(Name="receiptUnitsPerCase", EmitDefaultValue=false)]
        public int? ReceiptUnitsPerCase { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptRevisionDate
        /// </summary>
        [DataMember(Name="receiptRevisionDate", EmitDefaultValue=false)]
        public string ReceiptRevisionDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptProductionLot
        /// </summary>
        [DataMember(Name="receiptProductionLot", EmitDefaultValue=false)]
        public string ReceiptProductionLot { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptReceiveDate
        /// </summary>
        [DataMember(Name="receiptReceiveDate", EmitDefaultValue=false)]
        public DateTime? ReceiptReceiveDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptStatus
        /// </summary>
        [DataMember(Name="receiptStatus", EmitDefaultValue=false)]
        public string ReceiptStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptStatusName
        /// </summary>
        [DataMember(Name="receiptStatusName", EmitDefaultValue=false)]
        public string ReceiptStatusName { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptUnitCode
        /// </summary>
        [DataMember(Name="receiptUnitCode", EmitDefaultValue=false)]
        public int? ReceiptUnitCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptUnitCodeText
        /// </summary>
        [DataMember(Name="receiptUnitCodeText", EmitDefaultValue=false)]
        public string ReceiptUnitCodeText { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptWrapCode
        /// </summary>
        [DataMember(Name="receiptWrapCode", EmitDefaultValue=false)]
        public int? ReceiptWrapCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptWrapCodeText
        /// </summary>
        [DataMember(Name="receiptWrapCodeText", EmitDefaultValue=false)]
        public string ReceiptWrapCodeText { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptCaseWeight
        /// </summary>
        [DataMember(Name="receiptCaseWeight", EmitDefaultValue=false)]
        public double? ReceiptCaseWeight { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceiptProductIdTag
        /// </summary>
        [DataMember(Name="receiptProductIdTag", EmitDefaultValue=false)]
        public string ReceiptProductIdTag { get; set; }
    
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
            sb.Append("class InventorySnapshot {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseLocationId: ").Append(WarehouseLocationId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  SnapshotDate: ").Append(SnapshotDate).Append("\n");
            sb.Append("  IsMixedReceipts: ").Append(IsMixedReceipts).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
            sb.Append("  WarehouseZoneId: ").Append(WarehouseZoneId).Append("\n");
            sb.Append("  WarehouseZoneName: ").Append(WarehouseZoneName).Append("\n");
            sb.Append("  WarehouseZoneAddress: ").Append(WarehouseZoneAddress).Append("\n");
            sb.Append("  WarehouseBuildingId: ").Append(WarehouseBuildingId).Append("\n");
            sb.Append("  WarehouseBuildingName: ").Append(WarehouseBuildingName).Append("\n");
            sb.Append("  WarehouseAisleId: ").Append(WarehouseAisleId).Append("\n");
            sb.Append("  WarehouseAisleAddress: ").Append(WarehouseAisleAddress).Append("\n");
            sb.Append("  WarehouseLocationOriginId: ").Append(WarehouseLocationOriginId).Append("\n");
            sb.Append("  WarehouseLocationOriginName: ").Append(WarehouseLocationOriginName).Append("\n");
            sb.Append("  WarehouseLocationBillingTypeId: ").Append(WarehouseLocationBillingTypeId).Append("\n");
            sb.Append("  WarehouseLocationBillingTypeName: ").Append(WarehouseLocationBillingTypeName).Append("\n");
            sb.Append("  WarehouseLocationBehaviorTypeId: ").Append(WarehouseLocationBehaviorTypeId).Append("\n");
            sb.Append("  WarehouseLocationBehaviorTypeName: ").Append(WarehouseLocationBehaviorTypeName).Append("\n");
            sb.Append("  WarehouseLocationFootprintId: ").Append(WarehouseLocationFootprintId).Append("\n");
            sb.Append("  WarehouseLocationFootprintName: ").Append(WarehouseLocationFootprintName).Append("\n");
            sb.Append("  WarehouseLocationFootprintWidth: ").Append(WarehouseLocationFootprintWidth).Append("\n");
            sb.Append("  WarehouseLocationFootprintHeight: ").Append(WarehouseLocationFootprintHeight).Append("\n");
            sb.Append("  WarehouseLocationFootprintDepth: ").Append(WarehouseLocationFootprintDepth).Append("\n");
            sb.Append("  WarehouseLocationLevel: ").Append(WarehouseLocationLevel).Append("\n");
            sb.Append("  WarehouseLocationBay: ").Append(WarehouseLocationBay).Append("\n");
            sb.Append("  WarehouseLocationNumber: ").Append(WarehouseLocationNumber).Append("\n");
            sb.Append("  WarehouseLocationOnline: ").Append(WarehouseLocationOnline).Append("\n");
            sb.Append("  WarehouseLocationPriorityCode: ").Append(WarehouseLocationPriorityCode).Append("\n");
            sb.Append("  WarehouseLocationAllowItemMixing: ").Append(WarehouseLocationAllowItemMixing).Append("\n");
            sb.Append("  WarehouseLocationCost: ").Append(WarehouseLocationCost).Append("\n");
            sb.Append("  ControlNo: ").Append(ControlNo).Append("\n");
            sb.Append("  ItemVendorSku: ").Append(ItemVendorSku).Append("\n");
            sb.Append("  ItemUpc: ").Append(ItemUpc).Append("\n");
            sb.Append("  ItemMajorGroup: ").Append(ItemMajorGroup).Append("\n");
            sb.Append("  ItemMajorGroupName: ").Append(ItemMajorGroupName).Append("\n");
            sb.Append("  ItemSubGroup: ").Append(ItemSubGroup).Append("\n");
            sb.Append("  ItemSubGroupName: ").Append(ItemSubGroupName).Append("\n");
            sb.Append("  ItemProductCode: ").Append(ItemProductCode).Append("\n");
            sb.Append("  ItemProductCodeName: ").Append(ItemProductCodeName).Append("\n");
            sb.Append("  ItemAccountCode: ").Append(ItemAccountCode).Append("\n");
            sb.Append("  ItemAccountCodeName: ").Append(ItemAccountCodeName).Append("\n");
            sb.Append("  ItemSummaryCode: ").Append(ItemSummaryCode).Append("\n");
            sb.Append("  ItemSummaryCodeName: ").Append(ItemSummaryCodeName).Append("\n");
            sb.Append("  ItemSector: ").Append(ItemSector).Append("\n");
            sb.Append("  PoNo: ").Append(PoNo).Append("\n");
            sb.Append("  ReceiptDistributionDate: ").Append(ReceiptDistributionDate).Append("\n");
            sb.Append("  ReceiptUnitsPerWrap: ").Append(ReceiptUnitsPerWrap).Append("\n");
            sb.Append("  ReceiptUnitsPerCase: ").Append(ReceiptUnitsPerCase).Append("\n");
            sb.Append("  ReceiptRevisionDate: ").Append(ReceiptRevisionDate).Append("\n");
            sb.Append("  ReceiptProductionLot: ").Append(ReceiptProductionLot).Append("\n");
            sb.Append("  ReceiptReceiveDate: ").Append(ReceiptReceiveDate).Append("\n");
            sb.Append("  ReceiptStatus: ").Append(ReceiptStatus).Append("\n");
            sb.Append("  ReceiptStatusName: ").Append(ReceiptStatusName).Append("\n");
            sb.Append("  ReceiptUnitCode: ").Append(ReceiptUnitCode).Append("\n");
            sb.Append("  ReceiptUnitCodeText: ").Append(ReceiptUnitCodeText).Append("\n");
            sb.Append("  ReceiptWrapCode: ").Append(ReceiptWrapCode).Append("\n");
            sb.Append("  ReceiptWrapCodeText: ").Append(ReceiptWrapCodeText).Append("\n");
            sb.Append("  ReceiptCaseWeight: ").Append(ReceiptCaseWeight).Append("\n");
            sb.Append("  ReceiptProductIdTag: ").Append(ReceiptProductIdTag).Append("\n");
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
            return this.Equals(obj as InventorySnapshot);
        }

        /// <summary>
        /// Returns true if InventorySnapshot instances are equal
        /// </summary>
        /// <param name="other">Instance of InventorySnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventorySnapshot other)
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
                    this.WarehouseLocationId == other.WarehouseLocationId ||
                    this.WarehouseLocationId != null &&
                    this.WarehouseLocationId.Equals(other.WarehouseLocationId)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.SnapshotDate == other.SnapshotDate ||
                    this.SnapshotDate != null &&
                    this.SnapshotDate.Equals(other.SnapshotDate)
                ) && 
                (
                    this.IsMixedReceipts == other.IsMixedReceipts ||
                    this.IsMixedReceipts != null &&
                    this.IsMixedReceipts.Equals(other.IsMixedReceipts)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                    this.WarehouseZoneId == other.WarehouseZoneId ||
                    this.WarehouseZoneId != null &&
                    this.WarehouseZoneId.Equals(other.WarehouseZoneId)
                ) && 
                (
                    this.WarehouseZoneName == other.WarehouseZoneName ||
                    this.WarehouseZoneName != null &&
                    this.WarehouseZoneName.Equals(other.WarehouseZoneName)
                ) && 
                (
                    this.WarehouseZoneAddress == other.WarehouseZoneAddress ||
                    this.WarehouseZoneAddress != null &&
                    this.WarehouseZoneAddress.Equals(other.WarehouseZoneAddress)
                ) && 
                (
                    this.WarehouseBuildingId == other.WarehouseBuildingId ||
                    this.WarehouseBuildingId != null &&
                    this.WarehouseBuildingId.Equals(other.WarehouseBuildingId)
                ) && 
                (
                    this.WarehouseBuildingName == other.WarehouseBuildingName ||
                    this.WarehouseBuildingName != null &&
                    this.WarehouseBuildingName.Equals(other.WarehouseBuildingName)
                ) && 
                (
                    this.WarehouseAisleId == other.WarehouseAisleId ||
                    this.WarehouseAisleId != null &&
                    this.WarehouseAisleId.Equals(other.WarehouseAisleId)
                ) && 
                (
                    this.WarehouseAisleAddress == other.WarehouseAisleAddress ||
                    this.WarehouseAisleAddress != null &&
                    this.WarehouseAisleAddress.Equals(other.WarehouseAisleAddress)
                ) && 
                (
                    this.WarehouseLocationOriginId == other.WarehouseLocationOriginId ||
                    this.WarehouseLocationOriginId != null &&
                    this.WarehouseLocationOriginId.Equals(other.WarehouseLocationOriginId)
                ) && 
                (
                    this.WarehouseLocationOriginName == other.WarehouseLocationOriginName ||
                    this.WarehouseLocationOriginName != null &&
                    this.WarehouseLocationOriginName.Equals(other.WarehouseLocationOriginName)
                ) && 
                (
                    this.WarehouseLocationBillingTypeId == other.WarehouseLocationBillingTypeId ||
                    this.WarehouseLocationBillingTypeId != null &&
                    this.WarehouseLocationBillingTypeId.Equals(other.WarehouseLocationBillingTypeId)
                ) && 
                (
                    this.WarehouseLocationBillingTypeName == other.WarehouseLocationBillingTypeName ||
                    this.WarehouseLocationBillingTypeName != null &&
                    this.WarehouseLocationBillingTypeName.Equals(other.WarehouseLocationBillingTypeName)
                ) && 
                (
                    this.WarehouseLocationBehaviorTypeId == other.WarehouseLocationBehaviorTypeId ||
                    this.WarehouseLocationBehaviorTypeId != null &&
                    this.WarehouseLocationBehaviorTypeId.Equals(other.WarehouseLocationBehaviorTypeId)
                ) && 
                (
                    this.WarehouseLocationBehaviorTypeName == other.WarehouseLocationBehaviorTypeName ||
                    this.WarehouseLocationBehaviorTypeName != null &&
                    this.WarehouseLocationBehaviorTypeName.Equals(other.WarehouseLocationBehaviorTypeName)
                ) && 
                (
                    this.WarehouseLocationFootprintId == other.WarehouseLocationFootprintId ||
                    this.WarehouseLocationFootprintId != null &&
                    this.WarehouseLocationFootprintId.Equals(other.WarehouseLocationFootprintId)
                ) && 
                (
                    this.WarehouseLocationFootprintName == other.WarehouseLocationFootprintName ||
                    this.WarehouseLocationFootprintName != null &&
                    this.WarehouseLocationFootprintName.Equals(other.WarehouseLocationFootprintName)
                ) && 
                (
                    this.WarehouseLocationFootprintWidth == other.WarehouseLocationFootprintWidth ||
                    this.WarehouseLocationFootprintWidth != null &&
                    this.WarehouseLocationFootprintWidth.Equals(other.WarehouseLocationFootprintWidth)
                ) && 
                (
                    this.WarehouseLocationFootprintHeight == other.WarehouseLocationFootprintHeight ||
                    this.WarehouseLocationFootprintHeight != null &&
                    this.WarehouseLocationFootprintHeight.Equals(other.WarehouseLocationFootprintHeight)
                ) && 
                (
                    this.WarehouseLocationFootprintDepth == other.WarehouseLocationFootprintDepth ||
                    this.WarehouseLocationFootprintDepth != null &&
                    this.WarehouseLocationFootprintDepth.Equals(other.WarehouseLocationFootprintDepth)
                ) && 
                (
                    this.WarehouseLocationLevel == other.WarehouseLocationLevel ||
                    this.WarehouseLocationLevel != null &&
                    this.WarehouseLocationLevel.Equals(other.WarehouseLocationLevel)
                ) && 
                (
                    this.WarehouseLocationBay == other.WarehouseLocationBay ||
                    this.WarehouseLocationBay != null &&
                    this.WarehouseLocationBay.Equals(other.WarehouseLocationBay)
                ) && 
                (
                    this.WarehouseLocationNumber == other.WarehouseLocationNumber ||
                    this.WarehouseLocationNumber != null &&
                    this.WarehouseLocationNumber.Equals(other.WarehouseLocationNumber)
                ) && 
                (
                    this.WarehouseLocationOnline == other.WarehouseLocationOnline ||
                    this.WarehouseLocationOnline != null &&
                    this.WarehouseLocationOnline.Equals(other.WarehouseLocationOnline)
                ) && 
                (
                    this.WarehouseLocationPriorityCode == other.WarehouseLocationPriorityCode ||
                    this.WarehouseLocationPriorityCode != null &&
                    this.WarehouseLocationPriorityCode.Equals(other.WarehouseLocationPriorityCode)
                ) && 
                (
                    this.WarehouseLocationAllowItemMixing == other.WarehouseLocationAllowItemMixing ||
                    this.WarehouseLocationAllowItemMixing != null &&
                    this.WarehouseLocationAllowItemMixing.Equals(other.WarehouseLocationAllowItemMixing)
                ) && 
                (
                    this.WarehouseLocationCost == other.WarehouseLocationCost ||
                    this.WarehouseLocationCost != null &&
                    this.WarehouseLocationCost.Equals(other.WarehouseLocationCost)
                ) && 
                (
                    this.ControlNo == other.ControlNo ||
                    this.ControlNo != null &&
                    this.ControlNo.Equals(other.ControlNo)
                ) && 
                (
                    this.ItemVendorSku == other.ItemVendorSku ||
                    this.ItemVendorSku != null &&
                    this.ItemVendorSku.Equals(other.ItemVendorSku)
                ) && 
                (
                    this.ItemUpc == other.ItemUpc ||
                    this.ItemUpc != null &&
                    this.ItemUpc.Equals(other.ItemUpc)
                ) && 
                (
                    this.ItemMajorGroup == other.ItemMajorGroup ||
                    this.ItemMajorGroup != null &&
                    this.ItemMajorGroup.Equals(other.ItemMajorGroup)
                ) && 
                (
                    this.ItemMajorGroupName == other.ItemMajorGroupName ||
                    this.ItemMajorGroupName != null &&
                    this.ItemMajorGroupName.Equals(other.ItemMajorGroupName)
                ) && 
                (
                    this.ItemSubGroup == other.ItemSubGroup ||
                    this.ItemSubGroup != null &&
                    this.ItemSubGroup.Equals(other.ItemSubGroup)
                ) && 
                (
                    this.ItemSubGroupName == other.ItemSubGroupName ||
                    this.ItemSubGroupName != null &&
                    this.ItemSubGroupName.Equals(other.ItemSubGroupName)
                ) && 
                (
                    this.ItemProductCode == other.ItemProductCode ||
                    this.ItemProductCode != null &&
                    this.ItemProductCode.Equals(other.ItemProductCode)
                ) && 
                (
                    this.ItemProductCodeName == other.ItemProductCodeName ||
                    this.ItemProductCodeName != null &&
                    this.ItemProductCodeName.Equals(other.ItemProductCodeName)
                ) && 
                (
                    this.ItemAccountCode == other.ItemAccountCode ||
                    this.ItemAccountCode != null &&
                    this.ItemAccountCode.Equals(other.ItemAccountCode)
                ) && 
                (
                    this.ItemAccountCodeName == other.ItemAccountCodeName ||
                    this.ItemAccountCodeName != null &&
                    this.ItemAccountCodeName.Equals(other.ItemAccountCodeName)
                ) && 
                (
                    this.ItemSummaryCode == other.ItemSummaryCode ||
                    this.ItemSummaryCode != null &&
                    this.ItemSummaryCode.Equals(other.ItemSummaryCode)
                ) && 
                (
                    this.ItemSummaryCodeName == other.ItemSummaryCodeName ||
                    this.ItemSummaryCodeName != null &&
                    this.ItemSummaryCodeName.Equals(other.ItemSummaryCodeName)
                ) && 
                (
                    this.ItemSector == other.ItemSector ||
                    this.ItemSector != null &&
                    this.ItemSector.Equals(other.ItemSector)
                ) && 
                (
                    this.PoNo == other.PoNo ||
                    this.PoNo != null &&
                    this.PoNo.Equals(other.PoNo)
                ) && 
                (
                    this.ReceiptDistributionDate == other.ReceiptDistributionDate ||
                    this.ReceiptDistributionDate != null &&
                    this.ReceiptDistributionDate.Equals(other.ReceiptDistributionDate)
                ) && 
                (
                    this.ReceiptUnitsPerWrap == other.ReceiptUnitsPerWrap ||
                    this.ReceiptUnitsPerWrap != null &&
                    this.ReceiptUnitsPerWrap.Equals(other.ReceiptUnitsPerWrap)
                ) && 
                (
                    this.ReceiptUnitsPerCase == other.ReceiptUnitsPerCase ||
                    this.ReceiptUnitsPerCase != null &&
                    this.ReceiptUnitsPerCase.Equals(other.ReceiptUnitsPerCase)
                ) && 
                (
                    this.ReceiptRevisionDate == other.ReceiptRevisionDate ||
                    this.ReceiptRevisionDate != null &&
                    this.ReceiptRevisionDate.Equals(other.ReceiptRevisionDate)
                ) && 
                (
                    this.ReceiptProductionLot == other.ReceiptProductionLot ||
                    this.ReceiptProductionLot != null &&
                    this.ReceiptProductionLot.Equals(other.ReceiptProductionLot)
                ) && 
                (
                    this.ReceiptReceiveDate == other.ReceiptReceiveDate ||
                    this.ReceiptReceiveDate != null &&
                    this.ReceiptReceiveDate.Equals(other.ReceiptReceiveDate)
                ) && 
                (
                    this.ReceiptStatus == other.ReceiptStatus ||
                    this.ReceiptStatus != null &&
                    this.ReceiptStatus.Equals(other.ReceiptStatus)
                ) && 
                (
                    this.ReceiptStatusName == other.ReceiptStatusName ||
                    this.ReceiptStatusName != null &&
                    this.ReceiptStatusName.Equals(other.ReceiptStatusName)
                ) && 
                (
                    this.ReceiptUnitCode == other.ReceiptUnitCode ||
                    this.ReceiptUnitCode != null &&
                    this.ReceiptUnitCode.Equals(other.ReceiptUnitCode)
                ) && 
                (
                    this.ReceiptUnitCodeText == other.ReceiptUnitCodeText ||
                    this.ReceiptUnitCodeText != null &&
                    this.ReceiptUnitCodeText.Equals(other.ReceiptUnitCodeText)
                ) && 
                (
                    this.ReceiptWrapCode == other.ReceiptWrapCode ||
                    this.ReceiptWrapCode != null &&
                    this.ReceiptWrapCode.Equals(other.ReceiptWrapCode)
                ) && 
                (
                    this.ReceiptWrapCodeText == other.ReceiptWrapCodeText ||
                    this.ReceiptWrapCodeText != null &&
                    this.ReceiptWrapCodeText.Equals(other.ReceiptWrapCodeText)
                ) && 
                (
                    this.ReceiptCaseWeight == other.ReceiptCaseWeight ||
                    this.ReceiptCaseWeight != null &&
                    this.ReceiptCaseWeight.Equals(other.ReceiptCaseWeight)
                ) && 
                (
                    this.ReceiptProductIdTag == other.ReceiptProductIdTag ||
                    this.ReceiptProductIdTag != null &&
                    this.ReceiptProductIdTag.Equals(other.ReceiptProductIdTag)
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
                
                if (this.WarehouseLocationId != null)
                    hash = hash * 59 + this.WarehouseLocationId.GetHashCode();
                
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.SnapshotDate != null)
                    hash = hash * 59 + this.SnapshotDate.GetHashCode();
                
                if (this.IsMixedReceipts != null)
                    hash = hash * 59 + this.IsMixedReceipts.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.WarehouseName != null)
                    hash = hash * 59 + this.WarehouseName.GetHashCode();
                
                if (this.WarehouseZoneId != null)
                    hash = hash * 59 + this.WarehouseZoneId.GetHashCode();
                
                if (this.WarehouseZoneName != null)
                    hash = hash * 59 + this.WarehouseZoneName.GetHashCode();
                
                if (this.WarehouseZoneAddress != null)
                    hash = hash * 59 + this.WarehouseZoneAddress.GetHashCode();
                
                if (this.WarehouseBuildingId != null)
                    hash = hash * 59 + this.WarehouseBuildingId.GetHashCode();
                
                if (this.WarehouseBuildingName != null)
                    hash = hash * 59 + this.WarehouseBuildingName.GetHashCode();
                
                if (this.WarehouseAisleId != null)
                    hash = hash * 59 + this.WarehouseAisleId.GetHashCode();
                
                if (this.WarehouseAisleAddress != null)
                    hash = hash * 59 + this.WarehouseAisleAddress.GetHashCode();
                
                if (this.WarehouseLocationOriginId != null)
                    hash = hash * 59 + this.WarehouseLocationOriginId.GetHashCode();
                
                if (this.WarehouseLocationOriginName != null)
                    hash = hash * 59 + this.WarehouseLocationOriginName.GetHashCode();
                
                if (this.WarehouseLocationBillingTypeId != null)
                    hash = hash * 59 + this.WarehouseLocationBillingTypeId.GetHashCode();
                
                if (this.WarehouseLocationBillingTypeName != null)
                    hash = hash * 59 + this.WarehouseLocationBillingTypeName.GetHashCode();
                
                if (this.WarehouseLocationBehaviorTypeId != null)
                    hash = hash * 59 + this.WarehouseLocationBehaviorTypeId.GetHashCode();
                
                if (this.WarehouseLocationBehaviorTypeName != null)
                    hash = hash * 59 + this.WarehouseLocationBehaviorTypeName.GetHashCode();
                
                if (this.WarehouseLocationFootprintId != null)
                    hash = hash * 59 + this.WarehouseLocationFootprintId.GetHashCode();
                
                if (this.WarehouseLocationFootprintName != null)
                    hash = hash * 59 + this.WarehouseLocationFootprintName.GetHashCode();
                
                if (this.WarehouseLocationFootprintWidth != null)
                    hash = hash * 59 + this.WarehouseLocationFootprintWidth.GetHashCode();
                
                if (this.WarehouseLocationFootprintHeight != null)
                    hash = hash * 59 + this.WarehouseLocationFootprintHeight.GetHashCode();
                
                if (this.WarehouseLocationFootprintDepth != null)
                    hash = hash * 59 + this.WarehouseLocationFootprintDepth.GetHashCode();
                
                if (this.WarehouseLocationLevel != null)
                    hash = hash * 59 + this.WarehouseLocationLevel.GetHashCode();
                
                if (this.WarehouseLocationBay != null)
                    hash = hash * 59 + this.WarehouseLocationBay.GetHashCode();
                
                if (this.WarehouseLocationNumber != null)
                    hash = hash * 59 + this.WarehouseLocationNumber.GetHashCode();
                
                if (this.WarehouseLocationOnline != null)
                    hash = hash * 59 + this.WarehouseLocationOnline.GetHashCode();
                
                if (this.WarehouseLocationPriorityCode != null)
                    hash = hash * 59 + this.WarehouseLocationPriorityCode.GetHashCode();
                
                if (this.WarehouseLocationAllowItemMixing != null)
                    hash = hash * 59 + this.WarehouseLocationAllowItemMixing.GetHashCode();
                
                if (this.WarehouseLocationCost != null)
                    hash = hash * 59 + this.WarehouseLocationCost.GetHashCode();
                
                if (this.ControlNo != null)
                    hash = hash * 59 + this.ControlNo.GetHashCode();
                
                if (this.ItemVendorSku != null)
                    hash = hash * 59 + this.ItemVendorSku.GetHashCode();
                
                if (this.ItemUpc != null)
                    hash = hash * 59 + this.ItemUpc.GetHashCode();
                
                if (this.ItemMajorGroup != null)
                    hash = hash * 59 + this.ItemMajorGroup.GetHashCode();
                
                if (this.ItemMajorGroupName != null)
                    hash = hash * 59 + this.ItemMajorGroupName.GetHashCode();
                
                if (this.ItemSubGroup != null)
                    hash = hash * 59 + this.ItemSubGroup.GetHashCode();
                
                if (this.ItemSubGroupName != null)
                    hash = hash * 59 + this.ItemSubGroupName.GetHashCode();
                
                if (this.ItemProductCode != null)
                    hash = hash * 59 + this.ItemProductCode.GetHashCode();
                
                if (this.ItemProductCodeName != null)
                    hash = hash * 59 + this.ItemProductCodeName.GetHashCode();
                
                if (this.ItemAccountCode != null)
                    hash = hash * 59 + this.ItemAccountCode.GetHashCode();
                
                if (this.ItemAccountCodeName != null)
                    hash = hash * 59 + this.ItemAccountCodeName.GetHashCode();
                
                if (this.ItemSummaryCode != null)
                    hash = hash * 59 + this.ItemSummaryCode.GetHashCode();
                
                if (this.ItemSummaryCodeName != null)
                    hash = hash * 59 + this.ItemSummaryCodeName.GetHashCode();
                
                if (this.ItemSector != null)
                    hash = hash * 59 + this.ItemSector.GetHashCode();
                
                if (this.PoNo != null)
                    hash = hash * 59 + this.PoNo.GetHashCode();
                
                if (this.ReceiptDistributionDate != null)
                    hash = hash * 59 + this.ReceiptDistributionDate.GetHashCode();
                
                if (this.ReceiptUnitsPerWrap != null)
                    hash = hash * 59 + this.ReceiptUnitsPerWrap.GetHashCode();
                
                if (this.ReceiptUnitsPerCase != null)
                    hash = hash * 59 + this.ReceiptUnitsPerCase.GetHashCode();
                
                if (this.ReceiptRevisionDate != null)
                    hash = hash * 59 + this.ReceiptRevisionDate.GetHashCode();
                
                if (this.ReceiptProductionLot != null)
                    hash = hash * 59 + this.ReceiptProductionLot.GetHashCode();
                
                if (this.ReceiptReceiveDate != null)
                    hash = hash * 59 + this.ReceiptReceiveDate.GetHashCode();
                
                if (this.ReceiptStatus != null)
                    hash = hash * 59 + this.ReceiptStatus.GetHashCode();
                
                if (this.ReceiptStatusName != null)
                    hash = hash * 59 + this.ReceiptStatusName.GetHashCode();
                
                if (this.ReceiptUnitCode != null)
                    hash = hash * 59 + this.ReceiptUnitCode.GetHashCode();
                
                if (this.ReceiptUnitCodeText != null)
                    hash = hash * 59 + this.ReceiptUnitCodeText.GetHashCode();
                
                if (this.ReceiptWrapCode != null)
                    hash = hash * 59 + this.ReceiptWrapCode.GetHashCode();
                
                if (this.ReceiptWrapCodeText != null)
                    hash = hash * 59 + this.ReceiptWrapCodeText.GetHashCode();
                
                if (this.ReceiptCaseWeight != null)
                    hash = hash * 59 + this.ReceiptCaseWeight.GetHashCode();
                
                if (this.ReceiptProductIdTag != null)
                    hash = hash * 59 + this.ReceiptProductIdTag.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
