# Infoplus.Api.AlertApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAlertAudit**](AlertApi.md#addalertaudit) | **PUT** /beta/alert/{alertId}/audit/{alertAudit} | Add new audit for an alert
[**AddAlertTag**](AlertApi.md#addalerttag) | **PUT** /beta/alert/{alertId}/tag/{alertTag} | Add new tags for an alert.
[**DeleteAlertTag**](AlertApi.md#deletealerttag) | **DELETE** /beta/alert/{alertId}/tag/{alertTag} | Delete a tag for an alert.
[**GetAlertByFilter**](AlertApi.md#getalertbyfilter) | **GET** /beta/alert/search | Search alerts by filter
[**GetAlertById**](AlertApi.md#getalertbyid) | **GET** /beta/alert/{alertId} | Get an alert by id
[**GetAlertTags**](AlertApi.md#getalerttags) | **GET** /beta/alert/{alertId}/tag | Get the tags for an alert.
[**GetDuplicateAlertById**](AlertApi.md#getduplicatealertbyid) | **GET** /beta/alert/duplicate/{alertId} | Get a duplicated an alert by id
[**UpdateAlertCustomFields**](AlertApi.md#updatealertcustomfields) | **PUT** /beta/alert/customFields | Update an alert custom fields


<a name="addalertaudit"></a>
# **AddAlertAudit**
> void AddAlertAudit (int? alertId, string alertAudit)

Add new audit for an alert

Adds an audit to an existing alert.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddAlertAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var alertId = 56;  // int? | Id of the alert to add an audit to
            var alertAudit = alertAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an alert
                apiInstance.AddAlertAudit(alertId, alertAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.AddAlertAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertId** | **int?**| Id of the alert to add an audit to | 
 **alertAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addalerttag"></a>
# **AddAlertTag**
> void AddAlertTag (int? alertId, string alertTag)

Add new tags for an alert.

Adds a tag to an existing alert.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddAlertTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var alertId = 56;  // int? | Id of the alert to add a tag to
            var alertTag = alertTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an alert.
                apiInstance.AddAlertTag(alertId, alertTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.AddAlertTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertId** | **int?**| Id of the alert to add a tag to | 
 **alertTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletealerttag"></a>
# **DeleteAlertTag**
> void DeleteAlertTag (int? alertId, string alertTag)

Delete a tag for an alert.

Deletes an existing alert tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteAlertTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var alertId = 56;  // int? | Id of the alert to remove tag from
            var alertTag = alertTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an alert.
                apiInstance.DeleteAlertTag(alertId, alertTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.DeleteAlertTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertId** | **int?**| Id of the alert to remove tag from | 
 **alertTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalertbyfilter"></a>
# **GetAlertByFilter**
> List<Alert> GetAlertByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search alerts by filter

Returns the list of alerts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAlertByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search alerts by filter
                List&lt;Alert&gt; result = apiInstance.GetAlertByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.GetAlertByFilter: " + e.Message );
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

[**List<Alert>**](Alert.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalertbyid"></a>
# **GetAlertById**
> Alert GetAlertById (int? alertId)

Get an alert by id

Returns the alert identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAlertByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var alertId = 56;  // int? | Id of the alert to be returned.

            try
            {
                // Get an alert by id
                Alert result = apiInstance.GetAlertById(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.GetAlertById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertId** | **int?**| Id of the alert to be returned. | 

### Return type

[**Alert**](Alert.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalerttags"></a>
# **GetAlertTags**
> void GetAlertTags (int? alertId)

Get the tags for an alert.

Get all existing alert tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAlertTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var alertId = 56;  // int? | Id of the alert to get tags for

            try
            {
                // Get the tags for an alert.
                apiInstance.GetAlertTags(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.GetAlertTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertId** | **int?**| Id of the alert to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatealertbyid"></a>
# **GetDuplicateAlertById**
> Alert GetDuplicateAlertById (int? alertId)

Get a duplicated an alert by id

Returns a duplicated alert identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateAlertByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var alertId = 56;  // int? | Id of the alert to be duplicated.

            try
            {
                // Get a duplicated an alert by id
                Alert result = apiInstance.GetDuplicateAlertById(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.GetDuplicateAlertById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertId** | **int?**| Id of the alert to be duplicated. | 

### Return type

[**Alert**](Alert.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatealertcustomfields"></a>
# **UpdateAlertCustomFields**
> void UpdateAlertCustomFields (Alert body)

Update an alert custom fields

Updates an existing alert custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateAlertCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AlertApi();
            var body = new Alert(); // Alert | Alert to be updated.

            try
            {
                // Update an alert custom fields
                apiInstance.UpdateAlertCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.UpdateAlertCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Alert**](Alert.md)| Alert to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

