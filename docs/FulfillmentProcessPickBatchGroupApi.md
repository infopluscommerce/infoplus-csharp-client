# Infoplus.Api.FulfillmentProcessPickBatchGroupApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFulfillmentProcessGroupPicksByById**](FulfillmentProcessPickBatchGroupApi.md#getfulfillmentprocessgrouppicksbybyid) | **GET** /beta/fulfillmentProcessPickBatchGroup/{fulfillmentProcessPickBatchGroupId} | Get a fulfillmentProcessPickBatchGroup by id
[**GetFulfillmentProcessPickBatchGroupBySearchText**](FulfillmentProcessPickBatchGroupApi.md#getfulfillmentprocesspickbatchgroupbysearchtext) | **GET** /beta/fulfillmentProcessPickBatchGroup/search | Search fulfillmentProcessPickBatchGroups


<a name="getfulfillmentprocessgrouppicksbybyid"></a>
# **GetFulfillmentProcessGroupPicksByById**
> FulfillmentProcessPickBatchGroup GetFulfillmentProcessGroupPicksByById (string fulfillmentProcessPickBatchGroupId)

Get a fulfillmentProcessPickBatchGroup by id

Returns the fulfillmentProcessPickBatchGroup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessGroupPicksByByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessPickBatchGroupApi();
            var fulfillmentProcessPickBatchGroupId = fulfillmentProcessPickBatchGroupId_example;  // string | Id of fulfillmentProcessPickBatchGroup to be returned.

            try
            {
                // Get a fulfillmentProcessPickBatchGroup by id
                FulfillmentProcessPickBatchGroup result = apiInstance.GetFulfillmentProcessGroupPicksByById(fulfillmentProcessPickBatchGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessPickBatchGroupApi.GetFulfillmentProcessGroupPicksByById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessPickBatchGroupId** | **string**| Id of fulfillmentProcessPickBatchGroup to be returned. | 

### Return type

[**FulfillmentProcessPickBatchGroup**](FulfillmentProcessPickBatchGroup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocesspickbatchgroupbysearchtext"></a>
# **GetFulfillmentProcessPickBatchGroupBySearchText**
> List<FulfillmentProcessPickBatchGroup> GetFulfillmentProcessPickBatchGroupBySearchText (string searchText = null, int? page = null, int? limit = null)

Search fulfillmentProcessPickBatchGroups

Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessPickBatchGroupBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessPickBatchGroupApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search fulfillmentProcessPickBatchGroups
                List&lt;FulfillmentProcessPickBatchGroup&gt; result = apiInstance.GetFulfillmentProcessPickBatchGroupBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessPickBatchGroupApi.GetFulfillmentProcessPickBatchGroupBySearchText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchText** | **string**| Search text, used to filter results. | [optional] 
 **page** | **int?**| Result page number.  Defaults to 1. | [optional] 
 **limit** | **int?**| Maximum results per page.  Defaults to 20.  Max allowed value is 250. | [optional] 

### Return type

[**List<FulfillmentProcessPickBatchGroup>**](FulfillmentProcessPickBatchGroup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

