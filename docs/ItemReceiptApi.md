# Infoplus.Api.ItemReceiptApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemReceiptByFilter**](ItemReceiptApi.md#getitemreceiptbyfilter) | **GET** /beta/itemReceipt/search | Search itemReceipts by filter
[**GetItemReceiptById**](ItemReceiptApi.md#getitemreceiptbyid) | **GET** /beta/itemReceipt/{itemReceiptId} | Get an itemReceipt by id
[**UpdateItemReceiptCustomFields**](ItemReceiptApi.md#updateitemreceiptcustomfields) | **PUT** /beta/itemReceipt/customFields | Update an itemReceipt custom fields


<a name="getitemreceiptbyfilter"></a>
# **GetItemReceiptByFilter**
> List<ItemReceipt> GetItemReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemReceipts by filter

Returns the list of itemReceipts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemReceipts by filter
                List&lt;ItemReceipt&gt; result = apiInstance.GetItemReceiptByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetItemReceiptByFilter: " + e.Message );
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

[**List<ItemReceipt>**](ItemReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptbyid"></a>
# **GetItemReceiptById**
> ItemReceipt GetItemReceiptById (int? itemReceiptId)

Get an itemReceipt by id

Returns the itemReceipt identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var itemReceiptId = 56;  // int? | Id of the itemReceipt to be returned.

            try
            {
                // Get an itemReceipt by id
                ItemReceipt result = apiInstance.GetItemReceiptById(itemReceiptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.GetItemReceiptById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptId** | **int?**| Id of the itemReceipt to be returned. | 

### Return type

[**ItemReceipt**](ItemReceipt.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemreceiptcustomfields"></a>
# **UpdateItemReceiptCustomFields**
> void UpdateItemReceiptCustomFields (ItemReceipt body)

Update an itemReceipt custom fields

Updates an existing itemReceipt custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemReceiptCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ItemReceiptApi();
            var body = new ItemReceipt(); // ItemReceipt | ItemReceipt to be updated.

            try
            {
                // Update an itemReceipt custom fields
                apiInstance.UpdateItemReceiptCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptApi.UpdateItemReceiptCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemReceipt**](ItemReceipt.md)| ItemReceipt to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

