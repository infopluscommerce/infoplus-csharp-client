# Infoplus.Api.WorkBatchApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWorkBatchByFilter**](WorkBatchApi.md#getworkbatchbyfilter) | **GET** /beta/workBatch/search | Search workBatchs by filter
[**GetWorkBatchById**](WorkBatchApi.md#getworkbatchbyid) | **GET** /beta/workBatch/{workBatchId} | Get a workBatch by id
[**UpdateWorkBatchCustomFields**](WorkBatchApi.md#updateworkbatchcustomfields) | **PUT** /beta/workBatch/customFields | Update a workBatch custom fields


<a name="getworkbatchbyfilter"></a>
# **GetWorkBatchByFilter**
> List<WorkBatch> GetWorkBatchByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search workBatchs by filter

Returns the list of workBatchs that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkBatchByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new WorkBatchApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search workBatchs by filter
                List&lt;WorkBatch&gt; result = apiInstance.GetWorkBatchByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkBatchApi.GetWorkBatchByFilter: " + e.Message );
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

[**List<WorkBatch>**](WorkBatch.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkbatchbyid"></a>
# **GetWorkBatchById**
> WorkBatch GetWorkBatchById (int? workBatchId)

Get a workBatch by id

Returns the workBatch identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkBatchByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new WorkBatchApi();
            var workBatchId = 56;  // int? | Id of the workBatch to be returned.

            try
            {
                // Get a workBatch by id
                WorkBatch result = apiInstance.GetWorkBatchById(workBatchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkBatchApi.GetWorkBatchById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workBatchId** | **int?**| Id of the workBatch to be returned. | 

### Return type

[**WorkBatch**](WorkBatch.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkbatchcustomfields"></a>
# **UpdateWorkBatchCustomFields**
> void UpdateWorkBatchCustomFields (WorkBatch body)

Update a workBatch custom fields

Updates an existing workBatch custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWorkBatchCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new WorkBatchApi();
            var body = new WorkBatch(); // WorkBatch | WorkBatch to be updated.

            try
            {
                // Update a workBatch custom fields
                apiInstance.UpdateWorkBatchCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkBatchApi.UpdateWorkBatchCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkBatch**](WorkBatch.md)| WorkBatch to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

