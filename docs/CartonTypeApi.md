# Infoplus.Api.CartonTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartonType**](CartonTypeApi.md#addcartontype) | **POST** /beta/cartonType | Create a cartonType
[**DeleteCartonType**](CartonTypeApi.md#deletecartontype) | **DELETE** /beta/cartonType/{cartonTypeId} | Delete a cartonType
[**GetCartonTypeByFilter**](CartonTypeApi.md#getcartontypebyfilter) | **GET** /beta/cartonType/search | Search cartonTypes by filter
[**GetCartonTypeById**](CartonTypeApi.md#getcartontypebyid) | **GET** /beta/cartonType/{cartonTypeId} | Get a cartonType by id
[**UpdateCartonType**](CartonTypeApi.md#updatecartontype) | **PUT** /beta/cartonType | Update a cartonType
[**UpdateCartonTypeCustomFields**](CartonTypeApi.md#updatecartontypecustomfields) | **PUT** /beta/cartonType/customFields | Update a cartonType custom fields


<a name="addcartontype"></a>
# **AddCartonType**
> CartonType AddCartonType (CartonType body)

Create a cartonType

Inserts a new cartonType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new CartonType(); // CartonType | CartonType to be inserted.

            try
            {
                // Create a cartonType
                CartonType result = apiInstance.AddCartonType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.AddCartonType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonType**](CartonType.md)| CartonType to be inserted. | 

### Return type

[**CartonType**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartontype"></a>
# **DeleteCartonType**
> void DeleteCartonType (int? cartonTypeId)

Delete a cartonType

Deletes the cartonType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to be deleted.

            try
            {
                // Delete a cartonType
                apiInstance.DeleteCartonType(cartonTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.DeleteCartonType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontypebyfilter"></a>
# **GetCartonTypeByFilter**
> List<CartonType> GetCartonTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartonTypes by filter

Returns the list of cartonTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTypeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartonTypes by filter
                List&lt;CartonType&gt; result = apiInstance.GetCartonTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetCartonTypeByFilter: " + e.Message );
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

[**List<CartonType>**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontypebyid"></a>
# **GetCartonTypeById**
> CartonType GetCartonTypeById (int? cartonTypeId)

Get a cartonType by id

Returns the cartonType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTypeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to be returned.

            try
            {
                // Get a cartonType by id
                CartonType result = apiInstance.GetCartonTypeById(cartonTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetCartonTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to be returned. | 

### Return type

[**CartonType**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartontype"></a>
# **UpdateCartonType**
> void UpdateCartonType (CartonType body)

Update a cartonType

Updates an existing cartonType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new CartonType(); // CartonType | CartonType to be updated.

            try
            {
                // Update a cartonType
                apiInstance.UpdateCartonType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.UpdateCartonType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonType**](CartonType.md)| CartonType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartontypecustomfields"></a>
# **UpdateCartonTypeCustomFields**
> void UpdateCartonTypeCustomFields (CartonType body)

Update a cartonType custom fields

Updates an existing cartonType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonTypeCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new CartonType(); // CartonType | CartonType to be updated.

            try
            {
                // Update a cartonType custom fields
                apiInstance.UpdateCartonTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.UpdateCartonTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonType**](CartonType.md)| CartonType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

