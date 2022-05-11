# Infoplus.Api.ItemSectorApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemSector**](ItemSectorApi.md#additemsector) | **POST** /v3.0/itemSector | Create an itemSector
[**AddItemSectorAudit**](ItemSectorApi.md#additemsectoraudit) | **PUT** /v3.0/itemSector/{itemSectorId}/audit/{itemSectorAudit} | Add new audit for an itemSector
[**AddItemSectorFile**](ItemSectorApi.md#additemsectorfile) | **POST** /v3.0/itemSector/{itemSectorId}/file/{fileName} | Attach a file to an itemSector
[**AddItemSectorFileByURL**](ItemSectorApi.md#additemsectorfilebyurl) | **POST** /v3.0/itemSector/{itemSectorId}/file | Attach a file to an itemSector by URL.
[**AddItemSectorTag**](ItemSectorApi.md#additemsectortag) | **PUT** /v3.0/itemSector/{itemSectorId}/tag/{itemSectorTag} | Add new tags for an itemSector.
[**DeleteItemSector**](ItemSectorApi.md#deleteitemsector) | **DELETE** /v3.0/itemSector/{itemSectorId} | Delete an itemSector
[**DeleteItemSectorFile**](ItemSectorApi.md#deleteitemsectorfile) | **DELETE** /v3.0/itemSector/{itemSectorId}/file/{fileId} | Delete a file for an itemSector.
[**DeleteItemSectorTag**](ItemSectorApi.md#deleteitemsectortag) | **DELETE** /v3.0/itemSector/{itemSectorId}/tag/{itemSectorTag} | Delete a tag for an itemSector.
[**GetDuplicateItemSectorById**](ItemSectorApi.md#getduplicateitemsectorbyid) | **GET** /v3.0/itemSector/duplicate/{itemSectorId} | Get a duplicated an itemSector by id
[**GetItemSectorByFilter**](ItemSectorApi.md#getitemsectorbyfilter) | **GET** /v3.0/itemSector/search | Search itemSectors by filter
[**GetItemSectorById**](ItemSectorApi.md#getitemsectorbyid) | **GET** /v3.0/itemSector/{itemSectorId} | Get an itemSector by id
[**GetItemSectorFiles**](ItemSectorApi.md#getitemsectorfiles) | **GET** /v3.0/itemSector/{itemSectorId}/file | Get the files for an itemSector.
[**GetItemSectorTags**](ItemSectorApi.md#getitemsectortags) | **GET** /v3.0/itemSector/{itemSectorId}/tag | Get the tags for an itemSector.
[**UpdateItemSector**](ItemSectorApi.md#updateitemsector) | **PUT** /v3.0/itemSector | Update an itemSector


<a name="additemsector"></a>
# **AddItemSector**
> ItemSector AddItemSector (ItemSector body)

Create an itemSector

Inserts a new itemSector using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSectorExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var body = new ItemSector(); // ItemSector | ItemSector to be inserted.

            try
            {
                // Create an itemSector
                ItemSector result = apiInstance.AddItemSector(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.AddItemSector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSector**](ItemSector.md)| ItemSector to be inserted. | 

### Return type

[**ItemSector**](ItemSector.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsectoraudit"></a>
# **AddItemSectorAudit**
> void AddItemSectorAudit (int? itemSectorId, string itemSectorAudit)

Add new audit for an itemSector

Adds an audit to an existing itemSector.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSectorAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to add an audit to
            var itemSectorAudit = itemSectorAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemSector
                apiInstance.AddItemSectorAudit(itemSectorId, itemSectorAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.AddItemSectorAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to add an audit to | 
 **itemSectorAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsectorfile"></a>
# **AddItemSectorFile**
> void AddItemSectorFile (int? itemSectorId, string fileName)

Attach a file to an itemSector

Adds a file to an existing itemSector.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSectorFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemSector
                apiInstance.AddItemSectorFile(itemSectorId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.AddItemSectorFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsectorfilebyurl"></a>
# **AddItemSectorFileByURL**
> void AddItemSectorFileByURL (RecordFile body, int? itemSectorId)

Attach a file to an itemSector by URL.

Adds a file to an existing itemSector by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSectorFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemSectorId = 56;  // int? | Id of the itemSector to add an file to

            try
            {
                // Attach a file to an itemSector by URL.
                apiInstance.AddItemSectorFileByURL(body, itemSectorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.AddItemSectorFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemSectorId** | **int?**| Id of the itemSector to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsectortag"></a>
# **AddItemSectorTag**
> void AddItemSectorTag (int? itemSectorId, string itemSectorTag)

Add new tags for an itemSector.

Adds a tag to an existing itemSector.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSectorTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to add a tag to
            var itemSectorTag = itemSectorTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemSector.
                apiInstance.AddItemSectorTag(itemSectorId, itemSectorTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.AddItemSectorTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to add a tag to | 
 **itemSectorTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsector"></a>
# **DeleteItemSector**
> void DeleteItemSector (int? itemSectorId)

Delete an itemSector

Deletes the itemSector identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSectorExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to be deleted.

            try
            {
                // Delete an itemSector
                apiInstance.DeleteItemSector(itemSectorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.DeleteItemSector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsectorfile"></a>
# **DeleteItemSectorFile**
> void DeleteItemSectorFile (int? itemSectorId, int? fileId)

Delete a file for an itemSector.

Deletes an existing itemSector file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSectorFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemSector.
                apiInstance.DeleteItemSectorFile(itemSectorId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.DeleteItemSectorFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsectortag"></a>
# **DeleteItemSectorTag**
> void DeleteItemSectorTag (int? itemSectorId, string itemSectorTag)

Delete a tag for an itemSector.

Deletes an existing itemSector tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSectorTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to remove tag from
            var itemSectorTag = itemSectorTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemSector.
                apiInstance.DeleteItemSectorTag(itemSectorId, itemSectorTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.DeleteItemSectorTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to remove tag from | 
 **itemSectorTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemsectorbyid"></a>
# **GetDuplicateItemSectorById**
> ItemSector GetDuplicateItemSectorById (int? itemSectorId)

Get a duplicated an itemSector by id

Returns a duplicated itemSector identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemSectorByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to be duplicated.

            try
            {
                // Get a duplicated an itemSector by id
                ItemSector result = apiInstance.GetDuplicateItemSectorById(itemSectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.GetDuplicateItemSectorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to be duplicated. | 

### Return type

[**ItemSector**](ItemSector.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsectorbyfilter"></a>
# **GetItemSectorByFilter**
> List<ItemSector> GetItemSectorByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemSectors by filter

Returns the list of itemSectors that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSectorByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemSectors by filter
                List&lt;ItemSector&gt; result = apiInstance.GetItemSectorByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.GetItemSectorByFilter: " + e.Message );
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

[**List<ItemSector>**](ItemSector.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsectorbyid"></a>
# **GetItemSectorById**
> ItemSector GetItemSectorById (int? itemSectorId)

Get an itemSector by id

Returns the itemSector identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSectorByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to be returned.

            try
            {
                // Get an itemSector by id
                ItemSector result = apiInstance.GetItemSectorById(itemSectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.GetItemSectorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to be returned. | 

### Return type

[**ItemSector**](ItemSector.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsectorfiles"></a>
# **GetItemSectorFiles**
> void GetItemSectorFiles (int? itemSectorId)

Get the files for an itemSector.

Get all existing itemSector files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSectorFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to get files for

            try
            {
                // Get the files for an itemSector.
                apiInstance.GetItemSectorFiles(itemSectorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.GetItemSectorFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsectortags"></a>
# **GetItemSectorTags**
> void GetItemSectorTags (int? itemSectorId)

Get the tags for an itemSector.

Get all existing itemSector tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSectorTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var itemSectorId = 56;  // int? | Id of the itemSector to get tags for

            try
            {
                // Get the tags for an itemSector.
                apiInstance.GetItemSectorTags(itemSectorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.GetItemSectorTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSectorId** | **int?**| Id of the itemSector to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemsector"></a>
# **UpdateItemSector**
> void UpdateItemSector (ItemSector body)

Update an itemSector

Updates an existing itemSector using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemSectorExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSectorApi();
            var body = new ItemSector(); // ItemSector | ItemSector to be updated.

            try
            {
                // Update an itemSector
                apiInstance.UpdateItemSector(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSectorApi.UpdateItemSector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSector**](ItemSector.md)| ItemSector to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

