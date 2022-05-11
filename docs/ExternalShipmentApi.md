# Infoplus.Api.ExternalShipmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddExternalShipment**](ExternalShipmentApi.md#addexternalshipment) | **POST** /v3.0/externalShipment | Create an externalShipment
[**AddExternalShipmentAudit**](ExternalShipmentApi.md#addexternalshipmentaudit) | **PUT** /v3.0/externalShipment/{externalShipmentId}/audit/{externalShipmentAudit} | Add new audit for an externalShipment
[**AddExternalShipmentFile**](ExternalShipmentApi.md#addexternalshipmentfile) | **POST** /v3.0/externalShipment/{externalShipmentId}/file/{fileName} | Attach a file to an externalShipment
[**AddExternalShipmentFileByURL**](ExternalShipmentApi.md#addexternalshipmentfilebyurl) | **POST** /v3.0/externalShipment/{externalShipmentId}/file | Attach a file to an externalShipment by URL.
[**AddExternalShipmentTag**](ExternalShipmentApi.md#addexternalshipmenttag) | **PUT** /v3.0/externalShipment/{externalShipmentId}/tag/{externalShipmentTag} | Add new tags for an externalShipment.
[**DeleteExternalShipment**](ExternalShipmentApi.md#deleteexternalshipment) | **DELETE** /v3.0/externalShipment/{externalShipmentId} | Delete an externalShipment
[**DeleteExternalShipmentFile**](ExternalShipmentApi.md#deleteexternalshipmentfile) | **DELETE** /v3.0/externalShipment/{externalShipmentId}/file/{fileId} | Delete a file for an externalShipment.
[**DeleteExternalShipmentTag**](ExternalShipmentApi.md#deleteexternalshipmenttag) | **DELETE** /v3.0/externalShipment/{externalShipmentId}/tag/{externalShipmentTag} | Delete a tag for an externalShipment.
[**GetDuplicateExternalShipmentById**](ExternalShipmentApi.md#getduplicateexternalshipmentbyid) | **GET** /v3.0/externalShipment/duplicate/{externalShipmentId} | Get a duplicated an externalShipment by id
[**GetExternalShipmentByFilter**](ExternalShipmentApi.md#getexternalshipmentbyfilter) | **GET** /v3.0/externalShipment/search | Search externalShipments by filter
[**GetExternalShipmentById**](ExternalShipmentApi.md#getexternalshipmentbyid) | **GET** /v3.0/externalShipment/{externalShipmentId} | Get an externalShipment by id
[**GetExternalShipmentFiles**](ExternalShipmentApi.md#getexternalshipmentfiles) | **GET** /v3.0/externalShipment/{externalShipmentId}/file | Get the files for an externalShipment.
[**GetExternalShipmentTags**](ExternalShipmentApi.md#getexternalshipmenttags) | **GET** /v3.0/externalShipment/{externalShipmentId}/tag | Get the tags for an externalShipment.
[**UpdateExternalShipment**](ExternalShipmentApi.md#updateexternalshipment) | **PUT** /v3.0/externalShipment | Update an externalShipment
[**UpdateExternalShipmentCustomFields**](ExternalShipmentApi.md#updateexternalshipmentcustomfields) | **PUT** /v3.0/externalShipment/customFields | Update an externalShipment custom fields


<a name="addexternalshipment"></a>
# **AddExternalShipment**
> ExternalShipment AddExternalShipment (ExternalShipment body)

Create an externalShipment

Inserts a new externalShipment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShipmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var body = new ExternalShipment(); // ExternalShipment | ExternalShipment to be inserted.

            try
            {
                // Create an externalShipment
                ExternalShipment result = apiInstance.AddExternalShipment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.AddExternalShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShipment**](ExternalShipment.md)| ExternalShipment to be inserted. | 

### Return type

[**ExternalShipment**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexternalshipmentaudit"></a>
# **AddExternalShipmentAudit**
> void AddExternalShipmentAudit (int? externalShipmentId, string externalShipmentAudit)

Add new audit for an externalShipment

Adds an audit to an existing externalShipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShipmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to add an audit to
            var externalShipmentAudit = externalShipmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an externalShipment
                apiInstance.AddExternalShipmentAudit(externalShipmentId, externalShipmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.AddExternalShipmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to add an audit to | 
 **externalShipmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexternalshipmentfile"></a>
# **AddExternalShipmentFile**
> void AddExternalShipmentFile (int? externalShipmentId, string fileName)

Attach a file to an externalShipment

Adds a file to an existing externalShipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShipmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an externalShipment
                apiInstance.AddExternalShipmentFile(externalShipmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.AddExternalShipmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexternalshipmentfilebyurl"></a>
# **AddExternalShipmentFileByURL**
> void AddExternalShipmentFileByURL (RecordFile body, int? externalShipmentId)

Attach a file to an externalShipment by URL.

Adds a file to an existing externalShipment by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShipmentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var externalShipmentId = 56;  // int? | Id of the externalShipment to add an file to

            try
            {
                // Attach a file to an externalShipment by URL.
                apiInstance.AddExternalShipmentFileByURL(body, externalShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.AddExternalShipmentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **externalShipmentId** | **int?**| Id of the externalShipment to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexternalshipmenttag"></a>
# **AddExternalShipmentTag**
> void AddExternalShipmentTag (int? externalShipmentId, string externalShipmentTag)

Add new tags for an externalShipment.

Adds a tag to an existing externalShipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShipmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to add a tag to
            var externalShipmentTag = externalShipmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an externalShipment.
                apiInstance.AddExternalShipmentTag(externalShipmentId, externalShipmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.AddExternalShipmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to add a tag to | 
 **externalShipmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexternalshipment"></a>
# **DeleteExternalShipment**
> void DeleteExternalShipment (int? externalShipmentId)

Delete an externalShipment

Deletes the externalShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteExternalShipmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to be deleted.

            try
            {
                // Delete an externalShipment
                apiInstance.DeleteExternalShipment(externalShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.DeleteExternalShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexternalshipmentfile"></a>
# **DeleteExternalShipmentFile**
> void DeleteExternalShipmentFile (int? externalShipmentId, int? fileId)

Delete a file for an externalShipment.

Deletes an existing externalShipment file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteExternalShipmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an externalShipment.
                apiInstance.DeleteExternalShipmentFile(externalShipmentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.DeleteExternalShipmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexternalshipmenttag"></a>
# **DeleteExternalShipmentTag**
> void DeleteExternalShipmentTag (int? externalShipmentId, string externalShipmentTag)

Delete a tag for an externalShipment.

Deletes an existing externalShipment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteExternalShipmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to remove tag from
            var externalShipmentTag = externalShipmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an externalShipment.
                apiInstance.DeleteExternalShipmentTag(externalShipmentId, externalShipmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.DeleteExternalShipmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to remove tag from | 
 **externalShipmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateexternalshipmentbyid"></a>
# **GetDuplicateExternalShipmentById**
> ExternalShipment GetDuplicateExternalShipmentById (int? externalShipmentId)

Get a duplicated an externalShipment by id

Returns a duplicated externalShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateExternalShipmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to be duplicated.

            try
            {
                // Get a duplicated an externalShipment by id
                ExternalShipment result = apiInstance.GetDuplicateExternalShipmentById(externalShipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetDuplicateExternalShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to be duplicated. | 

### Return type

[**ExternalShipment**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshipmentbyfilter"></a>
# **GetExternalShipmentByFilter**
> List<ExternalShipment> GetExternalShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search externalShipments by filter

Returns the list of externalShipments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShipmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search externalShipments by filter
                List&lt;ExternalShipment&gt; result = apiInstance.GetExternalShipmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetExternalShipmentByFilter: " + e.Message );
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

[**List<ExternalShipment>**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshipmentbyid"></a>
# **GetExternalShipmentById**
> ExternalShipment GetExternalShipmentById (int? externalShipmentId)

Get an externalShipment by id

Returns the externalShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShipmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to be returned.

            try
            {
                // Get an externalShipment by id
                ExternalShipment result = apiInstance.GetExternalShipmentById(externalShipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetExternalShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to be returned. | 

### Return type

[**ExternalShipment**](ExternalShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshipmentfiles"></a>
# **GetExternalShipmentFiles**
> void GetExternalShipmentFiles (int? externalShipmentId)

Get the files for an externalShipment.

Get all existing externalShipment files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShipmentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to get files for

            try
            {
                // Get the files for an externalShipment.
                apiInstance.GetExternalShipmentFiles(externalShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetExternalShipmentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshipmenttags"></a>
# **GetExternalShipmentTags**
> void GetExternalShipmentTags (int? externalShipmentId)

Get the tags for an externalShipment.

Get all existing externalShipment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShipmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var externalShipmentId = 56;  // int? | Id of the externalShipment to get tags for

            try
            {
                // Get the tags for an externalShipment.
                apiInstance.GetExternalShipmentTags(externalShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.GetExternalShipmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **int?**| Id of the externalShipment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexternalshipment"></a>
# **UpdateExternalShipment**
> void UpdateExternalShipment (ExternalShipment body)

Update an externalShipment

Updates an existing externalShipment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateExternalShipmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var body = new ExternalShipment(); // ExternalShipment | ExternalShipment to be updated.

            try
            {
                // Update an externalShipment
                apiInstance.UpdateExternalShipment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.UpdateExternalShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShipment**](ExternalShipment.md)| ExternalShipment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexternalshipmentcustomfields"></a>
# **UpdateExternalShipmentCustomFields**
> void UpdateExternalShipmentCustomFields (ExternalShipment body)

Update an externalShipment custom fields

Updates an existing externalShipment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateExternalShipmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShipmentApi();
            var body = new ExternalShipment(); // ExternalShipment | ExternalShipment to be updated.

            try
            {
                // Update an externalShipment custom fields
                apiInstance.UpdateExternalShipmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShipmentApi.UpdateExternalShipmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShipment**](ExternalShipment.md)| ExternalShipment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

