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
    ///  Class for testing ServiceTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ServiceTypeApiTests
    {
        private ServiceTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServiceTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServiceTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ServiceTypeApi
            //Assert.IsInstanceOfType(typeof(ServiceTypeApi), instance, "instance is a ServiceTypeApi");
        }

        
        /// <summary>
        /// Test GetServiceTypeById
        /// </summary>
        [Test]
        public void GetServiceTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceTypeId = null;
            //var response = instance.GetServiceTypeById(serviceTypeId);
            //Assert.IsInstanceOf<ServiceType> (response, "response is ServiceType");
        }
        
        /// <summary>
        /// Test GetServiceTypeBySearchText
        /// </summary>
        [Test]
        public void GetServiceTypeBySearchTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetServiceTypeBySearchText(searchText, page, limit);
            //Assert.IsInstanceOf<List<ServiceType>> (response, "response is List<ServiceType>");
        }
        
    }

}
