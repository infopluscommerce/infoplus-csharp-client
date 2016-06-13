# Infoplus.Api.ParcelShipmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetParcelShipmentByFilter**](ParcelShipmentApi.md#getparcelshipmentbyfilter) | **GET** /v1.0/parcelShipment/search | Search parcelShipments by filter
[**GetParcelShipmentById**](ParcelShipmentApi.md#getparcelshipmentbyid) | **GET** /v1.0/parcelShipment/{parcelShipmentId} | Get a parcelShipment by id


# **GetParcelShipmentByFilter**
> List<ParcelShipment> GetParcelShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search parcelShipments by filter

Returns the list of parcelShipments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelShipmentByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ParcelShipmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search parcelShipments by filter
                List&lt;ParcelShipment&gt; result = apiInstance.GetParcelShipmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelShipmentApi.GetParcelShipmentByFilter: " + e.Message );
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

[**List<ParcelShipment>**](ParcelShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetParcelShipmentById**
> ParcelShipment GetParcelShipmentById (int? parcelShipmentId)

Get a parcelShipment by id

Returns the parcelShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelShipmentByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ParcelShipmentApi();
            var parcelShipmentId = 56;  // int? | Id of the parcelShipment to be returned.

            try
            {
                // Get a parcelShipment by id
                ParcelShipment result = apiInstance.GetParcelShipmentById(parcelShipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelShipmentApi.GetParcelShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelShipmentId** | **int?**| Id of the parcelShipment to be returned. | 

### Return type

[**ParcelShipment**](ParcelShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

