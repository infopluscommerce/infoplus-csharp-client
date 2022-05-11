# Infoplus.Api.ReceivingProcessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReceivingProcessAudit**](ReceivingProcessApi.md#addreceivingprocessaudit) | **PUT** /v3.0/receivingProcess/{receivingProcessId}/audit/{receivingProcessAudit} | Add new audit for a receivingProcess
[**AddReceivingProcessFile**](ReceivingProcessApi.md#addreceivingprocessfile) | **POST** /v3.0/receivingProcess/{receivingProcessId}/file/{fileName} | Attach a file to a receivingProcess
[**AddReceivingProcessFileByURL**](ReceivingProcessApi.md#addreceivingprocessfilebyurl) | **POST** /v3.0/receivingProcess/{receivingProcessId}/file | Attach a file to a receivingProcess by URL.
[**AddReceivingProcessTag**](ReceivingProcessApi.md#addreceivingprocesstag) | **PUT** /v3.0/receivingProcess/{receivingProcessId}/tag/{receivingProcessTag} | Add new tags for a receivingProcess.
[**DeleteReceivingProcessFile**](ReceivingProcessApi.md#deletereceivingprocessfile) | **DELETE** /v3.0/receivingProcess/{receivingProcessId}/file/{fileId} | Delete a file for a receivingProcess.
[**DeleteReceivingProcessTag**](ReceivingProcessApi.md#deletereceivingprocesstag) | **DELETE** /v3.0/receivingProcess/{receivingProcessId}/tag/{receivingProcessTag} | Delete a tag for a receivingProcess.
[**GetDuplicateReceivingProcessById**](ReceivingProcessApi.md#getduplicatereceivingprocessbyid) | **GET** /v3.0/receivingProcess/duplicate/{receivingProcessId} | Get a duplicated a receivingProcess by id
[**GetReceivingProcessByFilter**](ReceivingProcessApi.md#getreceivingprocessbyfilter) | **GET** /v3.0/receivingProcess/search | Search receivingProcesses by filter
[**GetReceivingProcessById**](ReceivingProcessApi.md#getreceivingprocessbyid) | **GET** /v3.0/receivingProcess/{receivingProcessId} | Get a receivingProcess by id
[**GetReceivingProcessFiles**](ReceivingProcessApi.md#getreceivingprocessfiles) | **GET** /v3.0/receivingProcess/{receivingProcessId}/file | Get the files for a receivingProcess.
[**GetReceivingProcessTags**](ReceivingProcessApi.md#getreceivingprocesstags) | **GET** /v3.0/receivingProcess/{receivingProcessId}/tag | Get the tags for a receivingProcess.
[**UpdateReceivingProcessCustomFields**](ReceivingProcessApi.md#updatereceivingprocesscustomfields) | **PUT** /v3.0/receivingProcess/customFields | Update a receivingProcess custom fields


<a name="addreceivingprocessaudit"></a>
# **AddReceivingProcessAudit**
> void AddReceivingProcessAudit (int? receivingProcessId, string receivingProcessAudit)

Add new audit for a receivingProcess

Adds an audit to an existing receivingProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingProcessAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to add an audit to
            var receivingProcessAudit = receivingProcessAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a receivingProcess
                apiInstance.AddReceivingProcessAudit(receivingProcessId, receivingProcessAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.AddReceivingProcessAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to add an audit to | 
 **receivingProcessAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreceivingprocessfile"></a>
# **AddReceivingProcessFile**
> void AddReceivingProcessFile (int? receivingProcessId, string fileName)

Attach a file to a receivingProcess

Adds a file to an existing receivingProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingProcessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a receivingProcess
                apiInstance.AddReceivingProcessFile(receivingProcessId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.AddReceivingProcessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreceivingprocessfilebyurl"></a>
# **AddReceivingProcessFileByURL**
> void AddReceivingProcessFileByURL (RecordFile body, int? receivingProcessId)

Attach a file to a receivingProcess by URL.

Adds a file to an existing receivingProcess by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingProcessFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to add an file to

            try
            {
                // Attach a file to a receivingProcess by URL.
                apiInstance.AddReceivingProcessFileByURL(body, receivingProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.AddReceivingProcessFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **receivingProcessId** | **int?**| Id of the receivingProcess to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreceivingprocesstag"></a>
# **AddReceivingProcessTag**
> void AddReceivingProcessTag (int? receivingProcessId, string receivingProcessTag)

Add new tags for a receivingProcess.

Adds a tag to an existing receivingProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingProcessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to add a tag to
            var receivingProcessTag = receivingProcessTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a receivingProcess.
                apiInstance.AddReceivingProcessTag(receivingProcessId, receivingProcessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.AddReceivingProcessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to add a tag to | 
 **receivingProcessTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereceivingprocessfile"></a>
# **DeleteReceivingProcessFile**
> void DeleteReceivingProcessFile (int? receivingProcessId, int? fileId)

Delete a file for a receivingProcess.

Deletes an existing receivingProcess file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReceivingProcessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a receivingProcess.
                apiInstance.DeleteReceivingProcessFile(receivingProcessId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.DeleteReceivingProcessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereceivingprocesstag"></a>
# **DeleteReceivingProcessTag**
> void DeleteReceivingProcessTag (int? receivingProcessId, string receivingProcessTag)

Delete a tag for a receivingProcess.

Deletes an existing receivingProcess tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReceivingProcessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to remove tag from
            var receivingProcessTag = receivingProcessTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a receivingProcess.
                apiInstance.DeleteReceivingProcessTag(receivingProcessId, receivingProcessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.DeleteReceivingProcessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to remove tag from | 
 **receivingProcessTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereceivingprocessbyid"></a>
# **GetDuplicateReceivingProcessById**
> ReceivingProcess GetDuplicateReceivingProcessById (int? receivingProcessId)

Get a duplicated a receivingProcess by id

Returns a duplicated receivingProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReceivingProcessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to be duplicated.

            try
            {
                // Get a duplicated a receivingProcess by id
                ReceivingProcess result = apiInstance.GetDuplicateReceivingProcessById(receivingProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetDuplicateReceivingProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to be duplicated. | 

### Return type

[**ReceivingProcess**](ReceivingProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingprocessbyfilter"></a>
# **GetReceivingProcessByFilter**
> List<ReceivingProcess> GetReceivingProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search receivingProcesses by filter

Returns the list of receivingProcesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingProcessByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search receivingProcesses by filter
                List&lt;ReceivingProcess&gt; result = apiInstance.GetReceivingProcessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetReceivingProcessByFilter: " + e.Message );
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

[**List<ReceivingProcess>**](ReceivingProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingprocessbyid"></a>
# **GetReceivingProcessById**
> ReceivingProcess GetReceivingProcessById (int? receivingProcessId)

Get a receivingProcess by id

Returns the receivingProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingProcessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to be returned.

            try
            {
                // Get a receivingProcess by id
                ReceivingProcess result = apiInstance.GetReceivingProcessById(receivingProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetReceivingProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to be returned. | 

### Return type

[**ReceivingProcess**](ReceivingProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingprocessfiles"></a>
# **GetReceivingProcessFiles**
> void GetReceivingProcessFiles (int? receivingProcessId)

Get the files for a receivingProcess.

Get all existing receivingProcess files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingProcessFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to get files for

            try
            {
                // Get the files for a receivingProcess.
                apiInstance.GetReceivingProcessFiles(receivingProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetReceivingProcessFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingprocesstags"></a>
# **GetReceivingProcessTags**
> void GetReceivingProcessTags (int? receivingProcessId)

Get the tags for a receivingProcess.

Get all existing receivingProcess tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingProcessTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to get tags for

            try
            {
                // Get the tags for a receivingProcess.
                apiInstance.GetReceivingProcessTags(receivingProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetReceivingProcessTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereceivingprocesscustomfields"></a>
# **UpdateReceivingProcessCustomFields**
> void UpdateReceivingProcessCustomFields (ReceivingProcess body)

Update a receivingProcess custom fields

Updates an existing receivingProcess custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReceivingProcessCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var body = new ReceivingProcess(); // ReceivingProcess | ReceivingProcess to be updated.

            try
            {
                // Update a receivingProcess custom fields
                apiInstance.UpdateReceivingProcessCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.UpdateReceivingProcessCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReceivingProcess**](ReceivingProcess.md)| ReceivingProcess to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

