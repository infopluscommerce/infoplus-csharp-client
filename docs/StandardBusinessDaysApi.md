# Infoplus.Api.StandardBusinessDaysApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddStandardBusinessDays**](StandardBusinessDaysApi.md#addstandardbusinessdays) | **POST** /beta/standardBusinessDays | Create a standardBusinessDays
[**AddStandardBusinessDaysAudit**](StandardBusinessDaysApi.md#addstandardbusinessdaysaudit) | **PUT** /beta/standardBusinessDays/{standardBusinessDaysId}/audit/{standardBusinessDaysAudit} | Add new audit for a standardBusinessDays
[**AddStandardBusinessDaysFile**](StandardBusinessDaysApi.md#addstandardbusinessdaysfile) | **POST** /beta/standardBusinessDays/{standardBusinessDaysId}/file/{fileName} | Attach a file to a standardBusinessDays
[**AddStandardBusinessDaysTag**](StandardBusinessDaysApi.md#addstandardbusinessdaystag) | **PUT** /beta/standardBusinessDays/{standardBusinessDaysId}/tag/{standardBusinessDaysTag} | Add new tags for a standardBusinessDays.
[**DeleteStandardBusinessDays**](StandardBusinessDaysApi.md#deletestandardbusinessdays) | **DELETE** /beta/standardBusinessDays/{standardBusinessDaysId} | Delete a standardBusinessDays
[**DeleteStandardBusinessDaysTag**](StandardBusinessDaysApi.md#deletestandardbusinessdaystag) | **DELETE** /beta/standardBusinessDays/{standardBusinessDaysId}/tag/{standardBusinessDaysTag} | Delete a tag for a standardBusinessDays.
[**GetDuplicateStandardBusinessDaysById**](StandardBusinessDaysApi.md#getduplicatestandardbusinessdaysbyid) | **GET** /beta/standardBusinessDays/duplicate/{standardBusinessDaysId} | Get a duplicated a standardBusinessDays by id
[**GetStandardBusinessDaysByFilter**](StandardBusinessDaysApi.md#getstandardbusinessdaysbyfilter) | **GET** /beta/standardBusinessDays/search | Search standardBusinessDayses by filter
[**GetStandardBusinessDaysById**](StandardBusinessDaysApi.md#getstandardbusinessdaysbyid) | **GET** /beta/standardBusinessDays/{standardBusinessDaysId} | Get a standardBusinessDays by id
[**GetStandardBusinessDaysTags**](StandardBusinessDaysApi.md#getstandardbusinessdaystags) | **GET** /beta/standardBusinessDays/{standardBusinessDaysId}/tag | Get the tags for a standardBusinessDays.
[**UpdateStandardBusinessDays**](StandardBusinessDaysApi.md#updatestandardbusinessdays) | **PUT** /beta/standardBusinessDays | Update a standardBusinessDays


<a name="addstandardbusinessdays"></a>
# **AddStandardBusinessDays**
> StandardBusinessDays AddStandardBusinessDays (StandardBusinessDays body)

Create a standardBusinessDays

Inserts a new standardBusinessDays using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddStandardBusinessDaysExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var body = new StandardBusinessDays(); // StandardBusinessDays | StandardBusinessDays to be inserted.

            try
            {
                // Create a standardBusinessDays
                StandardBusinessDays result = apiInstance.AddStandardBusinessDays(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.AddStandardBusinessDays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StandardBusinessDays**](StandardBusinessDays.md)| StandardBusinessDays to be inserted. | 

### Return type

[**StandardBusinessDays**](StandardBusinessDays.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstandardbusinessdaysaudit"></a>
# **AddStandardBusinessDaysAudit**
> void AddStandardBusinessDaysAudit (int? standardBusinessDaysId, string standardBusinessDaysAudit)

Add new audit for a standardBusinessDays

Adds an audit to an existing standardBusinessDays.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddStandardBusinessDaysAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to add an audit to
            var standardBusinessDaysAudit = standardBusinessDaysAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a standardBusinessDays
                apiInstance.AddStandardBusinessDaysAudit(standardBusinessDaysId, standardBusinessDaysAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.AddStandardBusinessDaysAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to add an audit to | 
 **standardBusinessDaysAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstandardbusinessdaysfile"></a>
# **AddStandardBusinessDaysFile**
> void AddStandardBusinessDaysFile (int? standardBusinessDaysId, string fileName)

Attach a file to a standardBusinessDays

Adds a file to an existing standardBusinessDays.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddStandardBusinessDaysFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a standardBusinessDays
                apiInstance.AddStandardBusinessDaysFile(standardBusinessDaysId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.AddStandardBusinessDaysFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstandardbusinessdaystag"></a>
# **AddStandardBusinessDaysTag**
> void AddStandardBusinessDaysTag (int? standardBusinessDaysId, string standardBusinessDaysTag)

Add new tags for a standardBusinessDays.

Adds a tag to an existing standardBusinessDays.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddStandardBusinessDaysTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to add a tag to
            var standardBusinessDaysTag = standardBusinessDaysTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a standardBusinessDays.
                apiInstance.AddStandardBusinessDaysTag(standardBusinessDaysId, standardBusinessDaysTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.AddStandardBusinessDaysTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to add a tag to | 
 **standardBusinessDaysTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestandardbusinessdays"></a>
# **DeleteStandardBusinessDays**
> void DeleteStandardBusinessDays (int? standardBusinessDaysId)

Delete a standardBusinessDays

Deletes the standardBusinessDays identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteStandardBusinessDaysExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to be deleted.

            try
            {
                // Delete a standardBusinessDays
                apiInstance.DeleteStandardBusinessDays(standardBusinessDaysId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.DeleteStandardBusinessDays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestandardbusinessdaystag"></a>
# **DeleteStandardBusinessDaysTag**
> void DeleteStandardBusinessDaysTag (int? standardBusinessDaysId, string standardBusinessDaysTag)

Delete a tag for a standardBusinessDays.

Deletes an existing standardBusinessDays tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteStandardBusinessDaysTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to remove tag from
            var standardBusinessDaysTag = standardBusinessDaysTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a standardBusinessDays.
                apiInstance.DeleteStandardBusinessDaysTag(standardBusinessDaysId, standardBusinessDaysTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.DeleteStandardBusinessDaysTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to remove tag from | 
 **standardBusinessDaysTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatestandardbusinessdaysbyid"></a>
# **GetDuplicateStandardBusinessDaysById**
> StandardBusinessDays GetDuplicateStandardBusinessDaysById (int? standardBusinessDaysId)

Get a duplicated a standardBusinessDays by id

Returns a duplicated standardBusinessDays identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateStandardBusinessDaysByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to be duplicated.

            try
            {
                // Get a duplicated a standardBusinessDays by id
                StandardBusinessDays result = apiInstance.GetDuplicateStandardBusinessDaysById(standardBusinessDaysId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.GetDuplicateStandardBusinessDaysById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to be duplicated. | 

### Return type

[**StandardBusinessDays**](StandardBusinessDays.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstandardbusinessdaysbyfilter"></a>
# **GetStandardBusinessDaysByFilter**
> List<StandardBusinessDays> GetStandardBusinessDaysByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search standardBusinessDayses by filter

Returns the list of standardBusinessDayses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetStandardBusinessDaysByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search standardBusinessDayses by filter
                List&lt;StandardBusinessDays&gt; result = apiInstance.GetStandardBusinessDaysByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.GetStandardBusinessDaysByFilter: " + e.Message );
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

[**List<StandardBusinessDays>**](StandardBusinessDays.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstandardbusinessdaysbyid"></a>
# **GetStandardBusinessDaysById**
> StandardBusinessDays GetStandardBusinessDaysById (int? standardBusinessDaysId)

Get a standardBusinessDays by id

Returns the standardBusinessDays identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetStandardBusinessDaysByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to be returned.

            try
            {
                // Get a standardBusinessDays by id
                StandardBusinessDays result = apiInstance.GetStandardBusinessDaysById(standardBusinessDaysId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.GetStandardBusinessDaysById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to be returned. | 

### Return type

[**StandardBusinessDays**](StandardBusinessDays.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstandardbusinessdaystags"></a>
# **GetStandardBusinessDaysTags**
> void GetStandardBusinessDaysTags (int? standardBusinessDaysId)

Get the tags for a standardBusinessDays.

Get all existing standardBusinessDays tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetStandardBusinessDaysTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var standardBusinessDaysId = 56;  // int? | Id of the standardBusinessDays to get tags for

            try
            {
                // Get the tags for a standardBusinessDays.
                apiInstance.GetStandardBusinessDaysTags(standardBusinessDaysId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.GetStandardBusinessDaysTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **standardBusinessDaysId** | **int?**| Id of the standardBusinessDays to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestandardbusinessdays"></a>
# **UpdateStandardBusinessDays**
> void UpdateStandardBusinessDays (StandardBusinessDays body)

Update a standardBusinessDays

Updates an existing standardBusinessDays using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateStandardBusinessDaysExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new StandardBusinessDaysApi();
            var body = new StandardBusinessDays(); // StandardBusinessDays | StandardBusinessDays to be updated.

            try
            {
                // Update a standardBusinessDays
                apiInstance.UpdateStandardBusinessDays(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardBusinessDaysApi.UpdateStandardBusinessDays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StandardBusinessDays**](StandardBusinessDays.md)| StandardBusinessDays to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

