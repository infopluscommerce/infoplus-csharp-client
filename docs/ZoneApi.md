# Infoplus.Api.ZoneApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddZone**](ZoneApi.md#addzone) | **POST** /v3.0/zone | Create a zone
[**AddZoneAudit**](ZoneApi.md#addzoneaudit) | **PUT** /v3.0/zone/{zoneId}/audit/{zoneAudit} | Add new audit for a zone
[**AddZoneFile**](ZoneApi.md#addzonefile) | **POST** /v3.0/zone/{zoneId}/file/{fileName} | Attach a file to a zone
[**AddZoneFileByURL**](ZoneApi.md#addzonefilebyurl) | **POST** /v3.0/zone/{zoneId}/file | Attach a file to a zone by URL.
[**AddZoneTag**](ZoneApi.md#addzonetag) | **PUT** /v3.0/zone/{zoneId}/tag/{zoneTag} | Add new tags for a zone.
[**DeleteZone**](ZoneApi.md#deletezone) | **DELETE** /v3.0/zone/{zoneId} | Delete a zone
[**DeleteZoneFile**](ZoneApi.md#deletezonefile) | **DELETE** /v3.0/zone/{zoneId}/file/{fileId} | Delete a file for a zone.
[**DeleteZoneTag**](ZoneApi.md#deletezonetag) | **DELETE** /v3.0/zone/{zoneId}/tag/{zoneTag} | Delete a tag for a zone.
[**GetDuplicateZoneById**](ZoneApi.md#getduplicatezonebyid) | **GET** /v3.0/zone/duplicate/{zoneId} | Get a duplicated a zone by id
[**GetZoneByFilter**](ZoneApi.md#getzonebyfilter) | **GET** /v3.0/zone/search | Search zones by filter
[**GetZoneById**](ZoneApi.md#getzonebyid) | **GET** /v3.0/zone/{zoneId} | Get a zone by id
[**GetZoneFiles**](ZoneApi.md#getzonefiles) | **GET** /v3.0/zone/{zoneId}/file | Get the files for a zone.
[**GetZoneTags**](ZoneApi.md#getzonetags) | **GET** /v3.0/zone/{zoneId}/tag | Get the tags for a zone.
[**UpdateZone**](ZoneApi.md#updatezone) | **PUT** /v3.0/zone | Update a zone
[**UpdateZoneCustomFields**](ZoneApi.md#updatezonecustomfields) | **PUT** /v3.0/zone/customFields | Update a zone custom fields


<a name="addzone"></a>
# **AddZone**
> Zone AddZone (Zone body)

Create a zone

Inserts a new zone using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZoneExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var body = new Zone(); // Zone | Zone to be inserted.

            try
            {
                // Create a zone
                Zone result = apiInstance.AddZone(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.AddZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Zone**](Zone.md)| Zone to be inserted. | 

### Return type

[**Zone**](Zone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzoneaudit"></a>
# **AddZoneAudit**
> void AddZoneAudit (int? zoneId, string zoneAudit)

Add new audit for a zone

Adds an audit to an existing zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZoneAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to add an audit to
            var zoneAudit = zoneAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a zone
                apiInstance.AddZoneAudit(zoneId, zoneAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.AddZoneAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to add an audit to | 
 **zoneAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzonefile"></a>
# **AddZoneFile**
> void AddZoneFile (int? zoneId, string fileName)

Attach a file to a zone

Adds a file to an existing zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZoneFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a zone
                apiInstance.AddZoneFile(zoneId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.AddZoneFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzonefilebyurl"></a>
# **AddZoneFileByURL**
> void AddZoneFileByURL (RecordFile body, int? zoneId)

Attach a file to a zone by URL.

Adds a file to an existing zone by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZoneFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var zoneId = 56;  // int? | Id of the zone to add an file to

            try
            {
                // Attach a file to a zone by URL.
                apiInstance.AddZoneFileByURL(body, zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.AddZoneFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **zoneId** | **int?**| Id of the zone to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addzonetag"></a>
# **AddZoneTag**
> void AddZoneTag (int? zoneId, string zoneTag)

Add new tags for a zone.

Adds a tag to an existing zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddZoneTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to add a tag to
            var zoneTag = zoneTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a zone.
                apiInstance.AddZoneTag(zoneId, zoneTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.AddZoneTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to add a tag to | 
 **zoneTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezone"></a>
# **DeleteZone**
> void DeleteZone (int? zoneId)

Delete a zone

Deletes the zone identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteZoneExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to be deleted.

            try
            {
                // Delete a zone
                apiInstance.DeleteZone(zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.DeleteZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezonefile"></a>
# **DeleteZoneFile**
> void DeleteZoneFile (int? zoneId, int? fileId)

Delete a file for a zone.

Deletes an existing zone file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteZoneFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a zone.
                apiInstance.DeleteZoneFile(zoneId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.DeleteZoneFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezonetag"></a>
# **DeleteZoneTag**
> void DeleteZoneTag (int? zoneId, string zoneTag)

Delete a tag for a zone.

Deletes an existing zone tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteZoneTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to remove tag from
            var zoneTag = zoneTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a zone.
                apiInstance.DeleteZoneTag(zoneId, zoneTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.DeleteZoneTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to remove tag from | 
 **zoneTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatezonebyid"></a>
# **GetDuplicateZoneById**
> Zone GetDuplicateZoneById (int? zoneId)

Get a duplicated a zone by id

Returns a duplicated zone identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateZoneByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to be duplicated.

            try
            {
                // Get a duplicated a zone by id
                Zone result = apiInstance.GetDuplicateZoneById(zoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.GetDuplicateZoneById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to be duplicated. | 

### Return type

[**Zone**](Zone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzonebyfilter"></a>
# **GetZoneByFilter**
> List<Zone> GetZoneByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search zones by filter

Returns the list of zones that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZoneByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search zones by filter
                List&lt;Zone&gt; result = apiInstance.GetZoneByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.GetZoneByFilter: " + e.Message );
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

[**List<Zone>**](Zone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzonebyid"></a>
# **GetZoneById**
> Zone GetZoneById (int? zoneId)

Get a zone by id

Returns the zone identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZoneByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to be returned.

            try
            {
                // Get a zone by id
                Zone result = apiInstance.GetZoneById(zoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.GetZoneById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to be returned. | 

### Return type

[**Zone**](Zone.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzonefiles"></a>
# **GetZoneFiles**
> void GetZoneFiles (int? zoneId)

Get the files for a zone.

Get all existing zone files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZoneFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to get files for

            try
            {
                // Get the files for a zone.
                apiInstance.GetZoneFiles(zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.GetZoneFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzonetags"></a>
# **GetZoneTags**
> void GetZoneTags (int? zoneId)

Get the tags for a zone.

Get all existing zone tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetZoneTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var zoneId = 56;  // int? | Id of the zone to get tags for

            try
            {
                // Get the tags for a zone.
                apiInstance.GetZoneTags(zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.GetZoneTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **zoneId** | **int?**| Id of the zone to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatezone"></a>
# **UpdateZone**
> void UpdateZone (Zone body)

Update a zone

Updates an existing zone using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateZoneExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var body = new Zone(); // Zone | Zone to be updated.

            try
            {
                // Update a zone
                apiInstance.UpdateZone(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.UpdateZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Zone**](Zone.md)| Zone to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatezonecustomfields"></a>
# **UpdateZoneCustomFields**
> void UpdateZoneCustomFields (Zone body)

Update a zone custom fields

Updates an existing zone custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateZoneCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ZoneApi();
            var body = new Zone(); // Zone | Zone to be updated.

            try
            {
                // Update a zone custom fields
                apiInstance.UpdateZoneCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.UpdateZoneCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Zone**](Zone.md)| Zone to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

