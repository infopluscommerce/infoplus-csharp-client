# Infoplus.Api.FulfillmentProcessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentProcessAudit**](FulfillmentProcessApi.md#addfulfillmentprocessaudit) | **PUT** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/audit/{fulfillmentProcessAudit} | Add new audit for a fulfillmentProcess
[**AddFulfillmentProcessFile**](FulfillmentProcessApi.md#addfulfillmentprocessfile) | **POST** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/file/{fileName} | Attach a file to a fulfillmentProcess
[**AddFulfillmentProcessFileByURL**](FulfillmentProcessApi.md#addfulfillmentprocessfilebyurl) | **POST** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/file | Attach a file to a fulfillmentProcess by URL.
[**AddFulfillmentProcessTag**](FulfillmentProcessApi.md#addfulfillmentprocesstag) | **PUT** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/tag/{fulfillmentProcessTag} | Add new tags for a fulfillmentProcess.
[**DeleteFulfillmentProcessFile**](FulfillmentProcessApi.md#deletefulfillmentprocessfile) | **DELETE** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/file/{fileId} | Delete a file for a fulfillmentProcess.
[**DeleteFulfillmentProcessTag**](FulfillmentProcessApi.md#deletefulfillmentprocesstag) | **DELETE** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/tag/{fulfillmentProcessTag} | Delete a tag for a fulfillmentProcess.
[**GetDuplicateFulfillmentProcessById**](FulfillmentProcessApi.md#getduplicatefulfillmentprocessbyid) | **GET** /v3.0/fulfillmentProcess/duplicate/{fulfillmentProcessId} | Get a duplicated a fulfillmentProcess by id
[**GetFulfillmentProcessByFilter**](FulfillmentProcessApi.md#getfulfillmentprocessbyfilter) | **GET** /v3.0/fulfillmentProcess/search | Search fulfillmentProcesses by filter
[**GetFulfillmentProcessById**](FulfillmentProcessApi.md#getfulfillmentprocessbyid) | **GET** /v3.0/fulfillmentProcess/{fulfillmentProcessId} | Get a fulfillmentProcess by id
[**GetFulfillmentProcessFiles**](FulfillmentProcessApi.md#getfulfillmentprocessfiles) | **GET** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/file | Get the files for a fulfillmentProcess.
[**GetFulfillmentProcessTags**](FulfillmentProcessApi.md#getfulfillmentprocesstags) | **GET** /v3.0/fulfillmentProcess/{fulfillmentProcessId}/tag | Get the tags for a fulfillmentProcess.
[**UpdateFulfillmentProcessCustomFields**](FulfillmentProcessApi.md#updatefulfillmentprocesscustomfields) | **PUT** /v3.0/fulfillmentProcess/customFields | Update a fulfillmentProcess custom fields


<a name="addfulfillmentprocessaudit"></a>
# **AddFulfillmentProcessAudit**
> void AddFulfillmentProcessAudit (int? fulfillmentProcessId, string fulfillmentProcessAudit)

Add new audit for a fulfillmentProcess

Adds an audit to an existing fulfillmentProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to add an audit to
            var fulfillmentProcessAudit = fulfillmentProcessAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a fulfillmentProcess
                apiInstance.AddFulfillmentProcessAudit(fulfillmentProcessId, fulfillmentProcessAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.AddFulfillmentProcessAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to add an audit to | 
 **fulfillmentProcessAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentprocessfile"></a>
# **AddFulfillmentProcessFile**
> void AddFulfillmentProcessFile (int? fulfillmentProcessId, string fileName)

Attach a file to a fulfillmentProcess

Adds a file to an existing fulfillmentProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a fulfillmentProcess
                apiInstance.AddFulfillmentProcessFile(fulfillmentProcessId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.AddFulfillmentProcessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentprocessfilebyurl"></a>
# **AddFulfillmentProcessFileByURL**
> void AddFulfillmentProcessFileByURL (RecordFile body, int? fulfillmentProcessId)

Attach a file to a fulfillmentProcess by URL.

Adds a file to an existing fulfillmentProcess by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to add an file to

            try
            {
                // Attach a file to a fulfillmentProcess by URL.
                apiInstance.AddFulfillmentProcessFileByURL(body, fulfillmentProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.AddFulfillmentProcessFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentprocesstag"></a>
# **AddFulfillmentProcessTag**
> void AddFulfillmentProcessTag (int? fulfillmentProcessId, string fulfillmentProcessTag)

Add new tags for a fulfillmentProcess.

Adds a tag to an existing fulfillmentProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentProcessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to add a tag to
            var fulfillmentProcessTag = fulfillmentProcessTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a fulfillmentProcess.
                apiInstance.AddFulfillmentProcessTag(fulfillmentProcessId, fulfillmentProcessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.AddFulfillmentProcessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to add a tag to | 
 **fulfillmentProcessTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentprocessfile"></a>
# **DeleteFulfillmentProcessFile**
> void DeleteFulfillmentProcessFile (int? fulfillmentProcessId, int? fileId)

Delete a file for a fulfillmentProcess.

Deletes an existing fulfillmentProcess file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentProcessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a fulfillmentProcess.
                apiInstance.DeleteFulfillmentProcessFile(fulfillmentProcessId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.DeleteFulfillmentProcessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentprocesstag"></a>
# **DeleteFulfillmentProcessTag**
> void DeleteFulfillmentProcessTag (int? fulfillmentProcessId, string fulfillmentProcessTag)

Delete a tag for a fulfillmentProcess.

Deletes an existing fulfillmentProcess tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentProcessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to remove tag from
            var fulfillmentProcessTag = fulfillmentProcessTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a fulfillmentProcess.
                apiInstance.DeleteFulfillmentProcessTag(fulfillmentProcessId, fulfillmentProcessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.DeleteFulfillmentProcessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to remove tag from | 
 **fulfillmentProcessTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatefulfillmentprocessbyid"></a>
# **GetDuplicateFulfillmentProcessById**
> FulfillmentProcess GetDuplicateFulfillmentProcessById (int? fulfillmentProcessId)

Get a duplicated a fulfillmentProcess by id

Returns a duplicated fulfillmentProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateFulfillmentProcessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to be duplicated.

            try
            {
                // Get a duplicated a fulfillmentProcess by id
                FulfillmentProcess result = apiInstance.GetDuplicateFulfillmentProcessById(fulfillmentProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetDuplicateFulfillmentProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to be duplicated. | 

### Return type

[**FulfillmentProcess**](FulfillmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocessbyfilter"></a>
# **GetFulfillmentProcessByFilter**
> List<FulfillmentProcess> GetFulfillmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search fulfillmentProcesses by filter

Returns the list of fulfillmentProcesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search fulfillmentProcesses by filter
                List&lt;FulfillmentProcess&gt; result = apiInstance.GetFulfillmentProcessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetFulfillmentProcessByFilter: " + e.Message );
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

[**List<FulfillmentProcess>**](FulfillmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocessbyid"></a>
# **GetFulfillmentProcessById**
> FulfillmentProcess GetFulfillmentProcessById (int? fulfillmentProcessId)

Get a fulfillmentProcess by id

Returns the fulfillmentProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to be returned.

            try
            {
                // Get a fulfillmentProcess by id
                FulfillmentProcess result = apiInstance.GetFulfillmentProcessById(fulfillmentProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetFulfillmentProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to be returned. | 

### Return type

[**FulfillmentProcess**](FulfillmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocessfiles"></a>
# **GetFulfillmentProcessFiles**
> void GetFulfillmentProcessFiles (int? fulfillmentProcessId)

Get the files for a fulfillmentProcess.

Get all existing fulfillmentProcess files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to get files for

            try
            {
                // Get the files for a fulfillmentProcess.
                apiInstance.GetFulfillmentProcessFiles(fulfillmentProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetFulfillmentProcessFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentprocesstags"></a>
# **GetFulfillmentProcessTags**
> void GetFulfillmentProcessTags (int? fulfillmentProcessId)

Get the tags for a fulfillmentProcess.

Get all existing fulfillmentProcess tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentProcessTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var fulfillmentProcessId = 56;  // int? | Id of the fulfillmentProcess to get tags for

            try
            {
                // Get the tags for a fulfillmentProcess.
                apiInstance.GetFulfillmentProcessTags(fulfillmentProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.GetFulfillmentProcessTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentProcessId** | **int?**| Id of the fulfillmentProcess to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentprocesscustomfields"></a>
# **UpdateFulfillmentProcessCustomFields**
> void UpdateFulfillmentProcessCustomFields (FulfillmentProcess body)

Update a fulfillmentProcess custom fields

Updates an existing fulfillmentProcess custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFulfillmentProcessCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentProcessApi();
            var body = new FulfillmentProcess(); // FulfillmentProcess | FulfillmentProcess to be updated.

            try
            {
                // Update a fulfillmentProcess custom fields
                apiInstance.UpdateFulfillmentProcessCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentProcessApi.UpdateFulfillmentProcessCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentProcess**](FulfillmentProcess.md)| FulfillmentProcess to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

