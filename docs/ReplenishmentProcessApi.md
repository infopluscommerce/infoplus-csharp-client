# Infoplus.Api.ReplenishmentProcessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetReplenishmentProcessByFilter**](ReplenishmentProcessApi.md#getreplenishmentprocessbyfilter) | **GET** /v1.0/replenishmentProcess/search | Search replenishmentProcesses by filter
[**GetReplenishmentProcessById**](ReplenishmentProcessApi.md#getreplenishmentprocessbyid) | **GET** /v1.0/replenishmentProcess/{replenishmentProcessId} | Get a replenishmentProcess by id


# **GetReplenishmentProcessByFilter**
> List<ReplenishmentProcess> GetReplenishmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search replenishmentProcesses by filter

Returns the list of replenishmentProcesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentProcessByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentProcessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search replenishmentProcesses by filter
                List&lt;ReplenishmentProcess&gt; result = apiInstance.GetReplenishmentProcessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.GetReplenishmentProcessByFilter: " + e.Message );
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

[**List<ReplenishmentProcess>**](ReplenishmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetReplenishmentProcessById**
> ReplenishmentProcess GetReplenishmentProcessById (int? replenishmentProcessId)

Get a replenishmentProcess by id

Returns the replenishmentProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentProcessByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to be returned.

            try
            {
                // Get a replenishmentProcess by id
                ReplenishmentProcess result = apiInstance.GetReplenishmentProcessById(replenishmentProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.GetReplenishmentProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to be returned. | 

### Return type

[**ReplenishmentProcess**](ReplenishmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

