# Infoplus.Api.ItemSummaryCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemSummaryCodeBySearchText**](ItemSummaryCodeApi.md#getitemsummarycodebysearchtext) | **GET** /beta/itemSummaryCode/search | Search itemSummaryCodes
[**GetTranslateSummaryCodeById**](ItemSummaryCodeApi.md#gettranslatesummarycodebyid) | **GET** /beta/itemSummaryCode/{itemSummaryCodeId} | Get an itemSummaryCode by id


<a name="getitemsummarycodebysearchtext"></a>
# **GetItemSummaryCodeBySearchText**
> List<ItemSummaryCode> GetItemSummaryCodeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemSummaryCodes

Returns the list of itemSummaryCodes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSummaryCodeBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemSummaryCodes
                List&lt;ItemSummaryCode&gt; result = apiInstance.GetItemSummaryCodeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.GetItemSummaryCodeBySearchText: " + e.Message );
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

[**List<ItemSummaryCode>**](ItemSummaryCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettranslatesummarycodebyid"></a>
# **GetTranslateSummaryCodeById**
> ItemSummaryCode GetTranslateSummaryCodeById (string itemSummaryCodeId)

Get an itemSummaryCode by id

Returns the itemSummaryCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateSummaryCodeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemSummaryCodeApi();
            var itemSummaryCodeId = itemSummaryCodeId_example;  // string | Id of itemSummaryCode to be returned.

            try
            {
                // Get an itemSummaryCode by id
                ItemSummaryCode result = apiInstance.GetTranslateSummaryCodeById(itemSummaryCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSummaryCodeApi.GetTranslateSummaryCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSummaryCodeId** | **string**| Id of itemSummaryCode to be returned. | 

### Return type

[**ItemSummaryCode**](ItemSummaryCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

