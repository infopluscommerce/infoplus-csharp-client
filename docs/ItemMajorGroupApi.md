# Infoplus.Api.ItemMajorGroupApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemMajorGroupBySearchText**](ItemMajorGroupApi.md#getitemmajorgroupbysearchtext) | **GET** /beta/itemMajorGroup/search | Search itemMajorGroups
[**GetTranslateMajorGroupById**](ItemMajorGroupApi.md#gettranslatemajorgroupbyid) | **GET** /beta/itemMajorGroup/{itemMajorGroupId} | Get an itemMajorGroup by id


<a name="getitemmajorgroupbysearchtext"></a>
# **GetItemMajorGroupBySearchText**
> List<ItemMajorGroup> GetItemMajorGroupBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemMajorGroups

Returns the list of itemMajorGroups that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemMajorGroupBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemMajorGroupApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemMajorGroups
                List&lt;ItemMajorGroup&gt; result = apiInstance.GetItemMajorGroupBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemMajorGroupApi.GetItemMajorGroupBySearchText: " + e.Message );
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

[**List<ItemMajorGroup>**](ItemMajorGroup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettranslatemajorgroupbyid"></a>
# **GetTranslateMajorGroupById**
> ItemMajorGroup GetTranslateMajorGroupById (string itemMajorGroupId)

Get an itemMajorGroup by id

Returns the itemMajorGroup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetTranslateMajorGroupByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemMajorGroupApi();
            var itemMajorGroupId = itemMajorGroupId_example;  // string | Id of itemMajorGroup to be returned.

            try
            {
                // Get an itemMajorGroup by id
                ItemMajorGroup result = apiInstance.GetTranslateMajorGroupById(itemMajorGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemMajorGroupApi.GetTranslateMajorGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemMajorGroupId** | **string**| Id of itemMajorGroup to be returned. | 

### Return type

[**ItemMajorGroup**](ItemMajorGroup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

