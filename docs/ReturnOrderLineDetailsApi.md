# Infoplus.Api.ReturnOrderLineDetailsApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReturnOrderLineDetailsAudit**](ReturnOrderLineDetailsApi.md#addreturnorderlinedetailsaudit) | **PUT** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/audit/{returnOrderLineDetailsAudit} | Add new audit for a returnOrderLineDetails
[**AddReturnOrderLineDetailsFile**](ReturnOrderLineDetailsApi.md#addreturnorderlinedetailsfile) | **POST** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/file/{fileName} | Attach a file to a returnOrderLineDetails
[**AddReturnOrderLineDetailsFileByURL**](ReturnOrderLineDetailsApi.md#addreturnorderlinedetailsfilebyurl) | **POST** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/file | Attach a file to a returnOrderLineDetails by URL.
[**AddReturnOrderLineDetailsTag**](ReturnOrderLineDetailsApi.md#addreturnorderlinedetailstag) | **PUT** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/tag/{returnOrderLineDetailsTag} | Add new tags for a returnOrderLineDetails.
[**DeleteReturnOrderLineDetailsFile**](ReturnOrderLineDetailsApi.md#deletereturnorderlinedetailsfile) | **DELETE** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/file/{fileId} | Delete a file for a returnOrderLineDetails.
[**DeleteReturnOrderLineDetailsTag**](ReturnOrderLineDetailsApi.md#deletereturnorderlinedetailstag) | **DELETE** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/tag/{returnOrderLineDetailsTag} | Delete a tag for a returnOrderLineDetails.
[**GetDuplicateReturnOrderLineDetailsById**](ReturnOrderLineDetailsApi.md#getduplicatereturnorderlinedetailsbyid) | **GET** /beta/returnOrderLineDetails/duplicate/{returnOrderLineDetailsId} | Get a duplicated a returnOrderLineDetails by id
[**GetReturnOrderLineDetailsByFilter**](ReturnOrderLineDetailsApi.md#getreturnorderlinedetailsbyfilter) | **GET** /beta/returnOrderLineDetails/search | Search returnOrderLineDetailses by filter
[**GetReturnOrderLineDetailsById**](ReturnOrderLineDetailsApi.md#getreturnorderlinedetailsbyid) | **GET** /beta/returnOrderLineDetails/{returnOrderLineDetailsId} | Get a returnOrderLineDetails by id
[**GetReturnOrderLineDetailsFiles**](ReturnOrderLineDetailsApi.md#getreturnorderlinedetailsfiles) | **GET** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/file | Get the files for a returnOrderLineDetails.
[**GetReturnOrderLineDetailsTags**](ReturnOrderLineDetailsApi.md#getreturnorderlinedetailstags) | **GET** /beta/returnOrderLineDetails/{returnOrderLineDetailsId}/tag | Get the tags for a returnOrderLineDetails.
[**UpdateReturnOrderLineDetailsCustomFields**](ReturnOrderLineDetailsApi.md#updatereturnorderlinedetailscustomfields) | **PUT** /beta/returnOrderLineDetails/customFields | Update a returnOrderLineDetails custom fields


<a name="addreturnorderlinedetailsaudit"></a>
# **AddReturnOrderLineDetailsAudit**
> void AddReturnOrderLineDetailsAudit (int? returnOrderLineDetailsId, string returnOrderLineDetailsAudit)

Add new audit for a returnOrderLineDetails

Adds an audit to an existing returnOrderLineDetails.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineDetailsAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to add an audit to
            var returnOrderLineDetailsAudit = returnOrderLineDetailsAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a returnOrderLineDetails
                apiInstance.AddReturnOrderLineDetailsAudit(returnOrderLineDetailsId, returnOrderLineDetailsAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.AddReturnOrderLineDetailsAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to add an audit to | 
 **returnOrderLineDetailsAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderlinedetailsfile"></a>
# **AddReturnOrderLineDetailsFile**
> void AddReturnOrderLineDetailsFile (int? returnOrderLineDetailsId, string fileName)

Attach a file to a returnOrderLineDetails

Adds a file to an existing returnOrderLineDetails.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineDetailsFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a returnOrderLineDetails
                apiInstance.AddReturnOrderLineDetailsFile(returnOrderLineDetailsId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.AddReturnOrderLineDetailsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderlinedetailsfilebyurl"></a>
# **AddReturnOrderLineDetailsFileByURL**
> void AddReturnOrderLineDetailsFileByURL (RecordFile body, int? returnOrderLineDetailsId)

Attach a file to a returnOrderLineDetails by URL.

Adds a file to an existing returnOrderLineDetails by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineDetailsFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to add an file to

            try
            {
                // Attach a file to a returnOrderLineDetails by URL.
                apiInstance.AddReturnOrderLineDetailsFileByURL(body, returnOrderLineDetailsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.AddReturnOrderLineDetailsFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnorderlinedetailstag"></a>
# **AddReturnOrderLineDetailsTag**
> void AddReturnOrderLineDetailsTag (int? returnOrderLineDetailsId, string returnOrderLineDetailsTag)

Add new tags for a returnOrderLineDetails.

Adds a tag to an existing returnOrderLineDetails.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnOrderLineDetailsTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to add a tag to
            var returnOrderLineDetailsTag = returnOrderLineDetailsTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a returnOrderLineDetails.
                apiInstance.AddReturnOrderLineDetailsTag(returnOrderLineDetailsId, returnOrderLineDetailsTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.AddReturnOrderLineDetailsTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to add a tag to | 
 **returnOrderLineDetailsTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnorderlinedetailsfile"></a>
# **DeleteReturnOrderLineDetailsFile**
> void DeleteReturnOrderLineDetailsFile (int? returnOrderLineDetailsId, int? fileId)

Delete a file for a returnOrderLineDetails.

Deletes an existing returnOrderLineDetails file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnOrderLineDetailsFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a returnOrderLineDetails.
                apiInstance.DeleteReturnOrderLineDetailsFile(returnOrderLineDetailsId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.DeleteReturnOrderLineDetailsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnorderlinedetailstag"></a>
# **DeleteReturnOrderLineDetailsTag**
> void DeleteReturnOrderLineDetailsTag (int? returnOrderLineDetailsId, string returnOrderLineDetailsTag)

Delete a tag for a returnOrderLineDetails.

Deletes an existing returnOrderLineDetails tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnOrderLineDetailsTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to remove tag from
            var returnOrderLineDetailsTag = returnOrderLineDetailsTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a returnOrderLineDetails.
                apiInstance.DeleteReturnOrderLineDetailsTag(returnOrderLineDetailsId, returnOrderLineDetailsTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.DeleteReturnOrderLineDetailsTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to remove tag from | 
 **returnOrderLineDetailsTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereturnorderlinedetailsbyid"></a>
# **GetDuplicateReturnOrderLineDetailsById**
> ReturnOrderLineDetails GetDuplicateReturnOrderLineDetailsById (int? returnOrderLineDetailsId)

Get a duplicated a returnOrderLineDetails by id

Returns a duplicated returnOrderLineDetails identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReturnOrderLineDetailsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to be duplicated.

            try
            {
                // Get a duplicated a returnOrderLineDetails by id
                ReturnOrderLineDetails result = apiInstance.GetDuplicateReturnOrderLineDetailsById(returnOrderLineDetailsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.GetDuplicateReturnOrderLineDetailsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to be duplicated. | 

### Return type

[**ReturnOrderLineDetails**](ReturnOrderLineDetails.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinedetailsbyfilter"></a>
# **GetReturnOrderLineDetailsByFilter**
> List<ReturnOrderLineDetails> GetReturnOrderLineDetailsByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search returnOrderLineDetailses by filter

Returns the list of returnOrderLineDetailses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineDetailsByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search returnOrderLineDetailses by filter
                List&lt;ReturnOrderLineDetails&gt; result = apiInstance.GetReturnOrderLineDetailsByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.GetReturnOrderLineDetailsByFilter: " + e.Message );
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

[**List<ReturnOrderLineDetails>**](ReturnOrderLineDetails.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinedetailsbyid"></a>
# **GetReturnOrderLineDetailsById**
> ReturnOrderLineDetails GetReturnOrderLineDetailsById (int? returnOrderLineDetailsId)

Get a returnOrderLineDetails by id

Returns the returnOrderLineDetails identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineDetailsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to be returned.

            try
            {
                // Get a returnOrderLineDetails by id
                ReturnOrderLineDetails result = apiInstance.GetReturnOrderLineDetailsById(returnOrderLineDetailsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.GetReturnOrderLineDetailsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to be returned. | 

### Return type

[**ReturnOrderLineDetails**](ReturnOrderLineDetails.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinedetailsfiles"></a>
# **GetReturnOrderLineDetailsFiles**
> void GetReturnOrderLineDetailsFiles (int? returnOrderLineDetailsId)

Get the files for a returnOrderLineDetails.

Get all existing returnOrderLineDetails files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineDetailsFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to get files for

            try
            {
                // Get the files for a returnOrderLineDetails.
                apiInstance.GetReturnOrderLineDetailsFiles(returnOrderLineDetailsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.GetReturnOrderLineDetailsFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnorderlinedetailstags"></a>
# **GetReturnOrderLineDetailsTags**
> void GetReturnOrderLineDetailsTags (int? returnOrderLineDetailsId)

Get the tags for a returnOrderLineDetails.

Get all existing returnOrderLineDetails tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnOrderLineDetailsTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var returnOrderLineDetailsId = 56;  // int? | Id of the returnOrderLineDetails to get tags for

            try
            {
                // Get the tags for a returnOrderLineDetails.
                apiInstance.GetReturnOrderLineDetailsTags(returnOrderLineDetailsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.GetReturnOrderLineDetailsTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnOrderLineDetailsId** | **int?**| Id of the returnOrderLineDetails to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereturnorderlinedetailscustomfields"></a>
# **UpdateReturnOrderLineDetailsCustomFields**
> void UpdateReturnOrderLineDetailsCustomFields (ReturnOrderLineDetails body)

Update a returnOrderLineDetails custom fields

Updates an existing returnOrderLineDetails custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReturnOrderLineDetailsCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnOrderLineDetailsApi();
            var body = new ReturnOrderLineDetails(); // ReturnOrderLineDetails | ReturnOrderLineDetails to be updated.

            try
            {
                // Update a returnOrderLineDetails custom fields
                apiInstance.UpdateReturnOrderLineDetailsCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderLineDetailsApi.UpdateReturnOrderLineDetailsCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnOrderLineDetails**](ReturnOrderLineDetails.md)| ReturnOrderLineDetails to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

