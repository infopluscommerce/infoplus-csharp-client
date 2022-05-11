# Infoplus.Api.PackingSlipTemplateLineItemDescriptionEnumApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPackingSlipTemplateLineItemDescriptionEnumById**](PackingSlipTemplateLineItemDescriptionEnumApi.md#getpackingsliptemplatelineitemdescriptionenumbyid) | **GET** /v3.0/packingSlipTemplateLineItemDescriptionEnum/{packingSlipTemplateLineItemDescriptionEnumId} | Get a packingSlipTemplateLineItemDescriptionEnum by id
[**GetPackingSlipTemplateLineItemDescriptionEnumBySearchText**](PackingSlipTemplateLineItemDescriptionEnumApi.md#getpackingsliptemplatelineitemdescriptionenumbysearchtext) | **GET** /v3.0/packingSlipTemplateLineItemDescriptionEnum/search | Search packingSlipTemplateLineItemDescriptionEnums


<a name="getpackingsliptemplatelineitemdescriptionenumbyid"></a>
# **GetPackingSlipTemplateLineItemDescriptionEnumById**
> PackingSlipTemplateLineItemDescriptionEnum GetPackingSlipTemplateLineItemDescriptionEnumById (string packingSlipTemplateLineItemDescriptionEnumId)

Get a packingSlipTemplateLineItemDescriptionEnum by id

Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingSlipTemplateLineItemDescriptionEnumByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingSlipTemplateLineItemDescriptionEnumApi();
            var packingSlipTemplateLineItemDescriptionEnumId = packingSlipTemplateLineItemDescriptionEnumId_example;  // string | Id of packingSlipTemplateLineItemDescriptionEnum to be returned.

            try
            {
                // Get a packingSlipTemplateLineItemDescriptionEnum by id
                PackingSlipTemplateLineItemDescriptionEnum result = apiInstance.GetPackingSlipTemplateLineItemDescriptionEnumById(packingSlipTemplateLineItemDescriptionEnumId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingSlipTemplateLineItemDescriptionEnumApi.GetPackingSlipTemplateLineItemDescriptionEnumById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingSlipTemplateLineItemDescriptionEnumId** | **string**| Id of packingSlipTemplateLineItemDescriptionEnum to be returned. | 

### Return type

[**PackingSlipTemplateLineItemDescriptionEnum**](PackingSlipTemplateLineItemDescriptionEnum.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingsliptemplatelineitemdescriptionenumbysearchtext"></a>
# **GetPackingSlipTemplateLineItemDescriptionEnumBySearchText**
> List<PackingSlipTemplateLineItemDescriptionEnum> GetPackingSlipTemplateLineItemDescriptionEnumBySearchText (string searchText = null, int? page = null, int? limit = null)

Search packingSlipTemplateLineItemDescriptionEnums

Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingSlipTemplateLineItemDescriptionEnumApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search packingSlipTemplateLineItemDescriptionEnums
                List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt; result = apiInstance.GetPackingSlipTemplateLineItemDescriptionEnumBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingSlipTemplateLineItemDescriptionEnumApi.GetPackingSlipTemplateLineItemDescriptionEnumBySearchText: " + e.Message );
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

[**List<PackingSlipTemplateLineItemDescriptionEnum>**](PackingSlipTemplateLineItemDescriptionEnum.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

