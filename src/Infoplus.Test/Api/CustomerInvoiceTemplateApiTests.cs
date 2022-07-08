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
    ///  Class for testing CustomerInvoiceTemplateApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerInvoiceTemplateApiTests
    {
        private CustomerInvoiceTemplateApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerInvoiceTemplateApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerInvoiceTemplateApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerInvoiceTemplateApi
            //Assert.IsInstanceOfType(typeof(CustomerInvoiceTemplateApi), instance, "instance is a CustomerInvoiceTemplateApi");
        }

        
        /// <summary>
        /// Test AddCustomerInvoiceTemplate
        /// </summary>
        [Test]
        public void AddCustomerInvoiceTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerInvoiceTemplate body = null;
            //var response = instance.AddCustomerInvoiceTemplate(body);
            //Assert.IsInstanceOf<CustomerInvoiceTemplate> (response, "response is CustomerInvoiceTemplate");
        }
        
        /// <summary>
        /// Test AddCustomerInvoiceTemplateAudit
        /// </summary>
        [Test]
        public void AddCustomerInvoiceTemplateAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //string customerInvoiceTemplateAudit = null;
            //instance.AddCustomerInvoiceTemplateAudit(customerInvoiceTemplateId, customerInvoiceTemplateAudit);
            
        }
        
        /// <summary>
        /// Test AddCustomerInvoiceTemplateFile
        /// </summary>
        [Test]
        public void AddCustomerInvoiceTemplateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //string fileName = null;
            //instance.AddCustomerInvoiceTemplateFile(customerInvoiceTemplateId, fileName);
            
        }
        
        /// <summary>
        /// Test AddCustomerInvoiceTemplateFileByURL
        /// </summary>
        [Test]
        public void AddCustomerInvoiceTemplateFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? customerInvoiceTemplateId = null;
            //instance.AddCustomerInvoiceTemplateFileByURL(body, customerInvoiceTemplateId);
            
        }
        
        /// <summary>
        /// Test AddCustomerInvoiceTemplateTag
        /// </summary>
        [Test]
        public void AddCustomerInvoiceTemplateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //string customerInvoiceTemplateTag = null;
            //instance.AddCustomerInvoiceTemplateTag(customerInvoiceTemplateId, customerInvoiceTemplateTag);
            
        }
        
        /// <summary>
        /// Test DeleteCustomerInvoiceTemplate
        /// </summary>
        [Test]
        public void DeleteCustomerInvoiceTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //instance.DeleteCustomerInvoiceTemplate(customerInvoiceTemplateId);
            
        }
        
        /// <summary>
        /// Test DeleteCustomerInvoiceTemplateFile
        /// </summary>
        [Test]
        public void DeleteCustomerInvoiceTemplateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //int? fileId = null;
            //instance.DeleteCustomerInvoiceTemplateFile(customerInvoiceTemplateId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteCustomerInvoiceTemplateTag
        /// </summary>
        [Test]
        public void DeleteCustomerInvoiceTemplateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //string customerInvoiceTemplateTag = null;
            //instance.DeleteCustomerInvoiceTemplateTag(customerInvoiceTemplateId, customerInvoiceTemplateTag);
            
        }
        
        /// <summary>
        /// Test GetCustomerInvoiceTemplateByFilter
        /// </summary>
        [Test]
        public void GetCustomerInvoiceTemplateByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetCustomerInvoiceTemplateByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<CustomerInvoiceTemplate>> (response, "response is List<CustomerInvoiceTemplate>");
        }
        
        /// <summary>
        /// Test GetCustomerInvoiceTemplateById
        /// </summary>
        [Test]
        public void GetCustomerInvoiceTemplateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //var response = instance.GetCustomerInvoiceTemplateById(customerInvoiceTemplateId);
            //Assert.IsInstanceOf<CustomerInvoiceTemplate> (response, "response is CustomerInvoiceTemplate");
        }
        
        /// <summary>
        /// Test GetCustomerInvoiceTemplateFiles
        /// </summary>
        [Test]
        public void GetCustomerInvoiceTemplateFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //instance.GetCustomerInvoiceTemplateFiles(customerInvoiceTemplateId);
            
        }
        
        /// <summary>
        /// Test GetCustomerInvoiceTemplateTags
        /// </summary>
        [Test]
        public void GetCustomerInvoiceTemplateTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //instance.GetCustomerInvoiceTemplateTags(customerInvoiceTemplateId);
            
        }
        
        /// <summary>
        /// Test GetDuplicateCustomerInvoiceTemplateById
        /// </summary>
        [Test]
        public void GetDuplicateCustomerInvoiceTemplateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? customerInvoiceTemplateId = null;
            //var response = instance.GetDuplicateCustomerInvoiceTemplateById(customerInvoiceTemplateId);
            //Assert.IsInstanceOf<CustomerInvoiceTemplate> (response, "response is CustomerInvoiceTemplate");
        }
        
        /// <summary>
        /// Test UpdateCustomerInvoiceTemplate
        /// </summary>
        [Test]
        public void UpdateCustomerInvoiceTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerInvoiceTemplate body = null;
            //instance.UpdateCustomerInvoiceTemplate(body);
            
        }
        
    }

}