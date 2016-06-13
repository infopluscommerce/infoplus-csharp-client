# Infoplus.Api.LocationAddressSchemeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocationAddressScheme**](LocationAddressSchemeApi.md#addlocationaddressscheme) | **POST** /v1.0/locationAddressScheme | Create a locationAddressScheme
[**DeleteLocationAddressScheme**](LocationAddressSchemeApi.md#deletelocationaddressscheme) | **DELETE** /v1.0/locationAddressScheme/{locationAddressSchemeId} | Delete a locationAddressScheme
[**GetLocationAddressSchemeByFilter**](LocationAddressSchemeApi.md#getlocationaddressschemebyfilter) | **GET** /v1.0/locationAddressScheme/search | Search locationAddressSchemes by filter
[**GetLocationAddressSchemeById**](LocationAddressSchemeApi.md#getlocationaddressschemebyid) | **GET** /v1.0/locationAddressScheme/{locationAddressSchemeId} | Get a locationAddressScheme by id
[**UpdateLocationAddressScheme**](LocationAddressSchemeApi.md#updatelocationaddressscheme) | **PUT** /v1.0/locationAddressScheme | Update a locationAddressScheme


# **AddLocationAddressScheme**
> LocationAddressScheme AddLocationAddressScheme (LocationAddressScheme body)

Create a locationAddressScheme

Inserts a new locationAddressScheme using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationAddressSchemeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationAddressSchemeApi();
            var body = new LocationAddressScheme(); // LocationAddressScheme | LocationAddressScheme to be inserted.

            try
            {
                // Create a locationAddressScheme
                LocationAddressScheme result = apiInstance.AddLocationAddressScheme(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.AddLocationAddressScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationAddressScheme**](LocationAddressScheme.md)| LocationAddressScheme to be inserted. | 

### Return type

[**LocationAddressScheme**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteLocationAddressScheme**
> void DeleteLocationAddressScheme (int? locationAddressSchemeId)

Delete a locationAddressScheme

Deletes the locationAddressScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationAddressSchemeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to be deleted.

            try
            {
                // Delete a locationAddressScheme
                apiInstance.DeleteLocationAddressScheme(locationAddressSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.DeleteLocationAddressScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetLocationAddressSchemeByFilter**
> List<LocationAddressScheme> GetLocationAddressSchemeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search locationAddressSchemes by filter

Returns the list of locationAddressSchemes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationAddressSchemeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationAddressSchemeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search locationAddressSchemes by filter
                List&lt;LocationAddressScheme&gt; result = apiInstance.GetLocationAddressSchemeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.GetLocationAddressSchemeByFilter: " + e.Message );
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

[**List<LocationAddressScheme>**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetLocationAddressSchemeById**
> LocationAddressScheme GetLocationAddressSchemeById (int? locationAddressSchemeId)

Get a locationAddressScheme by id

Returns the locationAddressScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationAddressSchemeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to be returned.

            try
            {
                // Get a locationAddressScheme by id
                LocationAddressScheme result = apiInstance.GetLocationAddressSchemeById(locationAddressSchemeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.GetLocationAddressSchemeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to be returned. | 

### Return type

[**LocationAddressScheme**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateLocationAddressScheme**
> void UpdateLocationAddressScheme (LocationAddressScheme body)

Update a locationAddressScheme

Updates an existing locationAddressScheme using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationAddressSchemeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationAddressSchemeApi();
            var body = new LocationAddressScheme(); // LocationAddressScheme | LocationAddressScheme to be updated.

            try
            {
                // Update a locationAddressScheme
                apiInstance.UpdateLocationAddressScheme(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.UpdateLocationAddressScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationAddressScheme**](LocationAddressScheme.md)| LocationAddressScheme to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

