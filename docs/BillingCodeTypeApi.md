# Infoplus.Api.BillingCodeTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillingCodeType**](BillingCodeTypeApi.md#addbillingcodetype) | **POST** /beta/billingCodeType | Create a billingCodeType
[**DeleteBillingCodeType**](BillingCodeTypeApi.md#deletebillingcodetype) | **DELETE** /beta/billingCodeType/{billingCodeTypeId} | Delete a billingCodeType
[**GetBillingCodeTypeByFilter**](BillingCodeTypeApi.md#getbillingcodetypebyfilter) | **GET** /beta/billingCodeType/search | Search billingCodeTypes by filter
[**GetBillingCodeTypeById**](BillingCodeTypeApi.md#getbillingcodetypebyid) | **GET** /beta/billingCodeType/{billingCodeTypeId} | Get a billingCodeType by id
[**UpdateBillingCodeType**](BillingCodeTypeApi.md#updatebillingcodetype) | **PUT** /beta/billingCodeType | Update a billingCodeType
[**UpdateBillingCodeTypeCustomFields**](BillingCodeTypeApi.md#updatebillingcodetypecustomfields) | **PUT** /beta/billingCodeType/customFields | Update a billingCodeType custom fields


<a name="addbillingcodetype"></a>
# **AddBillingCodeType**
> BillingCodeType AddBillingCodeType (BillingCodeType body)

Create a billingCodeType

Inserts a new billingCodeType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new BillingCodeType(); // BillingCodeType | BillingCodeType to be inserted.

            try
            {
                // Create a billingCodeType
                BillingCodeType result = apiInstance.AddBillingCodeType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.AddBillingCodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeType**](BillingCodeType.md)| BillingCodeType to be inserted. | 

### Return type

[**BillingCodeType**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodetype"></a>
# **DeleteBillingCodeType**
> void DeleteBillingCodeType (int? billingCodeTypeId)

Delete a billingCodeType

Deletes the billingCodeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to be deleted.

            try
            {
                // Delete a billingCodeType
                apiInstance.DeleteBillingCodeType(billingCodeTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.DeleteBillingCodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetypebyfilter"></a>
# **GetBillingCodeTypeByFilter**
> List<BillingCodeType> GetBillingCodeTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billingCodeTypes by filter

Returns the list of billingCodeTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTypeByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billingCodeTypes by filter
                List&lt;BillingCodeType&gt; result = apiInstance.GetBillingCodeTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetBillingCodeTypeByFilter: " + e.Message );
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

[**List<BillingCodeType>**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetypebyid"></a>
# **GetBillingCodeTypeById**
> BillingCodeType GetBillingCodeTypeById (int? billingCodeTypeId)

Get a billingCodeType by id

Returns the billingCodeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTypeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to be returned.

            try
            {
                // Get a billingCodeType by id
                BillingCodeType result = apiInstance.GetBillingCodeTypeById(billingCodeTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetBillingCodeTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to be returned. | 

### Return type

[**BillingCodeType**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcodetype"></a>
# **UpdateBillingCodeType**
> void UpdateBillingCodeType (BillingCodeType body)

Update a billingCodeType

Updates an existing billingCodeType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeTypeExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new BillingCodeType(); // BillingCodeType | BillingCodeType to be updated.

            try
            {
                // Update a billingCodeType
                apiInstance.UpdateBillingCodeType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.UpdateBillingCodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeType**](BillingCodeType.md)| BillingCodeType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcodetypecustomfields"></a>
# **UpdateBillingCodeTypeCustomFields**
> void UpdateBillingCodeTypeCustomFields (BillingCodeType body)

Update a billingCodeType custom fields

Updates an existing billingCodeType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeTypeCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new BillingCodeType(); // BillingCodeType | BillingCodeType to be updated.

            try
            {
                // Update a billingCodeType custom fields
                apiInstance.UpdateBillingCodeTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.UpdateBillingCodeTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeType**](BillingCodeType.md)| BillingCodeType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

