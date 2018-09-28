# Infoplus.Api.LowStockApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLowStockAudit**](LowStockApi.md#addlowstockaudit) | **PUT** /beta/lowStock/{lowStockId}/audit/{lowStockAudit} | Add new audit for a lowStock
[**AddLowStockTag**](LowStockApi.md#addlowstocktag) | **PUT** /beta/lowStock/{lowStockId}/tag/{lowStockTag} | Add new tags for a lowStock.
[**DeleteLowStockTag**](LowStockApi.md#deletelowstocktag) | **DELETE** /beta/lowStock/{lowStockId}/tag/{lowStockTag} | Delete a tag for a lowStock.
[**GetDuplicateLowStockById**](LowStockApi.md#getduplicatelowstockbyid) | **GET** /beta/lowStock/duplicate/{lowStockId} | Get a duplicated a lowStock by id
[**GetLowStockByFilter**](LowStockApi.md#getlowstockbyfilter) | **GET** /beta/lowStock/search | Search lowStocks by filter
[**GetLowStockById**](LowStockApi.md#getlowstockbyid) | **GET** /beta/lowStock/{lowStockId} | Get a lowStock by id
[**GetLowStockTags**](LowStockApi.md#getlowstocktags) | **GET** /beta/lowStock/{lowStockId}/tag | Get the tags for a lowStock.


<a name="addlowstockaudit"></a>
# **AddLowStockAudit**
> void AddLowStockAudit (int? lowStockId, string lowStockAudit)

Add new audit for a lowStock

Adds an audit to an existing lowStock.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLowStockAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var lowStockId = 56;  // int? | Id of the lowStock to add an audit to
            var lowStockAudit = lowStockAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a lowStock
                apiInstance.AddLowStockAudit(lowStockId, lowStockAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.AddLowStockAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lowStockId** | **int?**| Id of the lowStock to add an audit to | 
 **lowStockAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlowstocktag"></a>
# **AddLowStockTag**
> void AddLowStockTag (int? lowStockId, string lowStockTag)

Add new tags for a lowStock.

Adds a tag to an existing lowStock.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLowStockTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var lowStockId = 56;  // int? | Id of the lowStock to add a tag to
            var lowStockTag = lowStockTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a lowStock.
                apiInstance.AddLowStockTag(lowStockId, lowStockTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.AddLowStockTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lowStockId** | **int?**| Id of the lowStock to add a tag to | 
 **lowStockTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelowstocktag"></a>
# **DeleteLowStockTag**
> void DeleteLowStockTag (int? lowStockId, string lowStockTag)

Delete a tag for a lowStock.

Deletes an existing lowStock tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLowStockTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var lowStockId = 56;  // int? | Id of the lowStock to remove tag from
            var lowStockTag = lowStockTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a lowStock.
                apiInstance.DeleteLowStockTag(lowStockId, lowStockTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.DeleteLowStockTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lowStockId** | **int?**| Id of the lowStock to remove tag from | 
 **lowStockTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatelowstockbyid"></a>
# **GetDuplicateLowStockById**
> LowStock GetDuplicateLowStockById (int? lowStockId)

Get a duplicated a lowStock by id

Returns a duplicated lowStock identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLowStockByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var lowStockId = 56;  // int? | Id of the lowStock to be duplicated.

            try
            {
                // Get a duplicated a lowStock by id
                LowStock result = apiInstance.GetDuplicateLowStockById(lowStockId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.GetDuplicateLowStockById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lowStockId** | **int?**| Id of the lowStock to be duplicated. | 

### Return type

[**LowStock**](LowStock.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlowstockbyfilter"></a>
# **GetLowStockByFilter**
> List<LowStock> GetLowStockByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search lowStocks by filter

Returns the list of lowStocks that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLowStockByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search lowStocks by filter
                List&lt;LowStock&gt; result = apiInstance.GetLowStockByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.GetLowStockByFilter: " + e.Message );
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

[**List<LowStock>**](LowStock.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlowstockbyid"></a>
# **GetLowStockById**
> LowStock GetLowStockById (int? lowStockId)

Get a lowStock by id

Returns the lowStock identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLowStockByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var lowStockId = 56;  // int? | Id of the lowStock to be returned.

            try
            {
                // Get a lowStock by id
                LowStock result = apiInstance.GetLowStockById(lowStockId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.GetLowStockById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lowStockId** | **int?**| Id of the lowStock to be returned. | 

### Return type

[**LowStock**](LowStock.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlowstocktags"></a>
# **GetLowStockTags**
> void GetLowStockTags (int? lowStockId)

Get the tags for a lowStock.

Get all existing lowStock tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLowStockTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LowStockApi();
            var lowStockId = 56;  // int? | Id of the lowStock to get tags for

            try
            {
                // Get the tags for a lowStock.
                apiInstance.GetLowStockTags(lowStockId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowStockApi.GetLowStockTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lowStockId** | **int?**| Id of the lowStock to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

