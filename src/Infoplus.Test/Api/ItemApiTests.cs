/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Infoplus.Client;
using Infoplus.Api;
using Infoplus.Model;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing ItemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemApiTests
    {
        private ItemApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemApi
            //Assert.IsInstanceOfType(typeof(ItemApi), instance, "instance is a ItemApi");
        }

        
        /// <summary>
        /// Test AddItem
        /// </summary>
        [Test]
        public void AddItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item body = null;
            //var response = instance.AddItem(body);
            //Assert.IsInstanceOf<Item> (response, "response is Item");
        }
        
        /// <summary>
        /// Test AddItemAudit
        /// </summary>
        [Test]
        public void AddItemAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //string itemAudit = null;
            //instance.AddItemAudit(itemId, itemAudit);
            
        }
        
        /// <summary>
        /// Test AddItemTag
        /// </summary>
        [Test]
        public void AddItemTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //string itemTag = null;
            //instance.AddItemTag(itemId, itemTag);
            
        }
        
        /// <summary>
        /// Test DeleteItem
        /// </summary>
        [Test]
        public void DeleteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //instance.DeleteItem(itemId);
            
        }
        
        /// <summary>
        /// Test DeleteItemTag
        /// </summary>
        [Test]
        public void DeleteItemTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //string itemTag = null;
            //instance.DeleteItemTag(itemId, itemTag);
            
        }
        
        /// <summary>
        /// Test GetBySKU
        /// </summary>
        [Test]
        public void GetBySKUTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? lobId = null;
            //string sku = null;
            //var response = instance.GetBySKU(lobId, sku);
            //Assert.IsInstanceOf<Item> (response, "response is Item");
        }
        
        /// <summary>
        /// Test GetDuplicateItemById
        /// </summary>
        [Test]
        public void GetDuplicateItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //var response = instance.GetDuplicateItemById(itemId);
            //Assert.IsInstanceOf<Item> (response, "response is Item");
        }
        
        /// <summary>
        /// Test GetItemByFilter
        /// </summary>
        [Test]
        public void GetItemByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetItemByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Item>> (response, "response is List<Item>");
        }
        
        /// <summary>
        /// Test GetItemById
        /// </summary>
        [Test]
        public void GetItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //var response = instance.GetItemById(itemId);
            //Assert.IsInstanceOf<Item> (response, "response is Item");
        }
        
        /// <summary>
        /// Test GetItemTags
        /// </summary>
        [Test]
        public void GetItemTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemId = null;
            //instance.GetItemTags(itemId);
            
        }
        
        /// <summary>
        /// Test UpdateItem
        /// </summary>
        [Test]
        public void UpdateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item body = null;
            //instance.UpdateItem(body);
            
        }
        
        /// <summary>
        /// Test UpdateItemCustomFields
        /// </summary>
        [Test]
        public void UpdateItemCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item body = null;
            //instance.UpdateItemCustomFields(body);
            
        }
        
    }

}