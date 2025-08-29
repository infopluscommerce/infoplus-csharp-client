# Infoplus.Api.CarrierCompanyCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCarrierCompanyCodeById**](CarrierCompanyCodeApi.md#getcarriercompanycodebyid) | **GET** /beta/carrierCompanyCode/{carrierCompanyCodeId} | Get a carrierCompanyCode by id
[**GetCarrierCompanyCodeBySearchText**](CarrierCompanyCodeApi.md#getcarriercompanycodebysearchtext) | **GET** /beta/carrierCompanyCode/search | Search carrierCompanyCodes


<a name="getcarriercompanycodebyid"></a>
# **GetCarrierCompanyCodeById**
> CarrierCompanyCode GetCarrierCompanyCodeById (string carrierCompanyCodeId)

Get a carrierCompanyCode by id

Returns the carrierCompanyCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCarrierCompanyCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CarrierCompanyCodeApi();
            var carrierCompanyCodeId = carrierCompanyCodeId_example;  // string | Id of carrierCompanyCode to be returned.

            try
            {
                // Get a carrierCompanyCode by id
                CarrierCompanyCode result = apiInstance.GetCarrierCompanyCodeById(carrierCompanyCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierCompanyCodeApi.GetCarrierCompanyCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierCompanyCodeId** | **string**| Id of carrierCompanyCode to be returned. | 

### Return type

[**CarrierCompanyCode**](CarrierCompanyCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarriercompanycodebysearchtext"></a>
# **GetCarrierCompanyCodeBySearchText**
> List<CarrierCompanyCode> GetCarrierCompanyCodeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search carrierCompanyCodes

Returns the list of carrierCompanyCodes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCarrierCompanyCodeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CarrierCompanyCodeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search carrierCompanyCodes
                List&lt;CarrierCompanyCode&gt; result = apiInstance.GetCarrierCompanyCodeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierCompanyCodeApi.GetCarrierCompanyCodeBySearchText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchText** | **string**| Search text, used to filter results. | [optional] 
 **page** | **int?**| Result page number.  Defaults to 1. | [optional] 
 **limit** | **int?**| Maximum results per page.  Defaults to 20.  Max allowed value is 250. | [optional] 

### Return type

[**List<CarrierCompanyCode>**](CarrierCompanyCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

