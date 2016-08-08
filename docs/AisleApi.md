# Infoplus.Api.AisleApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAisle**](AisleApi.md#addaisle) | **POST** /beta/aisle | Create an aisle
[**DeleteAisle**](AisleApi.md#deleteaisle) | **DELETE** /beta/aisle/{aisleId} | Delete an aisle
[**GetAisleByFilter**](AisleApi.md#getaislebyfilter) | **GET** /beta/aisle/search | Search aisles by filter
[**GetAisleById**](AisleApi.md#getaislebyid) | **GET** /beta/aisle/{aisleId} | Get an aisle by id
[**UpdateAisle**](AisleApi.md#updateaisle) | **PUT** /beta/aisle | Update an aisle
[**UpdateAisleCustomFields**](AisleApi.md#updateaislecustomfields) | **PUT** /beta/aisle/customFields | Update an aisle custom fields


<a name="addaisle"></a>
# **AddAisle**
> Aisle AddAisle (Aisle body)

Create an aisle

Inserts a new aisle using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddAisleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new AisleApi();
            var body = new Aisle(); // Aisle | Aisle to be inserted.

            try
            {
                // Create an aisle
                Aisle result = apiInstance.AddAisle(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.AddAisle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Aisle**](Aisle.md)| Aisle to be inserted. | 

### Return type

[**Aisle**](Aisle.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaisle"></a>
# **DeleteAisle**
> void DeleteAisle (int? aisleId)

Delete an aisle

Deletes the aisle identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteAisleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new AisleApi();
            var aisleId = 56;  // int? | Id of the aisle to be deleted.

            try
            {
                // Delete an aisle
                apiInstance.DeleteAisle(aisleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.DeleteAisle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aisleId** | **int?**| Id of the aisle to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaislebyfilter"></a>
# **GetAisleByFilter**
> List<Aisle> GetAisleByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search aisles by filter

Returns the list of aisles that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAisleByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new AisleApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search aisles by filter
                List&lt;Aisle&gt; result = apiInstance.GetAisleByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.GetAisleByFilter: " + e.Message );
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

[**List<Aisle>**](Aisle.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaislebyid"></a>
# **GetAisleById**
> Aisle GetAisleById (int? aisleId)

Get an aisle by id

Returns the aisle identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAisleByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new AisleApi();
            var aisleId = 56;  // int? | Id of the aisle to be returned.

            try
            {
                // Get an aisle by id
                Aisle result = apiInstance.GetAisleById(aisleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.GetAisleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aisleId** | **int?**| Id of the aisle to be returned. | 

### Return type

[**Aisle**](Aisle.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaisle"></a>
# **UpdateAisle**
> void UpdateAisle (Aisle body)

Update an aisle

Updates an existing aisle using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateAisleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new AisleApi();
            var body = new Aisle(); // Aisle | Aisle to be updated.

            try
            {
                // Update an aisle
                apiInstance.UpdateAisle(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.UpdateAisle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Aisle**](Aisle.md)| Aisle to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaislecustomfields"></a>
# **UpdateAisleCustomFields**
> void UpdateAisleCustomFields (Aisle body)

Update an aisle custom fields

Updates an existing aisle custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateAisleCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new AisleApi();
            var body = new Aisle(); // Aisle | Aisle to be updated.

            try
            {
                // Update an aisle custom fields
                apiInstance.UpdateAisleCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AisleApi.UpdateAisleCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Aisle**](Aisle.md)| Aisle to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

