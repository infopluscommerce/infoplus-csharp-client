# Infoplus.Api.ReplenishmentProcessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReplenishmentProcessAudit**](ReplenishmentProcessApi.md#addreplenishmentprocessaudit) | **PUT** /beta/replenishmentProcess/{replenishmentProcessId}/audit/{replenishmentProcessAudit} | Add new audit for a replenishmentProcess
[**AddReplenishmentProcessFile**](ReplenishmentProcessApi.md#addreplenishmentprocessfile) | **POST** /beta/replenishmentProcess/{replenishmentProcessId}/file/{fileName} | Attach a file to a replenishmentProcess
[**AddReplenishmentProcessTag**](ReplenishmentProcessApi.md#addreplenishmentprocesstag) | **PUT** /beta/replenishmentProcess/{replenishmentProcessId}/tag/{replenishmentProcessTag} | Add new tags for a replenishmentProcess.
[**DeleteReplenishmentProcessTag**](ReplenishmentProcessApi.md#deletereplenishmentprocesstag) | **DELETE** /beta/replenishmentProcess/{replenishmentProcessId}/tag/{replenishmentProcessTag} | Delete a tag for a replenishmentProcess.
[**GetDuplicateReplenishmentProcessById**](ReplenishmentProcessApi.md#getduplicatereplenishmentprocessbyid) | **GET** /beta/replenishmentProcess/duplicate/{replenishmentProcessId} | Get a duplicated a replenishmentProcess by id
[**GetReplenishmentProcessByFilter**](ReplenishmentProcessApi.md#getreplenishmentprocessbyfilter) | **GET** /beta/replenishmentProcess/search | Search replenishmentProcesses by filter
[**GetReplenishmentProcessById**](ReplenishmentProcessApi.md#getreplenishmentprocessbyid) | **GET** /beta/replenishmentProcess/{replenishmentProcessId} | Get a replenishmentProcess by id
[**GetReplenishmentProcessTags**](ReplenishmentProcessApi.md#getreplenishmentprocesstags) | **GET** /beta/replenishmentProcess/{replenishmentProcessId}/tag | Get the tags for a replenishmentProcess.
[**UpdateReplenishmentProcessCustomFields**](ReplenishmentProcessApi.md#updatereplenishmentprocesscustomfields) | **PUT** /beta/replenishmentProcess/customFields | Update a replenishmentProcess custom fields


<a name="addreplenishmentprocessaudit"></a>
# **AddReplenishmentProcessAudit**
> void AddReplenishmentProcessAudit (int? replenishmentProcessId, string replenishmentProcessAudit)

Add new audit for a replenishmentProcess

Adds an audit to an existing replenishmentProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentProcessAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to add an audit to
            var replenishmentProcessAudit = replenishmentProcessAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a replenishmentProcess
                apiInstance.AddReplenishmentProcessAudit(replenishmentProcessId, replenishmentProcessAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.AddReplenishmentProcessAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to add an audit to | 
 **replenishmentProcessAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentprocessfile"></a>
# **AddReplenishmentProcessFile**
> void AddReplenishmentProcessFile (int? replenishmentProcessId, string fileName)

Attach a file to a replenishmentProcess

Adds a file to an existing replenishmentProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentProcessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a replenishmentProcess
                apiInstance.AddReplenishmentProcessFile(replenishmentProcessId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.AddReplenishmentProcessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentprocesstag"></a>
# **AddReplenishmentProcessTag**
> void AddReplenishmentProcessTag (int? replenishmentProcessId, string replenishmentProcessTag)

Add new tags for a replenishmentProcess.

Adds a tag to an existing replenishmentProcess.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentProcessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to add a tag to
            var replenishmentProcessTag = replenishmentProcessTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a replenishmentProcess.
                apiInstance.AddReplenishmentProcessTag(replenishmentProcessId, replenishmentProcessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.AddReplenishmentProcessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to add a tag to | 
 **replenishmentProcessTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereplenishmentprocesstag"></a>
# **DeleteReplenishmentProcessTag**
> void DeleteReplenishmentProcessTag (int? replenishmentProcessId, string replenishmentProcessTag)

Delete a tag for a replenishmentProcess.

Deletes an existing replenishmentProcess tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReplenishmentProcessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to remove tag from
            var replenishmentProcessTag = replenishmentProcessTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a replenishmentProcess.
                apiInstance.DeleteReplenishmentProcessTag(replenishmentProcessId, replenishmentProcessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.DeleteReplenishmentProcessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to remove tag from | 
 **replenishmentProcessTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereplenishmentprocessbyid"></a>
# **GetDuplicateReplenishmentProcessById**
> ReplenishmentProcess GetDuplicateReplenishmentProcessById (int? replenishmentProcessId)

Get a duplicated a replenishmentProcess by id

Returns a duplicated replenishmentProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReplenishmentProcessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to be duplicated.

            try
            {
                // Get a duplicated a replenishmentProcess by id
                ReplenishmentProcess result = apiInstance.GetDuplicateReplenishmentProcessById(replenishmentProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.GetDuplicateReplenishmentProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to be duplicated. | 

### Return type

[**ReplenishmentProcess**](ReplenishmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentprocessbyfilter"></a>
# **GetReplenishmentProcessByFilter**
> List<ReplenishmentProcess> GetReplenishmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search replenishmentProcesses by filter

Returns the list of replenishmentProcesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentProcessByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search replenishmentProcesses by filter
                List&lt;ReplenishmentProcess&gt; result = apiInstance.GetReplenishmentProcessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.GetReplenishmentProcessByFilter: " + e.Message );
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

[**List<ReplenishmentProcess>**](ReplenishmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentprocessbyid"></a>
# **GetReplenishmentProcessById**
> ReplenishmentProcess GetReplenishmentProcessById (int? replenishmentProcessId)

Get a replenishmentProcess by id

Returns the replenishmentProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentProcessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to be returned.

            try
            {
                // Get a replenishmentProcess by id
                ReplenishmentProcess result = apiInstance.GetReplenishmentProcessById(replenishmentProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.GetReplenishmentProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to be returned. | 

### Return type

[**ReplenishmentProcess**](ReplenishmentProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentprocesstags"></a>
# **GetReplenishmentProcessTags**
> void GetReplenishmentProcessTags (int? replenishmentProcessId)

Get the tags for a replenishmentProcess.

Get all existing replenishmentProcess tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentProcessTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var replenishmentProcessId = 56;  // int? | Id of the replenishmentProcess to get tags for

            try
            {
                // Get the tags for a replenishmentProcess.
                apiInstance.GetReplenishmentProcessTags(replenishmentProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.GetReplenishmentProcessTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentProcessId** | **int?**| Id of the replenishmentProcess to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereplenishmentprocesscustomfields"></a>
# **UpdateReplenishmentProcessCustomFields**
> void UpdateReplenishmentProcessCustomFields (ReplenishmentProcess body)

Update a replenishmentProcess custom fields

Updates an existing replenishmentProcess custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReplenishmentProcessCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentProcessApi();
            var body = new ReplenishmentProcess(); // ReplenishmentProcess | ReplenishmentProcess to be updated.

            try
            {
                // Update a replenishmentProcess custom fields
                apiInstance.UpdateReplenishmentProcessCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentProcessApi.UpdateReplenishmentProcessCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentProcess**](ReplenishmentProcess.md)| ReplenishmentProcess to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

