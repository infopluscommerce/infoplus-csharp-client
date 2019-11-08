# Infoplus.Api.ItemCategoryApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemCategory**](ItemCategoryApi.md#additemcategory) | **POST** /beta/itemCategory | Create an itemCategory
[**AddItemCategoryAudit**](ItemCategoryApi.md#additemcategoryaudit) | **PUT** /beta/itemCategory/{itemCategoryId}/audit/{itemCategoryAudit} | Add new audit for an itemCategory
[**AddItemCategoryFile**](ItemCategoryApi.md#additemcategoryfile) | **POST** /beta/itemCategory/{itemCategoryId}/file/{fileName} | Attach a file to an itemCategory
[**AddItemCategoryTag**](ItemCategoryApi.md#additemcategorytag) | **PUT** /beta/itemCategory/{itemCategoryId}/tag/{itemCategoryTag} | Add new tags for an itemCategory.
[**DeleteItemCategory**](ItemCategoryApi.md#deleteitemcategory) | **DELETE** /beta/itemCategory/{itemCategoryId} | Delete an itemCategory
[**DeleteItemCategoryTag**](ItemCategoryApi.md#deleteitemcategorytag) | **DELETE** /beta/itemCategory/{itemCategoryId}/tag/{itemCategoryTag} | Delete a tag for an itemCategory.
[**GetDuplicateItemCategoryById**](ItemCategoryApi.md#getduplicateitemcategorybyid) | **GET** /beta/itemCategory/duplicate/{itemCategoryId} | Get a duplicated an itemCategory by id
[**GetItemCategoryByFilter**](ItemCategoryApi.md#getitemcategorybyfilter) | **GET** /beta/itemCategory/search | Search itemCategorys by filter
[**GetItemCategoryById**](ItemCategoryApi.md#getitemcategorybyid) | **GET** /beta/itemCategory/{itemCategoryId} | Get an itemCategory by id
[**GetItemCategoryTags**](ItemCategoryApi.md#getitemcategorytags) | **GET** /beta/itemCategory/{itemCategoryId}/tag | Get the tags for an itemCategory.
[**UpdateItemCategory**](ItemCategoryApi.md#updateitemcategory) | **PUT** /beta/itemCategory | Update an itemCategory


<a name="additemcategory"></a>
# **AddItemCategory**
> ItemCategory AddItemCategory (ItemCategory body)

Create an itemCategory

Inserts a new itemCategory using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var body = new ItemCategory(); // ItemCategory | ItemCategory to be inserted.

            try
            {
                // Create an itemCategory
                ItemCategory result = apiInstance.AddItemCategory(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.AddItemCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemCategory**](ItemCategory.md)| ItemCategory to be inserted. | 

### Return type

[**ItemCategory**](ItemCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemcategoryaudit"></a>
# **AddItemCategoryAudit**
> void AddItemCategoryAudit (int? itemCategoryId, string itemCategoryAudit)

Add new audit for an itemCategory

Adds an audit to an existing itemCategory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemCategoryAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to add an audit to
            var itemCategoryAudit = itemCategoryAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemCategory
                apiInstance.AddItemCategoryAudit(itemCategoryId, itemCategoryAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.AddItemCategoryAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to add an audit to | 
 **itemCategoryAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemcategoryfile"></a>
# **AddItemCategoryFile**
> void AddItemCategoryFile (int? itemCategoryId, string fileName)

Attach a file to an itemCategory

Adds a file to an existing itemCategory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemCategoryFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemCategory
                apiInstance.AddItemCategoryFile(itemCategoryId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.AddItemCategoryFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemcategorytag"></a>
# **AddItemCategoryTag**
> void AddItemCategoryTag (int? itemCategoryId, string itemCategoryTag)

Add new tags for an itemCategory.

Adds a tag to an existing itemCategory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemCategoryTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to add a tag to
            var itemCategoryTag = itemCategoryTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemCategory.
                apiInstance.AddItemCategoryTag(itemCategoryId, itemCategoryTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.AddItemCategoryTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to add a tag to | 
 **itemCategoryTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemcategory"></a>
# **DeleteItemCategory**
> void DeleteItemCategory (int? itemCategoryId)

Delete an itemCategory

Deletes the itemCategory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to be deleted.

            try
            {
                // Delete an itemCategory
                apiInstance.DeleteItemCategory(itemCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.DeleteItemCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemcategorytag"></a>
# **DeleteItemCategoryTag**
> void DeleteItemCategoryTag (int? itemCategoryId, string itemCategoryTag)

Delete a tag for an itemCategory.

Deletes an existing itemCategory tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemCategoryTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to remove tag from
            var itemCategoryTag = itemCategoryTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemCategory.
                apiInstance.DeleteItemCategoryTag(itemCategoryId, itemCategoryTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.DeleteItemCategoryTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to remove tag from | 
 **itemCategoryTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemcategorybyid"></a>
# **GetDuplicateItemCategoryById**
> ItemCategory GetDuplicateItemCategoryById (int? itemCategoryId)

Get a duplicated an itemCategory by id

Returns a duplicated itemCategory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemCategoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to be duplicated.

            try
            {
                // Get a duplicated an itemCategory by id
                ItemCategory result = apiInstance.GetDuplicateItemCategoryById(itemCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.GetDuplicateItemCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to be duplicated. | 

### Return type

[**ItemCategory**](ItemCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemcategorybyfilter"></a>
# **GetItemCategoryByFilter**
> List<ItemCategory> GetItemCategoryByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemCategorys by filter

Returns the list of itemCategorys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemCategoryByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemCategorys by filter
                List&lt;ItemCategory&gt; result = apiInstance.GetItemCategoryByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.GetItemCategoryByFilter: " + e.Message );
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

[**List<ItemCategory>**](ItemCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemcategorybyid"></a>
# **GetItemCategoryById**
> ItemCategory GetItemCategoryById (int? itemCategoryId)

Get an itemCategory by id

Returns the itemCategory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemCategoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to be returned.

            try
            {
                // Get an itemCategory by id
                ItemCategory result = apiInstance.GetItemCategoryById(itemCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.GetItemCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to be returned. | 

### Return type

[**ItemCategory**](ItemCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemcategorytags"></a>
# **GetItemCategoryTags**
> void GetItemCategoryTags (int? itemCategoryId)

Get the tags for an itemCategory.

Get all existing itemCategory tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemCategoryTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var itemCategoryId = 56;  // int? | Id of the itemCategory to get tags for

            try
            {
                // Get the tags for an itemCategory.
                apiInstance.GetItemCategoryTags(itemCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.GetItemCategoryTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemCategoryId** | **int?**| Id of the itemCategory to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemcategory"></a>
# **UpdateItemCategory**
> void UpdateItemCategory (ItemCategory body)

Update an itemCategory

Updates an existing itemCategory using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemCategoryApi();
            var body = new ItemCategory(); // ItemCategory | ItemCategory to be updated.

            try
            {
                // Update an itemCategory
                apiInstance.UpdateItemCategory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemCategoryApi.UpdateItemCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemCategory**](ItemCategory.md)| ItemCategory to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

