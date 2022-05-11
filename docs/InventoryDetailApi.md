# Infoplus.Api.InventoryDetailApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventoryDetailAudit**](InventoryDetailApi.md#addinventorydetailaudit) | **PUT** /v3.0/inventoryDetail/{inventoryDetailId}/audit/{inventoryDetailAudit} | Add new audit for an inventoryDetail
[**AddInventoryDetailFile**](InventoryDetailApi.md#addinventorydetailfile) | **POST** /v3.0/inventoryDetail/{inventoryDetailId}/file/{fileName} | Attach a file to an inventoryDetail
[**AddInventoryDetailFileByURL**](InventoryDetailApi.md#addinventorydetailfilebyurl) | **POST** /v3.0/inventoryDetail/{inventoryDetailId}/file | Attach a file to an inventoryDetail by URL.
[**AddInventoryDetailTag**](InventoryDetailApi.md#addinventorydetailtag) | **PUT** /v3.0/inventoryDetail/{inventoryDetailId}/tag/{inventoryDetailTag} | Add new tags for an inventoryDetail.
[**DeleteInventoryDetailFile**](InventoryDetailApi.md#deleteinventorydetailfile) | **DELETE** /v3.0/inventoryDetail/{inventoryDetailId}/file/{fileId} | Delete a file for an inventoryDetail.
[**DeleteInventoryDetailTag**](InventoryDetailApi.md#deleteinventorydetailtag) | **DELETE** /v3.0/inventoryDetail/{inventoryDetailId}/tag/{inventoryDetailTag} | Delete a tag for an inventoryDetail.
[**GetDuplicateInventoryDetailById**](InventoryDetailApi.md#getduplicateinventorydetailbyid) | **GET** /v3.0/inventoryDetail/duplicate/{inventoryDetailId} | Get a duplicated an inventoryDetail by id
[**GetInventoryDetailByFilter**](InventoryDetailApi.md#getinventorydetailbyfilter) | **GET** /v3.0/inventoryDetail/search | Search inventoryDetails by filter
[**GetInventoryDetailById**](InventoryDetailApi.md#getinventorydetailbyid) | **GET** /v3.0/inventoryDetail/{inventoryDetailId} | Get an inventoryDetail by id
[**GetInventoryDetailFiles**](InventoryDetailApi.md#getinventorydetailfiles) | **GET** /v3.0/inventoryDetail/{inventoryDetailId}/file | Get the files for an inventoryDetail.
[**GetInventoryDetailTags**](InventoryDetailApi.md#getinventorydetailtags) | **GET** /v3.0/inventoryDetail/{inventoryDetailId}/tag | Get the tags for an inventoryDetail.
[**UpdateInventoryDetailCustomFields**](InventoryDetailApi.md#updateinventorydetailcustomfields) | **PUT** /v3.0/inventoryDetail/customFields | Update an inventoryDetail custom fields


<a name="addinventorydetailaudit"></a>
# **AddInventoryDetailAudit**
> void AddInventoryDetailAudit (int? inventoryDetailId, string inventoryDetailAudit)

Add new audit for an inventoryDetail

Adds an audit to an existing inventoryDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryDetailAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to add an audit to
            var inventoryDetailAudit = inventoryDetailAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an inventoryDetail
                apiInstance.AddInventoryDetailAudit(inventoryDetailId, inventoryDetailAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.AddInventoryDetailAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to add an audit to | 
 **inventoryDetailAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorydetailfile"></a>
# **AddInventoryDetailFile**
> void AddInventoryDetailFile (int? inventoryDetailId, string fileName)

Attach a file to an inventoryDetail

Adds a file to an existing inventoryDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an inventoryDetail
                apiInstance.AddInventoryDetailFile(inventoryDetailId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.AddInventoryDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorydetailfilebyurl"></a>
# **AddInventoryDetailFileByURL**
> void AddInventoryDetailFileByURL (RecordFile body, int? inventoryDetailId)

Attach a file to an inventoryDetail by URL.

Adds a file to an existing inventoryDetail by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryDetailFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to add an file to

            try
            {
                // Attach a file to an inventoryDetail by URL.
                apiInstance.AddInventoryDetailFileByURL(body, inventoryDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.AddInventoryDetailFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinventorydetailtag"></a>
# **AddInventoryDetailTag**
> void AddInventoryDetailTag (int? inventoryDetailId, string inventoryDetailTag)

Add new tags for an inventoryDetail.

Adds a tag to an existing inventoryDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInventoryDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to add a tag to
            var inventoryDetailTag = inventoryDetailTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an inventoryDetail.
                apiInstance.AddInventoryDetailTag(inventoryDetailId, inventoryDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.AddInventoryDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to add a tag to | 
 **inventoryDetailTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorydetailfile"></a>
# **DeleteInventoryDetailFile**
> void DeleteInventoryDetailFile (int? inventoryDetailId, int? fileId)

Delete a file for an inventoryDetail.

Deletes an existing inventoryDetail file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an inventoryDetail.
                apiInstance.DeleteInventoryDetailFile(inventoryDetailId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.DeleteInventoryDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinventorydetailtag"></a>
# **DeleteInventoryDetailTag**
> void DeleteInventoryDetailTag (int? inventoryDetailId, string inventoryDetailTag)

Delete a tag for an inventoryDetail.

Deletes an existing inventoryDetail tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInventoryDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to remove tag from
            var inventoryDetailTag = inventoryDetailTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an inventoryDetail.
                apiInstance.DeleteInventoryDetailTag(inventoryDetailId, inventoryDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.DeleteInventoryDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to remove tag from | 
 **inventoryDetailTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinventorydetailbyid"></a>
# **GetDuplicateInventoryDetailById**
> InventoryDetail GetDuplicateInventoryDetailById (int? inventoryDetailId)

Get a duplicated an inventoryDetail by id

Returns a duplicated inventoryDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInventoryDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to be duplicated.

            try
            {
                // Get a duplicated an inventoryDetail by id
                InventoryDetail result = apiInstance.GetDuplicateInventoryDetailById(inventoryDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetDuplicateInventoryDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to be duplicated. | 

### Return type

[**InventoryDetail**](InventoryDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorydetailbyfilter"></a>
# **GetInventoryDetailByFilter**
> List<InventoryDetail> GetInventoryDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search inventoryDetails by filter

Returns the list of inventoryDetails that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryDetailByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search inventoryDetails by filter
                List&lt;InventoryDetail&gt; result = apiInstance.GetInventoryDetailByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetInventoryDetailByFilter: " + e.Message );
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

[**List<InventoryDetail>**](InventoryDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorydetailbyid"></a>
# **GetInventoryDetailById**
> InventoryDetail GetInventoryDetailById (int? inventoryDetailId)

Get an inventoryDetail by id

Returns the inventoryDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to be returned.

            try
            {
                // Get an inventoryDetail by id
                InventoryDetail result = apiInstance.GetInventoryDetailById(inventoryDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetInventoryDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to be returned. | 

### Return type

[**InventoryDetail**](InventoryDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorydetailfiles"></a>
# **GetInventoryDetailFiles**
> void GetInventoryDetailFiles (int? inventoryDetailId)

Get the files for an inventoryDetail.

Get all existing inventoryDetail files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryDetailFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to get files for

            try
            {
                // Get the files for an inventoryDetail.
                apiInstance.GetInventoryDetailFiles(inventoryDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetInventoryDetailFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventorydetailtags"></a>
# **GetInventoryDetailTags**
> void GetInventoryDetailTags (int? inventoryDetailId)

Get the tags for an inventoryDetail.

Get all existing inventoryDetail tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInventoryDetailTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var inventoryDetailId = 56;  // int? | Id of the inventoryDetail to get tags for

            try
            {
                // Get the tags for an inventoryDetail.
                apiInstance.GetInventoryDetailTags(inventoryDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.GetInventoryDetailTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryDetailId** | **int?**| Id of the inventoryDetail to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinventorydetailcustomfields"></a>
# **UpdateInventoryDetailCustomFields**
> void UpdateInventoryDetailCustomFields (InventoryDetail body)

Update an inventoryDetail custom fields

Updates an existing inventoryDetail custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateInventoryDetailCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InventoryDetailApi();
            var body = new InventoryDetail(); // InventoryDetail | InventoryDetail to be updated.

            try
            {
                // Update an inventoryDetail custom fields
                apiInstance.UpdateInventoryDetailCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryDetailApi.UpdateInventoryDetailCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryDetail**](InventoryDetail.md)| InventoryDetail to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

