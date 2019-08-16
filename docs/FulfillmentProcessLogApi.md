# Infoplus.Api.FulfillmentProcessLogApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentProcessLogAudit**](FulfillmentProcessLogApi.md#addfulfillmentprocesslogaudit) | **PUT** /beta/fulfillmentProcessLog/{fulfillmentProcessLogId}/audit/{fulfillmentProcessLogAudit} | Add new audit for a fulfillmentProcessLog
[**AddFulfillmentProcessLogFile**](FulfillmentProcessLogApi.md#addfulfillmentprocesslogfile) | **POST** /beta/fulfillmentProcessLog/{fulfillmentProcessLogId}/file/{fileName} | Attach a file to a fulfillmentProcessLog
[**AddFulfillmentProcessLogTag**](FulfillmentProcessLogApi.md#addfulfillmentprocesslogtag) | **PUT** /beta/fulfillmentProcessLog/{fulfillmentProcessLogId}/tag/{fulfillmentProcessLogTag} | Add new tags for a fulfillmentProcessLog.
[**DeleteFulfillmentProcessLogTag**](FulfillmentProcessLogApi.md#deletefulfillmentprocesslogtag) | **DELETE** /beta/fulfillmentProcessLog/{fulfillmentProcessLogId}/tag/{fulfillmentProcessLogTag} | Delete a tag for a fulfillmentProcessLog.
[**GetDuplicateFulfillmentProcessLogById**](FulfillmentProcessLogApi.md#getduplicatefulfillmentprocesslogbyid) | **GET** /beta/fulfillmentProcessLog/duplicate/{fulfillmentProcessLogId} | Get a duplicated a fulfillmentProcessLog by id
[**GetFulfillmentProcessLogByFilter**](FulfillmentProcessLogApi.md#getfulfillmentprocesslogbyfilter) | **GET** /beta/fulfillmentProcessLog/search | Search fulfillmentProcessLogs by filter
[**GetFulfillmentProcessLogById**](FulfillmentProcessLogApi.md#getfulfillmentprocesslogbyid) | **GET** /beta/fulfillmentProcessLog/{fulfillmentProcessLogId} | Get a fulfillmentProcessLog by id
[**GetFulfillmentProcessLogTags**](FulfillmentProcessLogApi.md#getfulfillmentprocesslogtags) | **GET** /beta/fulfillmentProcessLog/{fulfillmentProcessLogId}/tag | Get the tags for a fulfillmentProcessLog.


<a name="addfulfillmentprocesslogaudit"></a>
# **AddFulfillmentProcessLogAudit**
> void AddFulfillmentProcessLogAudit (int? fulfillmentProcessLogId, string fulfillmentProcessLogAudit)

Add new audit for a fulfillmentProcessLog

Adds an audit to an existing fulfillmentProcessLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessLogAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to add an audit to
            var fulfillmentProcessLogAudit = fulfillmentProcessLogAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a fulfillmentProcessLog
                apiInstance.AddFulfillmentProcessLogAudit(fulfillmentProcessLogId, fulfillmentProcessLogAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.AddFulfillmentProcessLogAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to add an audit to | 
 **fulfillmentProcessLogAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentprocesslogfile"></a>
# **AddFulfillmentProcessLogFile**
> void AddFulfillmentProcessLogFile (int? fulfillmentProcessLogId, string fileName)

Attach a file to a fulfillmentProcessLog

Adds a file to an existing fulfillmentProcessLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a fulfillmentProcessLog
                apiInstance.AddFulfillmentProcessLogFile(fulfillmentProcessLogId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.AddFulfillmentProcessLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentprocesslogtag"></a>
# **AddFulfillmentProcessLogTag**
> void AddFulfillmentProcessLogTag (int? fulfillmentProcessLogId, string fulfillmentProcessLogTag)

Add new tags for a fulfillmentProcessLog.

Adds a tag to an existing fulfillmentProcessLog.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to add a tag to
            var fulfillmentProcessLogTag = fulfillmentProcessLogTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a fulfillmentProcessLog.
                apiInstance.AddFulfillmentProcessLogTag(fulfillmentProcessLogId, fulfillmentProcessLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.AddFulfillmentProcessLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to add a tag to | 
 **fulfillmentProcessLogTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentprocesslogtag"></a>
# **DeleteFulfillmentProcessLogTag**
> void DeleteFulfillmentProcessLogTag (int? fulfillmentProcessLogId, string fulfillmentProcessLogTag)

Delete a tag for a fulfillmentProcessLog.

Deletes an existing fulfillmentProcessLog tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentProcessLogTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to remove tag from
            var fulfillmentProcessLogTag = fulfillmentProcessLogTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a fulfillmentProcessLog.
                apiInstance.DeleteFulfillmentProcessLogTag(fulfillmentProcessLogId, fulfillmentProcessLogTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.DeleteFulfillmentProcessLogTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to remove tag from | 
 **fulfillmentProcessLogTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatefulfillmentprocesslogbyid"></a>
# **GetDuplicateFulfillmentProcessLogById**
> FulfillmentProcessLog GetDuplicateFulfillmentProcessLogById (int? fulfillmentProcessLogId)

Get a duplicated a fulfillmentProcessLog by id

Returns a duplicated fulfillmentProcessLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateFulfillmentProcessLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to be duplicated.

            try
            {
                // Get a duplicated a fulfillmentProcessLog by id
                FulfillmentProcessLog result = apiInstance.GetDuplicateFulfillmentProcessLogById(fulfillmentProcessLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.GetDuplicateFulfillmentProcessLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to be duplicated. | 

### Return type

[**FulfillmentProcessLog**](FulfillmentProcessLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocesslogbyfilter"></a>
# **GetFulfillmentProcessLogByFilter**
> List<FulfillmentProcessLog> GetFulfillmentProcessLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search fulfillmentProcessLogs by filter

Returns the list of fulfillmentProcessLogs that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessLogByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search fulfillmentProcessLogs by filter
                List&lt;FulfillmentProcessLog&gt; result = apiInstance.GetFulfillmentProcessLogByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.GetFulfillmentProcessLogByFilter: " + e.Message );
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

[**List<FulfillmentProcessLog>**](FulfillmentProcessLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocesslogbyid"></a>
# **GetFulfillmentProcessLogById**
> FulfillmentProcessLog GetFulfillmentProcessLogById (int? fulfillmentProcessLogId)

Get a fulfillmentProcessLog by id

Returns the fulfillmentProcessLog identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessLogByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to be returned.

            try
            {
                // Get a fulfillmentProcessLog by id
                FulfillmentProcessLog result = apiInstance.GetFulfillmentProcessLogById(fulfillmentProcessLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.GetFulfillmentProcessLogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to be returned. | 

### Return type

[**FulfillmentProcessLog**](FulfillmentProcessLog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocesslogtags"></a>
# **GetFulfillmentProcessLogTags**
> void GetFulfillmentProcessLogTags (int? fulfillmentProcessLogId)

Get the tags for a fulfillmentProcessLog.

Get all existing fulfillmentProcessLog tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessLogTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessLogApi();
            var fulfillmentProcessLogId = 56;  // int? | Id of the fulfillmentProcessLog to get tags for

            try
            {
                // Get the tags for a fulfillmentProcessLog.
                apiInstance.GetFulfillmentProcessLogTags(fulfillmentProcessLogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessLogApi.GetFulfillmentProcessLogTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessLogId** | **int?**| Id of the fulfillmentProcessLog to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

