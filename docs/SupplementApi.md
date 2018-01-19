# Infoplus.Api.SupplementApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSupplement**](SupplementApi.md#addsupplement) | **POST** /beta/supplement | Create a supplement
[**AddSupplementAudit**](SupplementApi.md#addsupplementaudit) | **PUT** /beta/supplement/{supplementId}/audit/{supplementAudit} | Add new audit for a supplement
[**AddSupplementTag**](SupplementApi.md#addsupplementtag) | **PUT** /beta/supplement/{supplementId}/tag/{supplementTag} | Add new tags for a supplement.
[**DeleteSupplement**](SupplementApi.md#deletesupplement) | **DELETE** /beta/supplement/{supplementId} | Delete a supplement
[**DeleteSupplementTag**](SupplementApi.md#deletesupplementtag) | **DELETE** /beta/supplement/{supplementId}/tag/{supplementTag} | Delete a tag for a supplement.
[**GetDuplicateSupplementById**](SupplementApi.md#getduplicatesupplementbyid) | **GET** /beta/supplement/duplicate/{supplementId} | Get a duplicated a supplement by id
[**GetSupplementByFilter**](SupplementApi.md#getsupplementbyfilter) | **GET** /beta/supplement/search | Search supplements by filter
[**GetSupplementById**](SupplementApi.md#getsupplementbyid) | **GET** /beta/supplement/{supplementId} | Get a supplement by id
[**GetSupplementTags**](SupplementApi.md#getsupplementtags) | **GET** /beta/supplement/{supplementId}/tag | Get the tags for a supplement.
[**UpdateSupplement**](SupplementApi.md#updatesupplement) | **PUT** /beta/supplement | Update a supplement
[**UpdateSupplementCustomFields**](SupplementApi.md#updatesupplementcustomfields) | **PUT** /beta/supplement/customFields | Update a supplement custom fields


<a name="addsupplement"></a>
# **AddSupplement**
> Supplement AddSupplement (Supplement body)

Create a supplement

Inserts a new supplement using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSupplementExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var body = new Supplement(); // Supplement | Supplement to be inserted.

            try
            {
                // Create a supplement
                Supplement result = apiInstance.AddSupplement(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.AddSupplement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Supplement**](Supplement.md)| Supplement to be inserted. | 

### Return type

[**Supplement**](Supplement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsupplementaudit"></a>
# **AddSupplementAudit**
> void AddSupplementAudit (int? supplementId, string supplementAudit)

Add new audit for a supplement

Adds an audit to an existing supplement.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSupplementAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to add an audit to
            var supplementAudit = supplementAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a supplement
                apiInstance.AddSupplementAudit(supplementId, supplementAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.AddSupplementAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to add an audit to | 
 **supplementAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsupplementtag"></a>
# **AddSupplementTag**
> void AddSupplementTag (int? supplementId, string supplementTag)

Add new tags for a supplement.

Adds a tag to an existing supplement.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSupplementTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to add a tag to
            var supplementTag = supplementTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a supplement.
                apiInstance.AddSupplementTag(supplementId, supplementTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.AddSupplementTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to add a tag to | 
 **supplementTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesupplement"></a>
# **DeleteSupplement**
> void DeleteSupplement (int? supplementId)

Delete a supplement

Deletes the supplement identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteSupplementExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to be deleted.

            try
            {
                // Delete a supplement
                apiInstance.DeleteSupplement(supplementId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.DeleteSupplement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesupplementtag"></a>
# **DeleteSupplementTag**
> void DeleteSupplementTag (int? supplementId, string supplementTag)

Delete a tag for a supplement.

Deletes an existing supplement tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteSupplementTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to remove tag from
            var supplementTag = supplementTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a supplement.
                apiInstance.DeleteSupplementTag(supplementId, supplementTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.DeleteSupplementTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to remove tag from | 
 **supplementTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatesupplementbyid"></a>
# **GetDuplicateSupplementById**
> Supplement GetDuplicateSupplementById (int? supplementId)

Get a duplicated a supplement by id

Returns a duplicated supplement identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateSupplementByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to be duplicated.

            try
            {
                // Get a duplicated a supplement by id
                Supplement result = apiInstance.GetDuplicateSupplementById(supplementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.GetDuplicateSupplementById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to be duplicated. | 

### Return type

[**Supplement**](Supplement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupplementbyfilter"></a>
# **GetSupplementByFilter**
> List<Supplement> GetSupplementByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search supplements by filter

Returns the list of supplements that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSupplementByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search supplements by filter
                List&lt;Supplement&gt; result = apiInstance.GetSupplementByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.GetSupplementByFilter: " + e.Message );
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

[**List<Supplement>**](Supplement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupplementbyid"></a>
# **GetSupplementById**
> Supplement GetSupplementById (int? supplementId)

Get a supplement by id

Returns the supplement identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSupplementByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to be returned.

            try
            {
                // Get a supplement by id
                Supplement result = apiInstance.GetSupplementById(supplementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.GetSupplementById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to be returned. | 

### Return type

[**Supplement**](Supplement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupplementtags"></a>
# **GetSupplementTags**
> void GetSupplementTags (int? supplementId)

Get the tags for a supplement.

Get all existing supplement tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSupplementTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var supplementId = 56;  // int? | Id of the supplement to get tags for

            try
            {
                // Get the tags for a supplement.
                apiInstance.GetSupplementTags(supplementId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.GetSupplementTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplementId** | **int?**| Id of the supplement to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesupplement"></a>
# **UpdateSupplement**
> void UpdateSupplement (Supplement body)

Update a supplement

Updates an existing supplement using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateSupplementExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var body = new Supplement(); // Supplement | Supplement to be updated.

            try
            {
                // Update a supplement
                apiInstance.UpdateSupplement(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.UpdateSupplement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Supplement**](Supplement.md)| Supplement to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesupplementcustomfields"></a>
# **UpdateSupplementCustomFields**
> void UpdateSupplementCustomFields (Supplement body)

Update a supplement custom fields

Updates an existing supplement custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateSupplementCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SupplementApi();
            var body = new Supplement(); // Supplement | Supplement to be updated.

            try
            {
                // Update a supplement custom fields
                apiInstance.UpdateSupplementCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SupplementApi.UpdateSupplementCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Supplement**](Supplement.md)| Supplement to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

