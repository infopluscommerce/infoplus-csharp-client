# Infoplus.Api.ExternalShipmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddExternalShipment**](ExternalShipmentApi.md#addexternalshipment) | **POST** /v1.0/externalShipment | Create an externalShipment
[**DeleteExternalShipment**](ExternalShipmentApi.md#deleteexternalshipment) | **DELETE** /v1.0/externalShipment/{externalShipmentId} | Delete an externalShipment
[**GetExternalShipmentByFilter**](ExternalShipmentApi.md#getexternalshipmentbyfilter) | **GET** /v1.0/externalShipment/search | Search externalShipments by filter
[**GetExternalShipmentById**](ExternalShipmentApi.md#getexternalshipmentbyid) | **GET** /v1.0/externalShipment/{externalShipmentId} | Get an externalShipment by id
[**UpdateExternalShipment**](ExternalShipmentApi.md#updateexternalshipment) | **PUT** /v1.0/externalShipment | Update an externalShipment


# **AddExternalShipment**
> ExternalShipment AddExternalShipment (ExternalShipment body)

Create an externalShipment

Inserts a new externalShipment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShipmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ExternalShipmentApi();
            var body = new ExternalShipment(); // ExternalShipment | ExternalShipment to be inserted.

            try
            {
                // Create an externalShipment
                ExternalShipment result = apiInstance.AddExternalShipment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.AddExternalShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShipment**](ExternalShipment.md)| ExternalShipment to be inserted. | 

### Return type

[**ExternalShipment**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteExternalShipment**
> void DeleteExternalShipment (int? externalShipmentId)

Delete an externalShipment

Deletes the externalShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteExternalShipmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to be deleted.

            try
            {
                // Delete an externalShipment
                apiInstance.DeleteExternalShipment(externalShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.DeleteExternalShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetExternalShipmentByFilter**
> List<ExternalShipment> GetExternalShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search externalShipments by filter

Returns the list of externalShipments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShipmentByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ExternalShipmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search externalShipments by filter
                List&lt;ExternalShipment&gt; result = apiInstance.GetExternalShipmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetExternalShipmentByFilter: " + e.Message );
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

[**List<ExternalShipment>**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetExternalShipmentById**
> ExternalShipment GetExternalShipmentById (int? externalShipmentId)

Get an externalShipment by id

Returns the externalShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShipmentByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to be returned.

            try
            {
                // Get an externalShipment by id
                ExternalShipment result = apiInstance.GetExternalShipmentById(externalShipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetExternalShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to be returned. | 

### Return type

[**ExternalShipment**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateExternalShipment**
> void UpdateExternalShipment (ExternalShipment body)

Update an externalShipment

Updates an existing externalShipment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateExternalShipmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ExternalShipmentApi();
            var body = new ExternalShipment(); // ExternalShipment | ExternalShipment to be updated.

            try
            {
                // Update an externalShipment
                apiInstance.UpdateExternalShipment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.UpdateExternalShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShipment**](ExternalShipment.md)| ExternalShipment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

