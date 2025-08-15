# Infoplus.Api.ReturnShipmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReturnShipmentAudit**](ReturnShipmentApi.md#addreturnshipmentaudit) | **PUT** /beta/returnShipment/{returnShipmentId}/audit/{returnShipmentAudit} | Add new audit for a returnShipment
[**AddReturnShipmentFile**](ReturnShipmentApi.md#addreturnshipmentfile) | **POST** /beta/returnShipment/{returnShipmentId}/file/{fileName} | Attach a file to a returnShipment
[**AddReturnShipmentFileByURL**](ReturnShipmentApi.md#addreturnshipmentfilebyurl) | **POST** /beta/returnShipment/{returnShipmentId}/file | Attach a file to a returnShipment by URL.
[**AddReturnShipmentTag**](ReturnShipmentApi.md#addreturnshipmenttag) | **PUT** /beta/returnShipment/{returnShipmentId}/tag/{returnShipmentTag} | Add new tags for a returnShipment.
[**DeleteReturnShipmentFile**](ReturnShipmentApi.md#deletereturnshipmentfile) | **DELETE** /beta/returnShipment/{returnShipmentId}/file/{fileId} | Delete a file for a returnShipment.
[**DeleteReturnShipmentTag**](ReturnShipmentApi.md#deletereturnshipmenttag) | **DELETE** /beta/returnShipment/{returnShipmentId}/tag/{returnShipmentTag} | Delete a tag for a returnShipment.
[**GetDuplicateReturnShipmentById**](ReturnShipmentApi.md#getduplicatereturnshipmentbyid) | **GET** /beta/returnShipment/duplicate/{returnShipmentId} | Get a duplicated a returnShipment by id
[**GetReturnShipmentByFilter**](ReturnShipmentApi.md#getreturnshipmentbyfilter) | **GET** /beta/returnShipment/search | Search returnShipments by filter
[**GetReturnShipmentById**](ReturnShipmentApi.md#getreturnshipmentbyid) | **GET** /beta/returnShipment/{returnShipmentId} | Get a returnShipment by id
[**GetReturnShipmentFiles**](ReturnShipmentApi.md#getreturnshipmentfiles) | **GET** /beta/returnShipment/{returnShipmentId}/file | Get the files for a returnShipment.
[**GetReturnShipmentTags**](ReturnShipmentApi.md#getreturnshipmenttags) | **GET** /beta/returnShipment/{returnShipmentId}/tag | Get the tags for a returnShipment.
[**UpdateReturnShipmentCustomFields**](ReturnShipmentApi.md#updatereturnshipmentcustomfields) | **PUT** /beta/returnShipment/customFields | Update a returnShipment custom fields


<a name="addreturnshipmentaudit"></a>
# **AddReturnShipmentAudit**
> void AddReturnShipmentAudit (int? returnShipmentId, string returnShipmentAudit)

Add new audit for a returnShipment

Adds an audit to an existing returnShipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnShipmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to add an audit to
            var returnShipmentAudit = returnShipmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a returnShipment
                apiInstance.AddReturnShipmentAudit(returnShipmentId, returnShipmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.AddReturnShipmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to add an audit to | 
 **returnShipmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnshipmentfile"></a>
# **AddReturnShipmentFile**
> void AddReturnShipmentFile (int? returnShipmentId, string fileName)

Attach a file to a returnShipment

Adds a file to an existing returnShipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnShipmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a returnShipment
                apiInstance.AddReturnShipmentFile(returnShipmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.AddReturnShipmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnshipmentfilebyurl"></a>
# **AddReturnShipmentFileByURL**
> void AddReturnShipmentFileByURL (RecordFile body, int? returnShipmentId)

Attach a file to a returnShipment by URL.

Adds a file to an existing returnShipment by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnShipmentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var returnShipmentId = 56;  // int? | Id of the returnShipment to add an file to

            try
            {
                // Attach a file to a returnShipment by URL.
                apiInstance.AddReturnShipmentFileByURL(body, returnShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.AddReturnShipmentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **returnShipmentId** | **int?**| Id of the returnShipment to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreturnshipmenttag"></a>
# **AddReturnShipmentTag**
> void AddReturnShipmentTag (int? returnShipmentId, string returnShipmentTag)

Add new tags for a returnShipment.

Adds a tag to an existing returnShipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddReturnShipmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to add a tag to
            var returnShipmentTag = returnShipmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a returnShipment.
                apiInstance.AddReturnShipmentTag(returnShipmentId, returnShipmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.AddReturnShipmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to add a tag to | 
 **returnShipmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnshipmentfile"></a>
# **DeleteReturnShipmentFile**
> void DeleteReturnShipmentFile (int? returnShipmentId, int? fileId)

Delete a file for a returnShipment.

Deletes an existing returnShipment file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnShipmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a returnShipment.
                apiInstance.DeleteReturnShipmentFile(returnShipmentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.DeleteReturnShipmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereturnshipmenttag"></a>
# **DeleteReturnShipmentTag**
> void DeleteReturnShipmentTag (int? returnShipmentId, string returnShipmentTag)

Delete a tag for a returnShipment.

Deletes an existing returnShipment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteReturnShipmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to remove tag from
            var returnShipmentTag = returnShipmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a returnShipment.
                apiInstance.DeleteReturnShipmentTag(returnShipmentId, returnShipmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.DeleteReturnShipmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to remove tag from | 
 **returnShipmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatereturnshipmentbyid"></a>
# **GetDuplicateReturnShipmentById**
> ReturnShipment GetDuplicateReturnShipmentById (int? returnShipmentId)

Get a duplicated a returnShipment by id

Returns a duplicated returnShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateReturnShipmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to be duplicated.

            try
            {
                // Get a duplicated a returnShipment by id
                ReturnShipment result = apiInstance.GetDuplicateReturnShipmentById(returnShipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.GetDuplicateReturnShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to be duplicated. | 

### Return type

[**ReturnShipment**](ReturnShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnshipmentbyfilter"></a>
# **GetReturnShipmentByFilter**
> List<ReturnShipment> GetReturnShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search returnShipments by filter

Returns the list of returnShipments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnShipmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search returnShipments by filter
                List&lt;ReturnShipment&gt; result = apiInstance.GetReturnShipmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.GetReturnShipmentByFilter: " + e.Message );
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

[**List<ReturnShipment>**](ReturnShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnshipmentbyid"></a>
# **GetReturnShipmentById**
> ReturnShipment GetReturnShipmentById (int? returnShipmentId)

Get a returnShipment by id

Returns the returnShipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnShipmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to be returned.

            try
            {
                // Get a returnShipment by id
                ReturnShipment result = apiInstance.GetReturnShipmentById(returnShipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.GetReturnShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to be returned. | 

### Return type

[**ReturnShipment**](ReturnShipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnshipmentfiles"></a>
# **GetReturnShipmentFiles**
> void GetReturnShipmentFiles (int? returnShipmentId)

Get the files for a returnShipment.

Get all existing returnShipment files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnShipmentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to get files for

            try
            {
                // Get the files for a returnShipment.
                apiInstance.GetReturnShipmentFiles(returnShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.GetReturnShipmentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreturnshipmenttags"></a>
# **GetReturnShipmentTags**
> void GetReturnShipmentTags (int? returnShipmentId)

Get the tags for a returnShipment.

Get all existing returnShipment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetReturnShipmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var returnShipmentId = 56;  // int? | Id of the returnShipment to get tags for

            try
            {
                // Get the tags for a returnShipment.
                apiInstance.GetReturnShipmentTags(returnShipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.GetReturnShipmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnShipmentId** | **int?**| Id of the returnShipment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereturnshipmentcustomfields"></a>
# **UpdateReturnShipmentCustomFields**
> void UpdateReturnShipmentCustomFields (ReturnShipment body)

Update a returnShipment custom fields

Updates an existing returnShipment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateReturnShipmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReturnShipmentApi();
            var body = new ReturnShipment(); // ReturnShipment | ReturnShipment to be updated.

            try
            {
                // Update a returnShipment custom fields
                apiInstance.UpdateReturnShipmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShipmentApi.UpdateReturnShipmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnShipment**](ReturnShipment.md)| ReturnShipment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

