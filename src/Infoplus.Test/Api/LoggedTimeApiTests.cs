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
    ///  Class for testing LoggedTimeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LoggedTimeApiTests
    {
        private LoggedTimeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LoggedTimeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoggedTimeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LoggedTimeApi
            //Assert.IsInstanceOfType(typeof(LoggedTimeApi), instance, "instance is a LoggedTimeApi");
        }

        
        /// <summary>
        /// Test AddLoggedTimeAudit
        /// </summary>
        [Test]
        public void AddLoggedTimeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //string loggedTimeAudit = null;
            //instance.AddLoggedTimeAudit(loggedTimeId, loggedTimeAudit);
            
        }
        
        /// <summary>
        /// Test AddLoggedTimeFile
        /// </summary>
        [Test]
        public void AddLoggedTimeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //string fileName = null;
            //instance.AddLoggedTimeFile(loggedTimeId, fileName);
            
        }
        
        /// <summary>
        /// Test AddLoggedTimeFileByURL
        /// </summary>
        [Test]
        public void AddLoggedTimeFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? loggedTimeId = null;
            //instance.AddLoggedTimeFileByURL(body, loggedTimeId);
            
        }
        
        /// <summary>
        /// Test AddLoggedTimeTag
        /// </summary>
        [Test]
        public void AddLoggedTimeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //string loggedTimeTag = null;
            //instance.AddLoggedTimeTag(loggedTimeId, loggedTimeTag);
            
        }
        
        /// <summary>
        /// Test DeleteLoggedTimeFile
        /// </summary>
        [Test]
        public void DeleteLoggedTimeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //int? fileId = null;
            //instance.DeleteLoggedTimeFile(loggedTimeId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteLoggedTimeTag
        /// </summary>
        [Test]
        public void DeleteLoggedTimeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //string loggedTimeTag = null;
            //instance.DeleteLoggedTimeTag(loggedTimeId, loggedTimeTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateLoggedTimeById
        /// </summary>
        [Test]
        public void GetDuplicateLoggedTimeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //var response = instance.GetDuplicateLoggedTimeById(loggedTimeId);
            //Assert.IsInstanceOf<LoggedTime> (response, "response is LoggedTime");
        }
        
        /// <summary>
        /// Test GetLoggedTimeByFilter
        /// </summary>
        [Test]
        public void GetLoggedTimeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetLoggedTimeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<LoggedTime>> (response, "response is List<LoggedTime>");
        }
        
        /// <summary>
        /// Test GetLoggedTimeById
        /// </summary>
        [Test]
        public void GetLoggedTimeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //var response = instance.GetLoggedTimeById(loggedTimeId);
            //Assert.IsInstanceOf<LoggedTime> (response, "response is LoggedTime");
        }
        
        /// <summary>
        /// Test GetLoggedTimeFiles
        /// </summary>
        [Test]
        public void GetLoggedTimeFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //instance.GetLoggedTimeFiles(loggedTimeId);
            
        }
        
        /// <summary>
        /// Test GetLoggedTimeTags
        /// </summary>
        [Test]
        public void GetLoggedTimeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? loggedTimeId = null;
            //instance.GetLoggedTimeTags(loggedTimeId);
            
        }
        
        /// <summary>
        /// Test UpdateLoggedTimeCustomFields
        /// </summary>
        [Test]
        public void UpdateLoggedTimeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoggedTime body = null;
            //instance.UpdateLoggedTimeCustomFields(body);
            
        }
        
    }

}
