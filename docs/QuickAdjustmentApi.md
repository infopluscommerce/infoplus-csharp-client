# Infoplus.Api.QuickAdjustmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddQuickAdjustment**](QuickAdjustmentApi.md#addquickadjustment) | **POST** /v1.0/quickAdjustment | Create a quickAdjustment
[**DeleteQuickAdjustment**](QuickAdjustmentApi.md#deletequickadjustment) | **DELETE** /v1.0/quickAdjustment/{quickAdjustmentId} | Delete a quickAdjustment
[**GetQuickAdjustmentByFilter**](QuickAdjustmentApi.md#getquickadjustmentbyfilter) | **GET** /v1.0/quickAdjustment/search | Search quickAdjustments by filter
[**GetQuickAdjustmentById**](QuickAdjustmentApi.md#getquickadjustmentbyid) | **GET** /v1.0/quickAdjustment/{quickAdjustmentId} | Get a quickAdjustment by id
[**UpdateQuickAdjustment**](QuickAdjustmentApi.md#updatequickadjustment) | **PUT** /v1.0/quickAdjustment | Update a quickAdjustment


# **AddQuickAdjustment**
> QuickAdjustment AddQuickAdjustment (QuickAdjustment body)

Create a quickAdjustment

Inserts a new quickAdjustment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickAdjustmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new QuickAdjustmentApi();
            var body = new QuickAdjustment(); // QuickAdjustment | QuickAdjustment to be inserted.

            try
            {
                // Create a quickAdjustment
                QuickAdjustment result = apiInstance.AddQuickAdjustment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.AddQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickAdjustment**](QuickAdjustment.md)| QuickAdjustment to be inserted. | 

### Return type

[**QuickAdjustment**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteQuickAdjustment**
> void DeleteQuickAdjustment (int? quickAdjustmentId)

Delete a quickAdjustment

Deletes the quickAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteQuickAdjustmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to be deleted.

            try
            {
                // Delete a quickAdjustment
                apiInstance.DeleteQuickAdjustment(quickAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.DeleteQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetQuickAdjustmentByFilter**
> List<QuickAdjustment> GetQuickAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search quickAdjustments by filter

Returns the list of quickAdjustments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickAdjustmentByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new QuickAdjustmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search quickAdjustments by filter
                List&lt;QuickAdjustment&gt; result = apiInstance.GetQuickAdjustmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetQuickAdjustmentByFilter: " + e.Message );
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

[**List<QuickAdjustment>**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetQuickAdjustmentById**
> QuickAdjustment GetQuickAdjustmentById (int? quickAdjustmentId)

Get a quickAdjustment by id

Returns the quickAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickAdjustmentByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to be returned.

            try
            {
                // Get a quickAdjustment by id
                QuickAdjustment result = apiInstance.GetQuickAdjustmentById(quickAdjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetQuickAdjustmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to be returned. | 

### Return type

[**QuickAdjustment**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateQuickAdjustment**
> void UpdateQuickAdjustment (QuickAdjustment body)

Update a quickAdjustment

Updates an existing quickAdjustment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateQuickAdjustmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new QuickAdjustmentApi();
            var body = new QuickAdjustment(); // QuickAdjustment | QuickAdjustment to be updated.

            try
            {
                // Update a quickAdjustment
                apiInstance.UpdateQuickAdjustment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.UpdateQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickAdjustment**](QuickAdjustment.md)| QuickAdjustment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

