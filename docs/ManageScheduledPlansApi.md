# Infoplus.Api.ManageScheduledPlansApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddManageScheduledPlans**](ManageScheduledPlansApi.md#addmanagescheduledplans) | **POST** /beta/manageScheduledPlans | Create a manageScheduledPlans
[**DeleteManageScheduledPlans**](ManageScheduledPlansApi.md#deletemanagescheduledplans) | **DELETE** /beta/manageScheduledPlans/{manageScheduledPlansId} | Delete a manageScheduledPlans
[**GetManageScheduledPlansByFilter**](ManageScheduledPlansApi.md#getmanagescheduledplansbyfilter) | **GET** /beta/manageScheduledPlans/search | Search manageScheduledPlanses by filter
[**GetManageScheduledPlansById**](ManageScheduledPlansApi.md#getmanagescheduledplansbyid) | **GET** /beta/manageScheduledPlans/{manageScheduledPlansId} | Get a manageScheduledPlans by id
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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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

