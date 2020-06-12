# Infoplus.Api.CustomerInvoiceTemplateApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomerInvoiceTemplate**](CustomerInvoiceTemplateApi.md#addcustomerinvoicetemplate) | **POST** /beta/customerInvoiceTemplate | Create a customerInvoiceTemplate
[**AddCustomerInvoiceTemplateAudit**](CustomerInvoiceTemplateApi.md#addcustomerinvoicetemplateaudit) | **PUT** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/audit/{customerInvoiceTemplateAudit} | Add new audit for a customerInvoiceTemplate
[**AddCustomerInvoiceTemplateFile**](CustomerInvoiceTemplateApi.md#addcustomerinvoicetemplatefile) | **POST** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/file/{fileName} | Attach a file to a customerInvoiceTemplate
[**AddCustomerInvoiceTemplateFileByURL**](CustomerInvoiceTemplateApi.md#addcustomerinvoicetemplatefilebyurl) | **POST** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/file | Attach a file to a customerInvoiceTemplate by URL.
[**AddCustomerInvoiceTemplateTag**](CustomerInvoiceTemplateApi.md#addcustomerinvoicetemplatetag) | **PUT** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag/{customerInvoiceTemplateTag} | Add new tags for a customerInvoiceTemplate.
[**DeleteCustomerInvoiceTemplate**](CustomerInvoiceTemplateApi.md#deletecustomerinvoicetemplate) | **DELETE** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId} | Delete a customerInvoiceTemplate
[**DeleteCustomerInvoiceTemplateFile**](CustomerInvoiceTemplateApi.md#deletecustomerinvoicetemplatefile) | **DELETE** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/file/{fileId} | Delete a file for a customerInvoiceTemplate.
[**DeleteCustomerInvoiceTemplateTag**](CustomerInvoiceTemplateApi.md#deletecustomerinvoicetemplatetag) | **DELETE** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag/{customerInvoiceTemplateTag} | Delete a tag for a customerInvoiceTemplate.
[**GetCustomerInvoiceTemplateByFilter**](CustomerInvoiceTemplateApi.md#getcustomerinvoicetemplatebyfilter) | **GET** /beta/customerInvoiceTemplate/search | Search customerInvoiceTemplates by filter
[**GetCustomerInvoiceTemplateById**](CustomerInvoiceTemplateApi.md#getcustomerinvoicetemplatebyid) | **GET** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId} | Get a customerInvoiceTemplate by id
[**GetCustomerInvoiceTemplateFiles**](CustomerInvoiceTemplateApi.md#getcustomerinvoicetemplatefiles) | **GET** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/file | Get the files for a customerInvoiceTemplate.
[**GetCustomerInvoiceTemplateTags**](CustomerInvoiceTemplateApi.md#getcustomerinvoicetemplatetags) | **GET** /beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag | Get the tags for a customerInvoiceTemplate.
[**GetDuplicateCustomerInvoiceTemplateById**](CustomerInvoiceTemplateApi.md#getduplicatecustomerinvoicetemplatebyid) | **GET** /beta/customerInvoiceTemplate/duplicate/{customerInvoiceTemplateId} | Get a duplicated a customerInvoiceTemplate by id
[**UpdateCustomerInvoiceTemplate**](CustomerInvoiceTemplateApi.md#updatecustomerinvoicetemplate) | **PUT** /beta/customerInvoiceTemplate | Update a customerInvoiceTemplate


<a name="addcustomerinvoicetemplate"></a>
# **AddCustomerInvoiceTemplate**
> CustomerInvoiceTemplate AddCustomerInvoiceTemplate (CustomerInvoiceTemplate body)

Create a customerInvoiceTemplate

Inserts a new customerInvoiceTemplate using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var body = new CustomerInvoiceTemplate(); // CustomerInvoiceTemplate | CustomerInvoiceTemplate to be inserted.

            try
            {
                // Create a customerInvoiceTemplate
                CustomerInvoiceTemplate result = apiInstance.AddCustomerInvoiceTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.AddCustomerInvoiceTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceTemplate**](CustomerInvoiceTemplate.md)| CustomerInvoiceTemplate to be inserted. | 

### Return type

[**CustomerInvoiceTemplate**](CustomerInvoiceTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomerinvoicetemplateaudit"></a>
# **AddCustomerInvoiceTemplateAudit**
> void AddCustomerInvoiceTemplateAudit (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit)

Add new audit for a customerInvoiceTemplate

Adds an audit to an existing customerInvoiceTemplate.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to add an audit to
            var customerInvoiceTemplateAudit = customerInvoiceTemplateAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a customerInvoiceTemplate
                apiInstance.AddCustomerInvoiceTemplateAudit(customerInvoiceTemplateId, customerInvoiceTemplateAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.AddCustomerInvoiceTemplateAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to add an audit to | 
 **customerInvoiceTemplateAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomerinvoicetemplatefile"></a>
# **AddCustomerInvoiceTemplateFile**
> void AddCustomerInvoiceTemplateFile (int? customerInvoiceTemplateId, string fileName)

Attach a file to a customerInvoiceTemplate

Adds a file to an existing customerInvoiceTemplate.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a customerInvoiceTemplate
                apiInstance.AddCustomerInvoiceTemplateFile(customerInvoiceTemplateId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.AddCustomerInvoiceTemplateFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomerinvoicetemplatefilebyurl"></a>
# **AddCustomerInvoiceTemplateFileByURL**
> void AddCustomerInvoiceTemplateFileByURL (RecordFile body, int? customerInvoiceTemplateId)

Attach a file to a customerInvoiceTemplate by URL.

Adds a file to an existing customerInvoiceTemplate by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to add an file to

            try
            {
                // Attach a file to a customerInvoiceTemplate by URL.
                apiInstance.AddCustomerInvoiceTemplateFileByURL(body, customerInvoiceTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.AddCustomerInvoiceTemplateFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomerinvoicetemplatetag"></a>
# **AddCustomerInvoiceTemplateTag**
> void AddCustomerInvoiceTemplateTag (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)

Add new tags for a customerInvoiceTemplate.

Adds a tag to an existing customerInvoiceTemplate.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerInvoiceTemplateTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to add a tag to
            var customerInvoiceTemplateTag = customerInvoiceTemplateTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a customerInvoiceTemplate.
                apiInstance.AddCustomerInvoiceTemplateTag(customerInvoiceTemplateId, customerInvoiceTemplateTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.AddCustomerInvoiceTemplateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to add a tag to | 
 **customerInvoiceTemplateTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerinvoicetemplate"></a>
# **DeleteCustomerInvoiceTemplate**
> void DeleteCustomerInvoiceTemplate (int? customerInvoiceTemplateId)

Delete a customerInvoiceTemplate

Deletes the customerInvoiceTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerInvoiceTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to be deleted.

            try
            {
                // Delete a customerInvoiceTemplate
                apiInstance.DeleteCustomerInvoiceTemplate(customerInvoiceTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.DeleteCustomerInvoiceTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerinvoicetemplatefile"></a>
# **DeleteCustomerInvoiceTemplateFile**
> void DeleteCustomerInvoiceTemplateFile (int? customerInvoiceTemplateId, int? fileId)

Delete a file for a customerInvoiceTemplate.

Deletes an existing customerInvoiceTemplate file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerInvoiceTemplateFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a customerInvoiceTemplate.
                apiInstance.DeleteCustomerInvoiceTemplateFile(customerInvoiceTemplateId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.DeleteCustomerInvoiceTemplateFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerinvoicetemplatetag"></a>
# **DeleteCustomerInvoiceTemplateTag**
> void DeleteCustomerInvoiceTemplateTag (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)

Delete a tag for a customerInvoiceTemplate.

Deletes an existing customerInvoiceTemplate tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerInvoiceTemplateTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to remove tag from
            var customerInvoiceTemplateTag = customerInvoiceTemplateTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a customerInvoiceTemplate.
                apiInstance.DeleteCustomerInvoiceTemplateTag(customerInvoiceTemplateId, customerInvoiceTemplateTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.DeleteCustomerInvoiceTemplateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to remove tag from | 
 **customerInvoiceTemplateTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatebyfilter"></a>
# **GetCustomerInvoiceTemplateByFilter**
> List<CustomerInvoiceTemplate> GetCustomerInvoiceTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search customerInvoiceTemplates by filter

Returns the list of customerInvoiceTemplates that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search customerInvoiceTemplates by filter
                List&lt;CustomerInvoiceTemplate&gt; result = apiInstance.GetCustomerInvoiceTemplateByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.GetCustomerInvoiceTemplateByFilter: " + e.Message );
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

[**List<CustomerInvoiceTemplate>**](CustomerInvoiceTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatebyid"></a>
# **GetCustomerInvoiceTemplateById**
> CustomerInvoiceTemplate GetCustomerInvoiceTemplateById (int? customerInvoiceTemplateId)

Get a customerInvoiceTemplate by id

Returns the customerInvoiceTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to be returned.

            try
            {
                // Get a customerInvoiceTemplate by id
                CustomerInvoiceTemplate result = apiInstance.GetCustomerInvoiceTemplateById(customerInvoiceTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.GetCustomerInvoiceTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to be returned. | 

### Return type

[**CustomerInvoiceTemplate**](CustomerInvoiceTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatefiles"></a>
# **GetCustomerInvoiceTemplateFiles**
> void GetCustomerInvoiceTemplateFiles (int? customerInvoiceTemplateId)

Get the files for a customerInvoiceTemplate.

Get all existing customerInvoiceTemplate files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to get files for

            try
            {
                // Get the files for a customerInvoiceTemplate.
                apiInstance.GetCustomerInvoiceTemplateFiles(customerInvoiceTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.GetCustomerInvoiceTemplateFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerinvoicetemplatetags"></a>
# **GetCustomerInvoiceTemplateTags**
> void GetCustomerInvoiceTemplateTags (int? customerInvoiceTemplateId)

Get the tags for a customerInvoiceTemplate.

Get all existing customerInvoiceTemplate tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerInvoiceTemplateTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to get tags for

            try
            {
                // Get the tags for a customerInvoiceTemplate.
                apiInstance.GetCustomerInvoiceTemplateTags(customerInvoiceTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.GetCustomerInvoiceTemplateTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecustomerinvoicetemplatebyid"></a>
# **GetDuplicateCustomerInvoiceTemplateById**
> CustomerInvoiceTemplate GetDuplicateCustomerInvoiceTemplateById (int? customerInvoiceTemplateId)

Get a duplicated a customerInvoiceTemplate by id

Returns a duplicated customerInvoiceTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCustomerInvoiceTemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var customerInvoiceTemplateId = 56;  // int? | Id of the customerInvoiceTemplate to be duplicated.

            try
            {
                // Get a duplicated a customerInvoiceTemplate by id
                CustomerInvoiceTemplate result = apiInstance.GetDuplicateCustomerInvoiceTemplateById(customerInvoiceTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.GetDuplicateCustomerInvoiceTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerInvoiceTemplateId** | **int?**| Id of the customerInvoiceTemplate to be duplicated. | 

### Return type

[**CustomerInvoiceTemplate**](CustomerInvoiceTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerinvoicetemplate"></a>
# **UpdateCustomerInvoiceTemplate**
> void UpdateCustomerInvoiceTemplate (CustomerInvoiceTemplate body)

Update a customerInvoiceTemplate

Updates an existing customerInvoiceTemplate using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCustomerInvoiceTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerInvoiceTemplateApi();
            var body = new CustomerInvoiceTemplate(); // CustomerInvoiceTemplate | CustomerInvoiceTemplate to be updated.

            try
            {
                // Update a customerInvoiceTemplate
                apiInstance.UpdateCustomerInvoiceTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerInvoiceTemplateApi.UpdateCustomerInvoiceTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceTemplate**](CustomerInvoiceTemplate.md)| CustomerInvoiceTemplate to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

