# Infoplus.Api.FinanceSystemConnectionLogApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFinanceSystemConnectionLogAudit**](FinanceSystemConnectionLogApi.md#addfinancesystemconnectionlogaudit) | **PUT** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/audit/{financeSystemConnectionLogAudit} | Add new audit for a financeSystemConnectionLog
[**AddFinanceSystemConnectionLogFile**](FinanceSystemConnectionLogApi.md#addfinancesystemconnectionlogfile) | **POST** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/file/{fileName} | Attach a file to a financeSystemConnectionLog
[**AddFinanceSystemConnectionLogFileByURL**](FinanceSystemConnectionLogApi.md#addfinancesystemconnectionlogfilebyurl) | **POST** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/file | Attach a file to a financeSystemConnectionLog by URL.
[**AddFinanceSystemConnectionLogTag**](FinanceSystemConnectionLogApi.md#addfinancesystemconnectionlogtag) | **PUT** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/tag/{financeSystemConnectionLogTag} | Add new tags for a financeSystemConnectionLog.
[**DeleteFinanceSystemConnectionLogFile**](FinanceSystemConnectionLogApi.md#deletefinancesystemconnectionlogfile) | **DELETE** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/file/{fileId} | Delete a file for a financeSystemConnectionLog.
[**DeleteFinanceSystemConnectionLogTag**](FinanceSystemConnectionLogApi.md#deletefinancesystemconnectionlogtag) | **DELETE** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/tag/{financeSystemConnectionLogTag} | Delete a tag for a financeSystemConnectionLog.
[**GetDuplicateFinanceSystemConnectionLogById**](FinanceSystemConnectionLogApi.md#getduplicatefinancesystemconnectionlogbyid) | **GET** /v3.0/financeSystemConnectionLog/duplicate/{financeSystemConnectionLogId} | Get a duplicated a financeSystemConnectionLog by id
[**GetFinanceSystemConnectionLogByFilter**](FinanceSystemConnectionLogApi.md#getfinancesystemconnectionlogbyfilter) | **GET** /v3.0/financeSystemConnectionLog/search | Search financeSystemConnectionLogs by filter
[**GetFinanceSystemConnectionLogById**](FinanceSystemConnectionLogApi.md#getfinancesystemconnectionlogbyid) | **GET** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId} | Get a financeSystemConnectionLog by id
[**GetFinanceSystemConnectionLogFiles**](FinanceSystemConnectionLogApi.md#getfinancesystemconnectionlogfiles) | **GET** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/file | Get the files for a financeSystemConnectionLog.
[**GetFinanceSystemConnectionLogTags**](FinanceSystemConnectionLogApi.md#getfinancesystemconnectionlogtags) | **GET** /v3.0/financeSystemConnectionLog/{financeSystemConnectionLogId}/tag | Get the tags for a financeSystemConnectionLog.


<a name="addfinancesystemconnectionlogaudit"></a>
# **AddFinanceSystemConnectionLogAudit**
> void AddFinanceSystemConnectionLogAudit (int? financeSystemConnectionLogId, string financeSystemConnectionLogAudit)

Add new audit for a financeSystemConnectionLog

Adds an audit to an existing financeSystemConnectionLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionLogAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to add an audit to
            var financeSystemConnectionLogAudit = financeSystemConnectionLogAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a financeSystemConnectionLog
                apiInstance.AddFinanceSystemConnectionLogAudit(financeSystemConnectionLogId, financeSystemConnectionLogAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.AddFinanceSystemConnectionLogAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to add an audit to | 
 **financeSystemConnectionLogAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfinancesystemconnectionlogfile"></a>
# **AddFinanceSystemConnectionLogFile**
> void AddFinanceSystemConnectionLogFile (int? financeSystemConnectionLogId, string fileName)

Attach a file to a financeSystemConnectionLog

Adds a file to an existing financeSystemConnectionLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a financeSystemConnectionLog
                apiInstance.AddFinanceSystemConnectionLogFile(financeSystemConnectionLogId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.AddFinanceSystemConnectionLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfinancesystemconnectionlogfilebyurl"></a>
# **AddFinanceSystemConnectionLogFileByURL**
> void AddFinanceSystemConnectionLogFileByURL (RecordFile body, int? financeSystemConnectionLogId)

Attach a file to a financeSystemConnectionLog by URL.

Adds a file to an existing financeSystemConnectionLog by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionLogFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to add an file to

            try
            {
                // Attach a file to a financeSystemConnectionLog by URL.
                apiInstance.AddFinanceSystemConnectionLogFileByURL(body, financeSystemConnectionLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.AddFinanceSystemConnectionLogFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfinancesystemconnectionlogtag"></a>
# **AddFinanceSystemConnectionLogTag**
> void AddFinanceSystemConnectionLogTag (int? financeSystemConnectionLogId, string financeSystemConnectionLogTag)

Add new tags for a financeSystemConnectionLog.

Adds a tag to an existing financeSystemConnectionLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to add a tag to
            var financeSystemConnectionLogTag = financeSystemConnectionLogTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a financeSystemConnectionLog.
                apiInstance.AddFinanceSystemConnectionLogTag(financeSystemConnectionLogId, financeSystemConnectionLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.AddFinanceSystemConnectionLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to add a tag to | 
 **financeSystemConnectionLogTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefinancesystemconnectionlogfile"></a>
# **DeleteFinanceSystemConnectionLogFile**
> void DeleteFinanceSystemConnectionLogFile (int? financeSystemConnectionLogId, int? fileId)

Delete a file for a financeSystemConnectionLog.

Deletes an existing financeSystemConnectionLog file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFinanceSystemConnectionLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a financeSystemConnectionLog.
                apiInstance.DeleteFinanceSystemConnectionLogFile(financeSystemConnectionLogId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.DeleteFinanceSystemConnectionLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefinancesystemconnectionlogtag"></a>
# **DeleteFinanceSystemConnectionLogTag**
> void DeleteFinanceSystemConnectionLogTag (int? financeSystemConnectionLogId, string financeSystemConnectionLogTag)

Delete a tag for a financeSystemConnectionLog.

Deletes an existing financeSystemConnectionLog tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFinanceSystemConnectionLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to remove tag from
            var financeSystemConnectionLogTag = financeSystemConnectionLogTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a financeSystemConnectionLog.
                apiInstance.DeleteFinanceSystemConnectionLogTag(financeSystemConnectionLogId, financeSystemConnectionLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.DeleteFinanceSystemConnectionLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to remove tag from | 
 **financeSystemConnectionLogTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatefinancesystemconnectionlogbyid"></a>
# **GetDuplicateFinanceSystemConnectionLogById**
> FinanceSystemConnectionLog GetDuplicateFinanceSystemConnectionLogById (int? financeSystemConnectionLogId)

Get a duplicated a financeSystemConnectionLog by id

Returns a duplicated financeSystemConnectionLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateFinanceSystemConnectionLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to be duplicated.

            try
            {
                // Get a duplicated a financeSystemConnectionLog by id
                FinanceSystemConnectionLog result = apiInstance.GetDuplicateFinanceSystemConnectionLogById(financeSystemConnectionLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.GetDuplicateFinanceSystemConnectionLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to be duplicated. | 

### Return type

[**FinanceSystemConnectionLog**](FinanceSystemConnectionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectionlogbyfilter"></a>
# **GetFinanceSystemConnectionLogByFilter**
> List<FinanceSystemConnectionLog> GetFinanceSystemConnectionLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search financeSystemConnectionLogs by filter

Returns the list of financeSystemConnectionLogs that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionLogByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search financeSystemConnectionLogs by filter
                List&lt;FinanceSystemConnectionLog&gt; result = apiInstance.GetFinanceSystemConnectionLogByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.GetFinanceSystemConnectionLogByFilter: " + e.Message );
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

[**List<FinanceSystemConnectionLog>**](FinanceSystemConnectionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectionlogbyid"></a>
# **GetFinanceSystemConnectionLogById**
> FinanceSystemConnectionLog GetFinanceSystemConnectionLogById (int? financeSystemConnectionLogId)

Get a financeSystemConnectionLog by id

Returns the financeSystemConnectionLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to be returned.

            try
            {
                // Get a financeSystemConnectionLog by id
                FinanceSystemConnectionLog result = apiInstance.GetFinanceSystemConnectionLogById(financeSystemConnectionLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.GetFinanceSystemConnectionLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to be returned. | 

### Return type

[**FinanceSystemConnectionLog**](FinanceSystemConnectionLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectionlogfiles"></a>
# **GetFinanceSystemConnectionLogFiles**
> void GetFinanceSystemConnectionLogFiles (int? financeSystemConnectionLogId)

Get the files for a financeSystemConnectionLog.

Get all existing financeSystemConnectionLog files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionLogFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to get files for

            try
            {
                // Get the files for a financeSystemConnectionLog.
                apiInstance.GetFinanceSystemConnectionLogFiles(financeSystemConnectionLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.GetFinanceSystemConnectionLogFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectionlogtags"></a>
# **GetFinanceSystemConnectionLogTags**
> void GetFinanceSystemConnectionLogTags (int? financeSystemConnectionLogId)

Get the tags for a financeSystemConnectionLog.

Get all existing financeSystemConnectionLog tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionLogTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionLogApi();
            var financeSystemConnectionLogId = 56;  // int? | Id of the financeSystemConnectionLog to get tags for

            try
            {
                // Get the tags for a financeSystemConnectionLog.
                apiInstance.GetFinanceSystemConnectionLogTags(financeSystemConnectionLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionLogApi.GetFinanceSystemConnectionLogTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionLogId** | **int?**| Id of the financeSystemConnectionLog to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

