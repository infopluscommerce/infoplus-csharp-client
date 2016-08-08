# Infoplus.Api.QuickReceiptApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddQuickReceipt**](QuickReceiptApi.md#addquickreceipt) | **POST** /beta/quickReceipt | Create a quickReceipt
[**DeleteQuickReceipt**](QuickReceiptApi.md#deletequickreceipt) | **DELETE** /beta/quickReceipt/{quickReceiptId} | Delete a quickReceipt
[**GetQuickReceiptByFilter**](QuickReceiptApi.md#getquickreceiptbyfilter) | **GET** /beta/quickReceipt/search | Search quickReceipts by filter
[**GetQuickReceiptById**](QuickReceiptApi.md#getquickreceiptbyid) | **GET** /beta/quickReceipt/{quickReceiptId} | Get a quickReceipt by id
[**UpdateQuickReceipt**](QuickReceiptApi.md#updatequickreceipt) | **PUT** /beta/quickReceipt | Update a quickReceipt
[**UpdateQuickReceiptCustomFields**](QuickReceiptApi.md#updatequickreceiptcustomfields) | **PUT** /beta/quickReceipt/customFields | Update a quickReceipt custom fields


<a name="addquickreceipt"></a>
# **AddQuickReceipt**
> QuickReceipt AddQuickReceipt (QuickReceipt body)

Create a quickReceipt

Inserts a new quickReceipt using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickReceiptExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var body = new QuickReceipt(); // QuickReceipt | QuickReceipt to be inserted.

            try
            {
                // Create a quickReceipt
                QuickReceipt result = apiInstance.AddQuickReceipt(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.AddQuickReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickReceipt**](QuickReceipt.md)| QuickReceipt to be inserted. | 

### Return type

[**QuickReceipt**](QuickReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequickreceipt"></a>
# **DeleteQuickReceipt**
> void DeleteQuickReceipt (int? quickReceiptId)

Delete a quickReceipt

Deletes the quickReceipt identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteQuickReceiptExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to be deleted.

            try
            {
                // Delete a quickReceipt
                apiInstance.DeleteQuickReceipt(quickReceiptId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.DeleteQuickReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquickreceiptbyfilter"></a>
# **GetQuickReceiptByFilter**
> List<QuickReceipt> GetQuickReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search quickReceipts by filter

Returns the list of quickReceipts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickReceiptByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search quickReceipts by filter
                List&lt;QuickReceipt&gt; result = apiInstance.GetQuickReceiptByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.GetQuickReceiptByFilter: " + e.Message );
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

[**List<QuickReceipt>**](QuickReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquickreceiptbyid"></a>
# **GetQuickReceiptById**
> QuickReceipt GetQuickReceiptById (int? quickReceiptId)

Get a quickReceipt by id

Returns the quickReceipt identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickReceiptByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to be returned.

            try
            {
                // Get a quickReceipt by id
                QuickReceipt result = apiInstance.GetQuickReceiptById(quickReceiptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.GetQuickReceiptById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to be returned. | 

### Return type

[**QuickReceipt**](QuickReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequickreceipt"></a>
# **UpdateQuickReceipt**
> void UpdateQuickReceipt (QuickReceipt body)

Update a quickReceipt

Updates an existing quickReceipt using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateQuickReceiptExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var body = new QuickReceipt(); // QuickReceipt | QuickReceipt to be updated.

            try
            {
                // Update a quickReceipt
                apiInstance.UpdateQuickReceipt(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.UpdateQuickReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickReceipt**](QuickReceipt.md)| QuickReceipt to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequickreceiptcustomfields"></a>
# **UpdateQuickReceiptCustomFields**
> void UpdateQuickReceiptCustomFields (QuickReceipt body)

Update a quickReceipt custom fields

Updates an existing quickReceipt custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateQuickReceiptCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var body = new QuickReceipt(); // QuickReceipt | QuickReceipt to be updated.

            try
            {
                // Update a quickReceipt custom fields
                apiInstance.UpdateQuickReceiptCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.UpdateQuickReceiptCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickReceipt**](QuickReceipt.md)| QuickReceipt to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

