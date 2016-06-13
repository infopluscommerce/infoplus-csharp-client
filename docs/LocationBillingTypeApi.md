# Infoplus.Api.LocationBillingTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocationBillingType**](LocationBillingTypeApi.md#addlocationbillingtype) | **POST** /v1.0/locationBillingType | Create a locationBillingType
[**DeleteLocationBillingType**](LocationBillingTypeApi.md#deletelocationbillingtype) | **DELETE** /v1.0/locationBillingType/{locationBillingTypeId} | Delete a locationBillingType
[**GetLocationBillingTypeByFilter**](LocationBillingTypeApi.md#getlocationbillingtypebyfilter) | **GET** /v1.0/locationBillingType/search | Search locationBillingTypes by filter
[**GetLocationBillingTypeById**](LocationBillingTypeApi.md#getlocationbillingtypebyid) | **GET** /v1.0/locationBillingType/{locationBillingTypeId} | Get a locationBillingType by id
[**UpdateLocationBillingType**](LocationBillingTypeApi.md#updatelocationbillingtype) | **PUT** /v1.0/locationBillingType | Update a locationBillingType


# **AddLocationBillingType**
> LocationBillingType AddLocationBillingType (LocationBillingType body)

Create a locationBillingType

Inserts a new locationBillingType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationBillingTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationBillingTypeApi();
            var body = new LocationBillingType(); // LocationBillingType | LocationBillingType to be inserted.

            try
            {
                // Create a locationBillingType
                LocationBillingType result = apiInstance.AddLocationBillingType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.AddLocationBillingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationBillingType**](LocationBillingType.md)| LocationBillingType to be inserted. | 

### Return type

[**LocationBillingType**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteLocationBillingType**
> void DeleteLocationBillingType (int? locationBillingTypeId)

Delete a locationBillingType

Deletes the locationBillingType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationBillingTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to be deleted.

            try
            {
                // Delete a locationBillingType
                apiInstance.DeleteLocationBillingType(locationBillingTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.DeleteLocationBillingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetLocationBillingTypeByFilter**
> List<LocationBillingType> GetLocationBillingTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search locationBillingTypes by filter

Returns the list of locationBillingTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationBillingTypeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationBillingTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search locationBillingTypes by filter
                List&lt;LocationBillingType&gt; result = apiInstance.GetLocationBillingTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetLocationBillingTypeByFilter: " + e.Message );
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

[**List<LocationBillingType>**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetLocationBillingTypeById**
> LocationBillingType GetLocationBillingTypeById (int? locationBillingTypeId)

Get a locationBillingType by id

Returns the locationBillingType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationBillingTypeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to be returned.

            try
            {
                // Get a locationBillingType by id
                LocationBillingType result = apiInstance.GetLocationBillingTypeById(locationBillingTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetLocationBillingTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to be returned. | 

### Return type

[**LocationBillingType**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateLocationBillingType**
> void UpdateLocationBillingType (LocationBillingType body)

Update a locationBillingType

Updates an existing locationBillingType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationBillingTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new LocationBillingTypeApi();
            var body = new LocationBillingType(); // LocationBillingType | LocationBillingType to be updated.

            try
            {
                // Update a locationBillingType
                apiInstance.UpdateLocationBillingType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.UpdateLocationBillingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationBillingType**](LocationBillingType.md)| LocationBillingType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

