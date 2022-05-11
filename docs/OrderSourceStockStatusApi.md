# Infoplus.Api.OrderSourceStockStatusApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderSourceStockStatusAudit**](OrderSourceStockStatusApi.md#addordersourcestockstatusaudit) | **PUT** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/audit/{orderSourceStockStatusAudit} | Add new audit for an orderSourceStockStatus
[**AddOrderSourceStockStatusFile**](OrderSourceStockStatusApi.md#addordersourcestockstatusfile) | **POST** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/file/{fileName} | Attach a file to an orderSourceStockStatus
[**AddOrderSourceStockStatusFileByURL**](OrderSourceStockStatusApi.md#addordersourcestockstatusfilebyurl) | **POST** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/file | Attach a file to an orderSourceStockStatus by URL.
[**AddOrderSourceStockStatusTag**](OrderSourceStockStatusApi.md#addordersourcestockstatustag) | **PUT** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/tag/{orderSourceStockStatusTag} | Add new tags for an orderSourceStockStatus.
[**DeleteOrderSourceStockStatusFile**](OrderSourceStockStatusApi.md#deleteordersourcestockstatusfile) | **DELETE** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/file/{fileId} | Delete a file for an orderSourceStockStatus.
[**DeleteOrderSourceStockStatusTag**](OrderSourceStockStatusApi.md#deleteordersourcestockstatustag) | **DELETE** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/tag/{orderSourceStockStatusTag} | Delete a tag for an orderSourceStockStatus.
[**GetDuplicateOrderSourceStockStatusById**](OrderSourceStockStatusApi.md#getduplicateordersourcestockstatusbyid) | **GET** /v3.0/orderSourceStockStatus/duplicate/{orderSourceStockStatusId} | Get a duplicated an orderSourceStockStatus by id
[**GetOrderSourceStockStatusByFilter**](OrderSourceStockStatusApi.md#getordersourcestockstatusbyfilter) | **GET** /v3.0/orderSourceStockStatus/search | Search orderSourceStockStatuses by filter
[**GetOrderSourceStockStatusById**](OrderSourceStockStatusApi.md#getordersourcestockstatusbyid) | **GET** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId} | Get an orderSourceStockStatus by id
[**GetOrderSourceStockStatusFiles**](OrderSourceStockStatusApi.md#getordersourcestockstatusfiles) | **GET** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/file | Get the files for an orderSourceStockStatus.
[**GetOrderSourceStockStatusTags**](OrderSourceStockStatusApi.md#getordersourcestockstatustags) | **GET** /v3.0/orderSourceStockStatus/{orderSourceStockStatusId}/tag | Get the tags for an orderSourceStockStatus.


<a name="addordersourcestockstatusaudit"></a>
# **AddOrderSourceStockStatusAudit**
> void AddOrderSourceStockStatusAudit (int? orderSourceStockStatusId, string orderSourceStockStatusAudit)

Add new audit for an orderSourceStockStatus

Adds an audit to an existing orderSourceStockStatus.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceStockStatusAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to add an audit to
            var orderSourceStockStatusAudit = orderSourceStockStatusAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderSourceStockStatus
                apiInstance.AddOrderSourceStockStatusAudit(orderSourceStockStatusId, orderSourceStockStatusAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.AddOrderSourceStockStatusAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to add an audit to | 
 **orderSourceStockStatusAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcestockstatusfile"></a>
# **AddOrderSourceStockStatusFile**
> void AddOrderSourceStockStatusFile (int? orderSourceStockStatusId, string fileName)

Attach a file to an orderSourceStockStatus

Adds a file to an existing orderSourceStockStatus.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceStockStatusFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an orderSourceStockStatus
                apiInstance.AddOrderSourceStockStatusFile(orderSourceStockStatusId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.AddOrderSourceStockStatusFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcestockstatusfilebyurl"></a>
# **AddOrderSourceStockStatusFileByURL**
> void AddOrderSourceStockStatusFileByURL (RecordFile body, int? orderSourceStockStatusId)

Attach a file to an orderSourceStockStatus by URL.

Adds a file to an existing orderSourceStockStatus by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceStockStatusFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to add an file to

            try
            {
                // Attach a file to an orderSourceStockStatus by URL.
                apiInstance.AddOrderSourceStockStatusFileByURL(body, orderSourceStockStatusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.AddOrderSourceStockStatusFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcestockstatustag"></a>
# **AddOrderSourceStockStatusTag**
> void AddOrderSourceStockStatusTag (int? orderSourceStockStatusId, string orderSourceStockStatusTag)

Add new tags for an orderSourceStockStatus.

Adds a tag to an existing orderSourceStockStatus.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceStockStatusTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to add a tag to
            var orderSourceStockStatusTag = orderSourceStockStatusTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderSourceStockStatus.
                apiInstance.AddOrderSourceStockStatusTag(orderSourceStockStatusId, orderSourceStockStatusTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.AddOrderSourceStockStatusTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to add a tag to | 
 **orderSourceStockStatusTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourcestockstatusfile"></a>
# **DeleteOrderSourceStockStatusFile**
> void DeleteOrderSourceStockStatusFile (int? orderSourceStockStatusId, int? fileId)

Delete a file for an orderSourceStockStatus.

Deletes an existing orderSourceStockStatus file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceStockStatusFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an orderSourceStockStatus.
                apiInstance.DeleteOrderSourceStockStatusFile(orderSourceStockStatusId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.DeleteOrderSourceStockStatusFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourcestockstatustag"></a>
# **DeleteOrderSourceStockStatusTag**
> void DeleteOrderSourceStockStatusTag (int? orderSourceStockStatusId, string orderSourceStockStatusTag)

Delete a tag for an orderSourceStockStatus.

Deletes an existing orderSourceStockStatus tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceStockStatusTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to remove tag from
            var orderSourceStockStatusTag = orderSourceStockStatusTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderSourceStockStatus.
                apiInstance.DeleteOrderSourceStockStatusTag(orderSourceStockStatusId, orderSourceStockStatusTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.DeleteOrderSourceStockStatusTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to remove tag from | 
 **orderSourceStockStatusTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateordersourcestockstatusbyid"></a>
# **GetDuplicateOrderSourceStockStatusById**
> OrderSourceStockStatus GetDuplicateOrderSourceStockStatusById (int? orderSourceStockStatusId)

Get a duplicated an orderSourceStockStatus by id

Returns a duplicated orderSourceStockStatus identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderSourceStockStatusByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to be duplicated.

            try
            {
                // Get a duplicated an orderSourceStockStatus by id
                OrderSourceStockStatus result = apiInstance.GetDuplicateOrderSourceStockStatusById(orderSourceStockStatusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.GetDuplicateOrderSourceStockStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to be duplicated. | 

### Return type

[**OrderSourceStockStatus**](OrderSourceStockStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcestockstatusbyfilter"></a>
# **GetOrderSourceStockStatusByFilter**
> List<OrderSourceStockStatus> GetOrderSourceStockStatusByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderSourceStockStatuses by filter

Returns the list of orderSourceStockStatuses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceStockStatusByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderSourceStockStatuses by filter
                List&lt;OrderSourceStockStatus&gt; result = apiInstance.GetOrderSourceStockStatusByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.GetOrderSourceStockStatusByFilter: " + e.Message );
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

[**List<OrderSourceStockStatus>**](OrderSourceStockStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcestockstatusbyid"></a>
# **GetOrderSourceStockStatusById**
> OrderSourceStockStatus GetOrderSourceStockStatusById (int? orderSourceStockStatusId)

Get an orderSourceStockStatus by id

Returns the orderSourceStockStatus identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceStockStatusByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to be returned.

            try
            {
                // Get an orderSourceStockStatus by id
                OrderSourceStockStatus result = apiInstance.GetOrderSourceStockStatusById(orderSourceStockStatusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.GetOrderSourceStockStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to be returned. | 

### Return type

[**OrderSourceStockStatus**](OrderSourceStockStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcestockstatusfiles"></a>
# **GetOrderSourceStockStatusFiles**
> void GetOrderSourceStockStatusFiles (int? orderSourceStockStatusId)

Get the files for an orderSourceStockStatus.

Get all existing orderSourceStockStatus files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceStockStatusFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to get files for

            try
            {
                // Get the files for an orderSourceStockStatus.
                apiInstance.GetOrderSourceStockStatusFiles(orderSourceStockStatusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.GetOrderSourceStockStatusFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcestockstatustags"></a>
# **GetOrderSourceStockStatusTags**
> void GetOrderSourceStockStatusTags (int? orderSourceStockStatusId)

Get the tags for an orderSourceStockStatus.

Get all existing orderSourceStockStatus tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceStockStatusTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceStockStatusApi();
            var orderSourceStockStatusId = 56;  // int? | Id of the orderSourceStockStatus to get tags for

            try
            {
                // Get the tags for an orderSourceStockStatus.
                apiInstance.GetOrderSourceStockStatusTags(orderSourceStockStatusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceStockStatusApi.GetOrderSourceStockStatusTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceStockStatusId** | **int?**| Id of the orderSourceStockStatus to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

