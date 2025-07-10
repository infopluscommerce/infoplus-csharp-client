# Infoplus.Api.PredefinedCartonApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPredefinedCartonById**](PredefinedCartonApi.md#getpredefinedcartonbyid) | **GET** /beta/predefinedCarton/{predefinedCartonId} | Get a predefinedCarton by id
[**GetPredefinedCartonBySearchText**](PredefinedCartonApi.md#getpredefinedcartonbysearchtext) | **GET** /beta/predefinedCarton/search | Search predefinedCartons


<a name="getpredefinedcartonbyid"></a>
# **GetPredefinedCartonById**
> PredefinedCarton GetPredefinedCartonById (string predefinedCartonId)

Get a predefinedCarton by id

Returns the predefinedCarton identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPredefinedCartonByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PredefinedCartonApi();
            var predefinedCartonId = predefinedCartonId_example;  // string | Id of predefinedCarton to be returned.

            try
            {
                // Get a predefinedCarton by id
                PredefinedCarton result = apiInstance.GetPredefinedCartonById(predefinedCartonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedCartonApi.GetPredefinedCartonById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedCartonId** | **string**| Id of predefinedCarton to be returned. | 

### Return type

[**PredefinedCarton**](PredefinedCarton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpredefinedcartonbysearchtext"></a>
# **GetPredefinedCartonBySearchText**
> List<PredefinedCarton> GetPredefinedCartonBySearchText (string searchText = null, int? page = null, int? limit = null)

Search predefinedCartons

Returns the list of predefinedCartons that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPredefinedCartonBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PredefinedCartonApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search predefinedCartons
                List&lt;PredefinedCarton&gt; result = apiInstance.GetPredefinedCartonBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedCartonApi.GetPredefinedCartonBySearchText: " + e.Message );
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

[**List<PredefinedCarton>**](PredefinedCarton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

