# Infoplus.Api.ItemActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemActivityAudit**](ItemActivityApi.md#additemactivityaudit) | **PUT** /v3.0/itemActivity/{itemActivityId}/audit/{itemActivityAudit} | Add new audit for an itemActivity
[**AddItemActivityFile**](ItemActivityApi.md#additemactivityfile) | **POST** /v3.0/itemActivity/{itemActivityId}/file/{fileName} | Attach a file to an itemActivity
[**AddItemActivityFileByURL**](ItemActivityApi.md#additemactivityfilebyurl) | **POST** /v3.0/itemActivity/{itemActivityId}/file | Attach a file to an itemActivity by URL.
[**AddItemActivityTag**](ItemActivityApi.md#additemactivitytag) | **PUT** /v3.0/itemActivity/{itemActivityId}/tag/{itemActivityTag} | Add new tags for an itemActivity.
[**DeleteItemActivityFile**](ItemActivityApi.md#deleteitemactivityfile) | **DELETE** /v3.0/itemActivity/{itemActivityId}/file/{fileId} | Delete a file for an itemActivity.
[**DeleteItemActivityTag**](ItemActivityApi.md#deleteitemactivitytag) | **DELETE** /v3.0/itemActivity/{itemActivityId}/tag/{itemActivityTag} | Delete a tag for an itemActivity.
[**GetDuplicateItemActivityById**](ItemActivityApi.md#getduplicateitemactivitybyid) | **GET** /v3.0/itemActivity/duplicate/{itemActivityId} | Get a duplicated an itemActivity by id
[**GetItemActivityByFilter**](ItemActivityApi.md#getitemactivitybyfilter) | **GET** /v3.0/itemActivity/search | Search itemActivitys by filter
[**GetItemActivityById**](ItemActivityApi.md#getitemactivitybyid) | **GET** /v3.0/itemActivity/{itemActivityId} | Get an itemActivity by id
[**GetItemActivityFiles**](ItemActivityApi.md#getitemactivityfiles) | **GET** /v3.0/itemActivity/{itemActivityId}/file | Get the files for an itemActivity.
[**GetItemActivityTags**](ItemActivityApi.md#getitemactivitytags) | **GET** /v3.0/itemActivity/{itemActivityId}/tag | Get the tags for an itemActivity.


<a name="additemactivityaudit"></a>
# **AddItemActivityAudit**
> void AddItemActivityAudit (int? itemActivityId, string itemActivityAudit)

Add new audit for an itemActivity

Adds an audit to an existing itemActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to add an audit to
            var itemActivityAudit = itemActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemActivity
                apiInstance.AddItemActivityAudit(itemActivityId, itemActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.AddItemActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to add an audit to | 
 **itemActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemactivityfile"></a>
# **AddItemActivityFile**
> void AddItemActivityFile (int? itemActivityId, string fileName)

Attach a file to an itemActivity

Adds a file to an existing itemActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an itemActivity
                apiInstance.AddItemActivityFile(itemActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.AddItemActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemactivityfilebyurl"></a>
# **AddItemActivityFileByURL**
> void AddItemActivityFileByURL (RecordFile body, int? itemActivityId)

Attach a file to an itemActivity by URL.

Adds a file to an existing itemActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var itemActivityId = 56;  // int? | Id of the itemActivity to add an file to

            try
            {
                // Attach a file to an itemActivity by URL.
                apiInstance.AddItemActivityFileByURL(body, itemActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.AddItemActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **itemActivityId** | **int?**| Id of the itemActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemactivitytag"></a>
# **AddItemActivityTag**
> void AddItemActivityTag (int? itemActivityId, string itemActivityTag)

Add new tags for an itemActivity.

Adds a tag to an existing itemActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to add a tag to
            var itemActivityTag = itemActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemActivity.
                apiInstance.AddItemActivityTag(itemActivityId, itemActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.AddItemActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to add a tag to | 
 **itemActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemactivityfile"></a>
# **DeleteItemActivityFile**
> void DeleteItemActivityFile (int? itemActivityId, int? fileId)

Delete a file for an itemActivity.

Deletes an existing itemActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an itemActivity.
                apiInstance.DeleteItemActivityFile(itemActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.DeleteItemActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemactivitytag"></a>
# **DeleteItemActivityTag**
> void DeleteItemActivityTag (int? itemActivityId, string itemActivityTag)

Delete a tag for an itemActivity.

Deletes an existing itemActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to remove tag from
            var itemActivityTag = itemActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemActivity.
                apiInstance.DeleteItemActivityTag(itemActivityId, itemActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.DeleteItemActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to remove tag from | 
 **itemActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemactivitybyid"></a>
# **GetDuplicateItemActivityById**
> ItemActivity GetDuplicateItemActivityById (int? itemActivityId)

Get a duplicated an itemActivity by id

Returns a duplicated itemActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to be duplicated.

            try
            {
                // Get a duplicated an itemActivity by id
                ItemActivity result = apiInstance.GetDuplicateItemActivityById(itemActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.GetDuplicateItemActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to be duplicated. | 

### Return type

[**ItemActivity**](ItemActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemactivitybyfilter"></a>
# **GetItemActivityByFilter**
> List<ItemActivity> GetItemActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemActivitys by filter

Returns the list of itemActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemActivitys by filter
                List&lt;ItemActivity&gt; result = apiInstance.GetItemActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.GetItemActivityByFilter: " + e.Message );
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

[**List<ItemActivity>**](ItemActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemactivitybyid"></a>
# **GetItemActivityById**
> ItemActivity GetItemActivityById (int? itemActivityId)

Get an itemActivity by id

Returns the itemActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to be returned.

            try
            {
                // Get an itemActivity by id
                ItemActivity result = apiInstance.GetItemActivityById(itemActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.GetItemActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to be returned. | 

### Return type

[**ItemActivity**](ItemActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemactivityfiles"></a>
# **GetItemActivityFiles**
> void GetItemActivityFiles (int? itemActivityId)

Get the files for an itemActivity.

Get all existing itemActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to get files for

            try
            {
                // Get the files for an itemActivity.
                apiInstance.GetItemActivityFiles(itemActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.GetItemActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemactivitytags"></a>
# **GetItemActivityTags**
> void GetItemActivityTags (int? itemActivityId)

Get the tags for an itemActivity.

Get all existing itemActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityApi();
            var itemActivityId = 56;  // int? | Id of the itemActivity to get tags for

            try
            {
                // Get the tags for an itemActivity.
                apiInstance.GetItemActivityTags(itemActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityApi.GetItemActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityId** | **int?**| Id of the itemActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

