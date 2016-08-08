# Infoplus.Api.OrderLoadProgramApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderLoadProgramBySearchText**](OrderLoadProgramApi.md#getorderloadprogrambysearchtext) | **GET** /beta/orderLoadProgram/search | Search orderLoadPrograms
[**GetReqLoadProgramById**](OrderLoadProgramApi.md#getreqloadprogrambyid) | **GET** /beta/orderLoadProgram/{orderLoadProgramId} | Get an orderLoadProgram by id


<a name="getorderloadprogrambysearchtext"></a>
# **GetOrderLoadProgramBySearchText**
> List<OrderLoadProgram> GetOrderLoadProgramBySearchText (string searchText = null, int? page = null, int? limit = null)

Search orderLoadPrograms

Returns the list of orderLoadPrograms that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLoadProgramBySearchTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new OrderLoadProgramApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search orderLoadPrograms
                List&lt;OrderLoadProgram&gt; result = apiInstance.GetOrderLoadProgramBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLoadProgramApi.GetOrderLoadProgramBySearchText: " + e.Message );
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

[**List<OrderLoadProgram>**](OrderLoadProgram.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreqloadprogrambyid"></a>
# **GetReqLoadProgramById**
> OrderLoadProgram GetReqLoadProgramById (string orderLoadProgramId)

Get an orderLoadProgram by id

Returns the orderLoadProgram identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReqLoadProgramByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new OrderLoadProgramApi();
            var orderLoadProgramId = orderLoadProgramId_example;  // string | Id of orderLoadProgram to be returned.

            try
            {
                // Get an orderLoadProgram by id
                OrderLoadProgram result = apiInstance.GetReqLoadProgramById(orderLoadProgramId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLoadProgramApi.GetReqLoadProgramById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLoadProgramId** | **string**| Id of orderLoadProgram to be returned. | 

### Return type

[**OrderLoadProgram**](OrderLoadProgram.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

