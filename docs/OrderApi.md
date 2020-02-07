# Infoplus.Api.OrderApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrder**](OrderApi.md#addorder) | **POST** /beta/order | Create an order
[**AddOrderAudit**](OrderApi.md#addorderaudit) | **PUT** /beta/order/{orderId}/audit/{orderAudit} | Add new audit for an order
[**AddOrderFile**](OrderApi.md#addorderfile) | **POST** /beta/order/{orderId}/file/{fileName} | Attach a file to an order
[**AddOrderFileByURL**](OrderApi.md#addorderfilebyurl) | **POST** /beta/order/{orderId}/file | Attach a file to an order by URL.
[**AddOrderTag**](OrderApi.md#addordertag) | **PUT** /beta/order/{orderId}/tag/{orderTag} | Add new tags for an order.
[**ApplyOrderWarehouseFulfillmentPlan**](OrderApi.md#applyorderwarehousefulfillmentplan) | **POST** /beta/order/applyOrderWarehouseFulfillmentPlan | Run the Apply Order Warehouse Fulfillment Plan method.
[**DeleteOrder**](OrderApi.md#deleteorder) | **DELETE** /beta/order/{orderId} | Delete an order
[**DeleteOrderFile**](OrderApi.md#deleteorderfile) | **DELETE** /beta/order/{orderId}/file/{fileId} | Delete a file for an order.
[**DeleteOrderTag**](OrderApi.md#deleteordertag) | **DELETE** /beta/order/{orderId}/tag/{orderTag} | Delete a tag for an order.
[**EditFulfillmentChannel**](OrderApi.md#editfulfillmentchannel) | **POST** /beta/order/editFulfillmentChannel | Run the EditLineItemFulfillmentStrategy process.
[**EditLineItems**](OrderApi.md#editlineitems) | **POST** /beta/order/editLineItems | Run the ReqManualSubstitution process.
[**GetDuplicateOrderById**](OrderApi.md#getduplicateorderbyid) | **GET** /beta/order/duplicate/{orderId} | Get a duplicated an order by id
[**GetOrderByFilter**](OrderApi.md#getorderbyfilter) | **GET** /beta/order/search | Search orders by filter
[**GetOrderById**](OrderApi.md#getorderbyid) | **GET** /beta/order/{orderId} | Get an order by id
[**GetOrderFiles**](OrderApi.md#getorderfiles) | **GET** /beta/order/{orderId}/file | Get the files for an order.
[**GetOrderTags**](OrderApi.md#getordertags) | **GET** /beta/order/{orderId}/tag | Get the tags for an order.
[**GetOrderWarehouseFulfillmentData**](OrderApi.md#getorderwarehousefulfillmentdata) | **POST** /beta/order/getOrderWarehouseFulfillmentData | Run the Get Order Warehouse Fulfillment Plan method.
[**RunFulfillmentPlan**](OrderApi.md#runfulfillmentplan) | **POST** /beta/order/runFulfillmentPlan | Run the RunFulfillmentPlan process.
[**UpdateOrder**](OrderApi.md#updateorder) | **PUT** /beta/order | Update an order
[**UpdateOrderCustomFields**](OrderApi.md#updateordercustomfields) | **PUT** /beta/order/customFields | Update an order custom fields


<a name="addorder"></a>
# **AddOrder**
> Order AddOrder (Order body)

Create an order

Inserts a new order using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new Order(); // Order | Order to be inserted.

            try
            {
                // Create an order
                Order result = apiInstance.AddOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AddOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Order**](Order.md)| Order to be inserted. | 

### Return type

[**Order**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderaudit"></a>
# **AddOrderAudit**
> void AddOrderAudit (decimal? orderId, string orderAudit)

Add new audit for an order

Adds an audit to an existing order.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to add an audit to
            var orderAudit = orderAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an order
                apiInstance.AddOrderAudit(orderId, orderAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AddOrderAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to add an audit to | 
 **orderAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderfile"></a>
# **AddOrderFile**
> void AddOrderFile (decimal? orderId, string fileName)

Attach a file to an order

Adds a file to an existing order.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an order
                apiInstance.AddOrderFile(orderId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AddOrderFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderfilebyurl"></a>
# **AddOrderFileByURL**
> void AddOrderFileByURL (RecordFile body, decimal? orderId)

Attach a file to an order by URL.

Adds a file to an existing order by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var orderId = 8.14;  // decimal? | Id of the order to add an file to

            try
            {
                // Attach a file to an order by URL.
                apiInstance.AddOrderFileByURL(body, orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AddOrderFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **orderId** | **decimal?**| Id of the order to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordertag"></a>
# **AddOrderTag**
> void AddOrderTag (decimal? orderId, string orderTag)

Add new tags for an order.

Adds a tag to an existing order.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to add a tag to
            var orderTag = orderTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an order.
                apiInstance.AddOrderTag(orderId, orderTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.AddOrderTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to add a tag to | 
 **orderTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applyorderwarehousefulfillmentplan"></a>
# **ApplyOrderWarehouseFulfillmentPlan**
> ApplyOrderWarehouseFulfillmentPlanOutput ApplyOrderWarehouseFulfillmentPlan (ApplyOrderWarehouseFulfillmentPlanInput body)

Run the Apply Order Warehouse Fulfillment Plan method.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class ApplyOrderWarehouseFulfillmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new ApplyOrderWarehouseFulfillmentPlanInput(); // ApplyOrderWarehouseFulfillmentPlanInput | Input data for Apply Order Warehouse Fulfillment Plan process.

            try
            {
                // Run the Apply Order Warehouse Fulfillment Plan method.
                ApplyOrderWarehouseFulfillmentPlanOutput result = apiInstance.ApplyOrderWarehouseFulfillmentPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ApplyOrderWarehouseFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplyOrderWarehouseFulfillmentPlanInput**](ApplyOrderWarehouseFulfillmentPlanInput.md)| Input data for Apply Order Warehouse Fulfillment Plan process. | 

### Return type

[**ApplyOrderWarehouseFulfillmentPlanOutput**](ApplyOrderWarehouseFulfillmentPlanOutput.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorder"></a>
# **DeleteOrder**
> void DeleteOrder (decimal? orderId)

Delete an order

Deletes the order identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to be deleted.

            try
            {
                // Delete an order
                apiInstance.DeleteOrder(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderfile"></a>
# **DeleteOrderFile**
> void DeleteOrderFile (decimal? orderId, int? fileId)

Delete a file for an order.

Deletes an existing order file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an order.
                apiInstance.DeleteOrderFile(orderId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrderFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordertag"></a>
# **DeleteOrderTag**
> void DeleteOrderTag (decimal? orderId, string orderTag)

Delete a tag for an order.

Deletes an existing order tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to remove tag from
            var orderTag = orderTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an order.
                apiInstance.DeleteOrderTag(orderId, orderTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrderTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to remove tag from | 
 **orderTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editfulfillmentchannel"></a>
# **EditFulfillmentChannel**
> List<ProcessOutputAPIModel> EditFulfillmentChannel (EditLineItemFulfillmentStrategyInputAPIModel body)

Run the EditLineItemFulfillmentStrategy process.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class EditFulfillmentChannelExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new EditLineItemFulfillmentStrategyInputAPIModel(); // EditLineItemFulfillmentStrategyInputAPIModel | Input data for EditLineItemFulfillmentStrategy process.

            try
            {
                // Run the EditLineItemFulfillmentStrategy process.
                List&lt;ProcessOutputAPIModel&gt; result = apiInstance.EditFulfillmentChannel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.EditFulfillmentChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EditLineItemFulfillmentStrategyInputAPIModel**](EditLineItemFulfillmentStrategyInputAPIModel.md)| Input data for EditLineItemFulfillmentStrategy process. | 

### Return type

[**List<ProcessOutputAPIModel>**](ProcessOutputAPIModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editlineitems"></a>
# **EditLineItems**
> List<ProcessOutputAPIModel> EditLineItems (ReqManualSubstitutionInputAPIModel body)

Run the ReqManualSubstitution process.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class EditLineItemsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new ReqManualSubstitutionInputAPIModel(); // ReqManualSubstitutionInputAPIModel | Input data for ReqManualSubstitution process.

            try
            {
                // Run the ReqManualSubstitution process.
                List&lt;ProcessOutputAPIModel&gt; result = apiInstance.EditLineItems(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.EditLineItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReqManualSubstitutionInputAPIModel**](ReqManualSubstitutionInputAPIModel.md)| Input data for ReqManualSubstitution process. | 

### Return type

[**List<ProcessOutputAPIModel>**](ProcessOutputAPIModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateorderbyid"></a>
# **GetDuplicateOrderById**
> Order GetDuplicateOrderById (decimal? orderId)

Get a duplicated an order by id

Returns a duplicated order identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to be duplicated.

            try
            {
                // Get a duplicated an order by id
                Order result = apiInstance.GetDuplicateOrderById(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetDuplicateOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to be duplicated. | 

### Return type

[**Order**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyfilter"></a>
# **GetOrderByFilter**
> List<Order> GetOrderByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orders by filter

Returns the list of orders that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orders by filter
                List&lt;Order&gt; result = apiInstance.GetOrderByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Query string, used to filter results. | [optional] 
 **page** | **int?**| Result page number.  Defaults to 1. | [optional] 
 **limit** | **int?**| Maximum results per page.  Defaults to 20.  Max allowed value is 250. | [optional] 
 **sort** | **string**| Sort results by specified field. | [optional] 

### Return type

[**List<Order>**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyid"></a>
# **GetOrderById**
> Order GetOrderById (decimal? orderId)

Get an order by id

Returns the order identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to be returned.

            try
            {
                // Get an order by id
                Order result = apiInstance.GetOrderById(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to be returned. | 

### Return type

[**Order**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderfiles"></a>
# **GetOrderFiles**
> void GetOrderFiles (decimal? orderId)

Get the files for an order.

Get all existing order files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to get files for

            try
            {
                // Get the files for an order.
                apiInstance.GetOrderFiles(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordertags"></a>
# **GetOrderTags**
> void GetOrderTags (decimal? orderId)

Get the tags for an order.

Get all existing order tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var orderId = 8.14;  // decimal? | Id of the order to get tags for

            try
            {
                // Get the tags for an order.
                apiInstance.GetOrderTags(orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **decimal?**| Id of the order to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderwarehousefulfillmentdata"></a>
# **GetOrderWarehouseFulfillmentData**
> GetOrderWarehouseFulfillmentDataOutput GetOrderWarehouseFulfillmentData (GetOrderWarehouseFulfillmentDataInput body)

Run the Get Order Warehouse Fulfillment Plan method.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderWarehouseFulfillmentDataExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new GetOrderWarehouseFulfillmentDataInput(); // GetOrderWarehouseFulfillmentDataInput | Input data for Get Order Warehouse Fulfillment Plan process.

            try
            {
                // Run the Get Order Warehouse Fulfillment Plan method.
                GetOrderWarehouseFulfillmentDataOutput result = apiInstance.GetOrderWarehouseFulfillmentData(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderWarehouseFulfillmentData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetOrderWarehouseFulfillmentDataInput**](GetOrderWarehouseFulfillmentDataInput.md)| Input data for Get Order Warehouse Fulfillment Plan process. | 

### Return type

[**GetOrderWarehouseFulfillmentDataOutput**](GetOrderWarehouseFulfillmentDataOutput.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runfulfillmentplan"></a>
# **RunFulfillmentPlan**
> List<ProcessOutputAPIModel> RunFulfillmentPlan (RunFulfillmentPlanInputAPIModel body)

Run the RunFulfillmentPlan process.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class RunFulfillmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new RunFulfillmentPlanInputAPIModel(); // RunFulfillmentPlanInputAPIModel | Input data for RunFulfillmentPlan process.

            try
            {
                // Run the RunFulfillmentPlan process.
                List&lt;ProcessOutputAPIModel&gt; result = apiInstance.RunFulfillmentPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.RunFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RunFulfillmentPlanInputAPIModel**](RunFulfillmentPlanInputAPIModel.md)| Input data for RunFulfillmentPlan process. | 

### Return type

[**List<ProcessOutputAPIModel>**](ProcessOutputAPIModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorder"></a>
# **UpdateOrder**
> void UpdateOrder (Order body)

Update an order

Updates an existing order using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new Order(); // Order | Order to be updated.

            try
            {
                // Update an order
                apiInstance.UpdateOrder(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Order**](Order.md)| Order to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateordercustomfields"></a>
# **UpdateOrderCustomFields**
> void UpdateOrderCustomFields (Order body)

Update an order custom fields

Updates an existing order custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderApi();
            var body = new Order(); // Order | Order to be updated.

            try
            {
                // Update an order custom fields
                apiInstance.UpdateOrderCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateOrderCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Order**](Order.md)| Order to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

