# Infoplus.Api.ItemSummaryCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemSummaryCode**](ItemSummaryCodeApi.md#additemsummarycode) | **POST** /beta/itemSummaryCode | Create an itemSummaryCode
[**AddItemSummaryCodeAudit**](ItemSummaryCodeApi.md#additemsummarycodeaudit) | **PUT** /beta/itemSummaryCode/{itemSummaryCodeId}/audit/{itemSummaryCodeAudit} | Add new audit for an itemSummaryCode
[**AddItemSummaryCodeFile**](ItemSummaryCodeApi.md#additemsummarycodefile) | **POST** /beta/itemSummaryCode/{itemSummaryCodeId}/file/{fileName} | Attach a file to an itemSummaryCode
[**AddItemSummaryCodeTag**](ItemSummaryCodeApi.md#additemsummarycodetag) | **PUT** /beta/itemSummaryCode/{itemSummaryCodeId}/tag/{itemSummaryCodeTag} | Add new tags for an itemSummaryCode.
[**DeleteItemSummaryCode**](ItemSummaryCodeApi.md#deleteitemsummarycode) | **DELETE** /beta/itemSummaryCode/{itemSummaryCodeId} | Delete an itemSummaryCode
[**DeleteItemSummaryCodeTag**](ItemSummaryCodeApi.md#deleteitemsummarycodetag) | **DELETE** /beta/itemSummaryCode/{itemSummaryCodeId}/tag/{itemSummaryCodeTag} | Delete a tag for an itemSummaryCode.
[**GetDuplicateItemSummaryCodeById**](ItemSummaryCodeApi.md#getduplicateitemsummarycodebyid) | **GET** /beta/itemSummaryCode/duplicate/{itemSummaryCodeId} | Get a duplicated an itemSummaryCode by id
[**GetItemSummaryCodeByFilter**](ItemSummaryCodeApi.md#getitemsummarycodebyfilter) | **GET** /beta/itemSummaryCode/search | Search itemSummaryCodes by filter
[**GetItemSummaryCodeById**](ItemSummaryCodeApi.md#getitemsummarycodebyid) | **GET** /beta/itemSummaryCode/{itemSummaryCodeId} | Get an itemSummaryCode by id
[**GetItemSummaryCodeTags**](ItemSummaryCodeApi.md#getitemsummarycodetags) | **GET** /beta/itemSummaryCode/{itemSummaryCodeId}/tag | Get the tags for an itemSummaryCode.
[**UpdateItemSummaryCode**](ItemSummaryCodeApi.md#updateitemsummarycode) | **PUT** /beta/itemSummaryCode | Update an itemSummaryCode


<a name="additemsummarycode"></a>
# **AddItemSummaryCode**
> ItemSummaryCode AddItemSummaryCode (ItemSummaryCode body)

Create an itemSummaryCode

Inserts a new itemSummaryCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSummaryCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var body = new ItemSummaryCode(); // ItemSummaryCode | ItemSummaryCode to be inserted.

            try
            {
                // Create an itemSummaryCode
                ItemSummaryCode result = apiInstance.AddItemSummaryCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.AddItemSummaryCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSummaryCode**](ItemSummaryCode.md)| ItemSummaryCode to be inserted. | 

### Return type

[**ItemSummaryCode**](ItemSummaryCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsummarycodeaudit"></a>
# **AddItemSummaryCodeAudit**
> void AddItemSummaryCodeAudit (int? itemSummaryCodeId, string itemSummaryCodeAudit)

Add new audit for an itemSummaryCode

Adds an audit to an existing itemSummaryCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSummaryCodeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to add an audit to
            var itemSummaryCodeAudit = itemSummaryCodeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemSummaryCode
                apiInstance.AddItemSummaryCodeAudit(itemSummaryCodeId, itemSummaryCodeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.AddItemSummaryCodeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to add an audit to | 
 **itemSummaryCodeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsummarycodefile"></a>
# **AddItemSummaryCodeFile**
> void AddItemSummaryCodeFile (int? itemSummaryCodeId, string fileName)

Attach a file to an itemSummaryCode

Adds a file to an existing itemSummaryCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSummaryCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemSummaryCode
                apiInstance.AddItemSummaryCodeFile(itemSummaryCodeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.AddItemSummaryCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsummarycodetag"></a>
# **AddItemSummaryCodeTag**
> void AddItemSummaryCodeTag (int? itemSummaryCodeId, string itemSummaryCodeTag)

Add new tags for an itemSummaryCode.

Adds a tag to an existing itemSummaryCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSummaryCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to add a tag to
            var itemSummaryCodeTag = itemSummaryCodeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemSummaryCode.
                apiInstance.AddItemSummaryCodeTag(itemSummaryCodeId, itemSummaryCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.AddItemSummaryCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to add a tag to | 
 **itemSummaryCodeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsummarycode"></a>
# **DeleteItemSummaryCode**
> void DeleteItemSummaryCode (int? itemSummaryCodeId)

Delete an itemSummaryCode

Deletes the itemSummaryCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSummaryCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to be deleted.

            try
            {
                // Delete an itemSummaryCode
                apiInstance.DeleteItemSummaryCode(itemSummaryCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.DeleteItemSummaryCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsummarycodetag"></a>
# **DeleteItemSummaryCodeTag**
> void DeleteItemSummaryCodeTag (int? itemSummaryCodeId, string itemSummaryCodeTag)

Delete a tag for an itemSummaryCode.

Deletes an existing itemSummaryCode tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSummaryCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to remove tag from
            var itemSummaryCodeTag = itemSummaryCodeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemSummaryCode.
                apiInstance.DeleteItemSummaryCodeTag(itemSummaryCodeId, itemSummaryCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.DeleteItemSummaryCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to remove tag from | 
 **itemSummaryCodeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemsummarycodebyid"></a>
# **GetDuplicateItemSummaryCodeById**
> ItemSummaryCode GetDuplicateItemSummaryCodeById (int? itemSummaryCodeId)

Get a duplicated an itemSummaryCode by id

Returns a duplicated itemSummaryCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemSummaryCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to be duplicated.

            try
            {
                // Get a duplicated an itemSummaryCode by id
                ItemSummaryCode result = apiInstance.GetDuplicateItemSummaryCodeById(itemSummaryCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.GetDuplicateItemSummaryCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to be duplicated. | 

### Return type

[**ItemSummaryCode**](ItemSummaryCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsummarycodebyfilter"></a>
# **GetItemSummaryCodeByFilter**
> List<ItemSummaryCode> GetItemSummaryCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemSummaryCodes by filter

Returns the list of itemSummaryCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSummaryCodeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemSummaryCodes by filter
                List&lt;ItemSummaryCode&gt; result = apiInstance.GetItemSummaryCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.GetItemSummaryCodeByFilter: " + e.Message );
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

[**List<ItemSummaryCode>**](ItemSummaryCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsummarycodebyid"></a>
# **GetItemSummaryCodeById**
> ItemSummaryCode GetItemSummaryCodeById (int? itemSummaryCodeId)

Get an itemSummaryCode by id

Returns the itemSummaryCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSummaryCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to be returned.

            try
            {
                // Get an itemSummaryCode by id
                ItemSummaryCode result = apiInstance.GetItemSummaryCodeById(itemSummaryCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.GetItemSummaryCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to be returned. | 

### Return type

[**ItemSummaryCode**](ItemSummaryCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsummarycodetags"></a>
# **GetItemSummaryCodeTags**
> void GetItemSummaryCodeTags (int? itemSummaryCodeId)

Get the tags for an itemSummaryCode.

Get all existing itemSummaryCode tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSummaryCodeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = 56;  // int? | Id of the itemSummaryCode to get tags for

            try
            {
                // Get the tags for an itemSummaryCode.
                apiInstance.GetItemSummaryCodeTags(itemSummaryCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.GetItemSummaryCodeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **int?**| Id of the itemSummaryCode to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemsummarycode"></a>
# **UpdateItemSummaryCode**
> void UpdateItemSummaryCode (ItemSummaryCode body)

Update an itemSummaryCode

Updates an existing itemSummaryCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemSummaryCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var body = new ItemSummaryCode(); // ItemSummaryCode | ItemSummaryCode to be updated.

            try
            {
                // Update an itemSummaryCode
                apiInstance.UpdateItemSummaryCode(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.UpdateItemSummaryCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSummaryCode**](ItemSummaryCode.md)| ItemSummaryCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

