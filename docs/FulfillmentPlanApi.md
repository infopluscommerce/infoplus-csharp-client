# Infoplus.Api.FulfillmentPlanApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFulfillmentPlan**](FulfillmentPlanApi.md#addfulfillmentplan) | **POST** /beta/fulfillmentPlan | Create a fulfillmentPlan
[**AddFulfillmentPlanAudit**](FulfillmentPlanApi.md#addfulfillmentplanaudit) | **PUT** /beta/fulfillmentPlan/{fulfillmentPlanId}/audit/{fulfillmentPlanAudit} | Add new audit for a fulfillmentPlan
[**AddFulfillmentPlanFile**](FulfillmentPlanApi.md#addfulfillmentplanfile) | **POST** /beta/fulfillmentPlan/{fulfillmentPlanId}/file/{fileName} | Attach a file to a fulfillmentPlan
[**AddFulfillmentPlanFileByURL**](FulfillmentPlanApi.md#addfulfillmentplanfilebyurl) | **POST** /beta/fulfillmentPlan/{fulfillmentPlanId}/file | Attach a file to a fulfillmentPlan by URL.
[**AddFulfillmentPlanTag**](FulfillmentPlanApi.md#addfulfillmentplantag) | **PUT** /beta/fulfillmentPlan/{fulfillmentPlanId}/tag/{fulfillmentPlanTag} | Add new tags for a fulfillmentPlan.
[**DeleteFulfillmentPlan**](FulfillmentPlanApi.md#deletefulfillmentplan) | **DELETE** /beta/fulfillmentPlan/{fulfillmentPlanId} | Delete a fulfillmentPlan
[**DeleteFulfillmentPlanFile**](FulfillmentPlanApi.md#deletefulfillmentplanfile) | **DELETE** /beta/fulfillmentPlan/{fulfillmentPlanId}/file/{fileId} | Delete a file for a fulfillmentPlan.
[**DeleteFulfillmentPlanTag**](FulfillmentPlanApi.md#deletefulfillmentplantag) | **DELETE** /beta/fulfillmentPlan/{fulfillmentPlanId}/tag/{fulfillmentPlanTag} | Delete a tag for a fulfillmentPlan.
[**GetDuplicateFulfillmentPlanById**](FulfillmentPlanApi.md#getduplicatefulfillmentplanbyid) | **GET** /beta/fulfillmentPlan/duplicate/{fulfillmentPlanId} | Get a duplicated a fulfillmentPlan by id
[**GetFulfillmentPlanByFilter**](FulfillmentPlanApi.md#getfulfillmentplanbyfilter) | **GET** /beta/fulfillmentPlan/search | Search fulfillmentPlans by filter
[**GetFulfillmentPlanById**](FulfillmentPlanApi.md#getfulfillmentplanbyid) | **GET** /beta/fulfillmentPlan/{fulfillmentPlanId} | Get a fulfillmentPlan by id
[**GetFulfillmentPlanFiles**](FulfillmentPlanApi.md#getfulfillmentplanfiles) | **GET** /beta/fulfillmentPlan/{fulfillmentPlanId}/file | Get the files for a fulfillmentPlan.
[**GetFulfillmentPlanTags**](FulfillmentPlanApi.md#getfulfillmentplantags) | **GET** /beta/fulfillmentPlan/{fulfillmentPlanId}/tag | Get the tags for a fulfillmentPlan.
[**UpdateFulfillmentPlan**](FulfillmentPlanApi.md#updatefulfillmentplan) | **PUT** /beta/fulfillmentPlan | Update a fulfillmentPlan
[**UpdateFulfillmentPlanCustomFields**](FulfillmentPlanApi.md#updatefulfillmentplancustomfields) | **PUT** /beta/fulfillmentPlan/customFields | Update a fulfillmentPlan custom fields


<a name="addfulfillmentplan"></a>
# **AddFulfillmentPlan**
> FulfillmentPlan AddFulfillmentPlan (FulfillmentPlan body)

Create a fulfillmentPlan

Inserts a new fulfillmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new FulfillmentPlan(); // FulfillmentPlan | FulfillmentPlan to be inserted.

            try
            {
                // Create a fulfillmentPlan
                FulfillmentPlan result = apiInstance.AddFulfillmentPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.AddFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentPlan**](FulfillmentPlan.md)| FulfillmentPlan to be inserted. | 

### Return type

[**FulfillmentPlan**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentplanaudit"></a>
# **AddFulfillmentPlanAudit**
> void AddFulfillmentPlanAudit (int? fulfillmentPlanId, string fulfillmentPlanAudit)

Add new audit for a fulfillmentPlan

Adds an audit to an existing fulfillmentPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentPlanAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to add an audit to
            var fulfillmentPlanAudit = fulfillmentPlanAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a fulfillmentPlan
                apiInstance.AddFulfillmentPlanAudit(fulfillmentPlanId, fulfillmentPlanAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.AddFulfillmentPlanAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to add an audit to | 
 **fulfillmentPlanAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentplanfile"></a>
# **AddFulfillmentPlanFile**
> void AddFulfillmentPlanFile (int? fulfillmentPlanId, string fileName)

Attach a file to a fulfillmentPlan

Adds a file to an existing fulfillmentPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentPlanFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a fulfillmentPlan
                apiInstance.AddFulfillmentPlanFile(fulfillmentPlanId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.AddFulfillmentPlanFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentplanfilebyurl"></a>
# **AddFulfillmentPlanFileByURL**
> void AddFulfillmentPlanFileByURL (RecordFile body, int? fulfillmentPlanId)

Attach a file to a fulfillmentPlan by URL.

Adds a file to an existing fulfillmentPlan by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentPlanFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to add an file to

            try
            {
                // Attach a file to a fulfillmentPlan by URL.
                apiInstance.AddFulfillmentPlanFileByURL(body, fulfillmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.AddFulfillmentPlanFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfulfillmentplantag"></a>
# **AddFulfillmentPlanTag**
> void AddFulfillmentPlanTag (int? fulfillmentPlanId, string fulfillmentPlanTag)

Add new tags for a fulfillmentPlan.

Adds a tag to an existing fulfillmentPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFulfillmentPlanTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to add a tag to
            var fulfillmentPlanTag = fulfillmentPlanTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a fulfillmentPlan.
                apiInstance.AddFulfillmentPlanTag(fulfillmentPlanId, fulfillmentPlanTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.AddFulfillmentPlanTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to add a tag to | 
 **fulfillmentPlanTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentplan"></a>
# **DeleteFulfillmentPlan**
> void DeleteFulfillmentPlan (int? fulfillmentPlanId)

Delete a fulfillmentPlan

Deletes the fulfillmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to be deleted.

            try
            {
                // Delete a fulfillmentPlan
                apiInstance.DeleteFulfillmentPlan(fulfillmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.DeleteFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentplanfile"></a>
# **DeleteFulfillmentPlanFile**
> void DeleteFulfillmentPlanFile (int? fulfillmentPlanId, int? fileId)

Delete a file for a fulfillmentPlan.

Deletes an existing fulfillmentPlan file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentPlanFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a fulfillmentPlan.
                apiInstance.DeleteFulfillmentPlanFile(fulfillmentPlanId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.DeleteFulfillmentPlanFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefulfillmentplantag"></a>
# **DeleteFulfillmentPlanTag**
> void DeleteFulfillmentPlanTag (int? fulfillmentPlanId, string fulfillmentPlanTag)

Delete a tag for a fulfillmentPlan.

Deletes an existing fulfillmentPlan tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFulfillmentPlanTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to remove tag from
            var fulfillmentPlanTag = fulfillmentPlanTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a fulfillmentPlan.
                apiInstance.DeleteFulfillmentPlanTag(fulfillmentPlanId, fulfillmentPlanTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.DeleteFulfillmentPlanTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to remove tag from | 
 **fulfillmentPlanTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatefulfillmentplanbyid"></a>
# **GetDuplicateFulfillmentPlanById**
> FulfillmentPlan GetDuplicateFulfillmentPlanById (int? fulfillmentPlanId)

Get a duplicated a fulfillmentPlan by id

Returns a duplicated fulfillmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateFulfillmentPlanByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to be duplicated.

            try
            {
                // Get a duplicated a fulfillmentPlan by id
                FulfillmentPlan result = apiInstance.GetDuplicateFulfillmentPlanById(fulfillmentPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetDuplicateFulfillmentPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to be duplicated. | 

### Return type

[**FulfillmentPlan**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentplanbyfilter"></a>
# **GetFulfillmentPlanByFilter**
> List<FulfillmentPlan> GetFulfillmentPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search fulfillmentPlans by filter

Returns the list of fulfillmentPlans that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentPlanByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search fulfillmentPlans by filter
                List&lt;FulfillmentPlan&gt; result = apiInstance.GetFulfillmentPlanByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetFulfillmentPlanByFilter: " + e.Message );
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

[**List<FulfillmentPlan>**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentplanbyid"></a>
# **GetFulfillmentPlanById**
> FulfillmentPlan GetFulfillmentPlanById (int? fulfillmentPlanId)

Get a fulfillmentPlan by id

Returns the fulfillmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentPlanByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to be returned.

            try
            {
                // Get a fulfillmentPlan by id
                FulfillmentPlan result = apiInstance.GetFulfillmentPlanById(fulfillmentPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetFulfillmentPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to be returned. | 

### Return type

[**FulfillmentPlan**](FulfillmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentplanfiles"></a>
# **GetFulfillmentPlanFiles**
> void GetFulfillmentPlanFiles (int? fulfillmentPlanId)

Get the files for a fulfillmentPlan.

Get all existing fulfillmentPlan files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentPlanFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to get files for

            try
            {
                // Get the files for a fulfillmentPlan.
                apiInstance.GetFulfillmentPlanFiles(fulfillmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetFulfillmentPlanFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentplantags"></a>
# **GetFulfillmentPlanTags**
> void GetFulfillmentPlanTags (int? fulfillmentPlanId)

Get the tags for a fulfillmentPlan.

Get all existing fulfillmentPlan tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFulfillmentPlanTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var fulfillmentPlanId = 56;  // int? | Id of the fulfillmentPlan to get tags for

            try
            {
                // Get the tags for a fulfillmentPlan.
                apiInstance.GetFulfillmentPlanTags(fulfillmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.GetFulfillmentPlanTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentPlanId** | **int?**| Id of the fulfillmentPlan to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentplan"></a>
# **UpdateFulfillmentPlan**
> void UpdateFulfillmentPlan (FulfillmentPlan body)

Update a fulfillmentPlan

Updates an existing fulfillmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFulfillmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new FulfillmentPlan(); // FulfillmentPlan | FulfillmentPlan to be updated.

            try
            {
                // Update a fulfillmentPlan
                apiInstance.UpdateFulfillmentPlan(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.UpdateFulfillmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentPlan**](FulfillmentPlan.md)| FulfillmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefulfillmentplancustomfields"></a>
# **UpdateFulfillmentPlanCustomFields**
> void UpdateFulfillmentPlanCustomFields (FulfillmentPlan body)

Update a fulfillmentPlan custom fields

Updates an existing fulfillmentPlan custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFulfillmentPlanCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FulfillmentPlanApi();
            var body = new FulfillmentPlan(); // FulfillmentPlan | FulfillmentPlan to be updated.

            try
            {
                // Update a fulfillmentPlan custom fields
                apiInstance.UpdateFulfillmentPlanCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FulfillmentPlanApi.UpdateFulfillmentPlanCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FulfillmentPlan**](FulfillmentPlan.md)| FulfillmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

