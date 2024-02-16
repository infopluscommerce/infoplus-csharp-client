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
    ///  Class for testing WarehouseInventory
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WarehouseInventoryTests
    {
        // TODO uncomment below to declare an instance variable for WarehouseInventory
        //private WarehouseInventory instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of WarehouseInventory
            //instance = new WarehouseInventory();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WarehouseInventory
        /// </summary>
        [Test]
        public void WarehouseInventoryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" WarehouseInventory
            //Assert.IsInstanceOfType<WarehouseInventory> (instance, "variable 'instance' is a WarehouseInventory");
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
        /// Test the property 'Sku'
        /// </summary>
        [Test]
        public void SkuTest()
        {
            // TODO unit test for the property 'Sku'
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
        /// Test the property 'WarehouseId'
        /// </summary>
        [Test]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
        }
        /// <summary>
        /// Test the property 'OnHandQuantity'
        /// </summary>
        [Test]
        public void OnHandQuantityTest()
        {
            // TODO unit test for the property 'OnHandQuantity'
        }
        /// <summary>
        /// Test the property 'UnavailableQuantity'
        /// </summary>
        [Test]
        public void UnavailableQuantityTest()
        {
            // TODO unit test for the property 'UnavailableQuantity'
        }
        /// <summary>
        /// Test the property 'OpenPOQuantity'
        /// </summary>
        [Test]
        public void OpenPOQuantityTest()
        {
            // TODO unit test for the property 'OpenPOQuantity'
        }
        /// <summary>
        /// Test the property 'OpenOrderQuantity'
        /// </summary>
        [Test]
        public void OpenOrderQuantityTest()
        {
            // TODO unit test for the property 'OpenOrderQuantity'
        }
        /// <summary>
        /// Test the property 'AvailableQuantity'
        /// </summary>
        [Test]
        public void AvailableQuantityTest()
        {
            // TODO unit test for the property 'AvailableQuantity'
        }
        /// <summary>
        /// Test the property 'DamagedQuantity'
        /// </summary>
        [Test]
        public void DamagedQuantityTest()
        {
            // TODO unit test for the property 'DamagedQuantity'
        }
        /// <summary>
        /// Test the property 'InFulfillmentProcessQuantity'
        /// </summary>
        [Test]
        public void InFulfillmentProcessQuantityTest()
        {
            // TODO unit test for the property 'InFulfillmentProcessQuantity'
        }
        /// <summary>
        /// Test the property 'OrderableQuantity'
        /// </summary>
        [Test]
        public void OrderableQuantityTest()
        {
            // TODO unit test for the property 'OrderableQuantity'
        }
        /// <summary>
        /// Test the property 'UnallocatableQuantity'
        /// </summary>
        [Test]
        public void UnallocatableQuantityTest()
        {
            // TODO unit test for the property 'UnallocatableQuantity'
        }
        /// <summary>
        /// Test the property 'DaysOnHand'
        /// </summary>
        [Test]
        public void DaysOnHandTest()
        {
            // TODO unit test for the property 'DaysOnHand'
        }
        /// <summary>
        /// Test the property 'StockStatus'
        /// </summary>
        [Test]
        public void StockStatusTest()
        {
            // TODO unit test for the property 'StockStatus'
        }
        /// <summary>
        /// Test the property 'AvailableQuantityCases'
        /// </summary>
        [Test]
        public void AvailableQuantityCasesTest()
        {
            // TODO unit test for the property 'AvailableQuantityCases'
        }
        /// <summary>
        /// Test the property 'AvailableQuantityInnerPacks'
        /// </summary>
        [Test]
        public void AvailableQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'AvailableQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'AvailableQuantityPallets'
        /// </summary>
        [Test]
        public void AvailableQuantityPalletsTest()
        {
            // TODO unit test for the property 'AvailableQuantityPallets'
        }
        /// <summary>
        /// Test the property 'DamagedQuantityCases'
        /// </summary>
        [Test]
        public void DamagedQuantityCasesTest()
        {
            // TODO unit test for the property 'DamagedQuantityCases'
        }
        /// <summary>
        /// Test the property 'DamagedQuantityInnerPacks'
        /// </summary>
        [Test]
        public void DamagedQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'DamagedQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'DamagedQuantityPallets'
        /// </summary>
        [Test]
        public void DamagedQuantityPalletsTest()
        {
            // TODO unit test for the property 'DamagedQuantityPallets'
        }
        /// <summary>
        /// Test the property 'InFulfillmentProcessQuantityCases'
        /// </summary>
        [Test]
        public void InFulfillmentProcessQuantityCasesTest()
        {
            // TODO unit test for the property 'InFulfillmentProcessQuantityCases'
        }
        /// <summary>
        /// Test the property 'InFulfillmentProcessQuantityInnerPacks'
        /// </summary>
        [Test]
        public void InFulfillmentProcessQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'InFulfillmentProcessQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'InFulfillmentProcessQuantityPallets'
        /// </summary>
        [Test]
        public void InFulfillmentProcessQuantityPalletsTest()
        {
            // TODO unit test for the property 'InFulfillmentProcessQuantityPallets'
        }
        /// <summary>
        /// Test the property 'OnHandQuantityCases'
        /// </summary>
        [Test]
        public void OnHandQuantityCasesTest()
        {
            // TODO unit test for the property 'OnHandQuantityCases'
        }
        /// <summary>
        /// Test the property 'OnHandQuantityInnerPacks'
        /// </summary>
        [Test]
        public void OnHandQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'OnHandQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'OnHandQuantityPallets'
        /// </summary>
        [Test]
        public void OnHandQuantityPalletsTest()
        {
            // TODO unit test for the property 'OnHandQuantityPallets'
        }
        /// <summary>
        /// Test the property 'OpenOrderQuantityCases'
        /// </summary>
        [Test]
        public void OpenOrderQuantityCasesTest()
        {
            // TODO unit test for the property 'OpenOrderQuantityCases'
        }
        /// <summary>
        /// Test the property 'OpenOrderQuantityInnerPacks'
        /// </summary>
        [Test]
        public void OpenOrderQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'OpenOrderQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'OpenOrderQuantityPallets'
        /// </summary>
        [Test]
        public void OpenOrderQuantityPalletsTest()
        {
            // TODO unit test for the property 'OpenOrderQuantityPallets'
        }
        /// <summary>
        /// Test the property 'OpenPOQuantityCases'
        /// </summary>
        [Test]
        public void OpenPOQuantityCasesTest()
        {
            // TODO unit test for the property 'OpenPOQuantityCases'
        }
        /// <summary>
        /// Test the property 'OpenPOQuantityInnerPacks'
        /// </summary>
        [Test]
        public void OpenPOQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'OpenPOQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'OpenPOQuantityPallets'
        /// </summary>
        [Test]
        public void OpenPOQuantityPalletsTest()
        {
            // TODO unit test for the property 'OpenPOQuantityPallets'
        }
        /// <summary>
        /// Test the property 'OrderableQuantityCases'
        /// </summary>
        [Test]
        public void OrderableQuantityCasesTest()
        {
            // TODO unit test for the property 'OrderableQuantityCases'
        }
        /// <summary>
        /// Test the property 'OrderableQuantityInnerPacks'
        /// </summary>
        [Test]
        public void OrderableQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'OrderableQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'OrderableQuantityPallets'
        /// </summary>
        [Test]
        public void OrderableQuantityPalletsTest()
        {
            // TODO unit test for the property 'OrderableQuantityPallets'
        }
        /// <summary>
        /// Test the property 'UnallocatableQuantityCases'
        /// </summary>
        [Test]
        public void UnallocatableQuantityCasesTest()
        {
            // TODO unit test for the property 'UnallocatableQuantityCases'
        }
        /// <summary>
        /// Test the property 'UnallocatableQuantityInnerPacks'
        /// </summary>
        [Test]
        public void UnallocatableQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'UnallocatableQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'UnallocatableQuantityPallets'
        /// </summary>
        [Test]
        public void UnallocatableQuantityPalletsTest()
        {
            // TODO unit test for the property 'UnallocatableQuantityPallets'
        }
        /// <summary>
        /// Test the property 'UnavailableQuantityCases'
        /// </summary>
        [Test]
        public void UnavailableQuantityCasesTest()
        {
            // TODO unit test for the property 'UnavailableQuantityCases'
        }
        /// <summary>
        /// Test the property 'UnavailableQuantityInnerPacks'
        /// </summary>
        [Test]
        public void UnavailableQuantityInnerPacksTest()
        {
            // TODO unit test for the property 'UnavailableQuantityInnerPacks'
        }
        /// <summary>
        /// Test the property 'UnavailableQuantityPallets'
        /// </summary>
        [Test]
        public void UnavailableQuantityPalletsTest()
        {
            // TODO unit test for the property 'UnavailableQuantityPallets'
        }
        /// <summary>
        /// Test the property 'TotalDemand'
        /// </summary>
        [Test]
        public void TotalDemandTest()
        {
            // TODO unit test for the property 'TotalDemand'
        }
        /// <summary>
        /// Test the property 'NextRequestDeliveryDate'
        /// </summary>
        [Test]
        public void NextRequestDeliveryDateTest()
        {
            // TODO unit test for the property 'NextRequestDeliveryDate'
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
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }

    }

}