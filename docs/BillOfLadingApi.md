# Infoplus.Api.BillOfLadingApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillOfLading**](BillOfLadingApi.md#addbilloflading) | **POST** /beta/billOfLading | Create a billOfLading
[**DeleteBillOfLading**](BillOfLadingApi.md#deletebilloflading) | **DELETE** /beta/billOfLading/{billOfLadingId} | Delete a billOfLading
[**GetBillOfLadingByFilter**](BillOfLadingApi.md#getbillofladingbyfilter) | **GET** /beta/billOfLading/search | Search billOfLadings by filter
[**GetBillOfLadingById**](BillOfLadingApi.md#getbillofladingbyid) | **GET** /beta/billOfLading/{billOfLadingId} | Get a billOfLading by id
[**UpdateBillOfLading**](BillOfLadingApi.md#updatebilloflading) | **PUT** /beta/billOfLading | Update a billOfLading
[**UpdateBillOfLadingCustomFields**](BillOfLadingApi.md#updatebillofladingcustomfields) | **PUT** /beta/billOfLading/customFields | Update a billOfLading custom fields


<a name="addbilloflading"></a>
# **AddBillOfLading**
> BillOfLading AddBillOfLading (BillOfLading body)

Create a billOfLading

Inserts a new billOfLading using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillOfLadingExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new BillOfLading(); // BillOfLading | BillOfLading to be inserted.

            try
            {
                // Create a billOfLading
                BillOfLading result = apiInstance.AddBillOfLading(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.AddBillOfLading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfLading**](BillOfLading.md)| BillOfLading to be inserted. | 

### Return type

[**BillOfLading**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebilloflading"></a>
# **DeleteBillOfLading**
> void DeleteBillOfLading (int? billOfLadingId)

Delete a billOfLading

Deletes the billOfLading identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillOfLadingExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to be deleted.

            try
            {
                // Delete a billOfLading
                apiInstance.DeleteBillOfLading(billOfLadingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.DeleteBillOfLading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillofladingbyfilter"></a>
# **GetBillOfLadingByFilter**
> List<BillOfLading> GetBillOfLadingByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billOfLadings by filter

Returns the list of billOfLadings that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillOfLadingByFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billOfLadings by filter
                List&lt;BillOfLading&gt; result = apiInstance.GetBillOfLadingByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetBillOfLadingByFilter: " + e.Message );
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

[**List<BillOfLading>**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillofladingbyid"></a>
# **GetBillOfLadingById**
> BillOfLading GetBillOfLadingById (int? billOfLadingId)

Get a billOfLading by id

Returns the billOfLading identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillOfLadingByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to be returned.

            try
            {
                // Get a billOfLading by id
                BillOfLading result = apiInstance.GetBillOfLadingById(billOfLadingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetBillOfLadingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to be returned. | 

### Return type

[**BillOfLading**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebilloflading"></a>
# **UpdateBillOfLading**
> void UpdateBillOfLading (BillOfLading body)

Update a billOfLading

Updates an existing billOfLading using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillOfLadingExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new BillOfLading(); // BillOfLading | BillOfLading to be updated.

            try
            {
                // Update a billOfLading
                apiInstance.UpdateBillOfLading(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.UpdateBillOfLading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfLading**](BillOfLading.md)| BillOfLading to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillofladingcustomfields"></a>
# **UpdateBillOfLadingCustomFields**
> void UpdateBillOfLadingCustomFields (BillOfLading body)

Update a billOfLading custom fields

Updates an existing billOfLading custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillOfLadingCustomFieldsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new BillOfLading(); // BillOfLading | BillOfLading to be updated.

            try
            {
                // Update a billOfLading custom fields
                apiInstance.UpdateBillOfLadingCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.UpdateBillOfLadingCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfLading**](BillOfLading.md)| BillOfLading to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

