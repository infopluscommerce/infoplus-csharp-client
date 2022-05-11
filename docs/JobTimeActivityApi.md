# Infoplus.Api.JobTimeActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddJobTimeActivity**](JobTimeActivityApi.md#addjobtimeactivity) | **POST** /v3.0/jobTimeActivity | Create a jobTimeActivity
[**AddJobTimeActivityAudit**](JobTimeActivityApi.md#addjobtimeactivityaudit) | **PUT** /v3.0/jobTimeActivity/{jobTimeActivityId}/audit/{jobTimeActivityAudit} | Add new audit for a jobTimeActivity
[**AddJobTimeActivityFile**](JobTimeActivityApi.md#addjobtimeactivityfile) | **POST** /v3.0/jobTimeActivity/{jobTimeActivityId}/file/{fileName} | Attach a file to a jobTimeActivity
[**AddJobTimeActivityFileByURL**](JobTimeActivityApi.md#addjobtimeactivityfilebyurl) | **POST** /v3.0/jobTimeActivity/{jobTimeActivityId}/file | Attach a file to a jobTimeActivity by URL.
[**AddJobTimeActivityTag**](JobTimeActivityApi.md#addjobtimeactivitytag) | **PUT** /v3.0/jobTimeActivity/{jobTimeActivityId}/tag/{jobTimeActivityTag} | Add new tags for a jobTimeActivity.
[**DeleteJobTimeActivity**](JobTimeActivityApi.md#deletejobtimeactivity) | **DELETE** /v3.0/jobTimeActivity/{jobTimeActivityId} | Delete a jobTimeActivity
[**DeleteJobTimeActivityFile**](JobTimeActivityApi.md#deletejobtimeactivityfile) | **DELETE** /v3.0/jobTimeActivity/{jobTimeActivityId}/file/{fileId} | Delete a file for a jobTimeActivity.
[**DeleteJobTimeActivityTag**](JobTimeActivityApi.md#deletejobtimeactivitytag) | **DELETE** /v3.0/jobTimeActivity/{jobTimeActivityId}/tag/{jobTimeActivityTag} | Delete a tag for a jobTimeActivity.
[**GetDuplicateJobTimeActivityById**](JobTimeActivityApi.md#getduplicatejobtimeactivitybyid) | **GET** /v3.0/jobTimeActivity/duplicate/{jobTimeActivityId} | Get a duplicated a jobTimeActivity by id
[**GetJobTimeActivityByFilter**](JobTimeActivityApi.md#getjobtimeactivitybyfilter) | **GET** /v3.0/jobTimeActivity/search | Search jobTimeActivitys by filter
[**GetJobTimeActivityById**](JobTimeActivityApi.md#getjobtimeactivitybyid) | **GET** /v3.0/jobTimeActivity/{jobTimeActivityId} | Get a jobTimeActivity by id
[**GetJobTimeActivityFiles**](JobTimeActivityApi.md#getjobtimeactivityfiles) | **GET** /v3.0/jobTimeActivity/{jobTimeActivityId}/file | Get the files for a jobTimeActivity.
[**GetJobTimeActivityTags**](JobTimeActivityApi.md#getjobtimeactivitytags) | **GET** /v3.0/jobTimeActivity/{jobTimeActivityId}/tag | Get the tags for a jobTimeActivity.
[**UpdateJobTimeActivity**](JobTimeActivityApi.md#updatejobtimeactivity) | **PUT** /v3.0/jobTimeActivity | Update a jobTimeActivity


<a name="addjobtimeactivity"></a>
# **AddJobTimeActivity**
> JobTimeActivity AddJobTimeActivity (JobTimeActivity body)

Create a jobTimeActivity

Inserts a new jobTimeActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var body = new JobTimeActivity(); // JobTimeActivity | JobTimeActivity to be inserted.

            try
            {
                // Create a jobTimeActivity
                JobTimeActivity result = apiInstance.AddJobTimeActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.AddJobTimeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobTimeActivity**](JobTimeActivity.md)| JobTimeActivity to be inserted. | 

### Return type

[**JobTimeActivity**](JobTimeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimeactivityaudit"></a>
# **AddJobTimeActivityAudit**
> void AddJobTimeActivityAudit (int? jobTimeActivityId, string jobTimeActivityAudit)

Add new audit for a jobTimeActivity

Adds an audit to an existing jobTimeActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to add an audit to
            var jobTimeActivityAudit = jobTimeActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a jobTimeActivity
                apiInstance.AddJobTimeActivityAudit(jobTimeActivityId, jobTimeActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.AddJobTimeActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to add an audit to | 
 **jobTimeActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimeactivityfile"></a>
# **AddJobTimeActivityFile**
> void AddJobTimeActivityFile (int? jobTimeActivityId, string fileName)

Attach a file to a jobTimeActivity

Adds a file to an existing jobTimeActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a jobTimeActivity
                apiInstance.AddJobTimeActivityFile(jobTimeActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.AddJobTimeActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimeactivityfilebyurl"></a>
# **AddJobTimeActivityFileByURL**
> void AddJobTimeActivityFileByURL (RecordFile body, int? jobTimeActivityId)

Attach a file to a jobTimeActivity by URL.

Adds a file to an existing jobTimeActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to add an file to

            try
            {
                // Attach a file to a jobTimeActivity by URL.
                apiInstance.AddJobTimeActivityFileByURL(body, jobTimeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.AddJobTimeActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimeactivitytag"></a>
# **AddJobTimeActivityTag**
> void AddJobTimeActivityTag (int? jobTimeActivityId, string jobTimeActivityTag)

Add new tags for a jobTimeActivity.

Adds a tag to an existing jobTimeActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to add a tag to
            var jobTimeActivityTag = jobTimeActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a jobTimeActivity.
                apiInstance.AddJobTimeActivityTag(jobTimeActivityId, jobTimeActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.AddJobTimeActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to add a tag to | 
 **jobTimeActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtimeactivity"></a>
# **DeleteJobTimeActivity**
> void DeleteJobTimeActivity (int? jobTimeActivityId)

Delete a jobTimeActivity

Deletes the jobTimeActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTimeActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to be deleted.

            try
            {
                // Delete a jobTimeActivity
                apiInstance.DeleteJobTimeActivity(jobTimeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.DeleteJobTimeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtimeactivityfile"></a>
# **DeleteJobTimeActivityFile**
> void DeleteJobTimeActivityFile (int? jobTimeActivityId, int? fileId)

Delete a file for a jobTimeActivity.

Deletes an existing jobTimeActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTimeActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a jobTimeActivity.
                apiInstance.DeleteJobTimeActivityFile(jobTimeActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.DeleteJobTimeActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtimeactivitytag"></a>
# **DeleteJobTimeActivityTag**
> void DeleteJobTimeActivityTag (int? jobTimeActivityId, string jobTimeActivityTag)

Delete a tag for a jobTimeActivity.

Deletes an existing jobTimeActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTimeActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to remove tag from
            var jobTimeActivityTag = jobTimeActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a jobTimeActivity.
                apiInstance.DeleteJobTimeActivityTag(jobTimeActivityId, jobTimeActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.DeleteJobTimeActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to remove tag from | 
 **jobTimeActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatejobtimeactivitybyid"></a>
# **GetDuplicateJobTimeActivityById**
> JobTimeActivity GetDuplicateJobTimeActivityById (int? jobTimeActivityId)

Get a duplicated a jobTimeActivity by id

Returns a duplicated jobTimeActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateJobTimeActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to be duplicated.

            try
            {
                // Get a duplicated a jobTimeActivity by id
                JobTimeActivity result = apiInstance.GetDuplicateJobTimeActivityById(jobTimeActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.GetDuplicateJobTimeActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to be duplicated. | 

### Return type

[**JobTimeActivity**](JobTimeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimeactivitybyfilter"></a>
# **GetJobTimeActivityByFilter**
> List<JobTimeActivity> GetJobTimeActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search jobTimeActivitys by filter

Returns the list of jobTimeActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search jobTimeActivitys by filter
                List&lt;JobTimeActivity&gt; result = apiInstance.GetJobTimeActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.GetJobTimeActivityByFilter: " + e.Message );
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

[**List<JobTimeActivity>**](JobTimeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimeactivitybyid"></a>
# **GetJobTimeActivityById**
> JobTimeActivity GetJobTimeActivityById (int? jobTimeActivityId)

Get a jobTimeActivity by id

Returns the jobTimeActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to be returned.

            try
            {
                // Get a jobTimeActivity by id
                JobTimeActivity result = apiInstance.GetJobTimeActivityById(jobTimeActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.GetJobTimeActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to be returned. | 

### Return type

[**JobTimeActivity**](JobTimeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimeactivityfiles"></a>
# **GetJobTimeActivityFiles**
> void GetJobTimeActivityFiles (int? jobTimeActivityId)

Get the files for a jobTimeActivity.

Get all existing jobTimeActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to get files for

            try
            {
                // Get the files for a jobTimeActivity.
                apiInstance.GetJobTimeActivityFiles(jobTimeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.GetJobTimeActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimeactivitytags"></a>
# **GetJobTimeActivityTags**
> void GetJobTimeActivityTags (int? jobTimeActivityId)

Get the tags for a jobTimeActivity.

Get all existing jobTimeActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var jobTimeActivityId = 56;  // int? | Id of the jobTimeActivity to get tags for

            try
            {
                // Get the tags for a jobTimeActivity.
                apiInstance.GetJobTimeActivityTags(jobTimeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.GetJobTimeActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeActivityId** | **int?**| Id of the jobTimeActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobtimeactivity"></a>
# **UpdateJobTimeActivity**
> void UpdateJobTimeActivity (JobTimeActivity body)

Update a jobTimeActivity

Updates an existing jobTimeActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobTimeActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeActivityApi();
            var body = new JobTimeActivity(); // JobTimeActivity | JobTimeActivity to be updated.

            try
            {
                // Update a jobTimeActivity
                apiInstance.UpdateJobTimeActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeActivityApi.UpdateJobTimeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobTimeActivity**](JobTimeActivity.md)| JobTimeActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

