# Infoplus.Api.PackingSlipTemplateLineExtraDataEnumApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPackingSlipTemplateLineExtraDataEnumById**](PackingSlipTemplateLineExtraDataEnumApi.md#getpackingsliptemplatelineextradataenumbyid) | **GET** /v3.0/packingSlipTemplateLineExtraDataEnum/{packingSlipTemplateLineExtraDataEnumId} | Get a packingSlipTemplateLineExtraDataEnum by id
[**GetPackingSlipTemplateLineExtraDataEnumBySearchText**](PackingSlipTemplateLineExtraDataEnumApi.md#getpackingsliptemplatelineextradataenumbysearchtext) | **GET** /v3.0/packingSlipTemplateLineExtraDataEnum/search | Search packingSlipTemplateLineExtraDataEnums


<a name="getpackingsliptemplatelineextradataenumbyid"></a>
# **GetPackingSlipTemplateLineExtraDataEnumById**
> PackingSlipTemplateLineExtraDataEnum GetPackingSlipTemplateLineExtraDataEnumById (string packingSlipTemplateLineExtraDataEnumId)

Get a packingSlipTemplateLineExtraDataEnum by id

Returns the packingSlipTemplateLineExtraDataEnum identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingSlipTemplateLineExtraDataEnumByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingSlipTemplateLineExtraDataEnumApi();
            var packingSlipTemplateLineExtraDataEnumId = packingSlipTemplateLineExtraDataEnumId_example;  // string | Id of packingSlipTemplateLineExtraDataEnum to be returned.

            try
            {
                // Get a packingSlipTemplateLineExtraDataEnum by id
                PackingSlipTemplateLineExtraDataEnum result = apiInstance.GetPackingSlipTemplateLineExtraDataEnumById(packingSlipTemplateLineExtraDataEnumId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingSlipTemplateLineExtraDataEnumApi.GetPackingSlipTemplateLineExtraDataEnumById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingSlipTemplateLineExtraDataEnumId** | **string**| Id of packingSlipTemplateLineExtraDataEnum to be returned. | 

### Return type

[**PackingSlipTemplateLineExtraDataEnum**](PackingSlipTemplateLineExtraDataEnum.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingsliptemplatelineextradataenumbysearchtext"></a>
# **GetPackingSlipTemplateLineExtraDataEnumBySearchText**
> List<PackingSlipTemplateLineExtraDataEnum> GetPackingSlipTemplateLineExtraDataEnumBySearchText (string searchText = null, int? page = null, int? limit = null)

Search packingSlipTemplateLineExtraDataEnums

Returns the list of packingSlipTemplateLineExtraDataEnums that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingSlipTemplateLineExtraDataEnumBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingSlipTemplateLineExtraDataEnumApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search packingSlipTemplateLineExtraDataEnums
                List&lt;PackingSlipTemplateLineExtraDataEnum&gt; result = apiInstance.GetPackingSlipTemplateLineExtraDataEnumBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingSlipTemplateLineExtraDataEnumApi.GetPackingSlipTemplateLineExtraDataEnumBySearchText: " + e.Message );
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

[**List<PackingSlipTemplateLineExtraDataEnum>**](PackingSlipTemplateLineExtraDataEnum.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

