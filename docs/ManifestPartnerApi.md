# Infoplus.Api.ManifestPartnerApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetManifestPartnerBySearchText**](ManifestPartnerApi.md#getmanifestpartnerbysearchtext) | **GET** /beta/manifestPartner/search | Search manifestPartners
[**GetManifestSolutionProviderById**](ManifestPartnerApi.md#getmanifestsolutionproviderbyid) | **GET** /beta/manifestPartner/{manifestPartnerId} | Get a manifestPartner by id


<a name="getmanifestpartnerbysearchtext"></a>
# **GetManifestPartnerBySearchText**
> List<ManifestPartner> GetManifestPartnerBySearchText (string searchText = null, int? page = null, int? limit = null)

Search manifestPartners

Returns the list of manifestPartners that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetManifestPartnerBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManifestPartnerApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search manifestPartners
                List&lt;ManifestPartner&gt; result = apiInstance.GetManifestPartnerBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManifestPartnerApi.GetManifestPartnerBySearchText: " + e.Message );
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

[**List<ManifestPartner>**](ManifestPartner.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanifestsolutionproviderbyid"></a>
# **GetManifestSolutionProviderById**
> ManifestPartner GetManifestSolutionProviderById (string manifestPartnerId)

Get a manifestPartner by id

Returns the manifestPartner identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetManifestSolutionProviderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManifestPartnerApi();
            var manifestPartnerId = manifestPartnerId_example;  // string | Id of manifestPartner to be returned.

            try
            {
                // Get a manifestPartner by id
                ManifestPartner result = apiInstance.GetManifestSolutionProviderById(manifestPartnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManifestPartnerApi.GetManifestSolutionProviderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manifestPartnerId** | **string**| Id of manifestPartner to be returned. | 

### Return type

[**ManifestPartner**](ManifestPartner.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

