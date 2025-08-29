# Infoplus.Api.ItemReceiptApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemReceiptAudit**](ItemReceiptApi.md#additemreceiptaudit) | **PUT** /beta/itemReceipt/{itemReceiptId}/audit/{itemReceiptAudit} | Add new audit for an itemReceipt
[**AddItemReceiptFile**](ItemReceiptApi.md#additemreceiptfile) | **POST** /beta/itemReceipt/{itemReceiptId}/file/{fileName} | Attach a file to an itemReceipt
[**AddItemReceiptFileByURL**](ItemReceiptApi.md#additemreceiptfilebyurl) | **POST** /beta/itemReceipt/{itemReceiptId}/file | Attach a file to an itemReceipt by URL.
[**AddItemReceiptTag**](ItemReceiptApi.md#additemreceipttag) | **PUT** /beta/itemReceipt/{itemReceiptId}/tag/{itemReceiptTag} | Add new tags for an itemReceipt.
[**DeleteItemReceiptFile**](ItemReceiptApi.md#deleteitemreceiptfile) | **DELETE** /beta/itemReceipt/{itemReceiptId}/file/{fileId} | Delete a file for an itemReceipt.
[**DeleteItemReceiptTag**](ItemReceiptApi.md#deleteitemreceipttag) | **DELETE** /beta/itemReceipt/{itemReceiptId}/tag/{itemReceiptTag} | Delete a tag for an itemReceipt.
[**GetDuplicateItemReceiptById**](ItemReceiptApi.md#getduplicateitemreceiptbyid) | **GET** /beta/itemReceipt/duplicate/{itemReceiptId} | Get a duplicated an itemReceipt by id
[**GetItemReceiptByFilter**](ItemReceiptApi.md#getitemreceiptbyfilter) | **GET** /beta/itemReceipt/search | Search itemReceipts by filter
[**GetItemReceiptById**](ItemReceiptApi.md#getitemreceiptbyid) | **GET** /beta/itemReceipt/{itemReceiptId} | Get an itemReceipt by id
[**GetItemReceiptFiles**](ItemReceiptApi.md#getitemreceiptfiles) | **GET** /beta/itemReceipt/{itemReceiptId}/file | Get the files for an itemReceipt.
[**GetItemReceiptTags**](ItemReceiptApi.md#getitemreceipttags) | **GET** /beta/itemReceipt/{itemReceiptId}/tag | Get the tags for an itemReceipt.
[**UpdateItemReceipt**](ItemReceiptApi.md#updateitemreceipt) | **PUT** /beta/itemReceipt | Update an itemReceipt
[**UpdateItemReceiptCustomFields**](ItemReceiptApi.md#updateitemreceiptcustomfields) | **PUT** /beta/itemReceipt/customFields | Update an itemReceipt custom fields


<a name="additemreceiptaudit"></a>
# **AddItemReceiptAudit**
> void AddItemReceiptAudit (int? itemReceiptId, string itemReceiptAudit)

Add new audit for an itemReceipt

Adds an audit to an existing itemReceipt.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to add an audit to
            var itemReceiptAudit = itemReceiptAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemReceipt
                apiInstance.AddItemReceiptAudit(itemReceiptId, itemReceiptAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.AddItemReceiptAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to add an audit to | 
 **itemReceiptAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemreceiptfile"></a>
# **AddItemReceiptFile**
> void AddItemReceiptFile (int? itemReceiptId, string fileName)

Attach a file to an itemReceipt

Adds a file to an existing itemReceipt.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemReceipt
                apiInstance.AddItemReceiptFile(itemReceiptId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.AddItemReceiptFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemreceiptfilebyurl"></a>
# **AddItemReceiptFileByURL**
> void AddItemReceiptFileByURL (RecordFile body, int? itemReceiptId)

Attach a file to an itemReceipt by URL.

Adds a file to an existing itemReceipt by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to add an file to

            try
            {
                // Attach a file to an itemReceipt by URL.
                apiInstance.AddItemReceiptFileByURL(body, itemReceiptId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.AddItemReceiptFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemReceiptId** | **int?**| Id of the itemReceipt to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemreceipttag"></a>
# **AddItemReceiptTag**
> void AddItemReceiptTag (int? itemReceiptId, string itemReceiptTag)

Add new tags for an itemReceipt.

Adds a tag to an existing itemReceipt.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to add a tag to
            var itemReceiptTag = itemReceiptTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemReceipt.
                apiInstance.AddItemReceiptTag(itemReceiptId, itemReceiptTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.AddItemReceiptTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to add a tag to | 
 **itemReceiptTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemreceiptfile"></a>
# **DeleteItemReceiptFile**
> void DeleteItemReceiptFile (int? itemReceiptId, int? fileId)

Delete a file for an itemReceipt.

Deletes an existing itemReceipt file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemReceiptFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemReceipt.
                apiInstance.DeleteItemReceiptFile(itemReceiptId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.DeleteItemReceiptFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemreceipttag"></a>
# **DeleteItemReceiptTag**
> void DeleteItemReceiptTag (int? itemReceiptId, string itemReceiptTag)

Delete a tag for an itemReceipt.

Deletes an existing itemReceipt tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemReceiptTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to remove tag from
            var itemReceiptTag = itemReceiptTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemReceipt.
                apiInstance.DeleteItemReceiptTag(itemReceiptId, itemReceiptTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.DeleteItemReceiptTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to remove tag from | 
 **itemReceiptTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemreceiptbyid"></a>
# **GetDuplicateItemReceiptById**
> ItemReceipt GetDuplicateItemReceiptById (int? itemReceiptId)

Get a duplicated an itemReceipt by id

Returns a duplicated itemReceipt identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemReceiptByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to be duplicated.

            try
            {
                // Get a duplicated an itemReceipt by id
                ItemReceipt result = apiInstance.GetDuplicateItemReceiptById(itemReceiptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetDuplicateItemReceiptById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to be duplicated. | 

### Return type

[**ItemReceipt**](ItemReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptbyfilter"></a>
# **GetItemReceiptByFilter**
> List<ItemReceipt> GetItemReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemReceipts by filter

Returns the list of itemReceipts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemReceipts by filter
                List&lt;ItemReceipt&gt; result = apiInstance.GetItemReceiptByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetItemReceiptByFilter: " + e.Message );
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

[**List<ItemReceipt>**](ItemReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptbyid"></a>
# **GetItemReceiptById**
> ItemReceipt GetItemReceiptById (int? itemReceiptId)

Get an itemReceipt by id

Returns the itemReceipt identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to be returned.

            try
            {
                // Get an itemReceipt by id
                ItemReceipt result = apiInstance.GetItemReceiptById(itemReceiptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetItemReceiptById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to be returned. | 

### Return type

[**ItemReceipt**](ItemReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptfiles"></a>
# **GetItemReceiptFiles**
> void GetItemReceiptFiles (int? itemReceiptId)

Get the files for an itemReceipt.

Get all existing itemReceipt files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to get files for

            try
            {
                // Get the files for an itemReceipt.
                apiInstance.GetItemReceiptFiles(itemReceiptId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetItemReceiptFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceipttags"></a>
# **GetItemReceiptTags**
> void GetItemReceiptTags (int? itemReceiptId)

Get the tags for an itemReceipt.

Get all existing itemReceipt tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to get tags for

            try
            {
                // Get the tags for an itemReceipt.
                apiInstance.GetItemReceiptTags(itemReceiptId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetItemReceiptTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemreceipt"></a>
# **UpdateItemReceipt**
> void UpdateItemReceipt (ItemReceipt body)

Update an itemReceipt

Updates an existing itemReceipt using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemReceiptExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var body = new ItemReceipt(); // ItemReceipt | ItemReceipt to be updated.

            try
            {
                // Update an itemReceipt
                apiInstance.UpdateItemReceipt(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.UpdateItemReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemReceipt**](ItemReceipt.md)| ItemReceipt to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemreceiptcustomfields"></a>
# **UpdateItemReceiptCustomFields**
> void UpdateItemReceiptCustomFields (ItemReceipt body)

Update an itemReceipt custom fields

Updates an existing itemReceipt custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemReceiptCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var body = new ItemReceipt(); // ItemReceipt | ItemReceipt to be updated.

            try
            {
                // Update an itemReceipt custom fields
                apiInstance.UpdateItemReceiptCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.UpdateItemReceiptCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemReceipt**](ItemReceipt.md)| ItemReceipt to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

