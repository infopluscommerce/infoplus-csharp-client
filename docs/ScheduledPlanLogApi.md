# Infoplus.Api.ScheduledPlanLogApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddScheduledPlanLogAudit**](ScheduledPlanLogApi.md#addscheduledplanlogaudit) | **PUT** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/audit/{scheduledPlanLogAudit} | Add new audit for a scheduledPlanLog
[**AddScheduledPlanLogFile**](ScheduledPlanLogApi.md#addscheduledplanlogfile) | **POST** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/file/{fileName} | Attach a file to a scheduledPlanLog
[**AddScheduledPlanLogFileByURL**](ScheduledPlanLogApi.md#addscheduledplanlogfilebyurl) | **POST** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/file | Attach a file to a scheduledPlanLog by URL.
[**AddScheduledPlanLogTag**](ScheduledPlanLogApi.md#addscheduledplanlogtag) | **PUT** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/tag/{scheduledPlanLogTag} | Add new tags for a scheduledPlanLog.
[**DeleteScheduledPlanLogFile**](ScheduledPlanLogApi.md#deletescheduledplanlogfile) | **DELETE** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/file/{fileId} | Delete a file for a scheduledPlanLog.
[**DeleteScheduledPlanLogTag**](ScheduledPlanLogApi.md#deletescheduledplanlogtag) | **DELETE** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/tag/{scheduledPlanLogTag} | Delete a tag for a scheduledPlanLog.
[**GetDuplicateScheduledPlanLogById**](ScheduledPlanLogApi.md#getduplicatescheduledplanlogbyid) | **GET** /v3.0/scheduledPlanLog/duplicate/{scheduledPlanLogId} | Get a duplicated a scheduledPlanLog by id
[**GetScheduledPlanLogByFilter**](ScheduledPlanLogApi.md#getscheduledplanlogbyfilter) | **GET** /v3.0/scheduledPlanLog/search | Search scheduledPlanLogs by filter
[**GetScheduledPlanLogById**](ScheduledPlanLogApi.md#getscheduledplanlogbyid) | **GET** /v3.0/scheduledPlanLog/{scheduledPlanLogId} | Get a scheduledPlanLog by id
[**GetScheduledPlanLogFiles**](ScheduledPlanLogApi.md#getscheduledplanlogfiles) | **GET** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/file | Get the files for a scheduledPlanLog.
[**GetScheduledPlanLogTags**](ScheduledPlanLogApi.md#getscheduledplanlogtags) | **GET** /v3.0/scheduledPlanLog/{scheduledPlanLogId}/tag | Get the tags for a scheduledPlanLog.


<a name="addscheduledplanlogaudit"></a>
# **AddScheduledPlanLogAudit**
> void AddScheduledPlanLogAudit (int? scheduledPlanLogId, string scheduledPlanLogAudit)

Add new audit for a scheduledPlanLog

Adds an audit to an existing scheduledPlanLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddScheduledPlanLogAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to add an audit to
            var scheduledPlanLogAudit = scheduledPlanLogAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a scheduledPlanLog
                apiInstance.AddScheduledPlanLogAudit(scheduledPlanLogId, scheduledPlanLogAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.AddScheduledPlanLogAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to add an audit to | 
 **scheduledPlanLogAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addscheduledplanlogfile"></a>
# **AddScheduledPlanLogFile**
> void AddScheduledPlanLogFile (int? scheduledPlanLogId, string fileName)

Attach a file to a scheduledPlanLog

Adds a file to an existing scheduledPlanLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddScheduledPlanLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a scheduledPlanLog
                apiInstance.AddScheduledPlanLogFile(scheduledPlanLogId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.AddScheduledPlanLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addscheduledplanlogfilebyurl"></a>
# **AddScheduledPlanLogFileByURL**
> void AddScheduledPlanLogFileByURL (RecordFile body, int? scheduledPlanLogId)

Attach a file to a scheduledPlanLog by URL.

Adds a file to an existing scheduledPlanLog by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddScheduledPlanLogFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to add an file to

            try
            {
                // Attach a file to a scheduledPlanLog by URL.
                apiInstance.AddScheduledPlanLogFileByURL(body, scheduledPlanLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.AddScheduledPlanLogFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addscheduledplanlogtag"></a>
# **AddScheduledPlanLogTag**
> void AddScheduledPlanLogTag (int? scheduledPlanLogId, string scheduledPlanLogTag)

Add new tags for a scheduledPlanLog.

Adds a tag to an existing scheduledPlanLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddScheduledPlanLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to add a tag to
            var scheduledPlanLogTag = scheduledPlanLogTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a scheduledPlanLog.
                apiInstance.AddScheduledPlanLogTag(scheduledPlanLogId, scheduledPlanLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.AddScheduledPlanLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to add a tag to | 
 **scheduledPlanLogTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescheduledplanlogfile"></a>
# **DeleteScheduledPlanLogFile**
> void DeleteScheduledPlanLogFile (int? scheduledPlanLogId, int? fileId)

Delete a file for a scheduledPlanLog.

Deletes an existing scheduledPlanLog file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteScheduledPlanLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a scheduledPlanLog.
                apiInstance.DeleteScheduledPlanLogFile(scheduledPlanLogId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.DeleteScheduledPlanLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescheduledplanlogtag"></a>
# **DeleteScheduledPlanLogTag**
> void DeleteScheduledPlanLogTag (int? scheduledPlanLogId, string scheduledPlanLogTag)

Delete a tag for a scheduledPlanLog.

Deletes an existing scheduledPlanLog tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteScheduledPlanLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to remove tag from
            var scheduledPlanLogTag = scheduledPlanLogTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a scheduledPlanLog.
                apiInstance.DeleteScheduledPlanLogTag(scheduledPlanLogId, scheduledPlanLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.DeleteScheduledPlanLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to remove tag from | 
 **scheduledPlanLogTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatescheduledplanlogbyid"></a>
# **GetDuplicateScheduledPlanLogById**
> ScheduledPlanLog GetDuplicateScheduledPlanLogById (int? scheduledPlanLogId)

Get a duplicated a scheduledPlanLog by id

Returns a duplicated scheduledPlanLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateScheduledPlanLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to be duplicated.

            try
            {
                // Get a duplicated a scheduledPlanLog by id
                ScheduledPlanLog result = apiInstance.GetDuplicateScheduledPlanLogById(scheduledPlanLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.GetDuplicateScheduledPlanLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to be duplicated. | 

### Return type

[**ScheduledPlanLog**](ScheduledPlanLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getscheduledplanlogfiles"></a>
# **GetScheduledPlanLogFiles**
> void GetScheduledPlanLogFiles (int? scheduledPlanLogId)

Get the files for a scheduledPlanLog.

Get all existing scheduledPlanLog files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetScheduledPlanLogFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to get files for

            try
            {
                // Get the files for a scheduledPlanLog.
                apiInstance.GetScheduledPlanLogFiles(scheduledPlanLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.GetScheduledPlanLogFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledplanlogtags"></a>
# **GetScheduledPlanLogTags**
> void GetScheduledPlanLogTags (int? scheduledPlanLogId)

Get the tags for a scheduledPlanLog.

Get all existing scheduledPlanLog tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetScheduledPlanLogTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ScheduledPlanLogApi();
            var scheduledPlanLogId = 56;  // int? | Id of the scheduledPlanLog to get tags for

            try
            {
                // Get the tags for a scheduledPlanLog.
                apiInstance.GetScheduledPlanLogTags(scheduledPlanLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduledPlanLogApi.GetScheduledPlanLogTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduledPlanLogId** | **int?**| Id of the scheduledPlanLog to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

