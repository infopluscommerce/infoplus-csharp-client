# Infoplus.Api.ItemSerialApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemSerial**](ItemSerialApi.md#additemserial) | **POST** /beta/itemSerial | Create an itemSerial
[**AddItemSerialAudit**](ItemSerialApi.md#additemserialaudit) | **PUT** /beta/itemSerial/{itemSerialId}/audit/{itemSerialAudit} | Add new audit for an itemSerial
[**AddItemSerialFile**](ItemSerialApi.md#additemserialfile) | **POST** /beta/itemSerial/{itemSerialId}/file/{fileName} | Attach a file to an itemSerial
[**AddItemSerialFileByURL**](ItemSerialApi.md#additemserialfilebyurl) | **POST** /beta/itemSerial/{itemSerialId}/file | Attach a file to an itemSerial by URL.
[**AddItemSerialTag**](ItemSerialApi.md#additemserialtag) | **PUT** /beta/itemSerial/{itemSerialId}/tag/{itemSerialTag} | Add new tags for an itemSerial.
[**DeleteItemSerial**](ItemSerialApi.md#deleteitemserial) | **DELETE** /beta/itemSerial/{itemSerialId} | Delete an itemSerial
[**DeleteItemSerialFile**](ItemSerialApi.md#deleteitemserialfile) | **DELETE** /beta/itemSerial/{itemSerialId}/file/{fileId} | Delete a file for an itemSerial.
[**DeleteItemSerialTag**](ItemSerialApi.md#deleteitemserialtag) | **DELETE** /beta/itemSerial/{itemSerialId}/tag/{itemSerialTag} | Delete a tag for an itemSerial.
[**GetDuplicateItemSerialById**](ItemSerialApi.md#getduplicateitemserialbyid) | **GET** /beta/itemSerial/duplicate/{itemSerialId} | Get a duplicated an itemSerial by id
[**GetItemSerialByFilter**](ItemSerialApi.md#getitemserialbyfilter) | **GET** /beta/itemSerial/search | Search itemSerials by filter
[**GetItemSerialById**](ItemSerialApi.md#getitemserialbyid) | **GET** /beta/itemSerial/{itemSerialId} | Get an itemSerial by id
[**GetItemSerialFiles**](ItemSerialApi.md#getitemserialfiles) | **GET** /beta/itemSerial/{itemSerialId}/file | Get the files for an itemSerial.
[**GetItemSerialTags**](ItemSerialApi.md#getitemserialtags) | **GET** /beta/itemSerial/{itemSerialId}/tag | Get the tags for an itemSerial.
[**UpdateItemSerial**](ItemSerialApi.md#updateitemserial) | **PUT** /beta/itemSerial | Update an itemSerial


<a name="additemserial"></a>
# **AddItemSerial**
> ItemSerial AddItemSerial (ItemSerial body)

Create an itemSerial

Inserts a new itemSerial using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var body = new ItemSerial(); // ItemSerial | ItemSerial to be inserted.

            try
            {
                // Create an itemSerial
                ItemSerial result = apiInstance.AddItemSerial(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.AddItemSerial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSerial**](ItemSerial.md)| ItemSerial to be inserted. | 

### Return type

[**ItemSerial**](ItemSerial.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialaudit"></a>
# **AddItemSerialAudit**
> void AddItemSerialAudit (int? itemSerialId, string itemSerialAudit)

Add new audit for an itemSerial

Adds an audit to an existing itemSerial.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to add an audit to
            var itemSerialAudit = itemSerialAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemSerial
                apiInstance.AddItemSerialAudit(itemSerialId, itemSerialAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.AddItemSerialAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to add an audit to | 
 **itemSerialAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialfile"></a>
# **AddItemSerialFile**
> void AddItemSerialFile (int? itemSerialId, string fileName)

Attach a file to an itemSerial

Adds a file to an existing itemSerial.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemSerial
                apiInstance.AddItemSerialFile(itemSerialId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.AddItemSerialFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialfilebyurl"></a>
# **AddItemSerialFileByURL**
> void AddItemSerialFileByURL (RecordFile body, int? itemSerialId)

Attach a file to an itemSerial by URL.

Adds a file to an existing itemSerial by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemSerialId = 56;  // int? | Id of the itemSerial to add an file to

            try
            {
                // Attach a file to an itemSerial by URL.
                apiInstance.AddItemSerialFileByURL(body, itemSerialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.AddItemSerialFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemSerialId** | **int?**| Id of the itemSerial to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemserialtag"></a>
# **AddItemSerialTag**
> void AddItemSerialTag (int? itemSerialId, string itemSerialTag)

Add new tags for an itemSerial.

Adds a tag to an existing itemSerial.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSerialTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to add a tag to
            var itemSerialTag = itemSerialTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemSerial.
                apiInstance.AddItemSerialTag(itemSerialId, itemSerialTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.AddItemSerialTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to add a tag to | 
 **itemSerialTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemserial"></a>
# **DeleteItemSerial**
> void DeleteItemSerial (int? itemSerialId)

Delete an itemSerial

Deletes the itemSerial identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSerialExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to be deleted.

            try
            {
                // Delete an itemSerial
                apiInstance.DeleteItemSerial(itemSerialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.DeleteItemSerial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemserialfile"></a>
# **DeleteItemSerialFile**
> void DeleteItemSerialFile (int? itemSerialId, int? fileId)

Delete a file for an itemSerial.

Deletes an existing itemSerial file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSerialFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemSerial.
                apiInstance.DeleteItemSerialFile(itemSerialId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.DeleteItemSerialFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemserialtag"></a>
# **DeleteItemSerialTag**
> void DeleteItemSerialTag (int? itemSerialId, string itemSerialTag)

Delete a tag for an itemSerial.

Deletes an existing itemSerial tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSerialTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to remove tag from
            var itemSerialTag = itemSerialTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemSerial.
                apiInstance.DeleteItemSerialTag(itemSerialId, itemSerialTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.DeleteItemSerialTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to remove tag from | 
 **itemSerialTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemserialbyid"></a>
# **GetDuplicateItemSerialById**
> ItemSerial GetDuplicateItemSerialById (int? itemSerialId)

Get a duplicated an itemSerial by id

Returns a duplicated itemSerial identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemSerialByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to be duplicated.

            try
            {
                // Get a duplicated an itemSerial by id
                ItemSerial result = apiInstance.GetDuplicateItemSerialById(itemSerialId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.GetDuplicateItemSerialById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to be duplicated. | 

### Return type

[**ItemSerial**](ItemSerial.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialbyfilter"></a>
# **GetItemSerialByFilter**
> List<ItemSerial> GetItemSerialByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemSerials by filter

Returns the list of itemSerials that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemSerials by filter
                List&lt;ItemSerial&gt; result = apiInstance.GetItemSerialByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.GetItemSerialByFilter: " + e.Message );
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

[**List<ItemSerial>**](ItemSerial.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialbyid"></a>
# **GetItemSerialById**
> ItemSerial GetItemSerialById (int? itemSerialId)

Get an itemSerial by id

Returns the itemSerial identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to be returned.

            try
            {
                // Get an itemSerial by id
                ItemSerial result = apiInstance.GetItemSerialById(itemSerialId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.GetItemSerialById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to be returned. | 

### Return type

[**ItemSerial**](ItemSerial.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialfiles"></a>
# **GetItemSerialFiles**
> void GetItemSerialFiles (int? itemSerialId)

Get the files for an itemSerial.

Get all existing itemSerial files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to get files for

            try
            {
                // Get the files for an itemSerial.
                apiInstance.GetItemSerialFiles(itemSerialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.GetItemSerialFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemserialtags"></a>
# **GetItemSerialTags**
> void GetItemSerialTags (int? itemSerialId)

Get the tags for an itemSerial.

Get all existing itemSerial tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSerialTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var itemSerialId = 56;  // int? | Id of the itemSerial to get tags for

            try
            {
                // Get the tags for an itemSerial.
                apiInstance.GetItemSerialTags(itemSerialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.GetItemSerialTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSerialId** | **int?**| Id of the itemSerial to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemserial"></a>
# **UpdateItemSerial**
> void UpdateItemSerial (ItemSerial body)

Update an itemSerial

Updates an existing itemSerial using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemSerialExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSerialApi();
            var body = new ItemSerial(); // ItemSerial | ItemSerial to be updated.

            try
            {
                // Update an itemSerial
                apiInstance.UpdateItemSerial(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSerialApi.UpdateItemSerial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSerial**](ItemSerial.md)| ItemSerial to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

