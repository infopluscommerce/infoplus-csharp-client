# Infoplus.Api.Gs1128TemplateApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGs1128Template**](Gs1128TemplateApi.md#addgs1128template) | **POST** /beta/gs1128Template | Create a gs1128Template
[**AddGs1128TemplateAudit**](Gs1128TemplateApi.md#addgs1128templateaudit) | **PUT** /beta/gs1128Template/{gs1128TemplateId}/audit/{gs1128TemplateAudit} | Add new audit for a gs1128Template
[**AddGs1128TemplateFile**](Gs1128TemplateApi.md#addgs1128templatefile) | **POST** /beta/gs1128Template/{gs1128TemplateId}/file/{fileName} | Attach a file to a gs1128Template
[**AddGs1128TemplateFileByURL**](Gs1128TemplateApi.md#addgs1128templatefilebyurl) | **POST** /beta/gs1128Template/{gs1128TemplateId}/file | Attach a file to a gs1128Template by URL.
[**AddGs1128TemplateTag**](Gs1128TemplateApi.md#addgs1128templatetag) | **PUT** /beta/gs1128Template/{gs1128TemplateId}/tag/{gs1128TemplateTag} | Add new tags for a gs1128Template.
[**DeleteGs1128Template**](Gs1128TemplateApi.md#deletegs1128template) | **DELETE** /beta/gs1128Template/{gs1128TemplateId} | Delete a gs1128Template
[**DeleteGs1128TemplateFile**](Gs1128TemplateApi.md#deletegs1128templatefile) | **DELETE** /beta/gs1128Template/{gs1128TemplateId}/file/{fileId} | Delete a file for a gs1128Template.
[**DeleteGs1128TemplateTag**](Gs1128TemplateApi.md#deletegs1128templatetag) | **DELETE** /beta/gs1128Template/{gs1128TemplateId}/tag/{gs1128TemplateTag} | Delete a tag for a gs1128Template.
[**GetDuplicateGs1128TemplateById**](Gs1128TemplateApi.md#getduplicategs1128templatebyid) | **GET** /beta/gs1128Template/duplicate/{gs1128TemplateId} | Get a duplicated a gs1128Template by id
[**GetGs1128TemplateByFilter**](Gs1128TemplateApi.md#getgs1128templatebyfilter) | **GET** /beta/gs1128Template/search | Search gs1128Templates by filter
[**GetGs1128TemplateById**](Gs1128TemplateApi.md#getgs1128templatebyid) | **GET** /beta/gs1128Template/{gs1128TemplateId} | Get a gs1128Template by id
[**GetGs1128TemplateFiles**](Gs1128TemplateApi.md#getgs1128templatefiles) | **GET** /beta/gs1128Template/{gs1128TemplateId}/file | Get the files for a gs1128Template.
[**GetGs1128TemplateTags**](Gs1128TemplateApi.md#getgs1128templatetags) | **GET** /beta/gs1128Template/{gs1128TemplateId}/tag | Get the tags for a gs1128Template.
[**UpdateGs1128Template**](Gs1128TemplateApi.md#updategs1128template) | **PUT** /beta/gs1128Template | Update a gs1128Template


<a name="addgs1128template"></a>
# **AddGs1128Template**
> Gs1128Template AddGs1128Template (Gs1128Template body)

Create a gs1128Template

Inserts a new gs1128Template using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128TemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var body = new Gs1128Template(); // Gs1128Template | Gs1128Template to be inserted.

            try
            {
                // Create a gs1128Template
                Gs1128Template result = apiInstance.AddGs1128Template(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.AddGs1128Template: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Gs1128Template**](Gs1128Template.md)| Gs1128Template to be inserted. | 

### Return type

[**Gs1128Template**](Gs1128Template.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128templateaudit"></a>
# **AddGs1128TemplateAudit**
> void AddGs1128TemplateAudit (int? gs1128TemplateId, string gs1128TemplateAudit)

Add new audit for a gs1128Template

Adds an audit to an existing gs1128Template.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128TemplateAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to add an audit to
            var gs1128TemplateAudit = gs1128TemplateAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a gs1128Template
                apiInstance.AddGs1128TemplateAudit(gs1128TemplateId, gs1128TemplateAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.AddGs1128TemplateAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to add an audit to | 
 **gs1128TemplateAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128templatefile"></a>
# **AddGs1128TemplateFile**
> void AddGs1128TemplateFile (int? gs1128TemplateId, string fileName)

Attach a file to a gs1128Template

Adds a file to an existing gs1128Template.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128TemplateFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a gs1128Template
                apiInstance.AddGs1128TemplateFile(gs1128TemplateId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.AddGs1128TemplateFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128templatefilebyurl"></a>
# **AddGs1128TemplateFileByURL**
> void AddGs1128TemplateFileByURL (RecordFile body, int? gs1128TemplateId)

Attach a file to a gs1128Template by URL.

Adds a file to an existing gs1128Template by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128TemplateFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to add an file to

            try
            {
                // Attach a file to a gs1128Template by URL.
                apiInstance.AddGs1128TemplateFileByURL(body, gs1128TemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.AddGs1128TemplateFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128templatetag"></a>
# **AddGs1128TemplateTag**
> void AddGs1128TemplateTag (int? gs1128TemplateId, string gs1128TemplateTag)

Add new tags for a gs1128Template.

Adds a tag to an existing gs1128Template.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128TemplateTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to add a tag to
            var gs1128TemplateTag = gs1128TemplateTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a gs1128Template.
                apiInstance.AddGs1128TemplateTag(gs1128TemplateId, gs1128TemplateTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.AddGs1128TemplateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to add a tag to | 
 **gs1128TemplateTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegs1128template"></a>
# **DeleteGs1128Template**
> void DeleteGs1128Template (int? gs1128TemplateId)

Delete a gs1128Template

Deletes the gs1128Template identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteGs1128TemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to be deleted.

            try
            {
                // Delete a gs1128Template
                apiInstance.DeleteGs1128Template(gs1128TemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.DeleteGs1128Template: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegs1128templatefile"></a>
# **DeleteGs1128TemplateFile**
> void DeleteGs1128TemplateFile (int? gs1128TemplateId, int? fileId)

Delete a file for a gs1128Template.

Deletes an existing gs1128Template file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteGs1128TemplateFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a gs1128Template.
                apiInstance.DeleteGs1128TemplateFile(gs1128TemplateId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.DeleteGs1128TemplateFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegs1128templatetag"></a>
# **DeleteGs1128TemplateTag**
> void DeleteGs1128TemplateTag (int? gs1128TemplateId, string gs1128TemplateTag)

Delete a tag for a gs1128Template.

Deletes an existing gs1128Template tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteGs1128TemplateTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to remove tag from
            var gs1128TemplateTag = gs1128TemplateTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a gs1128Template.
                apiInstance.DeleteGs1128TemplateTag(gs1128TemplateId, gs1128TemplateTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.DeleteGs1128TemplateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to remove tag from | 
 **gs1128TemplateTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicategs1128templatebyid"></a>
# **GetDuplicateGs1128TemplateById**
> Gs1128Template GetDuplicateGs1128TemplateById (int? gs1128TemplateId)

Get a duplicated a gs1128Template by id

Returns a duplicated gs1128Template identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateGs1128TemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to be duplicated.

            try
            {
                // Get a duplicated a gs1128Template by id
                Gs1128Template result = apiInstance.GetDuplicateGs1128TemplateById(gs1128TemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.GetDuplicateGs1128TemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to be duplicated. | 

### Return type

[**Gs1128Template**](Gs1128Template.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128templatebyfilter"></a>
# **GetGs1128TemplateByFilter**
> List<Gs1128Template> GetGs1128TemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search gs1128Templates by filter

Returns the list of gs1128Templates that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128TemplateByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search gs1128Templates by filter
                List&lt;Gs1128Template&gt; result = apiInstance.GetGs1128TemplateByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.GetGs1128TemplateByFilter: " + e.Message );
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

[**List<Gs1128Template>**](Gs1128Template.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128templatebyid"></a>
# **GetGs1128TemplateById**
> Gs1128Template GetGs1128TemplateById (int? gs1128TemplateId)

Get a gs1128Template by id

Returns the gs1128Template identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128TemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to be returned.

            try
            {
                // Get a gs1128Template by id
                Gs1128Template result = apiInstance.GetGs1128TemplateById(gs1128TemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.GetGs1128TemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to be returned. | 

### Return type

[**Gs1128Template**](Gs1128Template.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128templatefiles"></a>
# **GetGs1128TemplateFiles**
> void GetGs1128TemplateFiles (int? gs1128TemplateId)

Get the files for a gs1128Template.

Get all existing gs1128Template files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128TemplateFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to get files for

            try
            {
                // Get the files for a gs1128Template.
                apiInstance.GetGs1128TemplateFiles(gs1128TemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.GetGs1128TemplateFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128templatetags"></a>
# **GetGs1128TemplateTags**
> void GetGs1128TemplateTags (int? gs1128TemplateId)

Get the tags for a gs1128Template.

Get all existing gs1128Template tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128TemplateTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var gs1128TemplateId = 56;  // int? | Id of the gs1128Template to get tags for

            try
            {
                // Get the tags for a gs1128Template.
                apiInstance.GetGs1128TemplateTags(gs1128TemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.GetGs1128TemplateTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128TemplateId** | **int?**| Id of the gs1128Template to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategs1128template"></a>
# **UpdateGs1128Template**
> void UpdateGs1128Template (Gs1128Template body)

Update a gs1128Template

Updates an existing gs1128Template using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateGs1128TemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128TemplateApi();
            var body = new Gs1128Template(); // Gs1128Template | Gs1128Template to be updated.

            try
            {
                // Update a gs1128Template
                apiInstance.UpdateGs1128Template(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128TemplateApi.UpdateGs1128Template: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Gs1128Template**](Gs1128Template.md)| Gs1128Template to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

