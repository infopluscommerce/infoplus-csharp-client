# Infoplus.Api.InvoiceWorksheetLineDetailApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInvoiceWorksheetLineDetailAudit**](InvoiceWorksheetLineDetailApi.md#addinvoiceworksheetlinedetailaudit) | **PUT** /beta/invoiceWorksheetLineDetail/{invoiceWorksheetLineDetailId}/audit/{invoiceWorksheetLineDetailAudit} | Add new audit for an invoiceWorksheetLineDetail
[**AddInvoiceWorksheetLineDetailFile**](InvoiceWorksheetLineDetailApi.md#addinvoiceworksheetlinedetailfile) | **POST** /beta/invoiceWorksheetLineDetail/{invoiceWorksheetLineDetailId}/file/{fileName} | Attach a file to an invoiceWorksheetLineDetail
[**AddInvoiceWorksheetLineDetailTag**](InvoiceWorksheetLineDetailApi.md#addinvoiceworksheetlinedetailtag) | **PUT** /beta/invoiceWorksheetLineDetail/{invoiceWorksheetLineDetailId}/tag/{invoiceWorksheetLineDetailTag} | Add new tags for an invoiceWorksheetLineDetail.
[**DeleteInvoiceWorksheetLineDetailTag**](InvoiceWorksheetLineDetailApi.md#deleteinvoiceworksheetlinedetailtag) | **DELETE** /beta/invoiceWorksheetLineDetail/{invoiceWorksheetLineDetailId}/tag/{invoiceWorksheetLineDetailTag} | Delete a tag for an invoiceWorksheetLineDetail.
[**GetDuplicateInvoiceWorksheetLineDetailById**](InvoiceWorksheetLineDetailApi.md#getduplicateinvoiceworksheetlinedetailbyid) | **GET** /beta/invoiceWorksheetLineDetail/duplicate/{invoiceWorksheetLineDetailId} | Get a duplicated an invoiceWorksheetLineDetail by id
[**GetInvoiceWorksheetLineDetailByFilter**](InvoiceWorksheetLineDetailApi.md#getinvoiceworksheetlinedetailbyfilter) | **GET** /beta/invoiceWorksheetLineDetail/search | Search invoiceWorksheetLineDetails by filter
[**GetInvoiceWorksheetLineDetailById**](InvoiceWorksheetLineDetailApi.md#getinvoiceworksheetlinedetailbyid) | **GET** /beta/invoiceWorksheetLineDetail/{invoiceWorksheetLineDetailId} | Get an invoiceWorksheetLineDetail by id
[**GetInvoiceWorksheetLineDetailTags**](InvoiceWorksheetLineDetailApi.md#getinvoiceworksheetlinedetailtags) | **GET** /beta/invoiceWorksheetLineDetail/{invoiceWorksheetLineDetailId}/tag | Get the tags for an invoiceWorksheetLineDetail.


<a name="addinvoiceworksheetlinedetailaudit"></a>
# **AddInvoiceWorksheetLineDetailAudit**
> void AddInvoiceWorksheetLineDetailAudit (int? invoiceWorksheetLineDetailId, string invoiceWorksheetLineDetailAudit)

Add new audit for an invoiceWorksheetLineDetail

Adds an audit to an existing invoiceWorksheetLineDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetLineDetailAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to add an audit to
            var invoiceWorksheetLineDetailAudit = invoiceWorksheetLineDetailAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an invoiceWorksheetLineDetail
                apiInstance.AddInvoiceWorksheetLineDetailAudit(invoiceWorksheetLineDetailId, invoiceWorksheetLineDetailAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.AddInvoiceWorksheetLineDetailAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to add an audit to | 
 **invoiceWorksheetLineDetailAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetlinedetailfile"></a>
# **AddInvoiceWorksheetLineDetailFile**
> void AddInvoiceWorksheetLineDetailFile (int? invoiceWorksheetLineDetailId, string fileName)

Attach a file to an invoiceWorksheetLineDetail

Adds a file to an existing invoiceWorksheetLineDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetLineDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an invoiceWorksheetLineDetail
                apiInstance.AddInvoiceWorksheetLineDetailFile(invoiceWorksheetLineDetailId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.AddInvoiceWorksheetLineDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetlinedetailtag"></a>
# **AddInvoiceWorksheetLineDetailTag**
> void AddInvoiceWorksheetLineDetailTag (int? invoiceWorksheetLineDetailId, string invoiceWorksheetLineDetailTag)

Add new tags for an invoiceWorksheetLineDetail.

Adds a tag to an existing invoiceWorksheetLineDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetLineDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to add a tag to
            var invoiceWorksheetLineDetailTag = invoiceWorksheetLineDetailTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an invoiceWorksheetLineDetail.
                apiInstance.AddInvoiceWorksheetLineDetailTag(invoiceWorksheetLineDetailId, invoiceWorksheetLineDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.AddInvoiceWorksheetLineDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to add a tag to | 
 **invoiceWorksheetLineDetailTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceworksheetlinedetailtag"></a>
# **DeleteInvoiceWorksheetLineDetailTag**
> void DeleteInvoiceWorksheetLineDetailTag (int? invoiceWorksheetLineDetailId, string invoiceWorksheetLineDetailTag)

Delete a tag for an invoiceWorksheetLineDetail.

Deletes an existing invoiceWorksheetLineDetail tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInvoiceWorksheetLineDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to remove tag from
            var invoiceWorksheetLineDetailTag = invoiceWorksheetLineDetailTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an invoiceWorksheetLineDetail.
                apiInstance.DeleteInvoiceWorksheetLineDetailTag(invoiceWorksheetLineDetailId, invoiceWorksheetLineDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.DeleteInvoiceWorksheetLineDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to remove tag from | 
 **invoiceWorksheetLineDetailTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinvoiceworksheetlinedetailbyid"></a>
# **GetDuplicateInvoiceWorksheetLineDetailById**
> InvoiceWorksheetLineDetail GetDuplicateInvoiceWorksheetLineDetailById (int? invoiceWorksheetLineDetailId)

Get a duplicated an invoiceWorksheetLineDetail by id

Returns a duplicated invoiceWorksheetLineDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInvoiceWorksheetLineDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to be duplicated.

            try
            {
                // Get a duplicated an invoiceWorksheetLineDetail by id
                InvoiceWorksheetLineDetail result = apiInstance.GetDuplicateInvoiceWorksheetLineDetailById(invoiceWorksheetLineDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.GetDuplicateInvoiceWorksheetLineDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to be duplicated. | 

### Return type

[**InvoiceWorksheetLineDetail**](InvoiceWorksheetLineDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetlinedetailbyfilter"></a>
# **GetInvoiceWorksheetLineDetailByFilter**
> List<InvoiceWorksheetLineDetail> GetInvoiceWorksheetLineDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search invoiceWorksheetLineDetails by filter

Returns the list of invoiceWorksheetLineDetails that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetLineDetailByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search invoiceWorksheetLineDetails by filter
                List&lt;InvoiceWorksheetLineDetail&gt; result = apiInstance.GetInvoiceWorksheetLineDetailByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.GetInvoiceWorksheetLineDetailByFilter: " + e.Message );
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

[**List<InvoiceWorksheetLineDetail>**](InvoiceWorksheetLineDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetlinedetailbyid"></a>
# **GetInvoiceWorksheetLineDetailById**
> InvoiceWorksheetLineDetail GetInvoiceWorksheetLineDetailById (int? invoiceWorksheetLineDetailId)

Get an invoiceWorksheetLineDetail by id

Returns the invoiceWorksheetLineDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetLineDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to be returned.

            try
            {
                // Get an invoiceWorksheetLineDetail by id
                InvoiceWorksheetLineDetail result = apiInstance.GetInvoiceWorksheetLineDetailById(invoiceWorksheetLineDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.GetInvoiceWorksheetLineDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to be returned. | 

### Return type

[**InvoiceWorksheetLineDetail**](InvoiceWorksheetLineDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetlinedetailtags"></a>
# **GetInvoiceWorksheetLineDetailTags**
> void GetInvoiceWorksheetLineDetailTags (int? invoiceWorksheetLineDetailId)

Get the tags for an invoiceWorksheetLineDetail.

Get all existing invoiceWorksheetLineDetail tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetLineDetailTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineDetailApi();
            var invoiceWorksheetLineDetailId = 56;  // int? | Id of the invoiceWorksheetLineDetail to get tags for

            try
            {
                // Get the tags for an invoiceWorksheetLineDetail.
                apiInstance.GetInvoiceWorksheetLineDetailTags(invoiceWorksheetLineDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineDetailApi.GetInvoiceWorksheetLineDetailTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineDetailId** | **int?**| Id of the invoiceWorksheetLineDetail to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

