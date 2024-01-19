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
    ///  Class for testing LocationFootprintApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationFootprintApiTests
    {
        private LocationFootprintApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationFootprintApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationFootprintApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LocationFootprintApi
            //Assert.IsInstanceOfType(typeof(LocationFootprintApi), instance, "instance is a LocationFootprintApi");
        }

        
        /// <summary>
        /// Test AddLocationFootprint
        /// </summary>
        [Test]
        public void AddLocationFootprintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationFootprint body = null;
            //var response = instance.AddLocationFootprint(body);
            //Assert.IsInstanceOf<LocationFootprint> (response, "response is LocationFootprint");
        }
        
        /// <summary>
        /// Test AddLocationFootprintAudit
        /// </summary>
        [Test]
        public void AddLocationFootprintAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //string locationFootprintAudit = null;
            //instance.AddLocationFootprintAudit(locationFootprintId, locationFootprintAudit);
            
        }
        
        /// <summary>
        /// Test AddLocationFootprintFile
        /// </summary>
        [Test]
        public void AddLocationFootprintFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //string fileName = null;
            //instance.AddLocationFootprintFile(locationFootprintId, fileName);
            
        }
        
        /// <summary>
        /// Test AddLocationFootprintFileByURL
        /// </summary>
        [Test]
        public void AddLocationFootprintFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? locationFootprintId = null;
            //instance.AddLocationFootprintFileByURL(body, locationFootprintId);
            
        }
        
        /// <summary>
        /// Test AddLocationFootprintTag
        /// </summary>
        [Test]
        public void AddLocationFootprintTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //string locationFootprintTag = null;
            //instance.AddLocationFootprintTag(locationFootprintId, locationFootprintTag);
            
        }
        
        /// <summary>
        /// Test DeleteLocationFootprint
        /// </summary>
        [Test]
        public void DeleteLocationFootprintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //instance.DeleteLocationFootprint(locationFootprintId);
            
        }
        
        /// <summary>
        /// Test DeleteLocationFootprintFile
        /// </summary>
        [Test]
        public void DeleteLocationFootprintFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //int? fileId = null;
            //instance.DeleteLocationFootprintFile(locationFootprintId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteLocationFootprintTag
        /// </summary>
        [Test]
        public void DeleteLocationFootprintTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //string locationFootprintTag = null;
            //instance.DeleteLocationFootprintTag(locationFootprintId, locationFootprintTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateLocationFootprintById
        /// </summary>
        [Test]
        public void GetDuplicateLocationFootprintByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //var response = instance.GetDuplicateLocationFootprintById(locationFootprintId);
            //Assert.IsInstanceOf<LocationFootprint> (response, "response is LocationFootprint");
        }
        
        /// <summary>
        /// Test GetLocationFootprintByFilter
        /// </summary>
        [Test]
        public void GetLocationFootprintByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetLocationFootprintByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<LocationFootprint>> (response, "response is List<LocationFootprint>");
        }
        
        /// <summary>
        /// Test GetLocationFootprintById
        /// </summary>
        [Test]
        public void GetLocationFootprintByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //var response = instance.GetLocationFootprintById(locationFootprintId);
            //Assert.IsInstanceOf<LocationFootprint> (response, "response is LocationFootprint");
        }
        
        /// <summary>
        /// Test GetLocationFootprintFiles
        /// </summary>
        [Test]
        public void GetLocationFootprintFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //instance.GetLocationFootprintFiles(locationFootprintId);
            
        }
        
        /// <summary>
        /// Test GetLocationFootprintTags
        /// </summary>
        [Test]
        public void GetLocationFootprintTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationFootprintId = null;
            //instance.GetLocationFootprintTags(locationFootprintId);
            
        }
        
        /// <summary>
        /// Test UpdateLocationFootprint
        /// </summary>
        [Test]
        public void UpdateLocationFootprintTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationFootprint body = null;
            //instance.UpdateLocationFootprint(body);
            
        }
        
        /// <summary>
        /// Test UpdateLocationFootprintCustomFields
        /// </summary>
        [Test]
        public void UpdateLocationFootprintCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationFootprint body = null;
            //instance.UpdateLocationFootprintCustomFields(body);
            
        }
        
    }

}
