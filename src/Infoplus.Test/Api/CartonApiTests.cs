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
    ///  Class for testing CartonApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CartonApiTests
    {
        private CartonApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CartonApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CartonApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CartonApi
            //Assert.IsInstanceOfType(typeof(CartonApi), instance, "instance is a CartonApi");
        }

        
        /// <summary>
        /// Test AddCarton
        /// </summary>
        [Test]
        public void AddCartonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Carton body = null;
            //var response = instance.AddCarton(body);
            //Assert.IsInstanceOf<Carton> (response, "response is Carton");
        }
        
        /// <summary>
        /// Test AddCartonAudit
        /// </summary>
        [Test]
        public void AddCartonAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //string cartonAudit = null;
            //instance.AddCartonAudit(cartonId, cartonAudit);
            
        }
        
        /// <summary>
        /// Test AddCartonFile
        /// </summary>
        [Test]
        public void AddCartonFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //string fileName = null;
            //instance.AddCartonFile(cartonId, fileName);
            
        }
        
        /// <summary>
        /// Test AddCartonFileByURL
        /// </summary>
        [Test]
        public void AddCartonFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? cartonId = null;
            //instance.AddCartonFileByURL(body, cartonId);
            
        }
        
        /// <summary>
        /// Test AddCartonTag
        /// </summary>
        [Test]
        public void AddCartonTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //string cartonTag = null;
            //instance.AddCartonTag(cartonId, cartonTag);
            
        }
        
        /// <summary>
        /// Test DeleteCarton
        /// </summary>
        [Test]
        public void DeleteCartonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //instance.DeleteCarton(cartonId);
            
        }
        
        /// <summary>
        /// Test DeleteCartonFile
        /// </summary>
        [Test]
        public void DeleteCartonFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //int? fileId = null;
            //instance.DeleteCartonFile(cartonId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteCartonTag
        /// </summary>
        [Test]
        public void DeleteCartonTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //string cartonTag = null;
            //instance.DeleteCartonTag(cartonId, cartonTag);
            
        }
        
        /// <summary>
        /// Test GetCartonByFilter
        /// </summary>
        [Test]
        public void GetCartonByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCartonByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Carton>> (response, "response is List<Carton>");
        }
        
        /// <summary>
        /// Test GetCartonById
        /// </summary>
        [Test]
        public void GetCartonByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //var response = instance.GetCartonById(cartonId);
            //Assert.IsInstanceOf<Carton> (response, "response is Carton");
        }
        
        /// <summary>
        /// Test GetCartonFiles
        /// </summary>
        [Test]
        public void GetCartonFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //instance.GetCartonFiles(cartonId);
            
        }
        
        /// <summary>
        /// Test GetCartonTags
        /// </summary>
        [Test]
        public void GetCartonTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //instance.GetCartonTags(cartonId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateCartonById
        /// </summary>
        [Test]
        public void GetDuplicateCartonByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonId = null;
            //var response = instance.GetDuplicateCartonById(cartonId);
            //Assert.IsInstanceOf<Carton> (response, "response is Carton");
        }
        
        /// <summary>
        /// Test UpdateCarton
        /// </summary>
        [Test]
        public void UpdateCartonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Carton body = null;
            //instance.UpdateCarton(body);
            
        }
        
        /// <summary>
        /// Test UpdateCartonCustomFields
        /// </summary>
        [Test]
        public void UpdateCartonCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Carton body = null;
            //instance.UpdateCartonCustomFields(body);
            
        }
        
    }

}
