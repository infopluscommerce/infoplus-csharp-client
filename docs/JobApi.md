# Infoplus.Api.JobApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddJob**](JobApi.md#addjob) | **POST** /beta/job | Create a job
[**AddJobAudit**](JobApi.md#addjobaudit) | **PUT** /beta/job/{jobId}/audit/{jobAudit} | Add new audit for a job
[**AddJobFile**](JobApi.md#addjobfile) | **POST** /beta/job/{jobId}/file/{fileName} | Attach a file to a job
[**AddJobFileByURL**](JobApi.md#addjobfilebyurl) | **POST** /beta/job/{jobId}/file | Attach a file to a job by URL.
[**AddJobTag**](JobApi.md#addjobtag) | **PUT** /beta/job/{jobId}/tag/{jobTag} | Add new tags for a job.
[**DeleteJob**](JobApi.md#deletejob) | **DELETE** /beta/job/{jobId} | Delete a job
[**DeleteJobFile**](JobApi.md#deletejobfile) | **DELETE** /beta/job/{jobId}/file/{fileId} | Delete a file for a job.
[**DeleteJobTag**](JobApi.md#deletejobtag) | **DELETE** /beta/job/{jobId}/tag/{jobTag} | Delete a tag for a job.
[**ExecuteJob**](JobApi.md#executejob) | **POST** /beta/job/executeJob | Run the ExecuteJob process.
[**GetDuplicateJobById**](JobApi.md#getduplicatejobbyid) | **GET** /beta/job/duplicate/{jobId} | Get a duplicated a job by id
[**GetJobByFilter**](JobApi.md#getjobbyfilter) | **GET** /beta/job/search | Search jobs by filter
[**GetJobById**](JobApi.md#getjobbyid) | **GET** /beta/job/{jobId} | Get a job by id
[**GetJobFiles**](JobApi.md#getjobfiles) | **GET** /beta/job/{jobId}/file | Get the files for a job.
[**GetJobTags**](JobApi.md#getjobtags) | **GET** /beta/job/{jobId}/tag | Get the tags for a job.
[**UpdateJob**](JobApi.md#updatejob) | **PUT** /beta/job | Update a job
[**UpdateJobCustomFields**](JobApi.md#updatejobcustomfields) | **PUT** /beta/job/customFields | Update a job custom fields


<a name="addjob"></a>
# **AddJob**
> Job AddJob (Job body)

Create a job

Inserts a new job using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var body = new Job(); // Job | Job to be inserted.

            try
            {
                // Create a job
                Job result = apiInstance.AddJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.AddJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Job**](Job.md)| Job to be inserted. | 

### Return type

[**Job**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobaudit"></a>
# **AddJobAudit**
> void AddJobAudit (int? jobId, string jobAudit)

Add new audit for a job

Adds an audit to an existing job.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to add an audit to
            var jobAudit = jobAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a job
                apiInstance.AddJobAudit(jobId, jobAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.AddJobAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to add an audit to | 
 **jobAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobfile"></a>
# **AddJobFile**
> void AddJobFile (int? jobId, string fileName)

Attach a file to a job

Adds a file to an existing job.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a job
                apiInstance.AddJobFile(jobId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.AddJobFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobfilebyurl"></a>
# **AddJobFileByURL**
> void AddJobFileByURL (RecordFile body, int? jobId)

Attach a file to a job by URL.

Adds a file to an existing job by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var jobId = 56;  // int? | Id of the job to add an file to

            try
            {
                // Attach a file to a job by URL.
                apiInstance.AddJobFileByURL(body, jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.AddJobFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **jobId** | **int?**| Id of the job to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtag"></a>
# **AddJobTag**
> void AddJobTag (int? jobId, string jobTag)

Add new tags for a job.

Adds a tag to an existing job.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to add a tag to
            var jobTag = jobTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a job.
                apiInstance.AddJobTag(jobId, jobTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.AddJobTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to add a tag to | 
 **jobTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejob"></a>
# **DeleteJob**
> void DeleteJob (int? jobId)

Delete a job

Deletes the job identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to be deleted.

            try
            {
                // Delete a job
                apiInstance.DeleteJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.DeleteJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobfile"></a>
# **DeleteJobFile**
> void DeleteJobFile (int? jobId, int? fileId)

Delete a file for a job.

Deletes an existing job file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a job.
                apiInstance.DeleteJobFile(jobId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.DeleteJobFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtag"></a>
# **DeleteJobTag**
> void DeleteJobTag (int? jobId, string jobTag)

Delete a tag for a job.

Deletes an existing job tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to remove tag from
            var jobTag = jobTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a job.
                apiInstance.DeleteJobTag(jobId, jobTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.DeleteJobTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to remove tag from | 
 **jobTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executejob"></a>
# **ExecuteJob**
> List<ProcessOutputAPIModel> ExecuteJob (ExecuteJobInputAPIModel body)

Run the ExecuteJob process.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class ExecuteJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var body = new ExecuteJobInputAPIModel(); // ExecuteJobInputAPIModel | Input data for ExecuteJob process.

            try
            {
                // Run the ExecuteJob process.
                List&lt;ProcessOutputAPIModel&gt; result = apiInstance.ExecuteJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.ExecuteJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteJobInputAPIModel**](ExecuteJobInputAPIModel.md)| Input data for ExecuteJob process. | 

### Return type

[**List<ProcessOutputAPIModel>**](ProcessOutputAPIModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatejobbyid"></a>
# **GetDuplicateJobById**
> Job GetDuplicateJobById (int? jobId)

Get a duplicated a job by id

Returns a duplicated job identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateJobByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to be duplicated.

            try
            {
                // Get a duplicated a job by id
                Job result = apiInstance.GetDuplicateJobById(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.GetDuplicateJobById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to be duplicated. | 

### Return type

[**Job**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobbyfilter"></a>
# **GetJobByFilter**
> List<Job> GetJobByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search jobs by filter

Returns the list of jobs that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search jobs by filter
                List&lt;Job&gt; result = apiInstance.GetJobByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.GetJobByFilter: " + e.Message );
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

[**List<Job>**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobbyid"></a>
# **GetJobById**
> Job GetJobById (int? jobId)

Get a job by id

Returns the job identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to be returned.

            try
            {
                // Get a job by id
                Job result = apiInstance.GetJobById(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.GetJobById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to be returned. | 

### Return type

[**Job**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobfiles"></a>
# **GetJobFiles**
> void GetJobFiles (int? jobId)

Get the files for a job.

Get all existing job files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to get files for

            try
            {
                // Get the files for a job.
                apiInstance.GetJobFiles(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.GetJobFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtags"></a>
# **GetJobTags**
> void GetJobTags (int? jobId)

Get the tags for a job.

Get all existing job tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var jobId = 56;  // int? | Id of the job to get tags for

            try
            {
                // Get the tags for a job.
                apiInstance.GetJobTags(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.GetJobTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| Id of the job to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejob"></a>
# **UpdateJob**
> void UpdateJob (Job body)

Update a job

Updates an existing job using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var body = new Job(); // Job | Job to be updated.

            try
            {
                // Update a job
                apiInstance.UpdateJob(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.UpdateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Job**](Job.md)| Job to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobcustomfields"></a>
# **UpdateJobCustomFields**
> void UpdateJobCustomFields (Job body)

Update a job custom fields

Updates an existing job custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobApi();
            var body = new Job(); // Job | Job to be updated.

            try
            {
                // Update a job custom fields
                apiInstance.UpdateJobCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobApi.UpdateJobCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Job**](Job.md)| Job to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

