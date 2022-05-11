# Infoplus.Api.OrderLineApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderLineAudit**](OrderLineApi.md#addorderlineaudit) | **PUT** /v3.0/orderLine/{orderLineId}/audit/{orderLineAudit} | Add new audit for an orderLine
[**AddOrderLineFile**](OrderLineApi.md#addorderlinefile) | **POST** /v3.0/orderLine/{orderLineId}/file/{fileName} | Attach a file to an orderLine
[**AddOrderLineFileByURL**](OrderLineApi.md#addorderlinefilebyurl) | **POST** /v3.0/orderLine/{orderLineId}/file | Attach a file to an orderLine by URL.
[**AddOrderLineTag**](OrderLineApi.md#addorderlinetag) | **PUT** /v3.0/orderLine/{orderLineId}/tag/{orderLineTag} | Add new tags for an orderLine.
[**DeleteOrderLineFile**](OrderLineApi.md#deleteorderlinefile) | **DELETE** /v3.0/orderLine/{orderLineId}/file/{fileId} | Delete a file for an orderLine.
[**DeleteOrderLineTag**](OrderLineApi.md#deleteorderlinetag) | **DELETE** /v3.0/orderLine/{orderLineId}/tag/{orderLineTag} | Delete a tag for an orderLine.
[**GetDuplicateOrderLineById**](OrderLineApi.md#getduplicateorderlinebyid) | **GET** /v3.0/orderLine/duplicate/{orderLineId} | Get a duplicated an orderLine by id
[**GetOrderLineByFilter**](OrderLineApi.md#getorderlinebyfilter) | **GET** /v3.0/orderLine/search | Search orderLines by filter
[**GetOrderLineById**](OrderLineApi.md#getorderlinebyid) | **GET** /v3.0/orderLine/{orderLineId} | Get an orderLine by id
[**GetOrderLineFiles**](OrderLineApi.md#getorderlinefiles) | **GET** /v3.0/orderLine/{orderLineId}/file | Get the files for an orderLine.
[**GetOrderLineTags**](OrderLineApi.md#getorderlinetags) | **GET** /v3.0/orderLine/{orderLineId}/tag | Get the tags for an orderLine.
[**UpdateOrderLineCustomFields**](OrderLineApi.md#updateorderlinecustomfields) | **PUT** /v3.0/orderLine/customFields | Update an orderLine custom fields


<a name="addorderlineaudit"></a>
# **AddOrderLineAudit**
> void AddOrderLineAudit (int? orderLineId, string orderLineAudit)

Add new audit for an orderLine

Adds an audit to an existing orderLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to add an audit to
            var orderLineAudit = orderLineAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderLine
                apiInstance.AddOrderLineAudit(orderLineId, orderLineAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.AddOrderLineAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to add an audit to | 
 **orderLineAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlinefile"></a>
# **AddOrderLineFile**
> void AddOrderLineFile (int? orderLineId, string fileName)

Attach a file to an orderLine

Adds a file to an existing orderLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an orderLine
                apiInstance.AddOrderLineFile(orderLineId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.AddOrderLineFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlinefilebyurl"></a>
# **AddOrderLineFileByURL**
> void AddOrderLineFileByURL (RecordFile body, int? orderLineId)

Attach a file to an orderLine by URL.

Adds a file to an existing orderLine by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var orderLineId = 56;  // int? | Id of the orderLine to add an file to

            try
            {
                // Attach a file to an orderLine by URL.
                apiInstance.AddOrderLineFileByURL(body, orderLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.AddOrderLineFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **orderLineId** | **int?**| Id of the orderLine to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorderlinetag"></a>
# **AddOrderLineTag**
> void AddOrderLineTag (int? orderLineId, string orderLineTag)

Add new tags for an orderLine.

Adds a tag to an existing orderLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to add a tag to
            var orderLineTag = orderLineTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderLine.
                apiInstance.AddOrderLineTag(orderLineId, orderLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.AddOrderLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to add a tag to | 
 **orderLineTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlinefile"></a>
# **DeleteOrderLineFile**
> void DeleteOrderLineFile (int? orderLineId, int? fileId)

Delete a file for an orderLine.

Deletes an existing orderLine file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an orderLine.
                apiInstance.DeleteOrderLineFile(orderLineId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.DeleteOrderLineFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderlinetag"></a>
# **DeleteOrderLineTag**
> void DeleteOrderLineTag (int? orderLineId, string orderLineTag)

Delete a tag for an orderLine.

Deletes an existing orderLine tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to remove tag from
            var orderLineTag = orderLineTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderLine.
                apiInstance.DeleteOrderLineTag(orderLineId, orderLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.DeleteOrderLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to remove tag from | 
 **orderLineTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateorderlinebyid"></a>
# **GetDuplicateOrderLineById**
> OrderLine GetDuplicateOrderLineById (int? orderLineId)

Get a duplicated an orderLine by id

Returns a duplicated orderLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to be duplicated.

            try
            {
                // Get a duplicated an orderLine by id
                OrderLine result = apiInstance.GetDuplicateOrderLineById(orderLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetDuplicateOrderLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to be duplicated. | 

### Return type

[**OrderLine**](OrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlinebyfilter"></a>
# **GetOrderLineByFilter**
> List<OrderLine> GetOrderLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderLines by filter

Returns the list of orderLines that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderLines by filter
                List&lt;OrderLine&gt; result = apiInstance.GetOrderLineByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetOrderLineByFilter: " + e.Message );
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

[**List<OrderLine>**](OrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlinebyid"></a>
# **GetOrderLineById**
> OrderLine GetOrderLineById (int? orderLineId)

Get an orderLine by id

Returns the orderLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to be returned.

            try
            {
                // Get an orderLine by id
                OrderLine result = apiInstance.GetOrderLineById(orderLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetOrderLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to be returned. | 

### Return type

[**OrderLine**](OrderLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlinefiles"></a>
# **GetOrderLineFiles**
> void GetOrderLineFiles (int? orderLineId)

Get the files for an orderLine.

Get all existing orderLine files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to get files for

            try
            {
                // Get the files for an orderLine.
                apiInstance.GetOrderLineFiles(orderLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetOrderLineFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlinetags"></a>
# **GetOrderLineTags**
> void GetOrderLineTags (int? orderLineId)

Get the tags for an orderLine.

Get all existing orderLine tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderLineTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var orderLineId = 56;  // int? | Id of the orderLine to get tags for

            try
            {
                // Get the tags for an orderLine.
                apiInstance.GetOrderLineTags(orderLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.GetOrderLineTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineId** | **int?**| Id of the orderLine to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderlinecustomfields"></a>
# **UpdateOrderLineCustomFields**
> void UpdateOrderLineCustomFields (OrderLine body)

Update an orderLine custom fields

Updates an existing orderLine custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderLineCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderLineApi();
            var body = new OrderLine(); // OrderLine | OrderLine to be updated.

            try
            {
                // Update an orderLine custom fields
                apiInstance.UpdateOrderLineCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderLineApi.UpdateOrderLineCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderLine**](OrderLine.md)| OrderLine to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

