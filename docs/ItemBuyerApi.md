# Infoplus.Api.ItemBuyerApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemBuyer**](ItemBuyerApi.md#additembuyer) | **POST** /v3.0/itemBuyer | Create an itemBuyer
[**AddItemBuyerAudit**](ItemBuyerApi.md#additembuyeraudit) | **PUT** /v3.0/itemBuyer/{itemBuyerId}/audit/{itemBuyerAudit} | Add new audit for an itemBuyer
[**AddItemBuyerFile**](ItemBuyerApi.md#additembuyerfile) | **POST** /v3.0/itemBuyer/{itemBuyerId}/file/{fileName} | Attach a file to an itemBuyer
[**AddItemBuyerFileByURL**](ItemBuyerApi.md#additembuyerfilebyurl) | **POST** /v3.0/itemBuyer/{itemBuyerId}/file | Attach a file to an itemBuyer by URL.
[**AddItemBuyerTag**](ItemBuyerApi.md#additembuyertag) | **PUT** /v3.0/itemBuyer/{itemBuyerId}/tag/{itemBuyerTag} | Add new tags for an itemBuyer.
[**DeleteItemBuyer**](ItemBuyerApi.md#deleteitembuyer) | **DELETE** /v3.0/itemBuyer/{itemBuyerId} | Delete an itemBuyer
[**DeleteItemBuyerFile**](ItemBuyerApi.md#deleteitembuyerfile) | **DELETE** /v3.0/itemBuyer/{itemBuyerId}/file/{fileId} | Delete a file for an itemBuyer.
[**DeleteItemBuyerTag**](ItemBuyerApi.md#deleteitembuyertag) | **DELETE** /v3.0/itemBuyer/{itemBuyerId}/tag/{itemBuyerTag} | Delete a tag for an itemBuyer.
[**GetDuplicateItemBuyerById**](ItemBuyerApi.md#getduplicateitembuyerbyid) | **GET** /v3.0/itemBuyer/duplicate/{itemBuyerId} | Get a duplicated an itemBuyer by id
[**GetItemBuyerByFilter**](ItemBuyerApi.md#getitembuyerbyfilter) | **GET** /v3.0/itemBuyer/search | Search itemBuyers by filter
[**GetItemBuyerById**](ItemBuyerApi.md#getitembuyerbyid) | **GET** /v3.0/itemBuyer/{itemBuyerId} | Get an itemBuyer by id
[**GetItemBuyerFiles**](ItemBuyerApi.md#getitembuyerfiles) | **GET** /v3.0/itemBuyer/{itemBuyerId}/file | Get the files for an itemBuyer.
[**GetItemBuyerTags**](ItemBuyerApi.md#getitembuyertags) | **GET** /v3.0/itemBuyer/{itemBuyerId}/tag | Get the tags for an itemBuyer.
[**UpdateItemBuyer**](ItemBuyerApi.md#updateitembuyer) | **PUT** /v3.0/itemBuyer | Update an itemBuyer


<a name="additembuyer"></a>
# **AddItemBuyer**
> ItemBuyer AddItemBuyer (ItemBuyer body)

Create an itemBuyer

Inserts a new itemBuyer using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemBuyerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var body = new ItemBuyer(); // ItemBuyer | ItemBuyer to be inserted.

            try
            {
                // Create an itemBuyer
                ItemBuyer result = apiInstance.AddItemBuyer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.AddItemBuyer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemBuyer**](ItemBuyer.md)| ItemBuyer to be inserted. | 

### Return type

[**ItemBuyer**](ItemBuyer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additembuyeraudit"></a>
# **AddItemBuyerAudit**
> void AddItemBuyerAudit (int? itemBuyerId, string itemBuyerAudit)

Add new audit for an itemBuyer

Adds an audit to an existing itemBuyer.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemBuyerAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to add an audit to
            var itemBuyerAudit = itemBuyerAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemBuyer
                apiInstance.AddItemBuyerAudit(itemBuyerId, itemBuyerAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.AddItemBuyerAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to add an audit to | 
 **itemBuyerAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additembuyerfile"></a>
# **AddItemBuyerFile**
> void AddItemBuyerFile (int? itemBuyerId, string fileName)

Attach a file to an itemBuyer

Adds a file to an existing itemBuyer.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemBuyerFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemBuyer
                apiInstance.AddItemBuyerFile(itemBuyerId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.AddItemBuyerFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additembuyerfilebyurl"></a>
# **AddItemBuyerFileByURL**
> void AddItemBuyerFileByURL (RecordFile body, int? itemBuyerId)

Attach a file to an itemBuyer by URL.

Adds a file to an existing itemBuyer by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemBuyerFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to add an file to

            try
            {
                // Attach a file to an itemBuyer by URL.
                apiInstance.AddItemBuyerFileByURL(body, itemBuyerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.AddItemBuyerFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemBuyerId** | **int?**| Id of the itemBuyer to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additembuyertag"></a>
# **AddItemBuyerTag**
> void AddItemBuyerTag (int? itemBuyerId, string itemBuyerTag)

Add new tags for an itemBuyer.

Adds a tag to an existing itemBuyer.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemBuyerTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to add a tag to
            var itemBuyerTag = itemBuyerTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemBuyer.
                apiInstance.AddItemBuyerTag(itemBuyerId, itemBuyerTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.AddItemBuyerTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to add a tag to | 
 **itemBuyerTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitembuyer"></a>
# **DeleteItemBuyer**
> void DeleteItemBuyer (int? itemBuyerId)

Delete an itemBuyer

Deletes the itemBuyer identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemBuyerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to be deleted.

            try
            {
                // Delete an itemBuyer
                apiInstance.DeleteItemBuyer(itemBuyerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.DeleteItemBuyer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitembuyerfile"></a>
# **DeleteItemBuyerFile**
> void DeleteItemBuyerFile (int? itemBuyerId, int? fileId)

Delete a file for an itemBuyer.

Deletes an existing itemBuyer file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemBuyerFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemBuyer.
                apiInstance.DeleteItemBuyerFile(itemBuyerId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.DeleteItemBuyerFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitembuyertag"></a>
# **DeleteItemBuyerTag**
> void DeleteItemBuyerTag (int? itemBuyerId, string itemBuyerTag)

Delete a tag for an itemBuyer.

Deletes an existing itemBuyer tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemBuyerTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to remove tag from
            var itemBuyerTag = itemBuyerTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemBuyer.
                apiInstance.DeleteItemBuyerTag(itemBuyerId, itemBuyerTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.DeleteItemBuyerTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to remove tag from | 
 **itemBuyerTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitembuyerbyid"></a>
# **GetDuplicateItemBuyerById**
> ItemBuyer GetDuplicateItemBuyerById (int? itemBuyerId)

Get a duplicated an itemBuyer by id

Returns a duplicated itemBuyer identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemBuyerByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to be duplicated.

            try
            {
                // Get a duplicated an itemBuyer by id
                ItemBuyer result = apiInstance.GetDuplicateItemBuyerById(itemBuyerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.GetDuplicateItemBuyerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to be duplicated. | 

### Return type

[**ItemBuyer**](ItemBuyer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembuyerbyfilter"></a>
# **GetItemBuyerByFilter**
> List<ItemBuyer> GetItemBuyerByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemBuyers by filter

Returns the list of itemBuyers that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemBuyerByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemBuyers by filter
                List&lt;ItemBuyer&gt; result = apiInstance.GetItemBuyerByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.GetItemBuyerByFilter: " + e.Message );
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

[**List<ItemBuyer>**](ItemBuyer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembuyerbyid"></a>
# **GetItemBuyerById**
> ItemBuyer GetItemBuyerById (int? itemBuyerId)

Get an itemBuyer by id

Returns the itemBuyer identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemBuyerByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to be returned.

            try
            {
                // Get an itemBuyer by id
                ItemBuyer result = apiInstance.GetItemBuyerById(itemBuyerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.GetItemBuyerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to be returned. | 

### Return type

[**ItemBuyer**](ItemBuyer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembuyerfiles"></a>
# **GetItemBuyerFiles**
> void GetItemBuyerFiles (int? itemBuyerId)

Get the files for an itemBuyer.

Get all existing itemBuyer files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemBuyerFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to get files for

            try
            {
                // Get the files for an itemBuyer.
                apiInstance.GetItemBuyerFiles(itemBuyerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.GetItemBuyerFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitembuyertags"></a>
# **GetItemBuyerTags**
> void GetItemBuyerTags (int? itemBuyerId)

Get the tags for an itemBuyer.

Get all existing itemBuyer tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemBuyerTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var itemBuyerId = 56;  // int? | Id of the itemBuyer to get tags for

            try
            {
                // Get the tags for an itemBuyer.
                apiInstance.GetItemBuyerTags(itemBuyerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.GetItemBuyerTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemBuyerId** | **int?**| Id of the itemBuyer to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitembuyer"></a>
# **UpdateItemBuyer**
> void UpdateItemBuyer (ItemBuyer body)

Update an itemBuyer

Updates an existing itemBuyer using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemBuyerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemBuyerApi();
            var body = new ItemBuyer(); // ItemBuyer | ItemBuyer to be updated.

            try
            {
                // Update an itemBuyer
                apiInstance.UpdateItemBuyer(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemBuyerApi.UpdateItemBuyer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemBuyer**](ItemBuyer.md)| ItemBuyer to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

