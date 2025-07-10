# Infoplus.Api.InventorySnapshotApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventorySnapshotAudit**](InventorySnapshotApi.md#addinventorysnapshotaudit) | **PUT** /beta/inventorySnapshot/{inventorySnapshotId}/audit/{inventorySnapshotAudit} | Add new audit for an inventorySnapshot
[**AddInventorySnapshotFile**](InventorySnapshotApi.md#addinventorysnapshotfile) | **POST** /beta/inventorySnapshot/{inventorySnapshotId}/file/{fileName} | Attach a file to an inventorySnapshot
[**AddInventorySnapshotFileByURL**](InventorySnapshotApi.md#addinventorysnapshotfilebyurl) | **POST** /beta/inventorySnapshot/{inventorySnapshotId}/file | Attach a file to an inventorySnapshot by URL.
[**AddInventorySnapshotTag**](InventorySnapshotApi.md#addinventorysnapshottag) | **PUT** /beta/inventorySnapshot/{inventorySnapshotId}/tag/{inventorySnapshotTag} | Add new tags for an inventorySnapshot.
[**DeleteInventorySnapshotFile**](InventorySnapshotApi.md#deleteinventorysnapshotfile) | **DELETE** /beta/inventorySnapshot/{inventorySnapshotId}/file/{fileId} | Delete a file for an inventorySnapshot.
[**DeleteInventorySnapshotTag**](InventorySnapshotApi.md#deleteinventorysnapshottag) | **DELETE** /beta/inventorySnapshot/{inventorySnapshotId}/tag/{inventorySnapshotTag} | Delete a tag for an inventorySnapshot.
[**GetDuplicateInventorySnapshotById**](InventorySnapshotApi.md#getduplicateinventorysnapshotbyid) | **GET** /beta/inventorySnapshot/duplicate/{inventorySnapshotId} | Get a duplicated an inventorySnapshot by id
[**GetInventorySnapshotByFilter**](InventorySnapshotApi.md#getinventorysnapshotbyfilter) | **GET** /beta/inventorySnapshot/search | Search inventorySnapshots by filter
[**GetInventorySnapshotById**](InventorySnapshotApi.md#getinventorysnapshotbyid) | **GET** /beta/inventorySnapshot/{inventorySnapshotId} | Get an inventorySnapshot by id
[**GetInventorySnapshotFiles**](InventorySnapshotApi.md#getinventorysnapshotfiles) | **GET** /beta/inventorySnapshot/{inventorySnapshotId}/file | Get the files for an inventorySnapshot.
[**GetInventorySnapshotTags**](InventorySnapshotApi.md#getinventorysnapshottags) | **GET** /beta/inventorySnapshot/{inventorySnapshotId}/tag | Get the tags for an inventorySnapshot.


<a name="addinventorysnapshotaudit"></a>
# **AddInventorySnapshotAudit**
> void AddInventorySnapshotAudit (int? inventorySnapshotId, string inventorySnapshotAudit)

Add new audit for an inventorySnapshot

Adds an audit to an existing inventorySnapshot.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventorySnapshotAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to add an audit to
            var inventorySnapshotAudit = inventorySnapshotAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an inventorySnapshot
                apiInstance.AddInventorySnapshotAudit(inventorySnapshotId, inventorySnapshotAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.AddInventorySnapshotAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to add an audit to | 
 **inventorySnapshotAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorysnapshotfile"></a>
# **AddInventorySnapshotFile**
> void AddInventorySnapshotFile (int? inventorySnapshotId, string fileName)

Attach a file to an inventorySnapshot

Adds a file to an existing inventorySnapshot.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventorySnapshotFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an inventorySnapshot
                apiInstance.AddInventorySnapshotFile(inventorySnapshotId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.AddInventorySnapshotFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorysnapshotfilebyurl"></a>
# **AddInventorySnapshotFileByURL**
> void AddInventorySnapshotFileByURL (RecordFile body, int? inventorySnapshotId)

Attach a file to an inventorySnapshot by URL.

Adds a file to an existing inventorySnapshot by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventorySnapshotFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to add an file to

            try
            {
                // Attach a file to an inventorySnapshot by URL.
                apiInstance.AddInventorySnapshotFileByURL(body, inventorySnapshotId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.AddInventorySnapshotFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorysnapshottag"></a>
# **AddInventorySnapshotTag**
> void AddInventorySnapshotTag (int? inventorySnapshotId, string inventorySnapshotTag)

Add new tags for an inventorySnapshot.

Adds a tag to an existing inventorySnapshot.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventorySnapshotTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to add a tag to
            var inventorySnapshotTag = inventorySnapshotTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an inventorySnapshot.
                apiInstance.AddInventorySnapshotTag(inventorySnapshotId, inventorySnapshotTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.AddInventorySnapshotTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to add a tag to | 
 **inventorySnapshotTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorysnapshotfile"></a>
# **DeleteInventorySnapshotFile**
> void DeleteInventorySnapshotFile (int? inventorySnapshotId, int? fileId)

Delete a file for an inventorySnapshot.

Deletes an existing inventorySnapshot file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventorySnapshotFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an inventorySnapshot.
                apiInstance.DeleteInventorySnapshotFile(inventorySnapshotId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.DeleteInventorySnapshotFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorysnapshottag"></a>
# **DeleteInventorySnapshotTag**
> void DeleteInventorySnapshotTag (int? inventorySnapshotId, string inventorySnapshotTag)

Delete a tag for an inventorySnapshot.

Deletes an existing inventorySnapshot tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventorySnapshotTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to remove tag from
            var inventorySnapshotTag = inventorySnapshotTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an inventorySnapshot.
                apiInstance.DeleteInventorySnapshotTag(inventorySnapshotId, inventorySnapshotTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.DeleteInventorySnapshotTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to remove tag from | 
 **inventorySnapshotTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinventorysnapshotbyid"></a>
# **GetDuplicateInventorySnapshotById**
> InventorySnapshot GetDuplicateInventorySnapshotById (int? inventorySnapshotId)

Get a duplicated an inventorySnapshot by id

Returns a duplicated inventorySnapshot identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInventorySnapshotByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to be duplicated.

            try
            {
                // Get a duplicated an inventorySnapshot by id
                InventorySnapshot result = apiInstance.GetDuplicateInventorySnapshotById(inventorySnapshotId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.GetDuplicateInventorySnapshotById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to be duplicated. | 

### Return type

[**InventorySnapshot**](InventorySnapshot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorysnapshotbyfilter"></a>
# **GetInventorySnapshotByFilter**
> List<InventorySnapshot> GetInventorySnapshotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search inventorySnapshots by filter

Returns the list of inventorySnapshots that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventorySnapshotByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search inventorySnapshots by filter
                List&lt;InventorySnapshot&gt; result = apiInstance.GetInventorySnapshotByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.GetInventorySnapshotByFilter: " + e.Message );
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

[**List<InventorySnapshot>**](InventorySnapshot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorysnapshotbyid"></a>
# **GetInventorySnapshotById**
> InventorySnapshot GetInventorySnapshotById (int? inventorySnapshotId)

Get an inventorySnapshot by id

Returns the inventorySnapshot identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventorySnapshotByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to be returned.

            try
            {
                // Get an inventorySnapshot by id
                InventorySnapshot result = apiInstance.GetInventorySnapshotById(inventorySnapshotId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.GetInventorySnapshotById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to be returned. | 

### Return type

[**InventorySnapshot**](InventorySnapshot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorysnapshotfiles"></a>
# **GetInventorySnapshotFiles**
> void GetInventorySnapshotFiles (int? inventorySnapshotId)

Get the files for an inventorySnapshot.

Get all existing inventorySnapshot files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventorySnapshotFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to get files for

            try
            {
                // Get the files for an inventorySnapshot.
                apiInstance.GetInventorySnapshotFiles(inventorySnapshotId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.GetInventorySnapshotFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorysnapshottags"></a>
# **GetInventorySnapshotTags**
> void GetInventorySnapshotTags (int? inventorySnapshotId)

Get the tags for an inventorySnapshot.

Get all existing inventorySnapshot tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventorySnapshotTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventorySnapshotApi();
            var inventorySnapshotId = 56;  // int? | Id of the inventorySnapshot to get tags for

            try
            {
                // Get the tags for an inventorySnapshot.
                apiInstance.GetInventorySnapshotTags(inventorySnapshotId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventorySnapshotApi.GetInventorySnapshotTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventorySnapshotId** | **int?**| Id of the inventorySnapshot to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

