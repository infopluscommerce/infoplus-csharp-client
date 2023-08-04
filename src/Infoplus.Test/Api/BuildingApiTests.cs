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
    ///  Class for testing BuildingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BuildingApiTests
    {
        private BuildingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BuildingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BuildingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BuildingApi
            //Assert.IsInstanceOfType(typeof(BuildingApi), instance, "instance is a BuildingApi");
        }

        
        /// <summary>
        /// Test AddBuilding
        /// </summary>
        [Test]
        public void AddBuildingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Building body = null;
            //var response = instance.AddBuilding(body);
            //Assert.IsInstanceOf<Building> (response, "response is Building");
        }
        
        /// <summary>
        /// Test AddBuildingAudit
        /// </summary>
        [Test]
        public void AddBuildingAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //string buildingAudit = null;
            //instance.AddBuildingAudit(buildingId, buildingAudit);
            
        }
        
        /// <summary>
        /// Test AddBuildingFile
        /// </summary>
        [Test]
        public void AddBuildingFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //string fileName = null;
            //instance.AddBuildingFile(buildingId, fileName);
            
        }
        
        /// <summary>
        /// Test AddBuildingFileByURL
        /// </summary>
        [Test]
        public void AddBuildingFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? buildingId = null;
            //instance.AddBuildingFileByURL(body, buildingId);
            
        }
        
        /// <summary>
        /// Test AddBuildingTag
        /// </summary>
        [Test]
        public void AddBuildingTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //string buildingTag = null;
            //instance.AddBuildingTag(buildingId, buildingTag);
            
        }
        
        /// <summary>
        /// Test DeleteBuilding
        /// </summary>
        [Test]
        public void DeleteBuildingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //instance.DeleteBuilding(buildingId);
            
        }
        
        /// <summary>
        /// Test DeleteBuildingFile
        /// </summary>
        [Test]
        public void DeleteBuildingFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //int? fileId = null;
            //instance.DeleteBuildingFile(buildingId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteBuildingTag
        /// </summary>
        [Test]
        public void DeleteBuildingTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //string buildingTag = null;
            //instance.DeleteBuildingTag(buildingId, buildingTag);
            
        }
        
        /// <summary>
        /// Test GetBuildingByFilter
        /// </summary>
        [Test]
        public void GetBuildingByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetBuildingByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Building>> (response, "response is List<Building>");
        }
        
        /// <summary>
        /// Test GetBuildingById
        /// </summary>
        [Test]
        public void GetBuildingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //var response = instance.GetBuildingById(buildingId);
            //Assert.IsInstanceOf<Building> (response, "response is Building");
        }
        
        /// <summary>
        /// Test GetBuildingFiles
        /// </summary>
        [Test]
        public void GetBuildingFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //instance.GetBuildingFiles(buildingId);
            
        }
        
        /// <summary>
        /// Test GetBuildingTags
        /// </summary>
        [Test]
        public void GetBuildingTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //instance.GetBuildingTags(buildingId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateBuildingById
        /// </summary>
        [Test]
        public void GetDuplicateBuildingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? buildingId = null;
            //var response = instance.GetDuplicateBuildingById(buildingId);
            //Assert.IsInstanceOf<Building> (response, "response is Building");
        }
        
        /// <summary>
        /// Test UpdateBuilding
        /// </summary>
        [Test]
        public void UpdateBuildingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Building body = null;
            //instance.UpdateBuilding(body);
            
        }
        
        /// <summary>
        /// Test UpdateBuildingCustomFields
        /// </summary>
        [Test]
        public void UpdateBuildingCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Building body = null;
            //instance.UpdateBuildingCustomFields(body);
            
        }
        
    }

}
