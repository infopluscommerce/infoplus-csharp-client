/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v3.0
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
    ///  Class for testing OrderActivityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderActivityApiTests
    {
        private OrderActivityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderActivityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderActivityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderActivityApi
            //Assert.IsInstanceOfType(typeof(OrderActivityApi), instance, "instance is a OrderActivityApi");
        }

        
        /// <summary>
        /// Test AddOrderActivity
        /// </summary>
        [Test]
        public void AddOrderActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderActivity body = null;
            //var response = instance.AddOrderActivity(body);
            //Assert.IsInstanceOf<OrderActivity> (response, "response is OrderActivity");
        }
        
        /// <summary>
        /// Test AddOrderActivityAudit
        /// </summary>
        [Test]
        public void AddOrderActivityAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //string orderActivityAudit = null;
            //instance.AddOrderActivityAudit(orderActivityId, orderActivityAudit);
            
        }
        
        /// <summary>
        /// Test AddOrderActivityFile
        /// </summary>
        [Test]
        public void AddOrderActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //string fileName = null;
            //instance.AddOrderActivityFile(orderActivityId, fileName);
            
        }
        
        /// <summary>
        /// Test AddOrderActivityFileByURL
        /// </summary>
        [Test]
        public void AddOrderActivityFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //decimal? orderActivityId = null;
            //instance.AddOrderActivityFileByURL(body, orderActivityId);
            
        }
        
        /// <summary>
        /// Test AddOrderActivityTag
        /// </summary>
        [Test]
        public void AddOrderActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //string orderActivityTag = null;
            //instance.AddOrderActivityTag(orderActivityId, orderActivityTag);
            
        }
        
        /// <summary>
        /// Test DeleteOrderActivity
        /// </summary>
        [Test]
        public void DeleteOrderActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //instance.DeleteOrderActivity(orderActivityId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderActivityFile
        /// </summary>
        [Test]
        public void DeleteOrderActivityFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //int? fileId = null;
            //instance.DeleteOrderActivityFile(orderActivityId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteOrderActivityTag
        /// </summary>
        [Test]
        public void DeleteOrderActivityTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //string orderActivityTag = null;
            //instance.DeleteOrderActivityTag(orderActivityId, orderActivityTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOrderActivityById
        /// </summary>
        [Test]
        public void GetDuplicateOrderActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //var response = instance.GetDuplicateOrderActivityById(orderActivityId);
            //Assert.IsInstanceOf<OrderActivity> (response, "response is OrderActivity");
        }
        
        /// <summary>
        /// Test GetOrderActivityByFilter
        /// </summary>
        [Test]
        public void GetOrderActivityByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderActivityByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OrderActivity>> (response, "response is List<OrderActivity>");
        }
        
        /// <summary>
        /// Test GetOrderActivityById
        /// </summary>
        [Test]
        public void GetOrderActivityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //var response = instance.GetOrderActivityById(orderActivityId);
            //Assert.IsInstanceOf<OrderActivity> (response, "response is OrderActivity");
        }
        
        /// <summary>
        /// Test GetOrderActivityFiles
        /// </summary>
        [Test]
        public void GetOrderActivityFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //instance.GetOrderActivityFiles(orderActivityId);
            
        }
        
        /// <summary>
        /// Test GetOrderActivityTags
        /// </summary>
        [Test]
        public void GetOrderActivityTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? orderActivityId = null;
            //instance.GetOrderActivityTags(orderActivityId);
            
        }
        
        /// <summary>
        /// Test UpdateOrderActivity
        /// </summary>
        [Test]
        public void UpdateOrderActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderActivity body = null;
            //instance.UpdateOrderActivity(body);
            
        }
        
    }

}
