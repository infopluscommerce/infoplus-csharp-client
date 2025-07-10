# Infoplus.Api.ReturnOrderLineApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReturnOrderLineAudit**](ReturnOrderLineApi.md#addreturnorderlineaudit) | **PUT** /beta/returnOrderLine/{returnOrderLineId}/audit/{returnOrderLineAudit} | Add new audit for a returnOrderLine
[**AddReturnOrderLineFile**](ReturnOrderLineApi.md#addreturnorderlinefile) | **POST** /beta/returnOrderLine/{returnOrderLineId}/file/{fileName} | Attach a file to a returnOrderLine
[**AddReturnOrderLineFileByURL**](ReturnOrderLineApi.md#addreturnorderlinefilebyurl) | **POST** /beta/returnOrderLine/{returnOrderLineId}/file | Attach a file to a returnOrderLine by URL.
[**AddReturnOrderLineTag**](ReturnOrderLineApi.md#addreturnorderlinetag) | **PUT** /beta/returnOrderLine/{returnOrderLineId}/tag/{returnOrderLineTag} | Add new tags for a returnOrderLine.
[**DeleteReturnOrderLineFile**](ReturnOrderLineApi.md#deletereturnorderlinefile) | **DELETE** /beta/returnOrderLine/{returnOrderLineId}/file/{fileId} | Delete a file for a returnOrderLine.
[**DeleteReturnOrderLineTag**](ReturnOrderLineApi.md#deletereturnorderlinetag) | **DELETE** /beta/returnOrderLine/{returnOrderLineId}/tag/{returnOrderLineTag} | Delete a tag for a returnOrderLine.
[**GetDuplicateReturnOrderLineById**](ReturnOrderLineApi.md#getduplicatereturnorderlinebyid) | **GET** /beta/returnOrderLine/duplicate/{returnOrderLineId} | Get a duplicated a returnOrderLine by id
[**GetReturnOrderLineByFilter**](ReturnOrderLineApi.md#getreturnorderlinebyfilter) | **GET** /beta/returnOrderLine/search | Search returnOrderLines by filter
[**GetReturnOrderLineById**](ReturnOrderLineApi.md#getreturnorderlinebyid) | **GET** /beta/returnOrderLine/{returnOrderLineId} | Get a returnOrderLine by id
[**GetReturnOrderLineFiles**](ReturnOrderLineApi.md#getreturnorderlinefiles) | **GET** /beta/returnOrderLine/{returnOrderLineId}/file | Get the files for a returnOrderLine.
[**GetReturnOrderLineTags**](ReturnOrderLineApi.md#getreturnorderlinetags) | **GET** /beta/returnOrderLine/{returnOrderLineId}/tag | Get the tags for a returnOrderLine.
[**UpdateReturnOrderLineCustomFields**](ReturnOrderLineApi.md#updatereturnorderlinecustomfields) | **PUT** /beta/returnOrderLine/customFields | Update a returnOrderLine custom fields


<a name="addreturnorderlineaudit"></a>
# **AddReturnOrderLineAudit**
> void AddReturnOrderLineAudit (int? returnOrderLineId, string returnOrderLineAudit)

Add new audit for a returnOrderLine

Adds an audit to an existing returnOrderLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to add an audit to
            var returnOrderLineAudit = returnOrderLineAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a returnOrderLine
                apiInstance.AddReturnOrderLineAudit(returnOrderLineId, returnOrderLineAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.AddReturnOrderLineAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to add an audit to | 
 **returnOrderLineAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderlinefile"></a>
# **AddReturnOrderLineFile**
> void AddReturnOrderLineFile (int? returnOrderLineId, string fileName)

Attach a file to a returnOrderLine

Adds a file to an existing returnOrderLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a returnOrderLine
                apiInstance.AddReturnOrderLineFile(returnOrderLineId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.AddReturnOrderLineFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderlinefilebyurl"></a>
# **AddReturnOrderLineFileByURL**
> void AddReturnOrderLineFileByURL (RecordFile body, int? returnOrderLineId)

Attach a file to a returnOrderLine by URL.

Adds a file to an existing returnOrderLine by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to add an file to

            try
            {
                // Attach a file to a returnOrderLine by URL.
                apiInstance.AddReturnOrderLineFileByURL(body, returnOrderLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.AddReturnOrderLineFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderlinetag"></a>
# **AddReturnOrderLineTag**
> void AddReturnOrderLineTag (int? returnOrderLineId, string returnOrderLineTag)

Add new tags for a returnOrderLine.

Adds a tag to an existing returnOrderLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to add a tag to
            var returnOrderLineTag = returnOrderLineTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a returnOrderLine.
                apiInstance.AddReturnOrderLineTag(returnOrderLineId, returnOrderLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.AddReturnOrderLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to add a tag to | 
 **returnOrderLineTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnorderlinefile"></a>
# **DeleteReturnOrderLineFile**
> void DeleteReturnOrderLineFile (int? returnOrderLineId, int? fileId)

Delete a file for a returnOrderLine.

Deletes an existing returnOrderLine file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnOrderLineFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a returnOrderLine.
                apiInstance.DeleteReturnOrderLineFile(returnOrderLineId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.DeleteReturnOrderLineFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnorderlinetag"></a>
# **DeleteReturnOrderLineTag**
> void DeleteReturnOrderLineTag (int? returnOrderLineId, string returnOrderLineTag)

Delete a tag for a returnOrderLine.

Deletes an existing returnOrderLine tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnOrderLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to remove tag from
            var returnOrderLineTag = returnOrderLineTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a returnOrderLine.
                apiInstance.DeleteReturnOrderLineTag(returnOrderLineId, returnOrderLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.DeleteReturnOrderLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to remove tag from | 
 **returnOrderLineTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereturnorderlinebyid"></a>
# **GetDuplicateReturnOrderLineById**
> ReturnOrderLine GetDuplicateReturnOrderLineById (int? returnOrderLineId)

Get a duplicated a returnOrderLine by id

Returns a duplicated returnOrderLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReturnOrderLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to be duplicated.

            try
            {
                // Get a duplicated a returnOrderLine by id
                ReturnOrderLine result = apiInstance.GetDuplicateReturnOrderLineById(returnOrderLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.GetDuplicateReturnOrderLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to be duplicated. | 

### Return type

[**ReturnOrderLine**](ReturnOrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinebyfilter"></a>
# **GetReturnOrderLineByFilter**
> List<ReturnOrderLine> GetReturnOrderLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search returnOrderLines by filter

Returns the list of returnOrderLines that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search returnOrderLines by filter
                List&lt;ReturnOrderLine&gt; result = apiInstance.GetReturnOrderLineByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.GetReturnOrderLineByFilter: " + e.Message );
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

[**List<ReturnOrderLine>**](ReturnOrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinebyid"></a>
# **GetReturnOrderLineById**
> ReturnOrderLine GetReturnOrderLineById (int? returnOrderLineId)

Get a returnOrderLine by id

Returns the returnOrderLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to be returned.

            try
            {
                // Get a returnOrderLine by id
                ReturnOrderLine result = apiInstance.GetReturnOrderLineById(returnOrderLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.GetReturnOrderLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to be returned. | 

### Return type

[**ReturnOrderLine**](ReturnOrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinefiles"></a>
# **GetReturnOrderLineFiles**
> void GetReturnOrderLineFiles (int? returnOrderLineId)

Get the files for a returnOrderLine.

Get all existing returnOrderLine files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to get files for

            try
            {
                // Get the files for a returnOrderLine.
                apiInstance.GetReturnOrderLineFiles(returnOrderLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.GetReturnOrderLineFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinetags"></a>
# **GetReturnOrderLineTags**
> void GetReturnOrderLineTags (int? returnOrderLineId)

Get the tags for a returnOrderLine.

Get all existing returnOrderLine tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var returnOrderLineId = 56;  // int? | Id of the returnOrderLine to get tags for

            try
            {
                // Get the tags for a returnOrderLine.
                apiInstance.GetReturnOrderLineTags(returnOrderLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.GetReturnOrderLineTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineId** | **int?**| Id of the returnOrderLine to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereturnorderlinecustomfields"></a>
# **UpdateReturnOrderLineCustomFields**
> void UpdateReturnOrderLineCustomFields (ReturnOrderLine body)

Update a returnOrderLine custom fields

Updates an existing returnOrderLine custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReturnOrderLineCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineApi();
            var body = new ReturnOrderLine(); // ReturnOrderLine | ReturnOrderLine to be updated.

            try
            {
                // Update a returnOrderLine custom fields
                apiInstance.UpdateReturnOrderLineCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineApi.UpdateReturnOrderLineCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnOrderLine**](ReturnOrderLine.md)| ReturnOrderLine to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

