# Infoplus.Api.OrderSourceReservationApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderSourceReservation**](OrderSourceReservationApi.md#addordersourcereservation) | **POST** /v1.0/orderSourceReservation | Create an orderSourceReservation
[**DeleteOrderSourceReservation**](OrderSourceReservationApi.md#deleteordersourcereservation) | **DELETE** /v1.0/orderSourceReservation/{orderSourceReservationId} | Delete an orderSourceReservation
[**GetOrderSourceReservationByFilter**](OrderSourceReservationApi.md#getordersourcereservationbyfilter) | **GET** /v1.0/orderSourceReservation/search | Search orderSourceReservations by filter
[**GetOrderSourceReservationById**](OrderSourceReservationApi.md#getordersourcereservationbyid) | **GET** /v1.0/orderSourceReservation/{orderSourceReservationId} | Get an orderSourceReservation by id
[**UpdateOrderSourceReservation**](OrderSourceReservationApi.md#updateordersourcereservation) | **PUT** /v1.0/orderSourceReservation | Update an orderSourceReservation


# **AddOrderSourceReservation**
> OrderSourceReservation AddOrderSourceReservation (OrderSourceReservation body)

Create an orderSourceReservation

Inserts a new orderSourceReservation using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceReservationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OrderSourceReservationApi();
            var body = new OrderSourceReservation(); // OrderSourceReservation | OrderSourceReservation to be inserted.

            try
            {
                // Create an orderSourceReservation
                OrderSourceReservation result = apiInstance.AddOrderSourceReservation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.AddOrderSourceReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSourceReservation**](OrderSourceReservation.md)| OrderSourceReservation to be inserted. | 

### Return type

[**OrderSourceReservation**](OrderSourceReservation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteOrderSourceReservation**
> void DeleteOrderSourceReservation (int? orderSourceReservationId)

Delete an orderSourceReservation

Deletes the orderSourceReservation identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceReservationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to be deleted.

            try
            {
                // Delete an orderSourceReservation
                apiInstance.DeleteOrderSourceReservation(orderSourceReservationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.DeleteOrderSourceReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetOrderSourceReservationByFilter**
> List<OrderSourceReservation> GetOrderSourceReservationByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderSourceReservations by filter

Returns the list of orderSourceReservations that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceReservationByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OrderSourceReservationApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderSourceReservations by filter
                List&lt;OrderSourceReservation&gt; result = apiInstance.GetOrderSourceReservationByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.GetOrderSourceReservationByFilter: " + e.Message );
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

[**List<OrderSourceReservation>**](OrderSourceReservation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetOrderSourceReservationById**
> OrderSourceReservation GetOrderSourceReservationById (int? orderSourceReservationId)

Get an orderSourceReservation by id

Returns the orderSourceReservation identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceReservationByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to be returned.

            try
            {
                // Get an orderSourceReservation by id
                OrderSourceReservation result = apiInstance.GetOrderSourceReservationById(orderSourceReservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.GetOrderSourceReservationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to be returned. | 

### Return type

[**OrderSourceReservation**](OrderSourceReservation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateOrderSourceReservation**
> void UpdateOrderSourceReservation (OrderSourceReservation body)

Update an orderSourceReservation

Updates an existing orderSourceReservation using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderSourceReservationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OrderSourceReservationApi();
            var body = new OrderSourceReservation(); // OrderSourceReservation | OrderSourceReservation to be updated.

            try
            {
                // Update an orderSourceReservation
                apiInstance.UpdateOrderSourceReservation(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.UpdateOrderSourceReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSourceReservation**](OrderSourceReservation.md)| OrderSourceReservation to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

