# Infoplus.Api.Gs1128LabelApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGs1128LabelAudit**](Gs1128LabelApi.md#addgs1128labelaudit) | **PUT** /v3.0/gs1128Label/{gs1128LabelId}/audit/{gs1128LabelAudit} | Add new audit for a gs1128Label
[**AddGs1128LabelFile**](Gs1128LabelApi.md#addgs1128labelfile) | **POST** /v3.0/gs1128Label/{gs1128LabelId}/file/{fileName} | Attach a file to a gs1128Label
[**AddGs1128LabelFileByURL**](Gs1128LabelApi.md#addgs1128labelfilebyurl) | **POST** /v3.0/gs1128Label/{gs1128LabelId}/file | Attach a file to a gs1128Label by URL.
[**AddGs1128LabelTag**](Gs1128LabelApi.md#addgs1128labeltag) | **PUT** /v3.0/gs1128Label/{gs1128LabelId}/tag/{gs1128LabelTag} | Add new tags for a gs1128Label.
[**DeleteGs1128Label**](Gs1128LabelApi.md#deletegs1128label) | **DELETE** /v3.0/gs1128Label/{gs1128LabelId} | Delete a gs1128Label
[**DeleteGs1128LabelFile**](Gs1128LabelApi.md#deletegs1128labelfile) | **DELETE** /v3.0/gs1128Label/{gs1128LabelId}/file/{fileId} | Delete a file for a gs1128Label.
[**DeleteGs1128LabelTag**](Gs1128LabelApi.md#deletegs1128labeltag) | **DELETE** /v3.0/gs1128Label/{gs1128LabelId}/tag/{gs1128LabelTag} | Delete a tag for a gs1128Label.
[**GetDuplicateGs1128LabelById**](Gs1128LabelApi.md#getduplicategs1128labelbyid) | **GET** /v3.0/gs1128Label/duplicate/{gs1128LabelId} | Get a duplicated a gs1128Label by id
[**GetGs1128LabelByFilter**](Gs1128LabelApi.md#getgs1128labelbyfilter) | **GET** /v3.0/gs1128Label/search | Search gs1128Labels by filter
[**GetGs1128LabelById**](Gs1128LabelApi.md#getgs1128labelbyid) | **GET** /v3.0/gs1128Label/{gs1128LabelId} | Get a gs1128Label by id
[**GetGs1128LabelFiles**](Gs1128LabelApi.md#getgs1128labelfiles) | **GET** /v3.0/gs1128Label/{gs1128LabelId}/file | Get the files for a gs1128Label.
[**GetGs1128LabelTags**](Gs1128LabelApi.md#getgs1128labeltags) | **GET** /v3.0/gs1128Label/{gs1128LabelId}/tag | Get the tags for a gs1128Label.
[**UpdateGs1128LabelCustomFields**](Gs1128LabelApi.md#updategs1128labelcustomfields) | **PUT** /v3.0/gs1128Label/customFields | Update a gs1128Label custom fields


<a name="addgs1128labelaudit"></a>
# **AddGs1128LabelAudit**
> void AddGs1128LabelAudit (int? gs1128LabelId, string gs1128LabelAudit)

Add new audit for a gs1128Label

Adds an audit to an existing gs1128Label.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128LabelAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to add an audit to
            var gs1128LabelAudit = gs1128LabelAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a gs1128Label
                apiInstance.AddGs1128LabelAudit(gs1128LabelId, gs1128LabelAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.AddGs1128LabelAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to add an audit to | 
 **gs1128LabelAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128labelfile"></a>
# **AddGs1128LabelFile**
> void AddGs1128LabelFile (int? gs1128LabelId, string fileName)

Attach a file to a gs1128Label

Adds a file to an existing gs1128Label.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128LabelFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a gs1128Label
                apiInstance.AddGs1128LabelFile(gs1128LabelId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.AddGs1128LabelFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128labelfilebyurl"></a>
# **AddGs1128LabelFileByURL**
> void AddGs1128LabelFileByURL (RecordFile body, int? gs1128LabelId)

Attach a file to a gs1128Label by URL.

Adds a file to an existing gs1128Label by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128LabelFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to add an file to

            try
            {
                // Attach a file to a gs1128Label by URL.
                apiInstance.AddGs1128LabelFileByURL(body, gs1128LabelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.AddGs1128LabelFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **gs1128LabelId** | **int?**| Id of the gs1128Label to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgs1128labeltag"></a>
# **AddGs1128LabelTag**
> void AddGs1128LabelTag (int? gs1128LabelId, string gs1128LabelTag)

Add new tags for a gs1128Label.

Adds a tag to an existing gs1128Label.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddGs1128LabelTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to add a tag to
            var gs1128LabelTag = gs1128LabelTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a gs1128Label.
                apiInstance.AddGs1128LabelTag(gs1128LabelId, gs1128LabelTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.AddGs1128LabelTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to add a tag to | 
 **gs1128LabelTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegs1128label"></a>
# **DeleteGs1128Label**
> void DeleteGs1128Label (int? gs1128LabelId)

Delete a gs1128Label

Deletes the gs1128Label identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteGs1128LabelExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to be deleted.

            try
            {
                // Delete a gs1128Label
                apiInstance.DeleteGs1128Label(gs1128LabelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.DeleteGs1128Label: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegs1128labelfile"></a>
# **DeleteGs1128LabelFile**
> void DeleteGs1128LabelFile (int? gs1128LabelId, int? fileId)

Delete a file for a gs1128Label.

Deletes an existing gs1128Label file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteGs1128LabelFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a gs1128Label.
                apiInstance.DeleteGs1128LabelFile(gs1128LabelId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.DeleteGs1128LabelFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegs1128labeltag"></a>
# **DeleteGs1128LabelTag**
> void DeleteGs1128LabelTag (int? gs1128LabelId, string gs1128LabelTag)

Delete a tag for a gs1128Label.

Deletes an existing gs1128Label tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteGs1128LabelTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to remove tag from
            var gs1128LabelTag = gs1128LabelTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a gs1128Label.
                apiInstance.DeleteGs1128LabelTag(gs1128LabelId, gs1128LabelTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.DeleteGs1128LabelTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to remove tag from | 
 **gs1128LabelTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicategs1128labelbyid"></a>
# **GetDuplicateGs1128LabelById**
> GS1128Label GetDuplicateGs1128LabelById (int? gs1128LabelId)

Get a duplicated a gs1128Label by id

Returns a duplicated gs1128Label identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateGs1128LabelByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to be duplicated.

            try
            {
                // Get a duplicated a gs1128Label by id
                GS1128Label result = apiInstance.GetDuplicateGs1128LabelById(gs1128LabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.GetDuplicateGs1128LabelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to be duplicated. | 

### Return type

[**GS1128Label**](GS1128Label.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128labelbyfilter"></a>
# **GetGs1128LabelByFilter**
> List<GS1128Label> GetGs1128LabelByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search gs1128Labels by filter

Returns the list of gs1128Labels that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128LabelByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search gs1128Labels by filter
                List&lt;GS1128Label&gt; result = apiInstance.GetGs1128LabelByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.GetGs1128LabelByFilter: " + e.Message );
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

[**List<GS1128Label>**](GS1128Label.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128labelbyid"></a>
# **GetGs1128LabelById**
> GS1128Label GetGs1128LabelById (int? gs1128LabelId)

Get a gs1128Label by id

Returns the gs1128Label identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128LabelByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to be returned.

            try
            {
                // Get a gs1128Label by id
                GS1128Label result = apiInstance.GetGs1128LabelById(gs1128LabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.GetGs1128LabelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to be returned. | 

### Return type

[**GS1128Label**](GS1128Label.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128labelfiles"></a>
# **GetGs1128LabelFiles**
> void GetGs1128LabelFiles (int? gs1128LabelId)

Get the files for a gs1128Label.

Get all existing gs1128Label files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128LabelFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to get files for

            try
            {
                // Get the files for a gs1128Label.
                apiInstance.GetGs1128LabelFiles(gs1128LabelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.GetGs1128LabelFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgs1128labeltags"></a>
# **GetGs1128LabelTags**
> void GetGs1128LabelTags (int? gs1128LabelId)

Get the tags for a gs1128Label.

Get all existing gs1128Label tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetGs1128LabelTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var gs1128LabelId = 56;  // int? | Id of the gs1128Label to get tags for

            try
            {
                // Get the tags for a gs1128Label.
                apiInstance.GetGs1128LabelTags(gs1128LabelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.GetGs1128LabelTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gs1128LabelId** | **int?**| Id of the gs1128Label to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategs1128labelcustomfields"></a>
# **UpdateGs1128LabelCustomFields**
> void UpdateGs1128LabelCustomFields (GS1128Label body)

Update a gs1128Label custom fields

Updates an existing gs1128Label custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateGs1128LabelCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new Gs1128LabelApi();
            var body = new GS1128Label(); // GS1128Label | Gs1128Label to be updated.

            try
            {
                // Update a gs1128Label custom fields
                apiInstance.UpdateGs1128LabelCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Gs1128LabelApi.UpdateGs1128LabelCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GS1128Label**](GS1128Label.md)| Gs1128Label to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

