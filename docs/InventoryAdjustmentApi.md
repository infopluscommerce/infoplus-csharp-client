# Infoplus.Api.InventoryAdjustmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventoryAdjustmentAudit**](InventoryAdjustmentApi.md#addinventoryadjustmentaudit) | **PUT** /beta/inventoryAdjustment/{inventoryAdjustmentId}/audit/{inventoryAdjustmentAudit} | Add new audit for an inventoryAdjustment
[**AddInventoryAdjustmentFile**](InventoryAdjustmentApi.md#addinventoryadjustmentfile) | **POST** /beta/inventoryAdjustment/{inventoryAdjustmentId}/file/{fileName} | Attach a file to an inventoryAdjustment
[**AddInventoryAdjustmentFileByURL**](InventoryAdjustmentApi.md#addinventoryadjustmentfilebyurl) | **POST** /beta/inventoryAdjustment/{inventoryAdjustmentId}/file | Attach a file to an inventoryAdjustment by URL.
[**AddInventoryAdjustmentTag**](InventoryAdjustmentApi.md#addinventoryadjustmenttag) | **PUT** /beta/inventoryAdjustment/{inventoryAdjustmentId}/tag/{inventoryAdjustmentTag} | Add new tags for an inventoryAdjustment.
[**DeleteInventoryAdjustmentFile**](InventoryAdjustmentApi.md#deleteinventoryadjustmentfile) | **DELETE** /beta/inventoryAdjustment/{inventoryAdjustmentId}/file/{fileId} | Delete a file for an inventoryAdjustment.
[**DeleteInventoryAdjustmentTag**](InventoryAdjustmentApi.md#deleteinventoryadjustmenttag) | **DELETE** /beta/inventoryAdjustment/{inventoryAdjustmentId}/tag/{inventoryAdjustmentTag} | Delete a tag for an inventoryAdjustment.
[**GetDuplicateInventoryAdjustmentById**](InventoryAdjustmentApi.md#getduplicateinventoryadjustmentbyid) | **GET** /beta/inventoryAdjustment/duplicate/{inventoryAdjustmentId} | Get a duplicated an inventoryAdjustment by id
[**GetInventoryAdjustmentByFilter**](InventoryAdjustmentApi.md#getinventoryadjustmentbyfilter) | **GET** /beta/inventoryAdjustment/search | Search inventoryAdjustments by filter
[**GetInventoryAdjustmentById**](InventoryAdjustmentApi.md#getinventoryadjustmentbyid) | **GET** /beta/inventoryAdjustment/{inventoryAdjustmentId} | Get an inventoryAdjustment by id
[**GetInventoryAdjustmentFiles**](InventoryAdjustmentApi.md#getinventoryadjustmentfiles) | **GET** /beta/inventoryAdjustment/{inventoryAdjustmentId}/file | Get the files for an inventoryAdjustment.
[**GetInventoryAdjustmentTags**](InventoryAdjustmentApi.md#getinventoryadjustmenttags) | **GET** /beta/inventoryAdjustment/{inventoryAdjustmentId}/tag | Get the tags for an inventoryAdjustment.
[**UpdateInventoryAdjustmentCustomFields**](InventoryAdjustmentApi.md#updateinventoryadjustmentcustomfields) | **PUT** /beta/inventoryAdjustment/customFields | Update an inventoryAdjustment custom fields


<a name="addinventoryadjustmentaudit"></a>
# **AddInventoryAdjustmentAudit**
> void AddInventoryAdjustmentAudit (int? inventoryAdjustmentId, string inventoryAdjustmentAudit)

Add new audit for an inventoryAdjustment

Adds an audit to an existing inventoryAdjustment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryAdjustmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to add an audit to
            var inventoryAdjustmentAudit = inventoryAdjustmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an inventoryAdjustment
                apiInstance.AddInventoryAdjustmentAudit(inventoryAdjustmentId, inventoryAdjustmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.AddInventoryAdjustmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to add an audit to | 
 **inventoryAdjustmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventoryadjustmentfile"></a>
# **AddInventoryAdjustmentFile**
> void AddInventoryAdjustmentFile (int? inventoryAdjustmentId, string fileName)

Attach a file to an inventoryAdjustment

Adds a file to an existing inventoryAdjustment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryAdjustmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an inventoryAdjustment
                apiInstance.AddInventoryAdjustmentFile(inventoryAdjustmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.AddInventoryAdjustmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventoryadjustmentfilebyurl"></a>
# **AddInventoryAdjustmentFileByURL**
> void AddInventoryAdjustmentFileByURL (RecordFile body, int? inventoryAdjustmentId)

Attach a file to an inventoryAdjustment by URL.

Adds a file to an existing inventoryAdjustment by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryAdjustmentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to add an file to

            try
            {
                // Attach a file to an inventoryAdjustment by URL.
                apiInstance.AddInventoryAdjustmentFileByURL(body, inventoryAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.AddInventoryAdjustmentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventoryadjustmenttag"></a>
# **AddInventoryAdjustmentTag**
> void AddInventoryAdjustmentTag (int? inventoryAdjustmentId, string inventoryAdjustmentTag)

Add new tags for an inventoryAdjustment.

Adds a tag to an existing inventoryAdjustment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryAdjustmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to add a tag to
            var inventoryAdjustmentTag = inventoryAdjustmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an inventoryAdjustment.
                apiInstance.AddInventoryAdjustmentTag(inventoryAdjustmentId, inventoryAdjustmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.AddInventoryAdjustmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to add a tag to | 
 **inventoryAdjustmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventoryadjustmentfile"></a>
# **DeleteInventoryAdjustmentFile**
> void DeleteInventoryAdjustmentFile (int? inventoryAdjustmentId, int? fileId)

Delete a file for an inventoryAdjustment.

Deletes an existing inventoryAdjustment file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryAdjustmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an inventoryAdjustment.
                apiInstance.DeleteInventoryAdjustmentFile(inventoryAdjustmentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.DeleteInventoryAdjustmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventoryadjustmenttag"></a>
# **DeleteInventoryAdjustmentTag**
> void DeleteInventoryAdjustmentTag (int? inventoryAdjustmentId, string inventoryAdjustmentTag)

Delete a tag for an inventoryAdjustment.

Deletes an existing inventoryAdjustment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryAdjustmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to remove tag from
            var inventoryAdjustmentTag = inventoryAdjustmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an inventoryAdjustment.
                apiInstance.DeleteInventoryAdjustmentTag(inventoryAdjustmentId, inventoryAdjustmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.DeleteInventoryAdjustmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to remove tag from | 
 **inventoryAdjustmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinventoryadjustmentbyid"></a>
# **GetDuplicateInventoryAdjustmentById**
> InventoryAdjustment GetDuplicateInventoryAdjustmentById (int? inventoryAdjustmentId)

Get a duplicated an inventoryAdjustment by id

Returns a duplicated inventoryAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInventoryAdjustmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to be duplicated.

            try
            {
                // Get a duplicated an inventoryAdjustment by id
                InventoryAdjustment result = apiInstance.GetDuplicateInventoryAdjustmentById(inventoryAdjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetDuplicateInventoryAdjustmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to be duplicated. | 

### Return type

[**InventoryAdjustment**](InventoryAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryadjustmentbyfilter"></a>
# **GetInventoryAdjustmentByFilter**
> List<InventoryAdjustment> GetInventoryAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search inventoryAdjustments by filter

Returns the list of inventoryAdjustments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryAdjustmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search inventoryAdjustments by filter
                List&lt;InventoryAdjustment&gt; result = apiInstance.GetInventoryAdjustmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetInventoryAdjustmentByFilter: " + e.Message );
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

[**List<InventoryAdjustment>**](InventoryAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryadjustmentbyid"></a>
# **GetInventoryAdjustmentById**
> InventoryAdjustment GetInventoryAdjustmentById (int? inventoryAdjustmentId)

Get an inventoryAdjustment by id

Returns the inventoryAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryAdjustmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to be returned.

            try
            {
                // Get an inventoryAdjustment by id
                InventoryAdjustment result = apiInstance.GetInventoryAdjustmentById(inventoryAdjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetInventoryAdjustmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to be returned. | 

### Return type

[**InventoryAdjustment**](InventoryAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryadjustmentfiles"></a>
# **GetInventoryAdjustmentFiles**
> void GetInventoryAdjustmentFiles (int? inventoryAdjustmentId)

Get the files for an inventoryAdjustment.

Get all existing inventoryAdjustment files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryAdjustmentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to get files for

            try
            {
                // Get the files for an inventoryAdjustment.
                apiInstance.GetInventoryAdjustmentFiles(inventoryAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetInventoryAdjustmentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventoryadjustmenttags"></a>
# **GetInventoryAdjustmentTags**
> void GetInventoryAdjustmentTags (int? inventoryAdjustmentId)

Get the tags for an inventoryAdjustment.

Get all existing inventoryAdjustment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryAdjustmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var inventoryAdjustmentId = 56;  // int? | Id of the inventoryAdjustment to get tags for

            try
            {
                // Get the tags for an inventoryAdjustment.
                apiInstance.GetInventoryAdjustmentTags(inventoryAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.GetInventoryAdjustmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryAdjustmentId** | **int?**| Id of the inventoryAdjustment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventoryadjustmentcustomfields"></a>
# **UpdateInventoryAdjustmentCustomFields**
> void UpdateInventoryAdjustmentCustomFields (InventoryAdjustment body)

Update an inventoryAdjustment custom fields

Updates an existing inventoryAdjustment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateInventoryAdjustmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryAdjustmentApi();
            var body = new InventoryAdjustment(); // InventoryAdjustment | InventoryAdjustment to be updated.

            try
            {
                // Update an inventoryAdjustment custom fields
                apiInstance.UpdateInventoryAdjustmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryAdjustmentApi.UpdateInventoryAdjustmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryAdjustment**](InventoryAdjustment.md)| InventoryAdjustment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

