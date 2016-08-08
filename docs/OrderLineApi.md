# Infoplus.Api.OrderLineApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderLineByFilter**](OrderLineApi.md#getorderlinebyfilter) | **GET** /beta/orderLine/search | Search orderLines by filter
[**GetOrderLineById**](OrderLineApi.md#getorderlinebyid) | **GET** /beta/orderLine/{orderLineId} | Get an orderLine by id
[**UpdateOrderLineCustomFields**](OrderLineApi.md#updateorderlinecustomfields) | **PUT** /beta/orderLine/customFields | Update an orderLine custom fields


<a name="getorderlinebyfilter"></a>
# **GetOrderLineByFilter**
> List<OrderLine> GetOrderLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderLines by filter

Returns the list of orderLines that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderLines by filter
                List&lt;OrderLine&gt; result = apiInstance.GetOrderLineByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetOrderLineByFilter: " + e.Message );
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

[**List<OrderLine>**](OrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlinebyid"></a>
# **GetOrderLineById**
> OrderLine GetOrderLineById (int? orderLineId)

Get an orderLine by id

Returns the orderLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to be returned.

            try
            {
                // Get an orderLine by id
                OrderLine result = apiInstance.GetOrderLineById(orderLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetOrderLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to be returned. | 

### Return type

[**OrderLine**](OrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderlinecustomfields"></a>
# **UpdateOrderLineCustomFields**
> void UpdateOrderLineCustomFields (OrderLine body)

Update an orderLine custom fields

Updates an existing orderLine custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderLineCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var body = new OrderLine(); // OrderLine | OrderLine to be updated.

            try
            {
                // Update an orderLine custom fields
                apiInstance.UpdateOrderLineCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.UpdateOrderLineCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderLine**](OrderLine.md)| OrderLine to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

