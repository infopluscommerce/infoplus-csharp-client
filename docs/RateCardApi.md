# Infoplus.Api.RateCardApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRateCard**](RateCardApi.md#addratecard) | **POST** /beta/rateCard | Create a rateCard
[**AddRateCardAudit**](RateCardApi.md#addratecardaudit) | **PUT** /beta/rateCard/{rateCardId}/audit/{rateCardAudit} | Add new audit for a rateCard
[**AddRateCardFile**](RateCardApi.md#addratecardfile) | **POST** /beta/rateCard/{rateCardId}/file/{fileName} | Attach a file to a rateCard
[**AddRateCardFileByURL**](RateCardApi.md#addratecardfilebyurl) | **POST** /beta/rateCard/{rateCardId}/file | Attach a file to a rateCard by URL.
[**AddRateCardTag**](RateCardApi.md#addratecardtag) | **PUT** /beta/rateCard/{rateCardId}/tag/{rateCardTag} | Add new tags for a rateCard.
[**DeleteRateCard**](RateCardApi.md#deleteratecard) | **DELETE** /beta/rateCard/{rateCardId} | Delete a rateCard
[**DeleteRateCardFile**](RateCardApi.md#deleteratecardfile) | **DELETE** /beta/rateCard/{rateCardId}/file/{fileId} | Delete a file for a rateCard.
[**DeleteRateCardTag**](RateCardApi.md#deleteratecardtag) | **DELETE** /beta/rateCard/{rateCardId}/tag/{rateCardTag} | Delete a tag for a rateCard.
[**GetDuplicateRateCardById**](RateCardApi.md#getduplicateratecardbyid) | **GET** /beta/rateCard/duplicate/{rateCardId} | Get a duplicated a rateCard by id
[**GetRateCardByFilter**](RateCardApi.md#getratecardbyfilter) | **GET** /beta/rateCard/search | Search rateCards by filter
[**GetRateCardById**](RateCardApi.md#getratecardbyid) | **GET** /beta/rateCard/{rateCardId} | Get a rateCard by id
[**GetRateCardFiles**](RateCardApi.md#getratecardfiles) | **GET** /beta/rateCard/{rateCardId}/file | Get the files for a rateCard.
[**GetRateCardTags**](RateCardApi.md#getratecardtags) | **GET** /beta/rateCard/{rateCardId}/tag | Get the tags for a rateCard.
[**UpdateRateCard**](RateCardApi.md#updateratecard) | **PUT** /beta/rateCard | Update a rateCard


<a name="addratecard"></a>
# **AddRateCard**
> RateCard AddRateCard (RateCard body)

Create a rateCard

Inserts a new rateCard using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddRateCardExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var body = new RateCard(); // RateCard | RateCard to be inserted.

            try
            {
                // Create a rateCard
                RateCard result = apiInstance.AddRateCard(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.AddRateCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RateCard**](RateCard.md)| RateCard to be inserted. | 

### Return type

[**RateCard**](RateCard.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addratecardaudit"></a>
# **AddRateCardAudit**
> void AddRateCardAudit (int? rateCardId, string rateCardAudit)

Add new audit for a rateCard

Adds an audit to an existing rateCard.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddRateCardAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to add an audit to
            var rateCardAudit = rateCardAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a rateCard
                apiInstance.AddRateCardAudit(rateCardId, rateCardAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.AddRateCardAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to add an audit to | 
 **rateCardAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addratecardfile"></a>
# **AddRateCardFile**
> void AddRateCardFile (int? rateCardId, string fileName)

Attach a file to a rateCard

Adds a file to an existing rateCard.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddRateCardFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a rateCard
                apiInstance.AddRateCardFile(rateCardId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.AddRateCardFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addratecardfilebyurl"></a>
# **AddRateCardFileByURL**
> void AddRateCardFileByURL (RecordFile body, int? rateCardId)

Attach a file to a rateCard by URL.

Adds a file to an existing rateCard by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddRateCardFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var rateCardId = 56;  // int? | Id of the rateCard to add an file to

            try
            {
                // Attach a file to a rateCard by URL.
                apiInstance.AddRateCardFileByURL(body, rateCardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.AddRateCardFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **rateCardId** | **int?**| Id of the rateCard to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addratecardtag"></a>
# **AddRateCardTag**
> void AddRateCardTag (int? rateCardId, string rateCardTag)

Add new tags for a rateCard.

Adds a tag to an existing rateCard.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddRateCardTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to add a tag to
            var rateCardTag = rateCardTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a rateCard.
                apiInstance.AddRateCardTag(rateCardId, rateCardTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.AddRateCardTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to add a tag to | 
 **rateCardTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteratecard"></a>
# **DeleteRateCard**
> void DeleteRateCard (int? rateCardId)

Delete a rateCard

Deletes the rateCard identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteRateCardExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to be deleted.

            try
            {
                // Delete a rateCard
                apiInstance.DeleteRateCard(rateCardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.DeleteRateCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteratecardfile"></a>
# **DeleteRateCardFile**
> void DeleteRateCardFile (int? rateCardId, int? fileId)

Delete a file for a rateCard.

Deletes an existing rateCard file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteRateCardFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a rateCard.
                apiInstance.DeleteRateCardFile(rateCardId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.DeleteRateCardFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteratecardtag"></a>
# **DeleteRateCardTag**
> void DeleteRateCardTag (int? rateCardId, string rateCardTag)

Delete a tag for a rateCard.

Deletes an existing rateCard tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteRateCardTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to remove tag from
            var rateCardTag = rateCardTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a rateCard.
                apiInstance.DeleteRateCardTag(rateCardId, rateCardTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.DeleteRateCardTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to remove tag from | 
 **rateCardTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateratecardbyid"></a>
# **GetDuplicateRateCardById**
> RateCard GetDuplicateRateCardById (int? rateCardId)

Get a duplicated a rateCard by id

Returns a duplicated rateCard identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateRateCardByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to be duplicated.

            try
            {
                // Get a duplicated a rateCard by id
                RateCard result = apiInstance.GetDuplicateRateCardById(rateCardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.GetDuplicateRateCardById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to be duplicated. | 

### Return type

[**RateCard**](RateCard.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratecardbyfilter"></a>
# **GetRateCardByFilter**
> List<RateCard> GetRateCardByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search rateCards by filter

Returns the list of rateCards that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetRateCardByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search rateCards by filter
                List&lt;RateCard&gt; result = apiInstance.GetRateCardByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.GetRateCardByFilter: " + e.Message );
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

[**List<RateCard>**](RateCard.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratecardbyid"></a>
# **GetRateCardById**
> RateCard GetRateCardById (int? rateCardId)

Get a rateCard by id

Returns the rateCard identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetRateCardByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to be returned.

            try
            {
                // Get a rateCard by id
                RateCard result = apiInstance.GetRateCardById(rateCardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.GetRateCardById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to be returned. | 

### Return type

[**RateCard**](RateCard.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratecardfiles"></a>
# **GetRateCardFiles**
> void GetRateCardFiles (int? rateCardId)

Get the files for a rateCard.

Get all existing rateCard files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetRateCardFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to get files for

            try
            {
                // Get the files for a rateCard.
                apiInstance.GetRateCardFiles(rateCardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.GetRateCardFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratecardtags"></a>
# **GetRateCardTags**
> void GetRateCardTags (int? rateCardId)

Get the tags for a rateCard.

Get all existing rateCard tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetRateCardTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var rateCardId = 56;  // int? | Id of the rateCard to get tags for

            try
            {
                // Get the tags for a rateCard.
                apiInstance.GetRateCardTags(rateCardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.GetRateCardTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateCardId** | **int?**| Id of the rateCard to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateratecard"></a>
# **UpdateRateCard**
> void UpdateRateCard (RateCard body)

Update a rateCard

Updates an existing rateCard using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateRateCardExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new RateCardApi();
            var body = new RateCard(); // RateCard | RateCard to be updated.

            try
            {
                // Update a rateCard
                apiInstance.UpdateRateCard(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateCardApi.UpdateRateCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RateCard**](RateCard.md)| RateCard to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

