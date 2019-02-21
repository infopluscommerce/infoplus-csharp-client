# Infoplus.Api.CustomerInvoiceTemplateLineApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomerInvoiceTemplateLineAudit**](CustomerInvoiceTemplateLineApi.md#addcustomerinvoicetemplatelineaudit) | **PUT** /beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/audit/{customerInvoiceTemplateLineAudit} | Add new audit for a customerInvoiceTemplateLine
[**AddCustomerInvoiceTemplateLineTag**](CustomerInvoiceTemplateLineApi.md#addcustomerinvoicetemplatelinetag) | **PUT** /beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag/{customerInvoiceTemplateLineTag} | Add new tags for a customerInvoiceTemplateLine.
[**DeleteCustomerInvoiceTemplateLine**](CustomerInvoiceTemplateLineApi.md#deletecustomerinvoicetemplateline) | **DELETE** /beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId} | Delete a customerInvoiceTemplateLine
[**DeleteCustomerInvoiceTemplateLineTag**](CustomerInvoiceTemplateLineApi.md#deletecustomerinvoicetemplatelinetag) | **DELETE** /beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag/{customerInvoiceTemplateLineTag} | Delete a tag for a customerInvoiceTemplateLine.
[**GetCustomerInvoiceTemplateLineByFilter**](CustomerInvoiceTemplateLineApi.md#getcustomerinvoicetemplatelinebyfilter) | **GET** /beta/customerInvoiceTemplateLine/search | Search customerInvoiceTemplateLines by filter
[**GetCustomerInvoiceTemplateLineById**](CustomerInvoiceTemplateLineApi.md#getcustomerinvoicetemplatelinebyid) | **GET** /beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId} | Get a customerInvoiceTemplateLine by id
[**GetCustomerInvoiceTemplateLineTags**](CustomerInvoiceTemplateLineApi.md#getcustomerinvoicetemplatelinetags) | **GET** /beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag | Get the tags for a customerInvoiceTemplateLine.
[**GetDuplicateCustomerInvoiceTemplateLineById**](CustomerInvoiceTemplateLineApi.md#getduplicatecustomerinvoicetemplatelinebyid) | **GET** /beta/customerInvoiceTemplateLine/duplicate/{customerInvoiceTemplateLineId} | Get a duplicated a customerInvoiceTemplateLine by id
[**UpdateCustomerInvoiceTemplateLine**](CustomerInvoiceTemplateLineApi.md#updatecustomerinvoicetemplateline) | **PUT** /beta/customerInvoiceTemplateLine | Update a customerInvoiceTemplateLine


<a name="addcustomerinvoicetemplatelineaudit"></a>
# **AddCustomerInvoiceTemplateLineAudit**
> void AddCustomerInvoiceTemplateLineAudit (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit)

Add new audit for a customerInvoiceTemplateLine

Adds an audit to an existing customerInvoiceTemplateLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateLineAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to add an audit to
            var customerInvoiceTemplateLineAudit = customerInvoiceTemplateLineAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a customerInvoiceTemplateLine
                apiInstance.AddCustomerInvoiceTemplateLineAudit(customerInvoiceTemplateLineId, customerInvoiceTemplateLineAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.AddCustomerInvoiceTemplateLineAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to add an audit to | 
 **customerInvoiceTemplateLineAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomerinvoicetemplatelinetag"></a>
# **AddCustomerInvoiceTemplateLineTag**
> void AddCustomerInvoiceTemplateLineTag (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)

Add new tags for a customerInvoiceTemplateLine.

Adds a tag to an existing customerInvoiceTemplateLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to add a tag to
            var customerInvoiceTemplateLineTag = customerInvoiceTemplateLineTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a customerInvoiceTemplateLine.
                apiInstance.AddCustomerInvoiceTemplateLineTag(customerInvoiceTemplateLineId, customerInvoiceTemplateLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.AddCustomerInvoiceTemplateLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to add a tag to | 
 **customerInvoiceTemplateLineTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerinvoicetemplateline"></a>
# **DeleteCustomerInvoiceTemplateLine**
> void DeleteCustomerInvoiceTemplateLine (int? customerInvoiceTemplateLineId)

Delete a customerInvoiceTemplateLine

Deletes the customerInvoiceTemplateLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerInvoiceTemplateLineExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to be deleted.

            try
            {
                // Delete a customerInvoiceTemplateLine
                apiInstance.DeleteCustomerInvoiceTemplateLine(customerInvoiceTemplateLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.DeleteCustomerInvoiceTemplateLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerinvoicetemplatelinetag"></a>
# **DeleteCustomerInvoiceTemplateLineTag**
> void DeleteCustomerInvoiceTemplateLineTag (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)

Delete a tag for a customerInvoiceTemplateLine.

Deletes an existing customerInvoiceTemplateLine tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerInvoiceTemplateLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to remove tag from
            var customerInvoiceTemplateLineTag = customerInvoiceTemplateLineTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a customerInvoiceTemplateLine.
                apiInstance.DeleteCustomerInvoiceTemplateLineTag(customerInvoiceTemplateLineId, customerInvoiceTemplateLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.DeleteCustomerInvoiceTemplateLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to remove tag from | 
 **customerInvoiceTemplateLineTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatelinebyfilter"></a>
# **GetCustomerInvoiceTemplateLineByFilter**
> List<CustomerInvoiceTemplateLine> GetCustomerInvoiceTemplateLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search customerInvoiceTemplateLines by filter

Returns the list of customerInvoiceTemplateLines that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateLineByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search customerInvoiceTemplateLines by filter
                List&lt;CustomerInvoiceTemplateLine&gt; result = apiInstance.GetCustomerInvoiceTemplateLineByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.GetCustomerInvoiceTemplateLineByFilter: " + e.Message );
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

[**List<CustomerInvoiceTemplateLine>**](CustomerInvoiceTemplateLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatelinebyid"></a>
# **GetCustomerInvoiceTemplateLineById**
> CustomerInvoiceTemplateLine GetCustomerInvoiceTemplateLineById (int? customerInvoiceTemplateLineId)

Get a customerInvoiceTemplateLine by id

Returns the customerInvoiceTemplateLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to be returned.

            try
            {
                // Get a customerInvoiceTemplateLine by id
                CustomerInvoiceTemplateLine result = apiInstance.GetCustomerInvoiceTemplateLineById(customerInvoiceTemplateLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.GetCustomerInvoiceTemplateLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to be returned. | 

### Return type

[**CustomerInvoiceTemplateLine**](CustomerInvoiceTemplateLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatelinetags"></a>
# **GetCustomerInvoiceTemplateLineTags**
> void GetCustomerInvoiceTemplateLineTags (int? customerInvoiceTemplateLineId)

Get the tags for a customerInvoiceTemplateLine.

Get all existing customerInvoiceTemplateLine tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateLineTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to get tags for

            try
            {
                // Get the tags for a customerInvoiceTemplateLine.
                apiInstance.GetCustomerInvoiceTemplateLineTags(customerInvoiceTemplateLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.GetCustomerInvoiceTemplateLineTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecustomerinvoicetemplatelinebyid"></a>
# **GetDuplicateCustomerInvoiceTemplateLineById**
> CustomerInvoiceTemplateLine GetDuplicateCustomerInvoiceTemplateLineById (int? customerInvoiceTemplateLineId)

Get a duplicated a customerInvoiceTemplateLine by id

Returns a duplicated customerInvoiceTemplateLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCustomerInvoiceTemplateLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var customerInvoiceTemplateLineId = 56;  // int? | Id of the customerInvoiceTemplateLine to be duplicated.

            try
            {
                // Get a duplicated a customerInvoiceTemplateLine by id
                CustomerInvoiceTemplateLine result = apiInstance.GetDuplicateCustomerInvoiceTemplateLineById(customerInvoiceTemplateLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.GetDuplicateCustomerInvoiceTemplateLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateLineId** | **int?**| Id of the customerInvoiceTemplateLine to be duplicated. | 

### Return type

[**CustomerInvoiceTemplateLine**](CustomerInvoiceTemplateLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerinvoicetemplateline"></a>
# **UpdateCustomerInvoiceTemplateLine**
> void UpdateCustomerInvoiceTemplateLine (CustomerInvoiceTemplateLine body)

Update a customerInvoiceTemplateLine

Updates an existing customerInvoiceTemplateLine using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCustomerInvoiceTemplateLineExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateLineApi();
            var body = new CustomerInvoiceTemplateLine(); // CustomerInvoiceTemplateLine | CustomerInvoiceTemplateLine to be updated.

            try
            {
                // Update a customerInvoiceTemplateLine
                apiInstance.UpdateCustomerInvoiceTemplateLine(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateLineApi.UpdateCustomerInvoiceTemplateLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceTemplateLine**](CustomerInvoiceTemplateLine.md)| CustomerInvoiceTemplateLine to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

