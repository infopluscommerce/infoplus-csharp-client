# Infoplus.Api.ReplenishmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReplenishmentAudit**](ReplenishmentApi.md#addreplenishmentaudit) | **PUT** /beta/replenishment/{replenishmentId}/audit/{replenishmentAudit} | Add new audit for a replenishment
[**AddReplenishmentFile**](ReplenishmentApi.md#addreplenishmentfile) | **POST** /beta/replenishment/{replenishmentId}/file/{fileName} | Attach a file to a replenishment
[**AddReplenishmentFileByURL**](ReplenishmentApi.md#addreplenishmentfilebyurl) | **POST** /beta/replenishment/{replenishmentId}/file | Attach a file to a replenishment by URL.
[**AddReplenishmentTag**](ReplenishmentApi.md#addreplenishmenttag) | **PUT** /beta/replenishment/{replenishmentId}/tag/{replenishmentTag} | Add new tags for a replenishment.
[**DeleteReplenishmentFile**](ReplenishmentApi.md#deletereplenishmentfile) | **DELETE** /beta/replenishment/{replenishmentId}/file/{fileId} | Delete a file for a replenishment.
[**DeleteReplenishmentTag**](ReplenishmentApi.md#deletereplenishmenttag) | **DELETE** /beta/replenishment/{replenishmentId}/tag/{replenishmentTag} | Delete a tag for a replenishment.
[**GetDuplicateReplenishmentById**](ReplenishmentApi.md#getduplicatereplenishmentbyid) | **GET** /beta/replenishment/duplicate/{replenishmentId} | Get a duplicated a replenishment by id
[**GetReplenishmentByFilter**](ReplenishmentApi.md#getreplenishmentbyfilter) | **GET** /beta/replenishment/search | Search replenishments by filter
[**GetReplenishmentById**](ReplenishmentApi.md#getreplenishmentbyid) | **GET** /beta/replenishment/{replenishmentId} | Get a replenishment by id
[**GetReplenishmentFiles**](ReplenishmentApi.md#getreplenishmentfiles) | **GET** /beta/replenishment/{replenishmentId}/file | Get the files for a replenishment.
[**GetReplenishmentTags**](ReplenishmentApi.md#getreplenishmenttags) | **GET** /beta/replenishment/{replenishmentId}/tag | Get the tags for a replenishment.
[**UpdateReplenishmentCustomFields**](ReplenishmentApi.md#updatereplenishmentcustomfields) | **PUT** /beta/replenishment/customFields | Update a replenishment custom fields


<a name="addreplenishmentaudit"></a>
# **AddReplenishmentAudit**
> void AddReplenishmentAudit (int? replenishmentId, string replenishmentAudit)

Add new audit for a replenishment

Adds an audit to an existing replenishment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to add an audit to
            var replenishmentAudit = replenishmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a replenishment
                apiInstance.AddReplenishmentAudit(replenishmentId, replenishmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.AddReplenishmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to add an audit to | 
 **replenishmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentfile"></a>
# **AddReplenishmentFile**
> void AddReplenishmentFile (int? replenishmentId, string fileName)

Attach a file to a replenishment

Adds a file to an existing replenishment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a replenishment
                apiInstance.AddReplenishmentFile(replenishmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.AddReplenishmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentfilebyurl"></a>
# **AddReplenishmentFileByURL**
> void AddReplenishmentFileByURL (RecordFile body, int? replenishmentId)

Attach a file to a replenishment by URL.

Adds a file to an existing replenishment by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var replenishmentId = 56;  // int? | Id of the replenishment to add an file to

            try
            {
                // Attach a file to a replenishment by URL.
                apiInstance.AddReplenishmentFileByURL(body, replenishmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.AddReplenishmentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **replenishmentId** | **int?**| Id of the replenishment to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmenttag"></a>
# **AddReplenishmentTag**
> void AddReplenishmentTag (int? replenishmentId, string replenishmentTag)

Add new tags for a replenishment.

Adds a tag to an existing replenishment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to add a tag to
            var replenishmentTag = replenishmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a replenishment.
                apiInstance.AddReplenishmentTag(replenishmentId, replenishmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.AddReplenishmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to add a tag to | 
 **replenishmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereplenishmentfile"></a>
# **DeleteReplenishmentFile**
> void DeleteReplenishmentFile (int? replenishmentId, int? fileId)

Delete a file for a replenishment.

Deletes an existing replenishment file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReplenishmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a replenishment.
                apiInstance.DeleteReplenishmentFile(replenishmentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.DeleteReplenishmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereplenishmenttag"></a>
# **DeleteReplenishmentTag**
> void DeleteReplenishmentTag (int? replenishmentId, string replenishmentTag)

Delete a tag for a replenishment.

Deletes an existing replenishment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReplenishmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to remove tag from
            var replenishmentTag = replenishmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a replenishment.
                apiInstance.DeleteReplenishmentTag(replenishmentId, replenishmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.DeleteReplenishmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to remove tag from | 
 **replenishmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereplenishmentbyid"></a>
# **GetDuplicateReplenishmentById**
> Replenishment GetDuplicateReplenishmentById (int? replenishmentId)

Get a duplicated a replenishment by id

Returns a duplicated replenishment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReplenishmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to be duplicated.

            try
            {
                // Get a duplicated a replenishment by id
                Replenishment result = apiInstance.GetDuplicateReplenishmentById(replenishmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.GetDuplicateReplenishmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to be duplicated. | 

### Return type

[**Replenishment**](Replenishment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentbyfilter"></a>
# **GetReplenishmentByFilter**
> List<Replenishment> GetReplenishmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search replenishments by filter

Returns the list of replenishments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search replenishments by filter
                List&lt;Replenishment&gt; result = apiInstance.GetReplenishmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.GetReplenishmentByFilter: " + e.Message );
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

[**List<Replenishment>**](Replenishment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentbyid"></a>
# **GetReplenishmentById**
> Replenishment GetReplenishmentById (int? replenishmentId)

Get a replenishment by id

Returns the replenishment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to be returned.

            try
            {
                // Get a replenishment by id
                Replenishment result = apiInstance.GetReplenishmentById(replenishmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.GetReplenishmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to be returned. | 

### Return type

[**Replenishment**](Replenishment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentfiles"></a>
# **GetReplenishmentFiles**
> void GetReplenishmentFiles (int? replenishmentId)

Get the files for a replenishment.

Get all existing replenishment files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to get files for

            try
            {
                // Get the files for a replenishment.
                apiInstance.GetReplenishmentFiles(replenishmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.GetReplenishmentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmenttags"></a>
# **GetReplenishmentTags**
> void GetReplenishmentTags (int? replenishmentId)

Get the tags for a replenishment.

Get all existing replenishment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var replenishmentId = 56;  // int? | Id of the replenishment to get tags for

            try
            {
                // Get the tags for a replenishment.
                apiInstance.GetReplenishmentTags(replenishmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.GetReplenishmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentId** | **int?**| Id of the replenishment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereplenishmentcustomfields"></a>
# **UpdateReplenishmentCustomFields**
> void UpdateReplenishmentCustomFields (Replenishment body)

Update a replenishment custom fields

Updates an existing replenishment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReplenishmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentApi();
            var body = new Replenishment(); // Replenishment | Replenishment to be updated.

            try
            {
                // Update a replenishment custom fields
                apiInstance.UpdateReplenishmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentApi.UpdateReplenishmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Replenishment**](Replenishment.md)| Replenishment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

