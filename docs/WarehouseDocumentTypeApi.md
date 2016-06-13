# Infoplus.Api.WarehouseDocumentTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWarehouseDocumentTypeByFilter**](WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyfilter) | **GET** /v1.0/warehouseDocumentType/search | Search warehouseDocumentTypes by filter
[**GetWarehouseDocumentTypeById**](WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyid) | **GET** /v1.0/warehouseDocumentType/{warehouseDocumentTypeId} | Get a warehouseDocumentType by id


# **GetWarehouseDocumentTypeByFilter**
> List<WarehouseDocumentType> GetWarehouseDocumentTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search warehouseDocumentTypes by filter

Returns the list of warehouseDocumentTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentTypeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new WarehouseDocumentTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search warehouseDocumentTypes by filter
                List&lt;WarehouseDocumentType&gt; result = apiInstance.GetWarehouseDocumentTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.GetWarehouseDocumentTypeByFilter: " + e.Message );
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

[**List<WarehouseDocumentType>**](WarehouseDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetWarehouseDocumentTypeById**
> WarehouseDocumentType GetWarehouseDocumentTypeById (int? warehouseDocumentTypeId)

Get a warehouseDocumentType by id

Returns the warehouseDocumentType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentTypeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to be returned.

            try
            {
                // Get a warehouseDocumentType by id
                WarehouseDocumentType result = apiInstance.GetWarehouseDocumentTypeById(warehouseDocumentTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.GetWarehouseDocumentTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to be returned. | 

### Return type

[**WarehouseDocumentType**](WarehouseDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

