# Infoplus.Api.BillingCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillingCode**](BillingCodeApi.md#addbillingcode) | **POST** /v1.0/billingCode | Create a billingCode
[**DeleteBillingCode**](BillingCodeApi.md#deletebillingcode) | **DELETE** /v1.0/billingCode/{billingCodeId} | Delete a billingCode
[**GetBillingCodeByFilter**](BillingCodeApi.md#getbillingcodebyfilter) | **GET** /v1.0/billingCode/search | Search billingCodes by filter
[**GetBillingCodeById**](BillingCodeApi.md#getbillingcodebyid) | **GET** /v1.0/billingCode/{billingCodeId} | Get a billingCode by id
[**UpdateBillingCode**](BillingCodeApi.md#updatebillingcode) | **PUT** /v1.0/billingCode | Update a billingCode


# **AddBillingCode**
> BillingCode AddBillingCode (BillingCode body)

Create a billingCode

Inserts a new billingCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new BillingCodeApi();
            var body = new BillingCode(); // BillingCode | BillingCode to be inserted.

            try
            {
                // Create a billingCode
                BillingCode result = apiInstance.AddBillingCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.AddBillingCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCode**](BillingCode.md)| BillingCode to be inserted. | 

### Return type

[**BillingCode**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteBillingCode**
> void DeleteBillingCode (int? billingCodeId)

Delete a billingCode

Deletes the billingCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to be deleted.

            try
            {
                // Delete a billingCode
                apiInstance.DeleteBillingCode(billingCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.DeleteBillingCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetBillingCodeByFilter**
> List<BillingCode> GetBillingCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billingCodes by filter

Returns the list of billingCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new BillingCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billingCodes by filter
                List&lt;BillingCode&gt; result = apiInstance.GetBillingCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetBillingCodeByFilter: " + e.Message );
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

[**List<BillingCode>**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetBillingCodeById**
> BillingCode GetBillingCodeById (int? billingCodeId)

Get a billingCode by id

Returns the billingCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to be returned.

            try
            {
                // Get a billingCode by id
                BillingCode result = apiInstance.GetBillingCodeById(billingCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetBillingCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to be returned. | 

### Return type

[**BillingCode**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateBillingCode**
> void UpdateBillingCode (BillingCode body)

Update a billingCode

Updates an existing billingCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new BillingCodeApi();
            var body = new BillingCode(); // BillingCode | BillingCode to be updated.

            try
            {
                // Update a billingCode
                apiInstance.UpdateBillingCode(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.UpdateBillingCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCode**](BillingCode.md)| BillingCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

