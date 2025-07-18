# Infoplus.Api.ItemSubCategoryApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemSubCategory**](ItemSubCategoryApi.md#additemsubcategory) | **POST** /beta/itemSubCategory | Create an itemSubCategory
[**AddItemSubCategoryAudit**](ItemSubCategoryApi.md#additemsubcategoryaudit) | **PUT** /beta/itemSubCategory/{itemSubCategoryId}/audit/{itemSubCategoryAudit} | Add new audit for an itemSubCategory
[**AddItemSubCategoryFile**](ItemSubCategoryApi.md#additemsubcategoryfile) | **POST** /beta/itemSubCategory/{itemSubCategoryId}/file/{fileName} | Attach a file to an itemSubCategory
[**AddItemSubCategoryFileByURL**](ItemSubCategoryApi.md#additemsubcategoryfilebyurl) | **POST** /beta/itemSubCategory/{itemSubCategoryId}/file | Attach a file to an itemSubCategory by URL.
[**AddItemSubCategoryTag**](ItemSubCategoryApi.md#additemsubcategorytag) | **PUT** /beta/itemSubCategory/{itemSubCategoryId}/tag/{itemSubCategoryTag} | Add new tags for an itemSubCategory.
[**DeleteItemSubCategory**](ItemSubCategoryApi.md#deleteitemsubcategory) | **DELETE** /beta/itemSubCategory/{itemSubCategoryId} | Delete an itemSubCategory
[**DeleteItemSubCategoryFile**](ItemSubCategoryApi.md#deleteitemsubcategoryfile) | **DELETE** /beta/itemSubCategory/{itemSubCategoryId}/file/{fileId} | Delete a file for an itemSubCategory.
[**DeleteItemSubCategoryTag**](ItemSubCategoryApi.md#deleteitemsubcategorytag) | **DELETE** /beta/itemSubCategory/{itemSubCategoryId}/tag/{itemSubCategoryTag} | Delete a tag for an itemSubCategory.
[**GetDuplicateItemSubCategoryById**](ItemSubCategoryApi.md#getduplicateitemsubcategorybyid) | **GET** /beta/itemSubCategory/duplicate/{itemSubCategoryId} | Get a duplicated an itemSubCategory by id
[**GetItemSubCategoryByFilter**](ItemSubCategoryApi.md#getitemsubcategorybyfilter) | **GET** /beta/itemSubCategory/search | Search itemSubCategorys by filter
[**GetItemSubCategoryById**](ItemSubCategoryApi.md#getitemsubcategorybyid) | **GET** /beta/itemSubCategory/{itemSubCategoryId} | Get an itemSubCategory by id
[**GetItemSubCategoryFiles**](ItemSubCategoryApi.md#getitemsubcategoryfiles) | **GET** /beta/itemSubCategory/{itemSubCategoryId}/file | Get the files for an itemSubCategory.
[**GetItemSubCategoryTags**](ItemSubCategoryApi.md#getitemsubcategorytags) | **GET** /beta/itemSubCategory/{itemSubCategoryId}/tag | Get the tags for an itemSubCategory.
[**UpdateItemSubCategory**](ItemSubCategoryApi.md#updateitemsubcategory) | **PUT** /beta/itemSubCategory | Update an itemSubCategory


<a name="additemsubcategory"></a>
# **AddItemSubCategory**
> ItemSubCategory AddItemSubCategory (ItemSubCategory body)

Create an itemSubCategory

Inserts a new itemSubCategory using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSubCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var body = new ItemSubCategory(); // ItemSubCategory | ItemSubCategory to be inserted.

            try
            {
                // Create an itemSubCategory
                ItemSubCategory result = apiInstance.AddItemSubCategory(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.AddItemSubCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSubCategory**](ItemSubCategory.md)| ItemSubCategory to be inserted. | 

### Return type

[**ItemSubCategory**](ItemSubCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsubcategoryaudit"></a>
# **AddItemSubCategoryAudit**
> void AddItemSubCategoryAudit (int? itemSubCategoryId, string itemSubCategoryAudit)

Add new audit for an itemSubCategory

Adds an audit to an existing itemSubCategory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSubCategoryAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to add an audit to
            var itemSubCategoryAudit = itemSubCategoryAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemSubCategory
                apiInstance.AddItemSubCategoryAudit(itemSubCategoryId, itemSubCategoryAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.AddItemSubCategoryAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to add an audit to | 
 **itemSubCategoryAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsubcategoryfile"></a>
# **AddItemSubCategoryFile**
> void AddItemSubCategoryFile (int? itemSubCategoryId, string fileName)

Attach a file to an itemSubCategory

Adds a file to an existing itemSubCategory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSubCategoryFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemSubCategory
                apiInstance.AddItemSubCategoryFile(itemSubCategoryId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.AddItemSubCategoryFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsubcategoryfilebyurl"></a>
# **AddItemSubCategoryFileByURL**
> void AddItemSubCategoryFileByURL (RecordFile body, int? itemSubCategoryId)

Attach a file to an itemSubCategory by URL.

Adds a file to an existing itemSubCategory by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSubCategoryFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to add an file to

            try
            {
                // Attach a file to an itemSubCategory by URL.
                apiInstance.AddItemSubCategoryFileByURL(body, itemSubCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.AddItemSubCategoryFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemsubcategorytag"></a>
# **AddItemSubCategoryTag**
> void AddItemSubCategoryTag (int? itemSubCategoryId, string itemSubCategoryTag)

Add new tags for an itemSubCategory.

Adds a tag to an existing itemSubCategory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemSubCategoryTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to add a tag to
            var itemSubCategoryTag = itemSubCategoryTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemSubCategory.
                apiInstance.AddItemSubCategoryTag(itemSubCategoryId, itemSubCategoryTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.AddItemSubCategoryTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to add a tag to | 
 **itemSubCategoryTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsubcategory"></a>
# **DeleteItemSubCategory**
> void DeleteItemSubCategory (int? itemSubCategoryId)

Delete an itemSubCategory

Deletes the itemSubCategory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSubCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to be deleted.

            try
            {
                // Delete an itemSubCategory
                apiInstance.DeleteItemSubCategory(itemSubCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.DeleteItemSubCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsubcategoryfile"></a>
# **DeleteItemSubCategoryFile**
> void DeleteItemSubCategoryFile (int? itemSubCategoryId, int? fileId)

Delete a file for an itemSubCategory.

Deletes an existing itemSubCategory file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSubCategoryFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemSubCategory.
                apiInstance.DeleteItemSubCategoryFile(itemSubCategoryId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.DeleteItemSubCategoryFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemsubcategorytag"></a>
# **DeleteItemSubCategoryTag**
> void DeleteItemSubCategoryTag (int? itemSubCategoryId, string itemSubCategoryTag)

Delete a tag for an itemSubCategory.

Deletes an existing itemSubCategory tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemSubCategoryTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to remove tag from
            var itemSubCategoryTag = itemSubCategoryTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemSubCategory.
                apiInstance.DeleteItemSubCategoryTag(itemSubCategoryId, itemSubCategoryTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.DeleteItemSubCategoryTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to remove tag from | 
 **itemSubCategoryTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemsubcategorybyid"></a>
# **GetDuplicateItemSubCategoryById**
> ItemSubCategory GetDuplicateItemSubCategoryById (int? itemSubCategoryId)

Get a duplicated an itemSubCategory by id

Returns a duplicated itemSubCategory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemSubCategoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to be duplicated.

            try
            {
                // Get a duplicated an itemSubCategory by id
                ItemSubCategory result = apiInstance.GetDuplicateItemSubCategoryById(itemSubCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.GetDuplicateItemSubCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to be duplicated. | 

### Return type

[**ItemSubCategory**](ItemSubCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsubcategorybyfilter"></a>
# **GetItemSubCategoryByFilter**
> List<ItemSubCategory> GetItemSubCategoryByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemSubCategorys by filter

Returns the list of itemSubCategorys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSubCategoryByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemSubCategorys by filter
                List&lt;ItemSubCategory&gt; result = apiInstance.GetItemSubCategoryByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.GetItemSubCategoryByFilter: " + e.Message );
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

[**List<ItemSubCategory>**](ItemSubCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsubcategorybyid"></a>
# **GetItemSubCategoryById**
> ItemSubCategory GetItemSubCategoryById (int? itemSubCategoryId)

Get an itemSubCategory by id

Returns the itemSubCategory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSubCategoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to be returned.

            try
            {
                // Get an itemSubCategory by id
                ItemSubCategory result = apiInstance.GetItemSubCategoryById(itemSubCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.GetItemSubCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to be returned. | 

### Return type

[**ItemSubCategory**](ItemSubCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsubcategoryfiles"></a>
# **GetItemSubCategoryFiles**
> void GetItemSubCategoryFiles (int? itemSubCategoryId)

Get the files for an itemSubCategory.

Get all existing itemSubCategory files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSubCategoryFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to get files for

            try
            {
                // Get the files for an itemSubCategory.
                apiInstance.GetItemSubCategoryFiles(itemSubCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.GetItemSubCategoryFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemsubcategorytags"></a>
# **GetItemSubCategoryTags**
> void GetItemSubCategoryTags (int? itemSubCategoryId)

Get the tags for an itemSubCategory.

Get all existing itemSubCategory tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSubCategoryTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var itemSubCategoryId = 56;  // int? | Id of the itemSubCategory to get tags for

            try
            {
                // Get the tags for an itemSubCategory.
                apiInstance.GetItemSubCategoryTags(itemSubCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.GetItemSubCategoryTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubCategoryId** | **int?**| Id of the itemSubCategory to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemsubcategory"></a>
# **UpdateItemSubCategory**
> void UpdateItemSubCategory (ItemSubCategory body)

Update an itemSubCategory

Updates an existing itemSubCategory using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemSubCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemSubCategoryApi();
            var body = new ItemSubCategory(); // ItemSubCategory | ItemSubCategory to be updated.

            try
            {
                // Update an itemSubCategory
                apiInstance.UpdateItemSubCategory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubCategoryApi.UpdateItemSubCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemSubCategory**](ItemSubCategory.md)| ItemSubCategory to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

