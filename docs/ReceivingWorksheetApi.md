# Infoplus.Api.ReceivingWorksheetApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReceivingWorksheet**](ReceivingWorksheetApi.md#addreceivingworksheet) | **POST** /beta/receivingWorksheet | Create a receivingWorksheet
[**AddReceivingWorksheetAudit**](ReceivingWorksheetApi.md#addreceivingworksheetaudit) | **PUT** /beta/receivingWorksheet/{receivingWorksheetId}/audit/{receivingWorksheetAudit} | Add new audit for a receivingWorksheet
[**AddReceivingWorksheetTag**](ReceivingWorksheetApi.md#addreceivingworksheettag) | **PUT** /beta/receivingWorksheet/{receivingWorksheetId}/tag/{receivingWorksheetTag} | Add new tags for a receivingWorksheet.
[**DeleteReceivingWorksheet**](ReceivingWorksheetApi.md#deletereceivingworksheet) | **DELETE** /beta/receivingWorksheet/{receivingWorksheetId} | Delete a receivingWorksheet
[**DeleteReceivingWorksheetTag**](ReceivingWorksheetApi.md#deletereceivingworksheettag) | **DELETE** /beta/receivingWorksheet/{receivingWorksheetId}/tag/{receivingWorksheetTag} | Delete a tag for a receivingWorksheet.
[**GetDuplicateReceivingWorksheetById**](ReceivingWorksheetApi.md#getduplicatereceivingworksheetbyid) | **GET** /beta/receivingWorksheet/duplicate/{receivingWorksheetId} | Get a duplicated a receivingWorksheet by id
[**GetReceivingWorksheetByFilter**](ReceivingWorksheetApi.md#getreceivingworksheetbyfilter) | **GET** /beta/receivingWorksheet/search | Search receivingWorksheets by filter
[**GetReceivingWorksheetById**](ReceivingWorksheetApi.md#getreceivingworksheetbyid) | **GET** /beta/receivingWorksheet/{receivingWorksheetId} | Get a receivingWorksheet by id
[**GetReceivingWorksheetTags**](ReceivingWorksheetApi.md#getreceivingworksheettags) | **GET** /beta/receivingWorksheet/{receivingWorksheetId}/tag | Get the tags for a receivingWorksheet.
[**UpdateReceivingWorksheet**](ReceivingWorksheetApi.md#updatereceivingworksheet) | **PUT** /beta/receivingWorksheet | Update a receivingWorksheet
[**UpdateReceivingWorksheetCustomFields**](ReceivingWorksheetApi.md#updatereceivingworksheetcustomfields) | **PUT** /beta/receivingWorksheet/customFields | Update a receivingWorksheet custom fields


<a name="addreceivingworksheet"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="addreceivingworksheetaudit"></a>
# **AddReceivingWorksheetAudit**
> void AddReceivingWorksheetAudit (int? receivingWorksheetId, string receivingWorksheetAudit)

Add new audit for a receivingWorksheet

Adds an audit to an existing receivingWorksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingWorksheetAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to add an audit to
            var receivingWorksheetAudit = receivingWorksheetAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a receivingWorksheet
                apiInstance.AddReceivingWorksheetAudit(receivingWorksheetId, receivingWorksheetAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.AddReceivingWorksheetAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to add an audit to | 
 **receivingWorksheetAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreceivingworksheettag"></a>
# **AddReceivingWorksheetTag**
> void AddReceivingWorksheetTag (int? receivingWorksheetId, string receivingWorksheetTag)

Add new tags for a receivingWorksheet.

Adds a tag to an existing receivingWorksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReceivingWorksheetTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to add a tag to
            var receivingWorksheetTag = receivingWorksheetTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a receivingWorksheet.
                apiInstance.AddReceivingWorksheetTag(receivingWorksheetId, receivingWorksheetTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.AddReceivingWorksheetTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to add a tag to | 
 **receivingWorksheetTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereceivingworksheet"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="deletereceivingworksheettag"></a>
# **DeleteReceivingWorksheetTag**
> void DeleteReceivingWorksheetTag (int? receivingWorksheetId, string receivingWorksheetTag)

Delete a tag for a receivingWorksheet.

Deletes an existing receivingWorksheet tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReceivingWorksheetTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to remove tag from
            var receivingWorksheetTag = receivingWorksheetTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a receivingWorksheet.
                apiInstance.DeleteReceivingWorksheetTag(receivingWorksheetId, receivingWorksheetTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.DeleteReceivingWorksheetTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to remove tag from | 
 **receivingWorksheetTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereceivingworksheetbyid"></a>
# **GetDuplicateReceivingWorksheetById**
> ReceivingWorksheet GetDuplicateReceivingWorksheetById (int? receivingWorksheetId)

Get a duplicated a receivingWorksheet by id

Returns a duplicated receivingWorksheet identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReceivingWorksheetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to be duplicated.

            try
            {
                // Get a duplicated a receivingWorksheet by id
                ReceivingWorksheet result = apiInstance.GetDuplicateReceivingWorksheetById(receivingWorksheetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.GetDuplicateReceivingWorksheetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to be duplicated. | 

### Return type

[**ReceivingWorksheet**](ReceivingWorksheet.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivingworksheetbyfilter"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getreceivingworksheetbyid"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="getreceivingworksheettags"></a>
# **GetReceivingWorksheetTags**
> void GetReceivingWorksheetTags (int? receivingWorksheetId)

Get the tags for a receivingWorksheet.

Get all existing receivingWorksheet tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReceivingWorksheetTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingWorksheetApi();
            var receivingWorksheetId = 56;  // int? | Id of the receivingWorksheet to get tags for

            try
            {
                // Get the tags for a receivingWorksheet.
                apiInstance.GetReceivingWorksheetTags(receivingWorksheetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.GetReceivingWorksheetTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receivingWorksheetId** | **int?**| Id of the receivingWorksheet to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereceivingworksheet"></a>
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
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

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

<a name="updatereceivingworksheetcustomfields"></a>
# **UpdateReceivingWorksheetCustomFields**
> void UpdateReceivingWorksheetCustomFields (ReceivingWorksheet body)

Update a receivingWorksheet custom fields

Updates an existing receivingWorksheet custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReceivingWorksheetCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReceivingWorksheetApi();
            var body = new ReceivingWorksheet(); // ReceivingWorksheet | ReceivingWorksheet to be updated.

            try
            {
                // Update a receivingWorksheet custom fields
                apiInstance.UpdateReceivingWorksheetCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceivingWorksheetApi.UpdateReceivingWorksheetCustomFields: " + e.Message );
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

