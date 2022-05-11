# Infoplus.Api.LoggedTimeTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoggedTimeTypeById**](LoggedTimeTypeApi.md#getloggedtimetypebyid) | **GET** /v3.0/loggedTimeType/{loggedTimeTypeId} | Get a loggedTimeType by id
[**GetLoggedTimeTypeBySearchText**](LoggedTimeTypeApi.md#getloggedtimetypebysearchtext) | **GET** /v3.0/loggedTimeType/search | Search loggedTimeTypes


<a name="getloggedtimetypebyid"></a>
# **GetLoggedTimeTypeById**
> LoggedTimeType GetLoggedTimeTypeById (string loggedTimeTypeId)

Get a loggedTimeType by id

Returns the loggedTimeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoggedTimeTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeTypeApi();
            var loggedTimeTypeId = loggedTimeTypeId_example;  // string | Id of loggedTimeType to be returned.

            try
            {
                // Get a loggedTimeType by id
                LoggedTimeType result = apiInstance.GetLoggedTimeTypeById(loggedTimeTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeTypeApi.GetLoggedTimeTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedTimeTypeId** | **string**| Id of loggedTimeType to be returned. | 

### Return type

[**LoggedTimeType**](LoggedTimeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloggedtimetypebysearchtext"></a>
# **GetLoggedTimeTypeBySearchText**
> List<LoggedTimeType> GetLoggedTimeTypeBySearchText (string searchText = null, int? page = null, int? limit = null)

Search loggedTimeTypes

Returns the list of loggedTimeTypes that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoggedTimeTypeBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoggedTimeTypeApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search loggedTimeTypes
                List&lt;LoggedTimeType&gt; result = apiInstance.GetLoggedTimeTypeBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggedTimeTypeApi.GetLoggedTimeTypeBySearchText: " + e.Message );
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

[**List<LoggedTimeType>**](LoggedTimeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

