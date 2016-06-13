# Infoplus.Api.ItemLowStockCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemLowStockCodeBySearchText**](ItemLowStockCodeApi.md#getitemlowstockcodebysearchtext) | **GET** /v1.0/itemLowStockCode/search | Search itemLowStockCodes
[**GetTranslateLowStockCodeById**](ItemLowStockCodeApi.md#gettranslatelowstockcodebyid) | **GET** /v1.0/itemLowStockCode/{itemLowStockCodeId} | Get an itemLowStockCode by id


# **GetItemLowStockCodeBySearchText**
> List<ItemLowStockCode> GetItemLowStockCodeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemLowStockCodes

Returns the list of itemLowStockCodes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemLowStockCodeBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ItemLowStockCodeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemLowStockCodes
                List&lt;ItemLowStockCode&gt; result = apiInstance.GetItemLowStockCodeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowStockCodeApi.GetItemLowStockCodeBySearchText: " + e.Message );
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

[**List<ItemLowStockCode>**](ItemLowStockCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetTranslateLowStockCodeById**
> ItemLowStockCode GetTranslateLowStockCodeById (string itemLowStockCodeId)

Get an itemLowStockCode by id

Returns the itemLowStockCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateLowStockCodeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ItemLowStockCodeApi();
            var itemLowStockCodeId = itemLowStockCodeId_example;  // string | Id of itemLowStockCode to be returned.

            try
            {
                // Get an itemLowStockCode by id
                ItemLowStockCode result = apiInstance.GetTranslateLowStockCodeById(itemLowStockCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLowStockCodeApi.GetTranslateLowStockCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLowStockCodeId** | **string**| Id of itemLowStockCode to be returned. | 

### Return type

[**ItemLowStockCode**](ItemLowStockCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

