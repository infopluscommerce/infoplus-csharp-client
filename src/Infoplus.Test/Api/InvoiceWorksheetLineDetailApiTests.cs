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
    ///  Class for testing InvoiceWorksheetLineDetailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvoiceWorksheetLineDetailApiTests
    {
        private InvoiceWorksheetLineDetailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoiceWorksheetLineDetailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceWorksheetLineDetailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoiceWorksheetLineDetailApi
            //Assert.IsInstanceOfType(typeof(InvoiceWorksheetLineDetailApi), instance, "instance is a InvoiceWorksheetLineDetailApi");
        }

        
        /// <summary>
        /// Test AddInvoiceWorksheetLineDetailAudit
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineDetailAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //string invoiceWorksheetLineDetailAudit = null;
            //instance.AddInvoiceWorksheetLineDetailAudit(invoiceWorksheetLineDetailId, invoiceWorksheetLineDetailAudit);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineDetailFile
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineDetailFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //string fileName = null;
            //instance.AddInvoiceWorksheetLineDetailFile(invoiceWorksheetLineDetailId, fileName);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineDetailFileByURL
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineDetailFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? invoiceWorksheetLineDetailId = null;
            //instance.AddInvoiceWorksheetLineDetailFileByURL(body, invoiceWorksheetLineDetailId);
            
        }
        
        /// <summary>
        /// Test AddInvoiceWorksheetLineDetailTag
        /// </summary>
        [Test]
        public void AddInvoiceWorksheetLineDetailTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //string invoiceWorksheetLineDetailTag = null;
            //instance.AddInvoiceWorksheetLineDetailTag(invoiceWorksheetLineDetailId, invoiceWorksheetLineDetailTag);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheetLineDetailFile
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetLineDetailFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //int? fileId = null;
            //instance.DeleteInvoiceWorksheetLineDetailFile(invoiceWorksheetLineDetailId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteInvoiceWorksheetLineDetailTag
        /// </summary>
        [Test]
        public void DeleteInvoiceWorksheetLineDetailTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //string invoiceWorksheetLineDetailTag = null;
            //instance.DeleteInvoiceWorksheetLineDetailTag(invoiceWorksheetLineDetailId, invoiceWorksheetLineDetailTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateInvoiceWorksheetLineDetailById
        /// </summary>
        [Test]
        public void GetDuplicateInvoiceWorksheetLineDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //var response = instance.GetDuplicateInvoiceWorksheetLineDetailById(invoiceWorksheetLineDetailId);
            //Assert.IsInstanceOf<InvoiceWorksheetLineDetail> (response, "response is InvoiceWorksheetLineDetail");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineDetailByFilter
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineDetailByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetInvoiceWorksheetLineDetailByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<InvoiceWorksheetLineDetail>> (response, "response is List<InvoiceWorksheetLineDetail>");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineDetailById
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineDetailByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //var response = instance.GetInvoiceWorksheetLineDetailById(invoiceWorksheetLineDetailId);
            //Assert.IsInstanceOf<InvoiceWorksheetLineDetail> (response, "response is InvoiceWorksheetLineDetail");
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineDetailFiles
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineDetailFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //instance.GetInvoiceWorksheetLineDetailFiles(invoiceWorksheetLineDetailId);
            
        }
        
        /// <summary>
        /// Test GetInvoiceWorksheetLineDetailTags
        /// </summary>
        [Test]
        public void GetInvoiceWorksheetLineDetailTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? invoiceWorksheetLineDetailId = null;
            //instance.GetInvoiceWorksheetLineDetailTags(invoiceWorksheetLineDetailId);
            
        }
        
        /// <summary>
        /// Test UpdateInvoiceWorksheetLineDetailCustomFields
        /// </summary>
        [Test]
        public void UpdateInvoiceWorksheetLineDetailCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceWorksheetLineDetail body = null;
            //instance.UpdateInvoiceWorksheetLineDetailCustomFields(body);
            
        }
        
    }

}