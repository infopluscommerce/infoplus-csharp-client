# Infoplus.Api.LoadContentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLoadContentAudit**](LoadContentApi.md#addloadcontentaudit) | **PUT** /v3.0/loadContent/{loadContentId}/audit/{loadContentAudit} | Add new audit for a loadContent
[**AddLoadContentFile**](LoadContentApi.md#addloadcontentfile) | **POST** /v3.0/loadContent/{loadContentId}/file/{fileName} | Attach a file to a loadContent
[**AddLoadContentFileByURL**](LoadContentApi.md#addloadcontentfilebyurl) | **POST** /v3.0/loadContent/{loadContentId}/file | Attach a file to a loadContent by URL.
[**AddLoadContentTag**](LoadContentApi.md#addloadcontenttag) | **PUT** /v3.0/loadContent/{loadContentId}/tag/{loadContentTag} | Add new tags for a loadContent.
[**DeleteLoadContentFile**](LoadContentApi.md#deleteloadcontentfile) | **DELETE** /v3.0/loadContent/{loadContentId}/file/{fileId} | Delete a file for a loadContent.
[**DeleteLoadContentTag**](LoadContentApi.md#deleteloadcontenttag) | **DELETE** /v3.0/loadContent/{loadContentId}/tag/{loadContentTag} | Delete a tag for a loadContent.
[**GetDuplicateLoadContentById**](LoadContentApi.md#getduplicateloadcontentbyid) | **GET** /v3.0/loadContent/duplicate/{loadContentId} | Get a duplicated a loadContent by id
[**GetLoadContentByFilter**](LoadContentApi.md#getloadcontentbyfilter) | **GET** /v3.0/loadContent/search | Search loadContents by filter
[**GetLoadContentById**](LoadContentApi.md#getloadcontentbyid) | **GET** /v3.0/loadContent/{loadContentId} | Get a loadContent by id
[**GetLoadContentFiles**](LoadContentApi.md#getloadcontentfiles) | **GET** /v3.0/loadContent/{loadContentId}/file | Get the files for a loadContent.
[**GetLoadContentTags**](LoadContentApi.md#getloadcontenttags) | **GET** /v3.0/loadContent/{loadContentId}/tag | Get the tags for a loadContent.
[**UpdateLoadContentCustomFields**](LoadContentApi.md#updateloadcontentcustomfields) | **PUT** /v3.0/loadContent/customFields | Update a loadContent custom fields


<a name="addloadcontentaudit"></a>
# **AddLoadContentAudit**
> void AddLoadContentAudit (int? loadContentId, string loadContentAudit)

Add new audit for a loadContent

Adds an audit to an existing loadContent.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadContentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to add an audit to
            var loadContentAudit = loadContentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a loadContent
                apiInstance.AddLoadContentAudit(loadContentId, loadContentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.AddLoadContentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to add an audit to | 
 **loadContentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloadcontentfile"></a>
# **AddLoadContentFile**
> void AddLoadContentFile (int? loadContentId, string fileName)

Attach a file to a loadContent

Adds a file to an existing loadContent.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadContentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a loadContent
                apiInstance.AddLoadContentFile(loadContentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.AddLoadContentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloadcontentfilebyurl"></a>
# **AddLoadContentFileByURL**
> void AddLoadContentFileByURL (RecordFile body, int? loadContentId)

Attach a file to a loadContent by URL.

Adds a file to an existing loadContent by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadContentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var loadContentId = 56;  // int? | Id of the loadContent to add an file to

            try
            {
                // Attach a file to a loadContent by URL.
                apiInstance.AddLoadContentFileByURL(body, loadContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.AddLoadContentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **loadContentId** | **int?**| Id of the loadContent to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloadcontenttag"></a>
# **AddLoadContentTag**
> void AddLoadContentTag (int? loadContentId, string loadContentTag)

Add new tags for a loadContent.

Adds a tag to an existing loadContent.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadContentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to add a tag to
            var loadContentTag = loadContentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a loadContent.
                apiInstance.AddLoadContentTag(loadContentId, loadContentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.AddLoadContentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to add a tag to | 
 **loadContentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloadcontentfile"></a>
# **DeleteLoadContentFile**
> void DeleteLoadContentFile (int? loadContentId, int? fileId)

Delete a file for a loadContent.

Deletes an existing loadContent file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLoadContentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a loadContent.
                apiInstance.DeleteLoadContentFile(loadContentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.DeleteLoadContentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloadcontenttag"></a>
# **DeleteLoadContentTag**
> void DeleteLoadContentTag (int? loadContentId, string loadContentTag)

Delete a tag for a loadContent.

Deletes an existing loadContent tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLoadContentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to remove tag from
            var loadContentTag = loadContentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a loadContent.
                apiInstance.DeleteLoadContentTag(loadContentId, loadContentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.DeleteLoadContentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to remove tag from | 
 **loadContentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateloadcontentbyid"></a>
# **GetDuplicateLoadContentById**
> LoadContent GetDuplicateLoadContentById (int? loadContentId)

Get a duplicated a loadContent by id

Returns a duplicated loadContent identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLoadContentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to be duplicated.

            try
            {
                // Get a duplicated a loadContent by id
                LoadContent result = apiInstance.GetDuplicateLoadContentById(loadContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.GetDuplicateLoadContentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to be duplicated. | 

### Return type

[**LoadContent**](LoadContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadcontentbyfilter"></a>
# **GetLoadContentByFilter**
> List<LoadContent> GetLoadContentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search loadContents by filter

Returns the list of loadContents that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadContentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search loadContents by filter
                List&lt;LoadContent&gt; result = apiInstance.GetLoadContentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.GetLoadContentByFilter: " + e.Message );
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

[**List<LoadContent>**](LoadContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadcontentbyid"></a>
# **GetLoadContentById**
> LoadContent GetLoadContentById (int? loadContentId)

Get a loadContent by id

Returns the loadContent identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadContentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to be returned.

            try
            {
                // Get a loadContent by id
                LoadContent result = apiInstance.GetLoadContentById(loadContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.GetLoadContentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to be returned. | 

### Return type

[**LoadContent**](LoadContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadcontentfiles"></a>
# **GetLoadContentFiles**
> void GetLoadContentFiles (int? loadContentId)

Get the files for a loadContent.

Get all existing loadContent files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadContentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to get files for

            try
            {
                // Get the files for a loadContent.
                apiInstance.GetLoadContentFiles(loadContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.GetLoadContentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadcontenttags"></a>
# **GetLoadContentTags**
> void GetLoadContentTags (int? loadContentId)

Get the tags for a loadContent.

Get all existing loadContent tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadContentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var loadContentId = 56;  // int? | Id of the loadContent to get tags for

            try
            {
                // Get the tags for a loadContent.
                apiInstance.GetLoadContentTags(loadContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.GetLoadContentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadContentId** | **int?**| Id of the loadContent to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloadcontentcustomfields"></a>
# **UpdateLoadContentCustomFields**
> void UpdateLoadContentCustomFields (LoadContent body)

Update a loadContent custom fields

Updates an existing loadContent custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLoadContentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadContentApi();
            var body = new LoadContent(); // LoadContent | LoadContent to be updated.

            try
            {
                // Update a loadContent custom fields
                apiInstance.UpdateLoadContentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadContentApi.UpdateLoadContentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoadContent**](LoadContent.md)| LoadContent to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

