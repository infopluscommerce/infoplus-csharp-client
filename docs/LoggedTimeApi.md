# Infoplus.Api.LoggedTimeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoggedTimeByFilter**](LoggedTimeApi.md#getloggedtimebyfilter) | **GET** /beta/loggedTime/search | Search loggedTimes by filter
[**GetLoggedTimeById**](LoggedTimeApi.md#getloggedtimebyid) | **GET** /beta/loggedTime/{loggedTimeId} | Get a loggedTime by id
[**UpdateLoggedTimeCustomFields**](LoggedTimeApi.md#updateloggedtimecustomfields) | **PUT** /beta/loggedTime/customFields | Update a loggedTime custom fields


<a name="getloggedtimebyfilter"></a>
# **GetLoggedTimeByFilter**
> List<LoggedTime> GetLoggedTimeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search loggedTimes by filter

Returns the list of loggedTimes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoggedTimeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search loggedTimes by filter
                List&lt;LoggedTime&gt; result = apiInstance.GetLoggedTimeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.GetLoggedTimeByFilter: " + e.Message );
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

[**List<LoggedTime>**](LoggedTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloggedtimebyid"></a>
# **GetLoggedTimeById**
> LoggedTime GetLoggedTimeById (int? loggedTimeId)

Get a loggedTime by id

Returns the loggedTime identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoggedTimeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var loggedTimeId = 56;  // int? | Id of the loggedTime to be returned.

            try
            {
                // Get a loggedTime by id
                LoggedTime result = apiInstance.GetLoggedTimeById(loggedTimeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.GetLoggedTimeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeId** | **int?**| Id of the loggedTime to be returned. | 

### Return type

[**LoggedTime**](LoggedTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloggedtimecustomfields"></a>
# **UpdateLoggedTimeCustomFields**
> void UpdateLoggedTimeCustomFields (LoggedTime body)

Update a loggedTime custom fields

Updates an existing loggedTime custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLoggedTimeCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var body = new LoggedTime(); // LoggedTime | LoggedTime to be updated.

            try
            {
                // Update a loggedTime custom fields
                apiInstance.UpdateLoggedTimeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.UpdateLoggedTimeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoggedTime**](LoggedTime.md)| LoggedTime to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

