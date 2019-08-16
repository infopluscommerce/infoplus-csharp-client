# Infoplus.Api.VendorComplianceSurveyApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVendorComplianceSurvey**](VendorComplianceSurveyApi.md#addvendorcompliancesurvey) | **POST** /beta/vendorComplianceSurvey | Create a vendorComplianceSurvey
[**AddVendorComplianceSurveyAudit**](VendorComplianceSurveyApi.md#addvendorcompliancesurveyaudit) | **PUT** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/audit/{vendorComplianceSurveyAudit} | Add new audit for a vendorComplianceSurvey
[**AddVendorComplianceSurveyFile**](VendorComplianceSurveyApi.md#addvendorcompliancesurveyfile) | **POST** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/file/{fileName} | Attach a file to a vendorComplianceSurvey
[**AddVendorComplianceSurveyTag**](VendorComplianceSurveyApi.md#addvendorcompliancesurveytag) | **PUT** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag/{vendorComplianceSurveyTag} | Add new tags for a vendorComplianceSurvey.
[**DeleteVendorComplianceSurvey**](VendorComplianceSurveyApi.md#deletevendorcompliancesurvey) | **DELETE** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId} | Delete a vendorComplianceSurvey
[**DeleteVendorComplianceSurveyTag**](VendorComplianceSurveyApi.md#deletevendorcompliancesurveytag) | **DELETE** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag/{vendorComplianceSurveyTag} | Delete a tag for a vendorComplianceSurvey.
[**GetDuplicateVendorComplianceSurveyById**](VendorComplianceSurveyApi.md#getduplicatevendorcompliancesurveybyid) | **GET** /beta/vendorComplianceSurvey/duplicate/{vendorComplianceSurveyId} | Get a duplicated a vendorComplianceSurvey by id
[**GetVendorComplianceSurveyByFilter**](VendorComplianceSurveyApi.md#getvendorcompliancesurveybyfilter) | **GET** /beta/vendorComplianceSurvey/search | Search vendorComplianceSurveys by filter
[**GetVendorComplianceSurveyById**](VendorComplianceSurveyApi.md#getvendorcompliancesurveybyid) | **GET** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId} | Get a vendorComplianceSurvey by id
[**GetVendorComplianceSurveyTags**](VendorComplianceSurveyApi.md#getvendorcompliancesurveytags) | **GET** /beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag | Get the tags for a vendorComplianceSurvey.
[**UpdateVendorComplianceSurvey**](VendorComplianceSurveyApi.md#updatevendorcompliancesurvey) | **PUT** /beta/vendorComplianceSurvey | Update a vendorComplianceSurvey
[**UpdateVendorComplianceSurveyCustomFields**](VendorComplianceSurveyApi.md#updatevendorcompliancesurveycustomfields) | **PUT** /beta/vendorComplianceSurvey/customFields | Update a vendorComplianceSurvey custom fields


<a name="addvendorcompliancesurvey"></a>
# **AddVendorComplianceSurvey**
> VendorComplianceSurvey AddVendorComplianceSurvey (VendorComplianceSurvey body)

Create a vendorComplianceSurvey

Inserts a new vendorComplianceSurvey using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorComplianceSurveyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var body = new VendorComplianceSurvey(); // VendorComplianceSurvey | VendorComplianceSurvey to be inserted.

            try
            {
                // Create a vendorComplianceSurvey
                VendorComplianceSurvey result = apiInstance.AddVendorComplianceSurvey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.AddVendorComplianceSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VendorComplianceSurvey**](VendorComplianceSurvey.md)| VendorComplianceSurvey to be inserted. | 

### Return type

[**VendorComplianceSurvey**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendorcompliancesurveyaudit"></a>
# **AddVendorComplianceSurveyAudit**
> void AddVendorComplianceSurveyAudit (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit)

Add new audit for a vendorComplianceSurvey

Adds an audit to an existing vendorComplianceSurvey.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorComplianceSurveyAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to add an audit to
            var vendorComplianceSurveyAudit = vendorComplianceSurveyAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a vendorComplianceSurvey
                apiInstance.AddVendorComplianceSurveyAudit(vendorComplianceSurveyId, vendorComplianceSurveyAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.AddVendorComplianceSurveyAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to add an audit to | 
 **vendorComplianceSurveyAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendorcompliancesurveyfile"></a>
# **AddVendorComplianceSurveyFile**
> void AddVendorComplianceSurveyFile (int? vendorComplianceSurveyId, string fileName)

Attach a file to a vendorComplianceSurvey

Adds a file to an existing vendorComplianceSurvey.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorComplianceSurveyFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a vendorComplianceSurvey
                apiInstance.AddVendorComplianceSurveyFile(vendorComplianceSurveyId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.AddVendorComplianceSurveyFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendorcompliancesurveytag"></a>
# **AddVendorComplianceSurveyTag**
> void AddVendorComplianceSurveyTag (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)

Add new tags for a vendorComplianceSurvey.

Adds a tag to an existing vendorComplianceSurvey.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorComplianceSurveyTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to add a tag to
            var vendorComplianceSurveyTag = vendorComplianceSurveyTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a vendorComplianceSurvey.
                apiInstance.AddVendorComplianceSurveyTag(vendorComplianceSurveyId, vendorComplianceSurveyTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.AddVendorComplianceSurveyTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to add a tag to | 
 **vendorComplianceSurveyTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendorcompliancesurvey"></a>
# **DeleteVendorComplianceSurvey**
> void DeleteVendorComplianceSurvey (int? vendorComplianceSurveyId)

Delete a vendorComplianceSurvey

Deletes the vendorComplianceSurvey identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteVendorComplianceSurveyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to be deleted.

            try
            {
                // Delete a vendorComplianceSurvey
                apiInstance.DeleteVendorComplianceSurvey(vendorComplianceSurveyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.DeleteVendorComplianceSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendorcompliancesurveytag"></a>
# **DeleteVendorComplianceSurveyTag**
> void DeleteVendorComplianceSurveyTag (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)

Delete a tag for a vendorComplianceSurvey.

Deletes an existing vendorComplianceSurvey tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteVendorComplianceSurveyTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to remove tag from
            var vendorComplianceSurveyTag = vendorComplianceSurveyTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a vendorComplianceSurvey.
                apiInstance.DeleteVendorComplianceSurveyTag(vendorComplianceSurveyId, vendorComplianceSurveyTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.DeleteVendorComplianceSurveyTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to remove tag from | 
 **vendorComplianceSurveyTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatevendorcompliancesurveybyid"></a>
# **GetDuplicateVendorComplianceSurveyById**
> VendorComplianceSurvey GetDuplicateVendorComplianceSurveyById (int? vendorComplianceSurveyId)

Get a duplicated a vendorComplianceSurvey by id

Returns a duplicated vendorComplianceSurvey identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateVendorComplianceSurveyByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to be duplicated.

            try
            {
                // Get a duplicated a vendorComplianceSurvey by id
                VendorComplianceSurvey result = apiInstance.GetDuplicateVendorComplianceSurveyById(vendorComplianceSurveyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.GetDuplicateVendorComplianceSurveyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to be duplicated. | 

### Return type

[**VendorComplianceSurvey**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorcompliancesurveybyfilter"></a>
# **GetVendorComplianceSurveyByFilter**
> List<VendorComplianceSurvey> GetVendorComplianceSurveyByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search vendorComplianceSurveys by filter

Returns the list of vendorComplianceSurveys that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorComplianceSurveyByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search vendorComplianceSurveys by filter
                List&lt;VendorComplianceSurvey&gt; result = apiInstance.GetVendorComplianceSurveyByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.GetVendorComplianceSurveyByFilter: " + e.Message );
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

[**List<VendorComplianceSurvey>**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorcompliancesurveybyid"></a>
# **GetVendorComplianceSurveyById**
> VendorComplianceSurvey GetVendorComplianceSurveyById (int? vendorComplianceSurveyId)

Get a vendorComplianceSurvey by id

Returns the vendorComplianceSurvey identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorComplianceSurveyByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to be returned.

            try
            {
                // Get a vendorComplianceSurvey by id
                VendorComplianceSurvey result = apiInstance.GetVendorComplianceSurveyById(vendorComplianceSurveyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.GetVendorComplianceSurveyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to be returned. | 

### Return type

[**VendorComplianceSurvey**](VendorComplianceSurvey.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorcompliancesurveytags"></a>
# **GetVendorComplianceSurveyTags**
> void GetVendorComplianceSurveyTags (int? vendorComplianceSurveyId)

Get the tags for a vendorComplianceSurvey.

Get all existing vendorComplianceSurvey tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorComplianceSurveyTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var vendorComplianceSurveyId = 56;  // int? | Id of the vendorComplianceSurvey to get tags for

            try
            {
                // Get the tags for a vendorComplianceSurvey.
                apiInstance.GetVendorComplianceSurveyTags(vendorComplianceSurveyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.GetVendorComplianceSurveyTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorComplianceSurveyId** | **int?**| Id of the vendorComplianceSurvey to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendorcompliancesurvey"></a>
# **UpdateVendorComplianceSurvey**
> void UpdateVendorComplianceSurvey (VendorComplianceSurvey body)

Update a vendorComplianceSurvey

Updates an existing vendorComplianceSurvey using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateVendorComplianceSurveyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var body = new VendorComplianceSurvey(); // VendorComplianceSurvey | VendorComplianceSurvey to be updated.

            try
            {
                // Update a vendorComplianceSurvey
                apiInstance.UpdateVendorComplianceSurvey(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.UpdateVendorComplianceSurvey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VendorComplianceSurvey**](VendorComplianceSurvey.md)| VendorComplianceSurvey to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendorcompliancesurveycustomfields"></a>
# **UpdateVendorComplianceSurveyCustomFields**
> void UpdateVendorComplianceSurveyCustomFields (VendorComplianceSurvey body)

Update a vendorComplianceSurvey custom fields

Updates an existing vendorComplianceSurvey custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateVendorComplianceSurveyCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorComplianceSurveyApi();
            var body = new VendorComplianceSurvey(); // VendorComplianceSurvey | VendorComplianceSurvey to be updated.

            try
            {
                // Update a vendorComplianceSurvey custom fields
                apiInstance.UpdateVendorComplianceSurveyCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorComplianceSurveyApi.UpdateVendorComplianceSurveyCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VendorComplianceSurvey**](VendorComplianceSurvey.md)| VendorComplianceSurvey to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

