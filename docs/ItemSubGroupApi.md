# Infoplus.Api.ItemSubGroupApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemSubGroupBySearchText**](ItemSubGroupApi.md#getitemsubgroupbysearchtext) | **GET** /beta/itemSubGroup/search | Search itemSubGroups
[**GetTranslateSubGroupById**](ItemSubGroupApi.md#gettranslatesubgroupbyid) | **GET** /beta/itemSubGroup/{itemSubGroupId} | Get an itemSubGroup by id


<a name="getitemsubgroupbysearchtext"></a>
# **GetItemSubGroupBySearchText**
> List<ItemSubGroup> GetItemSubGroupBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemSubGroups

Returns the list of itemSubGroups that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemSubGroupBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemSubGroupApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemSubGroups
                List&lt;ItemSubGroup&gt; result = apiInstance.GetItemSubGroupBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubGroupApi.GetItemSubGroupBySearchText: " + e.Message );
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

[**List<ItemSubGroup>**](ItemSubGroup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettranslatesubgroupbyid"></a>
# **GetTranslateSubGroupById**
> ItemSubGroup GetTranslateSubGroupById (string itemSubGroupId)

Get an itemSubGroup by id

Returns the itemSubGroup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateSubGroupByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemSubGroupApi();
            var itemSubGroupId = itemSubGroupId_example;  // string | Id of itemSubGroup to be returned.

            try
            {
                // Get an itemSubGroup by id
                ItemSubGroup result = apiInstance.GetTranslateSubGroupById(itemSubGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemSubGroupApi.GetTranslateSubGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemSubGroupId** | **string**| Id of itemSubGroup to be returned. | 

### Return type

[**ItemSubGroup**](ItemSubGroup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

