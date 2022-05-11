# Infoplus.Api.OrderLineActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderLineActivity**](OrderLineActivityApi.md#addorderlineactivity) | **POST** /v3.0/orderLineActivity | Create an orderLineActivity
[**AddOrderLineActivityAudit**](OrderLineActivityApi.md#addorderlineactivityaudit) | **PUT** /v3.0/orderLineActivity/{orderLineActivityId}/audit/{orderLineActivityAudit} | Add new audit for an orderLineActivity
[**AddOrderLineActivityFile**](OrderLineActivityApi.md#addorderlineactivityfile) | **POST** /v3.0/orderLineActivity/{orderLineActivityId}/file/{fileName} | Attach a file to an orderLineActivity
[**AddOrderLineActivityFileByURL**](OrderLineActivityApi.md#addorderlineactivityfilebyurl) | **POST** /v3.0/orderLineActivity/{orderLineActivityId}/file | Attach a file to an orderLineActivity by URL.
[**AddOrderLineActivityTag**](OrderLineActivityApi.md#addorderlineactivitytag) | **PUT** /v3.0/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag} | Add new tags for an orderLineActivity.
[**DeleteOrderLineActivity**](OrderLineActivityApi.md#deleteorderlineactivity) | **DELETE** /v3.0/orderLineActivity/{orderLineActivityId} | Delete an orderLineActivity
[**DeleteOrderLineActivityFile**](OrderLineActivityApi.md#deleteorderlineactivityfile) | **DELETE** /v3.0/orderLineActivity/{orderLineActivityId}/file/{fileId} | Delete a file for an orderLineActivity.
[**DeleteOrderLineActivityTag**](OrderLineActivityApi.md#deleteorderlineactivitytag) | **DELETE** /v3.0/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag} | Delete a tag for an orderLineActivity.
[**GetDuplicateOrderLineActivityById**](OrderLineActivityApi.md#getduplicateorderlineactivitybyid) | **GET** /v3.0/orderLineActivity/duplicate/{orderLineActivityId} | Get a duplicated an orderLineActivity by id
[**GetOrderLineActivityByFilter**](OrderLineActivityApi.md#getorderlineactivitybyfilter) | **GET** /v3.0/orderLineActivity/search | Search orderLineActivitys by filter
[**GetOrderLineActivityById**](OrderLineActivityApi.md#getorderlineactivitybyid) | **GET** /v3.0/orderLineActivity/{orderLineActivityId} | Get an orderLineActivity by id
[**GetOrderLineActivityFiles**](OrderLineActivityApi.md#getorderlineactivityfiles) | **GET** /v3.0/orderLineActivity/{orderLineActivityId}/file | Get the files for an orderLineActivity.
[**GetOrderLineActivityTags**](OrderLineActivityApi.md#getorderlineactivitytags) | **GET** /v3.0/orderLineActivity/{orderLineActivityId}/tag | Get the tags for an orderLineActivity.
[**UpdateOrderLineActivity**](OrderLineActivityApi.md#updateorderlineactivity) | **PUT** /v3.0/orderLineActivity | Update an orderLineActivity


<a name="addorderlineactivity"></a>
# **AddOrderLineActivity**
> OrderLineActivity AddOrderLineActivity (OrderLineActivity body)

Create an orderLineActivity

Inserts a new orderLineActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var body = new OrderLineActivity(); // OrderLineActivity | OrderLineActivity to be inserted.

            try
            {
                // Create an orderLineActivity
                OrderLineActivity result = apiInstance.AddOrderLineActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderLineActivity**](OrderLineActivity.md)| OrderLineActivity to be inserted. | 

### Return type

[**OrderLineActivity**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlineactivityaudit"></a>
# **AddOrderLineActivityAudit**
> void AddOrderLineActivityAudit (int? orderLineActivityId, string orderLineActivityAudit)

Add new audit for an orderLineActivity

Adds an audit to an existing orderLineActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to add an audit to
            var orderLineActivityAudit = orderLineActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderLineActivity
                apiInstance.AddOrderLineActivityAudit(orderLineActivityId, orderLineActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to add an audit to | 
 **orderLineActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlineactivityfile"></a>
# **AddOrderLineActivityFile**
> void AddOrderLineActivityFile (int? orderLineActivityId, string fileName)

Attach a file to an orderLineActivity

Adds a file to an existing orderLineActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an orderLineActivity
                apiInstance.AddOrderLineActivityFile(orderLineActivityId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlineactivityfilebyurl"></a>
# **AddOrderLineActivityFileByURL**
> void AddOrderLineActivityFileByURL (RecordFile body, int? orderLineActivityId)

Attach a file to an orderLineActivity by URL.

Adds a file to an existing orderLineActivity by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to add an file to

            try
            {
                // Attach a file to an orderLineActivity by URL.
                apiInstance.AddOrderLineActivityFileByURL(body, orderLineActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivityFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlineactivitytag"></a>
# **AddOrderLineActivityTag**
> void AddOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag)

Add new tags for an orderLineActivity.

Adds a tag to an existing orderLineActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to add a tag to
            var orderLineActivityTag = orderLineActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderLineActivity.
                apiInstance.AddOrderLineActivityTag(orderLineActivityId, orderLineActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.AddOrderLineActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to add a tag to | 
 **orderLineActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlineactivity"></a>
# **DeleteOrderLineActivity**
> void DeleteOrderLineActivity (int? orderLineActivityId)

Delete an orderLineActivity

Deletes the orderLineActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to be deleted.

            try
            {
                // Delete an orderLineActivity
                apiInstance.DeleteOrderLineActivity(orderLineActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.DeleteOrderLineActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlineactivityfile"></a>
# **DeleteOrderLineActivityFile**
> void DeleteOrderLineActivityFile (int? orderLineActivityId, int? fileId)

Delete a file for an orderLineActivity.

Deletes an existing orderLineActivity file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineActivityFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an orderLineActivity.
                apiInstance.DeleteOrderLineActivityFile(orderLineActivityId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.DeleteOrderLineActivityFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlineactivitytag"></a>
# **DeleteOrderLineActivityTag**
> void DeleteOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag)

Delete a tag for an orderLineActivity.

Deletes an existing orderLineActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to remove tag from
            var orderLineActivityTag = orderLineActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderLineActivity.
                apiInstance.DeleteOrderLineActivityTag(orderLineActivityId, orderLineActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.DeleteOrderLineActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to remove tag from | 
 **orderLineActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateorderlineactivitybyid"></a>
# **GetDuplicateOrderLineActivityById**
> OrderLineActivity GetDuplicateOrderLineActivityById (int? orderLineActivityId)

Get a duplicated an orderLineActivity by id

Returns a duplicated orderLineActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderLineActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to be duplicated.

            try
            {
                // Get a duplicated an orderLineActivity by id
                OrderLineActivity result = apiInstance.GetDuplicateOrderLineActivityById(orderLineActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetDuplicateOrderLineActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to be duplicated. | 

### Return type

[**OrderLineActivity**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivitybyfilter"></a>
# **GetOrderLineActivityByFilter**
> List<OrderLineActivity> GetOrderLineActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderLineActivitys by filter

Returns the list of orderLineActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderLineActivitys by filter
                List&lt;OrderLineActivity&gt; result = apiInstance.GetOrderLineActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityByFilter: " + e.Message );
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

[**List<OrderLineActivity>**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivitybyid"></a>
# **GetOrderLineActivityById**
> OrderLineActivity GetOrderLineActivityById (int? orderLineActivityId)

Get an orderLineActivity by id

Returns the orderLineActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to be returned.

            try
            {
                // Get an orderLineActivity by id
                OrderLineActivity result = apiInstance.GetOrderLineActivityById(orderLineActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to be returned. | 

### Return type

[**OrderLineActivity**](OrderLineActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivityfiles"></a>
# **GetOrderLineActivityFiles**
> void GetOrderLineActivityFiles (int? orderLineActivityId)

Get the files for an orderLineActivity.

Get all existing orderLineActivity files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to get files for

            try
            {
                // Get the files for an orderLineActivity.
                apiInstance.GetOrderLineActivityFiles(orderLineActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlineactivitytags"></a>
# **GetOrderLineActivityTags**
> void GetOrderLineActivityTags (int? orderLineActivityId)

Get the tags for an orderLineActivity.

Get all existing orderLineActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var orderLineActivityId = 56;  // int? | Id of the orderLineActivity to get tags for

            try
            {
                // Get the tags for an orderLineActivity.
                apiInstance.GetOrderLineActivityTags(orderLineActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.GetOrderLineActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineActivityId** | **int?**| Id of the orderLineActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderlineactivity"></a>
# **UpdateOrderLineActivity**
> void UpdateOrderLineActivity (OrderLineActivity body)

Update an orderLineActivity

Updates an existing orderLineActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderLineActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineActivityApi();
            var body = new OrderLineActivity(); // OrderLineActivity | OrderLineActivity to be updated.

            try
            {
                // Update an orderLineActivity
                apiInstance.UpdateOrderLineActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineActivityApi.UpdateOrderLineActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderLineActivity**](OrderLineActivity.md)| OrderLineActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

