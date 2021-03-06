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
    ///  Class for testing ShoppingCartConnection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ShoppingCartConnectionTests
    {
        // TODO uncomment below to declare an instance variable for ShoppingCartConnection
        //private ShoppingCartConnection instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ShoppingCartConnection
            //instance = new ShoppingCartConnection();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShoppingCartConnection
        /// </summary>
        [Test]
        public void ShoppingCartConnectionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ShoppingCartConnection
            //Assert.IsInstanceOfType<ShoppingCartConnection> (instance, "variable 'instance' is a ShoppingCartConnection");
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
        /// Test the property 'ClientId'
        /// </summary>
        [Test]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }
        /// <summary>
        /// Test the property 'Nonce'
        /// </summary>
        [Test]
        public void NonceTest()
        {
            // TODO unit test for the property 'Nonce'
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
        /// Test the property 'OrderSourceId'
        /// </summary>
        [Test]
        public void OrderSourceIdTest()
        {
            // TODO unit test for the property 'OrderSourceId'
        }
        /// <summary>
        /// Test the property 'IntegrationPartnerId'
        /// </summary>
        [Test]
        public void IntegrationPartnerIdTest()
        {
            // TODO unit test for the property 'IntegrationPartnerId'
        }
        /// <summary>
        /// Test the property 'ConnectionType'
        /// </summary>
        [Test]
        public void ConnectionTypeTest()
        {
            // TODO unit test for the property 'ConnectionType'
        }
        /// <summary>
        /// Test the property 'ItemFilterId'
        /// </summary>
        [Test]
        public void ItemFilterIdTest()
        {
            // TODO unit test for the property 'ItemFilterId'
        }
        /// <summary>
        /// Test the property 'InfoplusSKUFieldToMap'
        /// </summary>
        [Test]
        public void InfoplusSKUFieldToMapTest()
        {
            // TODO unit test for the property 'InfoplusSKUFieldToMap'
        }
        /// <summary>
        /// Test the property 'ShoppingCartSKUFieldToMap'
        /// </summary>
        [Test]
        public void ShoppingCartSKUFieldToMapTest()
        {
            // TODO unit test for the property 'ShoppingCartSKUFieldToMap'
        }
        /// <summary>
        /// Test the property 'ScriptId'
        /// </summary>
        [Test]
        public void ScriptIdTest()
        {
            // TODO unit test for the property 'ScriptId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ShoppingCartStoreURL'
        /// </summary>
        [Test]
        public void ShoppingCartStoreURLTest()
        {
            // TODO unit test for the property 'ShoppingCartStoreURL'
        }
        /// <summary>
        /// Test the property 'AccessCode'
        /// </summary>
        [Test]
        public void AccessCodeTest()
        {
            // TODO unit test for the property 'AccessCode'
        }
        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Test]
        public void AccessTokenTest()
        {
            // TODO unit test for the property 'AccessToken'
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Test]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'DefaultCarrierId'
        /// </summary>
        [Test]
        public void DefaultCarrierIdTest()
        {
            // TODO unit test for the property 'DefaultCarrierId'
        }
        /// <summary>
        /// Test the property 'OrderShipmentLevel'
        /// </summary>
        [Test]
        public void OrderShipmentLevelTest()
        {
            // TODO unit test for the property 'OrderShipmentLevel'
        }
        /// <summary>
        /// Test the property 'CreateInvoices'
        /// </summary>
        [Test]
        public void CreateInvoicesTest()
        {
            // TODO unit test for the property 'CreateInvoices'
        }
        /// <summary>
        /// Test the property 'SyncOrders'
        /// </summary>
        [Test]
        public void SyncOrdersTest()
        {
            // TODO unit test for the property 'SyncOrders'
        }
        /// <summary>
        /// Test the property 'SyncInventory'
        /// </summary>
        [Test]
        public void SyncInventoryTest()
        {
            // TODO unit test for the property 'SyncInventory'
        }
        /// <summary>
        /// Test the property 'SyncTrackingData'
        /// </summary>
        [Test]
        public void SyncTrackingDataTest()
        {
            // TODO unit test for the property 'SyncTrackingData'
        }
        /// <summary>
        /// Test the property 'SyncInventoryCronString'
        /// </summary>
        [Test]
        public void SyncInventoryCronStringTest()
        {
            // TODO unit test for the property 'SyncInventoryCronString'
        }
        /// <summary>
        /// Test the property 'FulfillAllItems'
        /// </summary>
        [Test]
        public void FulfillAllItemsTest()
        {
            // TODO unit test for the property 'FulfillAllItems'
        }
        /// <summary>
        /// Test the property 'SyncInventoryLevelsLastRunTime'
        /// </summary>
        [Test]
        public void SyncInventoryLevelsLastRunTimeTest()
        {
            // TODO unit test for the property 'SyncInventoryLevelsLastRunTime'
        }
        /// <summary>
        /// Test the property 'SyncOrdersLastRunTime'
        /// </summary>
        [Test]
        public void SyncOrdersLastRunTimeTest()
        {
            // TODO unit test for the property 'SyncOrdersLastRunTime'
        }
        /// <summary>
        /// Test the property 'InventoryLevelWarehouseControls'
        /// </summary>
        [Test]
        public void InventoryLevelWarehouseControlsTest()
        {
            // TODO unit test for the property 'InventoryLevelWarehouseControls'
        }
        /// <summary>
        /// Test the property 'WarehouseList'
        /// </summary>
        [Test]
        public void WarehouseListTest()
        {
            // TODO unit test for the property 'WarehouseList'
        }
        /// <summary>
        /// Test the property 'InventoryLevelStoreControls'
        /// </summary>
        [Test]
        public void InventoryLevelStoreControlsTest()
        {
            // TODO unit test for the property 'InventoryLevelStoreControls'
        }
        /// <summary>
        /// Test the property 'StoreList'
        /// </summary>
        [Test]
        public void StoreListTest()
        {
            // TODO unit test for the property 'StoreList'
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
