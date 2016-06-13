# Infoplus.Api.VendorComplianceSurveyApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVendorComplianceSurvey**](VendorComplianceSurveyApi.md#addvendorcompliancesurvey) | **POST** /v1.0/vendorComplianceSurvey | Create a vendorComplianceSurvey
[**DeleteVendorComplianceSurvey**](VendorComplianceSurveyApi.md#deletevendorcompliancesurvey) | **DELETE** /v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId} | Delete a vendorComplianceSurvey
[**GetVendorComplianceSurveyByFilter**](VendorComplianceSurveyApi.md#getvendorcompliancesurveybyfilter) | **GET** /v1.0/vendorComplianceSurvey/search | Search vendorComplianceSurveys by filter
[**GetVendorComplianceSurveyById**](VendorComplianceSurveyApi.md#getvendorcompliancesurveybyid) | **GET** /v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId} | Get a vendorComplianceSurvey by id
[**UpdateVendorComplianceSurvey**](VendorComplianceSurveyApi.md#updatevendorcompliancesurvey) | **PUT** /v1.0/vendorComplianceSurvey | Update a vendorComplianceSurvey


# **AddVendorComplianceSurvey**
> VendorComplianceSurvey AddVendorComplianceSurvey (VendorComplianceSurvey body)

Create a vendorComplianceSurvey

Inserts a new vendorComplianceSurvey using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorComplianceSurveyExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new VendorComplianceSurveyApi();
            var body = new VendorComplianceSurvey(); // VendorComplianceSurvey | VendorComplianceSurvey to be inserted.

            try
            {
                // Create a vendorComplianceSurvey
                VendorComplianceSurvey result = apiInstance.AddVendorComplianceSurvey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.AddVendorComplianceSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VendorComplianceSurvey**](VendorComplianceSurvey.md)| VendorComplianceSurvey to be inserted. | 

### Return type

[**VendorComplianceSurvey**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteVendorComplianceSurvey**
> void DeleteVendorComplianceSurvey (int? vendorComplianceSurveyId)

Delete a vendorComplianceSurvey

Deletes the vendorComplianceSurvey identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteVendorComplianceSurveyExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to be deleted.

            try
            {
                // Delete a vendorComplianceSurvey
                apiInstance.DeleteVendorComplianceSurvey(vendorComplianceSurveyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.DeleteVendorComplianceSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetVendorComplianceSurveyByFilter**
> List<VendorComplianceSurvey> GetVendorComplianceSurveyByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search vendorComplianceSurveys by filter

Returns the list of vendorComplianceSurveys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorComplianceSurveyByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new VendorComplianceSurveyApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search vendorComplianceSurveys by filter
                List&lt;VendorComplianceSurvey&gt; result = apiInstance.GetVendorComplianceSurveyByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.GetVendorComplianceSurveyByFilter: " + e.Message );
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

[**List<VendorComplianceSurvey>**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetVendorComplianceSurveyById**
> VendorComplianceSurvey GetVendorComplianceSurveyById (int? vendorComplianceSurveyId)

Get a vendorComplianceSurvey by id

Returns the vendorComplianceSurvey identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorComplianceSurveyByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to be returned.

            try
            {
                // Get a vendorComplianceSurvey by id
                VendorComplianceSurvey result = apiInstance.GetVendorComplianceSurveyById(vendorComplianceSurveyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.GetVendorComplianceSurveyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to be returned. | 

### Return type

[**VendorComplianceSurvey**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateVendorComplianceSurvey**
> void UpdateVendorComplianceSurvey (VendorComplianceSurvey body)

Update a vendorComplianceSurvey

Updates an existing vendorComplianceSurvey using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateVendorComplianceSurveyExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new VendorComplianceSurveyApi();
            var body = new VendorComplianceSurvey(); // VendorComplianceSurvey | VendorComplianceSurvey to be updated.

            try
            {
                // Update a vendorComplianceSurvey
                apiInstance.UpdateVendorComplianceSurvey(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.UpdateVendorComplianceSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VendorComplianceSurvey**](VendorComplianceSurvey.md)| VendorComplianceSurvey to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

