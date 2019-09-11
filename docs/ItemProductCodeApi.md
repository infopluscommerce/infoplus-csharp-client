# Infoplus.Api.ItemProductCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemProductCode**](ItemProductCodeApi.md#additemproductcode) | **POST** /beta/itemProductCode | Create an itemProductCode
[**AddItemProductCodeAudit**](ItemProductCodeApi.md#additemproductcodeaudit) | **PUT** /beta/itemProductCode/{itemProductCodeId}/audit/{itemProductCodeAudit} | Add new audit for an itemProductCode
[**AddItemProductCodeFile**](ItemProductCodeApi.md#additemproductcodefile) | **POST** /beta/itemProductCode/{itemProductCodeId}/file/{fileName} | Attach a file to an itemProductCode
[**AddItemProductCodeTag**](ItemProductCodeApi.md#additemproductcodetag) | **PUT** /beta/itemProductCode/{itemProductCodeId}/tag/{itemProductCodeTag} | Add new tags for an itemProductCode.
[**DeleteItemProductCode**](ItemProductCodeApi.md#deleteitemproductcode) | **DELETE** /beta/itemProductCode/{itemProductCodeId} | Delete an itemProductCode
[**DeleteItemProductCodeTag**](ItemProductCodeApi.md#deleteitemproductcodetag) | **DELETE** /beta/itemProductCode/{itemProductCodeId}/tag/{itemProductCodeTag} | Delete a tag for an itemProductCode.
[**GetDuplicateItemProductCodeById**](ItemProductCodeApi.md#getduplicateitemproductcodebyid) | **GET** /beta/itemProductCode/duplicate/{itemProductCodeId} | Get a duplicated an itemProductCode by id
[**GetItemProductCodeByFilter**](ItemProductCodeApi.md#getitemproductcodebyfilter) | **GET** /beta/itemProductCode/search | Search itemProductCodes by filter
[**GetItemProductCodeById**](ItemProductCodeApi.md#getitemproductcodebyid) | **GET** /beta/itemProductCode/{itemProductCodeId} | Get an itemProductCode by id
[**GetItemProductCodeTags**](ItemProductCodeApi.md#getitemproductcodetags) | **GET** /beta/itemProductCode/{itemProductCodeId}/tag | Get the tags for an itemProductCode.
[**UpdateItemProductCode**](ItemProductCodeApi.md#updateitemproductcode) | **PUT** /beta/itemProductCode | Update an itemProductCode


<a name="additemproductcode"></a>
# **AddItemProductCode**
> ItemProductCode AddItemProductCode (ItemProductCode body)

Create an itemProductCode

Inserts a new itemProductCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemProductCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var body = new ItemProductCode(); // ItemProductCode | ItemProductCode to be inserted.

            try
            {
                // Create an itemProductCode
                ItemProductCode result = apiInstance.AddItemProductCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.AddItemProductCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemProductCode**](ItemProductCode.md)| ItemProductCode to be inserted. | 

### Return type

[**ItemProductCode**](ItemProductCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemproductcodeaudit"></a>
# **AddItemProductCodeAudit**
> void AddItemProductCodeAudit (int? itemProductCodeId, string itemProductCodeAudit)

Add new audit for an itemProductCode

Adds an audit to an existing itemProductCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemProductCodeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to add an audit to
            var itemProductCodeAudit = itemProductCodeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemProductCode
                apiInstance.AddItemProductCodeAudit(itemProductCodeId, itemProductCodeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.AddItemProductCodeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to add an audit to | 
 **itemProductCodeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemproductcodefile"></a>
# **AddItemProductCodeFile**
> void AddItemProductCodeFile (int? itemProductCodeId, string fileName)

Attach a file to an itemProductCode

Adds a file to an existing itemProductCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemProductCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemProductCode
                apiInstance.AddItemProductCodeFile(itemProductCodeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.AddItemProductCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemproductcodetag"></a>
# **AddItemProductCodeTag**
> void AddItemProductCodeTag (int? itemProductCodeId, string itemProductCodeTag)

Add new tags for an itemProductCode.

Adds a tag to an existing itemProductCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemProductCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to add a tag to
            var itemProductCodeTag = itemProductCodeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemProductCode.
                apiInstance.AddItemProductCodeTag(itemProductCodeId, itemProductCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.AddItemProductCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to add a tag to | 
 **itemProductCodeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemproductcode"></a>
# **DeleteItemProductCode**
> void DeleteItemProductCode (int? itemProductCodeId)

Delete an itemProductCode

Deletes the itemProductCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemProductCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to be deleted.

            try
            {
                // Delete an itemProductCode
                apiInstance.DeleteItemProductCode(itemProductCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.DeleteItemProductCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemproductcodetag"></a>
# **DeleteItemProductCodeTag**
> void DeleteItemProductCodeTag (int? itemProductCodeId, string itemProductCodeTag)

Delete a tag for an itemProductCode.

Deletes an existing itemProductCode tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemProductCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to remove tag from
            var itemProductCodeTag = itemProductCodeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemProductCode.
                apiInstance.DeleteItemProductCodeTag(itemProductCodeId, itemProductCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.DeleteItemProductCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to remove tag from | 
 **itemProductCodeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemproductcodebyid"></a>
# **GetDuplicateItemProductCodeById**
> ItemProductCode GetDuplicateItemProductCodeById (int? itemProductCodeId)

Get a duplicated an itemProductCode by id

Returns a duplicated itemProductCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemProductCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to be duplicated.

            try
            {
                // Get a duplicated an itemProductCode by id
                ItemProductCode result = apiInstance.GetDuplicateItemProductCodeById(itemProductCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.GetDuplicateItemProductCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to be duplicated. | 

### Return type

[**ItemProductCode**](ItemProductCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemproductcodebyfilter"></a>
# **GetItemProductCodeByFilter**
> List<ItemProductCode> GetItemProductCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemProductCodes by filter

Returns the list of itemProductCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemProductCodeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemProductCodes by filter
                List&lt;ItemProductCode&gt; result = apiInstance.GetItemProductCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.GetItemProductCodeByFilter: " + e.Message );
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

[**List<ItemProductCode>**](ItemProductCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemproductcodebyid"></a>
# **GetItemProductCodeById**
> ItemProductCode GetItemProductCodeById (int? itemProductCodeId)

Get an itemProductCode by id

Returns the itemProductCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemProductCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to be returned.

            try
            {
                // Get an itemProductCode by id
                ItemProductCode result = apiInstance.GetItemProductCodeById(itemProductCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.GetItemProductCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to be returned. | 

### Return type

[**ItemProductCode**](ItemProductCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemproductcodetags"></a>
# **GetItemProductCodeTags**
> void GetItemProductCodeTags (int? itemProductCodeId)

Get the tags for an itemProductCode.

Get all existing itemProductCode tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemProductCodeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = 56;  // int? | Id of the itemProductCode to get tags for

            try
            {
                // Get the tags for an itemProductCode.
                apiInstance.GetItemProductCodeTags(itemProductCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.GetItemProductCodeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **int?**| Id of the itemProductCode to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemproductcode"></a>
# **UpdateItemProductCode**
> void UpdateItemProductCode (ItemProductCode body)

Update an itemProductCode

Updates an existing itemProductCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemProductCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var body = new ItemProductCode(); // ItemProductCode | ItemProductCode to be updated.

            try
            {
                // Update an itemProductCode
                apiInstance.UpdateItemProductCode(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.UpdateItemProductCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemProductCode**](ItemProductCode.md)| ItemProductCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

