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
    ///  Class for testing ExternalShippingSystemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExternalShippingSystemApiTests
    {
        private ExternalShippingSystemApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExternalShippingSystemApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalShippingSystemApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExternalShippingSystemApi
            //Assert.IsInstanceOfType(typeof(ExternalShippingSystemApi), instance, "instance is a ExternalShippingSystemApi");
        }

        
        /// <summary>
        /// Test AddExternalShippingSystem
        /// </summary>
        [Test]
        public void AddExternalShippingSystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExternalShippingSystem body = null;
            //var response = instance.AddExternalShippingSystem(body);
            //Assert.IsInstanceOf<ExternalShippingSystem> (response, "response is ExternalShippingSystem");
        }
        
        /// <summary>
        /// Test AddExternalShippingSystemAudit
        /// </summary>
        [Test]
        public void AddExternalShippingSystemAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //string externalShippingSystemAudit = null;
            //instance.AddExternalShippingSystemAudit(externalShippingSystemId, externalShippingSystemAudit);
            
        }
        
        /// <summary>
        /// Test AddExternalShippingSystemFile
        /// </summary>
        [Test]
        public void AddExternalShippingSystemFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //string fileName = null;
            //instance.AddExternalShippingSystemFile(externalShippingSystemId, fileName);
            
        }
        
        /// <summary>
        /// Test AddExternalShippingSystemTag
        /// </summary>
        [Test]
        public void AddExternalShippingSystemTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //string externalShippingSystemTag = null;
            //instance.AddExternalShippingSystemTag(externalShippingSystemId, externalShippingSystemTag);
            
        }
        
        /// <summary>
        /// Test DeleteExternalShippingSystem
        /// </summary>
        [Test]
        public void DeleteExternalShippingSystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //instance.DeleteExternalShippingSystem(externalShippingSystemId);
            
        }
        
        /// <summary>
        /// Test DeleteExternalShippingSystemTag
        /// </summary>
        [Test]
        public void DeleteExternalShippingSystemTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //string externalShippingSystemTag = null;
            //instance.DeleteExternalShippingSystemTag(externalShippingSystemId, externalShippingSystemTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateExternalShippingSystemById
        /// </summary>
        [Test]
        public void GetDuplicateExternalShippingSystemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //var response = instance.GetDuplicateExternalShippingSystemById(externalShippingSystemId);
            //Assert.IsInstanceOf<ExternalShippingSystem> (response, "response is ExternalShippingSystem");
        }
        
        /// <summary>
        /// Test GetExternalShippingSystemByFilter
        /// </summary>
        [Test]
        public void GetExternalShippingSystemByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetExternalShippingSystemByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ExternalShippingSystem>> (response, "response is List<ExternalShippingSystem>");
        }
        
        /// <summary>
        /// Test GetExternalShippingSystemById
        /// </summary>
        [Test]
        public void GetExternalShippingSystemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //var response = instance.GetExternalShippingSystemById(externalShippingSystemId);
            //Assert.IsInstanceOf<ExternalShippingSystem> (response, "response is ExternalShippingSystem");
        }
        
        /// <summary>
        /// Test GetExternalShippingSystemTags
        /// </summary>
        [Test]
        public void GetExternalShippingSystemTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? externalShippingSystemId = null;
            //instance.GetExternalShippingSystemTags(externalShippingSystemId);
            
        }
        
        /// <summary>
        /// Test UpdateExternalShippingSystem
        /// </summary>
        [Test]
        public void UpdateExternalShippingSystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExternalShippingSystem body = null;
            //instance.UpdateExternalShippingSystem(body);
            
        }
        
        /// <summary>
        /// Test UpdateExternalShippingSystemCustomFields
        /// </summary>
        [Test]
        public void UpdateExternalShippingSystemCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExternalShippingSystem body = null;
            //instance.UpdateExternalShippingSystemCustomFields(body);
            
        }
        
    }

}