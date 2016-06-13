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
    ///  Class for testing QuickReceiptApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class QuickReceiptApiTests
    {
        private QuickReceiptApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuickReceiptApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuickReceiptApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' QuickReceiptApi
            Assert.IsInstanceOfType(typeof(QuickReceiptApi), instance, "instance is a QuickReceiptApi");
        }

        
        /// <summary>
        /// Test AddQuickReceipt
        /// </summary>
        [Test]
        public void AddQuickReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickReceipt body = null;
            //var response = instance.AddQuickReceipt(body);
            //Assert.IsInstanceOf<QuickReceipt> (response, "response is QuickReceipt");
        }
        
        /// <summary>
        /// Test DeleteQuickReceipt
        /// </summary>
        [Test]
        public void DeleteQuickReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickReceiptId = null;
            //instance.DeleteQuickReceipt(quickReceiptId);
            
        }
        
        /// <summary>
        /// Test GetQuickReceiptByFilter
        /// </summary>
        [Test]
        public void GetQuickReceiptByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetQuickReceiptByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<QuickReceipt>> (response, "response is List<QuickReceipt>");
        }
        
        /// <summary>
        /// Test GetQuickReceiptById
        /// </summary>
        [Test]
        public void GetQuickReceiptByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quickReceiptId = null;
            //var response = instance.GetQuickReceiptById(quickReceiptId);
            //Assert.IsInstanceOf<QuickReceipt> (response, "response is QuickReceipt");
        }
        
        /// <summary>
        /// Test UpdateQuickReceipt
        /// </summary>
        [Test]
        public void UpdateQuickReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickReceipt body = null;
            //instance.UpdateQuickReceipt(body);
            
        }
        
    }

}
