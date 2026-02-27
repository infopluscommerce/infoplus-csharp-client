# Infoplus.Api.WarehouseInventoryApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWarehouseInventoryAudit**](WarehouseInventoryApi.md#addwarehouseinventoryaudit) | **PUT** /beta/warehouseInventory/{warehouseInventoryId}/audit/{warehouseInventoryAudit} | Add new audit for a warehouseInventory
[**AddWarehouseInventoryFile**](WarehouseInventoryApi.md#addwarehouseinventoryfile) | **POST** /beta/warehouseInventory/{warehouseInventoryId}/file/{fileName} | Attach a file to a warehouseInventory
[**AddWarehouseInventoryFileByURL**](WarehouseInventoryApi.md#addwarehouseinventoryfilebyurl) | **POST** /beta/warehouseInventory/{warehouseInventoryId}/file | Attach a file to a warehouseInventory by URL.
[**AddWarehouseInventoryTag**](WarehouseInventoryApi.md#addwarehouseinventorytag) | **PUT** /beta/warehouseInventory/{warehouseInventoryId}/tag/{warehouseInventoryTag} | Add new tags for a warehouseInventory.
[**DeleteWarehouseInventoryFile**](WarehouseInventoryApi.md#deletewarehouseinventoryfile) | **DELETE** /beta/warehouseInventory/{warehouseInventoryId}/file/{fileId} | Delete a file for a warehouseInventory.
[**DeleteWarehouseInventoryTag**](WarehouseInventoryApi.md#deletewarehouseinventorytag) | **DELETE** /beta/warehouseInventory/{warehouseInventoryId}/tag/{warehouseInventoryTag} | Delete a tag for a warehouseInventory.
[**GetDuplicateWarehouseInventoryById**](WarehouseInventoryApi.md#getduplicatewarehouseinventorybyid) | **GET** /beta/warehouseInventory/duplicate/{warehouseInventoryId} | Get a duplicated a warehouseInventory by id
[**GetWarehouseInventoryByFilter**](WarehouseInventoryApi.md#getwarehouseinventorybyfilter) | **GET** /beta/warehouseInventory/search | Search warehouseInventorys by filter
[**GetWarehouseInventoryById**](WarehouseInventoryApi.md#getwarehouseinventorybyid) | **GET** /beta/warehouseInventory/{warehouseInventoryId} | Get a warehouseInventory by id
[**GetWarehouseInventoryFiles**](WarehouseInventoryApi.md#getwarehouseinventoryfiles) | **GET** /beta/warehouseInventory/{warehouseInventoryId}/file | Get the files for a warehouseInventory.
[**GetWarehouseInventoryTags**](WarehouseInventoryApi.md#getwarehouseinventorytags) | **GET** /beta/warehouseInventory/{warehouseInventoryId}/tag | Get the tags for a warehouseInventory.


<a name="addwarehouseinventoryaudit"></a>
# **AddWarehouseInventoryAudit**
> void AddWarehouseInventoryAudit (int? warehouseInventoryId, string warehouseInventoryAudit)

Add new audit for a warehouseInventory

Adds an audit to an existing warehouseInventory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseInventoryAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to add an audit to
            var warehouseInventoryAudit = warehouseInventoryAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a warehouseInventory
                apiInstance.AddWarehouseInventoryAudit(warehouseInventoryId, warehouseInventoryAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.AddWarehouseInventoryAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to add an audit to | 
 **warehouseInventoryAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehouseinventoryfile"></a>
# **AddWarehouseInventoryFile**
> void AddWarehouseInventoryFile (int? warehouseInventoryId, string fileName)

Attach a file to a warehouseInventory

Adds a file to an existing warehouseInventory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseInventoryFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a warehouseInventory
                apiInstance.AddWarehouseInventoryFile(warehouseInventoryId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.AddWarehouseInventoryFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehouseinventoryfilebyurl"></a>
# **AddWarehouseInventoryFileByURL**
> void AddWarehouseInventoryFileByURL (RecordFile body, int? warehouseInventoryId)

Attach a file to a warehouseInventory by URL.

Adds a file to an existing warehouseInventory by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseInventoryFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to add an file to

            try
            {
                // Attach a file to a warehouseInventory by URL.
                apiInstance.AddWarehouseInventoryFileByURL(body, warehouseInventoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.AddWarehouseInventoryFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehouseinventorytag"></a>
# **AddWarehouseInventoryTag**
> void AddWarehouseInventoryTag (int? warehouseInventoryId, string warehouseInventoryTag)

Add new tags for a warehouseInventory.

Adds a tag to an existing warehouseInventory.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseInventoryTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to add a tag to
            var warehouseInventoryTag = warehouseInventoryTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a warehouseInventory.
                apiInstance.AddWarehouseInventoryTag(warehouseInventoryId, warehouseInventoryTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.AddWarehouseInventoryTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to add a tag to | 
 **warehouseInventoryTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehouseinventoryfile"></a>
# **DeleteWarehouseInventoryFile**
> void DeleteWarehouseInventoryFile (int? warehouseInventoryId, int? fileId)

Delete a file for a warehouseInventory.

Deletes an existing warehouseInventory file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseInventoryFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a warehouseInventory.
                apiInstance.DeleteWarehouseInventoryFile(warehouseInventoryId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.DeleteWarehouseInventoryFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehouseinventorytag"></a>
# **DeleteWarehouseInventoryTag**
> void DeleteWarehouseInventoryTag (int? warehouseInventoryId, string warehouseInventoryTag)

Delete a tag for a warehouseInventory.

Deletes an existing warehouseInventory tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseInventoryTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to remove tag from
            var warehouseInventoryTag = warehouseInventoryTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a warehouseInventory.
                apiInstance.DeleteWarehouseInventoryTag(warehouseInventoryId, warehouseInventoryTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.DeleteWarehouseInventoryTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to remove tag from | 
 **warehouseInventoryTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatewarehouseinventorybyid"></a>
# **GetDuplicateWarehouseInventoryById**
> WarehouseInventory GetDuplicateWarehouseInventoryById (int? warehouseInventoryId)

Get a duplicated a warehouseInventory by id

Returns a duplicated warehouseInventory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWarehouseInventoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to be duplicated.

            try
            {
                // Get a duplicated a warehouseInventory by id
                WarehouseInventory result = apiInstance.GetDuplicateWarehouseInventoryById(warehouseInventoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.GetDuplicateWarehouseInventoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to be duplicated. | 

### Return type

[**WarehouseInventory**](WarehouseInventory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseinventorybyfilter"></a>
# **GetWarehouseInventoryByFilter**
> List<WarehouseInventory> GetWarehouseInventoryByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search warehouseInventorys by filter

Returns the list of warehouseInventorys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseInventoryByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search warehouseInventorys by filter
                List&lt;WarehouseInventory&gt; result = apiInstance.GetWarehouseInventoryByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.GetWarehouseInventoryByFilter: " + e.Message );
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

[**List<WarehouseInventory>**](WarehouseInventory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseinventorybyid"></a>
# **GetWarehouseInventoryById**
> WarehouseInventory GetWarehouseInventoryById (int? warehouseInventoryId)

Get a warehouseInventory by id

Returns the warehouseInventory identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseInventoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to be returned.

            try
            {
                // Get a warehouseInventory by id
                WarehouseInventory result = apiInstance.GetWarehouseInventoryById(warehouseInventoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.GetWarehouseInventoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to be returned. | 

### Return type

[**WarehouseInventory**](WarehouseInventory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseinventoryfiles"></a>
# **GetWarehouseInventoryFiles**
> void GetWarehouseInventoryFiles (int? warehouseInventoryId)

Get the files for a warehouseInventory.

Get all existing warehouseInventory files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseInventoryFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to get files for

            try
            {
                // Get the files for a warehouseInventory.
                apiInstance.GetWarehouseInventoryFiles(warehouseInventoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.GetWarehouseInventoryFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseinventorytags"></a>
# **GetWarehouseInventoryTags**
> void GetWarehouseInventoryTags (int? warehouseInventoryId)

Get the tags for a warehouseInventory.

Get all existing warehouseInventory tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseInventoryTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseInventoryApi();
            var warehouseInventoryId = 56;  // int? | Id of the warehouseInventory to get tags for

            try
            {
                // Get the tags for a warehouseInventory.
                apiInstance.GetWarehouseInventoryTags(warehouseInventoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseInventoryApi.GetWarehouseInventoryTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseInventoryId** | **int?**| Id of the warehouseInventory to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

