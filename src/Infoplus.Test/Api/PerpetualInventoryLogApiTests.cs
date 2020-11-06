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
    ///  Class for testing PerpetualInventoryLogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PerpetualInventoryLogApiTests
    {
        private PerpetualInventoryLogApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PerpetualInventoryLogApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PerpetualInventoryLogApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PerpetualInventoryLogApi
            //Assert.IsInstanceOfType(typeof(PerpetualInventoryLogApi), instance, "instance is a PerpetualInventoryLogApi");
        }

        
        /// <summary>
        /// Test AddPerpetualInventoryLogAudit
        /// </summary>
        [Test]
        public void AddPerpetualInventoryLogAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //string perpetualInventoryLogAudit = null;
            //instance.AddPerpetualInventoryLogAudit(perpetualInventoryLogId, perpetualInventoryLogAudit);
            
        }
        
        /// <summary>
        /// Test AddPerpetualInventoryLogFile
        /// </summary>
        [Test]
        public void AddPerpetualInventoryLogFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //string fileName = null;
            //instance.AddPerpetualInventoryLogFile(perpetualInventoryLogId, fileName);
            
        }
        
        /// <summary>
        /// Test AddPerpetualInventoryLogFileByURL
        /// </summary>
        [Test]
        public void AddPerpetualInventoryLogFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? perpetualInventoryLogId = null;
            //instance.AddPerpetualInventoryLogFileByURL(body, perpetualInventoryLogId);
            
        }
        
        /// <summary>
        /// Test AddPerpetualInventoryLogTag
        /// </summary>
        [Test]
        public void AddPerpetualInventoryLogTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //string perpetualInventoryLogTag = null;
            //instance.AddPerpetualInventoryLogTag(perpetualInventoryLogId, perpetualInventoryLogTag);
            
        }
        
        /// <summary>
        /// Test DeletePerpetualInventoryLogFile
        /// </summary>
        [Test]
        public void DeletePerpetualInventoryLogFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //int? fileId = null;
            //instance.DeletePerpetualInventoryLogFile(perpetualInventoryLogId, fileId);
            
        }
        
        /// <summary>
        /// Test DeletePerpetualInventoryLogTag
        /// </summary>
        [Test]
        public void DeletePerpetualInventoryLogTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //string perpetualInventoryLogTag = null;
            //instance.DeletePerpetualInventoryLogTag(perpetualInventoryLogId, perpetualInventoryLogTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicatePerpetualInventoryLogById
        /// </summary>
        [Test]
        public void GetDuplicatePerpetualInventoryLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //var response = instance.GetDuplicatePerpetualInventoryLogById(perpetualInventoryLogId);
            //Assert.IsInstanceOf<PerpetualInventoryLog> (response, "response is PerpetualInventoryLog");
        }
        
        /// <summary>
        /// Test GetPerpetualInventoryLogByFilter
        /// </summary>
        [Test]
        public void GetPerpetualInventoryLogByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetPerpetualInventoryLogByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<PerpetualInventoryLog>> (response, "response is List<PerpetualInventoryLog>");
        }
        
        /// <summary>
        /// Test GetPerpetualInventoryLogById
        /// </summary>
        [Test]
        public void GetPerpetualInventoryLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //var response = instance.GetPerpetualInventoryLogById(perpetualInventoryLogId);
            //Assert.IsInstanceOf<PerpetualInventoryLog> (response, "response is PerpetualInventoryLog");
        }
        
        /// <summary>
        /// Test GetPerpetualInventoryLogFiles
        /// </summary>
        [Test]
        public void GetPerpetualInventoryLogFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //instance.GetPerpetualInventoryLogFiles(perpetualInventoryLogId);
            
        }
        
        /// <summary>
        /// Test GetPerpetualInventoryLogTags
        /// </summary>
        [Test]
        public void GetPerpetualInventoryLogTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perpetualInventoryLogId = null;
            //instance.GetPerpetualInventoryLogTags(perpetualInventoryLogId);
            
        }
        
    }

}
