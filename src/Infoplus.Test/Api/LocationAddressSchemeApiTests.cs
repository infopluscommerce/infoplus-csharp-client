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
    ///  Class for testing LocationAddressSchemeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationAddressSchemeApiTests
    {
        private LocationAddressSchemeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationAddressSchemeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationAddressSchemeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LocationAddressSchemeApi
            //Assert.IsInstanceOfType(typeof(LocationAddressSchemeApi), instance, "instance is a LocationAddressSchemeApi");
        }

        
        /// <summary>
        /// Test AddLocationAddressScheme
        /// </summary>
        [Test]
        public void AddLocationAddressSchemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationAddressScheme body = null;
            //var response = instance.AddLocationAddressScheme(body);
            //Assert.IsInstanceOf<LocationAddressScheme> (response, "response is LocationAddressScheme");
        }
        
        /// <summary>
        /// Test AddLocationAddressSchemeAudit
        /// </summary>
        [Test]
        public void AddLocationAddressSchemeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //string locationAddressSchemeAudit = null;
            //instance.AddLocationAddressSchemeAudit(locationAddressSchemeId, locationAddressSchemeAudit);
            
        }
        
        /// <summary>
        /// Test AddLocationAddressSchemeFile
        /// </summary>
        [Test]
        public void AddLocationAddressSchemeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //string fileName = null;
            //instance.AddLocationAddressSchemeFile(locationAddressSchemeId, fileName);
            
        }
        
        /// <summary>
        /// Test AddLocationAddressSchemeFileByURL
        /// </summary>
        [Test]
        public void AddLocationAddressSchemeFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? locationAddressSchemeId = null;
            //instance.AddLocationAddressSchemeFileByURL(body, locationAddressSchemeId);
            
        }
        
        /// <summary>
        /// Test AddLocationAddressSchemeTag
        /// </summary>
        [Test]
        public void AddLocationAddressSchemeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //string locationAddressSchemeTag = null;
            //instance.AddLocationAddressSchemeTag(locationAddressSchemeId, locationAddressSchemeTag);
            
        }
        
        /// <summary>
        /// Test DeleteLocationAddressScheme
        /// </summary>
        [Test]
        public void DeleteLocationAddressSchemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //instance.DeleteLocationAddressScheme(locationAddressSchemeId);
            
        }
        
        /// <summary>
        /// Test DeleteLocationAddressSchemeFile
        /// </summary>
        [Test]
        public void DeleteLocationAddressSchemeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //int? fileId = null;
            //instance.DeleteLocationAddressSchemeFile(locationAddressSchemeId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteLocationAddressSchemeTag
        /// </summary>
        [Test]
        public void DeleteLocationAddressSchemeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //string locationAddressSchemeTag = null;
            //instance.DeleteLocationAddressSchemeTag(locationAddressSchemeId, locationAddressSchemeTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateLocationAddressSchemeById
        /// </summary>
        [Test]
        public void GetDuplicateLocationAddressSchemeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //var response = instance.GetDuplicateLocationAddressSchemeById(locationAddressSchemeId);
            //Assert.IsInstanceOf<LocationAddressScheme> (response, "response is LocationAddressScheme");
        }
        
        /// <summary>
        /// Test GetLocationAddressSchemeByFilter
        /// </summary>
        [Test]
        public void GetLocationAddressSchemeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetLocationAddressSchemeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<LocationAddressScheme>> (response, "response is List<LocationAddressScheme>");
        }
        
        /// <summary>
        /// Test GetLocationAddressSchemeById
        /// </summary>
        [Test]
        public void GetLocationAddressSchemeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //var response = instance.GetLocationAddressSchemeById(locationAddressSchemeId);
            //Assert.IsInstanceOf<LocationAddressScheme> (response, "response is LocationAddressScheme");
        }
        
        /// <summary>
        /// Test GetLocationAddressSchemeFiles
        /// </summary>
        [Test]
        public void GetLocationAddressSchemeFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //instance.GetLocationAddressSchemeFiles(locationAddressSchemeId);
            
        }
        
        /// <summary>
        /// Test GetLocationAddressSchemeTags
        /// </summary>
        [Test]
        public void GetLocationAddressSchemeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? locationAddressSchemeId = null;
            //instance.GetLocationAddressSchemeTags(locationAddressSchemeId);
            
        }
        
        /// <summary>
        /// Test UpdateLocationAddressScheme
        /// </summary>
        [Test]
        public void UpdateLocationAddressSchemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationAddressScheme body = null;
            //instance.UpdateLocationAddressScheme(body);
            
        }
        
        /// <summary>
        /// Test UpdateLocationAddressSchemeCustomFields
        /// </summary>
        [Test]
        public void UpdateLocationAddressSchemeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationAddressScheme body = null;
            //instance.UpdateLocationAddressSchemeCustomFields(body);
            
        }
        
    }

}
