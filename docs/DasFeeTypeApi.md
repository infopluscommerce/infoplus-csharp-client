# Infoplus.Api.DasFeeTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDASFeeTypeById**](DasFeeTypeApi.md#getdasfeetypebyid) | **GET** /beta/dasFeeType/{dasFeeTypeId} | Get a dasFeeType by id
[**GetDasFeeTypeBySearchText**](DasFeeTypeApi.md#getdasfeetypebysearchtext) | **GET** /beta/dasFeeType/search | Search dasFeeTypes


<a name="getdasfeetypebyid"></a>
# **GetDASFeeTypeById**
> DasFeeType GetDASFeeTypeById (string dasFeeTypeId)

Get a dasFeeType by id

Returns the dasFeeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDASFeeTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeeTypeApi();
            var dasFeeTypeId = dasFeeTypeId_example;  // string | Id of dasFeeType to be returned.

            try
            {
                // Get a dasFeeType by id
                DasFeeType result = apiInstance.GetDASFeeTypeById(dasFeeTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeeTypeApi.GetDASFeeTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeeTypeId** | **string**| Id of dasFeeType to be returned. | 

### Return type

[**DasFeeType**](DasFeeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdasfeetypebysearchtext"></a>
# **GetDasFeeTypeBySearchText**
> List<DasFeeType> GetDasFeeTypeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search dasFeeTypes

Returns the list of dasFeeTypes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDasFeeTypeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeeTypeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search dasFeeTypes
                List&lt;DasFeeType&gt; result = apiInstance.GetDasFeeTypeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeeTypeApi.GetDasFeeTypeBySearchText: " + e.Message );
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

[**List<DasFeeType>**](DasFeeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

