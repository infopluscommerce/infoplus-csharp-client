# Infoplus.Api.PalletTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPalletType**](PalletTypeApi.md#addpallettype) | **POST** /v3.0/palletType | Create a palletType
[**AddPalletTypeAudit**](PalletTypeApi.md#addpallettypeaudit) | **PUT** /v3.0/palletType/{palletTypeId}/audit/{palletTypeAudit} | Add new audit for a palletType
[**AddPalletTypeFile**](PalletTypeApi.md#addpallettypefile) | **POST** /v3.0/palletType/{palletTypeId}/file/{fileName} | Attach a file to a palletType
[**AddPalletTypeFileByURL**](PalletTypeApi.md#addpallettypefilebyurl) | **POST** /v3.0/palletType/{palletTypeId}/file | Attach a file to a palletType by URL.
[**AddPalletTypeTag**](PalletTypeApi.md#addpallettypetag) | **PUT** /v3.0/palletType/{palletTypeId}/tag/{palletTypeTag} | Add new tags for a palletType.
[**DeletePalletType**](PalletTypeApi.md#deletepallettype) | **DELETE** /v3.0/palletType/{palletTypeId} | Delete a palletType
[**DeletePalletTypeFile**](PalletTypeApi.md#deletepallettypefile) | **DELETE** /v3.0/palletType/{palletTypeId}/file/{fileId} | Delete a file for a palletType.
[**DeletePalletTypeTag**](PalletTypeApi.md#deletepallettypetag) | **DELETE** /v3.0/palletType/{palletTypeId}/tag/{palletTypeTag} | Delete a tag for a palletType.
[**GetDuplicatePalletTypeById**](PalletTypeApi.md#getduplicatepallettypebyid) | **GET** /v3.0/palletType/duplicate/{palletTypeId} | Get a duplicated a palletType by id
[**GetPalletTypeByFilter**](PalletTypeApi.md#getpallettypebyfilter) | **GET** /v3.0/palletType/search | Search palletTypes by filter
[**GetPalletTypeById**](PalletTypeApi.md#getpallettypebyid) | **GET** /v3.0/palletType/{palletTypeId} | Get a palletType by id
[**GetPalletTypeFiles**](PalletTypeApi.md#getpallettypefiles) | **GET** /v3.0/palletType/{palletTypeId}/file | Get the files for a palletType.
[**GetPalletTypeTags**](PalletTypeApi.md#getpallettypetags) | **GET** /v3.0/palletType/{palletTypeId}/tag | Get the tags for a palletType.
[**UpdatePalletType**](PalletTypeApi.md#updatepallettype) | **PUT** /v3.0/palletType | Update a palletType
[**UpdatePalletTypeCustomFields**](PalletTypeApi.md#updatepallettypecustomfields) | **PUT** /v3.0/palletType/customFields | Update a palletType custom fields


<a name="addpallettype"></a>
# **AddPalletType**
> PalletType AddPalletType (PalletType body)

Create a palletType

Inserts a new palletType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPalletTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var body = new PalletType(); // PalletType | PalletType to be inserted.

            try
            {
                // Create a palletType
                PalletType result = apiInstance.AddPalletType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.AddPalletType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PalletType**](PalletType.md)| PalletType to be inserted. | 

### Return type

[**PalletType**](PalletType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpallettypeaudit"></a>
# **AddPalletTypeAudit**
> void AddPalletTypeAudit (int? palletTypeId, string palletTypeAudit)

Add new audit for a palletType

Adds an audit to an existing palletType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPalletTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to add an audit to
            var palletTypeAudit = palletTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a palletType
                apiInstance.AddPalletTypeAudit(palletTypeId, palletTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.AddPalletTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to add an audit to | 
 **palletTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpallettypefile"></a>
# **AddPalletTypeFile**
> void AddPalletTypeFile (int? palletTypeId, string fileName)

Attach a file to a palletType

Adds a file to an existing palletType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPalletTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a palletType
                apiInstance.AddPalletTypeFile(palletTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.AddPalletTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpallettypefilebyurl"></a>
# **AddPalletTypeFileByURL**
> void AddPalletTypeFileByURL (RecordFile body, int? palletTypeId)

Attach a file to a palletType by URL.

Adds a file to an existing palletType by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPalletTypeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var palletTypeId = 56;  // int? | Id of the palletType to add an file to

            try
            {
                // Attach a file to a palletType by URL.
                apiInstance.AddPalletTypeFileByURL(body, palletTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.AddPalletTypeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **palletTypeId** | **int?**| Id of the palletType to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpallettypetag"></a>
# **AddPalletTypeTag**
> void AddPalletTypeTag (int? palletTypeId, string palletTypeTag)

Add new tags for a palletType.

Adds a tag to an existing palletType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPalletTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to add a tag to
            var palletTypeTag = palletTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a palletType.
                apiInstance.AddPalletTypeTag(palletTypeId, palletTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.AddPalletTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to add a tag to | 
 **palletTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepallettype"></a>
# **DeletePalletType**
> void DeletePalletType (int? palletTypeId)

Delete a palletType

Deletes the palletType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePalletTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to be deleted.

            try
            {
                // Delete a palletType
                apiInstance.DeletePalletType(palletTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.DeletePalletType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepallettypefile"></a>
# **DeletePalletTypeFile**
> void DeletePalletTypeFile (int? palletTypeId, int? fileId)

Delete a file for a palletType.

Deletes an existing palletType file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePalletTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a palletType.
                apiInstance.DeletePalletTypeFile(palletTypeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.DeletePalletTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepallettypetag"></a>
# **DeletePalletTypeTag**
> void DeletePalletTypeTag (int? palletTypeId, string palletTypeTag)

Delete a tag for a palletType.

Deletes an existing palletType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePalletTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to remove tag from
            var palletTypeTag = palletTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a palletType.
                apiInstance.DeletePalletTypeTag(palletTypeId, palletTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.DeletePalletTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to remove tag from | 
 **palletTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatepallettypebyid"></a>
# **GetDuplicatePalletTypeById**
> PalletType GetDuplicatePalletTypeById (int? palletTypeId)

Get a duplicated a palletType by id

Returns a duplicated palletType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicatePalletTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to be duplicated.

            try
            {
                // Get a duplicated a palletType by id
                PalletType result = apiInstance.GetDuplicatePalletTypeById(palletTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.GetDuplicatePalletTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to be duplicated. | 

### Return type

[**PalletType**](PalletType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpallettypebyfilter"></a>
# **GetPalletTypeByFilter**
> List<PalletType> GetPalletTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search palletTypes by filter

Returns the list of palletTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPalletTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search palletTypes by filter
                List&lt;PalletType&gt; result = apiInstance.GetPalletTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.GetPalletTypeByFilter: " + e.Message );
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

[**List<PalletType>**](PalletType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpallettypebyid"></a>
# **GetPalletTypeById**
> PalletType GetPalletTypeById (int? palletTypeId)

Get a palletType by id

Returns the palletType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPalletTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to be returned.

            try
            {
                // Get a palletType by id
                PalletType result = apiInstance.GetPalletTypeById(palletTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.GetPalletTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to be returned. | 

### Return type

[**PalletType**](PalletType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpallettypefiles"></a>
# **GetPalletTypeFiles**
> void GetPalletTypeFiles (int? palletTypeId)

Get the files for a palletType.

Get all existing palletType files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPalletTypeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to get files for

            try
            {
                // Get the files for a palletType.
                apiInstance.GetPalletTypeFiles(palletTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.GetPalletTypeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpallettypetags"></a>
# **GetPalletTypeTags**
> void GetPalletTypeTags (int? palletTypeId)

Get the tags for a palletType.

Get all existing palletType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPalletTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var palletTypeId = 56;  // int? | Id of the palletType to get tags for

            try
            {
                // Get the tags for a palletType.
                apiInstance.GetPalletTypeTags(palletTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.GetPalletTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **palletTypeId** | **int?**| Id of the palletType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepallettype"></a>
# **UpdatePalletType**
> void UpdatePalletType (PalletType body)

Update a palletType

Updates an existing palletType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePalletTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var body = new PalletType(); // PalletType | PalletType to be updated.

            try
            {
                // Update a palletType
                apiInstance.UpdatePalletType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.UpdatePalletType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PalletType**](PalletType.md)| PalletType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepallettypecustomfields"></a>
# **UpdatePalletTypeCustomFields**
> void UpdatePalletTypeCustomFields (PalletType body)

Update a palletType custom fields

Updates an existing palletType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePalletTypeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PalletTypeApi();
            var body = new PalletType(); // PalletType | PalletType to be updated.

            try
            {
                // Update a palletType custom fields
                apiInstance.UpdatePalletTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PalletTypeApi.UpdatePalletTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PalletType**](PalletType.md)| PalletType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

