# Infoplus.Api.KitApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddKit**](KitApi.md#addkit) | **POST** /beta/kit | Create a kit
[**AddKitAudit**](KitApi.md#addkitaudit) | **PUT** /beta/kit/{kitId}/audit/{kitAudit} | Add new audit for a kit
[**AddKitTag**](KitApi.md#addkittag) | **PUT** /beta/kit/{kitId}/tag/{kitTag} | Add new tags for a kit.
[**DeleteKit**](KitApi.md#deletekit) | **DELETE** /beta/kit/{kitId} | Delete a kit
[**DeleteKitTag**](KitApi.md#deletekittag) | **DELETE** /beta/kit/{kitId}/tag/{kitTag} | Delete a tag for a kit.
[**GetDuplicateKitById**](KitApi.md#getduplicatekitbyid) | **GET** /beta/kit/duplicate/{kitId} | Get a duplicated a kit by id
[**GetKitByFilter**](KitApi.md#getkitbyfilter) | **GET** /beta/kit/search | Search kits by filter
[**GetKitById**](KitApi.md#getkitbyid) | **GET** /beta/kit/{kitId} | Get a kit by id
[**GetKitTags**](KitApi.md#getkittags) | **GET** /beta/kit/{kitId}/tag | Get the tags for a kit.
[**UpdateKit**](KitApi.md#updatekit) | **PUT** /beta/kit | Update a kit
[**UpdateKitCustomFields**](KitApi.md#updatekitcustomfields) | **PUT** /beta/kit/customFields | Update a kit custom fields


<a name="addkit"></a>
# **AddKit**
> Kit AddKit (Kit body)

Create a kit

Inserts a new kit using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddKitExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var body = new Kit(); // Kit | Kit to be inserted.

            try
            {
                // Create a kit
                Kit result = apiInstance.AddKit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.AddKit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kit**](Kit.md)| Kit to be inserted. | 

### Return type

[**Kit**](Kit.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addkitaudit"></a>
# **AddKitAudit**
> void AddKitAudit (int? kitId, string kitAudit)

Add new audit for a kit

Adds an audit to an existing kit.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddKitAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to add an audit to
            var kitAudit = kitAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a kit
                apiInstance.AddKitAudit(kitId, kitAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.AddKitAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to add an audit to | 
 **kitAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addkittag"></a>
# **AddKitTag**
> void AddKitTag (int? kitId, string kitTag)

Add new tags for a kit.

Adds a tag to an existing kit.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddKitTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to add a tag to
            var kitTag = kitTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a kit.
                apiInstance.AddKitTag(kitId, kitTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.AddKitTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to add a tag to | 
 **kitTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekit"></a>
# **DeleteKit**
> void DeleteKit (int? kitId)

Delete a kit

Deletes the kit identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteKitExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to be deleted.

            try
            {
                // Delete a kit
                apiInstance.DeleteKit(kitId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.DeleteKit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekittag"></a>
# **DeleteKitTag**
> void DeleteKitTag (int? kitId, string kitTag)

Delete a tag for a kit.

Deletes an existing kit tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteKitTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to remove tag from
            var kitTag = kitTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a kit.
                apiInstance.DeleteKitTag(kitId, kitTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.DeleteKitTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to remove tag from | 
 **kitTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatekitbyid"></a>
# **GetDuplicateKitById**
> Kit GetDuplicateKitById (int? kitId)

Get a duplicated a kit by id

Returns a duplicated kit identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateKitByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to be duplicated.

            try
            {
                // Get a duplicated a kit by id
                Kit result = apiInstance.GetDuplicateKitById(kitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.GetDuplicateKitById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to be duplicated. | 

### Return type

[**Kit**](Kit.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkitbyfilter"></a>
# **GetKitByFilter**
> List<Kit> GetKitByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search kits by filter

Returns the list of kits that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetKitByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search kits by filter
                List&lt;Kit&gt; result = apiInstance.GetKitByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.GetKitByFilter: " + e.Message );
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

[**List<Kit>**](Kit.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkitbyid"></a>
# **GetKitById**
> Kit GetKitById (int? kitId)

Get a kit by id

Returns the kit identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetKitByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to be returned.

            try
            {
                // Get a kit by id
                Kit result = apiInstance.GetKitById(kitId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.GetKitById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to be returned. | 

### Return type

[**Kit**](Kit.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkittags"></a>
# **GetKitTags**
> void GetKitTags (int? kitId)

Get the tags for a kit.

Get all existing kit tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetKitTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var kitId = 56;  // int? | Id of the kit to get tags for

            try
            {
                // Get the tags for a kit.
                apiInstance.GetKitTags(kitId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.GetKitTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kitId** | **int?**| Id of the kit to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatekit"></a>
# **UpdateKit**
> void UpdateKit (Kit body)

Update a kit

Updates an existing kit using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateKitExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var body = new Kit(); // Kit | Kit to be updated.

            try
            {
                // Update a kit
                apiInstance.UpdateKit(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.UpdateKit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kit**](Kit.md)| Kit to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatekitcustomfields"></a>
# **UpdateKitCustomFields**
> void UpdateKitCustomFields (Kit body)

Update a kit custom fields

Updates an existing kit custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateKitCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new KitApi();
            var body = new Kit(); // Kit | Kit to be updated.

            try
            {
                // Update a kit custom fields
                apiInstance.UpdateKitCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KitApi.UpdateKitCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kit**](Kit.md)| Kit to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

