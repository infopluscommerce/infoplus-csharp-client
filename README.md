# betaplus-csharp-client
betaplus is a cloud platform to manage your inventory, orders, warehouse, and shipments.

The betaplus API exposes the full breadth and depth of the betaplus platform to all clients.
With the betaplus API, you can integrate betaplus functionality into other platforms 
(e.g. your ERP, shopping cart, accounting system, etc.), enabling you to do, in your own platform, 
anything you can do in betaplus. 

This repository is a native C# client for full access to the betaplus API.

## betaplus API Resources
The Resources listed below will provide all the betarmation you need to integrate with the betaplus API. 

### Developer's Home Page
https://www.betapluscommerce.com/developers/
* This site gives you an overview of the betaplus API. 
* Get a general understanding of the API and quick steps on getting started. 

### betaplus API Reference Site
http://developers.betapluscommerce.com/
* The betaplus API is a modern JSON + REST API, and the API Reference Site is the complete documentation of all endpoints, resources, and fields available in the API. 
* Whether you're using the API directly over HTTPS, or if you're using a pre-built Client Library like this one, the API Reference Site gives you the specific details you need for each API call available, along with live demo capabilities.
* The API Reference Site also lets you request access to a free Demo Account to test out the API. 

### Have Questions?
* Read an [Overview of the betaplus API](https://support.betapluscommerce.com/support/solutions/articles/11000010373)
* Get in touch with the [betaplus Support Team](https://support.betapluscommerce.com/support/tickets/new)
* Visit the [betaplus API Forum](https://support.betapluscommerce.com/support/discussions/forums/11000000138)

# C# Client Details
- API version: v1.0
- SDK version: 1.0
- Build date: 2016-06-21T08:50:00.164-05:00
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen
    For more betarmation, please visit [http://www.betapluscommerce.com](http://www.betapluscommerce.com)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using betaplus.Api;
using betaplus.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using betaplus.Api;
using betaplus.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');

            // Construct Api instances specifying your betaplus domain:
            var apiInstance = new AisleApi("https://YOUR_DOMAIN.betapluswms.com/");
            var body = new Aisle(); // Aisle | Aisle to be inserted.

            try
            {
                // Create an aisle
                Aisle result = apiInstance.AddAisle(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.AddAisle: " + e.Message );
            }
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to * https://YOUR_DOMAIN.betapluswms.com/betaplus-wms/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AisleApi* | [**AddAisle**](docs/AisleApi.md#addaisle) | **POST** /v1.0/aisle | Create an aisle
*AisleApi* | [**DeleteAisle**](docs/AisleApi.md#deleteaisle) | **DELETE** /v1.0/aisle/{aisleId} | Delete an aisle
*AisleApi* | [**GetAisleByFilter**](docs/AisleApi.md#getaislebyfilter) | **GET** /v1.0/aisle/search | Search aisles by filter
*AisleApi* | [**GetAisleById**](docs/AisleApi.md#getaislebyid) | **GET** /v1.0/aisle/{aisleId} | Get an aisle by id
*AisleApi* | [**UpdateAisle**](docs/AisleApi.md#updateaisle) | **PUT** /v1.0/aisle | Update an aisle
*AlertApi* | [**GetAlertByFilter**](docs/AlertApi.md#getalertbyfilter) | **GET** /v1.0/alert/search | Search alerts by filter
*AlertApi* | [**GetAlertById**](docs/AlertApi.md#getalertbyid) | **GET** /v1.0/alert/{alertId} | Get an alert by id
*AsnApi* | [**AddAsn**](docs/AsnApi.md#addasn) | **POST** /v1.0/asn | Create an asn
*AsnApi* | [**DeleteAsn**](docs/AsnApi.md#deleteasn) | **DELETE** /v1.0/asn/{asnId} | Delete an asn
*AsnApi* | [**GetAsnByFilter**](docs/AsnApi.md#getasnbyfilter) | **GET** /v1.0/asn/search | Search asns by filter
*AsnApi* | [**GetAsnById**](docs/AsnApi.md#getasnbyid) | **GET** /v1.0/asn/{asnId} | Get an asn by id
*AsnApi* | [**UpdateAsn**](docs/AsnApi.md#updateasn) | **PUT** /v1.0/asn | Update an asn
*BillOfLadingApi* | [**AddBillOfLading**](docs/BillOfLadingApi.md#addbilloflading) | **POST** /v1.0/billOfLading | Create a billOfLading
*BillOfLadingApi* | [**DeleteBillOfLading**](docs/BillOfLadingApi.md#deletebilloflading) | **DELETE** /v1.0/billOfLading/{billOfLadingId} | Delete a billOfLading
*BillOfLadingApi* | [**GetBillOfLadingByFilter**](docs/BillOfLadingApi.md#getbillofladingbyfilter) | **GET** /v1.0/billOfLading/search | Search billOfLadings by filter
*BillOfLadingApi* | [**GetBillOfLadingById**](docs/BillOfLadingApi.md#getbillofladingbyid) | **GET** /v1.0/billOfLading/{billOfLadingId} | Get a billOfLading by id
*BillOfLadingApi* | [**UpdateBillOfLading**](docs/BillOfLadingApi.md#updatebilloflading) | **PUT** /v1.0/billOfLading | Update a billOfLading
*BillingCodeApi* | [**AddBillingCode**](docs/BillingCodeApi.md#addbillingcode) | **POST** /v1.0/billingCode | Create a billingCode
*BillingCodeApi* | [**DeleteBillingCode**](docs/BillingCodeApi.md#deletebillingcode) | **DELETE** /v1.0/billingCode/{billingCodeId} | Delete a billingCode
*BillingCodeApi* | [**GetBillingCodeByFilter**](docs/BillingCodeApi.md#getbillingcodebyfilter) | **GET** /v1.0/billingCode/search | Search billingCodes by filter
*BillingCodeApi* | [**GetBillingCodeById**](docs/BillingCodeApi.md#getbillingcodebyid) | **GET** /v1.0/billingCode/{billingCodeId} | Get a billingCode by id
*BillingCodeApi* | [**UpdateBillingCode**](docs/BillingCodeApi.md#updatebillingcode) | **PUT** /v1.0/billingCode | Update a billingCode
*BillingCodeTypeApi* | [**AddBillingCodeType**](docs/BillingCodeTypeApi.md#addbillingcodetype) | **POST** /v1.0/billingCodeType | Create a billingCodeType
*BillingCodeTypeApi* | [**DeleteBillingCodeType**](docs/BillingCodeTypeApi.md#deletebillingcodetype) | **DELETE** /v1.0/billingCodeType/{billingCodeTypeId} | Delete a billingCodeType
*BillingCodeTypeApi* | [**GetBillingCodeTypeByFilter**](docs/BillingCodeTypeApi.md#getbillingcodetypebyfilter) | **GET** /v1.0/billingCodeType/search | Search billingCodeTypes by filter
*BillingCodeTypeApi* | [**GetBillingCodeTypeById**](docs/BillingCodeTypeApi.md#getbillingcodetypebyid) | **GET** /v1.0/billingCodeType/{billingCodeTypeId} | Get a billingCodeType by id
*BillingCodeTypeApi* | [**UpdateBillingCodeType**](docs/BillingCodeTypeApi.md#updatebillingcodetype) | **PUT** /v1.0/billingCodeType | Update a billingCodeType
*BuildingApi* | [**AddBuilding**](docs/BuildingApi.md#addbuilding) | **POST** /v1.0/building | Create a building
*BuildingApi* | [**DeleteBuilding**](docs/BuildingApi.md#deletebuilding) | **DELETE** /v1.0/building/{buildingId} | Delete a building
*BuildingApi* | [**GetBuildingByFilter**](docs/BuildingApi.md#getbuildingbyfilter) | **GET** /v1.0/building/search | Search buildings by filter
*BuildingApi* | [**GetBuildingById**](docs/BuildingApi.md#getbuildingbyid) | **GET** /v1.0/building/{buildingId} | Get a building by id
*BuildingApi* | [**UpdateBuilding**](docs/BuildingApi.md#updatebuilding) | **PUT** /v1.0/building | Update a building
*BusinessTransactionApi* | [**GetBusinessTransactionByFilter**](docs/BusinessTransactionApi.md#getbusinesstransactionbyfilter) | **GET** /v1.0/businessTransaction/search | Search businessTransactions by filter
*BusinessTransactionApi* | [**GetBusinessTransactionById**](docs/BusinessTransactionApi.md#getbusinesstransactionbyid) | **GET** /v1.0/businessTransaction/{businessTransactionId} | Get a businessTransaction by id
*CarrierApi* | [**GetCarrierById**](docs/CarrierApi.md#getcarrierbyid) | **GET** /v1.0/carrier/{carrierId} | Get a carrier by id
*CarrierApi* | [**GetCarrierBySearchText**](docs/CarrierApi.md#getcarrierbysearchtext) | **GET** /v1.0/carrier/search | Search carriers
*CarrierServiceApi* | [**GetCarrierServiceById**](docs/CarrierServiceApi.md#getcarrierservicebyid) | **GET** /v1.0/carrierService/{carrierServiceId} | Get a carrierService by id
*CarrierServiceApi* | [**GetCarrierServiceBySearchText**](docs/CarrierServiceApi.md#getcarrierservicebysearchtext) | **GET** /v1.0/carrierService/search | Search carrierServices
*CartonApi* | [**AddCarton**](docs/CartonApi.md#addcarton) | **POST** /v1.0/carton | Create a carton
*CartonApi* | [**DeleteCarton**](docs/CartonApi.md#deletecarton) | **DELETE** /v1.0/carton/{cartonId} | Delete a carton
*CartonApi* | [**GetCartonByFilter**](docs/CartonApi.md#getcartonbyfilter) | **GET** /v1.0/carton/search | Search cartons by filter
*CartonApi* | [**GetCartonById**](docs/CartonApi.md#getcartonbyid) | **GET** /v1.0/carton/{cartonId} | Get a carton by id
*CartonApi* | [**UpdateCarton**](docs/CartonApi.md#updatecarton) | **PUT** /v1.0/carton | Update a carton
*CartonContentApi* | [**AddCartonContent**](docs/CartonContentApi.md#addcartoncontent) | **POST** /v1.0/cartonContent | Create a cartonContent
*CartonContentApi* | [**DeleteCartonContent**](docs/CartonContentApi.md#deletecartoncontent) | **DELETE** /v1.0/cartonContent/{cartonContentId} | Delete a cartonContent
*CartonContentApi* | [**GetCartonContentByFilter**](docs/CartonContentApi.md#getcartoncontentbyfilter) | **GET** /v1.0/cartonContent/search | Search cartonContents by filter
*CartonContentApi* | [**GetCartonContentById**](docs/CartonContentApi.md#getcartoncontentbyid) | **GET** /v1.0/cartonContent/{cartonContentId} | Get a cartonContent by id
*CartonContentApi* | [**UpdateCartonContent**](docs/CartonContentApi.md#updatecartoncontent) | **PUT** /v1.0/cartonContent | Update a cartonContent
*CartonTypeApi* | [**AddCartonType**](docs/CartonTypeApi.md#addcartontype) | **POST** /v1.0/cartonType | Create a cartonType
*CartonTypeApi* | [**DeleteCartonType**](docs/CartonTypeApi.md#deletecartontype) | **DELETE** /v1.0/cartonType/{cartonTypeId} | Delete a cartonType
*CartonTypeApi* | [**GetCartonTypeByFilter**](docs/CartonTypeApi.md#getcartontypebyfilter) | **GET** /v1.0/cartonType/search | Search cartonTypes by filter
*CartonTypeApi* | [**GetCartonTypeById**](docs/CartonTypeApi.md#getcartontypebyid) | **GET** /v1.0/cartonType/{cartonTypeId} | Get a cartonType by id
*CartonTypeApi* | [**UpdateCartonType**](docs/CartonTypeApi.md#updatecartontype) | **PUT** /v1.0/cartonType | Update a cartonType
*CustomerApi* | [**AddCustomer**](docs/CustomerApi.md#addcustomer) | **POST** /v1.0/customer | Create a customer
*CustomerApi* | [**DeleteCustomer**](docs/CustomerApi.md#deletecustomer) | **DELETE** /v1.0/customer/{customerId} | Delete a customer
*CustomerApi* | [**GetByCustomerNo**](docs/CustomerApi.md#getbycustomerno) | **GET** /v1.0/customer/getByCustomerNo | Get a customer by Customer No
*CustomerApi* | [**GetCustomerByFilter**](docs/CustomerApi.md#getcustomerbyfilter) | **GET** /v1.0/customer/search | Search customers by filter
*CustomerApi* | [**GetCustomerById**](docs/CustomerApi.md#getcustomerbyid) | **GET** /v1.0/customer/{customerId} | Get a customer by id
*CustomerApi* | [**UpdateCustomer**](docs/CustomerApi.md#updatecustomer) | **PUT** /v1.0/customer | Update a customer
*EmailTemplateApi* | [**AddEmailTemplate**](docs/EmailTemplateApi.md#addemailtemplate) | **POST** /v1.0/emailTemplate | Create an emailTemplate
*EmailTemplateApi* | [**DeleteEmailTemplate**](docs/EmailTemplateApi.md#deleteemailtemplate) | **DELETE** /v1.0/emailTemplate/{emailTemplateId} | Delete an emailTemplate
*EmailTemplateApi* | [**GetEmailTemplateByFilter**](docs/EmailTemplateApi.md#getemailtemplatebyfilter) | **GET** /v1.0/emailTemplate/search | Search emailTemplates by filter
*EmailTemplateApi* | [**GetEmailTemplateById**](docs/EmailTemplateApi.md#getemailtemplatebyid) | **GET** /v1.0/emailTemplate/{emailTemplateId} | Get an emailTemplate by id
*EmailTemplateApi* | [**UpdateEmailTemplate**](docs/EmailTemplateApi.md#updateemailtemplate) | **PUT** /v1.0/emailTemplate | Update an emailTemplate
*ExternalShipmentApi* | [**AddExternalShipment**](docs/ExternalShipmentApi.md#addexternalshipment) | **POST** /v1.0/externalShipment | Create an externalShipment
*ExternalShipmentApi* | [**DeleteExternalShipment**](docs/ExternalShipmentApi.md#deleteexternalshipment) | **DELETE** /v1.0/externalShipment/{externalShipmentId} | Delete an externalShipment
*ExternalShipmentApi* | [**GetExternalShipmentByFilter**](docs/ExternalShipmentApi.md#getexternalshipmentbyfilter) | **GET** /v1.0/externalShipment/search | Search externalShipments by filter
*ExternalShipmentApi* | [**GetExternalShipmentById**](docs/ExternalShipmentApi.md#getexternalshipmentbyid) | **GET** /v1.0/externalShipment/{externalShipmentId} | Get an externalShipment by id
*ExternalShipmentApi* | [**UpdateExternalShipment**](docs/ExternalShipmentApi.md#updateexternalshipment) | **PUT** /v1.0/externalShipment | Update an externalShipment
*FulfillmentPlanApi* | [**AddFulfillmentPlan**](docs/FulfillmentPlanApi.md#addfulfillmentplan) | **POST** /v1.0/fulfillmentPlan | Create a fulfillmentPlan
*FulfillmentPlanApi* | [**DeleteFulfillmentPlan**](docs/FulfillmentPlanApi.md#deletefulfillmentplan) | **DELETE** /v1.0/fulfillmentPlan/{fulfillmentPlanId} | Delete a fulfillmentPlan
*FulfillmentPlanApi* | [**GetFulfillmentPlanByFilter**](docs/FulfillmentPlanApi.md#getfulfillmentplanbyfilter) | **GET** /v1.0/fulfillmentPlan/search | Search fulfillmentPlans by filter
*FulfillmentPlanApi* | [**GetFulfillmentPlanById**](docs/FulfillmentPlanApi.md#getfulfillmentplanbyid) | **GET** /v1.0/fulfillmentPlan/{fulfillmentPlanId} | Get a fulfillmentPlan by id
*FulfillmentPlanApi* | [**UpdateFulfillmentPlan**](docs/FulfillmentPlanApi.md#updatefulfillmentplan) | **PUT** /v1.0/fulfillmentPlan | Update a fulfillmentPlan
*FulfillmentProcessApi* | [**GetFulfillmentProcessByFilter**](docs/FulfillmentProcessApi.md#getfulfillmentprocessbyfilter) | **GET** /v1.0/fulfillmentProcess/search | Search fulfillmentProcesses by filter
*FulfillmentProcessApi* | [**GetFulfillmentProcessById**](docs/FulfillmentProcessApi.md#getfulfillmentprocessbyid) | **GET** /v1.0/fulfillmentProcess/{fulfillmentProcessId} | Get a fulfillmentProcess by id
*IntegrationPartnerApi* | [**GetIntegrationPartnerById**](docs/IntegrationPartnerApi.md#getintegrationpartnerbyid) | **GET** /v1.0/integrationPartner/{integrationPartnerId} | Get an integrationPartner by id
*IntegrationPartnerApi* | [**GetIntegrationPartnerBySearchText**](docs/IntegrationPartnerApi.md#getintegrationpartnerbysearchtext) | **GET** /v1.0/integrationPartner/search | Search integrationPartners
*InventoryAdjustmentApi* | [**GetInventoryAdjustmentByFilter**](docs/InventoryAdjustmentApi.md#getinventoryadjustmentbyfilter) | **GET** /v1.0/inventoryAdjustment/search | Search inventoryAdjustments by filter
*InventoryAdjustmentApi* | [**GetInventoryAdjustmentById**](docs/InventoryAdjustmentApi.md#getinventoryadjustmentbyid) | **GET** /v1.0/inventoryAdjustment/{inventoryAdjustmentId} | Get an inventoryAdjustment by id
*InventoryDetailApi* | [**GetInventoryDetailByFilter**](docs/InventoryDetailApi.md#getinventorydetailbyfilter) | **GET** /v1.0/inventoryDetail/search | Search inventoryDetails by filter
*InventoryDetailApi* | [**GetInventoryDetailById**](docs/InventoryDetailApi.md#getinventorydetailbyid) | **GET** /v1.0/inventoryDetail/{inventoryDetailId} | Get an inventoryDetail by id
*ItemApi* | [**AddItem**](docs/ItemApi.md#additem) | **POST** /v1.0/item | Create an item
*ItemApi* | [**DeleteItem**](docs/ItemApi.md#deleteitem) | **DELETE** /v1.0/item/{itemId} | Delete an item
*ItemApi* | [**GetBySKU**](docs/ItemApi.md#getbysku) | **GET** /v1.0/item/getBySKU | Get an item by SKU
*ItemApi* | [**GetItemByFilter**](docs/ItemApi.md#getitembyfilter) | **GET** /v1.0/item/search | Search items by filter
*ItemApi* | [**GetItemById**](docs/ItemApi.md#getitembyid) | **GET** /v1.0/item/{itemId} | Get an item by id
*ItemApi* | [**UpdateItem**](docs/ItemApi.md#updateitem) | **PUT** /v1.0/item | Update an item
*ItemAccountCodeApi* | [**GetItemAccountCodeBySearchText**](docs/ItemAccountCodeApi.md#getitemaccountcodebysearchtext) | **GET** /v1.0/itemAccountCode/search | Search itemAccountCodes
*ItemAccountCodeApi* | [**GetTranslateAccountCodeById**](docs/ItemAccountCodeApi.md#gettranslateaccountcodebyid) | **GET** /v1.0/itemAccountCode/{itemAccountCodeId} | Get an itemAccountCode by id
*ItemBuyerApi* | [**GetItemBuyerBySearchText**](docs/ItemBuyerApi.md#getitembuyerbysearchtext) | **GET** /v1.0/itemBuyer/search | Search itemBuyers
*ItemBuyerApi* | [**GetTranslateBuyerById**](docs/ItemBuyerApi.md#gettranslatebuyerbyid) | **GET** /v1.0/itemBuyer/{itemBuyerId} | Get an itemBuyer by id
*ItemLegacyLowStockContactApi* | [**GetItemLegacyLowStockContactBySearchText**](docs/ItemLegacyLowStockContactApi.md#getitemlegacylowstockcontactbysearchtext) | **GET** /v1.0/itemLegacyLowStockContact/search | Search itemLegacyLowStockContacts
*ItemLegacyLowStockContactApi* | [**GetTranslateLowStockContactById**](docs/ItemLegacyLowStockContactApi.md#gettranslatelowstockcontactbyid) | **GET** /v1.0/itemLegacyLowStockContact/{itemLegacyLowStockContactId} | Get an itemLegacyLowStockContact by id
*ItemLowStockCodeApi* | [**GetItemLowStockCodeBySearchText**](docs/ItemLowStockCodeApi.md#getitemlowstockcodebysearchtext) | **GET** /v1.0/itemLowStockCode/search | Search itemLowStockCodes
*ItemLowStockCodeApi* | [**GetTranslateLowStockCodeById**](docs/ItemLowStockCodeApi.md#gettranslatelowstockcodebyid) | **GET** /v1.0/itemLowStockCode/{itemLowStockCodeId} | Get an itemLowStockCode by id
*ItemMajorGroupApi* | [**GetItemMajorGroupBySearchText**](docs/ItemMajorGroupApi.md#getitemmajorgroupbysearchtext) | **GET** /v1.0/itemMajorGroup/search | Search itemMajorGroups
*ItemMajorGroupApi* | [**GetTranslateMajorGroupById**](docs/ItemMajorGroupApi.md#gettranslatemajorgroupbyid) | **GET** /v1.0/itemMajorGroup/{itemMajorGroupId} | Get an itemMajorGroup by id
*ItemProductCodeApi* | [**GetItemProductCodeBySearchText**](docs/ItemProductCodeApi.md#getitemproductcodebysearchtext) | **GET** /v1.0/itemProductCode/search | Search itemProductCodes
*ItemProductCodeApi* | [**GetTranslateProductCodeById**](docs/ItemProductCodeApi.md#gettranslateproductcodebyid) | **GET** /v1.0/itemProductCode/{itemProductCodeId} | Get an itemProductCode by id
*ItemReceiptApi* | [**GetItemReceiptByFilter**](docs/ItemReceiptApi.md#getitemreceiptbyfilter) | **GET** /v1.0/itemReceipt/search | Search itemReceipts by filter
*ItemReceiptApi* | [**GetItemReceiptById**](docs/ItemReceiptApi.md#getitemreceiptbyid) | **GET** /v1.0/itemReceipt/{itemReceiptId} | Get an itemReceipt by id
*ItemSubGroupApi* | [**GetItemSubGroupBySearchText**](docs/ItemSubGroupApi.md#getitemsubgroupbysearchtext) | **GET** /v1.0/itemSubGroup/search | Search itemSubGroups
*ItemSubGroupApi* | [**GetTranslateSubGroupById**](docs/ItemSubGroupApi.md#gettranslatesubgroupbyid) | **GET** /v1.0/itemSubGroup/{itemSubGroupId} | Get an itemSubGroup by id
*ItemSummaryCodeApi* | [**GetItemSummaryCodeBySearchText**](docs/ItemSummaryCodeApi.md#getitemsummarycodebysearchtext) | **GET** /v1.0/itemSummaryCode/search | Search itemSummaryCodes
*ItemSummaryCodeApi* | [**GetTranslateSummaryCodeById**](docs/ItemSummaryCodeApi.md#gettranslatesummarycodebyid) | **GET** /v1.0/itemSummaryCode/{itemSummaryCodeId} | Get an itemSummaryCode by id
*JobTimeApi* | [**AddJobTime**](docs/JobTimeApi.md#addjobtime) | **POST** /v1.0/jobTime | Create a jobTime
*JobTimeApi* | [**DeleteJobTime**](docs/JobTimeApi.md#deletejobtime) | **DELETE** /v1.0/jobTime/{jobTimeId} | Delete a jobTime
*JobTimeApi* | [**GetJobTimeByFilter**](docs/JobTimeApi.md#getjobtimebyfilter) | **GET** /v1.0/jobTime/search | Search jobTimes by filter
*JobTimeApi* | [**GetJobTimeById**](docs/JobTimeApi.md#getjobtimebyid) | **GET** /v1.0/jobTime/{jobTimeId} | Get a jobTime by id
*JobTimeApi* | [**UpdateJobTime**](docs/JobTimeApi.md#updatejobtime) | **PUT** /v1.0/jobTime | Update a jobTime
*JobTypeApi* | [**AddJobType**](docs/JobTypeApi.md#addjobtype) | **POST** /v1.0/jobType | Create a jobType
*JobTypeApi* | [**DeleteJobType**](docs/JobTypeApi.md#deletejobtype) | **DELETE** /v1.0/jobType/{jobTypeId} | Delete a jobType
*JobTypeApi* | [**GetJobTypeByFilter**](docs/JobTypeApi.md#getjobtypebyfilter) | **GET** /v1.0/jobType/search | Search jobTypes by filter
*JobTypeApi* | [**GetJobTypeById**](docs/JobTypeApi.md#getjobtypebyid) | **GET** /v1.0/jobType/{jobTypeId} | Get a jobType by id
*JobTypeApi* | [**UpdateJobType**](docs/JobTypeApi.md#updatejobtype) | **PUT** /v1.0/jobType | Update a jobType
*LineOfBusinessApi* | [**GetLineOfBusinessById**](docs/LineOfBusinessApi.md#getlineofbusinessbyid) | **GET** /v1.0/lineOfBusiness/{lineOfBusinessId} | Get a lineOfBusiness by id
*LineOfBusinessApi* | [**GetLineOfBusinessBySearchText**](docs/LineOfBusinessApi.md#getlineofbusinessbysearchtext) | **GET** /v1.0/lineOfBusiness/search | Search lineOfBusinesses
*LocationApi* | [**AddLocation**](docs/LocationApi.md#addlocation) | **POST** /v1.0/location | Create a location
*LocationApi* | [**DeleteLocation**](docs/LocationApi.md#deletelocation) | **DELETE** /v1.0/location/{locationId} | Delete a location
*LocationApi* | [**GetLocationByFilter**](docs/LocationApi.md#getlocationbyfilter) | **GET** /v1.0/location/search | Search locations by filter
*LocationApi* | [**GetLocationById**](docs/LocationApi.md#getlocationbyid) | **GET** /v1.0/location/{locationId} | Get a location by id
*LocationApi* | [**UpdateLocation**](docs/LocationApi.md#updatelocation) | **PUT** /v1.0/location | Update a location
*LocationAddressSchemeApi* | [**AddLocationAddressScheme**](docs/LocationAddressSchemeApi.md#addlocationaddressscheme) | **POST** /v1.0/locationAddressScheme | Create a locationAddressScheme
*LocationAddressSchemeApi* | [**DeleteLocationAddressScheme**](docs/LocationAddressSchemeApi.md#deletelocationaddressscheme) | **DELETE** /v1.0/locationAddressScheme/{locationAddressSchemeId} | Delete a locationAddressScheme
*LocationAddressSchemeApi* | [**GetLocationAddressSchemeByFilter**](docs/LocationAddressSchemeApi.md#getlocationaddressschemebyfilter) | **GET** /v1.0/locationAddressScheme/search | Search locationAddressSchemes by filter
*LocationAddressSchemeApi* | [**GetLocationAddressSchemeById**](docs/LocationAddressSchemeApi.md#getlocationaddressschemebyid) | **GET** /v1.0/locationAddressScheme/{locationAddressSchemeId} | Get a locationAddressScheme by id
*LocationAddressSchemeApi* | [**UpdateLocationAddressScheme**](docs/LocationAddressSchemeApi.md#updatelocationaddressscheme) | **PUT** /v1.0/locationAddressScheme | Update a locationAddressScheme
*LocationBillingTypeApi* | [**AddLocationBillingType**](docs/LocationBillingTypeApi.md#addlocationbillingtype) | **POST** /v1.0/locationBillingType | Create a locationBillingType
*LocationBillingTypeApi* | [**DeleteLocationBillingType**](docs/LocationBillingTypeApi.md#deletelocationbillingtype) | **DELETE** /v1.0/locationBillingType/{locationBillingTypeId} | Delete a locationBillingType
*LocationBillingTypeApi* | [**GetLocationBillingTypeByFilter**](docs/LocationBillingTypeApi.md#getlocationbillingtypebyfilter) | **GET** /v1.0/locationBillingType/search | Search locationBillingTypes by filter
*LocationBillingTypeApi* | [**GetLocationBillingTypeById**](docs/LocationBillingTypeApi.md#getlocationbillingtypebyid) | **GET** /v1.0/locationBillingType/{locationBillingTypeId} | Get a locationBillingType by id
*LocationBillingTypeApi* | [**UpdateLocationBillingType**](docs/LocationBillingTypeApi.md#updatelocationbillingtype) | **PUT** /v1.0/locationBillingType | Update a locationBillingType
*LocationFootprintApi* | [**AddLocationFootprint**](docs/LocationFootprintApi.md#addlocationfootprint) | **POST** /v1.0/locationFootprint | Create a locationFootprint
*LocationFootprintApi* | [**DeleteLocationFootprint**](docs/LocationFootprintApi.md#deletelocationfootprint) | **DELETE** /v1.0/locationFootprint/{locationFootprintId} | Delete a locationFootprint
*LocationFootprintApi* | [**GetLocationFootprintByFilter**](docs/LocationFootprintApi.md#getlocationfootprintbyfilter) | **GET** /v1.0/locationFootprint/search | Search locationFootprints by filter
*LocationFootprintApi* | [**GetLocationFootprintById**](docs/LocationFootprintApi.md#getlocationfootprintbyid) | **GET** /v1.0/locationFootprint/{locationFootprintId} | Get a locationFootprint by id
*LocationFootprintApi* | [**UpdateLocationFootprint**](docs/LocationFootprintApi.md#updatelocationfootprint) | **PUT** /v1.0/locationFootprint | Update a locationFootprint
*LoggedTimeApi* | [**GetLoggedTimeByFilter**](docs/LoggedTimeApi.md#getloggedtimebyfilter) | **GET** /v1.0/loggedTime/search | Search loggedTimes by filter
*LoggedTimeApi* | [**GetLoggedTimeById**](docs/LoggedTimeApi.md#getloggedtimebyid) | **GET** /v1.0/loggedTime/{loggedTimeId} | Get a loggedTime by id
*LoggedTimeTypeApi* | [**GetLoggedTimeTypeById**](docs/LoggedTimeTypeApi.md#getloggedtimetypebyid) | **GET** /v1.0/loggedTimeType/{loggedTimeTypeId} | Get a loggedTimeType by id
*LoggedTimeTypeApi* | [**GetLoggedTimeTypeBySearchText**](docs/LoggedTimeTypeApi.md#getloggedtimetypebysearchtext) | **GET** /v1.0/loggedTimeType/search | Search loggedTimeTypes
*LowStockApi* | [**GetLowStockByFilter**](docs/LowStockApi.md#getlowstockbyfilter) | **GET** /v1.0/lowStock/search | Search lowStocks by filter
*LowStockApi* | [**GetLowStockById**](docs/LowStockApi.md#getlowstockbyid) | **GET** /v1.0/lowStock/{lowStockId} | Get a lowStock by id
*OrderApi* | [**AddOrder**](docs/OrderApi.md#addorder) | **POST** /v1.0/order | Create an order
*OrderApi* | [**DeleteOrder**](docs/OrderApi.md#deleteorder) | **DELETE** /v1.0/order/{orderId} | Delete an order
*OrderApi* | [**GetOrderByFilter**](docs/OrderApi.md#getorderbyfilter) | **GET** /v1.0/order/search | Search orders by filter
*OrderApi* | [**GetOrderById**](docs/OrderApi.md#getorderbyid) | **GET** /v1.0/order/{orderId} | Get an order by id
*OrderApi* | [**UpdateOrder**](docs/OrderApi.md#updateorder) | **PUT** /v1.0/order | Update an order
*OrderLineApi* | [**GetOrderLineByFilter**](docs/OrderLineApi.md#getorderlinebyfilter) | **GET** /v1.0/orderLine/search | Search orderLines by filter
*OrderLineApi* | [**GetOrderLineById**](docs/OrderLineApi.md#getorderlinebyid) | **GET** /v1.0/orderLine/{orderLineId} | Get an orderLine by id
*OrderLoadProgramApi* | [**GetOrderLoadProgramBySearchText**](docs/OrderLoadProgramApi.md#getorderloadprogrambysearchtext) | **GET** /v1.0/orderLoadProgram/search | Search orderLoadPrograms
*OrderLoadProgramApi* | [**GetReqLoadProgramById**](docs/OrderLoadProgramApi.md#getreqloadprogrambyid) | **GET** /v1.0/orderLoadProgram/{orderLoadProgramId} | Get an orderLoadProgram by id
*OrderSourceApi* | [**AddOrderSource**](docs/OrderSourceApi.md#addordersource) | **POST** /v1.0/orderSource | Create an orderSource
*OrderSourceApi* | [**DeleteOrderSource**](docs/OrderSourceApi.md#deleteordersource) | **DELETE** /v1.0/orderSource/{orderSourceId} | Delete an orderSource
*OrderSourceApi* | [**GetOrderSourceByFilter**](docs/OrderSourceApi.md#getordersourcebyfilter) | **GET** /v1.0/orderSource/search | Search orderSources by filter
*OrderSourceApi* | [**GetOrderSourceById**](docs/OrderSourceApi.md#getordersourcebyid) | **GET** /v1.0/orderSource/{orderSourceId} | Get an orderSource by id
*OrderSourceApi* | [**UpdateOrderSource**](docs/OrderSourceApi.md#updateordersource) | **PUT** /v1.0/orderSource | Update an orderSource
*OrderSourceReservationApi* | [**AddOrderSourceReservation**](docs/OrderSourceReservationApi.md#addordersourcereservation) | **POST** /v1.0/orderSourceReservation | Create an orderSourceReservation
*OrderSourceReservationApi* | [**DeleteOrderSourceReservation**](docs/OrderSourceReservationApi.md#deleteordersourcereservation) | **DELETE** /v1.0/orderSourceReservation/{orderSourceReservationId} | Delete an orderSourceReservation
*OrderSourceReservationApi* | [**GetOrderSourceReservationByFilter**](docs/OrderSourceReservationApi.md#getordersourcereservationbyfilter) | **GET** /v1.0/orderSourceReservation/search | Search orderSourceReservations by filter
*OrderSourceReservationApi* | [**GetOrderSourceReservationById**](docs/OrderSourceReservationApi.md#getordersourcereservationbyid) | **GET** /v1.0/orderSourceReservation/{orderSourceReservationId} | Get an orderSourceReservation by id
*OrderSourceReservationApi* | [**UpdateOrderSourceReservation**](docs/OrderSourceReservationApi.md#updateordersourcereservation) | **PUT** /v1.0/orderSourceReservation | Update an orderSourceReservation
*OverrideReturnAddressApi* | [**AddOverrideReturnAddress**](docs/OverrideReturnAddressApi.md#addoverridereturnaddress) | **POST** /v1.0/overrideReturnAddress | Create an overrideReturnAddress
*OverrideReturnAddressApi* | [**DeleteOverrideReturnAddress**](docs/OverrideReturnAddressApi.md#deleteoverridereturnaddress) | **DELETE** /v1.0/overrideReturnAddress/{overrideReturnAddressId} | Delete an overrideReturnAddress
*OverrideReturnAddressApi* | [**GetOverrideReturnAddressByFilter**](docs/OverrideReturnAddressApi.md#getoverridereturnaddressbyfilter) | **GET** /v1.0/overrideReturnAddress/search | Search overrideReturnAddresses by filter
*OverrideReturnAddressApi* | [**GetOverrideReturnAddressById**](docs/OverrideReturnAddressApi.md#getoverridereturnaddressbyid) | **GET** /v1.0/overrideReturnAddress/{overrideReturnAddressId} | Get an overrideReturnAddress by id
*OverrideReturnAddressApi* | [**UpdateOverrideReturnAddress**](docs/OverrideReturnAddressApi.md#updateoverridereturnaddress) | **PUT** /v1.0/overrideReturnAddress | Update an overrideReturnAddress
*ParcelAccountApi* | [**GetParcelAccountByFilter**](docs/ParcelAccountApi.md#getparcelaccountbyfilter) | **GET** /v1.0/parcelAccount/search | Search parcelAccounts by filter
*ParcelAccountApi* | [**GetParcelAccountById**](docs/ParcelAccountApi.md#getparcelaccountbyid) | **GET** /v1.0/parcelAccount/{parcelAccountId} | Get a parcelAccount by id
*ParcelShipmentApi* | [**GetParcelShipmentByFilter**](docs/ParcelShipmentApi.md#getparcelshipmentbyfilter) | **GET** /v1.0/parcelShipment/search | Search parcelShipments by filter
*ParcelShipmentApi* | [**GetParcelShipmentById**](docs/ParcelShipmentApi.md#getparcelshipmentbyid) | **GET** /v1.0/parcelShipment/{parcelShipmentId} | Get a parcelShipment by id
*PickFaceAssignmentApi* | [**AddPickFaceAssignment**](docs/PickFaceAssignmentApi.md#addpickfaceassignment) | **POST** /v1.0/pickFaceAssignment | Create a pickFaceAssignment
*PickFaceAssignmentApi* | [**DeletePickFaceAssignment**](docs/PickFaceAssignmentApi.md#deletepickfaceassignment) | **DELETE** /v1.0/pickFaceAssignment/{pickFaceAssignmentId} | Delete a pickFaceAssignment
*PickFaceAssignmentApi* | [**GetPickFaceAssignmentByFilter**](docs/PickFaceAssignmentApi.md#getpickfaceassignmentbyfilter) | **GET** /v1.0/pickFaceAssignment/search | Search pickFaceAssignments by filter
*PickFaceAssignmentApi* | [**GetPickFaceAssignmentById**](docs/PickFaceAssignmentApi.md#getpickfaceassignmentbyid) | **GET** /v1.0/pickFaceAssignment/{pickFaceAssignmentId} | Get a pickFaceAssignment by id
*PickFaceAssignmentApi* | [**UpdatePickFaceAssignment**](docs/PickFaceAssignmentApi.md#updatepickfaceassignment) | **PUT** /v1.0/pickFaceAssignment | Update a pickFaceAssignment
*ProductTypeApi* | [**GetProductTypeById**](docs/ProductTypeApi.md#getproducttypebyid) | **GET** /v1.0/productType/{productTypeId} | Get a productType by id
*ProductTypeApi* | [**GetProductTypeBySearchText**](docs/ProductTypeApi.md#getproducttypebysearchtext) | **GET** /v1.0/productType/search | Search productTypes
*ProductionLotApi* | [**GetProductionLotByFilter**](docs/ProductionLotApi.md#getproductionlotbyfilter) | **GET** /v1.0/productionLot/search | Search productionLots by filter
*ProductionLotApi* | [**GetProductionLotById**](docs/ProductionLotApi.md#getproductionlotbyid) | **GET** /v1.0/productionLot/{productionLotId} | Get a productionLot by id
*QuickAdjustmentApi* | [**AddQuickAdjustment**](docs/QuickAdjustmentApi.md#addquickadjustment) | **POST** /v1.0/quickAdjustment | Create a quickAdjustment
*QuickAdjustmentApi* | [**DeleteQuickAdjustment**](docs/QuickAdjustmentApi.md#deletequickadjustment) | **DELETE** /v1.0/quickAdjustment/{quickAdjustmentId} | Delete a quickAdjustment
*QuickAdjustmentApi* | [**GetQuickAdjustmentByFilter**](docs/QuickAdjustmentApi.md#getquickadjustmentbyfilter) | **GET** /v1.0/quickAdjustment/search | Search quickAdjustments by filter
*QuickAdjustmentApi* | [**GetQuickAdjustmentById**](docs/QuickAdjustmentApi.md#getquickadjustmentbyid) | **GET** /v1.0/quickAdjustment/{quickAdjustmentId} | Get a quickAdjustment by id
*QuickAdjustmentApi* | [**UpdateQuickAdjustment**](docs/QuickAdjustmentApi.md#updatequickadjustment) | **PUT** /v1.0/quickAdjustment | Update a quickAdjustment
*QuickReceiptApi* | [**AddQuickReceipt**](docs/QuickReceiptApi.md#addquickreceipt) | **POST** /v1.0/quickReceipt | Create a quickReceipt
*QuickReceiptApi* | [**DeleteQuickReceipt**](docs/QuickReceiptApi.md#deletequickreceipt) | **DELETE** /v1.0/quickReceipt/{quickReceiptId} | Delete a quickReceipt
*QuickReceiptApi* | [**GetQuickReceiptByFilter**](docs/QuickReceiptApi.md#getquickreceiptbyfilter) | **GET** /v1.0/quickReceipt/search | Search quickReceipts by filter
*QuickReceiptApi* | [**GetQuickReceiptById**](docs/QuickReceiptApi.md#getquickreceiptbyid) | **GET** /v1.0/quickReceipt/{quickReceiptId} | Get a quickReceipt by id
*QuickReceiptApi* | [**UpdateQuickReceipt**](docs/QuickReceiptApi.md#updatequickreceipt) | **PUT** /v1.0/quickReceipt | Update a quickReceipt
*ReceivingProcessApi* | [**DeleteReceivingProcess**](docs/ReceivingProcessApi.md#deletereceivingprocess) | **DELETE** /v1.0/receivingProcess/{receivingProcessId} | Delete a receivingProcess
*ReceivingProcessApi* | [**GetReceivingProcessByFilter**](docs/ReceivingProcessApi.md#getreceivingprocessbyfilter) | **GET** /v1.0/receivingProcess/search | Search receivingProcesses by filter
*ReceivingProcessApi* | [**GetReceivingProcessById**](docs/ReceivingProcessApi.md#getreceivingprocessbyid) | **GET** /v1.0/receivingProcess/{receivingProcessId} | Get a receivingProcess by id
*ReceivingWorksheetApi* | [**AddReceivingWorksheet**](docs/ReceivingWorksheetApi.md#addreceivingworksheet) | **POST** /v1.0/receivingWorksheet | Create a receivingWorksheet
*ReceivingWorksheetApi* | [**DeleteReceivingWorksheet**](docs/ReceivingWorksheetApi.md#deletereceivingworksheet) | **DELETE** /v1.0/receivingWorksheet/{receivingWorksheetId} | Delete a receivingWorksheet
*ReceivingWorksheetApi* | [**GetReceivingWorksheetByFilter**](docs/ReceivingWorksheetApi.md#getreceivingworksheetbyfilter) | **GET** /v1.0/receivingWorksheet/search | Search receivingWorksheets by filter
*ReceivingWorksheetApi* | [**GetReceivingWorksheetById**](docs/ReceivingWorksheetApi.md#getreceivingworksheetbyid) | **GET** /v1.0/receivingWorksheet/{receivingWorksheetId} | Get a receivingWorksheet by id
*ReceivingWorksheetApi* | [**UpdateReceivingWorksheet**](docs/ReceivingWorksheetApi.md#updatereceivingworksheet) | **PUT** /v1.0/receivingWorksheet | Update a receivingWorksheet
*ReplenishmentApi* | [**GetReplenishmentByFilter**](docs/ReplenishmentApi.md#getreplenishmentbyfilter) | **GET** /v1.0/replenishment/search | Search replenishments by filter
*ReplenishmentApi* | [**GetReplenishmentById**](docs/ReplenishmentApi.md#getreplenishmentbyid) | **GET** /v1.0/replenishment/{replenishmentId} | Get a replenishment by id
*ReplenishmentPlanApi* | [**AddReplenishmentPlan**](docs/ReplenishmentPlanApi.md#addreplenishmentplan) | **POST** /v1.0/replenishmentPlan | Create a replenishmentPlan
*ReplenishmentPlanApi* | [**DeleteReplenishmentPlan**](docs/ReplenishmentPlanApi.md#deletereplenishmentplan) | **DELETE** /v1.0/replenishmentPlan/{replenishmentPlanId} | Delete a replenishmentPlan
*ReplenishmentPlanApi* | [**GetReplenishmentPlanByFilter**](docs/ReplenishmentPlanApi.md#getreplenishmentplanbyfilter) | **GET** /v1.0/replenishmentPlan/search | Search replenishmentPlans by filter
*ReplenishmentPlanApi* | [**GetReplenishmentPlanById**](docs/ReplenishmentPlanApi.md#getreplenishmentplanbyid) | **GET** /v1.0/replenishmentPlan/{replenishmentPlanId} | Get a replenishmentPlan by id
*ReplenishmentPlanApi* | [**UpdateReplenishmentPlan**](docs/ReplenishmentPlanApi.md#updatereplenishmentplan) | **PUT** /v1.0/replenishmentPlan | Update a replenishmentPlan
*ReplenishmentProcessApi* | [**GetReplenishmentProcessByFilter**](docs/ReplenishmentProcessApi.md#getreplenishmentprocessbyfilter) | **GET** /v1.0/replenishmentProcess/search | Search replenishmentProcesses by filter
*ReplenishmentProcessApi* | [**GetReplenishmentProcessById**](docs/ReplenishmentProcessApi.md#getreplenishmentprocessbyid) | **GET** /v1.0/replenishmentProcess/{replenishmentProcessId} | Get a replenishmentProcess by id
*ServiceTypeApi* | [**GetServiceTypeById**](docs/ServiceTypeApi.md#getservicetypebyid) | **GET** /v1.0/serviceType/{serviceTypeId} | Get a serviceType by id
*ServiceTypeApi* | [**GetServiceTypeBySearchText**](docs/ServiceTypeApi.md#getservicetypebysearchtext) | **GET** /v1.0/serviceType/search | Search serviceTypes
*ShoppingCartConnectionApi* | [**AddShoppingCartConnection**](docs/ShoppingCartConnectionApi.md#addshoppingcartconnection) | **POST** /v1.0/shoppingCartConnection | Create a shoppingCartConnection
*ShoppingCartConnectionApi* | [**DeleteShoppingCartConnection**](docs/ShoppingCartConnectionApi.md#deleteshoppingcartconnection) | **DELETE** /v1.0/shoppingCartConnection/{shoppingCartConnectionId} | Delete a shoppingCartConnection
*ShoppingCartConnectionApi* | [**GetShoppingCartConnectionByFilter**](docs/ShoppingCartConnectionApi.md#getshoppingcartconnectionbyfilter) | **GET** /v1.0/shoppingCartConnection/search | Search shoppingCartConnections by filter
*ShoppingCartConnectionApi* | [**GetShoppingCartConnectionById**](docs/ShoppingCartConnectionApi.md#getshoppingcartconnectionbyid) | **GET** /v1.0/shoppingCartConnection/{shoppingCartConnectionId} | Get a shoppingCartConnection by id
*ShoppingCartConnectionApi* | [**UpdateShoppingCartConnection**](docs/ShoppingCartConnectionApi.md#updateshoppingcartconnection) | **PUT** /v1.0/shoppingCartConnection | Update a shoppingCartConnection
*ThirdPartyParcelAccountApi* | [**AddThirdPartyParcelAccount**](docs/ThirdPartyParcelAccountApi.md#addthirdpartyparcelaccount) | **POST** /v1.0/thirdPartyParcelAccount | Create a thirdPartyParcelAccount
*ThirdPartyParcelAccountApi* | [**DeleteThirdPartyParcelAccount**](docs/ThirdPartyParcelAccountApi.md#deletethirdpartyparcelaccount) | **DELETE** /v1.0/thirdPartyParcelAccount/{thirdPartyParcelAccountId} | Delete a thirdPartyParcelAccount
*ThirdPartyParcelAccountApi* | [**GetThirdPartyParcelAccountByFilter**](docs/ThirdPartyParcelAccountApi.md#getthirdpartyparcelaccountbyfilter) | **GET** /v1.0/thirdPartyParcelAccount/search | Search thirdPartyParcelAccounts by filter
*ThirdPartyParcelAccountApi* | [**GetThirdPartyParcelAccountById**](docs/ThirdPartyParcelAccountApi.md#getthirdpartyparcelaccountbyid) | **GET** /v1.0/thirdPartyParcelAccount/{thirdPartyParcelAccountId} | Get a thirdPartyParcelAccount by id
*ThirdPartyParcelAccountApi* | [**UpdateThirdPartyParcelAccount**](docs/ThirdPartyParcelAccountApi.md#updatethirdpartyparcelaccount) | **PUT** /v1.0/thirdPartyParcelAccount | Update a thirdPartyParcelAccount
*UserApi* | [**GetUserById**](docs/UserApi.md#getuserbyid) | **GET** /v1.0/user/{userId} | Get an user by id
*UserApi* | [**GetUserBySearchText**](docs/UserApi.md#getuserbysearchtext) | **GET** /v1.0/user/search | Search users
*VendorApi* | [**AddVendor**](docs/VendorApi.md#addvendor) | **POST** /v1.0/vendor | Create a vendor
*VendorApi* | [**DeleteVendor**](docs/VendorApi.md#deletevendor) | **DELETE** /v1.0/vendor/{vendorId} | Delete a vendor
*VendorApi* | [**GetVendorByFilter**](docs/VendorApi.md#getvendorbyfilter) | **GET** /v1.0/vendor/search | Search vendors by filter
*VendorApi* | [**GetVendorById**](docs/VendorApi.md#getvendorbyid) | **GET** /v1.0/vendor/{vendorId} | Get a vendor by id
*VendorApi* | [**UpdateVendor**](docs/VendorApi.md#updatevendor) | **PUT** /v1.0/vendor | Update a vendor
*VendorComplianceSurveyApi* | [**AddVendorComplianceSurvey**](docs/VendorComplianceSurveyApi.md#addvendorcompliancesurvey) | **POST** /v1.0/vendorComplianceSurvey | Create a vendorComplianceSurvey
*VendorComplianceSurveyApi* | [**DeleteVendorComplianceSurvey**](docs/VendorComplianceSurveyApi.md#deletevendorcompliancesurvey) | **DELETE** /v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId} | Delete a vendorComplianceSurvey
*VendorComplianceSurveyApi* | [**GetVendorComplianceSurveyByFilter**](docs/VendorComplianceSurveyApi.md#getvendorcompliancesurveybyfilter) | **GET** /v1.0/vendorComplianceSurvey/search | Search vendorComplianceSurveys by filter
*VendorComplianceSurveyApi* | [**GetVendorComplianceSurveyById**](docs/VendorComplianceSurveyApi.md#getvendorcompliancesurveybyid) | **GET** /v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId} | Get a vendorComplianceSurvey by id
*VendorComplianceSurveyApi* | [**UpdateVendorComplianceSurvey**](docs/VendorComplianceSurveyApi.md#updatevendorcompliancesurvey) | **PUT** /v1.0/vendorComplianceSurvey | Update a vendorComplianceSurvey
*WarehouseApi* | [**GetWarehouseByFilter**](docs/WarehouseApi.md#getwarehousebyfilter) | **GET** /v1.0/warehouse/search | Search warehouses by filter
*WarehouseApi* | [**GetWarehouseById**](docs/WarehouseApi.md#getwarehousebyid) | **GET** /v1.0/warehouse/{warehouseId} | Get a warehouse by id
*WarehouseApi* | [**UpdateWarehouse**](docs/WarehouseApi.md#updatewarehouse) | **PUT** /v1.0/warehouse | Update a warehouse
*WarehouseDocumentApi* | [**GetWarehouseDocumentByFilter**](docs/WarehouseDocumentApi.md#getwarehousedocumentbyfilter) | **GET** /v1.0/warehouseDocument/search | Search warehouseDocuments by filter
*WarehouseDocumentApi* | [**GetWarehouseDocumentById**](docs/WarehouseDocumentApi.md#getwarehousedocumentbyid) | **GET** /v1.0/warehouseDocument/{warehouseDocumentId} | Get a warehouseDocument by id
*WarehouseDocumentTypeApi* | [**GetWarehouseDocumentTypeByFilter**](docs/WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyfilter) | **GET** /v1.0/warehouseDocumentType/search | Search warehouseDocumentTypes by filter
*WarehouseDocumentTypeApi* | [**GetWarehouseDocumentTypeById**](docs/WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyid) | **GET** /v1.0/warehouseDocumentType/{warehouseDocumentTypeId} | Get a warehouseDocumentType by id
*WorkApi* | [**GetWorkByFilter**](docs/WorkApi.md#getworkbyfilter) | **GET** /v1.0/work/search | Search works by filter
*WorkApi* | [**GetWorkById**](docs/WorkApi.md#getworkbyid) | **GET** /v1.0/work/{workId} | Get a work by id
*WorkBatchApi* | [**GetWorkBatchByFilter**](docs/WorkBatchApi.md#getworkbatchbyfilter) | **GET** /v1.0/workBatch/search | Search workBatchs by filter
*WorkBatchApi* | [**GetWorkBatchById**](docs/WorkBatchApi.md#getworkbatchbyid) | **GET** /v1.0/workBatch/{workBatchId} | Get a workBatch by id
*ZoneApi* | [**AddZone**](docs/ZoneApi.md#addzone) | **POST** /v1.0/zone | Create a zone
*ZoneApi* | [**DeleteZone**](docs/ZoneApi.md#deletezone) | **DELETE** /v1.0/zone/{zoneId} | Delete a zone
*ZoneApi* | [**GetZoneByFilter**](docs/ZoneApi.md#getzonebyfilter) | **GET** /v1.0/zone/search | Search zones by filter
*ZoneApi* | [**GetZoneById**](docs/ZoneApi.md#getzonebyid) | **GET** /v1.0/zone/{zoneId} | Get a zone by id
*ZoneApi* | [**UpdateZone**](docs/ZoneApi.md#updatezone) | **PUT** /v1.0/zone | Update a zone


## Documentation for Models

 - [Model.Aisle](docs/Aisle.md)
 - [Model.Alert](docs/Alert.md)
 - [Model.ApiResponse](docs/ApiResponse.md)
 - [Model.Asn](docs/Asn.md)
 - [Model.BillOfLading](docs/BillOfLading.md)
 - [Model.BillOfLadingCarrierbetaLine](docs/BillOfLadingCarrierbetaLine.md)
 - [Model.BillOfLadingOrderbetaLine](docs/BillOfLadingOrderbetaLine.md)
 - [Model.BillingCode](docs/BillingCode.md)
 - [Model.BillingCodeType](docs/BillingCodeType.md)
 - [Model.Building](docs/Building.md)
 - [Model.BusinessTransaction](docs/BusinessTransaction.md)
 - [Model.Carrier](docs/Carrier.md)
 - [Model.CarrierService](docs/CarrierService.md)
 - [Model.Carton](docs/Carton.md)
 - [Model.CartonContent](docs/CartonContent.md)
 - [Model.CartonType](docs/CartonType.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.EmailTemplate](docs/EmailTemplate.md)
 - [Model.ExternalShipment](docs/ExternalShipment.md)
 - [Model.FulfillmentPlan](docs/FulfillmentPlan.md)
 - [Model.FulfillmentProcess](docs/FulfillmentProcess.md)
 - [Model.IntegrationPartner](docs/IntegrationPartner.md)
 - [Model.InventoryAdjustment](docs/InventoryAdjustment.md)
 - [Model.InventoryDetail](docs/InventoryDetail.md)
 - [Model.Item](docs/Item.md)
 - [Model.ItemAccountCode](docs/ItemAccountCode.md)
 - [Model.ItemBuyer](docs/ItemBuyer.md)
 - [Model.ItemLegacyLowStockContact](docs/ItemLegacyLowStockContact.md)
 - [Model.ItemLowStockCode](docs/ItemLowStockCode.md)
 - [Model.ItemMajorGroup](docs/ItemMajorGroup.md)
 - [Model.ItemProductCode](docs/ItemProductCode.md)
 - [Model.ItemReceipt](docs/ItemReceipt.md)
 - [Model.ItemSubGroup](docs/ItemSubGroup.md)
 - [Model.ItemSummaryCode](docs/ItemSummaryCode.md)
 - [Model.JobTime](docs/JobTime.md)
 - [Model.JobType](docs/JobType.md)
 - [Model.LineOfBusiness](docs/LineOfBusiness.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationAddressScheme](docs/LocationAddressScheme.md)
 - [Model.LocationBillingType](docs/LocationBillingType.md)
 - [Model.LocationFootprint](docs/LocationFootprint.md)
 - [Model.LoggedTime](docs/LoggedTime.md)
 - [Model.LoggedTimeType](docs/LoggedTimeType.md)
 - [Model.LowStock](docs/LowStock.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderLine](docs/OrderLine.md)
 - [Model.OrderLoadProgram](docs/OrderLoadProgram.md)
 - [Model.OrderSource](docs/OrderSource.md)
 - [Model.OrderSourceReservation](docs/OrderSourceReservation.md)
 - [Model.OverrideReturnAddress](docs/OverrideReturnAddress.md)
 - [Model.ParcelAccount](docs/ParcelAccount.md)
 - [Model.ParcelShipment](docs/ParcelShipment.md)
 - [Model.PickFaceAssignment](docs/PickFaceAssignment.md)
 - [Model.ProductType](docs/ProductType.md)
 - [Model.ProductionLot](docs/ProductionLot.md)
 - [Model.QuickAdjustment](docs/QuickAdjustment.md)
 - [Model.QuickReceipt](docs/QuickReceipt.md)
 - [Model.ReceivingProcess](docs/ReceivingProcess.md)
 - [Model.ReceivingWorksheet](docs/ReceivingWorksheet.md)
 - [Model.ReceivingWorksheetLineItem](docs/ReceivingWorksheetLineItem.md)
 - [Model.ReceivingWorksheetPutAwayPlan](docs/ReceivingWorksheetPutAwayPlan.md)
 - [Model.Replenishment](docs/Replenishment.md)
 - [Model.ReplenishmentPlan](docs/ReplenishmentPlan.md)
 - [Model.ReplenishmentProcess](docs/ReplenishmentProcess.md)
 - [Model.ServiceType](docs/ServiceType.md)
 - [Model.ShoppingCartConnection](docs/ShoppingCartConnection.md)
 - [Model.ThirdPartyParcelAccount](docs/ThirdPartyParcelAccount.md)
 - [Model.User](docs/User.md)
 - [Model.Vendor](docs/Vendor.md)
 - [Model.VendorComplianceSurvey](docs/VendorComplianceSurvey.md)
 - [Model.Warehouse](docs/Warehouse.md)
 - [Model.WarehouseDocument](docs/WarehouseDocument.md)
 - [Model.WarehouseDocumentType](docs/WarehouseDocumentType.md)
 - [Model.Work](docs/Work.md)
 - [Model.WorkBatch](docs/WorkBatch.md)
 - [Model.Zone](docs/Zone.md)


## Documentation for Authorization


### api_key

- **Type**: API key
- **API key parameter name**: API-Key
- **Location**: HTTP header

