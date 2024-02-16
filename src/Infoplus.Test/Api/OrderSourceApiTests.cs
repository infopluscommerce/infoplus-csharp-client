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
    ///  Class for testing OrderSourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderSourceApiTests
    {
        private OrderSourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderSourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderSourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderSourceApi
            //Assert.IsInstanceOfType(typeof(OrderSourceApi), instance, "instance is a OrderSourceApi");
        }

        
        /// <summary>
        /// Test AddOrderSource
        /// </summary>
        [Test]
        public void AddOrderSourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSource body = null;
            //var response = instance.AddOrderSource(body);
            //Assert.IsInstanceOf<OrderSource> (response, "response is OrderSource");
        }
        
        /// <summary>
        /// Test AddOrderSourceAudit
        /// </summary>
        [Test]
        public void AddOrderSourceAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //string orderSourceAudit = null;
            //instance.AddOrderSourceAudit(orderSourceId, orderSourceAudit);
            
        }
        
        /// <summary>
        /// Test AddOrderSourceFile
        /// </summary>
        [Test]
        public void AddOrderSourceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //string fileName = null;
            //instance.AddOrderSourceFile(orderSourceId, fileName);
            
        }
        
        /// <summary>
        /// Test AddOrderSourceFileByURL
        /// </summary>
        [Test]
        public void AddOrderSourceFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? orderSourceId = null;
            //instance.AddOrderSourceFileByURL(body, orderSourceId);
            
        }
        
        /// <summary>
        /// Test AddOrderSourceTag
        /// </summary>
        [Test]
        public void AddOrderSourceTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //string orderSourceTag = null;
            //instance.AddOrderSourceTag(orderSourceId, orderSourceTag);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSource
        /// </summary>
        [Test]
        public void DeleteOrderSourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //instance.DeleteOrderSource(orderSourceId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSourceFile
        /// </summary>
        [Test]
        public void DeleteOrderSourceFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //int? fileId = null;
            //instance.DeleteOrderSourceFile(orderSourceId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderSourceTag
        /// </summary>
        [Test]
        public void DeleteOrderSourceTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //string orderSourceTag = null;
            //instance.DeleteOrderSourceTag(orderSourceId, orderSourceTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOrderSourceById
        /// </summary>
        [Test]
        public void GetDuplicateOrderSourceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //var response = instance.GetDuplicateOrderSourceById(orderSourceId);
            //Assert.IsInstanceOf<OrderSource> (response, "response is OrderSource");
        }
        
        /// <summary>
        /// Test GetOrderSourceByFilter
        /// </summary>
        [Test]
        public void GetOrderSourceByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderSourceByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OrderSource>> (response, "response is List<OrderSource>");
        }
        
        /// <summary>
        /// Test GetOrderSourceById
        /// </summary>
        [Test]
        public void GetOrderSourceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //var response = instance.GetOrderSourceById(orderSourceId);
            //Assert.IsInstanceOf<OrderSource> (response, "response is OrderSource");
        }
        
        /// <summary>
        /// Test GetOrderSourceFiles
        /// </summary>
        [Test]
        public void GetOrderSourceFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //instance.GetOrderSourceFiles(orderSourceId);
            
        }
        
        /// <summary>
        /// Test GetOrderSourceTags
        /// </summary>
        [Test]
        public void GetOrderSourceTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderSourceId = null;
            //instance.GetOrderSourceTags(orderSourceId);
            
        }
        
        /// <summary>
        /// Test UpdateOrderSource
        /// </summary>
        [Test]
        public void UpdateOrderSourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSource body = null;
            //instance.UpdateOrderSource(body);
            
        }
        
        /// <summary>
        /// Test UpdateOrderSourceCustomFields
        /// </summary>
        [Test]
        public void UpdateOrderSourceCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderSource body = null;
            //instance.UpdateOrderSourceCustomFields(body);
            
        }
        
    }

}
