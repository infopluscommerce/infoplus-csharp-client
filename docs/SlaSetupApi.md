# Infoplus.Api.SlaSetupApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSlaSetupAudit**](SlaSetupApi.md#addslasetupaudit) | **PUT** /beta/slaSetup/{slaSetupId}/audit/{slaSetupAudit} | Add new audit for a slaSetup
[**AddSlaSetupFile**](SlaSetupApi.md#addslasetupfile) | **POST** /beta/slaSetup/{slaSetupId}/file/{fileName} | Attach a file to a slaSetup
[**AddSlaSetupTag**](SlaSetupApi.md#addslasetuptag) | **PUT** /beta/slaSetup/{slaSetupId}/tag/{slaSetupTag} | Add new tags for a slaSetup.
[**DeleteSlaSetupTag**](SlaSetupApi.md#deleteslasetuptag) | **DELETE** /beta/slaSetup/{slaSetupId}/tag/{slaSetupTag} | Delete a tag for a slaSetup.
[**GetDuplicateSlaSetupById**](SlaSetupApi.md#getduplicateslasetupbyid) | **GET** /beta/slaSetup/duplicate/{slaSetupId} | Get a duplicated a slaSetup by id
[**GetSlaSetupByFilter**](SlaSetupApi.md#getslasetupbyfilter) | **GET** /beta/slaSetup/search | Search slaSetups by filter
[**GetSlaSetupById**](SlaSetupApi.md#getslasetupbyid) | **GET** /beta/slaSetup/{slaSetupId} | Get a slaSetup by id
[**GetSlaSetupTags**](SlaSetupApi.md#getslasetuptags) | **GET** /beta/slaSetup/{slaSetupId}/tag | Get the tags for a slaSetup.


<a name="addslasetupaudit"></a>
# **AddSlaSetupAudit**
> void AddSlaSetupAudit (int? slaSetupId, string slaSetupAudit)

Add new audit for a slaSetup

Adds an audit to an existing slaSetup.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSlaSetupAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to add an audit to
            var slaSetupAudit = slaSetupAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a slaSetup
                apiInstance.AddSlaSetupAudit(slaSetupId, slaSetupAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.AddSlaSetupAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to add an audit to | 
 **slaSetupAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addslasetupfile"></a>
# **AddSlaSetupFile**
> void AddSlaSetupFile (int? slaSetupId, string fileName)

Attach a file to a slaSetup

Adds a file to an existing slaSetup.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSlaSetupFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a slaSetup
                apiInstance.AddSlaSetupFile(slaSetupId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.AddSlaSetupFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addslasetuptag"></a>
# **AddSlaSetupTag**
> void AddSlaSetupTag (int? slaSetupId, string slaSetupTag)

Add new tags for a slaSetup.

Adds a tag to an existing slaSetup.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddSlaSetupTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to add a tag to
            var slaSetupTag = slaSetupTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a slaSetup.
                apiInstance.AddSlaSetupTag(slaSetupId, slaSetupTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.AddSlaSetupTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to add a tag to | 
 **slaSetupTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteslasetuptag"></a>
# **DeleteSlaSetupTag**
> void DeleteSlaSetupTag (int? slaSetupId, string slaSetupTag)

Delete a tag for a slaSetup.

Deletes an existing slaSetup tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteSlaSetupTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to remove tag from
            var slaSetupTag = slaSetupTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a slaSetup.
                apiInstance.DeleteSlaSetupTag(slaSetupId, slaSetupTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.DeleteSlaSetupTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to remove tag from | 
 **slaSetupTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateslasetupbyid"></a>
# **GetDuplicateSlaSetupById**
> SlaSetup GetDuplicateSlaSetupById (int? slaSetupId)

Get a duplicated a slaSetup by id

Returns a duplicated slaSetup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateSlaSetupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to be duplicated.

            try
            {
                // Get a duplicated a slaSetup by id
                SlaSetup result = apiInstance.GetDuplicateSlaSetupById(slaSetupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.GetDuplicateSlaSetupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to be duplicated. | 

### Return type

[**SlaSetup**](SlaSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getslasetupbyfilter"></a>
# **GetSlaSetupByFilter**
> List<SlaSetup> GetSlaSetupByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search slaSetups by filter

Returns the list of slaSetups that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSlaSetupByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search slaSetups by filter
                List&lt;SlaSetup&gt; result = apiInstance.GetSlaSetupByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.GetSlaSetupByFilter: " + e.Message );
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

[**List<SlaSetup>**](SlaSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getslasetupbyid"></a>
# **GetSlaSetupById**
> SlaSetup GetSlaSetupById (int? slaSetupId)

Get a slaSetup by id

Returns the slaSetup identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSlaSetupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to be returned.

            try
            {
                // Get a slaSetup by id
                SlaSetup result = apiInstance.GetSlaSetupById(slaSetupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.GetSlaSetupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to be returned. | 

### Return type

[**SlaSetup**](SlaSetup.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getslasetuptags"></a>
# **GetSlaSetupTags**
> void GetSlaSetupTags (int? slaSetupId)

Get the tags for a slaSetup.

Get all existing slaSetup tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetSlaSetupTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new SlaSetupApi();
            var slaSetupId = 56;  // int? | Id of the slaSetup to get tags for

            try
            {
                // Get the tags for a slaSetup.
                apiInstance.GetSlaSetupTags(slaSetupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlaSetupApi.GetSlaSetupTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slaSetupId** | **int?**| Id of the slaSetup to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

