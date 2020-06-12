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
    ///  Class for testing ShoppingCartConnectionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ShoppingCartConnectionApiTests
    {
        private ShoppingCartConnectionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ShoppingCartConnectionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShoppingCartConnectionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ShoppingCartConnectionApi
            //Assert.IsInstanceOfType(typeof(ShoppingCartConnectionApi), instance, "instance is a ShoppingCartConnectionApi");
        }

        
        /// <summary>
        /// Test AddShoppingCartConnection
        /// </summary>
        [Test]
        public void AddShoppingCartConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShoppingCartConnection body = null;
            //var response = instance.AddShoppingCartConnection(body);
            //Assert.IsInstanceOf<ShoppingCartConnection> (response, "response is ShoppingCartConnection");
        }
        
        /// <summary>
        /// Test AddShoppingCartConnectionAudit
        /// </summary>
        [Test]
        public void AddShoppingCartConnectionAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //string shoppingCartConnectionAudit = null;
            //instance.AddShoppingCartConnectionAudit(shoppingCartConnectionId, shoppingCartConnectionAudit);
            
        }
        
        /// <summary>
        /// Test AddShoppingCartConnectionFile
        /// </summary>
        [Test]
        public void AddShoppingCartConnectionFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //string fileName = null;
            //instance.AddShoppingCartConnectionFile(shoppingCartConnectionId, fileName);
            
        }
        
        /// <summary>
        /// Test AddShoppingCartConnectionFileByURL
        /// </summary>
        [Test]
        public void AddShoppingCartConnectionFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? shoppingCartConnectionId = null;
            //instance.AddShoppingCartConnectionFileByURL(body, shoppingCartConnectionId);
            
        }
        
        /// <summary>
        /// Test AddShoppingCartConnectionTag
        /// </summary>
        [Test]
        public void AddShoppingCartConnectionTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //string shoppingCartConnectionTag = null;
            //instance.AddShoppingCartConnectionTag(shoppingCartConnectionId, shoppingCartConnectionTag);
            
        }
        
        /// <summary>
        /// Test DeleteShoppingCartConnection
        /// </summary>
        [Test]
        public void DeleteShoppingCartConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //instance.DeleteShoppingCartConnection(shoppingCartConnectionId);
            
        }
        
        /// <summary>
        /// Test DeleteShoppingCartConnectionFile
        /// </summary>
        [Test]
        public void DeleteShoppingCartConnectionFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //int? fileId = null;
            //instance.DeleteShoppingCartConnectionFile(shoppingCartConnectionId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteShoppingCartConnectionTag
        /// </summary>
        [Test]
        public void DeleteShoppingCartConnectionTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //string shoppingCartConnectionTag = null;
            //instance.DeleteShoppingCartConnectionTag(shoppingCartConnectionId, shoppingCartConnectionTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateShoppingCartConnectionById
        /// </summary>
        [Test]
        public void GetDuplicateShoppingCartConnectionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //var response = instance.GetDuplicateShoppingCartConnectionById(shoppingCartConnectionId);
            //Assert.IsInstanceOf<ShoppingCartConnection> (response, "response is ShoppingCartConnection");
        }
        
        /// <summary>
        /// Test GetShoppingCartConnectionByFilter
        /// </summary>
        [Test]
        public void GetShoppingCartConnectionByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetShoppingCartConnectionByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ShoppingCartConnection>> (response, "response is List<ShoppingCartConnection>");
        }
        
        /// <summary>
        /// Test GetShoppingCartConnectionById
        /// </summary>
        [Test]
        public void GetShoppingCartConnectionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //var response = instance.GetShoppingCartConnectionById(shoppingCartConnectionId);
            //Assert.IsInstanceOf<ShoppingCartConnection> (response, "response is ShoppingCartConnection");
        }
        
        /// <summary>
        /// Test GetShoppingCartConnectionFiles
        /// </summary>
        [Test]
        public void GetShoppingCartConnectionFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //instance.GetShoppingCartConnectionFiles(shoppingCartConnectionId);
            
        }
        
        /// <summary>
        /// Test GetShoppingCartConnectionTags
        /// </summary>
        [Test]
        public void GetShoppingCartConnectionTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? shoppingCartConnectionId = null;
            //instance.GetShoppingCartConnectionTags(shoppingCartConnectionId);
            
        }
        
        /// <summary>
        /// Test UpdateShoppingCartConnection
        /// </summary>
        [Test]
        public void UpdateShoppingCartConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShoppingCartConnection body = null;
            //instance.UpdateShoppingCartConnection(body);
            
        }
        
        /// <summary>
        /// Test UpdateShoppingCartConnectionCustomFields
        /// </summary>
        [Test]
        public void UpdateShoppingCartConnectionCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShoppingCartConnection body = null;
            //instance.UpdateShoppingCartConnectionCustomFields(body);
            
        }
        
    }

}
