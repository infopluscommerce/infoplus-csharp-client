# Infoplus.Api.ProductionLotApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProductionLotByFilter**](ProductionLotApi.md#getproductionlotbyfilter) | **GET** /beta/productionLot/search | Search productionLots by filter
[**GetProductionLotById**](ProductionLotApi.md#getproductionlotbyid) | **GET** /beta/productionLot/{productionLotId} | Get a productionLot by id
[**UpdateProductionLotCustomFields**](ProductionLotApi.md#updateproductionlotcustomfields) | **PUT** /beta/productionLot/customFields | Update a productionLot custom fields


<a name="getproductionlotbyfilter"></a>
# **GetProductionLotByFilter**
> List<ProductionLot> GetProductionLotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search productionLots by filter

Returns the list of productionLots that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionLotByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search productionLots by filter
                List&lt;ProductionLot&gt; result = apiInstance.GetProductionLotByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.GetProductionLotByFilter: " + e.Message );
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

[**List<ProductionLot>**](ProductionLot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionlotbyid"></a>
# **GetProductionLotById**
> ProductionLot GetProductionLotById (int? productionLotId)

Get a productionLot by id

Returns the productionLot identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionLotByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to be returned.

            try
            {
                // Get a productionLot by id
                ProductionLot result = apiInstance.GetProductionLotById(productionLotId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.GetProductionLotById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to be returned. | 

### Return type

[**ProductionLot**](ProductionLot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductionlotcustomfields"></a>
# **UpdateProductionLotCustomFields**
> void UpdateProductionLotCustomFields (ProductionLot body)

Update a productionLot custom fields

Updates an existing productionLot custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateProductionLotCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var body = new ProductionLot(); // ProductionLot | ProductionLot to be updated.

            try
            {
                // Update a productionLot custom fields
                apiInstance.UpdateProductionLotCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.UpdateProductionLotCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionLot**](ProductionLot.md)| ProductionLot to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

