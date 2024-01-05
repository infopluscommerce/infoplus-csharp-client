# Infoplus.Api.PackingPlanDetailApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPackingPlanDetailAudit**](PackingPlanDetailApi.md#addpackingplandetailaudit) | **PUT** /beta/packingPlanDetail/{packingPlanDetailId}/audit/{packingPlanDetailAudit} | Add new audit for a packingPlanDetail
[**AddPackingPlanDetailFile**](PackingPlanDetailApi.md#addpackingplandetailfile) | **POST** /beta/packingPlanDetail/{packingPlanDetailId}/file/{fileName} | Attach a file to a packingPlanDetail
[**AddPackingPlanDetailFileByURL**](PackingPlanDetailApi.md#addpackingplandetailfilebyurl) | **POST** /beta/packingPlanDetail/{packingPlanDetailId}/file | Attach a file to a packingPlanDetail by URL.
[**AddPackingPlanDetailTag**](PackingPlanDetailApi.md#addpackingplandetailtag) | **PUT** /beta/packingPlanDetail/{packingPlanDetailId}/tag/{packingPlanDetailTag} | Add new tags for a packingPlanDetail.
[**DeletePackingPlanDetailFile**](PackingPlanDetailApi.md#deletepackingplandetailfile) | **DELETE** /beta/packingPlanDetail/{packingPlanDetailId}/file/{fileId} | Delete a file for a packingPlanDetail.
[**DeletePackingPlanDetailTag**](PackingPlanDetailApi.md#deletepackingplandetailtag) | **DELETE** /beta/packingPlanDetail/{packingPlanDetailId}/tag/{packingPlanDetailTag} | Delete a tag for a packingPlanDetail.
[**GetDuplicatePackingPlanDetailById**](PackingPlanDetailApi.md#getduplicatepackingplandetailbyid) | **GET** /beta/packingPlanDetail/duplicate/{packingPlanDetailId} | Get a duplicated a packingPlanDetail by id
[**GetPackingPlanDetailByFilter**](PackingPlanDetailApi.md#getpackingplandetailbyfilter) | **GET** /beta/packingPlanDetail/search | Search packingPlanDetails by filter
[**GetPackingPlanDetailById**](PackingPlanDetailApi.md#getpackingplandetailbyid) | **GET** /beta/packingPlanDetail/{packingPlanDetailId} | Get a packingPlanDetail by id
[**GetPackingPlanDetailFiles**](PackingPlanDetailApi.md#getpackingplandetailfiles) | **GET** /beta/packingPlanDetail/{packingPlanDetailId}/file | Get the files for a packingPlanDetail.
[**GetPackingPlanDetailTags**](PackingPlanDetailApi.md#getpackingplandetailtags) | **GET** /beta/packingPlanDetail/{packingPlanDetailId}/tag | Get the tags for a packingPlanDetail.
[**UpdatePackingPlanDetailCustomFields**](PackingPlanDetailApi.md#updatepackingplandetailcustomfields) | **PUT** /beta/packingPlanDetail/customFields | Update a packingPlanDetail custom fields


<a name="addpackingplandetailaudit"></a>
# **AddPackingPlanDetailAudit**
> void AddPackingPlanDetailAudit (int? packingPlanDetailId, string packingPlanDetailAudit)

Add new audit for a packingPlanDetail

Adds an audit to an existing packingPlanDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanDetailAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to add an audit to
            var packingPlanDetailAudit = packingPlanDetailAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a packingPlanDetail
                apiInstance.AddPackingPlanDetailAudit(packingPlanDetailId, packingPlanDetailAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.AddPackingPlanDetailAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to add an audit to | 
 **packingPlanDetailAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplandetailfile"></a>
# **AddPackingPlanDetailFile**
> void AddPackingPlanDetailFile (int? packingPlanDetailId, string fileName)

Attach a file to a packingPlanDetail

Adds a file to an existing packingPlanDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a packingPlanDetail
                apiInstance.AddPackingPlanDetailFile(packingPlanDetailId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.AddPackingPlanDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplandetailfilebyurl"></a>
# **AddPackingPlanDetailFileByURL**
> void AddPackingPlanDetailFileByURL (RecordFile body, int? packingPlanDetailId)

Attach a file to a packingPlanDetail by URL.

Adds a file to an existing packingPlanDetail by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanDetailFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to add an file to

            try
            {
                // Attach a file to a packingPlanDetail by URL.
                apiInstance.AddPackingPlanDetailFileByURL(body, packingPlanDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.AddPackingPlanDetailFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplandetailtag"></a>
# **AddPackingPlanDetailTag**
> void AddPackingPlanDetailTag (int? packingPlanDetailId, string packingPlanDetailTag)

Add new tags for a packingPlanDetail.

Adds a tag to an existing packingPlanDetail.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to add a tag to
            var packingPlanDetailTag = packingPlanDetailTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a packingPlanDetail.
                apiInstance.AddPackingPlanDetailTag(packingPlanDetailId, packingPlanDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.AddPackingPlanDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to add a tag to | 
 **packingPlanDetailTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingplandetailfile"></a>
# **DeletePackingPlanDetailFile**
> void DeletePackingPlanDetailFile (int? packingPlanDetailId, int? fileId)

Delete a file for a packingPlanDetail.

Deletes an existing packingPlanDetail file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingPlanDetailFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a packingPlanDetail.
                apiInstance.DeletePackingPlanDetailFile(packingPlanDetailId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.DeletePackingPlanDetailFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingplandetailtag"></a>
# **DeletePackingPlanDetailTag**
> void DeletePackingPlanDetailTag (int? packingPlanDetailId, string packingPlanDetailTag)

Delete a tag for a packingPlanDetail.

Deletes an existing packingPlanDetail tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingPlanDetailTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to remove tag from
            var packingPlanDetailTag = packingPlanDetailTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a packingPlanDetail.
                apiInstance.DeletePackingPlanDetailTag(packingPlanDetailId, packingPlanDetailTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.DeletePackingPlanDetailTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to remove tag from | 
 **packingPlanDetailTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatepackingplandetailbyid"></a>
# **GetDuplicatePackingPlanDetailById**
> PackingPlanDetail GetDuplicatePackingPlanDetailById (int? packingPlanDetailId)

Get a duplicated a packingPlanDetail by id

Returns a duplicated packingPlanDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicatePackingPlanDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to be duplicated.

            try
            {
                // Get a duplicated a packingPlanDetail by id
                PackingPlanDetail result = apiInstance.GetDuplicatePackingPlanDetailById(packingPlanDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.GetDuplicatePackingPlanDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to be duplicated. | 

### Return type

[**PackingPlanDetail**](PackingPlanDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplandetailbyfilter"></a>
# **GetPackingPlanDetailByFilter**
> List<PackingPlanDetail> GetPackingPlanDetailByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search packingPlanDetails by filter

Returns the list of packingPlanDetails that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanDetailByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search packingPlanDetails by filter
                List&lt;PackingPlanDetail&gt; result = apiInstance.GetPackingPlanDetailByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.GetPackingPlanDetailByFilter: " + e.Message );
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

[**List<PackingPlanDetail>**](PackingPlanDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplandetailbyid"></a>
# **GetPackingPlanDetailById**
> PackingPlanDetail GetPackingPlanDetailById (int? packingPlanDetailId)

Get a packingPlanDetail by id

Returns the packingPlanDetail identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanDetailByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to be returned.

            try
            {
                // Get a packingPlanDetail by id
                PackingPlanDetail result = apiInstance.GetPackingPlanDetailById(packingPlanDetailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.GetPackingPlanDetailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to be returned. | 

### Return type

[**PackingPlanDetail**](PackingPlanDetail.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplandetailfiles"></a>
# **GetPackingPlanDetailFiles**
> void GetPackingPlanDetailFiles (int? packingPlanDetailId)

Get the files for a packingPlanDetail.

Get all existing packingPlanDetail files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanDetailFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to get files for

            try
            {
                // Get the files for a packingPlanDetail.
                apiInstance.GetPackingPlanDetailFiles(packingPlanDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.GetPackingPlanDetailFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplandetailtags"></a>
# **GetPackingPlanDetailTags**
> void GetPackingPlanDetailTags (int? packingPlanDetailId)

Get the tags for a packingPlanDetail.

Get all existing packingPlanDetail tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanDetailTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var packingPlanDetailId = 56;  // int? | Id of the packingPlanDetail to get tags for

            try
            {
                // Get the tags for a packingPlanDetail.
                apiInstance.GetPackingPlanDetailTags(packingPlanDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.GetPackingPlanDetailTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanDetailId** | **int?**| Id of the packingPlanDetail to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepackingplandetailcustomfields"></a>
# **UpdatePackingPlanDetailCustomFields**
> void UpdatePackingPlanDetailCustomFields (PackingPlanDetail body)

Update a packingPlanDetail custom fields

Updates an existing packingPlanDetail custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePackingPlanDetailCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanDetailApi();
            var body = new PackingPlanDetail(); // PackingPlanDetail | PackingPlanDetail to be updated.

            try
            {
                // Update a packingPlanDetail custom fields
                apiInstance.UpdatePackingPlanDetailCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanDetailApi.UpdatePackingPlanDetailCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PackingPlanDetail**](PackingPlanDetail.md)| PackingPlanDetail to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

