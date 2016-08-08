# Infoplus.Api.ReceivingProcessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteReceivingProcess**](ReceivingProcessApi.md#deletereceivingprocess) | **DELETE** /beta/receivingProcess/{receivingProcessId} | Delete a receivingProcess
[**GetReceivingProcessByFilter**](ReceivingProcessApi.md#getreceivingprocessbyfilter) | **GET** /beta/receivingProcess/search | Search receivingProcesses by filter
[**GetReceivingProcessById**](ReceivingProcessApi.md#getreceivingprocessbyid) | **GET** /beta/receivingProcess/{receivingProcessId} | Get a receivingProcess by id
[**UpdateReceivingProcessCustomFields**](ReceivingProcessApi.md#updatereceivingprocesscustomfields) | **PUT** /beta/receivingProcess/customFields | Update a receivingProcess custom fields


<a name="deletereceivingprocess"></a>
# **DeleteReceivingProcess**
> void DeleteReceivingProcess (int? receivingProcessId)

Delete a receivingProcess

Deletes the receivingProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReceivingProcessExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to be deleted.

            try
            {
                // Delete a receivingProcess
                apiInstance.DeleteReceivingProcess(receivingProcessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.DeleteReceivingProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingprocessbyfilter"></a>
# **GetReceivingProcessByFilter**
> List<ReceivingProcess> GetReceivingProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search receivingProcesses by filter

Returns the list of receivingProcesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingProcessByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search receivingProcesses by filter
                List&lt;ReceivingProcess&gt; result = apiInstance.GetReceivingProcessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetReceivingProcessByFilter: " + e.Message );
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

[**List<ReceivingProcess>**](ReceivingProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingprocessbyid"></a>
# **GetReceivingProcessById**
> ReceivingProcess GetReceivingProcessById (int? receivingProcessId)

Get a receivingProcess by id

Returns the receivingProcess identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingProcessByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var receivingProcessId = 56;  // int? | Id of the receivingProcess to be returned.

            try
            {
                // Get a receivingProcess by id
                ReceivingProcess result = apiInstance.GetReceivingProcessById(receivingProcessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.GetReceivingProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingProcessId** | **int?**| Id of the receivingProcess to be returned. | 

### Return type

[**ReceivingProcess**](ReceivingProcess.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereceivingprocesscustomfields"></a>
# **UpdateReceivingProcessCustomFields**
> void UpdateReceivingProcessCustomFields (ReceivingProcess body)

Update a receivingProcess custom fields

Updates an existing receivingProcess custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReceivingProcessCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new ReceivingProcessApi();
            var body = new ReceivingProcess(); // ReceivingProcess | ReceivingProcess to be updated.

            try
            {
                // Update a receivingProcess custom fields
                apiInstance.UpdateReceivingProcessCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingProcessApi.UpdateReceivingProcessCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReceivingProcess**](ReceivingProcess.md)| ReceivingProcess to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

