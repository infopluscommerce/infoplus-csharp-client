# Infoplus.Api.ZipCodeZoneApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddZipCodeZone**](ZipCodeZoneApi.md#addzipcodezone) | **POST** /beta/zipCodeZone | Create a zipCodeZone
[**AddZipCodeZoneAudit**](ZipCodeZoneApi.md#addzipcodezoneaudit) | **PUT** /beta/zipCodeZone/{zipCodeZoneId}/audit/{zipCodeZoneAudit} | Add new audit for a zipCodeZone
[**AddZipCodeZoneFile**](ZipCodeZoneApi.md#addzipcodezonefile) | **POST** /beta/zipCodeZone/{zipCodeZoneId}/file/{fileName} | Attach a file to a zipCodeZone
[**AddZipCodeZoneFileByURL**](ZipCodeZoneApi.md#addzipcodezonefilebyurl) | **POST** /beta/zipCodeZone/{zipCodeZoneId}/file | Attach a file to a zipCodeZone by URL.
[**AddZipCodeZoneTag**](ZipCodeZoneApi.md#addzipcodezonetag) | **PUT** /beta/zipCodeZone/{zipCodeZoneId}/tag/{zipCodeZoneTag} | Add new tags for a zipCodeZone.
[**DeleteZipCodeZone**](ZipCodeZoneApi.md#deletezipcodezone) | **DELETE** /beta/zipCodeZone/{zipCodeZoneId} | Delete a zipCodeZone
[**DeleteZipCodeZoneFile**](ZipCodeZoneApi.md#deletezipcodezonefile) | **DELETE** /beta/zipCodeZone/{zipCodeZoneId}/file/{fileId} | Delete a file for a zipCodeZone.
[**DeleteZipCodeZoneTag**](ZipCodeZoneApi.md#deletezipcodezonetag) | **DELETE** /beta/zipCodeZone/{zipCodeZoneId}/tag/{zipCodeZoneTag} | Delete a tag for a zipCodeZone.
[**GetDuplicateZipCodeZoneById**](ZipCodeZoneApi.md#getduplicatezipcodezonebyid) | **GET** /beta/zipCodeZone/duplicate/{zipCodeZoneId} | Get a duplicated a zipCodeZone by id
[**GetZipCodeZoneByFilter**](ZipCodeZoneApi.md#getzipcodezonebyfilter) | **GET** /beta/zipCodeZone/search | Search zipCodeZones by filter
[**GetZipCodeZoneById**](ZipCodeZoneApi.md#getzipcodezonebyid) | **GET** /beta/zipCodeZone/{zipCodeZoneId} | Get a zipCodeZone by id
[**GetZipCodeZoneFiles**](ZipCodeZoneApi.md#getzipcodezonefiles) | **GET** /beta/zipCodeZone/{zipCodeZoneId}/file | Get the files for a zipCodeZone.
[**GetZipCodeZoneTags**](ZipCodeZoneApi.md#getzipcodezonetags) | **GET** /beta/zipCodeZone/{zipCodeZoneId}/tag | Get the tags for a zipCodeZone.
[**UpdateZipCodeZone**](ZipCodeZoneApi.md#updatezipcodezone) | **PUT** /beta/zipCodeZone | Update a zipCodeZone


<a name="addzipcodezone"></a>
# **AddZipCodeZone**
> ZipCodeZone AddZipCodeZone (ZipCodeZone body)

Create a zipCodeZone

Inserts a new zipCodeZone using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZipCodeZoneExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var body = new ZipCodeZone(); // ZipCodeZone | ZipCodeZone to be inserted.

            try
            {
                // Create a zipCodeZone
                ZipCodeZone result = apiInstance.AddZipCodeZone(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.AddZipCodeZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ZipCodeZone**](ZipCodeZone.md)| ZipCodeZone to be inserted. | 

### Return type

[**ZipCodeZone**](ZipCodeZone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzipcodezoneaudit"></a>
# **AddZipCodeZoneAudit**
> void AddZipCodeZoneAudit (int? zipCodeZoneId, string zipCodeZoneAudit)

Add new audit for a zipCodeZone

Adds an audit to an existing zipCodeZone.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZipCodeZoneAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to add an audit to
            var zipCodeZoneAudit = zipCodeZoneAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a zipCodeZone
                apiInstance.AddZipCodeZoneAudit(zipCodeZoneId, zipCodeZoneAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.AddZipCodeZoneAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to add an audit to | 
 **zipCodeZoneAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzipcodezonefile"></a>
# **AddZipCodeZoneFile**
> void AddZipCodeZoneFile (int? zipCodeZoneId, string fileName)

Attach a file to a zipCodeZone

Adds a file to an existing zipCodeZone.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZipCodeZoneFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a zipCodeZone
                apiInstance.AddZipCodeZoneFile(zipCodeZoneId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.AddZipCodeZoneFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzipcodezonefilebyurl"></a>
# **AddZipCodeZoneFileByURL**
> void AddZipCodeZoneFileByURL (RecordFile body, int? zipCodeZoneId)

Attach a file to a zipCodeZone by URL.

Adds a file to an existing zipCodeZone by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZipCodeZoneFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to add an file to

            try
            {
                // Attach a file to a zipCodeZone by URL.
                apiInstance.AddZipCodeZoneFileByURL(body, zipCodeZoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.AddZipCodeZoneFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzipcodezonetag"></a>
# **AddZipCodeZoneTag**
> void AddZipCodeZoneTag (int? zipCodeZoneId, string zipCodeZoneTag)

Add new tags for a zipCodeZone.

Adds a tag to an existing zipCodeZone.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZipCodeZoneTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to add a tag to
            var zipCodeZoneTag = zipCodeZoneTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a zipCodeZone.
                apiInstance.AddZipCodeZoneTag(zipCodeZoneId, zipCodeZoneTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.AddZipCodeZoneTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to add a tag to | 
 **zipCodeZoneTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezipcodezone"></a>
# **DeleteZipCodeZone**
> void DeleteZipCodeZone (int? zipCodeZoneId)

Delete a zipCodeZone

Deletes the zipCodeZone identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteZipCodeZoneExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to be deleted.

            try
            {
                // Delete a zipCodeZone
                apiInstance.DeleteZipCodeZone(zipCodeZoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.DeleteZipCodeZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezipcodezonefile"></a>
# **DeleteZipCodeZoneFile**
> void DeleteZipCodeZoneFile (int? zipCodeZoneId, int? fileId)

Delete a file for a zipCodeZone.

Deletes an existing zipCodeZone file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteZipCodeZoneFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a zipCodeZone.
                apiInstance.DeleteZipCodeZoneFile(zipCodeZoneId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.DeleteZipCodeZoneFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezipcodezonetag"></a>
# **DeleteZipCodeZoneTag**
> void DeleteZipCodeZoneTag (int? zipCodeZoneId, string zipCodeZoneTag)

Delete a tag for a zipCodeZone.

Deletes an existing zipCodeZone tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteZipCodeZoneTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to remove tag from
            var zipCodeZoneTag = zipCodeZoneTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a zipCodeZone.
                apiInstance.DeleteZipCodeZoneTag(zipCodeZoneId, zipCodeZoneTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.DeleteZipCodeZoneTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to remove tag from | 
 **zipCodeZoneTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatezipcodezonebyid"></a>
# **GetDuplicateZipCodeZoneById**
> ZipCodeZone GetDuplicateZipCodeZoneById (int? zipCodeZoneId)

Get a duplicated a zipCodeZone by id

Returns a duplicated zipCodeZone identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateZipCodeZoneByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to be duplicated.

            try
            {
                // Get a duplicated a zipCodeZone by id
                ZipCodeZone result = apiInstance.GetDuplicateZipCodeZoneById(zipCodeZoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.GetDuplicateZipCodeZoneById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to be duplicated. | 

### Return type

[**ZipCodeZone**](ZipCodeZone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipcodezonebyfilter"></a>
# **GetZipCodeZoneByFilter**
> List<ZipCodeZone> GetZipCodeZoneByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search zipCodeZones by filter

Returns the list of zipCodeZones that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZipCodeZoneByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search zipCodeZones by filter
                List&lt;ZipCodeZone&gt; result = apiInstance.GetZipCodeZoneByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.GetZipCodeZoneByFilter: " + e.Message );
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

[**List<ZipCodeZone>**](ZipCodeZone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipcodezonebyid"></a>
# **GetZipCodeZoneById**
> ZipCodeZone GetZipCodeZoneById (int? zipCodeZoneId)

Get a zipCodeZone by id

Returns the zipCodeZone identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZipCodeZoneByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to be returned.

            try
            {
                // Get a zipCodeZone by id
                ZipCodeZone result = apiInstance.GetZipCodeZoneById(zipCodeZoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.GetZipCodeZoneById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to be returned. | 

### Return type

[**ZipCodeZone**](ZipCodeZone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipcodezonefiles"></a>
# **GetZipCodeZoneFiles**
> void GetZipCodeZoneFiles (int? zipCodeZoneId)

Get the files for a zipCodeZone.

Get all existing zipCodeZone files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZipCodeZoneFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to get files for

            try
            {
                // Get the files for a zipCodeZone.
                apiInstance.GetZipCodeZoneFiles(zipCodeZoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.GetZipCodeZoneFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipcodezonetags"></a>
# **GetZipCodeZoneTags**
> void GetZipCodeZoneTags (int? zipCodeZoneId)

Get the tags for a zipCodeZone.

Get all existing zipCodeZone tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZipCodeZoneTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var zipCodeZoneId = 56;  // int? | Id of the zipCodeZone to get tags for

            try
            {
                // Get the tags for a zipCodeZone.
                apiInstance.GetZipCodeZoneTags(zipCodeZoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.GetZipCodeZoneTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zipCodeZoneId** | **int?**| Id of the zipCodeZone to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatezipcodezone"></a>
# **UpdateZipCodeZone**
> void UpdateZipCodeZone (ZipCodeZone body)

Update a zipCodeZone

Updates an existing zipCodeZone using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateZipCodeZoneExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZipCodeZoneApi();
            var body = new ZipCodeZone(); // ZipCodeZone | ZipCodeZone to be updated.

            try
            {
                // Update a zipCodeZone
                apiInstance.UpdateZipCodeZone(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipCodeZoneApi.UpdateZipCodeZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ZipCodeZone**](ZipCodeZone.md)| ZipCodeZone to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

