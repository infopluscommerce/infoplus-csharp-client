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
    public partial class ItemReceiptActivity :  IEquatable<ItemReceiptActivity>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReceiptActivity" /> class.
        /// Initializes a new instance of the <see cref="ItemReceiptActivity" />class.
        /// </summary>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="LobId">LobId (required).</param>
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
        /// <param name="WarehouseId">WarehouseId.</param>
        /// <param name="WarehouseName">WarehouseName.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="ControlNo">ControlNo.</param>
        /// <param name="ItemVendorSku">ItemVendorSku.</param>
        /// <param name="ItemUPC">ItemUPC.</param>
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
        /// <param name="VendorComplianceSurveyAnswer1">VendorComplianceSurveyAnswer1.</param>
        /// <param name="VendorComplianceSurveyAnswer2">VendorComplianceSurveyAnswer2.</param>
        /// <param name="VendorComplianceSurveyAnswer3">VendorComplianceSurveyAnswer3.</param>
        /// <param name="VendorComplianceSurveyAnswer4">VendorComplianceSurveyAnswer4.</param>
        /// <param name="VendorComplianceSurveyAnswer5">VendorComplianceSurveyAnswer5.</param>
        /// <param name="VendorComplianceSurveyAnswer6">VendorComplianceSurveyAnswer6.</param>
        /// <param name="VendorComplianceSurveyAnswer7">VendorComplianceSurveyAnswer7.</param>
        /// <param name="VendorComplianceSurveyAnswer8">VendorComplianceSurveyAnswer8.</param>
        /// <param name="VendorComplianceSurveyAnswer9">VendorComplianceSurveyAnswer9.</param>
        /// <param name="VendorComplianceSurveyAnswer10">VendorComplianceSurveyAnswer10.</param>
        /// <param name="VendorComplianceSurveyAnswer11">VendorComplianceSurveyAnswer11.</param>
        /// <param name="VendorComplianceSurveyAnswer12">VendorComplianceSurveyAnswer12.</param>
        /// <param name="VendorComplianceSurveyAnswer13">VendorComplianceSurveyAnswer13.</param>
        /// <param name="VendorComplianceSurveyAnswer14">VendorComplianceSurveyAnswer14.</param>
        /// <param name="VendorComplianceSurveyAnswer15">VendorComplianceSurveyAnswer15.</param>
        /// <param name="VendorComplianceSurveyAnswer16">VendorComplianceSurveyAnswer16.</param>
        /// <param name="VendorComplianceSurveyAnswer17">VendorComplianceSurveyAnswer17.</param>
        /// <param name="VendorComplianceSurveyAnswer18">VendorComplianceSurveyAnswer18.</param>
        /// <param name="VendorComplianceSurveyAnswer19">VendorComplianceSurveyAnswer19.</param>
        /// <param name="VendorComplianceSurveyAnswer20">VendorComplianceSurveyAnswer20.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ItemReceiptActivity(DateTime? CreateDate = null, DateTime? ModifyDate = null, int? LobId = null, string PoNo = null, DateTime? ReceiptDistributionDate = null, int? ReceiptUnitsPerWrap = null, int? ReceiptUnitsPerCase = null, string ReceiptRevisionDate = null, string ReceiptProductionLot = null, DateTime? ReceiptReceiveDate = null, string ReceiptStatus = null, string ReceiptStatusName = null, int? ReceiptUnitCode = null, string ReceiptUnitCodeText = null, int? ReceiptWrapCode = null, string ReceiptWrapCodeText = null, double? ReceiptCaseWeight = null, string ReceiptProductIdTag = null, int? WarehouseId = null, string WarehouseName = null, int? ItemId = null, string ControlNo = null, string ItemVendorSku = null, string ItemUPC = null, int? ItemMajorGroup = null, string ItemMajorGroupName = null, int? ItemSubGroup = null, string ItemSubGroupName = null, int? ItemProductCode = null, string ItemProductCodeName = null, string ItemAccountCode = null, string ItemAccountCodeName = null, int? ItemSummaryCode = null, string ItemSummaryCodeName = null, string ItemSector = null, string VendorComplianceSurveyAnswer1 = null, string VendorComplianceSurveyAnswer2 = null, string VendorComplianceSurveyAnswer3 = null, string VendorComplianceSurveyAnswer4 = null, string VendorComplianceSurveyAnswer5 = null, string VendorComplianceSurveyAnswer6 = null, string VendorComplianceSurveyAnswer7 = null, string VendorComplianceSurveyAnswer8 = null, string VendorComplianceSurveyAnswer9 = null, string VendorComplianceSurveyAnswer10 = null, string VendorComplianceSurveyAnswer11 = null, string VendorComplianceSurveyAnswer12 = null, string VendorComplianceSurveyAnswer13 = null, string VendorComplianceSurveyAnswer14 = null, string VendorComplianceSurveyAnswer15 = null, string VendorComplianceSurveyAnswer16 = null, string VendorComplianceSurveyAnswer17 = null, string VendorComplianceSurveyAnswer18 = null, string VendorComplianceSurveyAnswer19 = null, string VendorComplianceSurveyAnswer20 = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for ItemReceiptActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
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
            this.WarehouseId = WarehouseId;
            this.WarehouseName = WarehouseName;
            this.ItemId = ItemId;
            this.ControlNo = ControlNo;
            this.ItemVendorSku = ItemVendorSku;
            this.ItemUPC = ItemUPC;
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
            this.VendorComplianceSurveyAnswer1 = VendorComplianceSurveyAnswer1;
            this.VendorComplianceSurveyAnswer2 = VendorComplianceSurveyAnswer2;
            this.VendorComplianceSurveyAnswer3 = VendorComplianceSurveyAnswer3;
            this.VendorComplianceSurveyAnswer4 = VendorComplianceSurveyAnswer4;
            this.VendorComplianceSurveyAnswer5 = VendorComplianceSurveyAnswer5;
            this.VendorComplianceSurveyAnswer6 = VendorComplianceSurveyAnswer6;
            this.VendorComplianceSurveyAnswer7 = VendorComplianceSurveyAnswer7;
            this.VendorComplianceSurveyAnswer8 = VendorComplianceSurveyAnswer8;
            this.VendorComplianceSurveyAnswer9 = VendorComplianceSurveyAnswer9;
            this.VendorComplianceSurveyAnswer10 = VendorComplianceSurveyAnswer10;
            this.VendorComplianceSurveyAnswer11 = VendorComplianceSurveyAnswer11;
            this.VendorComplianceSurveyAnswer12 = VendorComplianceSurveyAnswer12;
            this.VendorComplianceSurveyAnswer13 = VendorComplianceSurveyAnswer13;
            this.VendorComplianceSurveyAnswer14 = VendorComplianceSurveyAnswer14;
            this.VendorComplianceSurveyAnswer15 = VendorComplianceSurveyAnswer15;
            this.VendorComplianceSurveyAnswer16 = VendorComplianceSurveyAnswer16;
            this.VendorComplianceSurveyAnswer17 = VendorComplianceSurveyAnswer17;
            this.VendorComplianceSurveyAnswer18 = VendorComplianceSurveyAnswer18;
            this.VendorComplianceSurveyAnswer19 = VendorComplianceSurveyAnswer19;
            this.VendorComplianceSurveyAnswer20 = VendorComplianceSurveyAnswer20;
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
        /// Gets or Sets ItemReceiptId
        /// </summary>
        [DataMember(Name="itemReceiptId", EmitDefaultValue=false)]
        public int? ItemReceiptId { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
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
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public int? ItemId { get; set; }
    
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
        /// Gets or Sets ItemUPC
        /// </summary>
        [DataMember(Name="itemUPC", EmitDefaultValue=false)]
        public string ItemUPC { get; set; }
    
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
        /// Gets or Sets VendorComplianceSurveyAnswer1
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer1", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer1 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer2
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer2", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer2 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer3
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer3", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer3 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer4
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer4", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer4 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer5
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer5", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer5 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer6
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer6", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer6 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer7
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer7", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer7 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer8
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer8", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer8 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer9
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer9", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer9 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer10
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer10", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer10 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer11
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer11", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer11 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer12
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer12", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer12 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer13
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer13", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer13 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer14
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer14", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer14 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer15
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer15", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer15 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer16
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer16", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer16 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer17
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer17", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer17 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer18
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer18", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer18 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer19
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer19", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer19 { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorComplianceSurveyAnswer20
        /// </summary>
        [DataMember(Name="vendorComplianceSurveyAnswer20", EmitDefaultValue=false)]
        public string VendorComplianceSurveyAnswer20 { get; set; }
    
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
            sb.Append("class ItemReceiptActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ItemReceiptId: ").Append(ItemReceiptId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
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
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ControlNo: ").Append(ControlNo).Append("\n");
            sb.Append("  ItemVendorSku: ").Append(ItemVendorSku).Append("\n");
            sb.Append("  ItemUPC: ").Append(ItemUPC).Append("\n");
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
            sb.Append("  VendorComplianceSurveyAnswer1: ").Append(VendorComplianceSurveyAnswer1).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer2: ").Append(VendorComplianceSurveyAnswer2).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer3: ").Append(VendorComplianceSurveyAnswer3).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer4: ").Append(VendorComplianceSurveyAnswer4).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer5: ").Append(VendorComplianceSurveyAnswer5).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer6: ").Append(VendorComplianceSurveyAnswer6).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer7: ").Append(VendorComplianceSurveyAnswer7).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer8: ").Append(VendorComplianceSurveyAnswer8).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer9: ").Append(VendorComplianceSurveyAnswer9).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer10: ").Append(VendorComplianceSurveyAnswer10).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer11: ").Append(VendorComplianceSurveyAnswer11).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer12: ").Append(VendorComplianceSurveyAnswer12).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer13: ").Append(VendorComplianceSurveyAnswer13).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer14: ").Append(VendorComplianceSurveyAnswer14).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer15: ").Append(VendorComplianceSurveyAnswer15).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer16: ").Append(VendorComplianceSurveyAnswer16).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer17: ").Append(VendorComplianceSurveyAnswer17).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer18: ").Append(VendorComplianceSurveyAnswer18).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer19: ").Append(VendorComplianceSurveyAnswer19).Append("\n");
            sb.Append("  VendorComplianceSurveyAnswer20: ").Append(VendorComplianceSurveyAnswer20).Append("\n");
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
            return this.Equals(obj as ItemReceiptActivity);
        }

        /// <summary>
        /// Returns true if ItemReceiptActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemReceiptActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemReceiptActivity other)
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
                    this.ItemReceiptId == other.ItemReceiptId ||
                    this.ItemReceiptId != null &&
                    this.ItemReceiptId.Equals(other.ItemReceiptId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
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
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
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
                    this.ItemUPC == other.ItemUPC ||
                    this.ItemUPC != null &&
                    this.ItemUPC.Equals(other.ItemUPC)
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
                    this.VendorComplianceSurveyAnswer1 == other.VendorComplianceSurveyAnswer1 ||
                    this.VendorComplianceSurveyAnswer1 != null &&
                    this.VendorComplianceSurveyAnswer1.Equals(other.VendorComplianceSurveyAnswer1)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer2 == other.VendorComplianceSurveyAnswer2 ||
                    this.VendorComplianceSurveyAnswer2 != null &&
                    this.VendorComplianceSurveyAnswer2.Equals(other.VendorComplianceSurveyAnswer2)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer3 == other.VendorComplianceSurveyAnswer3 ||
                    this.VendorComplianceSurveyAnswer3 != null &&
                    this.VendorComplianceSurveyAnswer3.Equals(other.VendorComplianceSurveyAnswer3)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer4 == other.VendorComplianceSurveyAnswer4 ||
                    this.VendorComplianceSurveyAnswer4 != null &&
                    this.VendorComplianceSurveyAnswer4.Equals(other.VendorComplianceSurveyAnswer4)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer5 == other.VendorComplianceSurveyAnswer5 ||
                    this.VendorComplianceSurveyAnswer5 != null &&
                    this.VendorComplianceSurveyAnswer5.Equals(other.VendorComplianceSurveyAnswer5)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer6 == other.VendorComplianceSurveyAnswer6 ||
                    this.VendorComplianceSurveyAnswer6 != null &&
                    this.VendorComplianceSurveyAnswer6.Equals(other.VendorComplianceSurveyAnswer6)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer7 == other.VendorComplianceSurveyAnswer7 ||
                    this.VendorComplianceSurveyAnswer7 != null &&
                    this.VendorComplianceSurveyAnswer7.Equals(other.VendorComplianceSurveyAnswer7)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer8 == other.VendorComplianceSurveyAnswer8 ||
                    this.VendorComplianceSurveyAnswer8 != null &&
                    this.VendorComplianceSurveyAnswer8.Equals(other.VendorComplianceSurveyAnswer8)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer9 == other.VendorComplianceSurveyAnswer9 ||
                    this.VendorComplianceSurveyAnswer9 != null &&
                    this.VendorComplianceSurveyAnswer9.Equals(other.VendorComplianceSurveyAnswer9)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer10 == other.VendorComplianceSurveyAnswer10 ||
                    this.VendorComplianceSurveyAnswer10 != null &&
                    this.VendorComplianceSurveyAnswer10.Equals(other.VendorComplianceSurveyAnswer10)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer11 == other.VendorComplianceSurveyAnswer11 ||
                    this.VendorComplianceSurveyAnswer11 != null &&
                    this.VendorComplianceSurveyAnswer11.Equals(other.VendorComplianceSurveyAnswer11)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer12 == other.VendorComplianceSurveyAnswer12 ||
                    this.VendorComplianceSurveyAnswer12 != null &&
                    this.VendorComplianceSurveyAnswer12.Equals(other.VendorComplianceSurveyAnswer12)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer13 == other.VendorComplianceSurveyAnswer13 ||
                    this.VendorComplianceSurveyAnswer13 != null &&
                    this.VendorComplianceSurveyAnswer13.Equals(other.VendorComplianceSurveyAnswer13)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer14 == other.VendorComplianceSurveyAnswer14 ||
                    this.VendorComplianceSurveyAnswer14 != null &&
                    this.VendorComplianceSurveyAnswer14.Equals(other.VendorComplianceSurveyAnswer14)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer15 == other.VendorComplianceSurveyAnswer15 ||
                    this.VendorComplianceSurveyAnswer15 != null &&
                    this.VendorComplianceSurveyAnswer15.Equals(other.VendorComplianceSurveyAnswer15)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer16 == other.VendorComplianceSurveyAnswer16 ||
                    this.VendorComplianceSurveyAnswer16 != null &&
                    this.VendorComplianceSurveyAnswer16.Equals(other.VendorComplianceSurveyAnswer16)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer17 == other.VendorComplianceSurveyAnswer17 ||
                    this.VendorComplianceSurveyAnswer17 != null &&
                    this.VendorComplianceSurveyAnswer17.Equals(other.VendorComplianceSurveyAnswer17)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer18 == other.VendorComplianceSurveyAnswer18 ||
                    this.VendorComplianceSurveyAnswer18 != null &&
                    this.VendorComplianceSurveyAnswer18.Equals(other.VendorComplianceSurveyAnswer18)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer19 == other.VendorComplianceSurveyAnswer19 ||
                    this.VendorComplianceSurveyAnswer19 != null &&
                    this.VendorComplianceSurveyAnswer19.Equals(other.VendorComplianceSurveyAnswer19)
                ) && 
                (
                    this.VendorComplianceSurveyAnswer20 == other.VendorComplianceSurveyAnswer20 ||
                    this.VendorComplianceSurveyAnswer20 != null &&
                    this.VendorComplianceSurveyAnswer20.Equals(other.VendorComplianceSurveyAnswer20)
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
                
                if (this.ItemReceiptId != null)
                    hash = hash * 59 + this.ItemReceiptId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
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
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.WarehouseName != null)
                    hash = hash * 59 + this.WarehouseName.GetHashCode();
                
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                
                if (this.ControlNo != null)
                    hash = hash * 59 + this.ControlNo.GetHashCode();
                
                if (this.ItemVendorSku != null)
                    hash = hash * 59 + this.ItemVendorSku.GetHashCode();
                
                if (this.ItemUPC != null)
                    hash = hash * 59 + this.ItemUPC.GetHashCode();
                
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
                
                if (this.VendorComplianceSurveyAnswer1 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer1.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer2 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer2.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer3 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer3.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer4 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer4.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer5 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer5.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer6 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer6.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer7 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer7.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer8 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer8.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer9 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer9.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer10 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer10.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer11 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer11.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer12 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer12.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer13 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer13.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer14 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer14.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer15 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer15.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer16 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer16.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer17 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer17.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer18 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer18.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer19 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer19.GetHashCode();
                
                if (this.VendorComplianceSurveyAnswer20 != null)
                    hash = hash * 59 + this.VendorComplianceSurveyAnswer20.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
