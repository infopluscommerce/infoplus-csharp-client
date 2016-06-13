# Infoplus.Api.ItemLegacyLowStockContactApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemLegacyLowStockContactBySearchText**](ItemLegacyLowStockContactApi.md#getitemlegacylowstockcontactbysearchtext) | **GET** /v1.0/itemLegacyLowStockContact/search | Search itemLegacyLowStockContacts
[**GetTranslateLowStockContactById**](ItemLegacyLowStockContactApi.md#gettranslatelowstockcontactbyid) | **GET** /v1.0/itemLegacyLowStockContact/{itemLegacyLowStockContactId} | Get an itemLegacyLowStockContact by id


# **GetItemLegacyLowStockContactBySearchText**
> List<ItemLegacyLowStockContact> GetItemLegacyLowStockContactBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemLegacyLowStockContacts

Returns the list of itemLegacyLowStockContacts that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemLegacyLowStockContactBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ItemLegacyLowStockContactApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemLegacyLowStockContacts
                List&lt;ItemLegacyLowStockContact&gt; result = apiInstance.GetItemLegacyLowStockContactBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLegacyLowStockContactApi.GetItemLegacyLowStockContactBySearchText: " + e.Message );
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

[**List<ItemLegacyLowStockContact>**](ItemLegacyLowStockContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetTranslateLowStockContactById**
> ItemLegacyLowStockContact GetTranslateLowStockContactById (string itemLegacyLowStockContactId)

Get an itemLegacyLowStockContact by id

Returns the itemLegacyLowStockContact identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateLowStockContactByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ItemLegacyLowStockContactApi();
            var itemLegacyLowStockContactId = itemLegacyLowStockContactId_example;  // string | Id of itemLegacyLowStockContact to be returned.

            try
            {
                // Get an itemLegacyLowStockContact by id
                ItemLegacyLowStockContact result = apiInstance.GetTranslateLowStockContactById(itemLegacyLowStockContactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemLegacyLowStockContactApi.GetTranslateLowStockContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemLegacyLowStockContactId** | **string**| Id of itemLegacyLowStockContact to be returned. | 

### Return type

[**ItemLegacyLowStockContact**](ItemLegacyLowStockContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

