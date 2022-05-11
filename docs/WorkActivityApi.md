# Infoplus.Api.WorkActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWorkActivity**](WorkActivityApi.md#addworkactivity) | **POST** /v3.0/workActivity | Create a workActivity
[**AddWorkActivityAudit**](WorkActivityApi.md#addworkactivityaudit) | **PUT** /v3.0/workActivity/{workActivityId}/audit/{workActivityAudit} | Add new audit for a workActivity
[**AddWorkActivityFile**](WorkActivityApi.md#addworkactivityfile) | **POST** /v3.0/workActivity/{workActivityId}/file/{fileName} | Attach a file to a workActivity
[**AddWorkActivityFileByURL**](WorkActivityApi.md#addworkactivityfilebyurl) | **POST** /v3.0/workActivity/{workActivityId}/file | Attach a file to a workActivity by URL.
[**AddWorkActivityTag**](WorkActivityApi.md#addworkactivitytag) | **PUT** /v3.0/workActivity/{workActivityId}/tag/{workActivityTag} | Add new tags for a workActivity.
[**DeleteWorkActivity**](WorkActivityApi.md#deleteworkactivity) | **DELETE** /v3.0/workActivity/{workActivityId} | Delete a workActivity
[**DeleteWorkActivityFile**](WorkActivityApi.md#deleteworkactivityfile) | **DELETE** /v3.0/workActivity/{workActivityId}/file/{fileId} | Delete a file for a workActivity.
[**DeleteWorkActivityTag**](WorkActivityApi.md#deleteworkactivitytag) | **DELETE** /v3.0/workActivity/{workActivityId}/tag/{workActivityTag} | Delete a tag for a workActivity.
[**GetDuplicateWorkActivityById**](WorkActivityApi.md#getduplicateworkactivitybyid) | **GET** /v3.0/workActivity/duplicate/{workActivityId} | Get a duplicated a workActivity by id
[**GetWorkActivityByFilter**](WorkActivityApi.md#getworkactivitybyfilter) | **GET** /v3.0/workActivity/search | Search workActivitys by filter
[**GetWorkActivityById**](WorkActivityApi.md#getworkactivitybyid) | **GET** /v3.0/workActivity/{workActivityId} | Get a workActivity by id
[**GetWorkActivityFiles**](WorkActivityApi.md#getworkactivityfiles) | **GET** /v3.0/workActivity/{workActivityId}/file | Get the files for a workActivity.
[**GetWorkActivityTags**](WorkActivityApi.md#getworkactivitytags) | **GET** /v3.0/workActivity/{workActivityId}/tag | Get the tags for a workActivity.
[**UpdateWorkActivity**](WorkActivityApi.md#updateworkactivity) | **PUT** /v3.0/workActivity | Update a workActivity


<a name="addworkactivity"></a>
# **AddWorkActivity**
> WorkActivity AddWorkActivity (WorkActivity body)

Create a workActivity

Inserts a new workActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var body = new WorkActivity(); // WorkActivity | WorkActivity to be inserted.

            try
            {
                // Create a workActivity
                WorkActivity result = apiInstance.AddWorkActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.AddWorkActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkActivity**](WorkActivity.md)| WorkActivity to be inserted. | 

### Return type

[**WorkActivity**](WorkActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworkactivityaudit"></a>
# **AddWorkActivityAudit**
> void AddWorkActivityAudit (int? workActivityId, string workActivityAudit)

Add new audit for a workActivity

Adds an audit to an existing workActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to add an audit to
            var workActivityAudit = workActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a workActivity
                apiInstance.AddWorkActivityAudit(workActivityId, workActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.AddWorkActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to add an audit to | 
 **workActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworkactivityfile"></a>
# **AddWorkActivityFile**
> void AddWorkActivityFile (int? workActivityId, string fileName)

Attach a file to a workActivity

Adds a file to an existing workActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a workActivity
                apiInstance.AddWorkActivityFile(workActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.AddWorkActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworkactivityfilebyurl"></a>
# **AddWorkActivityFileByURL**
> void AddWorkActivityFileByURL (RecordFile body, int? workActivityId)

Attach a file to a workActivity by URL.

Adds a file to an existing workActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var workActivityId = 56;  // int? | Id of the workActivity to add an file to

            try
            {
                // Attach a file to a workActivity by URL.
                apiInstance.AddWorkActivityFileByURL(body, workActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.AddWorkActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **workActivityId** | **int?**| Id of the workActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworkactivitytag"></a>
# **AddWorkActivityTag**
> void AddWorkActivityTag (int? workActivityId, string workActivityTag)

Add new tags for a workActivity.

Adds a tag to an existing workActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to add a tag to
            var workActivityTag = workActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a workActivity.
                apiInstance.AddWorkActivityTag(workActivityId, workActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.AddWorkActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to add a tag to | 
 **workActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkactivity"></a>
# **DeleteWorkActivity**
> void DeleteWorkActivity (int? workActivityId)

Delete a workActivity

Deletes the workActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWorkActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to be deleted.

            try
            {
                // Delete a workActivity
                apiInstance.DeleteWorkActivity(workActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.DeleteWorkActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkactivityfile"></a>
# **DeleteWorkActivityFile**
> void DeleteWorkActivityFile (int? workActivityId, int? fileId)

Delete a file for a workActivity.

Deletes an existing workActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWorkActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a workActivity.
                apiInstance.DeleteWorkActivityFile(workActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.DeleteWorkActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkactivitytag"></a>
# **DeleteWorkActivityTag**
> void DeleteWorkActivityTag (int? workActivityId, string workActivityTag)

Delete a tag for a workActivity.

Deletes an existing workActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWorkActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to remove tag from
            var workActivityTag = workActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a workActivity.
                apiInstance.DeleteWorkActivityTag(workActivityId, workActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.DeleteWorkActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to remove tag from | 
 **workActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateworkactivitybyid"></a>
# **GetDuplicateWorkActivityById**
> WorkActivity GetDuplicateWorkActivityById (int? workActivityId)

Get a duplicated a workActivity by id

Returns a duplicated workActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWorkActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to be duplicated.

            try
            {
                // Get a duplicated a workActivity by id
                WorkActivity result = apiInstance.GetDuplicateWorkActivityById(workActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.GetDuplicateWorkActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to be duplicated. | 

### Return type

[**WorkActivity**](WorkActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkactivitybyfilter"></a>
# **GetWorkActivityByFilter**
> List<WorkActivity> GetWorkActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search workActivitys by filter

Returns the list of workActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search workActivitys by filter
                List&lt;WorkActivity&gt; result = apiInstance.GetWorkActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.GetWorkActivityByFilter: " + e.Message );
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

[**List<WorkActivity>**](WorkActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkactivitybyid"></a>
# **GetWorkActivityById**
> WorkActivity GetWorkActivityById (int? workActivityId)

Get a workActivity by id

Returns the workActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to be returned.

            try
            {
                // Get a workActivity by id
                WorkActivity result = apiInstance.GetWorkActivityById(workActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.GetWorkActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to be returned. | 

### Return type

[**WorkActivity**](WorkActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkactivityfiles"></a>
# **GetWorkActivityFiles**
> void GetWorkActivityFiles (int? workActivityId)

Get the files for a workActivity.

Get all existing workActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to get files for

            try
            {
                // Get the files for a workActivity.
                apiInstance.GetWorkActivityFiles(workActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.GetWorkActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkactivitytags"></a>
# **GetWorkActivityTags**
> void GetWorkActivityTags (int? workActivityId)

Get the tags for a workActivity.

Get all existing workActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var workActivityId = 56;  // int? | Id of the workActivity to get tags for

            try
            {
                // Get the tags for a workActivity.
                apiInstance.GetWorkActivityTags(workActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.GetWorkActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workActivityId** | **int?**| Id of the workActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkactivity"></a>
# **UpdateWorkActivity**
> void UpdateWorkActivity (WorkActivity body)

Update a workActivity

Updates an existing workActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWorkActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkActivityApi();
            var body = new WorkActivity(); // WorkActivity | WorkActivity to be updated.

            try
            {
                // Update a workActivity
                apiInstance.UpdateWorkActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkActivityApi.UpdateWorkActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkActivity**](WorkActivity.md)| WorkActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

