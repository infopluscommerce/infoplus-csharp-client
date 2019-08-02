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
    ///  Class for testing ProductionModelApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductionModelApiTests
    {
        private ProductionModelApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductionModelApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductionModelApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductionModelApi
            //Assert.IsInstanceOfType(typeof(ProductionModelApi), instance, "instance is a ProductionModelApi");
        }

        
        /// <summary>
        /// Test AddProductionModel
        /// </summary>
        [Test]
        public void AddProductionModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionModel body = null;
            //var response = instance.AddProductionModel(body);
            //Assert.IsInstanceOf<ProductionModel> (response, "response is ProductionModel");
        }
        
        /// <summary>
        /// Test AddProductionModelAudit
        /// </summary>
        [Test]
        public void AddProductionModelAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //string productionModelAudit = null;
            //instance.AddProductionModelAudit(productionModelId, productionModelAudit);
            
        }
        
        /// <summary>
        /// Test AddProductionModelFile
        /// </summary>
        [Test]
        public void AddProductionModelFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //string fileName = null;
            //instance.AddProductionModelFile(productionModelId, fileName);
            
        }
        
        /// <summary>
        /// Test AddProductionModelTag
        /// </summary>
        [Test]
        public void AddProductionModelTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //string productionModelTag = null;
            //instance.AddProductionModelTag(productionModelId, productionModelTag);
            
        }
        
        /// <summary>
        /// Test DeleteProductionModel
        /// </summary>
        [Test]
        public void DeleteProductionModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //instance.DeleteProductionModel(productionModelId);
            
        }
        
        /// <summary>
        /// Test DeleteProductionModelTag
        /// </summary>
        [Test]
        public void DeleteProductionModelTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //string productionModelTag = null;
            //instance.DeleteProductionModelTag(productionModelId, productionModelTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateProductionModelById
        /// </summary>
        [Test]
        public void GetDuplicateProductionModelByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //var response = instance.GetDuplicateProductionModelById(productionModelId);
            //Assert.IsInstanceOf<ProductionModel> (response, "response is ProductionModel");
        }
        
        /// <summary>
        /// Test GetProductionModelByFilter
        /// </summary>
        [Test]
        public void GetProductionModelByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetProductionModelByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ProductionModel>> (response, "response is List<ProductionModel>");
        }
        
        /// <summary>
        /// Test GetProductionModelById
        /// </summary>
        [Test]
        public void GetProductionModelByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //var response = instance.GetProductionModelById(productionModelId);
            //Assert.IsInstanceOf<ProductionModel> (response, "response is ProductionModel");
        }
        
        /// <summary>
        /// Test GetProductionModelTags
        /// </summary>
        [Test]
        public void GetProductionModelTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productionModelId = null;
            //instance.GetProductionModelTags(productionModelId);
            
        }
        
        /// <summary>
        /// Test UpdateProductionModel
        /// </summary>
        [Test]
        public void UpdateProductionModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionModel body = null;
            //instance.UpdateProductionModel(body);
            
        }
        
        /// <summary>
        /// Test UpdateProductionModelCustomFields
        /// </summary>
        [Test]
        public void UpdateProductionModelCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductionModel body = null;
            //instance.UpdateProductionModelCustomFields(body);
            
        }
        
    }

}
