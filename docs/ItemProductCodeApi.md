# Infoplus.Api.ItemProductCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemProductCodeBySearchText**](ItemProductCodeApi.md#getitemproductcodebysearchtext) | **GET** /beta/itemProductCode/search | Search itemProductCodes
[**GetTranslateProductCodeById**](ItemProductCodeApi.md#gettranslateproductcodebyid) | **GET** /beta/itemProductCode/{itemProductCodeId} | Get an itemProductCode by id


<a name="getitemproductcodebysearchtext"></a>
# **GetItemProductCodeBySearchText**
> List<ItemProductCode> GetItemProductCodeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemProductCodes

Returns the list of itemProductCodes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemProductCodeBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemProductCodes
                List&lt;ItemProductCode&gt; result = apiInstance.GetItemProductCodeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.GetItemProductCodeBySearchText: " + e.Message );
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

[**List<ItemProductCode>**](ItemProductCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettranslateproductcodebyid"></a>
# **GetTranslateProductCodeById**
> ItemProductCode GetTranslateProductCodeById (string itemProductCodeId)

Get an itemProductCode by id

Returns the itemProductCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateProductCodeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemProductCodeApi();
            var itemProductCodeId = itemProductCodeId_example;  // string | Id of itemProductCode to be returned.

            try
            {
                // Get an itemProductCode by id
                ItemProductCode result = apiInstance.GetTranslateProductCodeById(itemProductCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemProductCodeApi.GetTranslateProductCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemProductCodeId** | **string**| Id of itemProductCode to be returned. | 

### Return type

[**ItemProductCode**](ItemProductCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

