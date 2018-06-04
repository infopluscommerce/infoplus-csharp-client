# Infoplus.Api.ItemReceiptActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemReceiptActivity**](ItemReceiptActivityApi.md#additemreceiptactivity) | **POST** /beta/itemReceiptActivity | Create an itemReceiptActivity
[**AddItemReceiptActivityAudit**](ItemReceiptActivityApi.md#additemreceiptactivityaudit) | **PUT** /beta/itemReceiptActivity/{itemReceiptActivityId}/audit/{itemReceiptActivityAudit} | Add new audit for an itemReceiptActivity
[**AddItemReceiptActivityTag**](ItemReceiptActivityApi.md#additemreceiptactivitytag) | **PUT** /beta/itemReceiptActivity/{itemReceiptActivityId}/tag/{itemReceiptActivityTag} | Add new tags for an itemReceiptActivity.
[**DeleteItemReceiptActivity**](ItemReceiptActivityApi.md#deleteitemreceiptactivity) | **DELETE** /beta/itemReceiptActivity/{itemReceiptActivityId} | Delete an itemReceiptActivity
[**DeleteItemReceiptActivityTag**](ItemReceiptActivityApi.md#deleteitemreceiptactivitytag) | **DELETE** /beta/itemReceiptActivity/{itemReceiptActivityId}/tag/{itemReceiptActivityTag} | Delete a tag for an itemReceiptActivity.
[**GetDuplicateItemReceiptActivityById**](ItemReceiptActivityApi.md#getduplicateitemreceiptactivitybyid) | **GET** /beta/itemReceiptActivity/duplicate/{itemReceiptActivityId} | Get a duplicated an itemReceiptActivity by id
[**GetItemReceiptActivityByFilter**](ItemReceiptActivityApi.md#getitemreceiptactivitybyfilter) | **GET** /beta/itemReceiptActivity/search | Search itemReceiptActivitys by filter
[**GetItemReceiptActivityById**](ItemReceiptActivityApi.md#getitemreceiptactivitybyid) | **GET** /beta/itemReceiptActivity/{itemReceiptActivityId} | Get an itemReceiptActivity by id
[**GetItemReceiptActivityTags**](ItemReceiptActivityApi.md#getitemreceiptactivitytags) | **GET** /beta/itemReceiptActivity/{itemReceiptActivityId}/tag | Get the tags for an itemReceiptActivity.
[**UpdateItemReceiptActivity**](ItemReceiptActivityApi.md#updateitemreceiptactivity) | **PUT** /beta/itemReceiptActivity | Update an itemReceiptActivity


<a name="additemreceiptactivity"></a>
# **AddItemReceiptActivity**
> ItemReceiptActivity AddItemReceiptActivity (ItemReceiptActivity body)

Create an itemReceiptActivity

Inserts a new itemReceiptActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var body = new ItemReceiptActivity(); // ItemReceiptActivity | ItemReceiptActivity to be inserted.

            try
            {
                // Create an itemReceiptActivity
                ItemReceiptActivity result = apiInstance.AddItemReceiptActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.AddItemReceiptActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemReceiptActivity**](ItemReceiptActivity.md)| ItemReceiptActivity to be inserted. | 

### Return type

[**ItemReceiptActivity**](ItemReceiptActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemreceiptactivityaudit"></a>
# **AddItemReceiptActivityAudit**
> void AddItemReceiptActivityAudit (int? itemReceiptActivityId, string itemReceiptActivityAudit)

Add new audit for an itemReceiptActivity

Adds an audit to an existing itemReceiptActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to add an audit to
            var itemReceiptActivityAudit = itemReceiptActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an itemReceiptActivity
                apiInstance.AddItemReceiptActivityAudit(itemReceiptActivityId, itemReceiptActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.AddItemReceiptActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to add an audit to | 
 **itemReceiptActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemreceiptactivitytag"></a>
# **AddItemReceiptActivityTag**
> void AddItemReceiptActivityTag (int? itemReceiptActivityId, string itemReceiptActivityTag)

Add new tags for an itemReceiptActivity.

Adds a tag to an existing itemReceiptActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddItemReceiptActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to add a tag to
            var itemReceiptActivityTag = itemReceiptActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an itemReceiptActivity.
                apiInstance.AddItemReceiptActivityTag(itemReceiptActivityId, itemReceiptActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.AddItemReceiptActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to add a tag to | 
 **itemReceiptActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemreceiptactivity"></a>
# **DeleteItemReceiptActivity**
> void DeleteItemReceiptActivity (int? itemReceiptActivityId)

Delete an itemReceiptActivity

Deletes the itemReceiptActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemReceiptActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to be deleted.

            try
            {
                // Delete an itemReceiptActivity
                apiInstance.DeleteItemReceiptActivity(itemReceiptActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.DeleteItemReceiptActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemreceiptactivitytag"></a>
# **DeleteItemReceiptActivityTag**
> void DeleteItemReceiptActivityTag (int? itemReceiptActivityId, string itemReceiptActivityTag)

Delete a tag for an itemReceiptActivity.

Deletes an existing itemReceiptActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteItemReceiptActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to remove tag from
            var itemReceiptActivityTag = itemReceiptActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an itemReceiptActivity.
                apiInstance.DeleteItemReceiptActivityTag(itemReceiptActivityId, itemReceiptActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.DeleteItemReceiptActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to remove tag from | 
 **itemReceiptActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateitemreceiptactivitybyid"></a>
# **GetDuplicateItemReceiptActivityById**
> ItemReceiptActivity GetDuplicateItemReceiptActivityById (int? itemReceiptActivityId)

Get a duplicated an itemReceiptActivity by id

Returns a duplicated itemReceiptActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateItemReceiptActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to be duplicated.

            try
            {
                // Get a duplicated an itemReceiptActivity by id
                ItemReceiptActivity result = apiInstance.GetDuplicateItemReceiptActivityById(itemReceiptActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.GetDuplicateItemReceiptActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to be duplicated. | 

### Return type

[**ItemReceiptActivity**](ItemReceiptActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptactivitybyfilter"></a>
# **GetItemReceiptActivityByFilter**
> List<ItemReceiptActivity> GetItemReceiptActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search itemReceiptActivitys by filter

Returns the list of itemReceiptActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search itemReceiptActivitys by filter
                List&lt;ItemReceiptActivity&gt; result = apiInstance.GetItemReceiptActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.GetItemReceiptActivityByFilter: " + e.Message );
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

[**List<ItemReceiptActivity>**](ItemReceiptActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptactivitybyid"></a>
# **GetItemReceiptActivityById**
> ItemReceiptActivity GetItemReceiptActivityById (int? itemReceiptActivityId)

Get an itemReceiptActivity by id

Returns the itemReceiptActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to be returned.

            try
            {
                // Get an itemReceiptActivity by id
                ItemReceiptActivity result = apiInstance.GetItemReceiptActivityById(itemReceiptActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.GetItemReceiptActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to be returned. | 

### Return type

[**ItemReceiptActivity**](ItemReceiptActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemreceiptactivitytags"></a>
# **GetItemReceiptActivityTags**
> void GetItemReceiptActivityTags (int? itemReceiptActivityId)

Get the tags for an itemReceiptActivity.

Get all existing itemReceiptActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetItemReceiptActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var itemReceiptActivityId = 56;  // int? | Id of the itemReceiptActivity to get tags for

            try
            {
                // Get the tags for an itemReceiptActivity.
                apiInstance.GetItemReceiptActivityTags(itemReceiptActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.GetItemReceiptActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemReceiptActivityId** | **int?**| Id of the itemReceiptActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemreceiptactivity"></a>
# **UpdateItemReceiptActivity**
> void UpdateItemReceiptActivity (ItemReceiptActivity body)

Update an itemReceiptActivity

Updates an existing itemReceiptActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateItemReceiptActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ItemReceiptActivityApi();
            var body = new ItemReceiptActivity(); // ItemReceiptActivity | ItemReceiptActivity to be updated.

            try
            {
                // Update an itemReceiptActivity
                apiInstance.UpdateItemReceiptActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemReceiptActivityApi.UpdateItemReceiptActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ItemReceiptActivity**](ItemReceiptActivity.md)| ItemReceiptActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

