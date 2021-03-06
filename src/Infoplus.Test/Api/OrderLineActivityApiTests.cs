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
    ///  Class for testing OrderLineActivityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderLineActivityApiTests
    {
        private OrderLineActivityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderLineActivityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderLineActivityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderLineActivityApi
            //Assert.IsInstanceOfType(typeof(OrderLineActivityApi), instance, "instance is a OrderLineActivityApi");
        }

        
        /// <summary>
        /// Test AddOrderLineActivity
        /// </summary>
        [Test]
        public void AddOrderLineActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderLineActivity body = null;
            //var response = instance.AddOrderLineActivity(body);
            //Assert.IsInstanceOf<OrderLineActivity> (response, "response is OrderLineActivity");
        }
        
        /// <summary>
        /// Test AddOrderLineActivityAudit
        /// </summary>
        [Test]
        public void AddOrderLineActivityAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //string orderLineActivityAudit = null;
            //instance.AddOrderLineActivityAudit(orderLineActivityId, orderLineActivityAudit);
            
        }
        
        /// <summary>
        /// Test AddOrderLineActivityFile
        /// </summary>
        [Test]
        public void AddOrderLineActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //string fileName = null;
            //instance.AddOrderLineActivityFile(orderLineActivityId, fileName);
            
        }
        
        /// <summary>
        /// Test AddOrderLineActivityFileByURL
        /// </summary>
        [Test]
        public void AddOrderLineActivityFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? orderLineActivityId = null;
            //instance.AddOrderLineActivityFileByURL(body, orderLineActivityId);
            
        }
        
        /// <summary>
        /// Test AddOrderLineActivityTag
        /// </summary>
        [Test]
        public void AddOrderLineActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //string orderLineActivityTag = null;
            //instance.AddOrderLineActivityTag(orderLineActivityId, orderLineActivityTag);
            
        }
        
        /// <summary>
        /// Test DeleteOrderLineActivity
        /// </summary>
        [Test]
        public void DeleteOrderLineActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //instance.DeleteOrderLineActivity(orderLineActivityId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderLineActivityFile
        /// </summary>
        [Test]
        public void DeleteOrderLineActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //int? fileId = null;
            //instance.DeleteOrderLineActivityFile(orderLineActivityId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderLineActivityTag
        /// </summary>
        [Test]
        public void DeleteOrderLineActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //string orderLineActivityTag = null;
            //instance.DeleteOrderLineActivityTag(orderLineActivityId, orderLineActivityTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOrderLineActivityById
        /// </summary>
        [Test]
        public void GetDuplicateOrderLineActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //var response = instance.GetDuplicateOrderLineActivityById(orderLineActivityId);
            //Assert.IsInstanceOf<OrderLineActivity> (response, "response is OrderLineActivity");
        }
        
        /// <summary>
        /// Test GetOrderLineActivityByFilter
        /// </summary>
        [Test]
        public void GetOrderLineActivityByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderLineActivityByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OrderLineActivity>> (response, "response is List<OrderLineActivity>");
        }
        
        /// <summary>
        /// Test GetOrderLineActivityById
        /// </summary>
        [Test]
        public void GetOrderLineActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //var response = instance.GetOrderLineActivityById(orderLineActivityId);
            //Assert.IsInstanceOf<OrderLineActivity> (response, "response is OrderLineActivity");
        }
        
        /// <summary>
        /// Test GetOrderLineActivityFiles
        /// </summary>
        [Test]
        public void GetOrderLineActivityFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //instance.GetOrderLineActivityFiles(orderLineActivityId);
            
        }
        
        /// <summary>
        /// Test GetOrderLineActivityTags
        /// </summary>
        [Test]
        public void GetOrderLineActivityTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderLineActivityId = null;
            //instance.GetOrderLineActivityTags(orderLineActivityId);
            
        }
        
        /// <summary>
        /// Test UpdateOrderLineActivity
        /// </summary>
        [Test]
        public void UpdateOrderLineActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderLineActivity body = null;
            //instance.UpdateOrderLineActivity(body);
            
        }
        
    }

}
