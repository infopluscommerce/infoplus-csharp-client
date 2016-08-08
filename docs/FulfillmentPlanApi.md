# Infoplus.Api.FulfillmentPlanApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentPlan**](FulfillmentPlanApi.md#addfulfillmentplan) | **POST** /beta/fulfillmentPlan | Create a fulfillmentPlan
[**DeleteFulfillmentPlan**](FulfillmentPlanApi.md#deletefulfillmentplan) | **DELETE** /beta/fulfillmentPlan/{fulfillmentPlanId} | Delete a fulfillmentPlan
[**GetFulfillmentPlanByFilter**](FulfillmentPlanApi.md#getfulfillmentplanbyfilter) | **GET** /beta/fulfillmentPlan/search | Search fulfillmentPlans by filter
[**GetFulfillmentPlanById**](FulfillmentPlanApi.md#getfulfillmentplanbyid) | **GET** /beta/fulfillmentPlan/{fulfillmentPlanId} | Get a fulfillmentPlan by id
[**UpdateFulfillmentPlan**](FulfillmentPlanApi.md#updatefulfillmentplan) | **PUT** /beta/fulfillmentPlan | Update a fulfillmentPlan
[**UpdateFulfillmentPlanCustomFields**](FulfillmentPlanApi.md#updatefulfillmentplancustomfields) | **PUT** /beta/fulfillmentPlan/customFields | Update a fulfillmentPlan custom fields


<a name="addfulfillmentplan"></a>
# **AddFulfillmentPlan**
> FulfillmentPlan AddFulfillmentPlan (FulfillmentPlan body)

Create a fulfillmentPlan

Inserts a new fulfillmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new FulfillmentPlan(); // FulfillmentPlan | FulfillmentPlan to be inserted.

            try
            {
                // Create a fulfillmentPlan
                FulfillmentPlan result = apiInstance.AddFulfillmentPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.AddFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentPlan**](FulfillmentPlan.md)| FulfillmentPlan to be inserted. | 

### Return type

[**FulfillmentPlan**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentplan"></a>
# **DeleteFulfillmentPlan**
> void DeleteFulfillmentPlan (int? fulfillmentPlanId)

Delete a fulfillmentPlan

Deletes the fulfillmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to be deleted.

            try
            {
                // Delete a fulfillmentPlan
                apiInstance.DeleteFulfillmentPlan(fulfillmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.DeleteFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentplanbyfilter"></a>
# **GetFulfillmentPlanByFilter**
> List<FulfillmentPlan> GetFulfillmentPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search fulfillmentPlans by filter

Returns the list of fulfillmentPlans that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentPlanByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search fulfillmentPlans by filter
                List&lt;FulfillmentPlan&gt; result = apiInstance.GetFulfillmentPlanByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetFulfillmentPlanByFilter: " + e.Message );
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

[**List<FulfillmentPlan>**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentplanbyid"></a>
# **GetFulfillmentPlanById**
> FulfillmentPlan GetFulfillmentPlanById (int? fulfillmentPlanId)

Get a fulfillmentPlan by id

Returns the fulfillmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentPlanByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to be returned.

            try
            {
                // Get a fulfillmentPlan by id
                FulfillmentPlan result = apiInstance.GetFulfillmentPlanById(fulfillmentPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetFulfillmentPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to be returned. | 

### Return type

[**FulfillmentPlan**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentplan"></a>
# **UpdateFulfillmentPlan**
> void UpdateFulfillmentPlan (FulfillmentPlan body)

Update a fulfillmentPlan

Updates an existing fulfillmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFulfillmentPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new FulfillmentPlan(); // FulfillmentPlan | FulfillmentPlan to be updated.

            try
            {
                // Update a fulfillmentPlan
                apiInstance.UpdateFulfillmentPlan(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.UpdateFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentPlan**](FulfillmentPlan.md)| FulfillmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentplancustomfields"></a>
# **UpdateFulfillmentPlanCustomFields**
> void UpdateFulfillmentPlanCustomFields (FulfillmentPlan body)

Update a fulfillmentPlan custom fields

Updates an existing fulfillmentPlan custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFulfillmentPlanCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new FulfillmentPlan(); // FulfillmentPlan | FulfillmentPlan to be updated.

            try
            {
                // Update a fulfillmentPlan custom fields
                apiInstance.UpdateFulfillmentPlanCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.UpdateFulfillmentPlanCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentPlan**](FulfillmentPlan.md)| FulfillmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

