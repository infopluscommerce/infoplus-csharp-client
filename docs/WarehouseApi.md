# Infoplus.Api.WarehouseApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWarehouseByFilter**](WarehouseApi.md#getwarehousebyfilter) | **GET** /beta/warehouse/search | Search warehouses by filter
[**GetWarehouseById**](WarehouseApi.md#getwarehousebyid) | **GET** /beta/warehouse/{warehouseId} | Get a warehouse by id
[**UpdateWarehouse**](WarehouseApi.md#updatewarehouse) | **PUT** /beta/warehouse | Update a warehouse
[**UpdateWarehouseCustomFields**](WarehouseApi.md#updatewarehousecustomfields) | **PUT** /beta/warehouse/customFields | Update a warehouse custom fields


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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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

