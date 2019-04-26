# Infoplus.Api.PerpetualInventoryLogApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPerpetualInventoryLogAudit**](PerpetualInventoryLogApi.md#addperpetualinventorylogaudit) | **PUT** /beta/perpetualInventoryLog/{perpetualInventoryLogId}/audit/{perpetualInventoryLogAudit} | Add new audit for a perpetualInventoryLog
[**AddPerpetualInventoryLogFile**](PerpetualInventoryLogApi.md#addperpetualinventorylogfile) | **POST** /beta/perpetualInventoryLog/{perpetualInventoryLogId}/file/{fileName} | Attach a file to a perpetualInventoryLog
[**AddPerpetualInventoryLogTag**](PerpetualInventoryLogApi.md#addperpetualinventorylogtag) | **PUT** /beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag/{perpetualInventoryLogTag} | Add new tags for a perpetualInventoryLog.
[**DeletePerpetualInventoryLogTag**](PerpetualInventoryLogApi.md#deleteperpetualinventorylogtag) | **DELETE** /beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag/{perpetualInventoryLogTag} | Delete a tag for a perpetualInventoryLog.
[**GetDuplicatePerpetualInventoryLogById**](PerpetualInventoryLogApi.md#getduplicateperpetualinventorylogbyid) | **GET** /beta/perpetualInventoryLog/duplicate/{perpetualInventoryLogId} | Get a duplicated a perpetualInventoryLog by id
[**GetPerpetualInventoryLogByFilter**](PerpetualInventoryLogApi.md#getperpetualinventorylogbyfilter) | **GET** /beta/perpetualInventoryLog/search | Search perpetualInventoryLogs by filter
[**GetPerpetualInventoryLogById**](PerpetualInventoryLogApi.md#getperpetualinventorylogbyid) | **GET** /beta/perpetualInventoryLog/{perpetualInventoryLogId} | Get a perpetualInventoryLog by id
[**GetPerpetualInventoryLogTags**](PerpetualInventoryLogApi.md#getperpetualinventorylogtags) | **GET** /beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag | Get the tags for a perpetualInventoryLog.


<a name="addperpetualinventorylogaudit"></a>
# **AddPerpetualInventoryLogAudit**
> void AddPerpetualInventoryLogAudit (int? perpetualInventoryLogId, string perpetualInventoryLogAudit)

Add new audit for a perpetualInventoryLog

Adds an audit to an existing perpetualInventoryLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPerpetualInventoryLogAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to add an audit to
            var perpetualInventoryLogAudit = perpetualInventoryLogAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a perpetualInventoryLog
                apiInstance.AddPerpetualInventoryLogAudit(perpetualInventoryLogId, perpetualInventoryLogAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.AddPerpetualInventoryLogAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to add an audit to | 
 **perpetualInventoryLogAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addperpetualinventorylogfile"></a>
# **AddPerpetualInventoryLogFile**
> void AddPerpetualInventoryLogFile (int? perpetualInventoryLogId, string fileName)

Attach a file to a perpetualInventoryLog

Adds a file to an existing perpetualInventoryLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPerpetualInventoryLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a perpetualInventoryLog
                apiInstance.AddPerpetualInventoryLogFile(perpetualInventoryLogId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.AddPerpetualInventoryLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addperpetualinventorylogtag"></a>
# **AddPerpetualInventoryLogTag**
> void AddPerpetualInventoryLogTag (int? perpetualInventoryLogId, string perpetualInventoryLogTag)

Add new tags for a perpetualInventoryLog.

Adds a tag to an existing perpetualInventoryLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPerpetualInventoryLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to add a tag to
            var perpetualInventoryLogTag = perpetualInventoryLogTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a perpetualInventoryLog.
                apiInstance.AddPerpetualInventoryLogTag(perpetualInventoryLogId, perpetualInventoryLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.AddPerpetualInventoryLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to add a tag to | 
 **perpetualInventoryLogTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteperpetualinventorylogtag"></a>
# **DeletePerpetualInventoryLogTag**
> void DeletePerpetualInventoryLogTag (int? perpetualInventoryLogId, string perpetualInventoryLogTag)

Delete a tag for a perpetualInventoryLog.

Deletes an existing perpetualInventoryLog tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePerpetualInventoryLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to remove tag from
            var perpetualInventoryLogTag = perpetualInventoryLogTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a perpetualInventoryLog.
                apiInstance.DeletePerpetualInventoryLogTag(perpetualInventoryLogId, perpetualInventoryLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.DeletePerpetualInventoryLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to remove tag from | 
 **perpetualInventoryLogTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateperpetualinventorylogbyid"></a>
# **GetDuplicatePerpetualInventoryLogById**
> PerpetualInventoryLog GetDuplicatePerpetualInventoryLogById (int? perpetualInventoryLogId)

Get a duplicated a perpetualInventoryLog by id

Returns a duplicated perpetualInventoryLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicatePerpetualInventoryLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to be duplicated.

            try
            {
                // Get a duplicated a perpetualInventoryLog by id
                PerpetualInventoryLog result = apiInstance.GetDuplicatePerpetualInventoryLogById(perpetualInventoryLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.GetDuplicatePerpetualInventoryLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to be duplicated. | 

### Return type

[**PerpetualInventoryLog**](PerpetualInventoryLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getperpetualinventorylogbyfilter"></a>
# **GetPerpetualInventoryLogByFilter**
> List<PerpetualInventoryLog> GetPerpetualInventoryLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search perpetualInventoryLogs by filter

Returns the list of perpetualInventoryLogs that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPerpetualInventoryLogByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search perpetualInventoryLogs by filter
                List&lt;PerpetualInventoryLog&gt; result = apiInstance.GetPerpetualInventoryLogByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.GetPerpetualInventoryLogByFilter: " + e.Message );
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

[**List<PerpetualInventoryLog>**](PerpetualInventoryLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getperpetualinventorylogbyid"></a>
# **GetPerpetualInventoryLogById**
> PerpetualInventoryLog GetPerpetualInventoryLogById (int? perpetualInventoryLogId)

Get a perpetualInventoryLog by id

Returns the perpetualInventoryLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPerpetualInventoryLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to be returned.

            try
            {
                // Get a perpetualInventoryLog by id
                PerpetualInventoryLog result = apiInstance.GetPerpetualInventoryLogById(perpetualInventoryLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.GetPerpetualInventoryLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to be returned. | 

### Return type

[**PerpetualInventoryLog**](PerpetualInventoryLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getperpetualinventorylogtags"></a>
# **GetPerpetualInventoryLogTags**
> void GetPerpetualInventoryLogTags (int? perpetualInventoryLogId)

Get the tags for a perpetualInventoryLog.

Get all existing perpetualInventoryLog tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPerpetualInventoryLogTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PerpetualInventoryLogApi();
            var perpetualInventoryLogId = 56;  // int? | Id of the perpetualInventoryLog to get tags for

            try
            {
                // Get the tags for a perpetualInventoryLog.
                apiInstance.GetPerpetualInventoryLogTags(perpetualInventoryLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PerpetualInventoryLogApi.GetPerpetualInventoryLogTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perpetualInventoryLogId** | **int?**| Id of the perpetualInventoryLog to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

