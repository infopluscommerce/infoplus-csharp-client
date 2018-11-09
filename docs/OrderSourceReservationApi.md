# Infoplus.Api.OrderSourceReservationApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderSourceReservation**](OrderSourceReservationApi.md#addordersourcereservation) | **POST** /beta/orderSourceReservation | Create an orderSourceReservation
[**AddOrderSourceReservationAudit**](OrderSourceReservationApi.md#addordersourcereservationaudit) | **PUT** /beta/orderSourceReservation/{orderSourceReservationId}/audit/{orderSourceReservationAudit} | Add new audit for an orderSourceReservation
[**AddOrderSourceReservationTag**](OrderSourceReservationApi.md#addordersourcereservationtag) | **PUT** /beta/orderSourceReservation/{orderSourceReservationId}/tag/{orderSourceReservationTag} | Add new tags for an orderSourceReservation.
[**DeleteOrderSourceReservation**](OrderSourceReservationApi.md#deleteordersourcereservation) | **DELETE** /beta/orderSourceReservation/{orderSourceReservationId} | Delete an orderSourceReservation
[**DeleteOrderSourceReservationTag**](OrderSourceReservationApi.md#deleteordersourcereservationtag) | **DELETE** /beta/orderSourceReservation/{orderSourceReservationId}/tag/{orderSourceReservationTag} | Delete a tag for an orderSourceReservation.
[**GetDuplicateOrderSourceReservationById**](OrderSourceReservationApi.md#getduplicateordersourcereservationbyid) | **GET** /beta/orderSourceReservation/duplicate/{orderSourceReservationId} | Get a duplicated an orderSourceReservation by id
[**GetOrderSourceReservationByFilter**](OrderSourceReservationApi.md#getordersourcereservationbyfilter) | **GET** /beta/orderSourceReservation/search | Search orderSourceReservations by filter
[**GetOrderSourceReservationById**](OrderSourceReservationApi.md#getordersourcereservationbyid) | **GET** /beta/orderSourceReservation/{orderSourceReservationId} | Get an orderSourceReservation by id
[**GetOrderSourceReservationTags**](OrderSourceReservationApi.md#getordersourcereservationtags) | **GET** /beta/orderSourceReservation/{orderSourceReservationId}/tag | Get the tags for an orderSourceReservation.
[**UpdateOrderSourceReservation**](OrderSourceReservationApi.md#updateordersourcereservation) | **PUT** /beta/orderSourceReservation | Update an orderSourceReservation
[**UpdateOrderSourceReservationCustomFields**](OrderSourceReservationApi.md#updateordersourcereservationcustomfields) | **PUT** /beta/orderSourceReservation/customFields | Update an orderSourceReservation custom fields


<a name="addordersourcereservation"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="addordersourcereservationaudit"></a>
# **AddOrderSourceReservationAudit**
> void AddOrderSourceReservationAudit (int? orderSourceReservationId, string orderSourceReservationAudit)

Add new audit for an orderSourceReservation

Adds an audit to an existing orderSourceReservation.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceReservationAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to add an audit to
            var orderSourceReservationAudit = orderSourceReservationAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderSourceReservation
                apiInstance.AddOrderSourceReservationAudit(orderSourceReservationId, orderSourceReservationAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.AddOrderSourceReservationAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to add an audit to | 
 **orderSourceReservationAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcereservationtag"></a>
# **AddOrderSourceReservationTag**
> void AddOrderSourceReservationTag (int? orderSourceReservationId, string orderSourceReservationTag)

Add new tags for an orderSourceReservation.

Adds a tag to an existing orderSourceReservation.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceReservationTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to add a tag to
            var orderSourceReservationTag = orderSourceReservationTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderSourceReservation.
                apiInstance.AddOrderSourceReservationTag(orderSourceReservationId, orderSourceReservationTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.AddOrderSourceReservationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to add a tag to | 
 **orderSourceReservationTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourcereservation"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="deleteordersourcereservationtag"></a>
# **DeleteOrderSourceReservationTag**
> void DeleteOrderSourceReservationTag (int? orderSourceReservationId, string orderSourceReservationTag)

Delete a tag for an orderSourceReservation.

Deletes an existing orderSourceReservation tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceReservationTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to remove tag from
            var orderSourceReservationTag = orderSourceReservationTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderSourceReservation.
                apiInstance.DeleteOrderSourceReservationTag(orderSourceReservationId, orderSourceReservationTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.DeleteOrderSourceReservationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to remove tag from | 
 **orderSourceReservationTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateordersourcereservationbyid"></a>
# **GetDuplicateOrderSourceReservationById**
> OrderSourceReservation GetDuplicateOrderSourceReservationById (int? orderSourceReservationId)

Get a duplicated an orderSourceReservation by id

Returns a duplicated orderSourceReservation identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderSourceReservationByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to be duplicated.

            try
            {
                // Get a duplicated an orderSourceReservation by id
                OrderSourceReservation result = apiInstance.GetDuplicateOrderSourceReservationById(orderSourceReservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.GetDuplicateOrderSourceReservationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to be duplicated. | 

### Return type

[**OrderSourceReservation**](OrderSourceReservation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcereservationbyfilter"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getordersourcereservationbyid"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getordersourcereservationtags"></a>
# **GetOrderSourceReservationTags**
> void GetOrderSourceReservationTags (int? orderSourceReservationId)

Get the tags for an orderSourceReservation.

Get all existing orderSourceReservation tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceReservationTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceReservationApi();
            var orderSourceReservationId = 56;  // int? | Id of the orderSourceReservation to get tags for

            try
            {
                // Get the tags for an orderSourceReservation.
                apiInstance.GetOrderSourceReservationTags(orderSourceReservationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.GetOrderSourceReservationTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceReservationId** | **int?**| Id of the orderSourceReservation to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateordersourcereservation"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="updateordersourcereservationcustomfields"></a>
# **UpdateOrderSourceReservationCustomFields**
> void UpdateOrderSourceReservationCustomFields (OrderSourceReservation body)

Update an orderSourceReservation custom fields

Updates an existing orderSourceReservation custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderSourceReservationCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceReservationApi();
            var body = new OrderSourceReservation(); // OrderSourceReservation | OrderSourceReservation to be updated.

            try
            {
                // Update an orderSourceReservation custom fields
                apiInstance.UpdateOrderSourceReservationCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceReservationApi.UpdateOrderSourceReservationCustomFields: " + e.Message );
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

