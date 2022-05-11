# Infoplus.Api.ItemActivityTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemActivityTypeById**](ItemActivityTypeApi.md#getitemactivitytypebyid) | **GET** /v3.0/itemActivityType/{itemActivityTypeId} | Get an itemActivityType by id
[**GetItemActivityTypeBySearchText**](ItemActivityTypeApi.md#getitemactivitytypebysearchtext) | **GET** /v3.0/itemActivityType/search | Search itemActivityTypes


<a name="getitemactivitytypebyid"></a>
# **GetItemActivityTypeById**
> ItemActivityType GetItemActivityTypeById (string itemActivityTypeId)

Get an itemActivityType by id

Returns the itemActivityType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemActivityTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityTypeApi();
            var itemActivityTypeId = itemActivityTypeId_example;  // string | Id of itemActivityType to be returned.

            try
            {
                // Get an itemActivityType by id
                ItemActivityType result = apiInstance.GetItemActivityTypeById(itemActivityTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityTypeApi.GetItemActivityTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemActivityTypeId** | **string**| Id of itemActivityType to be returned. | 

### Return type

[**ItemActivityType**](ItemActivityType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemactivitytypebysearchtext"></a>
# **GetItemActivityTypeBySearchText**
> List<ItemActivityType> GetItemActivityTypeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search itemActivityTypes

Returns the list of itemActivityTypes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemActivityTypeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemActivityTypeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search itemActivityTypes
                List&lt;ItemActivityType&gt; result = apiInstance.GetItemActivityTypeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemActivityTypeApi.GetItemActivityTypeBySearchText: " + e.Message );
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

[**List<ItemActivityType>**](ItemActivityType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

