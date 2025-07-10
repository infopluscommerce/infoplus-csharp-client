# Infoplus.Api.EDIDocumentTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEDIDocumentTypeById**](EDIDocumentTypeApi.md#getedidocumenttypebyid) | **GET** /beta/eDIDocumentType/{eDIDocumentTypeId} | Get an eDIDocumentType by id
[**GetEDIDocumentTypeBySearchText**](EDIDocumentTypeApi.md#getedidocumenttypebysearchtext) | **GET** /beta/eDIDocumentType/search | Search eDIDocumentTypes


<a name="getedidocumenttypebyid"></a>
# **GetEDIDocumentTypeById**
> EDIDocumentType GetEDIDocumentTypeById (string eDIDocumentTypeId)

Get an eDIDocumentType by id

Returns the eDIDocumentType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEDIDocumentTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EDIDocumentTypeApi();
            var eDIDocumentTypeId = eDIDocumentTypeId_example;  // string | Id of eDIDocumentType to be returned.

            try
            {
                // Get an eDIDocumentType by id
                EDIDocumentType result = apiInstance.GetEDIDocumentTypeById(eDIDocumentTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EDIDocumentTypeApi.GetEDIDocumentTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eDIDocumentTypeId** | **string**| Id of eDIDocumentType to be returned. | 

### Return type

[**EDIDocumentType**](EDIDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getedidocumenttypebysearchtext"></a>
# **GetEDIDocumentTypeBySearchText**
> List<EDIDocumentType> GetEDIDocumentTypeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search eDIDocumentTypes

Returns the list of eDIDocumentTypes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEDIDocumentTypeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EDIDocumentTypeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search eDIDocumentTypes
                List&lt;EDIDocumentType&gt; result = apiInstance.GetEDIDocumentTypeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EDIDocumentTypeApi.GetEDIDocumentTypeBySearchText: " + e.Message );
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

[**List<EDIDocumentType>**](EDIDocumentType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

