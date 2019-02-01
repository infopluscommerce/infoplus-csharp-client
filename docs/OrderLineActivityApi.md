# Infoplus.Api.OrderLineActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderLineActivity**](OrderLineActivityApi.md#addorderlineactivity) | **POST** /beta/orderLineActivity | Create an orderLineActivity
[**AddOrderLineActivityAudit**](OrderLineActivityApi.md#addorderlineactivityaudit) | **PUT** /beta/orderLineActivity/{orderLineActivityId}/audit/{orderLineActivityAudit} | Add new audit for an orderLineActivity
[**AddOrderLineActivityTag**](OrderLineActivityApi.md#addorderlineactivitytag) | **PUT** /beta/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag} | Add new tags for an orderLineActivity.
[**DeleteOrderLineActivity**](OrderLineActivityApi.md#deleteorderlineactivity) | **DELETE** /beta/orderLineActivity/{orderLineActivityId} | Delete an orderLineActivity
[**DeleteOrderLineActivityTag**](OrderLineActivityApi.md#deleteorderlineactivitytag) | **DELETE** /beta/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag} | Delete a tag for an orderLineActivity.
[**GetDuplicateOrderLineActivityById**](OrderLineActivityApi.md#getduplicateorderlineactivitybyid) | **GET** /beta/orderLineActivity/duplicate/{orderLineActivityId} | Get a duplicated an orderLineActivity by id
[**GetOrderLineActivityByFilter**](OrderLineActivityApi.md#getorderlineactivitybyfilter) | **GET** /beta/orderLineActivity/search | Search orderLineActivitys by filter
[**GetOrderLineActivityById**](OrderLineActivityApi.md#getorderlineactivitybyid) | **GET** /beta/orderLineActivity/{orderLineActivityId} | Get an orderLineActivity by id
[**GetOrderLineActivityTags**](OrderLineActivityApi.md#getorderlineactivitytags) | **GET** /beta/orderLineActivity/{orderLineActivityId}/tag | Get the tags for an orderLineActivity.
[**UpdateOrderLineActivity**](OrderLineActivityApi.md#updateorderlineactivity) | **PUT** /beta/orderLineActivity | Update an orderLineActivity


<a name="addorderlineactivity"></a>
# **AddOrderLineActivity**
> OrderLineActivity AddOrderLineActivity (OrderLineActivity body)

Create an orderLineActivity

Inserts a new orderLineActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var body = new OrderLineActivity(); // OrderLineActivity | OrderLineActivity to be inserted.

            try
            {
                // Create an orderLineActivity
                OrderLineActivity result = apiInstance.AddOrderLineActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderLineActivity**](OrderLineActivity.md)| OrderLineActivity to be inserted. | 

### Return type

[**OrderLineActivity**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlineactivityaudit"></a>
# **AddOrderLineActivityAudit**
> void AddOrderLineActivityAudit (int? orderLineActivityId, string orderLineActivityAudit)

Add new audit for an orderLineActivity

Adds an audit to an existing orderLineActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to add an audit to
            var orderLineActivityAudit = orderLineActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderLineActivity
                apiInstance.AddOrderLineActivityAudit(orderLineActivityId, orderLineActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to add an audit to | 
 **orderLineActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlineactivitytag"></a>
# **AddOrderLineActivityTag**
> void AddOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag)

Add new tags for an orderLineActivity.

Adds a tag to an existing orderLineActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to add a tag to
            var orderLineActivityTag = orderLineActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderLineActivity.
                apiInstance.AddOrderLineActivityTag(orderLineActivityId, orderLineActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to add a tag to | 
 **orderLineActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlineactivity"></a>
# **DeleteOrderLineActivity**
> void DeleteOrderLineActivity (int? orderLineActivityId)

Delete an orderLineActivity

Deletes the orderLineActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to be deleted.

            try
            {
                // Delete an orderLineActivity
                apiInstance.DeleteOrderLineActivity(orderLineActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.DeleteOrderLineActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlineactivitytag"></a>
# **DeleteOrderLineActivityTag**
> void DeleteOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag)

Delete a tag for an orderLineActivity.

Deletes an existing orderLineActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to remove tag from
            var orderLineActivityTag = orderLineActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderLineActivity.
                apiInstance.DeleteOrderLineActivityTag(orderLineActivityId, orderLineActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.DeleteOrderLineActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to remove tag from | 
 **orderLineActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateorderlineactivitybyid"></a>
# **GetDuplicateOrderLineActivityById**
> OrderLineActivity GetDuplicateOrderLineActivityById (int? orderLineActivityId)

Get a duplicated an orderLineActivity by id

Returns a duplicated orderLineActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderLineActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to be duplicated.

            try
            {
                // Get a duplicated an orderLineActivity by id
                OrderLineActivity result = apiInstance.GetDuplicateOrderLineActivityById(orderLineActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetDuplicateOrderLineActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to be duplicated. | 

### Return type

[**OrderLineActivity**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivitybyfilter"></a>
# **GetOrderLineActivityByFilter**
> List<OrderLineActivity> GetOrderLineActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderLineActivitys by filter

Returns the list of orderLineActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderLineActivitys by filter
                List&lt;OrderLineActivity&gt; result = apiInstance.GetOrderLineActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityByFilter: " + e.Message );
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

[**List<OrderLineActivity>**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivitybyid"></a>
# **GetOrderLineActivityById**
> OrderLineActivity GetOrderLineActivityById (int? orderLineActivityId)

Get an orderLineActivity by id

Returns the orderLineActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to be returned.

            try
            {
                // Get an orderLineActivity by id
                OrderLineActivity result = apiInstance.GetOrderLineActivityById(orderLineActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to be returned. | 

### Return type

[**OrderLineActivity**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivitytags"></a>
# **GetOrderLineActivityTags**
> void GetOrderLineActivityTags (int? orderLineActivityId)

Get the tags for an orderLineActivity.

Get all existing orderLineActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to get tags for

            try
            {
                // Get the tags for an orderLineActivity.
                apiInstance.GetOrderLineActivityTags(orderLineActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderlineactivity"></a>
# **UpdateOrderLineActivity**
> void UpdateOrderLineActivity (OrderLineActivity body)

Update an orderLineActivity

Updates an existing orderLineActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderLineActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var body = new OrderLineActivity(); // OrderLineActivity | OrderLineActivity to be updated.

            try
            {
                // Update an orderLineActivity
                apiInstance.UpdateOrderLineActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.UpdateOrderLineActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderLineActivity**](OrderLineActivity.md)| OrderLineActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

