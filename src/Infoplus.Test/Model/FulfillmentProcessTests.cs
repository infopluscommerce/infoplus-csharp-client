/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v1.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing FulfillmentProcess
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FulfillmentProcessTests
    {
        // TODO uncomment below to declare an instance variable for FulfillmentProcess
        //private FulfillmentProcess instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FulfillmentProcess
            //instance = new FulfillmentProcess();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentProcess
        /// </summary>
        [Test]
        public void FulfillmentProcessInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FulfillmentProcess
            //Assert.IsInstanceOfType<FulfillmentProcess> (instance, "variable 'instance' is a FulfillmentProcess");
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
        /// Test the property 'ProcessNo'
        /// </summary>
        [Test]
        public void ProcessNoTest()
        {
            // TODO unit test for the property 'ProcessNo'
        }
        /// <summary>
        /// Test the property 'WorkBatchId'
        /// </summary>
        [Test]
        public void WorkBatchIdTest()
        {
            // TODO unit test for the property 'WorkBatchId'
        }
        /// <summary>
        /// Test the property 'WarehouseId'
        /// </summary>
        [Test]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
        }
        /// <summary>
        /// Test the property 'AllocationPlanId'
        /// </summary>
        [Test]
        public void AllocationPlanIdTest()
        {
            // TODO unit test for the property 'AllocationPlanId'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'OrderSmartFilterId'
        /// </summary>
        [Test]
        public void OrderSmartFilterIdTest()
        {
            // TODO unit test for the property 'OrderSmartFilterId'
        }
        /// <summary>
        /// Test the property 'LocationSmartFilterId'
        /// </summary>
        [Test]
        public void LocationSmartFilterIdTest()
        {
            // TODO unit test for the property 'LocationSmartFilterId'
        }
        /// <summary>
        /// Test the property 'OrderLimit'
        /// </summary>
        [Test]
        public void OrderLimitTest()
        {
            // TODO unit test for the property 'OrderLimit'
        }
        /// <summary>
        /// Test the property 'NumberOfOrders'
        /// </summary>
        [Test]
        public void NumberOfOrdersTest()
        {
            // TODO unit test for the property 'NumberOfOrders'
        }
        /// <summary>
        /// Test the property 'NumberOfLines'
        /// </summary>
        [Test]
        public void NumberOfLinesTest()
        {
            // TODO unit test for the property 'NumberOfLines'
        }
        /// <summary>
        /// Test the property 'NumberOfSKUs'
        /// </summary>
        [Test]
        public void NumberOfSKUsTest()
        {
            // TODO unit test for the property 'NumberOfSKUs'
        }
        /// <summary>
        /// Test the property 'CompletedPicks'
        /// </summary>
        [Test]
        public void CompletedPicksTest()
        {
            // TODO unit test for the property 'CompletedPicks'
        }
        /// <summary>
        /// Test the property 'TotalPicks'
        /// </summary>
        [Test]
        public void TotalPicksTest()
        {
            // TODO unit test for the property 'TotalPicks'
        }
        /// <summary>
        /// Test the property 'ShippedCasebreaks'
        /// </summary>
        [Test]
        public void ShippedCasebreaksTest()
        {
            // TODO unit test for the property 'ShippedCasebreaks'
        }
        /// <summary>
        /// Test the property 'TotalCasebreaksToShip'
        /// </summary>
        [Test]
        public void TotalCasebreaksToShipTest()
        {
            // TODO unit test for the property 'TotalCasebreaksToShip'
        }
        /// <summary>
        /// Test the property 'ShippedOrders'
        /// </summary>
        [Test]
        public void ShippedOrdersTest()
        {
            // TODO unit test for the property 'ShippedOrders'
        }
        /// <summary>
        /// Test the property 'TotalOrdersToShip'
        /// </summary>
        [Test]
        public void TotalOrdersToShipTest()
        {
            // TODO unit test for the property 'TotalOrdersToShip'
        }
        /// <summary>
        /// Test the property 'CompletedToDo'
        /// </summary>
        [Test]
        public void CompletedToDoTest()
        {
            // TODO unit test for the property 'CompletedToDo'
        }
        /// <summary>
        /// Test the property 'TotalToDo'
        /// </summary>
        [Test]
        public void TotalToDoTest()
        {
            // TODO unit test for the property 'TotalToDo'
        }
        /// <summary>
        /// Test the property 'CreatePickWork'
        /// </summary>
        [Test]
        public void CreatePickWorkTest()
        {
            // TODO unit test for the property 'CreatePickWork'
        }
        /// <summary>
        /// Test the property 'PickingRule'
        /// </summary>
        [Test]
        public void PickingRuleTest()
        {
            // TODO unit test for the property 'PickingRule'
        }
        /// <summary>
        /// Test the property 'LayoutRule'
        /// </summary>
        [Test]
        public void LayoutRuleTest()
        {
            // TODO unit test for the property 'LayoutRule'
        }
        /// <summary>
        /// Test the property 'PickSortRule'
        /// </summary>
        [Test]
        public void PickSortRuleTest()
        {
            // TODO unit test for the property 'PickSortRule'
        }
        /// <summary>
        /// Test the property 'FirstPickPosition'
        /// </summary>
        [Test]
        public void FirstPickPositionTest()
        {
            // TODO unit test for the property 'FirstPickPosition'
        }
        /// <summary>
        /// Test the property 'PickListFormat'
        /// </summary>
        [Test]
        public void PickListFormatTest()
        {
            // TODO unit test for the property 'PickListFormat'
        }
        /// <summary>
        /// Test the property 'PickListLayout'
        /// </summary>
        [Test]
        public void PickListLayoutTest()
        {
            // TODO unit test for the property 'PickListLayout'
        }
        /// <summary>
        /// Test the property 'PickListGroup'
        /// </summary>
        [Test]
        public void PickListGroupTest()
        {
            // TODO unit test for the property 'PickListGroup'
        }
        /// <summary>
        /// Test the property 'PickListSort'
        /// </summary>
        [Test]
        public void PickListSortTest()
        {
            // TODO unit test for the property 'PickListSort'
        }
        /// <summary>
        /// Test the property 'PickSummaryFormat'
        /// </summary>
        [Test]
        public void PickSummaryFormatTest()
        {
            // TODO unit test for the property 'PickSummaryFormat'
        }
        /// <summary>
        /// Test the property 'PickSummaryLayout'
        /// </summary>
        [Test]
        public void PickSummaryLayoutTest()
        {
            // TODO unit test for the property 'PickSummaryLayout'
        }
        /// <summary>
        /// Test the property 'PickSummarySort'
        /// </summary>
        [Test]
        public void PickSummarySortTest()
        {
            // TODO unit test for the property 'PickSummarySort'
        }
        /// <summary>
        /// Test the property 'CreatePickSummary'
        /// </summary>
        [Test]
        public void CreatePickSummaryTest()
        {
            // TODO unit test for the property 'CreatePickSummary'
        }
        /// <summary>
        /// Test the property 'CreatePickList'
        /// </summary>
        [Test]
        public void CreatePickListTest()
        {
            // TODO unit test for the property 'CreatePickList'
        }
        /// <summary>
        /// Test the property 'PreGenerateParcelLabels'
        /// </summary>
        [Test]
        public void PreGenerateParcelLabelsTest()
        {
            // TODO unit test for the property 'PreGenerateParcelLabels'
        }
        /// <summary>
        /// Test the property 'ShipDate'
        /// </summary>
        [Test]
        public void ShipDateTest()
        {
            // TODO unit test for the property 'ShipDate'
        }
        /// <summary>
        /// Test the property 'AutoShipCasebreakCartons'
        /// </summary>
        [Test]
        public void AutoShipCasebreakCartonsTest()
        {
            // TODO unit test for the property 'AutoShipCasebreakCartons'
        }
        /// <summary>
        /// Test the property 'CartonizeOrders'
        /// </summary>
        [Test]
        public void CartonizeOrdersTest()
        {
            // TODO unit test for the property 'CartonizeOrders'
        }
        /// <summary>
        /// Test the property 'CreatePackingSlip'
        /// </summary>
        [Test]
        public void CreatePackingSlipTest()
        {
            // TODO unit test for the property 'CreatePackingSlip'
        }
        /// <summary>
        /// Test the property 'OverridePackingSlipTemplateId'
        /// </summary>
        [Test]
        public void OverridePackingSlipTemplateIdTest()
        {
            // TODO unit test for the property 'OverridePackingSlipTemplateId'
        }
        /// <summary>
        /// Test the property 'CreateOrderAssemblyGuide'
        /// </summary>
        [Test]
        public void CreateOrderAssemblyGuideTest()
        {
            // TODO unit test for the property 'CreateOrderAssemblyGuide'
        }

    }

}
