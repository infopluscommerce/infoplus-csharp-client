# Infoplus.Api.WarehouseDocumentTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWarehouseDocumentTypeAudit**](WarehouseDocumentTypeApi.md#addwarehousedocumenttypeaudit) | **PUT** /beta/warehouseDocumentType/{warehouseDocumentTypeId}/audit/{warehouseDocumentTypeAudit} | Add new audit for a warehouseDocumentType
[**AddWarehouseDocumentTypeFile**](WarehouseDocumentTypeApi.md#addwarehousedocumenttypefile) | **POST** /beta/warehouseDocumentType/{warehouseDocumentTypeId}/file/{fileName} | Attach a file to a warehouseDocumentType
[**AddWarehouseDocumentTypeTag**](WarehouseDocumentTypeApi.md#addwarehousedocumenttypetag) | **PUT** /beta/warehouseDocumentType/{warehouseDocumentTypeId}/tag/{warehouseDocumentTypeTag} | Add new tags for a warehouseDocumentType.
[**DeleteWarehouseDocumentTypeTag**](WarehouseDocumentTypeApi.md#deletewarehousedocumenttypetag) | **DELETE** /beta/warehouseDocumentType/{warehouseDocumentTypeId}/tag/{warehouseDocumentTypeTag} | Delete a tag for a warehouseDocumentType.
[**GetDuplicateWarehouseDocumentTypeById**](WarehouseDocumentTypeApi.md#getduplicatewarehousedocumenttypebyid) | **GET** /beta/warehouseDocumentType/duplicate/{warehouseDocumentTypeId} | Get a duplicated a warehouseDocumentType by id
[**GetWarehouseDocumentTypeByFilter**](WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyfilter) | **GET** /beta/warehouseDocumentType/search | Search warehouseDocumentTypes by filter
[**GetWarehouseDocumentTypeById**](WarehouseDocumentTypeApi.md#getwarehousedocumenttypebyid) | **GET** /beta/warehouseDocumentType/{warehouseDocumentTypeId} | Get a warehouseDocumentType by id
[**GetWarehouseDocumentTypeTags**](WarehouseDocumentTypeApi.md#getwarehousedocumenttypetags) | **GET** /beta/warehouseDocumentType/{warehouseDocumentTypeId}/tag | Get the tags for a warehouseDocumentType.


<a name="addwarehousedocumenttypeaudit"></a>
# **AddWarehouseDocumentTypeAudit**
> void AddWarehouseDocumentTypeAudit (int? warehouseDocumentTypeId, string warehouseDocumentTypeAudit)

Add new audit for a warehouseDocumentType

Adds an audit to an existing warehouseDocumentType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to add an audit to
            var warehouseDocumentTypeAudit = warehouseDocumentTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a warehouseDocumentType
                apiInstance.AddWarehouseDocumentTypeAudit(warehouseDocumentTypeId, warehouseDocumentTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.AddWarehouseDocumentTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to add an audit to | 
 **warehouseDocumentTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousedocumenttypefile"></a>
# **AddWarehouseDocumentTypeFile**
> void AddWarehouseDocumentTypeFile (int? warehouseDocumentTypeId, string fileName)

Attach a file to a warehouseDocumentType

Adds a file to an existing warehouseDocumentType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a warehouseDocumentType
                apiInstance.AddWarehouseDocumentTypeFile(warehouseDocumentTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.AddWarehouseDocumentTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousedocumenttypetag"></a>
# **AddWarehouseDocumentTypeTag**
> void AddWarehouseDocumentTypeTag (int? warehouseDocumentTypeId, string warehouseDocumentTypeTag)

Add new tags for a warehouseDocumentType.

Adds a tag to an existing warehouseDocumentType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseDocumentTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to add a tag to
            var warehouseDocumentTypeTag = warehouseDocumentTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a warehouseDocumentType.
                apiInstance.AddWarehouseDocumentTypeTag(warehouseDocumentTypeId, warehouseDocumentTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.AddWarehouseDocumentTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to add a tag to | 
 **warehouseDocumentTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehousedocumenttypetag"></a>
# **DeleteWarehouseDocumentTypeTag**
> void DeleteWarehouseDocumentTypeTag (int? warehouseDocumentTypeId, string warehouseDocumentTypeTag)

Delete a tag for a warehouseDocumentType.

Deletes an existing warehouseDocumentType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseDocumentTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to remove tag from
            var warehouseDocumentTypeTag = warehouseDocumentTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a warehouseDocumentType.
                apiInstance.DeleteWarehouseDocumentTypeTag(warehouseDocumentTypeId, warehouseDocumentTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.DeleteWarehouseDocumentTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to remove tag from | 
 **warehouseDocumentTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatewarehousedocumenttypebyid"></a>
# **GetDuplicateWarehouseDocumentTypeById**
> WarehouseDocumentType GetDuplicateWarehouseDocumentTypeById (int? warehouseDocumentTypeId)

Get a duplicated a warehouseDocumentType by id

Returns a duplicated warehouseDocumentType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWarehouseDocumentTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to be duplicated.

            try
            {
                // Get a duplicated a warehouseDocumentType by id
                WarehouseDocumentType result = apiInstance.GetDuplicateWarehouseDocumentTypeById(warehouseDocumentTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.GetDuplicateWarehouseDocumentTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to be duplicated. | 

### Return type

[**WarehouseDocumentType**](WarehouseDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumenttypebyfilter"></a>
# **GetWarehouseDocumentTypeByFilter**
> List<WarehouseDocumentType> GetWarehouseDocumentTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search warehouseDocumentTypes by filter

Returns the list of warehouseDocumentTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search warehouseDocumentTypes by filter
                List&lt;WarehouseDocumentType&gt; result = apiInstance.GetWarehouseDocumentTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.GetWarehouseDocumentTypeByFilter: " + e.Message );
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

[**List<WarehouseDocumentType>**](WarehouseDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumenttypebyid"></a>
# **GetWarehouseDocumentTypeById**
> WarehouseDocumentType GetWarehouseDocumentTypeById (int? warehouseDocumentTypeId)

Get a warehouseDocumentType by id

Returns the warehouseDocumentType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to be returned.

            try
            {
                // Get a warehouseDocumentType by id
                WarehouseDocumentType result = apiInstance.GetWarehouseDocumentTypeById(warehouseDocumentTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.GetWarehouseDocumentTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to be returned. | 

### Return type

[**WarehouseDocumentType**](WarehouseDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousedocumenttypetags"></a>
# **GetWarehouseDocumentTypeTags**
> void GetWarehouseDocumentTypeTags (int? warehouseDocumentTypeId)

Get the tags for a warehouseDocumentType.

Get all existing warehouseDocumentType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseDocumentTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseDocumentTypeApi();
            var warehouseDocumentTypeId = 56;  // int? | Id of the warehouseDocumentType to get tags for

            try
            {
                // Get the tags for a warehouseDocumentType.
                apiInstance.GetWarehouseDocumentTypeTags(warehouseDocumentTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseDocumentTypeApi.GetWarehouseDocumentTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseDocumentTypeId** | **int?**| Id of the warehouseDocumentType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

