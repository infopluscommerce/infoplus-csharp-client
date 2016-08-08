# Infoplus.Api.SubstitutionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSubstitution**](SubstitutionApi.md#addsubstitution) | **POST** /beta/substitution | Create a substitution
[**DeleteSubstitution**](SubstitutionApi.md#deletesubstitution) | **DELETE** /beta/substitution/{substitutionId} | Delete a substitution
[**GetSubstitutionByFilter**](SubstitutionApi.md#getsubstitutionbyfilter) | **GET** /beta/substitution/search | Search substitutions by filter
[**GetSubstitutionById**](SubstitutionApi.md#getsubstitutionbyid) | **GET** /beta/substitution/{substitutionId} | Get a substitution by id
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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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

