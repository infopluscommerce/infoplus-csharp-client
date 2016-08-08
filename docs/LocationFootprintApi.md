# Infoplus.Api.LocationFootprintApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocationFootprint**](LocationFootprintApi.md#addlocationfootprint) | **POST** /beta/locationFootprint | Create a locationFootprint
[**DeleteLocationFootprint**](LocationFootprintApi.md#deletelocationfootprint) | **DELETE** /beta/locationFootprint/{locationFootprintId} | Delete a locationFootprint
[**GetLocationFootprintByFilter**](LocationFootprintApi.md#getlocationfootprintbyfilter) | **GET** /beta/locationFootprint/search | Search locationFootprints by filter
[**GetLocationFootprintById**](LocationFootprintApi.md#getlocationfootprintbyid) | **GET** /beta/locationFootprint/{locationFootprintId} | Get a locationFootprint by id
[**UpdateLocationFootprint**](LocationFootprintApi.md#updatelocationfootprint) | **PUT** /beta/locationFootprint | Update a locationFootprint
[**UpdateLocationFootprintCustomFields**](LocationFootprintApi.md#updatelocationfootprintcustomfields) | **PUT** /beta/locationFootprint/customFields | Update a locationFootprint custom fields


<a name="addlocationfootprint"></a>
# **AddLocationFootprint**
> LocationFootprint AddLocationFootprint (LocationFootprint body)

Create a locationFootprint

Inserts a new locationFootprint using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLocationFootprintExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LocationFootprintApi();
            var body = new LocationFootprint(); // LocationFootprint | LocationFootprint to be inserted.

            try
            {
                // Create a locationFootprint
                LocationFootprint result = apiInstance.AddLocationFootprint(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationFootprintApi.AddLocationFootprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationFootprint**](LocationFootprint.md)| LocationFootprint to be inserted. | 

### Return type

[**LocationFootprint**](LocationFootprint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocationfootprint"></a>
# **DeleteLocationFootprint**
> void DeleteLocationFootprint (int? locationFootprintId)

Delete a locationFootprint

Deletes the locationFootprint identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLocationFootprintExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LocationFootprintApi();
            var locationFootprintId = 56;  // int? | Id of the locationFootprint to be deleted.

            try
            {
                // Delete a locationFootprint
                apiInstance.DeleteLocationFootprint(locationFootprintId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationFootprintApi.DeleteLocationFootprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationFootprintId** | **int?**| Id of the locationFootprint to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationfootprintbyfilter"></a>
# **GetLocationFootprintByFilter**
> List<LocationFootprint> GetLocationFootprintByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search locationFootprints by filter

Returns the list of locationFootprints that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationFootprintByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LocationFootprintApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search locationFootprints by filter
                List&lt;LocationFootprint&gt; result = apiInstance.GetLocationFootprintByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationFootprintApi.GetLocationFootprintByFilter: " + e.Message );
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

[**List<LocationFootprint>**](LocationFootprint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationfootprintbyid"></a>
# **GetLocationFootprintById**
> LocationFootprint GetLocationFootprintById (int? locationFootprintId)

Get a locationFootprint by id

Returns the locationFootprint identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLocationFootprintByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LocationFootprintApi();
            var locationFootprintId = 56;  // int? | Id of the locationFootprint to be returned.

            try
            {
                // Get a locationFootprint by id
                LocationFootprint result = apiInstance.GetLocationFootprintById(locationFootprintId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationFootprintApi.GetLocationFootprintById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationFootprintId** | **int?**| Id of the locationFootprint to be returned. | 

### Return type

[**LocationFootprint**](LocationFootprint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationfootprint"></a>
# **UpdateLocationFootprint**
> void UpdateLocationFootprint (LocationFootprint body)

Update a locationFootprint

Updates an existing locationFootprint using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationFootprintExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LocationFootprintApi();
            var body = new LocationFootprint(); // LocationFootprint | LocationFootprint to be updated.

            try
            {
                // Update a locationFootprint
                apiInstance.UpdateLocationFootprint(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationFootprintApi.UpdateLocationFootprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationFootprint**](LocationFootprint.md)| LocationFootprint to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationfootprintcustomfields"></a>
# **UpdateLocationFootprintCustomFields**
> void UpdateLocationFootprintCustomFields (LocationFootprint body)

Update a locationFootprint custom fields

Updates an existing locationFootprint custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLocationFootprintCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new LocationFootprintApi();
            var body = new LocationFootprint(); // LocationFootprint | LocationFootprint to be updated.

            try
            {
                // Update a locationFootprint custom fields
                apiInstance.UpdateLocationFootprintCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationFootprintApi.UpdateLocationFootprintCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LocationFootprint**](LocationFootprint.md)| LocationFootprint to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

