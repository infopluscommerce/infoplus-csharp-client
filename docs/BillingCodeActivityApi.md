# Infoplus.Api.BillingCodeActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillingCodeActivity**](BillingCodeActivityApi.md#addbillingcodeactivity) | **POST** /beta/billingCodeActivity | Create a billingCodeActivity
[**AddBillingCodeActivityAudit**](BillingCodeActivityApi.md#addbillingcodeactivityaudit) | **PUT** /beta/billingCodeActivity/{billingCodeActivityId}/audit/{billingCodeActivityAudit} | Add new audit for a billingCodeActivity
[**AddBillingCodeActivityFile**](BillingCodeActivityApi.md#addbillingcodeactivityfile) | **POST** /beta/billingCodeActivity/{billingCodeActivityId}/file/{fileName} | Attach a file to a billingCodeActivity
[**AddBillingCodeActivityFileByURL**](BillingCodeActivityApi.md#addbillingcodeactivityfilebyurl) | **POST** /beta/billingCodeActivity/{billingCodeActivityId}/file | Attach a file to a billingCodeActivity by URL.
[**AddBillingCodeActivityTag**](BillingCodeActivityApi.md#addbillingcodeactivitytag) | **PUT** /beta/billingCodeActivity/{billingCodeActivityId}/tag/{billingCodeActivityTag} | Add new tags for a billingCodeActivity.
[**DeleteBillingCodeActivity**](BillingCodeActivityApi.md#deletebillingcodeactivity) | **DELETE** /beta/billingCodeActivity/{billingCodeActivityId} | Delete a billingCodeActivity
[**DeleteBillingCodeActivityFile**](BillingCodeActivityApi.md#deletebillingcodeactivityfile) | **DELETE** /beta/billingCodeActivity/{billingCodeActivityId}/file/{fileId} | Delete a file for a billingCodeActivity.
[**DeleteBillingCodeActivityTag**](BillingCodeActivityApi.md#deletebillingcodeactivitytag) | **DELETE** /beta/billingCodeActivity/{billingCodeActivityId}/tag/{billingCodeActivityTag} | Delete a tag for a billingCodeActivity.
[**GetBillingCodeActivityByFilter**](BillingCodeActivityApi.md#getbillingcodeactivitybyfilter) | **GET** /beta/billingCodeActivity/search | Search billingCodeActivitys by filter
[**GetBillingCodeActivityById**](BillingCodeActivityApi.md#getbillingcodeactivitybyid) | **GET** /beta/billingCodeActivity/{billingCodeActivityId} | Get a billingCodeActivity by id
[**GetBillingCodeActivityFiles**](BillingCodeActivityApi.md#getbillingcodeactivityfiles) | **GET** /beta/billingCodeActivity/{billingCodeActivityId}/file | Get the files for a billingCodeActivity.
[**GetBillingCodeActivityTags**](BillingCodeActivityApi.md#getbillingcodeactivitytags) | **GET** /beta/billingCodeActivity/{billingCodeActivityId}/tag | Get the tags for a billingCodeActivity.
[**GetDuplicateBillingCodeActivityById**](BillingCodeActivityApi.md#getduplicatebillingcodeactivitybyid) | **GET** /beta/billingCodeActivity/duplicate/{billingCodeActivityId} | Get a duplicated a billingCodeActivity by id
[**UpdateBillingCodeActivity**](BillingCodeActivityApi.md#updatebillingcodeactivity) | **PUT** /beta/billingCodeActivity | Update a billingCodeActivity


<a name="addbillingcodeactivity"></a>
# **AddBillingCodeActivity**
> BillingCodeActivity AddBillingCodeActivity (BillingCodeActivity body)

Create a billingCodeActivity

Inserts a new billingCodeActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var body = new BillingCodeActivity(); // BillingCodeActivity | BillingCodeActivity to be inserted.

            try
            {
                // Create a billingCodeActivity
                BillingCodeActivity result = apiInstance.AddBillingCodeActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.AddBillingCodeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeActivity**](BillingCodeActivity.md)| BillingCodeActivity to be inserted. | 

### Return type

[**BillingCodeActivity**](BillingCodeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodeactivityaudit"></a>
# **AddBillingCodeActivityAudit**
> void AddBillingCodeActivityAudit (int? billingCodeActivityId, string billingCodeActivityAudit)

Add new audit for a billingCodeActivity

Adds an audit to an existing billingCodeActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to add an audit to
            var billingCodeActivityAudit = billingCodeActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a billingCodeActivity
                apiInstance.AddBillingCodeActivityAudit(billingCodeActivityId, billingCodeActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.AddBillingCodeActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to add an audit to | 
 **billingCodeActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodeactivityfile"></a>
# **AddBillingCodeActivityFile**
> void AddBillingCodeActivityFile (int? billingCodeActivityId, string fileName)

Attach a file to a billingCodeActivity

Adds a file to an existing billingCodeActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a billingCodeActivity
                apiInstance.AddBillingCodeActivityFile(billingCodeActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.AddBillingCodeActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodeactivityfilebyurl"></a>
# **AddBillingCodeActivityFileByURL**
> void AddBillingCodeActivityFileByURL (RecordFile body, int? billingCodeActivityId)

Attach a file to a billingCodeActivity by URL.

Adds a file to an existing billingCodeActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to add an file to

            try
            {
                // Attach a file to a billingCodeActivity by URL.
                apiInstance.AddBillingCodeActivityFileByURL(body, billingCodeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.AddBillingCodeActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodeactivitytag"></a>
# **AddBillingCodeActivityTag**
> void AddBillingCodeActivityTag (int? billingCodeActivityId, string billingCodeActivityTag)

Add new tags for a billingCodeActivity.

Adds a tag to an existing billingCodeActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to add a tag to
            var billingCodeActivityTag = billingCodeActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a billingCodeActivity.
                apiInstance.AddBillingCodeActivityTag(billingCodeActivityId, billingCodeActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.AddBillingCodeActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to add a tag to | 
 **billingCodeActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodeactivity"></a>
# **DeleteBillingCodeActivity**
> void DeleteBillingCodeActivity (int? billingCodeActivityId)

Delete a billingCodeActivity

Deletes the billingCodeActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to be deleted.

            try
            {
                // Delete a billingCodeActivity
                apiInstance.DeleteBillingCodeActivity(billingCodeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.DeleteBillingCodeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodeactivityfile"></a>
# **DeleteBillingCodeActivityFile**
> void DeleteBillingCodeActivityFile (int? billingCodeActivityId, int? fileId)

Delete a file for a billingCodeActivity.

Deletes an existing billingCodeActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a billingCodeActivity.
                apiInstance.DeleteBillingCodeActivityFile(billingCodeActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.DeleteBillingCodeActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodeactivitytag"></a>
# **DeleteBillingCodeActivityTag**
> void DeleteBillingCodeActivityTag (int? billingCodeActivityId, string billingCodeActivityTag)

Delete a tag for a billingCodeActivity.

Deletes an existing billingCodeActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to remove tag from
            var billingCodeActivityTag = billingCodeActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a billingCodeActivity.
                apiInstance.DeleteBillingCodeActivityTag(billingCodeActivityId, billingCodeActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.DeleteBillingCodeActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to remove tag from | 
 **billingCodeActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodeactivitybyfilter"></a>
# **GetBillingCodeActivityByFilter**
> List<BillingCodeActivity> GetBillingCodeActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billingCodeActivitys by filter

Returns the list of billingCodeActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billingCodeActivitys by filter
                List&lt;BillingCodeActivity&gt; result = apiInstance.GetBillingCodeActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.GetBillingCodeActivityByFilter: " + e.Message );
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

[**List<BillingCodeActivity>**](BillingCodeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodeactivitybyid"></a>
# **GetBillingCodeActivityById**
> BillingCodeActivity GetBillingCodeActivityById (int? billingCodeActivityId)

Get a billingCodeActivity by id

Returns the billingCodeActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to be returned.

            try
            {
                // Get a billingCodeActivity by id
                BillingCodeActivity result = apiInstance.GetBillingCodeActivityById(billingCodeActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.GetBillingCodeActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to be returned. | 

### Return type

[**BillingCodeActivity**](BillingCodeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodeactivityfiles"></a>
# **GetBillingCodeActivityFiles**
> void GetBillingCodeActivityFiles (int? billingCodeActivityId)

Get the files for a billingCodeActivity.

Get all existing billingCodeActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to get files for

            try
            {
                // Get the files for a billingCodeActivity.
                apiInstance.GetBillingCodeActivityFiles(billingCodeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.GetBillingCodeActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodeactivitytags"></a>
# **GetBillingCodeActivityTags**
> void GetBillingCodeActivityTags (int? billingCodeActivityId)

Get the tags for a billingCodeActivity.

Get all existing billingCodeActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to get tags for

            try
            {
                // Get the tags for a billingCodeActivity.
                apiInstance.GetBillingCodeActivityTags(billingCodeActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.GetBillingCodeActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatebillingcodeactivitybyid"></a>
# **GetDuplicateBillingCodeActivityById**
> BillingCodeActivity GetDuplicateBillingCodeActivityById (int? billingCodeActivityId)

Get a duplicated a billingCodeActivity by id

Returns a duplicated billingCodeActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateBillingCodeActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var billingCodeActivityId = 56;  // int? | Id of the billingCodeActivity to be duplicated.

            try
            {
                // Get a duplicated a billingCodeActivity by id
                BillingCodeActivity result = apiInstance.GetDuplicateBillingCodeActivityById(billingCodeActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.GetDuplicateBillingCodeActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeActivityId** | **int?**| Id of the billingCodeActivity to be duplicated. | 

### Return type

[**BillingCodeActivity**](BillingCodeActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcodeactivity"></a>
# **UpdateBillingCodeActivity**
> void UpdateBillingCodeActivity (BillingCodeActivity body)

Update a billingCodeActivity

Updates an existing billingCodeActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeActivityApi();
            var body = new BillingCodeActivity(); // BillingCodeActivity | BillingCodeActivity to be updated.

            try
            {
                // Update a billingCodeActivity
                apiInstance.UpdateBillingCodeActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeActivityApi.UpdateBillingCodeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeActivity**](BillingCodeActivity.md)| BillingCodeActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

