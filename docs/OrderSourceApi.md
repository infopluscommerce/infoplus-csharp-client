# Infoplus.Api.OrderSourceApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderSource**](OrderSourceApi.md#addordersource) | **POST** /beta/orderSource | Create an orderSource
[**AddOrderSourceAudit**](OrderSourceApi.md#addordersourceaudit) | **PUT** /beta/orderSource/{orderSourceId}/audit/{orderSourceAudit} | Add new audit for an orderSource
[**AddOrderSourceFile**](OrderSourceApi.md#addordersourcefile) | **POST** /beta/orderSource/{orderSourceId}/file/{fileName} | Attach a file to an orderSource
[**AddOrderSourceFileByURL**](OrderSourceApi.md#addordersourcefilebyurl) | **POST** /beta/orderSource/{orderSourceId}/file | Attach a file to an orderSource by URL.
[**AddOrderSourceTag**](OrderSourceApi.md#addordersourcetag) | **PUT** /beta/orderSource/{orderSourceId}/tag/{orderSourceTag} | Add new tags for an orderSource.
[**DeleteOrderSource**](OrderSourceApi.md#deleteordersource) | **DELETE** /beta/orderSource/{orderSourceId} | Delete an orderSource
[**DeleteOrderSourceFile**](OrderSourceApi.md#deleteordersourcefile) | **DELETE** /beta/orderSource/{orderSourceId}/file/{fileId} | Delete a file for an orderSource.
[**DeleteOrderSourceTag**](OrderSourceApi.md#deleteordersourcetag) | **DELETE** /beta/orderSource/{orderSourceId}/tag/{orderSourceTag} | Delete a tag for an orderSource.
[**GetDuplicateOrderSourceById**](OrderSourceApi.md#getduplicateordersourcebyid) | **GET** /beta/orderSource/duplicate/{orderSourceId} | Get a duplicated an orderSource by id
[**GetOrderSourceByFilter**](OrderSourceApi.md#getordersourcebyfilter) | **GET** /beta/orderSource/search | Search orderSources by filter
[**GetOrderSourceById**](OrderSourceApi.md#getordersourcebyid) | **GET** /beta/orderSource/{orderSourceId} | Get an orderSource by id
[**GetOrderSourceFiles**](OrderSourceApi.md#getordersourcefiles) | **GET** /beta/orderSource/{orderSourceId}/file | Get the files for an orderSource.
[**GetOrderSourceTags**](OrderSourceApi.md#getordersourcetags) | **GET** /beta/orderSource/{orderSourceId}/tag | Get the tags for an orderSource.
[**UpdateOrderSource**](OrderSourceApi.md#updateordersource) | **PUT** /beta/orderSource | Update an orderSource
[**UpdateOrderSourceCustomFields**](OrderSourceApi.md#updateordersourcecustomfields) | **PUT** /beta/orderSource/customFields | Update an orderSource custom fields


<a name="addordersource"></a>
# **AddOrderSource**
> OrderSource AddOrderSource (OrderSource body)

Create an orderSource

Inserts a new orderSource using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var body = new OrderSource(); // OrderSource | OrderSource to be inserted.

            try
            {
                // Create an orderSource
                OrderSource result = apiInstance.AddOrderSource(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.AddOrderSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSource**](OrderSource.md)| OrderSource to be inserted. | 

### Return type

[**OrderSource**](OrderSource.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourceaudit"></a>
# **AddOrderSourceAudit**
> void AddOrderSourceAudit (int? orderSourceId, string orderSourceAudit)

Add new audit for an orderSource

Adds an audit to an existing orderSource.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to add an audit to
            var orderSourceAudit = orderSourceAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderSource
                apiInstance.AddOrderSourceAudit(orderSourceId, orderSourceAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.AddOrderSourceAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to add an audit to | 
 **orderSourceAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcefile"></a>
# **AddOrderSourceFile**
> void AddOrderSourceFile (int? orderSourceId, string fileName)

Attach a file to an orderSource

Adds a file to an existing orderSource.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an orderSource
                apiInstance.AddOrderSourceFile(orderSourceId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.AddOrderSourceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcefilebyurl"></a>
# **AddOrderSourceFileByURL**
> void AddOrderSourceFileByURL (RecordFile body, int? orderSourceId)

Attach a file to an orderSource by URL.

Adds a file to an existing orderSource by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var orderSourceId = 56;  // int? | Id of the orderSource to add an file to

            try
            {
                // Attach a file to an orderSource by URL.
                apiInstance.AddOrderSourceFileByURL(body, orderSourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.AddOrderSourceFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **orderSourceId** | **int?**| Id of the orderSource to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourcetag"></a>
# **AddOrderSourceTag**
> void AddOrderSourceTag (int? orderSourceId, string orderSourceTag)

Add new tags for an orderSource.

Adds a tag to an existing orderSource.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to add a tag to
            var orderSourceTag = orderSourceTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderSource.
                apiInstance.AddOrderSourceTag(orderSourceId, orderSourceTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.AddOrderSourceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to add a tag to | 
 **orderSourceTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersource"></a>
# **DeleteOrderSource**
> void DeleteOrderSource (int? orderSourceId)

Delete an orderSource

Deletes the orderSource identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to be deleted.

            try
            {
                // Delete an orderSource
                apiInstance.DeleteOrderSource(orderSourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.DeleteOrderSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourcefile"></a>
# **DeleteOrderSourceFile**
> void DeleteOrderSourceFile (int? orderSourceId, int? fileId)

Delete a file for an orderSource.

Deletes an existing orderSource file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an orderSource.
                apiInstance.DeleteOrderSourceFile(orderSourceId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.DeleteOrderSourceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourcetag"></a>
# **DeleteOrderSourceTag**
> void DeleteOrderSourceTag (int? orderSourceId, string orderSourceTag)

Delete a tag for an orderSource.

Deletes an existing orderSource tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to remove tag from
            var orderSourceTag = orderSourceTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderSource.
                apiInstance.DeleteOrderSourceTag(orderSourceId, orderSourceTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.DeleteOrderSourceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to remove tag from | 
 **orderSourceTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateordersourcebyid"></a>
# **GetDuplicateOrderSourceById**
> OrderSource GetDuplicateOrderSourceById (int? orderSourceId)

Get a duplicated an orderSource by id

Returns a duplicated orderSource identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderSourceByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to be duplicated.

            try
            {
                // Get a duplicated an orderSource by id
                OrderSource result = apiInstance.GetDuplicateOrderSourceById(orderSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.GetDuplicateOrderSourceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to be duplicated. | 

### Return type

[**OrderSource**](OrderSource.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcebyfilter"></a>
# **GetOrderSourceByFilter**
> List<OrderSource> GetOrderSourceByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderSources by filter

Returns the list of orderSources that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderSources by filter
                List&lt;OrderSource&gt; result = apiInstance.GetOrderSourceByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.GetOrderSourceByFilter: " + e.Message );
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

[**List<OrderSource>**](OrderSource.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcebyid"></a>
# **GetOrderSourceById**
> OrderSource GetOrderSourceById (int? orderSourceId)

Get an orderSource by id

Returns the orderSource identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to be returned.

            try
            {
                // Get an orderSource by id
                OrderSource result = apiInstance.GetOrderSourceById(orderSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.GetOrderSourceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to be returned. | 

### Return type

[**OrderSource**](OrderSource.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcefiles"></a>
# **GetOrderSourceFiles**
> void GetOrderSourceFiles (int? orderSourceId)

Get the files for an orderSource.

Get all existing orderSource files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to get files for

            try
            {
                // Get the files for an orderSource.
                apiInstance.GetOrderSourceFiles(orderSourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.GetOrderSourceFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourcetags"></a>
# **GetOrderSourceTags**
> void GetOrderSourceTags (int? orderSourceId)

Get the tags for an orderSource.

Get all existing orderSource tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var orderSourceId = 56;  // int? | Id of the orderSource to get tags for

            try
            {
                // Get the tags for an orderSource.
                apiInstance.GetOrderSourceTags(orderSourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.GetOrderSourceTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceId** | **int?**| Id of the orderSource to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateordersource"></a>
# **UpdateOrderSource**
> void UpdateOrderSource (OrderSource body)

Update an orderSource

Updates an existing orderSource using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderSourceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var body = new OrderSource(); // OrderSource | OrderSource to be updated.

            try
            {
                // Update an orderSource
                apiInstance.UpdateOrderSource(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.UpdateOrderSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSource**](OrderSource.md)| OrderSource to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateordersourcecustomfields"></a>
# **UpdateOrderSourceCustomFields**
> void UpdateOrderSourceCustomFields (OrderSource body)

Update an orderSource custom fields

Updates an existing orderSource custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderSourceCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceApi();
            var body = new OrderSource(); // OrderSource | OrderSource to be updated.

            try
            {
                // Update an orderSource custom fields
                apiInstance.UpdateOrderSourceCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceApi.UpdateOrderSourceCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSource**](OrderSource.md)| OrderSource to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

