# Infoplus.Api.CartonActivityApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartonActivity**](CartonActivityApi.md#addcartonactivity) | **POST** /beta/cartonActivity | Create a cartonActivity
[**AddCartonActivityAudit**](CartonActivityApi.md#addcartonactivityaudit) | **PUT** /beta/cartonActivity/{cartonActivityId}/audit/{cartonActivityAudit} | Add new audit for a cartonActivity
[**AddCartonActivityTag**](CartonActivityApi.md#addcartonactivitytag) | **PUT** /beta/cartonActivity/{cartonActivityId}/tag/{cartonActivityTag} | Add new tags for a cartonActivity.
[**DeleteCartonActivity**](CartonActivityApi.md#deletecartonactivity) | **DELETE** /beta/cartonActivity/{cartonActivityId} | Delete a cartonActivity
[**DeleteCartonActivityTag**](CartonActivityApi.md#deletecartonactivitytag) | **DELETE** /beta/cartonActivity/{cartonActivityId}/tag/{cartonActivityTag} | Delete a tag for a cartonActivity.
[**GetCartonActivityByFilter**](CartonActivityApi.md#getcartonactivitybyfilter) | **GET** /beta/cartonActivity/search | Search cartonActivitys by filter
[**GetCartonActivityById**](CartonActivityApi.md#getcartonactivitybyid) | **GET** /beta/cartonActivity/{cartonActivityId} | Get a cartonActivity by id
[**GetCartonActivityTags**](CartonActivityApi.md#getcartonactivitytags) | **GET** /beta/cartonActivity/{cartonActivityId}/tag | Get the tags for a cartonActivity.
[**GetDuplicateCartonActivityById**](CartonActivityApi.md#getduplicatecartonactivitybyid) | **GET** /beta/cartonActivity/duplicate/{cartonActivityId} | Get a duplicated a cartonActivity by id
[**UpdateCartonActivity**](CartonActivityApi.md#updatecartonactivity) | **PUT** /beta/cartonActivity | Update a cartonActivity


<a name="addcartonactivity"></a>
# **AddCartonActivity**
> CartonActivity AddCartonActivity (CartonActivity body)

Create a cartonActivity

Inserts a new cartonActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var body = new CartonActivity(); // CartonActivity | CartonActivity to be inserted.

            try
            {
                // Create a cartonActivity
                CartonActivity result = apiInstance.AddCartonActivity(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.AddCartonActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonActivity**](CartonActivity.md)| CartonActivity to be inserted. | 

### Return type

[**CartonActivity**](CartonActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartonactivityaudit"></a>
# **AddCartonActivityAudit**
> void AddCartonActivityAudit (int? cartonActivityId, string cartonActivityAudit)

Add new audit for a cartonActivity

Adds an audit to an existing cartonActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonActivityAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to add an audit to
            var cartonActivityAudit = cartonActivityAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a cartonActivity
                apiInstance.AddCartonActivityAudit(cartonActivityId, cartonActivityAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.AddCartonActivityAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to add an audit to | 
 **cartonActivityAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartonactivitytag"></a>
# **AddCartonActivityTag**
> void AddCartonActivityTag (int? cartonActivityId, string cartonActivityTag)

Add new tags for a cartonActivity.

Adds a tag to an existing cartonActivity.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to add a tag to
            var cartonActivityTag = cartonActivityTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a cartonActivity.
                apiInstance.AddCartonActivityTag(cartonActivityId, cartonActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.AddCartonActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to add a tag to | 
 **cartonActivityTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartonactivity"></a>
# **DeleteCartonActivity**
> void DeleteCartonActivity (int? cartonActivityId)

Delete a cartonActivity

Deletes the cartonActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to be deleted.

            try
            {
                // Delete a cartonActivity
                apiInstance.DeleteCartonActivity(cartonActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.DeleteCartonActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartonactivitytag"></a>
# **DeleteCartonActivityTag**
> void DeleteCartonActivityTag (int? cartonActivityId, string cartonActivityTag)

Delete a tag for a cartonActivity.

Deletes an existing cartonActivity tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonActivityTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to remove tag from
            var cartonActivityTag = cartonActivityTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a cartonActivity.
                apiInstance.DeleteCartonActivityTag(cartonActivityId, cartonActivityTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.DeleteCartonActivityTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to remove tag from | 
 **cartonActivityTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonactivitybyfilter"></a>
# **GetCartonActivityByFilter**
> List<CartonActivity> GetCartonActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartonActivitys by filter

Returns the list of cartonActivitys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonActivityByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartonActivitys by filter
                List&lt;CartonActivity&gt; result = apiInstance.GetCartonActivityByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.GetCartonActivityByFilter: " + e.Message );
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

[**List<CartonActivity>**](CartonActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonactivitybyid"></a>
# **GetCartonActivityById**
> CartonActivity GetCartonActivityById (int? cartonActivityId)

Get a cartonActivity by id

Returns the cartonActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to be returned.

            try
            {
                // Get a cartonActivity by id
                CartonActivity result = apiInstance.GetCartonActivityById(cartonActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.GetCartonActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to be returned. | 

### Return type

[**CartonActivity**](CartonActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonactivitytags"></a>
# **GetCartonActivityTags**
> void GetCartonActivityTags (int? cartonActivityId)

Get the tags for a cartonActivity.

Get all existing cartonActivity tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonActivityTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to get tags for

            try
            {
                // Get the tags for a cartonActivity.
                apiInstance.GetCartonActivityTags(cartonActivityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.GetCartonActivityTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecartonactivitybyid"></a>
# **GetDuplicateCartonActivityById**
> CartonActivity GetDuplicateCartonActivityById (int? cartonActivityId)

Get a duplicated a cartonActivity by id

Returns a duplicated cartonActivity identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCartonActivityByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var cartonActivityId = 56;  // int? | Id of the cartonActivity to be duplicated.

            try
            {
                // Get a duplicated a cartonActivity by id
                CartonActivity result = apiInstance.GetDuplicateCartonActivityById(cartonActivityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.GetDuplicateCartonActivityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonActivityId** | **int?**| Id of the cartonActivity to be duplicated. | 

### Return type

[**CartonActivity**](CartonActivity.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartonactivity"></a>
# **UpdateCartonActivity**
> void UpdateCartonActivity (CartonActivity body)

Update a cartonActivity

Updates an existing cartonActivity using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonActivityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonActivityApi();
            var body = new CartonActivity(); // CartonActivity | CartonActivity to be updated.

            try
            {
                // Update a cartonActivity
                apiInstance.UpdateCartonActivity(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonActivityApi.UpdateCartonActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonActivity**](CartonActivity.md)| CartonActivity to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

