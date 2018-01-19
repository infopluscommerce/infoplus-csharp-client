# Infoplus.Api.LocationApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocation**](LocationApi.md#addlocation) | **POST** /beta/location | Create a location
[**AddLocationAudit**](LocationApi.md#addlocationaudit) | **PUT** /beta/location/{locationId}/audit/{locationAudit} | Add new audit for a location
[**AddLocationTag**](LocationApi.md#addlocationtag) | **PUT** /beta/location/{locationId}/tag/{locationTag} | Add new tags for a location.
[**DeleteLocation**](LocationApi.md#deletelocation) | **DELETE** /beta/location/{locationId} | Delete a location
[**DeleteLocationTag**](LocationApi.md#deletelocationtag) | **DELETE** /beta/location/{locationId}/tag/{locationTag} | Delete a tag for a location.
[**GetDuplicateLocationById**](LocationApi.md#getduplicatelocationbyid) | **GET** /beta/location/duplicate/{locationId} | Get a duplicated a location by id
[**GetLocationByFilter**](LocationApi.md#getlocationbyfilter) | **GET** /beta/location/search | Search locations by filter
[**GetLocationById**](LocationApi.md#getlocationbyid) | **GET** /beta/location/{locationId} | Get a location by id
[**GetLocationTags**](LocationApi.md#getlocationtags) | **GET** /beta/location/{locationId}/tag | Get the tags for a location.
[**UpdateLocation**](LocationApi.md#updatelocation) | **PUT** /beta/location | Update a location
[**UpdateLocationCustomFields**](LocationApi.md#updatelocationcustomfields) | **PUT** /beta/location/customFields | Update a location custom fields


<a name="addlocation"></a>
# **AddLocation**
> Location AddLocation (Location body)

Create a location

Inserts a new location using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var body = new Location(); // Location | Location to be inserted.

            try
            {
                // Create a location
                Location result = apiInstance.AddLocation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.AddLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)| Location to be inserted. | 

### Return type

[**Location**](Location.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationaudit"></a>
# **AddLocationAudit**
> void AddLocationAudit (int? locationId, string locationAudit)

Add new audit for a location

Adds an audit to an existing location.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to add an audit to
            var locationAudit = locationAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a location
                apiInstance.AddLocationAudit(locationId, locationAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.AddLocationAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to add an audit to | 
 **locationAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlocationtag"></a>
# **AddLocationTag**
> void AddLocationTag (int? locationId, string locationTag)

Add new tags for a location.

Adds a tag to an existing location.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to add a tag to
            var locationTag = locationTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a location.
                apiInstance.AddLocationTag(locationId, locationTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.AddLocationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to add a tag to | 
 **locationTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocation"></a>
# **DeleteLocation**
> void DeleteLocation (int? locationId)

Delete a location

Deletes the location identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to be deleted.

            try
            {
                // Delete a location
                apiInstance.DeleteLocation(locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.DeleteLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationtag"></a>
# **DeleteLocationTag**
> void DeleteLocationTag (int? locationId, string locationTag)

Delete a tag for a location.

Deletes an existing location tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to remove tag from
            var locationTag = locationTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a location.
                apiInstance.DeleteLocationTag(locationId, locationTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.DeleteLocationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to remove tag from | 
 **locationTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatelocationbyid"></a>
# **GetDuplicateLocationById**
> Location GetDuplicateLocationById (int? locationId)

Get a duplicated a location by id

Returns a duplicated location identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLocationByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to be duplicated.

            try
            {
                // Get a duplicated a location by id
                Location result = apiInstance.GetDuplicateLocationById(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetDuplicateLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to be duplicated. | 

### Return type

[**Location**](Location.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationbyfilter"></a>
# **GetLocationByFilter**
> List<Location> GetLocationByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search locations by filter

Returns the list of locations that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search locations by filter
                List&lt;Location&gt; result = apiInstance.GetLocationByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetLocationByFilter: " + e.Message );
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

[**List<Location>**](Location.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationbyid"></a>
# **GetLocationById**
> Location GetLocationById (int? locationId)

Get a location by id

Returns the location identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to be returned.

            try
            {
                // Get a location by id
                Location result = apiInstance.GetLocationById(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to be returned. | 

### Return type

[**Location**](Location.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationtags"></a>
# **GetLocationTags**
> void GetLocationTags (int? locationId)

Get the tags for a location.

Get all existing location tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the location to get tags for

            try
            {
                // Get the tags for a location.
                apiInstance.GetLocationTags(locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetLocationTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the location to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocation"></a>
# **UpdateLocation**
> void UpdateLocation (Location body)

Update a location

Updates an existing location using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var body = new Location(); // Location | Location to be updated.

            try
            {
                // Update a location
                apiInstance.UpdateLocation(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.UpdateLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)| Location to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationcustomfields"></a>
# **UpdateLocationCustomFields**
> void UpdateLocationCustomFields (Location body)

Update a location custom fields

Updates an existing location custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LocationApi();
            var body = new Location(); // Location | Location to be updated.

            try
            {
                // Update a location custom fields
                apiInstance.UpdateLocationCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.UpdateLocationCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)| Location to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

