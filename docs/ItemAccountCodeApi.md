# Infoplus.Api.ItemAccountCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemAccountCode**](ItemAccountCodeApi.md#additemaccountcode) | **POST** /beta/itemAccountCode | Create an itemAccountCode
[**AddItemAccountCodeAudit**](ItemAccountCodeApi.md#additemaccountcodeaudit) | **PUT** /beta/itemAccountCode/{itemAccountCodeId}/audit/{itemAccountCodeAudit} | Add new audit for an itemAccountCode
[**AddItemAccountCodeTag**](ItemAccountCodeApi.md#additemaccountcodetag) | **PUT** /beta/itemAccountCode/{itemAccountCodeId}/tag/{itemAccountCodeTag} | Add new tags for an itemAccountCode.
[**DeleteItemAccountCode**](ItemAccountCodeApi.md#deleteitemaccountcode) | **DELETE** /beta/itemAccountCode/{itemAccountCodeId} | Delete an itemAccountCode
[**DeleteItemAccountCodeTag**](ItemAccountCodeApi.md#deleteitemaccountcodetag) | **DELETE** /beta/itemAccountCode/{itemAccountCodeId}/tag/{itemAccountCodeTag} | Delete a tag for an itemAccountCode.
[**GetDuplicateItemAccountCodeById**](ItemAccountCodeApi.md#getduplicateitemaccountcodebyid) | **GET** /beta/itemAccountCode/duplicate/{itemAccountCodeId} | Get a duplicated an itemAccountCode by id
[**GetItemAccountCodeByFilter**](ItemAccountCodeApi.md#getitemaccountcodebyfilter) | **GET** /beta/itemAccountCode/search | Search itemAccountCodes by filter
[**GetItemAccountCodeById**](ItemAccountCodeApi.md#getitemaccountcodebyid) | **GET** /beta/itemAccountCode/{itemAccountCodeId} | Get an itemAccountCode by id
[**GetItemAccountCodeTags**](ItemAccountCodeApi.md#getitemaccountcodetags) | **GET** /beta/itemAccountCode/{itemAccountCodeId}/tag | Get the tags for an itemAccountCode.
[**UpdateItemAccountCode**](ItemAccountCodeApi.md#updateitemaccountcode) | **PUT** /beta/itemAccountCode | Update an itemAccountCode


<a name="additemaccountcode"></a>
# **AddItemAccountCode**
> ItemAccountCode AddItemAccountCode (ItemAccountCode body)

Create an itemAccountCode

Inserts a new itemAccountCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemAccountCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var body = new ItemAccountCode(); // ItemAccountCode | ItemAccountCode to be inserted.

            try
            {
                // Create an itemAccountCode
                ItemAccountCode result = apiInstance.AddItemAccountCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.AddItemAccountCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemAccountCode**](ItemAccountCode.md)| ItemAccountCode to be inserted. | 

### Return type

[**ItemAccountCode**](ItemAccountCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemaccountcodeaudit"></a>
# **AddItemAccountCodeAudit**
> void AddItemAccountCodeAudit (int? itemAccountCodeId, string itemAccountCodeAudit)

Add new audit for an itemAccountCode

Adds an audit to an existing itemAccountCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemAccountCodeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to add an audit to
            var itemAccountCodeAudit = itemAccountCodeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemAccountCode
                apiInstance.AddItemAccountCodeAudit(itemAccountCodeId, itemAccountCodeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.AddItemAccountCodeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to add an audit to | 
 **itemAccountCodeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemaccountcodetag"></a>
# **AddItemAccountCodeTag**
> void AddItemAccountCodeTag (int? itemAccountCodeId, string itemAccountCodeTag)

Add new tags for an itemAccountCode.

Adds a tag to an existing itemAccountCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemAccountCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to add a tag to
            var itemAccountCodeTag = itemAccountCodeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemAccountCode.
                apiInstance.AddItemAccountCodeTag(itemAccountCodeId, itemAccountCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.AddItemAccountCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to add a tag to | 
 **itemAccountCodeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemaccountcode"></a>
# **DeleteItemAccountCode**
> void DeleteItemAccountCode (int? itemAccountCodeId)

Delete an itemAccountCode

Deletes the itemAccountCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemAccountCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to be deleted.

            try
            {
                // Delete an itemAccountCode
                apiInstance.DeleteItemAccountCode(itemAccountCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.DeleteItemAccountCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemaccountcodetag"></a>
# **DeleteItemAccountCodeTag**
> void DeleteItemAccountCodeTag (int? itemAccountCodeId, string itemAccountCodeTag)

Delete a tag for an itemAccountCode.

Deletes an existing itemAccountCode tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemAccountCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to remove tag from
            var itemAccountCodeTag = itemAccountCodeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemAccountCode.
                apiInstance.DeleteItemAccountCodeTag(itemAccountCodeId, itemAccountCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.DeleteItemAccountCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to remove tag from | 
 **itemAccountCodeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemaccountcodebyid"></a>
# **GetDuplicateItemAccountCodeById**
> ItemAccountCode GetDuplicateItemAccountCodeById (int? itemAccountCodeId)

Get a duplicated an itemAccountCode by id

Returns a duplicated itemAccountCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemAccountCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to be duplicated.

            try
            {
                // Get a duplicated an itemAccountCode by id
                ItemAccountCode result = apiInstance.GetDuplicateItemAccountCodeById(itemAccountCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.GetDuplicateItemAccountCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to be duplicated. | 

### Return type

[**ItemAccountCode**](ItemAccountCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemaccountcodebyfilter"></a>
# **GetItemAccountCodeByFilter**
> List<ItemAccountCode> GetItemAccountCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemAccountCodes by filter

Returns the list of itemAccountCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemAccountCodeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemAccountCodes by filter
                List&lt;ItemAccountCode&gt; result = apiInstance.GetItemAccountCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.GetItemAccountCodeByFilter: " + e.Message );
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

[**List<ItemAccountCode>**](ItemAccountCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemaccountcodebyid"></a>
# **GetItemAccountCodeById**
> ItemAccountCode GetItemAccountCodeById (int? itemAccountCodeId)

Get an itemAccountCode by id

Returns the itemAccountCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemAccountCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to be returned.

            try
            {
                // Get an itemAccountCode by id
                ItemAccountCode result = apiInstance.GetItemAccountCodeById(itemAccountCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.GetItemAccountCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to be returned. | 

### Return type

[**ItemAccountCode**](ItemAccountCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemaccountcodetags"></a>
# **GetItemAccountCodeTags**
> void GetItemAccountCodeTags (int? itemAccountCodeId)

Get the tags for an itemAccountCode.

Get all existing itemAccountCode tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemAccountCodeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = 56;  // int? | Id of the itemAccountCode to get tags for

            try
            {
                // Get the tags for an itemAccountCode.
                apiInstance.GetItemAccountCodeTags(itemAccountCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.GetItemAccountCodeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **int?**| Id of the itemAccountCode to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemaccountcode"></a>
# **UpdateItemAccountCode**
> void UpdateItemAccountCode (ItemAccountCode body)

Update an itemAccountCode

Updates an existing itemAccountCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemAccountCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var body = new ItemAccountCode(); // ItemAccountCode | ItemAccountCode to be updated.

            try
            {
                // Update an itemAccountCode
                apiInstance.UpdateItemAccountCode(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.UpdateItemAccountCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemAccountCode**](ItemAccountCode.md)| ItemAccountCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

