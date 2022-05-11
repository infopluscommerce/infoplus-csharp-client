# Infoplus.Api.BuildingApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBuilding**](BuildingApi.md#addbuilding) | **POST** /v3.0/building | Create a building
[**AddBuildingAudit**](BuildingApi.md#addbuildingaudit) | **PUT** /v3.0/building/{buildingId}/audit/{buildingAudit} | Add new audit for a building
[**AddBuildingFile**](BuildingApi.md#addbuildingfile) | **POST** /v3.0/building/{buildingId}/file/{fileName} | Attach a file to a building
[**AddBuildingFileByURL**](BuildingApi.md#addbuildingfilebyurl) | **POST** /v3.0/building/{buildingId}/file | Attach a file to a building by URL.
[**AddBuildingTag**](BuildingApi.md#addbuildingtag) | **PUT** /v3.0/building/{buildingId}/tag/{buildingTag} | Add new tags for a building.
[**DeleteBuilding**](BuildingApi.md#deletebuilding) | **DELETE** /v3.0/building/{buildingId} | Delete a building
[**DeleteBuildingFile**](BuildingApi.md#deletebuildingfile) | **DELETE** /v3.0/building/{buildingId}/file/{fileId} | Delete a file for a building.
[**DeleteBuildingTag**](BuildingApi.md#deletebuildingtag) | **DELETE** /v3.0/building/{buildingId}/tag/{buildingTag} | Delete a tag for a building.
[**GetBuildingByFilter**](BuildingApi.md#getbuildingbyfilter) | **GET** /v3.0/building/search | Search buildings by filter
[**GetBuildingById**](BuildingApi.md#getbuildingbyid) | **GET** /v3.0/building/{buildingId} | Get a building by id
[**GetBuildingFiles**](BuildingApi.md#getbuildingfiles) | **GET** /v3.0/building/{buildingId}/file | Get the files for a building.
[**GetBuildingTags**](BuildingApi.md#getbuildingtags) | **GET** /v3.0/building/{buildingId}/tag | Get the tags for a building.
[**GetDuplicateBuildingById**](BuildingApi.md#getduplicatebuildingbyid) | **GET** /v3.0/building/duplicate/{buildingId} | Get a duplicated a building by id
[**UpdateBuilding**](BuildingApi.md#updatebuilding) | **PUT** /v3.0/building | Update a building
[**UpdateBuildingCustomFields**](BuildingApi.md#updatebuildingcustomfields) | **PUT** /v3.0/building/customFields | Update a building custom fields


<a name="addbuilding"></a>
# **AddBuilding**
> Building AddBuilding (Building body)

Create a building

Inserts a new building using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBuildingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var body = new Building(); // Building | Building to be inserted.

            try
            {
                // Create a building
                Building result = apiInstance.AddBuilding(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.AddBuilding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| Building to be inserted. | 

### Return type

[**Building**](Building.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbuildingaudit"></a>
# **AddBuildingAudit**
> void AddBuildingAudit (int? buildingId, string buildingAudit)

Add new audit for a building

Adds an audit to an existing building.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBuildingAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to add an audit to
            var buildingAudit = buildingAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a building
                apiInstance.AddBuildingAudit(buildingId, buildingAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.AddBuildingAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to add an audit to | 
 **buildingAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbuildingfile"></a>
# **AddBuildingFile**
> void AddBuildingFile (int? buildingId, string fileName)

Attach a file to a building

Adds a file to an existing building.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBuildingFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a building
                apiInstance.AddBuildingFile(buildingId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.AddBuildingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbuildingfilebyurl"></a>
# **AddBuildingFileByURL**
> void AddBuildingFileByURL (RecordFile body, int? buildingId)

Attach a file to a building by URL.

Adds a file to an existing building by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBuildingFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var buildingId = 56;  // int? | Id of the building to add an file to

            try
            {
                // Attach a file to a building by URL.
                apiInstance.AddBuildingFileByURL(body, buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.AddBuildingFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **buildingId** | **int?**| Id of the building to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbuildingtag"></a>
# **AddBuildingTag**
> void AddBuildingTag (int? buildingId, string buildingTag)

Add new tags for a building.

Adds a tag to an existing building.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBuildingTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to add a tag to
            var buildingTag = buildingTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a building.
                apiInstance.AddBuildingTag(buildingId, buildingTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.AddBuildingTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to add a tag to | 
 **buildingTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebuilding"></a>
# **DeleteBuilding**
> void DeleteBuilding (int? buildingId)

Delete a building

Deletes the building identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBuildingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to be deleted.

            try
            {
                // Delete a building
                apiInstance.DeleteBuilding(buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.DeleteBuilding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebuildingfile"></a>
# **DeleteBuildingFile**
> void DeleteBuildingFile (int? buildingId, int? fileId)

Delete a file for a building.

Deletes an existing building file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBuildingFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a building.
                apiInstance.DeleteBuildingFile(buildingId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.DeleteBuildingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebuildingtag"></a>
# **DeleteBuildingTag**
> void DeleteBuildingTag (int? buildingId, string buildingTag)

Delete a tag for a building.

Deletes an existing building tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBuildingTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to remove tag from
            var buildingTag = buildingTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a building.
                apiInstance.DeleteBuildingTag(buildingId, buildingTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.DeleteBuildingTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to remove tag from | 
 **buildingTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildingbyfilter"></a>
# **GetBuildingByFilter**
> List<Building> GetBuildingByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search buildings by filter

Returns the list of buildings that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBuildingByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search buildings by filter
                List&lt;Building&gt; result = apiInstance.GetBuildingByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.GetBuildingByFilter: " + e.Message );
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

[**List<Building>**](Building.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildingbyid"></a>
# **GetBuildingById**
> Building GetBuildingById (int? buildingId)

Get a building by id

Returns the building identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBuildingByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to be returned.

            try
            {
                // Get a building by id
                Building result = apiInstance.GetBuildingById(buildingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.GetBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to be returned. | 

### Return type

[**Building**](Building.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildingfiles"></a>
# **GetBuildingFiles**
> void GetBuildingFiles (int? buildingId)

Get the files for a building.

Get all existing building files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBuildingFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to get files for

            try
            {
                // Get the files for a building.
                apiInstance.GetBuildingFiles(buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.GetBuildingFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildingtags"></a>
# **GetBuildingTags**
> void GetBuildingTags (int? buildingId)

Get the tags for a building.

Get all existing building tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBuildingTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to get tags for

            try
            {
                // Get the tags for a building.
                apiInstance.GetBuildingTags(buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.GetBuildingTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatebuildingbyid"></a>
# **GetDuplicateBuildingById**
> Building GetDuplicateBuildingById (int? buildingId)

Get a duplicated a building by id

Returns a duplicated building identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateBuildingByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var buildingId = 56;  // int? | Id of the building to be duplicated.

            try
            {
                // Get a duplicated a building by id
                Building result = apiInstance.GetDuplicateBuildingById(buildingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.GetDuplicateBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | **int?**| Id of the building to be duplicated. | 

### Return type

[**Building**](Building.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebuilding"></a>
# **UpdateBuilding**
> void UpdateBuilding (Building body)

Update a building

Updates an existing building using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBuildingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var body = new Building(); // Building | Building to be updated.

            try
            {
                // Update a building
                apiInstance.UpdateBuilding(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.UpdateBuilding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| Building to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebuildingcustomfields"></a>
# **UpdateBuildingCustomFields**
> void UpdateBuildingCustomFields (Building body)

Update a building custom fields

Updates an existing building custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBuildingCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var body = new Building(); // Building | Building to be updated.

            try
            {
                // Update a building custom fields
                apiInstance.UpdateBuildingCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.UpdateBuildingCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| Building to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

