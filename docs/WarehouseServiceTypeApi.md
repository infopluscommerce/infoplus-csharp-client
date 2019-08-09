# Infoplus.Api.WarehouseServiceTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWarehouseServiceType**](WarehouseServiceTypeApi.md#addwarehouseservicetype) | **POST** /beta/warehouseServiceType | Create a warehouseServiceType
[**AddWarehouseServiceTypeAudit**](WarehouseServiceTypeApi.md#addwarehouseservicetypeaudit) | **PUT** /beta/warehouseServiceType/{warehouseServiceTypeId}/audit/{warehouseServiceTypeAudit} | Add new audit for a warehouseServiceType
[**AddWarehouseServiceTypeFile**](WarehouseServiceTypeApi.md#addwarehouseservicetypefile) | **POST** /beta/warehouseServiceType/{warehouseServiceTypeId}/file/{fileName} | Attach a file to a warehouseServiceType
[**AddWarehouseServiceTypeTag**](WarehouseServiceTypeApi.md#addwarehouseservicetypetag) | **PUT** /beta/warehouseServiceType/{warehouseServiceTypeId}/tag/{warehouseServiceTypeTag} | Add new tags for a warehouseServiceType.
[**DeleteWarehouseServiceType**](WarehouseServiceTypeApi.md#deletewarehouseservicetype) | **DELETE** /beta/warehouseServiceType/{warehouseServiceTypeId} | Delete a warehouseServiceType
[**DeleteWarehouseServiceTypeTag**](WarehouseServiceTypeApi.md#deletewarehouseservicetypetag) | **DELETE** /beta/warehouseServiceType/{warehouseServiceTypeId}/tag/{warehouseServiceTypeTag} | Delete a tag for a warehouseServiceType.
[**GetDuplicateWarehouseServiceTypeById**](WarehouseServiceTypeApi.md#getduplicatewarehouseservicetypebyid) | **GET** /beta/warehouseServiceType/duplicate/{warehouseServiceTypeId} | Get a duplicated a warehouseServiceType by id
[**GetWarehouseServiceTypeByFilter**](WarehouseServiceTypeApi.md#getwarehouseservicetypebyfilter) | **GET** /beta/warehouseServiceType/search | Search warehouseServiceTypes by filter
[**GetWarehouseServiceTypeById**](WarehouseServiceTypeApi.md#getwarehouseservicetypebyid) | **GET** /beta/warehouseServiceType/{warehouseServiceTypeId} | Get a warehouseServiceType by id
[**GetWarehouseServiceTypeTags**](WarehouseServiceTypeApi.md#getwarehouseservicetypetags) | **GET** /beta/warehouseServiceType/{warehouseServiceTypeId}/tag | Get the tags for a warehouseServiceType.
[**UpdateWarehouseServiceType**](WarehouseServiceTypeApi.md#updatewarehouseservicetype) | **PUT** /beta/warehouseServiceType | Update a warehouseServiceType
[**UpdateWarehouseServiceTypeCustomFields**](WarehouseServiceTypeApi.md#updatewarehouseservicetypecustomfields) | **PUT** /beta/warehouseServiceType/customFields | Update a warehouseServiceType custom fields


<a name="addwarehouseservicetype"></a>
# **AddWarehouseServiceType**
> WarehouseServiceType AddWarehouseServiceType (WarehouseServiceType body)

Create a warehouseServiceType

Inserts a new warehouseServiceType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseServiceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var body = new WarehouseServiceType(); // WarehouseServiceType | WarehouseServiceType to be inserted.

            try
            {
                // Create a warehouseServiceType
                WarehouseServiceType result = apiInstance.AddWarehouseServiceType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.AddWarehouseServiceType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WarehouseServiceType**](WarehouseServiceType.md)| WarehouseServiceType to be inserted. | 

### Return type

[**WarehouseServiceType**](WarehouseServiceType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehouseservicetypeaudit"></a>
# **AddWarehouseServiceTypeAudit**
> void AddWarehouseServiceTypeAudit (int? warehouseServiceTypeId, string warehouseServiceTypeAudit)

Add new audit for a warehouseServiceType

Adds an audit to an existing warehouseServiceType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseServiceTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to add an audit to
            var warehouseServiceTypeAudit = warehouseServiceTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a warehouseServiceType
                apiInstance.AddWarehouseServiceTypeAudit(warehouseServiceTypeId, warehouseServiceTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.AddWarehouseServiceTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to add an audit to | 
 **warehouseServiceTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehouseservicetypefile"></a>
# **AddWarehouseServiceTypeFile**
> void AddWarehouseServiceTypeFile (int? warehouseServiceTypeId, string fileName)

Attach a file to a warehouseServiceType

Adds a file to an existing warehouseServiceType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseServiceTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a warehouseServiceType
                apiInstance.AddWarehouseServiceTypeFile(warehouseServiceTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.AddWarehouseServiceTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwarehouseservicetypetag"></a>
# **AddWarehouseServiceTypeTag**
> void AddWarehouseServiceTypeTag (int? warehouseServiceTypeId, string warehouseServiceTypeTag)

Add new tags for a warehouseServiceType.

Adds a tag to an existing warehouseServiceType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddWarehouseServiceTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to add a tag to
            var warehouseServiceTypeTag = warehouseServiceTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a warehouseServiceType.
                apiInstance.AddWarehouseServiceTypeTag(warehouseServiceTypeId, warehouseServiceTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.AddWarehouseServiceTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to add a tag to | 
 **warehouseServiceTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehouseservicetype"></a>
# **DeleteWarehouseServiceType**
> void DeleteWarehouseServiceType (int? warehouseServiceTypeId)

Delete a warehouseServiceType

Deletes the warehouseServiceType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseServiceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to be deleted.

            try
            {
                // Delete a warehouseServiceType
                apiInstance.DeleteWarehouseServiceType(warehouseServiceTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.DeleteWarehouseServiceType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewarehouseservicetypetag"></a>
# **DeleteWarehouseServiceTypeTag**
> void DeleteWarehouseServiceTypeTag (int? warehouseServiceTypeId, string warehouseServiceTypeTag)

Delete a tag for a warehouseServiceType.

Deletes an existing warehouseServiceType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteWarehouseServiceTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to remove tag from
            var warehouseServiceTypeTag = warehouseServiceTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a warehouseServiceType.
                apiInstance.DeleteWarehouseServiceTypeTag(warehouseServiceTypeId, warehouseServiceTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.DeleteWarehouseServiceTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to remove tag from | 
 **warehouseServiceTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatewarehouseservicetypebyid"></a>
# **GetDuplicateWarehouseServiceTypeById**
> WarehouseServiceType GetDuplicateWarehouseServiceTypeById (int? warehouseServiceTypeId)

Get a duplicated a warehouseServiceType by id

Returns a duplicated warehouseServiceType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateWarehouseServiceTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to be duplicated.

            try
            {
                // Get a duplicated a warehouseServiceType by id
                WarehouseServiceType result = apiInstance.GetDuplicateWarehouseServiceTypeById(warehouseServiceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.GetDuplicateWarehouseServiceTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to be duplicated. | 

### Return type

[**WarehouseServiceType**](WarehouseServiceType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseservicetypebyfilter"></a>
# **GetWarehouseServiceTypeByFilter**
> List<WarehouseServiceType> GetWarehouseServiceTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search warehouseServiceTypes by filter

Returns the list of warehouseServiceTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseServiceTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search warehouseServiceTypes by filter
                List&lt;WarehouseServiceType&gt; result = apiInstance.GetWarehouseServiceTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.GetWarehouseServiceTypeByFilter: " + e.Message );
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

[**List<WarehouseServiceType>**](WarehouseServiceType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseservicetypebyid"></a>
# **GetWarehouseServiceTypeById**
> WarehouseServiceType GetWarehouseServiceTypeById (int? warehouseServiceTypeId)

Get a warehouseServiceType by id

Returns the warehouseServiceType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseServiceTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to be returned.

            try
            {
                // Get a warehouseServiceType by id
                WarehouseServiceType result = apiInstance.GetWarehouseServiceTypeById(warehouseServiceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.GetWarehouseServiceTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to be returned. | 

### Return type

[**WarehouseServiceType**](WarehouseServiceType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarehouseservicetypetags"></a>
# **GetWarehouseServiceTypeTags**
> void GetWarehouseServiceTypeTags (int? warehouseServiceTypeId)

Get the tags for a warehouseServiceType.

Get all existing warehouseServiceType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetWarehouseServiceTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var warehouseServiceTypeId = 56;  // int? | Id of the warehouseServiceType to get tags for

            try
            {
                // Get the tags for a warehouseServiceType.
                apiInstance.GetWarehouseServiceTypeTags(warehouseServiceTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.GetWarehouseServiceTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseServiceTypeId** | **int?**| Id of the warehouseServiceType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewarehouseservicetype"></a>
# **UpdateWarehouseServiceType**
> void UpdateWarehouseServiceType (WarehouseServiceType body)

Update a warehouseServiceType

Updates an existing warehouseServiceType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWarehouseServiceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var body = new WarehouseServiceType(); // WarehouseServiceType | WarehouseServiceType to be updated.

            try
            {
                // Update a warehouseServiceType
                apiInstance.UpdateWarehouseServiceType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.UpdateWarehouseServiceType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WarehouseServiceType**](WarehouseServiceType.md)| WarehouseServiceType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewarehouseservicetypecustomfields"></a>
# **UpdateWarehouseServiceTypeCustomFields**
> void UpdateWarehouseServiceTypeCustomFields (WarehouseServiceType body)

Update a warehouseServiceType custom fields

Updates an existing warehouseServiceType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateWarehouseServiceTypeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new WarehouseServiceTypeApi();
            var body = new WarehouseServiceType(); // WarehouseServiceType | WarehouseServiceType to be updated.

            try
            {
                // Update a warehouseServiceType custom fields
                apiInstance.UpdateWarehouseServiceTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehouseServiceTypeApi.UpdateWarehouseServiceTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WarehouseServiceType**](WarehouseServiceType.md)| WarehouseServiceType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

