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
    ///  Class for testing AsnApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AsnApiTests
    {
        private AsnApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AsnApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AsnApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AsnApi
            //Assert.IsInstanceOfType(typeof(AsnApi), instance, "instance is a AsnApi");
        }

        
        /// <summary>
        /// Test AddAsn
        /// </summary>
        [Test]
        public void AddAsnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Asn body = null;
            //var response = instance.AddAsn(body);
            //Assert.IsInstanceOf<Asn> (response, "response is Asn");
        }
        
        /// <summary>
        /// Test AddAsnAudit
        /// </summary>
        [Test]
        public void AddAsnAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //string asnAudit = null;
            //instance.AddAsnAudit(asnId, asnAudit);
            
        }
        
        /// <summary>
        /// Test AddAsnFile
        /// </summary>
        [Test]
        public void AddAsnFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //string fileName = null;
            //instance.AddAsnFile(asnId, fileName);
            
        }
        
        /// <summary>
        /// Test AddAsnFileByURL
        /// </summary>
        [Test]
        public void AddAsnFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? asnId = null;
            //instance.AddAsnFileByURL(body, asnId);
            
        }
        
        /// <summary>
        /// Test AddAsnTag
        /// </summary>
        [Test]
        public void AddAsnTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //string asnTag = null;
            //instance.AddAsnTag(asnId, asnTag);
            
        }
        
        /// <summary>
        /// Test DeleteAsn
        /// </summary>
        [Test]
        public void DeleteAsnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //instance.DeleteAsn(asnId);
            
        }
        
        /// <summary>
        /// Test DeleteAsnFile
        /// </summary>
        [Test]
        public void DeleteAsnFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //int? fileId = null;
            //instance.DeleteAsnFile(asnId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteAsnTag
        /// </summary>
        [Test]
        public void DeleteAsnTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //string asnTag = null;
            //instance.DeleteAsnTag(asnId, asnTag);
            
        }
        
        /// <summary>
        /// Test GetAsnByFilter
        /// </summary>
        [Test]
        public void GetAsnByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetAsnByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Asn>> (response, "response is List<Asn>");
        }
        
        /// <summary>
        /// Test GetAsnById
        /// </summary>
        [Test]
        public void GetAsnByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //var response = instance.GetAsnById(asnId);
            //Assert.IsInstanceOf<Asn> (response, "response is Asn");
        }
        
        /// <summary>
        /// Test GetAsnFiles
        /// </summary>
        [Test]
        public void GetAsnFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //instance.GetAsnFiles(asnId);
            
        }
        
        /// <summary>
        /// Test GetAsnTags
        /// </summary>
        [Test]
        public void GetAsnTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //instance.GetAsnTags(asnId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateAsnById
        /// </summary>
        [Test]
        public void GetDuplicateAsnByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? asnId = null;
            //var response = instance.GetDuplicateAsnById(asnId);
            //Assert.IsInstanceOf<Asn> (response, "response is Asn");
        }
        
        /// <summary>
        /// Test UpdateAsn
        /// </summary>
        [Test]
        public void UpdateAsnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Asn body = null;
            //instance.UpdateAsn(body);
            
        }
        
        /// <summary>
        /// Test UpdateAsnCustomFields
        /// </summary>
        [Test]
        public void UpdateAsnCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Asn body = null;
            //instance.UpdateAsnCustomFields(body);
            
        }
        
    }

}
