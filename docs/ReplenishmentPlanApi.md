# Infoplus.Api.ReplenishmentPlanApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReplenishmentPlan**](ReplenishmentPlanApi.md#addreplenishmentplan) | **POST** /beta/replenishmentPlan | Create a replenishmentPlan
[**AddReplenishmentPlanAudit**](ReplenishmentPlanApi.md#addreplenishmentplanaudit) | **PUT** /beta/replenishmentPlan/{replenishmentPlanId}/audit/{replenishmentPlanAudit} | Add new audit for a replenishmentPlan
[**AddReplenishmentPlanFile**](ReplenishmentPlanApi.md#addreplenishmentplanfile) | **POST** /beta/replenishmentPlan/{replenishmentPlanId}/file/{fileName} | Attach a file to a replenishmentPlan
[**AddReplenishmentPlanTag**](ReplenishmentPlanApi.md#addreplenishmentplantag) | **PUT** /beta/replenishmentPlan/{replenishmentPlanId}/tag/{replenishmentPlanTag} | Add new tags for a replenishmentPlan.
[**DeleteReplenishmentPlan**](ReplenishmentPlanApi.md#deletereplenishmentplan) | **DELETE** /beta/replenishmentPlan/{replenishmentPlanId} | Delete a replenishmentPlan
[**DeleteReplenishmentPlanTag**](ReplenishmentPlanApi.md#deletereplenishmentplantag) | **DELETE** /beta/replenishmentPlan/{replenishmentPlanId}/tag/{replenishmentPlanTag} | Delete a tag for a replenishmentPlan.
[**GetDuplicateReplenishmentPlanById**](ReplenishmentPlanApi.md#getduplicatereplenishmentplanbyid) | **GET** /beta/replenishmentPlan/duplicate/{replenishmentPlanId} | Get a duplicated a replenishmentPlan by id
[**GetReplenishmentPlanByFilter**](ReplenishmentPlanApi.md#getreplenishmentplanbyfilter) | **GET** /beta/replenishmentPlan/search | Search replenishmentPlans by filter
[**GetReplenishmentPlanById**](ReplenishmentPlanApi.md#getreplenishmentplanbyid) | **GET** /beta/replenishmentPlan/{replenishmentPlanId} | Get a replenishmentPlan by id
[**GetReplenishmentPlanTags**](ReplenishmentPlanApi.md#getreplenishmentplantags) | **GET** /beta/replenishmentPlan/{replenishmentPlanId}/tag | Get the tags for a replenishmentPlan.
[**UpdateReplenishmentPlan**](ReplenishmentPlanApi.md#updatereplenishmentplan) | **PUT** /beta/replenishmentPlan | Update a replenishmentPlan
[**UpdateReplenishmentPlanCustomFields**](ReplenishmentPlanApi.md#updatereplenishmentplancustomfields) | **PUT** /beta/replenishmentPlan/customFields | Update a replenishmentPlan custom fields


<a name="addreplenishmentplan"></a>
# **AddReplenishmentPlan**
> ReplenishmentPlan AddReplenishmentPlan (ReplenishmentPlan body)

Create a replenishmentPlan

Inserts a new replenishmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var body = new ReplenishmentPlan(); // ReplenishmentPlan | ReplenishmentPlan to be inserted.

            try
            {
                // Create a replenishmentPlan
                ReplenishmentPlan result = apiInstance.AddReplenishmentPlan(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.AddReplenishmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentPlan**](ReplenishmentPlan.md)| ReplenishmentPlan to be inserted. | 

### Return type

[**ReplenishmentPlan**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentplanaudit"></a>
# **AddReplenishmentPlanAudit**
> void AddReplenishmentPlanAudit (int? replenishmentPlanId, string replenishmentPlanAudit)

Add new audit for a replenishmentPlan

Adds an audit to an existing replenishmentPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentPlanAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to add an audit to
            var replenishmentPlanAudit = replenishmentPlanAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a replenishmentPlan
                apiInstance.AddReplenishmentPlanAudit(replenishmentPlanId, replenishmentPlanAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.AddReplenishmentPlanAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to add an audit to | 
 **replenishmentPlanAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentplanfile"></a>
# **AddReplenishmentPlanFile**
> void AddReplenishmentPlanFile (int? replenishmentPlanId, string fileName)

Attach a file to a replenishmentPlan

Adds a file to an existing replenishmentPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentPlanFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a replenishmentPlan
                apiInstance.AddReplenishmentPlanFile(replenishmentPlanId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.AddReplenishmentPlanFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreplenishmentplantag"></a>
# **AddReplenishmentPlanTag**
> void AddReplenishmentPlanTag (int? replenishmentPlanId, string replenishmentPlanTag)

Add new tags for a replenishmentPlan.

Adds a tag to an existing replenishmentPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReplenishmentPlanTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to add a tag to
            var replenishmentPlanTag = replenishmentPlanTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a replenishmentPlan.
                apiInstance.AddReplenishmentPlanTag(replenishmentPlanId, replenishmentPlanTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.AddReplenishmentPlanTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to add a tag to | 
 **replenishmentPlanTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereplenishmentplan"></a>
# **DeleteReplenishmentPlan**
> void DeleteReplenishmentPlan (int? replenishmentPlanId)

Delete a replenishmentPlan

Deletes the replenishmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReplenishmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to be deleted.

            try
            {
                // Delete a replenishmentPlan
                apiInstance.DeleteReplenishmentPlan(replenishmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.DeleteReplenishmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereplenishmentplantag"></a>
# **DeleteReplenishmentPlanTag**
> void DeleteReplenishmentPlanTag (int? replenishmentPlanId, string replenishmentPlanTag)

Delete a tag for a replenishmentPlan.

Deletes an existing replenishmentPlan tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReplenishmentPlanTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to remove tag from
            var replenishmentPlanTag = replenishmentPlanTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a replenishmentPlan.
                apiInstance.DeleteReplenishmentPlanTag(replenishmentPlanId, replenishmentPlanTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.DeleteReplenishmentPlanTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to remove tag from | 
 **replenishmentPlanTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereplenishmentplanbyid"></a>
# **GetDuplicateReplenishmentPlanById**
> ReplenishmentPlan GetDuplicateReplenishmentPlanById (int? replenishmentPlanId)

Get a duplicated a replenishmentPlan by id

Returns a duplicated replenishmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReplenishmentPlanByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to be duplicated.

            try
            {
                // Get a duplicated a replenishmentPlan by id
                ReplenishmentPlan result = apiInstance.GetDuplicateReplenishmentPlanById(replenishmentPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.GetDuplicateReplenishmentPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to be duplicated. | 

### Return type

[**ReplenishmentPlan**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentplanbyfilter"></a>
# **GetReplenishmentPlanByFilter**
> List<ReplenishmentPlan> GetReplenishmentPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search replenishmentPlans by filter

Returns the list of replenishmentPlans that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentPlanByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search replenishmentPlans by filter
                List&lt;ReplenishmentPlan&gt; result = apiInstance.GetReplenishmentPlanByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.GetReplenishmentPlanByFilter: " + e.Message );
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

[**List<ReplenishmentPlan>**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentplanbyid"></a>
# **GetReplenishmentPlanById**
> ReplenishmentPlan GetReplenishmentPlanById (int? replenishmentPlanId)

Get a replenishmentPlan by id

Returns the replenishmentPlan identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentPlanByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to be returned.

            try
            {
                // Get a replenishmentPlan by id
                ReplenishmentPlan result = apiInstance.GetReplenishmentPlanById(replenishmentPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.GetReplenishmentPlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to be returned. | 

### Return type

[**ReplenishmentPlan**](ReplenishmentPlan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplenishmentplantags"></a>
# **GetReplenishmentPlanTags**
> void GetReplenishmentPlanTags (int? replenishmentPlanId)

Get the tags for a replenishmentPlan.

Get all existing replenishmentPlan tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReplenishmentPlanTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var replenishmentPlanId = 56;  // int? | Id of the replenishmentPlan to get tags for

            try
            {
                // Get the tags for a replenishmentPlan.
                apiInstance.GetReplenishmentPlanTags(replenishmentPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.GetReplenishmentPlanTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replenishmentPlanId** | **int?**| Id of the replenishmentPlan to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereplenishmentplan"></a>
# **UpdateReplenishmentPlan**
> void UpdateReplenishmentPlan (ReplenishmentPlan body)

Update a replenishmentPlan

Updates an existing replenishmentPlan using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReplenishmentPlanExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var body = new ReplenishmentPlan(); // ReplenishmentPlan | ReplenishmentPlan to be updated.

            try
            {
                // Update a replenishmentPlan
                apiInstance.UpdateReplenishmentPlan(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.UpdateReplenishmentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentPlan**](ReplenishmentPlan.md)| ReplenishmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereplenishmentplancustomfields"></a>
# **UpdateReplenishmentPlanCustomFields**
> void UpdateReplenishmentPlanCustomFields (ReplenishmentPlan body)

Update a replenishmentPlan custom fields

Updates an existing replenishmentPlan custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReplenishmentPlanCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReplenishmentPlanApi();
            var body = new ReplenishmentPlan(); // ReplenishmentPlan | ReplenishmentPlan to be updated.

            try
            {
                // Update a replenishmentPlan custom fields
                apiInstance.UpdateReplenishmentPlanCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplenishmentPlanApi.UpdateReplenishmentPlanCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplenishmentPlan**](ReplenishmentPlan.md)| ReplenishmentPlan to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

