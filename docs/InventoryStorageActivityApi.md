# Infoplus.Api.InventoryStorageActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventoryStorageActivity**](InventoryStorageActivityApi.md#addinventorystorageactivity) | **POST** /v3.0/inventoryStorageActivity | Create an inventoryStorageActivity
[**AddInventoryStorageActivityAudit**](InventoryStorageActivityApi.md#addinventorystorageactivityaudit) | **PUT** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/audit/{inventoryStorageActivityAudit} | Add new audit for an inventoryStorageActivity
[**AddInventoryStorageActivityFile**](InventoryStorageActivityApi.md#addinventorystorageactivityfile) | **POST** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/file/{fileName} | Attach a file to an inventoryStorageActivity
[**AddInventoryStorageActivityFileByURL**](InventoryStorageActivityApi.md#addinventorystorageactivityfilebyurl) | **POST** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/file | Attach a file to an inventoryStorageActivity by URL.
[**AddInventoryStorageActivityTag**](InventoryStorageActivityApi.md#addinventorystorageactivitytag) | **PUT** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/tag/{inventoryStorageActivityTag} | Add new tags for an inventoryStorageActivity.
[**DeleteInventoryStorageActivity**](InventoryStorageActivityApi.md#deleteinventorystorageactivity) | **DELETE** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId} | Delete an inventoryStorageActivity
[**DeleteInventoryStorageActivityFile**](InventoryStorageActivityApi.md#deleteinventorystorageactivityfile) | **DELETE** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/file/{fileId} | Delete a file for an inventoryStorageActivity.
[**DeleteInventoryStorageActivityTag**](InventoryStorageActivityApi.md#deleteinventorystorageactivitytag) | **DELETE** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/tag/{inventoryStorageActivityTag} | Delete a tag for an inventoryStorageActivity.
[**GetDuplicateInventoryStorageActivityById**](InventoryStorageActivityApi.md#getduplicateinventorystorageactivitybyid) | **GET** /v3.0/inventoryStorageActivity/duplicate/{inventoryStorageActivityId} | Get a duplicated an inventoryStorageActivity by id
[**GetInventoryStorageActivityByFilter**](InventoryStorageActivityApi.md#getinventorystorageactivitybyfilter) | **GET** /v3.0/inventoryStorageActivity/search | Search inventoryStorageActivitys by filter
[**GetInventoryStorageActivityById**](InventoryStorageActivityApi.md#getinventorystorageactivitybyid) | **GET** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId} | Get an inventoryStorageActivity by id
[**GetInventoryStorageActivityFiles**](InventoryStorageActivityApi.md#getinventorystorageactivityfiles) | **GET** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/file | Get the files for an inventoryStorageActivity.
[**GetInventoryStorageActivityTags**](InventoryStorageActivityApi.md#getinventorystorageactivitytags) | **GET** /v3.0/inventoryStorageActivity/{inventoryStorageActivityId}/tag | Get the tags for an inventoryStorageActivity.
[**UpdateInventoryStorageActivity**](InventoryStorageActivityApi.md#updateinventorystorageactivity) | **PUT** /v3.0/inventoryStorageActivity | Update an inventoryStorageActivity


<a name="addinventorystorageactivity"></a>
# **AddInventoryStorageActivity**
> InventoryStorageActivity AddInventoryStorageActivity (InventoryStorageActivity body)

Create an inventoryStorageActivity

Inserts a new inventoryStorageActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryStorageActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var body = new InventoryStorageActivity(); // InventoryStorageActivity | InventoryStorageActivity to be inserted.

            try
            {
                // Create an inventoryStorageActivity
                InventoryStorageActivity result = apiInstance.AddInventoryStorageActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.AddInventoryStorageActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryStorageActivity**](InventoryStorageActivity.md)| InventoryStorageActivity to be inserted. | 

### Return type

[**InventoryStorageActivity**](InventoryStorageActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorystorageactivityaudit"></a>
# **AddInventoryStorageActivityAudit**
> void AddInventoryStorageActivityAudit (int? inventoryStorageActivityId, string inventoryStorageActivityAudit)

Add new audit for an inventoryStorageActivity

Adds an audit to an existing inventoryStorageActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryStorageActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to add an audit to
            var inventoryStorageActivityAudit = inventoryStorageActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an inventoryStorageActivity
                apiInstance.AddInventoryStorageActivityAudit(inventoryStorageActivityId, inventoryStorageActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.AddInventoryStorageActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to add an audit to | 
 **inventoryStorageActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorystorageactivityfile"></a>
# **AddInventoryStorageActivityFile**
> void AddInventoryStorageActivityFile (int? inventoryStorageActivityId, string fileName)

Attach a file to an inventoryStorageActivity

Adds a file to an existing inventoryStorageActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryStorageActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an inventoryStorageActivity
                apiInstance.AddInventoryStorageActivityFile(inventoryStorageActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.AddInventoryStorageActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorystorageactivityfilebyurl"></a>
# **AddInventoryStorageActivityFileByURL**
> void AddInventoryStorageActivityFileByURL (RecordFile body, int? inventoryStorageActivityId)

Attach a file to an inventoryStorageActivity by URL.

Adds a file to an existing inventoryStorageActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryStorageActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to add an file to

            try
            {
                // Attach a file to an inventoryStorageActivity by URL.
                apiInstance.AddInventoryStorageActivityFileByURL(body, inventoryStorageActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.AddInventoryStorageActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorystorageactivitytag"></a>
# **AddInventoryStorageActivityTag**
> void AddInventoryStorageActivityTag (int? inventoryStorageActivityId, string inventoryStorageActivityTag)

Add new tags for an inventoryStorageActivity.

Adds a tag to an existing inventoryStorageActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryStorageActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to add a tag to
            var inventoryStorageActivityTag = inventoryStorageActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an inventoryStorageActivity.
                apiInstance.AddInventoryStorageActivityTag(inventoryStorageActivityId, inventoryStorageActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.AddInventoryStorageActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to add a tag to | 
 **inventoryStorageActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorystorageactivity"></a>
# **DeleteInventoryStorageActivity**
> void DeleteInventoryStorageActivity (int? inventoryStorageActivityId)

Delete an inventoryStorageActivity

Deletes the inventoryStorageActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryStorageActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to be deleted.

            try
            {
                // Delete an inventoryStorageActivity
                apiInstance.DeleteInventoryStorageActivity(inventoryStorageActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.DeleteInventoryStorageActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorystorageactivityfile"></a>
# **DeleteInventoryStorageActivityFile**
> void DeleteInventoryStorageActivityFile (int? inventoryStorageActivityId, int? fileId)

Delete a file for an inventoryStorageActivity.

Deletes an existing inventoryStorageActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryStorageActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an inventoryStorageActivity.
                apiInstance.DeleteInventoryStorageActivityFile(inventoryStorageActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.DeleteInventoryStorageActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorystorageactivitytag"></a>
# **DeleteInventoryStorageActivityTag**
> void DeleteInventoryStorageActivityTag (int? inventoryStorageActivityId, string inventoryStorageActivityTag)

Delete a tag for an inventoryStorageActivity.

Deletes an existing inventoryStorageActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryStorageActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to remove tag from
            var inventoryStorageActivityTag = inventoryStorageActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an inventoryStorageActivity.
                apiInstance.DeleteInventoryStorageActivityTag(inventoryStorageActivityId, inventoryStorageActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.DeleteInventoryStorageActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to remove tag from | 
 **inventoryStorageActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinventorystorageactivitybyid"></a>
# **GetDuplicateInventoryStorageActivityById**
> InventoryStorageActivity GetDuplicateInventoryStorageActivityById (int? inventoryStorageActivityId)

Get a duplicated an inventoryStorageActivity by id

Returns a duplicated inventoryStorageActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInventoryStorageActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to be duplicated.

            try
            {
                // Get a duplicated an inventoryStorageActivity by id
                InventoryStorageActivity result = apiInstance.GetDuplicateInventoryStorageActivityById(inventoryStorageActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.GetDuplicateInventoryStorageActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to be duplicated. | 

### Return type

[**InventoryStorageActivity**](InventoryStorageActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorystorageactivitybyfilter"></a>
# **GetInventoryStorageActivityByFilter**
> List<InventoryStorageActivity> GetInventoryStorageActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search inventoryStorageActivitys by filter

Returns the list of inventoryStorageActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryStorageActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search inventoryStorageActivitys by filter
                List&lt;InventoryStorageActivity&gt; result = apiInstance.GetInventoryStorageActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.GetInventoryStorageActivityByFilter: " + e.Message );
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

[**List<InventoryStorageActivity>**](InventoryStorageActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorystorageactivitybyid"></a>
# **GetInventoryStorageActivityById**
> InventoryStorageActivity GetInventoryStorageActivityById (int? inventoryStorageActivityId)

Get an inventoryStorageActivity by id

Returns the inventoryStorageActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryStorageActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to be returned.

            try
            {
                // Get an inventoryStorageActivity by id
                InventoryStorageActivity result = apiInstance.GetInventoryStorageActivityById(inventoryStorageActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.GetInventoryStorageActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to be returned. | 

### Return type

[**InventoryStorageActivity**](InventoryStorageActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorystorageactivityfiles"></a>
# **GetInventoryStorageActivityFiles**
> void GetInventoryStorageActivityFiles (int? inventoryStorageActivityId)

Get the files for an inventoryStorageActivity.

Get all existing inventoryStorageActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryStorageActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to get files for

            try
            {
                // Get the files for an inventoryStorageActivity.
                apiInstance.GetInventoryStorageActivityFiles(inventoryStorageActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.GetInventoryStorageActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorystorageactivitytags"></a>
# **GetInventoryStorageActivityTags**
> void GetInventoryStorageActivityTags (int? inventoryStorageActivityId)

Get the tags for an inventoryStorageActivity.

Get all existing inventoryStorageActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryStorageActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var inventoryStorageActivityId = 56;  // int? | Id of the inventoryStorageActivity to get tags for

            try
            {
                // Get the tags for an inventoryStorageActivity.
                apiInstance.GetInventoryStorageActivityTags(inventoryStorageActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.GetInventoryStorageActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryStorageActivityId** | **int?**| Id of the inventoryStorageActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventorystorageactivity"></a>
# **UpdateInventoryStorageActivity**
> void UpdateInventoryStorageActivity (InventoryStorageActivity body)

Update an inventoryStorageActivity

Updates an existing inventoryStorageActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateInventoryStorageActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryStorageActivityApi();
            var body = new InventoryStorageActivity(); // InventoryStorageActivity | InventoryStorageActivity to be updated.

            try
            {
                // Update an inventoryStorageActivity
                apiInstance.UpdateInventoryStorageActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryStorageActivityApi.UpdateInventoryStorageActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryStorageActivity**](InventoryStorageActivity.md)| InventoryStorageActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

