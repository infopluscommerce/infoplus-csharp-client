# Infoplus.Api.InventoryAdjustmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInventoryAdjustmentByFilter**](InventoryAdjustmentApi.md#getinventoryadjustmentbyfilter) | **GET** /v1.0/inventoryAdjustment/search | Search inventoryAdjustments by filter
[**GetInventoryAdjustmentById**](InventoryAdjustmentApi.md#getinventoryadjustmentbyid) | **GET** /v1.0/inventoryAdjustment/{inventoryAdjustmentId} | Get an inventoryAdjustment by id


# **GetInventoryAdjustmentByFilter**
> List<InventoryAdjustment> GetInventoryAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search inventoryAdjustments by filter

Returns the list of inventoryAdjustments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryAdjustmentByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new InventoryAdjustmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search inventoryAdjustments by filter
                List&lt;InventoryAdjustment&gt; result = apiInstance.GetInventoryAdjustmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetInventoryAdjustmentByFilter: " + e.Message );
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

[**List<InventoryAdjustment>**](InventoryAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetInventoryAdjustmentById**
> InventoryAdjustment GetInventoryAdjustmentById (int? inventoryAdjustmentId)

Get an inventoryAdjustment by id

Returns the inventoryAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryAdjustmentByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to be returned.

            try
            {
                // Get an inventoryAdjustment by id
                InventoryAdjustment result = apiInstance.GetInventoryAdjustmentById(inventoryAdjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetInventoryAdjustmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to be returned. | 

### Return type

[**InventoryAdjustment**](InventoryAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

