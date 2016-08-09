# infoplus-csharp-client
infoplus is a cloud platform to manage your inventory, orders, warehouse, and shipments.

The Infoplus API exposes the full breadth and depth of the Infoplus platform to all clients.
With the Infoplus API, you can integrate Infoplus functionality into other platforms 
(e.g. your ERP, shopping cart, accounting system, etc.), enabling you to do, in your own platform, 
anything you can do in Infoplus. 

This repository is a native C# client for full access to the Infoplus API.

## Infoplus API Resources
The Resources listed below will provide all the information you need to integrate with the Infoplus API. 

### Developer's Home Page
https://www.infopluscommerce.com/developers/
* This site gives you an overview of the Infoplus API. 
* Get a general understanding of the API and quick steps on getting started. 

### Infoplus API Reference Site
http://developers.infopluscommerce.com/
* The Infoplus API is a modern JSON + REST API, and the API Reference Site is the complete documentation of all endpoints, resources, and fields available in the API. 
* Whether you're using the API directly over HTTPS, or if you're using a pre-built Client Library like this one, the API Reference Site gives you the specific details you need for each API call available, along with live demo capabilities.
* The API Reference Site also lets you request access to a free Demo Account to test out the API. 

### Have Questions?
* Read an [Overview of the Infoplus API](https://support.infopluscommerce.com/support/solutions/articles/11000010373)
* Get in touch with the [Infoplus Support Team](https://support.infopluscommerce.com/support/tickets/new)
* Visit the [Infoplus API Forum](https://support.infopluscommerce.com/support/discussions/forums/11000000138)

# C# Client Details
- API version: beta
- SDK version: 1.0
- Build date: 2016-06-21T08:50:00.164-05:00
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [http://www.infopluscommerce.com](http://www.infopluscommerce.com)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

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
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;
```

## Getting Started

```csharp
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            try
            {
                // Configure the Api Client with your API-Key and Infoplus domain name.
                Configuration.Default.ApiKey.Add("API-Key", "<YOUR-API-KEY>");
                Configuration.Default.ApiClient = new ApiClient("https://<YOUR-SUBDOMAIN>.infopluswms.com/infoplus-wms/api/");

                // Instantiate Api objects.
                WarehouseApi warehouseApi = new WarehouseApi();
                ZoneApi zoneApi = new ZoneApi();

                // Get a list of Warehouse records.
                List<Warehouse> warehouseList = warehouseApi.GetWarehouseByFilter();
                warehouseList.ForEach(i => Debug.WriteLine(i));

                // Create a new Zone in the first Warehouse found, with a random name.
                Zone zone = new Zone(warehouseList[0].Id, "New Zone " + new Random().Next(1, 1000));
                zone = zoneApi.AddZone(zone);
                Debug.WriteLine("Added Zone: " + zone);
            }
            catch (Exception e)
            {
                Debug.Print("Exception in Infoplus API: " + e.Message);
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AisleApi* | [**AddAisle**](docs/AisleApi.md#addaisle) | **POST** /beta/aisle | Create an aisle
*AisleApi* | [**DeleteAisle**](docs/AisleApi.md#deleteaisle) | **DELETE** /beta/aisle/{aisleId} | Delete an aisle
*AisleApi* | [**GetAisleByFilter**](docs/AisleApi.md#getaislebyfilter) | **GET** /beta/aisle/search | Search aisles by filter
*AisleApi* | [**GetAisleById**](docs/AisleApi.md#getaislebyid) | **GET** /beta/aisle/{aisleId} | Get an aisle by id
*AisleApi* | [**UpdateAisle**](docs/AisleApi.md#updateaisle) | **PUT** /beta/aisle | Update an aisle
*AisleApi* | [**UpdateAisleCustomFields**](docs/AisleApi.md#updateaislecustomfields) | **PUT** /beta/aisle/customFields | Update an aisle custom fields
*AlertApi* | [**GetAlertByFilter**](docs/AlertApi.md#getalertbyfilter) | **GET** /beta/alert/search | Search alerts by filter
*AlertApi* | [**GetAlertById**](docs/AlertApi.md#getalertbyid) | **GET** /beta/alert/{alertId} | Get an alert by id
*AlertApi* | [**UpdateAlertCustomFields**](docs/AlertApi.md#updatealertcustomfields) | **PUT** /beta/alert/customFields | Update an alert custom fields
*AsnApi* | [**AddAsn**](docs/AsnApi.md#addasn) | **POST** /beta/asn | Create an asn
*AsnApi* | [**DeleteAsn**](docs/AsnApi.md#deleteasn) | **DELETE** /beta/asn/{asnId} | Delete an asn
*AsnApi* | [**GetAsnByFilter**](docs/AsnApi.md#getasnbyfilter) | **GET** /beta/asn/search | Search asns by filter
*AsnApi* | [**GetAsnById**](docs/AsnApi.md#getasnbyid) | **GET** /beta/asn/{asnId} | Get an asn by id
*AsnApi* | [**UpdateAsn**](docs/AsnApi.md#updateasn) | **PUT** /beta/asn | Update an asn
*AsnApi* | [**UpdateAsnCustomFields**](docs/AsnApi.md#updateasncustomfields) | **PUT** /beta/asn/customFields | Update an asn custom fields
*BillOfLadingApi* | [**AddBillOfLading**](docs/BillOfLadingApi.md#addbilloflading) | **POST** /beta/billOfLading | Create a billOfLading
*BillOfLadingApi* | [**DeleteBillOfLading**](docs/BillOfLadingApi.md#deletebilloflading) | **DELETE** /beta/billOfLading/{billOfLadingId} | Delete a billOfLading
*BillOfLadingApi* | [**GetBillOfLadingByFilter**](docs/BillOfLadingApi.md#getbillofladingbyfilter) | **GET** /beta/billOfLading/search | Search billOfLadings by filter
*BillOfLadingApi* | [**GetBillOfLadingById**](docs/BillOfLadingApi.md#getbillofladingbyid) | **GET** /beta/billOfLading/{billOfLadingId} | Get a billOfLading by id
*BillOfLadingApi* | [**UpdateBillOfLading**](docs/BillOfLadingApi.md#updatebilloflading) | **PUT** /beta/billOfLading | Update a billOfLading
*BillOfLadingApi* | [**UpdateBillOfLadingCustomFields**](docs/BillOfLadingApi.md#updatebillofladingcustomfields) | **PUT** /beta/billOfLading/customFields | Update a billOfLading custom fields
*BillingCodeApi* | [**AddBillingCode**](docs/BillingCodeApi.md#addbillingcode) | **POST** /beta/billingCode | Create a billingCode
*BillingCodeApi* | [**DeleteBillingCode**](docs/BillingCodeApi.md#deletebillingcode) | **DELETE** /beta/billingCode/{billingCodeId} | Delete a billingCode
*BillingCodeApi* | [**GetBillingCodeByFilter**](docs/BillingCodeApi.md#getbillingcodebyfilter) | **GET** /beta/billingCode/search | Search billingCodes by filter
*BillingCodeApi* | [**GetBillingCodeById**](docs/BillingCodeApi.md#getbillingcodebyid) | **GET** /beta/billingCode/{billingCodeId} | Get a billingCode by id
*BillingCodeApi* | [**UpdateBillingCode**](docs/BillingCodeApi.md#updatebillingcode) | **PUT** /beta/billingCode | Update a billingCode
*BillingCodeApi* | [**UpdateBillingCodeCustomFields**](docs/BillingCodeApi.md#updatebillingcodecustomfields) | **PUT** /beta/billingCode/customFields | Update a billingCode custom fields
*BillingCodeTypeApi* | [**AddBillingCodeType**](docs/BillingCodeTypeApi.md#addbillingcodetype) | **POST** /beta/billingCodeType | Create a billingCodeType
*BillingCodeTypeApi* | [**DeleteBillingCodeType**](docs/BillingCodeTypeApi.md#deletebillingcodetype) | **DELETE** /beta/billingCodeType/{billingCodeTypeId} | Delete a billingCodeType
*BillingCodeTypeApi* | [**GetBillingCodeTypeByFilter**](docs/BillingCodeTypeApi.md#getbillingcodetypebyfilter) | **GET** /beta/billingCodeType/search | Search billingCodeTypes by filter
*BillingCodeTypeApi* | [**GetBillingCodeTypeById**](docs/BillingCodeTypeApi.md#getbillingcodetypebyid) | **GET** /beta/billingCodeType/{billingCodeTypeId} | Get a billingCodeType by id
*BillingCodeTypeApi* | [**UpdateBillingCodeType**](docs/BillingCodeTypeApi.md#updatebillingcodetype) | **PUT** /beta/billingCodeType | Update a billingCodeType
*BillingCodeTypeApi* | [**UpdateBillingCodeTypeCustomFields**](docs/BillingCodeTypeApi.md#updatebillingcodetypecustomfields) | **PUT** /beta/billingCodeType/customFields | Update a billingCodeType custom fields
*BuildingApi* | [**AddBuilding**](docs/BuildingApi.md#addbuilding) | **POST** /beta/building | Create a building
*BuildingApi* | [**DeleteBuilding**](docs/BuildingApi.md#deletebuilding) | **DELETE** /beta/building/{buildingId} | Delete a building
*BuildingApi* | [**GetBuildingByFilter**](docs/BuildingApi.md#getbuildingbyfilter) | **GET** /beta/building/search | Search buildings by filter
*BuildingApi* | [**GetBuildingById**](docs/BuildingApi.md#getbuildingbyid) | **GET** /beta/building/{buildingId} | Get a building by id
*BuildingApi* | [**UpdateBuilding**](docs/BuildingApi.md#updatebuilding) | **PUT** /beta/building | Update a building
*BuildingApi* | [**UpdateBuildingCustomFields**](docs/BuildingApi.md#updatebuildingcustomfields) | **PUT** /beta/building/customFields | Update a building custom fields
*BusinessTransactionApi* | [**GetBusinessTransactionByFilter**](docs/BusinessTransactionApi.md#getbusinesstransactionbyfilter) | **GET** /beta/businessTransaction/search | Search businessTransactions by filter
*BusinessTransactionApi* | [**GetBusinessTransactionById**](docs/BusinessTransactionApi.md#getbusinesstransactionbyid) | **GET** /beta/businessTransaction/{businessTransactionId} | Get a businessTransaction by id
*BusinessTransactionApi* | [**UpdateBusinessTransactionCustomFields**](docs/BusinessTransactionApi.md#updatebusinesstransactioncustomfields) | **PUT** /beta/businessTransaction/customFields | Update a businessTransaction custom fields
*CarrierApi* | [**GetCarrierById**](docs/CarrierApi.md#getcarrierbyid) | **GET** /beta/carrier/{carrierId} | Get a carrier by id
*CarrierApi* | [**GetCarrierBySearchText**](docs/CarrierApi.md#getcarrierbysearchtext) | **GET** /beta/carrier/search | Search carriers
*CarrierServiceApi* | [**GetCarrierServiceById**](docs/CarrierServiceApi.md#getcarrierservicebyid) | **GET** /beta/carrierService/{carrierServiceId} | Get a carrierService by id
*CarrierServiceApi* | [**GetCarrierServiceBySearchText**](docs/CarrierServiceApi.md#getcarrierservicebysearchtext) | **GET** /beta/carrierService/search | Search carrierServices
*CartonApi* | [**AddCarton**](docs/CartonApi.md#addcarton) | **POST** /beta/carton | Create a carton
*CartonApi* | [**DeleteCarton**](docs/CartonApi.md#deletecarton) | **DELETE** /beta/carton/{cartonId} | Delete a carton
*CartonApi* | [**GetCartonByFilter**](docs/CartonApi.md#getcartonbyfilter) | **GET** /beta/carton/search | Search cartons by filter
*CartonApi* | [**GetCartonById**](docs/CartonApi.md#getcartonbyid) | **GET** /beta/carton/{cartonId} | Get a carton by id
*CartonApi* | [**UpdateCarton**](docs/CartonApi.md#updatecarton) | **PUT** /beta/carton | Update a carton
*CartonApi* | [**UpdateCartonCustomFields**](docs/CartonApi.md#updatecartoncustomfields) | **PUT** /beta/carton/customFields | Update a carton custom fields
*CartonContentApi* | [**AddCartonContent**](docs/CartonContentApi.md#addcartoncontent) | **POST** /beta/cartonContent | Create a cartonContent
*CartonContentApi* | [**DeleteCartonContent**](docs/CartonContentApi.md#deletecartoncontent) | **DELETE** /beta/cartonContent/{cartonContentId} | Delete a cartonContent
*CartonContentApi* | [**GetCartonContentByFilter**](docs/CartonContentApi.md#getcartoncontentbyfilter) | **GET** /beta/cartonContent/search | Search cartonContents by filter
*CartonContentApi* | [**GetCartonContentById**](docs/CartonContentApi.md#getcartoncontentbyid) | **GET** /beta/cartonContent/{cartonContentId} | Get a cartonContent by id
*CartonContentApi* | [**UpdateCartonContent**](docs/CartonContentApi.md#updatecartoncontent) | **PUT** /beta/cartonContent | Update a cartonContent
*CartonContentApi* | [**UpdateCartonContentCustomFields**](docs/CartonContentApi.md#updatecartoncontentcustomfields) | **PUT** /beta/cartonContent/customFields | Update a cartonContent custom fields
*CartonTypeApi* | [**AddCartonType**](docs/CartonTypeApi.md#addcartontype) | **POST** /beta/cartonType | Create a cartonType
*CartonTypeApi* | [**DeleteCartonType**](docs/CartonTypeApi.md#deletecartontype) | **DELETE** /beta/cartonType/{cartonTypeId} | Delete a cartonType
*CartonTypeApi* | [**GetCartonTypeByFilter**](docs/CartonTypeApi.md#getcartontypebyfilter) | **GET** /beta/cartonType/search | Search cartonTypes by filter
*CartonTypeApi* | [**GetCartonTypeById**](docs/CartonTypeApi.md#getcartontypebyid) | **GET** /beta/cartonType/{cartonTypeId} | Get a cartonType by id
*CartonTypeApi* | [**UpdateCartonType**](docs/CartonTypeApi.md#updatecartontype) | **PUT** /beta/cartonType | Update a cartonType
*CartonTypeApi* | [**UpdateCartonTypeCustomFields**](docs/CartonTypeApi.md#updatecartontypecustomfields) | **PUT** /beta/cartonType/customFields | Update a cartonType custom fields
*CustomerApi* | [**AddCustomer**](docs/CustomerApi.md#addcustomer) | **POST** /beta/customer | Create a customer
*CustomerApi* | [**DeleteCustomer**](docs/CustomerApi.md#deletecustomer) | **DELETE** /beta/customer/{customerId} | Delete a customer
*CustomerApi* | [**GetByCustomerNo**](docs/CustomerApi.md#getbycustomerno) | **GET** /beta/customer/getByCustomerNo | Get a customer by Customer No
*CustomerApi* | [**GetCustomerByFilter**](docs/CustomerApi.md#getcustomerbyfilter) | **GET** /beta/customer/search | Search customers by filter
*CustomerApi* | [**GetCustomerById**](docs/CustomerApi.md#getcustomerbyid) | **GET** /beta/customer/{customerId} | Get a customer by id
*CustomerApi* | [**UpdateCustomer**](docs/CustomerApi.md#updatecustomer) | **PUT** /beta/customer | Update a customer
*CustomerApi* | [**UpdateCustomerCustomFields**](docs/CustomerApi.md#updatecustomercustomfields) | **PUT** /beta/customer/customFields | Update a customer custom fields
*EmailTemplateApi* | [**AddEmailTemplate**](docs/EmailTemplateApi.md#addemailtemplate) | **POST** /beta/emailTemplate | Create an emailTemplate
*EmailTemplateApi* | [**DeleteEmailTemplate**](docs/EmailTemplateApi.md#deleteemailtemplate) | **DELETE** /beta/emailTemplate/{emailTemplateId} | Delete an emailTemplate
*EmailTemplateApi* | [**GetEmailTemplateByFilter**](docs/EmailTemplateApi.md#getemailtemplatebyfilter) | **GET** /beta/emailTemplate/search | Search emailTemplates by filter
*EmailTemplateApi* | [**GetEmailTemplateById**](docs/EmailTemplateApi.md#getemailtemplatebyid) | **GET** /beta/emailTemplate/{emailTemplateId} | Get an emailTemplate by id
*EmailTemplateApi* | [**UpdateEmailTemplate**](docs/EmailTemplateApi.md#updateemailtemplate) | **PUT** /beta/emailTemplate | Update an emailTemplate
*EmailTemplateApi* | [**UpdateEmailTemplateCustomFields**](docs/EmailTemplateApi.md#updateemailtemplatecustomfields) | **PUT** /beta/emailTemplate/customFields | Update an emailTemplate custom fields
*ExternalShipmentApi* | [**AddExternalShipment**](docs/ExternalShipmentApi.md#addexternalshipment) | **POST** /beta/externalShipment | Create an externalShipment
*ExternalShipmentApi* | [**DeleteExternalShipment**](docs/ExternalShipmentApi.md#deleteexternalshipment) | **DELETE** /beta/externalShipment/{externalShipmentId} | Delete an externalShipment
*ExternalShipmentApi* | [**GetExternalShipmentByFilter**](docs/ExternalShipmentApi.md#getexternalshipmentbyfilter) | **GET** /beta/externalShipment/search | Search externalShipments by filter
*ExternalShipmentApi* | [**GetExternalShipmentById**](docs/ExternalShipmentApi.md#getexternalshipmentbyid) | **GET** /beta/externalShipment/{externalShipmentId} | Get an externalShipment by id
*ExternalShipmentApi* | [**UpdateExternalShipment**](docs/ExternalShipmentApi.md#updateexternalshipment) | **PUT** /beta/externalShipment | Update an externalShipment
*ExternalShipmentApi* | [**UpdateExternalShipmentCustomFields**](docs/ExternalShipmentApi.md#updateexternalshipmentcustomfields) | **PUT** /beta/externalShipment/customFields | Update an externalShipment custom fields
*FulfillmentPlanApi* | [**AddFulfillmentPlan**](docs/FulfillmentPlanApi.md#addfulfillmentplan) | **POST** /beta/fulfillmentPlan | Create a fulfillmentPlan
*FulfillmentPlanApi* | [**DeleteFulfillmentPlan**](docs/FulfillmentPlanApi.md#deletefulfillmentplan) | **DELETE** /beta/fulfillmentPlan/{fulfillmentPlanId} | Delete a fulfillmentPlan
*FulfillmentPlanApi* | [**GetFulfillmentPlanByFilter**](docs/FulfillmentPlanApi.md#getfulfillmentplanbyfilter) | **GET** /beta/fulfillmentPlan/search | Search fulfillmentPlans by filter
*FulfillmentPlanApi* | [**GetFulfillmentPlanById**](docs/FulfillmentPlanApi.md#getfulfillmentplanbyid) | **GET** /beta/fulfillmentPlan/{fulfillmentPlanId} | Get a fulfillmentPlan by id
*FulfillmentPlanApi* | [**UpdateFulfillmentPlan**](docs/FulfillmentPlanApi.md#updatefulfillmentplan) | **PUT** /beta/fulfillmentPlan | Update a fulfillmentPlan
*FulfillmentPlanApi* | [**UpdateFulfillmentPlanCustomFields**](docs/FulfillmentPlanApi.md#updatefulfillmentplancustomfields) | **PUT** /beta/fulfillmentPlan/customFields | Update a fulfillmentPlan custom fields
*FulfillmentProcessApi* | [**GetFulfillmentProcessByFilter**](docs/FulfillmentProcessApi.md#getfulfillmentprocessbyfilter) | **GET** /beta/fulfillmentProcess/search | Search fulfillmentProcesses by filter
*FulfillmentProcessApi* | [**GetFulfillmentProcessById**](docs/FulfillmentProcessApi.md#getfulfillmentprocessbyid) | **GET** /beta/fulfillmentProcess/{fulfillmentProcessId} | Get a fulfillmentProcess by id
*FulfillmentProcessApi* | [**UpdateFulfillmentProcessCustomFields**](docs/FulfillmentProcessApi.md#updatefulfillmentprocesscustomfields) | **PUT** /beta/fulfillmentProcess/customFields | Update a fulfillmentProcess custom fields
*IntegrationPartnerApi* | [**GetIntegrationPartnerById**](docs/IntegrationPartnerApi.md#getintegrationpartnerbyid) | **GET** /beta/integrationPartner/{integrationPartnerId} | Get an integrationPartner by id
*IntegrationPartnerApi* | [**GetIntegrationPartnerBySearchText**](docs/IntegrationPartnerApi.md#getintegrationpartnerbysearchtext) | **GET** /beta/integrationPartner/search | Search integrationPartners
*InventoryAdjustmentApi* | [**GetInventoryAdjustmentByFilter**](docs/InventoryAdjustmentApi.md#getinventoryadjustmentbyfilter) | **GET** /beta/inventoryAdjustment/search | Search inventoryAdjustments by filter
*InventoryAdjustmentApi* | [**GetInventoryAdjustmentById**](docs/InventoryAdjustmentApi.md#getinventoryadjustmentbyid) | **GET** /beta/inventoryAdjustment/{inventoryAdjustmentId} | Get an inventoryAdjustment by id
*InventoryAdjustmentApi* | [**UpdateInventoryAdjustmentCustomFields**](docs/InventoryAdjustmentApi.md#updateinventoryadjustmentcustomfields) | **PUT** /beta/inventoryAdjustment/customFields | Update an inventoryAdjustment custom fields
*InventoryDetailApi* | [**GetInventoryDetailByFilter**](docs/InventoryDetailApi.md#getinventorydetailbyfilter) | **GET** /beta/inventoryDetail/search | Search inventoryDetails by filter
*InventoryDetailApi* | [**GetInventoryDetailById**](docs/InventoryDetailApi.md#getinventorydetailbyid) | **GET** /beta/inventoryDetail/{inventoryDetailId} | Get an inventoryDetail by id
*InventoryDetailApi* | [**UpdateInventoryDetailCustomFields**](docs/InventoryDetailApi.md#updateinventorydetailcustomfields) | **PUT** /beta/inventoryDetail/customFields | Update an inventoryDetail custom fields
*ItemApi* | [**AddItem**](docs/ItemApi.md#additem) | **POST** /beta/item | Create an item
*ItemApi* | [**DeleteItem**](docs/ItemApi.md#deleteitem) | **DELETE** /beta/item/{itemId} | Delete an item
*ItemApi* | [**GetBySKU**](docs/ItemApi.md#getbysku) | **GET** /beta/item/getBySKU | Get an item by SKU
*ItemApi* | [**GetItemByFilter**](docs/ItemApi.md#getitembyfilter) | **GET** /beta/item/search | Search items by filter
*ItemApi* | [**GetItemById**](docs/ItemApi.md#getitembyid) | **GET** /beta/item/{itemId} | Get an item by id
*ItemApi* | [**UpdateItem**](docs/ItemApi.md#updateitem) | **PUT** /beta/item | Update an item
*ItemApi* | [**UpdateItemCustomFields**](docs/ItemApi.md#updateitemcustomfields) | **PUT** /beta/item/customFields | Update an item custom fields
*ItemAccountCodeApi* | [**GetItemAccountCodeBySearchText**](docs/ItemAccountCodeApi.md#getitemaccountcodebysearchtext) | **GET** /beta/itemAccountCode/search | Search itemAccountCodes
*ItemAccountCodeApi* | [**GetTranslateAccountCodeById**](docs/ItemAccountCodeApi.md#gettranslateaccountcodebyid) | **GET** /beta/itemAccountCode/{itemAccountCodeId} | Get an itemAccountCode by id
*ItemBuyerApi* | [**GetItemBuyerBySearchText**](docs/ItemBuyerApi.md#getitembuyerbysearchtext) | **GET** /beta/itemBuyer/search | Search itemBuyers
*ItemBuyerApi* | [**GetTranslateBuyerById**](docs/ItemBuyerApi.md#gettranslatebuyerbyid) | **GET** /beta/itemBuyer/{itemBuyerId} | Get an itemBuyer by id
*ItemLegacyLowStockContactApi* | [**GetItemLegacyLowStockContactBySearchText**](docs/ItemLegacyLowStockContactApi.md#getitemlegacylowstockcontactbysearchtext) | **GET** /beta/itemLegacyLowStockContact/search | Search itemLegacyLowStockContacts
*ItemLegacyLowStockContactApi* | [**GetTranslateLowStockContactById**](docs/ItemLegacyLowStockContactApi.md#gettranslatelowstockcontactbyid) | **GET** /beta/itemLegacyLowStockContact/{itemLegacyLowStockContactId} | Get an itemLegacyLowStockContact by id
*ItemLowStockCodeApi* | [**GetItemLowStockCodeBySearchText**](docs/ItemLowStockCodeApi.md#getitemlowstockcodebysearchtext) | **GET** /beta/itemLowStockCode/search | Search itemLowStockCodes
*ItemLowStockCodeApi* | [**GetTranslateLowStockCodeById**](docs/ItemLowStockCodeApi.md#gettranslatelowstockcodebyid) | **GET** /beta/itemLowStockCode/{itemLowStockCodeId} | Get an itemLowStockCode by id
*ItemMajorGroupApi* | [**GetItemMajorGroupBySearchText**](docs/ItemMajorGroupApi.md#getitemmajorgroupbysearchtext) | **GET** /beta/itemMajorGroup/search | Search itemMajorGroups
*ItemMajorGroupApi* | [**GetTranslateMajorGroupById**](docs/ItemMajorGroupApi.md#gettranslatemajorgroupbyid) | **GET** /beta/itemMajorGroup/{itemMajorGroupId} | Get an itemMajorGroup by id
*ItemProductCodeApi* | [**GetItemProductCodeBySearchText**](docs/ItemProductCodeApi.md#getitemproductcodebysearchtext) | **GET** /beta/itemProductCode/search | Search itemProductCodes
*ItemProductCodeApi* | [**GetTranslateProductCodeById**](docs/ItemProductCodeApi.md#gettranslateproductcodebyid) | **GET** /beta/itemProductCode/{itemProductCodeId} | Get an itemProductCode by id
*ItemReceiptApi* | [**GetItemReceiptByFilter**](docs/ItemReceiptApi.md#getitemreceiptbyfilter) | **GET** /beta/itemReceipt/search | Search itemReceipts by filter
*ItemReceiptApi* | [**GetItemReceiptById**](docs/ItemReceiptApi.md#getitemreceiptbyid) | **GET** /beta/itemReceipt/{itemReceiptId} | Get an itemReceipt by id
*ItemReceiptApi* | [**UpdateItemReceiptCustomFields**](docs/ItemReceiptApi.md#updateitemreceiptcustomfields) | **PUT** /beta/itemReceipt/customFields | Update an itemReceipt custom fields
*ItemSubGroupApi* | [**GetItemSubGroupBySearchText**](docs/ItemSubGroupApi.md#getitemsubgroupbysearchtext) | **GET** /beta/itemSubGroup/search | Search itemSubGroups
*ItemSubGroupApi* | [**GetTranslateSubGroupById**](docs/ItemSubGroupApi.md#gettranslatesubgroupbyid) | **GET** /beta/itemSubGroup/{itemSubGroupId} | Get an itemSubGroup by id
*ItemSummaryCodeApi* | [**GetItemSummaryCodeBySearchText**](docs/ItemSummaryCodeApi.md#getitemsummarycodebysearchtext) | **GET** /beta/itemSummaryCode/search | Search itemSummaryCodes
*ItemSummaryCodeApi* | [**GetTranslateSummaryCodeById**](docs/ItemSummaryCodeApi.md#gettranslatesummarycodebyid) | **GET** /beta/itemSummaryCode/{itemSummaryCodeId} | Get an itemSummaryCode by id
*JobTimeApi* | [**AddJobTime**](docs/JobTimeApi.md#addjobtime) | **POST** /beta/jobTime | Create a jobTime
*JobTimeApi* | [**DeleteJobTime**](docs/JobTimeApi.md#deletejobtime) | **DELETE** /beta/jobTime/{jobTimeId} | Delete a jobTime
*JobTimeApi* | [**GetJobTimeByFilter**](docs/JobTimeApi.md#getjobtimebyfilter) | **GET** /beta/jobTime/search | Search jobTimes by filter
*JobTimeApi* | [**GetJobTimeById**](docs/JobTimeApi.md#getjobtimebyid) | **GET** /beta/jobTime/{jobTimeId} | Get a jobTime by id
*JobTimeApi* | [**UpdateJobTime**](docs/JobTimeApi.md#updatejobtime) | **PUT** /beta/jobTime | Update a jobTime
*JobTimeApi* | [**UpdateJobTimeCustomFields**](docs/JobTimeApi.md#updatejobtimecustomfields) | **PUT** /beta/jobTime/customFields | Update a jobTime custom fields
*JobTypeApi* | [**AddJobType**](docs/JobTypeApi.md#addjobtype) | **POST** /beta/jobType | Create a jobType
*JobTypeApi* | [**DeleteJobType**](docs/JobTypeApi.md#deletejobtype) | **DELETE** /beta/jobType/{jobTypeId} | Delete a jobType
*JobTypeApi* | [**GetJobTypeByFilter**](docs/JobTypeApi.md#getjobtypebyfilter) | **GET** /beta/jobType/search | Search jobTypes by filter
*JobTypeApi* | [**GetJobTypeById**](docs/JobTypeApi.md#getjobtypebyid) | **GET** /beta/jobType/{jobTypeId} | Get a jobType by id
*JobTypeApi* | [**UpdateJobType**](docs/JobTypeApi.md#updatejobtype) | **PUT** /beta/jobType | Update a jobType
*JobTypeApi* | [**UpdateJobTypeCustomFields**](docs/JobTypeApi.md#updatejobtypecustomfields) | **PUT** /beta/jobType/customFields | Update a jobType custom fields
*KitApi* | [**AddKit**](docs/KitApi.md#addkit) | **POST** /beta/kit | Create a kit
*KitApi* | [**DeleteKit**](docs/KitApi.md#deletekit) | **DELETE** /beta/kit/{kitId} | Delete a kit
*KitApi* | [**GetKitByFilter**](docs/KitApi.md#getkitbyfilter) | **GET** /beta/kit/search | Search kits by filter
*KitApi* | [**GetKitById**](docs/KitApi.md#getkitbyid) | **GET** /beta/kit/{kitId} | Get a kit by id
*KitApi* | [**UpdateKit**](docs/KitApi.md#updatekit) | **PUT** /beta/kit | Update a kit
*KitApi* | [**UpdateKitCustomFields**](docs/KitApi.md#updatekitcustomfields) | **PUT** /beta/kit/customFields | Update a kit custom fields
*LineOfBusinessApi* | [**GetLineOfBusinessById**](docs/LineOfBusinessApi.md#getlineofbusinessbyid) | **GET** /beta/lineOfBusiness/{lineOfBusinessId} | Get a lineOfBusiness by id
*LineOfBusinessApi* | [**GetLineOfBusinessBySearchText**](docs/LineOfBusinessApi.md#getlineofbusinessbysearchtext) | **GET** /beta/lineOfBusiness/search | Search lineOfBusinesses
*LocationApi* | [**AddLocation**](docs/LocationApi.md#addlocation) | **POST** /beta/location | Create a location
*LocationApi* | [**DeleteLocation**](docs/LocationApi.md#deletelocation) | **DELETE** /beta/location/{locationId} | Delete a location
*LocationApi* | [**GetLocationByFilter**](docs/LocationApi.md#getlocationbyfilter) | **GET** /beta/location/search | Search locations by filter
*LocationApi* | [**GetLocationById**](docs/LocationApi.md#getlocationbyid) | **GET** /beta/location/{locationId} | Get a location by id
*LocationApi* | [**UpdateLocation**](docs/LocationApi.md#updatelocation) | **PUT** /beta/location | Update a location
*LocationApi* | [**UpdateLocationCustomFields**](docs/LocationApi.md#updatelocationcustomfields) | **PUT** /beta/location/customFields | Update a location custom fields
*LocationAddressSchemeApi* | [**AddLocationAddressScheme**](docs/LocationAddressSchemeApi.md#addlocationaddressscheme) | **POST** /beta/locationAddressScheme | Create a locationAddressScheme
*LocationAddressSchemeApi* | [**DeleteLocationAddressScheme**](docs/LocationAddressSchemeApi.md#deletelocationaddressscheme) | **DELETE** /beta/locationAddressScheme/{locationAddressSchemeId} | Delete a locationAddressScheme
*LocationAddressSchemeApi* | [**GetLocationAddressSchemeByFilter**](docs/LocationAddressSchemeApi.md#getlocationaddressschemebyfilter) | **GET** /beta/locationAddressScheme/search | Search locationAddressSchemes by filter
*LocationAddressSchemeApi* | [**GetLocationAddressSchemeById**](docs/LocationAddressSchemeApi.md#getlocationaddressschemebyid) | **GET** /beta/locationAddressScheme/{locationAddressSchemeId} | Get a locationAddressScheme by id
*LocationAddressSchemeApi* | [**UpdateLocationAddressScheme**](docs/LocationAddressSchemeApi.md#updatelocationaddressscheme) | **PUT** /beta/locationAddressScheme | Update a locationAddressScheme
*LocationAddressSchemeApi* | [**UpdateLocationAddressSchemeCustomFields**](docs/LocationAddressSchemeApi.md#updatelocationaddressschemecustomfields) | **PUT** /beta/locationAddressScheme/customFields | Update a locationAddressScheme custom fields
*LocationBillingTypeApi* | [**AddLocationBillingType**](docs/LocationBillingTypeApi.md#addlocationbillingtype) | **POST** /beta/locationBillingType | Create a locationBillingType
*LocationBillingTypeApi* | [**DeleteLocationBillingType**](docs/LocationBillingTypeApi.md#deletelocationbillingtype) | **DELETE** /beta/locationBillingType/{locationBillingTypeId} | Delete a locationBillingType
*LocationBillingTypeApi* | [**GetLocationBillingTypeByFilter**](docs/LocationBillingTypeApi.md#getlocationbillingtypebyfilter) | **GET** /beta/locationBillingType/search | Search locationBillingTypes by filter
*LocationBillingTypeApi* | [**GetLocationBillingTypeById**](docs/LocationBillingTypeApi.md#getlocationbillingtypebyid) | **GET** /beta/locationBillingType/{locationBillingTypeId} | Get a locationBillingType by id
*LocationBillingTypeApi* | [**UpdateLocationBillingType**](docs/LocationBillingTypeApi.md#updatelocationbillingtype) | **PUT** /beta/locationBillingType | Update a locationBillingType
*LocationBillingTypeApi* | [**UpdateLocationBillingTypeCustomFields**](docs/LocationBillingTypeApi.md#updatelocationbillingtypecustomfields) | **PUT** /beta/locationBillingType/customFields | Update a locationBillingType custom fields
*LocationFootprintApi* | [**AddLocationFootprint**](docs/LocationFootprintApi.md#addlocationfootprint) | **POST** /beta/locationFootprint | Create a locationFootprint
*LocationFootprintApi* | [**DeleteLocationFootprint**](docs/LocationFootprintApi.md#deletelocationfootprint) | **DELETE** /beta/locationFootprint/{locationFootprintId} | Delete a locationFootprint
*LocationFootprintApi* | [**GetLocationFootprintByFilter**](docs/LocationFootprintApi.md#getlocationfootprintbyfilter) | **GET** /beta/locationFootprint/search | Search locationFootprints by filter
*LocationFootprintApi* | [**GetLocationFootprintById**](docs/LocationFootprintApi.md#getlocationfootprintbyid) | **GET** /beta/locationFootprint/{locationFootprintId} | Get a locationFootprint by id
*LocationFootprintApi* | [**UpdateLocationFootprint**](docs/LocationFootprintApi.md#updatelocationfootprint) | **PUT** /beta/locationFootprint | Update a locationFootprint
*LocationFootprintApi* | [**UpdateLocationFootprintCustomFields**](docs/LocationFootprintApi.md#updatelocationfootprintcustomfields) | **PUT** /beta/locationFootprint/customFields | Update a locationFootprint custom fields
*LoggedTimeApi* | [**GetLoggedTimeByFilter**](docs/LoggedTimeApi.md#getloggedtimebyfilter) | **GET** /beta/loggedTime/search | Search loggedTimes by filter
*LoggedTimeApi* | [**GetLoggedTimeById**](docs/LoggedTimeApi.md#getloggedtimebyid) | **GET** /beta/loggedTime/{loggedTimeId} | Get a loggedTime by id
*LoggedTimeApi* | [**UpdateLoggedTimeCustomFields**](docs/LoggedTimeApi.md#updateloggedtimecustomfields) | **PUT** /beta/loggedTime/customFields | Update a loggedTime custom fields
*LoggedTimeTypeApi* | [**GetLoggedTimeTypeById**](docs/LoggedTimeTypeApi.md#getloggedtimetypebyid) | **GET** /beta/loggedTimeType/{loggedTimeTypeId} | Get a loggedTimeType by id
*LoggedTimeTypeApi* | [**GetLoggedTimeTypeBySearchText**](docs/LoggedTimeTypeApi.md#getloggedtimetypebysearchtext) | **GET** /beta/loggedTimeType/search | Search loggedTimeTypes
*LowStockApi* | [**GetLowStockByFilter**](docs/LowStockApi.md#getlowstockbyfilter) | **GET** /beta/lowStock/search | Search lowStocks by filter
*LowStockApi* | [**GetLowStockById**](docs/LowStockApi.md#getlowstockbyid) | **GET** /beta/lowStock/{lowStockId} | Get a lowStock by id
*ManageScheduledPlansApi* | [**AddManageScheduledPlans**](docs/ManageScheduledPlansApi.md#addmanagescheduledplans) | **POST** /beta/manageScheduledPlans | Create a manageScheduledPlans
*ManageScheduledPlansApi* | [**DeleteManageScheduledPlans**](docs/ManageScheduledPlansApi.md#deletemanagescheduledplans) | **DELETE** /beta/manageScheduledPlans/{manageScheduledPlansId} | Delete a manageScheduledPlans
*ManageScheduledPlansApi* | [**GetManageScheduledPlansByFilter**](docs/ManageScheduledPlansApi.md#getmanagescheduledplansbyfilter) | **GET** /beta/manageScheduledPlans/search | Search manageScheduledPlanses by filter
*ManageScheduledPlansApi* | [**GetManageScheduledPlansById**](docs/ManageScheduledPlansApi.md#getmanagescheduledplansbyid) | **GET** /beta/manageScheduledPlans/{manageScheduledPlansId} | Get a manageScheduledPlans by id
*ManageScheduledPlansApi* | [**UpdateManageScheduledPlans**](docs/ManageScheduledPlansApi.md#updatemanagescheduledplans) | **PUT** /beta/manageScheduledPlans | Update a manageScheduledPlans
*OrderApi* | [**AddOrder**](docs/OrderApi.md#addorder) | **POST** /beta/order | Create an order
*OrderApi* | [**DeleteOrder**](docs/OrderApi.md#deleteorder) | **DELETE** /beta/order/{orderId} | Delete an order
*OrderApi* | [**GetOrderByFilter**](docs/OrderApi.md#getorderbyfilter) | **GET** /beta/order/search | Search orders by filter
*OrderApi* | [**GetOrderById**](docs/OrderApi.md#getorderbyid) | **GET** /beta/order/{orderId} | Get an order by id
*OrderApi* | [**UpdateOrder**](docs/OrderApi.md#updateorder) | **PUT** /beta/order | Update an order
*OrderApi* | [**UpdateOrderCustomFields**](docs/OrderApi.md#updateordercustomfields) | **PUT** /beta/order/customFields | Update an order custom fields
*OrderLineApi* | [**GetOrderLineByFilter**](docs/OrderLineApi.md#getorderlinebyfilter) | **GET** /beta/orderLine/search | Search orderLines by filter
*OrderLineApi* | [**GetOrderLineById**](docs/OrderLineApi.md#getorderlinebyid) | **GET** /beta/orderLine/{orderLineId} | Get an orderLine by id
*OrderLineApi* | [**UpdateOrderLineCustomFields**](docs/OrderLineApi.md#updateorderlinecustomfields) | **PUT** /beta/orderLine/customFields | Update an orderLine custom fields
*OrderLoadProgramApi* | [**GetOrderLoadProgramBySearchText**](docs/OrderLoadProgramApi.md#getorderloadprogrambysearchtext) | **GET** /beta/orderLoadProgram/search | Search orderLoadPrograms
*OrderLoadProgramApi* | [**GetReqLoadProgramById**](docs/OrderLoadProgramApi.md#getreqloadprogrambyid) | **GET** /beta/orderLoadProgram/{orderLoadProgramId} | Get an orderLoadProgram by id
*OrderSourceApi* | [**AddOrderSource**](docs/OrderSourceApi.md#addordersource) | **POST** /beta/orderSource | Create an orderSource
*OrderSourceApi* | [**DeleteOrderSource**](docs/OrderSourceApi.md#deleteordersource) | **DELETE** /beta/orderSource/{orderSourceId} | Delete an orderSource
*OrderSourceApi* | [**GetOrderSourceByFilter**](docs/OrderSourceApi.md#getordersourcebyfilter) | **GET** /beta/orderSource/search | Search orderSources by filter
*OrderSourceApi* | [**GetOrderSourceById**](docs/OrderSourceApi.md#getordersourcebyid) | **GET** /beta/orderSource/{orderSourceId} | Get an orderSource by id
*OrderSourceApi* | [**UpdateOrderSource**](docs/OrderSourceApi.md#updateordersource) | **PUT** /beta/orderSource | Update an orderSource
*OrderSourceApi* | [**UpdateOrderSourceCustomFields**](docs/OrderSourceApi.md#updateordersourcecustomfields) | **PUT** /beta/orderSource/customFields | Update an orderSource custom fields
*OrderSourceReservationApi* | [**AddOrderSourceReservation**](docs/OrderSourceReservationApi.md#addordersourcereservation) | **POST** /beta/orderSourceReservation | Create an orderSourceReservation
*OrderSourceReservationApi* | [**DeleteOrderSourceReservation**](docs/OrderSourceReservationApi.md#deleteordersourcereservation) | **DELETE** /beta/orderSourceReservation/{orderSourceReservationId} | Delete an orderSourceReservation
*OrderSourceReservationApi* | [**GetOrderSourceReservationByFilter**](docs/OrderSourceReservationApi.md#getordersourcereservationbyfilter) | **GET** /beta/orderSourceReservation/search | Search orderSourceReservations by filter
*OrderSourceReservationApi* | [**GetOrderSourceReservationById**](docs/OrderSourceReservationApi.md#getordersourcereservationbyid) | **GET** /beta/orderSourceReservation/{orderSourceReservationId} | Get an orderSourceReservation by id
*OrderSourceReservationApi* | [**UpdateOrderSourceReservation**](docs/OrderSourceReservationApi.md#updateordersourcereservation) | **PUT** /beta/orderSourceReservation | Update an orderSourceReservation
*OrderSourceReservationApi* | [**UpdateOrderSourceReservationCustomFields**](docs/OrderSourceReservationApi.md#updateordersourcereservationcustomfields) | **PUT** /beta/orderSourceReservation/customFields | Update an orderSourceReservation custom fields
*OverrideReturnAddressApi* | [**AddOverrideReturnAddress**](docs/OverrideReturnAddressApi.md#addoverridereturnaddress) | **POST** /beta/overrideReturnAddress | Create an overrideReturnAddress
*OverrideReturnAddressApi* | [**DeleteOverrideReturnAddress**](docs/OverrideReturnAddressApi.md#deleteoverridereturnaddress) | **DELETE** /beta/overrideReturnAddress/{overrideReturnAddressId} | Delete an overrideReturnAddress
*OverrideReturnAddressApi* | [**GetOverrideReturnAddressByFilter**](docs/OverrideReturnAddressApi.md#getoverridereturnaddressbyfilter) | **GET** /beta/overrideReturnAddress/search | Search overrideReturnAddresses by filter
*OverrideReturnAddressApi* | [**GetOverrideReturnAddressById**](docs/OverrideReturnAddressApi.md#getoverridereturnaddressbyid) | **GET** /beta/overrideReturnAddress/{overrideReturnAddressId} | Get an overrideReturnAddress by id
*OverrideReturnAddressApi* | [**UpdateOverrideReturnAddress**](docs/OverrideReturnAddressApi.md#updateoverridereturnaddress) | **PUT** /beta/overrideReturnAddress | Update an overrideReturnAddress
*OverrideReturnAddressApi* | [**UpdateOverrideReturnAddressCustomFields**](docs/OverrideReturnAddressApi.md#updateoverridereturnaddresscustomfields) | **PUT** /beta/overrideReturnAddress/customFields | Update an overrideReturnAddress custom fields
*ParcelAccountApi* | [**GetParcelAccountByFilter**](docs/ParcelAccountApi.md#getparcelaccountbyfilter) | **GET** /beta/parcelAccount/search | Search parcelAccounts by filter
*ParcelAccountApi* | [**GetParcelAccountById**](docs/ParcelAccountApi.md#getparcelaccountbyid) | **GET** /beta/parcelAccount/{parcelAccountId} | Get a parcelAccount by id
*ParcelAccountApi* | [**UpdateParcelAccountCustomFields**](docs/ParcelAccountApi.md#updateparcelaccountcustomfields) | **PUT** /beta/parcelAccount/customFields | Update a parcelAccount custom fields
*ParcelShipmentApi* | [**GetParcelShipmentByFilter**](docs/ParcelShipmentApi.md#getparcelshipmentbyfilter) | **GET** /beta/parcelShipment/search | Search parcelShipments by filter
*ParcelShipmentApi* | [**GetParcelShipmentById**](docs/ParcelShipmentApi.md#getparcelshipmentbyid) | **GET** /beta/parcelShipment/{parcelShipmentId} | Get a parcelShipment by id
*ParcelShipmentApi* | [**UpdateParcelShipmentCustomFields**](docs/ParcelShipmentApi.md#updateparcelshipmentcustomfields) | **PUT** /beta/parcelShipment/customFields | Update a parcelShipment custom fields
*PickFaceAssignmentApi* | [**AddPickFaceAssignment**](docs/PickFaceAssignmentApi.md#addpickfaceassignment) | **POST** /beta/pickFaceAssignment | Create a pickFaceAssignment
*PickFaceAssignmentApi* | [**DeletePickFaceAssignment**](docs/PickFaceAssignmentApi.md#deletepickfaceassignment) | **DELETE** /beta/pickFaceAssignment/{pickFaceAssignmentId} | Delete a pickFaceAssignment
*PickFaceAssignmentApi* | [**GetPickFaceAssignmentByFilter**](docs/PickFaceAssignmentApi.md#getpickfaceassignmentbyfilter) | **GET** /beta/pickFaceAssignment/search | Search pickFaceAssignments by filter
*PickFaceAssignmentApi* | [**GetPickFaceAssignmentById**](docs/PickFaceAssignmentApi.md#getpickfaceassignmentbyid) | **GET** /beta/pickFaceAssignment/{pickFaceAssignmentId} | Get a pickFaceAssignment by id
*PickFaceAssignmentApi* | [**UpdatePickFaceAssignment**](docs/PickFaceAssignmentApi.md#updatepickfaceassignment) | **PUT** /beta/pickFaceAssignment | Update a pickFaceAssignment
*PickFaceAssignmentApi* | [**UpdatePickFaceAssignmentCustomFields**](docs/PickFaceAssignmentApi.md#updatepickfaceassignmentcustomfields) | **PUT** /beta/pickFaceAssignment/customFields | Update a pickFaceAssignment custom fields
*ProductTypeApi* | [**GetProductTypeById**](docs/ProductTypeApi.md#getproducttypebyid) | **GET** /beta/productType/{productTypeId} | Get a productType by id
*ProductTypeApi* | [**GetProductTypeBySearchText**](docs/ProductTypeApi.md#getproducttypebysearchtext) | **GET** /beta/productType/search | Search productTypes
*ProductionLotApi* | [**GetProductionLotByFilter**](docs/ProductionLotApi.md#getproductionlotbyfilter) | **GET** /beta/productionLot/search | Search productionLots by filter
*ProductionLotApi* | [**GetProductionLotById**](docs/ProductionLotApi.md#getproductionlotbyid) | **GET** /beta/productionLot/{productionLotId} | Get a productionLot by id
*ProductionLotApi* | [**UpdateProductionLotCustomFields**](docs/ProductionLotApi.md#updateproductionlotcustomfields) | **PUT** /beta/productionLot/customFields | Update a productionLot custom fields
*QuickAdjustmentApi* | [**AddQuickAdjustment**](docs/QuickAdjustmentApi.md#addquickadjustment) | **POST** /beta/quickAdjustment | Create a quickAdjustment
*QuickAdjustmentApi* | [**DeleteQuickAdjustment**](docs/QuickAdjustmentApi.md#deletequickadjustment) | **DELETE** /beta/quickAdjustment/{quickAdjustmentId} | Delete a quickAdjustment
*QuickAdjustmentApi* | [**GetQuickAdjustmentByFilter**](docs/QuickAdjustmentApi.md#getquickadjustmentbyfilter) | **GET** /beta/quickAdjustment/search | Search quickAdjustments by filter
*QuickAdjustmentApi* | [**GetQuickAdjustmentById**](docs/QuickAdjustmentApi.md#getquickadjustmentbyid) | **GET** /beta/quickAdjustment/{quickAdjustmentId} | Get a quickAdjustment by id
*QuickAdjustmentApi* | [**UpdateQuickAdjustment**](docs/QuickAdjustmentApi.md#updatequickadjustment) | **PUT** /beta/quickAdjustment | Update a quickAdjustment
*QuickAdjustmentApi* | [**UpdateQuickAdjustmentCustomFields**](docs/QuickAdjustmentApi.md#updatequickadjustmentcustomfields) | **PUT** /beta/quickAdjustment/customFields | Update a quickAdjustment custom fields
*QuickReceiptApi* | [**AddQuickReceipt**](docs/QuickReceiptApi.md#addquickreceipt) | **POST** /beta/quickReceipt | Create a quickReceipt
*QuickReceiptApi* | [**DeleteQuickReceipt**](docs/QuickReceiptApi.md#deletequickreceipt) | **DELETE** /beta/quickReceipt/{quickReceiptId} | Delete a quickReceipt
*QuickReceiptApi* | [**GetQuickReceiptByFilter**](docs/QuickReceiptApi.md#getquickreceiptbyfilter) | **GET** /beta/quickReceipt/search | Search quickReceipts by filter
*QuickReceiptApi* | [**GetQuickReceiptById**](docs/QuickReceiptApi.md#getquickreceiptbyid) | **GET** /beta/quickReceipt/{quickReceiptId} | Get a quickReceipt by id
*QuickReceiptApi* | [**UpdateQuickReceipt**](docs/QuickReceiptApi.md#updatequickreceipt) | **PUT** /beta/quickReceipt | Update a quickReceipt
*QuickReceiptApi* | [**UpdateQuickReceiptCustomFields**](docs/QuickReceiptApi.md#updatequickreceiptcustomfields) | **PUT** /beta/quickReceipt/customFields | Update a quickReceipt custom fields
*ReceivingProcessApi* | [**DeleteReceivingProcess**](docs/ReceivingProcessApi.md#deletereceivingprocess) | **DELETE** /beta/receivingProcess/{receivingProcessId} | Delete a receivingProcess
*ReceivingProcessApi* | [**GetReceivingProcessByFilter**](docs/ReceivingProcessApi.md#getreceivingprocessbyfilter) | **GET** /beta/receivingProcess/search | Search receivingProcesses by filter
*ReceivingProcessApi* | [**GetReceivingProcessById**](docs/ReceivingProcessApi.md#getreceivingprocessbyid) | **GET** /beta/receivingProcess/{receivingProcessId} | Get a receivingProcess by id
*ReceivingProcessApi* | [**UpdateReceivingProcessCustomFields**](docs/ReceivingProcessApi.md#updatereceivingprocesscustomfields) | **PUT** /beta/receivingProcess/customFields | Update a receivingProcess custom fields
*ReceivingWorksheetApi* | [**AddReceivingWorksheet**](docs/ReceivingWorksheetApi.md#addreceivingworksheet) | **POST** /beta/receivingWorksheet | Create a receivingWorksheet
*ReceivingWorksheetApi* | [**DeleteReceivingWorksheet**](docs/ReceivingWorksheetApi.md#deletereceivingworksheet) | **DELETE** /beta/receivingWorksheet/{receivingWorksheetId} | Delete a receivingWorksheet
*ReceivingWorksheetApi* | [**GetReceivingWorksheetByFilter**](docs/ReceivingWorksheetApi.md#getreceivingworksheetbyfilter) | **GET** /beta/receivingWorksheet/search | Search receivingWorksheets by filter
*ReceivingWorksheetApi* | [**GetReceivingWorksheetById**](docs/ReceivingWorksheetApi.md#getreceivingworksheetbyid) | **GET** /beta/receivingWorksheet/{receivingWorksheetId} | Get a receivingWorksheet by id
*ReceivingWorksheetApi* | [**UpdateReceivingWorksheet**](docs/ReceivingWorksheetApi.md#updatereceivingworksheet) | **PUT** /beta/receivingWorksheet | Update a receivingWorksheet
*ReceivingWorksheetApi* | [**UpdateReceivingWorksheetCustomFields**](docs/ReceivingWorksheetApi.md#updatereceivingworksheetcustomfields) | **PUT** /beta/receivingWorksheet/customFields | Update a receivingWorksheet custom fields
*ReplenishmentApi* | [**GetReplenishmentByFilter**](docs/ReplenishmentApi.md#getreplenishmentbyfilter) | **GET** /beta/replenishment/search | Search replenishments by filter
*ReplenishmentApi* | [**GetReplenishmentById**](docs/ReplenishmentApi.md#getreplenishmentbyid) | **GET** /beta/replenishment/{replenishmentId} | Get a replenishment by id
*ReplenishmentApi* | [**UpdateReplenishmentCustomFields**](docs/ReplenishmentApi.md#updatereplenishmentcustomfields) | **PUT** /beta/replenishment/customFields | Update a replenishment custom fields
*ReplenishmentPlanApi* | [**AddReplenishmentPlan**](docs/ReplenishmentPlanApi.md#addreplenishmentplan) | **POST** /beta/replenishmentPlan | Create a replenishmentPlan
*ReplenishmentPlanApi* | [**DeleteReplenishmentPlan**](docs/ReplenishmentPlanApi.md#deletereplenishmentplan) | **DELETE** /beta/replenishmentPlan/{replenishmentPlanId} | Delete a replenishmentPlan
*ReplenishmentPlanApi* | [**GetReplenishmentPlanByFilter**](docs/ReplenishmentPlanApi.md#getreplenishmentplanbyfilter) | **GET** /beta/replenishmentPlan/search | Search replenishmentPlans by filter
*ReplenishmentPlanApi* | [**GetReplenishmentPlanById**](docs/ReplenishmentPlanApi.md#getreplenishmentplanbyid) | **GET** /beta/replenishmentPlan/{replenishmentPlanId} | Get a replenishmentPlan by id
*ReplenishmentPlanApi* | [**UpdateReplenishmentPlan**](docs/ReplenishmentPlanApi.md#updatereplenishmentplan) | **PUT** /beta/replenishmentPlan | Update a replenishmentPlan
*ReplenishmentPlanApi* | [**UpdateReplenishmentPlanCustomFields**](docs/ReplenishmentPlanApi.md#updatereplenishmentplancustomfields) | **PUT** /beta/replenishmentPlan/customFields | Update a replenishmentPlan custom fields
*ReplenishmentProcessApi* | [**GetReplenishmentProcessByFilter**](docs/ReplenishmentProcessApi.md#getreplenishmentprocessbyfilter) | **GET** /beta/replenishmentProcess/search | Search replenishmentProcesses by filter
*ReplenishmentProcessApi* | [**GetReplenishmentProcessById**](docs/ReplenishmentProcessApi.md#getreplenishmentprocessbyid) | **GET** /beta/replenishmentProcess/{replenishmentProcessId} | Get a replenishmentProcess by id
*ReplenishmentProcessApi* | [**UpdateReplenishmentProcessCustomFields**](docs/ReplenishmentProcessApi.md#updatereplenishmentprocesscustomfields) | **PUT** /beta/replenishmentProcess/customFields | Update a replenishmentProcess custom fields
*ScheduledPlanLogApi* | [**GetScheduledPlanLogByFilter**](docs/ScheduledPlanLogApi.md#getscheduledplanlogbyfilter) | **GET** /beta/scheduledPlanLog/search | Search scheduledPlanLogs by filter
*ScheduledPlanLogApi* | [**GetScheduledPlanLogById**](docs/ScheduledPlanLogApi.md#getscheduledplanlogbyid) | **GET** /beta/scheduledPlanLog/{scheduledPlanLogId} | Get a scheduledPlanLog by id
*ServiceTypeApi* | [**GetServiceTypeById**](docs/ServiceTypeApi.md#getservicetypebyid) | **GET** /beta/serviceType/{serviceTypeId} | Get a serviceType by id
*ServiceTypeApi* | [**GetServiceTypeBySearchText**](docs/ServiceTypeApi.md#getservicetypebysearchtext) | **GET** /beta/serviceType/search | Search serviceTypes
*ShoppingCartConnectionApi* | [**AddShoppingCartConnection**](docs/ShoppingCartConnectionApi.md#addshoppingcartconnection) | **POST** /beta/shoppingCartConnection | Create a shoppingCartConnection
*ShoppingCartConnectionApi* | [**DeleteShoppingCartConnection**](docs/ShoppingCartConnectionApi.md#deleteshoppingcartconnection) | **DELETE** /beta/shoppingCartConnection/{shoppingCartConnectionId} | Delete a shoppingCartConnection
*ShoppingCartConnectionApi* | [**GetShoppingCartConnectionByFilter**](docs/ShoppingCartConnectionApi.md#getshoppingcartconnectionbyfilter) | **GET** /beta/shoppingCartConnection/search | Search shoppingCartConnections by filter
*ShoppingCartConnectionApi* | [**GetShoppingCartConnectionById**](docs/ShoppingCartConnectionApi.md#getshoppingcartconnectionbyid) | **GET** /beta/shoppingCartConnection/{shoppingCartConnectionId} | Get a shoppingCartConnection by id
*ShoppingCartConnectionApi* | [**UpdateShoppingCartConnection**](docs/ShoppingCartConnectionApi.md#updateshoppingcartconnection) | **PUT** /beta/shoppingCartConnection | Update a shoppingCartConnection
*ShoppingCartConnectionApi* | [**UpdateShoppingCartConnectionCustomFields**](docs/ShoppingCartConnectionApi.md#updateshoppingcartconnectioncustomfields) | **PUT** /beta/shoppingCartConnection/customFields | Update a shoppingCartConnection custom fields
*SubstitutionApi* | [**AddSubstitution**](docs/SubstitutionApi.md#addsubstitution) | **POST** /beta/substitution | Create a substitution
*SubstitutionApi* | [**DeleteSubstitution**](docs/SubstitutionApi.md#deletesubstitution) | **DELETE** /beta/substitution/{substitutionId} | Delete a substitution
*SubstitutionApi* | [**GetSubstitutionByFilter**](docs/SubstitutionApi.md#getsubstitutionbyfilter) | **GET** /beta/substitution/search | Search substitutions by filter
*SubstitutionApi* | [**GetSubstitutionById**](docs/SubstitutionApi.md#getsubstitutionbyid) | **GET** /beta/substitution/{substitutionId} | Get a substitution by id
*SubstitutionApi* | [**UpdateSubstitution**](docs/SubstitutionApi.md#updatesubstitution) | **PUT** /beta/substitution | Update a substitution
*SubstitutionApi* | [**UpdateSubstitutionCustomFields**](docs/SubstitutionApi.md#updatesubstitutioncustomfields) | **PUT** /beta/substitution/customFields | Update a substitution custom fields
*SupplementApi* | [**AddSupplement**](docs/SupplementApi.md#addsupplement) | **POST** /beta/supplement | Create a supplement
*SupplementApi* | [**DeleteSupplement**](docs/SupplementApi.md#deletesupplement) | **DELETE** /beta/supplement/{supplementId} | Delete a supplement
*SupplementApi* | [**GetSupplementByFilter**](docs/SupplementApi.md#getsupplementbyfilter) | **GET** /beta/supplement/search | Search supplements by filter
*SupplementApi* | [**GetSupplementById**](docs/SupplementApi.md#getsupplementbyid) | **GET** /beta/supplement/{supplementId} | Get a supplement by id
*SupplementApi* | [**UpdateSupplement**](docs/SupplementApi.md#updatesupplement) | **PUT** /beta/supplement | Update a supplement
*SupplementApi* | [**UpdateSupplementCustomFields**](docs/SupplementApi.md#updatesupplementcustomfields) | **PUT** /beta/supplement/customFields | Update a supplement custom fields
*ThirdPartyParcelAccountApi* | [**AddThirdPartyParcelAccount**](docs/ThirdPartyParcelAccountApi.md#addthirdpartyparcelaccount) | **POST** /beta/thirdPartyParcelAccount | Create a thirdPartyParcelAccount
*ThirdPartyParcelAccountApi* | [**DeleteThirdPartyParcelAccount**](docs/ThirdPartyParcelAccountApi.md#deletethirdpartyparcelaccount) | **DELETE** /beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId} | Delete a thirdPartyParcelAccount
*ThirdPartyParcelAccountApi* | [**GetThirdPartyParcelAccountByFilter**](docs/ThirdPartyParcelAccountApi.md#getthirdpartyparcelaccountbyfilter) | **GET** /beta/thirdPartyParcelAccount/search | Search thirdPartyParcelAccounts by filter
*ThirdPartyParcelAccountApi* | [**GetThirdPartyParcelAccountById**](docs/ThirdPartyParcelAccountApi.md#getthirdpartyparcelaccountbyid) | **GET** /beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId} | Get a thirdPartyParcelAccount by id
*ThirdPartyParcelAccountApi* | [**UpdateThirdPartyParcelAccount**](docs/ThirdPartyParcelAccountApi.md#updatethirdpartyparcelaccount) | **PUT** /beta/thirdPartyParcelAccount | Update a thirdPartyParcelAccount
*ThirdPartyParcelAccountApi* | [**UpdateThirdPartyParcelAccountCustomFields**](docs/ThirdPartyParcelAccountApi.md#updatethirdpartyparcelaccountcustomfields) | **PUT** /beta/thirdPartyParcelAccount/customFields | Update a thirdPartyParcelAccount custom fields
*UserApi* | [**GetUserById**](docs/UserApi.md#getuserbyid) | **GET** /beta/user/{userId} | Get an user by id
*UserApi* | [**GetUserBySearchText**](docs/UserApi.md#getuserbysearchtext) | **GET** /beta/user/search | Search users
*VendorApi* | [**AddVendor**](docs/VendorApi.md#addvendor) | **POST** /beta/vendor | Create a vendor
*VendorApi* | [**DeleteVendor**](docs/VendorApi.md#deletevendor) | **DELETE** /beta/vendor/{vendorId} | Delete a vendor
*VendorApi* | [**GetVendorByFilter**](docs/VendorApi.md#getvendorbyfilter) | **GET** /beta/vendor/search | Search vendors by filter
*VendorApi* | [**GetVendorById**](docs/VendorApi.md#getvendorbyid) | **GET** /beta/vendor/{vendorId} | Get a vendor by id
*VendorApi* | [**UpdateVendor**](docs/VendorApi.md#updatevendor) | **PUT** /beta/vendor | Update a vendor
*VendorApi* | [**UpdateVendorCustomFields**](docs/VendorApi.md#updatevendorcustomfields) | **PUT** /beta/vendor/customFields | Update a vendor custom fields
*VendorComplianceSurveyApi* | [**AddVendorComplianceSurvey**](docs/VendorComplianceSurveyApi.md#addvendorcompliancesurvey) | **POST** /beta/vendorComplianceSurvey | Create a vendorComplianceSurvey
*VendorComplianceSurveyApi* | [**DeleteVendorComplianceSurvey**](docs/VendorComplianceSurveyApi.md#deletevendorcompliancesurvey) | **DELETE** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId} | Delete a vendorComplianceSurvey
*VendorComplianceSurveyApi* | [**GetVendorComplianceSurveyByFilter**](docs/VendorComplianceSurveyApi.md#getvendorcompliancesurveybyfilter) | **GET** /beta/vendorComplianceSurvey/search | Search vendorComplianceSurveys by filter
*VendorComplianceSurveyApi* | [**GetVendorComplianceSurveyById**](docs/VendorComplianceSurveyApi.md#getvendorcompliancesurveybyid) | **GET** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId} | Get a vendorComplianceSurvey by id
*VendorComplianceSurveyApi* | [**UpdateVendorComplianceSurvey**](docs/VendorComplianceSurveyApi.md#updatevendorcompliancesurvey) | **PUT** /beta/vendorComplianceSurvey | Update a vendorComplianceSurvey
*VendorComplianceSurveyApi* | [**UpdateVendorComplianceSurveyCustomFields**](docs/VendorComplianceSurveyApi.md#updatevendorcompliancesurveycustomfields) | **PUT** /beta/vendorComplianceSurvey/customFields | Update a vendorComplianceSurvey custom fields
*WarehouseApi* | [**GetWarehouseByFilter**](docs/WarehouseApi.md#getwarehousebyfilter) | **GET** /beta/warehouse/search | Search warehouses by filter
*WarehouseApi* | [**GetWarehouseById**](docs/WarehouseApi.md#getwarehousebyid) | **GET** /beta/warehouse/{warehouseId} | Get a warehouse by id
*WarehouseApi* | [**UpdateWarehouse**](docs/WarehouseApi.md#updatewarehouse) | **PUT** /beta/warehouse | Update a warehouse
*WarehouseApi* | [**UpdateWarehouseCustomFields**](docs/WarehouseApi.md#updatewarehousecustomfields) | **PUT** /beta/warehouse/customFields | Update a warehouse custom fields
*WarehouseDocumentApi* | [**GetWarehouseDocumentByFilter**](docs/WarehouseDocumentApi.md#getwarehousedocumentbyfilter) | **GET** /beta/warehouseDocument/search | Search warehouseDocuments by filter
*WarehouseDocumentApi* | [**GetWarehouseDocumentById**](docs/WarehouseDocumentApi.md#getwarehousedocumentbyid) | **GET** /beta/warehouseDocument/{warehouseDocumentId} | Get a warehouseDocument by id
*WarehouseDocumentApi* | [**UpdateWarehouseDocumentCustomFields**](docs/WarehouseDocumentApi.md#updatewarehousedocumentcustomfields) | **PUT** /beta/warehouseDocument/customFields | Update a warehouseDocument custom fields
*WarehouseDocumentTypeApi* | [**GetWarehouseDocumentTypeByFilter**](docs/WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyfilter) | **GET** /beta/warehouseDocumentType/search | Search warehouseDocumentTypes by filter
*WarehouseDocumentTypeApi* | [**GetWarehouseDocumentTypeById**](docs/WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyid) | **GET** /beta/warehouseDocumentType/{warehouseDocumentTypeId} | Get a warehouseDocumentType by id
*WorkApi* | [**GetWorkByFilter**](docs/WorkApi.md#getworkbyfilter) | **GET** /beta/work/search | Search works by filter
*WorkApi* | [**GetWorkById**](docs/WorkApi.md#getworkbyid) | **GET** /beta/work/{workId} | Get a work by id
*WorkApi* | [**UpdateWorkCustomFields**](docs/WorkApi.md#updateworkcustomfields) | **PUT** /beta/work/customFields | Update a work custom fields
*WorkBatchApi* | [**GetWorkBatchByFilter**](docs/WorkBatchApi.md#getworkbatchbyfilter) | **GET** /beta/workBatch/search | Search workBatchs by filter
*WorkBatchApi* | [**GetWorkBatchById**](docs/WorkBatchApi.md#getworkbatchbyid) | **GET** /beta/workBatch/{workBatchId} | Get a workBatch by id
*WorkBatchApi* | [**UpdateWorkBatchCustomFields**](docs/WorkBatchApi.md#updateworkbatchcustomfields) | **PUT** /beta/workBatch/customFields | Update a workBatch custom fields
*ZoneApi* | [**AddZone**](docs/ZoneApi.md#addzone) | **POST** /beta/zone | Create a zone
*ZoneApi* | [**DeleteZone**](docs/ZoneApi.md#deletezone) | **DELETE** /beta/zone/{zoneId} | Delete a zone
*ZoneApi* | [**GetZoneByFilter**](docs/ZoneApi.md#getzonebyfilter) | **GET** /beta/zone/search | Search zones by filter
*ZoneApi* | [**GetZoneById**](docs/ZoneApi.md#getzonebyid) | **GET** /beta/zone/{zoneId} | Get a zone by id
*ZoneApi* | [**UpdateZone**](docs/ZoneApi.md#updatezone) | **PUT** /beta/zone | Update a zone
*ZoneApi* | [**UpdateZoneCustomFields**](docs/ZoneApi.md#updatezonecustomfields) | **PUT** /beta/zone/customFields | Update a zone custom fields


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Aisle](docs/Aisle.md)
 - [Model.Alert](docs/Alert.md)
 - [Model.ApiResponse](docs/ApiResponse.md)
 - [Model.Asn](docs/Asn.md)
 - [Model.BillOfLading](docs/BillOfLading.md)
 - [Model.BillOfLadingCarrierInfoLine](docs/BillOfLadingCarrierInfoLine.md)
 - [Model.BillOfLadingOrderInfoLine](docs/BillOfLadingOrderInfoLine.md)
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
 - [Model.Kit](docs/Kit.md)
 - [Model.LineOfBusiness](docs/LineOfBusiness.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationAddressScheme](docs/LocationAddressScheme.md)
 - [Model.LocationBillingType](docs/LocationBillingType.md)
 - [Model.LocationFootprint](docs/LocationFootprint.md)
 - [Model.LoggedTime](docs/LoggedTime.md)
 - [Model.LoggedTimeType](docs/LoggedTimeType.md)
 - [Model.LowStock](docs/LowStock.md)
 - [Model.ManageScheduledPlans](docs/ManageScheduledPlans.md)
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
 - [Model.ScheduledPlanLog](docs/ScheduledPlanLog.md)
 - [Model.ServiceType](docs/ServiceType.md)
 - [Model.ShoppingCartConnection](docs/ShoppingCartConnection.md)
 - [Model.Substitution](docs/Substitution.md)
 - [Model.Supplement](docs/Supplement.md)
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

