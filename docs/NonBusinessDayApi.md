# Infoplus.Api.NonBusinessDayApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNonBusinessDay**](NonBusinessDayApi.md#addnonbusinessday) | **POST** /beta/nonBusinessDay | Create a nonBusinessDay
[**AddNonBusinessDayAudit**](NonBusinessDayApi.md#addnonbusinessdayaudit) | **PUT** /beta/nonBusinessDay/{nonBusinessDayId}/audit/{nonBusinessDayAudit} | Add new audit for a nonBusinessDay
[**AddNonBusinessDayFile**](NonBusinessDayApi.md#addnonbusinessdayfile) | **POST** /beta/nonBusinessDay/{nonBusinessDayId}/file/{fileName} | Attach a file to a nonBusinessDay
[**AddNonBusinessDayTag**](NonBusinessDayApi.md#addnonbusinessdaytag) | **PUT** /beta/nonBusinessDay/{nonBusinessDayId}/tag/{nonBusinessDayTag} | Add new tags for a nonBusinessDay.
[**DeleteNonBusinessDay**](NonBusinessDayApi.md#deletenonbusinessday) | **DELETE** /beta/nonBusinessDay/{nonBusinessDayId} | Delete a nonBusinessDay
[**DeleteNonBusinessDayTag**](NonBusinessDayApi.md#deletenonbusinessdaytag) | **DELETE** /beta/nonBusinessDay/{nonBusinessDayId}/tag/{nonBusinessDayTag} | Delete a tag for a nonBusinessDay.
[**GetDuplicateNonBusinessDayById**](NonBusinessDayApi.md#getduplicatenonbusinessdaybyid) | **GET** /beta/nonBusinessDay/duplicate/{nonBusinessDayId} | Get a duplicated a nonBusinessDay by id
[**GetNonBusinessDayByFilter**](NonBusinessDayApi.md#getnonbusinessdaybyfilter) | **GET** /beta/nonBusinessDay/search | Search nonBusinessDays by filter
[**GetNonBusinessDayById**](NonBusinessDayApi.md#getnonbusinessdaybyid) | **GET** /beta/nonBusinessDay/{nonBusinessDayId} | Get a nonBusinessDay by id
[**GetNonBusinessDayTags**](NonBusinessDayApi.md#getnonbusinessdaytags) | **GET** /beta/nonBusinessDay/{nonBusinessDayId}/tag | Get the tags for a nonBusinessDay.
[**UpdateNonBusinessDay**](NonBusinessDayApi.md#updatenonbusinessday) | **PUT** /beta/nonBusinessDay | Update a nonBusinessDay


<a name="addnonbusinessday"></a>
# **AddNonBusinessDay**
> NonBusinessDay AddNonBusinessDay (NonBusinessDay body)

Create a nonBusinessDay

Inserts a new nonBusinessDay using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddNonBusinessDayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var body = new NonBusinessDay(); // NonBusinessDay | NonBusinessDay to be inserted.

            try
            {
                // Create a nonBusinessDay
                NonBusinessDay result = apiInstance.AddNonBusinessDay(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.AddNonBusinessDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NonBusinessDay**](NonBusinessDay.md)| NonBusinessDay to be inserted. | 

### Return type

[**NonBusinessDay**](NonBusinessDay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addnonbusinessdayaudit"></a>
# **AddNonBusinessDayAudit**
> void AddNonBusinessDayAudit (int? nonBusinessDayId, string nonBusinessDayAudit)

Add new audit for a nonBusinessDay

Adds an audit to an existing nonBusinessDay.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddNonBusinessDayAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to add an audit to
            var nonBusinessDayAudit = nonBusinessDayAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a nonBusinessDay
                apiInstance.AddNonBusinessDayAudit(nonBusinessDayId, nonBusinessDayAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.AddNonBusinessDayAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to add an audit to | 
 **nonBusinessDayAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addnonbusinessdayfile"></a>
# **AddNonBusinessDayFile**
> void AddNonBusinessDayFile (int? nonBusinessDayId, string fileName)

Attach a file to a nonBusinessDay

Adds a file to an existing nonBusinessDay.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddNonBusinessDayFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a nonBusinessDay
                apiInstance.AddNonBusinessDayFile(nonBusinessDayId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.AddNonBusinessDayFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addnonbusinessdaytag"></a>
# **AddNonBusinessDayTag**
> void AddNonBusinessDayTag (int? nonBusinessDayId, string nonBusinessDayTag)

Add new tags for a nonBusinessDay.

Adds a tag to an existing nonBusinessDay.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddNonBusinessDayTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to add a tag to
            var nonBusinessDayTag = nonBusinessDayTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a nonBusinessDay.
                apiInstance.AddNonBusinessDayTag(nonBusinessDayId, nonBusinessDayTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.AddNonBusinessDayTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to add a tag to | 
 **nonBusinessDayTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenonbusinessday"></a>
# **DeleteNonBusinessDay**
> void DeleteNonBusinessDay (int? nonBusinessDayId)

Delete a nonBusinessDay

Deletes the nonBusinessDay identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteNonBusinessDayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to be deleted.

            try
            {
                // Delete a nonBusinessDay
                apiInstance.DeleteNonBusinessDay(nonBusinessDayId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.DeleteNonBusinessDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenonbusinessdaytag"></a>
# **DeleteNonBusinessDayTag**
> void DeleteNonBusinessDayTag (int? nonBusinessDayId, string nonBusinessDayTag)

Delete a tag for a nonBusinessDay.

Deletes an existing nonBusinessDay tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteNonBusinessDayTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to remove tag from
            var nonBusinessDayTag = nonBusinessDayTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a nonBusinessDay.
                apiInstance.DeleteNonBusinessDayTag(nonBusinessDayId, nonBusinessDayTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.DeleteNonBusinessDayTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to remove tag from | 
 **nonBusinessDayTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatenonbusinessdaybyid"></a>
# **GetDuplicateNonBusinessDayById**
> NonBusinessDay GetDuplicateNonBusinessDayById (int? nonBusinessDayId)

Get a duplicated a nonBusinessDay by id

Returns a duplicated nonBusinessDay identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateNonBusinessDayByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to be duplicated.

            try
            {
                // Get a duplicated a nonBusinessDay by id
                NonBusinessDay result = apiInstance.GetDuplicateNonBusinessDayById(nonBusinessDayId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.GetDuplicateNonBusinessDayById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to be duplicated. | 

### Return type

[**NonBusinessDay**](NonBusinessDay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnonbusinessdaybyfilter"></a>
# **GetNonBusinessDayByFilter**
> List<NonBusinessDay> GetNonBusinessDayByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search nonBusinessDays by filter

Returns the list of nonBusinessDays that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetNonBusinessDayByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search nonBusinessDays by filter
                List&lt;NonBusinessDay&gt; result = apiInstance.GetNonBusinessDayByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.GetNonBusinessDayByFilter: " + e.Message );
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

[**List<NonBusinessDay>**](NonBusinessDay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnonbusinessdaybyid"></a>
# **GetNonBusinessDayById**
> NonBusinessDay GetNonBusinessDayById (int? nonBusinessDayId)

Get a nonBusinessDay by id

Returns the nonBusinessDay identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetNonBusinessDayByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to be returned.

            try
            {
                // Get a nonBusinessDay by id
                NonBusinessDay result = apiInstance.GetNonBusinessDayById(nonBusinessDayId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.GetNonBusinessDayById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to be returned. | 

### Return type

[**NonBusinessDay**](NonBusinessDay.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnonbusinessdaytags"></a>
# **GetNonBusinessDayTags**
> void GetNonBusinessDayTags (int? nonBusinessDayId)

Get the tags for a nonBusinessDay.

Get all existing nonBusinessDay tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetNonBusinessDayTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var nonBusinessDayId = 56;  // int? | Id of the nonBusinessDay to get tags for

            try
            {
                // Get the tags for a nonBusinessDay.
                apiInstance.GetNonBusinessDayTags(nonBusinessDayId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.GetNonBusinessDayTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nonBusinessDayId** | **int?**| Id of the nonBusinessDay to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenonbusinessday"></a>
# **UpdateNonBusinessDay**
> void UpdateNonBusinessDay (NonBusinessDay body)

Update a nonBusinessDay

Updates an existing nonBusinessDay using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateNonBusinessDayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new NonBusinessDayApi();
            var body = new NonBusinessDay(); // NonBusinessDay | NonBusinessDay to be updated.

            try
            {
                // Update a nonBusinessDay
                apiInstance.UpdateNonBusinessDay(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NonBusinessDayApi.UpdateNonBusinessDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NonBusinessDay**](NonBusinessDay.md)| NonBusinessDay to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

