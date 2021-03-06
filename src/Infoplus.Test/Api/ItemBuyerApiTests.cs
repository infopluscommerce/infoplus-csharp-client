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
    ///  Class for testing ItemBuyerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemBuyerApiTests
    {
        private ItemBuyerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemBuyerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemBuyerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemBuyerApi
            //Assert.IsInstanceOfType(typeof(ItemBuyerApi), instance, "instance is a ItemBuyerApi");
        }

        
        /// <summary>
        /// Test AddItemBuyer
        /// </summary>
        [Test]
        public void AddItemBuyerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemBuyer body = null;
            //var response = instance.AddItemBuyer(body);
            //Assert.IsInstanceOf<ItemBuyer> (response, "response is ItemBuyer");
        }
        
        /// <summary>
        /// Test AddItemBuyerAudit
        /// </summary>
        [Test]
        public void AddItemBuyerAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //string itemBuyerAudit = null;
            //instance.AddItemBuyerAudit(itemBuyerId, itemBuyerAudit);
            
        }
        
        /// <summary>
        /// Test AddItemBuyerFile
        /// </summary>
        [Test]
        public void AddItemBuyerFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //string fileName = null;
            //instance.AddItemBuyerFile(itemBuyerId, fileName);
            
        }
        
        /// <summary>
        /// Test AddItemBuyerFileByURL
        /// </summary>
        [Test]
        public void AddItemBuyerFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? itemBuyerId = null;
            //instance.AddItemBuyerFileByURL(body, itemBuyerId);
            
        }
        
        /// <summary>
        /// Test AddItemBuyerTag
        /// </summary>
        [Test]
        public void AddItemBuyerTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //string itemBuyerTag = null;
            //instance.AddItemBuyerTag(itemBuyerId, itemBuyerTag);
            
        }
        
        /// <summary>
        /// Test DeleteItemBuyer
        /// </summary>
        [Test]
        public void DeleteItemBuyerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //instance.DeleteItemBuyer(itemBuyerId);
            
        }
        
        /// <summary>
        /// Test DeleteItemBuyerFile
        /// </summary>
        [Test]
        public void DeleteItemBuyerFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //int? fileId = null;
            //instance.DeleteItemBuyerFile(itemBuyerId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteItemBuyerTag
        /// </summary>
        [Test]
        public void DeleteItemBuyerTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //string itemBuyerTag = null;
            //instance.DeleteItemBuyerTag(itemBuyerId, itemBuyerTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateItemBuyerById
        /// </summary>
        [Test]
        public void GetDuplicateItemBuyerByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //var response = instance.GetDuplicateItemBuyerById(itemBuyerId);
            //Assert.IsInstanceOf<ItemBuyer> (response, "response is ItemBuyer");
        }
        
        /// <summary>
        /// Test GetItemBuyerByFilter
        /// </summary>
        [Test]
        public void GetItemBuyerByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetItemBuyerByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ItemBuyer>> (response, "response is List<ItemBuyer>");
        }
        
        /// <summary>
        /// Test GetItemBuyerById
        /// </summary>
        [Test]
        public void GetItemBuyerByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //var response = instance.GetItemBuyerById(itemBuyerId);
            //Assert.IsInstanceOf<ItemBuyer> (response, "response is ItemBuyer");
        }
        
        /// <summary>
        /// Test GetItemBuyerFiles
        /// </summary>
        [Test]
        public void GetItemBuyerFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //instance.GetItemBuyerFiles(itemBuyerId);
            
        }
        
        /// <summary>
        /// Test GetItemBuyerTags
        /// </summary>
        [Test]
        public void GetItemBuyerTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? itemBuyerId = null;
            //instance.GetItemBuyerTags(itemBuyerId);
            
        }
        
        /// <summary>
        /// Test UpdateItemBuyer
        /// </summary>
        [Test]
        public void UpdateItemBuyerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemBuyer body = null;
            //instance.UpdateItemBuyer(body);
            
        }
        
    }

}
