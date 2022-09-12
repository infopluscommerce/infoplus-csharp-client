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
    ///  Class for testing FinanceSystemConnectionLogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FinanceSystemConnectionLogApiTests
    {
        private FinanceSystemConnectionLogApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FinanceSystemConnectionLogApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FinanceSystemConnectionLogApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FinanceSystemConnectionLogApi
            //Assert.IsInstanceOfType(typeof(FinanceSystemConnectionLogApi), instance, "instance is a FinanceSystemConnectionLogApi");
        }

        
        /// <summary>
        /// Test AddFinanceSystemConnectionLogAudit
        /// </summary>
        [Test]
        public void AddFinanceSystemConnectionLogAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //string financeSystemConnectionLogAudit = null;
            //instance.AddFinanceSystemConnectionLogAudit(financeSystemConnectionLogId, financeSystemConnectionLogAudit);
            
        }
        
        /// <summary>
        /// Test AddFinanceSystemConnectionLogFile
        /// </summary>
        [Test]
        public void AddFinanceSystemConnectionLogFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //string fileName = null;
            //instance.AddFinanceSystemConnectionLogFile(financeSystemConnectionLogId, fileName);
            
        }
        
        /// <summary>
        /// Test AddFinanceSystemConnectionLogFileByURL
        /// </summary>
        [Test]
        public void AddFinanceSystemConnectionLogFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? financeSystemConnectionLogId = null;
            //instance.AddFinanceSystemConnectionLogFileByURL(body, financeSystemConnectionLogId);
            
        }
        
        /// <summary>
        /// Test AddFinanceSystemConnectionLogTag
        /// </summary>
        [Test]
        public void AddFinanceSystemConnectionLogTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //string financeSystemConnectionLogTag = null;
            //instance.AddFinanceSystemConnectionLogTag(financeSystemConnectionLogId, financeSystemConnectionLogTag);
            
        }
        
        /// <summary>
        /// Test DeleteFinanceSystemConnectionLogFile
        /// </summary>
        [Test]
        public void DeleteFinanceSystemConnectionLogFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //int? fileId = null;
            //instance.DeleteFinanceSystemConnectionLogFile(financeSystemConnectionLogId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteFinanceSystemConnectionLogTag
        /// </summary>
        [Test]
        public void DeleteFinanceSystemConnectionLogTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //string financeSystemConnectionLogTag = null;
            //instance.DeleteFinanceSystemConnectionLogTag(financeSystemConnectionLogId, financeSystemConnectionLogTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateFinanceSystemConnectionLogById
        /// </summary>
        [Test]
        public void GetDuplicateFinanceSystemConnectionLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //var response = instance.GetDuplicateFinanceSystemConnectionLogById(financeSystemConnectionLogId);
            //Assert.IsInstanceOf<FinanceSystemConnectionLog> (response, "response is FinanceSystemConnectionLog");
        }
        
        /// <summary>
        /// Test GetFinanceSystemConnectionLogByFilter
        /// </summary>
        [Test]
        public void GetFinanceSystemConnectionLogByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetFinanceSystemConnectionLogByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<FinanceSystemConnectionLog>> (response, "response is List<FinanceSystemConnectionLog>");
        }
        
        /// <summary>
        /// Test GetFinanceSystemConnectionLogById
        /// </summary>
        [Test]
        public void GetFinanceSystemConnectionLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //var response = instance.GetFinanceSystemConnectionLogById(financeSystemConnectionLogId);
            //Assert.IsInstanceOf<FinanceSystemConnectionLog> (response, "response is FinanceSystemConnectionLog");
        }
        
        /// <summary>
        /// Test GetFinanceSystemConnectionLogFiles
        /// </summary>
        [Test]
        public void GetFinanceSystemConnectionLogFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //instance.GetFinanceSystemConnectionLogFiles(financeSystemConnectionLogId);
            
        }
        
        /// <summary>
        /// Test GetFinanceSystemConnectionLogTags
        /// </summary>
        [Test]
        public void GetFinanceSystemConnectionLogTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? financeSystemConnectionLogId = null;
            //instance.GetFinanceSystemConnectionLogTags(financeSystemConnectionLogId);
            
        }
        
    }

}
