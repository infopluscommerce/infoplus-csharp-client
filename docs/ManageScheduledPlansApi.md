# Infoplus.Api.ManageScheduledPlansApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddManageScheduledPlans**](ManageScheduledPlansApi.md#addmanagescheduledplans) | **POST** /beta/manageScheduledPlans | Create a manageScheduledPlans
[**AddManageScheduledPlansAudit**](ManageScheduledPlansApi.md#addmanagescheduledplansaudit) | **PUT** /beta/manageScheduledPlans/{manageScheduledPlansId}/audit/{manageScheduledPlansAudit} | Add new audit for a manageScheduledPlans
[**AddManageScheduledPlansTag**](ManageScheduledPlansApi.md#addmanagescheduledplanstag) | **PUT** /beta/manageScheduledPlans/{manageScheduledPlansId}/tag/{manageScheduledPlansTag} | Add new tags for a manageScheduledPlans.
[**DeleteManageScheduledPlans**](ManageScheduledPlansApi.md#deletemanagescheduledplans) | **DELETE** /beta/manageScheduledPlans/{manageScheduledPlansId} | Delete a manageScheduledPlans
[**DeleteManageScheduledPlansTag**](ManageScheduledPlansApi.md#deletemanagescheduledplanstag) | **DELETE** /beta/manageScheduledPlans/{manageScheduledPlansId}/tag/{manageScheduledPlansTag} | Delete a tag for a manageScheduledPlans.
[**GetDuplicateManageScheduledPlansById**](ManageScheduledPlansApi.md#getduplicatemanagescheduledplansbyid) | **GET** /beta/manageScheduledPlans/duplicate/{manageScheduledPlansId} | Get a duplicated a manageScheduledPlans by id
[**GetManageScheduledPlansByFilter**](ManageScheduledPlansApi.md#getmanagescheduledplansbyfilter) | **GET** /beta/manageScheduledPlans/search | Search manageScheduledPlanses by filter
[**GetManageScheduledPlansById**](ManageScheduledPlansApi.md#getmanagescheduledplansbyid) | **GET** /beta/manageScheduledPlans/{manageScheduledPlansId} | Get a manageScheduledPlans by id
[**GetManageScheduledPlansTags**](ManageScheduledPlansApi.md#getmanagescheduledplanstags) | **GET** /beta/manageScheduledPlans/{manageScheduledPlansId}/tag | Get the tags for a manageScheduledPlans.
[**UpdateManageScheduledPlans**](ManageScheduledPlansApi.md#updatemanagescheduledplans) | **PUT** /beta/manageScheduledPlans | Update a manageScheduledPlans


<a name="addmanagescheduledplans"></a>
# **AddManageScheduledPlans**
> ManageScheduledPlans AddManageScheduledPlans (ManageScheduledPlans body)

Create a manageScheduledPlans

Inserts a new manageScheduledPlans using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddManageScheduledPlansExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var body = new ManageScheduledPlans(); // ManageScheduledPlans | ManageScheduledPlans to be inserted.

            try
            {
                // Create a manageScheduledPlans
                ManageScheduledPlans result = apiInstance.AddManageScheduledPlans(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.AddManageScheduledPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ManageScheduledPlans**](ManageScheduledPlans.md)| ManageScheduledPlans to be inserted. | 

### Return type

[**ManageScheduledPlans**](ManageScheduledPlans.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmanagescheduledplansaudit"></a>
# **AddManageScheduledPlansAudit**
> void AddManageScheduledPlansAudit (int? manageScheduledPlansId, string manageScheduledPlansAudit)

Add new audit for a manageScheduledPlans

Adds an audit to an existing manageScheduledPlans.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddManageScheduledPlansAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to add an audit to
            var manageScheduledPlansAudit = manageScheduledPlansAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a manageScheduledPlans
                apiInstance.AddManageScheduledPlansAudit(manageScheduledPlansId, manageScheduledPlansAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.AddManageScheduledPlansAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to add an audit to | 
 **manageScheduledPlansAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmanagescheduledplanstag"></a>
# **AddManageScheduledPlansTag**
> void AddManageScheduledPlansTag (int? manageScheduledPlansId, string manageScheduledPlansTag)

Add new tags for a manageScheduledPlans.

Adds a tag to an existing manageScheduledPlans.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddManageScheduledPlansTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to add a tag to
            var manageScheduledPlansTag = manageScheduledPlansTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a manageScheduledPlans.
                apiInstance.AddManageScheduledPlansTag(manageScheduledPlansId, manageScheduledPlansTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.AddManageScheduledPlansTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to add a tag to | 
 **manageScheduledPlansTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemanagescheduledplans"></a>
# **DeleteManageScheduledPlans**
> void DeleteManageScheduledPlans (int? manageScheduledPlansId)

Delete a manageScheduledPlans

Deletes the manageScheduledPlans identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteManageScheduledPlansExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to be deleted.

            try
            {
                // Delete a manageScheduledPlans
                apiInstance.DeleteManageScheduledPlans(manageScheduledPlansId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.DeleteManageScheduledPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemanagescheduledplanstag"></a>
# **DeleteManageScheduledPlansTag**
> void DeleteManageScheduledPlansTag (int? manageScheduledPlansId, string manageScheduledPlansTag)

Delete a tag for a manageScheduledPlans.

Deletes an existing manageScheduledPlans tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteManageScheduledPlansTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to remove tag from
            var manageScheduledPlansTag = manageScheduledPlansTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a manageScheduledPlans.
                apiInstance.DeleteManageScheduledPlansTag(manageScheduledPlansId, manageScheduledPlansTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.DeleteManageScheduledPlansTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to remove tag from | 
 **manageScheduledPlansTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatemanagescheduledplansbyid"></a>
# **GetDuplicateManageScheduledPlansById**
> ManageScheduledPlans GetDuplicateManageScheduledPlansById (int? manageScheduledPlansId)

Get a duplicated a manageScheduledPlans by id

Returns a duplicated manageScheduledPlans identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateManageScheduledPlansByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to be duplicated.

            try
            {
                // Get a duplicated a manageScheduledPlans by id
                ManageScheduledPlans result = apiInstance.GetDuplicateManageScheduledPlansById(manageScheduledPlansId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.GetDuplicateManageScheduledPlansById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to be duplicated. | 

### Return type

[**ManageScheduledPlans**](ManageScheduledPlans.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagescheduledplansbyfilter"></a>
# **GetManageScheduledPlansByFilter**
> List<ManageScheduledPlans> GetManageScheduledPlansByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search manageScheduledPlanses by filter

Returns the list of manageScheduledPlanses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetManageScheduledPlansByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search manageScheduledPlanses by filter
                List&lt;ManageScheduledPlans&gt; result = apiInstance.GetManageScheduledPlansByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.GetManageScheduledPlansByFilter: " + e.Message );
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

[**List<ManageScheduledPlans>**](ManageScheduledPlans.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagescheduledplansbyid"></a>
# **GetManageScheduledPlansById**
> ManageScheduledPlans GetManageScheduledPlansById (int? manageScheduledPlansId)

Get a manageScheduledPlans by id

Returns the manageScheduledPlans identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetManageScheduledPlansByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to be returned.

            try
            {
                // Get a manageScheduledPlans by id
                ManageScheduledPlans result = apiInstance.GetManageScheduledPlansById(manageScheduledPlansId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.GetManageScheduledPlansById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to be returned. | 

### Return type

[**ManageScheduledPlans**](ManageScheduledPlans.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanagescheduledplanstags"></a>
# **GetManageScheduledPlansTags**
> void GetManageScheduledPlansTags (int? manageScheduledPlansId)

Get the tags for a manageScheduledPlans.

Get all existing manageScheduledPlans tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetManageScheduledPlansTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var manageScheduledPlansId = 56;  // int? | Id of the manageScheduledPlans to get tags for

            try
            {
                // Get the tags for a manageScheduledPlans.
                apiInstance.GetManageScheduledPlansTags(manageScheduledPlansId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.GetManageScheduledPlansTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manageScheduledPlansId** | **int?**| Id of the manageScheduledPlans to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemanagescheduledplans"></a>
# **UpdateManageScheduledPlans**
> void UpdateManageScheduledPlans (ManageScheduledPlans body)

Update a manageScheduledPlans

Updates an existing manageScheduledPlans using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateManageScheduledPlansExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ManageScheduledPlansApi();
            var body = new ManageScheduledPlans(); // ManageScheduledPlans | ManageScheduledPlans to be updated.

            try
            {
                // Update a manageScheduledPlans
                apiInstance.UpdateManageScheduledPlans(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageScheduledPlansApi.UpdateManageScheduledPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ManageScheduledPlans**](ManageScheduledPlans.md)| ManageScheduledPlans to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

