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
    ///  Class for testing CartonTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CartonTypeApiTests
    {
        private CartonTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CartonTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CartonTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CartonTypeApi
            //Assert.IsInstanceOfType(typeof(CartonTypeApi), instance, "instance is a CartonTypeApi");
        }

        
        /// <summary>
        /// Test AddCartonType
        /// </summary>
        [Test]
        public void AddCartonTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonType body = null;
            //var response = instance.AddCartonType(body);
            //Assert.IsInstanceOf<CartonType> (response, "response is CartonType");
        }
        
        /// <summary>
        /// Test AddCartonTypeAudit
        /// </summary>
        [Test]
        public void AddCartonTypeAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //string cartonTypeAudit = null;
            //instance.AddCartonTypeAudit(cartonTypeId, cartonTypeAudit);
            
        }
        
        /// <summary>
        /// Test AddCartonTypeFile
        /// </summary>
        [Test]
        public void AddCartonTypeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //string fileName = null;
            //instance.AddCartonTypeFile(cartonTypeId, fileName);
            
        }
        
        /// <summary>
        /// Test AddCartonTypeFileByURL
        /// </summary>
        [Test]
        public void AddCartonTypeFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? cartonTypeId = null;
            //instance.AddCartonTypeFileByURL(body, cartonTypeId);
            
        }
        
        /// <summary>
        /// Test AddCartonTypeTag
        /// </summary>
        [Test]
        public void AddCartonTypeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //string cartonTypeTag = null;
            //instance.AddCartonTypeTag(cartonTypeId, cartonTypeTag);
            
        }
        
        /// <summary>
        /// Test DeleteCartonType
        /// </summary>
        [Test]
        public void DeleteCartonTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //instance.DeleteCartonType(cartonTypeId);
            
        }
        
        /// <summary>
        /// Test DeleteCartonTypeFile
        /// </summary>
        [Test]
        public void DeleteCartonTypeFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //int? fileId = null;
            //instance.DeleteCartonTypeFile(cartonTypeId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteCartonTypeTag
        /// </summary>
        [Test]
        public void DeleteCartonTypeTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //string cartonTypeTag = null;
            //instance.DeleteCartonTypeTag(cartonTypeId, cartonTypeTag);
            
        }
        
        /// <summary>
        /// Test GetCartonTypeByFilter
        /// </summary>
        [Test]
        public void GetCartonTypeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCartonTypeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<CartonType>> (response, "response is List<CartonType>");
        }
        
        /// <summary>
        /// Test GetCartonTypeById
        /// </summary>
        [Test]
        public void GetCartonTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //var response = instance.GetCartonTypeById(cartonTypeId);
            //Assert.IsInstanceOf<CartonType> (response, "response is CartonType");
        }
        
        /// <summary>
        /// Test GetCartonTypeFiles
        /// </summary>
        [Test]
        public void GetCartonTypeFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //instance.GetCartonTypeFiles(cartonTypeId);
            
        }
        
        /// <summary>
        /// Test GetCartonTypeTags
        /// </summary>
        [Test]
        public void GetCartonTypeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //instance.GetCartonTypeTags(cartonTypeId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateCartonTypeById
        /// </summary>
        [Test]
        public void GetDuplicateCartonTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? cartonTypeId = null;
            //var response = instance.GetDuplicateCartonTypeById(cartonTypeId);
            //Assert.IsInstanceOf<CartonType> (response, "response is CartonType");
        }
        
        /// <summary>
        /// Test UpdateCartonType
        /// </summary>
        [Test]
        public void UpdateCartonTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonType body = null;
            //instance.UpdateCartonType(body);
            
        }
        
        /// <summary>
        /// Test UpdateCartonTypeCustomFields
        /// </summary>
        [Test]
        public void UpdateCartonTypeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartonType body = null;
            //instance.UpdateCartonTypeCustomFields(body);
            
        }
        
    }

}
