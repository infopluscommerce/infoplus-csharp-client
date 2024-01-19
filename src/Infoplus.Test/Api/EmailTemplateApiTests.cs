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
    ///  Class for testing EmailTemplateApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailTemplateApiTests
    {
        private EmailTemplateApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailTemplateApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailTemplateApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmailTemplateApi
            //Assert.IsInstanceOfType(typeof(EmailTemplateApi), instance, "instance is a EmailTemplateApi");
        }

        
        /// <summary>
        /// Test AddEmailTemplate
        /// </summary>
        [Test]
        public void AddEmailTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailTemplate body = null;
            //var response = instance.AddEmailTemplate(body);
            //Assert.IsInstanceOf<EmailTemplate> (response, "response is EmailTemplate");
        }
        
        /// <summary>
        /// Test AddEmailTemplateAudit
        /// </summary>
        [Test]
        public void AddEmailTemplateAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //string emailTemplateAudit = null;
            //instance.AddEmailTemplateAudit(emailTemplateId, emailTemplateAudit);
            
        }
        
        /// <summary>
        /// Test AddEmailTemplateFile
        /// </summary>
        [Test]
        public void AddEmailTemplateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //string fileName = null;
            //instance.AddEmailTemplateFile(emailTemplateId, fileName);
            
        }
        
        /// <summary>
        /// Test AddEmailTemplateFileByURL
        /// </summary>
        [Test]
        public void AddEmailTemplateFileByURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RecordFile body = null;
            //int? emailTemplateId = null;
            //instance.AddEmailTemplateFileByURL(body, emailTemplateId);
            
        }
        
        /// <summary>
        /// Test AddEmailTemplateTag
        /// </summary>
        [Test]
        public void AddEmailTemplateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //string emailTemplateTag = null;
            //instance.AddEmailTemplateTag(emailTemplateId, emailTemplateTag);
            
        }
        
        /// <summary>
        /// Test DeleteEmailTemplate
        /// </summary>
        [Test]
        public void DeleteEmailTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //instance.DeleteEmailTemplate(emailTemplateId);
            
        }
        
        /// <summary>
        /// Test DeleteEmailTemplateFile
        /// </summary>
        [Test]
        public void DeleteEmailTemplateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //int? fileId = null;
            //instance.DeleteEmailTemplateFile(emailTemplateId, fileId);
            
        }
        
        /// <summary>
        /// Test DeleteEmailTemplateTag
        /// </summary>
        [Test]
        public void DeleteEmailTemplateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //string emailTemplateTag = null;
            //instance.DeleteEmailTemplateTag(emailTemplateId, emailTemplateTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateEmailTemplateById
        /// </summary>
        [Test]
        public void GetDuplicateEmailTemplateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //var response = instance.GetDuplicateEmailTemplateById(emailTemplateId);
            //Assert.IsInstanceOf<EmailTemplate> (response, "response is EmailTemplate");
        }
        
        /// <summary>
        /// Test GetEmailTemplateByFilter
        /// </summary>
        [Test]
        public void GetEmailTemplateByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetEmailTemplateByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<EmailTemplate>> (response, "response is List<EmailTemplate>");
        }
        
        /// <summary>
        /// Test GetEmailTemplateById
        /// </summary>
        [Test]
        public void GetEmailTemplateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //var response = instance.GetEmailTemplateById(emailTemplateId);
            //Assert.IsInstanceOf<EmailTemplate> (response, "response is EmailTemplate");
        }
        
        /// <summary>
        /// Test GetEmailTemplateFiles
        /// </summary>
        [Test]
        public void GetEmailTemplateFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //instance.GetEmailTemplateFiles(emailTemplateId);
            
        }
        
        /// <summary>
        /// Test GetEmailTemplateTags
        /// </summary>
        [Test]
        public void GetEmailTemplateTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? emailTemplateId = null;
            //instance.GetEmailTemplateTags(emailTemplateId);
            
        }
        
        /// <summary>
        /// Test UpdateEmailTemplate
        /// </summary>
        [Test]
        public void UpdateEmailTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailTemplate body = null;
            //instance.UpdateEmailTemplate(body);
            
        }
        
        /// <summary>
        /// Test UpdateEmailTemplateCustomFields
        /// </summary>
        [Test]
        public void UpdateEmailTemplateCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailTemplate body = null;
            //instance.UpdateEmailTemplateCustomFields(body);
            
        }
        
    }

}
