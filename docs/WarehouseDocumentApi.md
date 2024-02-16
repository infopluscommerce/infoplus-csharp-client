# Infoplus.Api.WarehouseDocumentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWarehouseDocumentAudit**](WarehouseDocumentApi.md#addwarehousedocumentaudit) | **PUT** /beta/warehouseDocument/{warehouseDocumentId}/audit/{warehouseDocumentAudit} | Add new audit for a warehouseDocument
[**AddWarehouseDocumentFile**](WarehouseDocumentApi.md#addwarehousedocumentfile) | **POST** /beta/warehouseDocument/{warehouseDocumentId}/file/{fileName} | Attach a file to a warehouseDocument
[**AddWarehouseDocumentFileByURL**](WarehouseDocumentApi.md#addwarehousedocumentfilebyurl) | **POST** /beta/warehouseDocument/{warehouseDocumentId}/file | Attach a file to a warehouseDocument by URL.
[**AddWarehouseDocumentTag**](WarehouseDocumentApi.md#addwarehousedocumenttag) | **PUT** /beta/warehouseDocument/{warehouseDocumentId}/tag/{warehouseDocumentTag} | Add new tags for a warehouseDocument.
[**DeleteWarehouseDocumentFile**](WarehouseDocumentApi.md#deletewarehousedocumentfile) | **DELETE** /beta/warehouseDocument/{warehouseDocumentId}/file/{fileId} | Delete a file for a warehouseDocument.
[**DeleteWarehouseDocumentTag**](WarehouseDocumentApi.md#deletewarehousedocumenttag) | **DELETE** /beta/warehouseDocument/{warehouseDocumentId}/tag/{warehouseDocumentTag} | Delete a tag for a warehouseDocument.
[**GetDuplicateWarehouseDocumentById**](WarehouseDocumentApi.md#getduplicatewarehousedocumentbyid) | **GET** /beta/warehouseDocument/duplicate/{warehouseDocumentId} | Get a duplicated a warehouseDocument by id
[**GetWarehouseDocumentByFilter**](WarehouseDocumentApi.md#getwarehousedocumentbyfilter) | **GET** /beta/warehouseDocument/search | Search warehouseDocuments by filter
[**GetWarehouseDocumentById**](WarehouseDocumentApi.md#getwarehousedocumentbyid) | **GET** /beta/warehouseDocument/{warehouseDocumentId} | Get a warehouseDocument by id
[**GetWarehouseDocumentFiles**](WarehouseDocumentApi.md#getwarehousedocumentfiles) | **GET** /beta/warehouseDocument/{warehouseDocumentId}/file | Get the files for a warehouseDocument.
[**GetWarehouseDocumentTags**](WarehouseDocumentApi.md#getwarehousedocumenttags) | **GET** /beta/warehouseDocument/{warehouseDocumentId}/tag | Get the tags for a warehouseDocument.
[**UpdateWarehouseDocumentCustomFields**](WarehouseDocumentApi.md#updatewarehousedocumentcustomfields) | **PUT** /beta/warehouseDocument/customFields | Update a warehouseDocument custom fields


<a name="addwarehousedocumentaudit"></a>
# **AddWarehouseDocumentAudit**
> void AddWarehouseDocumentAudit (int? warehouseDocumentId, string warehouseDocumentAudit)

Add new audit for a warehouseDocument

Adds an audit to an existing warehouseDocument.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to add an audit to
            var warehouseDocumentAudit = warehouseDocumentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a warehouseDocument
                apiInstance.AddWarehouseDocumentAudit(warehouseDocumentId, warehouseDocumentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.AddWarehouseDocumentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to add an audit to | 
 **warehouseDocumentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousedocumentfile"></a>
# **AddWarehouseDocumentFile**
> void AddWarehouseDocumentFile (int? warehouseDocumentId, string fileName)

Attach a file to a warehouseDocument

Adds a file to an existing warehouseDocument.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a warehouseDocument
                apiInstance.AddWarehouseDocumentFile(warehouseDocumentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.AddWarehouseDocumentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousedocumentfilebyurl"></a>
# **AddWarehouseDocumentFileByURL**
> void AddWarehouseDocumentFileByURL (RecordFile body, int? warehouseDocumentId)

Attach a file to a warehouseDocument by URL.

Adds a file to an existing warehouseDocument by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to add an file to

            try
            {
                // Attach a file to a warehouseDocument by URL.
                apiInstance.AddWarehouseDocumentFileByURL(body, warehouseDocumentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.AddWarehouseDocumentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousedocumenttag"></a>
# **AddWarehouseDocumentTag**
> void AddWarehouseDocumentTag (int? warehouseDocumentId, string warehouseDocumentTag)

Add new tags for a warehouseDocument.

Adds a tag to an existing warehouseDocument.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to add a tag to
            var warehouseDocumentTag = warehouseDocumentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a warehouseDocument.
                apiInstance.AddWarehouseDocumentTag(warehouseDocumentId, warehouseDocumentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.AddWarehouseDocumentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to add a tag to | 
 **warehouseDocumentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehousedocumentfile"></a>
# **DeleteWarehouseDocumentFile**
> void DeleteWarehouseDocumentFile (int? warehouseDocumentId, int? fileId)

Delete a file for a warehouseDocument.

Deletes an existing warehouseDocument file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseDocumentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a warehouseDocument.
                apiInstance.DeleteWarehouseDocumentFile(warehouseDocumentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.DeleteWarehouseDocumentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehousedocumenttag"></a>
# **DeleteWarehouseDocumentTag**
> void DeleteWarehouseDocumentTag (int? warehouseDocumentId, string warehouseDocumentTag)

Delete a tag for a warehouseDocument.

Deletes an existing warehouseDocument tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseDocumentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to remove tag from
            var warehouseDocumentTag = warehouseDocumentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a warehouseDocument.
                apiInstance.DeleteWarehouseDocumentTag(warehouseDocumentId, warehouseDocumentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.DeleteWarehouseDocumentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to remove tag from | 
 **warehouseDocumentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatewarehousedocumentbyid"></a>
# **GetDuplicateWarehouseDocumentById**
> WarehouseDocument GetDuplicateWarehouseDocumentById (int? warehouseDocumentId)

Get a duplicated a warehouseDocument by id

Returns a duplicated warehouseDocument identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWarehouseDocumentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to be duplicated.

            try
            {
                // Get a duplicated a warehouseDocument by id
                WarehouseDocument result = apiInstance.GetDuplicateWarehouseDocumentById(warehouseDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.GetDuplicateWarehouseDocumentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to be duplicated. | 

### Return type

[**WarehouseDocument**](WarehouseDocument.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumentbyfilter"></a>
# **GetWarehouseDocumentByFilter**
> List<WarehouseDocument> GetWarehouseDocumentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search warehouseDocuments by filter

Returns the list of warehouseDocuments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search warehouseDocuments by filter
                List&lt;WarehouseDocument&gt; result = apiInstance.GetWarehouseDocumentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.GetWarehouseDocumentByFilter: " + e.Message );
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

[**List<WarehouseDocument>**](WarehouseDocument.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumentbyid"></a>
# **GetWarehouseDocumentById**
> WarehouseDocument GetWarehouseDocumentById (int? warehouseDocumentId)

Get a warehouseDocument by id

Returns the warehouseDocument identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to be returned.

            try
            {
                // Get a warehouseDocument by id
                WarehouseDocument result = apiInstance.GetWarehouseDocumentById(warehouseDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.GetWarehouseDocumentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to be returned. | 

### Return type

[**WarehouseDocument**](WarehouseDocument.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumentfiles"></a>
# **GetWarehouseDocumentFiles**
> void GetWarehouseDocumentFiles (int? warehouseDocumentId)

Get the files for a warehouseDocument.

Get all existing warehouseDocument files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to get files for

            try
            {
                // Get the files for a warehouseDocument.
                apiInstance.GetWarehouseDocumentFiles(warehouseDocumentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.GetWarehouseDocumentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumenttags"></a>
# **GetWarehouseDocumentTags**
> void GetWarehouseDocumentTags (int? warehouseDocumentId)

Get the tags for a warehouseDocument.

Get all existing warehouseDocument tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var warehouseDocumentId = 56;  // int? | Id of the warehouseDocument to get tags for

            try
            {
                // Get the tags for a warehouseDocument.
                apiInstance.GetWarehouseDocumentTags(warehouseDocumentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.GetWarehouseDocumentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentId** | **int?**| Id of the warehouseDocument to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewarehousedocumentcustomfields"></a>
# **UpdateWarehouseDocumentCustomFields**
> void UpdateWarehouseDocumentCustomFields (WarehouseDocument body)

Update a warehouseDocument custom fields

Updates an existing warehouseDocument custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWarehouseDocumentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentApi();
            var body = new WarehouseDocument(); // WarehouseDocument | WarehouseDocument to be updated.

            try
            {
                // Update a warehouseDocument custom fields
                apiInstance.UpdateWarehouseDocumentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentApi.UpdateWarehouseDocumentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WarehouseDocument**](WarehouseDocument.md)| WarehouseDocument to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

