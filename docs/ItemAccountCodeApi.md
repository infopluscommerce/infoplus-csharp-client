# Infoplus.Api.ItemAccountCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemAccountCodeBySearchText**](ItemAccountCodeApi.md#getitemaccountcodebysearchtext) | **GET** /beta/itemAccountCode/search | Search itemAccountCodes
[**GetTranslateAccountCodeById**](ItemAccountCodeApi.md#gettranslateaccountcodebyid) | **GET** /beta/itemAccountCode/{itemAccountCodeId} | Get an itemAccountCode by id


<a name="getitemaccountcodebysearchtext"></a>
# **GetItemAccountCodeBySearchText**
> List<ItemAccountCode> GetItemAccountCodeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemAccountCodes

Returns the list of itemAccountCodes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemAccountCodeBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemAccountCodes
                List&lt;ItemAccountCode&gt; result = apiInstance.GetItemAccountCodeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.GetItemAccountCodeBySearchText: " + e.Message );
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

[**List<ItemAccountCode>**](ItemAccountCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettranslateaccountcodebyid"></a>
# **GetTranslateAccountCodeById**
> ItemAccountCode GetTranslateAccountCodeById (string itemAccountCodeId)

Get an itemAccountCode by id

Returns the itemAccountCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateAccountCodeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemAccountCodeApi();
            var itemAccountCodeId = itemAccountCodeId_example;  // string | Id of itemAccountCode to be returned.

            try
            {
                // Get an itemAccountCode by id
                ItemAccountCode result = apiInstance.GetTranslateAccountCodeById(itemAccountCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemAccountCodeApi.GetTranslateAccountCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemAccountCodeId** | **string**| Id of itemAccountCode to be returned. | 

### Return type

[**ItemAccountCode**](ItemAccountCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

