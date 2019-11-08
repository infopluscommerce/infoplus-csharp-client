# Infoplus.Api.OmsOrderApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOmsOrder**](OmsOrderApi.md#addomsorder) | **POST** /beta/omsOrder | Create an omsOrder
[**AddOmsOrderAudit**](OmsOrderApi.md#addomsorderaudit) | **PUT** /beta/omsOrder/{omsOrderId}/audit/{omsOrderAudit} | Add new audit for an omsOrder
[**AddOmsOrderFile**](OmsOrderApi.md#addomsorderfile) | **POST** /beta/omsOrder/{omsOrderId}/file/{fileName} | Attach a file to an omsOrder
[**AddOmsOrderTag**](OmsOrderApi.md#addomsordertag) | **PUT** /beta/omsOrder/{omsOrderId}/tag/{omsOrderTag} | Add new tags for an omsOrder.
[**DeleteOmsOrderTag**](OmsOrderApi.md#deleteomsordertag) | **DELETE** /beta/omsOrder/{omsOrderId}/tag/{omsOrderTag} | Delete a tag for an omsOrder.
[**GetDuplicateOmsOrderById**](OmsOrderApi.md#getduplicateomsorderbyid) | **GET** /beta/omsOrder/duplicate/{omsOrderId} | Get a duplicated an omsOrder by id
[**GetOmsOrderByFilter**](OmsOrderApi.md#getomsorderbyfilter) | **GET** /beta/omsOrder/search | Search omsOrders by filter
[**GetOmsOrderById**](OmsOrderApi.md#getomsorderbyid) | **GET** /beta/omsOrder/{omsOrderId} | Get an omsOrder by id
[**GetOmsOrderTags**](OmsOrderApi.md#getomsordertags) | **GET** /beta/omsOrder/{omsOrderId}/tag | Get the tags for an omsOrder.
[**UpdateOmsOrder**](OmsOrderApi.md#updateomsorder) | **PUT** /beta/omsOrder | Update an omsOrder
[**UpdateOmsOrderCustomFields**](OmsOrderApi.md#updateomsordercustomfields) | **PUT** /beta/omsOrder/customFields | Update an omsOrder custom fields


<a name="addomsorder"></a>
# **AddOmsOrder**
> OmsOrder AddOmsOrder (OmsOrder body)

Create an omsOrder

Inserts a new omsOrder using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOmsOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var body = new OmsOrder(); // OmsOrder | OmsOrder to be inserted.

            try
            {
                // Create an omsOrder
                OmsOrder result = apiInstance.AddOmsOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.AddOmsOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OmsOrder**](OmsOrder.md)| OmsOrder to be inserted. | 

### Return type

[**OmsOrder**](OmsOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addomsorderaudit"></a>
# **AddOmsOrderAudit**
> void AddOmsOrderAudit (int? omsOrderId, string omsOrderAudit)

Add new audit for an omsOrder

Adds an audit to an existing omsOrder.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOmsOrderAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to add an audit to
            var omsOrderAudit = omsOrderAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an omsOrder
                apiInstance.AddOmsOrderAudit(omsOrderId, omsOrderAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.AddOmsOrderAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to add an audit to | 
 **omsOrderAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addomsorderfile"></a>
# **AddOmsOrderFile**
> void AddOmsOrderFile (int? omsOrderId, string fileName)

Attach a file to an omsOrder

Adds a file to an existing omsOrder.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOmsOrderFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an omsOrder
                apiInstance.AddOmsOrderFile(omsOrderId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.AddOmsOrderFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addomsordertag"></a>
# **AddOmsOrderTag**
> void AddOmsOrderTag (int? omsOrderId, string omsOrderTag)

Add new tags for an omsOrder.

Adds a tag to an existing omsOrder.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOmsOrderTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to add a tag to
            var omsOrderTag = omsOrderTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an omsOrder.
                apiInstance.AddOmsOrderTag(omsOrderId, omsOrderTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.AddOmsOrderTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to add a tag to | 
 **omsOrderTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteomsordertag"></a>
# **DeleteOmsOrderTag**
> void DeleteOmsOrderTag (int? omsOrderId, string omsOrderTag)

Delete a tag for an omsOrder.

Deletes an existing omsOrder tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOmsOrderTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to remove tag from
            var omsOrderTag = omsOrderTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an omsOrder.
                apiInstance.DeleteOmsOrderTag(omsOrderId, omsOrderTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.DeleteOmsOrderTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to remove tag from | 
 **omsOrderTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateomsorderbyid"></a>
# **GetDuplicateOmsOrderById**
> OmsOrder GetDuplicateOmsOrderById (int? omsOrderId)

Get a duplicated an omsOrder by id

Returns a duplicated omsOrder identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOmsOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to be duplicated.

            try
            {
                // Get a duplicated an omsOrder by id
                OmsOrder result = apiInstance.GetDuplicateOmsOrderById(omsOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.GetDuplicateOmsOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to be duplicated. | 

### Return type

[**OmsOrder**](OmsOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getomsorderbyfilter"></a>
# **GetOmsOrderByFilter**
> List<OmsOrder> GetOmsOrderByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search omsOrders by filter

Returns the list of omsOrders that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOmsOrderByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search omsOrders by filter
                List&lt;OmsOrder&gt; result = apiInstance.GetOmsOrderByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.GetOmsOrderByFilter: " + e.Message );
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

[**List<OmsOrder>**](OmsOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getomsorderbyid"></a>
# **GetOmsOrderById**
> OmsOrder GetOmsOrderById (int? omsOrderId)

Get an omsOrder by id

Returns the omsOrder identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOmsOrderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to be returned.

            try
            {
                // Get an omsOrder by id
                OmsOrder result = apiInstance.GetOmsOrderById(omsOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.GetOmsOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to be returned. | 

### Return type

[**OmsOrder**](OmsOrder.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getomsordertags"></a>
# **GetOmsOrderTags**
> void GetOmsOrderTags (int? omsOrderId)

Get the tags for an omsOrder.

Get all existing omsOrder tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOmsOrderTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var omsOrderId = 56;  // int? | Id of the omsOrder to get tags for

            try
            {
                // Get the tags for an omsOrder.
                apiInstance.GetOmsOrderTags(omsOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.GetOmsOrderTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omsOrderId** | **int?**| Id of the omsOrder to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateomsorder"></a>
# **UpdateOmsOrder**
> void UpdateOmsOrder (OmsOrder body)

Update an omsOrder

Updates an existing omsOrder using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOmsOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var body = new OmsOrder(); // OmsOrder | OmsOrder to be updated.

            try
            {
                // Update an omsOrder
                apiInstance.UpdateOmsOrder(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.UpdateOmsOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OmsOrder**](OmsOrder.md)| OmsOrder to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateomsordercustomfields"></a>
# **UpdateOmsOrderCustomFields**
> void UpdateOmsOrderCustomFields (OmsOrder body)

Update an omsOrder custom fields

Updates an existing omsOrder custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOmsOrderCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OmsOrderApi();
            var body = new OmsOrder(); // OmsOrder | OmsOrder to be updated.

            try
            {
                // Update an omsOrder custom fields
                apiInstance.UpdateOmsOrderCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmsOrderApi.UpdateOmsOrderCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OmsOrder**](OmsOrder.md)| OmsOrder to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

