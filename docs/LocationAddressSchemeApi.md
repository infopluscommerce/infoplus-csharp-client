# Infoplus.Api.LocationAddressSchemeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocationAddressScheme**](LocationAddressSchemeApi.md#addlocationaddressscheme) | **POST** /beta/locationAddressScheme | Create a locationAddressScheme
[**AddLocationAddressSchemeAudit**](LocationAddressSchemeApi.md#addlocationaddressschemeaudit) | **PUT** /beta/locationAddressScheme/{locationAddressSchemeId}/audit/{locationAddressSchemeAudit} | Add new audit for a locationAddressScheme
[**AddLocationAddressSchemeFile**](LocationAddressSchemeApi.md#addlocationaddressschemefile) | **POST** /beta/locationAddressScheme/{locationAddressSchemeId}/file/{fileName} | Attach a file to a locationAddressScheme
[**AddLocationAddressSchemeTag**](LocationAddressSchemeApi.md#addlocationaddressschemetag) | **PUT** /beta/locationAddressScheme/{locationAddressSchemeId}/tag/{locationAddressSchemeTag} | Add new tags for a locationAddressScheme.
[**DeleteLocationAddressScheme**](LocationAddressSchemeApi.md#deletelocationaddressscheme) | **DELETE** /beta/locationAddressScheme/{locationAddressSchemeId} | Delete a locationAddressScheme
[**DeleteLocationAddressSchemeTag**](LocationAddressSchemeApi.md#deletelocationaddressschemetag) | **DELETE** /beta/locationAddressScheme/{locationAddressSchemeId}/tag/{locationAddressSchemeTag} | Delete a tag for a locationAddressScheme.
[**GetDuplicateLocationAddressSchemeById**](LocationAddressSchemeApi.md#getduplicatelocationaddressschemebyid) | **GET** /beta/locationAddressScheme/duplicate/{locationAddressSchemeId} | Get a duplicated a locationAddressScheme by id
[**GetLocationAddressSchemeByFilter**](LocationAddressSchemeApi.md#getlocationaddressschemebyfilter) | **GET** /beta/locationAddressScheme/search | Search locationAddressSchemes by filter
[**GetLocationAddressSchemeById**](LocationAddressSchemeApi.md#getlocationaddressschemebyid) | **GET** /beta/locationAddressScheme/{locationAddressSchemeId} | Get a locationAddressScheme by id
[**GetLocationAddressSchemeTags**](LocationAddressSchemeApi.md#getlocationaddressschemetags) | **GET** /beta/locationAddressScheme/{locationAddressSchemeId}/tag | Get the tags for a locationAddressScheme.
[**UpdateLocationAddressScheme**](LocationAddressSchemeApi.md#updatelocationaddressscheme) | **PUT** /beta/locationAddressScheme | Update a locationAddressScheme
[**UpdateLocationAddressSchemeCustomFields**](LocationAddressSchemeApi.md#updatelocationaddressschemecustomfields) | **PUT** /beta/locationAddressScheme/customFields | Update a locationAddressScheme custom fields


<a name="addlocationaddressscheme"></a>
# **AddLocationAddressScheme**
> LocationAddressScheme AddLocationAddressScheme (LocationAddressScheme body)

Create a locationAddressScheme

Inserts a new locationAddressScheme using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationAddressSchemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var body = new LocationAddressScheme(); // LocationAddressScheme | LocationAddressScheme to be inserted.

            try
            {
                // Create a locationAddressScheme
                LocationAddressScheme result = apiInstance.AddLocationAddressScheme(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.AddLocationAddressScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationAddressScheme**](LocationAddressScheme.md)| LocationAddressScheme to be inserted. | 

### Return type

[**LocationAddressScheme**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationaddressschemeaudit"></a>
# **AddLocationAddressSchemeAudit**
> void AddLocationAddressSchemeAudit (int? locationAddressSchemeId, string locationAddressSchemeAudit)

Add new audit for a locationAddressScheme

Adds an audit to an existing locationAddressScheme.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationAddressSchemeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to add an audit to
            var locationAddressSchemeAudit = locationAddressSchemeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a locationAddressScheme
                apiInstance.AddLocationAddressSchemeAudit(locationAddressSchemeId, locationAddressSchemeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.AddLocationAddressSchemeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to add an audit to | 
 **locationAddressSchemeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationaddressschemefile"></a>
# **AddLocationAddressSchemeFile**
> void AddLocationAddressSchemeFile (int? locationAddressSchemeId, string fileName)

Attach a file to a locationAddressScheme

Adds a file to an existing locationAddressScheme.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationAddressSchemeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a locationAddressScheme
                apiInstance.AddLocationAddressSchemeFile(locationAddressSchemeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.AddLocationAddressSchemeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationaddressschemetag"></a>
# **AddLocationAddressSchemeTag**
> void AddLocationAddressSchemeTag (int? locationAddressSchemeId, string locationAddressSchemeTag)

Add new tags for a locationAddressScheme.

Adds a tag to an existing locationAddressScheme.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationAddressSchemeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to add a tag to
            var locationAddressSchemeTag = locationAddressSchemeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a locationAddressScheme.
                apiInstance.AddLocationAddressSchemeTag(locationAddressSchemeId, locationAddressSchemeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.AddLocationAddressSchemeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to add a tag to | 
 **locationAddressSchemeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationaddressscheme"></a>
# **DeleteLocationAddressScheme**
> void DeleteLocationAddressScheme (int? locationAddressSchemeId)

Delete a locationAddressScheme

Deletes the locationAddressScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationAddressSchemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to be deleted.

            try
            {
                // Delete a locationAddressScheme
                apiInstance.DeleteLocationAddressScheme(locationAddressSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.DeleteLocationAddressScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationaddressschemetag"></a>
# **DeleteLocationAddressSchemeTag**
> void DeleteLocationAddressSchemeTag (int? locationAddressSchemeId, string locationAddressSchemeTag)

Delete a tag for a locationAddressScheme.

Deletes an existing locationAddressScheme tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationAddressSchemeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to remove tag from
            var locationAddressSchemeTag = locationAddressSchemeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a locationAddressScheme.
                apiInstance.DeleteLocationAddressSchemeTag(locationAddressSchemeId, locationAddressSchemeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.DeleteLocationAddressSchemeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to remove tag from | 
 **locationAddressSchemeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatelocationaddressschemebyid"></a>
# **GetDuplicateLocationAddressSchemeById**
> LocationAddressScheme GetDuplicateLocationAddressSchemeById (int? locationAddressSchemeId)

Get a duplicated a locationAddressScheme by id

Returns a duplicated locationAddressScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLocationAddressSchemeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to be duplicated.

            try
            {
                // Get a duplicated a locationAddressScheme by id
                LocationAddressScheme result = apiInstance.GetDuplicateLocationAddressSchemeById(locationAddressSchemeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.GetDuplicateLocationAddressSchemeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to be duplicated. | 

### Return type

[**LocationAddressScheme**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationaddressschemebyfilter"></a>
# **GetLocationAddressSchemeByFilter**
> List<LocationAddressScheme> GetLocationAddressSchemeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search locationAddressSchemes by filter

Returns the list of locationAddressSchemes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationAddressSchemeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search locationAddressSchemes by filter
                List&lt;LocationAddressScheme&gt; result = apiInstance.GetLocationAddressSchemeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.GetLocationAddressSchemeByFilter: " + e.Message );
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

[**List<LocationAddressScheme>**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationaddressschemebyid"></a>
# **GetLocationAddressSchemeById**
> LocationAddressScheme GetLocationAddressSchemeById (int? locationAddressSchemeId)

Get a locationAddressScheme by id

Returns the locationAddressScheme identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationAddressSchemeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to be returned.

            try
            {
                // Get a locationAddressScheme by id
                LocationAddressScheme result = apiInstance.GetLocationAddressSchemeById(locationAddressSchemeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.GetLocationAddressSchemeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to be returned. | 

### Return type

[**LocationAddressScheme**](LocationAddressScheme.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationaddressschemetags"></a>
# **GetLocationAddressSchemeTags**
> void GetLocationAddressSchemeTags (int? locationAddressSchemeId)

Get the tags for a locationAddressScheme.

Get all existing locationAddressScheme tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationAddressSchemeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var locationAddressSchemeId = 56;  // int? | Id of the locationAddressScheme to get tags for

            try
            {
                // Get the tags for a locationAddressScheme.
                apiInstance.GetLocationAddressSchemeTags(locationAddressSchemeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.GetLocationAddressSchemeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAddressSchemeId** | **int?**| Id of the locationAddressScheme to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationaddressscheme"></a>
# **UpdateLocationAddressScheme**
> void UpdateLocationAddressScheme (LocationAddressScheme body)

Update a locationAddressScheme

Updates an existing locationAddressScheme using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationAddressSchemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var body = new LocationAddressScheme(); // LocationAddressScheme | LocationAddressScheme to be updated.

            try
            {
                // Update a locationAddressScheme
                apiInstance.UpdateLocationAddressScheme(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.UpdateLocationAddressScheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationAddressScheme**](LocationAddressScheme.md)| LocationAddressScheme to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationaddressschemecustomfields"></a>
# **UpdateLocationAddressSchemeCustomFields**
> void UpdateLocationAddressSchemeCustomFields (LocationAddressScheme body)

Update a locationAddressScheme custom fields

Updates an existing locationAddressScheme custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationAddressSchemeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationAddressSchemeApi();
            var body = new LocationAddressScheme(); // LocationAddressScheme | LocationAddressScheme to be updated.

            try
            {
                // Update a locationAddressScheme custom fields
                apiInstance.UpdateLocationAddressSchemeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAddressSchemeApi.UpdateLocationAddressSchemeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationAddressScheme**](LocationAddressScheme.md)| LocationAddressScheme to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

