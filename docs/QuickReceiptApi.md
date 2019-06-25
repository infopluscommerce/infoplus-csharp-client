# Infoplus.Api.QuickReceiptApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddQuickReceipt**](QuickReceiptApi.md#addquickreceipt) | **POST** /beta/quickReceipt | Create a quickReceipt
[**AddQuickReceiptAudit**](QuickReceiptApi.md#addquickreceiptaudit) | **PUT** /beta/quickReceipt/{quickReceiptId}/audit/{quickReceiptAudit} | Add new audit for a quickReceipt
[**AddQuickReceiptFile**](QuickReceiptApi.md#addquickreceiptfile) | **POST** /beta/quickReceipt/{quickReceiptId}/file/{fileName} | Attach a file to a quickReceipt
[**AddQuickReceiptTag**](QuickReceiptApi.md#addquickreceipttag) | **PUT** /beta/quickReceipt/{quickReceiptId}/tag/{quickReceiptTag} | Add new tags for a quickReceipt.
[**DeleteQuickReceipt**](QuickReceiptApi.md#deletequickreceipt) | **DELETE** /beta/quickReceipt/{quickReceiptId} | Delete a quickReceipt
[**DeleteQuickReceiptTag**](QuickReceiptApi.md#deletequickreceipttag) | **DELETE** /beta/quickReceipt/{quickReceiptId}/tag/{quickReceiptTag} | Delete a tag for a quickReceipt.
[**ExecuteQuickReceipt**](QuickReceiptApi.md#executequickreceipt) | **POST** /beta/quickReceipt/executeQuickReceipt | Run the ExecuteQuickReceipt process.
[**GetDuplicateQuickReceiptById**](QuickReceiptApi.md#getduplicatequickreceiptbyid) | **GET** /beta/quickReceipt/duplicate/{quickReceiptId} | Get a duplicated a quickReceipt by id
[**GetQuickReceiptByFilter**](QuickReceiptApi.md#getquickreceiptbyfilter) | **GET** /beta/quickReceipt/search | Search quickReceipts by filter
[**GetQuickReceiptById**](QuickReceiptApi.md#getquickreceiptbyid) | **GET** /beta/quickReceipt/{quickReceiptId} | Get a quickReceipt by id
[**GetQuickReceiptTags**](QuickReceiptApi.md#getquickreceipttags) | **GET** /beta/quickReceipt/{quickReceiptId}/tag | Get the tags for a quickReceipt.
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="addquickreceiptaudit"></a>
# **AddQuickReceiptAudit**
> void AddQuickReceiptAudit (int? quickReceiptId, string quickReceiptAudit)

Add new audit for a quickReceipt

Adds an audit to an existing quickReceipt.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickReceiptAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to add an audit to
            var quickReceiptAudit = quickReceiptAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a quickReceipt
                apiInstance.AddQuickReceiptAudit(quickReceiptId, quickReceiptAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.AddQuickReceiptAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to add an audit to | 
 **quickReceiptAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquickreceiptfile"></a>
# **AddQuickReceiptFile**
> void AddQuickReceiptFile (int? quickReceiptId, string fileName)

Attach a file to a quickReceipt

Adds a file to an existing quickReceipt.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickReceiptFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a quickReceipt
                apiInstance.AddQuickReceiptFile(quickReceiptId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.AddQuickReceiptFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquickreceipttag"></a>
# **AddQuickReceiptTag**
> void AddQuickReceiptTag (int? quickReceiptId, string quickReceiptTag)

Add new tags for a quickReceipt.

Adds a tag to an existing quickReceipt.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickReceiptTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to add a tag to
            var quickReceiptTag = quickReceiptTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a quickReceipt.
                apiInstance.AddQuickReceiptTag(quickReceiptId, quickReceiptTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.AddQuickReceiptTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to add a tag to | 
 **quickReceiptTag** | **string**| The tag to add | 

### Return type

void (empty response body)

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="deletequickreceipttag"></a>
# **DeleteQuickReceiptTag**
> void DeleteQuickReceiptTag (int? quickReceiptId, string quickReceiptTag)

Delete a tag for a quickReceipt.

Deletes an existing quickReceipt tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteQuickReceiptTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to remove tag from
            var quickReceiptTag = quickReceiptTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a quickReceipt.
                apiInstance.DeleteQuickReceiptTag(quickReceiptId, quickReceiptTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.DeleteQuickReceiptTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to remove tag from | 
 **quickReceiptTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executequickreceipt"></a>
# **ExecuteQuickReceipt**
> List<ProcessOutputAPIModel> ExecuteQuickReceipt (ExecuteQuickReceiptInputAPIModel body)

Run the ExecuteQuickReceipt process.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class ExecuteQuickReceiptExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var body = new ExecuteQuickReceiptInputAPIModel(); // ExecuteQuickReceiptInputAPIModel | Input data for ExecuteQuickReceipt process.

            try
            {
                // Run the ExecuteQuickReceipt process.
                List&lt;ProcessOutputAPIModel&gt; result = apiInstance.ExecuteQuickReceipt(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.ExecuteQuickReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteQuickReceiptInputAPIModel**](ExecuteQuickReceiptInputAPIModel.md)| Input data for ExecuteQuickReceipt process. | 

### Return type

[**List<ProcessOutputAPIModel>**](ProcessOutputAPIModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatequickreceiptbyid"></a>
# **GetDuplicateQuickReceiptById**
> QuickReceipt GetDuplicateQuickReceiptById (int? quickReceiptId)

Get a duplicated a quickReceipt by id

Returns a duplicated quickReceipt identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateQuickReceiptByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to be duplicated.

            try
            {
                // Get a duplicated a quickReceipt by id
                QuickReceipt result = apiInstance.GetDuplicateQuickReceiptById(quickReceiptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.GetDuplicateQuickReceiptById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to be duplicated. | 

### Return type

[**QuickReceipt**](QuickReceipt.md)

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getquickreceipttags"></a>
# **GetQuickReceiptTags**
> void GetQuickReceiptTags (int? quickReceiptId)

Get the tags for a quickReceipt.

Get all existing quickReceipt tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickReceiptTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickReceiptApi();
            var quickReceiptId = 56;  // int? | Id of the quickReceipt to get tags for

            try
            {
                // Get the tags for a quickReceipt.
                apiInstance.GetQuickReceiptTags(quickReceiptId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickReceiptApi.GetQuickReceiptTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickReceiptId** | **int?**| Id of the quickReceipt to get tags for | 

### Return type

void (empty response body)

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

