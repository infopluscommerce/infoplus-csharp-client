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
    ///  Class for testing OrderLine
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrderLineTests
    {
        // TODO uncomment below to declare an instance variable for OrderLine
        //private OrderLine instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OrderLine
            //instance = new OrderLine();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderLine
        /// </summary>
        [Test]
        public void OrderLineInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OrderLine
            //Assert.IsInstanceOfType<OrderLine> (instance, "variable 'instance' is a OrderLine");
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
        /// Test the property 'LineItemId'
        /// </summary>
        [Test]
        public void LineItemIdTest()
        {
            // TODO unit test for the property 'LineItemId'
        }
        /// <summary>
        /// Test the property 'CustomerLineItemNo'
        /// </summary>
        [Test]
        public void CustomerLineItemNoTest()
        {
            // TODO unit test for the property 'CustomerLineItemNo'
        }
        /// <summary>
        /// Test the property 'OrderNo'
        /// </summary>
        [Test]
        public void OrderNoTest()
        {
            // TODO unit test for the property 'OrderNo'
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
        /// Test the property 'Sku'
        /// </summary>
        [Test]
        public void SkuTest()
        {
            // TODO unit test for the property 'Sku'
        }
        /// <summary>
        /// Test the property 'PoNoId'
        /// </summary>
        [Test]
        public void PoNoIdTest()
        {
            // TODO unit test for the property 'PoNoId'
        }
        /// <summary>
        /// Test the property 'OrderedQty'
        /// </summary>
        [Test]
        public void OrderedQtyTest()
        {
            // TODO unit test for the property 'OrderedQty'
        }
        /// <summary>
        /// Test the property 'AllowedQty'
        /// </summary>
        [Test]
        public void AllowedQtyTest()
        {
            // TODO unit test for the property 'AllowedQty'
        }
        /// <summary>
        /// Test the property 'ShippedQty'
        /// </summary>
        [Test]
        public void ShippedQtyTest()
        {
            // TODO unit test for the property 'ShippedQty'
        }
        /// <summary>
        /// Test the property 'BackorderQty'
        /// </summary>
        [Test]
        public void BackorderQtyTest()
        {
            // TODO unit test for the property 'BackorderQty'
        }
        /// <summary>
        /// Test the property 'NumberOfWraps'
        /// </summary>
        [Test]
        public void NumberOfWrapsTest()
        {
            // TODO unit test for the property 'NumberOfWraps'
        }
        /// <summary>
        /// Test the property 'NumberOfCases'
        /// </summary>
        [Test]
        public void NumberOfCasesTest()
        {
            // TODO unit test for the property 'NumberOfCases'
        }
        /// <summary>
        /// Test the property 'NumberOfInnerPacks'
        /// </summary>
        [Test]
        public void NumberOfInnerPacksTest()
        {
            // TODO unit test for the property 'NumberOfInnerPacks'
        }
        /// <summary>
        /// Test the property 'RevDate'
        /// </summary>
        [Test]
        public void RevDateTest()
        {
            // TODO unit test for the property 'RevDate'
        }
        /// <summary>
        /// Test the property 'ChargeCode'
        /// </summary>
        [Test]
        public void ChargeCodeTest()
        {
            // TODO unit test for the property 'ChargeCode'
        }
        /// <summary>
        /// Test the property 'DistributionCode'
        /// </summary>
        [Test]
        public void DistributionCodeTest()
        {
            // TODO unit test for the property 'DistributionCode'
        }
        /// <summary>
        /// Test the property 'Upc'
        /// </summary>
        [Test]
        public void UpcTest()
        {
            // TODO unit test for the property 'Upc'
        }
        /// <summary>
        /// Test the property 'VendorSKU'
        /// </summary>
        [Test]
        public void VendorSKUTest()
        {
            // TODO unit test for the property 'VendorSKU'
        }
        /// <summary>
        /// Test the property 'OrderSourceSKU'
        /// </summary>
        [Test]
        public void OrderSourceSKUTest()
        {
            // TODO unit test for the property 'OrderSourceSKU'
        }
        /// <summary>
        /// Test the property 'UnitCost'
        /// </summary>
        [Test]
        public void UnitCostTest()
        {
            // TODO unit test for the property 'UnitCost'
        }
        /// <summary>
        /// Test the property 'UnitSell'
        /// </summary>
        [Test]
        public void UnitSellTest()
        {
            // TODO unit test for the property 'UnitSell'
        }
        /// <summary>
        /// Test the property 'UnitDiscount'
        /// </summary>
        [Test]
        public void UnitDiscountTest()
        {
            // TODO unit test for the property 'UnitDiscount'
        }
        /// <summary>
        /// Test the property 'UnitDeclaredValueOverride'
        /// </summary>
        [Test]
        public void UnitDeclaredValueOverrideTest()
        {
            // TODO unit test for the property 'UnitDeclaredValueOverride'
        }
        /// <summary>
        /// Test the property 'ExtendedCost'
        /// </summary>
        [Test]
        public void ExtendedCostTest()
        {
            // TODO unit test for the property 'ExtendedCost'
        }
        /// <summary>
        /// Test the property 'ExtendedSell'
        /// </summary>
        [Test]
        public void ExtendedSellTest()
        {
            // TODO unit test for the property 'ExtendedSell'
        }
        /// <summary>
        /// Test the property 'ExtendedDiscount'
        /// </summary>
        [Test]
        public void ExtendedDiscountTest()
        {
            // TODO unit test for the property 'ExtendedDiscount'
        }
        /// <summary>
        /// Test the property 'NcExtendedSell'
        /// </summary>
        [Test]
        public void NcExtendedSellTest()
        {
            // TODO unit test for the property 'NcExtendedSell'
        }
        /// <summary>
        /// Test the property 'ExtendedDeclaredValueOverride'
        /// </summary>
        [Test]
        public void ExtendedDeclaredValueOverrideTest()
        {
            // TODO unit test for the property 'ExtendedDeclaredValueOverride'
        }
        /// <summary>
        /// Test the property 'ItemWeight'
        /// </summary>
        [Test]
        public void ItemWeightTest()
        {
            // TODO unit test for the property 'ItemWeight'
        }
        /// <summary>
        /// Test the property 'ProductionLot'
        /// </summary>
        [Test]
        public void ProductionLotTest()
        {
            // TODO unit test for the property 'ProductionLot'
        }
        /// <summary>
        /// Test the property 'ProductIdTag'
        /// </summary>
        [Test]
        public void ProductIdTagTest()
        {
            // TODO unit test for the property 'ProductIdTag'
        }
        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Test]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }
        /// <summary>
        /// Test the property 'WeightPerWrap'
        /// </summary>
        [Test]
        public void WeightPerWrapTest()
        {
            // TODO unit test for the property 'WeightPerWrap'
        }
        /// <summary>
        /// Test the property 'Sector'
        /// </summary>
        [Test]
        public void SectorTest()
        {
            // TODO unit test for the property 'Sector'
        }
        /// <summary>
        /// Test the property 'OrderAssemblyInstructions'
        /// </summary>
        [Test]
        public void OrderAssemblyInstructionsTest()
        {
            // TODO unit test for the property 'OrderAssemblyInstructions'
        }
        /// <summary>
        /// Test the property 'ItemAccountCodeId'
        /// </summary>
        [Test]
        public void ItemAccountCodeIdTest()
        {
            // TODO unit test for the property 'ItemAccountCodeId'
        }
        /// <summary>
        /// Test the property 'ItemLegacyLowStockContactId'
        /// </summary>
        [Test]
        public void ItemLegacyLowStockContactIdTest()
        {
            // TODO unit test for the property 'ItemLegacyLowStockContactId'
        }
        /// <summary>
        /// Test the property 'ItemMajorGroupId'
        /// </summary>
        [Test]
        public void ItemMajorGroupIdTest()
        {
            // TODO unit test for the property 'ItemMajorGroupId'
        }
        /// <summary>
        /// Test the property 'ItemSubGroupId'
        /// </summary>
        [Test]
        public void ItemSubGroupIdTest()
        {
            // TODO unit test for the property 'ItemSubGroupId'
        }
        /// <summary>
        /// Test the property 'ItemProductCodeId'
        /// </summary>
        [Test]
        public void ItemProductCodeIdTest()
        {
            // TODO unit test for the property 'ItemProductCodeId'
        }
        /// <summary>
        /// Test the property 'ItemSummaryCodeId'
        /// </summary>
        [Test]
        public void ItemSummaryCodeIdTest()
        {
            // TODO unit test for the property 'ItemSummaryCodeId'
        }
        /// <summary>
        /// Test the property 'FulfillmentChannel'
        /// </summary>
        [Test]
        public void FulfillmentChannelTest()
        {
            // TODO unit test for the property 'FulfillmentChannel'
        }
        /// <summary>
        /// Test the property 'DynamicKitComponentList'
        /// </summary>
        [Test]
        public void DynamicKitComponentListTest()
        {
            // TODO unit test for the property 'DynamicKitComponentList'
        }
        /// <summary>
        /// Test the property 'OverrideReceiptsForFulfillmentList'
        /// </summary>
        [Test]
        public void OverrideReceiptsForFulfillmentListTest()
        {
            // TODO unit test for the property 'OverrideReceiptsForFulfillmentList'
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
