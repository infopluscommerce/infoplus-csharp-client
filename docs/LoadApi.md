# Infoplus.Api.LoadApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLoadAudit**](LoadApi.md#addloadaudit) | **PUT** /v3.0/load/{loadId}/audit/{loadAudit} | Add new audit for a load
[**AddLoadFile**](LoadApi.md#addloadfile) | **POST** /v3.0/load/{loadId}/file/{fileName} | Attach a file to a load
[**AddLoadFileByURL**](LoadApi.md#addloadfilebyurl) | **POST** /v3.0/load/{loadId}/file | Attach a file to a load by URL.
[**AddLoadTag**](LoadApi.md#addloadtag) | **PUT** /v3.0/load/{loadId}/tag/{loadTag} | Add new tags for a load.
[**DeleteLoadFile**](LoadApi.md#deleteloadfile) | **DELETE** /v3.0/load/{loadId}/file/{fileId} | Delete a file for a load.
[**DeleteLoadTag**](LoadApi.md#deleteloadtag) | **DELETE** /v3.0/load/{loadId}/tag/{loadTag} | Delete a tag for a load.
[**GetDuplicateLoadById**](LoadApi.md#getduplicateloadbyid) | **GET** /v3.0/load/duplicate/{loadId} | Get a duplicated a load by id
[**GetLoadByFilter**](LoadApi.md#getloadbyfilter) | **GET** /v3.0/load/search | Search loads by filter
[**GetLoadById**](LoadApi.md#getloadbyid) | **GET** /v3.0/load/{loadId} | Get a load by id
[**GetLoadFiles**](LoadApi.md#getloadfiles) | **GET** /v3.0/load/{loadId}/file | Get the files for a load.
[**GetLoadTags**](LoadApi.md#getloadtags) | **GET** /v3.0/load/{loadId}/tag | Get the tags for a load.
[**UpdateLoadCustomFields**](LoadApi.md#updateloadcustomfields) | **PUT** /v3.0/load/customFields | Update a load custom fields


<a name="addloadaudit"></a>
# **AddLoadAudit**
> void AddLoadAudit (int? loadId, string loadAudit)

Add new audit for a load

Adds an audit to an existing load.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to add an audit to
            var loadAudit = loadAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a load
                apiInstance.AddLoadAudit(loadId, loadAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.AddLoadAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to add an audit to | 
 **loadAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloadfile"></a>
# **AddLoadFile**
> void AddLoadFile (int? loadId, string fileName)

Attach a file to a load

Adds a file to an existing load.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a load
                apiInstance.AddLoadFile(loadId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.AddLoadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloadfilebyurl"></a>
# **AddLoadFileByURL**
> void AddLoadFileByURL (RecordFile body, int? loadId)

Attach a file to a load by URL.

Adds a file to an existing load by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var loadId = 56;  // int? | Id of the load to add an file to

            try
            {
                // Attach a file to a load by URL.
                apiInstance.AddLoadFileByURL(body, loadId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.AddLoadFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **loadId** | **int?**| Id of the load to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addloadtag"></a>
# **AddLoadTag**
> void AddLoadTag (int? loadId, string loadTag)

Add new tags for a load.

Adds a tag to an existing load.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLoadTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to add a tag to
            var loadTag = loadTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a load.
                apiInstance.AddLoadTag(loadId, loadTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.AddLoadTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to add a tag to | 
 **loadTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloadfile"></a>
# **DeleteLoadFile**
> void DeleteLoadFile (int? loadId, int? fileId)

Delete a file for a load.

Deletes an existing load file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLoadFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a load.
                apiInstance.DeleteLoadFile(loadId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.DeleteLoadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloadtag"></a>
# **DeleteLoadTag**
> void DeleteLoadTag (int? loadId, string loadTag)

Delete a tag for a load.

Deletes an existing load tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLoadTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to remove tag from
            var loadTag = loadTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a load.
                apiInstance.DeleteLoadTag(loadId, loadTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.DeleteLoadTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to remove tag from | 
 **loadTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateloadbyid"></a>
# **GetDuplicateLoadById**
> Load GetDuplicateLoadById (int? loadId)

Get a duplicated a load by id

Returns a duplicated load identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLoadByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to be duplicated.

            try
            {
                // Get a duplicated a load by id
                Load result = apiInstance.GetDuplicateLoadById(loadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.GetDuplicateLoadById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to be duplicated. | 

### Return type

[**Load**](Load.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadbyfilter"></a>
# **GetLoadByFilter**
> List<Load> GetLoadByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search loads by filter

Returns the list of loads that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search loads by filter
                List&lt;Load&gt; result = apiInstance.GetLoadByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.GetLoadByFilter: " + e.Message );
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

[**List<Load>**](Load.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadbyid"></a>
# **GetLoadById**
> Load GetLoadById (int? loadId)

Get a load by id

Returns the load identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to be returned.

            try
            {
                // Get a load by id
                Load result = apiInstance.GetLoadById(loadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.GetLoadById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to be returned. | 

### Return type

[**Load**](Load.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadfiles"></a>
# **GetLoadFiles**
> void GetLoadFiles (int? loadId)

Get the files for a load.

Get all existing load files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to get files for

            try
            {
                // Get the files for a load.
                apiInstance.GetLoadFiles(loadId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.GetLoadFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloadtags"></a>
# **GetLoadTags**
> void GetLoadTags (int? loadId)

Get the tags for a load.

Get all existing load tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLoadTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var loadId = 56;  // int? | Id of the load to get tags for

            try
            {
                // Get the tags for a load.
                apiInstance.GetLoadTags(loadId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.GetLoadTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loadId** | **int?**| Id of the load to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloadcustomfields"></a>
# **UpdateLoadCustomFields**
> void UpdateLoadCustomFields (Load body)

Update a load custom fields

Updates an existing load custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLoadCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LoadApi();
            var body = new Load(); // Load | Load to be updated.

            try
            {
                // Update a load custom fields
                apiInstance.UpdateLoadCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoadApi.UpdateLoadCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Load**](Load.md)| Load to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

