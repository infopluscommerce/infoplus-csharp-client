# Infoplus.Api.JobRecipeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddJobRecipe**](JobRecipeApi.md#addjobrecipe) | **POST** /beta/jobRecipe | Create a jobRecipe
[**AddJobRecipeAudit**](JobRecipeApi.md#addjobrecipeaudit) | **PUT** /beta/jobRecipe/{jobRecipeId}/audit/{jobRecipeAudit} | Add new audit for a jobRecipe
[**AddJobRecipeFile**](JobRecipeApi.md#addjobrecipefile) | **POST** /beta/jobRecipe/{jobRecipeId}/file/{fileName} | Attach a file to a jobRecipe
[**AddJobRecipeFileByURL**](JobRecipeApi.md#addjobrecipefilebyurl) | **POST** /beta/jobRecipe/{jobRecipeId}/file | Attach a file to a jobRecipe by URL.
[**AddJobRecipeTag**](JobRecipeApi.md#addjobrecipetag) | **PUT** /beta/jobRecipe/{jobRecipeId}/tag/{jobRecipeTag} | Add new tags for a jobRecipe.
[**DeleteJobRecipe**](JobRecipeApi.md#deletejobrecipe) | **DELETE** /beta/jobRecipe/{jobRecipeId} | Delete a jobRecipe
[**DeleteJobRecipeFile**](JobRecipeApi.md#deletejobrecipefile) | **DELETE** /beta/jobRecipe/{jobRecipeId}/file/{fileId} | Delete a file for a jobRecipe.
[**DeleteJobRecipeTag**](JobRecipeApi.md#deletejobrecipetag) | **DELETE** /beta/jobRecipe/{jobRecipeId}/tag/{jobRecipeTag} | Delete a tag for a jobRecipe.
[**GetDuplicateJobRecipeById**](JobRecipeApi.md#getduplicatejobrecipebyid) | **GET** /beta/jobRecipe/duplicate/{jobRecipeId} | Get a duplicated a jobRecipe by id
[**GetJobRecipeByFilter**](JobRecipeApi.md#getjobrecipebyfilter) | **GET** /beta/jobRecipe/search | Search jobRecipes by filter
[**GetJobRecipeById**](JobRecipeApi.md#getjobrecipebyid) | **GET** /beta/jobRecipe/{jobRecipeId} | Get a jobRecipe by id
[**GetJobRecipeFiles**](JobRecipeApi.md#getjobrecipefiles) | **GET** /beta/jobRecipe/{jobRecipeId}/file | Get the files for a jobRecipe.
[**GetJobRecipeTags**](JobRecipeApi.md#getjobrecipetags) | **GET** /beta/jobRecipe/{jobRecipeId}/tag | Get the tags for a jobRecipe.
[**UpdateJobRecipe**](JobRecipeApi.md#updatejobrecipe) | **PUT** /beta/jobRecipe | Update a jobRecipe
[**UpdateJobRecipeCustomFields**](JobRecipeApi.md#updatejobrecipecustomfields) | **PUT** /beta/jobRecipe/customFields | Update a jobRecipe custom fields


<a name="addjobrecipe"></a>
# **AddJobRecipe**
> JobRecipe AddJobRecipe (JobRecipe body)

Create a jobRecipe

Inserts a new jobRecipe using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobRecipeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var body = new JobRecipe(); // JobRecipe | JobRecipe to be inserted.

            try
            {
                // Create a jobRecipe
                JobRecipe result = apiInstance.AddJobRecipe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.AddJobRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobRecipe**](JobRecipe.md)| JobRecipe to be inserted. | 

### Return type

[**JobRecipe**](JobRecipe.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobrecipeaudit"></a>
# **AddJobRecipeAudit**
> void AddJobRecipeAudit (int? jobRecipeId, string jobRecipeAudit)

Add new audit for a jobRecipe

Adds an audit to an existing jobRecipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobRecipeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to add an audit to
            var jobRecipeAudit = jobRecipeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a jobRecipe
                apiInstance.AddJobRecipeAudit(jobRecipeId, jobRecipeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.AddJobRecipeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to add an audit to | 
 **jobRecipeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobrecipefile"></a>
# **AddJobRecipeFile**
> void AddJobRecipeFile (int? jobRecipeId, string fileName)

Attach a file to a jobRecipe

Adds a file to an existing jobRecipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobRecipeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a jobRecipe
                apiInstance.AddJobRecipeFile(jobRecipeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.AddJobRecipeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobrecipefilebyurl"></a>
# **AddJobRecipeFileByURL**
> void AddJobRecipeFileByURL (RecordFile body, int? jobRecipeId)

Attach a file to a jobRecipe by URL.

Adds a file to an existing jobRecipe by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobRecipeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to add an file to

            try
            {
                // Attach a file to a jobRecipe by URL.
                apiInstance.AddJobRecipeFileByURL(body, jobRecipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.AddJobRecipeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **jobRecipeId** | **int?**| Id of the jobRecipe to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobrecipetag"></a>
# **AddJobRecipeTag**
> void AddJobRecipeTag (int? jobRecipeId, string jobRecipeTag)

Add new tags for a jobRecipe.

Adds a tag to an existing jobRecipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobRecipeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to add a tag to
            var jobRecipeTag = jobRecipeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a jobRecipe.
                apiInstance.AddJobRecipeTag(jobRecipeId, jobRecipeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.AddJobRecipeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to add a tag to | 
 **jobRecipeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobrecipe"></a>
# **DeleteJobRecipe**
> void DeleteJobRecipe (int? jobRecipeId)

Delete a jobRecipe

Deletes the jobRecipe identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobRecipeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to be deleted.

            try
            {
                // Delete a jobRecipe
                apiInstance.DeleteJobRecipe(jobRecipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.DeleteJobRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobrecipefile"></a>
# **DeleteJobRecipeFile**
> void DeleteJobRecipeFile (int? jobRecipeId, int? fileId)

Delete a file for a jobRecipe.

Deletes an existing jobRecipe file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobRecipeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a jobRecipe.
                apiInstance.DeleteJobRecipeFile(jobRecipeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.DeleteJobRecipeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobrecipetag"></a>
# **DeleteJobRecipeTag**
> void DeleteJobRecipeTag (int? jobRecipeId, string jobRecipeTag)

Delete a tag for a jobRecipe.

Deletes an existing jobRecipe tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobRecipeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to remove tag from
            var jobRecipeTag = jobRecipeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a jobRecipe.
                apiInstance.DeleteJobRecipeTag(jobRecipeId, jobRecipeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.DeleteJobRecipeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to remove tag from | 
 **jobRecipeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatejobrecipebyid"></a>
# **GetDuplicateJobRecipeById**
> JobRecipe GetDuplicateJobRecipeById (int? jobRecipeId)

Get a duplicated a jobRecipe by id

Returns a duplicated jobRecipe identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateJobRecipeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to be duplicated.

            try
            {
                // Get a duplicated a jobRecipe by id
                JobRecipe result = apiInstance.GetDuplicateJobRecipeById(jobRecipeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.GetDuplicateJobRecipeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to be duplicated. | 

### Return type

[**JobRecipe**](JobRecipe.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobrecipebyfilter"></a>
# **GetJobRecipeByFilter**
> List<JobRecipe> GetJobRecipeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search jobRecipes by filter

Returns the list of jobRecipes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobRecipeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search jobRecipes by filter
                List&lt;JobRecipe&gt; result = apiInstance.GetJobRecipeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.GetJobRecipeByFilter: " + e.Message );
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

[**List<JobRecipe>**](JobRecipe.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobrecipebyid"></a>
# **GetJobRecipeById**
> JobRecipe GetJobRecipeById (int? jobRecipeId)

Get a jobRecipe by id

Returns the jobRecipe identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobRecipeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to be returned.

            try
            {
                // Get a jobRecipe by id
                JobRecipe result = apiInstance.GetJobRecipeById(jobRecipeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.GetJobRecipeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to be returned. | 

### Return type

[**JobRecipe**](JobRecipe.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobrecipefiles"></a>
# **GetJobRecipeFiles**
> void GetJobRecipeFiles (int? jobRecipeId)

Get the files for a jobRecipe.

Get all existing jobRecipe files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobRecipeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to get files for

            try
            {
                // Get the files for a jobRecipe.
                apiInstance.GetJobRecipeFiles(jobRecipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.GetJobRecipeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobrecipetags"></a>
# **GetJobRecipeTags**
> void GetJobRecipeTags (int? jobRecipeId)

Get the tags for a jobRecipe.

Get all existing jobRecipe tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobRecipeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var jobRecipeId = 56;  // int? | Id of the jobRecipe to get tags for

            try
            {
                // Get the tags for a jobRecipe.
                apiInstance.GetJobRecipeTags(jobRecipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.GetJobRecipeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobRecipeId** | **int?**| Id of the jobRecipe to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobrecipe"></a>
# **UpdateJobRecipe**
> void UpdateJobRecipe (JobRecipe body)

Update a jobRecipe

Updates an existing jobRecipe using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobRecipeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var body = new JobRecipe(); // JobRecipe | JobRecipe to be updated.

            try
            {
                // Update a jobRecipe
                apiInstance.UpdateJobRecipe(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.UpdateJobRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobRecipe**](JobRecipe.md)| JobRecipe to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobrecipecustomfields"></a>
# **UpdateJobRecipeCustomFields**
> void UpdateJobRecipeCustomFields (JobRecipe body)

Update a jobRecipe custom fields

Updates an existing jobRecipe custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobRecipeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobRecipeApi();
            var body = new JobRecipe(); // JobRecipe | JobRecipe to be updated.

            try
            {
                // Update a jobRecipe custom fields
                apiInstance.UpdateJobRecipeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobRecipeApi.UpdateJobRecipeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobRecipe**](JobRecipe.md)| JobRecipe to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

