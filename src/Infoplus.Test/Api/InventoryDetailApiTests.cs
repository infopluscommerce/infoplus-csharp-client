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
    ///  Class for testing InventoryDetailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InventoryDetailApiTests
    {
        private InventoryDetailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InventoryDetailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InventoryDetailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InventoryDetailApi
            //Assert.IsInstanceOfType(typeof(InventoryDetailApi), instance, "instance is a InventoryDetailApi");
        }

        
        /// <summary>
        /// Test AddInventoryDetailAudit
        /// </summary>
        [Test]
        public void AddInventoryDetailAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //string inventoryDetailAudit = null;
            //instance.AddInventoryDetailAudit(inventoryDetailId, inventoryDetailAudit);
            
        }
        
        /// <summary>
        /// Test AddInventoryDetailFile
        /// </summary>
        [Test]
        public void AddInventoryDetailFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //string fileName = null;
            //instance.AddInventoryDetailFile(inventoryDetailId, fileName);
            
        }
        
        /// <summary>
        /// Test AddInventoryDetailFileByURL
        /// </summary>
        [Test]
        public void AddInventoryDetailFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? inventoryDetailId = null;
            //instance.AddInventoryDetailFileByURL(body, inventoryDetailId);
            
        }
        
        /// <summary>
        /// Test AddInventoryDetailTag
        /// </summary>
        [Test]
        public void AddInventoryDetailTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //string inventoryDetailTag = null;
            //instance.AddInventoryDetailTag(inventoryDetailId, inventoryDetailTag);
            
        }
        
        /// <summary>
        /// Test DeleteInventoryDetailFile
        /// </summary>
        [Test]
        public void DeleteInventoryDetailFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //int? fileId = null;
            //instance.DeleteInventoryDetailFile(inventoryDetailId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteInventoryDetailTag
        /// </summary>
        [Test]
        public void DeleteInventoryDetailTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //string inventoryDetailTag = null;
            //instance.DeleteInventoryDetailTag(inventoryDetailId, inventoryDetailTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateInventoryDetailById
        /// </summary>
        [Test]
        public void GetDuplicateInventoryDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //var response = instance.GetDuplicateInventoryDetailById(inventoryDetailId);
            //Assert.IsInstanceOf<InventoryDetail> (response, "response is InventoryDetail");
        }
        
        /// <summary>
        /// Test GetInventoryDetailByFilter
        /// </summary>
        [Test]
        public void GetInventoryDetailByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetInventoryDetailByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<InventoryDetail>> (response, "response is List<InventoryDetail>");
        }
        
        /// <summary>
        /// Test GetInventoryDetailById
        /// </summary>
        [Test]
        public void GetInventoryDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //var response = instance.GetInventoryDetailById(inventoryDetailId);
            //Assert.IsInstanceOf<InventoryDetail> (response, "response is InventoryDetail");
        }
        
        /// <summary>
        /// Test GetInventoryDetailFiles
        /// </summary>
        [Test]
        public void GetInventoryDetailFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //instance.GetInventoryDetailFiles(inventoryDetailId);
            
        }
        
        /// <summary>
        /// Test GetInventoryDetailTags
        /// </summary>
        [Test]
        public void GetInventoryDetailTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? inventoryDetailId = null;
            //instance.GetInventoryDetailTags(inventoryDetailId);
            
        }
        
        /// <summary>
        /// Test UpdateInventoryDetailCustomFields
        /// </summary>
        [Test]
        public void UpdateInventoryDetailCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InventoryDetail body = null;
            //instance.UpdateInventoryDetailCustomFields(body);
            
        }
        
    }

}
