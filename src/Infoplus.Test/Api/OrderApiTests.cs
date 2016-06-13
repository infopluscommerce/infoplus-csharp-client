/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v1.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderApiTests
    {
        private OrderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' OrderApi
            Assert.IsInstanceOfType(typeof(OrderApi), instance, "instance is a OrderApi");
        }

        
        /// <summary>
        /// Test AddOrder
        /// </summary>
        [Test]
        public void AddOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Order body = null;
            //var response = instance.AddOrder(body);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test DeleteOrder
        /// </summary>
        [Test]
        public void DeleteOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //double? orderId = null;
            //instance.DeleteOrder(orderId);
            
        }
        
        /// <summary>
        /// Test GetOrderByFilter
        /// </summary>
        [Test]
        public void GetOrderByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOrderByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test GetOrderById
        /// </summary>
        [Test]
        public void GetOrderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //double? orderId = null;
            //var response = instance.GetOrderById(orderId);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test UpdateOrder
        /// </summary>
        [Test]
        public void UpdateOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Order body = null;
            //instance.UpdateOrder(body);
            
        }
        
    }

}
