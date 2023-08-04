# Infoplus.Api.WorkApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWorkAudit**](WorkApi.md#addworkaudit) | **PUT** /beta/work/{workId}/audit/{workAudit} | Add new audit for a work
[**AddWorkFile**](WorkApi.md#addworkfile) | **POST** /beta/work/{workId}/file/{fileName} | Attach a file to a work
[**AddWorkFileByURL**](WorkApi.md#addworkfilebyurl) | **POST** /beta/work/{workId}/file | Attach a file to a work by URL.
[**AddWorkTag**](WorkApi.md#addworktag) | **PUT** /beta/work/{workId}/tag/{workTag} | Add new tags for a work.
[**DeleteWorkFile**](WorkApi.md#deleteworkfile) | **DELETE** /beta/work/{workId}/file/{fileId} | Delete a file for a work.
[**DeleteWorkTag**](WorkApi.md#deleteworktag) | **DELETE** /beta/work/{workId}/tag/{workTag} | Delete a tag for a work.
[**GetDuplicateWorkById**](WorkApi.md#getduplicateworkbyid) | **GET** /beta/work/duplicate/{workId} | Get a duplicated a work by id
[**GetWorkByFilter**](WorkApi.md#getworkbyfilter) | **GET** /beta/work/search | Search works by filter
[**GetWorkById**](WorkApi.md#getworkbyid) | **GET** /beta/work/{workId} | Get a work by id
[**GetWorkFiles**](WorkApi.md#getworkfiles) | **GET** /beta/work/{workId}/file | Get the files for a work.
[**GetWorkTags**](WorkApi.md#getworktags) | **GET** /beta/work/{workId}/tag | Get the tags for a work.
[**UpdateWork**](WorkApi.md#updatework) | **PUT** /beta/work | Update a work
[**UpdateWorkCustomFields**](WorkApi.md#updateworkcustomfields) | **PUT** /beta/work/customFields | Update a work custom fields


<a name="addworkaudit"></a>
# **AddWorkAudit**
> void AddWorkAudit (int? workId, string workAudit)

Add new audit for a work

Adds an audit to an existing work.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to add an audit to
            var workAudit = workAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a work
                apiInstance.AddWorkAudit(workId, workAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.AddWorkAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to add an audit to | 
 **workAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworkfile"></a>
# **AddWorkFile**
> void AddWorkFile (int? workId, string fileName)

Attach a file to a work

Adds a file to an existing work.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a work
                apiInstance.AddWorkFile(workId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.AddWorkFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworkfilebyurl"></a>
# **AddWorkFileByURL**
> void AddWorkFileByURL (RecordFile body, int? workId)

Attach a file to a work by URL.

Adds a file to an existing work by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var workId = 56;  // int? | Id of the work to add an file to

            try
            {
                // Attach a file to a work by URL.
                apiInstance.AddWorkFileByURL(body, workId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.AddWorkFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **workId** | **int?**| Id of the work to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addworktag"></a>
# **AddWorkTag**
> void AddWorkTag (int? workId, string workTag)

Add new tags for a work.

Adds a tag to an existing work.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWorkTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to add a tag to
            var workTag = workTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a work.
                apiInstance.AddWorkTag(workId, workTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.AddWorkTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to add a tag to | 
 **workTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkfile"></a>
# **DeleteWorkFile**
> void DeleteWorkFile (int? workId, int? fileId)

Delete a file for a work.

Deletes an existing work file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWorkFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a work.
                apiInstance.DeleteWorkFile(workId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.DeleteWorkFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworktag"></a>
# **DeleteWorkTag**
> void DeleteWorkTag (int? workId, string workTag)

Delete a tag for a work.

Deletes an existing work tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWorkTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to remove tag from
            var workTag = workTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a work.
                apiInstance.DeleteWorkTag(workId, workTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.DeleteWorkTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to remove tag from | 
 **workTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateworkbyid"></a>
# **GetDuplicateWorkById**
> Work GetDuplicateWorkById (int? workId)

Get a duplicated a work by id

Returns a duplicated work identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWorkByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to be duplicated.

            try
            {
                // Get a duplicated a work by id
                Work result = apiInstance.GetDuplicateWorkById(workId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.GetDuplicateWorkById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to be duplicated. | 

### Return type

[**Work**](Work.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkbyfilter"></a>
# **GetWorkByFilter**
> List<Work> GetWorkByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search works by filter

Returns the list of works that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search works by filter
                List&lt;Work&gt; result = apiInstance.GetWorkByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.GetWorkByFilter: " + e.Message );
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

[**List<Work>**](Work.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkbyid"></a>
# **GetWorkById**
> Work GetWorkById (int? workId)

Get a work by id

Returns the work identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to be returned.

            try
            {
                // Get a work by id
                Work result = apiInstance.GetWorkById(workId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.GetWorkById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to be returned. | 

### Return type

[**Work**](Work.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkfiles"></a>
# **GetWorkFiles**
> void GetWorkFiles (int? workId)

Get the files for a work.

Get all existing work files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to get files for

            try
            {
                // Get the files for a work.
                apiInstance.GetWorkFiles(workId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.GetWorkFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworktags"></a>
# **GetWorkTags**
> void GetWorkTags (int? workId)

Get the tags for a work.

Get all existing work tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWorkTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var workId = 56;  // int? | Id of the work to get tags for

            try
            {
                // Get the tags for a work.
                apiInstance.GetWorkTags(workId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.GetWorkTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workId** | **int?**| Id of the work to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatework"></a>
# **UpdateWork**
> void UpdateWork (Work body)

Update a work

Updates an existing work using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWorkExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var body = new Work(); // Work | Work to be updated.

            try
            {
                // Update a work
                apiInstance.UpdateWork(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.UpdateWork: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Work**](Work.md)| Work to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkcustomfields"></a>
# **UpdateWorkCustomFields**
> void UpdateWorkCustomFields (Work body)

Update a work custom fields

Updates an existing work custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWorkCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WorkApi();
            var body = new Work(); // Work | Work to be updated.

            try
            {
                // Update a work custom fields
                apiInstance.UpdateWorkCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkApi.UpdateWorkCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Work**](Work.md)| Work to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

