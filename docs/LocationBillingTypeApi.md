# Infoplus.Api.LocationBillingTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocationBillingType**](LocationBillingTypeApi.md#addlocationbillingtype) | **POST** /beta/locationBillingType | Create a locationBillingType
[**AddLocationBillingTypeAudit**](LocationBillingTypeApi.md#addlocationbillingtypeaudit) | **PUT** /beta/locationBillingType/{locationBillingTypeId}/audit/{locationBillingTypeAudit} | Add new audit for a locationBillingType
[**AddLocationBillingTypeFile**](LocationBillingTypeApi.md#addlocationbillingtypefile) | **POST** /beta/locationBillingType/{locationBillingTypeId}/file/{fileName} | Attach a file to a locationBillingType
[**AddLocationBillingTypeFileByURL**](LocationBillingTypeApi.md#addlocationbillingtypefilebyurl) | **POST** /beta/locationBillingType/{locationBillingTypeId}/file | Attach a file to a locationBillingType by URL.
[**AddLocationBillingTypeTag**](LocationBillingTypeApi.md#addlocationbillingtypetag) | **PUT** /beta/locationBillingType/{locationBillingTypeId}/tag/{locationBillingTypeTag} | Add new tags for a locationBillingType.
[**DeleteLocationBillingType**](LocationBillingTypeApi.md#deletelocationbillingtype) | **DELETE** /beta/locationBillingType/{locationBillingTypeId} | Delete a locationBillingType
[**DeleteLocationBillingTypeFile**](LocationBillingTypeApi.md#deletelocationbillingtypefile) | **DELETE** /beta/locationBillingType/{locationBillingTypeId}/file/{fileId} | Delete a file for a locationBillingType.
[**DeleteLocationBillingTypeTag**](LocationBillingTypeApi.md#deletelocationbillingtypetag) | **DELETE** /beta/locationBillingType/{locationBillingTypeId}/tag/{locationBillingTypeTag} | Delete a tag for a locationBillingType.
[**GetDuplicateLocationBillingTypeById**](LocationBillingTypeApi.md#getduplicatelocationbillingtypebyid) | **GET** /beta/locationBillingType/duplicate/{locationBillingTypeId} | Get a duplicated a locationBillingType by id
[**GetLocationBillingTypeByFilter**](LocationBillingTypeApi.md#getlocationbillingtypebyfilter) | **GET** /beta/locationBillingType/search | Search locationBillingTypes by filter
[**GetLocationBillingTypeById**](LocationBillingTypeApi.md#getlocationbillingtypebyid) | **GET** /beta/locationBillingType/{locationBillingTypeId} | Get a locationBillingType by id
[**GetLocationBillingTypeFiles**](LocationBillingTypeApi.md#getlocationbillingtypefiles) | **GET** /beta/locationBillingType/{locationBillingTypeId}/file | Get the files for a locationBillingType.
[**GetLocationBillingTypeTags**](LocationBillingTypeApi.md#getlocationbillingtypetags) | **GET** /beta/locationBillingType/{locationBillingTypeId}/tag | Get the tags for a locationBillingType.
[**UpdateLocationBillingType**](LocationBillingTypeApi.md#updatelocationbillingtype) | **PUT** /beta/locationBillingType | Update a locationBillingType
[**UpdateLocationBillingTypeCustomFields**](LocationBillingTypeApi.md#updatelocationbillingtypecustomfields) | **PUT** /beta/locationBillingType/customFields | Update a locationBillingType custom fields


<a name="addlocationbillingtype"></a>
# **AddLocationBillingType**
> LocationBillingType AddLocationBillingType (LocationBillingType body)

Create a locationBillingType

Inserts a new locationBillingType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationBillingTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var body = new LocationBillingType(); // LocationBillingType | LocationBillingType to be inserted.

            try
            {
                // Create a locationBillingType
                LocationBillingType result = apiInstance.AddLocationBillingType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.AddLocationBillingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationBillingType**](LocationBillingType.md)| LocationBillingType to be inserted. | 

### Return type

[**LocationBillingType**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationbillingtypeaudit"></a>
# **AddLocationBillingTypeAudit**
> void AddLocationBillingTypeAudit (int? locationBillingTypeId, string locationBillingTypeAudit)

Add new audit for a locationBillingType

Adds an audit to an existing locationBillingType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationBillingTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to add an audit to
            var locationBillingTypeAudit = locationBillingTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a locationBillingType
                apiInstance.AddLocationBillingTypeAudit(locationBillingTypeId, locationBillingTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.AddLocationBillingTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to add an audit to | 
 **locationBillingTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationbillingtypefile"></a>
# **AddLocationBillingTypeFile**
> void AddLocationBillingTypeFile (int? locationBillingTypeId, string fileName)

Attach a file to a locationBillingType

Adds a file to an existing locationBillingType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationBillingTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a locationBillingType
                apiInstance.AddLocationBillingTypeFile(locationBillingTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.AddLocationBillingTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationbillingtypefilebyurl"></a>
# **AddLocationBillingTypeFileByURL**
> void AddLocationBillingTypeFileByURL (RecordFile body, int? locationBillingTypeId)

Attach a file to a locationBillingType by URL.

Adds a file to an existing locationBillingType by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationBillingTypeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to add an file to

            try
            {
                // Attach a file to a locationBillingType by URL.
                apiInstance.AddLocationBillingTypeFileByURL(body, locationBillingTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.AddLocationBillingTypeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationbillingtypetag"></a>
# **AddLocationBillingTypeTag**
> void AddLocationBillingTypeTag (int? locationBillingTypeId, string locationBillingTypeTag)

Add new tags for a locationBillingType.

Adds a tag to an existing locationBillingType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationBillingTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to add a tag to
            var locationBillingTypeTag = locationBillingTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a locationBillingType.
                apiInstance.AddLocationBillingTypeTag(locationBillingTypeId, locationBillingTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.AddLocationBillingTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to add a tag to | 
 **locationBillingTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationbillingtype"></a>
# **DeleteLocationBillingType**
> void DeleteLocationBillingType (int? locationBillingTypeId)

Delete a locationBillingType

Deletes the locationBillingType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationBillingTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to be deleted.

            try
            {
                // Delete a locationBillingType
                apiInstance.DeleteLocationBillingType(locationBillingTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.DeleteLocationBillingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationbillingtypefile"></a>
# **DeleteLocationBillingTypeFile**
> void DeleteLocationBillingTypeFile (int? locationBillingTypeId, int? fileId)

Delete a file for a locationBillingType.

Deletes an existing locationBillingType file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationBillingTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a locationBillingType.
                apiInstance.DeleteLocationBillingTypeFile(locationBillingTypeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.DeleteLocationBillingTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationbillingtypetag"></a>
# **DeleteLocationBillingTypeTag**
> void DeleteLocationBillingTypeTag (int? locationBillingTypeId, string locationBillingTypeTag)

Delete a tag for a locationBillingType.

Deletes an existing locationBillingType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationBillingTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to remove tag from
            var locationBillingTypeTag = locationBillingTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a locationBillingType.
                apiInstance.DeleteLocationBillingTypeTag(locationBillingTypeId, locationBillingTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.DeleteLocationBillingTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to remove tag from | 
 **locationBillingTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatelocationbillingtypebyid"></a>
# **GetDuplicateLocationBillingTypeById**
> LocationBillingType GetDuplicateLocationBillingTypeById (int? locationBillingTypeId)

Get a duplicated a locationBillingType by id

Returns a duplicated locationBillingType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLocationBillingTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to be duplicated.

            try
            {
                // Get a duplicated a locationBillingType by id
                LocationBillingType result = apiInstance.GetDuplicateLocationBillingTypeById(locationBillingTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetDuplicateLocationBillingTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to be duplicated. | 

### Return type

[**LocationBillingType**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationbillingtypebyfilter"></a>
# **GetLocationBillingTypeByFilter**
> List<LocationBillingType> GetLocationBillingTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search locationBillingTypes by filter

Returns the list of locationBillingTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationBillingTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search locationBillingTypes by filter
                List&lt;LocationBillingType&gt; result = apiInstance.GetLocationBillingTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetLocationBillingTypeByFilter: " + e.Message );
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

[**List<LocationBillingType>**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationbillingtypebyid"></a>
# **GetLocationBillingTypeById**
> LocationBillingType GetLocationBillingTypeById (int? locationBillingTypeId)

Get a locationBillingType by id

Returns the locationBillingType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationBillingTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to be returned.

            try
            {
                // Get a locationBillingType by id
                LocationBillingType result = apiInstance.GetLocationBillingTypeById(locationBillingTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetLocationBillingTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to be returned. | 

### Return type

[**LocationBillingType**](LocationBillingType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationbillingtypefiles"></a>
# **GetLocationBillingTypeFiles**
> void GetLocationBillingTypeFiles (int? locationBillingTypeId)

Get the files for a locationBillingType.

Get all existing locationBillingType files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationBillingTypeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to get files for

            try
            {
                // Get the files for a locationBillingType.
                apiInstance.GetLocationBillingTypeFiles(locationBillingTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetLocationBillingTypeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationbillingtypetags"></a>
# **GetLocationBillingTypeTags**
> void GetLocationBillingTypeTags (int? locationBillingTypeId)

Get the tags for a locationBillingType.

Get all existing locationBillingType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationBillingTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var locationBillingTypeId = 56;  // int? | Id of the locationBillingType to get tags for

            try
            {
                // Get the tags for a locationBillingType.
                apiInstance.GetLocationBillingTypeTags(locationBillingTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.GetLocationBillingTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationBillingTypeId** | **int?**| Id of the locationBillingType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationbillingtype"></a>
# **UpdateLocationBillingType**
> void UpdateLocationBillingType (LocationBillingType body)

Update a locationBillingType

Updates an existing locationBillingType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationBillingTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var body = new LocationBillingType(); // LocationBillingType | LocationBillingType to be updated.

            try
            {
                // Update a locationBillingType
                apiInstance.UpdateLocationBillingType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.UpdateLocationBillingType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationBillingType**](LocationBillingType.md)| LocationBillingType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationbillingtypecustomfields"></a>
# **UpdateLocationBillingTypeCustomFields**
> void UpdateLocationBillingTypeCustomFields (LocationBillingType body)

Update a locationBillingType custom fields

Updates an existing locationBillingType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationBillingTypeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationBillingTypeApi();
            var body = new LocationBillingType(); // LocationBillingType | LocationBillingType to be updated.

            try
            {
                // Update a locationBillingType custom fields
                apiInstance.UpdateLocationBillingTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationBillingTypeApi.UpdateLocationBillingTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationBillingType**](LocationBillingType.md)| LocationBillingType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

