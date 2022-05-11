/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v3.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Infoplus.Api;
using Infoplus.Model;
using Infoplus.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing OmsOrder
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OmsOrderTests
    {
        // TODO uncomment below to declare an instance variable for OmsOrder
        //private OmsOrder instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OmsOrder
            //instance = new OmsOrder();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OmsOrder
        /// </summary>
        [Test]
        public void OmsOrderInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OmsOrder
            //Assert.IsInstanceOfType<OmsOrder> (instance, "variable 'instance' is a OmsOrder");
        }


        /// <summary>
        /// Test the property 'LobId'
        /// </summary>
        [Test]
        public void LobIdTest()
        {
            // TODO unit test for the property 'LobId'
        }
        /// <summary>
        /// Test the property 'ExternalId'
        /// </summary>
        [Test]
        public void ExternalIdTest()
        {
            // TODO unit test for the property 'ExternalId'
        }
        /// <summary>
        /// Test the property 'OmsOrderNo'
        /// </summary>
        [Test]
        public void OmsOrderNoTest()
        {
            // TODO unit test for the property 'OmsOrderNo'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'OrderStatus'
        /// </summary>
        [Test]
        public void OrderStatusTest()
        {
            // TODO unit test for the property 'OrderStatus'
        }
        /// <summary>
        /// Test the property 'OrderEntryProgramId'
        /// </summary>
        [Test]
        public void OrderEntryProgramIdTest()
        {
            // TODO unit test for the property 'OrderEntryProgramId'
        }
        /// <summary>
        /// Test the property 'LegacyUserId'
        /// </summary>
        [Test]
        public void LegacyUserIdTest()
        {
            // TODO unit test for the property 'LegacyUserId'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'ModifyDate'
        /// </summary>
        [Test]
        public void ModifyDateTest()
        {
            // TODO unit test for the property 'ModifyDate'
        }
        /// <summary>
        /// Test the property 'NextOMSOrderId'
        /// </summary>
        [Test]
        public void NextOMSOrderIdTest()
        {
            // TODO unit test for the property 'NextOMSOrderId'
        }
        /// <summary>
        /// Test the property 'CustomerId'
        /// </summary>
        [Test]
        public void CustomerIdTest()
        {
            // TODO unit test for the property 'CustomerId'
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Test]
        public void TaxTest()
        {
            // TODO unit test for the property 'Tax'
        }
        /// <summary>
        /// Test the property 'ShippingHandling'
        /// </summary>
        [Test]
        public void ShippingHandlingTest()
        {
            // TODO unit test for the property 'ShippingHandling'
        }
        /// <summary>
        /// Test the property 'ShOverrideAmount'
        /// </summary>
        [Test]
        public void ShOverrideAmountTest()
        {
            // TODO unit test for the property 'ShOverrideAmount'
        }
        /// <summary>
        /// Test the property 'IntegrationPartnerId'
        /// </summary>
        [Test]
        public void IntegrationPartnerIdTest()
        {
            // TODO unit test for the property 'IntegrationPartnerId'
        }
        /// <summary>
        /// Test the property 'OrderSourceId'
        /// </summary>
        [Test]
        public void OrderSourceIdTest()
        {
            // TODO unit test for the property 'OrderSourceId'
        }
        /// <summary>
        /// Test the property 'BatchNo'
        /// </summary>
        [Test]
        public void BatchNoTest()
        {
            // TODO unit test for the property 'BatchNo'
        }
        /// <summary>
        /// Test the property 'IsGift'
        /// </summary>
        [Test]
        public void IsGiftTest()
        {
            // TODO unit test for the property 'IsGift'
        }
        /// <summary>
        /// Test the property 'GiftMessageTo'
        /// </summary>
        [Test]
        public void GiftMessageToTest()
        {
            // TODO unit test for the property 'GiftMessageTo'
        }
        /// <summary>
        /// Test the property 'GiftMessageFrom'
        /// </summary>
        [Test]
        public void GiftMessageFromTest()
        {
            // TODO unit test for the property 'GiftMessageFrom'
        }
        /// <summary>
        /// Test the property 'GiftMessage'
        /// </summary>
        [Test]
        public void GiftMessageTest()
        {
            // TODO unit test for the property 'GiftMessage'
        }
        /// <summary>
        /// Test the property 'EmailRecipient'
        /// </summary>
        [Test]
        public void EmailRecipientTest()
        {
            // TODO unit test for the property 'EmailRecipient'
        }
        /// <summary>
        /// Test the property 'MailRecipient'
        /// </summary>
        [Test]
        public void MailRecipientTest()
        {
            // TODO unit test for the property 'MailRecipient'
        }
        /// <summary>
        /// Test the property 'KeyCode'
        /// </summary>
        [Test]
        public void KeyCodeTest()
        {
            // TODO unit test for the property 'KeyCode'
        }
        /// <summary>
        /// Test the property 'KeyCodeDescription'
        /// </summary>
        [Test]
        public void KeyCodeDescriptionTest()
        {
            // TODO unit test for the property 'KeyCodeDescription'
        }
        /// <summary>
        /// Test the property 'DeliverOnDate'
        /// </summary>
        [Test]
        public void DeliverOnDateTest()
        {
            // TODO unit test for the property 'DeliverOnDate'
        }
        /// <summary>
        /// Test the property 'DistCharges'
        /// </summary>
        [Test]
        public void DistChargesTest()
        {
            // TODO unit test for the property 'DistCharges'
        }
        /// <summary>
        /// Test the property 'SubTotal'
        /// </summary>
        [Test]
        public void SubTotalTest()
        {
            // TODO unit test for the property 'SubTotal'
        }
        /// <summary>
        /// Test the property 'ShipVia'
        /// </summary>
        [Test]
        public void ShipViaTest()
        {
            // TODO unit test for the property 'ShipVia'
        }
        /// <summary>
        /// Test the property 'LineItems'
        /// </summary>
        [Test]
        public void LineItemsTest()
        {
            // TODO unit test for the property 'LineItems'
        }
        /// <summary>
        /// Test the property 'ShipToFirstName'
        /// </summary>
        [Test]
        public void ShipToFirstNameTest()
        {
            // TODO unit test for the property 'ShipToFirstName'
        }
        /// <summary>
        /// Test the property 'ShipToLastName'
        /// </summary>
        [Test]
        public void ShipToLastNameTest()
        {
            // TODO unit test for the property 'ShipToLastName'
        }
        /// <summary>
        /// Test the property 'ShipToCompany'
        /// </summary>
        [Test]
        public void ShipToCompanyTest()
        {
            // TODO unit test for the property 'ShipToCompany'
        }
        /// <summary>
        /// Test the property 'ShipToStreet1'
        /// </summary>
        [Test]
        public void ShipToStreet1Test()
        {
            // TODO unit test for the property 'ShipToStreet1'
        }
        /// <summary>
        /// Test the property 'ShipToStreet2'
        /// </summary>
        [Test]
        public void ShipToStreet2Test()
        {
            // TODO unit test for the property 'ShipToStreet2'
        }
        /// <summary>
        /// Test the property 'ShipToStreet3'
        /// </summary>
        [Test]
        public void ShipToStreet3Test()
        {
            // TODO unit test for the property 'ShipToStreet3'
        }
        /// <summary>
        /// Test the property 'ShipToCity'
        /// </summary>
        [Test]
        public void ShipToCityTest()
        {
            // TODO unit test for the property 'ShipToCity'
        }
        /// <summary>
        /// Test the property 'ShipToState'
        /// </summary>
        [Test]
        public void ShipToStateTest()
        {
            // TODO unit test for the property 'ShipToState'
        }
        /// <summary>
        /// Test the property 'ShipToZip'
        /// </summary>
        [Test]
        public void ShipToZipTest()
        {
            // TODO unit test for the property 'ShipToZip'
        }
        /// <summary>
        /// Test the property 'ShipToEmail'
        /// </summary>
        [Test]
        public void ShipToEmailTest()
        {
            // TODO unit test for the property 'ShipToEmail'
        }
        /// <summary>
        /// Test the property 'ShipToPhone'
        /// </summary>
        [Test]
        public void ShipToPhoneTest()
        {
            // TODO unit test for the property 'ShipToPhone'
        }
        /// <summary>
        /// Test the property 'BillToFirstName'
        /// </summary>
        [Test]
        public void BillToFirstNameTest()
        {
            // TODO unit test for the property 'BillToFirstName'
        }
        /// <summary>
        /// Test the property 'BillToLastName'
        /// </summary>
        [Test]
        public void BillToLastNameTest()
        {
            // TODO unit test for the property 'BillToLastName'
        }
        /// <summary>
        /// Test the property 'BillToCompany'
        /// </summary>
        [Test]
        public void BillToCompanyTest()
        {
            // TODO unit test for the property 'BillToCompany'
        }
        /// <summary>
        /// Test the property 'BillToStreet1'
        /// </summary>
        [Test]
        public void BillToStreet1Test()
        {
            // TODO unit test for the property 'BillToStreet1'
        }
        /// <summary>
        /// Test the property 'BillToStreet2'
        /// </summary>
        [Test]
        public void BillToStreet2Test()
        {
            // TODO unit test for the property 'BillToStreet2'
        }
        /// <summary>
        /// Test the property 'BillToStreet3'
        /// </summary>
        [Test]
        public void BillToStreet3Test()
        {
            // TODO unit test for the property 'BillToStreet3'
        }
        /// <summary>
        /// Test the property 'BillToCity'
        /// </summary>
        [Test]
        public void BillToCityTest()
        {
            // TODO unit test for the property 'BillToCity'
        }
        /// <summary>
        /// Test the property 'BillToState'
        /// </summary>
        [Test]
        public void BillToStateTest()
        {
            // TODO unit test for the property 'BillToState'
        }
        /// <summary>
        /// Test the property 'BillToZip'
        /// </summary>
        [Test]
        public void BillToZipTest()
        {
            // TODO unit test for the property 'BillToZip'
        }
        /// <summary>
        /// Test the property 'BillToEmail'
        /// </summary>
        [Test]
        public void BillToEmailTest()
        {
            // TODO unit test for the property 'BillToEmail'
        }
        /// <summary>
        /// Test the property 'BillToPhone'
        /// </summary>
        [Test]
        public void BillToPhoneTest()
        {
            // TODO unit test for the property 'BillToPhone'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }

    }

}
