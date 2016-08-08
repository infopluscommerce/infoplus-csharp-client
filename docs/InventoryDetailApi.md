# Infoplus.Api.InventoryDetailApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInventoryDetailByFilter**](InventoryDetailApi.md#getinventorydetailbyfilter) | **GET** /beta/inventoryDetail/search | Search inventoryDetails by filter
[**GetInventoryDetailById**](InventoryDetailApi.md#getinventorydetailbyid) | **GET** /beta/inventoryDetail/{inventoryDetailId} | Get an inventoryDetail by id
[**UpdateInventoryDetailCustomFields**](InventoryDetailApi.md#updateinventorydetailcustomfields) | **PUT** /beta/inventoryDetail/customFields | Update an inventoryDetail custom fields


<a name="getinventorydetailbyfilter"></a>
# **GetInventoryDetailByFilter**
> List<InventoryDetail> GetInventoryDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search inventoryDetails by filter

Returns the list of inventoryDetails that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryDetailByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search inventoryDetails by filter
                List&lt;InventoryDetail&gt; result = apiInstance.GetInventoryDetailByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetInventoryDetailByFilter: " + e.Message );
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

[**List<InventoryDetail>**](InventoryDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorydetailbyid"></a>
# **GetInventoryDetailById**
> InventoryDetail GetInventoryDetailById (int? inventoryDetailId)

Get an inventoryDetail by id

Returns the inventoryDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryDetailByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to be returned.

            try
            {
                // Get an inventoryDetail by id
                InventoryDetail result = apiInstance.GetInventoryDetailById(inventoryDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetInventoryDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to be returned. | 

### Return type

[**InventoryDetail**](InventoryDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventorydetailcustomfields"></a>
# **UpdateInventoryDetailCustomFields**
> void UpdateInventoryDetailCustomFields (InventoryDetail body)

Update an inventoryDetail custom fields

Updates an existing inventoryDetail custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateInventoryDetailCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var body = new InventoryDetail(); // InventoryDetail | InventoryDetail to be updated.

            try
            {
                // Update an inventoryDetail custom fields
                apiInstance.UpdateInventoryDetailCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.UpdateInventoryDetailCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryDetail**](InventoryDetail.md)| InventoryDetail to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

