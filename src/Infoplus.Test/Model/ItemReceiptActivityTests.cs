/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
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
    ///  Class for testing ItemReceiptActivity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ItemReceiptActivityTests
    {
        // TODO uncomment below to declare an instance variable for ItemReceiptActivity
        //private ItemReceiptActivity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ItemReceiptActivity
            //instance = new ItemReceiptActivity();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemReceiptActivity
        /// </summary>
        [Test]
        public void ItemReceiptActivityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ItemReceiptActivity
            //Assert.IsInstanceOfType<ItemReceiptActivity> (instance, "variable 'instance' is a ItemReceiptActivity");
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
        /// Test the property 'ReceiptASNCreateDate'
        /// </summary>
        [Test]
        public void ReceiptASNCreateDateTest()
        {
            // TODO unit test for the property 'ReceiptASNCreateDate'
        }
        /// <summary>
        /// Test the property 'ReceiptModifyDate'
        /// </summary>
        [Test]
        public void ReceiptModifyDateTest()
        {
            // TODO unit test for the property 'ReceiptModifyDate'
        }
        /// <summary>
        /// Test the property 'ItemReceiptId'
        /// </summary>
        [Test]
        public void ItemReceiptIdTest()
        {
            // TODO unit test for the property 'ItemReceiptId'
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
        /// Test the property 'ReceiptUnitsPerCase'
        /// </summary>
        [Test]
        public void ReceiptUnitsPerCaseTest()
        {
            // TODO unit test for the property 'ReceiptUnitsPerCase'
        }
        /// <summary>
        /// Test the property 'ReceiptUnitsPerPallet'
        /// </summary>
        [Test]
        public void ReceiptUnitsPerPalletTest()
        {
            // TODO unit test for the property 'ReceiptUnitsPerPallet'
        }
        /// <summary>
        /// Test the property 'ReceiptVendor'
        /// </summary>
        [Test]
        public void ReceiptVendorTest()
        {
            // TODO unit test for the property 'ReceiptVendor'
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
        /// Test the property 'ReceiptReceiveQuantity'
        /// </summary>
        [Test]
        public void ReceiptReceiveQuantityTest()
        {
            // TODO unit test for the property 'ReceiptReceiveQuantity'
        }
        /// <summary>
        /// Test the property 'ReceiptNumberOfCases'
        /// </summary>
        [Test]
        public void ReceiptNumberOfCasesTest()
        {
            // TODO unit test for the property 'ReceiptNumberOfCases'
        }
        /// <summary>
        /// Test the property 'ReceiptNumberOfPallets'
        /// </summary>
        [Test]
        public void ReceiptNumberOfPalletsTest()
        {
            // TODO unit test for the property 'ReceiptNumberOfPallets'
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
        /// Test the property 'ReceiptWrapUnitWeight'
        /// </summary>
        [Test]
        public void ReceiptWrapUnitWeightTest()
        {
            // TODO unit test for the property 'ReceiptWrapUnitWeight'
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
        /// Test the property 'ReceiptEnteredBy'
        /// </summary>
        [Test]
        public void ReceiptEnteredByTest()
        {
            // TODO unit test for the property 'ReceiptEnteredBy'
        }
        /// <summary>
        /// Test the property 'ReceiptReceivedBy'
        /// </summary>
        [Test]
        public void ReceiptReceivedByTest()
        {
            // TODO unit test for the property 'ReceiptReceivedBy'
        }
        /// <summary>
        /// Test the property 'ReceiptType'
        /// </summary>
        [Test]
        public void ReceiptTypeTest()
        {
            // TODO unit test for the property 'ReceiptType'
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
        /// Test the property 'ItemId'
        /// </summary>
        [Test]
        public void ItemIdTest()
        {
            // TODO unit test for the property 'ItemId'
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
        /// Test the property 'ItemUPC'
        /// </summary>
        [Test]
        public void ItemUPCTest()
        {
            // TODO unit test for the property 'ItemUPC'
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
        /// Test the property 'VendorComplianceSurveyAnswer1'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer1Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer1'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer2'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer2Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer2'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer3'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer3Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer3'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer4'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer4Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer4'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer5'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer5Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer5'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer6'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer6Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer6'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer7'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer7Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer7'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer8'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer8Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer8'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer9'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer9Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer9'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer10'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer10Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer10'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer11'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer11Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer11'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer12'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer12Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer12'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer13'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer13Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer13'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer14'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer14Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer14'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer15'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer15Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer15'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer16'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer16Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer16'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer17'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer17Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer17'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer18'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer18Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer18'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer19'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer19Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer19'
        }
        /// <summary>
        /// Test the property 'VendorComplianceSurveyAnswer20'
        /// </summary>
        [Test]
        public void VendorComplianceSurveyAnswer20Test()
        {
            // TODO unit test for the property 'VendorComplianceSurveyAnswer20'
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
