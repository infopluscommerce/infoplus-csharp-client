# Infoplus.Api.LoggedTimeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLoggedTimeAudit**](LoggedTimeApi.md#addloggedtimeaudit) | **PUT** /beta/loggedTime/{loggedTimeId}/audit/{loggedTimeAudit} | Add new audit for a loggedTime
[**AddLoggedTimeTag**](LoggedTimeApi.md#addloggedtimetag) | **PUT** /beta/loggedTime/{loggedTimeId}/tag/{loggedTimeTag} | Add new tags for a loggedTime.
[**DeleteLoggedTimeTag**](LoggedTimeApi.md#deleteloggedtimetag) | **DELETE** /beta/loggedTime/{loggedTimeId}/tag/{loggedTimeTag} | Delete a tag for a loggedTime.
[**GetDuplicateLoggedTimeById**](LoggedTimeApi.md#getduplicateloggedtimebyid) | **GET** /beta/loggedTime/duplicate/{loggedTimeId} | Get a duplicated a loggedTime by id
[**GetLoggedTimeByFilter**](LoggedTimeApi.md#getloggedtimebyfilter) | **GET** /beta/loggedTime/search | Search loggedTimes by filter
[**GetLoggedTimeById**](LoggedTimeApi.md#getloggedtimebyid) | **GET** /beta/loggedTime/{loggedTimeId} | Get a loggedTime by id
[**GetLoggedTimeTags**](LoggedTimeApi.md#getloggedtimetags) | **GET** /beta/loggedTime/{loggedTimeId}/tag | Get the tags for a loggedTime.
[**UpdateLoggedTimeCustomFields**](LoggedTimeApi.md#updateloggedtimecustomfields) | **PUT** /beta/loggedTime/customFields | Update a loggedTime custom fields


<a name="addloggedtimeaudit"></a>
# **AddLoggedTimeAudit**
> void AddLoggedTimeAudit (int? loggedTimeId, string loggedTimeAudit)

Add new audit for a loggedTime

Adds an audit to an existing loggedTime.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoggedTimeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var loggedTimeId = 56;  // int? | Id of the loggedTime to add an audit to
            var loggedTimeAudit = loggedTimeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a loggedTime
                apiInstance.AddLoggedTimeAudit(loggedTimeId, loggedTimeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.AddLoggedTimeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeId** | **int?**| Id of the loggedTime to add an audit to | 
 **loggedTimeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloggedtimetag"></a>
# **AddLoggedTimeTag**
> void AddLoggedTimeTag (int? loggedTimeId, string loggedTimeTag)

Add new tags for a loggedTime.

Adds a tag to an existing loggedTime.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoggedTimeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var loggedTimeId = 56;  // int? | Id of the loggedTime to add a tag to
            var loggedTimeTag = loggedTimeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a loggedTime.
                apiInstance.AddLoggedTimeTag(loggedTimeId, loggedTimeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.AddLoggedTimeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeId** | **int?**| Id of the loggedTime to add a tag to | 
 **loggedTimeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloggedtimetag"></a>
# **DeleteLoggedTimeTag**
> void DeleteLoggedTimeTag (int? loggedTimeId, string loggedTimeTag)

Delete a tag for a loggedTime.

Deletes an existing loggedTime tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLoggedTimeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var loggedTimeId = 56;  // int? | Id of the loggedTime to remove tag from
            var loggedTimeTag = loggedTimeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a loggedTime.
                apiInstance.DeleteLoggedTimeTag(loggedTimeId, loggedTimeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.DeleteLoggedTimeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeId** | **int?**| Id of the loggedTime to remove tag from | 
 **loggedTimeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateloggedtimebyid"></a>
# **GetDuplicateLoggedTimeById**
> LoggedTime GetDuplicateLoggedTimeById (int? loggedTimeId)

Get a duplicated a loggedTime by id

Returns a duplicated loggedTime identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLoggedTimeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var loggedTimeId = 56;  // int? | Id of the loggedTime to be duplicated.

            try
            {
                // Get a duplicated a loggedTime by id
                LoggedTime result = apiInstance.GetDuplicateLoggedTimeById(loggedTimeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.GetDuplicateLoggedTimeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeId** | **int?**| Id of the loggedTime to be duplicated. | 

### Return type

[**LoggedTime**](LoggedTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getloggedtimetags"></a>
# **GetLoggedTimeTags**
> void GetLoggedTimeTags (int? loggedTimeId)

Get the tags for a loggedTime.

Get all existing loggedTime tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoggedTimeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeApi();
            var loggedTimeId = 56;  // int? | Id of the loggedTime to get tags for

            try
            {
                // Get the tags for a loggedTime.
                apiInstance.GetLoggedTimeTags(loggedTimeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeApi.GetLoggedTimeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeId** | **int?**| Id of the loggedTime to get tags for | 

### Return type

void (empty response body)

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

