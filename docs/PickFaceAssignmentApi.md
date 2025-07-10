# Infoplus.Api.PickFaceAssignmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPickFaceAssignment**](PickFaceAssignmentApi.md#addpickfaceassignment) | **POST** /beta/pickFaceAssignment | Create a pickFaceAssignment
[**AddPickFaceAssignmentAudit**](PickFaceAssignmentApi.md#addpickfaceassignmentaudit) | **PUT** /beta/pickFaceAssignment/{pickFaceAssignmentId}/audit/{pickFaceAssignmentAudit} | Add new audit for a pickFaceAssignment
[**AddPickFaceAssignmentFile**](PickFaceAssignmentApi.md#addpickfaceassignmentfile) | **POST** /beta/pickFaceAssignment/{pickFaceAssignmentId}/file/{fileName} | Attach a file to a pickFaceAssignment
[**AddPickFaceAssignmentFileByURL**](PickFaceAssignmentApi.md#addpickfaceassignmentfilebyurl) | **POST** /beta/pickFaceAssignment/{pickFaceAssignmentId}/file | Attach a file to a pickFaceAssignment by URL.
[**AddPickFaceAssignmentTag**](PickFaceAssignmentApi.md#addpickfaceassignmenttag) | **PUT** /beta/pickFaceAssignment/{pickFaceAssignmentId}/tag/{pickFaceAssignmentTag} | Add new tags for a pickFaceAssignment.
[**DeletePickFaceAssignment**](PickFaceAssignmentApi.md#deletepickfaceassignment) | **DELETE** /beta/pickFaceAssignment/{pickFaceAssignmentId} | Delete a pickFaceAssignment
[**DeletePickFaceAssignmentFile**](PickFaceAssignmentApi.md#deletepickfaceassignmentfile) | **DELETE** /beta/pickFaceAssignment/{pickFaceAssignmentId}/file/{fileId} | Delete a file for a pickFaceAssignment.
[**DeletePickFaceAssignmentTag**](PickFaceAssignmentApi.md#deletepickfaceassignmenttag) | **DELETE** /beta/pickFaceAssignment/{pickFaceAssignmentId}/tag/{pickFaceAssignmentTag} | Delete a tag for a pickFaceAssignment.
[**GetDuplicatePickFaceAssignmentById**](PickFaceAssignmentApi.md#getduplicatepickfaceassignmentbyid) | **GET** /beta/pickFaceAssignment/duplicate/{pickFaceAssignmentId} | Get a duplicated a pickFaceAssignment by id
[**GetPickFaceAssignmentByFilter**](PickFaceAssignmentApi.md#getpickfaceassignmentbyfilter) | **GET** /beta/pickFaceAssignment/search | Search pickFaceAssignments by filter
[**GetPickFaceAssignmentById**](PickFaceAssignmentApi.md#getpickfaceassignmentbyid) | **GET** /beta/pickFaceAssignment/{pickFaceAssignmentId} | Get a pickFaceAssignment by id
[**GetPickFaceAssignmentFiles**](PickFaceAssignmentApi.md#getpickfaceassignmentfiles) | **GET** /beta/pickFaceAssignment/{pickFaceAssignmentId}/file | Get the files for a pickFaceAssignment.
[**GetPickFaceAssignmentTags**](PickFaceAssignmentApi.md#getpickfaceassignmenttags) | **GET** /beta/pickFaceAssignment/{pickFaceAssignmentId}/tag | Get the tags for a pickFaceAssignment.
[**UpdatePickFaceAssignment**](PickFaceAssignmentApi.md#updatepickfaceassignment) | **PUT** /beta/pickFaceAssignment | Update a pickFaceAssignment
[**UpdatePickFaceAssignmentCustomFields**](PickFaceAssignmentApi.md#updatepickfaceassignmentcustomfields) | **PUT** /beta/pickFaceAssignment/customFields | Update a pickFaceAssignment custom fields


<a name="addpickfaceassignment"></a>
# **AddPickFaceAssignment**
> PickFaceAssignment AddPickFaceAssignment (PickFaceAssignment body)

Create a pickFaceAssignment

Inserts a new pickFaceAssignment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPickFaceAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var body = new PickFaceAssignment(); // PickFaceAssignment | PickFaceAssignment to be inserted.

            try
            {
                // Create a pickFaceAssignment
                PickFaceAssignment result = apiInstance.AddPickFaceAssignment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.AddPickFaceAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickFaceAssignment**](PickFaceAssignment.md)| PickFaceAssignment to be inserted. | 

### Return type

[**PickFaceAssignment**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpickfaceassignmentaudit"></a>
# **AddPickFaceAssignmentAudit**
> void AddPickFaceAssignmentAudit (int? pickFaceAssignmentId, string pickFaceAssignmentAudit)

Add new audit for a pickFaceAssignment

Adds an audit to an existing pickFaceAssignment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPickFaceAssignmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to add an audit to
            var pickFaceAssignmentAudit = pickFaceAssignmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a pickFaceAssignment
                apiInstance.AddPickFaceAssignmentAudit(pickFaceAssignmentId, pickFaceAssignmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.AddPickFaceAssignmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to add an audit to | 
 **pickFaceAssignmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpickfaceassignmentfile"></a>
# **AddPickFaceAssignmentFile**
> void AddPickFaceAssignmentFile (int? pickFaceAssignmentId, string fileName)

Attach a file to a pickFaceAssignment

Adds a file to an existing pickFaceAssignment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPickFaceAssignmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a pickFaceAssignment
                apiInstance.AddPickFaceAssignmentFile(pickFaceAssignmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.AddPickFaceAssignmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpickfaceassignmentfilebyurl"></a>
# **AddPickFaceAssignmentFileByURL**
> void AddPickFaceAssignmentFileByURL (RecordFile body, int? pickFaceAssignmentId)

Attach a file to a pickFaceAssignment by URL.

Adds a file to an existing pickFaceAssignment by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPickFaceAssignmentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to add an file to

            try
            {
                // Attach a file to a pickFaceAssignment by URL.
                apiInstance.AddPickFaceAssignmentFileByURL(body, pickFaceAssignmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.AddPickFaceAssignmentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpickfaceassignmenttag"></a>
# **AddPickFaceAssignmentTag**
> void AddPickFaceAssignmentTag (int? pickFaceAssignmentId, string pickFaceAssignmentTag)

Add new tags for a pickFaceAssignment.

Adds a tag to an existing pickFaceAssignment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPickFaceAssignmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to add a tag to
            var pickFaceAssignmentTag = pickFaceAssignmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a pickFaceAssignment.
                apiInstance.AddPickFaceAssignmentTag(pickFaceAssignmentId, pickFaceAssignmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.AddPickFaceAssignmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to add a tag to | 
 **pickFaceAssignmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepickfaceassignment"></a>
# **DeletePickFaceAssignment**
> void DeletePickFaceAssignment (int? pickFaceAssignmentId)

Delete a pickFaceAssignment

Deletes the pickFaceAssignment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePickFaceAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to be deleted.

            try
            {
                // Delete a pickFaceAssignment
                apiInstance.DeletePickFaceAssignment(pickFaceAssignmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.DeletePickFaceAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepickfaceassignmentfile"></a>
# **DeletePickFaceAssignmentFile**
> void DeletePickFaceAssignmentFile (int? pickFaceAssignmentId, int? fileId)

Delete a file for a pickFaceAssignment.

Deletes an existing pickFaceAssignment file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePickFaceAssignmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a pickFaceAssignment.
                apiInstance.DeletePickFaceAssignmentFile(pickFaceAssignmentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.DeletePickFaceAssignmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepickfaceassignmenttag"></a>
# **DeletePickFaceAssignmentTag**
> void DeletePickFaceAssignmentTag (int? pickFaceAssignmentId, string pickFaceAssignmentTag)

Delete a tag for a pickFaceAssignment.

Deletes an existing pickFaceAssignment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePickFaceAssignmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to remove tag from
            var pickFaceAssignmentTag = pickFaceAssignmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a pickFaceAssignment.
                apiInstance.DeletePickFaceAssignmentTag(pickFaceAssignmentId, pickFaceAssignmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.DeletePickFaceAssignmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to remove tag from | 
 **pickFaceAssignmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatepickfaceassignmentbyid"></a>
# **GetDuplicatePickFaceAssignmentById**
> PickFaceAssignment GetDuplicatePickFaceAssignmentById (int? pickFaceAssignmentId)

Get a duplicated a pickFaceAssignment by id

Returns a duplicated pickFaceAssignment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicatePickFaceAssignmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to be duplicated.

            try
            {
                // Get a duplicated a pickFaceAssignment by id
                PickFaceAssignment result = apiInstance.GetDuplicatePickFaceAssignmentById(pickFaceAssignmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetDuplicatePickFaceAssignmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to be duplicated. | 

### Return type

[**PickFaceAssignment**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpickfaceassignmentbyfilter"></a>
# **GetPickFaceAssignmentByFilter**
> List<PickFaceAssignment> GetPickFaceAssignmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search pickFaceAssignments by filter

Returns the list of pickFaceAssignments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPickFaceAssignmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search pickFaceAssignments by filter
                List&lt;PickFaceAssignment&gt; result = apiInstance.GetPickFaceAssignmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetPickFaceAssignmentByFilter: " + e.Message );
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

[**List<PickFaceAssignment>**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpickfaceassignmentbyid"></a>
# **GetPickFaceAssignmentById**
> PickFaceAssignment GetPickFaceAssignmentById (int? pickFaceAssignmentId)

Get a pickFaceAssignment by id

Returns the pickFaceAssignment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPickFaceAssignmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to be returned.

            try
            {
                // Get a pickFaceAssignment by id
                PickFaceAssignment result = apiInstance.GetPickFaceAssignmentById(pickFaceAssignmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetPickFaceAssignmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to be returned. | 

### Return type

[**PickFaceAssignment**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpickfaceassignmentfiles"></a>
# **GetPickFaceAssignmentFiles**
> void GetPickFaceAssignmentFiles (int? pickFaceAssignmentId)

Get the files for a pickFaceAssignment.

Get all existing pickFaceAssignment files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPickFaceAssignmentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to get files for

            try
            {
                // Get the files for a pickFaceAssignment.
                apiInstance.GetPickFaceAssignmentFiles(pickFaceAssignmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetPickFaceAssignmentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpickfaceassignmenttags"></a>
# **GetPickFaceAssignmentTags**
> void GetPickFaceAssignmentTags (int? pickFaceAssignmentId)

Get the tags for a pickFaceAssignment.

Get all existing pickFaceAssignment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPickFaceAssignmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to get tags for

            try
            {
                // Get the tags for a pickFaceAssignment.
                apiInstance.GetPickFaceAssignmentTags(pickFaceAssignmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetPickFaceAssignmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepickfaceassignment"></a>
# **UpdatePickFaceAssignment**
> void UpdatePickFaceAssignment (PickFaceAssignment body)

Update a pickFaceAssignment

Updates an existing pickFaceAssignment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePickFaceAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var body = new PickFaceAssignment(); // PickFaceAssignment | PickFaceAssignment to be updated.

            try
            {
                // Update a pickFaceAssignment
                apiInstance.UpdatePickFaceAssignment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.UpdatePickFaceAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickFaceAssignment**](PickFaceAssignment.md)| PickFaceAssignment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepickfaceassignmentcustomfields"></a>
# **UpdatePickFaceAssignmentCustomFields**
> void UpdatePickFaceAssignmentCustomFields (PickFaceAssignment body)

Update a pickFaceAssignment custom fields

Updates an existing pickFaceAssignment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePickFaceAssignmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PickFaceAssignmentApi();
            var body = new PickFaceAssignment(); // PickFaceAssignment | PickFaceAssignment to be updated.

            try
            {
                // Update a pickFaceAssignment custom fields
                apiInstance.UpdatePickFaceAssignmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.UpdatePickFaceAssignmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickFaceAssignment**](PickFaceAssignment.md)| PickFaceAssignment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

