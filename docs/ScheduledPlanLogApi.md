# Infoplus.Api.ScheduledPlanLogApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetScheduledPlanLogByFilter**](ScheduledPlanLogApi.md#getscheduledplanlogbyfilter) | **GET** /beta/scheduledPlanLog/search | Search scheduledPlanLogs by filter
[**GetScheduledPlanLogById**](ScheduledPlanLogApi.md#getscheduledplanlogbyid) | **GET** /beta/scheduledPlanLog/{scheduledPlanLogId} | Get a scheduledPlanLog by id


<a name="getscheduledplanlogbyfilter"></a>
# **GetScheduledPlanLogByFilter**
> List<ScheduledPlanLog> GetScheduledPlanLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search scheduledPlanLogs by filter

Returns the list of scheduledPlanLogs that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetScheduledPlanLogByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search scheduledPlanLogs by filter
                List&lt;ScheduledPlanLog&gt; result = apiInstance.GetScheduledPlanLogByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.GetScheduledPlanLogByFilter: " + e.Message );
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

[**List<ScheduledPlanLog>**](ScheduledPlanLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledplanlogbyid"></a>
# **GetScheduledPlanLogById**
> ScheduledPlanLog GetScheduledPlanLogById (int? scheduledPlanLogId)

Get a scheduledPlanLog by id

Returns the scheduledPlanLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetScheduledPlanLogByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to be returned.

            try
            {
                // Get a scheduledPlanLog by id
                ScheduledPlanLog result = apiInstance.GetScheduledPlanLogById(scheduledPlanLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.GetScheduledPlanLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to be returned. | 

### Return type

[**ScheduledPlanLog**](ScheduledPlanLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

