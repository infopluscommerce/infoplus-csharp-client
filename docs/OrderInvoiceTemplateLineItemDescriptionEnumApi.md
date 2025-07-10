# Infoplus.Api.OrderInvoiceTemplateLineItemDescriptionEnumApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderInvoiceTemplateLineItemDescriptionEnumById**](OrderInvoiceTemplateLineItemDescriptionEnumApi.md#getorderinvoicetemplatelineitemdescriptionenumbyid) | **GET** /beta/orderInvoiceTemplateLineItemDescriptionEnum/{orderInvoiceTemplateLineItemDescriptionEnumId} | Get an orderInvoiceTemplateLineItemDescriptionEnum by id
[**GetOrderInvoiceTemplateLineItemDescriptionEnumBySearchText**](OrderInvoiceTemplateLineItemDescriptionEnumApi.md#getorderinvoicetemplatelineitemdescriptionenumbysearchtext) | **GET** /beta/orderInvoiceTemplateLineItemDescriptionEnum/search | Search orderInvoiceTemplateLineItemDescriptionEnums


<a name="getorderinvoicetemplatelineitemdescriptionenumbyid"></a>
# **GetOrderInvoiceTemplateLineItemDescriptionEnumById**
> OrderInvoiceTemplateLineItemDescriptionEnum GetOrderInvoiceTemplateLineItemDescriptionEnumById (string orderInvoiceTemplateLineItemDescriptionEnumId)

Get an orderInvoiceTemplateLineItemDescriptionEnum by id

Returns the orderInvoiceTemplateLineItemDescriptionEnum identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderInvoiceTemplateLineItemDescriptionEnumByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderInvoiceTemplateLineItemDescriptionEnumApi();
            var orderInvoiceTemplateLineItemDescriptionEnumId = orderInvoiceTemplateLineItemDescriptionEnumId_example;  // string | Id of orderInvoiceTemplateLineItemDescriptionEnum to be returned.

            try
            {
                // Get an orderInvoiceTemplateLineItemDescriptionEnum by id
                OrderInvoiceTemplateLineItemDescriptionEnum result = apiInstance.GetOrderInvoiceTemplateLineItemDescriptionEnumById(orderInvoiceTemplateLineItemDescriptionEnumId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderInvoiceTemplateLineItemDescriptionEnumApi.GetOrderInvoiceTemplateLineItemDescriptionEnumById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderInvoiceTemplateLineItemDescriptionEnumId** | **string**| Id of orderInvoiceTemplateLineItemDescriptionEnum to be returned. | 

### Return type

[**OrderInvoiceTemplateLineItemDescriptionEnum**](OrderInvoiceTemplateLineItemDescriptionEnum.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderinvoicetemplatelineitemdescriptionenumbysearchtext"></a>
# **GetOrderInvoiceTemplateLineItemDescriptionEnumBySearchText**
> List<OrderInvoiceTemplateLineItemDescriptionEnum> GetOrderInvoiceTemplateLineItemDescriptionEnumBySearchText (string searchText = null, int? page = null, int? limit = null)

Search orderInvoiceTemplateLineItemDescriptionEnums

Returns the list of orderInvoiceTemplateLineItemDescriptionEnums that match the given searchText.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderInvoiceTemplateLineItemDescriptionEnumBySearchTextExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderInvoiceTemplateLineItemDescriptionEnumApi();
            var searchText = searchText_example;  // string | Search text, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 

            try
            {
                // Search orderInvoiceTemplateLineItemDescriptionEnums
                List&lt;OrderInvoiceTemplateLineItemDescriptionEnum&gt; result = apiInstance.GetOrderInvoiceTemplateLineItemDescriptionEnumBySearchText(searchText, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderInvoiceTemplateLineItemDescriptionEnumApi.GetOrderInvoiceTemplateLineItemDescriptionEnumBySearchText: " + e.Message );
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

[**List<OrderInvoiceTemplateLineItemDescriptionEnum>**](OrderInvoiceTemplateLineItemDescriptionEnum.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

