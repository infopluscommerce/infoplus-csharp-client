# Infoplus.Api.OrderSourceItemSetupApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrderSourceItemSetup**](OrderSourceItemSetupApi.md#addordersourceitemsetup) | **POST** /beta/orderSourceItemSetup | Create an orderSourceItemSetup
[**AddOrderSourceItemSetupAudit**](OrderSourceItemSetupApi.md#addordersourceitemsetupaudit) | **PUT** /beta/orderSourceItemSetup/{orderSourceItemSetupId}/audit/{orderSourceItemSetupAudit} | Add new audit for an orderSourceItemSetup
[**AddOrderSourceItemSetupFile**](OrderSourceItemSetupApi.md#addordersourceitemsetupfile) | **POST** /beta/orderSourceItemSetup/{orderSourceItemSetupId}/file/{fileName} | Attach a file to an orderSourceItemSetup
[**AddOrderSourceItemSetupTag**](OrderSourceItemSetupApi.md#addordersourceitemsetuptag) | **PUT** /beta/orderSourceItemSetup/{orderSourceItemSetupId}/tag/{orderSourceItemSetupTag} | Add new tags for an orderSourceItemSetup.
[**DeleteOrderSourceItemSetup**](OrderSourceItemSetupApi.md#deleteordersourceitemsetup) | **DELETE** /beta/orderSourceItemSetup/{orderSourceItemSetupId} | Delete an orderSourceItemSetup
[**DeleteOrderSourceItemSetupTag**](OrderSourceItemSetupApi.md#deleteordersourceitemsetuptag) | **DELETE** /beta/orderSourceItemSetup/{orderSourceItemSetupId}/tag/{orderSourceItemSetupTag} | Delete a tag for an orderSourceItemSetup.
[**GetDuplicateOrderSourceItemSetupById**](OrderSourceItemSetupApi.md#getduplicateordersourceitemsetupbyid) | **GET** /beta/orderSourceItemSetup/duplicate/{orderSourceItemSetupId} | Get a duplicated an orderSourceItemSetup by id
[**GetOrderSourceItemSetupByFilter**](OrderSourceItemSetupApi.md#getordersourceitemsetupbyfilter) | **GET** /beta/orderSourceItemSetup/search | Search orderSourceItemSetups by filter
[**GetOrderSourceItemSetupById**](OrderSourceItemSetupApi.md#getordersourceitemsetupbyid) | **GET** /beta/orderSourceItemSetup/{orderSourceItemSetupId} | Get an orderSourceItemSetup by id
[**GetOrderSourceItemSetupTags**](OrderSourceItemSetupApi.md#getordersourceitemsetuptags) | **GET** /beta/orderSourceItemSetup/{orderSourceItemSetupId}/tag | Get the tags for an orderSourceItemSetup.
[**UpdateOrderSourceItemSetup**](OrderSourceItemSetupApi.md#updateordersourceitemsetup) | **PUT** /beta/orderSourceItemSetup | Update an orderSourceItemSetup
[**UpdateOrderSourceItemSetupCustomFields**](OrderSourceItemSetupApi.md#updateordersourceitemsetupcustomfields) | **PUT** /beta/orderSourceItemSetup/customFields | Update an orderSourceItemSetup custom fields


<a name="addordersourceitemsetup"></a>
# **AddOrderSourceItemSetup**
> OrderSourceItemSetup AddOrderSourceItemSetup (OrderSourceItemSetup body)

Create an orderSourceItemSetup

Inserts a new orderSourceItemSetup using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceItemSetupExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var body = new OrderSourceItemSetup(); // OrderSourceItemSetup | OrderSourceItemSetup to be inserted.

            try
            {
                // Create an orderSourceItemSetup
                OrderSourceItemSetup result = apiInstance.AddOrderSourceItemSetup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.AddOrderSourceItemSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSourceItemSetup**](OrderSourceItemSetup.md)| OrderSourceItemSetup to be inserted. | 

### Return type

[**OrderSourceItemSetup**](OrderSourceItemSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourceitemsetupaudit"></a>
# **AddOrderSourceItemSetupAudit**
> void AddOrderSourceItemSetupAudit (int? orderSourceItemSetupId, string orderSourceItemSetupAudit)

Add new audit for an orderSourceItemSetup

Adds an audit to an existing orderSourceItemSetup.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceItemSetupAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to add an audit to
            var orderSourceItemSetupAudit = orderSourceItemSetupAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an orderSourceItemSetup
                apiInstance.AddOrderSourceItemSetupAudit(orderSourceItemSetupId, orderSourceItemSetupAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.AddOrderSourceItemSetupAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to add an audit to | 
 **orderSourceItemSetupAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourceitemsetupfile"></a>
# **AddOrderSourceItemSetupFile**
> void AddOrderSourceItemSetupFile (int? orderSourceItemSetupId, string fileName)

Attach a file to an orderSourceItemSetup

Adds a file to an existing orderSourceItemSetup.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceItemSetupFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an orderSourceItemSetup
                apiInstance.AddOrderSourceItemSetupFile(orderSourceItemSetupId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.AddOrderSourceItemSetupFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addordersourceitemsetuptag"></a>
# **AddOrderSourceItemSetupTag**
> void AddOrderSourceItemSetupTag (int? orderSourceItemSetupId, string orderSourceItemSetupTag)

Add new tags for an orderSourceItemSetup.

Adds a tag to an existing orderSourceItemSetup.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOrderSourceItemSetupTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to add a tag to
            var orderSourceItemSetupTag = orderSourceItemSetupTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an orderSourceItemSetup.
                apiInstance.AddOrderSourceItemSetupTag(orderSourceItemSetupId, orderSourceItemSetupTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.AddOrderSourceItemSetupTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to add a tag to | 
 **orderSourceItemSetupTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourceitemsetup"></a>
# **DeleteOrderSourceItemSetup**
> void DeleteOrderSourceItemSetup (int? orderSourceItemSetupId)

Delete an orderSourceItemSetup

Deletes the orderSourceItemSetup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceItemSetupExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to be deleted.

            try
            {
                // Delete an orderSourceItemSetup
                apiInstance.DeleteOrderSourceItemSetup(orderSourceItemSetupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.DeleteOrderSourceItemSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteordersourceitemsetuptag"></a>
# **DeleteOrderSourceItemSetupTag**
> void DeleteOrderSourceItemSetupTag (int? orderSourceItemSetupId, string orderSourceItemSetupTag)

Delete a tag for an orderSourceItemSetup.

Deletes an existing orderSourceItemSetup tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOrderSourceItemSetupTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to remove tag from
            var orderSourceItemSetupTag = orderSourceItemSetupTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an orderSourceItemSetup.
                apiInstance.DeleteOrderSourceItemSetupTag(orderSourceItemSetupId, orderSourceItemSetupTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.DeleteOrderSourceItemSetupTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to remove tag from | 
 **orderSourceItemSetupTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateordersourceitemsetupbyid"></a>
# **GetDuplicateOrderSourceItemSetupById**
> OrderSourceItemSetup GetDuplicateOrderSourceItemSetupById (int? orderSourceItemSetupId)

Get a duplicated an orderSourceItemSetup by id

Returns a duplicated orderSourceItemSetup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOrderSourceItemSetupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to be duplicated.

            try
            {
                // Get a duplicated an orderSourceItemSetup by id
                OrderSourceItemSetup result = apiInstance.GetDuplicateOrderSourceItemSetupById(orderSourceItemSetupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.GetDuplicateOrderSourceItemSetupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to be duplicated. | 

### Return type

[**OrderSourceItemSetup**](OrderSourceItemSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourceitemsetupbyfilter"></a>
# **GetOrderSourceItemSetupByFilter**
> List<OrderSourceItemSetup> GetOrderSourceItemSetupByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search orderSourceItemSetups by filter

Returns the list of orderSourceItemSetups that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceItemSetupByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search orderSourceItemSetups by filter
                List&lt;OrderSourceItemSetup&gt; result = apiInstance.GetOrderSourceItemSetupByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.GetOrderSourceItemSetupByFilter: " + e.Message );
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

[**List<OrderSourceItemSetup>**](OrderSourceItemSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourceitemsetupbyid"></a>
# **GetOrderSourceItemSetupById**
> OrderSourceItemSetup GetOrderSourceItemSetupById (int? orderSourceItemSetupId)

Get an orderSourceItemSetup by id

Returns the orderSourceItemSetup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceItemSetupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to be returned.

            try
            {
                // Get an orderSourceItemSetup by id
                OrderSourceItemSetup result = apiInstance.GetOrderSourceItemSetupById(orderSourceItemSetupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.GetOrderSourceItemSetupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to be returned. | 

### Return type

[**OrderSourceItemSetup**](OrderSourceItemSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getordersourceitemsetuptags"></a>
# **GetOrderSourceItemSetupTags**
> void GetOrderSourceItemSetupTags (int? orderSourceItemSetupId)

Get the tags for an orderSourceItemSetup.

Get all existing orderSourceItemSetup tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOrderSourceItemSetupTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var orderSourceItemSetupId = 56;  // int? | Id of the orderSourceItemSetup to get tags for

            try
            {
                // Get the tags for an orderSourceItemSetup.
                apiInstance.GetOrderSourceItemSetupTags(orderSourceItemSetupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.GetOrderSourceItemSetupTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSourceItemSetupId** | **int?**| Id of the orderSourceItemSetup to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateordersourceitemsetup"></a>
# **UpdateOrderSourceItemSetup**
> void UpdateOrderSourceItemSetup (OrderSourceItemSetup body)

Update an orderSourceItemSetup

Updates an existing orderSourceItemSetup using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderSourceItemSetupExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var body = new OrderSourceItemSetup(); // OrderSourceItemSetup | OrderSourceItemSetup to be updated.

            try
            {
                // Update an orderSourceItemSetup
                apiInstance.UpdateOrderSourceItemSetup(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.UpdateOrderSourceItemSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSourceItemSetup**](OrderSourceItemSetup.md)| OrderSourceItemSetup to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateordersourceitemsetupcustomfields"></a>
# **UpdateOrderSourceItemSetupCustomFields**
> void UpdateOrderSourceItemSetupCustomFields (OrderSourceItemSetup body)

Update an orderSourceItemSetup custom fields

Updates an existing orderSourceItemSetup custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOrderSourceItemSetupCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OrderSourceItemSetupApi();
            var body = new OrderSourceItemSetup(); // OrderSourceItemSetup | OrderSourceItemSetup to be updated.

            try
            {
                // Update an orderSourceItemSetup custom fields
                apiInstance.UpdateOrderSourceItemSetupCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderSourceItemSetupApi.UpdateOrderSourceItemSetupCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderSourceItemSetup**](OrderSourceItemSetup.md)| OrderSourceItemSetup to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

