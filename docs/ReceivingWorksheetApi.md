# Infoplus.Api.ReceivingWorksheetApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReceivingWorksheet**](ReceivingWorksheetApi.md#addreceivingworksheet) | **POST** /v1.0/receivingWorksheet | Create a receivingWorksheet
[**DeleteReceivingWorksheet**](ReceivingWorksheetApi.md#deletereceivingworksheet) | **DELETE** /v1.0/receivingWorksheet/{receivingWorksheetId} | Delete a receivingWorksheet
[**GetReceivingWorksheetByFilter**](ReceivingWorksheetApi.md#getreceivingworksheetbyfilter) | **GET** /v1.0/receivingWorksheet/search | Search receivingWorksheets by filter
[**GetReceivingWorksheetById**](ReceivingWorksheetApi.md#getreceivingworksheetbyid) | **GET** /v1.0/receivingWorksheet/{receivingWorksheetId} | Get a receivingWorksheet by id
[**UpdateReceivingWorksheet**](ReceivingWorksheetApi.md#updatereceivingworksheet) | **PUT** /v1.0/receivingWorksheet | Update a receivingWorksheet


# **AddReceivingWorksheet**
> ReceivingWorksheet AddReceivingWorksheet (ReceivingWorksheet body)

Create a receivingWorksheet

Inserts a new receivingWorksheet using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingWorksheetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReceivingWorksheetApi();
            var body = new ReceivingWorksheet(); // ReceivingWorksheet | ReceivingWorksheet to be inserted.

            try
            {
                // Create a receivingWorksheet
                ReceivingWorksheet result = apiInstance.AddReceivingWorksheet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.AddReceivingWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReceivingWorksheet**](ReceivingWorksheet.md)| ReceivingWorksheet to be inserted. | 

### Return type

[**ReceivingWorksheet**](ReceivingWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DeleteReceivingWorksheet**
> void DeleteReceivingWorksheet (int? receivingWorksheetId)

Delete a receivingWorksheet

Deletes the receivingWorksheet identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReceivingWorksheetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to be deleted.

            try
            {
                // Delete a receivingWorksheet
                apiInstance.DeleteReceivingWorksheet(receivingWorksheetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.DeleteReceivingWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetReceivingWorksheetByFilter**
> List<ReceivingWorksheet> GetReceivingWorksheetByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search receivingWorksheets by filter

Returns the list of receivingWorksheets that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingWorksheetByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReceivingWorksheetApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search receivingWorksheets by filter
                List&lt;ReceivingWorksheet&gt; result = apiInstance.GetReceivingWorksheetByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.GetReceivingWorksheetByFilter: " + e.Message );
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

[**List<ReceivingWorksheet>**](ReceivingWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetReceivingWorksheetById**
> ReceivingWorksheet GetReceivingWorksheetById (int? receivingWorksheetId)

Get a receivingWorksheet by id

Returns the receivingWorksheet identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingWorksheetByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to be returned.

            try
            {
                // Get a receivingWorksheet by id
                ReceivingWorksheet result = apiInstance.GetReceivingWorksheetById(receivingWorksheetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.GetReceivingWorksheetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to be returned. | 

### Return type

[**ReceivingWorksheet**](ReceivingWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **UpdateReceivingWorksheet**
> void UpdateReceivingWorksheet (ReceivingWorksheet body)

Update a receivingWorksheet

Updates an existing receivingWorksheet using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReceivingWorksheetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add('API-Key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('API-Key', 'Bearer');

            var apiInstance = new ReceivingWorksheetApi();
            var body = new ReceivingWorksheet(); // ReceivingWorksheet | ReceivingWorksheet to be updated.

            try
            {
                // Update a receivingWorksheet
                apiInstance.UpdateReceivingWorksheet(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.UpdateReceivingWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReceivingWorksheet**](ReceivingWorksheet.md)| ReceivingWorksheet to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

