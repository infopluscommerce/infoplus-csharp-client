# Infoplus.Api.QuickAdjustmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddQuickAdjustment**](QuickAdjustmentApi.md#addquickadjustment) | **POST** /beta/quickAdjustment | Create a quickAdjustment
[**AddQuickAdjustmentAudit**](QuickAdjustmentApi.md#addquickadjustmentaudit) | **PUT** /beta/quickAdjustment/{quickAdjustmentId}/audit/{quickAdjustmentAudit} | Add new audit for a quickAdjustment
[**AddQuickAdjustmentFile**](QuickAdjustmentApi.md#addquickadjustmentfile) | **POST** /beta/quickAdjustment/{quickAdjustmentId}/file/{fileName} | Attach a file to a quickAdjustment
[**AddQuickAdjustmentFileByURL**](QuickAdjustmentApi.md#addquickadjustmentfilebyurl) | **POST** /beta/quickAdjustment/{quickAdjustmentId}/file | Attach a file to a quickAdjustment by URL.
[**AddQuickAdjustmentTag**](QuickAdjustmentApi.md#addquickadjustmenttag) | **PUT** /beta/quickAdjustment/{quickAdjustmentId}/tag/{quickAdjustmentTag} | Add new tags for a quickAdjustment.
[**DeleteQuickAdjustment**](QuickAdjustmentApi.md#deletequickadjustment) | **DELETE** /beta/quickAdjustment/{quickAdjustmentId} | Delete a quickAdjustment
[**DeleteQuickAdjustmentFile**](QuickAdjustmentApi.md#deletequickadjustmentfile) | **DELETE** /beta/quickAdjustment/{quickAdjustmentId}/file/{fileId} | Delete a file for a quickAdjustment.
[**DeleteQuickAdjustmentTag**](QuickAdjustmentApi.md#deletequickadjustmenttag) | **DELETE** /beta/quickAdjustment/{quickAdjustmentId}/tag/{quickAdjustmentTag} | Delete a tag for a quickAdjustment.
[**ExecuteQuickAdjustment**](QuickAdjustmentApi.md#executequickadjustment) | **POST** /beta/quickAdjustment/executeQuickAdjustment | Run the ExecuteQuickAdjustment process.
[**GetDuplicateQuickAdjustmentById**](QuickAdjustmentApi.md#getduplicatequickadjustmentbyid) | **GET** /beta/quickAdjustment/duplicate/{quickAdjustmentId} | Get a duplicated a quickAdjustment by id
[**GetQuickAdjustmentByFilter**](QuickAdjustmentApi.md#getquickadjustmentbyfilter) | **GET** /beta/quickAdjustment/search | Search quickAdjustments by filter
[**GetQuickAdjustmentById**](QuickAdjustmentApi.md#getquickadjustmentbyid) | **GET** /beta/quickAdjustment/{quickAdjustmentId} | Get a quickAdjustment by id
[**GetQuickAdjustmentFiles**](QuickAdjustmentApi.md#getquickadjustmentfiles) | **GET** /beta/quickAdjustment/{quickAdjustmentId}/file | Get the files for a quickAdjustment.
[**GetQuickAdjustmentTags**](QuickAdjustmentApi.md#getquickadjustmenttags) | **GET** /beta/quickAdjustment/{quickAdjustmentId}/tag | Get the tags for a quickAdjustment.
[**UpdateQuickAdjustment**](QuickAdjustmentApi.md#updatequickadjustment) | **PUT** /beta/quickAdjustment | Update a quickAdjustment
[**UpdateQuickAdjustmentCustomFields**](QuickAdjustmentApi.md#updatequickadjustmentcustomfields) | **PUT** /beta/quickAdjustment/customFields | Update a quickAdjustment custom fields


<a name="addquickadjustment"></a>
# **AddQuickAdjustment**
> QuickAdjustment AddQuickAdjustment (QuickAdjustment body)

Create a quickAdjustment

Inserts a new quickAdjustment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickAdjustmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var body = new QuickAdjustment(); // QuickAdjustment | QuickAdjustment to be inserted.

            try
            {
                // Create a quickAdjustment
                QuickAdjustment result = apiInstance.AddQuickAdjustment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.AddQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickAdjustment**](QuickAdjustment.md)| QuickAdjustment to be inserted. | 

### Return type

[**QuickAdjustment**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquickadjustmentaudit"></a>
# **AddQuickAdjustmentAudit**
> void AddQuickAdjustmentAudit (int? quickAdjustmentId, string quickAdjustmentAudit)

Add new audit for a quickAdjustment

Adds an audit to an existing quickAdjustment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickAdjustmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to add an audit to
            var quickAdjustmentAudit = quickAdjustmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a quickAdjustment
                apiInstance.AddQuickAdjustmentAudit(quickAdjustmentId, quickAdjustmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.AddQuickAdjustmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to add an audit to | 
 **quickAdjustmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquickadjustmentfile"></a>
# **AddQuickAdjustmentFile**
> void AddQuickAdjustmentFile (int? quickAdjustmentId, string fileName)

Attach a file to a quickAdjustment

Adds a file to an existing quickAdjustment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickAdjustmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a quickAdjustment
                apiInstance.AddQuickAdjustmentFile(quickAdjustmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.AddQuickAdjustmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquickadjustmentfilebyurl"></a>
# **AddQuickAdjustmentFileByURL**
> void AddQuickAdjustmentFileByURL (RecordFile body, int? quickAdjustmentId)

Attach a file to a quickAdjustment by URL.

Adds a file to an existing quickAdjustment by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickAdjustmentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to add an file to

            try
            {
                // Attach a file to a quickAdjustment by URL.
                apiInstance.AddQuickAdjustmentFileByURL(body, quickAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.AddQuickAdjustmentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquickadjustmenttag"></a>
# **AddQuickAdjustmentTag**
> void AddQuickAdjustmentTag (int? quickAdjustmentId, string quickAdjustmentTag)

Add new tags for a quickAdjustment.

Adds a tag to an existing quickAdjustment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddQuickAdjustmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to add a tag to
            var quickAdjustmentTag = quickAdjustmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a quickAdjustment.
                apiInstance.AddQuickAdjustmentTag(quickAdjustmentId, quickAdjustmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.AddQuickAdjustmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to add a tag to | 
 **quickAdjustmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequickadjustment"></a>
# **DeleteQuickAdjustment**
> void DeleteQuickAdjustment (int? quickAdjustmentId)

Delete a quickAdjustment

Deletes the quickAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteQuickAdjustmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to be deleted.

            try
            {
                // Delete a quickAdjustment
                apiInstance.DeleteQuickAdjustment(quickAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.DeleteQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequickadjustmentfile"></a>
# **DeleteQuickAdjustmentFile**
> void DeleteQuickAdjustmentFile (int? quickAdjustmentId, int? fileId)

Delete a file for a quickAdjustment.

Deletes an existing quickAdjustment file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteQuickAdjustmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a quickAdjustment.
                apiInstance.DeleteQuickAdjustmentFile(quickAdjustmentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.DeleteQuickAdjustmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequickadjustmenttag"></a>
# **DeleteQuickAdjustmentTag**
> void DeleteQuickAdjustmentTag (int? quickAdjustmentId, string quickAdjustmentTag)

Delete a tag for a quickAdjustment.

Deletes an existing quickAdjustment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteQuickAdjustmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to remove tag from
            var quickAdjustmentTag = quickAdjustmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a quickAdjustment.
                apiInstance.DeleteQuickAdjustmentTag(quickAdjustmentId, quickAdjustmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.DeleteQuickAdjustmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to remove tag from | 
 **quickAdjustmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executequickadjustment"></a>
# **ExecuteQuickAdjustment**
> List<ProcessOutputAPIModel> ExecuteQuickAdjustment (ExecuteQuickAdjustmentInputAPIModel body)

Run the ExecuteQuickAdjustment process.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class ExecuteQuickAdjustmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var body = new ExecuteQuickAdjustmentInputAPIModel(); // ExecuteQuickAdjustmentInputAPIModel | Input data for ExecuteQuickAdjustment process.

            try
            {
                // Run the ExecuteQuickAdjustment process.
                List&lt;ProcessOutputAPIModel&gt; result = apiInstance.ExecuteQuickAdjustment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.ExecuteQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteQuickAdjustmentInputAPIModel**](ExecuteQuickAdjustmentInputAPIModel.md)| Input data for ExecuteQuickAdjustment process. | 

### Return type

[**List<ProcessOutputAPIModel>**](ProcessOutputAPIModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatequickadjustmentbyid"></a>
# **GetDuplicateQuickAdjustmentById**
> QuickAdjustment GetDuplicateQuickAdjustmentById (int? quickAdjustmentId)

Get a duplicated a quickAdjustment by id

Returns a duplicated quickAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateQuickAdjustmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to be duplicated.

            try
            {
                // Get a duplicated a quickAdjustment by id
                QuickAdjustment result = apiInstance.GetDuplicateQuickAdjustmentById(quickAdjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetDuplicateQuickAdjustmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to be duplicated. | 

### Return type

[**QuickAdjustment**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquickadjustmentbyfilter"></a>
# **GetQuickAdjustmentByFilter**
> List<QuickAdjustment> GetQuickAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search quickAdjustments by filter

Returns the list of quickAdjustments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickAdjustmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search quickAdjustments by filter
                List&lt;QuickAdjustment&gt; result = apiInstance.GetQuickAdjustmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetQuickAdjustmentByFilter: " + e.Message );
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

[**List<QuickAdjustment>**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquickadjustmentbyid"></a>
# **GetQuickAdjustmentById**
> QuickAdjustment GetQuickAdjustmentById (int? quickAdjustmentId)

Get a quickAdjustment by id

Returns the quickAdjustment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickAdjustmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to be returned.

            try
            {
                // Get a quickAdjustment by id
                QuickAdjustment result = apiInstance.GetQuickAdjustmentById(quickAdjustmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetQuickAdjustmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to be returned. | 

### Return type

[**QuickAdjustment**](QuickAdjustment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquickadjustmentfiles"></a>
# **GetQuickAdjustmentFiles**
> void GetQuickAdjustmentFiles (int? quickAdjustmentId)

Get the files for a quickAdjustment.

Get all existing quickAdjustment files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickAdjustmentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to get files for

            try
            {
                // Get the files for a quickAdjustment.
                apiInstance.GetQuickAdjustmentFiles(quickAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetQuickAdjustmentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquickadjustmenttags"></a>
# **GetQuickAdjustmentTags**
> void GetQuickAdjustmentTags (int? quickAdjustmentId)

Get the tags for a quickAdjustment.

Get all existing quickAdjustment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetQuickAdjustmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var quickAdjustmentId = 56;  // int? | Id of the quickAdjustment to get tags for

            try
            {
                // Get the tags for a quickAdjustment.
                apiInstance.GetQuickAdjustmentTags(quickAdjustmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.GetQuickAdjustmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickAdjustmentId** | **int?**| Id of the quickAdjustment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequickadjustment"></a>
# **UpdateQuickAdjustment**
> void UpdateQuickAdjustment (QuickAdjustment body)

Update a quickAdjustment

Updates an existing quickAdjustment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateQuickAdjustmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var body = new QuickAdjustment(); // QuickAdjustment | QuickAdjustment to be updated.

            try
            {
                // Update a quickAdjustment
                apiInstance.UpdateQuickAdjustment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.UpdateQuickAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickAdjustment**](QuickAdjustment.md)| QuickAdjustment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequickadjustmentcustomfields"></a>
# **UpdateQuickAdjustmentCustomFields**
> void UpdateQuickAdjustmentCustomFields (QuickAdjustment body)

Update a quickAdjustment custom fields

Updates an existing quickAdjustment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateQuickAdjustmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new QuickAdjustmentApi();
            var body = new QuickAdjustment(); // QuickAdjustment | QuickAdjustment to be updated.

            try
            {
                // Update a quickAdjustment custom fields
                apiInstance.UpdateQuickAdjustmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickAdjustmentApi.UpdateQuickAdjustmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuickAdjustment**](QuickAdjustment.md)| QuickAdjustment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

