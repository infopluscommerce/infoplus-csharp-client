# Infoplus.Api.ExternalShippingSystemApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddExternalShippingSystem**](ExternalShippingSystemApi.md#addexternalshippingsystem) | **POST** /beta/externalShippingSystem | Create an externalShippingSystem
[**AddExternalShippingSystemAudit**](ExternalShippingSystemApi.md#addexternalshippingsystemaudit) | **PUT** /beta/externalShippingSystem/{externalShippingSystemId}/audit/{externalShippingSystemAudit} | Add new audit for an externalShippingSystem
[**AddExternalShippingSystemTag**](ExternalShippingSystemApi.md#addexternalshippingsystemtag) | **PUT** /beta/externalShippingSystem/{externalShippingSystemId}/tag/{externalShippingSystemTag} | Add new tags for an externalShippingSystem.
[**DeleteExternalShippingSystem**](ExternalShippingSystemApi.md#deleteexternalshippingsystem) | **DELETE** /beta/externalShippingSystem/{externalShippingSystemId} | Delete an externalShippingSystem
[**DeleteExternalShippingSystemTag**](ExternalShippingSystemApi.md#deleteexternalshippingsystemtag) | **DELETE** /beta/externalShippingSystem/{externalShippingSystemId}/tag/{externalShippingSystemTag} | Delete a tag for an externalShippingSystem.
[**GetDuplicateExternalShippingSystemById**](ExternalShippingSystemApi.md#getduplicateexternalshippingsystembyid) | **GET** /beta/externalShippingSystem/duplicate/{externalShippingSystemId} | Get a duplicated an externalShippingSystem by id
[**GetExternalShippingSystemByFilter**](ExternalShippingSystemApi.md#getexternalshippingsystembyfilter) | **GET** /beta/externalShippingSystem/search | Search externalShippingSystems by filter
[**GetExternalShippingSystemById**](ExternalShippingSystemApi.md#getexternalshippingsystembyid) | **GET** /beta/externalShippingSystem/{externalShippingSystemId} | Get an externalShippingSystem by id
[**GetExternalShippingSystemTags**](ExternalShippingSystemApi.md#getexternalshippingsystemtags) | **GET** /beta/externalShippingSystem/{externalShippingSystemId}/tag | Get the tags for an externalShippingSystem.
[**UpdateExternalShippingSystem**](ExternalShippingSystemApi.md#updateexternalshippingsystem) | **PUT** /beta/externalShippingSystem | Update an externalShippingSystem
[**UpdateExternalShippingSystemCustomFields**](ExternalShippingSystemApi.md#updateexternalshippingsystemcustomfields) | **PUT** /beta/externalShippingSystem/customFields | Update an externalShippingSystem custom fields


<a name="addexternalshippingsystem"></a>
# **AddExternalShippingSystem**
> ExternalShippingSystem AddExternalShippingSystem (ExternalShippingSystem body)

Create an externalShippingSystem

Inserts a new externalShippingSystem using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShippingSystemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var body = new ExternalShippingSystem(); // ExternalShippingSystem | ExternalShippingSystem to be inserted.

            try
            {
                // Create an externalShippingSystem
                ExternalShippingSystem result = apiInstance.AddExternalShippingSystem(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.AddExternalShippingSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShippingSystem**](ExternalShippingSystem.md)| ExternalShippingSystem to be inserted. | 

### Return type

[**ExternalShippingSystem**](ExternalShippingSystem.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexternalshippingsystemaudit"></a>
# **AddExternalShippingSystemAudit**
> void AddExternalShippingSystemAudit (int? externalShippingSystemId, string externalShippingSystemAudit)

Add new audit for an externalShippingSystem

Adds an audit to an existing externalShippingSystem.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShippingSystemAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to add an audit to
            var externalShippingSystemAudit = externalShippingSystemAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an externalShippingSystem
                apiInstance.AddExternalShippingSystemAudit(externalShippingSystemId, externalShippingSystemAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.AddExternalShippingSystemAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to add an audit to | 
 **externalShippingSystemAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexternalshippingsystemtag"></a>
# **AddExternalShippingSystemTag**
> void AddExternalShippingSystemTag (int? externalShippingSystemId, string externalShippingSystemTag)

Add new tags for an externalShippingSystem.

Adds a tag to an existing externalShippingSystem.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddExternalShippingSystemTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to add a tag to
            var externalShippingSystemTag = externalShippingSystemTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an externalShippingSystem.
                apiInstance.AddExternalShippingSystemTag(externalShippingSystemId, externalShippingSystemTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.AddExternalShippingSystemTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to add a tag to | 
 **externalShippingSystemTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexternalshippingsystem"></a>
# **DeleteExternalShippingSystem**
> void DeleteExternalShippingSystem (int? externalShippingSystemId)

Delete an externalShippingSystem

Deletes the externalShippingSystem identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteExternalShippingSystemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to be deleted.

            try
            {
                // Delete an externalShippingSystem
                apiInstance.DeleteExternalShippingSystem(externalShippingSystemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.DeleteExternalShippingSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexternalshippingsystemtag"></a>
# **DeleteExternalShippingSystemTag**
> void DeleteExternalShippingSystemTag (int? externalShippingSystemId, string externalShippingSystemTag)

Delete a tag for an externalShippingSystem.

Deletes an existing externalShippingSystem tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteExternalShippingSystemTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to remove tag from
            var externalShippingSystemTag = externalShippingSystemTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an externalShippingSystem.
                apiInstance.DeleteExternalShippingSystemTag(externalShippingSystemId, externalShippingSystemTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.DeleteExternalShippingSystemTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to remove tag from | 
 **externalShippingSystemTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateexternalshippingsystembyid"></a>
# **GetDuplicateExternalShippingSystemById**
> ExternalShippingSystem GetDuplicateExternalShippingSystemById (int? externalShippingSystemId)

Get a duplicated an externalShippingSystem by id

Returns a duplicated externalShippingSystem identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateExternalShippingSystemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to be duplicated.

            try
            {
                // Get a duplicated an externalShippingSystem by id
                ExternalShippingSystem result = apiInstance.GetDuplicateExternalShippingSystemById(externalShippingSystemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.GetDuplicateExternalShippingSystemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to be duplicated. | 

### Return type

[**ExternalShippingSystem**](ExternalShippingSystem.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshippingsystembyfilter"></a>
# **GetExternalShippingSystemByFilter**
> List<ExternalShippingSystem> GetExternalShippingSystemByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search externalShippingSystems by filter

Returns the list of externalShippingSystems that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShippingSystemByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search externalShippingSystems by filter
                List&lt;ExternalShippingSystem&gt; result = apiInstance.GetExternalShippingSystemByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.GetExternalShippingSystemByFilter: " + e.Message );
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

[**List<ExternalShippingSystem>**](ExternalShippingSystem.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshippingsystembyid"></a>
# **GetExternalShippingSystemById**
> ExternalShippingSystem GetExternalShippingSystemById (int? externalShippingSystemId)

Get an externalShippingSystem by id

Returns the externalShippingSystem identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShippingSystemByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to be returned.

            try
            {
                // Get an externalShippingSystem by id
                ExternalShippingSystem result = apiInstance.GetExternalShippingSystemById(externalShippingSystemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.GetExternalShippingSystemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to be returned. | 

### Return type

[**ExternalShippingSystem**](ExternalShippingSystem.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalshippingsystemtags"></a>
# **GetExternalShippingSystemTags**
> void GetExternalShippingSystemTags (int? externalShippingSystemId)

Get the tags for an externalShippingSystem.

Get all existing externalShippingSystem tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetExternalShippingSystemTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var externalShippingSystemId = 56;  // int? | Id of the externalShippingSystem to get tags for

            try
            {
                // Get the tags for an externalShippingSystem.
                apiInstance.GetExternalShippingSystemTags(externalShippingSystemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.GetExternalShippingSystemTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShippingSystemId** | **int?**| Id of the externalShippingSystem to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexternalshippingsystem"></a>
# **UpdateExternalShippingSystem**
> void UpdateExternalShippingSystem (ExternalShippingSystem body)

Update an externalShippingSystem

Updates an existing externalShippingSystem using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateExternalShippingSystemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var body = new ExternalShippingSystem(); // ExternalShippingSystem | ExternalShippingSystem to be updated.

            try
            {
                // Update an externalShippingSystem
                apiInstance.UpdateExternalShippingSystem(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.UpdateExternalShippingSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShippingSystem**](ExternalShippingSystem.md)| ExternalShippingSystem to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexternalshippingsystemcustomfields"></a>
# **UpdateExternalShippingSystemCustomFields**
> void UpdateExternalShippingSystemCustomFields (ExternalShippingSystem body)

Update an externalShippingSystem custom fields

Updates an existing externalShippingSystem custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateExternalShippingSystemCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ExternalShippingSystemApi();
            var body = new ExternalShippingSystem(); // ExternalShippingSystem | ExternalShippingSystem to be updated.

            try
            {
                // Update an externalShippingSystem custom fields
                apiInstance.UpdateExternalShippingSystemCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalShippingSystemApi.UpdateExternalShippingSystemCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalShippingSystem**](ExternalShippingSystem.md)| ExternalShippingSystem to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

