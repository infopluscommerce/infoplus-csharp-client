# Infoplus.Api.WarehouseApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWarehouseAudit**](WarehouseApi.md#addwarehouseaudit) | **PUT** /beta/warehouse/{warehouseId}/audit/{warehouseAudit} | Add new audit for a warehouse
[**AddWarehouseFile**](WarehouseApi.md#addwarehousefile) | **POST** /beta/warehouse/{warehouseId}/file/{fileName} | Attach a file to a warehouse
[**AddWarehouseFileByURL**](WarehouseApi.md#addwarehousefilebyurl) | **POST** /beta/warehouse/{warehouseId}/file | Attach a file to a warehouse by URL.
[**AddWarehouseTag**](WarehouseApi.md#addwarehousetag) | **PUT** /beta/warehouse/{warehouseId}/tag/{warehouseTag} | Add new tags for a warehouse.
[**DeleteWarehouseFile**](WarehouseApi.md#deletewarehousefile) | **DELETE** /beta/warehouse/{warehouseId}/file/{fileId} | Delete a file for a warehouse.
[**DeleteWarehouseTag**](WarehouseApi.md#deletewarehousetag) | **DELETE** /beta/warehouse/{warehouseId}/tag/{warehouseTag} | Delete a tag for a warehouse.
[**GetDuplicateWarehouseById**](WarehouseApi.md#getduplicatewarehousebyid) | **GET** /beta/warehouse/duplicate/{warehouseId} | Get a duplicated a warehouse by id
[**GetWarehouseByFilter**](WarehouseApi.md#getwarehousebyfilter) | **GET** /beta/warehouse/search | Search warehouses by filter
[**GetWarehouseById**](WarehouseApi.md#getwarehousebyid) | **GET** /beta/warehouse/{warehouseId} | Get a warehouse by id
[**GetWarehouseFiles**](WarehouseApi.md#getwarehousefiles) | **GET** /beta/warehouse/{warehouseId}/file | Get the files for a warehouse.
[**GetWarehouseTags**](WarehouseApi.md#getwarehousetags) | **GET** /beta/warehouse/{warehouseId}/tag | Get the tags for a warehouse.
[**UpdateWarehouse**](WarehouseApi.md#updatewarehouse) | **PUT** /beta/warehouse | Update a warehouse
[**UpdateWarehouseCustomFields**](WarehouseApi.md#updatewarehousecustomfields) | **PUT** /beta/warehouse/customFields | Update a warehouse custom fields


<a name="addwarehouseaudit"></a>
# **AddWarehouseAudit**
> void AddWarehouseAudit (int? warehouseId, string warehouseAudit)

Add new audit for a warehouse

Adds an audit to an existing warehouse.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to add an audit to
            var warehouseAudit = warehouseAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a warehouse
                apiInstance.AddWarehouseAudit(warehouseId, warehouseAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.AddWarehouseAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to add an audit to | 
 **warehouseAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousefile"></a>
# **AddWarehouseFile**
> void AddWarehouseFile (int? warehouseId, string fileName)

Attach a file to a warehouse

Adds a file to an existing warehouse.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a warehouse
                apiInstance.AddWarehouseFile(warehouseId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.AddWarehouseFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousefilebyurl"></a>
# **AddWarehouseFileByURL**
> void AddWarehouseFileByURL (RecordFile body, int? warehouseId)

Attach a file to a warehouse by URL.

Adds a file to an existing warehouse by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var warehouseId = 56;  // int? | Id of the warehouse to add an file to

            try
            {
                // Attach a file to a warehouse by URL.
                apiInstance.AddWarehouseFileByURL(body, warehouseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.AddWarehouseFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **warehouseId** | **int?**| Id of the warehouse to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehousetag"></a>
# **AddWarehouseTag**
> void AddWarehouseTag (int? warehouseId, string warehouseTag)

Add new tags for a warehouse.

Adds a tag to an existing warehouse.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to add a tag to
            var warehouseTag = warehouseTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a warehouse.
                apiInstance.AddWarehouseTag(warehouseId, warehouseTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.AddWarehouseTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to add a tag to | 
 **warehouseTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehousefile"></a>
# **DeleteWarehouseFile**
> void DeleteWarehouseFile (int? warehouseId, int? fileId)

Delete a file for a warehouse.

Deletes an existing warehouse file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a warehouse.
                apiInstance.DeleteWarehouseFile(warehouseId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.DeleteWarehouseFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehousetag"></a>
# **DeleteWarehouseTag**
> void DeleteWarehouseTag (int? warehouseId, string warehouseTag)

Delete a tag for a warehouse.

Deletes an existing warehouse tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to remove tag from
            var warehouseTag = warehouseTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a warehouse.
                apiInstance.DeleteWarehouseTag(warehouseId, warehouseTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.DeleteWarehouseTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to remove tag from | 
 **warehouseTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatewarehousebyid"></a>
# **GetDuplicateWarehouseById**
> Warehouse GetDuplicateWarehouseById (int? warehouseId)

Get a duplicated a warehouse by id

Returns a duplicated warehouse identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWarehouseByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to be duplicated.

            try
            {
                // Get a duplicated a warehouse by id
                Warehouse result = apiInstance.GetDuplicateWarehouseById(warehouseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.GetDuplicateWarehouseById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to be duplicated. | 

### Return type

[**Warehouse**](Warehouse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousebyfilter"></a>
# **GetWarehouseByFilter**
> List<Warehouse> GetWarehouseByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search warehouses by filter

Returns the list of warehouses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search warehouses by filter
                List&lt;Warehouse&gt; result = apiInstance.GetWarehouseByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.GetWarehouseByFilter: " + e.Message );
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

[**List<Warehouse>**](Warehouse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousebyid"></a>
# **GetWarehouseById**
> Warehouse GetWarehouseById (int? warehouseId)

Get a warehouse by id

Returns the warehouse identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to be returned.

            try
            {
                // Get a warehouse by id
                Warehouse result = apiInstance.GetWarehouseById(warehouseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.GetWarehouseById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to be returned. | 

### Return type

[**Warehouse**](Warehouse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousefiles"></a>
# **GetWarehouseFiles**
> void GetWarehouseFiles (int? warehouseId)

Get the files for a warehouse.

Get all existing warehouse files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to get files for

            try
            {
                // Get the files for a warehouse.
                apiInstance.GetWarehouseFiles(warehouseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.GetWarehouseFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehousetags"></a>
# **GetWarehouseTags**
> void GetWarehouseTags (int? warehouseId)

Get the tags for a warehouse.

Get all existing warehouse tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var warehouseId = 56;  // int? | Id of the warehouse to get tags for

            try
            {
                // Get the tags for a warehouse.
                apiInstance.GetWarehouseTags(warehouseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.GetWarehouseTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **int?**| Id of the warehouse to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewarehouse"></a>
# **UpdateWarehouse**
> void UpdateWarehouse (Warehouse body)

Update a warehouse

Updates an existing warehouse using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWarehouseExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var body = new Warehouse(); // Warehouse | Warehouse to be updated.

            try
            {
                // Update a warehouse
                apiInstance.UpdateWarehouse(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.UpdateWarehouse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Warehouse**](Warehouse.md)| Warehouse to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewarehousecustomfields"></a>
# **UpdateWarehouseCustomFields**
> void UpdateWarehouseCustomFields (Warehouse body)

Update a warehouse custom fields

Updates an existing warehouse custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWarehouseCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseApi();
            var body = new Warehouse(); // Warehouse | Warehouse to be updated.

            try
            {
                // Update a warehouse custom fields
                apiInstance.UpdateWarehouseCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseApi.UpdateWarehouseCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Warehouse**](Warehouse.md)| Warehouse to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

