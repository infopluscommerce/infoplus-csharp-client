# Infoplus.Api.IntegrationPartnerApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIntegrationPartnerById**](IntegrationPartnerApi.md#getintegrationpartnerbyid) | **GET** /beta/integrationPartner/{integrationPartnerId} | Get an integrationPartner by id
[**GetIntegrationPartnerBySearchText**](IntegrationPartnerApi.md#getintegrationpartnerbysearchtext) | **GET** /beta/integrationPartner/search | Search integrationPartners


<a name="getintegrationpartnerbyid"></a>
# **GetIntegrationPartnerById**
> IntegrationPartner GetIntegrationPartnerById (string integrationPartnerId)

Get an integrationPartner by id

Returns the integrationPartner identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetIntegrationPartnerByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new IntegrationPartnerApi();
            var integrationPartnerId = integrationPartnerId_example;  // string | Id of integrationPartner to be returned.

            try
            {
                // Get an integrationPartner by id
                IntegrationPartner result = apiInstance.GetIntegrationPartnerById(integrationPartnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationPartnerApi.GetIntegrationPartnerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationPartnerId** | **string**| Id of integrationPartner to be returned. | 

### Return type

[**IntegrationPartner**](IntegrationPartner.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationpartnerbysearchtext"></a>
# **GetIntegrationPartnerBySearchText**
> List<IntegrationPartner> GetIntegrationPartnerBySearchText (string searchText = null, int? page = null, int? limit = null)

Search integrationPartners

Returns the list of integrationPartners that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetIntegrationPartnerBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new IntegrationPartnerApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search integrationPartners
                List&lt;IntegrationPartner&gt; result = apiInstance.GetIntegrationPartnerBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationPartnerApi.GetIntegrationPartnerBySearchText: " + e.Message );
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

[**List<IntegrationPartner>**](IntegrationPartner.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

