/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v3.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Infoplus.Api;
using Infoplus.Model;
using Infoplus.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing InventoryStorageActivity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InventoryStorageActivityTests
    {
        // TODO uncomment below to declare an instance variable for InventoryStorageActivity
        //private InventoryStorageActivity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InventoryStorageActivity
            //instance = new InventoryStorageActivity();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InventoryStorageActivity
        /// </summary>
        [Test]
        public void InventoryStorageActivityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InventoryStorageActivity
            //Assert.IsInstanceOfType<InventoryStorageActivity> (instance, "variable 'instance' is a InventoryStorageActivity");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'ImportedRecordId'
        /// </summary>
        [Test]
        public void ImportedRecordIdTest()
        {
            // TODO unit test for the property 'ImportedRecordId'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'ModifyDate'
        /// </summary>
        [Test]
        public void ModifyDateTest()
        {
            // TODO unit test for the property 'ModifyDate'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationId'
        /// </summary>
        [Test]
        public void WarehouseLocationIdTest()
        {
            // TODO unit test for the property 'WarehouseLocationId'
        }
        /// <summary>
        /// Test the property 'ItemId'
        /// </summary>
        [Test]
        public void ItemIdTest()
        {
            // TODO unit test for the property 'ItemId'
        }
        /// <summary>
        /// Test the property 'LobId'
        /// </summary>
        [Test]
        public void LobIdTest()
        {
            // TODO unit test for the property 'LobId'
        }
        /// <summary>
        /// Test the property 'SnapshotDate'
        /// </summary>
        [Test]
        public void SnapshotDateTest()
        {
            // TODO unit test for the property 'SnapshotDate'
        }
        /// <summary>
        /// Test the property 'IsMixedReceipts'
        /// </summary>
        [Test]
        public void IsMixedReceiptsTest()
        {
            // TODO unit test for the property 'IsMixedReceipts'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Test]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'EstimatedInnerPacks'
        /// </summary>
        [Test]
        public void EstimatedInnerPacksTest()
        {
            // TODO unit test for the property 'EstimatedInnerPacks'
        }
        /// <summary>
        /// Test the property 'EstimatedCases'
        /// </summary>
        [Test]
        public void EstimatedCasesTest()
        {
            // TODO unit test for the property 'EstimatedCases'
        }
        /// <summary>
        /// Test the property 'EstimatedPallets'
        /// </summary>
        [Test]
        public void EstimatedPalletsTest()
        {
            // TODO unit test for the property 'EstimatedPallets'
        }
        /// <summary>
        /// Test the property 'InventoryValue'
        /// </summary>
        [Test]
        public void InventoryValueTest()
        {
            // TODO unit test for the property 'InventoryValue'
        }
        /// <summary>
        /// Test the property 'InventoryAgeDays'
        /// </summary>
        [Test]
        public void InventoryAgeDaysTest()
        {
            // TODO unit test for the property 'InventoryAgeDays'
        }
        /// <summary>
        /// Test the property 'WarehouseId'
        /// </summary>
        [Test]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
        }
        /// <summary>
        /// Test the property 'WarehouseName'
        /// </summary>
        [Test]
        public void WarehouseNameTest()
        {
            // TODO unit test for the property 'WarehouseName'
        }
        /// <summary>
        /// Test the property 'WarehouseZoneId'
        /// </summary>
        [Test]
        public void WarehouseZoneIdTest()
        {
            // TODO unit test for the property 'WarehouseZoneId'
        }
        /// <summary>
        /// Test the property 'WarehouseZoneName'
        /// </summary>
        [Test]
        public void WarehouseZoneNameTest()
        {
            // TODO unit test for the property 'WarehouseZoneName'
        }
        /// <summary>
        /// Test the property 'WarehouseZoneAddress'
        /// </summary>
        [Test]
        public void WarehouseZoneAddressTest()
        {
            // TODO unit test for the property 'WarehouseZoneAddress'
        }
        /// <summary>
        /// Test the property 'WarehouseBuildingId'
        /// </summary>
        [Test]
        public void WarehouseBuildingIdTest()
        {
            // TODO unit test for the property 'WarehouseBuildingId'
        }
        /// <summary>
        /// Test the property 'WarehouseBuildingName'
        /// </summary>
        [Test]
        public void WarehouseBuildingNameTest()
        {
            // TODO unit test for the property 'WarehouseBuildingName'
        }
        /// <summary>
        /// Test the property 'WarehouseAisleId'
        /// </summary>
        [Test]
        public void WarehouseAisleIdTest()
        {
            // TODO unit test for the property 'WarehouseAisleId'
        }
        /// <summary>
        /// Test the property 'WarehouseAisleAddress'
        /// </summary>
        [Test]
        public void WarehouseAisleAddressTest()
        {
            // TODO unit test for the property 'WarehouseAisleAddress'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationOriginId'
        /// </summary>
        [Test]
        public void WarehouseLocationOriginIdTest()
        {
            // TODO unit test for the property 'WarehouseLocationOriginId'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationOriginName'
        /// </summary>
        [Test]
        public void WarehouseLocationOriginNameTest()
        {
            // TODO unit test for the property 'WarehouseLocationOriginName'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationBillingTypeId'
        /// </summary>
        [Test]
        public void WarehouseLocationBillingTypeIdTest()
        {
            // TODO unit test for the property 'WarehouseLocationBillingTypeId'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationBillingTypeName'
        /// </summary>
        [Test]
        public void WarehouseLocationBillingTypeNameTest()
        {
            // TODO unit test for the property 'WarehouseLocationBillingTypeName'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationBehaviorTypeId'
        /// </summary>
        [Test]
        public void WarehouseLocationBehaviorTypeIdTest()
        {
            // TODO unit test for the property 'WarehouseLocationBehaviorTypeId'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationBehaviorTypeName'
        /// </summary>
        [Test]
        public void WarehouseLocationBehaviorTypeNameTest()
        {
            // TODO unit test for the property 'WarehouseLocationBehaviorTypeName'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationFootprintId'
        /// </summary>
        [Test]
        public void WarehouseLocationFootprintIdTest()
        {
            // TODO unit test for the property 'WarehouseLocationFootprintId'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationFootprintName'
        /// </summary>
        [Test]
        public void WarehouseLocationFootprintNameTest()
        {
            // TODO unit test for the property 'WarehouseLocationFootprintName'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationFootprintWidth'
        /// </summary>
        [Test]
        public void WarehouseLocationFootprintWidthTest()
        {
            // TODO unit test for the property 'WarehouseLocationFootprintWidth'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationFootprintHeight'
        /// </summary>
        [Test]
        public void WarehouseLocationFootprintHeightTest()
        {
            // TODO unit test for the property 'WarehouseLocationFootprintHeight'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationFootprintDepth'
        /// </summary>
        [Test]
        public void WarehouseLocationFootprintDepthTest()
        {
            // TODO unit test for the property 'WarehouseLocationFootprintDepth'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationCubicFeet'
        /// </summary>
        [Test]
        public void WarehouseLocationCubicFeetTest()
        {
            // TODO unit test for the property 'WarehouseLocationCubicFeet'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationLevel'
        /// </summary>
        [Test]
        public void WarehouseLocationLevelTest()
        {
            // TODO unit test for the property 'WarehouseLocationLevel'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationBay'
        /// </summary>
        [Test]
        public void WarehouseLocationBayTest()
        {
            // TODO unit test for the property 'WarehouseLocationBay'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationNumber'
        /// </summary>
        [Test]
        public void WarehouseLocationNumberTest()
        {
            // TODO unit test for the property 'WarehouseLocationNumber'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationOnline'
        /// </summary>
        [Test]
        public void WarehouseLocationOnlineTest()
        {
            // TODO unit test for the property 'WarehouseLocationOnline'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationPriorityCode'
        /// </summary>
        [Test]
        public void WarehouseLocationPriorityCodeTest()
        {
            // TODO unit test for the property 'WarehouseLocationPriorityCode'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationAllowItemMixing'
        /// </summary>
        [Test]
        public void WarehouseLocationAllowItemMixingTest()
        {
            // TODO unit test for the property 'WarehouseLocationAllowItemMixing'
        }
        /// <summary>
        /// Test the property 'WarehouseLocationCost'
        /// </summary>
        [Test]
        public void WarehouseLocationCostTest()
        {
            // TODO unit test for the property 'WarehouseLocationCost'
        }
        /// <summary>
        /// Test the property 'Sku'
        /// </summary>
        [Test]
        public void SkuTest()
        {
            // TODO unit test for the property 'Sku'
        }
        /// <summary>
        /// Test the property 'ItemVendorSku'
        /// </summary>
        [Test]
        public void ItemVendorSkuTest()
        {
            // TODO unit test for the property 'ItemVendorSku'
        }
        /// <summary>
        /// Test the property 'ItemUpc'
        /// </summary>
        [Test]
        public void ItemUpcTest()
        {
            // TODO unit test for the property 'ItemUpc'
        }
        /// <summary>
        /// Test the property 'ItemMajorGroup'
        /// </summary>
        [Test]
        public void ItemMajorGroupTest()
        {
            // TODO unit test for the property 'ItemMajorGroup'
        }
        /// <summary>
        /// Test the property 'ItemMajorGroupName'
        /// </summary>
        [Test]
        public void ItemMajorGroupNameTest()
        {
            // TODO unit test for the property 'ItemMajorGroupName'
        }
        /// <summary>
        /// Test the property 'ItemSubGroup'
        /// </summary>
        [Test]
        public void ItemSubGroupTest()
        {
            // TODO unit test for the property 'ItemSubGroup'
        }
        /// <summary>
        /// Test the property 'ItemSubGroupName'
        /// </summary>
        [Test]
        public void ItemSubGroupNameTest()
        {
            // TODO unit test for the property 'ItemSubGroupName'
        }
        /// <summary>
        /// Test the property 'ItemProductCode'
        /// </summary>
        [Test]
        public void ItemProductCodeTest()
        {
            // TODO unit test for the property 'ItemProductCode'
        }
        /// <summary>
        /// Test the property 'ItemProductCodeName'
        /// </summary>
        [Test]
        public void ItemProductCodeNameTest()
        {
            // TODO unit test for the property 'ItemProductCodeName'
        }
        /// <summary>
        /// Test the property 'ItemAccountCode'
        /// </summary>
        [Test]
        public void ItemAccountCodeTest()
        {
            // TODO unit test for the property 'ItemAccountCode'
        }
        /// <summary>
        /// Test the property 'ItemAccountCodeName'
        /// </summary>
        [Test]
        public void ItemAccountCodeNameTest()
        {
            // TODO unit test for the property 'ItemAccountCodeName'
        }
        /// <summary>
        /// Test the property 'ItemSummaryCode'
        /// </summary>
        [Test]
        public void ItemSummaryCodeTest()
        {
            // TODO unit test for the property 'ItemSummaryCode'
        }
        /// <summary>
        /// Test the property 'ItemSummaryCodeName'
        /// </summary>
        [Test]
        public void ItemSummaryCodeNameTest()
        {
            // TODO unit test for the property 'ItemSummaryCodeName'
        }
        /// <summary>
        /// Test the property 'ItemSector'
        /// </summary>
        [Test]
        public void ItemSectorTest()
        {
            // TODO unit test for the property 'ItemSector'
        }
        /// <summary>
        /// Test the property 'ItemCubicFeet'
        /// </summary>
        [Test]
        public void ItemCubicFeetTest()
        {
            // TODO unit test for the property 'ItemCubicFeet'
        }
        /// <summary>
        /// Test the property 'PoNo'
        /// </summary>
        [Test]
        public void PoNoTest()
        {
            // TODO unit test for the property 'PoNo'
        }
        /// <summary>
        /// Test the property 'ReceiptDistributionDate'
        /// </summary>
        [Test]
        public void ReceiptDistributionDateTest()
        {
            // TODO unit test for the property 'ReceiptDistributionDate'
        }
        /// <summary>
        /// Test the property 'ReceiptUnitsPerWrap'
        /// </summary>
        [Test]
        public void ReceiptUnitsPerWrapTest()
        {
            // TODO unit test for the property 'ReceiptUnitsPerWrap'
        }
        /// <summary>
        /// Test the property 'ReceiptQuantityPerInnerPack'
        /// </summary>
        [Test]
        public void ReceiptQuantityPerInnerPackTest()
        {
            // TODO unit test for the property 'ReceiptQuantityPerInnerPack'
        }
        /// <summary>
        /// Test the property 'ReceiptQuantityPerCase'
        /// </summary>
        [Test]
        public void ReceiptQuantityPerCaseTest()
        {
            // TODO unit test for the property 'ReceiptQuantityPerCase'
        }
        /// <summary>
        /// Test the property 'ReceiptQuantityPerPallet'
        /// </summary>
        [Test]
        public void ReceiptQuantityPerPalletTest()
        {
            // TODO unit test for the property 'ReceiptQuantityPerPallet'
        }
        /// <summary>
        /// Test the property 'ReceiptRevisionDate'
        /// </summary>
        [Test]
        public void ReceiptRevisionDateTest()
        {
            // TODO unit test for the property 'ReceiptRevisionDate'
        }
        /// <summary>
        /// Test the property 'ReceiptProductionLot'
        /// </summary>
        [Test]
        public void ReceiptProductionLotTest()
        {
            // TODO unit test for the property 'ReceiptProductionLot'
        }
        /// <summary>
        /// Test the property 'ReceiptReceiveDate'
        /// </summary>
        [Test]
        public void ReceiptReceiveDateTest()
        {
            // TODO unit test for the property 'ReceiptReceiveDate'
        }
        /// <summary>
        /// Test the property 'ReceiptStatus'
        /// </summary>
        [Test]
        public void ReceiptStatusTest()
        {
            // TODO unit test for the property 'ReceiptStatus'
        }
        /// <summary>
        /// Test the property 'ReceiptStatusName'
        /// </summary>
        [Test]
        public void ReceiptStatusNameTest()
        {
            // TODO unit test for the property 'ReceiptStatusName'
        }
        /// <summary>
        /// Test the property 'ReceiptUnitCode'
        /// </summary>
        [Test]
        public void ReceiptUnitCodeTest()
        {
            // TODO unit test for the property 'ReceiptUnitCode'
        }
        /// <summary>
        /// Test the property 'ReceiptUnitCodeText'
        /// </summary>
        [Test]
        public void ReceiptUnitCodeTextTest()
        {
            // TODO unit test for the property 'ReceiptUnitCodeText'
        }
        /// <summary>
        /// Test the property 'ReceiptWrapCode'
        /// </summary>
        [Test]
        public void ReceiptWrapCodeTest()
        {
            // TODO unit test for the property 'ReceiptWrapCode'
        }
        /// <summary>
        /// Test the property 'ReceiptWrapCodeText'
        /// </summary>
        [Test]
        public void ReceiptWrapCodeTextTest()
        {
            // TODO unit test for the property 'ReceiptWrapCodeText'
        }
        /// <summary>
        /// Test the property 'ReceiptCaseWeight'
        /// </summary>
        [Test]
        public void ReceiptCaseWeightTest()
        {
            // TODO unit test for the property 'ReceiptCaseWeight'
        }
        /// <summary>
        /// Test the property 'ReceiptProductIdTag'
        /// </summary>
        [Test]
        public void ReceiptProductIdTagTest()
        {
            // TODO unit test for the property 'ReceiptProductIdTag'
        }
        /// <summary>
        /// Test the property 'AlcoholTypeId'
        /// </summary>
        [Test]
        public void AlcoholTypeIdTest()
        {
            // TODO unit test for the property 'AlcoholTypeId'
        }
        /// <summary>
        /// Test the property 'AlcoholTypeName'
        /// </summary>
        [Test]
        public void AlcoholTypeNameTest()
        {
            // TODO unit test for the property 'AlcoholTypeName'
        }
        /// <summary>
        /// Test the property 'AlcoholContent'
        /// </summary>
        [Test]
        public void AlcoholContentTest()
        {
            // TODO unit test for the property 'AlcoholContent'
        }
        /// <summary>
        /// Test the property 'AlcoholContainerId'
        /// </summary>
        [Test]
        public void AlcoholContainerIdTest()
        {
            // TODO unit test for the property 'AlcoholContainerId'
        }
        /// <summary>
        /// Test the property 'AlcoholContainerName'
        /// </summary>
        [Test]
        public void AlcoholContainerNameTest()
        {
            // TODO unit test for the property 'AlcoholContainerName'
        }
        /// <summary>
        /// Test the property 'AlcoholContainerVolume'
        /// </summary>
        [Test]
        public void AlcoholContainerVolumeTest()
        {
            // TODO unit test for the property 'AlcoholContainerVolume'
        }
        /// <summary>
        /// Test the property 'AlcoholVintageYear'
        /// </summary>
        [Test]
        public void AlcoholVintageYearTest()
        {
            // TODO unit test for the property 'AlcoholVintageYear'
        }
        /// <summary>
        /// Test the property 'AlcoholCountryId'
        /// </summary>
        [Test]
        public void AlcoholCountryIdTest()
        {
            // TODO unit test for the property 'AlcoholCountryId'
        }
        /// <summary>
        /// Test the property 'AlcoholCountryName'
        /// </summary>
        [Test]
        public void AlcoholCountryNameTest()
        {
            // TODO unit test for the property 'AlcoholCountryName'
        }
        /// <summary>
        /// Test the property 'AlcoholState'
        /// </summary>
        [Test]
        public void AlcoholStateTest()
        {
            // TODO unit test for the property 'AlcoholState'
        }
        /// <summary>
        /// Test the property 'AlcoholRegion'
        /// </summary>
        [Test]
        public void AlcoholRegionTest()
        {
            // TODO unit test for the property 'AlcoholRegion'
        }
        /// <summary>
        /// Test the property 'AlcoholBrand'
        /// </summary>
        [Test]
        public void AlcoholBrandTest()
        {
            // TODO unit test for the property 'AlcoholBrand'
        }
        /// <summary>
        /// Test the property 'AlcoholUPCCode'
        /// </summary>
        [Test]
        public void AlcoholUPCCodeTest()
        {
            // TODO unit test for the property 'AlcoholUPCCode'
        }
        /// <summary>
        /// Test the property 'AlcoholNABCACode'
        /// </summary>
        [Test]
        public void AlcoholNABCACodeTest()
        {
            // TODO unit test for the property 'AlcoholNABCACode'
        }
        /// <summary>
        /// Test the property 'AlcoholUNIMERCCode'
        /// </summary>
        [Test]
        public void AlcoholUNIMERCCodeTest()
        {
            // TODO unit test for the property 'AlcoholUNIMERCCode'
        }
        /// <summary>
        /// Test the property 'AlcoholSCCCode'
        /// </summary>
        [Test]
        public void AlcoholSCCCodeTest()
        {
            // TODO unit test for the property 'AlcoholSCCCode'
        }
        /// <summary>
        /// Test the property 'BillingQuantity'
        /// </summary>
        [Test]
        public void BillingQuantityTest()
        {
            // TODO unit test for the property 'BillingQuantity'
        }
        /// <summary>
        /// Test the property 'ChargeRate'
        /// </summary>
        [Test]
        public void ChargeRateTest()
        {
            // TODO unit test for the property 'ChargeRate'
        }
        /// <summary>
        /// Test the property 'ExtendedCharge'
        /// </summary>
        [Test]
        public void ExtendedChargeTest()
        {
            // TODO unit test for the property 'ExtendedCharge'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }

    }

}
