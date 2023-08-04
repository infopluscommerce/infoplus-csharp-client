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
    ///  Class for testing OverrideReturnAddressApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OverrideReturnAddressApiTests
    {
        private OverrideReturnAddressApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OverrideReturnAddressApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OverrideReturnAddressApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OverrideReturnAddressApi
            //Assert.IsInstanceOfType(typeof(OverrideReturnAddressApi), instance, "instance is a OverrideReturnAddressApi");
        }

        
        /// <summary>
        /// Test AddOverrideReturnAddress
        /// </summary>
        [Test]
        public void AddOverrideReturnAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OverrideReturnAddress body = null;
            //var response = instance.AddOverrideReturnAddress(body);
            //Assert.IsInstanceOf<OverrideReturnAddress> (response, "response is OverrideReturnAddress");
        }
        
        /// <summary>
        /// Test AddOverrideReturnAddressAudit
        /// </summary>
        [Test]
        public void AddOverrideReturnAddressAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //string overrideReturnAddressAudit = null;
            //instance.AddOverrideReturnAddressAudit(overrideReturnAddressId, overrideReturnAddressAudit);
            
        }
        
        /// <summary>
        /// Test AddOverrideReturnAddressFile
        /// </summary>
        [Test]
        public void AddOverrideReturnAddressFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //string fileName = null;
            //instance.AddOverrideReturnAddressFile(overrideReturnAddressId, fileName);
            
        }
        
        /// <summary>
        /// Test AddOverrideReturnAddressFileByURL
        /// </summary>
        [Test]
        public void AddOverrideReturnAddressFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? overrideReturnAddressId = null;
            //instance.AddOverrideReturnAddressFileByURL(body, overrideReturnAddressId);
            
        }
        
        /// <summary>
        /// Test AddOverrideReturnAddressTag
        /// </summary>
        [Test]
        public void AddOverrideReturnAddressTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //string overrideReturnAddressTag = null;
            //instance.AddOverrideReturnAddressTag(overrideReturnAddressId, overrideReturnAddressTag);
            
        }
        
        /// <summary>
        /// Test DeleteOverrideReturnAddress
        /// </summary>
        [Test]
        public void DeleteOverrideReturnAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //instance.DeleteOverrideReturnAddress(overrideReturnAddressId);
            
        }
        
        /// <summary>
        /// Test DeleteOverrideReturnAddressFile
        /// </summary>
        [Test]
        public void DeleteOverrideReturnAddressFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //int? fileId = null;
            //instance.DeleteOverrideReturnAddressFile(overrideReturnAddressId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteOverrideReturnAddressTag
        /// </summary>
        [Test]
        public void DeleteOverrideReturnAddressTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //string overrideReturnAddressTag = null;
            //instance.DeleteOverrideReturnAddressTag(overrideReturnAddressId, overrideReturnAddressTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateOverrideReturnAddressById
        /// </summary>
        [Test]
        public void GetDuplicateOverrideReturnAddressByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //var response = instance.GetDuplicateOverrideReturnAddressById(overrideReturnAddressId);
            //Assert.IsInstanceOf<OverrideReturnAddress> (response, "response is OverrideReturnAddress");
        }
        
        /// <summary>
        /// Test GetOverrideReturnAddressByFilter
        /// </summary>
        [Test]
        public void GetOverrideReturnAddressByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetOverrideReturnAddressByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<OverrideReturnAddress>> (response, "response is List<OverrideReturnAddress>");
        }
        
        /// <summary>
        /// Test GetOverrideReturnAddressById
        /// </summary>
        [Test]
        public void GetOverrideReturnAddressByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //var response = instance.GetOverrideReturnAddressById(overrideReturnAddressId);
            //Assert.IsInstanceOf<OverrideReturnAddress> (response, "response is OverrideReturnAddress");
        }
        
        /// <summary>
        /// Test GetOverrideReturnAddressFiles
        /// </summary>
        [Test]
        public void GetOverrideReturnAddressFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //instance.GetOverrideReturnAddressFiles(overrideReturnAddressId);
            
        }
        
        /// <summary>
        /// Test GetOverrideReturnAddressTags
        /// </summary>
        [Test]
        public void GetOverrideReturnAddressTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? overrideReturnAddressId = null;
            //instance.GetOverrideReturnAddressTags(overrideReturnAddressId);
            
        }
        
        /// <summary>
        /// Test UpdateOverrideReturnAddress
        /// </summary>
        [Test]
        public void UpdateOverrideReturnAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OverrideReturnAddress body = null;
            //instance.UpdateOverrideReturnAddress(body);
            
        }
        
        /// <summary>
        /// Test UpdateOverrideReturnAddressCustomFields
        /// </summary>
        [Test]
        public void UpdateOverrideReturnAddressCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OverrideReturnAddress body = null;
            //instance.UpdateOverrideReturnAddressCustomFields(body);
            
        }
        
    }

}
