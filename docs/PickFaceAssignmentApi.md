# Infoplus.Api.PickFaceAssignmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPickFaceAssignment**](PickFaceAssignmentApi.md#addpickfaceassignment) | **POST** /v1.0/pickFaceAssignment | Create a pickFaceAssignment
[**DeletePickFaceAssignment**](PickFaceAssignmentApi.md#deletepickfaceassignment) | **DELETE** /v1.0/pickFaceAssignment/{pickFaceAssignmentId} | Delete a pickFaceAssignment
[**GetPickFaceAssignmentByFilter**](PickFaceAssignmentApi.md#getpickfaceassignmentbyfilter) | **GET** /v1.0/pickFaceAssignment/search | Search pickFaceAssignments by filter
[**GetPickFaceAssignmentById**](PickFaceAssignmentApi.md#getpickfaceassignmentbyid) | **GET** /v1.0/pickFaceAssignment/{pickFaceAssignmentId} | Get a pickFaceAssignment by id
[**UpdatePickFaceAssignment**](PickFaceAssignmentApi.md#updatepickfaceassignment) | **PUT** /v1.0/pickFaceAssignment | Update a pickFaceAssignment


# **AddPickFaceAssignment**
> PickFaceAssignment AddPickFaceAssignment (PickFaceAssignment body)

Create a pickFaceAssignment

Inserts a new pickFaceAssignment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddPickFaceAssignmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new PickFaceAssignmentApi();
            var body = new PickFaceAssignment(); // PickFaceAssignment | PickFaceAssignment to be inserted.

            try
            {
                // Create a pickFaceAssignment
                PickFaceAssignment result = apiInstance.AddPickFaceAssignment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.AddPickFaceAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickFaceAssignment**](PickFaceAssignment.md)| PickFaceAssignment to be inserted. | 

### Return type

[**PickFaceAssignment**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeletePickFaceAssignment**
> void DeletePickFaceAssignment (int? pickFaceAssignmentId)

Delete a pickFaceAssignment

Deletes the pickFaceAssignment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeletePickFaceAssignmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to be deleted.

            try
            {
                // Delete a pickFaceAssignment
                apiInstance.DeletePickFaceAssignment(pickFaceAssignmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.DeletePickFaceAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetPickFaceAssignmentByFilter**
> List<PickFaceAssignment> GetPickFaceAssignmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search pickFaceAssignments by filter

Returns the list of pickFaceAssignments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPickFaceAssignmentByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new PickFaceAssignmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search pickFaceAssignments by filter
                List&lt;PickFaceAssignment&gt; result = apiInstance.GetPickFaceAssignmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetPickFaceAssignmentByFilter: " + e.Message );
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

[**List<PickFaceAssignment>**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetPickFaceAssignmentById**
> PickFaceAssignment GetPickFaceAssignmentById (int? pickFaceAssignmentId)

Get a pickFaceAssignment by id

Returns the pickFaceAssignment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetPickFaceAssignmentByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new PickFaceAssignmentApi();
            var pickFaceAssignmentId = 56;  // int? | Id of the pickFaceAssignment to be returned.

            try
            {
                // Get a pickFaceAssignment by id
                PickFaceAssignment result = apiInstance.GetPickFaceAssignmentById(pickFaceAssignmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.GetPickFaceAssignmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pickFaceAssignmentId** | **int?**| Id of the pickFaceAssignment to be returned. | 

### Return type

[**PickFaceAssignment**](PickFaceAssignment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdatePickFaceAssignment**
> void UpdatePickFaceAssignment (PickFaceAssignment body)

Update a pickFaceAssignment

Updates an existing pickFaceAssignment using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdatePickFaceAssignmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new PickFaceAssignmentApi();
            var body = new PickFaceAssignment(); // PickFaceAssignment | PickFaceAssignment to be updated.

            try
            {
                // Update a pickFaceAssignment
                apiInstance.UpdatePickFaceAssignment(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickFaceAssignmentApi.UpdatePickFaceAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickFaceAssignment**](PickFaceAssignment.md)| PickFaceAssignment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

