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
    public partial class WorkActivity :  IEquatable<WorkActivity>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkActivity" /> class.
        /// Initializes a new instance of the <see cref="WorkActivity" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="TypeName">TypeName (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="StatusName">StatusName (required).</param>
        /// <param name="WorkBatchId">WorkBatchId.</param>
        /// <param name="PriorityCode">PriorityCode (required).</param>
        /// <param name="SourceWarehouseId">SourceWarehouseId (required).</param>
        /// <param name="SourceWarehouseName">SourceWarehouseName (required).</param>
        /// <param name="SourceLocation">SourceLocation (required).</param>
        /// <param name="SourceBuildingId">SourceBuildingId (required).</param>
        /// <param name="SourceBuildingName">SourceBuildingName (required).</param>
        /// <param name="SourceZoneId">SourceZoneId.</param>
        /// <param name="SourceZoneName">SourceZoneName (required).</param>
        /// <param name="SourceAisleId">SourceAisleId.</param>
        /// <param name="SourceAisleAddress">SourceAisleAddress (required).</param>
        /// <param name="SourceOriginName">SourceOriginName (required).</param>
        /// <param name="SourceBillingTypeId">SourceBillingTypeId (required).</param>
        /// <param name="SourceBillingTypeName">SourceBillingTypeName (required).</param>
        /// <param name="SourceBehaviorType">SourceBehaviorType (required).</param>
        /// <param name="SourceBehaviorTypeName">SourceBehaviorTypeName (required).</param>
        /// <param name="SourceFootprintId">SourceFootprintId (required).</param>
        /// <param name="SourceFootprintName">SourceFootprintName (required).</param>
        /// <param name="SourceAddressSchemeId">SourceAddressSchemeId.</param>
        /// <param name="SourceAddressSchemeName">SourceAddressSchemeName (required).</param>
        /// <param name="SourceLevel">SourceLevel.</param>
        /// <param name="SourceBay">SourceBay.</param>
        /// <param name="SourceNumber">SourceNumber.</param>
        /// <param name="SourceOnline">SourceOnline (required) (default to false).</param>
        /// <param name="SourcePriorityCode">SourcePriorityCode.</param>
        /// <param name="SourceCost">SourceCost.</param>
        /// <param name="SourceAllowItemMixing">SourceAllowItemMixing (required) (default to false).</param>
        /// <param name="DestinationWarehouseId">DestinationWarehouseId (required).</param>
        /// <param name="DestinationWarehouseName">DestinationWarehouseName (required).</param>
        /// <param name="DestinationLocation">DestinationLocation (required).</param>
        /// <param name="DestinationBuildingId">DestinationBuildingId (required).</param>
        /// <param name="DestinationBuildingName">DestinationBuildingName (required).</param>
        /// <param name="DestinationZoneId">DestinationZoneId.</param>
        /// <param name="DestinationZoneName">DestinationZoneName (required).</param>
        /// <param name="DestinationAisleId">DestinationAisleId.</param>
        /// <param name="DestinationAisleAddress">DestinationAisleAddress (required).</param>
        /// <param name="DestinationOriginName">DestinationOriginName (required).</param>
        /// <param name="DestinationBillingTypeId">DestinationBillingTypeId (required).</param>
        /// <param name="DestinationBillingTypeName">DestinationBillingTypeName (required).</param>
        /// <param name="DestinationBehaviorType">DestinationBehaviorType (required).</param>
        /// <param name="DestinationBehaviorTypeName">DestinationBehaviorTypeName (required).</param>
        /// <param name="DestinationFootprintId">DestinationFootprintId (required).</param>
        /// <param name="DestinationFootprintName">DestinationFootprintName (required).</param>
        /// <param name="DestinationAddressSchemeId">DestinationAddressSchemeId.</param>
        /// <param name="DestinationAddressSchemeName">DestinationAddressSchemeName (required).</param>
        /// <param name="DestinationLevel">DestinationLevel.</param>
        /// <param name="DestinationBay">DestinationBay.</param>
        /// <param name="DestinationNumber">DestinationNumber.</param>
        /// <param name="DestinationOnline">DestinationOnline (required) (default to false).</param>
        /// <param name="DestinationPriorityCode">DestinationPriorityCode.</param>
        /// <param name="DestinationCost">DestinationCost.</param>
        /// <param name="DestinationAllowItemMixing">DestinationAllowItemMixing (required) (default to false).</param>
        /// <param name="WeightPerWrap">WeightPerWrap.</param>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="NumericSortOrder">NumericSortOrder.</param>
        /// <param name="ItemDescription">ItemDescription (required).</param>
        /// <param name="AdditionalDescription">AdditionalDescription.</param>
        /// <param name="UnitCode">UnitCode (required).</param>
        /// <param name="WrapCode">WrapCode (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap (required).</param>
        /// <param name="ClassRestriction">ClassRestriction (required).</param>
        /// <param name="MaxCycle">MaxCycle (required).</param>
        /// <param name="MaxInterim">MaxInterim (required).</param>
        /// <param name="SeasonalItem">SeasonalItem (required).</param>
        /// <param name="Secure">Secure (required).</param>
        /// <param name="ProductType">ProductType.</param>
        /// <param name="ItemStatus">ItemStatus (required).</param>
        /// <param name="OverallLeadTime">OverallLeadTime.</param>
        /// <param name="OverallFixedReorderPoint">OverallFixedReorderPoint.</param>
        /// <param name="QualityControlIndicator">QualityControlIndicator (required).</param>
        /// <param name="LotControlFlag">LotControlFlag.</param>
        /// <param name="ProductCodeFlag">ProductCodeFlag (required).</param>
        /// <param name="ChargeCode">ChargeCode (required).</param>
        /// <param name="PodRevDate">PodRevDate.</param>
        /// <param name="PodOrderSuffix">PodOrderSuffix.</param>
        /// <param name="SerialCode">SerialCode (required).</param>
        /// <param name="AssetCode">AssetCode.</param>
        /// <param name="Backorder">Backorder (required).</param>
        /// <param name="AbsoluteMax">AbsoluteMax.</param>
        /// <param name="AccountCodeId">AccountCodeId.</param>
        /// <param name="SummaryCodeId">SummaryCodeId.</param>
        /// <param name="LowStockContactId">LowStockContactId.</param>
        /// <param name="LegacyLowLevelContactId">LegacyLowLevelContactId.</param>
        /// <param name="LowStockCodeId">LowStockCodeId.</param>
        /// <param name="MajorGroupId">MajorGroupId (required).</param>
        /// <param name="SubGroupId">SubGroupId (required).</param>
        /// <param name="ProductCodeId">ProductCodeId.</param>
        /// <param name="BuyerId">BuyerId.</param>
        /// <param name="VendorSKU">VendorSKU.</param>
        /// <param name="Upc">Upc.</param>
        /// <param name="PackingSlipDescription">PackingSlipDescription.</param>
        /// <param name="CommodityCode">CommodityCode.</param>
        /// <param name="CompCode">CompCode.</param>
        /// <param name="CriticalAmount">CriticalAmount (required).</param>
        /// <param name="ListPrice">ListPrice.</param>
        /// <param name="OutsideVendor">OutsideVendor.</param>
        /// <param name="PickNo">PickNo.</param>
        /// <param name="RequiresProductionLot">RequiresProductionLot.</param>
        /// <param name="Sector">Sector.</param>
        /// <param name="ExtrinsicText1">ExtrinsicText1.</param>
        /// <param name="ExtrinsicText2">ExtrinsicText2.</param>
        /// <param name="ExtrinsicText3">ExtrinsicText3.</param>
        /// <param name="ExtrinsicNumber1">ExtrinsicNumber1.</param>
        /// <param name="ExtrinsicNumber2">ExtrinsicNumber2.</param>
        /// <param name="ExtrinsicDecimal1">ExtrinsicDecimal1.</param>
        /// <param name="ExtrinsicDecimal2">ExtrinsicDecimal2.</param>
        /// <param name="CasebreakEnabled">CasebreakEnabled.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public WorkActivity(int? LobId = null, int? UserId = null, string Email = null, string Type = null, string TypeName = null, string Status = null, string StatusName = null, int? WorkBatchId = null, int? PriorityCode = null, int? SourceWarehouseId = null, string SourceWarehouseName = null, string SourceLocation = null, int? SourceBuildingId = null, string SourceBuildingName = null, int? SourceZoneId = null, string SourceZoneName = null, int? SourceAisleId = null, string SourceAisleAddress = null, string SourceOriginName = null, int? SourceBillingTypeId = null, string SourceBillingTypeName = null, string SourceBehaviorType = null, string SourceBehaviorTypeName = null, int? SourceFootprintId = null, string SourceFootprintName = null, int? SourceAddressSchemeId = null, string SourceAddressSchemeName = null, int? SourceLevel = null, int? SourceBay = null, int? SourceNumber = null, bool? SourceOnline = null, int? SourcePriorityCode = null, int? SourceCost = null, bool? SourceAllowItemMixing = null, int? DestinationWarehouseId = null, string DestinationWarehouseName = null, string DestinationLocation = null, int? DestinationBuildingId = null, string DestinationBuildingName = null, int? DestinationZoneId = null, string DestinationZoneName = null, int? DestinationAisleId = null, string DestinationAisleAddress = null, string DestinationOriginName = null, int? DestinationBillingTypeId = null, string DestinationBillingTypeName = null, string DestinationBehaviorType = null, string DestinationBehaviorTypeName = null, int? DestinationFootprintId = null, string DestinationFootprintName = null, int? DestinationAddressSchemeId = null, string DestinationAddressSchemeName = null, int? DestinationLevel = null, int? DestinationBay = null, int? DestinationNumber = null, bool? DestinationOnline = null, int? DestinationPriorityCode = null, int? DestinationCost = null, bool? DestinationAllowItemMixing = null, double? WeightPerWrap = null, string Sku = null, int? NumericSortOrder = null, string ItemDescription = null, string AdditionalDescription = null, string UnitCode = null, string WrapCode = null, int? UnitsPerWrap = null, string ClassRestriction = null, int? MaxCycle = null, int? MaxInterim = null, string SeasonalItem = null, string Secure = null, int? ProductType = null, string ItemStatus = null, int? OverallLeadTime = null, int? OverallFixedReorderPoint = null, string QualityControlIndicator = null, string LotControlFlag = null, string ProductCodeFlag = null, string ChargeCode = null, string PodRevDate = null, int? PodOrderSuffix = null, string SerialCode = null, string AssetCode = null, string Backorder = null, string AbsoluteMax = null, int? AccountCodeId = null, int? SummaryCodeId = null, int? LowStockContactId = null, int? LegacyLowLevelContactId = null, int? LowStockCodeId = null, int? MajorGroupId = null, int? SubGroupId = null, int? ProductCodeId = null, int? BuyerId = null, string VendorSKU = null, string Upc = null, string PackingSlipDescription = null, string CommodityCode = null, int? CompCode = null, int? CriticalAmount = null, double? ListPrice = null, int? OutsideVendor = null, string PickNo = null, string RequiresProductionLot = null, string Sector = null, string ExtrinsicText1 = null, string ExtrinsicText2 = null, string ExtrinsicText3 = null, int? ExtrinsicNumber1 = null, int? ExtrinsicNumber2 = null, double? ExtrinsicDecimal1 = null, double? ExtrinsicDecimal2 = null, string CasebreakEnabled = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "TypeName" is required (not null)
            if (TypeName == null)
            {
                throw new InvalidDataException("TypeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.TypeName = TypeName;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "StatusName" is required (not null)
            if (StatusName == null)
            {
                throw new InvalidDataException("StatusName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.StatusName = StatusName;
            }
            // to ensure "PriorityCode" is required (not null)
            if (PriorityCode == null)
            {
                throw new InvalidDataException("PriorityCode is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.PriorityCode = PriorityCode;
            }
            // to ensure "SourceWarehouseId" is required (not null)
            if (SourceWarehouseId == null)
            {
                throw new InvalidDataException("SourceWarehouseId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceWarehouseId = SourceWarehouseId;
            }
            // to ensure "SourceWarehouseName" is required (not null)
            if (SourceWarehouseName == null)
            {
                throw new InvalidDataException("SourceWarehouseName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceWarehouseName = SourceWarehouseName;
            }
            // to ensure "SourceLocation" is required (not null)
            if (SourceLocation == null)
            {
                throw new InvalidDataException("SourceLocation is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceLocation = SourceLocation;
            }
            // to ensure "SourceBuildingId" is required (not null)
            if (SourceBuildingId == null)
            {
                throw new InvalidDataException("SourceBuildingId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceBuildingId = SourceBuildingId;
            }
            // to ensure "SourceBuildingName" is required (not null)
            if (SourceBuildingName == null)
            {
                throw new InvalidDataException("SourceBuildingName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceBuildingName = SourceBuildingName;
            }
            // to ensure "SourceZoneName" is required (not null)
            if (SourceZoneName == null)
            {
                throw new InvalidDataException("SourceZoneName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceZoneName = SourceZoneName;
            }
            // to ensure "SourceAisleAddress" is required (not null)
            if (SourceAisleAddress == null)
            {
                throw new InvalidDataException("SourceAisleAddress is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceAisleAddress = SourceAisleAddress;
            }
            // to ensure "SourceOriginName" is required (not null)
            if (SourceOriginName == null)
            {
                throw new InvalidDataException("SourceOriginName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceOriginName = SourceOriginName;
            }
            // to ensure "SourceBillingTypeId" is required (not null)
            if (SourceBillingTypeId == null)
            {
                throw new InvalidDataException("SourceBillingTypeId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceBillingTypeId = SourceBillingTypeId;
            }
            // to ensure "SourceBillingTypeName" is required (not null)
            if (SourceBillingTypeName == null)
            {
                throw new InvalidDataException("SourceBillingTypeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceBillingTypeName = SourceBillingTypeName;
            }
            // to ensure "SourceBehaviorType" is required (not null)
            if (SourceBehaviorType == null)
            {
                throw new InvalidDataException("SourceBehaviorType is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceBehaviorType = SourceBehaviorType;
            }
            // to ensure "SourceBehaviorTypeName" is required (not null)
            if (SourceBehaviorTypeName == null)
            {
                throw new InvalidDataException("SourceBehaviorTypeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceBehaviorTypeName = SourceBehaviorTypeName;
            }
            // to ensure "SourceFootprintId" is required (not null)
            if (SourceFootprintId == null)
            {
                throw new InvalidDataException("SourceFootprintId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceFootprintId = SourceFootprintId;
            }
            // to ensure "SourceFootprintName" is required (not null)
            if (SourceFootprintName == null)
            {
                throw new InvalidDataException("SourceFootprintName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceFootprintName = SourceFootprintName;
            }
            // to ensure "SourceAddressSchemeName" is required (not null)
            if (SourceAddressSchemeName == null)
            {
                throw new InvalidDataException("SourceAddressSchemeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceAddressSchemeName = SourceAddressSchemeName;
            }
            // to ensure "SourceOnline" is required (not null)
            if (SourceOnline == null)
            {
                throw new InvalidDataException("SourceOnline is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceOnline = SourceOnline;
            }
            // to ensure "SourceAllowItemMixing" is required (not null)
            if (SourceAllowItemMixing == null)
            {
                throw new InvalidDataException("SourceAllowItemMixing is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SourceAllowItemMixing = SourceAllowItemMixing;
            }
            // to ensure "DestinationWarehouseId" is required (not null)
            if (DestinationWarehouseId == null)
            {
                throw new InvalidDataException("DestinationWarehouseId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationWarehouseId = DestinationWarehouseId;
            }
            // to ensure "DestinationWarehouseName" is required (not null)
            if (DestinationWarehouseName == null)
            {
                throw new InvalidDataException("DestinationWarehouseName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationWarehouseName = DestinationWarehouseName;
            }
            // to ensure "DestinationLocation" is required (not null)
            if (DestinationLocation == null)
            {
                throw new InvalidDataException("DestinationLocation is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationLocation = DestinationLocation;
            }
            // to ensure "DestinationBuildingId" is required (not null)
            if (DestinationBuildingId == null)
            {
                throw new InvalidDataException("DestinationBuildingId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationBuildingId = DestinationBuildingId;
            }
            // to ensure "DestinationBuildingName" is required (not null)
            if (DestinationBuildingName == null)
            {
                throw new InvalidDataException("DestinationBuildingName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationBuildingName = DestinationBuildingName;
            }
            // to ensure "DestinationZoneName" is required (not null)
            if (DestinationZoneName == null)
            {
                throw new InvalidDataException("DestinationZoneName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationZoneName = DestinationZoneName;
            }
            // to ensure "DestinationAisleAddress" is required (not null)
            if (DestinationAisleAddress == null)
            {
                throw new InvalidDataException("DestinationAisleAddress is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationAisleAddress = DestinationAisleAddress;
            }
            // to ensure "DestinationOriginName" is required (not null)
            if (DestinationOriginName == null)
            {
                throw new InvalidDataException("DestinationOriginName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationOriginName = DestinationOriginName;
            }
            // to ensure "DestinationBillingTypeId" is required (not null)
            if (DestinationBillingTypeId == null)
            {
                throw new InvalidDataException("DestinationBillingTypeId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationBillingTypeId = DestinationBillingTypeId;
            }
            // to ensure "DestinationBillingTypeName" is required (not null)
            if (DestinationBillingTypeName == null)
            {
                throw new InvalidDataException("DestinationBillingTypeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationBillingTypeName = DestinationBillingTypeName;
            }
            // to ensure "DestinationBehaviorType" is required (not null)
            if (DestinationBehaviorType == null)
            {
                throw new InvalidDataException("DestinationBehaviorType is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationBehaviorType = DestinationBehaviorType;
            }
            // to ensure "DestinationBehaviorTypeName" is required (not null)
            if (DestinationBehaviorTypeName == null)
            {
                throw new InvalidDataException("DestinationBehaviorTypeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationBehaviorTypeName = DestinationBehaviorTypeName;
            }
            // to ensure "DestinationFootprintId" is required (not null)
            if (DestinationFootprintId == null)
            {
                throw new InvalidDataException("DestinationFootprintId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationFootprintId = DestinationFootprintId;
            }
            // to ensure "DestinationFootprintName" is required (not null)
            if (DestinationFootprintName == null)
            {
                throw new InvalidDataException("DestinationFootprintName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationFootprintName = DestinationFootprintName;
            }
            // to ensure "DestinationAddressSchemeName" is required (not null)
            if (DestinationAddressSchemeName == null)
            {
                throw new InvalidDataException("DestinationAddressSchemeName is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationAddressSchemeName = DestinationAddressSchemeName;
            }
            // to ensure "DestinationOnline" is required (not null)
            if (DestinationOnline == null)
            {
                throw new InvalidDataException("DestinationOnline is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationOnline = DestinationOnline;
            }
            // to ensure "DestinationAllowItemMixing" is required (not null)
            if (DestinationAllowItemMixing == null)
            {
                throw new InvalidDataException("DestinationAllowItemMixing is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.DestinationAllowItemMixing = DestinationAllowItemMixing;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "ItemDescription" is required (not null)
            if (ItemDescription == null)
            {
                throw new InvalidDataException("ItemDescription is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.ItemDescription = ItemDescription;
            }
            // to ensure "UnitCode" is required (not null)
            if (UnitCode == null)
            {
                throw new InvalidDataException("UnitCode is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.UnitCode = UnitCode;
            }
            // to ensure "WrapCode" is required (not null)
            if (WrapCode == null)
            {
                throw new InvalidDataException("WrapCode is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.WrapCode = WrapCode;
            }
            // to ensure "UnitsPerWrap" is required (not null)
            if (UnitsPerWrap == null)
            {
                throw new InvalidDataException("UnitsPerWrap is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.UnitsPerWrap = UnitsPerWrap;
            }
            // to ensure "ClassRestriction" is required (not null)
            if (ClassRestriction == null)
            {
                throw new InvalidDataException("ClassRestriction is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.ClassRestriction = ClassRestriction;
            }
            // to ensure "MaxCycle" is required (not null)
            if (MaxCycle == null)
            {
                throw new InvalidDataException("MaxCycle is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.MaxCycle = MaxCycle;
            }
            // to ensure "MaxInterim" is required (not null)
            if (MaxInterim == null)
            {
                throw new InvalidDataException("MaxInterim is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.MaxInterim = MaxInterim;
            }
            // to ensure "SeasonalItem" is required (not null)
            if (SeasonalItem == null)
            {
                throw new InvalidDataException("SeasonalItem is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SeasonalItem = SeasonalItem;
            }
            // to ensure "Secure" is required (not null)
            if (Secure == null)
            {
                throw new InvalidDataException("Secure is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.Secure = Secure;
            }
            // to ensure "ItemStatus" is required (not null)
            if (ItemStatus == null)
            {
                throw new InvalidDataException("ItemStatus is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.ItemStatus = ItemStatus;
            }
            // to ensure "QualityControlIndicator" is required (not null)
            if (QualityControlIndicator == null)
            {
                throw new InvalidDataException("QualityControlIndicator is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.QualityControlIndicator = QualityControlIndicator;
            }
            // to ensure "ProductCodeFlag" is required (not null)
            if (ProductCodeFlag == null)
            {
                throw new InvalidDataException("ProductCodeFlag is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.ProductCodeFlag = ProductCodeFlag;
            }
            // to ensure "ChargeCode" is required (not null)
            if (ChargeCode == null)
            {
                throw new InvalidDataException("ChargeCode is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.ChargeCode = ChargeCode;
            }
            // to ensure "SerialCode" is required (not null)
            if (SerialCode == null)
            {
                throw new InvalidDataException("SerialCode is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SerialCode = SerialCode;
            }
            // to ensure "Backorder" is required (not null)
            if (Backorder == null)
            {
                throw new InvalidDataException("Backorder is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.Backorder = Backorder;
            }
            // to ensure "MajorGroupId" is required (not null)
            if (MajorGroupId == null)
            {
                throw new InvalidDataException("MajorGroupId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.MajorGroupId = MajorGroupId;
            }
            // to ensure "SubGroupId" is required (not null)
            if (SubGroupId == null)
            {
                throw new InvalidDataException("SubGroupId is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.SubGroupId = SubGroupId;
            }
            // to ensure "CriticalAmount" is required (not null)
            if (CriticalAmount == null)
            {
                throw new InvalidDataException("CriticalAmount is a required property for WorkActivity and cannot be null");
            }
            else
            {
                this.CriticalAmount = CriticalAmount;
            }
            this.WorkBatchId = WorkBatchId;
            this.SourceZoneId = SourceZoneId;
            this.SourceAisleId = SourceAisleId;
            this.SourceAddressSchemeId = SourceAddressSchemeId;
            this.SourceLevel = SourceLevel;
            this.SourceBay = SourceBay;
            this.SourceNumber = SourceNumber;
            this.SourcePriorityCode = SourcePriorityCode;
            this.SourceCost = SourceCost;
            this.DestinationZoneId = DestinationZoneId;
            this.DestinationAisleId = DestinationAisleId;
            this.DestinationAddressSchemeId = DestinationAddressSchemeId;
            this.DestinationLevel = DestinationLevel;
            this.DestinationBay = DestinationBay;
            this.DestinationNumber = DestinationNumber;
            this.DestinationPriorityCode = DestinationPriorityCode;
            this.DestinationCost = DestinationCost;
            this.WeightPerWrap = WeightPerWrap;
            this.NumericSortOrder = NumericSortOrder;
            this.AdditionalDescription = AdditionalDescription;
            this.ProductType = ProductType;
            this.OverallLeadTime = OverallLeadTime;
            this.OverallFixedReorderPoint = OverallFixedReorderPoint;
            this.LotControlFlag = LotControlFlag;
            this.PodRevDate = PodRevDate;
            this.PodOrderSuffix = PodOrderSuffix;
            this.AssetCode = AssetCode;
            this.AbsoluteMax = AbsoluteMax;
            this.AccountCodeId = AccountCodeId;
            this.SummaryCodeId = SummaryCodeId;
            this.LowStockContactId = LowStockContactId;
            this.LegacyLowLevelContactId = LegacyLowLevelContactId;
            this.LowStockCodeId = LowStockCodeId;
            this.ProductCodeId = ProductCodeId;
            this.BuyerId = BuyerId;
            this.VendorSKU = VendorSKU;
            this.Upc = Upc;
            this.PackingSlipDescription = PackingSlipDescription;
            this.CommodityCode = CommodityCode;
            this.CompCode = CompCode;
            this.ListPrice = ListPrice;
            this.OutsideVendor = OutsideVendor;
            this.PickNo = PickNo;
            this.RequiresProductionLot = RequiresProductionLot;
            this.Sector = Sector;
            this.ExtrinsicText1 = ExtrinsicText1;
            this.ExtrinsicText2 = ExtrinsicText2;
            this.ExtrinsicText3 = ExtrinsicText3;
            this.ExtrinsicNumber1 = ExtrinsicNumber1;
            this.ExtrinsicNumber2 = ExtrinsicNumber2;
            this.ExtrinsicDecimal1 = ExtrinsicDecimal1;
            this.ExtrinsicDecimal2 = ExtrinsicDecimal2;
            this.CasebreakEnabled = CasebreakEnabled;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets ImportedRecordId
        /// </summary>
        [DataMember(Name="importedRecordId", EmitDefaultValue=false)]
        public int? ImportedRecordId { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
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
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets TypeName
        /// </summary>
        [DataMember(Name="typeName", EmitDefaultValue=false)]
        public string TypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusName
        /// </summary>
        [DataMember(Name="statusName", EmitDefaultValue=false)]
        public string StatusName { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkParentId
        /// </summary>
        [DataMember(Name="workParentId", EmitDefaultValue=false)]
        public int? WorkParentId { get; private set; }
    
        /// <summary>
        /// Gets or Sets PriorityCode
        /// </summary>
        [DataMember(Name="priorityCode", EmitDefaultValue=false)]
        public int? PriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ForeignId
        /// </summary>
        [DataMember(Name="foreignId", EmitDefaultValue=false)]
        public int? ForeignId { get; private set; }
    
        /// <summary>
        /// Gets or Sets SourceWarehouseId
        /// </summary>
        [DataMember(Name="sourceWarehouseId", EmitDefaultValue=false)]
        public int? SourceWarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceWarehouseName
        /// </summary>
        [DataMember(Name="sourceWarehouseName", EmitDefaultValue=false)]
        public string SourceWarehouseName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceLocation
        /// </summary>
        [DataMember(Name="sourceLocation", EmitDefaultValue=false)]
        public string SourceLocation { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBuildingId
        /// </summary>
        [DataMember(Name="sourceBuildingId", EmitDefaultValue=false)]
        public int? SourceBuildingId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBuildingName
        /// </summary>
        [DataMember(Name="sourceBuildingName", EmitDefaultValue=false)]
        public string SourceBuildingName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceZoneId
        /// </summary>
        [DataMember(Name="sourceZoneId", EmitDefaultValue=false)]
        public int? SourceZoneId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceZoneName
        /// </summary>
        [DataMember(Name="sourceZoneName", EmitDefaultValue=false)]
        public string SourceZoneName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceAisleId
        /// </summary>
        [DataMember(Name="sourceAisleId", EmitDefaultValue=false)]
        public int? SourceAisleId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceAisleAddress
        /// </summary>
        [DataMember(Name="sourceAisleAddress", EmitDefaultValue=false)]
        public string SourceAisleAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceOrigin
        /// </summary>
        [DataMember(Name="sourceOrigin", EmitDefaultValue=false)]
        public int? SourceOrigin { get; private set; }
    
        /// <summary>
        /// Gets or Sets SourceOriginName
        /// </summary>
        [DataMember(Name="sourceOriginName", EmitDefaultValue=false)]
        public string SourceOriginName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBillingTypeId
        /// </summary>
        [DataMember(Name="sourceBillingTypeId", EmitDefaultValue=false)]
        public int? SourceBillingTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBillingTypeName
        /// </summary>
        [DataMember(Name="sourceBillingTypeName", EmitDefaultValue=false)]
        public string SourceBillingTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBehaviorType
        /// </summary>
        [DataMember(Name="sourceBehaviorType", EmitDefaultValue=false)]
        public string SourceBehaviorType { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBehaviorTypeName
        /// </summary>
        [DataMember(Name="sourceBehaviorTypeName", EmitDefaultValue=false)]
        public string SourceBehaviorTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceFootprintId
        /// </summary>
        [DataMember(Name="sourceFootprintId", EmitDefaultValue=false)]
        public int? SourceFootprintId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceFootprintName
        /// </summary>
        [DataMember(Name="sourceFootprintName", EmitDefaultValue=false)]
        public string SourceFootprintName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceFootprintHeight
        /// </summary>
        [DataMember(Name="sourceFootprintHeight", EmitDefaultValue=false)]
        public int? SourceFootprintHeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets SourceFootprintWidth
        /// </summary>
        [DataMember(Name="sourceFootprintWidth", EmitDefaultValue=false)]
        public int? SourceFootprintWidth { get; private set; }
    
        /// <summary>
        /// Gets or Sets SourceFootprintDepth
        /// </summary>
        [DataMember(Name="sourceFootprintDepth", EmitDefaultValue=false)]
        public int? SourceFootprintDepth { get; private set; }
    
        /// <summary>
        /// Gets or Sets SourceAddressSchemeId
        /// </summary>
        [DataMember(Name="sourceAddressSchemeId", EmitDefaultValue=false)]
        public int? SourceAddressSchemeId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceAddressSchemeName
        /// </summary>
        [DataMember(Name="sourceAddressSchemeName", EmitDefaultValue=false)]
        public string SourceAddressSchemeName { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceLevel
        /// </summary>
        [DataMember(Name="sourceLevel", EmitDefaultValue=false)]
        public int? SourceLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBay
        /// </summary>
        [DataMember(Name="sourceBay", EmitDefaultValue=false)]
        public int? SourceBay { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceNumber
        /// </summary>
        [DataMember(Name="sourceNumber", EmitDefaultValue=false)]
        public int? SourceNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceOnline
        /// </summary>
        [DataMember(Name="sourceOnline", EmitDefaultValue=false)]
        public bool? SourceOnline { get; set; }
    
        /// <summary>
        /// Gets or Sets SourcePriorityCode
        /// </summary>
        [DataMember(Name="sourcePriorityCode", EmitDefaultValue=false)]
        public int? SourcePriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceCost
        /// </summary>
        [DataMember(Name="sourceCost", EmitDefaultValue=false)]
        public int? SourceCost { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceAllowItemMixing
        /// </summary>
        [DataMember(Name="sourceAllowItemMixing", EmitDefaultValue=false)]
        public bool? SourceAllowItemMixing { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationWarehouseId
        /// </summary>
        [DataMember(Name="destinationWarehouseId", EmitDefaultValue=false)]
        public int? DestinationWarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationWarehouseName
        /// </summary>
        [DataMember(Name="destinationWarehouseName", EmitDefaultValue=false)]
        public string DestinationWarehouseName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationLocation
        /// </summary>
        [DataMember(Name="destinationLocation", EmitDefaultValue=false)]
        public string DestinationLocation { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBuildingId
        /// </summary>
        [DataMember(Name="destinationBuildingId", EmitDefaultValue=false)]
        public int? DestinationBuildingId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBuildingName
        /// </summary>
        [DataMember(Name="destinationBuildingName", EmitDefaultValue=false)]
        public string DestinationBuildingName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationZoneId
        /// </summary>
        [DataMember(Name="destinationZoneId", EmitDefaultValue=false)]
        public int? DestinationZoneId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationZoneName
        /// </summary>
        [DataMember(Name="destinationZoneName", EmitDefaultValue=false)]
        public string DestinationZoneName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationAisleId
        /// </summary>
        [DataMember(Name="destinationAisleId", EmitDefaultValue=false)]
        public int? DestinationAisleId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationAisleAddress
        /// </summary>
        [DataMember(Name="destinationAisleAddress", EmitDefaultValue=false)]
        public string DestinationAisleAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationOrigin
        /// </summary>
        [DataMember(Name="destinationOrigin", EmitDefaultValue=false)]
        public int? DestinationOrigin { get; private set; }
    
        /// <summary>
        /// Gets or Sets DestinationOriginName
        /// </summary>
        [DataMember(Name="destinationOriginName", EmitDefaultValue=false)]
        public string DestinationOriginName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBillingTypeId
        /// </summary>
        [DataMember(Name="destinationBillingTypeId", EmitDefaultValue=false)]
        public int? DestinationBillingTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBillingTypeName
        /// </summary>
        [DataMember(Name="destinationBillingTypeName", EmitDefaultValue=false)]
        public string DestinationBillingTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBehaviorType
        /// </summary>
        [DataMember(Name="destinationBehaviorType", EmitDefaultValue=false)]
        public string DestinationBehaviorType { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBehaviorTypeName
        /// </summary>
        [DataMember(Name="destinationBehaviorTypeName", EmitDefaultValue=false)]
        public string DestinationBehaviorTypeName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationFootprintId
        /// </summary>
        [DataMember(Name="destinationFootprintId", EmitDefaultValue=false)]
        public int? DestinationFootprintId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationFootprintName
        /// </summary>
        [DataMember(Name="destinationFootprintName", EmitDefaultValue=false)]
        public string DestinationFootprintName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationFootprintHeight
        /// </summary>
        [DataMember(Name="destinationFootprintHeight", EmitDefaultValue=false)]
        public int? DestinationFootprintHeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets DestinationFootprintWidth
        /// </summary>
        [DataMember(Name="destinationFootprintWidth", EmitDefaultValue=false)]
        public int? DestinationFootprintWidth { get; private set; }
    
        /// <summary>
        /// Gets or Sets DestinationFootprintDepth
        /// </summary>
        [DataMember(Name="destinationFootprintDepth", EmitDefaultValue=false)]
        public int? DestinationFootprintDepth { get; private set; }
    
        /// <summary>
        /// Gets or Sets DestinationAddressSchemeId
        /// </summary>
        [DataMember(Name="destinationAddressSchemeId", EmitDefaultValue=false)]
        public int? DestinationAddressSchemeId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationAddressSchemeName
        /// </summary>
        [DataMember(Name="destinationAddressSchemeName", EmitDefaultValue=false)]
        public string DestinationAddressSchemeName { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationLevel
        /// </summary>
        [DataMember(Name="destinationLevel", EmitDefaultValue=false)]
        public int? DestinationLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBay
        /// </summary>
        [DataMember(Name="destinationBay", EmitDefaultValue=false)]
        public int? DestinationBay { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationNumber
        /// </summary>
        [DataMember(Name="destinationNumber", EmitDefaultValue=false)]
        public int? DestinationNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationOnline
        /// </summary>
        [DataMember(Name="destinationOnline", EmitDefaultValue=false)]
        public bool? DestinationOnline { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationPriorityCode
        /// </summary>
        [DataMember(Name="destinationPriorityCode", EmitDefaultValue=false)]
        public int? DestinationPriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationCost
        /// </summary>
        [DataMember(Name="destinationCost", EmitDefaultValue=false)]
        public int? DestinationCost { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationAllowItemMixing
        /// </summary>
        [DataMember(Name="destinationAllowItemMixing", EmitDefaultValue=false)]
        public bool? DestinationAllowItemMixing { get; set; }
    
        /// <summary>
        /// Gets or Sets MasterRef
        /// </summary>
        [DataMember(Name="masterRef", EmitDefaultValue=false)]
        public int? MasterRef { get; private set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets NumericSortOrder
        /// </summary>
        [DataMember(Name="numericSortOrder", EmitDefaultValue=false)]
        public int? NumericSortOrder { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="itemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalDescription
        /// </summary>
        [DataMember(Name="additionalDescription", EmitDefaultValue=false)]
        public string AdditionalDescription { get; set; }
    
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
        /// Gets or Sets ClassRestriction
        /// </summary>
        [DataMember(Name="classRestriction", EmitDefaultValue=false)]
        public string ClassRestriction { get; set; }
    
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
        /// Gets or Sets SeasonalItem
        /// </summary>
        [DataMember(Name="seasonalItem", EmitDefaultValue=false)]
        public string SeasonalItem { get; set; }
    
        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public string Secure { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public int? ProductType { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemStatus
        /// </summary>
        [DataMember(Name="itemStatus", EmitDefaultValue=false)]
        public string ItemStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets OverallLeadTime
        /// </summary>
        [DataMember(Name="overallLeadTime", EmitDefaultValue=false)]
        public int? OverallLeadTime { get; set; }
    
        /// <summary>
        /// Gets or Sets OverallFixedReorderPoint
        /// </summary>
        [DataMember(Name="overallFixedReorderPoint", EmitDefaultValue=false)]
        public int? OverallFixedReorderPoint { get; set; }
    
        /// <summary>
        /// Gets or Sets QualityControlIndicator
        /// </summary>
        [DataMember(Name="qualityControlIndicator", EmitDefaultValue=false)]
        public string QualityControlIndicator { get; set; }
    
        /// <summary>
        /// Gets or Sets LotControlFlag
        /// </summary>
        [DataMember(Name="lotControlFlag", EmitDefaultValue=false)]
        public string LotControlFlag { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductCodeFlag
        /// </summary>
        [DataMember(Name="productCodeFlag", EmitDefaultValue=false)]
        public string ProductCodeFlag { get; set; }
    
        /// <summary>
        /// Gets or Sets ChargeCode
        /// </summary>
        [DataMember(Name="chargeCode", EmitDefaultValue=false)]
        public string ChargeCode { get; set; }
    
        /// <summary>
        /// Gets or Sets PodRevDate
        /// </summary>
        [DataMember(Name="podRevDate", EmitDefaultValue=false)]
        public string PodRevDate { get; set; }
    
        /// <summary>
        /// Gets or Sets PodOrderSuffix
        /// </summary>
        [DataMember(Name="podOrderSuffix", EmitDefaultValue=false)]
        public int? PodOrderSuffix { get; set; }
    
        /// <summary>
        /// Gets or Sets SerialCode
        /// </summary>
        [DataMember(Name="serialCode", EmitDefaultValue=false)]
        public string SerialCode { get; set; }
    
        /// <summary>
        /// Gets or Sets AssetCode
        /// </summary>
        [DataMember(Name="assetCode", EmitDefaultValue=false)]
        public string AssetCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Backorder
        /// </summary>
        [DataMember(Name="backorder", EmitDefaultValue=false)]
        public string Backorder { get; set; }
    
        /// <summary>
        /// Gets or Sets AbsoluteMax
        /// </summary>
        [DataMember(Name="absoluteMax", EmitDefaultValue=false)]
        public string AbsoluteMax { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountCodeId
        /// </summary>
        [DataMember(Name="accountCodeId", EmitDefaultValue=false)]
        public int? AccountCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets SummaryCodeId
        /// </summary>
        [DataMember(Name="summaryCodeId", EmitDefaultValue=false)]
        public int? SummaryCodeId { get; set; }
    
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
        /// Gets or Sets BuyerId
        /// </summary>
        [DataMember(Name="buyerId", EmitDefaultValue=false)]
        public int? BuyerId { get; set; }
    
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
        /// Gets or Sets PackingSlipDescription
        /// </summary>
        [DataMember(Name="packingSlipDescription", EmitDefaultValue=false)]
        public string PackingSlipDescription { get; set; }
    
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
        /// Gets or Sets CriticalAmount
        /// </summary>
        [DataMember(Name="criticalAmount", EmitDefaultValue=false)]
        public int? CriticalAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets ListPrice
        /// </summary>
        [DataMember(Name="listPrice", EmitDefaultValue=false)]
        public double? ListPrice { get; set; }
    
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
        /// Gets or Sets VoidDate
        /// </summary>
        [DataMember(Name="voidDate", EmitDefaultValue=false)]
        public DateTime? VoidDate { get; private set; }
    
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
            sb.Append("class WorkActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImportedRecordId: ").Append(ImportedRecordId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusName: ").Append(StatusName).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
            sb.Append("  WorkParentId: ").Append(WorkParentId).Append("\n");
            sb.Append("  PriorityCode: ").Append(PriorityCode).Append("\n");
            sb.Append("  ForeignId: ").Append(ForeignId).Append("\n");
            sb.Append("  SourceWarehouseId: ").Append(SourceWarehouseId).Append("\n");
            sb.Append("  SourceWarehouseName: ").Append(SourceWarehouseName).Append("\n");
            sb.Append("  SourceLocation: ").Append(SourceLocation).Append("\n");
            sb.Append("  SourceBuildingId: ").Append(SourceBuildingId).Append("\n");
            sb.Append("  SourceBuildingName: ").Append(SourceBuildingName).Append("\n");
            sb.Append("  SourceZoneId: ").Append(SourceZoneId).Append("\n");
            sb.Append("  SourceZoneName: ").Append(SourceZoneName).Append("\n");
            sb.Append("  SourceAisleId: ").Append(SourceAisleId).Append("\n");
            sb.Append("  SourceAisleAddress: ").Append(SourceAisleAddress).Append("\n");
            sb.Append("  SourceOrigin: ").Append(SourceOrigin).Append("\n");
            sb.Append("  SourceOriginName: ").Append(SourceOriginName).Append("\n");
            sb.Append("  SourceBillingTypeId: ").Append(SourceBillingTypeId).Append("\n");
            sb.Append("  SourceBillingTypeName: ").Append(SourceBillingTypeName).Append("\n");
            sb.Append("  SourceBehaviorType: ").Append(SourceBehaviorType).Append("\n");
            sb.Append("  SourceBehaviorTypeName: ").Append(SourceBehaviorTypeName).Append("\n");
            sb.Append("  SourceFootprintId: ").Append(SourceFootprintId).Append("\n");
            sb.Append("  SourceFootprintName: ").Append(SourceFootprintName).Append("\n");
            sb.Append("  SourceFootprintHeight: ").Append(SourceFootprintHeight).Append("\n");
            sb.Append("  SourceFootprintWidth: ").Append(SourceFootprintWidth).Append("\n");
            sb.Append("  SourceFootprintDepth: ").Append(SourceFootprintDepth).Append("\n");
            sb.Append("  SourceAddressSchemeId: ").Append(SourceAddressSchemeId).Append("\n");
            sb.Append("  SourceAddressSchemeName: ").Append(SourceAddressSchemeName).Append("\n");
            sb.Append("  SourceLevel: ").Append(SourceLevel).Append("\n");
            sb.Append("  SourceBay: ").Append(SourceBay).Append("\n");
            sb.Append("  SourceNumber: ").Append(SourceNumber).Append("\n");
            sb.Append("  SourceOnline: ").Append(SourceOnline).Append("\n");
            sb.Append("  SourcePriorityCode: ").Append(SourcePriorityCode).Append("\n");
            sb.Append("  SourceCost: ").Append(SourceCost).Append("\n");
            sb.Append("  SourceAllowItemMixing: ").Append(SourceAllowItemMixing).Append("\n");
            sb.Append("  DestinationWarehouseId: ").Append(DestinationWarehouseId).Append("\n");
            sb.Append("  DestinationWarehouseName: ").Append(DestinationWarehouseName).Append("\n");
            sb.Append("  DestinationLocation: ").Append(DestinationLocation).Append("\n");
            sb.Append("  DestinationBuildingId: ").Append(DestinationBuildingId).Append("\n");
            sb.Append("  DestinationBuildingName: ").Append(DestinationBuildingName).Append("\n");
            sb.Append("  DestinationZoneId: ").Append(DestinationZoneId).Append("\n");
            sb.Append("  DestinationZoneName: ").Append(DestinationZoneName).Append("\n");
            sb.Append("  DestinationAisleId: ").Append(DestinationAisleId).Append("\n");
            sb.Append("  DestinationAisleAddress: ").Append(DestinationAisleAddress).Append("\n");
            sb.Append("  DestinationOrigin: ").Append(DestinationOrigin).Append("\n");
            sb.Append("  DestinationOriginName: ").Append(DestinationOriginName).Append("\n");
            sb.Append("  DestinationBillingTypeId: ").Append(DestinationBillingTypeId).Append("\n");
            sb.Append("  DestinationBillingTypeName: ").Append(DestinationBillingTypeName).Append("\n");
            sb.Append("  DestinationBehaviorType: ").Append(DestinationBehaviorType).Append("\n");
            sb.Append("  DestinationBehaviorTypeName: ").Append(DestinationBehaviorTypeName).Append("\n");
            sb.Append("  DestinationFootprintId: ").Append(DestinationFootprintId).Append("\n");
            sb.Append("  DestinationFootprintName: ").Append(DestinationFootprintName).Append("\n");
            sb.Append("  DestinationFootprintHeight: ").Append(DestinationFootprintHeight).Append("\n");
            sb.Append("  DestinationFootprintWidth: ").Append(DestinationFootprintWidth).Append("\n");
            sb.Append("  DestinationFootprintDepth: ").Append(DestinationFootprintDepth).Append("\n");
            sb.Append("  DestinationAddressSchemeId: ").Append(DestinationAddressSchemeId).Append("\n");
            sb.Append("  DestinationAddressSchemeName: ").Append(DestinationAddressSchemeName).Append("\n");
            sb.Append("  DestinationLevel: ").Append(DestinationLevel).Append("\n");
            sb.Append("  DestinationBay: ").Append(DestinationBay).Append("\n");
            sb.Append("  DestinationNumber: ").Append(DestinationNumber).Append("\n");
            sb.Append("  DestinationOnline: ").Append(DestinationOnline).Append("\n");
            sb.Append("  DestinationPriorityCode: ").Append(DestinationPriorityCode).Append("\n");
            sb.Append("  DestinationCost: ").Append(DestinationCost).Append("\n");
            sb.Append("  DestinationAllowItemMixing: ").Append(DestinationAllowItemMixing).Append("\n");
            sb.Append("  MasterRef: ").Append(MasterRef).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  NumericSortOrder: ").Append(NumericSortOrder).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  AdditionalDescription: ").Append(AdditionalDescription).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  ClassRestriction: ").Append(ClassRestriction).Append("\n");
            sb.Append("  MaxCycle: ").Append(MaxCycle).Append("\n");
            sb.Append("  MaxInterim: ").Append(MaxInterim).Append("\n");
            sb.Append("  SeasonalItem: ").Append(SeasonalItem).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  ItemStatus: ").Append(ItemStatus).Append("\n");
            sb.Append("  OverallLeadTime: ").Append(OverallLeadTime).Append("\n");
            sb.Append("  OverallFixedReorderPoint: ").Append(OverallFixedReorderPoint).Append("\n");
            sb.Append("  QualityControlIndicator: ").Append(QualityControlIndicator).Append("\n");
            sb.Append("  LotControlFlag: ").Append(LotControlFlag).Append("\n");
            sb.Append("  ProductCodeFlag: ").Append(ProductCodeFlag).Append("\n");
            sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
            sb.Append("  PodRevDate: ").Append(PodRevDate).Append("\n");
            sb.Append("  PodOrderSuffix: ").Append(PodOrderSuffix).Append("\n");
            sb.Append("  SerialCode: ").Append(SerialCode).Append("\n");
            sb.Append("  AssetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  Backorder: ").Append(Backorder).Append("\n");
            sb.Append("  AbsoluteMax: ").Append(AbsoluteMax).Append("\n");
            sb.Append("  AccountCodeId: ").Append(AccountCodeId).Append("\n");
            sb.Append("  SummaryCodeId: ").Append(SummaryCodeId).Append("\n");
            sb.Append("  LowStockContactId: ").Append(LowStockContactId).Append("\n");
            sb.Append("  LegacyLowLevelContactId: ").Append(LegacyLowLevelContactId).Append("\n");
            sb.Append("  LowStockCodeId: ").Append(LowStockCodeId).Append("\n");
            sb.Append("  MajorGroupId: ").Append(MajorGroupId).Append("\n");
            sb.Append("  SubGroupId: ").Append(SubGroupId).Append("\n");
            sb.Append("  ProductCodeId: ").Append(ProductCodeId).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  PackingSlipDescription: ").Append(PackingSlipDescription).Append("\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  CompCode: ").Append(CompCode).Append("\n");
            sb.Append("  CriticalAmount: ").Append(CriticalAmount).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  OutsideVendor: ").Append(OutsideVendor).Append("\n");
            sb.Append("  PickNo: ").Append(PickNo).Append("\n");
            sb.Append("  RequiresProductionLot: ").Append(RequiresProductionLot).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  VoidDate: ").Append(VoidDate).Append("\n");
            sb.Append("  ExtrinsicText1: ").Append(ExtrinsicText1).Append("\n");
            sb.Append("  ExtrinsicText2: ").Append(ExtrinsicText2).Append("\n");
            sb.Append("  ExtrinsicText3: ").Append(ExtrinsicText3).Append("\n");
            sb.Append("  ExtrinsicNumber1: ").Append(ExtrinsicNumber1).Append("\n");
            sb.Append("  ExtrinsicNumber2: ").Append(ExtrinsicNumber2).Append("\n");
            sb.Append("  ExtrinsicDecimal1: ").Append(ExtrinsicDecimal1).Append("\n");
            sb.Append("  ExtrinsicDecimal2: ").Append(ExtrinsicDecimal2).Append("\n");
            sb.Append("  CasebreakEnabled: ").Append(CasebreakEnabled).Append("\n");
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
            return this.Equals(obj as WorkActivity);
        }

        /// <summary>
        /// Returns true if WorkActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkActivity other)
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
                    this.ImportedRecordId == other.ImportedRecordId ||
                    this.ImportedRecordId != null &&
                    this.ImportedRecordId.Equals(other.ImportedRecordId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.TypeName == other.TypeName ||
                    this.TypeName != null &&
                    this.TypeName.Equals(other.TypeName)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusName == other.StatusName ||
                    this.StatusName != null &&
                    this.StatusName.Equals(other.StatusName)
                ) && 
                (
                    this.WorkBatchId == other.WorkBatchId ||
                    this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(other.WorkBatchId)
                ) && 
                (
                    this.WorkParentId == other.WorkParentId ||
                    this.WorkParentId != null &&
                    this.WorkParentId.Equals(other.WorkParentId)
                ) && 
                (
                    this.PriorityCode == other.PriorityCode ||
                    this.PriorityCode != null &&
                    this.PriorityCode.Equals(other.PriorityCode)
                ) && 
                (
                    this.ForeignId == other.ForeignId ||
                    this.ForeignId != null &&
                    this.ForeignId.Equals(other.ForeignId)
                ) && 
                (
                    this.SourceWarehouseId == other.SourceWarehouseId ||
                    this.SourceWarehouseId != null &&
                    this.SourceWarehouseId.Equals(other.SourceWarehouseId)
                ) && 
                (
                    this.SourceWarehouseName == other.SourceWarehouseName ||
                    this.SourceWarehouseName != null &&
                    this.SourceWarehouseName.Equals(other.SourceWarehouseName)
                ) && 
                (
                    this.SourceLocation == other.SourceLocation ||
                    this.SourceLocation != null &&
                    this.SourceLocation.Equals(other.SourceLocation)
                ) && 
                (
                    this.SourceBuildingId == other.SourceBuildingId ||
                    this.SourceBuildingId != null &&
                    this.SourceBuildingId.Equals(other.SourceBuildingId)
                ) && 
                (
                    this.SourceBuildingName == other.SourceBuildingName ||
                    this.SourceBuildingName != null &&
                    this.SourceBuildingName.Equals(other.SourceBuildingName)
                ) && 
                (
                    this.SourceZoneId == other.SourceZoneId ||
                    this.SourceZoneId != null &&
                    this.SourceZoneId.Equals(other.SourceZoneId)
                ) && 
                (
                    this.SourceZoneName == other.SourceZoneName ||
                    this.SourceZoneName != null &&
                    this.SourceZoneName.Equals(other.SourceZoneName)
                ) && 
                (
                    this.SourceAisleId == other.SourceAisleId ||
                    this.SourceAisleId != null &&
                    this.SourceAisleId.Equals(other.SourceAisleId)
                ) && 
                (
                    this.SourceAisleAddress == other.SourceAisleAddress ||
                    this.SourceAisleAddress != null &&
                    this.SourceAisleAddress.Equals(other.SourceAisleAddress)
                ) && 
                (
                    this.SourceOrigin == other.SourceOrigin ||
                    this.SourceOrigin != null &&
                    this.SourceOrigin.Equals(other.SourceOrigin)
                ) && 
                (
                    this.SourceOriginName == other.SourceOriginName ||
                    this.SourceOriginName != null &&
                    this.SourceOriginName.Equals(other.SourceOriginName)
                ) && 
                (
                    this.SourceBillingTypeId == other.SourceBillingTypeId ||
                    this.SourceBillingTypeId != null &&
                    this.SourceBillingTypeId.Equals(other.SourceBillingTypeId)
                ) && 
                (
                    this.SourceBillingTypeName == other.SourceBillingTypeName ||
                    this.SourceBillingTypeName != null &&
                    this.SourceBillingTypeName.Equals(other.SourceBillingTypeName)
                ) && 
                (
                    this.SourceBehaviorType == other.SourceBehaviorType ||
                    this.SourceBehaviorType != null &&
                    this.SourceBehaviorType.Equals(other.SourceBehaviorType)
                ) && 
                (
                    this.SourceBehaviorTypeName == other.SourceBehaviorTypeName ||
                    this.SourceBehaviorTypeName != null &&
                    this.SourceBehaviorTypeName.Equals(other.SourceBehaviorTypeName)
                ) && 
                (
                    this.SourceFootprintId == other.SourceFootprintId ||
                    this.SourceFootprintId != null &&
                    this.SourceFootprintId.Equals(other.SourceFootprintId)
                ) && 
                (
                    this.SourceFootprintName == other.SourceFootprintName ||
                    this.SourceFootprintName != null &&
                    this.SourceFootprintName.Equals(other.SourceFootprintName)
                ) && 
                (
                    this.SourceFootprintHeight == other.SourceFootprintHeight ||
                    this.SourceFootprintHeight != null &&
                    this.SourceFootprintHeight.Equals(other.SourceFootprintHeight)
                ) && 
                (
                    this.SourceFootprintWidth == other.SourceFootprintWidth ||
                    this.SourceFootprintWidth != null &&
                    this.SourceFootprintWidth.Equals(other.SourceFootprintWidth)
                ) && 
                (
                    this.SourceFootprintDepth == other.SourceFootprintDepth ||
                    this.SourceFootprintDepth != null &&
                    this.SourceFootprintDepth.Equals(other.SourceFootprintDepth)
                ) && 
                (
                    this.SourceAddressSchemeId == other.SourceAddressSchemeId ||
                    this.SourceAddressSchemeId != null &&
                    this.SourceAddressSchemeId.Equals(other.SourceAddressSchemeId)
                ) && 
                (
                    this.SourceAddressSchemeName == other.SourceAddressSchemeName ||
                    this.SourceAddressSchemeName != null &&
                    this.SourceAddressSchemeName.Equals(other.SourceAddressSchemeName)
                ) && 
                (
                    this.SourceLevel == other.SourceLevel ||
                    this.SourceLevel != null &&
                    this.SourceLevel.Equals(other.SourceLevel)
                ) && 
                (
                    this.SourceBay == other.SourceBay ||
                    this.SourceBay != null &&
                    this.SourceBay.Equals(other.SourceBay)
                ) && 
                (
                    this.SourceNumber == other.SourceNumber ||
                    this.SourceNumber != null &&
                    this.SourceNumber.Equals(other.SourceNumber)
                ) && 
                (
                    this.SourceOnline == other.SourceOnline ||
                    this.SourceOnline != null &&
                    this.SourceOnline.Equals(other.SourceOnline)
                ) && 
                (
                    this.SourcePriorityCode == other.SourcePriorityCode ||
                    this.SourcePriorityCode != null &&
                    this.SourcePriorityCode.Equals(other.SourcePriorityCode)
                ) && 
                (
                    this.SourceCost == other.SourceCost ||
                    this.SourceCost != null &&
                    this.SourceCost.Equals(other.SourceCost)
                ) && 
                (
                    this.SourceAllowItemMixing == other.SourceAllowItemMixing ||
                    this.SourceAllowItemMixing != null &&
                    this.SourceAllowItemMixing.Equals(other.SourceAllowItemMixing)
                ) && 
                (
                    this.DestinationWarehouseId == other.DestinationWarehouseId ||
                    this.DestinationWarehouseId != null &&
                    this.DestinationWarehouseId.Equals(other.DestinationWarehouseId)
                ) && 
                (
                    this.DestinationWarehouseName == other.DestinationWarehouseName ||
                    this.DestinationWarehouseName != null &&
                    this.DestinationWarehouseName.Equals(other.DestinationWarehouseName)
                ) && 
                (
                    this.DestinationLocation == other.DestinationLocation ||
                    this.DestinationLocation != null &&
                    this.DestinationLocation.Equals(other.DestinationLocation)
                ) && 
                (
                    this.DestinationBuildingId == other.DestinationBuildingId ||
                    this.DestinationBuildingId != null &&
                    this.DestinationBuildingId.Equals(other.DestinationBuildingId)
                ) && 
                (
                    this.DestinationBuildingName == other.DestinationBuildingName ||
                    this.DestinationBuildingName != null &&
                    this.DestinationBuildingName.Equals(other.DestinationBuildingName)
                ) && 
                (
                    this.DestinationZoneId == other.DestinationZoneId ||
                    this.DestinationZoneId != null &&
                    this.DestinationZoneId.Equals(other.DestinationZoneId)
                ) && 
                (
                    this.DestinationZoneName == other.DestinationZoneName ||
                    this.DestinationZoneName != null &&
                    this.DestinationZoneName.Equals(other.DestinationZoneName)
                ) && 
                (
                    this.DestinationAisleId == other.DestinationAisleId ||
                    this.DestinationAisleId != null &&
                    this.DestinationAisleId.Equals(other.DestinationAisleId)
                ) && 
                (
                    this.DestinationAisleAddress == other.DestinationAisleAddress ||
                    this.DestinationAisleAddress != null &&
                    this.DestinationAisleAddress.Equals(other.DestinationAisleAddress)
                ) && 
                (
                    this.DestinationOrigin == other.DestinationOrigin ||
                    this.DestinationOrigin != null &&
                    this.DestinationOrigin.Equals(other.DestinationOrigin)
                ) && 
                (
                    this.DestinationOriginName == other.DestinationOriginName ||
                    this.DestinationOriginName != null &&
                    this.DestinationOriginName.Equals(other.DestinationOriginName)
                ) && 
                (
                    this.DestinationBillingTypeId == other.DestinationBillingTypeId ||
                    this.DestinationBillingTypeId != null &&
                    this.DestinationBillingTypeId.Equals(other.DestinationBillingTypeId)
                ) && 
                (
                    this.DestinationBillingTypeName == other.DestinationBillingTypeName ||
                    this.DestinationBillingTypeName != null &&
                    this.DestinationBillingTypeName.Equals(other.DestinationBillingTypeName)
                ) && 
                (
                    this.DestinationBehaviorType == other.DestinationBehaviorType ||
                    this.DestinationBehaviorType != null &&
                    this.DestinationBehaviorType.Equals(other.DestinationBehaviorType)
                ) && 
                (
                    this.DestinationBehaviorTypeName == other.DestinationBehaviorTypeName ||
                    this.DestinationBehaviorTypeName != null &&
                    this.DestinationBehaviorTypeName.Equals(other.DestinationBehaviorTypeName)
                ) && 
                (
                    this.DestinationFootprintId == other.DestinationFootprintId ||
                    this.DestinationFootprintId != null &&
                    this.DestinationFootprintId.Equals(other.DestinationFootprintId)
                ) && 
                (
                    this.DestinationFootprintName == other.DestinationFootprintName ||
                    this.DestinationFootprintName != null &&
                    this.DestinationFootprintName.Equals(other.DestinationFootprintName)
                ) && 
                (
                    this.DestinationFootprintHeight == other.DestinationFootprintHeight ||
                    this.DestinationFootprintHeight != null &&
                    this.DestinationFootprintHeight.Equals(other.DestinationFootprintHeight)
                ) && 
                (
                    this.DestinationFootprintWidth == other.DestinationFootprintWidth ||
                    this.DestinationFootprintWidth != null &&
                    this.DestinationFootprintWidth.Equals(other.DestinationFootprintWidth)
                ) && 
                (
                    this.DestinationFootprintDepth == other.DestinationFootprintDepth ||
                    this.DestinationFootprintDepth != null &&
                    this.DestinationFootprintDepth.Equals(other.DestinationFootprintDepth)
                ) && 
                (
                    this.DestinationAddressSchemeId == other.DestinationAddressSchemeId ||
                    this.DestinationAddressSchemeId != null &&
                    this.DestinationAddressSchemeId.Equals(other.DestinationAddressSchemeId)
                ) && 
                (
                    this.DestinationAddressSchemeName == other.DestinationAddressSchemeName ||
                    this.DestinationAddressSchemeName != null &&
                    this.DestinationAddressSchemeName.Equals(other.DestinationAddressSchemeName)
                ) && 
                (
                    this.DestinationLevel == other.DestinationLevel ||
                    this.DestinationLevel != null &&
                    this.DestinationLevel.Equals(other.DestinationLevel)
                ) && 
                (
                    this.DestinationBay == other.DestinationBay ||
                    this.DestinationBay != null &&
                    this.DestinationBay.Equals(other.DestinationBay)
                ) && 
                (
                    this.DestinationNumber == other.DestinationNumber ||
                    this.DestinationNumber != null &&
                    this.DestinationNumber.Equals(other.DestinationNumber)
                ) && 
                (
                    this.DestinationOnline == other.DestinationOnline ||
                    this.DestinationOnline != null &&
                    this.DestinationOnline.Equals(other.DestinationOnline)
                ) && 
                (
                    this.DestinationPriorityCode == other.DestinationPriorityCode ||
                    this.DestinationPriorityCode != null &&
                    this.DestinationPriorityCode.Equals(other.DestinationPriorityCode)
                ) && 
                (
                    this.DestinationCost == other.DestinationCost ||
                    this.DestinationCost != null &&
                    this.DestinationCost.Equals(other.DestinationCost)
                ) && 
                (
                    this.DestinationAllowItemMixing == other.DestinationAllowItemMixing ||
                    this.DestinationAllowItemMixing != null &&
                    this.DestinationAllowItemMixing.Equals(other.DestinationAllowItemMixing)
                ) && 
                (
                    this.MasterRef == other.MasterRef ||
                    this.MasterRef != null &&
                    this.MasterRef.Equals(other.MasterRef)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.NumericSortOrder == other.NumericSortOrder ||
                    this.NumericSortOrder != null &&
                    this.NumericSortOrder.Equals(other.NumericSortOrder)
                ) && 
                (
                    this.ItemDescription == other.ItemDescription ||
                    this.ItemDescription != null &&
                    this.ItemDescription.Equals(other.ItemDescription)
                ) && 
                (
                    this.AdditionalDescription == other.AdditionalDescription ||
                    this.AdditionalDescription != null &&
                    this.AdditionalDescription.Equals(other.AdditionalDescription)
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
                    this.ClassRestriction == other.ClassRestriction ||
                    this.ClassRestriction != null &&
                    this.ClassRestriction.Equals(other.ClassRestriction)
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
                    this.SeasonalItem == other.SeasonalItem ||
                    this.SeasonalItem != null &&
                    this.SeasonalItem.Equals(other.SeasonalItem)
                ) && 
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
                ) && 
                (
                    this.ProductType == other.ProductType ||
                    this.ProductType != null &&
                    this.ProductType.Equals(other.ProductType)
                ) && 
                (
                    this.ItemStatus == other.ItemStatus ||
                    this.ItemStatus != null &&
                    this.ItemStatus.Equals(other.ItemStatus)
                ) && 
                (
                    this.OverallLeadTime == other.OverallLeadTime ||
                    this.OverallLeadTime != null &&
                    this.OverallLeadTime.Equals(other.OverallLeadTime)
                ) && 
                (
                    this.OverallFixedReorderPoint == other.OverallFixedReorderPoint ||
                    this.OverallFixedReorderPoint != null &&
                    this.OverallFixedReorderPoint.Equals(other.OverallFixedReorderPoint)
                ) && 
                (
                    this.QualityControlIndicator == other.QualityControlIndicator ||
                    this.QualityControlIndicator != null &&
                    this.QualityControlIndicator.Equals(other.QualityControlIndicator)
                ) && 
                (
                    this.LotControlFlag == other.LotControlFlag ||
                    this.LotControlFlag != null &&
                    this.LotControlFlag.Equals(other.LotControlFlag)
                ) && 
                (
                    this.ProductCodeFlag == other.ProductCodeFlag ||
                    this.ProductCodeFlag != null &&
                    this.ProductCodeFlag.Equals(other.ProductCodeFlag)
                ) && 
                (
                    this.ChargeCode == other.ChargeCode ||
                    this.ChargeCode != null &&
                    this.ChargeCode.Equals(other.ChargeCode)
                ) && 
                (
                    this.PodRevDate == other.PodRevDate ||
                    this.PodRevDate != null &&
                    this.PodRevDate.Equals(other.PodRevDate)
                ) && 
                (
                    this.PodOrderSuffix == other.PodOrderSuffix ||
                    this.PodOrderSuffix != null &&
                    this.PodOrderSuffix.Equals(other.PodOrderSuffix)
                ) && 
                (
                    this.SerialCode == other.SerialCode ||
                    this.SerialCode != null &&
                    this.SerialCode.Equals(other.SerialCode)
                ) && 
                (
                    this.AssetCode == other.AssetCode ||
                    this.AssetCode != null &&
                    this.AssetCode.Equals(other.AssetCode)
                ) && 
                (
                    this.Backorder == other.Backorder ||
                    this.Backorder != null &&
                    this.Backorder.Equals(other.Backorder)
                ) && 
                (
                    this.AbsoluteMax == other.AbsoluteMax ||
                    this.AbsoluteMax != null &&
                    this.AbsoluteMax.Equals(other.AbsoluteMax)
                ) && 
                (
                    this.AccountCodeId == other.AccountCodeId ||
                    this.AccountCodeId != null &&
                    this.AccountCodeId.Equals(other.AccountCodeId)
                ) && 
                (
                    this.SummaryCodeId == other.SummaryCodeId ||
                    this.SummaryCodeId != null &&
                    this.SummaryCodeId.Equals(other.SummaryCodeId)
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
                    this.BuyerId == other.BuyerId ||
                    this.BuyerId != null &&
                    this.BuyerId.Equals(other.BuyerId)
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
                    this.PackingSlipDescription == other.PackingSlipDescription ||
                    this.PackingSlipDescription != null &&
                    this.PackingSlipDescription.Equals(other.PackingSlipDescription)
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
                    this.CriticalAmount == other.CriticalAmount ||
                    this.CriticalAmount != null &&
                    this.CriticalAmount.Equals(other.CriticalAmount)
                ) && 
                (
                    this.ListPrice == other.ListPrice ||
                    this.ListPrice != null &&
                    this.ListPrice.Equals(other.ListPrice)
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
                    this.VoidDate == other.VoidDate ||
                    this.VoidDate != null &&
                    this.VoidDate.Equals(other.VoidDate)
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
                
                if (this.ImportedRecordId != null)
                    hash = hash * 59 + this.ImportedRecordId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.TypeName != null)
                    hash = hash * 59 + this.TypeName.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusName != null)
                    hash = hash * 59 + this.StatusName.GetHashCode();
                
                if (this.WorkBatchId != null)
                    hash = hash * 59 + this.WorkBatchId.GetHashCode();
                
                if (this.WorkParentId != null)
                    hash = hash * 59 + this.WorkParentId.GetHashCode();
                
                if (this.PriorityCode != null)
                    hash = hash * 59 + this.PriorityCode.GetHashCode();
                
                if (this.ForeignId != null)
                    hash = hash * 59 + this.ForeignId.GetHashCode();
                
                if (this.SourceWarehouseId != null)
                    hash = hash * 59 + this.SourceWarehouseId.GetHashCode();
                
                if (this.SourceWarehouseName != null)
                    hash = hash * 59 + this.SourceWarehouseName.GetHashCode();
                
                if (this.SourceLocation != null)
                    hash = hash * 59 + this.SourceLocation.GetHashCode();
                
                if (this.SourceBuildingId != null)
                    hash = hash * 59 + this.SourceBuildingId.GetHashCode();
                
                if (this.SourceBuildingName != null)
                    hash = hash * 59 + this.SourceBuildingName.GetHashCode();
                
                if (this.SourceZoneId != null)
                    hash = hash * 59 + this.SourceZoneId.GetHashCode();
                
                if (this.SourceZoneName != null)
                    hash = hash * 59 + this.SourceZoneName.GetHashCode();
                
                if (this.SourceAisleId != null)
                    hash = hash * 59 + this.SourceAisleId.GetHashCode();
                
                if (this.SourceAisleAddress != null)
                    hash = hash * 59 + this.SourceAisleAddress.GetHashCode();
                
                if (this.SourceOrigin != null)
                    hash = hash * 59 + this.SourceOrigin.GetHashCode();
                
                if (this.SourceOriginName != null)
                    hash = hash * 59 + this.SourceOriginName.GetHashCode();
                
                if (this.SourceBillingTypeId != null)
                    hash = hash * 59 + this.SourceBillingTypeId.GetHashCode();
                
                if (this.SourceBillingTypeName != null)
                    hash = hash * 59 + this.SourceBillingTypeName.GetHashCode();
                
                if (this.SourceBehaviorType != null)
                    hash = hash * 59 + this.SourceBehaviorType.GetHashCode();
                
                if (this.SourceBehaviorTypeName != null)
                    hash = hash * 59 + this.SourceBehaviorTypeName.GetHashCode();
                
                if (this.SourceFootprintId != null)
                    hash = hash * 59 + this.SourceFootprintId.GetHashCode();
                
                if (this.SourceFootprintName != null)
                    hash = hash * 59 + this.SourceFootprintName.GetHashCode();
                
                if (this.SourceFootprintHeight != null)
                    hash = hash * 59 + this.SourceFootprintHeight.GetHashCode();
                
                if (this.SourceFootprintWidth != null)
                    hash = hash * 59 + this.SourceFootprintWidth.GetHashCode();
                
                if (this.SourceFootprintDepth != null)
                    hash = hash * 59 + this.SourceFootprintDepth.GetHashCode();
                
                if (this.SourceAddressSchemeId != null)
                    hash = hash * 59 + this.SourceAddressSchemeId.GetHashCode();
                
                if (this.SourceAddressSchemeName != null)
                    hash = hash * 59 + this.SourceAddressSchemeName.GetHashCode();
                
                if (this.SourceLevel != null)
                    hash = hash * 59 + this.SourceLevel.GetHashCode();
                
                if (this.SourceBay != null)
                    hash = hash * 59 + this.SourceBay.GetHashCode();
                
                if (this.SourceNumber != null)
                    hash = hash * 59 + this.SourceNumber.GetHashCode();
                
                if (this.SourceOnline != null)
                    hash = hash * 59 + this.SourceOnline.GetHashCode();
                
                if (this.SourcePriorityCode != null)
                    hash = hash * 59 + this.SourcePriorityCode.GetHashCode();
                
                if (this.SourceCost != null)
                    hash = hash * 59 + this.SourceCost.GetHashCode();
                
                if (this.SourceAllowItemMixing != null)
                    hash = hash * 59 + this.SourceAllowItemMixing.GetHashCode();
                
                if (this.DestinationWarehouseId != null)
                    hash = hash * 59 + this.DestinationWarehouseId.GetHashCode();
                
                if (this.DestinationWarehouseName != null)
                    hash = hash * 59 + this.DestinationWarehouseName.GetHashCode();
                
                if (this.DestinationLocation != null)
                    hash = hash * 59 + this.DestinationLocation.GetHashCode();
                
                if (this.DestinationBuildingId != null)
                    hash = hash * 59 + this.DestinationBuildingId.GetHashCode();
                
                if (this.DestinationBuildingName != null)
                    hash = hash * 59 + this.DestinationBuildingName.GetHashCode();
                
                if (this.DestinationZoneId != null)
                    hash = hash * 59 + this.DestinationZoneId.GetHashCode();
                
                if (this.DestinationZoneName != null)
                    hash = hash * 59 + this.DestinationZoneName.GetHashCode();
                
                if (this.DestinationAisleId != null)
                    hash = hash * 59 + this.DestinationAisleId.GetHashCode();
                
                if (this.DestinationAisleAddress != null)
                    hash = hash * 59 + this.DestinationAisleAddress.GetHashCode();
                
                if (this.DestinationOrigin != null)
                    hash = hash * 59 + this.DestinationOrigin.GetHashCode();
                
                if (this.DestinationOriginName != null)
                    hash = hash * 59 + this.DestinationOriginName.GetHashCode();
                
                if (this.DestinationBillingTypeId != null)
                    hash = hash * 59 + this.DestinationBillingTypeId.GetHashCode();
                
                if (this.DestinationBillingTypeName != null)
                    hash = hash * 59 + this.DestinationBillingTypeName.GetHashCode();
                
                if (this.DestinationBehaviorType != null)
                    hash = hash * 59 + this.DestinationBehaviorType.GetHashCode();
                
                if (this.DestinationBehaviorTypeName != null)
                    hash = hash * 59 + this.DestinationBehaviorTypeName.GetHashCode();
                
                if (this.DestinationFootprintId != null)
                    hash = hash * 59 + this.DestinationFootprintId.GetHashCode();
                
                if (this.DestinationFootprintName != null)
                    hash = hash * 59 + this.DestinationFootprintName.GetHashCode();
                
                if (this.DestinationFootprintHeight != null)
                    hash = hash * 59 + this.DestinationFootprintHeight.GetHashCode();
                
                if (this.DestinationFootprintWidth != null)
                    hash = hash * 59 + this.DestinationFootprintWidth.GetHashCode();
                
                if (this.DestinationFootprintDepth != null)
                    hash = hash * 59 + this.DestinationFootprintDepth.GetHashCode();
                
                if (this.DestinationAddressSchemeId != null)
                    hash = hash * 59 + this.DestinationAddressSchemeId.GetHashCode();
                
                if (this.DestinationAddressSchemeName != null)
                    hash = hash * 59 + this.DestinationAddressSchemeName.GetHashCode();
                
                if (this.DestinationLevel != null)
                    hash = hash * 59 + this.DestinationLevel.GetHashCode();
                
                if (this.DestinationBay != null)
                    hash = hash * 59 + this.DestinationBay.GetHashCode();
                
                if (this.DestinationNumber != null)
                    hash = hash * 59 + this.DestinationNumber.GetHashCode();
                
                if (this.DestinationOnline != null)
                    hash = hash * 59 + this.DestinationOnline.GetHashCode();
                
                if (this.DestinationPriorityCode != null)
                    hash = hash * 59 + this.DestinationPriorityCode.GetHashCode();
                
                if (this.DestinationCost != null)
                    hash = hash * 59 + this.DestinationCost.GetHashCode();
                
                if (this.DestinationAllowItemMixing != null)
                    hash = hash * 59 + this.DestinationAllowItemMixing.GetHashCode();
                
                if (this.MasterRef != null)
                    hash = hash * 59 + this.MasterRef.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.NumericSortOrder != null)
                    hash = hash * 59 + this.NumericSortOrder.GetHashCode();
                
                if (this.ItemDescription != null)
                    hash = hash * 59 + this.ItemDescription.GetHashCode();
                
                if (this.AdditionalDescription != null)
                    hash = hash * 59 + this.AdditionalDescription.GetHashCode();
                
                if (this.UnitCode != null)
                    hash = hash * 59 + this.UnitCode.GetHashCode();
                
                if (this.WrapCode != null)
                    hash = hash * 59 + this.WrapCode.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.ClassRestriction != null)
                    hash = hash * 59 + this.ClassRestriction.GetHashCode();
                
                if (this.MaxCycle != null)
                    hash = hash * 59 + this.MaxCycle.GetHashCode();
                
                if (this.MaxInterim != null)
                    hash = hash * 59 + this.MaxInterim.GetHashCode();
                
                if (this.SeasonalItem != null)
                    hash = hash * 59 + this.SeasonalItem.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                if (this.ProductType != null)
                    hash = hash * 59 + this.ProductType.GetHashCode();
                
                if (this.ItemStatus != null)
                    hash = hash * 59 + this.ItemStatus.GetHashCode();
                
                if (this.OverallLeadTime != null)
                    hash = hash * 59 + this.OverallLeadTime.GetHashCode();
                
                if (this.OverallFixedReorderPoint != null)
                    hash = hash * 59 + this.OverallFixedReorderPoint.GetHashCode();
                
                if (this.QualityControlIndicator != null)
                    hash = hash * 59 + this.QualityControlIndicator.GetHashCode();
                
                if (this.LotControlFlag != null)
                    hash = hash * 59 + this.LotControlFlag.GetHashCode();
                
                if (this.ProductCodeFlag != null)
                    hash = hash * 59 + this.ProductCodeFlag.GetHashCode();
                
                if (this.ChargeCode != null)
                    hash = hash * 59 + this.ChargeCode.GetHashCode();
                
                if (this.PodRevDate != null)
                    hash = hash * 59 + this.PodRevDate.GetHashCode();
                
                if (this.PodOrderSuffix != null)
                    hash = hash * 59 + this.PodOrderSuffix.GetHashCode();
                
                if (this.SerialCode != null)
                    hash = hash * 59 + this.SerialCode.GetHashCode();
                
                if (this.AssetCode != null)
                    hash = hash * 59 + this.AssetCode.GetHashCode();
                
                if (this.Backorder != null)
                    hash = hash * 59 + this.Backorder.GetHashCode();
                
                if (this.AbsoluteMax != null)
                    hash = hash * 59 + this.AbsoluteMax.GetHashCode();
                
                if (this.AccountCodeId != null)
                    hash = hash * 59 + this.AccountCodeId.GetHashCode();
                
                if (this.SummaryCodeId != null)
                    hash = hash * 59 + this.SummaryCodeId.GetHashCode();
                
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
                
                if (this.BuyerId != null)
                    hash = hash * 59 + this.BuyerId.GetHashCode();
                
                if (this.VendorSKU != null)
                    hash = hash * 59 + this.VendorSKU.GetHashCode();
                
                if (this.Upc != null)
                    hash = hash * 59 + this.Upc.GetHashCode();
                
                if (this.PackingSlipDescription != null)
                    hash = hash * 59 + this.PackingSlipDescription.GetHashCode();
                
                if (this.CommodityCode != null)
                    hash = hash * 59 + this.CommodityCode.GetHashCode();
                
                if (this.CompCode != null)
                    hash = hash * 59 + this.CompCode.GetHashCode();
                
                if (this.CriticalAmount != null)
                    hash = hash * 59 + this.CriticalAmount.GetHashCode();
                
                if (this.ListPrice != null)
                    hash = hash * 59 + this.ListPrice.GetHashCode();
                
                if (this.OutsideVendor != null)
                    hash = hash * 59 + this.OutsideVendor.GetHashCode();
                
                if (this.PickNo != null)
                    hash = hash * 59 + this.PickNo.GetHashCode();
                
                if (this.RequiresProductionLot != null)
                    hash = hash * 59 + this.RequiresProductionLot.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.VoidDate != null)
                    hash = hash * 59 + this.VoidDate.GetHashCode();
                
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
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
