# Infoplus.Api.PackingDetailApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPackingDetailAudit**](PackingDetailApi.md#addpackingdetailaudit) | **PUT** /v3.0/packingDetail/{packingDetailId}/audit/{packingDetailAudit} | Add new audit for a packingDetail
[**AddPackingDetailFile**](PackingDetailApi.md#addpackingdetailfile) | **POST** /v3.0/packingDetail/{packingDetailId}/file/{fileName} | Attach a file to a packingDetail
[**AddPackingDetailFileByURL**](PackingDetailApi.md#addpackingdetailfilebyurl) | **POST** /v3.0/packingDetail/{packingDetailId}/file | Attach a file to a packingDetail by URL.
[**AddPackingDetailTag**](PackingDetailApi.md#addpackingdetailtag) | **PUT** /v3.0/packingDetail/{packingDetailId}/tag/{packingDetailTag} | Add new tags for a packingDetail.
[**DeletePackingDetailFile**](PackingDetailApi.md#deletepackingdetailfile) | **DELETE** /v3.0/packingDetail/{packingDetailId}/file/{fileId} | Delete a file for a packingDetail.
[**DeletePackingDetailTag**](PackingDetailApi.md#deletepackingdetailtag) | **DELETE** /v3.0/packingDetail/{packingDetailId}/tag/{packingDetailTag} | Delete a tag for a packingDetail.
[**GetDuplicatePackingDetailById**](PackingDetailApi.md#getduplicatepackingdetailbyid) | **GET** /v3.0/packingDetail/duplicate/{packingDetailId} | Get a duplicated a packingDetail by id
[**GetPackingDetailByFilter**](PackingDetailApi.md#getpackingdetailbyfilter) | **GET** /v3.0/packingDetail/search | Search packingDetails by filter
[**GetPackingDetailById**](PackingDetailApi.md#getpackingdetailbyid) | **GET** /v3.0/packingDetail/{packingDetailId} | Get a packingDetail by id
[**GetPackingDetailFiles**](PackingDetailApi.md#getpackingdetailfiles) | **GET** /v3.0/packingDetail/{packingDetailId}/file | Get the files for a packingDetail.
[**GetPackingDetailTags**](PackingDetailApi.md#getpackingdetailtags) | **GET** /v3.0/packingDetail/{packingDetailId}/tag | Get the tags for a packingDetail.
[**UpdatePackingDetailCustomFields**](PackingDetailApi.md#updatepackingdetailcustomfields) | **PUT** /v3.0/packingDetail/customFields | Update a packingDetail custom fields


<a name="addpackingdetailaudit"></a>
# **AddPackingDetailAudit**
> void AddPackingDetailAudit (int? packingDetailId, string packingDetailAudit)

Add new audit for a packingDetail

Adds an audit to an existing packingDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingDetailAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to add an audit to
            var packingDetailAudit = packingDetailAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a packingDetail
                apiInstance.AddPackingDetailAudit(packingDetailId, packingDetailAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.AddPackingDetailAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to add an audit to | 
 **packingDetailAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingdetailfile"></a>
# **AddPackingDetailFile**
> void AddPackingDetailFile (int? packingDetailId, string fileName)

Attach a file to a packingDetail

Adds a file to an existing packingDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a packingDetail
                apiInstance.AddPackingDetailFile(packingDetailId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.AddPackingDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingdetailfilebyurl"></a>
# **AddPackingDetailFileByURL**
> void AddPackingDetailFileByURL (RecordFile body, int? packingDetailId)

Attach a file to a packingDetail by URL.

Adds a file to an existing packingDetail by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingDetailFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var packingDetailId = 56;  // int? | Id of the packingDetail to add an file to

            try
            {
                // Attach a file to a packingDetail by URL.
                apiInstance.AddPackingDetailFileByURL(body, packingDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.AddPackingDetailFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **packingDetailId** | **int?**| Id of the packingDetail to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingdetailtag"></a>
# **AddPackingDetailTag**
> void AddPackingDetailTag (int? packingDetailId, string packingDetailTag)

Add new tags for a packingDetail.

Adds a tag to an existing packingDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to add a tag to
            var packingDetailTag = packingDetailTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a packingDetail.
                apiInstance.AddPackingDetailTag(packingDetailId, packingDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.AddPackingDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to add a tag to | 
 **packingDetailTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingdetailfile"></a>
# **DeletePackingDetailFile**
> void DeletePackingDetailFile (int? packingDetailId, int? fileId)

Delete a file for a packingDetail.

Deletes an existing packingDetail file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a packingDetail.
                apiInstance.DeletePackingDetailFile(packingDetailId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.DeletePackingDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingdetailtag"></a>
# **DeletePackingDetailTag**
> void DeletePackingDetailTag (int? packingDetailId, string packingDetailTag)

Delete a tag for a packingDetail.

Deletes an existing packingDetail tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to remove tag from
            var packingDetailTag = packingDetailTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a packingDetail.
                apiInstance.DeletePackingDetailTag(packingDetailId, packingDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.DeletePackingDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to remove tag from | 
 **packingDetailTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatepackingdetailbyid"></a>
# **GetDuplicatePackingDetailById**
> PackingDetail GetDuplicatePackingDetailById (int? packingDetailId)

Get a duplicated a packingDetail by id

Returns a duplicated packingDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicatePackingDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to be duplicated.

            try
            {
                // Get a duplicated a packingDetail by id
                PackingDetail result = apiInstance.GetDuplicatePackingDetailById(packingDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.GetDuplicatePackingDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to be duplicated. | 

### Return type

[**PackingDetail**](PackingDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingdetailbyfilter"></a>
# **GetPackingDetailByFilter**
> List<PackingDetail> GetPackingDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search packingDetails by filter

Returns the list of packingDetails that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingDetailByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search packingDetails by filter
                List&lt;PackingDetail&gt; result = apiInstance.GetPackingDetailByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.GetPackingDetailByFilter: " + e.Message );
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

[**List<PackingDetail>**](PackingDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingdetailbyid"></a>
# **GetPackingDetailById**
> PackingDetail GetPackingDetailById (int? packingDetailId)

Get a packingDetail by id

Returns the packingDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to be returned.

            try
            {
                // Get a packingDetail by id
                PackingDetail result = apiInstance.GetPackingDetailById(packingDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.GetPackingDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to be returned. | 

### Return type

[**PackingDetail**](PackingDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingdetailfiles"></a>
# **GetPackingDetailFiles**
> void GetPackingDetailFiles (int? packingDetailId)

Get the files for a packingDetail.

Get all existing packingDetail files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingDetailFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to get files for

            try
            {
                // Get the files for a packingDetail.
                apiInstance.GetPackingDetailFiles(packingDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.GetPackingDetailFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingdetailtags"></a>
# **GetPackingDetailTags**
> void GetPackingDetailTags (int? packingDetailId)

Get the tags for a packingDetail.

Get all existing packingDetail tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingDetailTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var packingDetailId = 56;  // int? | Id of the packingDetail to get tags for

            try
            {
                // Get the tags for a packingDetail.
                apiInstance.GetPackingDetailTags(packingDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.GetPackingDetailTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingDetailId** | **int?**| Id of the packingDetail to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepackingdetailcustomfields"></a>
# **UpdatePackingDetailCustomFields**
> void UpdatePackingDetailCustomFields (PackingDetail body)

Update a packingDetail custom fields

Updates an existing packingDetail custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePackingDetailCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingDetailApi();
            var body = new PackingDetail(); // PackingDetail | PackingDetail to be updated.

            try
            {
                // Update a packingDetail custom fields
                apiInstance.UpdatePackingDetailCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingDetailApi.UpdatePackingDetailCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PackingDetail**](PackingDetail.md)| PackingDetail to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

