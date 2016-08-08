# Infoplus.Api.CartonApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCarton**](CartonApi.md#addcarton) | **POST** /beta/carton | Create a carton
[**DeleteCarton**](CartonApi.md#deletecarton) | **DELETE** /beta/carton/{cartonId} | Delete a carton
[**GetCartonByFilter**](CartonApi.md#getcartonbyfilter) | **GET** /beta/carton/search | Search cartons by filter
[**GetCartonById**](CartonApi.md#getcartonbyid) | **GET** /beta/carton/{cartonId} | Get a carton by id
[**UpdateCarton**](CartonApi.md#updatecarton) | **PUT** /beta/carton | Update a carton
[**UpdateCartonCustomFields**](CartonApi.md#updatecartoncustomfields) | **PUT** /beta/carton/customFields | Update a carton custom fields


<a name="addcarton"></a>
# **AddCarton**
> Carton AddCarton (Carton body)

Create a carton

Inserts a new carton using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new Carton(); // Carton | Carton to be inserted.

            try
            {
                // Create a carton
                Carton result = apiInstance.AddCarton(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.AddCarton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Carton**](Carton.md)| Carton to be inserted. | 

### Return type

[**Carton**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecarton"></a>
# **DeleteCarton**
> void DeleteCarton (int? cartonId)

Delete a carton

Deletes the carton identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to be deleted.

            try
            {
                // Delete a carton
                apiInstance.DeleteCarton(cartonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.DeleteCarton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonbyfilter"></a>
# **GetCartonByFilter**
> List<Carton> GetCartonByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartons by filter

Returns the list of cartons that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartons by filter
                List&lt;Carton&gt; result = apiInstance.GetCartonByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetCartonByFilter: " + e.Message );
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

[**List<Carton>**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonbyid"></a>
# **GetCartonById**
> Carton GetCartonById (int? cartonId)

Get a carton by id

Returns the carton identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to be returned.

            try
            {
                // Get a carton by id
                Carton result = apiInstance.GetCartonById(cartonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetCartonById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to be returned. | 

### Return type

[**Carton**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecarton"></a>
# **UpdateCarton**
> void UpdateCarton (Carton body)

Update a carton

Updates an existing carton using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new Carton(); // Carton | Carton to be updated.

            try
            {
                // Update a carton
                apiInstance.UpdateCarton(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.UpdateCarton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Carton**](Carton.md)| Carton to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartoncustomfields"></a>
# **UpdateCartonCustomFields**
> void UpdateCartonCustomFields (Carton body)

Update a carton custom fields

Updates an existing carton custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new Carton(); // Carton | Carton to be updated.

            try
            {
                // Update a carton custom fields
                apiInstance.UpdateCartonCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.UpdateCartonCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Carton**](Carton.md)| Carton to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

