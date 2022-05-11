# Infoplus.Api.JobTimeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddJobTime**](JobTimeApi.md#addjobtime) | **POST** /v3.0/jobTime | Create a jobTime
[**AddJobTimeAudit**](JobTimeApi.md#addjobtimeaudit) | **PUT** /v3.0/jobTime/{jobTimeId}/audit/{jobTimeAudit} | Add new audit for a jobTime
[**AddJobTimeFile**](JobTimeApi.md#addjobtimefile) | **POST** /v3.0/jobTime/{jobTimeId}/file/{fileName} | Attach a file to a jobTime
[**AddJobTimeFileByURL**](JobTimeApi.md#addjobtimefilebyurl) | **POST** /v3.0/jobTime/{jobTimeId}/file | Attach a file to a jobTime by URL.
[**AddJobTimeTag**](JobTimeApi.md#addjobtimetag) | **PUT** /v3.0/jobTime/{jobTimeId}/tag/{jobTimeTag} | Add new tags for a jobTime.
[**DeleteJobTime**](JobTimeApi.md#deletejobtime) | **DELETE** /v3.0/jobTime/{jobTimeId} | Delete a jobTime
[**DeleteJobTimeFile**](JobTimeApi.md#deletejobtimefile) | **DELETE** /v3.0/jobTime/{jobTimeId}/file/{fileId} | Delete a file for a jobTime.
[**DeleteJobTimeTag**](JobTimeApi.md#deletejobtimetag) | **DELETE** /v3.0/jobTime/{jobTimeId}/tag/{jobTimeTag} | Delete a tag for a jobTime.
[**GetDuplicateJobTimeById**](JobTimeApi.md#getduplicatejobtimebyid) | **GET** /v3.0/jobTime/duplicate/{jobTimeId} | Get a duplicated a jobTime by id
[**GetJobTimeByFilter**](JobTimeApi.md#getjobtimebyfilter) | **GET** /v3.0/jobTime/search | Search jobTimes by filter
[**GetJobTimeById**](JobTimeApi.md#getjobtimebyid) | **GET** /v3.0/jobTime/{jobTimeId} | Get a jobTime by id
[**GetJobTimeFiles**](JobTimeApi.md#getjobtimefiles) | **GET** /v3.0/jobTime/{jobTimeId}/file | Get the files for a jobTime.
[**GetJobTimeTags**](JobTimeApi.md#getjobtimetags) | **GET** /v3.0/jobTime/{jobTimeId}/tag | Get the tags for a jobTime.
[**UpdateJobTime**](JobTimeApi.md#updatejobtime) | **PUT** /v3.0/jobTime | Update a jobTime
[**UpdateJobTimeCustomFields**](JobTimeApi.md#updatejobtimecustomfields) | **PUT** /v3.0/jobTime/customFields | Update a jobTime custom fields


<a name="addjobtime"></a>
# **AddJobTime**
> JobTime AddJobTime (JobTime body)

Create a jobTime

Inserts a new jobTime using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var body = new JobTime(); // JobTime | JobTime to be inserted.

            try
            {
                // Create a jobTime
                JobTime result = apiInstance.AddJobTime(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.AddJobTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobTime**](JobTime.md)| JobTime to be inserted. | 

### Return type

[**JobTime**](JobTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimeaudit"></a>
# **AddJobTimeAudit**
> void AddJobTimeAudit (int? jobTimeId, string jobTimeAudit)

Add new audit for a jobTime

Adds an audit to an existing jobTime.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to add an audit to
            var jobTimeAudit = jobTimeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a jobTime
                apiInstance.AddJobTimeAudit(jobTimeId, jobTimeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.AddJobTimeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to add an audit to | 
 **jobTimeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimefile"></a>
# **AddJobTimeFile**
> void AddJobTimeFile (int? jobTimeId, string fileName)

Attach a file to a jobTime

Adds a file to an existing jobTime.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a jobTime
                apiInstance.AddJobTimeFile(jobTimeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.AddJobTimeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimefilebyurl"></a>
# **AddJobTimeFileByURL**
> void AddJobTimeFileByURL (RecordFile body, int? jobTimeId)

Attach a file to a jobTime by URL.

Adds a file to an existing jobTime by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var jobTimeId = 56;  // int? | Id of the jobTime to add an file to

            try
            {
                // Attach a file to a jobTime by URL.
                apiInstance.AddJobTimeFileByURL(body, jobTimeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.AddJobTimeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **jobTimeId** | **int?**| Id of the jobTime to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtimetag"></a>
# **AddJobTimeTag**
> void AddJobTimeTag (int? jobTimeId, string jobTimeTag)

Add new tags for a jobTime.

Adds a tag to an existing jobTime.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTimeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to add a tag to
            var jobTimeTag = jobTimeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a jobTime.
                apiInstance.AddJobTimeTag(jobTimeId, jobTimeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.AddJobTimeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to add a tag to | 
 **jobTimeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtime"></a>
# **DeleteJobTime**
> void DeleteJobTime (int? jobTimeId)

Delete a jobTime

Deletes the jobTime identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTimeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to be deleted.

            try
            {
                // Delete a jobTime
                apiInstance.DeleteJobTime(jobTimeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.DeleteJobTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtimefile"></a>
# **DeleteJobTimeFile**
> void DeleteJobTimeFile (int? jobTimeId, int? fileId)

Delete a file for a jobTime.

Deletes an existing jobTime file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTimeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a jobTime.
                apiInstance.DeleteJobTimeFile(jobTimeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.DeleteJobTimeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtimetag"></a>
# **DeleteJobTimeTag**
> void DeleteJobTimeTag (int? jobTimeId, string jobTimeTag)

Delete a tag for a jobTime.

Deletes an existing jobTime tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTimeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to remove tag from
            var jobTimeTag = jobTimeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a jobTime.
                apiInstance.DeleteJobTimeTag(jobTimeId, jobTimeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.DeleteJobTimeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to remove tag from | 
 **jobTimeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatejobtimebyid"></a>
# **GetDuplicateJobTimeById**
> JobTime GetDuplicateJobTimeById (int? jobTimeId)

Get a duplicated a jobTime by id

Returns a duplicated jobTime identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateJobTimeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to be duplicated.

            try
            {
                // Get a duplicated a jobTime by id
                JobTime result = apiInstance.GetDuplicateJobTimeById(jobTimeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.GetDuplicateJobTimeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to be duplicated. | 

### Return type

[**JobTime**](JobTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimebyfilter"></a>
# **GetJobTimeByFilter**
> List<JobTime> GetJobTimeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search jobTimes by filter

Returns the list of jobTimes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search jobTimes by filter
                List&lt;JobTime&gt; result = apiInstance.GetJobTimeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.GetJobTimeByFilter: " + e.Message );
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

[**List<JobTime>**](JobTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimebyid"></a>
# **GetJobTimeById**
> JobTime GetJobTimeById (int? jobTimeId)

Get a jobTime by id

Returns the jobTime identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to be returned.

            try
            {
                // Get a jobTime by id
                JobTime result = apiInstance.GetJobTimeById(jobTimeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.GetJobTimeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to be returned. | 

### Return type

[**JobTime**](JobTime.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimefiles"></a>
# **GetJobTimeFiles**
> void GetJobTimeFiles (int? jobTimeId)

Get the files for a jobTime.

Get all existing jobTime files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to get files for

            try
            {
                // Get the files for a jobTime.
                apiInstance.GetJobTimeFiles(jobTimeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.GetJobTimeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtimetags"></a>
# **GetJobTimeTags**
> void GetJobTimeTags (int? jobTimeId)

Get the tags for a jobTime.

Get all existing jobTime tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTimeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var jobTimeId = 56;  // int? | Id of the jobTime to get tags for

            try
            {
                // Get the tags for a jobTime.
                apiInstance.GetJobTimeTags(jobTimeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.GetJobTimeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTimeId** | **int?**| Id of the jobTime to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobtime"></a>
# **UpdateJobTime**
> void UpdateJobTime (JobTime body)

Update a jobTime

Updates an existing jobTime using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobTimeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var body = new JobTime(); // JobTime | JobTime to be updated.

            try
            {
                // Update a jobTime
                apiInstance.UpdateJobTime(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.UpdateJobTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobTime**](JobTime.md)| JobTime to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobtimecustomfields"></a>
# **UpdateJobTimeCustomFields**
> void UpdateJobTimeCustomFields (JobTime body)

Update a jobTime custom fields

Updates an existing jobTime custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobTimeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTimeApi();
            var body = new JobTime(); // JobTime | JobTime to be updated.

            try
            {
                // Update a jobTime custom fields
                apiInstance.UpdateJobTimeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTimeApi.UpdateJobTimeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobTime**](JobTime.md)| JobTime to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

