# Infoplus.Api.OrderActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderActivity**](OrderActivityApi.md#addorderactivity) | **POST** /v3.0/orderActivity | Create an orderActivity
[**AddOrderActivityAudit**](OrderActivityApi.md#addorderactivityaudit) | **PUT** /v3.0/orderActivity/{orderActivityId}/audit/{orderActivityAudit} | Add new audit for an orderActivity
[**AddOrderActivityFile**](OrderActivityApi.md#addorderactivityfile) | **POST** /v3.0/orderActivity/{orderActivityId}/file/{fileName} | Attach a file to an orderActivity
[**AddOrderActivityFileByURL**](OrderActivityApi.md#addorderactivityfilebyurl) | **POST** /v3.0/orderActivity/{orderActivityId}/file | Attach a file to an orderActivity by URL.
[**AddOrderActivityTag**](OrderActivityApi.md#addorderactivitytag) | **PUT** /v3.0/orderActivity/{orderActivityId}/tag/{orderActivityTag} | Add new tags for an orderActivity.
[**DeleteOrderActivity**](OrderActivityApi.md#deleteorderactivity) | **DELETE** /v3.0/orderActivity/{orderActivityId} | Delete an orderActivity
[**DeleteOrderActivityFile**](OrderActivityApi.md#deleteorderactivityfile) | **DELETE** /v3.0/orderActivity/{orderActivityId}/file/{fileId} | Delete a file for an orderActivity.
[**DeleteOrderActivityTag**](OrderActivityApi.md#deleteorderactivitytag) | **DELETE** /v3.0/orderActivity/{orderActivityId}/tag/{orderActivityTag} | Delete a tag for an orderActivity.
[**GetDuplicateOrderActivityById**](OrderActivityApi.md#getduplicateorderactivitybyid) | **GET** /v3.0/orderActivity/duplicate/{orderActivityId} | Get a duplicated an orderActivity by id
[**GetOrderActivityByFilter**](OrderActivityApi.md#getorderactivitybyfilter) | **GET** /v3.0/orderActivity/search | Search orderActivitys by filter
[**GetOrderActivityById**](OrderActivityApi.md#getorderactivitybyid) | **GET** /v3.0/orderActivity/{orderActivityId} | Get an orderActivity by id
[**GetOrderActivityFiles**](OrderActivityApi.md#getorderactivityfiles) | **GET** /v3.0/orderActivity/{orderActivityId}/file | Get the files for an orderActivity.
[**GetOrderActivityTags**](OrderActivityApi.md#getorderactivitytags) | **GET** /v3.0/orderActivity/{orderActivityId}/tag | Get the tags for an orderActivity.
[**UpdateOrderActivity**](OrderActivityApi.md#updateorderactivity) | **PUT** /v3.0/orderActivity | Update an orderActivity


<a name="addorderactivity"></a>
# **AddOrderActivity**
> OrderActivity AddOrderActivity (OrderActivity body)

Create an orderActivity

Inserts a new orderActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var body = new OrderActivity(); // OrderActivity | OrderActivity to be inserted.

            try
            {
                // Create an orderActivity
                OrderActivity result = apiInstance.AddOrderActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.AddOrderActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderActivity**](OrderActivity.md)| OrderActivity to be inserted. | 

### Return type

[**OrderActivity**](OrderActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderactivityaudit"></a>
# **AddOrderActivityAudit**
> void AddOrderActivityAudit (decimal? orderActivityId, string orderActivityAudit)

Add new audit for an orderActivity

Adds an audit to an existing orderActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to add an audit to
            var orderActivityAudit = orderActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderActivity
                apiInstance.AddOrderActivityAudit(orderActivityId, orderActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.AddOrderActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to add an audit to | 
 **orderActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderactivityfile"></a>
# **AddOrderActivityFile**
> void AddOrderActivityFile (decimal? orderActivityId, string fileName)

Attach a file to an orderActivity

Adds a file to an existing orderActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an orderActivity
                apiInstance.AddOrderActivityFile(orderActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.AddOrderActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderactivityfilebyurl"></a>
# **AddOrderActivityFileByURL**
> void AddOrderActivityFileByURL (RecordFile body, decimal? orderActivityId)

Attach a file to an orderActivity by URL.

Adds a file to an existing orderActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to add an file to

            try
            {
                // Attach a file to an orderActivity by URL.
                apiInstance.AddOrderActivityFileByURL(body, orderActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.AddOrderActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **orderActivityId** | **decimal?**| Id of the orderActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderactivitytag"></a>
# **AddOrderActivityTag**
> void AddOrderActivityTag (decimal? orderActivityId, string orderActivityTag)

Add new tags for an orderActivity.

Adds a tag to an existing orderActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to add a tag to
            var orderActivityTag = orderActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderActivity.
                apiInstance.AddOrderActivityTag(orderActivityId, orderActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.AddOrderActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to add a tag to | 
 **orderActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderactivity"></a>
# **DeleteOrderActivity**
> void DeleteOrderActivity (decimal? orderActivityId)

Delete an orderActivity

Deletes the orderActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to be deleted.

            try
            {
                // Delete an orderActivity
                apiInstance.DeleteOrderActivity(orderActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.DeleteOrderActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderactivityfile"></a>
# **DeleteOrderActivityFile**
> void DeleteOrderActivityFile (decimal? orderActivityId, int? fileId)

Delete a file for an orderActivity.

Deletes an existing orderActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an orderActivity.
                apiInstance.DeleteOrderActivityFile(orderActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.DeleteOrderActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderactivitytag"></a>
# **DeleteOrderActivityTag**
> void DeleteOrderActivityTag (decimal? orderActivityId, string orderActivityTag)

Delete a tag for an orderActivity.

Deletes an existing orderActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to remove tag from
            var orderActivityTag = orderActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderActivity.
                apiInstance.DeleteOrderActivityTag(orderActivityId, orderActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.DeleteOrderActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to remove tag from | 
 **orderActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateorderactivitybyid"></a>
# **GetDuplicateOrderActivityById**
> OrderActivity GetDuplicateOrderActivityById (decimal? orderActivityId)

Get a duplicated an orderActivity by id

Returns a duplicated orderActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to be duplicated.

            try
            {
                // Get a duplicated an orderActivity by id
                OrderActivity result = apiInstance.GetDuplicateOrderActivityById(orderActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.GetDuplicateOrderActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to be duplicated. | 

### Return type

[**OrderActivity**](OrderActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderactivitybyfilter"></a>
# **GetOrderActivityByFilter**
> List<OrderActivity> GetOrderActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderActivitys by filter

Returns the list of orderActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderActivitys by filter
                List&lt;OrderActivity&gt; result = apiInstance.GetOrderActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.GetOrderActivityByFilter: " + e.Message );
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

[**List<OrderActivity>**](OrderActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderactivitybyid"></a>
# **GetOrderActivityById**
> OrderActivity GetOrderActivityById (decimal? orderActivityId)

Get an orderActivity by id

Returns the orderActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to be returned.

            try
            {
                // Get an orderActivity by id
                OrderActivity result = apiInstance.GetOrderActivityById(orderActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.GetOrderActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to be returned. | 

### Return type

[**OrderActivity**](OrderActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderactivityfiles"></a>
# **GetOrderActivityFiles**
> void GetOrderActivityFiles (decimal? orderActivityId)

Get the files for an orderActivity.

Get all existing orderActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to get files for

            try
            {
                // Get the files for an orderActivity.
                apiInstance.GetOrderActivityFiles(orderActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.GetOrderActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderactivitytags"></a>
# **GetOrderActivityTags**
> void GetOrderActivityTags (decimal? orderActivityId)

Get the tags for an orderActivity.

Get all existing orderActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var orderActivityId = 8.14;  // decimal? | Id of the orderActivity to get tags for

            try
            {
                // Get the tags for an orderActivity.
                apiInstance.GetOrderActivityTags(orderActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.GetOrderActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderActivityId** | **decimal?**| Id of the orderActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderactivity"></a>
# **UpdateOrderActivity**
> void UpdateOrderActivity (OrderActivity body)

Update an orderActivity

Updates an existing orderActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderActivityApi();
            var body = new OrderActivity(); // OrderActivity | OrderActivity to be updated.

            try
            {
                // Update an orderActivity
                apiInstance.UpdateOrderActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderActivityApi.UpdateOrderActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderActivity**](OrderActivity.md)| OrderActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

