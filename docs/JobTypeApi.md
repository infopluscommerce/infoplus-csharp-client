# Infoplus.Api.JobTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddJobType**](JobTypeApi.md#addjobtype) | **POST** /beta/jobType | Create a jobType
[**AddJobTypeAudit**](JobTypeApi.md#addjobtypeaudit) | **PUT** /beta/jobType/{jobTypeId}/audit/{jobTypeAudit} | Add new audit for a jobType
[**AddJobTypeFile**](JobTypeApi.md#addjobtypefile) | **POST** /beta/jobType/{jobTypeId}/file/{fileName} | Attach a file to a jobType
[**AddJobTypeTag**](JobTypeApi.md#addjobtypetag) | **PUT** /beta/jobType/{jobTypeId}/tag/{jobTypeTag} | Add new tags for a jobType.
[**DeleteJobType**](JobTypeApi.md#deletejobtype) | **DELETE** /beta/jobType/{jobTypeId} | Delete a jobType
[**DeleteJobTypeTag**](JobTypeApi.md#deletejobtypetag) | **DELETE** /beta/jobType/{jobTypeId}/tag/{jobTypeTag} | Delete a tag for a jobType.
[**GetDuplicateJobTypeById**](JobTypeApi.md#getduplicatejobtypebyid) | **GET** /beta/jobType/duplicate/{jobTypeId} | Get a duplicated a jobType by id
[**GetJobTypeByFilter**](JobTypeApi.md#getjobtypebyfilter) | **GET** /beta/jobType/search | Search jobTypes by filter
[**GetJobTypeById**](JobTypeApi.md#getjobtypebyid) | **GET** /beta/jobType/{jobTypeId} | Get a jobType by id
[**GetJobTypeTags**](JobTypeApi.md#getjobtypetags) | **GET** /beta/jobType/{jobTypeId}/tag | Get the tags for a jobType.
[**UpdateJobType**](JobTypeApi.md#updatejobtype) | **PUT** /beta/jobType | Update a jobType
[**UpdateJobTypeCustomFields**](JobTypeApi.md#updatejobtypecustomfields) | **PUT** /beta/jobType/customFields | Update a jobType custom fields


<a name="addjobtype"></a>
# **AddJobType**
> JobType AddJobType (JobType body)

Create a jobType

Inserts a new jobType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var body = new JobType(); // JobType | JobType to be inserted.

            try
            {
                // Create a jobType
                JobType result = apiInstance.AddJobType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.AddJobType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobType**](JobType.md)| JobType to be inserted. | 

### Return type

[**JobType**](JobType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtypeaudit"></a>
# **AddJobTypeAudit**
> void AddJobTypeAudit (int? jobTypeId, string jobTypeAudit)

Add new audit for a jobType

Adds an audit to an existing jobType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to add an audit to
            var jobTypeAudit = jobTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a jobType
                apiInstance.AddJobTypeAudit(jobTypeId, jobTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.AddJobTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to add an audit to | 
 **jobTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtypefile"></a>
# **AddJobTypeFile**
> void AddJobTypeFile (int? jobTypeId, string fileName)

Attach a file to a jobType

Adds a file to an existing jobType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a jobType
                apiInstance.AddJobTypeFile(jobTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.AddJobTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addjobtypetag"></a>
# **AddJobTypeTag**
> void AddJobTypeTag (int? jobTypeId, string jobTypeTag)

Add new tags for a jobType.

Adds a tag to an existing jobType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddJobTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to add a tag to
            var jobTypeTag = jobTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a jobType.
                apiInstance.AddJobTypeTag(jobTypeId, jobTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.AddJobTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to add a tag to | 
 **jobTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtype"></a>
# **DeleteJobType**
> void DeleteJobType (int? jobTypeId)

Delete a jobType

Deletes the jobType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to be deleted.

            try
            {
                // Delete a jobType
                apiInstance.DeleteJobType(jobTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.DeleteJobType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtypetag"></a>
# **DeleteJobTypeTag**
> void DeleteJobTypeTag (int? jobTypeId, string jobTypeTag)

Delete a tag for a jobType.

Deletes an existing jobType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteJobTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to remove tag from
            var jobTypeTag = jobTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a jobType.
                apiInstance.DeleteJobTypeTag(jobTypeId, jobTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.DeleteJobTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to remove tag from | 
 **jobTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatejobtypebyid"></a>
# **GetDuplicateJobTypeById**
> JobType GetDuplicateJobTypeById (int? jobTypeId)

Get a duplicated a jobType by id

Returns a duplicated jobType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateJobTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to be duplicated.

            try
            {
                // Get a duplicated a jobType by id
                JobType result = apiInstance.GetDuplicateJobTypeById(jobTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.GetDuplicateJobTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to be duplicated. | 

### Return type

[**JobType**](JobType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtypebyfilter"></a>
# **GetJobTypeByFilter**
> List<JobType> GetJobTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search jobTypes by filter

Returns the list of jobTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search jobTypes by filter
                List&lt;JobType&gt; result = apiInstance.GetJobTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.GetJobTypeByFilter: " + e.Message );
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

[**List<JobType>**](JobType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtypebyid"></a>
# **GetJobTypeById**
> JobType GetJobTypeById (int? jobTypeId)

Get a jobType by id

Returns the jobType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to be returned.

            try
            {
                // Get a jobType by id
                JobType result = apiInstance.GetJobTypeById(jobTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.GetJobTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to be returned. | 

### Return type

[**JobType**](JobType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobtypetags"></a>
# **GetJobTypeTags**
> void GetJobTypeTags (int? jobTypeId)

Get the tags for a jobType.

Get all existing jobType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetJobTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var jobTypeId = 56;  // int? | Id of the jobType to get tags for

            try
            {
                // Get the tags for a jobType.
                apiInstance.GetJobTypeTags(jobTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.GetJobTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobTypeId** | **int?**| Id of the jobType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobtype"></a>
# **UpdateJobType**
> void UpdateJobType (JobType body)

Update a jobType

Updates an existing jobType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var body = new JobType(); // JobType | JobType to be updated.

            try
            {
                // Update a jobType
                apiInstance.UpdateJobType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.UpdateJobType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobType**](JobType.md)| JobType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejobtypecustomfields"></a>
# **UpdateJobTypeCustomFields**
> void UpdateJobTypeCustomFields (JobType body)

Update a jobType custom fields

Updates an existing jobType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateJobTypeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new JobTypeApi();
            var body = new JobType(); // JobType | JobType to be updated.

            try
            {
                // Update a jobType custom fields
                apiInstance.UpdateJobTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobTypeApi.UpdateJobTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JobType**](JobType.md)| JobType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

