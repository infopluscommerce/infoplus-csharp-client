# Infoplus.Api.ReturnOrderApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReturnOrderAudit**](ReturnOrderApi.md#addreturnorderaudit) | **PUT** /beta/returnOrder/{returnOrderId}/audit/{returnOrderAudit} | Add new audit for a returnOrder
[**AddReturnOrderFile**](ReturnOrderApi.md#addreturnorderfile) | **POST** /beta/returnOrder/{returnOrderId}/file/{fileName} | Attach a file to a returnOrder
[**AddReturnOrderFileByURL**](ReturnOrderApi.md#addreturnorderfilebyurl) | **POST** /beta/returnOrder/{returnOrderId}/file | Attach a file to a returnOrder by URL.
[**AddReturnOrderTag**](ReturnOrderApi.md#addreturnordertag) | **PUT** /beta/returnOrder/{returnOrderId}/tag/{returnOrderTag} | Add new tags for a returnOrder.
[**DeleteReturnOrderFile**](ReturnOrderApi.md#deletereturnorderfile) | **DELETE** /beta/returnOrder/{returnOrderId}/file/{fileId} | Delete a file for a returnOrder.
[**DeleteReturnOrderTag**](ReturnOrderApi.md#deletereturnordertag) | **DELETE** /beta/returnOrder/{returnOrderId}/tag/{returnOrderTag} | Delete a tag for a returnOrder.
[**GetDuplicateReturnOrderById**](ReturnOrderApi.md#getduplicatereturnorderbyid) | **GET** /beta/returnOrder/duplicate/{returnOrderId} | Get a duplicated a returnOrder by id
[**GetReturnOrderByFilter**](ReturnOrderApi.md#getreturnorderbyfilter) | **GET** /beta/returnOrder/search | Search returnOrders by filter
[**GetReturnOrderById**](ReturnOrderApi.md#getreturnorderbyid) | **GET** /beta/returnOrder/{returnOrderId} | Get a returnOrder by id
[**GetReturnOrderFiles**](ReturnOrderApi.md#getreturnorderfiles) | **GET** /beta/returnOrder/{returnOrderId}/file | Get the files for a returnOrder.
[**GetReturnOrderTags**](ReturnOrderApi.md#getreturnordertags) | **GET** /beta/returnOrder/{returnOrderId}/tag | Get the tags for a returnOrder.
[**UpdateReturnOrder**](ReturnOrderApi.md#updatereturnorder) | **PUT** /beta/returnOrder | Update a returnOrder
[**UpdateReturnOrderCustomFields**](ReturnOrderApi.md#updatereturnordercustomfields) | **PUT** /beta/returnOrder/customFields | Update a returnOrder custom fields


<a name="addreturnorderaudit"></a>
# **AddReturnOrderAudit**
> void AddReturnOrderAudit (int? returnOrderId, string returnOrderAudit)

Add new audit for a returnOrder

Adds an audit to an existing returnOrder.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to add an audit to
            var returnOrderAudit = returnOrderAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a returnOrder
                apiInstance.AddReturnOrderAudit(returnOrderId, returnOrderAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.AddReturnOrderAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to add an audit to | 
 **returnOrderAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderfile"></a>
# **AddReturnOrderFile**
> void AddReturnOrderFile (int? returnOrderId, string fileName)

Attach a file to a returnOrder

Adds a file to an existing returnOrder.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a returnOrder
                apiInstance.AddReturnOrderFile(returnOrderId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.AddReturnOrderFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderfilebyurl"></a>
# **AddReturnOrderFileByURL**
> void AddReturnOrderFileByURL (RecordFile body, int? returnOrderId)

Attach a file to a returnOrder by URL.

Adds a file to an existing returnOrder by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var returnOrderId = 56;  // int? | Id of the returnOrder to add an file to

            try
            {
                // Attach a file to a returnOrder by URL.
                apiInstance.AddReturnOrderFileByURL(body, returnOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.AddReturnOrderFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **returnOrderId** | **int?**| Id of the returnOrder to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnordertag"></a>
# **AddReturnOrderTag**
> void AddReturnOrderTag (int? returnOrderId, string returnOrderTag)

Add new tags for a returnOrder.

Adds a tag to an existing returnOrder.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to add a tag to
            var returnOrderTag = returnOrderTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a returnOrder.
                apiInstance.AddReturnOrderTag(returnOrderId, returnOrderTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.AddReturnOrderTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to add a tag to | 
 **returnOrderTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnorderfile"></a>
# **DeleteReturnOrderFile**
> void DeleteReturnOrderFile (int? returnOrderId, int? fileId)

Delete a file for a returnOrder.

Deletes an existing returnOrder file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnOrderFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a returnOrder.
                apiInstance.DeleteReturnOrderFile(returnOrderId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.DeleteReturnOrderFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnordertag"></a>
# **DeleteReturnOrderTag**
> void DeleteReturnOrderTag (int? returnOrderId, string returnOrderTag)

Delete a tag for a returnOrder.

Deletes an existing returnOrder tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnOrderTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to remove tag from
            var returnOrderTag = returnOrderTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a returnOrder.
                apiInstance.DeleteReturnOrderTag(returnOrderId, returnOrderTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.DeleteReturnOrderTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to remove tag from | 
 **returnOrderTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereturnorderbyid"></a>
# **GetDuplicateReturnOrderById**
> ReturnOrder GetDuplicateReturnOrderById (int? returnOrderId)

Get a duplicated a returnOrder by id

Returns a duplicated returnOrder identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReturnOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to be duplicated.

            try
            {
                // Get a duplicated a returnOrder by id
                ReturnOrder result = apiInstance.GetDuplicateReturnOrderById(returnOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.GetDuplicateReturnOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to be duplicated. | 

### Return type

[**ReturnOrder**](ReturnOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderbyfilter"></a>
# **GetReturnOrderByFilter**
> List<ReturnOrder> GetReturnOrderByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search returnOrders by filter

Returns the list of returnOrders that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search returnOrders by filter
                List&lt;ReturnOrder&gt; result = apiInstance.GetReturnOrderByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.GetReturnOrderByFilter: " + e.Message );
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

[**List<ReturnOrder>**](ReturnOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderbyid"></a>
# **GetReturnOrderById**
> ReturnOrder GetReturnOrderById (int? returnOrderId)

Get a returnOrder by id

Returns the returnOrder identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to be returned.

            try
            {
                // Get a returnOrder by id
                ReturnOrder result = apiInstance.GetReturnOrderById(returnOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.GetReturnOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to be returned. | 

### Return type

[**ReturnOrder**](ReturnOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderfiles"></a>
# **GetReturnOrderFiles**
> void GetReturnOrderFiles (int? returnOrderId)

Get the files for a returnOrder.

Get all existing returnOrder files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to get files for

            try
            {
                // Get the files for a returnOrder.
                apiInstance.GetReturnOrderFiles(returnOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.GetReturnOrderFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnordertags"></a>
# **GetReturnOrderTags**
> void GetReturnOrderTags (int? returnOrderId)

Get the tags for a returnOrder.

Get all existing returnOrder tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var returnOrderId = 56;  // int? | Id of the returnOrder to get tags for

            try
            {
                // Get the tags for a returnOrder.
                apiInstance.GetReturnOrderTags(returnOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.GetReturnOrderTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderId** | **int?**| Id of the returnOrder to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereturnorder"></a>
# **UpdateReturnOrder**
> void UpdateReturnOrder (ReturnOrder body)

Update a returnOrder

Updates an existing returnOrder using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReturnOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var body = new ReturnOrder(); // ReturnOrder | ReturnOrder to be updated.

            try
            {
                // Update a returnOrder
                apiInstance.UpdateReturnOrder(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.UpdateReturnOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnOrder**](ReturnOrder.md)| ReturnOrder to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereturnordercustomfields"></a>
# **UpdateReturnOrderCustomFields**
> void UpdateReturnOrderCustomFields (ReturnOrder body)

Update a returnOrder custom fields

Updates an existing returnOrder custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReturnOrderCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderApi();
            var body = new ReturnOrder(); // ReturnOrder | ReturnOrder to be updated.

            try
            {
                // Update a returnOrder custom fields
                apiInstance.UpdateReturnOrderCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.UpdateReturnOrderCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnOrder**](ReturnOrder.md)| ReturnOrder to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

