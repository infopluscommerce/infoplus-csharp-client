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
    ///  Class for testing SlaSetupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SlaSetupApiTests
    {
        private SlaSetupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SlaSetupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SlaSetupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SlaSetupApi
            //Assert.IsInstanceOfType(typeof(SlaSetupApi), instance, "instance is a SlaSetupApi");
        }

        
        /// <summary>
        /// Test AddSlaSetupAudit
        /// </summary>
        [Test]
        public void AddSlaSetupAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? slaSetupId = null;
            //string slaSetupAudit = null;
            //instance.AddSlaSetupAudit(slaSetupId, slaSetupAudit);
            
        }
        
        /// <summary>
        /// Test AddSlaSetupTag
        /// </summary>
        [Test]
        public void AddSlaSetupTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? slaSetupId = null;
            //string slaSetupTag = null;
            //instance.AddSlaSetupTag(slaSetupId, slaSetupTag);
            
        }
        
        /// <summary>
        /// Test DeleteSlaSetupTag
        /// </summary>
        [Test]
        public void DeleteSlaSetupTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? slaSetupId = null;
            //string slaSetupTag = null;
            //instance.DeleteSlaSetupTag(slaSetupId, slaSetupTag);
            
        }
        
        /// <summary>
        /// Test GetDuplicateSlaSetupById
        /// </summary>
        [Test]
        public void GetDuplicateSlaSetupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? slaSetupId = null;
            //var response = instance.GetDuplicateSlaSetupById(slaSetupId);
            //Assert.IsInstanceOf<SlaSetup> (response, "response is SlaSetup");
        }
        
        /// <summary>
        /// Test GetSlaSetupByFilter
        /// </summary>
        [Test]
        public void GetSlaSetupByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetSlaSetupByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<SlaSetup>> (response, "response is List<SlaSetup>");
        }
        
        /// <summary>
        /// Test GetSlaSetupById
        /// </summary>
        [Test]
        public void GetSlaSetupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? slaSetupId = null;
            //var response = instance.GetSlaSetupById(slaSetupId);
            //Assert.IsInstanceOf<SlaSetup> (response, "response is SlaSetup");
        }
        
        /// <summary>
        /// Test GetSlaSetupTags
        /// </summary>
        [Test]
        public void GetSlaSetupTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? slaSetupId = null;
            //instance.GetSlaSetupTags(slaSetupId);
            
        }
        
    }

}