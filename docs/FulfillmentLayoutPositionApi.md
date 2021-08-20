# Infoplus.Api.FulfillmentLayoutPositionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentLayoutPositionAudit**](FulfillmentLayoutPositionApi.md#addfulfillmentlayoutpositionaudit) | **PUT** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/audit/{fulfillmentLayoutPositionAudit} | Add new audit for a fulfillmentLayoutPosition
[**AddFulfillmentLayoutPositionFile**](FulfillmentLayoutPositionApi.md#addfulfillmentlayoutpositionfile) | **POST** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/file/{fileName} | Attach a file to a fulfillmentLayoutPosition
[**AddFulfillmentLayoutPositionFileByURL**](FulfillmentLayoutPositionApi.md#addfulfillmentlayoutpositionfilebyurl) | **POST** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/file | Attach a file to a fulfillmentLayoutPosition by URL.
[**AddFulfillmentLayoutPositionTag**](FulfillmentLayoutPositionApi.md#addfulfillmentlayoutpositiontag) | **PUT** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/tag/{fulfillmentLayoutPositionTag} | Add new tags for a fulfillmentLayoutPosition.
[**DeleteFulfillmentLayoutPositionFile**](FulfillmentLayoutPositionApi.md#deletefulfillmentlayoutpositionfile) | **DELETE** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/file/{fileId} | Delete a file for a fulfillmentLayoutPosition.
[**DeleteFulfillmentLayoutPositionTag**](FulfillmentLayoutPositionApi.md#deletefulfillmentlayoutpositiontag) | **DELETE** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/tag/{fulfillmentLayoutPositionTag} | Delete a tag for a fulfillmentLayoutPosition.
[**GetDuplicateFulfillmentLayoutPositionById**](FulfillmentLayoutPositionApi.md#getduplicatefulfillmentlayoutpositionbyid) | **GET** /beta/fulfillmentLayoutPosition/duplicate/{fulfillmentLayoutPositionId} | Get a duplicated a fulfillmentLayoutPosition by id
[**GetFulfillmentLayoutPositionByFilter**](FulfillmentLayoutPositionApi.md#getfulfillmentlayoutpositionbyfilter) | **GET** /beta/fulfillmentLayoutPosition/search | Search fulfillmentLayoutPositions by filter
[**GetFulfillmentLayoutPositionById**](FulfillmentLayoutPositionApi.md#getfulfillmentlayoutpositionbyid) | **GET** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId} | Get a fulfillmentLayoutPosition by id
[**GetFulfillmentLayoutPositionFiles**](FulfillmentLayoutPositionApi.md#getfulfillmentlayoutpositionfiles) | **GET** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/file | Get the files for a fulfillmentLayoutPosition.
[**GetFulfillmentLayoutPositionTags**](FulfillmentLayoutPositionApi.md#getfulfillmentlayoutpositiontags) | **GET** /beta/fulfillmentLayoutPosition/{fulfillmentLayoutPositionId}/tag | Get the tags for a fulfillmentLayoutPosition.


<a name="addfulfillmentlayoutpositionaudit"></a>
# **AddFulfillmentLayoutPositionAudit**
> void AddFulfillmentLayoutPositionAudit (int? fulfillmentLayoutPositionId, string fulfillmentLayoutPositionAudit)

Add new audit for a fulfillmentLayoutPosition

Adds an audit to an existing fulfillmentLayoutPosition.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentLayoutPositionAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to add an audit to
            var fulfillmentLayoutPositionAudit = fulfillmentLayoutPositionAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a fulfillmentLayoutPosition
                apiInstance.AddFulfillmentLayoutPositionAudit(fulfillmentLayoutPositionId, fulfillmentLayoutPositionAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.AddFulfillmentLayoutPositionAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to add an audit to | 
 **fulfillmentLayoutPositionAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentlayoutpositionfile"></a>
# **AddFulfillmentLayoutPositionFile**
> void AddFulfillmentLayoutPositionFile (int? fulfillmentLayoutPositionId, string fileName)

Attach a file to a fulfillmentLayoutPosition

Adds a file to an existing fulfillmentLayoutPosition.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentLayoutPositionFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a fulfillmentLayoutPosition
                apiInstance.AddFulfillmentLayoutPositionFile(fulfillmentLayoutPositionId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.AddFulfillmentLayoutPositionFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentlayoutpositionfilebyurl"></a>
# **AddFulfillmentLayoutPositionFileByURL**
> void AddFulfillmentLayoutPositionFileByURL (RecordFile body, int? fulfillmentLayoutPositionId)

Attach a file to a fulfillmentLayoutPosition by URL.

Adds a file to an existing fulfillmentLayoutPosition by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentLayoutPositionFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to add an file to

            try
            {
                // Attach a file to a fulfillmentLayoutPosition by URL.
                apiInstance.AddFulfillmentLayoutPositionFileByURL(body, fulfillmentLayoutPositionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.AddFulfillmentLayoutPositionFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentlayoutpositiontag"></a>
# **AddFulfillmentLayoutPositionTag**
> void AddFulfillmentLayoutPositionTag (int? fulfillmentLayoutPositionId, string fulfillmentLayoutPositionTag)

Add new tags for a fulfillmentLayoutPosition.

Adds a tag to an existing fulfillmentLayoutPosition.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentLayoutPositionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to add a tag to
            var fulfillmentLayoutPositionTag = fulfillmentLayoutPositionTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a fulfillmentLayoutPosition.
                apiInstance.AddFulfillmentLayoutPositionTag(fulfillmentLayoutPositionId, fulfillmentLayoutPositionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.AddFulfillmentLayoutPositionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to add a tag to | 
 **fulfillmentLayoutPositionTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentlayoutpositionfile"></a>
# **DeleteFulfillmentLayoutPositionFile**
> void DeleteFulfillmentLayoutPositionFile (int? fulfillmentLayoutPositionId, int? fileId)

Delete a file for a fulfillmentLayoutPosition.

Deletes an existing fulfillmentLayoutPosition file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentLayoutPositionFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a fulfillmentLayoutPosition.
                apiInstance.DeleteFulfillmentLayoutPositionFile(fulfillmentLayoutPositionId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.DeleteFulfillmentLayoutPositionFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentlayoutpositiontag"></a>
# **DeleteFulfillmentLayoutPositionTag**
> void DeleteFulfillmentLayoutPositionTag (int? fulfillmentLayoutPositionId, string fulfillmentLayoutPositionTag)

Delete a tag for a fulfillmentLayoutPosition.

Deletes an existing fulfillmentLayoutPosition tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentLayoutPositionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to remove tag from
            var fulfillmentLayoutPositionTag = fulfillmentLayoutPositionTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a fulfillmentLayoutPosition.
                apiInstance.DeleteFulfillmentLayoutPositionTag(fulfillmentLayoutPositionId, fulfillmentLayoutPositionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.DeleteFulfillmentLayoutPositionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to remove tag from | 
 **fulfillmentLayoutPositionTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatefulfillmentlayoutpositionbyid"></a>
# **GetDuplicateFulfillmentLayoutPositionById**
> FulfillmentLayoutPosition GetDuplicateFulfillmentLayoutPositionById (int? fulfillmentLayoutPositionId)

Get a duplicated a fulfillmentLayoutPosition by id

Returns a duplicated fulfillmentLayoutPosition identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateFulfillmentLayoutPositionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to be duplicated.

            try
            {
                // Get a duplicated a fulfillmentLayoutPosition by id
                FulfillmentLayoutPosition result = apiInstance.GetDuplicateFulfillmentLayoutPositionById(fulfillmentLayoutPositionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.GetDuplicateFulfillmentLayoutPositionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to be duplicated. | 

### Return type

[**FulfillmentLayoutPosition**](FulfillmentLayoutPosition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlayoutpositionbyfilter"></a>
# **GetFulfillmentLayoutPositionByFilter**
> List<FulfillmentLayoutPosition> GetFulfillmentLayoutPositionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search fulfillmentLayoutPositions by filter

Returns the list of fulfillmentLayoutPositions that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentLayoutPositionByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search fulfillmentLayoutPositions by filter
                List&lt;FulfillmentLayoutPosition&gt; result = apiInstance.GetFulfillmentLayoutPositionByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.GetFulfillmentLayoutPositionByFilter: " + e.Message );
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

[**List<FulfillmentLayoutPosition>**](FulfillmentLayoutPosition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlayoutpositionbyid"></a>
# **GetFulfillmentLayoutPositionById**
> FulfillmentLayoutPosition GetFulfillmentLayoutPositionById (int? fulfillmentLayoutPositionId)

Get a fulfillmentLayoutPosition by id

Returns the fulfillmentLayoutPosition identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentLayoutPositionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to be returned.

            try
            {
                // Get a fulfillmentLayoutPosition by id
                FulfillmentLayoutPosition result = apiInstance.GetFulfillmentLayoutPositionById(fulfillmentLayoutPositionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.GetFulfillmentLayoutPositionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to be returned. | 

### Return type

[**FulfillmentLayoutPosition**](FulfillmentLayoutPosition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlayoutpositionfiles"></a>
# **GetFulfillmentLayoutPositionFiles**
> void GetFulfillmentLayoutPositionFiles (int? fulfillmentLayoutPositionId)

Get the files for a fulfillmentLayoutPosition.

Get all existing fulfillmentLayoutPosition files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentLayoutPositionFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to get files for

            try
            {
                // Get the files for a fulfillmentLayoutPosition.
                apiInstance.GetFulfillmentLayoutPositionFiles(fulfillmentLayoutPositionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.GetFulfillmentLayoutPositionFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentlayoutpositiontags"></a>
# **GetFulfillmentLayoutPositionTags**
> void GetFulfillmentLayoutPositionTags (int? fulfillmentLayoutPositionId)

Get the tags for a fulfillmentLayoutPosition.

Get all existing fulfillmentLayoutPosition tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentLayoutPositionTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentLayoutPositionApi();
            var fulfillmentLayoutPositionId = 56;  // int? | Id of the fulfillmentLayoutPosition to get tags for

            try
            {
                // Get the tags for a fulfillmentLayoutPosition.
                apiInstance.GetFulfillmentLayoutPositionTags(fulfillmentLayoutPositionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentLayoutPositionApi.GetFulfillmentLayoutPositionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentLayoutPositionId** | **int?**| Id of the fulfillmentLayoutPosition to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

