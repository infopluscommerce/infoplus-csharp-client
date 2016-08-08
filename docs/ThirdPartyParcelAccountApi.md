# Infoplus.Api.ThirdPartyParcelAccountApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddThirdPartyParcelAccount**](ThirdPartyParcelAccountApi.md#addthirdpartyparcelaccount) | **POST** /beta/thirdPartyParcelAccount | Create a thirdPartyParcelAccount
[**DeleteThirdPartyParcelAccount**](ThirdPartyParcelAccountApi.md#deletethirdpartyparcelaccount) | **DELETE** /beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId} | Delete a thirdPartyParcelAccount
[**GetThirdPartyParcelAccountByFilter**](ThirdPartyParcelAccountApi.md#getthirdpartyparcelaccountbyfilter) | **GET** /beta/thirdPartyParcelAccount/search | Search thirdPartyParcelAccounts by filter
[**GetThirdPartyParcelAccountById**](ThirdPartyParcelAccountApi.md#getthirdpartyparcelaccountbyid) | **GET** /beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId} | Get a thirdPartyParcelAccount by id
[**UpdateThirdPartyParcelAccount**](ThirdPartyParcelAccountApi.md#updatethirdpartyparcelaccount) | **PUT** /beta/thirdPartyParcelAccount | Update a thirdPartyParcelAccount
[**UpdateThirdPartyParcelAccountCustomFields**](ThirdPartyParcelAccountApi.md#updatethirdpartyparcelaccountcustomfields) | **PUT** /beta/thirdPartyParcelAccount/customFields | Update a thirdPartyParcelAccount custom fields


<a name="addthirdpartyparcelaccount"></a>
# **AddThirdPartyParcelAccount**
> ThirdPartyParcelAccount AddThirdPartyParcelAccount (ThirdPartyParcelAccount body)

Create a thirdPartyParcelAccount

Inserts a new thirdPartyParcelAccount using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddThirdPartyParcelAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ThirdPartyParcelAccountApi();
            var body = new ThirdPartyParcelAccount(); // ThirdPartyParcelAccount | ThirdPartyParcelAccount to be inserted.

            try
            {
                // Create a thirdPartyParcelAccount
                ThirdPartyParcelAccount result = apiInstance.AddThirdPartyParcelAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThirdPartyParcelAccountApi.AddThirdPartyParcelAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThirdPartyParcelAccount**](ThirdPartyParcelAccount.md)| ThirdPartyParcelAccount to be inserted. | 

### Return type

[**ThirdPartyParcelAccount**](ThirdPartyParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletethirdpartyparcelaccount"></a>
# **DeleteThirdPartyParcelAccount**
> void DeleteThirdPartyParcelAccount (int? thirdPartyParcelAccountId)

Delete a thirdPartyParcelAccount

Deletes the thirdPartyParcelAccount identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteThirdPartyParcelAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ThirdPartyParcelAccountApi();
            var thirdPartyParcelAccountId = 56;  // int? | Id of the thirdPartyParcelAccount to be deleted.

            try
            {
                // Delete a thirdPartyParcelAccount
                apiInstance.DeleteThirdPartyParcelAccount(thirdPartyParcelAccountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThirdPartyParcelAccountApi.DeleteThirdPartyParcelAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdPartyParcelAccountId** | **int?**| Id of the thirdPartyParcelAccount to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getthirdpartyparcelaccountbyfilter"></a>
# **GetThirdPartyParcelAccountByFilter**
> List<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search thirdPartyParcelAccounts by filter

Returns the list of thirdPartyParcelAccounts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetThirdPartyParcelAccountByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ThirdPartyParcelAccountApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search thirdPartyParcelAccounts by filter
                List&lt;ThirdPartyParcelAccount&gt; result = apiInstance.GetThirdPartyParcelAccountByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThirdPartyParcelAccountApi.GetThirdPartyParcelAccountByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Query string, used to filter results. | [optional] 
 **page** | **int?**| Result page number.  Defaults to 1. | [optional] 
 **limit** | **int?**| Maximum results per page.  Defaults to 20.  Max allowed value is 250. | [optional] 
 **sort** | **string**| Sort results by specified field. | [optional] 

### Return type

[**List<ThirdPartyParcelAccount>**](ThirdPartyParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getthirdpartyparcelaccountbyid"></a>
# **GetThirdPartyParcelAccountById**
> ThirdPartyParcelAccount GetThirdPartyParcelAccountById (int? thirdPartyParcelAccountId)

Get a thirdPartyParcelAccount by id

Returns the thirdPartyParcelAccount identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetThirdPartyParcelAccountByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ThirdPartyParcelAccountApi();
            var thirdPartyParcelAccountId = 56;  // int? | Id of the thirdPartyParcelAccount to be returned.

            try
            {
                // Get a thirdPartyParcelAccount by id
                ThirdPartyParcelAccount result = apiInstance.GetThirdPartyParcelAccountById(thirdPartyParcelAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThirdPartyParcelAccountApi.GetThirdPartyParcelAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdPartyParcelAccountId** | **int?**| Id of the thirdPartyParcelAccount to be returned. | 

### Return type

[**ThirdPartyParcelAccount**](ThirdPartyParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatethirdpartyparcelaccount"></a>
# **UpdateThirdPartyParcelAccount**
> void UpdateThirdPartyParcelAccount (ThirdPartyParcelAccount body)

Update a thirdPartyParcelAccount

Updates an existing thirdPartyParcelAccount using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateThirdPartyParcelAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ThirdPartyParcelAccountApi();
            var body = new ThirdPartyParcelAccount(); // ThirdPartyParcelAccount | ThirdPartyParcelAccount to be updated.

            try
            {
                // Update a thirdPartyParcelAccount
                apiInstance.UpdateThirdPartyParcelAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThirdPartyParcelAccountApi.UpdateThirdPartyParcelAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThirdPartyParcelAccount**](ThirdPartyParcelAccount.md)| ThirdPartyParcelAccount to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatethirdpartyparcelaccountcustomfields"></a>
# **UpdateThirdPartyParcelAccountCustomFields**
> void UpdateThirdPartyParcelAccountCustomFields (ThirdPartyParcelAccount body)

Update a thirdPartyParcelAccount custom fields

Updates an existing thirdPartyParcelAccount custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateThirdPartyParcelAccountCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ThirdPartyParcelAccountApi();
            var body = new ThirdPartyParcelAccount(); // ThirdPartyParcelAccount | ThirdPartyParcelAccount to be updated.

            try
            {
                // Update a thirdPartyParcelAccount custom fields
                apiInstance.UpdateThirdPartyParcelAccountCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThirdPartyParcelAccountApi.UpdateThirdPartyParcelAccountCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThirdPartyParcelAccount**](ThirdPartyParcelAccount.md)| ThirdPartyParcelAccount to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

