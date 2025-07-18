# Infoplus.Api.DasFeesApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDasFees**](DasFeesApi.md#adddasfees) | **POST** /beta/dasFees | Create a dasFees
[**AddDasFeesAudit**](DasFeesApi.md#adddasfeesaudit) | **PUT** /beta/dasFees/{dasFeesId}/audit/{dasFeesAudit} | Add new audit for a dasFees
[**AddDasFeesFile**](DasFeesApi.md#adddasfeesfile) | **POST** /beta/dasFees/{dasFeesId}/file/{fileName} | Attach a file to a dasFees
[**AddDasFeesFileByURL**](DasFeesApi.md#adddasfeesfilebyurl) | **POST** /beta/dasFees/{dasFeesId}/file | Attach a file to a dasFees by URL.
[**AddDasFeesTag**](DasFeesApi.md#adddasfeestag) | **PUT** /beta/dasFees/{dasFeesId}/tag/{dasFeesTag} | Add new tags for a dasFees.
[**DeleteDasFees**](DasFeesApi.md#deletedasfees) | **DELETE** /beta/dasFees/{dasFeesId} | Delete a dasFees
[**DeleteDasFeesFile**](DasFeesApi.md#deletedasfeesfile) | **DELETE** /beta/dasFees/{dasFeesId}/file/{fileId} | Delete a file for a dasFees.
[**DeleteDasFeesTag**](DasFeesApi.md#deletedasfeestag) | **DELETE** /beta/dasFees/{dasFeesId}/tag/{dasFeesTag} | Delete a tag for a dasFees.
[**GetDasFeesByFilter**](DasFeesApi.md#getdasfeesbyfilter) | **GET** /beta/dasFees/search | Search dasFeeses by filter
[**GetDasFeesById**](DasFeesApi.md#getdasfeesbyid) | **GET** /beta/dasFees/{dasFeesId} | Get a dasFees by id
[**GetDasFeesFiles**](DasFeesApi.md#getdasfeesfiles) | **GET** /beta/dasFees/{dasFeesId}/file | Get the files for a dasFees.
[**GetDasFeesTags**](DasFeesApi.md#getdasfeestags) | **GET** /beta/dasFees/{dasFeesId}/tag | Get the tags for a dasFees.
[**GetDuplicateDasFeesById**](DasFeesApi.md#getduplicatedasfeesbyid) | **GET** /beta/dasFees/duplicate/{dasFeesId} | Get a duplicated a dasFees by id
[**UpdateDasFees**](DasFeesApi.md#updatedasfees) | **PUT** /beta/dasFees | Update a dasFees


<a name="adddasfees"></a>
# **AddDasFees**
> DasFees AddDasFees (DasFees body)

Create a dasFees

Inserts a new dasFees using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDasFeesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var body = new DasFees(); // DasFees | DasFees to be inserted.

            try
            {
                // Create a dasFees
                DasFees result = apiInstance.AddDasFees(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.AddDasFees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DasFees**](DasFees.md)| DasFees to be inserted. | 

### Return type

[**DasFees**](DasFees.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddasfeesaudit"></a>
# **AddDasFeesAudit**
> void AddDasFeesAudit (int? dasFeesId, string dasFeesAudit)

Add new audit for a dasFees

Adds an audit to an existing dasFees.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDasFeesAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to add an audit to
            var dasFeesAudit = dasFeesAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a dasFees
                apiInstance.AddDasFeesAudit(dasFeesId, dasFeesAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.AddDasFeesAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to add an audit to | 
 **dasFeesAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddasfeesfile"></a>
# **AddDasFeesFile**
> void AddDasFeesFile (int? dasFeesId, string fileName)

Attach a file to a dasFees

Adds a file to an existing dasFees.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDasFeesFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a dasFees
                apiInstance.AddDasFeesFile(dasFeesId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.AddDasFeesFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddasfeesfilebyurl"></a>
# **AddDasFeesFileByURL**
> void AddDasFeesFileByURL (RecordFile body, int? dasFeesId)

Attach a file to a dasFees by URL.

Adds a file to an existing dasFees by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDasFeesFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var dasFeesId = 56;  // int? | Id of the dasFees to add an file to

            try
            {
                // Attach a file to a dasFees by URL.
                apiInstance.AddDasFeesFileByURL(body, dasFeesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.AddDasFeesFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **dasFeesId** | **int?**| Id of the dasFees to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddasfeestag"></a>
# **AddDasFeesTag**
> void AddDasFeesTag (int? dasFeesId, string dasFeesTag)

Add new tags for a dasFees.

Adds a tag to an existing dasFees.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDasFeesTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to add a tag to
            var dasFeesTag = dasFeesTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a dasFees.
                apiInstance.AddDasFeesTag(dasFeesId, dasFeesTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.AddDasFeesTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to add a tag to | 
 **dasFeesTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedasfees"></a>
# **DeleteDasFees**
> void DeleteDasFees (int? dasFeesId)

Delete a dasFees

Deletes the dasFees identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteDasFeesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to be deleted.

            try
            {
                // Delete a dasFees
                apiInstance.DeleteDasFees(dasFeesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.DeleteDasFees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedasfeesfile"></a>
# **DeleteDasFeesFile**
> void DeleteDasFeesFile (int? dasFeesId, int? fileId)

Delete a file for a dasFees.

Deletes an existing dasFees file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteDasFeesFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a dasFees.
                apiInstance.DeleteDasFeesFile(dasFeesId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.DeleteDasFeesFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedasfeestag"></a>
# **DeleteDasFeesTag**
> void DeleteDasFeesTag (int? dasFeesId, string dasFeesTag)

Delete a tag for a dasFees.

Deletes an existing dasFees tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteDasFeesTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to remove tag from
            var dasFeesTag = dasFeesTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a dasFees.
                apiInstance.DeleteDasFeesTag(dasFeesId, dasFeesTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.DeleteDasFeesTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to remove tag from | 
 **dasFeesTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdasfeesbyfilter"></a>
# **GetDasFeesByFilter**
> List<DasFees> GetDasFeesByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search dasFeeses by filter

Returns the list of dasFeeses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDasFeesByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search dasFeeses by filter
                List&lt;DasFees&gt; result = apiInstance.GetDasFeesByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.GetDasFeesByFilter: " + e.Message );
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

[**List<DasFees>**](DasFees.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdasfeesbyid"></a>
# **GetDasFeesById**
> DasFees GetDasFeesById (int? dasFeesId)

Get a dasFees by id

Returns the dasFees identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDasFeesByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to be returned.

            try
            {
                // Get a dasFees by id
                DasFees result = apiInstance.GetDasFeesById(dasFeesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.GetDasFeesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to be returned. | 

### Return type

[**DasFees**](DasFees.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdasfeesfiles"></a>
# **GetDasFeesFiles**
> void GetDasFeesFiles (int? dasFeesId)

Get the files for a dasFees.

Get all existing dasFees files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDasFeesFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to get files for

            try
            {
                // Get the files for a dasFees.
                apiInstance.GetDasFeesFiles(dasFeesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.GetDasFeesFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdasfeestags"></a>
# **GetDasFeesTags**
> void GetDasFeesTags (int? dasFeesId)

Get the tags for a dasFees.

Get all existing dasFees tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDasFeesTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to get tags for

            try
            {
                // Get the tags for a dasFees.
                apiInstance.GetDasFeesTags(dasFeesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.GetDasFeesTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatedasfeesbyid"></a>
# **GetDuplicateDasFeesById**
> DasFees GetDuplicateDasFeesById (int? dasFeesId)

Get a duplicated a dasFees by id

Returns a duplicated dasFees identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateDasFeesByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var dasFeesId = 56;  // int? | Id of the dasFees to be duplicated.

            try
            {
                // Get a duplicated a dasFees by id
                DasFees result = apiInstance.GetDuplicateDasFeesById(dasFeesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.GetDuplicateDasFeesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dasFeesId** | **int?**| Id of the dasFees to be duplicated. | 

### Return type

[**DasFees**](DasFees.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedasfees"></a>
# **UpdateDasFees**
> void UpdateDasFees (DasFees body)

Update a dasFees

Updates an existing dasFees using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateDasFeesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DasFeesApi();
            var body = new DasFees(); // DasFees | DasFees to be updated.

            try
            {
                // Update a dasFees
                apiInstance.UpdateDasFees(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DasFeesApi.UpdateDasFees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DasFees**](DasFees.md)| DasFees to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

