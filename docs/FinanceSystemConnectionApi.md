# Infoplus.Api.FinanceSystemConnectionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFinanceSystemConnection**](FinanceSystemConnectionApi.md#addfinancesystemconnection) | **POST** /beta/financeSystemConnection | Create a financeSystemConnection
[**AddFinanceSystemConnectionAudit**](FinanceSystemConnectionApi.md#addfinancesystemconnectionaudit) | **PUT** /beta/financeSystemConnection/{financeSystemConnectionId}/audit/{financeSystemConnectionAudit} | Add new audit for a financeSystemConnection
[**AddFinanceSystemConnectionTag**](FinanceSystemConnectionApi.md#addfinancesystemconnectiontag) | **PUT** /beta/financeSystemConnection/{financeSystemConnectionId}/tag/{financeSystemConnectionTag} | Add new tags for a financeSystemConnection.
[**DeleteFinanceSystemConnection**](FinanceSystemConnectionApi.md#deletefinancesystemconnection) | **DELETE** /beta/financeSystemConnection/{financeSystemConnectionId} | Delete a financeSystemConnection
[**DeleteFinanceSystemConnectionTag**](FinanceSystemConnectionApi.md#deletefinancesystemconnectiontag) | **DELETE** /beta/financeSystemConnection/{financeSystemConnectionId}/tag/{financeSystemConnectionTag} | Delete a tag for a financeSystemConnection.
[**GetDuplicateFinanceSystemConnectionById**](FinanceSystemConnectionApi.md#getduplicatefinancesystemconnectionbyid) | **GET** /beta/financeSystemConnection/duplicate/{financeSystemConnectionId} | Get a duplicated a financeSystemConnection by id
[**GetFinanceSystemConnectionByFilter**](FinanceSystemConnectionApi.md#getfinancesystemconnectionbyfilter) | **GET** /beta/financeSystemConnection/search | Search financeSystemConnections by filter
[**GetFinanceSystemConnectionById**](FinanceSystemConnectionApi.md#getfinancesystemconnectionbyid) | **GET** /beta/financeSystemConnection/{financeSystemConnectionId} | Get a financeSystemConnection by id
[**GetFinanceSystemConnectionTags**](FinanceSystemConnectionApi.md#getfinancesystemconnectiontags) | **GET** /beta/financeSystemConnection/{financeSystemConnectionId}/tag | Get the tags for a financeSystemConnection.
[**UpdateFinanceSystemConnection**](FinanceSystemConnectionApi.md#updatefinancesystemconnection) | **PUT** /beta/financeSystemConnection | Update a financeSystemConnection
[**UpdateFinanceSystemConnectionCustomFields**](FinanceSystemConnectionApi.md#updatefinancesystemconnectioncustomfields) | **PUT** /beta/financeSystemConnection/customFields | Update a financeSystemConnection custom fields


<a name="addfinancesystemconnection"></a>
# **AddFinanceSystemConnection**
> FinanceSystemConnection AddFinanceSystemConnection (FinanceSystemConnection body)

Create a financeSystemConnection

Inserts a new financeSystemConnection using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var body = new FinanceSystemConnection(); // FinanceSystemConnection | FinanceSystemConnection to be inserted.

            try
            {
                // Create a financeSystemConnection
                FinanceSystemConnection result = apiInstance.AddFinanceSystemConnection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.AddFinanceSystemConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinanceSystemConnection**](FinanceSystemConnection.md)| FinanceSystemConnection to be inserted. | 

### Return type

[**FinanceSystemConnection**](FinanceSystemConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfinancesystemconnectionaudit"></a>
# **AddFinanceSystemConnectionAudit**
> void AddFinanceSystemConnectionAudit (int? financeSystemConnectionId, string financeSystemConnectionAudit)

Add new audit for a financeSystemConnection

Adds an audit to an existing financeSystemConnection.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to add an audit to
            var financeSystemConnectionAudit = financeSystemConnectionAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a financeSystemConnection
                apiInstance.AddFinanceSystemConnectionAudit(financeSystemConnectionId, financeSystemConnectionAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.AddFinanceSystemConnectionAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to add an audit to | 
 **financeSystemConnectionAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfinancesystemconnectiontag"></a>
# **AddFinanceSystemConnectionTag**
> void AddFinanceSystemConnectionTag (int? financeSystemConnectionId, string financeSystemConnectionTag)

Add new tags for a financeSystemConnection.

Adds a tag to an existing financeSystemConnection.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddFinanceSystemConnectionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to add a tag to
            var financeSystemConnectionTag = financeSystemConnectionTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a financeSystemConnection.
                apiInstance.AddFinanceSystemConnectionTag(financeSystemConnectionId, financeSystemConnectionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.AddFinanceSystemConnectionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to add a tag to | 
 **financeSystemConnectionTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefinancesystemconnection"></a>
# **DeleteFinanceSystemConnection**
> void DeleteFinanceSystemConnection (int? financeSystemConnectionId)

Delete a financeSystemConnection

Deletes the financeSystemConnection identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFinanceSystemConnectionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to be deleted.

            try
            {
                // Delete a financeSystemConnection
                apiInstance.DeleteFinanceSystemConnection(financeSystemConnectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.DeleteFinanceSystemConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefinancesystemconnectiontag"></a>
# **DeleteFinanceSystemConnectionTag**
> void DeleteFinanceSystemConnectionTag (int? financeSystemConnectionId, string financeSystemConnectionTag)

Delete a tag for a financeSystemConnection.

Deletes an existing financeSystemConnection tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteFinanceSystemConnectionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to remove tag from
            var financeSystemConnectionTag = financeSystemConnectionTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a financeSystemConnection.
                apiInstance.DeleteFinanceSystemConnectionTag(financeSystemConnectionId, financeSystemConnectionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.DeleteFinanceSystemConnectionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to remove tag from | 
 **financeSystemConnectionTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatefinancesystemconnectionbyid"></a>
# **GetDuplicateFinanceSystemConnectionById**
> FinanceSystemConnection GetDuplicateFinanceSystemConnectionById (int? financeSystemConnectionId)

Get a duplicated a financeSystemConnection by id

Returns a duplicated financeSystemConnection identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateFinanceSystemConnectionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to be duplicated.

            try
            {
                // Get a duplicated a financeSystemConnection by id
                FinanceSystemConnection result = apiInstance.GetDuplicateFinanceSystemConnectionById(financeSystemConnectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.GetDuplicateFinanceSystemConnectionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to be duplicated. | 

### Return type

[**FinanceSystemConnection**](FinanceSystemConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectionbyfilter"></a>
# **GetFinanceSystemConnectionByFilter**
> List<FinanceSystemConnection> GetFinanceSystemConnectionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search financeSystemConnections by filter

Returns the list of financeSystemConnections that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search financeSystemConnections by filter
                List&lt;FinanceSystemConnection&gt; result = apiInstance.GetFinanceSystemConnectionByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.GetFinanceSystemConnectionByFilter: " + e.Message );
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

[**List<FinanceSystemConnection>**](FinanceSystemConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectionbyid"></a>
# **GetFinanceSystemConnectionById**
> FinanceSystemConnection GetFinanceSystemConnectionById (int? financeSystemConnectionId)

Get a financeSystemConnection by id

Returns the financeSystemConnection identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to be returned.

            try
            {
                // Get a financeSystemConnection by id
                FinanceSystemConnection result = apiInstance.GetFinanceSystemConnectionById(financeSystemConnectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.GetFinanceSystemConnectionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to be returned. | 

### Return type

[**FinanceSystemConnection**](FinanceSystemConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinancesystemconnectiontags"></a>
# **GetFinanceSystemConnectionTags**
> void GetFinanceSystemConnectionTags (int? financeSystemConnectionId)

Get the tags for a financeSystemConnection.

Get all existing financeSystemConnection tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetFinanceSystemConnectionTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var financeSystemConnectionId = 56;  // int? | Id of the financeSystemConnection to get tags for

            try
            {
                // Get the tags for a financeSystemConnection.
                apiInstance.GetFinanceSystemConnectionTags(financeSystemConnectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.GetFinanceSystemConnectionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financeSystemConnectionId** | **int?**| Id of the financeSystemConnection to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefinancesystemconnection"></a>
# **UpdateFinanceSystemConnection**
> void UpdateFinanceSystemConnection (FinanceSystemConnection body)

Update a financeSystemConnection

Updates an existing financeSystemConnection using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFinanceSystemConnectionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var body = new FinanceSystemConnection(); // FinanceSystemConnection | FinanceSystemConnection to be updated.

            try
            {
                // Update a financeSystemConnection
                apiInstance.UpdateFinanceSystemConnection(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.UpdateFinanceSystemConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinanceSystemConnection**](FinanceSystemConnection.md)| FinanceSystemConnection to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefinancesystemconnectioncustomfields"></a>
# **UpdateFinanceSystemConnectionCustomFields**
> void UpdateFinanceSystemConnectionCustomFields (FinanceSystemConnection body)

Update a financeSystemConnection custom fields

Updates an existing financeSystemConnection custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateFinanceSystemConnectionCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new FinanceSystemConnectionApi();
            var body = new FinanceSystemConnection(); // FinanceSystemConnection | FinanceSystemConnection to be updated.

            try
            {
                // Update a financeSystemConnection custom fields
                apiInstance.UpdateFinanceSystemConnectionCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FinanceSystemConnectionApi.UpdateFinanceSystemConnectionCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinanceSystemConnection**](FinanceSystemConnection.md)| FinanceSystemConnection to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

