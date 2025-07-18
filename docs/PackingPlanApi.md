# Infoplus.Api.PackingPlanApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPackingPlan**](PackingPlanApi.md#addpackingplan) | **POST** /beta/packingPlan | Create a packingPlan
[**AddPackingPlanAudit**](PackingPlanApi.md#addpackingplanaudit) | **PUT** /beta/packingPlan/{packingPlanId}/audit/{packingPlanAudit} | Add new audit for a packingPlan
[**AddPackingPlanFile**](PackingPlanApi.md#addpackingplanfile) | **POST** /beta/packingPlan/{packingPlanId}/file/{fileName} | Attach a file to a packingPlan
[**AddPackingPlanFileByURL**](PackingPlanApi.md#addpackingplanfilebyurl) | **POST** /beta/packingPlan/{packingPlanId}/file | Attach a file to a packingPlan by URL.
[**AddPackingPlanTag**](PackingPlanApi.md#addpackingplantag) | **PUT** /beta/packingPlan/{packingPlanId}/tag/{packingPlanTag} | Add new tags for a packingPlan.
[**DeletePackingPlan**](PackingPlanApi.md#deletepackingplan) | **DELETE** /beta/packingPlan/{packingPlanId} | Delete a packingPlan
[**DeletePackingPlanFile**](PackingPlanApi.md#deletepackingplanfile) | **DELETE** /beta/packingPlan/{packingPlanId}/file/{fileId} | Delete a file for a packingPlan.
[**DeletePackingPlanTag**](PackingPlanApi.md#deletepackingplantag) | **DELETE** /beta/packingPlan/{packingPlanId}/tag/{packingPlanTag} | Delete a tag for a packingPlan.
[**GetDuplicatePackingPlanById**](PackingPlanApi.md#getduplicatepackingplanbyid) | **GET** /beta/packingPlan/duplicate/{packingPlanId} | Get a duplicated a packingPlan by id
[**GetPackingPlanByFilter**](PackingPlanApi.md#getpackingplanbyfilter) | **GET** /beta/packingPlan/search | Search packingPlans by filter
[**GetPackingPlanById**](PackingPlanApi.md#getpackingplanbyid) | **GET** /beta/packingPlan/{packingPlanId} | Get a packingPlan by id
[**GetPackingPlanFiles**](PackingPlanApi.md#getpackingplanfiles) | **GET** /beta/packingPlan/{packingPlanId}/file | Get the files for a packingPlan.
[**GetPackingPlanTags**](PackingPlanApi.md#getpackingplantags) | **GET** /beta/packingPlan/{packingPlanId}/tag | Get the tags for a packingPlan.
[**UpdatePackingPlan**](PackingPlanApi.md#updatepackingplan) | **PUT** /beta/packingPlan | Update a packingPlan
[**UpdatePackingPlanCustomFields**](PackingPlanApi.md#updatepackingplancustomfields) | **PUT** /beta/packingPlan/customFields | Update a packingPlan custom fields


<a name="addpackingplan"></a>
# **AddPackingPlan**
> PackingPlan AddPackingPlan (PackingPlan body)

Create a packingPlan

Inserts a new packingPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var body = new PackingPlan(); // PackingPlan | PackingPlan to be inserted.

            try
            {
                // Create a packingPlan
                PackingPlan result = apiInstance.AddPackingPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.AddPackingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PackingPlan**](PackingPlan.md)| PackingPlan to be inserted. | 

### Return type

[**PackingPlan**](PackingPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplanaudit"></a>
# **AddPackingPlanAudit**
> void AddPackingPlanAudit (int? packingPlanId, string packingPlanAudit)

Add new audit for a packingPlan

Adds an audit to an existing packingPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to add an audit to
            var packingPlanAudit = packingPlanAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a packingPlan
                apiInstance.AddPackingPlanAudit(packingPlanId, packingPlanAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.AddPackingPlanAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to add an audit to | 
 **packingPlanAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplanfile"></a>
# **AddPackingPlanFile**
> void AddPackingPlanFile (int? packingPlanId, string fileName)

Attach a file to a packingPlan

Adds a file to an existing packingPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a packingPlan
                apiInstance.AddPackingPlanFile(packingPlanId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.AddPackingPlanFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplanfilebyurl"></a>
# **AddPackingPlanFileByURL**
> void AddPackingPlanFileByURL (RecordFile body, int? packingPlanId)

Attach a file to a packingPlan by URL.

Adds a file to an existing packingPlan by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var packingPlanId = 56;  // int? | Id of the packingPlan to add an file to

            try
            {
                // Attach a file to a packingPlan by URL.
                apiInstance.AddPackingPlanFileByURL(body, packingPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.AddPackingPlanFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **packingPlanId** | **int?**| Id of the packingPlan to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpackingplantag"></a>
# **AddPackingPlanTag**
> void AddPackingPlanTag (int? packingPlanId, string packingPlanTag)

Add new tags for a packingPlan.

Adds a tag to an existing packingPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPackingPlanTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to add a tag to
            var packingPlanTag = packingPlanTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a packingPlan.
                apiInstance.AddPackingPlanTag(packingPlanId, packingPlanTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.AddPackingPlanTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to add a tag to | 
 **packingPlanTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingplan"></a>
# **DeletePackingPlan**
> void DeletePackingPlan (int? packingPlanId)

Delete a packingPlan

Deletes the packingPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to be deleted.

            try
            {
                // Delete a packingPlan
                apiInstance.DeletePackingPlan(packingPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.DeletePackingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingplanfile"></a>
# **DeletePackingPlanFile**
> void DeletePackingPlanFile (int? packingPlanId, int? fileId)

Delete a file for a packingPlan.

Deletes an existing packingPlan file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingPlanFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a packingPlan.
                apiInstance.DeletePackingPlanFile(packingPlanId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.DeletePackingPlanFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepackingplantag"></a>
# **DeletePackingPlanTag**
> void DeletePackingPlanTag (int? packingPlanId, string packingPlanTag)

Delete a tag for a packingPlan.

Deletes an existing packingPlan tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePackingPlanTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to remove tag from
            var packingPlanTag = packingPlanTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a packingPlan.
                apiInstance.DeletePackingPlanTag(packingPlanId, packingPlanTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.DeletePackingPlanTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to remove tag from | 
 **packingPlanTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatepackingplanbyid"></a>
# **GetDuplicatePackingPlanById**
> PackingPlan GetDuplicatePackingPlanById (int? packingPlanId)

Get a duplicated a packingPlan by id

Returns a duplicated packingPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicatePackingPlanByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to be duplicated.

            try
            {
                // Get a duplicated a packingPlan by id
                PackingPlan result = apiInstance.GetDuplicatePackingPlanById(packingPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.GetDuplicatePackingPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to be duplicated. | 

### Return type

[**PackingPlan**](PackingPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplanbyfilter"></a>
# **GetPackingPlanByFilter**
> List<PackingPlan> GetPackingPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search packingPlans by filter

Returns the list of packingPlans that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search packingPlans by filter
                List&lt;PackingPlan&gt; result = apiInstance.GetPackingPlanByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.GetPackingPlanByFilter: " + e.Message );
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

[**List<PackingPlan>**](PackingPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplanbyid"></a>
# **GetPackingPlanById**
> PackingPlan GetPackingPlanById (int? packingPlanId)

Get a packingPlan by id

Returns the packingPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to be returned.

            try
            {
                // Get a packingPlan by id
                PackingPlan result = apiInstance.GetPackingPlanById(packingPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.GetPackingPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to be returned. | 

### Return type

[**PackingPlan**](PackingPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplanfiles"></a>
# **GetPackingPlanFiles**
> void GetPackingPlanFiles (int? packingPlanId)

Get the files for a packingPlan.

Get all existing packingPlan files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to get files for

            try
            {
                // Get the files for a packingPlan.
                apiInstance.GetPackingPlanFiles(packingPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.GetPackingPlanFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpackingplantags"></a>
# **GetPackingPlanTags**
> void GetPackingPlanTags (int? packingPlanId)

Get the tags for a packingPlan.

Get all existing packingPlan tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPackingPlanTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var packingPlanId = 56;  // int? | Id of the packingPlan to get tags for

            try
            {
                // Get the tags for a packingPlan.
                apiInstance.GetPackingPlanTags(packingPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.GetPackingPlanTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packingPlanId** | **int?**| Id of the packingPlan to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepackingplan"></a>
# **UpdatePackingPlan**
> void UpdatePackingPlan (PackingPlan body)

Update a packingPlan

Updates an existing packingPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePackingPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var body = new PackingPlan(); // PackingPlan | PackingPlan to be updated.

            try
            {
                // Update a packingPlan
                apiInstance.UpdatePackingPlan(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.UpdatePackingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PackingPlan**](PackingPlan.md)| PackingPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepackingplancustomfields"></a>
# **UpdatePackingPlanCustomFields**
> void UpdatePackingPlanCustomFields (PackingPlan body)

Update a packingPlan custom fields

Updates an existing packingPlan custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePackingPlanCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new PackingPlanApi();
            var body = new PackingPlan(); // PackingPlan | PackingPlan to be updated.

            try
            {
                // Update a packingPlan custom fields
                apiInstance.UpdatePackingPlanCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackingPlanApi.UpdatePackingPlanCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PackingPlan**](PackingPlan.md)| PackingPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

