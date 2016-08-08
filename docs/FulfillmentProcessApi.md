# Infoplus.Api.FulfillmentProcessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFulfillmentProcessByFilter**](FulfillmentProcessApi.md#getfulfillmentprocessbyfilter) | **GET** /beta/fulfillmentProcess/search | Search fulfillmentProcesses by filter
[**GetFulfillmentProcessById**](FulfillmentProcessApi.md#getfulfillmentprocessbyid) | **GET** /beta/fulfillmentProcess/{fulfillmentProcessId} | Get a fulfillmentProcess by id
[**UpdateFulfillmentProcessCustomFields**](FulfillmentProcessApi.md#updatefulfillmentprocesscustomfields) | **PUT** /beta/fulfillmentProcess/customFields | Update a fulfillmentProcess custom fields


<a name="getfulfillmentprocessbyfilter"></a>
# **GetFulfillmentProcessByFilter**
> List<FulfillmentProcess> GetFulfillmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search fulfillmentProcesses by filter

Returns the list of fulfillmentProcesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search fulfillmentProcesses by filter
                List&lt;FulfillmentProcess&gt; result = apiInstance.GetFulfillmentProcessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetFulfillmentProcessByFilter: " + e.Message );
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

[**List<FulfillmentProcess>**](FulfillmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocessbyid"></a>
# **GetFulfillmentProcessById**
> FulfillmentProcess GetFulfillmentProcessById (int? fulfillmentProcessId)

Get a fulfillmentProcess by id

Returns the fulfillmentProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to be returned.

            try
            {
                // Get a fulfillmentProcess by id
                FulfillmentProcess result = apiInstance.GetFulfillmentProcessById(fulfillmentProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetFulfillmentProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to be returned. | 

### Return type

[**FulfillmentProcess**](FulfillmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentprocesscustomfields"></a>
# **UpdateFulfillmentProcessCustomFields**
> void UpdateFulfillmentProcessCustomFields (FulfillmentProcess body)

Update a fulfillmentProcess custom fields

Updates an existing fulfillmentProcess custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFulfillmentProcessCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var body = new FulfillmentProcess(); // FulfillmentProcess | FulfillmentProcess to be updated.

            try
            {
                // Update a fulfillmentProcess custom fields
                apiInstance.UpdateFulfillmentProcessCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.UpdateFulfillmentProcessCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentProcess**](FulfillmentProcess.md)| FulfillmentProcess to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

