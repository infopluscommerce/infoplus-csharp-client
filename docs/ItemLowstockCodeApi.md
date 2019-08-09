# Infoplus.Api.ItemLowstockCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemLowstockCode**](ItemLowstockCodeApi.md#additemlowstockcode) | **POST** /beta/itemLowstockCode | Create an itemLowstockCode
[**AddItemLowstockCodeAudit**](ItemLowstockCodeApi.md#additemlowstockcodeaudit) | **PUT** /beta/itemLowstockCode/{itemLowstockCodeId}/audit/{itemLowstockCodeAudit} | Add new audit for an itemLowstockCode
[**AddItemLowstockCodeFile**](ItemLowstockCodeApi.md#additemlowstockcodefile) | **POST** /beta/itemLowstockCode/{itemLowstockCodeId}/file/{fileName} | Attach a file to an itemLowstockCode
[**AddItemLowstockCodeTag**](ItemLowstockCodeApi.md#additemlowstockcodetag) | **PUT** /beta/itemLowstockCode/{itemLowstockCodeId}/tag/{itemLowstockCodeTag} | Add new tags for an itemLowstockCode.
[**DeleteItemLowstockCode**](ItemLowstockCodeApi.md#deleteitemlowstockcode) | **DELETE** /beta/itemLowstockCode/{itemLowstockCodeId} | Delete an itemLowstockCode
[**DeleteItemLowstockCodeTag**](ItemLowstockCodeApi.md#deleteitemlowstockcodetag) | **DELETE** /beta/itemLowstockCode/{itemLowstockCodeId}/tag/{itemLowstockCodeTag} | Delete a tag for an itemLowstockCode.
[**GetDuplicateItemLowstockCodeById**](ItemLowstockCodeApi.md#getduplicateitemlowstockcodebyid) | **GET** /beta/itemLowstockCode/duplicate/{itemLowstockCodeId} | Get a duplicated an itemLowstockCode by id
[**GetItemLowstockCodeByFilter**](ItemLowstockCodeApi.md#getitemlowstockcodebyfilter) | **GET** /beta/itemLowstockCode/search | Search itemLowstockCodes by filter
[**GetItemLowstockCodeById**](ItemLowstockCodeApi.md#getitemlowstockcodebyid) | **GET** /beta/itemLowstockCode/{itemLowstockCodeId} | Get an itemLowstockCode by id
[**GetItemLowstockCodeTags**](ItemLowstockCodeApi.md#getitemlowstockcodetags) | **GET** /beta/itemLowstockCode/{itemLowstockCodeId}/tag | Get the tags for an itemLowstockCode.
[**UpdateItemLowstockCode**](ItemLowstockCodeApi.md#updateitemlowstockcode) | **PUT** /beta/itemLowstockCode | Update an itemLowstockCode


<a name="additemlowstockcode"></a>
# **AddItemLowstockCode**
> ItemLowstockCode AddItemLowstockCode (ItemLowstockCode body)

Create an itemLowstockCode

Inserts a new itemLowstockCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemLowstockCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var body = new ItemLowstockCode(); // ItemLowstockCode | ItemLowstockCode to be inserted.

            try
            {
                // Create an itemLowstockCode
                ItemLowstockCode result = apiInstance.AddItemLowstockCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.AddItemLowstockCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemLowstockCode**](ItemLowstockCode.md)| ItemLowstockCode to be inserted. | 

### Return type

[**ItemLowstockCode**](ItemLowstockCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemlowstockcodeaudit"></a>
# **AddItemLowstockCodeAudit**
> void AddItemLowstockCodeAudit (int? itemLowstockCodeId, string itemLowstockCodeAudit)

Add new audit for an itemLowstockCode

Adds an audit to an existing itemLowstockCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemLowstockCodeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to add an audit to
            var itemLowstockCodeAudit = itemLowstockCodeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemLowstockCode
                apiInstance.AddItemLowstockCodeAudit(itemLowstockCodeId, itemLowstockCodeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.AddItemLowstockCodeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to add an audit to | 
 **itemLowstockCodeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemlowstockcodefile"></a>
# **AddItemLowstockCodeFile**
> void AddItemLowstockCodeFile (int? itemLowstockCodeId, string fileName)

Attach a file to an itemLowstockCode

Adds a file to an existing itemLowstockCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemLowstockCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemLowstockCode
                apiInstance.AddItemLowstockCodeFile(itemLowstockCodeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.AddItemLowstockCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemlowstockcodetag"></a>
# **AddItemLowstockCodeTag**
> void AddItemLowstockCodeTag (int? itemLowstockCodeId, string itemLowstockCodeTag)

Add new tags for an itemLowstockCode.

Adds a tag to an existing itemLowstockCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemLowstockCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to add a tag to
            var itemLowstockCodeTag = itemLowstockCodeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemLowstockCode.
                apiInstance.AddItemLowstockCodeTag(itemLowstockCodeId, itemLowstockCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.AddItemLowstockCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to add a tag to | 
 **itemLowstockCodeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemlowstockcode"></a>
# **DeleteItemLowstockCode**
> void DeleteItemLowstockCode (int? itemLowstockCodeId)

Delete an itemLowstockCode

Deletes the itemLowstockCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemLowstockCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to be deleted.

            try
            {
                // Delete an itemLowstockCode
                apiInstance.DeleteItemLowstockCode(itemLowstockCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.DeleteItemLowstockCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemlowstockcodetag"></a>
# **DeleteItemLowstockCodeTag**
> void DeleteItemLowstockCodeTag (int? itemLowstockCodeId, string itemLowstockCodeTag)

Delete a tag for an itemLowstockCode.

Deletes an existing itemLowstockCode tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemLowstockCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to remove tag from
            var itemLowstockCodeTag = itemLowstockCodeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemLowstockCode.
                apiInstance.DeleteItemLowstockCodeTag(itemLowstockCodeId, itemLowstockCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.DeleteItemLowstockCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to remove tag from | 
 **itemLowstockCodeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemlowstockcodebyid"></a>
# **GetDuplicateItemLowstockCodeById**
> ItemLowstockCode GetDuplicateItemLowstockCodeById (int? itemLowstockCodeId)

Get a duplicated an itemLowstockCode by id

Returns a duplicated itemLowstockCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemLowstockCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to be duplicated.

            try
            {
                // Get a duplicated an itemLowstockCode by id
                ItemLowstockCode result = apiInstance.GetDuplicateItemLowstockCodeById(itemLowstockCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.GetDuplicateItemLowstockCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to be duplicated. | 

### Return type

[**ItemLowstockCode**](ItemLowstockCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemlowstockcodebyfilter"></a>
# **GetItemLowstockCodeByFilter**
> List<ItemLowstockCode> GetItemLowstockCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemLowstockCodes by filter

Returns the list of itemLowstockCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemLowstockCodeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemLowstockCodes by filter
                List&lt;ItemLowstockCode&gt; result = apiInstance.GetItemLowstockCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.GetItemLowstockCodeByFilter: " + e.Message );
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

[**List<ItemLowstockCode>**](ItemLowstockCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemlowstockcodebyid"></a>
# **GetItemLowstockCodeById**
> ItemLowstockCode GetItemLowstockCodeById (int? itemLowstockCodeId)

Get an itemLowstockCode by id

Returns the itemLowstockCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemLowstockCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to be returned.

            try
            {
                // Get an itemLowstockCode by id
                ItemLowstockCode result = apiInstance.GetItemLowstockCodeById(itemLowstockCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.GetItemLowstockCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to be returned. | 

### Return type

[**ItemLowstockCode**](ItemLowstockCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemlowstockcodetags"></a>
# **GetItemLowstockCodeTags**
> void GetItemLowstockCodeTags (int? itemLowstockCodeId)

Get the tags for an itemLowstockCode.

Get all existing itemLowstockCode tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemLowstockCodeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var itemLowstockCodeId = 56;  // int? | Id of the itemLowstockCode to get tags for

            try
            {
                // Get the tags for an itemLowstockCode.
                apiInstance.GetItemLowstockCodeTags(itemLowstockCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.GetItemLowstockCodeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowstockCodeId** | **int?**| Id of the itemLowstockCode to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemlowstockcode"></a>
# **UpdateItemLowstockCode**
> void UpdateItemLowstockCode (ItemLowstockCode body)

Update an itemLowstockCode

Updates an existing itemLowstockCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemLowstockCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemLowstockCodeApi();
            var body = new ItemLowstockCode(); // ItemLowstockCode | ItemLowstockCode to be updated.

            try
            {
                // Update an itemLowstockCode
                apiInstance.UpdateItemLowstockCode(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowstockCodeApi.UpdateItemLowstockCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemLowstockCode**](ItemLowstockCode.md)| ItemLowstockCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

