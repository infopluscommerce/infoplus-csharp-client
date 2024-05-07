# Infoplus.Api.UspsHazmatTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUSPSHazmatTypeById**](UspsHazmatTypeApi.md#getuspshazmattypebyid) | **GET** /beta/uspsHazmatType/{uspsHazmatTypeId} | Get an uspsHazmatType by id
[**GetUspsHazmatTypeBySearchText**](UspsHazmatTypeApi.md#getuspshazmattypebysearchtext) | **GET** /beta/uspsHazmatType/search | Search uspsHazmatTypes


<a name="getuspshazmattypebyid"></a>
# **GetUSPSHazmatTypeById**
> UspsHazmatType GetUSPSHazmatTypeById (string uspsHazmatTypeId)

Get an uspsHazmatType by id

Returns the uspsHazmatType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetUSPSHazmatTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new UspsHazmatTypeApi();
            var uspsHazmatTypeId = uspsHazmatTypeId_example;  // string | Id of uspsHazmatType to be returned.

            try
            {
                // Get an uspsHazmatType by id
                UspsHazmatType result = apiInstance.GetUSPSHazmatTypeById(uspsHazmatTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UspsHazmatTypeApi.GetUSPSHazmatTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uspsHazmatTypeId** | **string**| Id of uspsHazmatType to be returned. | 

### Return type

[**UspsHazmatType**](UspsHazmatType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuspshazmattypebysearchtext"></a>
# **GetUspsHazmatTypeBySearchText**
> List<UspsHazmatType> GetUspsHazmatTypeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search uspsHazmatTypes

Returns the list of uspsHazmatTypes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetUspsHazmatTypeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new UspsHazmatTypeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search uspsHazmatTypes
                List&lt;UspsHazmatType&gt; result = apiInstance.GetUspsHazmatTypeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UspsHazmatTypeApi.GetUspsHazmatTypeBySearchText: " + e.Message );
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

[**List<UspsHazmatType>**](UspsHazmatType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

