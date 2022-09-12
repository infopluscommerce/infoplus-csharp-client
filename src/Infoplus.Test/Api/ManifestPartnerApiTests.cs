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
    ///  Class for testing ManifestPartnerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ManifestPartnerApiTests
    {
        private ManifestPartnerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ManifestPartnerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ManifestPartnerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ManifestPartnerApi
            //Assert.IsInstanceOfType(typeof(ManifestPartnerApi), instance, "instance is a ManifestPartnerApi");
        }

        
        /// <summary>
        /// Test GetManifestPartnerBySearchText
        /// </summary>
        [Test]
        public void GetManifestPartnerBySearchTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetManifestPartnerBySearchText(searchText, page, limit);
            //Assert.IsInstanceOf<List<ManifestPartner>> (response, "response is List<ManifestPartner>");
        }
        
        /// <summary>
        /// Test GetManifestSolutionProviderById
        /// </summary>
        [Test]
        public void GetManifestSolutionProviderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string manifestPartnerId = null;
            //var response = instance.GetManifestSolutionProviderById(manifestPartnerId);
            //Assert.IsInstanceOf<ManifestPartner> (response, "response is ManifestPartner");
        }
        
    }

}