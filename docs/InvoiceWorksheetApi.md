# Infoplus.Api.InvoiceWorksheetApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInvoiceWorksheet**](InvoiceWorksheetApi.md#addinvoiceworksheet) | **POST** /beta/invoiceWorksheet | Create an invoiceWorksheet
[**AddInvoiceWorksheetAudit**](InvoiceWorksheetApi.md#addinvoiceworksheetaudit) | **PUT** /beta/invoiceWorksheet/{invoiceWorksheetId}/audit/{invoiceWorksheetAudit} | Add new audit for an invoiceWorksheet
[**AddInvoiceWorksheetFile**](InvoiceWorksheetApi.md#addinvoiceworksheetfile) | **POST** /beta/invoiceWorksheet/{invoiceWorksheetId}/file/{fileName} | Attach a file to an invoiceWorksheet
[**AddInvoiceWorksheetFileByURL**](InvoiceWorksheetApi.md#addinvoiceworksheetfilebyurl) | **POST** /beta/invoiceWorksheet/{invoiceWorksheetId}/file | Attach a file to an invoiceWorksheet by URL.
[**AddInvoiceWorksheetTag**](InvoiceWorksheetApi.md#addinvoiceworksheettag) | **PUT** /beta/invoiceWorksheet/{invoiceWorksheetId}/tag/{invoiceWorksheetTag} | Add new tags for an invoiceWorksheet.
[**DeleteInvoiceWorksheet**](InvoiceWorksheetApi.md#deleteinvoiceworksheet) | **DELETE** /beta/invoiceWorksheet/{invoiceWorksheetId} | Delete an invoiceWorksheet
[**DeleteInvoiceWorksheetFile**](InvoiceWorksheetApi.md#deleteinvoiceworksheetfile) | **DELETE** /beta/invoiceWorksheet/{invoiceWorksheetId}/file/{fileId} | Delete a file for an invoiceWorksheet.
[**DeleteInvoiceWorksheetTag**](InvoiceWorksheetApi.md#deleteinvoiceworksheettag) | **DELETE** /beta/invoiceWorksheet/{invoiceWorksheetId}/tag/{invoiceWorksheetTag} | Delete a tag for an invoiceWorksheet.
[**GetDuplicateInvoiceWorksheetById**](InvoiceWorksheetApi.md#getduplicateinvoiceworksheetbyid) | **GET** /beta/invoiceWorksheet/duplicate/{invoiceWorksheetId} | Get a duplicated an invoiceWorksheet by id
[**GetInvoiceWorksheetByFilter**](InvoiceWorksheetApi.md#getinvoiceworksheetbyfilter) | **GET** /beta/invoiceWorksheet/search | Search invoiceWorksheets by filter
[**GetInvoiceWorksheetById**](InvoiceWorksheetApi.md#getinvoiceworksheetbyid) | **GET** /beta/invoiceWorksheet/{invoiceWorksheetId} | Get an invoiceWorksheet by id
[**GetInvoiceWorksheetFiles**](InvoiceWorksheetApi.md#getinvoiceworksheetfiles) | **GET** /beta/invoiceWorksheet/{invoiceWorksheetId}/file | Get the files for an invoiceWorksheet.
[**GetInvoiceWorksheetTags**](InvoiceWorksheetApi.md#getinvoiceworksheettags) | **GET** /beta/invoiceWorksheet/{invoiceWorksheetId}/tag | Get the tags for an invoiceWorksheet.
[**UpdateInvoiceWorksheet**](InvoiceWorksheetApi.md#updateinvoiceworksheet) | **PUT** /beta/invoiceWorksheet | Update an invoiceWorksheet


<a name="addinvoiceworksheet"></a>
# **AddInvoiceWorksheet**
> InvoiceWorksheet AddInvoiceWorksheet (InvoiceWorksheet body)

Create an invoiceWorksheet

Inserts a new invoiceWorksheet using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var body = new InvoiceWorksheet(); // InvoiceWorksheet | InvoiceWorksheet to be inserted.

            try
            {
                // Create an invoiceWorksheet
                InvoiceWorksheet result = apiInstance.AddInvoiceWorksheet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.AddInvoiceWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvoiceWorksheet**](InvoiceWorksheet.md)| InvoiceWorksheet to be inserted. | 

### Return type

[**InvoiceWorksheet**](InvoiceWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetaudit"></a>
# **AddInvoiceWorksheetAudit**
> void AddInvoiceWorksheetAudit (int? invoiceWorksheetId, string invoiceWorksheetAudit)

Add new audit for an invoiceWorksheet

Adds an audit to an existing invoiceWorksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to add an audit to
            var invoiceWorksheetAudit = invoiceWorksheetAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an invoiceWorksheet
                apiInstance.AddInvoiceWorksheetAudit(invoiceWorksheetId, invoiceWorksheetAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.AddInvoiceWorksheetAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to add an audit to | 
 **invoiceWorksheetAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetfile"></a>
# **AddInvoiceWorksheetFile**
> void AddInvoiceWorksheetFile (int? invoiceWorksheetId, string fileName)

Attach a file to an invoiceWorksheet

Adds a file to an existing invoiceWorksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an invoiceWorksheet
                apiInstance.AddInvoiceWorksheetFile(invoiceWorksheetId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.AddInvoiceWorksheetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheetfilebyurl"></a>
# **AddInvoiceWorksheetFileByURL**
> void AddInvoiceWorksheetFileByURL (RecordFile body, int? invoiceWorksheetId)

Attach a file to an invoiceWorksheet by URL.

Adds a file to an existing invoiceWorksheet by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to add an file to

            try
            {
                // Attach a file to an invoiceWorksheet by URL.
                apiInstance.AddInvoiceWorksheetFileByURL(body, invoiceWorksheetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.AddInvoiceWorksheetFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinvoiceworksheettag"></a>
# **AddInvoiceWorksheetTag**
> void AddInvoiceWorksheetTag (int? invoiceWorksheetId, string invoiceWorksheetTag)

Add new tags for an invoiceWorksheet.

Adds a tag to an existing invoiceWorksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddInvoiceWorksheetTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to add a tag to
            var invoiceWorksheetTag = invoiceWorksheetTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an invoiceWorksheet.
                apiInstance.AddInvoiceWorksheetTag(invoiceWorksheetId, invoiceWorksheetTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.AddInvoiceWorksheetTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to add a tag to | 
 **invoiceWorksheetTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceworksheet"></a>
# **DeleteInvoiceWorksheet**
> void DeleteInvoiceWorksheet (int? invoiceWorksheetId)

Delete an invoiceWorksheet

Deletes the invoiceWorksheet identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInvoiceWorksheetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to be deleted.

            try
            {
                // Delete an invoiceWorksheet
                apiInstance.DeleteInvoiceWorksheet(invoiceWorksheetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.DeleteInvoiceWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceworksheetfile"></a>
# **DeleteInvoiceWorksheetFile**
> void DeleteInvoiceWorksheetFile (int? invoiceWorksheetId, int? fileId)

Delete a file for an invoiceWorksheet.

Deletes an existing invoiceWorksheet file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInvoiceWorksheetFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an invoiceWorksheet.
                apiInstance.DeleteInvoiceWorksheetFile(invoiceWorksheetId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.DeleteInvoiceWorksheetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceworksheettag"></a>
# **DeleteInvoiceWorksheetTag**
> void DeleteInvoiceWorksheetTag (int? invoiceWorksheetId, string invoiceWorksheetTag)

Delete a tag for an invoiceWorksheet.

Deletes an existing invoiceWorksheet tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteInvoiceWorksheetTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to remove tag from
            var invoiceWorksheetTag = invoiceWorksheetTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an invoiceWorksheet.
                apiInstance.DeleteInvoiceWorksheetTag(invoiceWorksheetId, invoiceWorksheetTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.DeleteInvoiceWorksheetTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to remove tag from | 
 **invoiceWorksheetTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateinvoiceworksheetbyid"></a>
# **GetDuplicateInvoiceWorksheetById**
> InvoiceWorksheet GetDuplicateInvoiceWorksheetById (int? invoiceWorksheetId)

Get a duplicated an invoiceWorksheet by id

Returns a duplicated invoiceWorksheet identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateInvoiceWorksheetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to be duplicated.

            try
            {
                // Get a duplicated an invoiceWorksheet by id
                InvoiceWorksheet result = apiInstance.GetDuplicateInvoiceWorksheetById(invoiceWorksheetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.GetDuplicateInvoiceWorksheetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to be duplicated. | 

### Return type

[**InvoiceWorksheet**](InvoiceWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetbyfilter"></a>
# **GetInvoiceWorksheetByFilter**
> List<InvoiceWorksheet> GetInvoiceWorksheetByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search invoiceWorksheets by filter

Returns the list of invoiceWorksheets that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search invoiceWorksheets by filter
                List&lt;InvoiceWorksheet&gt; result = apiInstance.GetInvoiceWorksheetByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.GetInvoiceWorksheetByFilter: " + e.Message );
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

[**List<InvoiceWorksheet>**](InvoiceWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetbyid"></a>
# **GetInvoiceWorksheetById**
> InvoiceWorksheet GetInvoiceWorksheetById (int? invoiceWorksheetId)

Get an invoiceWorksheet by id

Returns the invoiceWorksheet identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to be returned.

            try
            {
                // Get an invoiceWorksheet by id
                InvoiceWorksheet result = apiInstance.GetInvoiceWorksheetById(invoiceWorksheetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.GetInvoiceWorksheetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to be returned. | 

### Return type

[**InvoiceWorksheet**](InvoiceWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheetfiles"></a>
# **GetInvoiceWorksheetFiles**
> void GetInvoiceWorksheetFiles (int? invoiceWorksheetId)

Get the files for an invoiceWorksheet.

Get all existing invoiceWorksheet files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to get files for

            try
            {
                // Get the files for an invoiceWorksheet.
                apiInstance.GetInvoiceWorksheetFiles(invoiceWorksheetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.GetInvoiceWorksheetFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceworksheettags"></a>
# **GetInvoiceWorksheetTags**
> void GetInvoiceWorksheetTags (int? invoiceWorksheetId)

Get the tags for an invoiceWorksheet.

Get all existing invoiceWorksheet tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetInvoiceWorksheetTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var invoiceWorksheetId = 56;  // int? | Id of the invoiceWorksheet to get tags for

            try
            {
                // Get the tags for an invoiceWorksheet.
                apiInstance.GetInvoiceWorksheetTags(invoiceWorksheetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.GetInvoiceWorksheetTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceWorksheetId** | **int?**| Id of the invoiceWorksheet to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoiceworksheet"></a>
# **UpdateInvoiceWorksheet**
> void UpdateInvoiceWorksheet (InvoiceWorksheet body)

Update an invoiceWorksheet

Updates an existing invoiceWorksheet using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateInvoiceWorksheetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new InvoiceWorksheetApi();
            var body = new InvoiceWorksheet(); // InvoiceWorksheet | InvoiceWorksheet to be updated.

            try
            {
                // Update an invoiceWorksheet
                apiInstance.UpdateInvoiceWorksheet(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceWorksheetApi.UpdateInvoiceWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvoiceWorksheet**](InvoiceWorksheet.md)| InvoiceWorksheet to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

