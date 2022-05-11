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
    ///  Class for testing Gs1128LabelApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Gs1128LabelApiTests
    {
        private Gs1128LabelApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Gs1128LabelApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Gs1128LabelApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Gs1128LabelApi
            //Assert.IsInstanceOfType(typeof(Gs1128LabelApi), instance, "instance is a Gs1128LabelApi");
        }

        
        /// <summary>
        /// Test AddGs1128LabelAudit
        /// </summary>
        [Test]
        public void AddGs1128LabelAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //string gs1128LabelAudit = null;
            //instance.AddGs1128LabelAudit(gs1128LabelId, gs1128LabelAudit);
            
        }
        
        /// <summary>
        /// Test AddGs1128LabelFile
        /// </summary>
        [Test]
        public void AddGs1128LabelFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //string fileName = null;
            //instance.AddGs1128LabelFile(gs1128LabelId, fileName);
            
        }
        
        /// <summary>
        /// Test AddGs1128LabelFileByURL
        /// </summary>
        [Test]
        public void AddGs1128LabelFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? gs1128LabelId = null;
            //instance.AddGs1128LabelFileByURL(body, gs1128LabelId);
            
        }
        
        /// <summary>
        /// Test AddGs1128LabelTag
        /// </summary>
        [Test]
        public void AddGs1128LabelTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //string gs1128LabelTag = null;
            //instance.AddGs1128LabelTag(gs1128LabelId, gs1128LabelTag);
            
        }
        
        /// <summary>
        /// Test DeleteGs1128Label
        /// </summary>
        [Test]
        public void DeleteGs1128LabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //instance.DeleteGs1128Label(gs1128LabelId);
            
        }
        
        /// <summary>
        /// Test DeleteGs1128LabelFile
        /// </summary>
        [Test]
        public void DeleteGs1128LabelFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //int? fileId = null;
            //instance.DeleteGs1128LabelFile(gs1128LabelId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteGs1128LabelTag
        /// </summary>
        [Test]
        public void DeleteGs1128LabelTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //string gs1128LabelTag = null;
            //instance.DeleteGs1128LabelTag(gs1128LabelId, gs1128LabelTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateGs1128LabelById
        /// </summary>
        [Test]
        public void GetDuplicateGs1128LabelByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //var response = instance.GetDuplicateGs1128LabelById(gs1128LabelId);
            //Assert.IsInstanceOf<GS1128Label> (response, "response is GS1128Label");
        }
        
        /// <summary>
        /// Test GetGs1128LabelByFilter
        /// </summary>
        [Test]
        public void GetGs1128LabelByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetGs1128LabelByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<GS1128Label>> (response, "response is List<GS1128Label>");
        }
        
        /// <summary>
        /// Test GetGs1128LabelById
        /// </summary>
        [Test]
        public void GetGs1128LabelByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //var response = instance.GetGs1128LabelById(gs1128LabelId);
            //Assert.IsInstanceOf<GS1128Label> (response, "response is GS1128Label");
        }
        
        /// <summary>
        /// Test GetGs1128LabelFiles
        /// </summary>
        [Test]
        public void GetGs1128LabelFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //instance.GetGs1128LabelFiles(gs1128LabelId);
            
        }
        
        /// <summary>
        /// Test GetGs1128LabelTags
        /// </summary>
        [Test]
        public void GetGs1128LabelTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gs1128LabelId = null;
            //instance.GetGs1128LabelTags(gs1128LabelId);
            
        }
        
        /// <summary>
        /// Test UpdateGs1128LabelCustomFields
        /// </summary>
        [Test]
        public void UpdateGs1128LabelCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GS1128Label body = null;
            //instance.UpdateGs1128LabelCustomFields(body);
            
        }
        
    }

}
