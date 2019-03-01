# Infoplus.Api.SubstitutionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSubstitution**](SubstitutionApi.md#addsubstitution) | **POST** /beta/substitution | Create a substitution
[**AddSubstitutionAudit**](SubstitutionApi.md#addsubstitutionaudit) | **PUT** /beta/substitution/{substitutionId}/audit/{substitutionAudit} | Add new audit for a substitution
[**AddSubstitutionFile**](SubstitutionApi.md#addsubstitutionfile) | **POST** /beta/substitution/{substitutionId}/file/{fileName} | Attach a file to a substitution
[**AddSubstitutionTag**](SubstitutionApi.md#addsubstitutiontag) | **PUT** /beta/substitution/{substitutionId}/tag/{substitutionTag} | Add new tags for a substitution.
[**DeleteSubstitution**](SubstitutionApi.md#deletesubstitution) | **DELETE** /beta/substitution/{substitutionId} | Delete a substitution
[**DeleteSubstitutionTag**](SubstitutionApi.md#deletesubstitutiontag) | **DELETE** /beta/substitution/{substitutionId}/tag/{substitutionTag} | Delete a tag for a substitution.
[**GetDuplicateSubstitutionById**](SubstitutionApi.md#getduplicatesubstitutionbyid) | **GET** /beta/substitution/duplicate/{substitutionId} | Get a duplicated a substitution by id
[**GetSubstitutionByFilter**](SubstitutionApi.md#getsubstitutionbyfilter) | **GET** /beta/substitution/search | Search substitutions by filter
[**GetSubstitutionById**](SubstitutionApi.md#getsubstitutionbyid) | **GET** /beta/substitution/{substitutionId} | Get a substitution by id
[**GetSubstitutionTags**](SubstitutionApi.md#getsubstitutiontags) | **GET** /beta/substitution/{substitutionId}/tag | Get the tags for a substitution.
[**UpdateSubstitution**](SubstitutionApi.md#updatesubstitution) | **PUT** /beta/substitution | Update a substitution
[**UpdateSubstitutionCustomFields**](SubstitutionApi.md#updatesubstitutioncustomfields) | **PUT** /beta/substitution/customFields | Update a substitution custom fields


<a name="addsubstitution"></a>
# **AddSubstitution**
> Substitution AddSubstitution (Substitution body)

Create a substitution

Inserts a new substitution using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSubstitutionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var body = new Substitution(); // Substitution | Substitution to be inserted.

            try
            {
                // Create a substitution
                Substitution result = apiInstance.AddSubstitution(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.AddSubstitution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Substitution**](Substitution.md)| Substitution to be inserted. | 

### Return type

[**Substitution**](Substitution.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsubstitutionaudit"></a>
# **AddSubstitutionAudit**
> void AddSubstitutionAudit (int? substitutionId, string substitutionAudit)

Add new audit for a substitution

Adds an audit to an existing substitution.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSubstitutionAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to add an audit to
            var substitutionAudit = substitutionAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a substitution
                apiInstance.AddSubstitutionAudit(substitutionId, substitutionAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.AddSubstitutionAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to add an audit to | 
 **substitutionAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsubstitutionfile"></a>
# **AddSubstitutionFile**
> void AddSubstitutionFile (int? substitutionId, string fileName)

Attach a file to a substitution

Adds a file to an existing substitution.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSubstitutionFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a substitution
                apiInstance.AddSubstitutionFile(substitutionId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.AddSubstitutionFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsubstitutiontag"></a>
# **AddSubstitutionTag**
> void AddSubstitutionTag (int? substitutionId, string substitutionTag)

Add new tags for a substitution.

Adds a tag to an existing substitution.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSubstitutionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to add a tag to
            var substitutionTag = substitutionTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a substitution.
                apiInstance.AddSubstitutionTag(substitutionId, substitutionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.AddSubstitutionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to add a tag to | 
 **substitutionTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubstitution"></a>
# **DeleteSubstitution**
> void DeleteSubstitution (int? substitutionId)

Delete a substitution

Deletes the substitution identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteSubstitutionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to be deleted.

            try
            {
                // Delete a substitution
                apiInstance.DeleteSubstitution(substitutionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.DeleteSubstitution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubstitutiontag"></a>
# **DeleteSubstitutionTag**
> void DeleteSubstitutionTag (int? substitutionId, string substitutionTag)

Delete a tag for a substitution.

Deletes an existing substitution tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteSubstitutionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to remove tag from
            var substitutionTag = substitutionTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a substitution.
                apiInstance.DeleteSubstitutionTag(substitutionId, substitutionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.DeleteSubstitutionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to remove tag from | 
 **substitutionTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatesubstitutionbyid"></a>
# **GetDuplicateSubstitutionById**
> Substitution GetDuplicateSubstitutionById (int? substitutionId)

Get a duplicated a substitution by id

Returns a duplicated substitution identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateSubstitutionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to be duplicated.

            try
            {
                // Get a duplicated a substitution by id
                Substitution result = apiInstance.GetDuplicateSubstitutionById(substitutionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.GetDuplicateSubstitutionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to be duplicated. | 

### Return type

[**Substitution**](Substitution.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstitutionbyfilter"></a>
# **GetSubstitutionByFilter**
> List<Substitution> GetSubstitutionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search substitutions by filter

Returns the list of substitutions that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSubstitutionByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search substitutions by filter
                List&lt;Substitution&gt; result = apiInstance.GetSubstitutionByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.GetSubstitutionByFilter: " + e.Message );
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

[**List<Substitution>**](Substitution.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstitutionbyid"></a>
# **GetSubstitutionById**
> Substitution GetSubstitutionById (int? substitutionId)

Get a substitution by id

Returns the substitution identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSubstitutionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to be returned.

            try
            {
                // Get a substitution by id
                Substitution result = apiInstance.GetSubstitutionById(substitutionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.GetSubstitutionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to be returned. | 

### Return type

[**Substitution**](Substitution.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubstitutiontags"></a>
# **GetSubstitutionTags**
> void GetSubstitutionTags (int? substitutionId)

Get the tags for a substitution.

Get all existing substitution tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSubstitutionTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var substitutionId = 56;  // int? | Id of the substitution to get tags for

            try
            {
                // Get the tags for a substitution.
                apiInstance.GetSubstitutionTags(substitutionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.GetSubstitutionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **substitutionId** | **int?**| Id of the substitution to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubstitution"></a>
# **UpdateSubstitution**
> void UpdateSubstitution (Substitution body)

Update a substitution

Updates an existing substitution using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateSubstitutionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var body = new Substitution(); // Substitution | Substitution to be updated.

            try
            {
                // Update a substitution
                apiInstance.UpdateSubstitution(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.UpdateSubstitution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Substitution**](Substitution.md)| Substitution to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubstitutioncustomfields"></a>
# **UpdateSubstitutionCustomFields**
> void UpdateSubstitutionCustomFields (Substitution body)

Update a substitution custom fields

Updates an existing substitution custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateSubstitutionCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SubstitutionApi();
            var body = new Substitution(); // Substitution | Substitution to be updated.

            try
            {
                // Update a substitution custom fields
                apiInstance.UpdateSubstitutionCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubstitutionApi.UpdateSubstitutionCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Substitution**](Substitution.md)| Substitution to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

