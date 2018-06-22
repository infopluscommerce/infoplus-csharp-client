# Infoplus.Api.InvoiceWorksheetLineApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInvoiceWorksheetLine**](InvoiceWorksheetLineApi.md#addinvoiceworksheetline) | **POST** /beta/invoiceWorksheetLine | Create an invoiceWorksheetLine
[**AddInvoiceWorksheetLineAudit**](InvoiceWorksheetLineApi.md#addinvoiceworksheetlineaudit) | **PUT** /beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/audit/{invoiceWorksheetLineAudit} | Add new audit for an invoiceWorksheetLine
[**AddInvoiceWorksheetLineTag**](InvoiceWorksheetLineApi.md#addinvoiceworksheetlinetag) | **PUT** /beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag/{invoiceWorksheetLineTag} | Add new tags for an invoiceWorksheetLine.
[**DeleteInvoiceWorksheetLine**](InvoiceWorksheetLineApi.md#deleteinvoiceworksheetline) | **DELETE** /beta/invoiceWorksheetLine/{invoiceWorksheetLineId} | Delete an invoiceWorksheetLine
[**DeleteInvoiceWorksheetLineTag**](InvoiceWorksheetLineApi.md#deleteinvoiceworksheetlinetag) | **DELETE** /beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag/{invoiceWorksheetLineTag} | Delete a tag for an invoiceWorksheetLine.
[**GetDuplicateInvoiceWorksheetLineById**](InvoiceWorksheetLineApi.md#getduplicateinvoiceworksheetlinebyid) | **GET** /beta/invoiceWorksheetLine/duplicate/{invoiceWorksheetLineId} | Get a duplicated an invoiceWorksheetLine by id
[**GetInvoiceWorksheetLineByFilter**](InvoiceWorksheetLineApi.md#getinvoiceworksheetlinebyfilter) | **GET** /beta/invoiceWorksheetLine/search | Search invoiceWorksheetLines by filter
[**GetInvoiceWorksheetLineById**](InvoiceWorksheetLineApi.md#getinvoiceworksheetlinebyid) | **GET** /beta/invoiceWorksheetLine/{invoiceWorksheetLineId} | Get an invoiceWorksheetLine by id
[**GetInvoiceWorksheetLineTags**](InvoiceWorksheetLineApi.md#getinvoiceworksheetlinetags) | **GET** /beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag | Get the tags for an invoiceWorksheetLine.
[**UpdateInvoiceWorksheetLine**](InvoiceWorksheetLineApi.md#updateinvoiceworksheetline) | **PUT** /beta/invoiceWorksheetLine | Update an invoiceWorksheetLine


<a name="addinvoiceworksheetline"></a>
# **AddInvoiceWorksheetLine**
> InvoiceWorksheetLine AddInvoiceWorksheetLine (InvoiceWorksheetLine body)

Create an invoiceWorksheetLine

Inserts a new invoiceWorksheetLine using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetLineExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var body = new InvoiceWorksheetLine(); // InvoiceWorksheetLine | InvoiceWorksheetLine to be inserted.

            try
            {
                // Create an invoiceWorksheetLine
                InvoiceWorksheetLine result = apiInstance.AddInvoiceWorksheetLine(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.AddInvoiceWorksheetLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvoiceWorksheetLine**](InvoiceWorksheetLine.md)| InvoiceWorksheetLine to be inserted. | 

### Return type

[**InvoiceWorksheetLine**](InvoiceWorksheetLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetlineaudit"></a>
# **AddInvoiceWorksheetLineAudit**
> void AddInvoiceWorksheetLineAudit (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit)

Add new audit for an invoiceWorksheetLine

Adds an audit to an existing invoiceWorksheetLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetLineAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to add an audit to
            var invoiceWorksheetLineAudit = invoiceWorksheetLineAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an invoiceWorksheetLine
                apiInstance.AddInvoiceWorksheetLineAudit(invoiceWorksheetLineId, invoiceWorksheetLineAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.AddInvoiceWorksheetLineAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to add an audit to | 
 **invoiceWorksheetLineAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetlinetag"></a>
# **AddInvoiceWorksheetLineTag**
> void AddInvoiceWorksheetLineTag (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)

Add new tags for an invoiceWorksheetLine.

Adds a tag to an existing invoiceWorksheetLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to add a tag to
            var invoiceWorksheetLineTag = invoiceWorksheetLineTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an invoiceWorksheetLine.
                apiInstance.AddInvoiceWorksheetLineTag(invoiceWorksheetLineId, invoiceWorksheetLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.AddInvoiceWorksheetLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to add a tag to | 
 **invoiceWorksheetLineTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceworksheetline"></a>
# **DeleteInvoiceWorksheetLine**
> void DeleteInvoiceWorksheetLine (int? invoiceWorksheetLineId)

Delete an invoiceWorksheetLine

Deletes the invoiceWorksheetLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInvoiceWorksheetLineExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to be deleted.

            try
            {
                // Delete an invoiceWorksheetLine
                apiInstance.DeleteInvoiceWorksheetLine(invoiceWorksheetLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.DeleteInvoiceWorksheetLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceworksheetlinetag"></a>
# **DeleteInvoiceWorksheetLineTag**
> void DeleteInvoiceWorksheetLineTag (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)

Delete a tag for an invoiceWorksheetLine.

Deletes an existing invoiceWorksheetLine tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInvoiceWorksheetLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to remove tag from
            var invoiceWorksheetLineTag = invoiceWorksheetLineTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an invoiceWorksheetLine.
                apiInstance.DeleteInvoiceWorksheetLineTag(invoiceWorksheetLineId, invoiceWorksheetLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.DeleteInvoiceWorksheetLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to remove tag from | 
 **invoiceWorksheetLineTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinvoiceworksheetlinebyid"></a>
# **GetDuplicateInvoiceWorksheetLineById**
> InvoiceWorksheetLine GetDuplicateInvoiceWorksheetLineById (int? invoiceWorksheetLineId)

Get a duplicated an invoiceWorksheetLine by id

Returns a duplicated invoiceWorksheetLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInvoiceWorksheetLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to be duplicated.

            try
            {
                // Get a duplicated an invoiceWorksheetLine by id
                InvoiceWorksheetLine result = apiInstance.GetDuplicateInvoiceWorksheetLineById(invoiceWorksheetLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.GetDuplicateInvoiceWorksheetLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to be duplicated. | 

### Return type

[**InvoiceWorksheetLine**](InvoiceWorksheetLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetlinebyfilter"></a>
# **GetInvoiceWorksheetLineByFilter**
> List<InvoiceWorksheetLine> GetInvoiceWorksheetLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search invoiceWorksheetLines by filter

Returns the list of invoiceWorksheetLines that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetLineByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search invoiceWorksheetLines by filter
                List&lt;InvoiceWorksheetLine&gt; result = apiInstance.GetInvoiceWorksheetLineByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.GetInvoiceWorksheetLineByFilter: " + e.Message );
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

[**List<InvoiceWorksheetLine>**](InvoiceWorksheetLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetlinebyid"></a>
# **GetInvoiceWorksheetLineById**
> InvoiceWorksheetLine GetInvoiceWorksheetLineById (int? invoiceWorksheetLineId)

Get an invoiceWorksheetLine by id

Returns the invoiceWorksheetLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to be returned.

            try
            {
                // Get an invoiceWorksheetLine by id
                InvoiceWorksheetLine result = apiInstance.GetInvoiceWorksheetLineById(invoiceWorksheetLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.GetInvoiceWorksheetLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to be returned. | 

### Return type

[**InvoiceWorksheetLine**](InvoiceWorksheetLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetlinetags"></a>
# **GetInvoiceWorksheetLineTags**
> void GetInvoiceWorksheetLineTags (int? invoiceWorksheetLineId)

Get the tags for an invoiceWorksheetLine.

Get all existing invoiceWorksheetLine tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetLineTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var invoiceWorksheetLineId = 56;  // int? | Id of the invoiceWorksheetLine to get tags for

            try
            {
                // Get the tags for an invoiceWorksheetLine.
                apiInstance.GetInvoiceWorksheetLineTags(invoiceWorksheetLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.GetInvoiceWorksheetLineTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetLineId** | **int?**| Id of the invoiceWorksheetLine to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoiceworksheetline"></a>
# **UpdateInvoiceWorksheetLine**
> void UpdateInvoiceWorksheetLine (InvoiceWorksheetLine body)

Update an invoiceWorksheetLine

Updates an existing invoiceWorksheetLine using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateInvoiceWorksheetLineExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetLineApi();
            var body = new InvoiceWorksheetLine(); // InvoiceWorksheetLine | InvoiceWorksheetLine to be updated.

            try
            {
                // Update an invoiceWorksheetLine
                apiInstance.UpdateInvoiceWorksheetLine(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetLineApi.UpdateInvoiceWorksheetLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvoiceWorksheetLine**](InvoiceWorksheetLine.md)| InvoiceWorksheetLine to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

