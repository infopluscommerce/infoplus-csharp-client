# Infoplus.Api.ItemSerialSchemeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemSerialScheme**](ItemSerialSchemeApi.md#additemserialscheme) | **POST** /v3.0/itemSerialScheme | Create an itemSerialScheme
[**AddItemSerialSchemeAudit**](ItemSerialSchemeApi.md#additemserialschemeaudit) | **PUT** /v3.0/itemSerialScheme/{itemSerialSchemeId}/audit/{itemSerialSchemeAudit} | Add new audit for an itemSerialScheme
[**AddItemSerialSchemeFile**](ItemSerialSchemeApi.md#additemserialschemefile) | **POST** /v3.0/itemSerialScheme/{itemSerialSchemeId}/file/{fileName} | Attach a file to an itemSerialScheme
[**AddItemSerialSchemeFileByURL**](ItemSerialSchemeApi.md#additemserialschemefilebyurl) | **POST** /v3.0/itemSerialScheme/{itemSerialSchemeId}/file | Attach a file to an itemSerialScheme by URL.
[**AddItemSerialSchemeTag**](ItemSerialSchemeApi.md#additemserialschemetag) | **PUT** /v3.0/itemSerialScheme/{itemSerialSchemeId}/tag/{itemSerialSchemeTag} | Add new tags for an itemSerialScheme.
[**DeleteItemSerialScheme**](ItemSerialSchemeApi.md#deleteitemserialscheme) | **DELETE** /v3.0/itemSerialScheme/{itemSerialSchemeId} | Delete an itemSerialScheme
[**DeleteItemSerialSchemeFile**](ItemSerialSchemeApi.md#deleteitemserialschemefile) | **DELETE** /v3.0/itemSerialScheme/{itemSerialSchemeId}/file/{fileId} | Delete a file for an itemSerialScheme.
[**DeleteItemSerialSchemeTag**](ItemSerialSchemeApi.md#deleteitemserialschemetag) | **DELETE** /v3.0/itemSerialScheme/{itemSerialSchemeId}/tag/{itemSerialSchemeTag} | Delete a tag for an itemSerialScheme.
[**GetDuplicateItemSerialSchemeById**](ItemSerialSchemeApi.md#getduplicateitemserialschemebyid) | **GET** /v3.0/itemSerialScheme/duplicate/{itemSerialSchemeId} | Get a duplicated an itemSerialScheme by id
[**GetItemSerialSchemeByFilter**](ItemSerialSchemeApi.md#getitemserialschemebyfilter) | **GET** /v3.0/itemSerialScheme/search | Search itemSerialSchemes by filter
[**GetItemSerialSchemeById**](ItemSerialSchemeApi.md#getitemserialschemebyid) | **GET** /v3.0/itemSerialScheme/{itemSerialSchemeId} | Get an itemSerialScheme by id
[**GetItemSerialSchemeFiles**](ItemSerialSchemeApi.md#getitemserialschemefiles) | **GET** /v3.0/itemSerialScheme/{itemSerialSchemeId}/file | Get the files for an itemSerialScheme.
[**GetItemSerialSchemeTags**](ItemSerialSchemeApi.md#getitemserialschemetags) | **GET** /v3.0/itemSerialScheme/{itemSerialSchemeId}/tag | Get the tags for an itemSerialScheme.
[**UpdateItemSerialScheme**](ItemSerialSchemeApi.md#updateitemserialscheme) | **PUT** /v3.0/itemSerialScheme | Update an itemSerialScheme


<a name="additemserialscheme"></a>
# **AddItemSerialScheme**
> ItemSerialScheme AddItemSerialScheme (ItemSerialScheme body)

Create an itemSerialScheme

Inserts a new itemSerialScheme using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialSchemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var body = new ItemSerialScheme(); // ItemSerialScheme | ItemSerialScheme to be inserted.

            try
            {
                // Create an itemSerialScheme
                ItemSerialScheme result = apiInstance.AddItemSerialScheme(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.AddItemSerialScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSerialScheme**](ItemSerialScheme.md)| ItemSerialScheme to be inserted. | 

### Return type

[**ItemSerialScheme**](ItemSerialScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialschemeaudit"></a>
# **AddItemSerialSchemeAudit**
> void AddItemSerialSchemeAudit (int? itemSerialSchemeId, string itemSerialSchemeAudit)

Add new audit for an itemSerialScheme

Adds an audit to an existing itemSerialScheme.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialSchemeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to add an audit to
            var itemSerialSchemeAudit = itemSerialSchemeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemSerialScheme
                apiInstance.AddItemSerialSchemeAudit(itemSerialSchemeId, itemSerialSchemeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.AddItemSerialSchemeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to add an audit to | 
 **itemSerialSchemeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialschemefile"></a>
# **AddItemSerialSchemeFile**
> void AddItemSerialSchemeFile (int? itemSerialSchemeId, string fileName)

Attach a file to an itemSerialScheme

Adds a file to an existing itemSerialScheme.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialSchemeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemSerialScheme
                apiInstance.AddItemSerialSchemeFile(itemSerialSchemeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.AddItemSerialSchemeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialschemefilebyurl"></a>
# **AddItemSerialSchemeFileByURL**
> void AddItemSerialSchemeFileByURL (RecordFile body, int? itemSerialSchemeId)

Attach a file to an itemSerialScheme by URL.

Adds a file to an existing itemSerialScheme by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialSchemeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to add an file to

            try
            {
                // Attach a file to an itemSerialScheme by URL.
                apiInstance.AddItemSerialSchemeFileByURL(body, itemSerialSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.AddItemSerialSchemeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialschemetag"></a>
# **AddItemSerialSchemeTag**
> void AddItemSerialSchemeTag (int? itemSerialSchemeId, string itemSerialSchemeTag)

Add new tags for an itemSerialScheme.

Adds a tag to an existing itemSerialScheme.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialSchemeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to add a tag to
            var itemSerialSchemeTag = itemSerialSchemeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemSerialScheme.
                apiInstance.AddItemSerialSchemeTag(itemSerialSchemeId, itemSerialSchemeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.AddItemSerialSchemeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to add a tag to | 
 **itemSerialSchemeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemserialscheme"></a>
# **DeleteItemSerialScheme**
> void DeleteItemSerialScheme (int? itemSerialSchemeId)

Delete an itemSerialScheme

Deletes the itemSerialScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSerialSchemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to be deleted.

            try
            {
                // Delete an itemSerialScheme
                apiInstance.DeleteItemSerialScheme(itemSerialSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.DeleteItemSerialScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemserialschemefile"></a>
# **DeleteItemSerialSchemeFile**
> void DeleteItemSerialSchemeFile (int? itemSerialSchemeId, int? fileId)

Delete a file for an itemSerialScheme.

Deletes an existing itemSerialScheme file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSerialSchemeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemSerialScheme.
                apiInstance.DeleteItemSerialSchemeFile(itemSerialSchemeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.DeleteItemSerialSchemeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemserialschemetag"></a>
# **DeleteItemSerialSchemeTag**
> void DeleteItemSerialSchemeTag (int? itemSerialSchemeId, string itemSerialSchemeTag)

Delete a tag for an itemSerialScheme.

Deletes an existing itemSerialScheme tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSerialSchemeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to remove tag from
            var itemSerialSchemeTag = itemSerialSchemeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemSerialScheme.
                apiInstance.DeleteItemSerialSchemeTag(itemSerialSchemeId, itemSerialSchemeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.DeleteItemSerialSchemeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to remove tag from | 
 **itemSerialSchemeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemserialschemebyid"></a>
# **GetDuplicateItemSerialSchemeById**
> ItemSerialScheme GetDuplicateItemSerialSchemeById (int? itemSerialSchemeId)

Get a duplicated an itemSerialScheme by id

Returns a duplicated itemSerialScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemSerialSchemeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to be duplicated.

            try
            {
                // Get a duplicated an itemSerialScheme by id
                ItemSerialScheme result = apiInstance.GetDuplicateItemSerialSchemeById(itemSerialSchemeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.GetDuplicateItemSerialSchemeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to be duplicated. | 

### Return type

[**ItemSerialScheme**](ItemSerialScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialschemebyfilter"></a>
# **GetItemSerialSchemeByFilter**
> List<ItemSerialScheme> GetItemSerialSchemeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemSerialSchemes by filter

Returns the list of itemSerialSchemes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialSchemeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemSerialSchemes by filter
                List&lt;ItemSerialScheme&gt; result = apiInstance.GetItemSerialSchemeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.GetItemSerialSchemeByFilter: " + e.Message );
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

[**List<ItemSerialScheme>**](ItemSerialScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialschemebyid"></a>
# **GetItemSerialSchemeById**
> ItemSerialScheme GetItemSerialSchemeById (int? itemSerialSchemeId)

Get an itemSerialScheme by id

Returns the itemSerialScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialSchemeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to be returned.

            try
            {
                // Get an itemSerialScheme by id
                ItemSerialScheme result = apiInstance.GetItemSerialSchemeById(itemSerialSchemeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.GetItemSerialSchemeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to be returned. | 

### Return type

[**ItemSerialScheme**](ItemSerialScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialschemefiles"></a>
# **GetItemSerialSchemeFiles**
> void GetItemSerialSchemeFiles (int? itemSerialSchemeId)

Get the files for an itemSerialScheme.

Get all existing itemSerialScheme files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialSchemeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to get files for

            try
            {
                // Get the files for an itemSerialScheme.
                apiInstance.GetItemSerialSchemeFiles(itemSerialSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.GetItemSerialSchemeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialschemetags"></a>
# **GetItemSerialSchemeTags**
> void GetItemSerialSchemeTags (int? itemSerialSchemeId)

Get the tags for an itemSerialScheme.

Get all existing itemSerialScheme tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialSchemeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var itemSerialSchemeId = 56;  // int? | Id of the itemSerialScheme to get tags for

            try
            {
                // Get the tags for an itemSerialScheme.
                apiInstance.GetItemSerialSchemeTags(itemSerialSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.GetItemSerialSchemeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialSchemeId** | **int?**| Id of the itemSerialScheme to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemserialscheme"></a>
# **UpdateItemSerialScheme**
> void UpdateItemSerialScheme (ItemSerialScheme body)

Update an itemSerialScheme

Updates an existing itemSerialScheme using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemSerialSchemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialSchemeApi();
            var body = new ItemSerialScheme(); // ItemSerialScheme | ItemSerialScheme to be updated.

            try
            {
                // Update an itemSerialScheme
                apiInstance.UpdateItemSerialScheme(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialSchemeApi.UpdateItemSerialScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSerialScheme**](ItemSerialScheme.md)| ItemSerialScheme to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

