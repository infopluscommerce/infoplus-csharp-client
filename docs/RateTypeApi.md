# Infoplus.Api.RateTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRateTypeById**](RateTypeApi.md#getratetypebyid) | **GET** /beta/rateType/{rateTypeId} | Get a rateType by id
[**GetRateTypeBySearchText**](RateTypeApi.md#getratetypebysearchtext) | **GET** /beta/rateType/search | Search rateTypes


<a name="getratetypebyid"></a>
# **GetRateTypeById**
> RateType GetRateTypeById (string rateTypeId)

Get a rateType by id

Returns the rateType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetRateTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateTypeApi();
            var rateTypeId = rateTypeId_example;  // string | Id of rateType to be returned.

            try
            {
                // Get a rateType by id
                RateType result = apiInstance.GetRateTypeById(rateTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateTypeApi.GetRateTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateTypeId** | **string**| Id of rateType to be returned. | 

### Return type

[**RateType**](RateType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratetypebysearchtext"></a>
# **GetRateTypeBySearchText**
> List<RateType> GetRateTypeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search rateTypes

Returns the list of rateTypes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetRateTypeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateTypeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search rateTypes
                List&lt;RateType&gt; result = apiInstance.GetRateTypeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateTypeApi.GetRateTypeBySearchText: " + e.Message );
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

[**List<RateType>**](RateType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

