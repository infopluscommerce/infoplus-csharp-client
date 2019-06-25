# Infoplus.Api.ItemApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItem**](ItemApi.md#additem) | **POST** /beta/item | Create an item
[**AddItemAudit**](ItemApi.md#additemaudit) | **PUT** /beta/item/{itemId}/audit/{itemAudit} | Add new audit for an item
[**AddItemFile**](ItemApi.md#additemfile) | **POST** /beta/item/{itemId}/file/{fileName} | Attach a file to an item
[**AddItemTag**](ItemApi.md#additemtag) | **PUT** /beta/item/{itemId}/tag/{itemTag} | Add new tags for an item.
[**DeleteItem**](ItemApi.md#deleteitem) | **DELETE** /beta/item/{itemId} | Delete an item
[**DeleteItemTag**](ItemApi.md#deleteitemtag) | **DELETE** /beta/item/{itemId}/tag/{itemTag} | Delete a tag for an item.
[**GetBySKU**](ItemApi.md#getbysku) | **GET** /beta/item/getBySKU | Get an item by SKU
[**GetDuplicateItemById**](ItemApi.md#getduplicateitembyid) | **GET** /beta/item/duplicate/{itemId} | Get a duplicated an item by id
[**GetItemByFilter**](ItemApi.md#getitembyfilter) | **GET** /beta/item/search | Search items by filter
[**GetItemById**](ItemApi.md#getitembyid) | **GET** /beta/item/{itemId} | Get an item by id
[**GetItemTags**](ItemApi.md#getitemtags) | **GET** /beta/item/{itemId}/tag | Get the tags for an item.
[**UpdateItem**](ItemApi.md#updateitem) | **PUT** /beta/item | Update an item
[**UpdateItemCustomFields**](ItemApi.md#updateitemcustomfields) | **PUT** /beta/item/customFields | Update an item custom fields


<a name="additem"></a>
# **AddItem**
> Item AddItem (Item body)

Create an item

Inserts a new item using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new Item(); // Item | Item to be inserted.

            try
            {
                // Create an item
                Item result = apiInstance.AddItem(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.AddItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Item**](Item.md)| Item to be inserted. | 

### Return type

[**Item**](Item.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemaudit"></a>
# **AddItemAudit**
> void AddItemAudit (int? itemId, string itemAudit)

Add new audit for an item

Adds an audit to an existing item.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to add an audit to
            var itemAudit = itemAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an item
                apiInstance.AddItemAudit(itemId, itemAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.AddItemAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to add an audit to | 
 **itemAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemfile"></a>
# **AddItemFile**
> void AddItemFile (int? itemId, string fileName)

Attach a file to an item

Adds a file to an existing item.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an item
                apiInstance.AddItemFile(itemId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.AddItemFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemtag"></a>
# **AddItemTag**
> void AddItemTag (int? itemId, string itemTag)

Add new tags for an item.

Adds a tag to an existing item.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to add a tag to
            var itemTag = itemTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an item.
                apiInstance.AddItemTag(itemId, itemTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.AddItemTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to add a tag to | 
 **itemTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitem"></a>
# **DeleteItem**
> void DeleteItem (int? itemId)

Delete an item

Deletes the item identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to be deleted.

            try
            {
                // Delete an item
                apiInstance.DeleteItem(itemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.DeleteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemtag"></a>
# **DeleteItemTag**
> void DeleteItemTag (int? itemId, string itemTag)

Delete a tag for an item.

Deletes an existing item tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to remove tag from
            var itemTag = itemTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an item.
                apiInstance.DeleteItemTag(itemId, itemTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.DeleteItemTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to remove tag from | 
 **itemTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbysku"></a>
# **GetBySKU**
> Item GetBySKU (int? lobId, string sku)

Get an item by SKU

Returns the item identified by the specified parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBySKUExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var lobId = 56;  // int? | lobId of the item to be returned.
            var sku = sku_example;  // string | sku of the item to be returned.

            try
            {
                // Get an item by SKU
                Item result = apiInstance.GetBySKU(lobId, sku);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetBySKU: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lobId** | **int?**| lobId of the item to be returned. | 
 **sku** | **string**| sku of the item to be returned. | 

### Return type

[**Item**](Item.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitembyid"></a>
# **GetDuplicateItemById**
> Item GetDuplicateItemById (int? itemId)

Get a duplicated an item by id

Returns a duplicated item identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to be duplicated.

            try
            {
                // Get a duplicated an item by id
                Item result = apiInstance.GetDuplicateItemById(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetDuplicateItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to be duplicated. | 

### Return type

[**Item**](Item.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembyfilter"></a>
# **GetItemByFilter**
> List<Item> GetItemByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search items by filter

Returns the list of items that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search items by filter
                List&lt;Item&gt; result = apiInstance.GetItemByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItemByFilter: " + e.Message );
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

[**List<Item>**](Item.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembyid"></a>
# **GetItemById**
> Item GetItemById (int? itemId)

Get an item by id

Returns the item identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to be returned.

            try
            {
                // Get an item by id
                Item result = apiInstance.GetItemById(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to be returned. | 

### Return type

[**Item**](Item.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemtags"></a>
# **GetItemTags**
> void GetItemTags (int? itemId)

Get the tags for an item.

Get all existing item tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var itemId = 56;  // int? | Id of the item to get tags for

            try
            {
                // Get the tags for an item.
                apiInstance.GetItemTags(itemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.GetItemTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **int?**| Id of the item to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitem"></a>
# **UpdateItem**
> void UpdateItem (Item body)

Update an item

Updates an existing item using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new Item(); // Item | Item to be updated.

            try
            {
                // Update an item
                apiInstance.UpdateItem(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Item**](Item.md)| Item to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemcustomfields"></a>
# **UpdateItemCustomFields**
> void UpdateItemCustomFields (Item body)

Update an item custom fields

Updates an existing item custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemApi();
            var body = new Item(); // Item | Item to be updated.

            try
            {
                // Update an item custom fields
                apiInstance.UpdateItemCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemApi.UpdateItemCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Item**](Item.md)| Item to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

