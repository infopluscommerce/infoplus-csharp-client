# Infoplus.Api.OverrideReturnAddressApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOverrideReturnAddress**](OverrideReturnAddressApi.md#addoverridereturnaddress) | **POST** /v1.0/overrideReturnAddress | Create an overrideReturnAddress
[**DeleteOverrideReturnAddress**](OverrideReturnAddressApi.md#deleteoverridereturnaddress) | **DELETE** /v1.0/overrideReturnAddress/{overrideReturnAddressId} | Delete an overrideReturnAddress
[**GetOverrideReturnAddressByFilter**](OverrideReturnAddressApi.md#getoverridereturnaddressbyfilter) | **GET** /v1.0/overrideReturnAddress/search | Search overrideReturnAddresses by filter
[**GetOverrideReturnAddressById**](OverrideReturnAddressApi.md#getoverridereturnaddressbyid) | **GET** /v1.0/overrideReturnAddress/{overrideReturnAddressId} | Get an overrideReturnAddress by id
[**UpdateOverrideReturnAddress**](OverrideReturnAddressApi.md#updateoverridereturnaddress) | **PUT** /v1.0/overrideReturnAddress | Update an overrideReturnAddress


# **AddOverrideReturnAddress**
> OverrideReturnAddress AddOverrideReturnAddress (OverrideReturnAddress body)

Create an overrideReturnAddress

Inserts a new overrideReturnAddress using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOverrideReturnAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OverrideReturnAddressApi();
            var body = new OverrideReturnAddress(); // OverrideReturnAddress | OverrideReturnAddress to be inserted.

            try
            {
                // Create an overrideReturnAddress
                OverrideReturnAddress result = apiInstance.AddOverrideReturnAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.AddOverrideReturnAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverrideReturnAddress**](OverrideReturnAddress.md)| OverrideReturnAddress to be inserted. | 

### Return type

[**OverrideReturnAddress**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteOverrideReturnAddress**
> void DeleteOverrideReturnAddress (int? overrideReturnAddressId)

Delete an overrideReturnAddress

Deletes the overrideReturnAddress identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOverrideReturnAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to be deleted.

            try
            {
                // Delete an overrideReturnAddress
                apiInstance.DeleteOverrideReturnAddress(overrideReturnAddressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.DeleteOverrideReturnAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetOverrideReturnAddressByFilter**
> List<OverrideReturnAddress> GetOverrideReturnAddressByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search overrideReturnAddresses by filter

Returns the list of overrideReturnAddresses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOverrideReturnAddressByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OverrideReturnAddressApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search overrideReturnAddresses by filter
                List&lt;OverrideReturnAddress&gt; result = apiInstance.GetOverrideReturnAddressByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetOverrideReturnAddressByFilter: " + e.Message );
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

[**List<OverrideReturnAddress>**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetOverrideReturnAddressById**
> OverrideReturnAddress GetOverrideReturnAddressById (int? overrideReturnAddressId)

Get an overrideReturnAddress by id

Returns the overrideReturnAddress identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOverrideReturnAddressByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to be returned.

            try
            {
                // Get an overrideReturnAddress by id
                OverrideReturnAddress result = apiInstance.GetOverrideReturnAddressById(overrideReturnAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetOverrideReturnAddressById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to be returned. | 

### Return type

[**OverrideReturnAddress**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateOverrideReturnAddress**
> void UpdateOverrideReturnAddress (OverrideReturnAddress body)

Update an overrideReturnAddress

Updates an existing overrideReturnAddress using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOverrideReturnAddressExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new OverrideReturnAddressApi();
            var body = new OverrideReturnAddress(); // OverrideReturnAddress | OverrideReturnAddress to be updated.

            try
            {
                // Update an overrideReturnAddress
                apiInstance.UpdateOverrideReturnAddress(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.UpdateOverrideReturnAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverrideReturnAddress**](OverrideReturnAddress.md)| OverrideReturnAddress to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

